using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

// Captura rapida SEM entrar no Play: poe os herois em fila no trecho mais aberto da arena salva (Prototype1x1, com a luz
// do bake), amostra a pose de cada um (parado, correndo ou um quadro de uma skill), simula o efeito pedido ate o mesmo
// instante e fotografa pela camera da luta (55 graus, FOV 33, 16,5 m, pos-processamento da arena) e por uma camera
// aproximada no heroi em foco. Junta tudo numa imagem so, com legenda: Captures/rapida_<nome>.png.
// Menu: Arena Masters/Captura rapida/... (atalhos prontos e a janela para escolher pose e tempo de cada heroi).
// Pelo codigo (MCP): CapturaRapida.Tirar(new CapturaRapida.Pedido { ... }).
// Os objetos sao criados na cena da luta marcados "nao salvar" (HideFlags.DontSave) e apagados no fim: a cena nao fica
// alterada. (Uma cena temporaria carregada junto descarregaria o lightmap da luta ate o proximo quadro do editor.)
public static class CapturaRapida
{
	public const string CenaLuta = "Assets/Scenes/Prototype1x1.unity";
	static readonly Vector3 Centro = new Vector3(-8.77f, 0.31f, -7.43f);   // trecho mais aberto do DuelArena (8,7 m ate a borda)
	const float Espaco = 2.2f;
	const int Camada = 31;   // camada so da legenda

	[System.Serializable]
	public class Personagem
	{
		public string heroi = "Axie";      // Axie, Spark, Cavaleiro, Boneco, Aj
		public string pose = "idle";       // idle, correr, skill1..4 / ult (Axie e Spark), Redemoinho, GolpeChao, Ataque1..4 (Cavaleiro/Aj) ou o nome do clipe
		public float tempo = 0.5f;         // segundos dentro do clipe
		public int quadro = -1;            // >= 0: usa o quadro do clipe no lugar do tempo
		public bool deLado;                // de lado para a camera (correr/skills) em vez de virado para ela
		public string efeito = "";         // prefab de Resources simulado no mesmo instante (ex.: VFX_EsferaGiratoria)
		public float tempoEfeito = -1f;    // segundos de efeito (-1 = o tempo da pose menos o atraso)
		public Color corEfeito = Color.white;
		public float alturaEfeito = 1.15f;

		public Personagem() { }
		public Personagem(string heroi, string pose = "idle", float tempo = 0.5f) { this.heroi = heroi; this.pose = pose; this.tempo = tempo; }
	}

	[System.Serializable]
	public class Pedido
	{
		public string nome = "rapida";
		public string titulo = "";
		public List<Personagem> fileira = new List<Personagem>();
		public int foco = 2;               // indice do heroi da camera aproximada
	}

	// ---------- atalhos do menu ----------

	public static Pedido Fileira(string pose, bool deLado)
	{
		Pedido p = new Pedido { nome = "fileira_" + pose, titulo = "Leitura: " + pose };
		foreach (string h in new[] { "Axie", "Spark", "Cavaleiro", "Boneco" })
		{
			p.fileira.Add(new Personagem(h, h == "Boneco" ? "idle" : pose, 0.5f) { deLado = deLado });
		}
		return p;
	}

	[MenuItem("Arena Masters/Captura rapida/Fileira parada")]
	public static void MenuParada() => Abrir(Tirar(Fileira("idle", false)));

	[MenuItem("Arena Masters/Captura rapida/Fileira correndo")]
	public static void MenuCorrendo() => Abrir(Tirar(Fileira("correr", true)));

	[MenuItem("Arena Masters/Captura rapida/Cavaleiro na Skill B")]
	public static void MenuSkillB()
	{
		Pedido p = Fileira("idle", false);
		p.nome = "cavaleiro_skillB";
		p.titulo = "Cavaleiro no meio da Skill B (Redemoinho 0,6 s)";
		p.fileira[2] = new Personagem("Cavaleiro", "Redemoinho", 0.6f) { efeito = "VFX_EsferaGiratoria", tempoEfeito = 0.4f, corEfeito = new Color(0.04f, 0.4f, 1f) };
		Abrir(Tirar(p));
	}

	[MenuItem("Arena Masters/Captura rapida/Janela...")]
	public static void MenuJanela() => EditorWindow.GetWindow<CapturaRapidaJanela>("Captura rapida");

	static void Abrir(string caminho)
	{
		if (caminho != null && File.Exists(caminho))
		{
			EditorUtility.RevealInFinder(caminho);
		}
	}

	// ---------- captura ----------

	// devolve o caminho da imagem (ou null, com o motivo no Console)
	public static string Tirar(Pedido pedido)
	{
		if (EditorApplication.isPlayingOrWillChangePlaymode)
		{
			Debug.LogWarning("[Captura rapida] saia do Play primeiro (a ferramenta e para fora do Play)");
			return null;
		}
		Scene luta = SceneManager.GetSceneByPath(CenaLuta);
		if (!luta.isLoaded)
		{
			if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
			{
				return null;
			}
			luta = EditorSceneManager.OpenScene(CenaLuta, OpenSceneMode.Single);
		}
		SceneManager.SetActiveScene(luta);   // luz, ambiente e probes vem da cena ativa
		Scene temp = luta;
		List<GameObject> criados = new List<GameObject>();
		RenderTexture rtLuta = null, rtPerto = null, rtLegenda = null;
		AnimationMode.StartAnimationMode();
		try
		{
			float yaw = 0f;
			Quaternion giro = Quaternion.Euler(0f, yaw, 0f);
			Vector3 lado = giro * Vector3.right, paraCamera = giro * Vector3.back;
			int n = pedido.fileira.Count;
			List<GameObject> herois = new List<GameObject>();
			List<string> legendas = new List<string>();
			for (int i = 0; i < n; i++)
			{
				Personagem pe = pedido.fileira[i];
				GameObject go = Montar(pe.heroi);
				if (go == null)
				{
					Debug.LogWarning("[Captura rapida] heroi desconhecido: " + pe.heroi);
					continue;
				}
				Marcar(go, criados);
				criados.Add(go);
				herois.Add(go);
				Vector3 pos = Centro + lado * ((i - (n - 1) * 0.5f) * Espaco);
				go.transform.SetPositionAndRotation(pos, Quaternion.LookRotation(pe.deLado ? lado : paraCamera));
				string desc = Posar(go, pe);
				if (!string.IsNullOrEmpty(pe.efeito))
				{
					desc += Efeito(go, pe, temp, criados);
				}
				legendas.Add(pe.heroi + ": " + desc);
			}
			foreach (GameObject h in herois)
			{
				// efeitos em laco presos no heroi (faiscas da espada): 1,5 s simulados, como se ja estivessem no ar
				foreach (ParticleSystem ps in h.GetComponentsInChildren<ParticleSystem>(false))
				{
					if (ps.main.loop && (ps.transform.parent == null || ps.transform.parent.GetComponentInParent<ParticleSystem>() == null))
					{
						ps.Simulate(1.5f, true, true);
					}
				}
			}

			// camera da luta
			Vector3 foco = Centro + Vector3.up * 1f;
			Camera cam = NovaCamera(temp, criados, out Volume vol);
			cam.fieldOfView = 33f;
			cam.transform.rotation = Quaternion.Euler(55f, yaw, 0f);
			cam.transform.position = foco - cam.transform.forward * 16.5f;
			rtLuta = Render(cam, 960, 540);
			Texture2D luta960 = Ler(rtLuta);

			// camera aproximada no heroi em foco
			int f = Mathf.Clamp(pedido.foco, 0, herois.Count - 1);
			Vector3 alvo = herois[f].transform.position + Vector3.up * 1.1f;
			cam.fieldOfView = 30f;
			cam.transform.position = alvo + paraCamera * 4.2f + lado * 1.1f + Vector3.up * 2.4f;
			cam.transform.LookAt(alvo);
			rtPerto = Render(cam, 540, 540);
			Texture2D perto = Ler(rtPerto);

			// legenda
			string titulo = string.IsNullOrEmpty(pedido.titulo) ? pedido.nome : pedido.titulo;
			string linha1 = $"{titulo}   |   esquerda: camera da luta (55 graus, 16,5 m, FOV 33)   |   direita: {pedido.fileira[f].heroi} de perto";
			string linha2 = string.Join("   .   ", legendas);
			rtLegenda = Legenda(temp, criados, linha1 + "\n" + linha2, 1500, 64);
			Texture2D legenda = Ler(rtLegenda);

			Texture2D folha = new Texture2D(1500, 604, TextureFormat.RGB24, false);
			folha.SetPixels(0, 0, 960, 540, luta960.GetPixels());
			folha.SetPixels(960, 0, 540, 540, perto.GetPixels());
			folha.SetPixels(0, 540, 1500, 64, legenda.GetPixels());
			folha.Apply();
			Directory.CreateDirectory("Captures");
			string caminho = $"Captures/rapida_{pedido.nome}.png";
			File.WriteAllBytes(caminho, folha.EncodeToPNG());
			Object.DestroyImmediate(vol.sharedProfile);
			foreach (Texture2D t in new[] { luta960, perto, legenda, folha })
			{
				Object.DestroyImmediate(t);
			}
			Debug.Log("[Captura rapida] " + Path.GetFullPath(caminho));
			return Path.GetFullPath(caminho);
		}
		finally
		{
			AnimationMode.StopAnimationMode();
			foreach (RenderTexture rt in new[] { rtLuta, rtPerto, rtLegenda })
			{
				if (rt != null)
				{
					rt.Release();
				}
			}
			foreach (GameObject go in criados)
			{
				if (go != null)
				{
					Object.DestroyImmediate(go);
				}
			}
		}
	}

	// objeto temporario: nao vai para o arquivo da cena e e apagado no fim da captura
	static void Marcar(GameObject go, List<GameObject> criados)
	{
		foreach (Transform t in go.GetComponentsInChildren<Transform>(true))
		{
			t.gameObject.hideFlags = HideFlags.DontSave;
		}
		if (!criados.Contains(go))
		{
			criados.Add(go);
		}
	}

	// ---------- herois ----------

	static GameObject Montar(string heroi)
	{
		switch (heroi)
		{
			case "Axie":
				return Lutador(FighterDef.Axie(), "Assets/Prototype/KayKit/Characters/Barbarian.fbx");
			case "Spark":
				return Lutador(FighterDef.Spark(), "Assets/Prototype/KayKit/Characters/Mage.fbx");
			case "Cavaleiro":
			{
				GameObject go = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(CavaleiroSetup.Fbx));
				CavaleiroSetup.Vestir(go);
				return Preparar(go);
			}
			case "Aj":
				return Preparar((GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Herois/Aj/Aj_Idle.fbx")));
			case "Boneco":
			{
				GameObject go = new GameObject("Boneco de treino");
				VfxTestScene.MontarBoneco(go.transform).transform.localScale = Vector3.one * 0.85f;
				return Preparar(go);
			}
		}
		return null;
	}

	static GameObject Lutador(FighterDef def, string fbx)
	{
		GameObject go = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(fbx));
		go.name = def.name;
		foreach (Transform t in go.GetComponentsInChildren<Transform>(true))
		{
			if (System.Array.IndexOf(def.hiddenParts, t.name) >= 0)
			{
				t.gameObject.SetActive(false);
			}
		}
		return Preparar(go);
	}

	static GameObject Preparar(GameObject go)
	{
		foreach (SkinnedMeshRenderer smr in go.GetComponentsInChildren<SkinnedMeshRenderer>(true))
		{
			smr.forceMatrixRecalculationPerRender = true;   // sem isso a malha com esqueleto fica uma pose atrasada na foto
			smr.updateWhenOffscreen = true;
		}
		return go;
	}

	// amostra o clipe da pose; devolve a descricao para a legenda
	static string Posar(GameObject go, Personagem pe)
	{
		AnimationClip clip = pe.heroi == "Axie" || pe.heroi == "Spark" ? ClipeLutador(pe) : pe.heroi == "Boneco" ? ClipeBoneco() : ClipeHumanoide(pe.pose);
		if (clip == null)
		{
			return pe.pose + " (clipe nao achado)";
		}
		float t = pe.quadro >= 0 ? pe.quadro / clip.frameRate : pe.tempo;
		if (clip.isLooping || pe.pose == "idle" || pe.pose == "correr")
		{
			t = Mathf.Repeat(t, clip.length);
		}
		t = Mathf.Min(t, clip.length);
		Vector3 pos = go.transform.position;
		Quaternion rot = go.transform.rotation;
		if (clip.legacy)
		{
			// clipes antigos (Axie, Spark, boneco): caminhos a partir da raiz do modelo KayKit (o objeto com o Animation)
			Animation anim = go.GetComponentInChildren<Animation>(true);
			clip.SampleAnimation(anim != null ? anim.gameObject : go, t);
		}
		else
		{
			AnimationMode.BeginSampling();
			AnimationMode.SampleAnimationClip(go, clip, t);
			AnimationMode.EndSampling();
		}
		go.transform.SetPositionAndRotation(pos, rot);   // a pose nao mexe no lugar do heroi na fila
		int q = Mathf.RoundToInt(t * clip.frameRate), total = Mathf.RoundToInt(clip.length * clip.frameRate);
		return $"{pe.pose} {t:0.00} s (quadro {q} de {total})";
	}

	static AnimationClip ClipeLutador(Personagem pe)
	{
		FighterDef def = pe.heroi == "Axie" ? FighterDef.Axie() : FighterDef.Spark();
		string nome = pe.pose;
		if (pe.pose == "idle")
		{
			nome = def.animIdle;
		}
		else if (pe.pose == "correr")
		{
			nome = def.animRun;
		}
		else if (pe.pose == "ult")
		{
			nome = def.ultimate?.anim;
		}
		else if (pe.pose.StartsWith("skill") && int.TryParse(pe.pose.Substring(5), out int i) && i >= 1 && i <= def.skills.Length)
		{
			nome = def.skills[i - 1].anim;
		}
		if (string.IsNullOrEmpty(nome))
		{
			return null;
		}
		AnimationClip c = Resources.Load<AnimationClip>("Anim/" + nome);
		if (c != null)
		{
			return c;
		}
		string fbx = pe.heroi == "Axie" ? "Assets/Prototype/KayKit/Characters/Barbarian.fbx" : "Assets/Prototype/KayKit/Characters/Mage.fbx";
		foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(fbx))
		{
			if (o is AnimationClip ac && ac.name == nome)
			{
				return ac;
			}
		}
		return null;
	}

	// boneco de treino: guarda parada do proprio Rogue (sem arma, nao pode parecer heroi em acao)
	static AnimationClip ClipeBoneco()
	{
		foreach (Object o in AssetDatabase.LoadAllAssetsAtPath("Assets/Prototype/KayKit/Characters/Rogue.fbx"))
		{
			if (o is AnimationClip ac && ac.name == "Idle")
			{
				return ac;
			}
		}
		return null;
	}

	// clipes do Aj (Mixamo, Humanoid): servem no Cavaleiro e no Aj
	static AnimationClip ClipeHumanoide(string pose)
	{
		string nome = pose == "idle" ? "Aj_Idle" : pose == "correr" ? "Aj_Run" : pose == "ult" ? "Aj_GolpeChao" : pose == "skillB" ? "Aj_Redemoinho" : pose.StartsWith("Aj_") ? pose : "Aj_" + pose;
		foreach (string guid in AssetDatabase.FindAssets("t:Model", new[] { "Assets/Herois/Aj" }))
		{
			foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GUIDToAssetPath(guid)))
			{
				if (o is AnimationClip ac && ac.name == nome)
				{
					return ac;
				}
			}
		}
		return null;
	}

	// efeito de Resources no centro do corpo, virado para a frente do heroi, simulado ate o instante pedido
	static string Efeito(GameObject go, Personagem pe, Scene temp, List<GameObject> criados)
	{
		GameObject prefab = Resources.Load<GameObject>(pe.efeito);
		if (prefab == null)
		{
			return $" + {pe.efeito} (nao achado)";
		}
		float t = pe.tempoEfeito >= 0f ? pe.tempoEfeito : pe.tempo;
		Vector3 pos = go.transform.position + Vector3.up * pe.alturaEfeito;
		GameObject fx = EfeitoCor.Criar(prefab, pos, go.transform.rotation, null, pe.corEfeito, 1f, 99f);
		Marcar(fx, criados);
		criados.Add(fx);
		foreach (ParticleSystem ps in fx.GetComponentsInChildren<ParticleSystem>(true))
		{
			if (ps.transform.parent == null || ps.transform.parent.GetComponentInParent<ParticleSystem>() == null)
			{
				ps.Simulate(t, true, true);   // raiz de cada arvore de sistemas (os filhos vao junto)
			}
		}
		return $" + {pe.efeito} {t:0.00} s";
	}

	// ---------- camera, legenda ----------

	static Camera NovaCamera(Scene temp, List<GameObject> criados, out Volume vol)
	{
		Camera cam = new GameObject("CameraCaptura").AddComponent<Camera>();
		Marcar(cam.gameObject, criados);
		cam.enabled = false;
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.105f, 0.075f, 0.075f);   // igual ao fundo da luta
		cam.cullingMask = ~(1 << Camada);
		vol = PosProcessamentoArena.Aplicar(cam);
		Marcar(vol.gameObject, criados);
		return cam;
	}

	static RenderTexture Render(Camera cam, int w, int h)
	{
		RenderTexture rt = new RenderTexture(w, h, 24);
		cam.targetTexture = rt;
		cam.Render();
		cam.targetTexture = null;
		return rt;
	}

	static Texture2D Ler(RenderTexture rt)
	{
		RenderTexture old = RenderTexture.active;
		RenderTexture.active = rt;
		Texture2D tex = new Texture2D(rt.width, rt.height, TextureFormat.RGB24, false);
		tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
		tex.Apply();
		RenderTexture.active = old;
		return tex;
	}

	static RenderTexture Legenda(Scene temp, List<GameObject> criados, string texto, int w, int h)
	{
		Vector3 longe = new Vector3(0f, -3000f, 0f);
		GameObject go = new GameObject("Legenda");
		Marcar(go, criados);
		go.layer = Camada;
		go.transform.position = longe;
		TextMeshPro tmp = go.AddComponent<TextMeshPro>();
		tmp.text = texto;
		tmp.fontSize = 2.2f;
		tmp.color = new Color(0.92f, 0.9f, 0.86f);
		tmp.alignment = TextAlignmentOptions.MidlineLeft;
		tmp.enableWordWrapping = false;
		tmp.overflowMode = TextOverflowModes.Ellipsis;
		float altura = 1f, largura = altura * w / h;
		tmp.rectTransform.sizeDelta = new Vector2(largura - 0.3f, altura);
		tmp.ForceMeshUpdate();
		Camera cam = new GameObject("CameraLegenda").AddComponent<Camera>();
		Marcar(cam.gameObject, criados);
		cam.enabled = false;
		cam.orthographic = true;
		cam.orthographicSize = altura * 0.5f;
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.07f, 0.06f, 0.06f);
		cam.cullingMask = 1 << Camada;
		cam.transform.position = longe + Vector3.back * 5f;
		cam.nearClipPlane = 0.1f;
		cam.farClipPlane = 20f;
		return Render(cam, w, h);
	}
}

// janela: escolhe heroi, pose, tempo e efeito de cada lugar da fila
public class CapturaRapidaJanela : EditorWindow
{
	static readonly string[] Herois = { "Axie", "Spark", "Cavaleiro", "Boneco", "Aj" };
	CapturaRapida.Pedido m_pedido;
	Vector2 m_rolagem;

	void OnEnable()
	{
		m_pedido ??= CapturaRapida.Fileira("idle", false);
	}

	void OnGUI()
	{
		EditorGUILayout.HelpBox("Fotografa fora do Play pela camera da luta e por uma camera aproximada, numa imagem so (Captures/rapida_<nome>.png).\n" +
			"Pose: idle, correr, skill1..4/ult (Axie, Spark) ou Redemoinho, GolpeChao, Ataque1..4 (Cavaleiro, Aj).", MessageType.Info);
		m_pedido.nome = EditorGUILayout.TextField("Nome do arquivo", m_pedido.nome);
		m_pedido.titulo = EditorGUILayout.TextField("Titulo", m_pedido.titulo);
		m_rolagem = EditorGUILayout.BeginScrollView(m_rolagem);
		for (int i = 0; i < m_pedido.fileira.Count; i++)
		{
			CapturaRapida.Personagem p = m_pedido.fileira[i];
			EditorGUILayout.BeginVertical("box");
			EditorGUILayout.BeginHorizontal();
			int h = Mathf.Max(0, System.Array.IndexOf(Herois, p.heroi));
			p.heroi = Herois[EditorGUILayout.Popup(h, Herois)];
			if (GUILayout.Toggle(m_pedido.foco == i, "foco", "Button", GUILayout.Width(50)))
			{
				m_pedido.foco = i;
			}
			if (GUILayout.Button("X", GUILayout.Width(24)))
			{
				m_pedido.fileira.RemoveAt(i);
				GUIUtility.ExitGUI();
			}
			EditorGUILayout.EndHorizontal();
			p.pose = EditorGUILayout.TextField("Pose", p.pose);
			p.tempo = EditorGUILayout.FloatField("Tempo (s)", p.tempo);
			p.quadro = EditorGUILayout.IntField("Quadro (-1 = usa o tempo)", p.quadro);
			p.deLado = EditorGUILayout.Toggle("De lado", p.deLado);
			p.efeito = EditorGUILayout.TextField("Efeito (Resources)", p.efeito);
			if (!string.IsNullOrEmpty(p.efeito))
			{
				p.tempoEfeito = EditorGUILayout.FloatField("Tempo do efeito (s)", p.tempoEfeito);
				p.corEfeito = EditorGUILayout.ColorField("Cor do efeito", p.corEfeito);
			}
			EditorGUILayout.EndVertical();
		}
		EditorGUILayout.EndScrollView();
		if (GUILayout.Button("+ heroi"))
		{
			m_pedido.fileira.Add(new CapturaRapida.Personagem());
		}
		if (GUILayout.Button("Tirar foto", GUILayout.Height(32)))
		{
			string c = CapturaRapida.Tirar(m_pedido);
			if (c != null)
			{
				EditorUtility.RevealInFinder(c);
			}
		}
	}
}
