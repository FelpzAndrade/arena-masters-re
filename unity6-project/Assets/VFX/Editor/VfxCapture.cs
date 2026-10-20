using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Captura de teste dos efeitos proprios: luta bot x bot e, quando sai um corte do Machado Barbaro,
// fotografa a sequencia com a camera do jogo (captures/vfx_machado_*.png). Rodar: tools/ci_run.sh VfxCapture.Machado
public static class VfxCapture
{
	public static void Machado()
	{
		EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
		BattleManager bm = new GameObject("BattleManager").AddComponent<BattleManager>();
		bm.playerControlled = false;
		bm.font = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/08SeoulNamsanEB_0.ttf");
		typeof(PrototypeSetup).GetMethod("AssignModels", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public)?.Invoke(null, new object[] { bm });
		bm.Setup();
		string dir = "C:/Users/felip/arena-masters-re/captures";
		Directory.CreateDirectory(dir);
		RenderTexture rt = new RenderTexture(960, 540, 24, RenderTextureFormat.DefaultHDR);
		bm.cam.targetTexture = rt;
		Texture2D tex = new Texture2D(960, 540, TextureFormat.RGB24, false);
		int[] offsets = { 0, 1, 2, 4, 7, 11 };
		int sequences = 0, shot = 0, start = -1;
		bool wasAlive = false;
		for (int frame = 0; frame < 30 * 60 && sequences < 2; frame++)
		{
			bm.Step(1f / 30f);
			bool alive = GameObject.Find("VFX_MachadoBarbaro(Clone)") != null;
			if (alive && !wasAlive && start < 0)
			{
				start = frame;
			}
			wasAlive = alive;
			if (start < 0)
			{
				continue;
			}
			int k = System.Array.IndexOf(offsets, frame - start);
			if (k >= 0)
			{
				bm.cam.Render();
				RenderTexture.active = rt;
				tex.ReadPixels(new Rect(0, 0, 960, 540), 0, 0);
				tex.Apply();
				File.WriteAllBytes($"{dir}/vfx_machado_{shot++}.png", tex.EncodeToPNG());
			}
			if (frame - start > offsets[offsets.Length - 1])
			{
				start = -1;
				sequences++;
			}
		}
		RenderTexture.active = null;
		Debug.Log($"[VFX] captura: {shot} fotos");
	}

	// No Play (pelo MCP): poe o jogador num lugar aberto perto do inimigo, usa a skill e fotografa a sequencia em
	// tempo real (sem pausar: as particulas andam em tempo nao escalado). O inimigo fica parado durante a captura.
	// Fotos em captures/vfx_<nome>_*.png. ahead = quanto a camera olha para a frente do jogador; enemyAhead > 0 poe o inimigo
	// parado nessa distancia, na frente (para ver o acerto), senao ele fica longe da camera.
	public static string PlaySkill(int skill, string name, float ahead = 1.2f, float enemyAhead = 0f, float spotX = 12.5f, float spotZ = -2.71f, float slow = 1f, bool enemyCasts = false)
	{
		BattleManager bm = Object.FindFirstObjectByType<BattleManager>();
		if (!EditorApplication.isPlaying || bm == null || bm.player == null)
		{
			return "precisa estar no Play com a luta aberta";
		}
		Fighter p = enemyCasts ? bm.enemy : bm.player, e = enemyCasts ? bm.player : bm.enemy;   // p usa a skill, e e o alvo
		bm.brainsPaused = true;
		p.invulnerable = e.invulnerable = true;
		System.Reflection.FieldInfo goField = typeof(Fighter).GetField("go", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
		GameObject go = (GameObject)goField.GetValue(p), enemyGo = (GameObject)goField.GetValue(e);
		Vector3 spot = new Vector3(spotX, 1.31f, spotZ);    // trecho aberto do DuelArena (padrao); corredor longo: (-17, -7)
		string dir = "C:/Users/felip/arena-masters-re/captures";
		Directory.CreateDirectory(dir);
		float[] times = { 0.25f, 0.34f, 0.42f, 0.55f, 0.75f, 1f, 1.4f, 2f };
		int idx = -1;
		double t0 = 0;
		Camera cam = null;
		RenderTexture rt = null;
		EditorApplication.CallbackFunction cb = null;
		cb = () =>
		{
			if (!EditorApplication.isPlaying)
			{
				EditorApplication.update -= cb;
				return;
			}
			enemyGo.transform.position = enemyAhead > 0f ? spot + Vector3.right * enemyAhead : spot + new Vector3(0f, 0f, 7f);
			for (int i = 0; i < e.cooldowns.Length; i++)
			{
				e.cooldowns[i] = 99f;
			}
			if (idx < 0)
			{
				if (!p.CanAct)
				{
					return;
				}
				go.transform.position = spot;
				p.facing = Vector3.right;
				go.transform.rotation = Quaternion.LookRotation(Vector3.right);
				p.cooldowns[skill] = 0f;
				if (skill == Fighter.UltSlot)
				{
					p.ultCharge = 10000f;   // barra cheia
				}
				if (!p.TryUseSkill(skill, spot + Vector3.right * 3f))
				{
					return;
				}
				Vector3 c = p.Position + Vector3.right * ahead + Vector3.down * 0.7f;
				cam = new GameObject("CapturaVfx").AddComponent<Camera>();
				cam.CopyFrom(bm.cam);
				UnityEngine.Rendering.Universal.CameraExtensions.GetUniversalAdditionalCameraData(cam).renderPostProcessing = true;
				cam.enabled = false;
				cam.transform.position = c + new Vector3(1.2f, 3.6f, -4.2f) * Mathf.Max(1f, ahead / 2.4f);   // afasta para golpes longos
				cam.transform.LookAt(c);
				rt = new RenderTexture(960, 540, 24, RenderTextureFormat.ARGB32);
				cam.targetTexture = rt;
				t0 = EditorApplication.timeSinceStartup;
				idx = 0;
				return;
			}
			if (idx >= times.Length)
			{
				EditorApplication.update -= cb;
				Object.DestroyImmediate(cam.gameObject);
				rt.Release();
				bm.brainsPaused = false;
				Debug.Log("[VFX] captura ao vivo pronta: " + name);
				return;
			}
			if (EditorApplication.timeSinceStartup - t0 < times[idx] * slow)   // slow > 1 espalha as fotos (ultimate tem camera lenta)
			{
				return;
			}
			cam.Render();
			RenderTexture.active = rt;
			Texture2D tex = new Texture2D(960, 540, TextureFormat.RGB24, false);
			tex.ReadPixels(new Rect(0, 0, 960, 540), 0, 0);
			tex.Apply();
			RenderTexture.active = null;
			File.WriteAllBytes($"{dir}/vfx_{name}_{idx}.png", tex.EncodeToPNG());
			Object.DestroyImmediate(tex);
			idx++;
		};
		EditorApplication.update += cb;
		return "agendado";
	}

	// No Play: congela a luta (ninguem pensa nem leva dano) e fotografa pela camera do jogo, com pos-processamento,
	// direto num RenderTexture (o print da Game View pode vir velho quando o editor esta sem foco).
	// Salva em unity6-project/Captures/<nome>.png e devolve o brilho (media e percentis 10/50/90, so a area de jogo).
	public static string MapShot(string name)
	{
		BattleManager bm = Object.FindFirstObjectByType<BattleManager>();
		if (!EditorApplication.isPlaying || bm == null)
		{
			return "precisa estar no Play com a luta aberta";
		}
		bm.brainsPaused = true;
		bm.player.invulnerable = bm.enemy.invulnerable = true;
		RenderTexture rt = new RenderTexture(960, 540, 24);
		RenderTexture old = bm.cam.targetTexture;
		bm.cam.targetTexture = rt;
		bm.cam.Render();
		bm.cam.targetTexture = old;
		RenderTexture.active = rt;
		Texture2D tex = new Texture2D(960, 540, TextureFormat.RGB24, false);
		tex.ReadPixels(new Rect(0, 0, 960, 540), 0, 0);
		tex.Apply();
		RenderTexture.active = null;
		rt.Release();
		Directory.CreateDirectory("Captures");
		File.WriteAllBytes($"Captures/{name}.png", tex.EncodeToPNG());
		System.Collections.Generic.List<float> lum = new System.Collections.Generic.List<float>();
		Color[] px = tex.GetPixels();
		for (int i = 0; i < px.Length; i += 7)
		{
			int y = i / 960;
			if (y > 110 && y < 500)   // sem a barra de habilidades e o placar (a imagem vem de baixo para cima)
			{
				Color c = px[i];
				lum.Add(c.r * 0.299f + c.g * 0.587f + c.b * 0.114f);
			}
		}
		lum.Sort();
		float avg = 0f;
		foreach (float l in lum)
		{
			avg += l;
		}
		avg /= lum.Count;
		return $"media={avg:0.000} p10={lum[lum.Count / 10]:0.000} p50={lum[lum.Count / 2]:0.000} p90={lum[lum.Count * 9 / 10]:0.000}";
	}

	// Cena VFX_Test no Play: dispara uma acao do Aj ("skillB" ou "combo") e fotografa pela camera principal nos tempos
	// pedidos (segundos reais depois de apertar). Fotos em Captures/<nome>_<i>.png. times vazio = so uma foto agora.
	public static string TesteShot(string name, string acao, float[] times)
	{
		AjTeste aj = Object.FindAnyObjectByType<AjTeste>();
		Camera cam = Camera.main;
		if (!EditorApplication.isPlaying || aj == null || cam == null)
		{
			return "precisa estar no Play com a cena VFX_Test";
		}
		Directory.CreateDirectory("Captures");
		void Shot(string file)
		{
			RenderTexture rt = new RenderTexture(960, 540, 24);
			RenderTexture old = cam.targetTexture;
			cam.targetTexture = rt;
			cam.Render();
			cam.targetTexture = old;
			RenderTexture.active = rt;
			Texture2D tex = new Texture2D(960, 540, TextureFormat.RGB24, false);
			tex.ReadPixels(new Rect(0, 0, 960, 540), 0, 0);
			tex.Apply();
			RenderTexture.active = null;
			rt.Release();
			File.WriteAllBytes($"Captures/{file}.png", tex.EncodeToPNG());
			Object.DestroyImmediate(tex);
		}
		if (times == null || times.Length == 0)
		{
			Shot(name);
			return "ok";
		}
		aj.Resetar();   // sempre do mesmo lugar, para comparar fotos
		System.Action disparo = acao == "skillB" ? aj.SkillB : acao == "combo" ? aj.Atacar : (System.Action)null;
		CapturaSequencia.Iniciar(name, times, disparo);   // dispara e fotografa de dentro do jogo, no tempo exato
		return "agendado";
	}

	// os shaders do Cartoon FX sao gerados na importacao para o pipeline ativo: depois de trocar de pipeline, reimportar
	public static void ReimportCfxr()
	{
		foreach (string f in Directory.GetFiles("Assets/JMO Assets/Cartoon FX Remaster/CFXR Assets/Shaders", "*.cfxrshader"))
		{
			AssetDatabase.ImportAsset(f.Replace('\\', '/'), ImportAssetOptions.ForceUpdate);
		}
	}

	// lista o shader de cada efeito que aparece numa luta de 60 s (acha o que o pipeline nao desenha)
	public static void Diagnose()
	{
		EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
		BattleManager bm = new GameObject("BattleManager").AddComponent<BattleManager>();
		bm.playerControlled = false;
		typeof(PrototypeSetup).GetMethod("AssignModels", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)?.Invoke(null, new object[] { bm });
		bm.Setup();
		System.Collections.Generic.HashSet<string> seen = new System.Collections.Generic.HashSet<string>();
		System.Text.StringBuilder log = new System.Text.StringBuilder();
		for (int frame = 0; frame < 30 * 60; frame++)
		{
			bm.Step(1f / 30f);
			foreach (Renderer r in Object.FindObjectsByType<Renderer>(FindObjectsSortMode.None))
			{
				if (!(r is ParticleSystemRenderer || r is TrailRenderer || r is LineRenderer))
				{
					continue;
				}
				Transform root = r.transform.root;
				foreach (Material m in r.sharedMaterials)
				{
					string sh = m == null ? "NULL" : m.shader.name;
					bool ok = m != null && m.shader.isSupported && !ShaderUtil.ShaderHasError(m.shader);
					string key = $"{root.name} / {r.name} : {sh} ok={ok}";
					if (seen.Add(key))
					{
						log.AppendLine(key);
					}
				}
			}
		}
		File.WriteAllText("C:/Users/felip/arena-masters-re/captures/vfx_diagnostico.txt", log.ToString());
	}
}
