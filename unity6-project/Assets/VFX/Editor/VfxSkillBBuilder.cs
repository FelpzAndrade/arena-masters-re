using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;
using C = VfxCornetaBuilder;

// Efeitos da Skill B (esfera giratoria, Docs/ficha_skills_referencia.md) e o acerto padrao do combate_spec.md.
// Menu: Arena Masters/VFX/Montar Skill B (esfera). Nada aqui sabe de heroi: a cor vem do componente EfeitoCor
// (troca por heroi) e a escala de quem cria. Prefabs em Assets/VFX/Resources:
//   VFX_EsferaGiratoria  0,75 s presa no heroi (centro do corpo): 3 aneis de risco girando em eixos diferentes, borda clara,
//                        nucleo escuro atras do heroi e faiscas em orbita. Surge ja cheia e some seco (corte de 0,07 s).
//                        Particulas: 3 + 1 + 1 + 18 = 23
//   VFX_CorteEntrada     corte curto em arco na frente (golpe de entrada da skill), respingo escuro e clarao. 1 + 8 + 1 = 10
//   VFX_ImpactoGolpe     acerto (elementos 1, 2 e 3 do combate_spec.md): anel que cresce + 2o anel fino 0,05 s depois,
//                        riscos esticados amarelo/branco e clarao branco/amarelo de 2-3 quadros. Cor fixa. 1 + 1 + 14 + 1 = 17
public static class VfxSkillBBuilder
{
	private const string Root = "Assets/VFX";
	private static Shader s_shader;
	private static Texture2D s_noise;

	[MenuItem("Arena Masters/VFX/Montar Skill B (esfera)")]
	public static void Build()
	{
		s_shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		s_noise = Tex("T_Noise");
		Texture2D streak = Tex("T_AnelRisco"), ring = Tex("T_Ring"), spark = Tex("T_Spark"), slash = Tex("T_SlashMask"), puff = Tex("T_Puff");
		Mesh arc = AssetDatabase.LoadAssetAtPath<Mesh>(Root + "/Meshes/M_ArcoCorte.asset");
		if (s_shader == null || streak == null || ring == null || spark == null || slash == null || puff == null || arc == null)
		{
			Debug.LogError("[VFX] faltam shader, texturas (tools/gen_vfx_textures.py) ou M_ArcoCorte (Montar Machado Barbaro)");
			return;
		}
		C.SetClamp(streak);
		Mesh quad = B.SaveAsset(BuildQuad(), Root + "/Meshes/M_QuadChao.asset");

		// materiais com cor neutra: o EfeitoCor pinta por heroi (os fixos ja tem a cor final)
		Material anel = Mat("M_AnelEsfera", streak, Color.white, Color.white, 1.4f, 0.02f, 1f);
		anel.SetVector("_NoiseScroll", new Vector4(-1.5f, 0.3f, 0f, 0f));
		Material borda = Mat("M_BordaEsfera", ring, Color.white, Color.white, 1.5f, 0.02f, 1f);
		Material nucleo = Mat("M_NucleoEsfera", spark, new Color(0.16f, 0.05f, 0.32f), new Color(0.3f, 0.1f, 0.55f), 1f, 0f, 0f);   // roxo escuro atras do heroi
		Material faisca = Mat("M_FaiscaEsfera", spark, Color.white, Color.white, 1f, 0f, 1f);
		Material corte = Mat("M_CorteEsfera", slash, Color.white, Color.white, 2f, 0.04f, 1f);
		corte.SetTextureScale("_NoiseTex", new Vector2(2.5f, 1f));
		corte.SetVector("_NoiseScroll", new Vector4(-0.8f, 0.15f, 0f, 0f));
		Material respingo = Mat("M_RespingoEscuro", puff, new Color(0.05f, 0.02f, 0.06f), new Color(0.12f, 0.04f, 0.1f), 1f, 0.04f, 0f);
		respingo.SetColor("_EdgeColor", Color.black);
		Material clarao = Mat("M_ClaraoImpacto", spark, new Color(4f, 2.6f, 0.8f), new Color(6f, 5.6f, 5f), 1.2f, 0f, 1f);
		Material risco = Mat("M_RiscoImpacto", spark, new Color(4f, 3f, 1.2f), new Color(6f, 5.5f, 4.5f), 1f, 0f, 1f);
		Material anelImpacto = Mat("M_AnelImpacto", ring, new Color(3.5f, 2.4f, 0.8f), new Color(6f, 5f, 3.5f), 1.5f, 0.03f, 1f);

		// ---------- esfera ----------
		GameObject go = new GameObject("VFX_EsferaGiratoria");
		List<EfeitoCor.Parte> partes = new List<EfeitoCor.Parte>();
		Vector3[] tilts = { new Vector3(14f, 0f, 0f), new Vector3(-58f, 35f, 0f), new Vector3(62f, -50f, 20f) };
		float[] spins = { 17f, -21f, 14f };
		float[] sizes = { 2.5f, 2.3f, 2.15f };
		for (int i = 0; i < 3; i++)
		{
			ParticleSystemRenderer r = Ring(go.transform, "Anel" + (i + 1), anel, quad, tilts[i], spins[i], sizes[i]);
			partes.Add(new EfeitoCor.Parte { renderer = r, brilho = 1.7f, miolo = 0.45f });
		}
		partes.Add(new EfeitoCor.Parte { renderer = Rim(go.transform, borda), brilho = 1.5f, miolo = 0.75f });
		partes.Add(new EfeitoCor.Parte { renderer = Core(go.transform, nucleo), brilho = 0.12f, miolo = 0.1f, fixa = true });   // roxo escuro do material
		partes.Add(new EfeitoCor.Parte { renderer = Orbit(go.transform, faisca), brilho = 3f, miolo = 0.7f });
		EfeitoCor ec = go.AddComponent<EfeitoCor>();
		ec.partes = partes.ToArray();
		B.SavePrefab(go, Root + "/Resources/VFX_EsferaGiratoria.prefab");

		// ---------- corte de entrada ----------
		go = new GameObject("VFX_CorteEntrada");
		partes.Clear();
		partes.Add(new EfeitoCor.Parte { renderer = Cut(go.transform, corte, arc), brilho = 2.6f, miolo = 0.7f });
		Splash(go.transform, respingo);
		partes.Add(new EfeitoCor.Parte { renderer = Flash(go.transform, faisca, new Vector3(0f, 0f, 1.1f), 1.3f, 0.1f), brilho = 3f, miolo = 0.9f });
		ec = go.AddComponent<EfeitoCor>();
		ec.partes = partes.ToArray();
		B.SavePrefab(go, Root + "/Resources/VFX_CorteEntrada.prefab");

		// ---------- acerto padrao (cor fixa amarelo/branco) ----------
		go = new GameObject("VFX_ImpactoGolpe");
		ImpactRing(go.transform, "Anel", anelImpacto, 0f, 2.2f, 1f);
		ImpactRing(go.transform, "AnelFino", anelImpacto, 0.05f, 2.8f, 0.55f);
		Streaks(go.transform, risco);
		Flash(go.transform, clarao, Vector3.zero, 2.4f, 0.08f);
		B.SavePrefab(go, Root + "/Resources/VFX_ImpactoGolpe.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Skill B montada: VFX_EsferaGiratoria, VFX_CorteEntrada, VFX_ImpactoGolpe");
	}

	private static Texture2D Tex(string name) => AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/" + name + ".png");

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

	// quadrado 1x1 deitado no plano XZ (para o anel girar em volta do eixo Y local), sem cor de vertice
	private static Mesh BuildQuad()
	{
		Mesh m = new Mesh
		{
			name = "M_QuadChao",
			vertices = new[] { new Vector3(-0.5f, 0f, -0.5f), new Vector3(0.5f, 0f, -0.5f), new Vector3(-0.5f, 0f, 0.5f), new Vector3(0.5f, 0f, 0.5f) },
			uv = new[] { new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0f, 1f), new Vector2(1f, 1f) },
			triangles = new[] { 0, 2, 1, 1, 2, 3 },
		};
		m.RecalculateNormals();
		m.RecalculateBounds();
		return m;
	}

	// some seco: cheio ate 90% da vida e zero no fim (0,07 s de 0,75 s)
	private static Gradient Cut()
	{
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 0.9f), new GradientAlphaKey(0f, 1f) });
		return g;
	}

	private static ParticleSystem Sphere(Transform parent, string name, Material mat, int max)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, max);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 0.75f;
		main.startLifetime = 0.75f;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;   // vai junto com o heroi
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = Cut();
		return ps;
	}

	// anel de risco: quadrado deitado num eixo inclinado (transform do filho), girando rapido em volta do proprio Y
	private static ParticleSystemRenderer Ring(Transform parent, string name, Material mat, Mesh quad, Vector3 tilt, float spin, float size)
	{
		ParticleSystem ps = Sphere(parent, name, mat, 1);
		ps.transform.localRotation = Quaternion.Euler(tilt);
		ParticleSystem.MainModule main = ps.main;
		main.startSize = size;
		main.startRotation3D = true;
		main.startRotationY = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		B.Burst(ps, 0f, 1);
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.separateAxes = true;
		rot.x = new ParticleSystem.MinMaxCurve(0f);
		rot.y = new ParticleSystem.MinMaxCurve(spin);
		rot.z = new ParticleSystem.MinMaxCurve(0f);
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Mesh;
		r.mesh = quad;
		r.alignment = ParticleSystemRenderSpace.Local;
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0f));   // textura em Clamp: precisa dos streams
		return r;
	}

	// contorno virado para a camera: de cima, a esfera fica com silhueta clara
	private static ParticleSystemRenderer Rim(Transform parent, Material mat)
	{
		ParticleSystem ps = Sphere(parent, "Borda", mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startSize = 2.75f;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1.06f, 0.08f, 1f, 1f, 1f));   // estalo de entrada
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0f));
		return ps.GetComponent<ParticleSystemRenderer>();
	}

	// disco escuro atras do heroi (pivot empurra o billboard para longe da camera: nao cobre o corpo)
	private static ParticleSystemRenderer Core(Transform parent, Material mat)
	{
		ParticleSystem ps = Sphere(parent, "Nucleo", mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startSize = 2.6f;
		main.startColor = new Color(1f, 1f, 1f, 0.55f);
		B.Burst(ps, 0f, 1);
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.pivot = new Vector3(0f, 0f, -0.45f);   // negativo = para longe da camera
		r.sortingFudge = 10f;   // desenha antes dos aneis
		return r;
	}

	private static ParticleSystemRenderer Orbit(Transform parent, Material mat)
	{
		ParticleSystem ps = Sphere(parent, "Faiscas", mat, 18);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.3f, 0.5f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.11f);
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 26f;
		B.Burst(ps, 0f, 8);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 1.15f;
		shape.radiusThickness = 0.15f;
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.orbitalX = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.orbitalY = new ParticleSystem.MinMaxCurve(9f, 13f);
		v.orbitalZ = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.3f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.04f;
		r.lengthScale = 2f;
		return r;
	}

	// corte em arco curto e rapido (mesma malha e mesma logica de avanco do Machado Barbaro, mais curto)
	private static ParticleSystemRenderer Cut(Transform parent, Material mat, Mesh arc)
	{
		ParticleSystem ps = B.NewSystem(parent, "Corte", mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.3f;
		main.startSize = 1.7f;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule size = ps.sizeOverLifetime;
		size.enabled = true;
		size.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.85f, 0.15f, 1.05f, 1f, 1.1f));
		ParticleSystem.CustomDataModule custom = ps.customData;
		custom.enabled = true;
		custom.SetMode(ParticleSystemCustomData.Custom1, ParticleSystemCustomDataMode.Vector);
		custom.SetVectorComponentCount(ParticleSystemCustomData.Custom1, 2);
		custom.SetVector(ParticleSystemCustomData.Custom1, 0, new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f)));
		custom.SetVector(ParticleSystemCustomData.Custom1, 1, new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 0.12f, 0.2f, 0.3f, -0.15f, 1f, -0.5f)));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Mesh;
		r.mesh = arc;
		r.alignment = ParticleSystemRenderSpace.Local;
		r.SetActiveVertexStreams(new List<ParticleSystemVertexStream>
		{
			ParticleSystemVertexStream.Position,
			ParticleSystemVertexStream.Color,
			ParticleSystemVertexStream.UV,
			ParticleSystemVertexStream.Custom1XY,
			ParticleSystemVertexStream.StableRandomX,
		});
		return r;
	}

	// respingo escuro espirrando para a frente do corte (contraste com o azul)
	private static void Splash(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Respingo", mat, 8);
		ps.transform.localPosition = new Vector3(0f, 0f, 1.1f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.3f, 0.5f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.25f, 0.5f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(2f, 4.5f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.gravityModifier = 1.2f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 8);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 40f;
		shape.radius = 0.15f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1f, 1f, 0.7f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.4f, 0f, 1f, 1f));
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
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.7f, 0.35f, 1.1f, 1f, 1.25f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.3f);
		return ps.GetComponent<ParticleSystemRenderer>();
	}

	// elemento 1: anel virado para a camera que cresce rapido e queima no dissolve
	private static void ImpactRing(Transform parent, string name, Material mat, float delay, float size, float alpha)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = delay;
		main.startLifetime = 0.22f;
		main.startSize = size;
		main.startColor = new Color(1f, 1f, 1f, alpha);
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.2f, 0.35f, 0.85f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.35f, 0f, 1f, 1f));
	}

	// elemento 2: riscos esticados saindo do acerto, vida curta
	private static void Streaks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Riscos", mat, 14);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.15f, 0.25f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.06f, 0.12f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(9f, 16f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 14);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 0.15f;
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.12f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.05f;
		r.lengthScale = 2.2f;
	}
}
