using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Monta a cena Assets/Scenes/VFX_Test.unity (teste de efeitos de skill, combate_spec.md):
// pedaco de masmorra com o mesmo chao/paredes/cor da arena, tochas com brasas, luz e pos-processamento iguais aos da luta,
// o Cavaleiro (heroi de teste das skills), o Aj sem armadura e um boneco de treino cinza. Espaco = Skill B, J = combo, T = volta para o inicio.
// Menu: Arena Masters/VFX/Criar cena VFX_Test. Nao mexe na cena da luta.
public static class VfxTestScene
{
	public const string ScenePath = "Assets/Scenes/VFX_Test.unity";

	[MenuItem("Arena Masters/VFX/Criar cena VFX_Test")]
	public static void Build()
	{
		VfxSkillBBuilder.Build();
		VfxSkillABuilder.Build();
		VfxAmbienteBuilder.Build();
		VfxCavaleiroBuilder.Build();
		EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

		// luz parecida com a da arena (sem bake: cena pequena, luz em tempo real)
		RenderSettings.skybox = null;
		RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
		RenderSettings.ambientLight = new Color(0.3f, 0.22f, 0.17f);
		Light sun = new GameObject("Direcional").AddComponent<Light>();
		sun.type = LightType.Directional;
		sun.color = new Color(1f, 0.86f, 0.72f);
		sun.intensity = 0.5f;
		sun.shadows = LightShadows.Soft;
		sun.transform.rotation = Quaternion.Euler(62f, -35f, 0f);

		GameObject cenario = new GameObject("Cenario");
		Material[] chao =
		{
			AssetDatabase.LoadAssetAtPath<Material>("Assets/Map/Variantes/M_Chao_0_0.mat"),
			AssetDatabase.LoadAssetAtPath<Material>("Assets/Map/Variantes/M_Chao_1_0.mat"),
			AssetDatabase.LoadAssetAtPath<Material>("Assets/Map/Variantes/M_Chao_2_0.mat"),
		};
		Material parede = AssetDatabase.LoadAssetAtPath<Material>("Assets/Map/Variantes/M_Parede_0_0.mat");
		System.Random rng = new System.Random(5);
		for (int x = -5; x <= 5; x++)
		{
			for (int z = -4; z <= 5; z++)
			{
				GameObject t = Place("floor_tile_small", new Vector3(x * 2f, -0.05f, z * 2f), 90f * rng.Next(4), cenario.transform);
				Paint(t, chao[rng.Next(chao.Length)]);
			}
		}
		for (int x = -5; x <= 5; x += 2)
		{
			GameObject w = Place(x % 4 == 1 ? "wall_arched" : "wall", new Vector3(x * 2f, 0f, 11f), 0f, cenario.transform);
			Paint(w, parede);
		}
		GameObject embers = Resources.Load<GameObject>("VFX_BrasasTocha");
		foreach (float x in new[] { -6f, 6f })
		{
			GameObject torch = Place("torch_mounted", new Vector3(x, 2.4f, 10.45f), 180f, cenario.transform);
			Paint(torch, AssetDatabase.LoadAssetAtPath<Material>("Assets/Map/Variantes/M_Prop_0_0.mat"));
			Light l = new GameObject("luz_tocha").AddComponent<Light>();
			l.transform.position = new Vector3(x, 3.1f, 10f);
			l.type = LightType.Point;
			l.color = new Color(1f, 0.55f, 0.25f);
			l.range = 9f;
			l.intensity = 6f;
			GameObject e = (GameObject)PrefabUtility.InstantiatePrefab(embers, cenario.transform);
			e.transform.position = new Vector3(x, 3.1f, 10f);
		}
		foreach (Transform t in cenario.GetComponentsInChildren<Transform>())
		{
			t.gameObject.isStatic = t.GetComponent<ParticleSystem>() == null && t.root.name == "Cenario";
		}

		// heroi: Cavaleiro (corpo do KayKit Knight com as pecas dele, animacoes do Aj por retarget Humanoid)
		GameObject heroi = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(CavaleiroSetup.Fbx));
		heroi.name = "Cavaleiro";
		heroi.transform.SetPositionAndRotation(new Vector3(-2.5f, 0f, 0f), Quaternion.Euler(0f, 90f, 0f));
		CavaleiroSetup.Vestir(heroi);
		Animator anim = heroi.GetComponent<Animator>();
		anim.runtimeAnimatorController = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>("Assets/Herois/Aj/Aj.controller");
		anim.applyRootMotion = false;
		Bounds b = Bounds(heroi);
		SkillEsferaGiratoria skill = heroi.AddComponent<SkillEsferaGiratoria>();
		skill.alturaCentro = b.size.y * 0.45f;
		skill.escala = 1.9f / 1.8f + 0.15f;   // mesma esfera do Aj (o elmo alto nao aumenta o giro)
		CavaleiroSetup.Armar(heroi);   // ponta da lamina e rastro na espada do proprio modelo
		SkillUltimateExplosao ult = heroi.AddComponent<SkillUltimateExplosao>();
		ult.escala = skill.escala;
		AjTeste teste = heroi.AddComponent<AjTeste>();

		// Aj: so boneco de teste das animacoes, sem armadura, parado num canto
		GameObject aj = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Herois/Aj/Aj_Idle.fbx"));
		aj.name = "Aj (teste)";
		aj.transform.SetPositionAndRotation(new Vector3(-7f, 0f, 5f), Quaternion.Euler(0f, 150f, 0f));
		Animator ajAnim = aj.GetComponent<Animator>();
		ajAnim.runtimeAnimatorController = anim.runtimeAnimatorController;
		ajAnim.applyRootMotion = false;

		// boneco de treino: corpo do Rogue do KayKit todo cinza e sem armas (nao se confunde com nenhum heroi)
		GameObject boneco = new GameObject("Boneco de treino");
		boneco.transform.SetPositionAndRotation(new Vector3(-0.6f, 0f, 0f), Quaternion.Euler(0f, -90f, 0f));
		GameObject visual = MontarBoneco(boneco.transform);
		visual.transform.localScale = Vector3.one * 0.85f;
		BonecoTreino dummy = boneco.AddComponent<BonecoTreino>();
		dummy.altura = Bounds(boneco).size.y;
		teste.boneco = dummy;

		GameObject comboGo = new GameObject("Combo");
		teste.combo = comboGo.AddComponent<ComboCounter>();

		Camera cam = new GameObject("Main Camera").AddComponent<Camera>();
		cam.tag = "MainCamera";
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.105f, 0.075f, 0.075f);
		CenaTesteVfx ct = cam.gameObject.AddComponent<CenaTesteVfx>();
		ct.alvo = heroi.transform;
		ct.distancia = 12.5f;
		cam.transform.SetPositionAndRotation(new Vector3(-1.5f, 9.8f, -6.3f), Quaternion.Euler(55f, 0f, 0f));

		EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene(), ScenePath);
		Debug.Log($"[VFX] cena VFX_Test criada (Cavaleiro com {b.size.y:0.00} m, boneco com {dummy.altura:0.00} m)");
	}

	public static GameObject MontarBoneco(Transform pai)
	{
		GameObject visual = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prototype/KayKit/Characters/Rogue.fbx"), pai);
		visual.transform.localPosition = Vector3.zero;
		visual.transform.localRotation = Quaternion.identity;
		Material cinza = CavaleiroSetup.MaterialBoneco();
		foreach (Renderer r in visual.GetComponentsInChildren<Renderer>(true))
		{
			if (r.transform.parent.name.StartsWith("handslot"))
			{
				r.gameObject.SetActive(false);
				continue;
			}
			r.sharedMaterial = cinza;
		}
		return visual;
	}

	private static GameObject Place(string name, Vector3 pos, float yaw, Transform parent)
	{
		GameObject go = (GameObject)PrefabUtility.InstantiatePrefab(Resources.Load<GameObject>("KayKitDungeon/" + name), parent);
		go.transform.SetPositionAndRotation(pos, Quaternion.Euler(0f, yaw, 0f));
		return go;
	}

	private static void Paint(GameObject go, Material m)
	{
		if (m == null)
		{
			return;
		}
		foreach (Renderer r in go.GetComponentsInChildren<Renderer>())
		{
			r.sharedMaterial = m;
		}
	}

	private static Bounds Bounds(GameObject go)
	{
		Renderer[] rs = go.GetComponentsInChildren<Renderer>();
		Bounds b = rs[0].bounds;
		foreach (Renderer r in rs)
		{
			b.Encapsulate(r.bounds);
		}
		return b;
	}
}
