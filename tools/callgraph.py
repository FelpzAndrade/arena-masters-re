"""Grafo de chamadas (diretas) sobre a exportacao em massa do Ghidra e fecho a partir de classes raiz.

Uso: python callgraph.py <all_game_out.c> <saida.json> --roots ClasseA,ClasseB --exclude Prefixo1,Prefixo2
Chamadas virtuais/de interface sao indiretas no pseudo-C e nao aparecem; por isso o relatorio tambem
mostra o fecho por classe (toda classe alcancada entra inteira).
"""
import argparse, collections, json, re

ap = argparse.ArgumentParser()
ap.add_argument("decomp")
ap.add_argument("out")
ap.add_argument("--roots", required=True)
ap.add_argument("--exclude", default="")
a = ap.parse_args()

funcs = {}          # nome ghidra -> (rva, classe, metodo, linhas, corpo)
for block in open(a.decomp, encoding="utf-8", errors="replace").read().split("// ==== ")[1:]:
    head, _, rest = block.partition("\n")
    m = re.match(r"(0x[0-9A-F]+) (\S+)\$\$(\S+)", head)
    sig = re.search(r"\n(?:[\w\s\*]+?)\s\**([A-Za-z_][\w<>,.\- ]*?)\s*\(", rest)
    if not m or not sig:
        continue
    gname = sig.group(1).strip()
    funcs[gname] = (m.group(1), m.group(2), m.group(3), rest.count("\n"), rest)

call_re = re.compile(r"\b([A-Za-z_][\w<>,\-]*__[\w<>,\-]+)\s*\(")
excl = [e for e in a.exclude.split(",") if e]
def allowed(cls):
    return not any(cls.startswith(e) for e in excl)

roots = set(a.roots.split(","))
edges = collections.defaultdict(set)
for g, (rva, cls, meth, n, body) in funcs.items():
    for callee in call_re.findall(body):
        if callee in funcs and callee != g:
            edges[g].add(callee)

seen = set(g for g, v in funcs.items() if v[1] in roots)
queue = list(seen)
while queue:
    g = queue.pop()
    for c in edges[g]:
        if c not in seen and allowed(funcs[c][1]):
            seen.add(c)
            queue.append(c)

by_class = collections.defaultdict(lambda: [0, 0])
for g in seen:
    by_class[funcs[g][1]][0] += 1
    by_class[funcs[g][1]][1] += funcs[g][3]
class_total = collections.defaultdict(lambda: [0, 0])
for g, v in funcs.items():
    class_total[v[1]][0] += 1
    class_total[v[1]][1] += v[3]

def bucket(n):
    return "trivial(<=10)" if n <= 10 else "medio(11-60)" if n <= 60 else "longo(61-200)" if n <= 200 else "muito longo(>200)"
size = collections.Counter(bucket(funcs[g][3]) for g in seen)
report = {
    "metodos_alcancados": len(seen),
    "linhas_pseudo_c": sum(funcs[g][3] for g in seen),
    "por_tamanho": dict(size),
    "classes": sorted(([c, v[0], v[1], class_total[c][0], class_total[c][1]] for c, v in by_class.items()), key=lambda r: -r[2]),
    "fecho_por_classe": {"metodos": sum(class_total[c][0] for c in by_class), "linhas": sum(class_total[c][1] for c in by_class)},
    "metodos": sorted(f"{funcs[g][0]} {funcs[g][1]}$${funcs[g][2]}" for g in seen),
}
json.dump(report, open(a.out, "w", encoding="utf-8"), indent=1, ensure_ascii=False)
print("metodos alcancados:", report["metodos_alcancados"], "| linhas:", report["linhas_pseudo_c"], "|", dict(size))
print("fecho por classe:", report["fecho_por_classe"], "| classes:", len(by_class))
print("\nclasse                                   metodos  linhas   (classe inteira: metodos/linhas)")
for c, m_, l, tm, tl in report["classes"][:45]:
    print(f"{c[:40]:40s} {m_:6d} {l:7d}   ({tm}/{tl})")
