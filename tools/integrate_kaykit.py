"""Integra os personagens KayKit (CC0) no prototipo: modelo, armas visiveis e animacoes por estado/skill."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:60])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


# ---------- FighterDef ----------
fd = [
    ("""	public System.Action<CharStatus> applyStats;
""", """	public System.Action<CharStatus> applyStats;
	// visual: personagem KayKit (CC0) e animacoes embutidas no FBX
	public GameObject model;
	public string[] hiddenParts;
	public string animIdle;
	public string animRun;
	public string animHit;
	public string animDeath;
	public string animAirborne;
"""),
    ("""			name = "Machadinha",
			color = new Color(0.85f, 0.3f, 0.2f),""", """			name = "Machadinha",
			color = new Color(0.85f, 0.3f, 0.2f),
			hiddenParts = new[] { "1H_Axe", "1H_Axe_Offhand", "Barbarian_Round_Shield", "Mug" },
			animIdle = "2H_Melee_Idle",
			animRun = "Running_A",
			animHit = "Hit_A",
			animDeath = "Death_A",
			animAirborne = "Hit_B","""),
    ("""			name = "Bruxa",
			color = new Color(0.55f, 0.25f, 0.85f),""", """			name = "Bruxa",
			color = new Color(0.55f, 0.25f, 0.85f),
			hiddenParts = new[] { "Spellbook", "Spellbook_open", "1H_Wand" },
			animIdle = "Idle",
			animRun = "Running_A",
			animHit = "Hit_A",
			animDeath = "Death_B",
			animAirborne = "Hit_B","""),
]
anims = {
    "Machadada": "2H_Melee_Attack_Slice", "Giro do Machado": "2H_Melee_Attack_Spinning", "Salto Esmagador": "Jump_Full_Short",
    "Rolamento": "Dodge_Forward", "Raio Arcano": "Spellcast_Shoot", "Explosao Magica": "Spellcast_Raise", "Gira Gira": "2H_Melee_Attack_Spinning",
    "Teleporte": "Spellcasting",
}
for name, clip in anims.items():
    fd.append((f'name = "{name}",', f'name = "{name}", anim = "{clip}",'))
patch("Prototype/FighterDef.cs", fd)

patch("Prototype/SkillDef.cs", [("""	public string name;
""", """	public string name;
	public string anim;               // clipe KayKit tocado durante a skill (ajustado ao tempo windup+recovery)
""")])

# ---------- Fighter ----------
patch("Prototype/Fighter.cs", [
    ("""		go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
		go.name = def.name;
		Object.DestroyImmediate(go.GetComponent<Collider>());
		m_body = go.GetComponent<Renderer>();
		m_body.material = Arena.MakeMaterial(def.color);
		GameObject nose = GameObject.CreatePrimitive(PrimitiveType.Cube);
		Object.DestroyImmediate(nose.GetComponent<Collider>());
		nose.transform.SetParent(go.transform, false);
		nose.transform.localPosition = new Vector3(0f, 0.4f, 0.55f);
		nose.transform.localScale = new Vector3(0.35f, 0.2f, 0.5f);
		nose.GetComponent<Renderer>().material = Arena.MakeMaterial(Color.Lerp(def.color, Color.white, 0.5f));
		Respawn();""", """		go = new GameObject(def.name);
		if (def.model != null)
		{
			// personagem KayKit: pivot nos pes, o centro do lutador fica 1m acima
			GameObject visual = Object.Instantiate(def.model, go.transform);
			visual.transform.localPosition = new Vector3(0f, -Arena.CenterHeight, 0f);
			foreach (Transform t in visual.GetComponentsInChildren<Transform>(true))
			{
				if (System.Array.IndexOf(def.hiddenParts, t.name) >= 0)
				{
					t.gameObject.SetActive(false);
				}
			}
			m_renderers = visual.GetComponentsInChildren<Renderer>();
			m_anim = visual.GetComponent<Animation>();
		}
		else
		{
			GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			Object.DestroyImmediate(capsule.GetComponent<Collider>());
			capsule.transform.SetParent(go.transform, false);
			capsule.GetComponent<Renderer>().material = Arena.MakeMaterial(def.color);
			m_renderers = new[] { capsule.GetComponent<Renderer>() };
		}
		m_baseColors = new Color[m_renderers.Length];
		for (int i = 0; i < m_renderers.Length; i++)
		{
			m_baseColors[i] = m_renderers[i].material.color;
		}
		Respawn();"""),
    ("""	private readonly Renderer m_body;
""", """	private readonly Renderer[] m_renderers;
	private readonly Color[] m_baseColors;
	private readonly Animation m_anim;
	private string m_animName;
	private bool m_moved;
"""),
    ("""		m_body.material.color = m_flash > 0f ? Color.white : (IsDeathDoor() ? Color.Lerp(def.color, Color.black, 0.35f) : def.color);
""", """		for (int i = 0; i < m_renderers.Length; i++)
		{
			Color baseColor = m_baseColors[i];
			m_renderers[i].material.color = m_flash > 0f ? Color.Lerp(baseColor, Color.red, 0.6f) : (IsDeathDoor() ? Color.Lerp(baseColor, new Color(0.5f, 0.1f, 0.1f), 0.35f) : baseColor);
		}
"""),
    ("""		go.transform.rotation = Quaternion.Slerp(go.transform.rotation, Quaternion.LookRotation(facing), Mathf.Clamp01(dt * 15f));
	}""", """		go.transform.rotation = Quaternion.Slerp(go.transform.rotation, Quaternion.LookRotation(facing), Mathf.Clamp01(dt * 15f));
		if (state == State.Idle)
		{
			PlayLoop(m_moved ? def.animRun : def.animIdle);
		}
		m_moved = false;
		UpdateAnimation(dt);
	}

	// ---------- animacao (clipes Legacy do KayKit) ----------

	private void PlayLoop(string clip)
	{
		if (m_anim == null || clip == null || m_animName == clip || m_anim[clip] == null)
		{
			return;
		}
		m_anim[clip].wrapMode = WrapMode.Loop;
		m_anim[clip].speed = 1f;
		m_anim.CrossFade(clip, 0.15f);
		m_animName = clip;
	}

	// toca o clipe uma vez, esticado/comprimido para durar 'duration' segundos
	private void PlayOnce(string clip, float duration)
	{
		if (m_anim == null || clip == null || m_anim[clip] == null)
		{
			return;
		}
		AnimationState st = m_anim[clip];
		st.wrapMode = WrapMode.ClampForever;
		st.speed = duration > 0f ? st.length / duration : 1f;
		st.time = 0f;
		m_anim.CrossFade(clip, 0.08f);
		m_animName = clip;
	}

	private void UpdateAnimation(float dt)
	{
		// fora do Play (captura em batch) o Animation nao avanca sozinho
		if (m_anim == null || Application.isPlaying)
		{
			return;
		}
		foreach (AnimationState st in m_anim)
		{
			if (st.enabled)
			{
				st.time += dt * st.speed;
			}
		}
		m_anim.Sample();
	}"""),
    ("""		facing = dir;
		TryMoveTo(Position + dir * def.moveSpeed * dt);
	}""", """		facing = dir;
		TryMoveTo(Position + dir * def.moveSpeed * dt);
		m_moved = true;
	}"""),
    ("""		cooldowns[index] = sd.cooldown;
		state = State.Casting;""", """		cooldowns[index] = sd.cooldown;
		PlayOnce(sd.anim, Mathf.Max(0.2f, sd.windup + sd.recovery));
		state = State.Casting;"""),
    ("""		go.transform.position = arena.Snap(m_spawn);
		go.SetActive(true);""", """		go.transform.position = arena.Snap(m_spawn);
		go.SetActive(true);
		m_animName = null;
		PlayLoop(def.animIdle);"""),
    ("""			onPopup?.Invoke(this, "K.O.", Color.red);
			go.SetActive(false);
			return;""", """			onPopup?.Invoke(this, "K.O.", Color.red);
			PlayOnce(def.animDeath, 1.2f);
			return;"""),
    ("""		if (state == State.Dead)
		{
			m_stateTime += dt;
			if (m_stateTime >= 3f)
			{
				Respawn();
			}
			return;
		}""", """		if (state == State.Dead)
		{
			m_stateTime += dt;
			if (m_stateTime >= 2f && go.activeSelf)
			{
				go.SetActive(false);
			}
			if (m_stateTime >= 3f)
			{
				Respawn();
			}
			UpdateAnimation(dt);
			return;
		}"""),
    ("""		state = State.Controlled;
		m_skill = -1;""", """		state = State.Controlled;
		PlayOnce(m_airTime > 0f ? def.animAirborne : def.animHit, Mathf.Max(0.25f, time));
		m_skill = -1;"""),
])

# ---------- BattleManager ----------
patch("Prototype/BattleManager.cs", [
    ("""	public Font font;
""", """	public Font font;
	public GameObject machadinhaModel;
	public GameObject bruxaModel;
"""),
    ("""		player = new Fighter(FighterDef.Machadinha(), arena.SpawnPoint(new Vector3(-10f, 0f, 0f)), arena);
		enemy = new Fighter(FighterDef.Bruxa(), arena.SpawnPoint(new Vector3(10f, 0f, 0f)), arena);""", """		FighterDef machadinha = FighterDef.Machadinha();
		machadinha.model = machadinhaModel;
		FighterDef bruxa = FighterDef.Bruxa();
		bruxa.model = bruxaModel;
		player = new Fighter(machadinha, arena.SpawnPoint(new Vector3(-10f, 0f, 0f)), arena);
		enemy = new Fighter(bruxa, arena.SpawnPoint(new Vector3(10f, 0f, 0f)), arena);"""),
])

# ---------- PrototypeSetup ----------
patch("Editor/Reconstruction/PrototypeSetup.cs", [
    ("""	private const string FontPath = "Assets/Font/08SeoulNamsanEB_0.ttf";
""", """	private const string FontPath = "Assets/Font/08SeoulNamsanEB_0.ttf";
	private const string BarbarianPath = "Assets/Prototype/KayKit/Characters/Barbarian.fbx";
	private const string MagePath = "Assets/Prototype/KayKit/Characters/Mage.fbx";

	private static void AssignModels(BattleManager bm)
	{
		KayKitImport.EnsureLegacy(BarbarianPath);
		KayKitImport.EnsureLegacy(MagePath);
		bm.machadinhaModel = AssetDatabase.LoadAssetAtPath<GameObject>(BarbarianPath);
		bm.bruxaModel = AssetDatabase.LoadAssetAtPath<GameObject>(MagePath);
	}
"""),
    ("""		bm.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		EditorSceneManager.SaveScene""", """		bm.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		AssignModels(bm);
		EditorSceneManager.SaveScene"""),
    ("""		bm.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		bm.Setup();""", """		bm.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		AssignModels(bm);
		bm.Setup();"""),
])
print("ok")
