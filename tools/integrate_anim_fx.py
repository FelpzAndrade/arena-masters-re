"""Pacote visual: impacto sincronizado, locomocao twin-stick, knockdown, cheer, hit pesado,
rastro na arma, pos-processamento (bloom/cor/vinheta), morte afundando e soco de escala."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:90])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


patch("Prototype/FighterDef.cs", [
    ("""	public string animAirborne;""", """	public string animAirborne;
	public string animHitHeavy = "Hit_B";
	public string animGetUp = "Lie_StandUp";
	public string animCheer = "Cheer";
	public string animStrafeLeft = "Running_Strafe_Left";
	public string animStrafeRight = "Running_Strafe_Right";
	public string animBackwards = "Walking_Backwards";
	public string weapon;                  // objeto da arma para o rastro de luz"""),
    ("""			hiddenParts = new[] { "1H_Axe", "1H_Axe_Offhand", "Barbarian_Round_Shield", "Mug" },""",
     """			hiddenParts = new[] { "1H_Axe", "1H_Axe_Offhand", "Barbarian_Round_Shield", "Mug" },
			weapon = "2H_Axe","""),
    ("""			hiddenParts = new[] { "Spellbook", "Spellbook_open", "1H_Wand" },""",
     """			hiddenParts = new[] { "Spellbook", "Spellbook_open", "1H_Wand" },
			weapon = "2H_Staff","""),
])

patch("Prototype/Fighter.cs", [
    # campos
    ("""	private int m_hitsDone;""", """	private int m_hitsDone;
	private Transform m_visual;
	private TrailRenderer m_trail;
	private Vector3 m_moveDir;
	private float m_getUp;
	private float m_cheer;
	private float m_punch;
	private bool m_wasAirborne;

	// instante do golpe em cada clipe (s), medido pelo pico de velocidade da mao da arma (Editor/ImpactProbe).
	// No jogo original vinha de tabela (XSkillHitTime / character_anim.xml). Salto e Raise: ajuste manual.
	private static readonly Dictionary<string, float> ImpactTime = new Dictionary<string, float>
	{
		{ "2H_Melee_Attack_Slice", 0.385f }, { "2H_Melee_Attack_Stab", 0.387f }, { "2H_Melee_Attack_Chop", 0.721f },
		{ "2H_Melee_Attack_Spinning", 0.256f }, { "Jump_Full_Short", 0.85f }, { "Spellcast_Shoot", 0.3f },
		{ "Spellcasting", 0.45f }, { "Spellcast_Raise", 0.9f },
	};"""),
    # visual: guarda raiz e cria o rastro da arma
    ("""			m_renderers = visual.GetComponentsInChildren<Renderer>();
			m_anim = visual.GetComponent<Animation>();""", """			m_renderers = visual.GetComponentsInChildren<Renderer>();
			m_anim = visual.GetComponent<Animation>();
			m_visual = visual.transform;
			m_trail = CreateWeaponTrail(visual, def.weapon, def.color);"""),
    # morte afundando / reset no respawn
    ("""		go.transform.position = arena.Snap(m_spawn);
		go.SetActive(true);
		m_animName = null;""", """		go.transform.position = arena.Snap(m_spawn);
		go.SetActive(true);
		m_getUp = 0f;
		m_cheer = 0f;
		if (m_visual != null)
		{
			m_visual.localPosition = new Vector3(0f, -Arena.CenterHeight, 0f);
			m_visual.localScale = Vector3.one;
		}
		m_animName = null;"""),
    # twin-stick: o jogador pode andar sem virar
    ("""	public void Move(Vector3 dir, float dt)
	{
		if (dir.sqrMagnitude < 0.0001f || !IsAlive || IsStunned || HasControl(MotionControlType.Root))
		{
			return;
		}
		dir.y = 0f;
		dir.Normalize();
		if (CanAct)
		{
			facing = dir;
			TryMoveTo(Position + dir * MoveSpeed * dt);
			m_moved = true;
		}""", """	public void Move(Vector3 dir, float dt, bool keepFacing = false)
	{
		if (dir.sqrMagnitude < 0.0001f || !IsAlive || IsStunned || HasControl(MotionControlType.Root))
		{
			return;
		}
		dir.y = 0f;
		dir.Normalize();
		if (CanAct)
		{
			if (!keepFacing)
			{
				facing = dir;
			}
			// de lado um pouco mais lento, de costas bem mais lento
			float angle = Vector3.Angle(facing, dir);
			float mul = angle < 50f ? 1f : angle > 130f ? 0.7f : 0.85f;
			TryMoveTo(Position + dir * MoveSpeed * mul * dt);
			m_moved = true;
			m_moveDir = dir;
			m_cheer = 0f;
		}"""),
    # tick: morte afundando, getup, cheer, locomocao, soco, rastro
    ("""		if (state == State.Dead)
		{
			m_stateTime += dt;""", """		m_punch = Mathf.Max(0f, m_punch - dt * 6f);
		if (m_visual != null)
		{
			m_visual.localScale = Vector3.one * (1f + 0.12f * m_punch);
		}
		if (m_trail != null)
		{
			m_trail.emitting = (state == State.Casting || state == State.Recovering) && m_slot != DodgeSlot;
		}
		if (state == State.Dead)
		{
			m_stateTime += dt;
			if (m_visual != null && m_stateTime > 1.2f)
			{
				m_visual.localPosition = new Vector3(0f, -Arena.CenterHeight - Mathf.Clamp01((m_stateTime - 1.2f) / 0.8f) * 1.2f, 0f);
			}"""),
    ("""		if (state == State.Idle && !IsStunned)
		{
			PlayLoop(m_moved ? def.animRun : def.animIdle);
		}
		m_moved = false;""", """		if (state == State.Idle && !IsStunned)
		{
			if (m_moved)
			{
				PlayLoop(LocomotionClip());
			}
			else if (m_cheer > 0f)
			{
				m_cheer -= dt;
				if (m_animName != def.animCheer)
				{
					PlayOnce(def.animCheer, 1.6f);
				}
			}
			else
			{
				PlayLoop(def.animIdle);
			}
		}
		m_moved = false;"""),
    # skill: anima ate o impacto cair no windup
    ("""		PlayOnce(sd.anim, Mathf.Max(0.2f, sd.windup + (sd.hitCount - 1) * sd.hitInterval + sd.recovery));""",
     """		PlaySkillAnim(sd);"""),
    # acerto: soco de escala, golpe pesado
    ("""	public void TakeDamage(Fighter from, int damage, bool critical, Vector3 pushDir, SkillDef sd)
	{
		hp -= damage;
		m_flash = 0.12f;""", """	public void TakeDamage(Fighter from, int damage, bool critical, Vector3 pushDir, SkillDef sd)
	{
		hp -= damage;
		m_flash = 0.12f;
		m_punch = critical ? 1.6f : 1f;
		m_heavyHit = critical || damage > maxHp * 0.06f;"""),
    ("""		if (killer != null && killer != this)
		{
			killer.kills++;
		}""", """		if (killer != null && killer != this)
		{
			killer.kills++;
			killer.m_cheer = 1.6f;
		}"""),
    # knockdown: depois do ar, cai e levanta
    ("""		state = State.Controlled;
		PlayOnce(m_airTime > 0f ? def.animAirborne : def.animHit, Mathf.Max(0.25f, time));""",
     """		state = State.Controlled;
		m_wasAirborne = m_airTime > 0f;
		m_getUp = 0f;
		PlayOnce(m_airTime > 0f ? def.animAirborne : (m_heavyHit ? def.animHitHeavy : def.animHit), Mathf.Max(0.25f, time));"""),
    ("""		if (m_controlTime <= 0f)
		{
			state = State.Idle;
			m_pushSpeed = 0f;
			go.transform.position = p;
		}""", """		if (m_controlTime <= 0f)
		{
			if (m_wasAirborne && m_getUp <= 0f)
			{
				// caiu de um lancamento: levanta do chao (knockdown do original: Throwup/Airborne -> deitado -> levanta)
				m_wasAirborne = false;
				m_getUp = 0.55f;
				m_controlTime = m_getUp;
				m_pushSpeed = 0f;
				PlayOnce(def.animGetUp, m_getUp);
				go.transform.position = p;
				return;
			}
			state = State.Idle;
			m_pushSpeed = 0f;
			m_getUp = 0f;
			go.transform.position = p;
		}"""),
    # helpers
    ("""	// ---------- animacao (clipes Legacy do KayKit) ----------""", """	private bool m_heavyHit;

	private string LocomotionClip()
	{
		float angle = Vector3.SignedAngle(facing, m_moveDir, Vector3.up);
		float abs = Mathf.Abs(angle);
		if (abs < 50f)
		{
			return def.animRun;
		}
		if (abs > 130f)
		{
			return def.animBackwards;
		}
		return angle > 0f ? def.animStrafeRight : def.animStrafeLeft;
	}

	// toca a animacao da skill acelerada para o impacto do clipe cair exatamente no fim do windup
	private void PlaySkillAnim(SkillDef sd)
	{
		float total = Mathf.Max(0.2f, sd.windup + (sd.hitCount - 1) * sd.hitInterval + sd.recovery);
		if (m_anim == null || sd.anim == null || m_anim[sd.anim] == null)
		{
			return;
		}
		if (sd.hitCount == 1 && sd.windup > 0.05f && ImpactTime.TryGetValue(sd.anim, out float impact))
		{
			AnimationState st = m_anim[sd.anim];
			st.wrapMode = WrapMode.ClampForever;
			st.speed = Mathf.Clamp(impact / sd.windup, 0.4f, 4f);
			st.time = 0f;
			m_anim.CrossFade(sd.anim, 0.05f);
			m_animName = sd.anim;
			return;
		}
		PlayOnce(sd.anim, total);
	}

	private static TrailRenderer CreateWeaponTrail(GameObject visual, string weapon, Color color)
	{
		if (string.IsNullOrEmpty(weapon))
		{
			return null;
		}
		Transform w = null;
		foreach (Transform t in visual.GetComponentsInChildren<Transform>(true))
		{
			if (t.name == weapon)
			{
				w = t;
				break;
			}
		}
		MeshFilter mf = w != null ? w.GetComponent<MeshFilter>() : null;
		if (mf == null || mf.sharedMesh == null)
		{
			return null;
		}
		// ponta da arma: extremo do maior eixo da malha
		Bounds b = mf.sharedMesh.bounds;
		Vector3 e = b.extents;
		Vector3 axis = e.x >= e.y && e.x >= e.z ? Vector3.right * e.x : e.y >= e.z ? Vector3.up * e.y : Vector3.forward * e.z;
		GameObject tip = new GameObject("rastro_arma");
		tip.transform.SetParent(w, false);
		tip.transform.localPosition = b.center + axis * 0.9f;
		TrailRenderer tr = tip.AddComponent<TrailRenderer>();
		tr.time = 0.16f;
		tr.minVertexDistance = 0.05f;
		tr.widthCurve = new AnimationCurve(new Keyframe(0f, 0.35f), new Keyframe(1f, 0f));
		Material m = new Material(Shader.Find("Legacy Shaders/Particles/Additive") ?? Shader.Find("Sprites/Default"))
		{
			mainTexture = Resources.Load<Texture2D>("VFX/trace_04"),
		};
		tr.material = m;
		Color c = Color.Lerp(color, Color.white, 0.4f);
		Gradient g = new Gradient();
		g.SetKeys(new[] { new GradientColorKey(c, 0f), new GradientColorKey(color, 1f) },
			new[] { new GradientAlphaKey(0.9f, 0f), new GradientAlphaKey(0f, 1f) });
		tr.colorGradient = g;
		tr.emitting = false;
		return tr;
	}

	// ---------- animacao (clipes Legacy do KayKit) ----------"""),
])

# jogador: twin-stick (olha sempre para o mouse)
patch("Prototype/Brains.cs", [
    ("""		self.Move(move, dt);
		if (move.sqrMagnitude < 0.01f)
		{
			self.FaceTowards(AimPoint);
		}""", """		self.FaceTowards(AimPoint);
		self.Move(move, dt, true);"""),
])

# pos-processamento
patch("Prototype/BattleManager.cs", [
    ("""	public GameObject bruxaModel;""", """	public GameObject bruxaModel;
	public UnityEngine.Rendering.PostProcessing.PostProcessResources postResources;"""),
    ("""		m_playerBrain = playerControlled ? (IBrain)new PlayerBrain(cam) : new BotBrain(7);""", """		SetupPostProcessing();
		m_playerBrain = playerControlled ? (IBrain)new PlayerBrain(cam) : new BotBrain(7);"""),
    ("""	// ---------- projeteis (podem ser esquivados) ----------""", """	// bloom (magias, tochas, criticos brilham), cor mais quente/contrastada e vinheta
	private void SetupPostProcessing()
	{
		if (postResources == null)
		{
			return;
		}
		cam.allowHDR = true;
		UnityEngine.Rendering.PostProcessing.PostProcessLayer layer = cam.gameObject.AddComponent<UnityEngine.Rendering.PostProcessing.PostProcessLayer>();
		layer.Init(postResources);
		layer.volumeTrigger = cam.transform;
		layer.volumeLayer = ~0;
		layer.antialiasingMode = UnityEngine.Rendering.PostProcessing.PostProcessLayer.Antialiasing.FastApproximateAntialiasing;
		UnityEngine.Rendering.PostProcessing.PostProcessProfile profile = ScriptableObject.CreateInstance<UnityEngine.Rendering.PostProcessing.PostProcessProfile>();
		UnityEngine.Rendering.PostProcessing.Bloom bloom = profile.AddSettings<UnityEngine.Rendering.PostProcessing.Bloom>();
		bloom.enabled.Override(true);
		bloom.intensity.Override(2.2f);
		bloom.threshold.Override(0.75f);
		bloom.softKnee.Override(0.6f);
		bloom.diffusion.Override(7f);
		UnityEngine.Rendering.PostProcessing.ColorGrading grading = profile.AddSettings<UnityEngine.Rendering.PostProcessing.ColorGrading>();
		grading.enabled.Override(true);
		grading.tonemapper.Override(UnityEngine.Rendering.PostProcessing.Tonemapper.ACES);
		grading.saturation.Override(12f);
		grading.contrast.Override(14f);
		grading.temperature.Override(6f);
		grading.postExposure.Override(0.35f);
		UnityEngine.Rendering.PostProcessing.Vignette vignette = profile.AddSettings<UnityEngine.Rendering.PostProcessing.Vignette>();
		vignette.enabled.Override(true);
		vignette.intensity.Override(0.33f);
		vignette.smoothness.Override(0.45f);
		UnityEngine.Rendering.PostProcessing.PostProcessVolume volume = new GameObject("PosProcessamento").AddComponent<UnityEngine.Rendering.PostProcessing.PostProcessVolume>();
		volume.isGlobal = true;
		volume.priority = 1f;
		volume.sharedProfile = profile;
	}

	// ---------- projeteis (podem ser esquivados) ----------"""),
])

patch("Editor/Reconstruction/PrototypeSetup.cs", [
    ("""		bm.machadinhaModel = AssetDatabase.LoadAssetAtPath<GameObject>(BarbarianPath);""",
     """		bm.machadinhaModel = AssetDatabase.LoadAssetAtPath<GameObject>(BarbarianPath);
		string[] post = AssetDatabase.FindAssets("t:PostProcessResources");
		if (post.Length > 0)
		{
			bm.postResources = AssetDatabase.LoadAssetAtPath<UnityEngine.Rendering.PostProcessing.PostProcessResources>(AssetDatabase.GUIDToAssetPath(post[0]));
		}"""),
])
print("ok")
