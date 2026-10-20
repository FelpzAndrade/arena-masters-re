"""Aplica uma especificacao de reconstrucao aos stubs C# do projeto Unity.

Uso: python apply_recon.py <Assets/Scripts> <spec.recon>

Formato da spec (diretivas em linhas que comecam com //@):
  //@file Caminho/Relativo.cs        arquivo alvo (relativo a Assets/Scripts)
  //@using System.Xml.Serialization  acrescenta um using se faltar
  //@attr campo [XmlAttribute("x")]   insere atributo(s) na declaracao do campo/enum/classe "campo"
  //@init campo = valor              acrescenta inicializador ao campo (ex.: static readonly)
  //@body 0xRVA                       substitui o corpo do metodo com [Address(RVA = "0xRVA")]
  { ...corpo... }                    (o bloco seguinte, ate a proxima diretiva)
  //@ctorbase 0xRVA : base(x)        acrescenta inicializador de construtor
  //@member                           insere membros novos antes da '}' final da classe
"""
import re, sys, os

def find_block(s, start):
    """Indice do '{' em/apos start e do '}' que o fecha (ignora strings e comentarios simples)."""
    i = s.index("{", start)
    depth, j, n = 0, i, len(s)
    while j < n:
        c = s[j]
        if c == '"':
            j += 1
            while s[j] != '"':
                j += 2 if s[j] == "\\" else 1
        elif c == "'":
            j += 1
            while s[j] != "'":
                j += 2 if s[j] == "\\" else 1
        elif s.startswith("//", j):
            j = s.index("\n", j)
        elif c == "{":
            depth += 1
        elif c == "}":
            depth -= 1
            if depth == 0:
                return i, j
        j += 1
    raise ValueError("bloco sem fechamento")

def indent_of(s, pos):
    line_start = s.rfind("\n", 0, pos) + 1
    return re.match(r"[ \t]*", s[line_start:]).group(0)

def reindent(body, indent):
    lines = body.strip("\n").split("\n")
    base = min((len(l) - len(l.lstrip("\t")) for l in lines if l.strip()), default=0)
    return "\n".join((indent + l[base:]) if l.strip() else "" for l in lines)

def apply(src, directives, path):
    for kind, arg, block in directives:
        if kind == "using":
            if f"using {arg};" not in src:
                src = f"using {arg};\n" + src
        elif kind == "attr":
            name, attr = arg.split(" ", 1)
            m = re.search(r"^([ \t]*)((?:public|private|protected|internal)[^\n;({=]*?\b" + re.escape(name) + r"\b\s*(?:[;=]|$))", src, re.M)
            if not m:
                m = re.search(r"^([ \t]*)(" + re.escape(name) + r"\s*=\s*\d+)", src, re.M)
            if not m:
                raise ValueError(f"{path}: campo {name} nao encontrado")
            if attr not in src[max(0, m.start() - 300):m.start()]:
                src = src[:m.start()] + m.group(1) + attr + "\n" + src[m.start():]
        elif kind == "init":
            name, value = [x.strip() for x in arg.split("=", 1)]
            m = re.search(r"(\b" + re.escape(name) + r")\s*;", src)
            if not m:
                raise ValueError(f"{path}: campo {name} nao encontrado")
            src = src[:m.end(1)] + " = " + value + src[m.end(1):]
        elif kind in ("body", "ctorbase"):
            rva = arg.split()[0]
            m = re.search(r'\[Address\(RVA = "' + re.escape(rva) + r'"', src)
            if not m:
                raise ValueError(f"{path}: RVA {rva} nao encontrado")
            # a assinatura e a primeira linha que nao e atributo depois do [Address]
            sig = re.compile(r"^[ \t]*(?!\[)\S", re.M).search(src, src.index("\n", m.start()))
            o, c = find_block(src, sig.start())
            if kind == "ctorbase":
                head = src[sig.start():o].rstrip()
                src = src[:sig.start()] + head + " " + arg.split(None, 1)[1].strip() + "\n" + indent_of(src, sig.start()) + src[o:]
            else:
                ind = indent_of(src, o)
                inner = reindent(block, ind + "\t")
                src = src[:o] + "{\n" + inner + "\n" + ind + "}" + src[c + 1:]
        elif kind == "member":
            # '}' que fecha a classe: o ultimo, ou o penultimo se houver namespace
            last = src.rstrip().rfind("}")
            if re.search(r"^namespace ", src, re.M):
                last = src.rstrip()[:last].rstrip().rfind("}")
            line_start = src.rfind("\n", 0, last) + 1
            ind = indent_of(src, last) + "\t"
            src = src[:line_start].rstrip("\n") + "\n\n" + reindent(block, ind) + "\n" + src[line_start:]
    return src

def parse(spec):
    files, cur, d = {}, None, None
    for line in open(spec, encoding="utf-8").read().split("\n"):
        m = re.match(r"\s*//@(\w+)\s*(.*)$", line)
        if m:
            kind, arg = m.group(1), m.group(2).strip()
            if kind == "file":
                cur = files.setdefault(arg, [])
                d = None
            else:
                d = [kind, arg, ""]
                cur.append(d)
        elif d is not None and d[0] in ("body", "member"):
            d[2] += line + "\n"
    return files

if __name__ == "__main__":
    root, spec = sys.argv[1], sys.argv[2]
    for rel, directives in parse(spec).items():
        p = os.path.join(root, rel)
        src = open(p, encoding="utf-8-sig").read()
        for d in directives:
            if d[0] == "body":
                b = d[2].strip()
                assert b.startswith("{") and b.endswith("}"), f"{rel} {d[1]}: corpo deve estar entre chaves"
                d[2] = b[1:-1]
        out = apply(src, directives, rel)
        open(p, "w", encoding="utf-8").write(out)
        print(f"{rel}: {len(directives)} diretivas")
