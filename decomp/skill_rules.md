# Mecanicas de skill do original (resumo da analise)

## Projeteis (XSkillProjectile)
- Lanca em m_projectileShowTime/AtkSpeed; anda reto a m_fProjectileSpeed; some depois de projectile_range.
- IsTrap = alcance<=0 ou velocidade<=0 (armadilha/area parada; dura ExpiredTime).
- PenetratingChar=false: some no 1o acerto; true: atravessa, cada alvo leva 1 acerto por projetil.
- PenetratingWall=false: some ao bater em parede do mapa.
- Projetil lancado sobrevive ao cancelamento/controle do dono.
- Flags de texto: qualquer valor != "FALSE" = verdadeiro.

## Areas de acerto (XSkillCollider)
- Formas vem de prefabs (Prefab/Collider/*), nao de formulas. Hit-time i usa collider i.
- m_hitFollowTime<0: area acompanha o dono; >=0: fica parada no mundo onde o dono estava.
- hit_persistence: depois do CastingTime, cancelar/controlar o dono NAO encerra a skill (continua ate ExpiredTime).
- hit_clear_on_die: so entao a morte do dono encerra as skills persistentes.

## Varios acertos
- m_strHitTime "s,e/s,e/..." (valor unico: e=s+0.2). Janela ativa s..e (divididos por AtkSpeed).
- Cada janela gera novo UID: cada alvo leva 1 acerto por janela (anel de ~5 UIDs recentes por vitima).

## Passivas
- SkillPassiveTiming: Kill, Revive, DeathsDoor, Controlled, Tag, Dodge, Death, Hit, Damage, EnterDeathsDoor, HitMe,
  DamageMe, Physical/MagicalDamage(Me), CriticalHit(Me).
- Chance = procRatio x (accFactor da skill que acertou, ou 1). Recarga interna = cooldown da propria passiva.
- A passiva roda como uma skill normal em segundo plano.

## Cura
- healRatioPerMaxHp>0: o acerto cura (alvos aliados) heal = maxHP_alvo * ratio, limitado ao que falta.
- SkillHitTarget==Self: cura o proprio ao iniciar a skill.

## Medo / Transformacao / Invisivel
- Terrify sem objeto de controle: buff com movimento uniforme (m_uniformMotionSpeed, direcao pela fonte).
- Transformacao (Oz): buff troca o modelo (m_nChangeCharID) e desativa as skills.
- Invisivel: some ao usar skill ou ao acertar com skill dispelInvisibleOnHit.
- SNEAK_TIME: parado 3s esconde a barra de vida (modo de jogo), nao e invisibilidade.

## Combo
- Por linha de combo: proximo golpe aceito entre t+espera e t+espera+m_fComboLimitTime
  (espera = m_fComboSkillStartTime ou 0.8*duracao do clipe). Antes disso o toque e ignorado.
