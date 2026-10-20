#!/bin/bash
# Compila o projeto no Unity 6 em batchmode e resume os erros.
L=/c/Users/felip/arena-masters-re/unity6-import.log; rm -f $L
"/c/Program Files/Unity/Hub/Editor/6000.5.2f1/Editor/Unity.exe" -batchmode -quit -accept-apiupdate -projectPath "C:\Users\felip\arena-masters-re\unity6-project" -logFile "C:\Users\felip\arena-masters-re\unity6-import.log" >/dev/null 2>&1
echo "exit $?"
echo "erros CS (unicos): $(grep -E 'error CS[0-9]+' $L | sort -u | wc -l)"
grep -E 'error CS[0-9]+' $L | sort -u | grep -oE "error CS[0-9]+" | sort | uniq -c | sort -rn | head -12
