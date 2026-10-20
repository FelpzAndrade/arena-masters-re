"""Cartoon FX Remaster Free (JMO, gratis na Asset Store) por cima dos efeitos atuais."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:90])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


patch("Prototype/Vfx.cs", [
    ("""		public LineRenderer line;""", """		public LineRenderer line;
		public GameObject prefab;
		public ParticleSystem[] systems;"""),
    ("""	public static int LiveCount => s_live.Count;""", """	private static readonly Dictionary<string, GameObject> s_prefabs = new Dictionary<string, GameObject>();

	public static int LiveCount => s_live.Count;

	// prefabs do Cartoon FX Remaster (atribuidos pelo PrototypeSetup); sem eles fica so o efeito proprio
	public static void Register(GameObject[] prefabs)
	{
		s_prefabs.Clear();
		if (prefabs == null)
		{
			return;
		}
		foreach (GameObject p in prefabs)
		{
			if (p != null)
			{
				s_prefabs[p.name] = p;
			}
		}
	}

	private static bool Cfx(string name, Vector3 pos, float scale, float life, float yaw = 0f)
	{
		if (!s_prefabs.TryGetValue(name, out GameObject prefab))
		{
			return false;
		}
		GameObject go = Object.Instantiate(prefab, pos, Quaternion.Euler(0f, yaw, 0f));
		go.transform.localScale = Vector3.one * scale;
		ParticleSystem[] systems = go.GetComponentsInChildren<ParticleSystem>();
		foreach (ParticleSystem ps in systems)
		{
			ParticleSystem.MainModule main = ps.main;
			main.scalingMode = ParticleSystemScalingMode.Hierarchy;
		}
		if (!Application.isPlaying)
		{
			foreach (ParticleSystem ps in systems)
			{
				ps.Simulate(0f, false, true, false);
			}
		}
		s_live.Add(new Live { prefab = go, systems = systems, life = life, total = life });
		return true;
	}"""),
    # golpes
    ("""		ParticleSystem ps = Single("slash_02", pos + facing * radius * 0.45f, color, radius * 2f, 0.22f, true, Angle(facing) + 90f);""",
     """		Cfx("CFXR _SLASH_", pos + facing * radius * 0.5f + Vector3.up * 0.6f, 0.7f, 1f);
		ParticleSystem ps = Single("slash_02", pos + facing * radius * 0.45f, color, radius * 2f, 0.22f, true, Angle(facing) + 90f);"""),
    ("""		ParticleSystem ps = Single(magic ? "twirl_02" : "twirl_01", pos, color, radius * 2.2f, 0.45f, true, 0f);""",
     """		Cfx(magic ? "CFXR4 Sword Trail ICE (360 Spiral)" : "CFXR4 Sword Trail PLAIN (360 Spiral)", pos, radius * 0.55f, 1.2f);
		ParticleSystem ps = Single(magic ? "twirl_02" : "twirl_01", pos, color, radius * 2.2f, 0.45f, true, 0f);"""),
    ("""		ParticleSystem wave = Single("circle_05", groundPos + Vector3.up * 0.08f, color, radius * 2.6f, 0.4f, true, 0f);""",
     """		Cfx("CFXR2 Ground Hit", groundPos, radius * 0.6f, 2f);
		Cfx("CFXR _BOOM_", groundPos + Vector3.up * 1.4f, 0.8f, 1.2f);
		ParticleSystem wave = Single("circle_05", groundPos + Vector3.up * 0.08f, color, radius * 2.6f, 0.4f, true, 0f);"""),
    ("""		ParticleSystem circle = Single("symbol_02", groundPos + Vector3.up * 0.06f, color, radius * 2.4f, 0.5f, true, 0f);""",
     """		Cfx("CFXR2 WW Explosion", groundPos + Vector3.up * 0.3f, radius * 0.5f, 2f);
		ParticleSystem circle = Single("symbol_02", groundPos + Vector3.up * 0.06f, color, radius * 2.4f, 0.5f, true, 0f);"""),
    ("""		Burst("magic_05", pos, color, 20, 0.5f, 0.2f, 0.5f, true);""",
     """		Cfx("CFXR Magic Poof", pos, 1f, 1.5f);
		Burst("magic_05", pos, color, 20, 0.5f, 0.2f, 0.5f, true);"""),
    ("""	public static void Hit(Vector3 pos, Color color, bool critical)
	{""", """	public static void Hit(Vector3 pos, Color color, bool critical, bool magic = false)
	{
		Cfx(magic ? "CFXR Impact Glowing HDR (Blue)" : "CFXR4 Sword Hit PLAIN (Cross)", pos, magic ? 0.8f : 1f, 1.2f);
		if (critical)
		{
			Cfx("CFXR _POW_", pos + Vector3.up * 1.2f, 0.7f, 1.2f);
		}"""),
    ("""		Burst("smoke_03", pos, new Color(0.4f, 0.4f, 0.45f, 0.8f), 16, 1.2f, 1.2f, 2.2f, false);""",
     """		Cfx("CFXR2 Souls Escape", pos, 1f, 2.5f);
		Burst("smoke_03", pos, new Color(0.4f, 0.4f, 0.45f, 0.8f), 16, 1.2f, 1.2f, 2.2f, false);"""),
    ("""	public static void Impact(Vector3 pos, Color color)
	{""", """	public static void Impact(Vector3 pos, Color color)
	{
		Cfx("CFXR3 Hit Light B (Air)", pos, 0.7f, 1f);"""),
    # ciclo de vida dos prefabs
    ("""			if (l.ps != null && !Application.isPlaying)
			{
				l.ps.Simulate(dt, true, false, false);
			}""", """			if (l.ps != null && !Application.isPlaying)
			{
				l.ps.Simulate(dt, true, false, false);
			}
			if (l.systems != null && l.prefab != null && !Application.isPlaying)
			{
				foreach (ParticleSystem ps in l.systems)
				{
					if (ps != null)
					{
						ps.Simulate(dt, false, false, false);
					}
				}
			}"""),
    ("""				Object go = l.ps != null ? (Object)l.ps.gameObject : (l.line != null ? l.line.gameObject : null);""",
     """				Object go = l.prefab != null ? l.prefab : l.ps != null ? (Object)l.ps.gameObject : (l.line != null ? l.line.gameObject : null);"""),
])

patch("Prototype/BattleManager.cs", [
    ("""	public GameObject bruxaModel;""", """	public GameObject bruxaModel;
	public GameObject[] effectPrefabs;      // Cartoon FX Remaster Free"""),
    ("""		Vfx.Clear();
""", """		Vfx.Clear();
		Vfx.Register(effectPrefabs);
"""),
    ("""Vfx.Hit(who.Position + Vector3.up * 0.2f, who.opponent.def.color, crit);""",
     """Vfx.Hit(who.Position + Vector3.up * 0.2f, who.opponent.def.color, crit, who.opponent.def.skills[0].projectileSpeed > 0f);"""),
])

patch("Editor/Reconstruction/PrototypeSetup.cs", [
    ("""		bm.machadinhaModel = AssetDatabase.LoadAssetAtPath<GameObject>(BarbarianPath);""",
     """		bm.machadinhaModel = AssetDatabase.LoadAssetAtPath<GameObject>(BarbarianPath);
		System.Collections.Generic.List<GameObject> fx = new System.Collections.Generic.List<GameObject>();
		foreach (string guid in AssetDatabase.FindAssets("CFXR t:Prefab"))
		{
			fx.Add(AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(guid)));
		}
		bm.effectPrefabs = fx.ToArray();"""),
])
print("ok")
