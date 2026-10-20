using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Cena do prototipo de luta 1x1 e captura automatica (bot x bot) para verificacao.
public static class PrototypeSetup
{
	private const string ScenePath = "Assets/Scenes/Prototype1x1.unity";
	private const string FontPath = "Assets/Font/08SeoulNamsanEB_0.ttf";
	private const string BarbarianPath = "Assets/Prototype/KayKit/Characters/Barbarian.fbx";
	private const string MagePath = "Assets/Prototype/KayKit/Characters/Mage.fbx";

	private static void AssignModels(BattleManager bm)
	{
		KayKitImport.EnsureLegacy(BarbarianPath);
		KayKitImport.EnsureLegacy(MagePath);
		bm.machadinhaModel = AssetDatabase.LoadAssetAtPath<GameObject>(BarbarianPath);
		System.Collections.Generic.List<GameObject> fx = new System.Collections.Generic.List<GameObject>();
		foreach (string guid in AssetDatabase.FindAssets("CFXR t:Prefab"))
		{
			fx.Add(AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(guid)));
		}
		bm.effectPrefabs = fx.ToArray();
		string[] post = AssetDatabase.FindAssets("t:PostProcessResources");
		if (post.Length > 0)
		{
			bm.postResources = AssetDatabase.LoadAssetAtPath<UnityEngine.Rendering.PostProcessing.PostProcessResources>(AssetDatabase.GUIDToAssetPath(post[0]));
		}
		bm.bruxaModel = AssetDatabase.LoadAssetAtPath<GameObject>(MagePath);
	}

	[MenuItem("Arena Masters/Abrir luta 1x1 (prototipo)")]
	public static void CreateAndOpen()
	{
		EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
		var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
		BattleManager bm = new GameObject("BattleManager").AddComponent<BattleManager>();
		bm.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		AssignModels(bm);
		EditorSceneManager.SaveScene(scene, ScenePath);
		Debug.Log("Cena da luta criada em " + ScenePath + ". Aperte Play.");
	}

	public static void Capture()
	{
		EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
		GameObject host = new GameObject("BattleManager");
		BattleManager bm = host.AddComponent<BattleManager>();
		bm.playerControlled = false;
		bm.font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
		AssignModels(bm);
		bm.Setup();
		string dir = "C:/Users/felip/arena-masters-re/captures";
		Directory.CreateDirectory(dir);
		RenderTexture rt = new RenderTexture(1280, 720, 24);
		bm.cam.targetTexture = rt;
		Texture2D tex = new Texture2D(1280, 720, TextureFormat.RGB24, false);
		StringBuilder log = new StringBuilder();
		float dt = 1f / 30f;
		int shot = 0, lastFx = -1000, fxShots = 0;
		for (int frame = 0; frame < 30 * 90; frame++)
		{
			bm.Step(dt);
			if (frame % 30 == 0)
			{
				log.AppendLine($"t={frame * dt:0}s  {bm.player.def.name} hp={bm.player.hp:0} st={bm.player.state}  |  {bm.enemy.def.name} hp={bm.enemy.hp:0} st={bm.enemy.state}  placar {bm.player.kills}x{bm.enemy.kills}  pos {bm.player.Position:F1} {bm.enemy.Position:F1} dist {Vector3.Distance(bm.player.Position, bm.enemy.Position):F1} | buffs M[{string.Join(",", bm.player.buffs.ConvertAll(b => b.def.name + ":" + b.remaining.ToString("0.0")))}] B[{string.Join(",", bm.enemy.buffs.ConvertAll(b => b.def.name + ":" + b.remaining.ToString("0.0")))}] spd {bm.player.MoveSpeed:0.0}/{bm.enemy.MoveSpeed:0.0} pdef {bm.enemy.status.PhysicalDefense.Calc():0.00} ult {bm.player.UltPercent:P0}/{bm.enemy.UltPercent:P0} {bm.player.CurrentSkillName}/{bm.enemy.CurrentSkillName} cam {bm.cam.transform.position:F1} escB {bm.enemy.go.GetComponentInChildren<Animation>()?.transform.lossyScale:F2} escM {bm.player.go.GetComponentInChildren<Animation>()?.transform.lossyScale:F2}");
			}
			bool fxShot = Vfx.LiveCount >= 3 && frame - lastFx > 150 && fxShots < 6;
			if (fxShot)
			{
				lastFx = frame;
				fxShots++;
			}
			if (frame == 75 || frame == 300 || frame == 900 || frame == 1800 || fxShot)
			{
				Canvas.ForceUpdateCanvases();
				bm.cam.Render();
				RenderTexture.active = rt;
				tex.ReadPixels(new Rect(0, 0, 1280, 720), 0, 0);
				tex.Apply();
				File.WriteAllBytes($"{dir}/luta_{shot++}.png", tex.EncodeToPNG());
			}
		}
		// vista de cima do mapa inteiro
		bm.cam.transform.position = bm.arena.center + Vector3.up * 70f;
		bm.cam.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
		bm.cam.Render();
		RenderTexture.active = rt;
		tex.ReadPixels(new Rect(0, 0, 1280, 720), 0, 0);
		tex.Apply();
		File.WriteAllBytes($"{dir}/luta_mapa.png", tex.EncodeToPNG());
		RenderTexture.active = null;
		File.WriteAllText($"{dir}/luta_log.txt", log.ToString());
	}
}
