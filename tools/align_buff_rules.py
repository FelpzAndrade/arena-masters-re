"""Alinha os buffs do prototipo as regras extraidas do XModuleBuff/XBuff (decomp/buff_rules.md)."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:80])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


patch("Prototype/Buffs.cs", [
    ("""	public float period = 1f;              // intervalo do tique (m_fPeriod)""", """	public float period = 1f;              // intervalo do tique (m_fPeriod)
	public int maxStack = 1;               // XBuff.Reapply: mesmo buff reaplicado acumula ate o maximo e renova o tempo
	public bool clearOnDie = true;         // strClearOnDie: so esses saem quando o lutador morre"""),
    ("""	public float remaining;
	public float tickTimer;""", """	public float remaining;
	public float tickTimer;
	public int stack = 1;
	public int tickDamage;                 // % da vida maxima x stack, fixado na aplicacao (XBuff 0x1A99238)"""),
    # Sangramento: garantido e acumulavel (buffs de skill nao tem chance no jogo original)
    ("""		dotPerMaxHp = 0.015f, period = 1f, color = new Color(0.8f, 0.05f, 0.05f), auraTexture = "spark_05",""",
     """		dotPerMaxHp = 0.008f, period = 1f, maxStack = 3, color = new Color(0.8f, 0.05f, 0.05f), auraTexture = "spark_05","""),
])

patch("Prototype/FighterDef.cs", [
    ("""new BuffProc { timing = ProcTimingType.Hit, rate = 30, buff = BuffLibrary.Sangramento }""",
     """new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Sangramento }"""),
])

patch("Prototype/Fighter.cs", [
    # AddBuff com as regras reais
    ("""	// linha/rank: buffs da mesma linha nao acumulam; rank maior ou igual substitui e renova a duracao
	public void AddBuff(BuffDef buff, Fighter source)
	{
		if (!IsAlive)
		{
			return;
		}
		ActiveBuff same = buffs.Find(b => b.def.line != null && b.def.line == buff.line);
		if (same != null)
		{
			if (same.def.rank > buff.rank)
			{
				return;
			}
			RemoveBuff(same);
		}
		ActiveBuff active = new ActiveBuff { def = buff, source = source, remaining = buff.duration };
		buffs.Add(active);
		RecalcStatus();""", """	// Regras do XModuleBuff.GainBuff (0xB48D34), XBuff.Reapply (0x1A98F98), ApplyEraseBuff (0xB4C190), ApplyMF (0xB46454)
	public void AddBuff(BuffDef buff, Fighter source)
	{
		if (!IsAlive)
		{
			return;
		}
		// mesmo buff reaplicado: stack +1 ate o maximo e renova o tempo
		ActiveBuff existing = buffs.Find(b => b.def == buff);
		if (existing != null)
		{
			existing.stack = Mathf.Min(existing.stack + 1, buff.maxStack);
			existing.remaining = CalcDuration(buff);
			existing.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp * existing.stack));
			RecalcStatus();
			onPopup?.Invoke(this, buff.maxStack > 1 ? $"{buff.name} x{existing.stack}" : buff.name, buff.color);
			return;
		}
		// rank menor que um buff ativo da mesma linha e rejeitado
		if (buffs.Exists(b => b.def.line != null && b.def.line == buff.line && b.def.rank > buff.rank))
		{
			return;
		}
		float duration = CalcDuration(buff);
		if (duration < 0f)
		{
			onPopup?.Invoke(this, "IMUNE", Color.gray);
			return;
		}
		// o novo remove os buffs da mesma linha
		for (int i = buffs.Count - 1; i >= 0; i--)
		{
			if (buffs[i].def.line != null && buffs[i].def.line == buff.line)
			{
				RemoveBuff(buffs[i]);
			}
		}
		// so um controle de movimento por vez: o novo libera o anterior
		if (buff.control != MotionControlType.None)
		{
			for (int i = buffs.Count - 1; i >= 0; i--)
			{
				if (buffs[i].def.control != MotionControlType.None)
				{
					RemoveBuff(buffs[i]);
				}
			}
		}
		ActiveBuff active = new ActiveBuff { def = buff, source = source, remaining = duration };
		active.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp));
		buffs.Add(active);
		RecalcStatus();"""),
    ("""			PlayOnce(def.animHit, buff.duration);""", """			PlayOnce(def.animHit, duration);"""),
    # duracao: tenacidade so reduz Stun/Beaten (CalcDurationTime 0xB4E7A8)
    ("""	private void RemoveBuff(ActiveBuff b)""", """	private float CalcDuration(BuffDef buff)
	{
		if (buff.control == MotionControlType.Stun || buff.control == MotionControlType.Beaten)
		{
			float toughness = status.Toughness.Calc();
			if (toughness >= 1f)
			{
				return -1f;
			}
			return XCalculator.CalcMotionControlTime(buff.duration, toughness);
		}
		return buff.duration;
	}

	private void RemoveBuff(ActiveBuff b)"""),
    # atributos x stack (MergeBuffStatus 0xB364C4)
    ("""			status.Merge(b.def.stats, 1f);""", """			status.Merge(b.def.stats, b.stack);"""),
    # tique: dano fixado na aplicacao, bruto, respeita invencibilidade
    ("""					if (b.def.dotPerMaxHp > 0f)
					{
						TickDamage(b, Mathf.Max(1, Mathf.RoundToInt(maxHp * b.def.dotPerMaxHp)));
					}""", """					if (b.def.dotPerMaxHp > 0f && !invulnerable)
					{
						TickDamage(b, b.tickDamage);
					}"""),
    # morte: so saem os ClearOnDie (2 lugares)
    ("""			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);
			ClearBuffs();""", """			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);
			ClearBuffs(true);"""),
    ("""			onPopup?.Invoke(this, "K.O.", Color.red);
			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);
			ClearBuffs();""", """			onPopup?.Invoke(this, "K.O.", Color.red);
			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);
			ClearBuffs(true);"""),
    ("""	private void ClearBuffs()
	{
		for (int i = buffs.Count - 1; i >= 0; i--)
		{
			RemoveBuff(buffs[i]);
		}
	}""", """	private void ClearBuffs(bool onlyClearOnDie = false)
	{
		for (int i = buffs.Count - 1; i >= 0; i--)
		{
			if (!onlyClearOnDie || buffs[i].def.clearOnDie)
			{
				RemoveBuff(buffs[i]);
			}
		}
	}"""),
])

# nome do buff um pouco acima do numero de dano para nao sobrepor
patch("Prototype/BattleManager.cs", [
    ("""		tm.transform.position = who.Position + Vector3.up * 1.6f + new Vector3(Random.Range(-0.4f, 0.4f), 0f, 0f);""",
     """		bool isNumber = text.Length > 0 && char.IsDigit(text[0]);
		tm.transform.position = who.Position + Vector3.up * (isNumber ? 1.6f : 2.3f) + new Vector3(Random.Range(-0.4f, 0.4f), 0f, 0f);"""),
    ("""			sb.Append($"<color=#{hex}>{(b.def.type == CS.BuffType.Debuff ? "v" : "^")} {b.def.name} {b.remaining:0.0}s</color>   ");""",
     """			string stack = b.stack > 1 ? $" x{b.stack}" : string.Empty;
			sb.Append($"<color=#{hex}>{(b.def.type == CS.BuffType.Debuff ? "v" : "^")} {b.def.name}{stack} {b.remaining:0.0}s</color>   ");"""),
])
print("ok")
