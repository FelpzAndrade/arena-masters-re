"""Mapeia os arquivos serializados de assets/bin/Data com UnityPy (somente leitura)."""
import sys, os, re, json, collections
import UnityPy

data_dir, out_json = sys.argv[1], sys.argv[2]
env = UnityPy.load(data_dir)

report = {"files": {}, "scenes": [], "resources_container": [], "textassets": [], "scripts": collections.Counter()}

for name, sf in env.files.items():
    base = os.path.basename(name)
    types = collections.Counter()
    for obj in getattr(sf, "objects", {}).values():
        t = obj.type.name
        types[t] += 1
        try:
            if t == "BuildSettings":
                report["scenes"] = list(obj.read().scenes)
            elif t == "ResourceManager":
                rm = obj.read()
                for path, ptr in rm.m_Container:
                    report["resources_container"].append(path)
            elif t == "TextAsset":
                ta = obj.read()
                raw = ta.m_Script
                size = len(raw.encode("utf-8", "surrogateescape")) if isinstance(raw, str) else len(raw)
                report["textassets"].append({"file": base, "name": ta.m_Name, "size": size})
            elif t == "MonoScript":
                ms = obj.read()
                report["scripts"][f"{ms.m_Namespace}.{ms.m_ClassName}".lstrip(".")] += 1
        except Exception as e:
            types[f"!erro:{t}"] += 1
    report["files"][base] = dict(types)

report["scripts"] = dict(report["scripts"].most_common())
with open(out_json, "w", encoding="utf-8") as f:
    json.dump(report, f, ensure_ascii=False, indent=1)

# resumo no stdout
print("arquivos serializados:", len(report["files"]))
total = collections.Counter()
for t in report["files"].values():
    total.update(t)
print("objetos por tipo (top 25):")
for t, c in total.most_common(25):
    print(f"  {c:7d}  {t}")
print("\ncenas no BuildSettings:", len(report["scenes"]))
for i, s in enumerate(report["scenes"]):
    print(f"  level{i}: {s}")
print("\nResources/ container:", len(report["resources_container"]))
dirs = collections.Counter(p.split("/")[0] if "/" in p else "(raiz)" for p in report["resources_container"])
for d, c in dirs.most_common(20):
    print(f"  {c:5d}  {d}/")
print("\nTextAssets:", len(report["textassets"]))
for t in sorted(report["textassets"], key=lambda x: -x["size"])[:25]:
    print(f"  {t['size']:9d}  {t['name']}  [{t['file']}]")
