#!/bin/bash
# Lista "0xRVA Classe.Metodo" para os .cs dados
for f in "$@"; do c=$(basename "$f" .cs); awk -v c="$c" '/Address\(RVA = "0x/ { match($0, /0x[0-9A-F]+/); rva=substr($0, RSTART, RLENGTH); getline; while ($0 ~ /^\s*\[/) getline; gsub(/^\s+/, "", $0); print rva " " c " :: " $0 }' "$f"; done
