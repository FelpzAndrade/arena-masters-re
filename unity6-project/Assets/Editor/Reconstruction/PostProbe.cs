using System.IO;
using UnityEditor;

public static class PostProbe
{
	public static void Run()
	{
		string[] ids = AssetDatabase.FindAssets("t:PostProcessResources");
		File.WriteAllText("C:/Users/felip/arena-masters-re/captures/post_probe.txt", ids.Length > 0 ? AssetDatabase.GUIDToAssetPath(ids[0]) : "nenhum");
	}
}
