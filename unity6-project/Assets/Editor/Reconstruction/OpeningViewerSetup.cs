using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Monta a cena do visualizador da abertura e gera capturas das paginas para verificacao.
public static class OpeningViewerSetup
{
	private const string ScenePath = "Assets/Scenes/OpeningViewer.unity";
	private const string FontPath = "Assets/Font/08SeoulNamsanEB_0.ttf";

	[MenuItem("Arena Masters/Abrir abertura (quadrinhos)")]
	public static void CreateAndOpen()
	{
		EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
		var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
		OpeningViewer viewer = new GameObject("OpeningViewer").AddComponent<OpeningViewer>();
		viewer.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		EditorSceneManager.SaveScene(scene, ScenePath);
		Debug.Log("Cena da abertura criada em " + ScenePath + ". Aperte Play.");
	}

	// Batchmode: monta o visualizador fora do Play e renderiza algumas paginas em PNG.
	public static void Capture()
	{
		EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
		OpeningViewer viewer = new GameObject("OpeningViewer").AddComponent<OpeningViewer>();
		viewer.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		viewer.Setup();
		string dir = "C:/Users/felip/arena-masters-re/captures";
		Directory.CreateDirectory(dir);
		RenderTexture rt = new RenderTexture(1280, 720, 24);
		Camera cam = viewer.ViewCamera;
		cam.targetTexture = rt;
		Texture2D tex = new Texture2D(1280, 720, TextureFormat.RGB24, false);
		int[] pages = { 0, 1, 2, 5, 9, viewer.PageCount - 1 };
		foreach (int page in pages)
		{
			viewer.ShowPage(page);
			Canvas.ForceUpdateCanvases();
			cam.Render();
			RenderTexture.active = rt;
			tex.ReadPixels(new Rect(0, 0, 1280, 720), 0, 0);
			tex.Apply();
			File.WriteAllBytes($"{dir}/opening_page_{page + 1:00}.png", tex.EncodeToPNG());
		}
		RenderTexture.active = null;
		File.WriteAllText($"{dir}/opening_info.txt", "paginas=" + viewer.PageCount);
	}
}
