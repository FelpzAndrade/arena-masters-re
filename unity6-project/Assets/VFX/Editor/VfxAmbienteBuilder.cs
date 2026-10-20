using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;

// Etapa 3 do mapa (vida no ambiente), so Particle System + shader proprio, sem luz.
// Menu: Arena Masters/VFX/Montar Ambiente. O ArenaBake espalha os prefabs pelo mapa.
//   Resources/VFX_BrasasTocha  brasas subindo de cada tocha, balancando (6 no maximo por tocha)
//   Resources/VFX_PoeiraAr     poeira flutuando no ar em volta da luta (segue o ponto que a camera olha; 40 no maximo)
//   Resources/VFX_NevoaBorda   nevoa baixa deitada no chao perto das paredes de fora (3 no maximo por ponto)
// Os sistemas ficam fora da tela pausados sozinhos (culling automatico do Particle System).
public static class VfxAmbienteBuilder
{
	private const string Root = "Assets/VFX";

	[MenuItem("Arena Masters/VFX/Montar Ambiente")]
	public static void Build()
	{
		Shader shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		Texture2D spark = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Spark.png");
		Texture2D puff = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Puff.png");
		Texture2D noise = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png");
		if (shader == null || spark == null || puff == null || noise == null)
		{
			Debug.LogError("[VFX] faltam shader ou texturas em Assets/VFX");
			return;
		}

		Material ember = new Material(shader);
		ember.SetTexture("_MainTex", spark);
		ember.SetTexture("_NoiseTex", noise);
		ember.SetColor("_Color", new Color(2.4f, 0.9f, 0.25f, 1f));
		ember.SetColor("_CoreColor", new Color(3.5f, 2f, 0.8f, 1f));
		ember.SetFloat("_CorePower", 1f);
		ember.SetFloat("_Distortion", 0f);
		ember = B.SaveAsset(ember, Root + "/Materials/M_BrasaAmbiente.mat");

		Material mote = new Material(shader);
		mote.SetTexture("_MainTex", spark);
		mote.SetTexture("_NoiseTex", noise);
		mote.SetColor("_Color", new Color(1.2f, 0.85f, 0.5f, 1f));
		mote.SetColor("_CoreColor", new Color(1.8f, 1.4f, 0.9f, 1f));
		mote.SetFloat("_CorePower", 1f);
		mote.SetFloat("_Distortion", 0f);
		mote = B.SaveAsset(mote, Root + "/Materials/M_PoeiraAr.mat");

		Material fog = new Material(shader);
		fog.SetTexture("_MainTex", puff);
		fog.SetTexture("_NoiseTex", noise);
		fog.SetVector("_NoiseScroll", new Vector4(0.03f, 0.02f, 0f, 0f));
		fog.SetColor("_Color", new Color(0.36f, 0.28f, 0.22f, 1f));   // mais clara que o chao escuro das bordas: aparece como bruma
		fog.SetColor("_CoreColor", new Color(0.5f, 0.41f, 0.33f, 1f));
		fog.SetFloat("_CorePower", 1f);
		fog.SetFloat("_Distortion", 0.06f);
		fog.SetFloat("_Additive", 0.3f);
		fog = B.SaveAsset(fog, Root + "/Materials/M_NevoaBorda.mat");

		GameObject go = new GameObject("VFX_BrasasTocha");
		Embers(go.transform, ember);
		B.SavePrefab(go, Root + "/Resources/VFX_BrasasTocha.prefab");

		go = new GameObject("VFX_PoeiraAr");
		Motes(go.transform, mote);
		B.SavePrefab(go, Root + "/Resources/VFX_PoeiraAr.prefab");

		go = new GameObject("VFX_NevoaBorda");
		Fog(go.transform, fog);
		B.SavePrefab(go, Root + "/Resources/VFX_NevoaBorda.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Ambiente montado: VFX_BrasasTocha, VFX_PoeiraAr e VFX_NevoaBorda");
	}

	private static ParticleSystem Looping(Transform parent, string name, Material mat, int max)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, max);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.prewarm = true;                  // ja nasce com particulas no ar (sem "acender" no inicio da luta)
		main.useUnscaledTime = false;         // ambiente acompanha o hit stop como o resto do mundo
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		return ps;
	}

	private static void Embers(Transform parent, Material mat)
	{
		ParticleSystem ps = Looping(parent, "Brasas", mat, 8);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 2f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(1.4f, 2.4f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.06f, 0.11f);
		main.startColor = Color.white;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 3.6f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 0.12f;
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(-0.1f, 0.1f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.45f, 0.9f);
		v.z = new ParticleSystem.MinMaxCurve(-0.1f, 0.1f);
		ParticleSystem.NoiseModule n = ps.noise;
		n.enabled = true;
		n.strength = 0.35f;
		n.frequency = 0.9f;
		n.quality = ParticleSystemNoiseQuality.Low;   // barato no celular
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 0.7f, 0.8f, 1f, 0f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.5f);
	}

	private static void Motes(Transform parent, Material mat)
	{
		ParticleSystem ps = Looping(parent, "Poeira", mat, 40);
		ps.transform.localPosition = new Vector3(0f, 1.2f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 6f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(5f, 7f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.11f);
		main.startColor = new Color(1f, 1f, 1f, 0.7f);
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 6.5f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Box;
		shape.scale = new Vector3(20f, 2.5f, 16f);   // cobre a tela inteira da camera de luta
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(0.05f, 0.18f);
		v.y = new ParticleSystem.MinMaxCurve(-0.03f, 0.06f);
		v.z = new ParticleSystem.MinMaxCurve(-0.05f, 0.05f);
		ParticleSystem.NoiseModule n = ps.noise;
		n.enabled = true;
		n.strength = 0.12f;
		n.frequency = 0.3f;
		n.quality = ParticleSystemNoiseQuality.Low;
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(0f, 0f), new GradientAlphaKey(1f, 0.25f), new GradientAlphaKey(1f, 0.7f), new GradientAlphaKey(0f, 1f) });
		c.color = g;
	}

	private static void Fog(Transform parent, Material mat)
	{
		ParticleSystem ps = Looping(parent, "Nevoa", mat, 3);
		ps.transform.localPosition = new Vector3(0f, 0.35f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 9f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(8f, 11f);
		main.startSize = new ParticleSystem.MinMaxCurve(5f, 8f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.28f);   // bruma fina: so tira a nitidez do chao perto das paredes
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 0.3f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 1.5f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(-0.12f, 0.12f);
		v.y = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.z = new ParticleSystem.MinMaxCurve(-0.12f, 0.12f);
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(-0.08f, 0.08f);
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(0f, 0f), new GradientAlphaKey(1f, 0.3f), new GradientAlphaKey(1f, 0.65f), new GradientAlphaKey(0f, 1f) });
		c.color = g;
		VfxCornetaBuilder.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0f));   // T_Puff e Clamp: sem os streams a textura sai da particula
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}
}
