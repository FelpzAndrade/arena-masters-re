using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;

// Monta os efeitos da Corneta de Guerra (Axie) so com Particle System + shader proprio.
// Menu: Arena Masters/VFX/Montar Corneta de Guerra. Refaz materiais e prefabs (atualiza no lugar, mantem GUID).
//   Resources/VFX_CornetaGuerra  o grito: clarao no peito, 2 ondas de choque no chao, aneis de som, faiscas subindo
//   Resources/VFX_EscudoCorneta  a barreira (3 s): cupula de hexagonos, anel pulsando nos pes, pontos de luz subindo
// Tempos do grito: a antecipacao fica na animacao (Corneta_Guerra encolhe ate o quadro 9); no impacto sai tudo junto
// e a dissipacao e lenta (ondas queimam no dissolve, faiscas sobem ate ~1 s).
// Particulas vivas no maximo: grito 1 + 2 + 3 + 20 = 26; escudo 1 + 2 + 14 = 17.
public static class VfxCornetaBuilder
{
	private const string Root = "Assets/VFX";
	private static readonly Color Gold = new Color(1f, 0.82f, 0.45f);

	[MenuItem("Arena Masters/VFX/Montar Corneta de Guerra")]
	public static void Build()
	{
		Shader shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		Texture2D ring = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Ring.png");
		Texture2D hex = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Hex.png");
		Texture2D noise = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png");
		Texture2D spark = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Spark.png");
		if (shader == null || ring == null || hex == null || noise == null || spark == null)
		{
			Debug.LogError("[VFX] faltam shader ou texturas em Assets/VFX (rode tools/gen_vfx_textures.py)");
			return;
		}
		SetClamp(ring);

		Material wave = new Material(shader);
		wave.SetTexture("_MainTex", ring);
		wave.SetTexture("_NoiseTex", noise);
		wave.SetTextureScale("_NoiseTex", new Vector2(2f, 2f));
		wave.SetVector("_NoiseScroll", new Vector4(0.3f, 0.2f, 0f, 0f));
		wave.SetColor("_Color", new Color(2.2f, 1.5f, 0.4f, 1f));
		wave.SetColor("_CoreColor", new Color(4f, 3.4f, 2.2f, 1f));
		wave.SetFloat("_CorePower", 1.5f);
		wave.SetColor("_EdgeColor", new Color(5f, 2.6f, 0.6f, 1f));
		wave.SetFloat("_Distortion", 0.03f);
		wave = B.SaveAsset(wave, Root + "/Materials/M_OndaCorneta.mat");

		Material sparkMat = new Material(shader);
		sparkMat.SetTexture("_MainTex", spark);
		sparkMat.SetTexture("_NoiseTex", noise);
		sparkMat.SetColor("_Color", new Color(3f, 2f, 0.6f, 1f));
		sparkMat.SetColor("_CoreColor", new Color(4f, 2.8f, 1f, 1f));
		sparkMat.SetFloat("_CorePower", 1f);
		sparkMat.SetFloat("_Distortion", 0f);
		sparkMat = B.SaveAsset(sparkMat, Root + "/Materials/M_FaiscaCorneta.mat");

		// cupula: hexagonos girando devagar, linhas quentes, fundo fraco
		Material dome = new Material(shader);
		dome.SetTexture("_MainTex", hex);
		dome.SetTextureScale("_MainTex", new Vector2(6f, 3f));
		dome.SetVector("_MainScroll", new Vector4(0.04f, 0f, 0f, 0f));
		dome.SetTexture("_NoiseTex", noise);
		dome.SetVector("_NoiseScroll", new Vector4(0.1f, -0.25f, 0f, 0f));
		dome.SetColor("_Color", new Color(1.2f, 0.85f, 0.25f, 1f));
		dome.SetColor("_CoreColor", new Color(3f, 2.3f, 1.1f, 1f));
		dome.SetFloat("_CorePower", 1f);
		dome.SetFloat("_Distortion", 0.02f);
		dome.SetColor("_EdgeColor", new Color(5f, 3f, 0.8f, 1f));
		dome.SetFloat("_Intensity", 0.4f);   // forte demais esconde o Axie (frente e costas da esfera somam)
		dome = B.SaveAsset(dome, Root + "/Materials/M_CupulaCorneta.mat");

		GameObject shout = new GameObject("VFX_CornetaGuerra");
		Flash(shout.transform, sparkMat, new Vector3(0f, 1.3f, 0f), 2.4f);
		GroundWaves(shout.transform, wave);
		SoundRings(shout.transform, wave);
		RisingSparks(shout.transform, sparkMat);
		B.SavePrefab(shout, Root + "/Resources/VFX_CornetaGuerra.prefab");

		Mesh sphere = B.SaveAsset(BuildSphere(), Root + "/Meshes/M_Esfera.asset");
		GameObject shield = new GameObject("VFX_EscudoCorneta");
		Dome(shield.transform, dome, sphere);
		FeetPulse(shield.transform, wave);
		Motes(shield.transform, sparkMat);
		B.SavePrefab(shield, Root + "/Resources/VFX_EscudoCorneta.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Corneta de Guerra montada: VFX_CornetaGuerra e VFX_EscudoCorneta");
	}

	// esfera de raio 0,5 com UV de mapa-mundi (u = volta, v = polo a polo), sem cor de vertice
	private static Mesh BuildSphere()
	{
		const int lon = 32, lat = 16;
		List<Vector3> verts = new List<Vector3>();
		List<Vector2> uvs = new List<Vector2>();
		List<int> tris = new List<int>();
		for (int y = 0; y <= lat; y++)
		{
			float v = y / (float)lat;
			float phi = v * Mathf.PI;
			for (int x = 0; x <= lon; x++)
			{
				float u = x / (float)lon;
				float th = u * Mathf.PI * 2f;
				verts.Add(new Vector3(Mathf.Sin(phi) * Mathf.Cos(th), -Mathf.Cos(phi), Mathf.Sin(phi) * Mathf.Sin(th)) * 0.5f);
				uvs.Add(new Vector2(u, v));
				if (x < lon && y < lat)
				{
					int a = y * (lon + 1) + x, b = a + lon + 1;
					tris.AddRange(new[] { a, b, a + 1, a + 1, b, b + 1 });
				}
			}
		}
		Mesh mesh = new Mesh { name = "M_Esfera" };
		mesh.SetVertices(verts);
		mesh.SetUVs(0, uvs);
		mesh.SetTriangles(tris, 0);
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();
		return mesh;
	}

	internal static void SetClamp(Texture2D tex)
	{
		TextureImporter imp = (TextureImporter)AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(tex));
		if (imp.wrapMode != TextureWrapMode.Clamp)
		{
			imp.wrapMode = TextureWrapMode.Clamp;
			imp.SaveAndReimport();
		}
	}

	internal static void DissolveStreams(ParticleSystem ps, AnimationCurve dissolve)
	{
		ParticleSystem.CustomDataModule custom = ps.customData;
		custom.enabled = true;
		custom.SetMode(ParticleSystemCustomData.Custom1, ParticleSystemCustomDataMode.Vector);
		custom.SetVectorComponentCount(ParticleSystemCustomData.Custom1, 2);
		custom.SetVector(ParticleSystemCustomData.Custom1, 0, new ParticleSystem.MinMaxCurve(1f, dissolve));
		custom.SetVector(ParticleSystemCustomData.Custom1, 1, new ParticleSystem.MinMaxCurve(0f));
		ps.GetComponent<ParticleSystemRenderer>().SetActiveVertexStreams(new List<ParticleSystemVertexStream>
		{
			ParticleSystemVertexStream.Position,
			ParticleSystemVertexStream.Color,
			ParticleSystemVertexStream.UV,
			ParticleSystemVertexStream.Custom1XY,
			ParticleSystemVertexStream.StableRandomX,
		});
	}

	private static void Flash(Transform parent, Material mat, Vector3 pos, float size)
	{
		ParticleSystem ps = B.NewSystem(parent, "Clarao", mat, 1);
		ps.transform.localPosition = pos;
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.15f;
		main.startSize = size;
		main.startColor = Gold;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.2f);
	}

	// duas ondas de choque deitadas no chao, a segunda logo atras; abrem rapido e queimam no dissolve
	private static void GroundWaves(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Ondas", mat, 2);
		ps.transform.localPosition = new Vector3(0f, 0.05f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.55f;
		main.startSize = 6.4f;                 // diametro final ~ 2x o alcance (3 m)
		main.startColor = Color.white;
		ParticleSystem.EmissionModule em = ps.emission;
		em.SetBursts(new[] { new ParticleSystem.Burst(0f, 1), new ParticleSystem.Burst(0.12f, 1) });
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.12f, 0.3f, 0.75f, 1f, 1f));
		DissolveStreams(ps, B.Curve(0f, 0f, 0.35f, 0f, 1f, 1f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}

	// aneis de som saindo da cabeca, virados para a camera
	private static void SoundRings(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Som", mat, 3);
		ps.transform.localPosition = new Vector3(0f, 1.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.4f;
		main.startSize = 2.8f;
		main.startColor = new Color(1f, 0.95f, 0.8f, 0.8f);
		ParticleSystem.EmissionModule em = ps.emission;
		em.SetBursts(new[] { new ParticleSystem.Burst(0f, 1), new ParticleSystem.Burst(0.07f, 1), new ParticleSystem.Burst(0.14f, 1) });
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.2f, 1f, 1f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.3f);
		DissolveStreams(ps, B.Curve(0f, 0f, 0.5f, 0.2f, 1f, 0.8f));
	}

	private static void RisingSparks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Faiscas", mat, 20);
		ps.transform.localPosition = new Vector3(0f, 0.1f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = 0.02f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.6f, 1f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.12f);
		main.startColor = Gold;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 20);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 1.2f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(2f, 4f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.5f);
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.06f;
		r.lengthScale = 1.2f;
	}

	// cupula de 3 s: materializa pelo dissolve, segura, e se desfaz no fim da barreira
	private static void Dome(Transform parent, Material mat, Mesh sphere)
	{
		ParticleSystem ps = B.NewSystem(parent, "Cupula", mat, 1);
		ps.transform.localPosition = new Vector3(0f, 0.1f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 3.1f;
		main.duration = 3.1f;
		main.startSize = 2.4f;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.85f, 0.06f, 1.04f, 0.12f, 1f, 1f, 1f));
		DissolveStreams(ps, B.Curve(0f, 1f, 0.06f, 0f, 0.88f, 0f, 1f, 1f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Mesh;
		r.mesh = sphere;
		r.alignment = ParticleSystemRenderSpace.Local;
	}

	private static void FeetPulse(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Anel", mat, 2);
		ps.transform.localPosition = new Vector3(0f, -0.95f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 0.8f;
		main.startLifetime = 0.8f;
		main.startSize = 2.6f;
		main.startColor = new Color(1f, 0.9f, 0.6f, 0.7f);
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 1.25f;
		B.Burst(ps, 0f, 1);                  // o primeiro anel sai junto com a barreira
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 1f, 1f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.2f);
		DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.6f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}

	private static void Motes(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Pontos", mat, 14);
		ps.transform.localPosition = new Vector3(0f, -0.9f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.8f, 1.2f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.04f, 0.08f);
		main.startColor = Gold;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 10f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.9f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.8f, 1.4f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0f));
	}
}
