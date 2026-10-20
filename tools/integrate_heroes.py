"""Herois reais da wiki (Axie e Spark) + mecanicas: barreira (XShieldBuff), puxar (Pull), golpe em linha,
empurrao para os lados, muralha de pedras, passivas por acerto e 4 skills por heroi."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:90])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


patch("Prototype/FighterDef.cs", [
    ("""			// Eletrocutar: +7,5% de critico (ja somado acima na ficha da wiki? a ficha mostra 7,5%; a passiva soma mais 7,5%)
""", """			// Eletrocutar: a ficha da wiki ja mostra o critico de 7,5% vindo da passiva; a lentidao forte vem pelo proc das skills
"""),
])

patch("Prototype/SkillDef.cs", [
    ("""	public float blinkDistance;       // teleporte (sem dano)""", """	public float blinkDistance;       // teleporte (sem dano)
	public float lineWidth;           // > 0: golpe em linha reta (retangulo de 'range' x 'lineWidth') que atravessa
	public bool pushSideways;         // empurra para o lado da linha (Divisor de Terra)
	public bool rockWall;             // levanta pedras ao longo da linha que bloqueiam a passagem
	public float pullDistance;        // > 0: puxa o alvo para o centro da area a cada acerto (MotionControlType.Pull)"""),
])

patch("Prototype/Buffs.cs", [
    ("""	public float hotPerMaxHp;              // cura por tique (m_fHotHealPerMaxHP)""",
     """	public float hotPerMaxHp;              // cura por tique (m_fHotHealPerMaxHP)
	public float shieldPerMaxHp;           // barreira que absorve dano (XShieldBuff), em fracao da vida maxima"""),
    ("""	public int tickDamage;                 // % da vida maxima x stack, fixado na aplicacao (XBuff 0x1A99238)""",
     """	public int tickDamage;                 // % da vida maxima x stack, fixado na aplicacao (XBuff 0x1A99238)
	public float shield;                   // quanto a barreira ainda absorve"""),
    ("""	public static readonly BuffDef Queimadura = new BuffDef""", """	// ---- herois da wiki ----

	// Axie, Golpe da Terra: DEF +5% e velocidade, acumula 2x, 3s
	public static readonly BuffDef ForcaDaTerra = new BuffDef
	{
		id = 3001, name = "Forca da Terra", type = BuffType.Buff, duration = 3f, line = "forca_terra", maxStack = 2,
		color = new Color(0.85f, 0.6f, 0.3f), auraTexture = "dirt_02",
	}.WithStats(s => { s.PhysicalDefense.value = 0.05f; s.MagicalDefense.value = 0.05f; s.MovingSpeed.ratio = 0.1f; });

	public static readonly BuffDef LentidaoCurta = new BuffDef
	{
		id = 3002, name = "Lento", type = BuffType.Debuff, duration = 1.5f, line = "lentidao",
		control = MotionControlType.Slow, slowRatio = 0.3f, color = new Color(0.4f, 0.7f, 1f), auraTexture = "twirl_03",
	};

	// Axie, Corneta de Guerra: barreira de 10% da vida maxima por 3s
	public static readonly BuffDef BarreiraCorneta = new BuffDef
	{
		id = 3003, name = "Barreira", type = BuffType.Buff, duration = 3f, line = "barreira", shieldPerMaxHp = 0.1f,
		color = new Color(1f, 0.85f, 0.4f), auraTexture = "circle_03",
	};

	// Spark, passiva Eletrocutar: deixa muito lento
	public static readonly BuffDef Eletrocutado = new BuffDef
	{
		id = 3004, name = "Eletrocutado", type = BuffType.Debuff, duration = 1.5f, line = "lentidao", rank = 2,
		control = MotionControlType.Slow, slowRatio = 0.55f, color = new Color(0.45f, 0.85f, 1f), auraTexture = "spark_04",
	};

	// Spark, Relampago: +10% de dano magico, acumula 3x, 4s
	public static readonly BuffDef CargaDePoder = new BuffDef
	{
		id = 3005, name = "Carga de Poder", type = BuffType.Buff, duration = 4f, line = "carga_poder", maxStack = 3,
		color = new Color(0.5f, 0.8f, 1f), auraTexture = "spark_05",
	}.WithStats(s => { s.MagicalDamageAmp.value = 0.1f; });

	public static readonly BuffDef Pressa = new BuffDef
	{
		id = 3006, name = "Pressa", type = BuffType.Buff, duration = 1.5f, line = "pressa",
		color = new Color(0.6f, 1f, 0.8f), auraTexture = "trace_02",
	}.WithStats(s => { s.MovingSpeed.ratio = 0.2f; });

	// "Inconsciente" da wiki = atordoamento (Stun) com a duracao de cada skill
	private static readonly Dictionary<float, BuffDef> s_stuns = new Dictionary<float, BuffDef>();

	public static BuffDef Inconsciente(float duration)
	{
		if (!s_stuns.TryGetValue(duration, out BuffDef b))
		{
			b = new BuffDef
			{
				id = 3100 + s_stuns.Count, name = "Inconsciente", type = BuffType.Debuff, duration = duration, line = "controle",
				control = MotionControlType.Stun, color = new Color(1f, 0.9f, 0.3f), auraTexture = "star_04",
			};
			s_stuns[duration] = b;
		}
		return b;
	}

	public static readonly BuffDef Queimadura = new BuffDef"""),
])

patch("Prototype/Arena.cs", [
    ("""	public readonly List<Vector3> triangleCenters = new List<Vector3>();""",
     """	public readonly List<Vector3> triangleCenters = new List<Vector3>();
	// obstaculos temporarios (pedras do Divisor de Terra): centro, raio e tempo restante
	public readonly List<(Vector3 center, float radius, float life)> blockers = new List<(Vector3, float, float)>();

	public bool IsBlocked(Vector3 from, Vector3 to)
	{
		foreach ((Vector3 center, float radius, float life) b in blockers)
		{
			Vector2 c = new Vector2(b.center.x, b.center.z);
			bool inside = (new Vector2(to.x, to.z) - c).sqrMagnitude < b.radius * b.radius;
			bool wasInside = (new Vector2(from.x, from.z) - c).sqrMagnitude < b.radius * b.radius;
			if (inside && !wasInside)
			{
				return true;
			}
		}
		return false;
	}

	public void UpdateBlockers(float dt)
	{
		for (int i = blockers.Count - 1; i >= 0; i--)
		{
			(Vector3 center, float radius, float life) b = blockers[i];
			b.life -= dt;
			if (b.life <= 0f)
			{
				blockers.RemoveAt(i);
				continue;
			}
			blockers[i] = b;
		}
	}"""),
])

patch("Prototype/Fighter.cs", [
    ("""	public const int DodgeSlot = 3;
	public const int UltSlot = 4;""", """	public const int DodgeSlot = 4;        // 0 = basico, 1..3 = skills A/B/C, 4 = esquiva, 5 = ultimate
	public const int UltSlot = 5;"""),
    ("""	public float ultCharge;                // m_chargePoint do XUltimateSkillCharger""",
     """	public float ultCharge;                // m_chargePoint do XUltimateSkillCharger
	public float passiveTimer;             // recarga interna da passiva"""),
    ("""	// slot 0..2 = skills, 3 = esquiva. Ocupado: esquiva cancela; perto do fim, entra na fila.""",
     """	// slot 0..3 = skills, 4 = esquiva, 5 = ultimate. Ocupado: esquiva cancela; perto do fim, entra na fila."""),
    # pedras bloqueiam passagem (andar, avancos e empurroes)
    ("""		if (arena.TryGetFloor(target, Position.y, out Vector3 snapped))
		{
			go.transform.position = snapped;
		}""", """		if (arena.TryGetFloor(target, Position.y, out Vector3 snapped) && !arena.IsBlocked(Position, snapped))
		{
			go.transform.position = snapped;
		}"""),
    ("""		m_comboTimer = Mathf.Max(0f, m_comboTimer - dt);""", """		m_comboTimer = Mathf.Max(0f, m_comboTimer - dt);
		passiveTimer = Mathf.Max(0f, passiveTimer - dt);"""),
    # golpe sem dano (buff proprio), linha, muralha e puxao
    ("""		onSkillFx?.Invoke(this, sd, center);
		Fighter target = opponent;
		if (target == null || !target.IsAlive || target.invulnerable)
		{
			return;
		}
		Vector3 delta = target.Position - center;
		delta.y = 0f;
		if (delta.magnitude > sd.range + 0.5f || Mathf.Abs(target.Position.y - center.y) > 2.5f)
		{
			return;
		}
		if (sd.angle < 360f && !sd.areaAtTarget && Vector3.Angle(facing, delta) > sd.angle * 0.5f)
		{
			return;
		}
		ResolveHit(target, sd, info, delta.sqrMagnitude > 0.01f ? delta.normalized : facing);""",
     """		onSkillFx?.Invoke(this, sd, center);
		if (sd.rockWall)
		{
			// linha de pedras ao longo da onda de choque, bloqueando a passagem por 4s
			for (float d = 2f; d <= sd.range; d += 1.6f)
			{
				arena.blockers.Add((Position + facing * d, 0.75f, 4f));
			}
		}
		if (sd.damageRatio <= 0f)
		{
			return;                        // skill de efeito proprio (barreira, buff)
		}
		Fighter target = opponent;
		if (target == null || !target.IsAlive || target.invulnerable)
		{
			return;
		}
		Vector3 delta = target.Position - center;
		delta.y = 0f;
		if (Mathf.Abs(target.Position.y - center.y) > 2.5f)
		{
			return;
		}
		if (sd.lineWidth > 0f)
		{
			// retangulo a frente: distancia ao longo da linha e afastamento lateral
			float along = Vector3.Dot(delta, facing);
			float side = Vector3.Cross(facing, delta).y;
			if (along < -0.5f || along > sd.range + 0.5f || Mathf.Abs(side) > sd.lineWidth * 0.5f + 0.4f)
			{
				return;
			}
			Vector3 sideways = Vector3.Cross(Vector3.up, facing) * (side >= 0f ? -1f : 1f);
			ResolveHit(target, sd, info, sd.pushSideways ? sideways : facing);
			return;
		}
		if (delta.magnitude > sd.range + 0.5f)
		{
			return;
		}
		if (sd.angle < 360f && !sd.areaAtTarget && Vector3.Angle(facing, delta) > sd.angle * 0.5f)
		{
			return;
		}
		// puxao: direcao (nao normalizada) do alvo para o centro
		ResolveHit(target, sd, info, sd.pullDistance > 0f ? -delta : (delta.sqrMagnitude > 0.01f ? delta.normalized : facing));"""),
    ("""		if (target.IsAlive)
		{
			TriggerProcs(sd, ProcTimingType.Hit, target);""", """		def.passiveOnHit?.Invoke(this, target, sd, critical);
		if (target.IsAlive)
		{
			TriggerProcs(sd, ProcTimingType.Hit, target);"""),
    # barreira absorve antes da vida
    ("""	public void TakeDamage(Fighter from, int damage, bool critical, Vector3 pushDir, SkillDef sd)
	{
		hp -= damage;""", """	public void TakeDamage(Fighter from, int damage, bool critical, Vector3 pushDir, SkillDef sd)
	{
		damage = AbsorbWithShield(damage);
		hp -= damage;"""),
    ("""		if (sd.airborneHeight <= 0f && sd.knockbackDistance <= 0f && state != State.Controlled && !IsStunned)""",
     """		if (sd.pullDistance > 0f)
		{
			// puxado para o centro da fenda, sem passar do centro
			float dist = Mathf.Min(sd.pullDistance, Mathf.Max(0f, new Vector3(pushDir.x, 0f, pushDir.z).magnitude - 0.4f));
			StartControl(pushDir, dist, 0.25f);
			return;
		}
		if (sd.airborneHeight <= 0f && sd.knockbackDistance <= 0f && state != State.Controlled && !IsStunned)"""),
    ("""	private void Die(Fighter killer)""", """	private int AbsorbWithShield(int damage)
	{
		int absorbed = 0;
		for (int i = buffs.Count - 1; i >= 0 && damage > 0; i--)
		{
			ActiveBuff b = buffs[i];
			if (b.shield <= 0f)
			{
				continue;
			}
			float take = Mathf.Min(b.shield, damage);
			b.shield -= take;
			damage -= (int)take;
			absorbed += (int)take;
			if (b.shield <= 0f)
			{
				RemoveBuff(b);
			}
		}
		if (absorbed > 0)
		{
			onPopup?.Invoke(this, "(" + absorbed + ")", new Color(1f, 0.85f, 0.4f));
		}
		return damage;
	}

	public bool HasBuff(BuffDef buff) => buffs.Exists(b => b.def == buff);

	private void Die(Fighter killer)"""),
    ("""			existing.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp * existing.stack));""",
     """			existing.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp * existing.stack));
			existing.shield = maxHp * buff.shieldPerMaxHp;"""),
    ("""		active.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp));""",
     """		active.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp));
		active.shield = maxHp * buff.shieldPerMaxHp;"""),
])

patch("Prototype/Brains.cs", [
    ("""// Jogador: WASD move; mira com o mouse. J/clique = ataque basico (combo); K/L = segura para ver o indicador,""",
     """// Jogador: WASD move; mira com o mouse. J/clique = ataque basico (combo); K/L/I = segura para ver o indicador,"""),
    ("""		HoldToAim(self, KeyCode.L, 2);""", """		HoldToAim(self, KeyCode.L, 2);
		HoldToAim(self, KeyCode.I, 3);"""),
])

patch("Prototype/BattleManager.cs", [
    ("""		FighterDef machadinha = FighterDef.Machadinha();""", """		FighterDef machadinha = FighterDef.Axie();"""),
    ("""		FighterDef bruxa = FighterDef.Bruxa();""", """		FighterDef bruxa = FighterDef.Spark();"""),
    ("""		Vfx.Update(dt);""", """		Vfx.Update(dt);
		arena.UpdateBlockers(dt);"""),
    ("""		m_cooldownFill = new Image[4];
		string[] keys = { "J", "K", "L", "Espaco" };
		for (int i = 0; i < 4; i++)
		{
			string skillName = i < 3 ? player.def.skills[i].name : player.def.dodge.name;
			RectTransform box = Rect("skill" + i, canvas.transform, new Vector2(0.5f, 0f), new Vector2(-240f + i * 160f, 30f), new Vector2(150f, 70f));""",
     """		m_cooldownFill = new Image[5];
		string[] keys = { "J", "K", "L", "I", "Espaco" };
		for (int i = 0; i < 5; i++)
		{
			string skillName = i < 4 ? player.def.skills[i].name : player.def.dodge.name;
			RectTransform box = Rect("skill" + i, canvas.transform, new Vector2(0.5f, 0f), new Vector2(-256f + i * 128f, 30f), new Vector2(124f, 70f));"""),
    ("""			Image fill = Rect("cd", box, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(150f, 70f)).gameObject.AddComponent<Image>();""",
     """			Image fill = Rect("cd", box, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(124f, 70f)).gameObject.AddComponent<Image>();"""),
    ("""			Text t = Label(box, new Vector2(0.5f, 0.5f), Vector2.zero, 16, TextAnchor.MiddleCenter, new Vector2(150f, 70f));""",
     """			Text t = Label(box, new Vector2(0.5f, 0.5f), Vector2.zero, 14, TextAnchor.MiddleCenter, new Vector2(124f, 70f));"""),
    ("""		help.text = "WASD mover | mouse mira | J ou clique: combo | segure K/L/R para mirar, solte para usar\\nEspaco: esquiva (cancela a skill) | R: ultimate (carrega batendo e apanhando)";""",
     """		help.text = $"WASD mover | mouse mira | J ou clique: combo | segure K/L/I/R para mirar, solte para usar\\nEspaco: esquiva | R: ultimate | Passiva: {player.def.passiveName} - {player.def.passiveDesc}";"""),
    # efeitos novos
    ("""			case "bolt":
				Vfx.Muzzle(owner.Position + owner.facing * 0.7f + Vector3.up * 0.25f, sd.color);
				return;""", """			case "bolt":
				Vfx.Muzzle(owner.Position + owner.facing * 0.7f + Vector3.up * 0.25f, sd.color);
				return;
			case "barrier":
				Vfx.Barrier(owner.Position, sd.color);
				return;
			case "lightning":
				Vfx.Lightning(ground, sd.color, sd.range);
				return;
			case "wave":
				Vfx.Wave(owner.Position, owner.facing, sd.color, sd.range);
				return;
			case "rupture":
				Vfx.Rupture(ground, sd.color, sd.range);
				return;
			case "terrasplitter":
				Vfx.TerraSplitter(owner.Position + Vector3.down * Arena.CenterHeight, owner.facing, sd.color, sd.range);
				return;"""),
])

patch("Prototype/Vfx.cs", [
    ("""	// aviso no chao durante a preparacao da skill (o jogo original tambem marcava areas)""",
     """	// ---------- herois da wiki ----------

	public static void Barrier(Vector3 pos, Color color)
	{
		Cfx("CFXR3 Shield Leaves A (Lit)", pos + Vector3.down * 0.9f, 1.2f, 1.5f);
		ParticleSystem ring = Single("circle_03", pos + Vector3.down * 0.9f, color, 3f, 0.6f, true, 0f);
		Grow(ring, 0.4f, 1.2f);
		Burst("star_06", pos + Vector3.up * 0.5f, color, 14, 0.7f, 0.2f, 0.5f, true);
	}

	public static void Lightning(Vector3 groundPos, Color color, float radius)
	{
		Cfx("CFXR3 Hit Electric C (Air)", groundPos + Vector3.up * 0.5f, 1.3f, 1.2f);
		LineRenderer line = new GameObject("vfx_raio").AddComponent<LineRenderer>();
		line.material = Mat("trace_01", true);
		line.positionCount = 6;
		for (int i = 0; i < 6; i++)
		{
			Vector2 r = Random.insideUnitCircle * 0.35f;
			line.SetPosition(i, groundPos + new Vector3(r.x, 9f - i * 1.8f, r.y));
		}
		line.widthMultiplier = 0.7f;
		line.startColor = line.endColor = color;
		s_live.Add(new Live { line = line, life = 0.2f, total = 0.2f });
		Flash(groundPos + Vector3.up * 0.6f, color, radius * 1.6f);
		Sparks(groundPos + Vector3.up * 0.3f, color, 16, 6f, 0.35f);
	}

	public static void Wave(Vector3 pos, Vector3 facing, Color color, float range)
	{
		Cfx("CFXR Electrified 3", pos + facing * range * 0.5f, 1.2f, 1.2f);
		ParticleSystem ps = Single("trace_06", pos + facing * range * 0.5f, color, range * 1.8f, 0.3f, true, Angle(facing) + 90f);
		Grow(ps, 0.5f, 1.2f);
		Sparks(pos + facing * range * 0.6f, color, 20, 7f, 0.4f);
	}

	public static void Rupture(Vector3 groundPos, Color color, float radius)
	{
		Cfx("CFXR3 Hit Electric C (Air)", groundPos + Vector3.up * 0.7f, 1f, 1f);
		ParticleSystem ps = Single("twirl_02", groundPos + Vector3.up * 0.1f, color, radius * 2.2f, 0.35f, true, Random.Range(0f, 360f));
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(8f);
		Grow(ps, 1.1f, 0.4f);   // encolhe: suga para o centro
	}

	public static void TerraSplitter(Vector3 groundPos, Vector3 facing, Color color, float range)
	{
		for (float d = 1.2f; d <= range; d += 1.6f)
		{
			Vector3 p = groundPos + facing * d;
			Cfx("CFXR2 Ground Hit", p, 0.7f, 1.5f);
			Rock(p, 4f);
		}
		Cfx("CFXR _BOOM_", groundPos + facing * 2f + Vector3.up * 1.6f, 0.9f, 1.2f);
	}

	// pedra que sobe do chao e afunda no fim (visual do obstaculo do Arena.blockers)
	private static readonly List<(Transform t, float life, float total, float height, float groundY)> s_rocks = new List<(Transform, float, float, float, float)>();

	private static void Rock(Vector3 groundPos, float life)
	{
		GameObject rock = GameObject.CreatePrimitive(PrimitiveType.Cube);
		Object.DestroyImmediate(rock.GetComponent<Collider>());
		rock.name = "pedra";
		float h = Random.Range(1.1f, 1.6f);
		rock.transform.position = groundPos + Vector3.down * h;
		rock.transform.rotation = Quaternion.Euler(Random.Range(-15f, 15f), Random.Range(0f, 360f), Random.Range(-15f, 15f));
		rock.transform.localScale = new Vector3(Random.Range(0.9f, 1.3f), h, Random.Range(0.9f, 1.3f));
		rock.GetComponent<Renderer>().material = Arena.MakeMaterial(new Color(0.42f, 0.36f, 0.3f));
		s_rocks.Add((rock.transform, life, life, h, groundPos.y));
	}

	// sobe rapido (0,15s) e afunda nos ultimos 0,4s
	private static void UpdateRocks(float dt)
	{
		for (int i = s_rocks.Count - 1; i >= 0; i--)
		{
			(Transform t, float life, float total, float height, float groundY) r = s_rocks[i];
			r.life -= dt;
			if (r.t == null || r.life <= 0f)
			{
				if (r.t != null)
				{
					if (Application.isPlaying)
					{
						Object.Destroy(r.t.gameObject);
					}
					else
					{
						Object.DestroyImmediate(r.t.gameObject);
					}
				}
				s_rocks.RemoveAt(i);
				continue;
			}
			float up = Mathf.Clamp01((r.total - r.life) / 0.15f) * Mathf.Clamp01(r.life / 0.4f);
			Vector3 p = r.t.position;
			r.t.position = new Vector3(p.x, r.groundY + up * r.height - r.height * 0.5f, p.z);
			s_rocks[i] = r;
		}
	}

	// aviso no chao durante a preparacao da skill (o jogo original tambem marcava areas)"""),
])
patch("Prototype/Vfx.cs", [
    ("""	public static void Update(float dt)
	{""", """	public static void Update(float dt)
	{
		UpdateRocks(dt);"""),
    ("""		s_live.Clear();
		s_materials.Clear();""", """		s_live.Clear();
		s_materials.Clear();
		s_rocks.Clear();"""),
])
print("ok")
