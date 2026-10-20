using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;

// Efeitos das 6 reliquias (Etapa 4), so Particle System + shader proprio, cor HDR, sem luz.
// Menu: Arena Masters/VFX/Montar Reliquias. Prefabs em Assets/VFX/Resources; os que duram (estandarte, pilar, totem,
// auras) ficam em laco e quem cria apaga no fim (EfeitoCor.Criar com a vida). Custo (particulas no maximo):
//   VFX_ReliquiaCura        34 (1 anel + 1 brilho + 32 faiscas subindo), 1,4 s
//   VFX_ReliquiaEgide       15 (1 casca pulsando + 14 faiscas em orbita), aura da barreira
//   VFX_ReliquiaEstandarte  26 (1 anel de 5 m + 1 mastro de luz + 24 brasas)
//   VFX_ReliquiaPilar       34 (1 anel de 4 m + 1 pilar + 32 flocos girando)
//   VFX_ReliquiaVento       20 (12 riscos de vento + 8 de poeira), aura da velocidade
//   VFX_ReliquiaTotem       13 (1 orbe + 1 anel + 11 faiscas em orbita)
public static class VfxReliquiasBuilder
{
	const string Root = "Assets/VFX";
	static Shader s_shader;
	static Texture2D s_noise;

	[MenuItem("Arena Masters/VFX/Montar Reliquias")]
	public static void Build()
	{
		s_shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		s_noise = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png");

		// cura: verde-dourado subindo do chao
		GameObject go = new GameObject("VFX_ReliquiaCura");
		Anel(go.transform, "Anel", Mat("M_RelCuraAnel", "T_Ring", new Color(0.25f, 1.3f, 0.6f), new Color(0.8f, 1.6f, 0.9f)), 2.6f, 0.9f, false);
		Brilho(go.transform, "Coluna", Mat("M_RelCuraBrilho", "T_Spark", new Color(0.5f, 1.8f, 0.9f), new Color(1.5f, 2.2f, 1.2f)), new Vector3(0f, 1.1f, 0f), 2.6f, 1f);
		Subindo(go.transform, "Faiscas", Mat("M_RelCuraFaisca", "T_Spark", new Color(0.6f, 2.4f, 1f), new Color(2f, 2.6f, 1.6f)), 32, 0.9f, 1.4f, 2.5f, false);
		Salvar(go);

		// egide: casca dourada pulsando + faiscas em orbita (aura do buff da barreira)
		go = new GameObject("VFX_ReliquiaEgide");
		Brilho(go.transform, "Casca", Mat("M_RelEgideCasca", "T_Ring", new Color(1.8f, 1.3f, 0.4f), new Color(2.4f, 2f, 1f)), new Vector3(0f, 1f, 0f), 2.6f, -1f);
		Orbita(go.transform, "Faiscas", Mat("M_RelEgideFaisca", "T_Spark", new Color(2f, 1.5f, 0.5f), new Color(2.6f, 2.2f, 1.2f)), 14, 1.0f, 1.2f);
		Salvar(go);

		// estandarte: area de 5 m (anel), mastro de luz vermelho e brasas
		go = new GameObject("VFX_ReliquiaEstandarte");
		Anel(go.transform, "Area", Mat("M_RelEstAnel", "T_Ring", new Color(1.1f, 0.25f, 0.12f), new Color(1.4f, 0.55f, 0.3f)), 10f, -1f, true);
		Mastro(go.transform, "Mastro", Mat("M_RelEstMastro", "T_Spark", new Color(2.4f, 0.6f, 0.3f), new Color(3f, 1.6f, 0.8f)), 3.2f);
		Subindo(go.transform, "Brasas", Mat("M_RelEstBrasa", "T_Spark", new Color(2.4f, 0.8f, 0.3f), new Color(3f, 1.8f, 0.8f)), 24, 4.2f, 1.6f, 1.2f, true);
		Salvar(go);

		// pilar de gelo: anel de 4 m, pilar azul e flocos girando
		go = new GameObject("VFX_ReliquiaPilar");
		Anel(go.transform, "Area", Mat("M_RelPilarAnel", "T_Ring", new Color(0.25f, 0.65f, 1.3f), new Color(0.6f, 1f, 1.5f)), 8f, -1f, true);
		Mastro(go.transform, "Pilar", Mat("M_RelPilarPilar", "T_Spark", new Color(0.6f, 1.4f, 2.6f), new Color(1.6f, 2.2f, 3f)), 2.6f);
		Orbita(go.transform, "Flocos", Mat("M_RelPilarFloco", "T_Spark", new Color(0.8f, 1.6f, 2.6f), new Color(2f, 2.4f, 3f)), 32, 3.2f, 0.6f);
		Salvar(go);

		// vento: riscos de vento em volta do heroi e poeira nos pes (aura da velocidade)
		go = new GameObject("VFX_ReliquiaVento");
		Riscos(go.transform, "Vento", Mat("M_RelVentoRisco", "T_Spark", new Color(0.8f, 2f, 1.6f), new Color(2f, 2.6f, 2.2f)), 12);
		Subindo(go.transform, "Poeira", Mat("M_RelVentoPoeira", "T_Puff", new Color(0.5f, 0.6f, 0.55f), new Color(0.8f, 0.9f, 0.85f)), 8, 0.6f, 0.6f, 0.4f, true);
		Salvar(go);

		// totem: orbe roxo pulsando no alto, anel no chao e faiscas em orbita
		go = new GameObject("VFX_ReliquiaTotem");
		Brilho(go.transform, "Orbe", Mat("M_RelTotemOrbe", "T_Spark", new Color(1f, 0.6f, 2.6f), new Color(2.2f, 1.8f, 3f)), new Vector3(0f, 1.6f, 0f), 1.1f, -1f);
		Anel(go.transform, "Base", Mat("M_RelTotemAnel", "T_Ring", new Color(0.9f, 0.5f, 2.2f), new Color(1.8f, 1.4f, 2.8f)), 1.8f, -1f, true);
		Orbita(go.transform, "Faiscas", Mat("M_RelTotemFaisca", "T_Spark", new Color(1f, 0.7f, 2.6f), new Color(2.2f, 2f, 3f)), 11, 0.7f, 1.6f);
		Salvar(go);

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] reliquias montadas: 6 prefabs em Assets/VFX/Resources");
	}

	static Material Mat(string nome, string tex, Color cor, Color miolo)
	{
		Material m = new Material(s_shader);
		m.SetTexture("_MainTex", AssetDatabase.LoadAssetAtPath<Texture2D>($"{Root}/Textures/{tex}.png"));
		m.SetTexture("_NoiseTex", s_noise);
		m.SetColor("_Color", cor);
		m.SetColor("_CoreColor", miolo);
		m.SetFloat("_CorePower", 1.5f);
		m.SetFloat("_Distortion", 0f);
		return B.SaveAsset(m, $"{Root}/Materials/{nome}.mat");
	}

	// sistema base: em laco (vida < 0) ou uma vez
	static ParticleSystem Base(Transform pai, string nome, Material m, int max, bool laco)
	{
		ParticleSystem ps = B.NewSystem(pai, nome, m, max);
		ParticleSystem.MainModule main = ps.main;
		main.loop = laco;
		main.useUnscaledTime = false;
		main.startColor = Color.white;
		VfxCornetaBuilder.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0f));   // textura em Clamp precisa dos streams
		return ps;
	}

	// anel deitado no chao (diametro), uma particula; vida < 0 = fica enquanto o efeito existir
	static void Anel(Transform pai, string nome, Material m, float diametro, float vida, bool pulsa)
	{
		bool laco = vida < 0f;
		ParticleSystem ps = Base(pai, nome, m, 1, laco);
		ps.transform.localPosition = new Vector3(0f, 0.06f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = laco ? 1f : vida;
		main.startLifetime = laco ? 1f : vida;
		main.startSize = diametro;
		ParticleSystem.EmissionModule em = ps.emission;
		if (laco)
		{
			em.rateOverTime = 1f;   // uma particula de 1 s por segundo: anel sempre la, renovando
		}
		else
		{
			B.Burst(ps, 0f, 1);
		}
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, laco ? (pulsa ? B.Curve(0f, 0.97f, 0.5f, 1.02f, 1f, 0.97f) : B.Curve(0f, 1f, 1f, 1f)) : B.Curve(0f, 0.2f, 0.3f, 1f, 1f, 1.1f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = laco ? Gradiente(0.75f, 0.75f) : B.Fade(Color.white, 0.4f);
	}

	// brilho parado (billboard); vida < 0 = em laco pulsando
	static void Brilho(Transform pai, string nome, Material m, Vector3 pos, float tamanho, float vida)
	{
		bool laco = vida < 0f;
		ParticleSystem ps = Base(pai, nome, m, 1, laco);
		ps.transform.localPosition = pos;
		ParticleSystem.MainModule main = ps.main;
		main.duration = laco ? 1f : vida;
		main.startLifetime = laco ? 1f : vida;
		main.startSize = tamanho;
		ParticleSystem.EmissionModule em = ps.emission;
		if (laco)
		{
			em.rateOverTime = 1f;
		}
		else
		{
			B.Burst(ps, 0f, 1);
		}
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, laco ? B.Curve(0f, 0.92f, 0.5f, 1.05f, 1f, 0.92f) : B.Curve(0f, 0.3f, 0.25f, 1f, 1f, 0.6f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = laco ? Gradiente(0.35f, 0.55f) : B.Fade(Color.white, 0.3f);
	}

	// coluna de luz esticada (mastro do estandarte, pilar de gelo)
	static void Mastro(Transform pai, string nome, Material m, float altura)
	{
		ParticleSystem ps = Base(pai, nome, m, 1, true);
		ps.transform.localPosition = new Vector3(0f, altura * 0.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 1f;
		main.startSize3D = true;
		main.startSizeX = 0.55f;
		main.startSizeY = altura;
		main.startSizeZ = 1f;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 1f;
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.VerticalBillboard;
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = Gradiente(0.8f, 0.9f);
	}

	// particulas subindo de um disco (raio); laco = continuo, senao uma rajada
	static void Subindo(Transform pai, string nome, Material m, int max, float raio, float vida, float velocidade, bool laco)
	{
		ParticleSystem ps = Base(pai, nome, m, max, laco);
		ParticleSystem.MainModule main = ps.main;
		main.duration = laco ? 1f : 0.5f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(vida * 0.6f, vida);
		main.startSize = new ParticleSystem.MinMaxCurve(0.08f, 0.18f);
		ParticleSystem.EmissionModule em = ps.emission;
		if (laco)
		{
			em.rateOverTime = max / vida;
		}
		else
		{
			B.Burst(ps, 0f, max);
		}
		ParticleSystem.ShapeModule sh = ps.shape;
		sh.enabled = true;
		sh.shapeType = ParticleSystemShapeType.Circle;
		sh.radius = raio;
		sh.rotation = new Vector3(90f, 0f, 0f);   // disco deitado
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(-0.1f, 0.1f);
		v.y = new ParticleSystem.MinMaxCurve(velocidade * 0.6f, velocidade);
		v.z = new ParticleSystem.MinMaxCurve(-0.1f, 0.1f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.5f, 0.2f, 1f, 1f, 0f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.5f);
	}

	// particulas girando em volta do centro (orbita), em laco
	static void Orbita(Transform pai, string nome, Material m, int max, float raio, float altura)
	{
		ParticleSystem ps = Base(pai, nome, m, max, true);
		ps.transform.localPosition = new Vector3(0f, altura, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(1.2f, 1.8f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.07f, 0.15f);
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = max / 1.5f;
		ParticleSystem.ShapeModule sh = ps.shape;
		sh.enabled = true;
		sh.shapeType = ParticleSystemShapeType.Circle;
		sh.radius = raio;
		sh.radiusThickness = 0.2f;
		sh.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.orbitalX = new ParticleSystem.MinMaxCurve(0f);
		v.orbitalY = new ParticleSystem.MinMaxCurve(2.2f);
		v.orbitalZ = new ParticleSystem.MinMaxCurve(0f);
		v.x = new ParticleSystem.MinMaxCurve(0f);
		v.y = new ParticleSystem.MinMaxCurve(0.35f);
		v.z = new ParticleSystem.MinMaxCurve(0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0f, 0.2f, 1f, 1f, 0f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.6f);
	}

	// riscos de vento esticados na direcao do movimento (em volta do heroi)
	static void Riscos(Transform pai, string nome, Material m, int max)
	{
		ParticleSystem ps = Base(pai, nome, m, max, true);
		ps.transform.localPosition = new Vector3(0f, 0.9f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.25f, 0.4f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.08f, 0.14f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;   // ficam para tras quando o heroi corre
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = max / 0.35f;
		ParticleSystem.ShapeModule sh = ps.shape;
		sh.enabled = true;
		sh.shapeType = ParticleSystemShapeType.Sphere;
		sh.radius = 0.7f;
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.12f;
		r.lengthScale = 2.5f;
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(0f);
		v.y = new ParticleSystem.MinMaxCurve(0.4f);
		v.z = new ParticleSystem.MinMaxCurve(-3f);
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.3f);
	}

	static Gradient Gradiente(float alfaMeio, float alfaFim)
	{
		Gradient g = new Gradient();
		g.SetKeys(new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(alfaFim, 0f), new GradientAlphaKey(alfaMeio + 0.2f, 0.5f), new GradientAlphaKey(alfaFim, 1f) });
		return g;
	}

	static void Salvar(GameObject go)
	{
		go.AddComponent<EfeitoCor>();
		B.SavePrefab(go, $"{Root}/Resources/{go.name}.prefab");
	}
}
