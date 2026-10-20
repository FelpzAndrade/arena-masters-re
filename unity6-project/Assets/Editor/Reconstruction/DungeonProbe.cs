using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

// Mede tamanho/pivo dos modelos KayKit Dungeon para montar o cenario na grade certa.
public static class DungeonProbe
{
	public static void Run()
	{
		StringBuilder sb = new StringBuilder();
		foreach (string file in Directory.GetFiles("Assets/Prototype/KayKitDungeon", "*.fbx").OrderBy(p => p))
		{
			string path = file.Replace(Path.DirectorySeparatorChar, '/');
			GameObject m = AssetDatabase.LoadAssetAtPath<GameObject>(path);
			Renderer[] rs = m.GetComponentsInChildren<Renderer>();
			Bounds b = rs.Length > 0 ? rs[0].bounds : new Bounds();
			foreach (Renderer r in rs)
			{
				b.Encapsulate(r.bounds);
			}
			Material mat = rs.Length > 0 ? rs[0].sharedMaterial : null;
			string tex = mat != null && mat.mainTexture != null ? mat.mainTexture.name : "none";
			sb.AppendLine($"{Path.GetFileNameWithoutExtension(path),-28} size={b.size:F2} center={b.center:F2} tex={tex}");
		}
		File.WriteAllText("C:/Users/felip/arena-masters-re/captures/dungeon_probe.txt", sb.ToString());
	}
}
