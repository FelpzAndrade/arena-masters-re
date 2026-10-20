using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;
using C = VfxCornetaBuilder;

// Efeitos da Skill A (explosao com tela tingida e 2a onda, Docs/ficha_skills_referencia.md), modelo de ultimate.
// Menu: Arena Masters/VFX/Montar Skill A (explosao). A cor vem do EfeitoCor (troca por heroi); partes escuras,
// estilhacos claros e poeira ficam com a cor do material (contraste com qualquer cor de heroi). Assets/VFX/Resources:
//   VFX_UltCarga     brilho branco curto na mao (anuncia o golpe)                       1 + 6 = 7
//   VFX_UltRaio      raio que desce sobre o alvo, piscando 2 vezes                      2 + 1 = 3
//   VFX_UltImpacto   massa escura com borda colorida, onda no chao, clarao, estilhacos azul-claros, respingos escuros,
//                    poeira clara                                                        1+1+1+1+18+10+6 = 38
//   VFX_UltExplosao  uma explosao da 2a onda (o heroi solta 5 em sequencia)               1+1+4+6 = 12
//   VFX_UltFumaca    nuvem escura colorida cobrindo a area, se desfaz devagar, brasas      10 + 10 = 20
// Pico de particulas vivas: 2a onda inteira (5 x 12 = 60) + fumaca (20) = 80.
public static class VfxSkillABuilder
{
	private const string Root = "Assets/VFX";
	private static Shader s_shader;
	private static Texture2D s_noise;

	[MenuItem("Arena Masters/VFX/Montar Skill A (explosao)")]
	public static void Build()
	{
		s_shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		s_noise = Tex("T_Noise");
		Texture2D spark = Tex("T_Spark"), ring = Tex("T_Ring"), boltV = Tex("T_BoltV"), puff = Tex("T_Puff");
		Mesh sphere = AssetDatabase.LoadAssetAtPath<Mesh>(Root + "/Meshes/M_Esfera.asset");
		if (s_shader == null || spark == null || ring == null || boltV == null || puff == null || sphere == null)
		{
			Debug.LogError("[VFX] faltam shader, texturas ou M_Esfera");
			return;
		}

		Material brilho = Mat("M_UltBrilho", spark, Color.white, Color.white, 1f, 0f, 1f);
		Material raio = Mat("M_UltRaio", boltV, Color.white, Color.white, 1.2f, 0.04f, 1f);
		Material massa = Mat("M_UltMassa", null, new Color(0.03f, 0.01f, 0.05f), new Color(0.03f, 0.01f, 0.05f), 1f, 0f, 0f);
		Material onda = Mat("M_UltOnda", ring, Color.white, Color.white, 1.5f, 0.03f, 1f);
		Material estilhaco = Mat("M_UltEstilhaco", spark, new Color(0.9f, 1.8f, 2.6f), new Color(2.2f, 3f, 3.6f), 1f, 0f, 1f);   // azul-claro fixo
		Material respingo = Mat("M_UltRespingo", puff, new Color(0.05f, 0.01f, 0.03f), new Color(0.12f, 0.03f, 0.06f), 1f, 0.04f, 0f);
		respingo.SetColor("_EdgeColor", Color.black);
		Material poeira = Mat("M_UltPoeira", puff, new Color(0.45f, 0.4f, 0.38f), new Color(0.75f, 0.7f, 0.66f), 1f, 0.05f, 0f);
		poeira.SetColor("_EdgeColor", Color.black);
		Material fogo = Mat("M_UltFogo", puff, Color.white, Color.white, 1.2f, 0.06f, 0.8f);
		fogo.SetVector("_NoiseScroll", new Vector4(0.2f, 0.6f, 0f, 0f));
		Material fumaca = Mat("M_UltFumaca", puff, new Color(0.03f, 0.008f, 0.05f), new Color(0.07f, 0.02f, 0.11f), 1f, 0.06f, 0f);   // escura: a exposicao da tela (+1,4) clareia
		fumaca.SetColor("_EdgeColor", new Color(0.12f, 0.03f, 0.2f));   // borda do dissolve discreta (clara demais virava nevoa lilas)
		fumaca.SetVector("_NoiseScroll", new Vector4(0.05f, 0.08f, 0f, 0f));

		// ---------- carga na mao ----------
		GameObject go = new GameObject("VFX_UltCarga");
		Flash(go.transform, brilho, Vector3.zero, 0.9f, 0.14f);
		Glints(go.transform, brilho);
		B.SavePrefab(go, Root + "/Resources/VFX_UltCarga.prefab");

		// ---------- raio de cima ----------
		go = new GameObject("VFX_UltRaio");
		List<EfeitoCor.Parte> partes = new List<EfeitoCor.Parte>();
		partes.Add(new EfeitoCor.Parte { renderer = SkyBolt(go.transform, raio), brilho = 2.2f, miolo = 0.6f });
		partes.Add(new EfeitoCor.Parte { renderer = Flash(go.transform, brilho, new Vector3(0f, 0.4f, 0f), 1.8f, 0.12f), brilho = 2.5f, miolo = 0.7f });
		Cor(go, partes);
		B.SavePrefab(go, Root + "/Resources/VFX_UltRaio.prefab");

		// ---------- impacto principal ----------
		go = new GameObject("VFX_UltImpacto");
		partes.Clear();
		Mass(go.transform, massa, sphere);
		partes.Add(new EfeitoCor.Parte { renderer = MassRim(go.transform, onda), brilho = 2f, miolo = 0.35f });
		partes.Add(new EfeitoCor.Parte { renderer = GroundWave(go.transform, onda, 7f, 0.5f, 0f), brilho = 1.8f, miolo = 0.4f });
		partes.Add(new EfeitoCor.Parte { renderer = Flash(go.transform, brilho, new Vector3(0f, 0.9f, 0f), 3.2f, 0.12f), brilho = 2.4f, miolo = 0.8f });
		Shards(go.transform, estilhaco, 18);
		Splash(go.transform, respingo, 10);
		Dust(go.transform, poeira, 6);
		Cor(go, partes);
		B.SavePrefab(go, Root + "/Resources/VFX_UltImpacto.prefab");

		// ---------- explosao da 2a onda ----------
		go = new GameObject("VFX_UltExplosao");
		partes.Clear();
		partes.Add(new EfeitoCor.Parte { renderer = Flash(go.transform, brilho, new Vector3(0f, 0.5f, 0f), 1.6f, 0.08f), brilho = 1.4f, miolo = 0.4f });
		partes.Add(new EfeitoCor.Parte { renderer = GroundWave(go.transform, onda, 2.6f, 0.3f, 0f), brilho = 1.8f, miolo = 0.4f });
		partes.Add(new EfeitoCor.Parte { renderer = Fireball(go.transform, fogo), brilho = 1.1f, miolo = 0.3f });
		partes.Add(new EfeitoCor.Parte { renderer = Sparks(go.transform, brilho, 6), brilho = 2.4f, miolo = 0.6f });
		Cor(go, partes);
		B.SavePrefab(go, Root + "/Resources/VFX_UltExplosao.prefab");

		// ---------- fumaca residual ----------
		go = new GameObject("VFX_UltFumaca");
		partes.Clear();
		Smoke(go.transform, fumaca);
		partes.Add(new EfeitoCor.Parte { renderer = Embers(go.transform, brilho), brilho = 2f, miolo = 0.5f });
		Cor(go, partes);
		B.SavePrefab(go, Root + "/Resources/VFX_UltFumaca.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Skill A montada: VFX_UltCarga, VFX_UltRaio, VFX_UltImpacto, VFX_UltExplosao, VFX_UltFumaca");
	}

	private static Texture2D Tex(string name) => AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/" + name + ".png");

	private static void Cor(GameObject go, List<EfeitoCor.Parte> partes)
	{
		go.AddComponent<EfeitoCor>().partes = partes.ToArray();
	}

	private static Material Mat(string name, Texture2D tex, Color color, Color core, float corePower, float distortion, float additive)
	{
		Material m = new Material(s_shader);
		m.SetTexture("_MainTex", tex);
		m.SetTexture("_NoiseTex", s_noise);
		m.SetColor("_Color", color);
		m.SetColor("_CoreColor", core);
		m.SetFloat("_CorePower", corePower);
		m.SetFloat("_Distortion", distortion);
		m.SetFloat("_Additive", additive);
		m.SetColor("_EdgeColor", core);
		return B.SaveAsset(m, Root + "/Materials/" + name + ".mat");
	}

	private static ParticleSystemRenderer Flash(Transform parent, Material mat, Vector3 pos, float size, float life)
	{
		ParticleSystem ps = B.NewSystem(parent, "Clarao", mat, 1);
		ps.transform.localPosition = pos;
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = life;
		main.startSize = size;
		main.startColor = Color.white;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.25f);
		return ps.GetComponent<ParticleSystemRenderer>();
	}

	private static void Glints(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Pontos", mat, 6);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.15f, 0.3f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(1.5f, 3f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 6);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 0.1f;
		Stretch(ps, 0.05f, 1.6f);
	}

	private static void Stretch(ParticleSystem ps, float velocityScale, float lengthScale)
	{
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = velocityScale;
		r.lengthScale = lengthScale;
	}

	// raio vertical de 9 m, piscando duas vezes (mesma ideia do Relampago do Spark, outra cor)
	private static ParticleSystemRenderer SkyBolt(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Raio", mat, 2);
		ps.transform.localPosition = new Vector3(0f, 4.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.2f;
		main.startSize3D = true;
		main.startSizeX = new ParticleSystem.MinMaxCurve(2.2f, 2.8f);
		main.startSizeY = 9f;
		main.startSizeZ = 1f;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.SetBursts(new[] { new ParticleSystem.Burst(0f, 1), new ParticleSystem.Burst(0.07f, 1) });
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(0.4f, 0.35f), new GradientAlphaKey(1f, 0.55f), new GradientAlphaKey(0f, 1f) });
		c.color = g;
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.3f));   // textura em Clamp: precisa dos streams
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.VerticalBillboard;
		return r;
	}

	// massa escura no alvo: esfera quase preta misturada (contraste escuro no meio da tela colorida), cresce e se desfaz
	private static void Mass(Transform parent, Material mat, Mesh sphere)
	{
		ParticleSystem ps = B.NewSystem(parent, "Massa", mat, 1);
		ps.transform.localPosition = new Vector3(0f, 0.8f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.9f;
		main.startSize = 2.6f;
		main.startColor = new Color(1f, 1f, 1f, 0.85f);
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.4f, 0.1f, 1.1f, 0.6f, 1.2f, 1f, 1.35f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.55f, 0f, 1f, 1f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Mesh;
		r.mesh = sphere;
		r.alignment = ParticleSystemRenderSpace.Local;
		r.sortingFudge = 10f;
	}

	// borda colorida da massa (anel virado para a camera)
	private static ParticleSystemRenderer MassRim(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "BordaMassa", mat, 1);
		ps.transform.localPosition = new Vector3(0f, 0.8f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.9f;
		main.startSize = 3.6f;
		main.startColor = Color.white;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.4f, 0.1f, 1.05f, 1f, 1.3f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.5f, 0f, 1f, 1f));
		return ps.GetComponent<ParticleSystemRenderer>();
	}

	private static ParticleSystemRenderer GroundWave(Transform parent, Material mat, float size, float life, float delay)
	{
		ParticleSystem ps = B.NewSystem(parent, "Onda", mat, 1);
		ps.transform.localPosition = new Vector3(0f, 0.06f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = delay;
		main.startLifetime = life;
		main.startSize = size;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.15f, 0.35f, 0.8f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.HorizontalBillboard;
		return r;
	}

	// estilhacos azul-claros (cor fixa: contraste frio com qualquer cor de ultimate)
	private static void Shards(Transform parent, Material mat, int count)
	{
		ParticleSystem ps = B.NewSystem(parent, "Estilhacos", mat, count);
		ps.transform.localPosition = new Vector3(0f, 0.8f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = 0.05f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.4f, 0.8f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.07f, 0.14f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(6f, 12f);
		main.gravityModifier = 1.2f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, count);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Hemisphere;
		shape.radius = 0.4f;
		shape.rotation = new Vector3(-90f, 0f, 0f);   // meia esfera para cima
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.05f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.3f));
		Stretch(ps, 0.05f, 2f);
	}

	private static void Splash(Transform parent, Material mat, int count)
	{
		ParticleSystem ps = B.NewSystem(parent, "Respingos", mat, count);
		ps.transform.localPosition = new Vector3(0f, 0.6f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.5f, 0.9f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.35f, 0.7f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(3f, 6f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.gravityModifier = 1.4f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, count);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Hemisphere;
		shape.radius = 0.3f;
		shape.rotation = new Vector3(-90f, 0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1f, 1f, 0.8f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.5f, 0f, 1f, 1f));
	}

	private static void Dust(Transform parent, Material mat, int count)
	{
		ParticleSystem ps = B.NewSystem(parent, "Poeira", mat, count);
		ps.transform.localPosition = new Vector3(0f, 0.4f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = 0.1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(1f, 1.5f);
		main.startSize = new ParticleSystem.MinMaxCurve(1f, 1.6f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(1.5f, 3f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.6f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, count);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.6f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.12f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.1f, 1f, 1.6f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.5f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.4f, 0f, 1f, 1f));
	}

	// bola de fogo da explosao: poucos puffs aditivos que estouram e queimam no dissolve
	private static ParticleSystemRenderer Fireball(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Fogo", mat, 4);
		ps.transform.localPosition = new Vector3(0f, 0.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.35f, 0.55f);
		main.startSize = new ParticleSystem.MinMaxCurve(1f, 1.6f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(0.5f, 1.5f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 4);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 0.3f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.4f, 0.25f, 1f, 1f, 1.25f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f));
		return ps.GetComponent<ParticleSystemRenderer>();
	}

	private static ParticleSystemRenderer Sparks(Transform parent, Material mat, int count)
	{
		ParticleSystem ps = B.NewSystem(parent, "Faiscas", mat, count);
		ps.transform.localPosition = new Vector3(0f, 0.4f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.25f, 0.45f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(5f, 9f);
		main.gravityModifier = 1f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, count);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Hemisphere;
		shape.radius = 0.2f;
		shape.rotation = new Vector3(-90f, 0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		Stretch(ps, 0.05f, 1.6f);
		return ps.GetComponent<ParticleSystemRenderer>();
	}

	// nuvem escura cobrindo a area: aparece macia, segura e se desfaz devagar (dissolve de ~1 s)
	private static void Smoke(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Fumaca", mat, 10);
		ps.transform.localPosition = new Vector3(0f, 0.6f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 2.6f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(1.8f, 2.4f);
		main.startSize = new ParticleSystem.MinMaxCurve(2f, 3f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(0.2f, 0.6f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.75f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 10);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 2.6f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.15f, 0.4f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(-0.4f, 0.4f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.25f, 1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(0f, 0f), new GradientAlphaKey(1f, 0.15f), new GradientAlphaKey(1f, 1f) });
		c.color = g;
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.5f, 0f, 1f, 1f));   // desfaz devagar na segunda metade da vida
	}

	private static ParticleSystemRenderer Embers(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Brasas", mat, 10);
		ps.transform.localPosition = new Vector3(0f, 0.3f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 2f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(1f, 1.6f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.04f, 0.08f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 6f;
		B.Burst(ps, 0f, 4);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 2.4f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(-0.15f, 0.15f);
		v.y = new ParticleSystem.MinMaxCurve(0.8f, 1.6f);
		v.z = new ParticleSystem.MinMaxCurve(-0.15f, 0.15f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0f));
		return ps.GetComponent<ParticleSystemRenderer>();
	}
}
