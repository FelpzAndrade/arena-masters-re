using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

// Monta os efeitos do Machado Barbaro (Axie) so com Particle System + shader proprio (ArenaMasters/VFX/Particula Dissolve).
// Menu: Arena Masters/VFX/Montar Machado Barbaro. Refaz tudo do zero (malha, materiais e prefabs) a cada uso.
//   Resources/VFX_MachadoBarbaro  corte em arco + clarao + faiscas + brasas (sai no golpe, na frente do Axie)
//   Resources/VFX_MachadoImpacto  clarao + faiscas no inimigo atingido
// Tempos (vida do corte 0,4 s, em tempo real para aparecer durante o hit stop):
//   antecipacao 0-0,03 s: o arco corre rapido ate 2/3 do caminho, ainda pequeno
//   impacto 0,03-0,08 s:  arco inteiro, maior, clarao e faiscas
//   dissipacao 0,08-0,4 s: a cauda recolhe devagar e o dissolve queima o resto; brasas sobem ate ~1 s
// Particulas vivas no maximo: corte 1 + clarao 1 + faiscas 18 + brasas 10 = 30; impacto 1 + 14 = 15.
public static class VfxMachadoBuilder
{
	private const string Root = "Assets/VFX";
	private const string ShaderName = "ArenaMasters/VFX/Particula Dissolve";

	// arco: 150 graus centrado na frente (+Z), raio interno 0,35 e externo 1 na malha; o tamanho vem do startSize.
	// O prefab ja sai no tamanho do golpe de alcance 2,4 m (escala 1); o jogo escala por alcance / 2,4.
	public const float ReferenceRange = 2.4f;
	private const float ArcRadius = 2.2f;
	private const float ArcDegrees = 150f;
	private const float InnerRadius = 0.35f;

	[MenuItem("Arena Masters/VFX/Montar Machado Barbaro")]
	public static void Build()
	{
		Directory.CreateDirectory(Root + "/Meshes");
		Directory.CreateDirectory(Root + "/Materials");
		Directory.CreateDirectory(Root + "/Resources");
		Shader shader = Shader.Find(ShaderName);
		Texture2D mask = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_SlashMask.png");
		Texture2D noise = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Noise.png");
		Texture2D spark = AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/T_Spark.png");
		if (shader == null || mask == null || noise == null || spark == null)
		{
			Debug.LogError("[VFX] faltam shader ou texturas em Assets/VFX (rode tools/gen_vfx_textures.py)");
			return;
		}

		Mesh arc = SaveAsset(BuildArcMesh(), Root + "/Meshes/M_ArcoCorte.asset");

		Material cut = new Material(shader) { name = "M_CorteMachado" };
		cut.SetTexture("_MainTex", mask);
		cut.SetTexture("_NoiseTex", noise);
		cut.SetTextureScale("_NoiseTex", new Vector2(2.5f, 1f));
		cut.SetColor("_Color", new Color(2.5f, 0.9f, 0.25f, 1f));
		cut.SetColor("_CoreColor", new Color(5f, 4f, 3f, 1f));
		cut.SetFloat("_CorePower", 2f);
		cut.SetVector("_NoiseScroll", new Vector4(-0.8f, 0.15f, 0f, 0f));
		cut.SetFloat("_Distortion", 0.04f);
		cut.SetColor("_EdgeColor", new Color(6f, 1.8f, 0.4f, 1f));
		cut.SetFloat("_EdgeWidth", 0.08f);
		cut.SetFloat("_Softness", 0.04f);
		cut = SaveAsset(cut, Root + "/Materials/M_CorteMachado.mat");

		// faisca: sem Custom Data o dissolve fica 0; RGB da textura e branco, entao a cor vem do miolo
		Material sparkMat = new Material(shader) { name = "M_FaiscaMachado" };
		sparkMat.SetTexture("_MainTex", spark);
		sparkMat.SetTexture("_NoiseTex", noise);
		sparkMat.SetColor("_Color", new Color(4f, 1.6f, 0.5f, 1f));
		sparkMat.SetColor("_CoreColor", new Color(5f, 2.4f, 0.8f, 1f));
		sparkMat.SetFloat("_CorePower", 1f);
		sparkMat.SetFloat("_Distortion", 0f);
		sparkMat = SaveAsset(sparkMat, Root + "/Materials/M_FaiscaMachado.mat");

		GameObject slash = new GameObject("VFX_MachadoBarbaro");
		BuildCut(slash.transform, arc, cut);
		BuildFlash(slash.transform, sparkMat, new Vector3(0f, 0f, ArcRadius * 0.75f), 1.6f, 0.03f, new Color(1f, 0.8f, 0.55f));
		BuildSparks(slash.transform, sparkMat, 18, 0.03f);
		BuildEmbers(slash.transform, sparkMat);
		SavePrefab(slash, Root + "/Resources/VFX_MachadoBarbaro.prefab");

		GameObject impact = new GameObject("VFX_MachadoImpacto");
		BuildFlash(impact.transform, sparkMat, Vector3.zero, 1.3f, 0f, Color.white);
		BuildImpactSparks(impact.transform, sparkMat);
		SavePrefab(impact, Root + "/Resources/VFX_MachadoImpacto.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Machado Barbaro montado: Assets/VFX/Resources/VFX_MachadoBarbaro.prefab e VFX_MachadoImpacto.prefab");
	}

	// malha em meia-lua no plano XZ. UV: u = ao longo do arco (0 = inicio do golpe, a esquerda), v = 0 dentro, 1 no fio
	private static Mesh BuildArcMesh()
	{
		const int segments = 32;
		List<Vector3> verts = new List<Vector3>();
		List<Vector2> uvs = new List<Vector2>();
		List<int> tris = new List<int>();
		for (int i = 0; i <= segments; i++)
		{
			float u = i / (float)segments;
			float a = (u - 0.5f) * ArcDegrees * Mathf.Deg2Rad;
			Vector3 dir = new Vector3(Mathf.Sin(a), 0f, Mathf.Cos(a));
			verts.Add(dir * InnerRadius);
			verts.Add(dir);
			uvs.Add(new Vector2(u, 0f));
			uvs.Add(new Vector2(u, 1f));
			if (i < segments)
			{
				int b = i * 2;
				tris.AddRange(new[] { b, b + 1, b + 3, b, b + 3, b + 2 });
			}
		}
		Mesh mesh = new Mesh { name = "M_ArcoCorte" };
		mesh.SetVertices(verts);
		mesh.SetUVs(0, uvs);
		mesh.SetTriangles(tris, 0);
		// sem cor de vertice: no modo Mesh do Particle System, cor em Float32 chega errada no shader (fica azul escuro)
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();
		return mesh;
	}

	private static ParticleSystem NewSystem(Transform parent, string name, Material mat, int maxParticles)
	{
		GameObject go = new GameObject(name);
		go.transform.SetParent(parent, false);
		ParticleSystem ps = go.AddComponent<ParticleSystem>();
		ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 1f;
		main.loop = false;
		main.playOnAwake = true;
		main.useUnscaledTime = true;          // anda durante o hit stop
		main.scalingMode = ParticleSystemScalingMode.Hierarchy;
		main.maxParticles = maxParticles;
		main.startSpeed = 0f;
		ParticleSystem.EmissionModule emission = ps.emission;
		emission.rateOverTime = 0f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = false;
		ParticleSystemRenderer renderer = go.GetComponent<ParticleSystemRenderer>();
		renderer.sharedMaterial = mat;
		renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
		renderer.receiveShadows = false;
		renderer.lightProbeUsage = UnityEngine.Rendering.LightProbeUsage.Off;
		renderer.reflectionProbeUsage = UnityEngine.Rendering.ReflectionProbeUsage.Off;
		return ps;
	}

	private static void Burst(ParticleSystem ps, float time, int count)
	{
		ParticleSystem.EmissionModule emission = ps.emission;
		emission.SetBursts(new[] { new ParticleSystem.Burst(time, (short)count) });
	}

	private static AnimationCurve Curve(params float[] timeValue)
	{
		AnimationCurve c = new AnimationCurve();
		for (int i = 0; i + 1 < timeValue.Length; i += 2)
		{
			c.AddKey(timeValue[i], timeValue[i + 1]);
		}
		for (int i = 0; i < c.length; i++)
		{
			AnimationUtility.SetKeyLeftTangentMode(c, i, AnimationUtility.TangentMode.Linear);
			AnimationUtility.SetKeyRightTangentMode(c, i, AnimationUtility.TangentMode.Linear);
		}
		return c;
	}

	private static Gradient Fade(Color color, float holdUntil)
	{
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(color, 0f), new GradientColorKey(color, 1f) },
			new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, holdUntil), new GradientAlphaKey(0f, 1f) });
		return g;
	}

	private static void BuildCut(Transform parent, Mesh arc, Material mat)
	{
		ParticleSystem ps = NewSystem(parent, "Corte", mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.4f;
		main.startSize = ArcRadius;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		Burst(ps, 0f, 1);

		// antecipacao pequena, impacto estoura um pouco, dissipacao cresce devagar
		ParticleSystem.SizeOverLifetimeModule size = ps.sizeOverLifetime;
		size.enabled = true;
		size.size = new ParticleSystem.MinMaxCurve(1f, Curve(0f, 0.8f, 0.075f, 0.95f, 0.2f, 1.06f, 1f, 1.1f));

		// Custom1.x = dissolve, Custom1.y = avanco do corte (1 = escondido antes do inicio, 0 = inteiro, negativo = cauda saindo)
		ParticleSystem.CustomDataModule custom = ps.customData;
		custom.enabled = true;
		custom.SetMode(ParticleSystemCustomData.Custom1, ParticleSystemCustomDataMode.Vector);
		custom.SetVectorComponentCount(ParticleSystemCustomData.Custom1, 2);
		custom.SetVector(ParticleSystemCustomData.Custom1, 0, new ParticleSystem.MinMaxCurve(1f, Curve(0f, 0f, 0.25f, 0f, 1f, 1f)));
		custom.SetVector(ParticleSystemCustomData.Custom1, 1, new ParticleSystem.MinMaxCurve(1f, Curve(0f, 1f, 0.075f, 0.35f, 0.2f, -0.1f, 1f, -0.45f)));

		ParticleSystemRenderer renderer = ps.GetComponent<ParticleSystemRenderer>();
		renderer.renderMode = ParticleSystemRenderMode.Mesh;
		renderer.mesh = arc;
		renderer.alignment = ParticleSystemRenderSpace.Local;
		renderer.SetActiveVertexStreams(new List<ParticleSystemVertexStream>
		{
			ParticleSystemVertexStream.Position,
			ParticleSystemVertexStream.Color,
			ParticleSystemVertexStream.UV,
			ParticleSystemVertexStream.Custom1XY,
			ParticleSystemVertexStream.StableRandomX,
		});
	}

	private static void BuildFlash(Transform parent, Material mat, Vector3 localPos, float startSize, float delay, Color color)
	{
		ParticleSystem ps = NewSystem(parent, "Clarao", mat, 1);
		ps.transform.localPosition = localPos;
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = delay;
		main.startLifetime = 0.12f;
		main.startSize = startSize;
		main.startColor = color;
		Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule size = ps.sizeOverLifetime;
		size.enabled = true;
		size.size = new ParticleSystem.MinMaxCurve(1f, Curve(0f, 0.5f, 0.3f, 1.1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule col = ps.colorOverLifetime;
		col.enabled = true;
		col.color = Fade(Color.white, 0.25f);
	}

	// faiscas em leque para a frente (cone de 65 graus apontando para +Z)
	private static void BuildSparks(Transform parent, Material mat, int count, float delay)
	{
		ParticleSystem ps = NewSystem(parent, "Faiscas", mat, count);
		ps.transform.localPosition = new Vector3(0f, 0f, ArcRadius * 0.6f);   // saem da lamina, nao do corpo
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = delay;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.18f, 0.38f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(5f, 10f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.06f, 0.14f);
		main.gravityModifier = 0.6f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		Burst(ps, 0f, count);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 65f;
		shape.radius = 0.7f;
		ParticleSystem.SizeOverLifetimeModule size = ps.sizeOverLifetime;
		size.enabled = true;
		size.size = new ParticleSystem.MinMaxCurve(1f, Curve(0f, 1f, 1f, 0.2f));
		ParticleSystem.ColorOverLifetimeModule col = ps.colorOverLifetime;
		col.enabled = true;
		col.color = Fade(Color.white, 0.5f);
		ParticleSystemRenderer renderer = ps.GetComponent<ParticleSystemRenderer>();
		renderer.renderMode = ParticleSystemRenderMode.Stretch;
		renderer.velocityScale = 0.04f;
		renderer.lengthScale = 1.5f;
	}

	// brasas lentas que sobem na dissipacao
	private static void BuildEmbers(Transform parent, Material mat)
	{
		ParticleSystem ps = NewSystem(parent, "Brasas", mat, 10);
		ps.transform.localPosition = new Vector3(0f, 0f, ArcRadius * 0.55f);
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = 0.08f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.5f, 0.9f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(0.3f, 1f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.04f, 0.08f);
		main.startColor = new Color(1f, 0.6f, 0.3f);
		main.gravityModifier = -0.15f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		Burst(ps, 0f, 10);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 60f;
		shape.radius = 1f;
		ParticleSystem.SizeOverLifetimeModule size = ps.sizeOverLifetime;
		size.enabled = true;
		size.size = new ParticleSystem.MinMaxCurve(1f, Curve(0f, 1f, 1f, 0f));
		ParticleSystem.ColorOverLifetimeModule col = ps.colorOverLifetime;
		col.enabled = true;
		col.color = Fade(Color.white, 0.4f);
	}

	private static void BuildImpactSparks(Transform parent, Material mat)
	{
		ParticleSystem ps = NewSystem(parent, "Faiscas", mat, 14);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.15f, 0.3f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(4f, 8f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.12f);
		main.gravityModifier = 0.5f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		Burst(ps, 0f, 14);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 0.1f;
		ParticleSystem.SizeOverLifetimeModule size = ps.sizeOverLifetime;
		size.enabled = true;
		size.size = new ParticleSystem.MinMaxCurve(1f, Curve(0f, 1f, 1f, 0.2f));
		ParticleSystemRenderer renderer = ps.GetComponent<ParticleSystemRenderer>();
		renderer.renderMode = ParticleSystemRenderMode.Stretch;
		renderer.velocityScale = 0.04f;
		renderer.lengthScale = 1.5f;
	}

	// atualiza no lugar quando ja existe (mantem o GUID e as referencias dos prefabs)
	private static T SaveAsset<T>(T asset, string path) where T : Object
	{
		T existing = AssetDatabase.LoadAssetAtPath<T>(path);
		if (existing == null)
		{
			AssetDatabase.CreateAsset(asset, path);
			return asset;
		}
		EditorUtility.CopySerialized(asset, existing);
		existing.name = Path.GetFileNameWithoutExtension(path);
		EditorUtility.SetDirty(existing);
		return existing;
	}

	private static void SavePrefab(GameObject go, string path)
	{
		PrefabUtility.SaveAsPrefabAsset(go, path);
		Object.DestroyImmediate(go);
	}
}
