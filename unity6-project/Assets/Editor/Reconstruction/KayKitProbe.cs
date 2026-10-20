using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

public static class KayKitProbe
{
	public static void Run()
	{
		StringBuilder sb = new StringBuilder();
		foreach (string path in new[] { "Assets/Prototype/KayKit/Characters/Barbarian.fbx", "Assets/Prototype/KayKit/Characters/Mage.fbx" })
		{
			AnimationClip[] clips = AssetDatabase.LoadAllAssetsAtPath(path).OfType<AnimationClip>().Where(c => !c.name.StartsWith("__preview")).ToArray();
			GameObject model = AssetDatabase.LoadAssetAtPath<GameObject>(path);
			sb.AppendLine($"== {path}: {clips.Length} clips");
			sb.AppendLine(string.Join(", ", clips.Select(c => $"{c.name}({c.length:0.00}s)")));
			sb.AppendLine("ossos/slots: " + string.Join(", ", model.GetComponentsInChildren<Transform>().Select(t => t.name).Where(n => n.ToLower().Contains("hand") || n.ToLower().Contains("slot") || n.ToLower().Contains("head"))));
			sb.AppendLine("renderers: " + string.Join(", ", model.GetComponentsInChildren<Renderer>().Select(r => r.name)));
			Bounds b = new Bounds();
			foreach (Renderer r in model.GetComponentsInChildren<Renderer>()) b.Encapsulate(r.bounds);
			sb.AppendLine("bounds " + b);
		}
		File.WriteAllText("C:/Users/felip/arena-masters-re/captures/kaykit_probe.txt", sb.ToString());
	}
}
