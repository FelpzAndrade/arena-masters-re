#!/bin/bash
# Uso: ghidra_decomp.sh <entrada.txt> <saida.c>  (somente leitura sobre o projeto analisado)
cmd //c "C:\Users\felip\ghidra_12.1.4_PUBLIC\support\analyzeHeadless.bat" "${GHIDRA_PROJ_DIR:-C:\Users\felip\arena-masters-re\ghidra}" ArenaMasters -process libil2cpp.so -noanalysis -readOnly -scriptPath "C:\Users\felip\arena-masters-re\tools\ghidra_scripts" -postScript ExportDecomp2.java "$(cygpath -w "$1")" "$(cygpath -w "$2")" > /c/Users/felip/arena-masters-re/decomp/last_run2.log 2>&1
echo "exit $?"; grep -E "ERROR|Exception" /c/Users/felip/arena-masters-re/decomp/last_run2.log | head -5
