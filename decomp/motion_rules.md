# Controles de movimento do original (XMotionControl_*), resumo da analise

Fontes: decomp/motion_clean.c, all_game_out.c, dump.cs; constantes lidas do libil2cpp.so (VA-0x10000).

## Base
- Tipos: None0 Slow1 Beaten2 Stun3 Terrify4 Airborne5 Knockback6 Throwup7 Paralysis8 Root9 Pull10 Split11 Throw12.
  NewMotionControl (0xB332F4) cria objeto so para 2,3,5-12 (Terrify nao tem classe de movimento).
- Start (0xB9DEF8): Direction = normalize(dir.xz) com y=-10 (gravidade do CharacterController).
- Duracao (XModuleAction.CalcDuration 0xB33AAC), d = buff.fMotionControlDistance (0xD8):
  - Beaten/Stun: min(200,(1-tough)*t); imune se tough>=1
  - Airborne: 2*min(20,(2-w/10)*d)/14; imune se peso>=20
  - Knockback/Throwup/Split/Throw: min(50,(2-w/10)*d)/8 (sem dobrar)
  - Pull: OnStart define; imune se peso>=20
  - Paralysis/Root: duracao do buff
  - A duracao do buff passa a ser control.TotalTime.
- Direcao (XBuffLogic.GetControlDirection 0x1A9937C): Forward=vitima-fonte (empurra), Backward=fonte-vitima (puxa),
  Front=frente da fonte, Rear=-frente da fonte.
- Vertical: DOTween no Y local do modelo (raiz fica no chao). Eases: 2 InSine, 3 OutSine, 5 InQuad, 6 OutQuad. Queda usa 0.9*.

## Por tipo
- Beaten(2) "beaten": so pelo OnHitMe se dano > maxHP*limiar, tough<1, sem controle ativo e skill.beatenDuration>0.
  Tempo = beatenDuration (sem tenacidade), distancia beatenDistance, vira para o atacante (LookAt). Desloca por curva.
- Knockback(6) "knockback": desloca Direction*Distance pela curva; se no ar, cai em T*0.9.
- Stun(3) "stun" / Paralysis(8) "paralysis" (Animation.Stop: congela a pose) / Root(9) anim de idle: sem deslocamento.
- Airborne(5) "airborne": sobe ate H=T/2*14 (OutSine), cai em 0.9*T/2 (InSine). Sem deslocamento horizontal.
- Throwup(7) "throwup": mesma subida (14) + desloca horizontal a 8 u/s durante o tempo.
- Throw(12) "throwup": subida 3.5 u/s (H=1.75T, InQuad/OutQuad), horizontal 12.5 u/s.
- Split(11) "throwup": como Throwup, horizontal perpendicular a linha do ataque (Front: para fora da linha; Rear: para a linha).
- Pull(10) "throwup": puxa ate encostar (dist - raios), velocidade MFPullSpeed; depois quica de volta Distance2 com pulinho.

## Ciclo
- Inicio cancela a skill da vitima (XModuleSkill.OnMotionControlStart). Controle novo sobrescreve o atual (sem prioridade por tipo).
- Durante o controle: sem andar, sem idle, IA e botoes de skill bloqueados (HasMotionFactor).
- Fim: volta para idle com fade.
- FakeBeaten (0xB41C38): tranco visual aditivo ("fakebeaten", camada 10) em todo dano > 0 — sem controle e sem movimento.

## Nao resolvido
Curvas (beatenKnockbackCurve, MFPullCurve, bounce) e valores do XSystemData ficam em cena/prefab; limiar de dano do Beaten (XGlobal+0x44).
