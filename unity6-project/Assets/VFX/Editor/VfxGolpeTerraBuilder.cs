using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;
using C = VfxCornetaBuilder;

// Monta os efeitos do Golpe da Terra (Axie) so com Particle System + shader proprio.
// Menu: Arena Masters/VFX/Montar Golpe da Terra. Refaz materiais e prefabs (atualiza no lugar, mantem GUID).
//   Resources/VFX_GolpeTerra  o impacto: rachadura com lava que esfria, brilho, onda de terra, clarao, poeira, pedras, brasas
//   Resources/VFX_ForcaTerra  aura do buff Forca da Terra nos pes: anel de terra, pedrinhas girando e subindo, poeira
// O prefab nasce no ponto onde o machado bate (+Z = frente do Axie), feito para alcance 3 m (escala 1).
// Tempos: a antecipacao fica na animacao (Golpe_Terra ergue o machado ate o quadro 7, bate no 10); no impacto sai tudo
// junto e a dissipacao e lenta (lava esfria em ~0,6 s, rachadura se desfaz no dissolve ate 1,8 s, poeira ate ~1,4 s).
// Particulas vivas no maximo: impacto 1 + 1 + 1 + 1 + 16 + 10 + 12 = 42; aura 2 + 8 + 4 = 14.
public static class VfxGolpeTerraBuilder
{
	private const string Root = "Assets/VFX";
	public const float ReferenceRange = 3f;
	private static readonly Color Lava = new Color(1f, 0.55f, 0.2f);

	[MenuItem("Arena Masters/VFX/Montar Golpe da Terra")]
	public static void Build()
	{
		Shader shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		Texture2D crack = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Crack.png");
		Texture2D rocks = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Rocks.png");
		Texture2D puff = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Puff.png");
		Texture2D ring = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Ring.png");
		Texture2D noise = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png");
		Texture2D spark = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Spark.png");
		if (shader == null || crack == null || rocks == null || puff == null || ring == null || noise == null || spark == null)
		{
			Debug.LogError("[VFX] faltam shader ou texturas em Assets/VFX (rode tools/gen_vfx_textures.py)");
			return;
		}
		C.SetClamp(crack);
		C.SetClamp(puff);

		// rachadura escura no chao; o miolo e lava (cor do miolo HDR), apagada pela cor de vertice com o tempo
		Material crackMat = new Material(shader);
		crackMat.SetTexture("_MainTex", crack);
		crackMat.SetTexture("_NoiseTex", noise);
		crackMat.SetTextureScale("_NoiseTex", new Vector2(2f, 2f));
		crackMat.SetColor("_Color", new Color(0.05f, 0.035f, 0.025f, 1f));
		crackMat.SetColor("_CoreColor", new Color(3.2f, 1.1f, 0.25f, 1f));
		crackMat.SetFloat("_CorePower", 1.4f);
		crackMat.SetColor("_EdgeColor", new Color(2f, 0.7f, 0.15f, 1f));
		crackMat.SetFloat("_Distortion", 0f);
		crackMat.SetFloat("_Additive", 0f);
		crackMat = B.SaveAsset(crackMat, Root + "/Materials/M_RachaduraTerra.mat");

		// brilho somado por cima da rachadura so no primeiro instante
		Material glow = new Material(shader);
		glow.SetTexture("_MainTex", crack);
		glow.SetTexture("_NoiseTex", noise);
		glow.SetColor("_Color", new Color(2.4f, 0.8f, 0.15f, 1f));
		glow.SetColor("_CoreColor", new Color(6f, 3f, 1f, 1f));
		glow.SetFloat("_CorePower", 1f);
		glow.SetFloat("_Distortion", 0f);
		glow = B.SaveAsset(glow, Root + "/Materials/M_BrilhoTerra.mat");

		Material wave = new Material(shader);
		wave.SetTexture("_MainTex", ring);
		wave.SetTexture("_NoiseTex", noise);
		wave.SetTextureScale("_NoiseTex", new Vector2(2f, 2f));
		wave.SetVector("_NoiseScroll", new Vector4(0.3f, 0.2f, 0f, 0f));
		wave.SetColor("_Color", new Color(1.1f, 0.6f, 0.25f, 1f));
		wave.SetColor("_CoreColor", new Color(3f, 1.7f, 0.7f, 1f));
		wave.SetFloat("_CorePower", 1.5f);
		wave.SetColor("_EdgeColor", new Color(3f, 1.2f, 0.3f, 1f));
		wave.SetFloat("_Distortion", 0.03f);
		wave.SetFloat("_Additive", 0.5f);
		wave = B.SaveAsset(wave, Root + "/Materials/M_OndaTerra.mat");

		Material sparkMat = new Material(shader);
		sparkMat.SetTexture("_MainTex", spark);
		sparkMat.SetTexture("_NoiseTex", noise);
		sparkMat.SetColor("_Color", new Color(3f, 1.3f, 0.3f, 1f));
		sparkMat.SetColor("_CoreColor", new Color(4f, 2.4f, 0.9f, 1f));
		sparkMat.SetFloat("_CorePower", 1f);
		sparkMat.SetFloat("_Distortion", 0f);
		sparkMat = B.SaveAsset(sparkMat, Root + "/Materials/M_FaiscaTerra.mat");

		// poeira: misturada (nao soma), sombra embaixo e luz em cima vem do RGB da textura
		Material dust = new Material(shader);
		dust.SetTexture("_MainTex", puff);
		dust.SetTexture("_NoiseTex", noise);
		dust.SetVector("_NoiseScroll", new Vector4(0.1f, 0.15f, 0f, 0f));
		dust.SetColor("_Color", new Color(0.3f, 0.24f, 0.18f, 1f));
		dust.SetColor("_CoreColor", new Color(0.8f, 0.68f, 0.52f, 1f));
		dust.SetFloat("_CorePower", 1f);
		dust.SetColor("_EdgeColor", Color.black);   // borda do dissolve sem brilho (so corroi)
		dust.SetFloat("_Distortion", 0.05f);
		dust.SetFloat("_Additive", 0f);
		dust = B.SaveAsset(dust, Root + "/Materials/M_PoeiraTerra.mat");

		// pedras: misturadas; as facetas da textura vao da cor escura para a clara
		Material rock = new Material(shader);
		rock.SetTexture("_MainTex", rocks);
		rock.SetTexture("_NoiseTex", noise);
		rock.SetColor("_Color", new Color(0.16f, 0.12f, 0.09f, 1f));
		rock.SetColor("_CoreColor", new Color(0.5f, 0.4f, 0.31f, 1f));
		rock.SetFloat("_CorePower", 1.8f);
		rock.SetFloat("_Distortion", 0f);
		rock.SetFloat("_Additive", 0f);
		rock = B.SaveAsset(rock, Root + "/Materials/M_PedraTerra.mat");

		GameObject slam = new GameObject("VFX_GolpeTerra");
		Crack(slam.transform, crackMat);
		Glow(slam.transform, glow);
		Wave(slam.transform, wave);
		Flash(slam.transform, sparkMat);
		Dust(slam.transform, dust);
		Rocks(slam.transform, rock);
		Embers(slam.transform, sparkMat);
		B.SavePrefab(slam, Root + "/Resources/VFX_GolpeTerra.prefab");

		GameObject aura = new GameObject("VFX_ForcaTerra");
		FeetRing(aura.transform, wave);
		OrbitRocks(aura.transform, rock);
		FeetDust(aura.transform, dust);
		B.SavePrefab(aura, Root + "/Resources/VFX_ForcaTerra.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Golpe da Terra montado: VFX_GolpeTerra e VFX_ForcaTerra");
	}

	private static ParticleSystem Ground(Transform parent, string name, Material mat, float life, float size)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.duration = life;
		main.startLifetime = life;
		main.startSize = size;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 1);
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
		return ps;
	}

	// rachadura: abre num estalo, a lava esfria em ~0,6 s e a terra rachada se desfaz devagar
	private static void Crack(Transform parent, Material mat)
	{
		ParticleSystem ps = Ground(parent, "Rachadura", mat, 1.8f, 4.8f);
		ps.transform.localPosition = new Vector3(0f, 0.03f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.7f, 0.04f, 1f, 1f, 1f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(new Color(0.45f, 0.3f, 0.25f), 0.2f), new GradientColorKey(new Color(0.15f, 0.12f, 0.1f), 0.45f) },
			new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) });
		c.color = g;
		C.DissolveStreams(ps, B.Curve(0f, 0.4f, 0.05f, 0f, 0.6f, 0f, 1f, 1f));
	}

	private static void Glow(Transform parent, Material mat)
	{
		ParticleSystem ps = Ground(parent, "Brilho", mat, 0.5f, 4.8f);
		ps.transform.localPosition = new Vector3(0f, 0.05f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.7f, 0.08f, 1f, 1f, 1f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.15f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.5f));
	}

	private static void Wave(Transform parent, Material mat)
	{
		ParticleSystem ps = Ground(parent, "Onda", mat, 0.45f, 5.6f);
		ps.transform.localPosition = new Vector3(0f, 0.06f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.15f, 0.35f, 0.8f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f));
	}

	private static void Flash(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Clarao", mat, 1);
		ps.transform.localPosition = new Vector3(0f, 0.35f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.14f;
		main.startSize = 2.4f;
		main.startColor = Lava;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.2f);
	}

	// anel de poeira saindo rente ao chao, freia e sobe um pouco
	private static void Dust(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Poeira", mat, 16);
		ps.transform.localPosition = new Vector3(0f, 0.5f, 0f);     // alto o bastante para o chao nao cortar a nuvem
		ParticleSystem.MainModule main = ps.main;
		main.duration = 1.5f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.9f, 1.4f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.6f, 1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(3f, 5.5f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.75f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 16);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.4f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.12f;
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.5f, 0.9f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(-0.8f, 0.8f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.2f, 1f, 1.8f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.6f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.35f, 0f, 1f, 1f));
	}

	// pedrinhas saltando para cima e para os lados, caem com gravidade (girando)
	private static void Rocks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Pedras", mat, 10);
		ps.transform.localPosition = new Vector3(0f, 0.1f, 0f);
		ps.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);   // cone para cima
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.7f, 1f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.2f, 0.4f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(4f, 7f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.gravityModifier = 1.6f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 10);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 38f;
		shape.radius = 0.35f;
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(-9f, 9f);
		ParticleSystem.TextureSheetAnimationModule sheet = ps.textureSheetAnimation;
		sheet.enabled = true;
		sheet.numTilesX = 2;
		sheet.numTilesY = 2;
		sheet.frameOverTime = new ParticleSystem.MinMaxCurve(0f, 0.999f);   // sorteia uma das 4 pedras e fica nela
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.85f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0f));
	}

	private static void Embers(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Brasas", mat, 12);
		ps.transform.localPosition = new Vector3(0f, 0.1f, 0f);
		ps.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.4f, 0.8f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(3f, 6f);
		main.startColor = Lava;
		main.gravityModifier = 0.8f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 12);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 50f;
		shape.radius = 0.3f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.5f);
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.05f;
		r.lengthScale = 1.5f;
	}

	// ---------- aura do buff (presa no lutador; o pe fica em y = -0,95) ----------

	private static void FeetRing(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Anel", mat, 2);
		ps.transform.localPosition = new Vector3(0f, -0.92f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 0.7f;
		main.startLifetime = 0.7f;
		main.startSize = 1.7f;
		main.startColor = new Color(1f, 0.8f, 0.55f, 0.6f);
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 1.5f;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.5f, 1f, 1f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.2f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.6f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}

	private static void OrbitRocks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Pedrinhas", mat, 8);
		ps.transform.localPosition = new Vector3(0f, -0.9f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(1f, 1.4f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.07f, 0.13f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 6f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.55f;
		shape.radiusThickness = 0f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.4f, 0.8f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.orbitalX = new ParticleSystem.MinMaxCurve(0f, 0f);       // orbita tambem: os 3 eixos no mesmo modo de curva
		v.orbitalY = new ParticleSystem.MinMaxCurve(2.5f, 3.5f);   // gira em volta do Axie
		v.orbitalZ = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(-4f, 4f);
		ParticleSystem.TextureSheetAnimationModule sheet = ps.textureSheetAnimation;
		sheet.enabled = true;
		sheet.numTilesX = 2;
		sheet.numTilesY = 2;
		sheet.frameOverTime = new ParticleSystem.MinMaxCurve(0f, 0.999f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.3f, 0.2f, 1f, 0.8f, 1f, 1f, 0f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0f));
	}

	private static void FeetDust(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Poeira", mat, 4);
		ps.transform.localPosition = new Vector3(0f, -0.8f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = 1f;
		main.startSize = new ParticleSystem.MinMaxCurve(0.6f, 0.9f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.35f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 3.5f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.4f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(0f, 0f), new GradientAlphaKey(1f, 0.3f), new GradientAlphaKey(0f, 1f) });
		c.color = g;
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.5f, 0f, 1f, 0.8f));
	}
}
