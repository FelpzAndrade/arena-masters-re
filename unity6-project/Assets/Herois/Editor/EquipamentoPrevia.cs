using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

// Previa do equipamento fora do Play: posa o heroi em quadros de varias animacoes e fotografa de dois angulos
// (camera do jogo e de lado, perto). Usado para acertar posicao/rotacao/escala dos encaixes do componente Equipamento.
public static class EquipamentoPrevia
{
	// poses: pares (fbx do clipe, nome do clipe, segundos); salva Captures/<nome>.png (uma linha por pose, 2 angulos)
	public static string Folha(GameObject prefabHeroi, List<(string fbx, string clip, float t)> poses, string nome, System.Action<GameObject> preparar)
	{
		GameObject go = (GameObject)PrefabUtility.InstantiatePrefab(prefabHeroi);
		go.transform.position = new Vector3(0f, 500f, 0f);
		go.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
		preparar?.Invoke(go);
		Camera cam = new GameObject("PreviaCam").AddComponent<Camera>();
		cam.enabled = false;
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.22f, 0.18f, 0.16f);
		cam.fieldOfView = 30f;
		Light luz = new GameObject("PreviaLuz").AddComponent<Light>();
		luz.type = LightType.Directional;
		luz.intensity = 1.3f;
		luz.transform.rotation = Quaternion.Euler(45f, 150f, 0f);
		const int w = 300, h = 330;
		RenderTexture rt = new RenderTexture(w, h, 24);
		cam.targetTexture = rt;
		Texture2D folha = new Texture2D(w * 3, h * poses.Count, TextureFormat.RGB24, false);
		Vector3 foco = new Vector3(0f, 501f, 0f);
		Vector3[] vistas = { new Vector3(0f, 2.6f, -3.8f), new Vector3(3.8f, 0.6f, 0f), new Vector3(0f, 0.7f, 3.9f) };
		AnimationMode.StartAnimationMode();
		for (int i = 0; i < poses.Count; i++)
		{
			AnimationClip clip = null;
			foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(poses[i].fbx))
			{
				if (o is AnimationClip c && c.name == poses[i].clip)
				{
					clip = c;
				}
			}
			AnimationMode.BeginSampling();
			AnimationMode.SampleAnimationClip(go, clip, poses[i].t);
			AnimationMode.EndSampling();
			go.transform.position = new Vector3(0f, 500f, 0f);
			for (int v = 0; v < vistas.Length; v++)
			{
				cam.transform.position = foco + vistas[v];
				cam.transform.LookAt(foco);
				cam.Render();
				RenderTexture.active = rt;
				folha.ReadPixels(new Rect(0, 0, w, h), v * w, (poses.Count - 1 - i) * h);
			}
		}
		AnimationMode.StopAnimationMode();
		RenderTexture.active = null;
		folha.Apply();
		Directory.CreateDirectory("Captures");
		File.WriteAllBytes($"Captures/{nome}.png", folha.EncodeToPNG());
		Object.DestroyImmediate(go);
		Object.DestroyImmediate(cam.gameObject);
		Object.DestroyImmediate(luz.gameObject);
		rt.Release();
		return "ok";
	}
}
