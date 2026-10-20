"""Gera uma spec .recon para metodos triviais a partir da exportacao em massa do Ghidra.

Uso: python auto_trivial.py <decomp.c> <rvas.txt> <Assets/Scripts stubs> <Assets/Scripts original c/ FieldOffset> <saida.recon>

So traduz padroes de uma unica instrucao, com alta confianca:
  getter     return *(T *)(param_1 + 0xNN);         -> return campo;
  setter     *(T *)(param_1 + 0xNN) = param_2;      -> campo = value;
  constante  return N;                              -> return N/true/false; (tipos int/bool/enum)
"""
import os, re, sys, collections

decomp_path, rvas_path, stubs_root, orig_root, out_path = sys.argv[1:6]

# --- funcoes exportadas, por RVA
funcs = {}
for block in open(decomp_path, encoding="utf-8").read().split("// ==== ")[1:]:
    rva = block.split()[0].upper().replace("0X", "0x")
    funcs[rva] = block

# --- metodos alvo: RVA -> (arquivo, assinatura)
targets = {}
for line in open(rvas_path, encoding="utf-8"):
    m = re.match(r"(0x[0-9A-F]+) (\S+) :: (.*)$", line.strip())
    if m:
        targets.setdefault(m.group(1), (m.group(2), m.group(3)))

# --- mapa de arquivos por nome de classe
files = {}
for root, _, fs in os.walk(stubs_root):
    for f in fs:
        if f.endswith(".cs"):
            files.setdefault(f[:-3], os.path.join(root, f))

FIELD = re.compile(r'\[FieldOffset\(Offset = "0x([0-9A-F]+)"\)\]\s*\n(?:\s*\[[^\n]*\]\s*\n)*\s*((?:public|private|protected|internal)[^\n;=]*?)\s+(\w+)\s*(?:=[^\n;]*)?;')

def field_map(cls):
    """Campos de instancia por offset (a partir do export original, que preserva [FieldOffset])."""
    rel = os.path.relpath(files[cls], stubs_root)
    p = os.path.join(orig_root, rel)
    if not os.path.exists(p):
        return {}
    src = open(p, encoding="utf-8-sig").read()
    if src.count(" class ") + src.count(" struct ") > 1:
        return {}  # tipos aninhados: offsets ambiguos
    out = {}
    for m in FIELD.finditer(src):
        decl = m.group(2)
        if " static " in f" {decl} " or " const " in f" {decl} ":
            continue
        out[int(m.group(1), 16)] = (decl.split()[-1], m.group(3))
    return out

def accessor_kind(cls, rva):
    """Para 'get'/'set' do rvas.txt, descobre o tipo da propriedade no stub."""
    src = open(files[cls], encoding="utf-8-sig").read()
    m = re.search(r'\[Address\(RVA = "' + rva + r'"', src)
    head = src[:m.start()]
    prop = re.findall(r"\n\s*(?:public|private|protected|internal)[^\n(]*?\s(\S+)\s+(\w+)\s*\n\s*\{", head)
    return prop[-1] if prop else (None, None)

SMALL = {"int", "uint", "float", "bool", "byte", "sbyte", "short", "ushort", "string", "char"}
INTS = {"int", "uint", "short", "ushort", "byte", "sbyte"}

def parse_params(sig):
    """[(tipo, nome)] dos parametros da assinatura (sem genericos complexos)."""
    m = re.search(r"\((.*)\)", sig)
    if not m or not m.group(1).strip():
        return []
    out = []
    for p in m.group(1).split(","):
        p = re.sub(r"\s*=.*$", "", p.strip())
        parts = p.split()
        if len(parts) < 2 or parts[0] in ("ref", "out", "params", "this"):
            return [("?", "?")] * len(m.group(1).split(","))
        out.append((parts[-2], parts[-1]))
    return out

def is_ctor(sig, cls):
    return re.search(r"\b" + re.escape(cls) + r"\s*\(", sig) is not None

def enum_names():
    """Tipos enum conhecidos nos stubs (nome simples)."""
    names = set()
    for p in files.values():
        for m in re.finditer(r"\benum (\w+)", open(p, encoding="utf-8-sig").read()):
            names.add(m.group(1))
    return names

def const_for(ftype, v):
    """Literal C# para a constante v no tipo ftype, ou None se nao for seguro."""
    if ftype == "bool" and v in (0, 1):
        return "true" if v else "false"
    if ftype in INTS and abs(v) < 2**31:
        return str(v)
    if ftype == "float":
        import struct
        f = struct.unpack("<f", struct.pack("<I", v & 0xffffffff))[0]
        return f"{f!r}f" if f == f and abs(f) < 1e9 else None
    if ftype in ENUMS and 0 <= v < 2**31:
        return f"({ftype}){v}"
    return None
BODY = re.compile(r"\{\s*\n(.*?)\n\}", re.S)

ENUMS = enum_names()
spec = collections.defaultdict(list)
stats = collections.Counter()
fmaps = {}
for rva, (cls, sig) in targets.items():
    if rva not in funcs or cls not in files:
        continue
    m = BODY.search(funcs[rva])
    if not m:
        continue
    lines = [l.strip() for l in m.group(1).split("\n") if l.strip()]
    if cls not in fmaps:
        fmaps[cls] = field_map(cls)
    fmap = fmaps[cls]
    body = None
    if sig in ("get", "set"):
        ptype, _ = accessor_kind(cls, rva)
        if ptype is None:
            continue
        if sig == "get" and len(lines) == 1:
            g = re.fullmatch(r"return \*\((?:undefined\d?|int|uint|float|bool|char) \*\)\(param_1 \+ (0x[0-9a-f]+|\d+)\);", lines[0])
            if g:
                off = int(g.group(1), 0)
                if off in fmap and (fmap[off][0] == ptype) and (ptype in SMALL or ptype[0].isupper()):
                    body = f"return {fmap[off][1]};"
                    stats["getter"] += 1
        elif sig == "set" and len(lines) == 2 and lines[1] == "return;":
            s = re.fullmatch(r"\*\((?:undefined\d?|int|uint|float|bool|char) \*\)\(param_1 \+ (0x[0-9a-f]+|\d+)\) = param_2;", lines[0])
            if s:
                off = int(s.group(1), 0)
                if off in fmap and fmap[off][0] == ptype:
                    body = f"{fmap[off][1]} = value;"
                    stats["setter"] += 1
    else:
        r = re.match(r"(?:public|private|protected|internal|\s|static|override|virtual|sealed|new)*(\S+)\s+\w+\s*\(", sig)
        rtype = r.group(1) if r else None
        if " static " in f" {sig} ":
            continue
        params = parse_params(sig)
        # void: sequencia de "campo = param_N/constante" (opcionalmente com chamada ao ctor base sem efeito)
        if lines and lines[-1] == "return;" and (rtype == "void" or rtype is None or is_ctor(sig, cls)):
            stmts = []
            ok = len(lines) > 1
            for l in lines[:-1]:
                if re.fullmatch(r"System_Object___ctor\(param_1,0\);", l):
                    continue
                a = re.fullmatch(r"\*\((?:undefined\d?|int|uint|float|bool|char) \*\)\(param_1 \+ (0x[0-9a-f]+|\d+)\) = (param_\d+|-?(?:0x[0-9a-f]+|\d+));", l)
                if not a or int(a.group(1), 0) not in fmap:
                    ok = False
                    break
                ftype, fname = fmap[int(a.group(1), 0)]
                val = a.group(2)
                if val.startswith("param_"):
                    idx = int(val[6:]) - 2
                    if idx < 0 or idx >= len(params) or params[idx][0] != ftype:
                        ok = False
                        break
                    expr = params[idx][1]
                else:
                    expr = const_for(ftype, int(val, 0))
                    if expr is None:
                        ok = False
                        break
                stmts.append(f"{'this.' if expr == fname else ''}{fname} = {expr};")
            if ok and stmts:
                body = "\n\t".join(stmts)
                stats["atribuicoes"] += 1
        # bool: compara o primeiro argumento com constante
        if body is None and rtype == "bool" and len(lines) == 1 and len(params) == 1:
            c = re.fullmatch(r"return param_2 (==|!=) (-?(?:0x[0-9a-f]+|\d+));", lines[0])
            if c:
                expr = const_for(params[0][0], int(c.group(2), 0))
                if expr is not None:
                    body = f"return {params[0][1]} {c.group(1)} {expr};"
                    stats["comparacao"] += 1
        if body is None and len(lines) == 1 and rtype:
            c = re.fullmatch(r"return (-?(?:0x[0-9a-f]+|\d+));", lines[0])
            if c:
                v = int(c.group(1), 0)
                if rtype == "bool" and v in (0, 1):
                    body = "return " + ("true" if v else "false") + ";"
                elif rtype in ("int", "uint", "short", "byte") and abs(v) < 2**31:
                    body = f"return {v};"
                if body:
                    stats["constante"] += 1
    if body:
        rel = os.path.relpath(files[cls], stubs_root).replace("\\", "/")
        spec[rel].append((rva, body))

with open(out_path, "w", encoding="utf-8") as out:
    out.write("// Gerado por tools/auto_trivial.py: metodos triviais (getter/setter/constante) do pseudo-C.\n")
    for rel, items in sorted(spec.items()):
        out.write(f"\n//@file {rel}\n")
        for rva, body in items:
            out.write(f"//@body {rva}\n{{\n\t{body}\n}}\n")
print(dict(stats), "arquivos:", len(spec))
