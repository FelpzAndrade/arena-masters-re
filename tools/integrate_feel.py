"""Pacote de fluidez: projeteis, indicadores de mira, hitstop, tremor de camera, colisao entre lutadores."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:80])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


# ---------------- Vfx: projetil e disparo ----------------
patch("Prototype/Vfx.cs", [("""	// aura em volta do lutador""", """	// projetil: nucleo brilhante + rastro de particulas (seguem o objeto do projetil)
	public static void ProjectileVisual(GameObject owner, Color color)
	{
		ParticleSystem core = Create("light_01", owner.transform.position, true, 9999f);
		core.transform.SetParent(owner.transform, false);
		core.transform.localPosition = Vector3.zero;
		ParticleSystem.MainModule main = core.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = 0.12f;
		main.startSize = 1.1f;
		main.startColor = color;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = core.emission;
		em.rateOverTime = 40f;
		core.Play();
		ParticleSystem trail = Create("magic_02", owner.transform.position, true, 9999f);
		trail.transform.SetParent(owner.transform, false);
		trail.transform.localPosition = Vector3.zero;
		ParticleSystem.MainModule tm = trail.main;
		tm.loop = true;
		tm.duration = 1f;
		tm.startLifetime = new ParticleSystem.MinMaxCurve(0.2f, 0.35f);
		tm.startSize = new ParticleSystem.MinMaxCurve(0.2f, 0.45f);
		tm.startColor = color;
		tm.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		ParticleSystem.EmissionModule tem = trail.emission;
		tem.rateOverTime = 0f;
		tem.rateOverDistance = 12f;
		trail.Play();
	}

	public static void ReleaseProjectileVisual(GameObject owner)
	{
		foreach (ParticleSystem ps in owner.GetComponentsInChildren<ParticleSystem>())
		{
			DestroyAura(ps.gameObject);
		}
	}

	public static void Muzzle(Vector3 pos, Color color)
	{
		Flash(pos, color, 1.2f);
		Burst("magic_04", pos, color, 8, 0.25f, 0.1f, 0.3f, true);
	}

	public static void Impact(Vector3 pos, Color color)
	{
		Flash(pos, color, 1.8f);
		Burst("spark_04", pos, color, 14, 0.3f, 0.15f, 0.4f, true);
	}

	// aura em volta do lutador""")])

# ---------------- BattleManager ----------------
bm = [
    ("""	private IBrain m_playerBrain;""", """	private class Projectile
	{
		public Fighter owner;
		public SkillDef sd;
		public CS.CSSkillInfo info;
		public Vector3 dir;
		public float traveled;
		public GameObject go;
	}

	private readonly List<Projectile> m_projectiles = new List<Projectile>();
	private float m_hitstop;
	private float m_shake;
	private Vector3 m_camBase;
	private GameObject m_indicator;
	private MeshFilter m_indicatorMesh;
	private MeshRenderer m_indicatorRenderer;
	private GameObject m_rangeRing;
	private SkillDef m_indicatorSkill;
	private IBrain m_playerBrain;"""),
    # brains depois da camera (o jogador mira com o mouse)
    ("""		m_playerBrain = playerControlled ? (IBrain)new PlayerBrain() : new BotBrain(7);
		m_enemyBrain = new BotBrain(42);

		cam = new GameObject("Camera").AddComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.03f, 0.03f, 0.05f);
		cam.fieldOfView = 45f;""", """		cam = new GameObject("Camera").AddComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.03f, 0.03f, 0.05f);
		cam.fieldOfView = 45f;
		m_playerBrain = playerControlled ? (IBrain)new PlayerBrain(cam) : new BotBrain(7);
		m_enemyBrain = new BotBrain(42);
		BuildIndicator();"""),
    ("""			f.onBuffRemoved = (who, b) => Vfx.DestroyAura(b.aura);""", """			f.onBuffRemoved = (who, b) => Vfx.DestroyAura(b.aura);
			f.onProjectile = SpawnProjectile;
			f.onImpact = (sd, crit) =>
			{
				m_hitstop = Mathf.Max(m_hitstop, sd.hitstop * (crit ? 1.8f : 1f));
				m_shake = Mathf.Max(m_shake, sd.shake + (crit ? 0.15f : 0f));
			};"""),
    # loop: hitstop congela tudo (timeScale no Play; na captura so pula a simulacao)
    ("""	private void Update()
	{
		Step(Mathf.Min(Time.deltaTime, 0.05f));
	}

	public void Step(float dt)
	{""", """	private void Update()
	{
		if (m_hitstop > 0f)
		{
			m_hitstop -= Time.unscaledDeltaTime;
			Time.timeScale = m_hitstop > 0f ? 0.03f : 1f;
		}
		Step(Mathf.Min(Time.deltaTime, 0.05f));
	}

	private void OnDisable()
	{
		Time.timeScale = 1f;
	}

	public void Step(float dt)
	{
		if (!Application.isPlaying && m_hitstop > 0f)
		{
			m_hitstop -= dt;
			dt *= 0.03f;
		}"""),
    ("""		player.Tick(dt);
		enemy.Tick(dt);""", """		player.Tick(dt);
		enemy.Tick(dt);
		Separate();
		UpdateProjectiles(dt);
		UpdateIndicator();"""),
    # camera com tremor
    ("""		cam.transform.position = Vector3.Lerp(cam.transform.position, want, Mathf.Clamp01(dt * 5f));
		cam.transform.rotation = Quaternion.LookRotation(focus - want);""", """		m_camBase = Vector3.Lerp(m_camBase == Vector3.zero ? want : m_camBase, want, Mathf.Clamp01(dt * 5f));
		m_shake = Mathf.Max(0f, m_shake - Time.unscaledDeltaTime * 1.6f);
		Vector3 jitter = m_shake > 0f ? Random.insideUnitSphere * m_shake * 0.35f : Vector3.zero;
		cam.transform.position = m_camBase + jitter;
		cam.transform.rotation = Quaternion.LookRotation(focus - want);"""),
    # efeito do disparo
    ("""			case "teleport":
				Vfx.Teleport(owner.Position, owner.def.color);
				return;
		}
		GameObject disc""", """			case "teleport":
				Vfx.Teleport(owner.Position, owner.def.color);
				return;
			case "bolt":
				Vfx.Muzzle(owner.Position + owner.facing * 0.7f + Vector3.up * 0.25f, sd.color);
				return;
		}
		GameObject disc"""),
    # sistemas novos
    ("""	private void Popup(Fighter who, string text, Color color)""", """	// ---------- projeteis (podem ser esquivados) ----------

	private void SpawnProjectile(Fighter owner, SkillDef sd, CS.CSSkillInfo info, Vector3 origin, Vector3 dir)
	{
		GameObject go = new GameObject("projetil_" + sd.name);
		go.transform.position = origin;
		Vfx.ProjectileVisual(go, sd.color);
		m_projectiles.Add(new Projectile { owner = owner, sd = sd, info = info, dir = dir.normalized, go = go });
	}

	private void UpdateProjectiles(float dt)
	{
		for (int i = m_projectiles.Count - 1; i >= 0; i--)
		{
			Projectile p = m_projectiles[i];
			float step = p.sd.projectileSpeed * dt;
			Vector3 pos = p.go.transform.position + p.dir * step;
			p.traveled += step;
			p.go.transform.position = pos;
			Fighter target = p.owner.opponent;
			bool done = false;
			if (target != null && target.IsAlive && !target.invulnerable)
			{
				Vector3 d = target.Position - pos;
				float dy = Mathf.Abs(d.y);
				d.y = 0f;
				if (d.magnitude < p.sd.projectileRadius + 0.5f && dy < 2f)
				{
					p.owner.ResolveHit(target, p.sd, p.info, p.dir);
					Vfx.Impact(pos, p.sd.color);
					done = true;
				}
			}
			// bate em parede/borda: sem chao proximo abaixo do projetil
			if (!done && arena.FloorBelow(pos, pos.y + 0.3f) is float floorY && pos.y - floorY > 3f)
			{
				done = true;
			}
			if (!done && arena.FloorBelow(pos, pos.y + 0.3f) == null)
			{
				Vfx.Impact(pos, p.sd.color);
				done = true;
			}
			if (!done && p.traveled >= p.sd.range)
			{
				Vfx.Muzzle(pos, p.sd.color);
				done = true;
			}
			if (done)
			{
				Vfx.ReleaseProjectileVisual(p.go);
				DestroyAny(p.go);
				m_projectiles.RemoveAt(i);
			}
		}
	}

	// ---------- colisao entre lutadores ----------

	private void Separate()
	{
		if (!player.IsAlive || !enemy.IsAlive)
		{
			return;
		}
		Vector3 d = enemy.Position - player.Position;
		d.y = 0f;
		float dist = d.magnitude;
		const float minDist = 1.1f;
		if (dist < minDist && Mathf.Abs(enemy.Position.y - player.Position.y) < 1.5f)
		{
			Vector3 n = dist > 0.001f ? d / dist : Vector3.right;
			float push = (minDist - dist) * 0.5f;
			player.Nudge(-n * push);
			enemy.Nudge(n * push);
		}
	}

	// ---------- indicador de mira (segurar K/L) ----------

	private void BuildIndicator()
	{
		Material mat = new Material(Shader.Find("Sprites/Default"));
		m_indicator = new GameObject("indicador");
		m_indicatorMesh = m_indicator.AddComponent<MeshFilter>();
		m_indicatorRenderer = m_indicator.AddComponent<MeshRenderer>();
		m_indicatorRenderer.sharedMaterial = mat;
		m_indicator.SetActive(false);
		m_rangeRing = new GameObject("alcance");
		LineRenderer ring = m_rangeRing.AddComponent<LineRenderer>();
		ring.material = mat;
		ring.loop = true;
		ring.widthMultiplier = 0.06f;
		ring.positionCount = 48;
		m_rangeRing.SetActive(false);
	}

	private void UpdateIndicator()
	{
		PlayerBrain brain = m_playerBrain as PlayerBrain;
		SkillDef sd = brain != null && player.IsAlive ? brain.AimingSkill : null;
		m_indicator.SetActive(sd != null);
		m_rangeRing.SetActive(sd != null && sd.areaAtTarget);
		if (sd == null)
		{
			return;
		}
		Color c = sd.color;
		c.a = 0.35f;
		if (m_indicatorSkill != sd)
		{
			m_indicatorSkill = sd;
			bool circle = sd.areaAtTarget || sd.angle >= 360f;
			float length = sd.range + sd.dashDistance;
			m_indicatorMesh.sharedMesh = circle ? SectorMesh(360f, sd.range) : SectorMesh(Mathf.Max(sd.angle, 12f), length);
			m_indicatorRenderer.sharedMaterial.color = c;
		}
		Vector3 feet = player.Position + Vector3.down * (Arena.CenterHeight - 0.08f);
		Vector3 aim = brain.AimPoint - player.Position;
		aim.y = 0f;
		if (sd.areaAtTarget)
		{
			Vector3 center = feet + Vector3.ClampMagnitude(aim, sd.castRange);
			m_indicator.transform.position = center;
			m_indicator.transform.rotation = Quaternion.identity;
			LineRenderer ring = m_rangeRing.GetComponent<LineRenderer>();
			ring.startColor = ring.endColor = c;
			for (int i = 0; i < ring.positionCount; i++)
			{
				float a = i * Mathf.PI * 2f / ring.positionCount;
				ring.SetPosition(i, feet + new Vector3(Mathf.Cos(a), 0f, Mathf.Sin(a)) * sd.castRange);
			}
		}
		else
		{
			m_indicator.transform.position = feet;
			m_indicator.transform.rotation = aim.sqrMagnitude > 0.01f ? Quaternion.LookRotation(aim.normalized) : Quaternion.LookRotation(player.facing);
		}
	}

	// setor circular no plano XZ apontando para +Z (360 = circulo)
	private static Mesh SectorMesh(float angle, float radius)
	{
		int segments = Mathf.Max(6, Mathf.CeilToInt(angle / 6f));
		Vector3[] v = new Vector3[segments + 2];
		int[] t = new int[segments * 3];
		v[0] = Vector3.zero;
		for (int i = 0; i <= segments; i++)
		{
			float a = (-angle * 0.5f + angle * i / segments) * Mathf.Deg2Rad;
			v[i + 1] = new Vector3(Mathf.Sin(a), 0f, Mathf.Cos(a)) * radius;
		}
		for (int i = 0; i < segments; i++)
		{
			t[i * 3] = 0;
			t[i * 3 + 1] = i + 1;
			t[i * 3 + 2] = i + 2;
		}
		Mesh m = new Mesh { vertices = v, triangles = t };
		m.RecalculateNormals();
		return m;
	}

	private void Popup(Fighter who, string text, Color color)"""),
    # UI: mostra o golpe do combo
    ("""			m_cooldownFill[i].fillAmount = player.CooldownRatio(i);
		}""", """			m_cooldownFill[i].fillAmount = player.CooldownRatio(i);
		}
		if (player.ComboStep > 0 && player.SlotSkill(0).combo != null)
		{
			SkillDef[] combo = player.SlotSkill(0).combo;
			string next = player.ComboStep <= combo.Length ? combo[player.ComboStep - 1].name : player.SlotSkill(0).name;
			m_status.text = $"Combo {player.ComboStep + 1}/{combo.Length + 1}: {next}";
		}"""),
    ("""		help.text = "WASD mover | J/K/L skills | Espaco esquiva\\nDano, acerto e critico: formulas reconstruidas do jogo (XCalculator)";""",
     """		help.text = "WASD mover | mouse mira | J ou clique: combo | segure K/L para mirar, solte para usar\\nEspaco: esquiva (cancela a skill) | dano, acerto, critico e buffs: regras reconstruidas do jogo";"""),
]
patch("Prototype/BattleManager.cs", bm)
print("ok")
