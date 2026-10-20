using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;

// Efeitos da espada do Cavaleiro, so Particle System + shader proprio, sem luz.
// Menu: Arena Masters/VFX/Montar Espada do Cavaleiro.
//   Resources/VFX_FaiscasLamina   faiscas azul-roxo soltando da lamina, subindo devagar (8 vivas no maximo)
//   Materials/M_BrilhoLamina      camada de brilho (fio + runa) da espada, shader "Brilho Lamina"
public static class VfxCavaleiroBuilder
{
	private const string Root = "Assets/VFX";
	public const string MaterialBrilho = Root + "/Materials/M_BrilhoLamina.mat";
	public static readonly Color Cor = new Color(0.7f, 0.55f, 6.5f, 1f);   // emissao (forte: o tonemapping clareia e o bloom espalha)

	[MenuItem("Arena Masters/VFX/Montar Espada do Cavaleiro")]
	public static void Build()
	{
		Material brilho = new Material(Shader.Find("ArenaMasters/VFX/Brilho Lamina"));
		brilho.SetColor("_Color", Cor);
		brilho.SetFloat("_Brilho", 1f);
		brilho.SetFloat("_Fio", 0.04f);
		brilho.SetFloat("_Runa", 1.3f);
		B.SaveAsset(brilho, MaterialBrilho);

		Shader shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		Material faisca = new Material(shader);
		faisca.SetTexture("_MainTex", AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Spark.png"));
		faisca.SetTexture("_NoiseTex", AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png"));
		faisca.SetColor("_Color", new Color(0.6f, 0.5f, 2.6f, 1f));
		faisca.SetColor("_CoreColor", new Color(1.6f, 1.6f, 3.2f, 1f));
		faisca.SetFloat("_CorePower", 1f);
		faisca.SetFloat("_Distortion", 0f);
		faisca = B.SaveAsset(faisca, Root + "/Materials/M_FaiscaLamina.mat");

		GameObject go = new GameObject("VFX_FaiscasLamina");
		ParticleSystem ps = B.NewSystem(go.transform, "Faiscas", faisca, 8);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.prewarm = true;
		main.duration = 2f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;   // ficam no ar quando a espada se mexe
		main.startLifetime = new ParticleSystem.MinMaxCurve(1.1f, 1.8f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.035f, 0.07f);
		main.startColor = Color.white;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 4f;   // ~6 vivas ao mesmo tempo
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Box;   // ao longo da lamina (espaco da espada: y 0,3 ate 1,35)
		shape.position = new Vector3(0f, 0.82f, 0f);
		shape.scale = new Vector3(0.22f, 1.05f, 0.04f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(-0.06f, 0.06f);   // os 3 eixos com o mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.12f, 0.3f);
		v.z = new ParticleSystem.MinMaxCurve(-0.06f, 0.06f);
		ParticleSystem.NoiseModule n = ps.noise;
		n.enabled = true;
		n.strength = 0.15f;
		n.frequency = 1.2f;
		n.quality = ParticleSystemNoiseQuality.Low;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.4f, 0.25f, 1f, 1f, 0f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.35f);
		B.SavePrefab(go, Root + "/Resources/VFX_FaiscasLamina.prefab");

		// ultimate pronta: a espada fica escondida atras do corpo vista de cima nas poses de parado/correndo,
		// entao o aviso precisa sair do contorno do heroi: halo grande pulsando + faiscas subindo mais rapido
		Material halo = new Material(shader);
		halo.SetTexture("_MainTex", AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Spark.png"));
		halo.SetTexture("_NoiseTex", AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png"));
		halo.SetColor("_Color", new Color(0.35f, 0.28f, 1.6f, 1f));
		halo.SetColor("_CoreColor", new Color(0.6f, 0.5f, 2.4f, 1f));
		halo.SetFloat("_CorePower", 2f);
		halo.SetFloat("_Distortion", 0f);
		halo = B.SaveAsset(halo, Root + "/Materials/M_HaloLamina.mat");

		go = new GameObject("VFX_LaminaPronta");
		ParticleSystem h = B.NewSystem(go.transform, "Halo", halo, 2);
		h.transform.localPosition = new Vector3(0f, 0.8f, 0f);
		main = h.main;
		main.loop = true;
		main.prewarm = true;
		main.duration = 1f;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;   // preso na espada
		main.startLifetime = 1f;
		main.startSize = 1.7f;
		main.startSpeed = 0f;
		main.startColor = Color.white;
		em = h.emission;
		em.rateOverTime = 2f;   // 2 halos sobrepostos, cada um nasce e some em 1 s: pulso
		ParticleSystem.ShapeModule semForma = h.shape;
		semForma.enabled = false;
		s = h.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.8f, 0.5f, 1f, 1f, 0.85f));
		c = h.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(0f, 0f), new GradientAlphaKey(0.7f, 0.5f), new GradientAlphaKey(0f, 1f) });
		c.color = g;

		ParticleSystem f = B.NewSystem(go.transform, "FaiscasFortes", faisca, 12);
		main = f.main;
		main.loop = true;
		main.prewarm = true;
		main.duration = 1f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.6f, 1f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.07f, 0.13f);
		main.startSpeed = 0f;
		main.startColor = Color.white;
		em = f.emission;
		em.rateOverTime = 12f;
		shape = f.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Box;
		shape.position = new Vector3(0f, 0.82f, 0f);
		shape.scale = new Vector3(0.22f, 1.05f, 0.04f);
		v = f.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(-0.15f, 0.15f);
		v.y = new ParticleSystem.MinMaxCurve(1.2f, 2.2f);   // sobem acima da cabeca: aparecem de cima
		v.z = new ParticleSystem.MinMaxCurve(-0.15f, 0.15f);
		s = f.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0f));
		c = f.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.4f);
		B.SavePrefab(go, Root + "/Resources/VFX_LaminaPronta.prefab");

		CorteArcano();

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Espada do Cavaleiro montada: M_BrilhoLamina, VFX_FaiscasLamina, VFX_LaminaPronta e VFX_CorteArcano");
	}

	// Skill C (Corte Arcano): meia-lua azul-roxo que voa com o projetil (filha dele) e solta faiscas pelo caminho.
	// Custo: 1 malha do arco (M_ArcoCorte, a mesma do corte de entrada) + no maximo 20 faiscas no mundo
	static void CorteArcano()
	{
		Mesh arco = AssetDatabase.LoadAssetAtPath<Mesh>(Root + "/Meshes/M_ArcoCorte.asset");
		Material baseCorte = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_CorteEsfera.mat");
		if (arco == null || baseCorte == null)
		{
			Debug.LogError("[VFX] falta M_ArcoCorte ou M_CorteEsfera (Montar Machado Barbaro / Skill B)");
			return;
		}
		Material m = new Material(baseCorte);
		m.SetColor("_Color", new Color(0.55f, 0.35f, 2.6f, 1f));
		m.SetColor("_CoreColor", new Color(1.4f, 1.3f, 3.2f, 1f));
		m = B.SaveAsset(m, Root + "/Materials/M_CorteArcano.mat");

		GameObject go = new GameObject("VFX_CorteArcano");
		ParticleSystem ps = B.NewSystem(go.transform, "MeiaLua", m, 1);
		ps.transform.localRotation = Quaternion.Euler(0f, 0f, 12f);   // quase deitada: legivel de cima
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 10f;                    // dura o voo inteiro (o projetil apaga junto)
		main.startSize = 2.1f;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		main.useUnscaledTime = false;
		B.Burst(ps, 0f, 1);
		ParticleSystem.CustomDataModule custom = ps.customData;   // mesmo canal do corte: sem dissolver, varredura aberta
		custom.enabled = true;
		custom.SetMode(ParticleSystemCustomData.Custom1, ParticleSystemCustomDataMode.Vector);
		custom.SetVectorComponentCount(ParticleSystemCustomData.Custom1, 2);
		custom.SetVector(ParticleSystemCustomData.Custom1, 0, new ParticleSystem.MinMaxCurve(0f));
		custom.SetVector(ParticleSystemCustomData.Custom1, 1, new ParticleSystem.MinMaxCurve(-0.15f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Mesh;
		r.mesh = arco;
		r.alignment = ParticleSystemRenderSpace.Local;
		r.SetActiveVertexStreams(new System.Collections.Generic.List<ParticleSystemVertexStream>
		{
			ParticleSystemVertexStream.Position, ParticleSystemVertexStream.Color, ParticleSystemVertexStream.UV,
			ParticleSystemVertexStream.Custom1XY, ParticleSystemVertexStream.StableRandomX,
		});

		Material faisca = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_FaiscaLamina.mat");
		ParticleSystem f = B.NewSystem(go.transform, "Rastro", faisca, 20);
		main = f.main;
		main.loop = true;
		main.useUnscaledTime = false;
		main.simulationSpace = ParticleSystemSimulationSpace.World;   // ficam para tras no caminho
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.25f, 0.45f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.08f, 0.16f);
		main.startColor = Color.white;
		ParticleSystem.EmissionModule em = f.emission;
		em.rateOverTime = 45f;
		ParticleSystem.ShapeModule sh = f.shape;
		sh.enabled = true;
		sh.shapeType = ParticleSystemShapeType.Box;
		sh.scale = new Vector3(1.6f, 0.2f, 0.2f);
		ParticleSystem.SizeOverLifetimeModule s = f.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0f));
		B.SavePrefab(go, Root + "/Resources/VFX_CorteArcano.prefab");
	}
}
