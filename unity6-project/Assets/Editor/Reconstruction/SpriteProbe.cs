using System.IO;
using System.Linq;
using UnityEngine;

public static class SpriteProbe
{
	public static void Run()
	{
		var atlas = Resources.Load<GameObject>("atlas/opening/bg_main").GetComponent<XSpriteAtlas>();
		var sb = new System.Text.StringBuilder();
		foreach (var s in atlas.list.Where(x => x != null).Take(4))
		{
			sb.AppendLine($"{s.name} rect={s.rect} texRect={s.textureRect} packed={s.packed} tex={s.texture.name} {s.texture.width}x{s.texture.height} uv0={string.Join(";", s.uv.Select(u => u.ToString("F3")))} verts={s.vertices.Length}");
		}
		File.WriteAllText("C:/Users/felip/arena-masters-re/captures/sprite_probe.txt", sb.ToString());
	}
}
