using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;
using C = VfxCornetaBuilder;

// Monta os efeitos da Investida do Bufalo (Axie) so com Particle System + shader proprio.
// Menu: Arena Masters/VFX/Montar Investida do Bufalo. Refaz materiais e prefabs (atualiza no lugar, mantem GUID).
//   Resources/VFX_BufaloCorrida  preso no Axie durante a corrida (0,35 s): brilho na cabeca, linhas de vento, poeira nos pes
//   Resources/VFX_BufaloImpacto  na cabecada: clarao, onda de choque de frente para a camera, onda no chao, faiscas, poeira
// Tempos: a corrida e a antecipacao (rastro crescendo); o impacto sai todo junto e a poeira se dissipa devagar (~1 s).
// Particulas vivas no maximo: corrida 1 + 10 + 18 = 29; impacto 1 + 1 + 1 + 18 + 8 = 29.
public static class VfxBufaloBuilder
{
	private const string Root = "Assets/VFX";
	private static readonly Color Fury = new Color(1f, 0.45f, 0.2f);

	[MenuItem("Arena Masters/VFX/Montar Investida do Bufalo")]
	public static void Build()
	{
		Shader shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		Texture2D ring = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Ring.png");
		Texture2D noise = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png");
		Texture2D spark = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Spark.png");
		Material dust = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_PoeiraTerra.mat");
		if (shader == null || ring == null || noise == null || spark == null || dust == null)
		{
			Debug.LogError("[VFX] faltam shader, texturas ou M_PoeiraTerra (rode tools/gen_vfx_textures.py e Montar Golpe da Terra)");
			return;
		}

		Material wave = new Material(shader);
		wave.SetTexture("_MainTex", ring);
		wave.SetTexture("_NoiseTex", noise);
		wave.SetTextureScale("_NoiseTex", new Vector2(2f, 2f));
		wave.SetVector("_NoiseScroll", new Vector4(0.4f, 0.3f, 0f, 0f));
		wave.SetColor("_Color", new Color(2.4f, 0.9f, 0.35f, 1f));
		wave.SetColor("_CoreColor", new Color(4f, 2.6f, 1.6f, 1f));
		wave.SetFloat("_CorePower", 1.5f);
		wave.SetColor("_EdgeColor", new Color(4f, 1.4f, 0.4f, 1f));
		wave.SetFloat("_Distortion", 0.03f);
		wave = B.SaveAsset(wave, Root + "/Materials/M_OndaBufalo.mat");

		Material sparkMat = new Material(shader);
		sparkMat.SetTexture("_MainTex", spark);
		sparkMat.SetTexture("_NoiseTex", noise);
		sparkMat.SetColor("_Color", new Color(3f, 1.1f, 0.4f, 1f));
		sparkMat.SetColor("_CoreColor", new Color(4f, 2.8f, 1.6f, 1f));
		sparkMat.SetFloat("_CorePower", 1f);
		sparkMat.SetFloat("_Distortion", 0f);
		sparkMat = B.SaveAsset(sparkMat, Root + "/Materials/M_FaiscaBufalo.mat");

		GameObject run = new GameObject("VFX_BufaloCorrida");
		HeadGlow(run.transform, sparkMat);
		WindLines(run.transform, sparkMat);
		RunDust(run.transform, dust);
		B.SavePrefab(run, Root + "/Resources/VFX_BufaloCorrida.prefab");

		GameObject hit = new GameObject("VFX_BufaloImpacto");
		Flash(hit.transform, sparkMat);
		FrontWave(hit.transform, wave);
		GroundWave(hit.transform, wave);
		Sparks(hit.transform, sparkMat);
		ImpactDust(hit.transform, dust);
		B.SavePrefab(hit, Root + "/Resources/VFX_BufaloImpacto.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Investida do Bufalo montada: VFX_BufaloCorrida e VFX_BufaloImpacto");
	}

	// ---------- corrida (filho do Axie: centro do corpo em y = 0, pes em y = -0,95, frente = +Z) ----------

	// brilho pulsando na cabeca, que vai na frente (o Axie corre de cabeca baixa)
	private static void HeadGlow(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Cabeca", mat, 1);
		ps.transform.localPosition = new Vector3(0f, 0.15f, 0.55f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 0.35f;
		main.startLifetime = 0.4f;
		main.startSize = 1.3f;
		main.startColor = Fury;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.4f, 0.8f, 1f, 1f, 1.2f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(0.2f, 0f), new GradientAlphaKey(1f, 0.8f), new GradientAlphaKey(0f, 1f) });
		c.color = g;
	}

	// linhas de vento passando pelo corpo de frente para tras
	private static void WindLines(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Vento", mat, 10);
		ps.transform.localPosition = new Vector3(0f, 0f, 0.9f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 0.35f;
		main.startLifetime = 0.16f;
		main.startSize = new ParticleSystem.MinMaxCurve(0.08f, 0.14f);
		main.startColor = new Color(1f, 0.85f, 0.7f, 1f);
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 45f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.6f;
		shape.radiusThickness = 0.3f;   // so na borda: as linhas contornam o corpo
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.z = new ParticleSystem.MinMaxCurve(-14f, -10f);
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.3f);
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.06f;
		r.lengthScale = 3f;
	}

	// poeira levantada pelos pes, fica no chao (mundo) e se espalha
	private static void RunDust(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Poeira", mat, 18);
		ps.transform.localPosition = new Vector3(0f, -0.6f, -0.2f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 0.35f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.5f, 0.8f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.45f, 0.75f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.6f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 0f;
		em.rateOverDistance = 3f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.35f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.y = new ParticleSystem.MinMaxCurve(0.4f, 0.9f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.5f, 1f, 1.6f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.4f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.4f, 0f, 1f, 1f));
	}

	// ---------- impacto (nasce no ponto da cabecada, na altura do peito; frente = +Z) ----------

	private static void Flash(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Clarao", mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.14f;
		main.startSize = 2.8f;
		main.startColor = Fury;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.2f);
	}

	// anel de choque virado para a camera, abre rapido e queima no dissolve
	private static void FrontWave(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Onda", mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.3f;
		main.startSize = 3.2f;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.15f, 0.4f, 0.85f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f));
	}

	private static void GroundWave(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "OndaChao", mat, 1);
		ps.transform.localPosition = new Vector3(0f, -0.9f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.45f;
		main.startSize = 3.6f;
		main.startColor = new Color(1f, 1f, 1f, 0.8f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.15f, 0.35f, 0.8f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}

	// faiscas espirrando para a frente e para os lados (meia esfera virada para +Z)
	private static void Sparks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Faiscas", mat, 18);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.25f, 0.5f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.06f, 0.12f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(6f, 11f);
		main.startColor = Fury;
		main.gravityModifier = 0.6f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 18);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Hemisphere;
		shape.radius = 0.2f;
		shape.rotation = new Vector3(0f, 0f, 0f);   // hemisferio aponta para +Z
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.08f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.05f;
		r.lengthScale = 1.5f;
	}

	private static void ImpactDust(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Poeira", mat, 8);
		ps.transform.localPosition = new Vector3(0f, -0.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.7f, 1.1f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.6f, 1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(2f, 3.5f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.7f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 8);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.3f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.12f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.2f, 1f, 1.7f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.5f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.35f, 0f, 1f, 1f));
	}
}
