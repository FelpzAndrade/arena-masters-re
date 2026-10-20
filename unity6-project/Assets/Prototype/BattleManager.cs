using System.Collections.Generic;
using CS;
using UnityEngine;
using UnityEngine.UI;

// Prototipo de luta 1x1 offline: jogador (Machadinha) contra bot (Bruxa) na DuelArena.
// Regras de combate: codigo reconstruido do jogo (CharStatus + XCalculator). Resto: estrutura propria simples.
public class BattleManager : MonoBehaviour
{
	public bool playerControlled = true;
	public Font font;
	public GameObject machadinhaModel;
	public GameObject bruxaModel;
	public GameObject[] effectPrefabs;      // Cartoon FX Remaster Free

	public Fighter player;
	public Fighter enemy;
	public Arena arena;
	public Camera cam;

	private class Projectile
	{
		public Fighter owner;
		public SkillDef sd;
		public CS.CSSkillInfo info;
		public Vector3 dir;
		public float traveled;
		public GameObject go;
	}

	private readonly List<Projectile> m_projectiles = new List<Projectile>();
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
	}
	private Vector3 m_camBase;
	private GameObject m_indicator;
	private MeshFilter m_indicatorMesh;
	private MeshRenderer m_indicatorRenderer;
	private GameObject m_rangeRing;
	private SkillDef m_indicatorSkill;
	private IBrain m_playerBrain;
	private IBrain m_enemyBrain;
	private readonly List<(GameObject go, float life, float total)> m_fx = new List<(GameObject, float, float)>();
	private readonly List<(TextMesh text, float life)> m_popups = new List<(TextMesh, float)>();
	private Image m_playerHp;
	private Image m_enemyHp;
	private Text m_playerHpText;
	private Text m_enemyHpText;
	private Text m_score;
	private Text m_playerBuffs;
	private Text m_enemyBuffs;
	private Text m_status;
	private Image[] m_cooldownFill;

	private void Awake()
	{
		Setup();
	}

	public void Setup()
	{
		CSLog.Init(new CSLogger());
		Vfx.Clear();
		Vfx.Register(effectPrefabs);
		HitStop.Clear();
		CameraShake.Clear();
		// constantes reais do jogo (XGameConst..cctor no binario)
		XGameConst.AIRBORNE_SPEED = 14f;
		XGameConst.THROW_VERTICAL_SPEED = 3.5f;
		XGameConst.THROW_HORIZENTAL_SPEED = 12.5f;
		XGameConst.KNOCKBACK_SPEED = 8f;
		XGameConst.SNEAK_TIME = 3f;
		if (font == null)
		{
			font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		}

		arena = new Arena();
		DungeonDecor.Build(arena, 3);
		// clima de masmorra: luz fria e fraca de cima, tochas quentes nas paredes
		Light light = new GameObject("Luz ambiente").AddComponent<Light>();
		light.type = LightType.Directional;
		light.intensity = 0.65f;
		light.color = new Color(0.75f, 0.8f, 1f);
		light.shadows = LightShadows.Soft;
		light.transform.rotation = Quaternion.Euler(55f, -30f, 0f);
		RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
		RenderSettings.ambientLight = new Color(0.17f, 0.16f, 0.21f);   // espaco de cor Linear (URP): mais escuro que no Gamma

		FighterDef machadinha = FighterDef.Axie();
		machadinha.model = machadinhaModel;
		FighterDef bruxa = FighterDef.Spark();
		bruxa.model = bruxaModel;
		player = new Fighter(machadinha, arena.SpawnPoint(new Vector3(-10f, 0f, 0f)), arena);
		enemy = new Fighter(bruxa, arena.SpawnPoint(new Vector3(10f, 0f, 0f)), arena);
		player.opponent = enemy;
		enemy.opponent = player;
		foreach (Fighter f in new[] { player, enemy })
		{
			f.onPopup = Popup;
			f.onSkillFx = SkillFx;
			f.onSkillStart = SkillStartFx;
			f.onHitFx = (who, crit, sd) =>
			{
				if (sd != null && sd.vfx == "axeslash")
				{
					Vfx.AxeImpact(who.Position + Vector3.up * 0.2f);
					return;
				}
				Vfx.Hit(who.Position + Vector3.up * 0.2f, who.opponent.def.color, crit, who.opponent.def.skills[0].projectileSpeed > 0f);
			};
			f.onDeathFx = who => Vfx.Death(who.Position);
			f.onBuffAdded = (who, b) => b.aura = b.def.auraPrefab != null ? Vfx.OwnAura(who.go.transform, b.def.auraPrefab) : Vfx.Aura(who.go.transform, b.def.auraTexture, b.def.color, b.def.control == CS.MotionControlType.Stun);
			f.onBuffRemoved = (who, b) => Vfx.DestroyAura(b.aura);
			f.onProjectile = SpawnProjectile;
			f.onUltimate = (who, sd) =>
			{
				m_ultFocus = who;
				m_ultTime = 0.9f;
				HitStop.Request(0.35f);   // camera lenta na ativacao
				CameraShake.Add(0.2f);
				Popup(who, sd.name.ToUpper() + "!", sd.color);
			};
			f.onImpact = (sd, crit) =>
			{
				HitStop.Request(sd.hitstop * (crit ? 1.8f : 1f));
				CameraShake.Add(sd.shake + (crit ? 0.15f : 0f));
			};
		}
		cam = new GameObject("Camera").AddComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.03f, 0.03f, 0.05f);
		cam.fieldOfView = 45f;
		SetupPostProcessing();
		m_playerBrain = playerControlled ? (IBrain)new PlayerBrain(cam) : new BotBrain(7);
		m_enemyBrain = new BotBrain(42) { projectiles = LiveProjectiles };
		if (m_playerBrain is BotBrain playerBot)
		{
			playerBot.projectiles = LiveProjectiles;
		}
		BuildIndicator();
		BuildUI();
		UpdateCamera(1f);
	}

	private void Update()
	{
		HitStop.Tick(Time.unscaledDeltaTime);
		Step(Mathf.Min(Time.deltaTime, 0.05f));
	}

	private void OnDisable()
	{
		HitStop.Clear();
	}

	public void Step(float dt)
	{
		if (!Application.isPlaying && HitStop.Active)
		{
			HitStop.Tick(dt);
			dt *= HitStop.FrozenScale;
		}
		if (player.IsAlive)
		{
			m_playerBrain.Think(player, dt);
		}
		if (enemy.IsAlive)
		{
			m_enemyBrain.Think(enemy, dt);
		}
		player.Tick(dt);
		enemy.Tick(dt);
		Separate();
		UpdateProjectiles(dt);
		UpdateIndicator();
		UpdateFx(dt);
		Vfx.Update(dt);
		arena.UpdateBlockers(dt);
		UpdateCamera(dt);
		UpdateUI();
	}

	// tempo real (ignora o hitstop); na captura em modo de edicao o relogio real nao anda, usa o passo da simulacao
	private static float RealDt(float dt) => Application.isPlaying ? Time.unscaledDeltaTime : dt;

	private void UpdateCamera(float dt)
	{
		Vector3 focus = player.IsAlive ? (enemy.IsAlive ? Vector3.Lerp(player.Position, enemy.Position, 0.35f) : player.Position) : arena.center;
		m_ultTime = Mathf.Max(0f, m_ultTime - RealDt(dt));
		if (m_ultTime > 0f && m_ultFocus != null && m_ultFocus.IsAlive)
		{
			focus = Vector3.Lerp(focus, m_ultFocus.Position, 0.7f);
		}
		// lutadores longe (ou um entre a camera e o outro): afasta a camera para caber os dois
		float spread = player.IsAlive && enemy.IsAlive ? Vector3.Distance(player.Position, enemy.Position) : 0f;
		float zoomOut = 1f + Mathf.Clamp(spread - 5f, 0f, 10f) * 0.07f;
		Vector3 want = focus + (m_ultTime > 0f ? new Vector3(0f, 5.5f, -5f) : new Vector3(0f, 8.5f, -7.5f) * zoomOut);
		if (m_ultTime <= 0f && player.IsAlive && enemy.IsAlive)
		{
			// nunca deixa um lutador passar por baixo/atras da camera
			float nearest = Mathf.Min(player.Position.z, enemy.Position.z) - 6f;
			if (want.z > nearest)
			{
				want.y += (want.z - nearest) * 1.1f;
				want.z = nearest;
			}
		}
		m_camBase = Vector3.Lerp(m_camBase == Vector3.zero ? want : m_camBase, want, Mathf.Clamp01(dt * 5f));
		cam.transform.position = m_camBase + CameraShake.Offset(RealDt(dt));
		cam.transform.rotation = Quaternion.LookRotation(focus - want);
		DungeonDecor.UpdateOcclusion(focus, cam.transform.position);
	}

	// ---------- efeitos ----------

	private void SkillFx(Fighter owner, SkillDef sd, Vector3 center)
	{
		Vector3 ground = center + Vector3.down * Arena.CenterHeight;
		switch (sd.vfx)
		{
			case "warhorn":
				Vfx.WarHorn(owner.Position + Vector3.down * Arena.CenterHeight);
				CameraShake.Add(0.12f);
				return;
			case "axeslash":
				Vfx.AxeSlash(owner.Position, owner.facing, sd.range, sd.vfxRoll);
				return;
			case "slash":
				Vfx.Slash(owner.Position, owner.facing, sd.color, sd.range);
				return;
			case "spin":
				Vfx.Spin(owner.Position, sd.color, sd.range, false);
				return;
			case "magicspin":
				Vfx.Spin(owner.Position, sd.color, sd.range, true);
				return;
			case "slam":
				Vfx.Slam(ground, sd.color, sd.range);
				return;
			case "beam":
				Vfx.Beam(owner.Position + Vector3.up * 0.3f + owner.facing * 0.6f, owner.facing, sd.range, sd.color);
				return;
			case "burst":
				Vfx.MagicBurst(ground, sd.color, sd.range);
				return;
			case "dust":
				Vfx.Dust(owner.Position + Vector3.down * Arena.CenterHeight);
				return;
			case "teleport":
				Vfx.Teleport(owner.Position, owner.def.color);
				return;
			case "bolt":
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
				return;
		}
		GameObject disc = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		Object.DestroyImmediate(disc.GetComponent<Collider>());
		disc.name = "fx_" + sd.name;
		float r = sd.range;
		disc.transform.position = center + Vector3.down * (Arena.CenterHeight - 0.05f);
		disc.transform.localScale = new Vector3(r * 2f, 0.02f, r * 2f);
		disc.GetComponent<Renderer>().material = Arena.MakeMaterial(sd.color);
		m_fx.Add((disc, 0.25f, 0.25f));
		if (sd.angle < 360f && !sd.areaAtTarget)
		{
			// cone/linha: barra na direcao do golpe
			GameObject bar = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Object.DestroyImmediate(bar.GetComponent<Collider>());
			bar.transform.position = owner.Position + owner.facing * (r * 0.5f) + Vector3.down * 0.3f;
			bar.transform.rotation = Quaternion.LookRotation(owner.facing);
			bar.transform.localScale = new Vector3(Mathf.Max(0.4f, r * Mathf.Tan(sd.angle * 0.5f * Mathf.Deg2Rad)), 0.1f, r);
			bar.GetComponent<Renderer>().material = Arena.MakeMaterial(sd.color);
			m_fx.Add((bar, 0.2f, 0.2f));
			Object.DestroyImmediate(disc);
			m_fx.RemoveAt(m_fx.Count - 2);
		}
	}

	// aviso no chao durante a preparacao das skills de area
	private void SkillStartFx(Fighter owner, SkillDef sd, Vector3 center)
	{
		Vector3 ground = center + Vector3.down * (Arena.CenterHeight - 0.02f);
		if (sd.vfx == "burst" || sd.vfx == "slam" || sd.vfx == "magicspin" || sd.vfx == "spin")
		{
			Vfx.Telegraph(ground, sd.color, sd.range, Mathf.Max(0.2f, sd.windup), sd.vfx == "burst" || sd.vfx == "magicspin");
		}
		if (sd.vfx == "teleport")
		{
			Vfx.Teleport(owner.Position, owner.def.color);
		}
	}

	// bloom (magias, tochas, criticos brilham), cor mais quente/contrastada e vinheta
	private void SetupPostProcessing()
	{
		cam.allowHDR = true;
		UnityEngine.Rendering.Universal.UniversalAdditionalCameraData data = UnityEngine.Rendering.Universal.CameraExtensions.GetUniversalAdditionalCameraData(cam);
		data.renderPostProcessing = true;
		data.antialiasing = UnityEngine.Rendering.Universal.AntialiasingMode.FastApproximateAntialiasing;
		UnityEngine.Rendering.VolumeProfile profile = ScriptableObject.CreateInstance<UnityEngine.Rendering.VolumeProfile>();
		UnityEngine.Rendering.Universal.Bloom bloom = profile.Add<UnityEngine.Rendering.Universal.Bloom>(true);
		bloom.intensity.Override(1.1f);
		bloom.threshold.Override(0.9f);
		bloom.scatter.Override(0.7f);
		UnityEngine.Rendering.Universal.Tonemapping tonemapping = profile.Add<UnityEngine.Rendering.Universal.Tonemapping>(true);
		tonemapping.mode.Override(UnityEngine.Rendering.Universal.TonemappingMode.ACES);
		UnityEngine.Rendering.Universal.ColorAdjustments color = profile.Add<UnityEngine.Rendering.Universal.ColorAdjustments>(true);
		color.postExposure.Override(0.35f);
		color.contrast.Override(14f);
		color.saturation.Override(12f);
		UnityEngine.Rendering.Universal.WhiteBalance white = profile.Add<UnityEngine.Rendering.Universal.WhiteBalance>(true);
		white.temperature.Override(6f);
		UnityEngine.Rendering.Universal.Vignette vignette = profile.Add<UnityEngine.Rendering.Universal.Vignette>(true);
		vignette.intensity.Override(0.33f);
		vignette.smoothness.Override(0.45f);
		UnityEngine.Rendering.Volume volume = new GameObject("PosProcessamento").AddComponent<UnityEngine.Rendering.Volume>();
		volume.isGlobal = true;
		volume.priority = 1f;
		volume.sharedProfile = profile;
	}

	// ---------- projeteis (podem ser esquivados) ----------

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
		Material mat = Vfx.ParticleMaterial(Texture2D.whiteTexture, false);   // Sprites/Default fica rosa em malha 3D no URP
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
			m_indicatorRenderer.sharedMaterial.SetColor("_Tint", c);
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

	private void Popup(Fighter who, string text, Color color)
	{
		TextMesh tm = new GameObject("dano").AddComponent<TextMesh>();
		tm.font = font;
		tm.GetComponent<MeshRenderer>().sharedMaterial = font.material;
		tm.text = text;
		tm.color = color;
		tm.fontSize = 64;
		tm.characterSize = 0.06f;
		tm.anchor = TextAnchor.MiddleCenter;
		tm.fontStyle = FontStyle.Bold;
		bool isNumber = text.Length > 0 && char.IsDigit(text[0]);
		tm.transform.position = who.Position + Vector3.up * (isNumber ? 1.6f : 2.3f) + new Vector3(Random.Range(-0.4f, 0.4f), 0f, 0f);
		m_popups.Add((tm, 0.9f));
	}

	private void UpdateFx(float dt)
	{
		for (int i = m_fx.Count - 1; i >= 0; i--)
		{
			(GameObject go, float life, float total) = m_fx[i];
			life -= dt;
			if (life <= 0f)
			{
				DestroyAny(go);
				m_fx.RemoveAt(i);
				continue;
			}
			go.transform.localScale = Vector3.Scale(go.transform.localScale, new Vector3(1f, 1f, 1f)) * (1f + dt * 0.8f);
			m_fx[i] = (go, life, total);
		}
		for (int i = m_popups.Count - 1; i >= 0; i--)
		{
			(TextMesh tm, float life) = m_popups[i];
			life -= dt;
			if (life <= 0f)
			{
				DestroyAny(tm.gameObject);
				m_popups.RemoveAt(i);
				continue;
			}
			tm.transform.position += Vector3.up * dt * 1.5f;
			tm.transform.rotation = cam.transform.rotation;
			Color c = tm.color;
			c.a = Mathf.Clamp01(life / 0.4f);
			tm.color = c;
			m_popups[i] = (tm, life);
		}
	}

	private static string BuffText(Fighter f)
	{
		System.Text.StringBuilder sb = new System.Text.StringBuilder();
		foreach (ActiveBuff b in f.buffs)
		{
			string hex = ColorUtility.ToHtmlStringRGB(b.def.color);
			string stack = b.stack > 1 ? $" x{b.stack}" : string.Empty;
			sb.Append($"<color=#{hex}>{(b.def.type == CS.BuffType.Debuff ? "v" : "^")} {b.def.name}{stack} {b.remaining:0.0}s</color>   ");
		}
		return sb.ToString();
	}

	private static void DestroyAny(Object o)
	{
		if (Application.isPlaying)
		{
			Destroy(o);
		}
		else
		{
			DestroyImmediate(o);
		}
	}

	// ---------- UI (uGUI nativo) ----------

	private void BuildUI()
	{
		Canvas canvas = new GameObject("UI").AddComponent<Canvas>();
		canvas.renderMode = RenderMode.ScreenSpaceCamera;
		canvas.worldCamera = cam;
		canvas.planeDistance = 1f;
		CanvasScaler scaler = canvas.gameObject.AddComponent<CanvasScaler>();
		scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		scaler.referenceResolution = new Vector2(1280f, 720f);
		scaler.matchWidthOrHeight = 1f;

		m_playerHp = Bar(canvas.transform, new Vector2(0f, 1f), new Vector2(30f, -30f), player.def.color, out m_playerHpText, player.def.name + " (voce)");
		m_enemyHp = Bar(canvas.transform, new Vector2(1f, 1f), new Vector2(-30f, -30f), enemy.def.color, out m_enemyHpText, enemy.def.name + " (bot)");
		m_playerBuffs = Label(canvas.transform, new Vector2(0f, 1f), new Vector2(30f, -98f), 16, TextAnchor.UpperLeft, new Vector2(420f, 24f));
		m_playerBuffs.rectTransform.pivot = new Vector2(0f, 1f);
		m_enemyBuffs = Label(canvas.transform, new Vector2(1f, 1f), new Vector2(-30f, -98f), 16, TextAnchor.UpperRight, new Vector2(420f, 24f));
		m_enemyBuffs.rectTransform.pivot = new Vector2(1f, 1f);
		m_score = Label(canvas.transform, new Vector2(0.5f, 1f), new Vector2(0f, -28f), 30, TextAnchor.UpperCenter, new Vector2(400f, 44f));
		m_status = Label(canvas.transform, new Vector2(0.5f, 1f), new Vector2(0f, -70f), 18, TextAnchor.UpperCenter, new Vector2(700f, 30f));

		m_cooldownFill = new Image[5];
		string[] keys = { "J", "K", "L", "I", "Espaco" };
		for (int i = 0; i < 5; i++)
		{
			string skillName = i < 4 ? player.def.skills[i].name : player.def.dodge.name;
			RectTransform box = Rect("skill" + i, canvas.transform, new Vector2(0.5f, 0f), new Vector2(-256f + i * 128f, 30f), new Vector2(124f, 70f));
			box.pivot = new Vector2(0.5f, 0f);
			box.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.6f);
			Image fill = Rect("cd", box, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(124f, 70f)).gameObject.AddComponent<Image>();
			fill.color = new Color(1f, 1f, 1f, 0.25f);
			fill.type = Image.Type.Filled;
			fill.fillMethod = Image.FillMethod.Vertical;
			m_cooldownFill[i] = fill;
			Text t = Label(box, new Vector2(0.5f, 0.5f), Vector2.zero, 14, TextAnchor.MiddleCenter, new Vector2(124f, 70f));
			t.text = $"<b>{keys[i]}</b>\n{skillName}";
		}
		RectTransform ultBack = Rect("ult", canvas.transform, new Vector2(0.5f, 0f), new Vector2(0f, 112f), new Vector2(630f, 18f));
		ultBack.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.7f);
		m_ultFill = Rect("fill", ultBack, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(624f, 12f)).gameObject.AddComponent<Image>();
		m_ultFill.type = Image.Type.Filled;
		m_ultFill.fillMethod = Image.FillMethod.Horizontal;
		m_ultText = Label(ultBack, new Vector2(0.5f, 0.5f), new Vector2(0f, 18f), 16, TextAnchor.MiddleCenter, new Vector2(630f, 22f));
		Text help = Label(canvas.transform, new Vector2(0f, 0f), new Vector2(20f, 110f), 14, TextAnchor.LowerLeft, new Vector2(520f, 60f));
		help.rectTransform.pivot = new Vector2(0f, 0f);
		help.text = $"WASD mover | mouse mira | J ou clique: combo | segure K/L/I/R para mirar, solte para usar\nEspaco: esquiva | R: ultimate | Passiva: {player.def.passiveName} - {player.def.passiveDesc}";
	}

	private Image Bar(Transform parent, Vector2 anchor, Vector2 pos, Color color, out Text text, string title)
	{
		RectTransform back = Rect("hp", parent, anchor, pos, new Vector2(420f, 30f));
		back.pivot = anchor;
		back.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.7f);
		Image fill = Rect("fill", back, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(412f, 22f)).gameObject.AddComponent<Image>();
		fill.color = color;
		fill.type = Image.Type.Filled;
		fill.fillMethod = Image.FillMethod.Horizontal;
		fill.fillOrigin = anchor.x > 0.5f ? 1 : 0;
		text = Label(back, new Vector2(0.5f, 0.5f), Vector2.zero, 16, TextAnchor.MiddleCenter, new Vector2(412f, 22f));
		Text name = Label(back, new Vector2(anchor.x, 0f), new Vector2(0f, -4f), 18, anchor.x > 0.5f ? TextAnchor.UpperRight : TextAnchor.UpperLeft, new Vector2(412f, 26f));
		name.rectTransform.pivot = new Vector2(anchor.x, 1f);
		name.text = "<b>" + title + "</b>";
		return fill;
	}

	private Text Label(Transform parent, Vector2 anchor, Vector2 pos, int size, TextAnchor align, Vector2 boxSize)
	{
		Text t = Rect("txt", parent, anchor, pos, boxSize).gameObject.AddComponent<Text>();
		t.font = font;
		t.fontSize = size;
		t.alignment = align;
		t.color = Color.white;
		t.supportRichText = true;
		t.gameObject.AddComponent<Outline>().effectColor = Color.black;
		return t;
	}

	private static RectTransform Rect(string name, Transform parent, Vector2 anchor, Vector2 pos, Vector2 size)
	{
		RectTransform rt = new GameObject(name, typeof(RectTransform)).GetComponent<RectTransform>();
		rt.SetParent(parent, false);
		rt.anchorMin = rt.anchorMax = anchor;
		rt.pivot = new Vector2(0.5f, 0.5f);
		rt.anchoredPosition = pos;
		rt.sizeDelta = size;
		return rt;
	}

	private void UpdateUI()
	{
		m_playerHp.fillAmount = player.hp / player.maxHp;
		m_enemyHp.fillAmount = enemy.hp / enemy.maxHp;
		m_playerHpText.text = $"{Mathf.CeilToInt(player.hp)} / {Mathf.CeilToInt(player.maxHp)}" + (player.IsDeathDoor() ? "  (a beira da morte)" : string.Empty);
		m_enemyHpText.text = $"{Mathf.CeilToInt(enemy.hp)} / {Mathf.CeilToInt(enemy.maxHp)}" + (enemy.IsDeathDoor() ? "  (a beira da morte)" : string.Empty);
		m_score.text = $"<b>{player.kills}  x  {enemy.kills}</b>";
		m_playerBuffs.text = BuffText(player);
		m_enemyBuffs.text = BuffText(enemy);
		string s = !player.IsAlive ? "Voce foi derrotado - renascendo..." : !enemy.IsAlive ? "K.O.! A Bruxa renasce em instantes" : player.CurrentSkillName;
		m_status.text = s;
		for (int i = 0; i < m_cooldownFill.Length; i++)
		{
			m_cooldownFill[i].fillAmount = player.CooldownRatio(i);
		}
		m_ultFill.fillAmount = player.UltPercent;
		bool ready = player.UltReady;
		float pulse = ready ? 0.75f + 0.25f * Mathf.Sin(Time.unscaledTime * 8f) : 1f;
		m_ultFill.color = ready ? new Color(1f, 0.8f * pulse, 0.2f) : new Color(0.9f, 0.55f, 0.15f, 0.85f);
		m_ultText.text = ready ? $"<b>R: {player.def.ultimate.name} PRONTA!</b>" : $"Ultimate {Mathf.FloorToInt(player.UltPercent * 100f)}%";
		if (player.ComboStep > 0 && player.SlotSkill(0).combo != null)
		{
			SkillDef[] combo = player.SlotSkill(0).combo;
			string next = player.ComboStep <= combo.Length ? combo[player.ComboStep - 1].name : player.SlotSkill(0).name;
			m_status.text = $"Combo {player.ComboStep + 1}/{combo.Length + 1}: {next}";
		}
	}
}
