#!/bin/bash
# Sincroniza Assets para a copia de CI e roda um metodo de editor em batchmode.
# Uso: ci_run.sh [Classe.Metodo]
powershell -NoProfile -Command "robocopy 'C:\Users\felip\arena-masters-re\unity6-project\Assets' 'C:\Users\felip\arena-masters-re\unity6-ci\Assets' /MIR /NFL /NDL /NJH /NJS | Out-Null"
L=/c/Users/felip/arena-masters-re/ci.log; rm -f $L
ARGS=(-batchmode -quit -projectPath "C:\Users\felip\arena-masters-re\unity6-ci" -logFile "C:\Users\felip\arena-masters-re\ci.log")
[ -n "$1" ] && ARGS+=(-executeMethod "$1")
"/c/Program Files/Unity/Hub/Editor/6000.5.2f1/Editor/Unity.exe" "${ARGS[@]}" >/dev/null 2>&1
echo "exit $?  erros CS: $(grep -E 'error CS[0-9]+' $L | sort -u | wc -l)"
grep -E 'error CS[0-9]+' $L | sort -u | head -15 | cut -c1-250
grep -E "Exception|executeMethod.*(fail|not)" $L | grep -v "^\s*at " | sort -u | head -5 | cut -c1-250
