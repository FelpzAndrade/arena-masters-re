"""Corrige os scripts C# exportados pelo AssetRipper (stubs do Il2CppDumper) para compilarem no Unity 6.

Uso:
  python fix_scripts.py static <Assets>            correcoes fixas (rodar uma vez)
  python fix_scripts.py errors <Assets> <log>      correcoes guiadas pelos erros do log do Unity
"""
import os, re, sys, collections

def cs_files(assets):
    for root, _, files in os.walk(assets):
        for f in files:
            if f.endswith(".cs"):
                yield os.path.join(root, f)

def read(p):
    with open(p, encoding="utf-8-sig") as f:
        return f.read()

def write(p, s):
    with open(p, "w", encoding="utf-8") as f:
        f.write(s)

TYPE_MAP = [
    (r"(?<![\w.])GUIText(?!\w)", "UnityEngine.Component"),
    (r"(?<![\w.])GUITexture(?!\w)", "UnityEngine.Component"),
    (r"(?<![\w.])ParticleEmitter(?!\w)", "UnityEngine.Component"),
    (r"(?<![\w.])ParticleAnimator(?!\w)", "UnityEngine.Component"),
    (r"(?<![\w.])ParticleRenderer(?!\w)", "UnityEngine.Component"),
    (r"(?<![\w.])Particle(?!\w)", "UnityEngine.ParticleSystem.Particle"),
    (r"(?<![\w.])NavMeshAgent(?!\w)", "UnityEngine.AI.NavMeshAgent"),
]
DUMMY_ATTR = re.compile(r"^\s*\[(?:Il2CppDummyDll\.)?Attribute(?:Attribute)?\(Name = .*\)\]\s*\n", re.M)
FIELD_OFFSET = re.compile(r'\[(?:Il2CppDummyDll\.)?FieldOffset\(Offset = "0x([0-9A-Fa-f]+)"\)\]')
EXPLICIT = ("LayoutKind.Explicit", "(LayoutKind)2")

def fix_explicit_layout(src):
    """Converte o FieldOffset do Il2CppDummyDll no FieldOffset real dentro de structs de layout explicito."""
    if not any(e in src for e in EXPLICIT):
        return src
    lines = src.split("\n")
    i = 0
    while i < len(lines):
        if any(e in lines[i] for e in EXPLICIT):
            # acha a abertura do corpo e o fim por contagem de chaves
            j = i
            while "{" not in lines[j]:
                j += 1
            depth, k, members = 0, j, []
            while True:
                depth += lines[k].count("{") - lines[k].count("}")
                if depth == 1 and FIELD_OFFSET.search(lines[k]):
                    members.append(k)
                if depth == 0 and k > j:
                    break
                k += 1
            if members:
                base = min(int(FIELD_OFFSET.search(lines[m]).group(1), 16) for m in members)
                for m in members:
                    off = int(FIELD_OFFSET.search(lines[m]).group(1), 16) - base
                    lines[m] = FIELD_OFFSET.sub(f"[System.Runtime.InteropServices.FieldOffset({off})]", lines[m])
            i = k
        i += 1
    return "\n".join(lines)

def static(assets):
    removed = 0
    for root, _, files in os.walk(assets):
        if os.path.basename(root) == "Properties" and "AssemblyInfo.cs" in files:
            for f in ("AssemblyInfo.cs", "AssemblyInfo.cs.meta"):
                p = os.path.join(root, f)
                if os.path.exists(p):
                    os.remove(p)
            removed += 1
    print("AssemblyInfo removidos:", removed)
    changed = collections.Counter()
    for p in cs_files(assets):
        s = read(p)
        orig = s
        s, n = DUMMY_ATTR.subn("", s)
        changed["[Attribute] removidos"] += n
        for pat, rep in TYPE_MAP:
            s, n = re.subn(pat, rep, s)
            changed[rep] += n
        s2 = fix_explicit_layout(s)
        if s2 != s:
            changed["structs explicitos"] += 1
            s = s2
        if s != orig:
            write(p, s)
    for k, v in changed.items():
        print(f"  {k}: {v}")

ERR = re.compile(r"^(?P<file>Assets[^\(]+\.cs)\((?P<line>\d+),(?P<col>\d+)\): error (?P<code>CS\d+): (?P<msg>.*)$")

def remove_base_type(line, col):
    """Remove da lista de bases o tipo que comeca na coluna col (1-based)."""
    start = col - 1
    depth, end = 0, start
    while end < len(line):
        c = line[end]
        if c == "<":
            depth += 1
        elif c == ">":
            depth -= 1
        elif depth == 0 and c in ",{" or (depth == 0 and line[end:end + 6] == " where"):
            break
        end += 1
    before, after = line[:start].rstrip(), line[end:]
    if after.startswith(","):
        after = after[1:].lstrip()
        return before + " " + after if not before.endswith(":") else before + " " + after
    if before.endswith(","):
        return before[:-1] + (" " + after.lstrip() if after.strip() else after)
    if before.endswith(":"):
        return before[:-1].rstrip() + (" " + after.lstrip() if after.strip() else after)
    return before + after

def body_start(lines, i):
    """Indice da linha com a '{' que abre o corpo do membro declarado a partir da linha i."""
    while "{" not in lines[i]:
        i += 1
    return i

def insert_after_brace(lines, i, stmt):
    j = body_start(lines, i)
    indent = re.match(r"\s*", lines[j]).group(0) + "\t"
    if lines[j + 1].strip() != stmt.strip():
        lines.insert(j + 1, indent + stmt)
        return True
    return False

def add_default_ctors(assets, type_names, stats):
    """Adiciona um construtor protected vazio as classes base que nao tem construtor sem parametros."""
    for p in cs_files(assets):
        s = read(p)
        changed = False
        for name in list(type_names):
            m = re.search(r"\b(?:class)\s+" + re.escape(name) + r"\b[^{]*\{", s)
            if not m or re.search(r"\b" + re.escape(name) + r"\s*\(\s*\)\s*(?::[^{]*)?\{", s):
                continue
            s = s[:m.end()] + f"\n\t\tprotected {name}()\n\t\t{{\n\t\t}}\n" + s[m.end():]
            type_names.discard(name)
            stats["construtor vazio adicionado"] += 1
            changed = True
        if changed:
            write(p, s)

def errors(assets, log):
    project = os.path.dirname(assets)
    found = collections.defaultdict(set)
    with open(log, encoding="utf-8", errors="replace") as f:
        for raw in f:
            m = ERR.match(raw.strip())
            if m:
                found[m["file"]].add((int(m["line"]), int(m["col"]), m["code"], m["msg"]))
    stats = collections.Counter()
    need_ctor = set()
    for errs in found.values():
        for _, _, code, msg in errs:
            m = None
            if code == "CS1729":
                m = re.search(r"'([\w.]+)(?:<[^']*>)?' does not contain a constructor that takes 0", msg)
            elif code == "CS7036":
                m = re.search(r"of '(?:[\w.]+\.)?(\w+)\.\1\(", msg)
            if m:
                need_ctor.add(m.group(1).split(".")[-1])
    for rel, errs in found.items():
        p = os.path.join(project, rel.replace("\\", os.sep))
        lines = read(p).split("\n")
        inserts = sorted({(ln, code, msg) for ln, _, code, msg in errs if code in ("CS0171", "CS0177")}, reverse=True)
        errs = {e for e in errs if e[2] not in ("CS0171", "CS0177", "CS1729", "CS7036")}
        # 1) correcoes na propria linha; colunas da direita para a esquerda para nao deslocar as anteriores
        done = set()
        for ln, col, code, msg in sorted(errs, key=lambda e: (e[0], -e[1])):
            i = ln - 1
            if code == "CS0037":
                lines[i] = re.sub(r"\bnull\b", "default", lines[i], count=1)
                stats["null -> default"] += 1
            elif code == "CS1908":
                # a coluna aponta o nome do atributo, logo depois do '['
                head, tail = lines[i][:col - 2], lines[i][col - 2:]
                lines[i] = head + re.sub(r"\[DefaultParameterValue\([^\]]*\)\]", "", tail, count=1)
                stats["DefaultParameterValue removido"] += 1
            elif code == "CS0579" and (ln, "dup") not in done:
                done.add((ln, "dup"))
                lines[i] = ""
                stats["atributo duplicado"] += 1
            elif code == "CS0104":
                names = re.findall(r"'([\w.]+)'", msg)
                short, options = names[0], names[1:]
                pick = next((o for o in options if not o.startswith("System.")), options[0])
                head, tail = lines[i][:col - 1], lines[i][col - 1:]
                if tail.startswith(short):
                    lines[i] = head + pick + tail[len(short):]
                    stats["referencia ambigua"] += 1
            elif code in ("CS0535", "CS0738", "CS0470") and "interface" in msg:
                decl = re.search(r"\b(class|struct|interface)\b[^:]*:", lines[i])
                if (ln, col) in done or not decl or col - 1 < decl.end():
                    stats[f"ignorado {code} fora da declaracao"] += 1
                    continue
                done.add((ln, col))
                new = remove_base_type(lines[i], col)
                if new != lines[i]:
                    lines[i] = new
                    stats["interface removida"] += 1
            elif code == "CS0621":
                lines[i] = re.sub(r"\b(virtual|abstract|override) ", "", lines[i], count=1)
                stats["private virtual"] += 1
            elif code == "CS0592" and "SerializeField" in msg:
                lines[i] = lines[i].replace("[SerializeField]", "")
                stats["SerializeField"] += 1
            else:
                stats[f"nao tratado {code}"] += 1
        # 2) CS0171/CS0177 inserem linhas: de baixo para cima
        done_ctor = set()
        for ln, code, msg in inserts:
            i = ln - 1
            if code == "CS0171" and ln not in done_ctor:
                done_ctor.add(ln)
                if insert_after_brace(lines, i, "this = default;"):
                    stats["struct ctor this = default"] += 1
            elif code == "CS0177":
                name = re.search(r"out parameter '(\w+)'", msg).group(1)
                # o erro aponta o fim do metodo: volta ate a assinatura que declara o parametro
                k = i
                while k > 0 and not re.search(r"\bout\s+[\w.<>\[\], ]*?\b" + name + r"\b", lines[k]):
                    k -= 1
                if insert_after_brace(lines, k, f"{name} = default;"):
                    stats["out = default"] += 1
        write(p, "\n".join(lines))
    # 3) construtores vazios nas classes base (depois, porque desloca linhas)
    if need_ctor:
        add_default_ctors(assets, need_ctor, stats)
        for n in need_ctor:
            stats[f"base nao encontrada: {n}"] += 1
    for k, v in stats.most_common():
        print(f"  {k}: {v}")

if __name__ == "__main__":
    mode = sys.argv[1]
    if mode == "static":
        static(sys.argv[2])
    else:
        errors(sys.argv[2], sys.argv[3])
