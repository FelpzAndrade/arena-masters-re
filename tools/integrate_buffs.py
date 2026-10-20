"""Integra o sistema de buffs (Buffs.cs) ao prototipo: status efetivo, controle, tiques, gatilhos, aura e UI."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:80])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


# ---------- SkillDef: gatilhos de buff ----------
patch("Prototype/SkillDef.cs", [("""	public string vfx;""", """	public System.Collections.Generic.List<BuffProc> procs = new System.Collections.Generic.List<BuffProc>();
	public string vfx;""")])

# ---------- FighterDef: liga os buffs as skills ----------
procs = {
    'name = "Machadada",': 'procs = { new BuffProc { timing = ProcTimingType.Hit, rate = 30, buff = BuffLibrary.Sangramento } }, name = "Machadada",',
    'name = "Giro do Machado",': 'procs = { new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Atordoado } }, name = "Giro do Machado",',
    'name = "Salto Esmagador",': 'procs = { new BuffProc { timing = ProcTimingType.None, buff = BuffLibrary.Furia, onSelf = true } }, name = "Salto Esmagador",',
    'name = "Raio Arcano",': 'procs = { new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Enfraquecido }, new BuffProc { timing = ProcTimingType.CriHit, rate = 100, buff = BuffLibrary.Queimadura } }, name = "Raio Arcano",',
    'name = "Explosao Magica",': 'procs = { new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Lentidao }, new BuffProc { timing = ProcTimingType.CriHit, rate = 100, buff = BuffLibrary.Queimadura } }, name = "Explosao Magica",',
    'name = "Gira Gira",': 'procs = { new BuffProc { timing = ProcTimingType.CriHit, rate = 100, buff = BuffLibrary.Queimadura } }, name = "Gira Gira",',
    'name = "Teleporte",': 'procs = { new BuffProc { timing = ProcTimingType.None, buff = BuffLibrary.EscudoArcano, onSelf = true } }, name = "Teleporte",',
}
patch("Prototype/FighterDef.cs", list(procs.items()))

# ---------- Fighter ----------
patch("Prototype/Fighter.cs", [
    ("""	public readonly CharStatus status = new CharStatus();""", """	public readonly CharStatus status = new CharStatus();      // efetivo: base + buffs
	public readonly CharStatus baseStatus = new CharStatus();
	public readonly System.Collections.Generic.List<ActiveBuff> buffs = new System.Collections.Generic.List<ActiveBuff>();
	public System.Action<Fighter, ActiveBuff> onBuffAdded;
	public System.Action<Fighter, ActiveBuff> onBuffRemoved;"""),
    ("""		def.applyStats(status);
		maxHp = status.MaxHP.Calc();""", """		def.applyStats(baseStatus);
		status.Copy(baseStatus);
		maxHp = status.MaxHP.Calc();"""),
    ("""	public bool CanAct => state == State.Idle;""", """	public bool CanAct => state == State.Idle && !HasControl(MotionControlType.Stun);"""),
    # respawn limpa buffs
    ("""	public void Respawn()
	{
		hp = maxHp;""", """	public void Respawn()
	{
		ClearBuffs();
		hp = maxHp;"""),
    # movimento: velocidade com Furia/Lentidao, preso se atordoado/enraizado
    ("""		facing = dir;
		TryMoveTo(Position + dir * def.moveSpeed * dt);""", """		facing = dir;
		if (HasControl(MotionControlType.Root))
		{
			return;
		}
		TryMoveTo(Position + dir * MoveSpeed * dt);"""),
    # tick de buffs
    ("""		m_flash = Mathf.Max(0f, m_flash - dt);""", """		m_flash = Mathf.Max(0f, m_flash - dt);
		UpdateBuffs(dt);"""),
    # gatilho ao usar
    ("""		onSkillStart?.Invoke(this, sd, startCenter);""", """		onSkillStart?.Invoke(this, sd, startCenter);
		TriggerProcs(sd, ProcTimingType.None, null);"""),
    # gatilhos ao acertar
    ("""		target.TakeDamage(this, damage, critical, delta.sqrMagnitude > 0.01f ? delta.normalized : facing, sd);""", """		target.TakeDamage(this, damage, critical, delta.sqrMagnitude > 0.01f ? delta.normalized : facing, sd);
		if (target.IsAlive)
		{
			TriggerProcs(sd, ProcTimingType.Hit, target);
			if (critical)
			{
				TriggerProcs(sd, ProcTimingType.CriHit, target);
			}
		}"""),
    # morte limpa buffs
    ("""			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);""", """			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);
			ClearBuffs();"""),
    # API de buffs
    ("""	private void StartControl(Vector3 velocity, float time)""", """	// ---------- buffs ----------

	public float MoveSpeed
	{
		get
		{
			float slow = 0f;
			foreach (ActiveBuff b in buffs)
			{
				if (b.def.control == MotionControlType.Slow)
				{
					slow = Mathf.Max(slow, b.def.slowRatio);
				}
			}
			return def.moveSpeed * (1f + status.MovingSpeed.ratio) * (1f - slow);
		}
	}

	public bool HasControl(MotionControlType type)
	{
		foreach (ActiveBuff b in buffs)
		{
			if (b.def.control == type)
			{
				return true;
			}
		}
		return false;
	}

	private void TriggerProcs(SkillDef sd, ProcTimingType timing, Fighter target)
	{
		foreach (BuffProc proc in sd.procs)
		{
			if (proc.timing != timing || Random.Range(0, 100) >= proc.rate)
			{
				continue;
			}
			Fighter who = proc.onSelf ? this : target;
			who?.AddBuff(proc.buff, this);
		}
	}

	// linha/rank: buffs da mesma linha nao acumulam; rank maior ou igual substitui e renova a duracao
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
		RecalcStatus();
		if (buff.control == MotionControlType.Stun)
		{
			state = State.Idle;
			m_skill = -1;
			invulnerable = false;
			PlayOnce(def.animHit, buff.duration);
		}
		onBuffAdded?.Invoke(this, active);
		onPopup?.Invoke(this, buff.name, buff.color);
	}

	private void RemoveBuff(ActiveBuff b)
	{
		buffs.Remove(b);
		RecalcStatus();
		onBuffRemoved?.Invoke(this, b);
	}

	private void ClearBuffs()
	{
		for (int i = buffs.Count - 1; i >= 0; i--)
		{
			RemoveBuff(buffs[i]);
		}
	}

	// status efetivo = base + atributos de cada buff (CharStatus.Merge do jogo)
	private void RecalcStatus()
	{
		status.Copy(baseStatus);
		foreach (ActiveBuff b in buffs)
		{
			status.Merge(b.def.stats, 1f);
		}
	}

	private void UpdateBuffs(float dt)
	{
		for (int i = buffs.Count - 1; i >= 0 && i < buffs.Count; i--)
		{
			ActiveBuff b = buffs[i];
			b.remaining -= dt;
			if (b.def.dotPerMaxHp > 0f || b.def.hotPerMaxHp > 0f)
			{
				b.tickTimer += dt;
				while (b.tickTimer >= b.def.period && IsAlive)
				{
					b.tickTimer -= b.def.period;
					if (b.def.dotPerMaxHp > 0f)
					{
						TickDamage(b, Mathf.Max(1, Mathf.RoundToInt(maxHp * b.def.dotPerMaxHp)));
					}
					if (b.def.hotPerMaxHp > 0f)
					{
						hp = Mathf.Min(maxHp, hp + maxHp * b.def.hotPerMaxHp);
					}
				}
			}
			if (!IsAlive)
			{
				return;
			}
			if (b.remaining <= 0f && buffs.Contains(b))
			{
				RemoveBuff(b);
			}
		}
	}

	private void TickDamage(ActiveBuff b, int damage)
	{
		hp -= damage;
		onPopup?.Invoke(this, damage.ToString(), b.def.color);
		if (hp <= 0f)
		{
			hp = 0f;
			state = State.Dead;
			m_stateTime = 0f;
			if (b.source != null && b.source != this)
			{
				b.source.kills++;
			}
			onPopup?.Invoke(this, "K.O.", Color.red);
			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);
			ClearBuffs();
		}
	}

	private void StartControl(Vector3 velocity, float time)"""),
])

# ---------- Vfx: aura continua ----------
patch("Prototype/Vfx.cs", [("""	// ---------- base ----------""", """	// aura em volta do lutador enquanto o buff durar (removida em DestroyAura)
	public static GameObject Aura(Transform owner, string tex, Color color, bool overHead)
	{
		ParticleSystem ps = Create(tex, owner.position, true, 9999f);
		ps.transform.SetParent(owner, true);
		ps.transform.localPosition = overHead ? new Vector3(0f, 1.5f, 0f) : new Vector3(0f, -0.4f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.5f, 0.9f);
		main.startSize = new ParticleSystem.MinMaxCurve(overHead ? 0.3f : 0.25f, overHead ? 0.5f : 0.6f);
		color.a = 0.85f;
		main.startColor = color;
		main.startSpeed = new ParticleSystem.MinMaxCurve(0.2f, overHead ? 0.4f : 1.2f);
		main.simulationSpace = overHead ? ParticleSystemSimulationSpace.Local : ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = overHead ? 6f : 14f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = overHead ? 0.35f : 0.55f;
		shape.rotation = new Vector3(overHead ? 90f : -90f, 0f, 0f);
		if (overHead)
		{
			ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
			rot.enabled = true;
			rot.z = new ParticleSystem.MinMaxCurve(4f);
		}
		ps.Play();
		return ps.gameObject;
	}

	public static void DestroyAura(GameObject aura)
	{
		if (aura == null)
		{
			return;
		}
		int i = s_live.FindIndex(l => l.ps != null && l.ps.gameObject == aura);
		if (i >= 0)
		{
			s_live.RemoveAt(i);
		}
		if (Application.isPlaying)
		{
			Object.Destroy(aura);
		}
		else
		{
			Object.DestroyImmediate(aura);
		}
	}

	// ---------- base ----------""")])

# ---------- BattleManager: aura e UI dos buffs ----------
patch("Prototype/BattleManager.cs", [
    ("""			f.onDeathFx = who => Vfx.Death(who.Position);""", """			f.onDeathFx = who => Vfx.Death(who.Position);
			f.onBuffAdded = (who, b) => b.aura = Vfx.Aura(who.go.transform, b.def.auraTexture, b.def.color, b.def.control == CS.MotionControlType.Stun);
			f.onBuffRemoved = (who, b) => Vfx.DestroyAura(b.aura);"""),
    ("""	private Text m_score;""", """	private Text m_score;
	private Text m_playerBuffs;
	private Text m_enemyBuffs;"""),
    ("""		m_score = Label(""", """		m_playerBuffs = Label(canvas.transform, new Vector2(0f, 1f), new Vector2(30f, -98f), 16, TextAnchor.UpperLeft, new Vector2(420f, 24f));
		m_playerBuffs.rectTransform.pivot = new Vector2(0f, 1f);
		m_enemyBuffs = Label(canvas.transform, new Vector2(1f, 1f), new Vector2(-30f, -98f), 16, TextAnchor.UpperRight, new Vector2(420f, 24f));
		m_enemyBuffs.rectTransform.pivot = new Vector2(1f, 1f);
		m_score = Label("""),
    ("""		m_score.text = $"<b>{player.kills}  x  {enemy.kills}</b>";""", """		m_score.text = $"<b>{player.kills}  x  {enemy.kills}</b>";
		m_playerBuffs.text = BuffText(player);
		m_enemyBuffs.text = BuffText(enemy);"""),
    ("""	private static void DestroyAny(Object o)""", """	private static string BuffText(Fighter f)
	{
		System.Text.StringBuilder sb = new System.Text.StringBuilder();
		foreach (ActiveBuff b in f.buffs)
		{
			string hex = ColorUtility.ToHtmlStringRGB(b.def.color);
			sb.Append($"<color=#{hex}>{(b.def.type == CS.BuffType.Debuff ? "v" : "^")} {b.def.name} {b.remaining:0.0}s</color>   ");
		}
		return sb.ToString();
	}

	private static void DestroyAny(Object o)"""),
])
print("ok")
