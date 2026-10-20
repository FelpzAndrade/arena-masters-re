# Regras do sistema de buffs (Arena Masters, libil2cpp.so armeabi-v7a)

Fonte: pseudo-C do Ghidra em `decomp/buff_clean.c` (XModuleBuff, XBuff, CSBuffInfo) e `decomp/buffdeps_out.c`.
Legenda de certeza: **[O]** observado diretamente no pseudo-C; **[I]** inferido (estrutura clara, detalhe não confirmado).

Campos usados (offsets): XBuff `m_buffInfo 0x8, m_fDurationTime 0xC, m_fElapsedTime 0x10, m_dotInfo 0x14, m_bReleased 0x18,
m_ParentSkill 0x1C, m_buffStatus 0x20, m_stackCount 0x24, moveDir 0x2C, moveSpeed 0x38`. XModuleBuff `user 0xC, m_listBuff 0x10,
m_mFBuff 0x14, m_bInvincible 0x19, m_bImmunTrapPierce 0x1A, m_bInvisible 0x1B, m_binBush 0x1C, m_bImmunMapItem 0x1D, m_bGhost 0x1E`.
CSBuffInfo herda `CharStatus` (atributos 0x8..0xA4; `Duration` = 0x90, `Toughness` = 0x78, `Weight` = 0x84) + campos a partir de 0xB0.

## 1. Ciclo de vida

**GainBuff (0xB48D34)** — porta de entrada [O]:
1. Só roda no objeto local (dono da simulação).
2. Se o buff novo tem `buffLineList` (linhas) não vazia: percorre os buffs ativos (não liberados); se algum compartilha uma linha
   **e tem `m_nBuffRank` maior que o do novo, o novo é rejeitado** (return). Rank igual ou maior passa.
3. Calcula a duração com `CalcDurationTime` (virtual). **Duração < 0 = imune → buff não aplicado.**
4. Se já existe buff ativo com o **mesmo `m_nID`**: `XBuff.Reapply` (ver §2), move o buff para o fim da lista e chama `ReapplyBuff`;
   se atingiu o stack máximo e `triggingBuffTiming == MaxStack(2)`, ganha também o buff `triggingBuffId` (encadeamento).
5. Senão: se o novo tem controle de movimento (`nMotionControlType != 0`) e já existe um buff de controle ativo (`m_mFBuff`),
   **o controle anterior é liberado** (só um controle de movimento por vez). Depois `GainNewBuff`.

**GainNewBuff (0xB49C04)** [O]: ignora alvos com `CharacterInfo.type == 5` (tipo de personagem imune, provavelmente objeto/estrutura) [I quanto ao significado];
cria `XBuff` (pool), `Init(info, duração, skillPai, FinalMaxHP do alvo, atacante, stack=1, posição)`, adiciona à lista,
cria os efeitos visuais (`AddBuffEffect`) e chama `ApplyBuff`. Depois sincroniza pela rede (Photon).

**XBuff.Apply (0x1A98CA0)** [O]: guarda info/skillPai/duração, zera DoT, monta `m_buffStatus = CharStatus.New(); Merge(buffInfo, stackCount)`
(os atributos do buff **multiplicados pelo número de stacks**) e, se o atacante tem especialização de skill, soma o crescimento da especialização.

**ApplyBuff (0xB4BF30)** — aplica tudo na ordem [O]: `ApplyFlags` → `ApplyMF` (controle de movimento) → `ApplyAttribute`
(cegueira/visibilidade/fantasma) → `ApplyEraseBuff` (substituição/dispel) → `ApplyInstantDeath` → estado do jogador (zumbi etc.)
→ troca de modelo → meta-propriedades → `AddAdjustSkill` (altera cooldown de skill) → escala do modelo → `Notify_OnGainBuff`.

**Atualização (OnUpdate 0xB4E048 → BuffListUpdate 0xB4E180)** [O], a cada frame, só no objeto local:
para cada buff ativo: se `IsTimeOver` → `ReleaseBuffWithTrigging`; senão `XBuff.OnUpdate` (movimento uniforme) e
`PeriodUpdate` (`elapsed += dt` e DoT/HoT).

**IsTimeOver (0x1A996C4)** [O]: `elapsed > duration`, **exceto `BuffType.Passive (2)`, que nunca expira**.

**ReleaseBuffWithTrigging (0xB45A34)** [O]: libera e sincroniza; se `triggingBuffTiming == ThisBuffRelease(1)`, ganha o buff
`triggingBuffId` ao terminar (ex.: "ao acabar a fúria, fica exausto").

**CalcDurationTime (0xB4E7A8)** [O]:
- `base = Duration.Calc()` do status temporário = buffInfo (+ especialização). Ou seja, **a duração é o atributo `Duration`
  do próprio buff** (`value × (1+ratio) × multiplier`).
- `MotionControlType == Knockback (6)` → mantém `base`.
- `MotionControlType == None (0)`: só altera se o buff **transforma o personagem** (`m_nChangeCharID != 0`) e é **Debuff**:
  `Toughness` do alvo `< 1` → `CalcMotionControlTime(base, toughness)` = `min(200, (1-toughness)·base)`; `>= 1` → **-1 (imune)**.
  Buffs comuns de atributo **não são reduzidos por tenacidade**.
- Outros tipos → `XModuleAction.CalcDuration (0xB33AAC)`:
  - `Beaten(2)`, `Stun(3)`: `toughness < 1` → `min(200, (1-toughness)·base)`; senão **imune (-1)**.
  - `Airborne(5)`: `Weight < 20` → `CalcMotionControlAirborneTime(distância, peso)`; senão imune.
  - `Knockback(6)`, `Throwup(7)`, `Split(11)`, `Throw(12)`: `Weight < 20` → `CalcMotionControlKnockbackTime(distância, peso)`; senão imune.
  - `Pull(10)`: `Weight >= 20` → imune; senão 0 (a duração real vem do objeto de controle, ver §5).
  - `Slow(1)`, `Terrify(4)`, `Paralysis(8)`, `Root(9)`: **duração `base` sem redução**.

## 2. Acúmulo, substituição e dispel

- **Mesmo buff (mesmo `m_nID`)** [O] (`XBuff.Reapply 0x1A98F98`): `stack += 1` se `stack < stackCount` (campo 0x1C8 = stack máximo);
  **`elapsed = 0` (renova o tempo)**; reaplica (status recalculado com o novo stack, DoT recalculado). Duração nova = a recém calculada.
- **Linhas (`buffLineList`) e rank** [O]:
  - Entrada: rejeitado se já houver buff da mesma linha com rank **maior** (GainBuff).
  - Aplicação (`ApplyEraseBuff 0xB4C190`, passo 1): **todo outro buff ativo que compartilhe uma linha com o novo é removido**
    (com trigging). Resultado: na mesma linha, fica só o mais recente de rank ≥.
- **Dispel** [O] (`ApplyEraseBuff`, passo 2): todo outro buff ativo cuja `buffLineList` contenha alguma linha de
  `dispellBuffLineList` do novo é removido.
- As linhas vêm de strings (`m_strBuffLine`, `m_strDispellBuffLine`) convertidas em listas de int por `CookingBuffLine`/`CookingDispellBuffLine` [O].

## 3. Atributos no status

- `MergeBuffStatus (0xB364C4)` [O]: `status.Merge(buff.m_buffStatus, 1.0)` para cada buff ativo — **soma simples** usando a regra de
  `CharStatusAttr.Merge` (value e ratio somam; multiplier soma `(m-1)`).
- `m_buffStatus` já vem multiplicado pelo **stack** (§1, Apply). `m_fEffectRatio` **não aparece** no merge [O: ausente em Apply/Merge];
  provável uso visual/escala de efeito [I].

## 4. DoT / HoT

- `XBuff.InitDoTAndHoTInfo (0x1A99238)` [O]: só se `m_fPeriod > 0`.
  `dot = (int)(FinalMaxHP_do_alvo × m_fDotDamagePerMaxHP)`, `hot = (int)(FinalMaxHP_do_alvo × m_fHotHealPerMaxHP)`;
  se algum ≥ 1: `XDotInfo{ dano = stack × dot, cura = stack × hot, período = m_fPeriod, fonte = ATID do atacante }`.
  **Valores fixados na aplicação** (percentual da vida máxima **do alvo**, não do atacante).
- `XBuff.UpdateDotAndHot (0x1A994BC)` [O]: acumula `timer += dt`; quando `timer >= period` zera e dispara **um tique**
  (o primeiro tique ocorre após um período completo, não na aplicação). **Se há dano, só aplica dano; cura só se não houver dano.**
- Dano: `XModuleHit.OnHitDotDamage (0xB5FB70)` → `CheckHitEnabled` (respeita invencível etc.) → `DoHitDamage(fonte, valor, valor, …)`
  com o **valor bruto, sem passar por XCalculator** (sem defesa/crítico) [O]. Cura: `OnHitHotHeal (0xB6035C)` → `DoHitHeal` bruto [O].

## 5. Controle de movimento

- `ApplyMF (0xB46454)` [O], quando `nMotionControlType != 0`:
  - Origem: posição do atacante; se `nMotionControlSource == 1`, usa a posição passada explicitamente (ex.: centro da área).
  - Direção: `XBuffLogic.GetControlDirection (0x1A9937C)` por `nMotionControlDirection`: `0` = alvo − origem (afastar),
    `1` = origem − alvo (puxar para a origem), `3` = −forward do atacante, demais = forward do atacante.
  - Distância = `fMotionControlDistance`; em `Pull(10)` a distância vira `distXZ(origem, alvo) − raios`, com fator de força
    `clamp01(dist/configurada) × XSystemData` [O].
  - `XModuleAction.StartMotionControl(tipo, direção, duração, …)`; **a duração do buff passa a ser a do controle criado**.
  - O buff vira o `m_mFBuff` (único controle ativo). Ao liberar esse buff, `ReleaseMotionControl`.
- Movimento uniforme (`SetBuffUniformMotionInfo`/`XBuff.OnUpdate`) [O]: se `m_uniformMotionSpeed != 0`, a cada frame
  `CharacterController.ReserveMove(dir × dt × speed)` (ex.: vento empurrando continuamente).

## 6. Gatilhos (procs)

- **Buffs disparados por skill** [O] (`OnTrigger 0xB4EC30`): cada `CSSkillInfo` tem até 3 `XSkillBuff{buffID, alvo(HitTarget), momento(SkillBuffTiming)}`.
  Quando o momento e o alvo batem, o personagem ganha o buff. Momentos: `Use 0, Hit 1, Finish 2, CriHit 3, HitSuccess 4, CriSuccess 5`;
  alvos: `Self 1, Enemy 2, Allied 3, All 4`.
  - `OnHitActor (0xB4F8F0)`: ao acertar alguém dispara `Hit(1)` (uma vez por colisor), `CriHit(3)` se crítico, `HitSuccess(4)`/`CriSuccess(5)`
    uma vez por skill (UID).
  - `OnHitMe (0xB4F0E4)`: ao ser acertado, dispara os mesmos momentos para alvos `Enemy/Allied/All` do lado de quem levou.
- **Campos `m_nProcTimingType/m_nProcRate/m_nProcSkillID/m_fTriggingCooltime` do buff**: **não são lidos dentro de XModuleBuff** [O: ausência];
  o sistema de passivas usa `CSHelper.DiceRate(taxa × fator)` e cooldown de skill em `XModuleSkill.UsePassiveSkill (0xB8E934)` /
  `_UsePassiveSkill (0xB806B0)` [O parcial] — ou seja, "chance de soltar skill" é um mecanismo de **skill passiva**, não do buff [I].

## 7. Flags especiais

- `ApplyFlags (0xB461C8)` [O]: ao ganhar, liga `Invincible`, `ImmunTrapPierce`, `Invisible` (o buff de ID **151** liga "em arbusto" em vez de invisível),
  `ImmuneMapItem`, `Ghost`. Ao perder, **recalcula todas as flags a partir dos buffs restantes**.
- Invisível [O]: **é removido ao usar skill** (`OnAfterSkillStart`, predicado `<m__D6>`) e **ao acertar alguém** (`OnHitActor`, `<m__D8>`, quando a skill tem a flag em 0x25C).
- `InstantDeath (0xB4C5D0)` [O]: aplica `DoHitDamage` de **99.999.999** no próprio alvo.
- `ClearOnDie` [O] (`LostAllBuffOnDie 0xB47568`): ao morrer, remove efeitos visuais de todos os buffs não-de-modo e **libera só os que têm ClearOnDie**
  (os demais sobrevivem à morte).
- Condições extras de liberação (`extraReleaseConditions`, bool[]) [O]: índice **1** = ao terminar a skill que criou o buff
  (`DeleteBuffOnSkillEnd 0xB4EED8`); índice **2** = ao ser acertado (`OnHitMe`, `<m__D7>`). Índice 0 não observado.
- Strings booleanas do buff são "TRUE"/"FALSE" (`CSBuffInfo.Cooking 0x2225BD0`) [O].

## 8. Constantes

- Tenacidade ≥ **1.0** → imune a Beaten/Stun e a debuffs de transformação [O].
- Peso ≥ **20.0** → imune a Airborne/Knockback/Throwup/Split/Throw/Pull [O].
- Tempo de controle: `min(200, (1−tenacidade)·t)`; airborne/knockback via XCalculator (constantes XGameConst 14/8) [O].
- Dano de morte instantânea: **99999999** [O]. ID do buff "arbusto": **151 (0x97)** [O].
- Offset do efeito de Pull: **−1.1** em Y somado à metade da altura (DAT_00b60208) [O].
