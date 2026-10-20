"""Pacote 2: ultimate com carga (regras do XUltimateSkillCharger), skills multi-hit, superarmadura e bot mais esperto."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:90])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


patch("Prototype/SkillDef.cs", [("""	public float hitstop = 0.05f;     // congela o jogo no impacto (peso do golpe)""", """	public float hitstop = 0.05f;     // congela o jogo no impacto (peso do golpe)
	public int hitCount = 1;          // golpes repetidos depois do windup (ultimates)
	public float hitInterval = 0.3f;
	public float areaJitter;          // espalha cada golpe de area em volta da mira (chuva)
	public bool superArmor;           // nao e interrompida nem empurrada (ultimates)""")])

# ---------- FighterDef: ultimates ----------
patch("Prototype/FighterDef.cs", [
    ("""	public SkillDef dodge;""", """	public SkillDef dodge;
	public SkillDef ultimate;
	public float ultMaxCharge = 2600f;     // m_maxCharge do XUltimateSkillCharger (pontos de dano)"""),
    ("""			dodge = new SkillDef { name = "Rolamento", vfx = "dust", anim = "Dodge_Forward", cooldown = 3f, windup = 0f, recovery = 0.3f, dashDistance = 4.5f, damageRatio = 0f },""",
     """			dodge = new SkillDef { name = "Rolamento", vfx = "dust", anim = "Dodge_Forward", cooldown = 3f, windup = 0f, recovery = 0.3f, dashDistance = 4.5f, damageRatio = 0f },
			ultimate = new SkillDef
			{
				name = "Tornado de Machados", vfx = "spin", anim = "2H_Melee_Attack_Spin", damageRatio = 0.95f, cooldown = 1f, windup = 0.3f,
				hitCount = 6, hitInterval = 0.32f, recovery = 0.35f, range = 3.6f, angle = 360f, movable = true, superArmor = true, cancelable = false,
				color = new Color(1f, 0.25f, 0.05f), hitstop = 0.06f, shake = 0.25f, bonusAttackRatio = 0.15f,
				procs = { new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Sangramento } },
			},"""),
    ("""			dodge = new SkillDef
			{
				name = "Teleporte",""", """			ultimate = new SkillDef
			{
				name = "Chuva Arcana", vfx = "burst", anim = "Spellcast_Long", damageType = (SkillDamageTypes)2, damageRatio = 1.1f, cooldown = 1f,
				windup = 0.6f, hitCount = 5, hitInterval = 0.3f, recovery = 0.4f, range = 2.4f, angle = 360f, areaAtTarget = true, castRange = 9f,
				areaJitter = 2.2f, superArmor = true, cancelable = false, airborneHeight = 1.2f, color = new Color(0.85f, 0.35f, 1f),
				hitstop = 0.07f, shake = 0.3f, bonusAttackRatio = 0.15f,
				procs = { new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Lentidao }, burnOnCrit },
			},
			dodge = new SkillDef
			{
				name = "Teleporte","""),
])

# ---------- Fighter ----------
patch("Prototype/Fighter.cs", [
    ("""	public const int DodgeSlot = 3;""", """	public const int DodgeSlot = 3;
	public const int UltSlot = 4;"""),
    ("""	public System.Action<SkillDef, bool> onImpact;                                      // hitstop/tremor""", """	public System.Action<SkillDef, bool> onImpact;                                      // hitstop/tremor
	public System.Action<Fighter, SkillDef> onUltimate;                                 // camera lenta/zoom na ativacao"""),
    ("""	public bool invulnerable;
""", """	public bool invulnerable;
	public float ultCharge;                // m_chargePoint do XUltimateSkillCharger
"""),
    ("""	private float m_flash;
""", """	private float m_flash;
	private int m_hitsDone;
	private bool m_ultHitCharge;           // EnableHitCharge: so o primeiro acerto de cada skill carrega
"""),
    ("""	public int ComboStep => m_comboTimer > 0f ? m_comboStep : 0;""", """	public int ComboStep => m_comboTimer > 0f ? m_comboStep : 0;
	public bool UltReady => ultCharge >= def.ultMaxCharge;           // CheckActivate
	public float UltPercent => Mathf.Clamp01(ultCharge / def.ultMaxCharge);
	public Vector3 CurrentAim => m_aim;
	public float CastProgress => m_sd != null && state == State.Casting ? m_stateTime / Mathf.Max(0.01f, m_sd.windup) : 0f;"""),
    ("""		cooldowns = new float[def.skills.Length + 1];""", """		cooldowns = new float[def.skills.Length + 2];"""),
    ("""	public SkillDef SlotSkill(int slot) => slot < def.skills.Length ? def.skills[slot] : def.dodge;""",
     """	public SkillDef SlotSkill(int slot) => slot < def.skills.Length ? def.skills[slot] : slot == UltSlot ? def.ultimate : def.dodge;"""),
    # ult so com a barra cheia
    ("""		if (!CanAct || cooldowns[slot] > 0f)
		{
			return false;
		}
		Execute(slot, aim);""", """		if (!CanAct || cooldowns[slot] > 0f || (slot == UltSlot && (def.ultimate == null || !UltReady)))
		{
			return false;
		}
		Execute(slot, aim);"""),
    ("""		cooldowns[slot] = sd.cooldown;
		PlayOnce(sd.anim, Mathf.Max(0.2f, sd.windup + sd.recovery));""", """		cooldowns[slot] = sd.cooldown;
		m_hitsDone = 0;
		m_ultHitCharge = slot != UltSlot;
		if (slot == UltSlot)
		{
			ultCharge = 0f;                // Use()
			onUltimate?.Invoke(this, sd);
		}
		PlayOnce(sd.anim, Mathf.Max(0.2f, sd.windup + (sd.hitCount - 1) * sd.hitInterval + sd.recovery));"""),
    # multi-hit no UpdateCast
    ("""		if (m_slot != DodgeSlot)
		{
			ReleaseHit(sd, InfoFor(sd));
		}
		state = State.Recovering;
		m_stateTime = 0f;""", """		if (m_slot != DodgeSlot)
		{
			// golpes repetidos: o k-esimo sai em windup + k*intervalo
			while (m_hitsDone < sd.hitCount && m_stateTime >= release + m_hitsDone * sd.hitInterval)
			{
				ReleaseHit(sd, InfoFor(sd));
				m_hitsDone++;
			}
			if (m_hitsDone < sd.hitCount)
			{
				return;
			}
		}
		state = State.Recovering;
		m_stateTime = 0f;"""),
    ("""		if (sd.areaAtTarget)
		{
			Vector3 to = m_aim - Position;
			to.y = 0f;
			center = Position + Vector3.ClampMagnitude(to, sd.castRange);
		}
		onSkillFx?.Invoke(this, sd, center);
		Fighter target = opponent;""", """		if (sd.areaAtTarget)
		{
			Vector3 to = m_aim - Position;
			to.y = 0f;
			center = Position + Vector3.ClampMagnitude(to, sd.castRange);
			if (sd.areaJitter > 0f)
			{
				Vector2 r = Random.insideUnitCircle * sd.areaJitter;
				center += new Vector3(r.x, 0f, r.y);
			}
		}
		onSkillFx?.Invoke(this, sd, center);
		Fighter target = opponent;"""),
    # carga ao acertar / ao apanhar
    ("""		onImpact?.Invoke(sd, critical);
		target.TakeDamage(this, damage, critical, pushDir, sd);""", """		onImpact?.Invoke(sd, critical);
		if (m_ultHitCharge)
		{
			ultCharge = Mathf.Min(def.ultMaxCharge, ultCharge + damage);      // ChargeOnHit
			m_ultHitCharge = false;
		}
		target.ChargeOnBeaten(damage);
		target.TakeDamage(this, damage, critical, pushDir, sd);"""),
    ("""	public void TakeDamage(Fighter from, int damage, bool critical, Vector3 pushDir, SkillDef sd)
	{""", """	// ChargeOnBeaten: min(dano/vidaMax * 0.2, 0.05) da barra por golpe recebido
	public void ChargeOnBeaten(int damage)
	{
		if (def.ultimate == null || (m_slot == UltSlot && IsBusy))
		{
			return;
		}
		ultCharge = Mathf.Min(def.ultMaxCharge, ultCharge + Mathf.Min(damage / maxHp * 0.2f, 0.05f) * def.ultMaxCharge);
	}

	public void TakeDamage(Fighter from, int damage, bool critical, Vector3 pushDir, SkillDef sd)
	{"""),
    # superarmadura: nao interrompe nem empurra
    ("""		float weight = status.Weight.Calc();
		float toughness = status.Toughness.Calc();
		// tempos de controle""", """		if (IsBusy && m_sd != null && m_sd.superArmor)
		{
			return;
		}
		float weight = status.Weight.Calc();
		float toughness = status.Toughness.Calc();
		// tempos de controle"""),
    # ult nao some ao morrer, mas a carga zera no renascer como no original? (mantem a carga)
])

# ---------- Brains ----------
patch("Prototype/Brains.cs", [
    ("""		HoldToAim(self, KeyCode.K, 1);
		HoldToAim(self, KeyCode.L, 2);""", """		HoldToAim(self, KeyCode.K, 1);
		HoldToAim(self, KeyCode.L, 2);
		HoldToAim(self, KeyCode.R, Fighter.UltSlot);"""),
    ("""	private List<Vector3> m_path = new List<Vector3>();
	private float m_repath;

	public BotBrain(int seed)
	{
		m_rng = new System.Random(seed);
	}""", """	private List<Vector3> m_path = new List<Vector3>();
	private float m_repath;

	// projeteis vivos (posicao, direcao, dono) para o bot desviar
	public System.Func<IEnumerable<(Vector3 pos, Vector3 dir, Fighter owner)>> projectiles;

	public BotBrain(int seed)
	{
		m_rng = new System.Random(seed);
	}

	// perigo: area do inimigo em preparo sobre mim, ou projetil vindo na minha direcao
	private bool Danger(Fighter self, Fighter enemy, out Vector3 escape)
	{
		escape = Vector3.zero;
		SkillDef cast = enemy.state == Fighter.State.Casting ? enemy.CurrentSkill : null;
		if (cast != null && cast.damageRatio > 0f)
		{
			Vector3 center = enemy.Position;
			if (cast.areaAtTarget)
			{
				Vector3 to = enemy.CurrentAim - enemy.Position;
				to.y = 0f;
				center = enemy.Position + Vector3.ClampMagnitude(to, cast.castRange);
			}
			Vector3 away = self.Position - center;
			away.y = 0f;
			bool inArea = away.magnitude < cast.range + cast.areaJitter + 0.8f;
			bool inCone = cast.angle >= 360f || cast.areaAtTarget || Vector3.Angle(enemy.facing, -away * -1f) < cast.angle * 0.5f + 15f;
			if (inArea && inCone && cast.projectileSpeed <= 0f)
			{
				escape = away.sqrMagnitude > 0.01f ? away.normalized : Vector3.Cross(Vector3.up, enemy.facing);
				return true;
			}
		}
		if (projectiles != null)
		{
			foreach ((Vector3 pos, Vector3 dir, Fighter owner) p in projectiles())
			{
				if (p.owner == self)
				{
					continue;
				}
				Vector3 rel = self.Position - p.pos;
				rel.y = 0f;
				float along = Vector3.Dot(rel, p.dir);
				float side = Vector3.Cross(p.dir, rel).y;
				if (along > 0f && along < 6f && Mathf.Abs(side) < 1.3f)
				{
					escape = Vector3.Cross(Vector3.up, p.dir) * (side >= 0f ? -1f : 1f);
					return true;
				}
			}
		}
		return false;
	}"""),
    # comportamento: foge do perigo antes de atacar; usa ult; bruxa foge quando encostada
    ("""		// reage a um golpe vindo: esquiva (cancela a propria skill) com alguma chance
		if (enemy.state == Fighter.State.Casting && dist < 5f && m_reaction <= 0f)
		{
			m_reaction = 0.6f;
			if (Rand() < 0.3f && self.TryUseSkill(Fighter.DodgeSlot, self.Position + Vector3.Cross(Vector3.up, to).normalized * m_strafeSign))
			{
				return;
			}
		}
		if (!self.CanAct && !self.IsBusy)
		{
			return;
		}""", """		if (!self.CanAct && !self.IsBusy)
		{
			return;
		}
		// perigo: sai da area/linha de tiro andando; as vezes usa a esquiva (cancelando a propria skill)
		if (Danger(self, enemy, out Vector3 escape))
		{
			if (m_reaction <= 0f && Rand() < 0.45f && self.TryUseSkill(Fighter.DodgeSlot, self.Position + escape))
			{
				m_reaction = 0.8f;
				return;
			}
			if (self.CanAct)
			{
				self.Move(escape, dt);
				return;
			}
		}
		// ultimate cheia e alvo no alcance
		if (self.UltReady && self.def.ultimate != null)
		{
			SkillDef ult = self.def.ultimate;
			float reach = ult.areaAtTarget ? ult.castRange : ult.range + 1f;
			if (dist <= reach && self.TryUseSkill(Fighter.UltSlot, enemy.Position))
			{
				return;
			}
		}
		// lutador a distancia encostado: teleporta para longe
		bool ranged = self.def.skills[0].projectileSpeed > 0f;
		if (ranged && dist < 2.5f && m_reaction <= 0f && Rand() < 0.04f)
		{
			m_reaction = 1f;
			if (self.TryUseSkill(Fighter.DodgeSlot, self.Position - to.normalized * 3f))
			{
				return;
			}
		}"""),
    ("""		float preferred = Mathf.Min(self.def.skills[0].range * 0.75f, 6f);""",
     """		float preferred = ranged ? 6.5f : self.def.skills[0].range * 0.75f;"""),
])

# ---------- BattleManager ----------
patch("Prototype/BattleManager.cs", [
    ("""		m_enemyBrain = new BotBrain(42);""", """		m_enemyBrain = new BotBrain(42) { projectiles = LiveProjectiles };
		if (m_playerBrain is BotBrain playerBot)
		{
			playerBot.projectiles = LiveProjectiles;
		}"""),
    ("""			f.onProjectile = SpawnProjectile;""", """			f.onProjectile = SpawnProjectile;
			f.onUltimate = (who, sd) =>
			{
				m_ultFocus = who;
				m_ultTime = 0.9f;
				m_hitstop = Mathf.Max(m_hitstop, 0.35f);   // camera lenta na ativacao
				m_shake = Mathf.Max(m_shake, 0.2f);
				Popup(who, sd.name.ToUpper() + "!", sd.color);
			};"""),
    ("""	private readonly List<Projectile> m_projectiles = new List<Projectile>();""", """	private readonly List<Projectile> m_projectiles = new List<Projectile>();
	private Fighter m_ultFocus;
	private float m_ultTime;
	private Image m_ultFill;
	private Text m_ultText;

	private IEnumerable<(Vector3 pos, Vector3 dir, Fighter owner)> LiveProjectiles()
	{
		foreach (Projectile p in m_projectiles)
		{
			yield return (p.go.transform.position, p.dir, p.owner);
		}
	}"""),
    # zoom de camera na ultimate
    ("""		Vector3 want = focus + new Vector3(0f, 8.5f, -7.5f);""", """		m_ultTime = Mathf.Max(0f, m_ultTime - Time.unscaledDeltaTime);
		if (m_ultTime > 0f && m_ultFocus != null && m_ultFocus.IsAlive)
		{
			focus = Vector3.Lerp(focus, m_ultFocus.Position, 0.7f);
		}
		Vector3 want = focus + (m_ultTime > 0f ? new Vector3(0f, 5.5f, -5f) : new Vector3(0f, 8.5f, -7.5f));"""),
    # barra da ultimate
    ("""		Text help = Label(canvas.transform""", """		RectTransform ultBack = Rect("ult", canvas.transform, new Vector2(0.5f, 0f), new Vector2(0f, 112f), new Vector2(630f, 18f));
		ultBack.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.7f);
		m_ultFill = Rect("fill", ultBack, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(624f, 12f)).gameObject.AddComponent<Image>();
		m_ultFill.type = Image.Type.Filled;
		m_ultFill.fillMethod = Image.FillMethod.Horizontal;
		m_ultText = Label(ultBack, new Vector2(0.5f, 0.5f), new Vector2(0f, 18f), 16, TextAnchor.MiddleCenter, new Vector2(630f, 22f));
		Text help = Label(canvas.transform"""),
    ("""		if (player.ComboStep > 0 && player.SlotSkill(0).combo != null)""", """		m_ultFill.fillAmount = player.UltPercent;
		bool ready = player.UltReady;
		float pulse = ready ? 0.75f + 0.25f * Mathf.Sin(Time.unscaledTime * 8f) : 1f;
		m_ultFill.color = ready ? new Color(1f, 0.8f * pulse, 0.2f) : new Color(0.9f, 0.55f, 0.15f, 0.85f);
		m_ultText.text = ready ? $"<b>R: {player.def.ultimate.name} PRONTA!</b>" : $"Ultimate {Mathf.FloorToInt(player.UltPercent * 100f)}%";
		if (player.ComboStep > 0 && player.SlotSkill(0).combo != null)"""),
    ("""		help.text = "WASD mover | mouse mira | J ou clique: combo | segure K/L para mirar, solte para usar\\nEspaco: esquiva (cancela a skill) | dano, acerto, critico e buffs: regras reconstruidas do jogo";""",
     """		help.text = "WASD mover | mouse mira | J ou clique: combo | segure K/L/R para mirar, solte para usar\\nEspaco: esquiva (cancela a skill) | R: ultimate (carrega batendo e apanhando)";"""),
])

# captura: registra ultimate no log
patch("Editor/Reconstruction/PrototypeSetup.cs", [(""" pdef {bm.enemy.status.PhysicalDefense.Calc():0.00}");""",
                                                   """ pdef {bm.enemy.status.PhysicalDefense.Calc():0.00} ult {bm.player.UltPercent:P0}/{bm.enemy.UltPercent:P0} {bm.player.CurrentSkillName}/{bm.enemy.CurrentSkillName}");""")])
print("ok")
