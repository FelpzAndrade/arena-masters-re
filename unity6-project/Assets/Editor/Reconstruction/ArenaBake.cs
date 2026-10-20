using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;

// Salva o cenario da arena na cena da luta e faz o bake da luz (visual de jogo de celular, referencia_visual.md).
// Menu: Arena Masters/Mapa/Salvar arena e fazer bake.
//   1. monta o cenario com o mesmo codigo e a mesma semente do jogo (DungeonDecor.Build, semente 3): paredes, pilares e
//      obstaculos ficam iguais, porque saem do navmesh original; o jogo passa a usar esta copia (DungeonDecor.UseBaked)
//   2. marca tudo como Static e junta os 17 materiais iguais do KayKit em um so (Assets/Map/M_Masmorra)
//   3. luz: tochas e uma luz quente do alto no centro entram no lightmap (Baked); direcional fraca Mixed (Subtractive)
//      so para a sombra dos herois; ambiente escuro e quente; 3 luzes que piscam em tempo real (LuzesBraseiros)
//   4. Light Probes a cada 3 m em cada andar da area de luta, para os herois pegarem a luz do cenario
//   5. bake com o lightmapper de GPU; lightmaps em Assets/Scenes/Prototype1x1/
public static class ArenaBake
{
	private const string ScenePath = "Assets/Scenes/Prototype1x1.unity";
	private const string MapDir = "Assets/Map";
	private const string LightRootName = "Iluminacao (bake)";
	private const string DecalRootName = "Decalques";

	// cores da paleta da referencia (paleta.png), em sRGB
	private static readonly Color TorchColor = new Color(1f, 0.52f, 0.22f);       // fogo #9c441e clareado
	private static readonly Color CenterColor = new Color(0.82f, 0.65f, 0.35f);   // areia iluminada #d0a759
	private static readonly Color AmbientColor = new Color(0.3f, 0.22f, 0.17f);   // sombra marrom (nao preta): na referencia o escuro fica em ~0,09

	[MenuItem("Arena Masters/Mapa/Salvar arena e fazer bake")]
	public static void Run()
	{
		Prepare();
		Bake();
	}

	[MenuItem("Arena Masters/Mapa/So salvar arena (sem bake)")]
	public static void Prepare()
	{
		EnableLightmapUVs();
		PipelineSettings();
		Scene();
		Directory.CreateDirectory(MapDir);

		foreach (string n in new[] { DungeonDecor.RootName, LightRootName, DecalRootName, "DuelArena (navmesh original)" })
		{
			GameObject old = GameObject.Find(n);
			if (old != null)
			{
				Object.DestroyImmediate(old);
			}
		}

		Arena arena = new Arena();
		GameObject root = DungeonDecor.Build(arena, 3, 200);   // tochas a cada 6 m no mapa todo (luz de bake nao pesa no celular)
		Material shared = SharedMaterial(root);
		List<Vector3> flames = new List<Vector3>();
		foreach (Renderer r in root.GetComponentsInChildren<Renderer>(true))
		{
			GameObjectUtility.SetStaticEditorFlags(r.gameObject, StaticEditorFlags.ContributeGI | StaticEditorFlags.BatchingStatic | StaticEditorFlags.OccluderStatic | StaticEditorFlags.OccludeeStatic);
			Material[] mats = r.sharedMaterials;
			for (int i = 0; i < mats.Length; i++)
			{
				if (mats[i] != null && mats[i].mainTexture != null && mats[i].mainTexture.name == "dungeon_texture")
				{
					mats[i] = shared;
				}
			}
			r.sharedMaterials = mats;
			if (r is MeshRenderer mr)
			{
				mr.receiveGI = ReceiveGI.Lightmaps;
			}
			r.shadowCastingMode = ShadowCastingMode.On;   // sombra entra no lightmap; no jogo o UseBaked desliga a sombra em tempo real
		}
		foreach (Transform t in root.GetComponentsInChildren<Transform>(true))
		{
			GameObjectUtility.SetStaticEditorFlags(t.gameObject, GameObjectUtility.GetStaticEditorFlags(t.gameObject) | StaticEditorFlags.BatchingStatic | StaticEditorFlags.ContributeGI);
		}
		Vector3 fightCenter = arena.SpawnPoint(Vector3.zero) + Vector3.down * Arena.CenterHeight;   // meio entre os dois spawns
		ArenaVisual.Vary(root, fightCenter);
		ArenaVisual.Decals(arena, fightCenter, DecalRootName);
		// tochas do Build: viram luz de bake (a luz que pisca e a do LuzesBraseiros)
		foreach (Light l in root.GetComponentsInChildren<Light>(true))
		{
			l.lightmapBakeType = LightmapBakeType.Baked;
			l.color = TorchColor;
			l.intensity = 4f;   // o bake do URP usa queda de luz antiga (pelo alcance), nao a fisica do tempo real
			l.range = 10f;
			l.shadows = LightShadows.Soft;
			l.shapeRadius = 0.25f;
			flames.Add(l.transform.position);
		}

		GameObject lights = new GameObject(LightRootName);
		Bounds b = arena.floor.GetComponent<MeshFilter>().sharedMesh.bounds;

		Light sun = new GameObject("Direcional (sombra dos herois)").AddComponent<Light>();
		sun.transform.SetParent(lights.transform, false);
		sun.type = LightType.Directional;
		sun.lightmapBakeType = LightmapBakeType.Mixed;
		sun.color = new Color(1f, 0.86f, 0.72f);
		sun.intensity = 0.45f;
		sun.shadows = LightShadows.Soft;
		sun.shadowStrength = 0.8f;
		sun.transform.rotation = Quaternion.Euler(62f, -35f, 0f);

		// centro mais claro, bordas escuras (como no jogo): luz quente vinda do alto sobre o meio do mapa
		Light center = new GameObject("Luz do centro").AddComponent<Light>();
		center.transform.SetParent(lights.transform, false);
		center.type = LightType.Spot;
		center.lightmapBakeType = LightmapBakeType.Baked;
		center.color = CenterColor;
		center.spotAngle = 95f;
		center.innerSpotAngle = 40f;
		center.range = 40f;
		center.intensity = 2.4f;
		center.shadows = LightShadows.Soft;
		center.shapeRadius = 2f;
		center.transform.position = new Vector3(b.center.x, b.max.y + 16f, b.center.z);
		center.transform.rotation = Quaternion.Euler(90f, 0f, 0f);

		LuzesBraseiros flicker = lights.AddComponent<LuzesBraseiros>();
		flicker.chamas = flames.ToArray();
		flicker.maximo = 3;

		LightProbes(arena, lights.transform, b);

		RenderSettings.skybox = null;
		RenderSettings.ambientMode = AmbientMode.Flat;
		RenderSettings.ambientLight = AmbientColor;
		RenderSettings.subtractiveShadowColor = new Color(0.22f, 0.13f, 0.1f);
		RenderSettings.sun = sun;
		RenderSettings.fog = false;
		Lightmapping.lightingSettings = LightingAsset();

		Object.DestroyImmediate(arena.floor);   // o navmesh e criado de novo pelo jogo (colisao e logica)
		EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
		EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene());
		Debug.Log($"[Mapa] arena salva na cena: {root.GetComponentsInChildren<Renderer>().Length} pecas, {flames.Count} tochas");
	}

	public static void Bake()
	{
		Scene();
		Lightmapping.lightingSettings = LightingAsset();
		Lightmapping.bakeCompleted -= OnBaked;
		Lightmapping.bakeCompleted += OnBaked;
		Lightmapping.BakeAsync();
		Debug.Log("[Mapa] bake iniciado");
	}

	private static void OnBaked()
	{
		Lightmapping.bakeCompleted -= OnBaked;
		EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene());
		long bytes = 0;
		foreach (LightmapData d in LightmapSettings.lightmaps)
		{
			if (d.lightmapColor != null)
			{
				bytes += UnityEngine.Profiling.Profiler.GetRuntimeMemorySizeLong(d.lightmapColor);
			}
		}
		Debug.Log($"[Mapa] bake pronto: {LightmapSettings.lightmaps.Length} lightmaps ({bytes / 1024} KB), {(LightmapSettings.lightProbes != null ? LightmapSettings.lightProbes.count : 0)} probes");
	}

	private static void Scene()
	{
		if (EditorSceneManager.GetActiveScene().path != ScenePath)
		{
			EditorSceneManager.OpenScene(ScenePath, OpenSceneMode.Single);
		}
	}

	// URP para o celular: Forward+ (sem limite de luz por objeto), luz mista ligada, sombra suave so ate 25 m (so herois)
	private static void PipelineSettings()
	{
		var rp = GraphicsSettings.defaultRenderPipeline as UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset;
		if (rp == null)
		{
			return;
		}
		SerializedObject so = new SerializedObject(rp);
		so.FindProperty("m_ShadowDistance").floatValue = 25f;
		so.FindProperty("m_SoftShadowsSupported").boolValue = true;
		so.FindProperty("m_MixedLightingSupported").boolValue = true;
		so.FindProperty("m_AdditionalLightsPerObjectLimit").intValue = 4;
		so.FindProperty("m_ColorGradingMode").enumValueIndex = (int)UnityEngine.Rendering.Universal.ColorGradingMode.HighDynamicRange;   // ACES de verdade
		so.ApplyModifiedPropertiesWithoutUndo();
		var list = (UnityEngine.Rendering.Universal.ScriptableRendererData[])typeof(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset)
			.GetField("m_RendererDataList", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(rp);
		foreach (var d in list)
		{
			if (d is UnityEngine.Rendering.Universal.UniversalRendererData u)
			{
				u.renderingMode = UnityEngine.Rendering.Universal.RenderingMode.ForwardPlus;
				// sem este arquivo o renderer ignora todo o pos-processamento (bloom, cor, exposicao, vinheta)
				if (u.postProcessData == null)
				{
					u.postProcessData = AssetDatabase.LoadAssetAtPath<UnityEngine.Rendering.Universal.PostProcessData>("Packages/com.unity.render-pipelines.universal/Runtime/Data/PostProcessData.asset");
				}
				EditorUtility.SetDirty(u);
			}
		}
		EditorUtility.SetDirty(rp);
		AssetDatabase.SaveAssets();
	}

	// o KayKit vem sem segundo UV: sem ele o lightmap nao tem onde gravar
	private static void EnableLightmapUVs()
	{
		foreach (string guid in AssetDatabase.FindAssets("t:Model", new[] { "Assets/Prototype/Resources/KayKitDungeon" }))
		{
			ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath(AssetDatabase.GUIDToAssetPath(guid));
			if (!imp.generateSecondaryUV)
			{
				imp.generateSecondaryUV = true;
				imp.SaveAndReimport();
			}
		}
	}

	// os 17 materiais do KayKit sao a mesma textura: um material so = menos trocas de estado na GPU
	private static Material SharedMaterial(GameObject root)
	{
		string path = MapDir + "/M_Masmorra.mat";
		Material m = AssetDatabase.LoadAssetAtPath<Material>(path);
		if (m == null)
		{
			Renderer first = root.GetComponentInChildren<Renderer>();
			m = new Material(first.sharedMaterial) { name = "M_Masmorra" };
			m.enableInstancing = true;
			AssetDatabase.CreateAsset(m, path);
		}
		return m;
	}

	private static LightingSettings LightingAsset()
	{
		string path = MapDir + "/IluminacaoArena.lighting";
		LightingSettings s = AssetDatabase.LoadAssetAtPath<LightingSettings>(path);
		if (s == null)
		{
			s = new LightingSettings { name = "IluminacaoArena" };
			AssetDatabase.CreateAsset(s, path);
		}
		s.bakedGI = true;
		s.realtimeGI = false;
		s.mixedBakeMode = MixedLightingMode.Subtractive;   // o mais barato no celular: cenario todo assado, heroi com sombra em tempo real
		s.lightmapper = LightingSettings.Lightmapper.ProgressiveGPU;
		s.lightmapResolution = 5f;                         // texels por metro: chao grande, estilo pintado nao pede detalhe
		s.lightmapPadding = 2;
		s.lightmapMaxSize = 1024;
		s.lightmapCompression = LightmapCompression.NormalQuality;
		s.directionalityMode = LightmapsMode.NonDirectional;
		s.ao = true;
		s.aoMaxDistance = 1.2f;
		s.aoExponentDirect = 1f;
		s.aoExponentIndirect = 1f;
		s.maxBounces = 2;
		s.directSampleCount = 32;
		s.indirectSampleCount = 256;
		s.environmentSampleCount = 128;
		s.filteringMode = LightingSettings.FilterMode.Auto;
		s.albedoBoost = 1f;
		EditorUtility.SetDirty(s);
		AssetDatabase.SaveAssets();
		return s;
	}

	// probes a cada 3 m em cada altura de chao (o mapa tem varios andares), em 2 alturas: pe e cabeca do heroi
	private static void LightProbes(Arena arena, Transform parent, Bounds b)
	{
		List<Vector3> pts = new List<Vector3>();
		for (float x = b.min.x; x <= b.max.x; x += 3f)
		{
			for (float z = b.min.z; z <= b.max.z; z += 3f)
			{
				foreach (float y in arena.FloorHeights(x, z, 0.3f))
				{
					pts.Add(new Vector3(x, y + 0.4f, z));
					pts.Add(new Vector3(x, y + 2.2f, z));
				}
			}
		}
		LightProbeGroup group = new GameObject("Light Probes").AddComponent<LightProbeGroup>();
		group.transform.SetParent(parent, false);
		group.probePositions = pts.ToArray();
	}
}
