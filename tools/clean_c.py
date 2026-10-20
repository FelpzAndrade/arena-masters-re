"""Remove o ruido do runtime IL2CPP do pseudo-C exportado pelo ExportDecomp, para leitura/traducao.

Uso: python clean_c.py <entrada.c> [saida.c]
"""
import re, sys

src = open(sys.argv[1], encoding="utf-8").read()

# bloco de inicializacao lazy de metadados do metodo
src = re.sub(r"\n\s*if \(\*\(char \*\)\([^\n]*\) == '\\0'\) \{\n\s*i?Var\d+ = DAT_\w+ \+ 0x\w+;\n\s*FUN_0245fb20\([^\n]*\);\n\s*\*\(undefined1 \*\)\([^\n]*\) = 1;\n\s*\}", "", src)
# checagem de cctor executado: if (((*(byte *)(X + 0xb2) & 1) != 0) && (*(int *)(X + 0x60) == 0)) { FUN_02476778(); [reload] }
src = re.sub(r"\n\s*if \(\(\(\*\(byte \*\)\([^\n]*0xb2\) & 1\) != 0\) &&\s*\n?\s*\(\*\(int \*\)\([^\n]*0x60\) == 0\)\) \{\n\s*FUN_02476778\(\);\n(\s*\w+ = [^\n]*;\n)?\s*\}", "", src)
# carga do ponteiro de classe so usada pela checagem acima
src = re.sub(r"\n\s*i?Var\d+ = \*\*\(int \*\*\)\([^\n]*\);(?=\n)", lambda m: m.group(0) if "/*" in m.group(0) else "", src)
# declaracoes de variaveis locais e linhas vazias repetidas
src = re.sub(r"\n  (undefined\d?|int|uint|bool|byte|char|float|double|code|ushort) \**\w+(\[\d+\])?;", "", src)
src = re.sub(r"\n{3,}", "\n\n", src)
# nomes do runtime
src = src.replace("FUN_02490390();", "throw NullReferenceException();")
src = src.replace("thunk_FUN_02496c08(", "il2cpp_object_new(")

out = sys.argv[2] if len(sys.argv) > 2 else None
if out:
    open(out, "w", encoding="utf-8").write(src)
else:
    sys.stdout.reconfigure(encoding="utf-8")
    print(src)
