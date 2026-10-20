# Arena Masters RE — protótipo de luta em Unity

Engenharia reversa do APK Arena Masters (Nexon, desativado) para estudo e uso local, e um protótipo jogável de luta 1x1 que segue as regras reconstruídas do código original.

## Regras com o usuário
- Responder sempre em **português do Brasil**, linguagem simples, sem frases em inglês.
- Não comprar nada: só assets grátis/CC0 (KayKit, Kenney, Cartoon FX Free).
- Áudio fica para depois.
- Seguir o código original sempre que possível; quando um valor vier de tabela do servidor (GameData.zip, indisponível), estimar e dizer que é estimativa.
- Não sondar o S3 da Nexon (bloqueado pela segurança). Dados de heróis: wiki de fãs via API MediaWiki (`wiki/`).

## Pastas
- `unity6-project/` — projeto do usuário (aberto no Unity 6000.5.2f1). Não rodar batchmode nele.
- `unity6-ci/` — cópia para testes. `tools/ci_run.sh PrototypeSetup.Capture` espelha Assets e roda uma luta bot x bot de 90 s (≈ 1-2 min): gera `captures/luta_*.png`, `captures/luta_log.txt` e `ci.log` (procurar `error CS`).
- `unity6-project/Assets/Prototype/` — código do protótipo: `Fighter.cs` (lutador, buffs, controles de movimento), `FighterDef.cs` (heróis), `SkillDef.cs`, `Buffs.cs`, `Brains.cs` (jogador/bot), `BattleManager.cs` (cena, câmera, UI, efeitos), `Vfx.cs`, `Arena.cs` (navmesh do DuelArena), `DungeonDecor.cs`.
- `unity6-project/Assets/Editor/Reconstruction/PrototypeSetup.cs` — menu "Arena Masters/Abrir luta 1x1 (prototipo)" e a captura.
- `tools/integrate_*.py` — scripts de patch (python: `tools/venv/Scripts/python.exe -I`).
- `decomp/` — decompilação Ghidra (`all_game_out.c` = 28.530 métodos, cabeçalho `// ==== 0xRVA Classe$$Metodo`). Regras já extraídas: `buff_rules.md`, `motion_rules.md`, `skill_rules.md`.
- `dump-armv7/` — Il2CppDumper (`dump.cs` com offsets de campos, `stringliteral.json`). Constantes: offset no `extracted/lib/armeabi-v7a/libil2cpp.so` = endereço − 0x10000.
- `wiki/herois.txt` — 16 heróis com atributos e skills (fonte: arena-masters-legend-begins.fandom.com).

## Estado (2026-10-19)
- Heróis: **Axie** (KayKit Barbarian) e **Spark** (KayKit Mage) com números da wiki.
- Feito: 4 skills + passiva + esquiva + ultimate (barra 10.000, carga = `skill.ultimateCharge` por acerto); barreira, puxão, golpe em linha, Split, muralha de pedras.
- Controles de movimento seguem o original: FakeBeaten é só visual; Beaten, Knockback, Airborne, Throwup, Throw, Split, Pull, Stun, Paralysis, Root.
- Visual: Cartoon FX Remaster Free, pós-processamento 3.5.4 e rastro de arma.
- **Efeitos novos: só Particle System + shader próprio** (sem Cartoon FX). Pasta `Assets/VFX/`: shader HLSL `Shaders/ParticulaDissolve.shader` (Built-in; projeto ainda não é URP, troca adiada), texturas de `tools/gen_vfx_textures.py`, prefabs em `VFX/Resources` montados pelo menu "Arena Masters/VFX/Montar Machado Barbaro", scripts reutilizáveis `HitStop`, `CameraShake`, `HitFlash`. Teste: `tools/ci_run.sh VfxCapture.Machado` → `captures/vfx_machado_*.png`. Feito: Machado Bárbaro (vfx `axeslash`). Malha de partícula sem cor de vértice (Float32 chega errado no shader).
- **Animações novas no Blender 5.2** (add-on blender-mcp em `tools/blender/addon.py`; falar com ele pela ferramenta `blender_bridge` do Unity MCP, porta 9876). Abrir: `blender.exe --python tools/blender/abrir_axie.py` (carrega o Barbarian e liga o servidor); cena salva em `tools/blender/axie.blend`. Exportar só o Rig em FBX para `Prototype/KayKit/Animations/<Heroi>@<Clipe>.fbx` e rodar o menu "Arena Masters/Animacoes/Converter do Blender" (põe o prefixo `Rig/` e gera `Prototype/Resources/Anim/<Clipe>.anim`); o `Fighter` carrega sozinho clipes de skill que o modelo não tem. Pôr o tempo do impacto em `Fighter.ImpactTime`. Feito: `Bufalo_Cabecada` (Investida do Búfalo, impacto no quadro 12 de 27). Para conferir pose no Unity numa cena de prévia, assar a malha (`BakeMesh`): malha com esqueleto não atualiza lá.
- Unity MCP (pacote `com.coplaydev.unity-mcp` v10.3.0, servidor `UnityMCP` em http://127.0.0.1:8080/mcp): usar para ver o Play ao vivo.

## Próximos passos
1. **Nori** (`Knight.fbx`: 1H_Sword + Badge_Shield) e **Windy** (`Rogue.fbx`: 2H_Crossbow), já copiados em `Prototype/KayKit/Characters`. Precisam de: cura (healRatioPerMaxHp), invencível, armadilha (skill parada que dura ExpiredTime) e passiva com vida < 30% (EnterDeathsDoor).
2. Tela de escolha de herói.
3. Opcional: regras de projétil (atravessar personagem/parede), hit_persistence, janela de combo do original, troca de herói (Tag).
