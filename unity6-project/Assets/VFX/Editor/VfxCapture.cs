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
