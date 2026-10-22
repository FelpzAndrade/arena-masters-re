# Arena Masters RE

Estudo de engenharia reversa do **Arena Masters: Legend Begins** (Nexon, jogo de celular desativado) e um **protótipo jogável de luta 1x1 em Unity 6**, que segue as regras de combate reconstruídas do código original.

> Projeto pessoal, para estudo e uso local. Os arquivos e o código decompilado do jogo original pertencem à Nexon. Por isso o repositório é **privado**, e nada dele deve ser publicado.

## O que tem aqui

- **Reconstrução do jogo original:** o APK foi compilado com IL2CPP. Os nomes das classes vieram do **Il2CppDumper** (`dump-armv7/`) e o código legível do **Ghidra** (`decomp/`, 28.530 métodos). Dele saíram as regras de dano, buffs, movimento e skills (`decomp/*_rules.md`). Cenas, texturas e interface foram extraídas com o **AssetRipper**. Os heróis não estavam no APK (o jogo baixava depois), por isso o protótipo usa modelos grátis.
- **Protótipo de luta** (`unity6-project/`, Unity 6000.5.2f1, URP 17.5):
  - 3 heróis: **Axie** (bárbaro), **Spark** (mago) e **Cavaleiro** (herói próprio). Cada um tem combo, 4 skills, esquiva, ultimate e passiva.
  - Bot inimigo, luta até 3 abates, números de dano e combo.
  - Equipamentos (18 itens, conjunto, itens mágicos, aprimoramento +0 a +10), 6 relíquias e progresso salvo em JSON.
  - Telas de escolha de herói e de inventário.
  - Arena com lightmap, decalques, partículas de ambiente e pós-processamento.
  - Efeitos próprios: Particle System com shaders HLSL escritos à mão e texturas geradas em Python.
  - Controles de toque (joystick e botões com mira) e build para **Android** (rodando a 60 FPS num Galaxy Tab S10+) e projeto para **iOS**.

## Como abrir

1. Instale o **Unity 6000.5.2f1** pelo Unity Hub (para celular, adicione **Android Build Support** e/ou **iOS Build Support**).
2. Abra a pasta `unity6-project/`.
3. Menu **Arena Masters > Abrir luta 1x1 (protótipo)** e aperte Play.

**Controles no PC:** WASD para andar, mouse para mirar, botões e teclas das skills, 1 2 3 para as relíquias.

**Celular:** menu **Arena Masters > Celular**:
- "Build and Run Android" gera e instala o APK com o tablet ligado no USB.
- "Gerar projeto iOS" cria o projeto para abrir no Xcode, no Mac.

O passo a passo completo está no `CLAUDE.md`.

## Pastas

| Pasta | Conteúdo |
|---|---|
| `unity6-project/` | Projeto Unity principal |
| `unity6-project/Assets/Prototype/` | Combate: `Fighter`, `FighterDef` (heróis), `SkillDef`, `Buffs`, `Brains` (jogador/bot), `BattleManager` |
| `unity6-project/Assets/Herois/` | Cavaleiro, boneco de teste e componentes dos heróis |
| `unity6-project/Assets/VFX/` | Shaders HLSL, texturas, prefabs e scripts dos efeitos |
| `unity6-project/Assets/UI/` | Controles de toque, telas, números de dano |
| `decomp/` | Regras extraídas do código original (`*_rules.md`) |
| `wiki/` | Atributos e skills dos heróis, tirados da wiki de fãs |
| `tools/` | Scripts Python (texturas, patches), Blender e testes |

Ficam só no PC, fora do git por serem grandes: o APK extraído (`extracted/`), o código decompilado completo (`decomp/all_game_out.c`), o Il2CppDumper (`dump-armv7/`), os bancos do Ghidra, a cópia de testes `unity6-ci/` e a `Library/` do Unity. Os assets da Asset Store também ficam de fora; os modelos KayKit entram.

## Regras do projeto

- Só assets grátis/CC0 (KayKit, Kenney, Cartoon FX Free).
- Efeitos: Particle System, cor HDR, no máximo 80 partículas, sem luz em tempo real.
- Valores que vinham de tabelas do servidor (indisponíveis) são **estimativas**.
- Nenhum acesso a servidores da Nexon. Os dados vêm só dos arquivos locais e da wiki de fãs.

As regras de trabalho completas, o estado atual e os próximos passos estão no `CLAUDE.md`.

## Créditos

- Modelos e animações: [KayKit](https://kaylousberg.itch.io/) (Kay Lousberg, CC0) e Mixamo.
- Efeitos base: Kenney (CC0) e Cartoon FX Remaster Free (JMO).
- Dados de heróis: [Arena Masters Wiki](https://arena-masters-legend-begins.fandom.com) (fandom).
- Jogo original: Arena Masters: Legend Begins, © Nexon.
