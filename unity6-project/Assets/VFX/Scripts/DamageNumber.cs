using System.Collections.Generic;
using UnityEngine;

// Numero de dano (e textos curtos) que saltam sobre o personagem. Reutilizavel: a luta (BattleManager) e a cena VFX_Test.
// Uso: DamageNumber.Show(posicao, "5200", cor, DamageNumber.Estilo.Golpe) e, uma vez por quadro, DamageNumber.Tick(camera).
//   Estilo.Golpe   (combate_spec.md, elemento 4): negrito com contorno escuro, pulo de escala e sobe; some em 0,6 s
//   Estilo.Critico igual, 1,5x maior e amarelo-laranja
//   Estilo.Simples o texto antigo da luta (sobe 0,9 s, sem pulo nem contorno)
// Anda em tempo real: aparece normal durante o hit stop.
public static class DamageNumber
{
	public enum Estilo { Simples, Golpe, Critico }

	public static Font font;   // sem fonte, usa a padrao do Unity

	private class Item
	{
		public TextMesh text;
		public TextMesh[] outline;
		public Estilo estilo;
		public float age, life, scale;
		public Color color;
	}

	private static readonly List<Item> s_items = new List<Item>();
	private static readonly Vector2[] OutlineDirs = { new Vector2(1, 0), new Vector2(-1, 0), new Vector2(0, 1), new Vector2(0, -1) };

	public static void Show(Vector3 pos, string text, Color color, Estilo estilo)
	{
		if (font == null)
		{
			font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		}
		bool fancy = estilo != Estilo.Simples;
		Item it = new Item
		{
			estilo = estilo,
			life = fancy ? 0.6f : 0.9f,
			scale = estilo == Estilo.Critico ? 1.5f : 1f,
			color = estilo == Estilo.Critico ? new Color(1f, 0.78f, 0.15f) : color,
		};
		it.text = Make("dano", text, it.color, 0);
		it.text.transform.position = pos;
		if (fancy)
		{
			// contorno: 4 copias escuras um pouco deslocadas atras do texto (TextMesh nao tem contorno proprio)
			it.outline = new TextMesh[OutlineDirs.Length];
			for (int i = 0; i < OutlineDirs.Length; i++)
			{
				TextMesh o = Make("contorno", text, new Color(0.08f, 0.04f, 0.02f), -1);
				o.transform.SetParent(it.text.transform, false);
				o.transform.localPosition = new Vector3(OutlineDirs[i].x, OutlineDirs[i].y, 0.02f) * 0.045f;
				it.outline[i] = o;
			}
		}
		s_items.Add(it);
		Apply(it, Camera.main);
	}

	public static void Tick(Camera cam)
	{
		float dt = Application.isPlaying ? Time.unscaledDeltaTime : 1f / 30f;
		for (int i = s_items.Count - 1; i >= 0; i--)
		{
			Item it = s_items[i];
			it.age += dt;
			if (it.age >= it.life || it.text == null)
			{
				Destroy(it.text != null ? it.text.gameObject : null);
				s_items.RemoveAt(i);
				continue;
			}
			it.text.transform.position += Vector3.up * dt * (it.estilo == Estilo.Simples ? 1.5f : 1.2f);
			Apply(it, cam);
		}
	}

	public static void Clear()
	{
		foreach (Item it in s_items)
		{
			Destroy(it.text != null ? it.text.gameObject : null);
		}
		s_items.Clear();
	}

	private static void Apply(Item it, Camera cam)
	{
		if (cam != null)
		{
			it.text.transform.rotation = cam.transform.rotation;
		}
		float alpha;
		float s = it.scale;
		if (it.estilo == Estilo.Simples)
		{
			alpha = Mathf.Clamp01((it.life - it.age) / 0.4f);
		}
		else
		{
			// pulo: 0,6 -> 1,25 em 0,08 s, assenta em 1 ate 0,16 s; some nos ultimos 0,25 s
			float t = it.age;
			s *= t < 0.08f ? Mathf.Lerp(0.6f, 1.25f, t / 0.08f) : t < 0.16f ? Mathf.Lerp(1.25f, 1f, (t - 0.08f) / 0.08f) : 1f;
			alpha = Mathf.Clamp01((it.life - it.age) / 0.25f);
		}
		it.text.transform.localScale = Vector3.one * s;
		Color c = it.color;
		c.a = alpha;
		it.text.color = c;
		if (it.outline != null)
		{
			foreach (TextMesh o in it.outline)
			{
				Color oc = o.color;
				oc.a = alpha * 0.9f;
				o.color = oc;
			}
		}
	}

	private static TextMesh Make(string name, string text, Color color, int order)
	{
		TextMesh tm = new GameObject(name).AddComponent<TextMesh>();
		tm.font = font;
		MeshRenderer r = tm.GetComponent<MeshRenderer>();
		r.sharedMaterial = font.material;
		r.sortingOrder = order;
		tm.text = text;
		tm.color = color;
		tm.fontSize = 64;
		tm.characterSize = 0.06f;
		tm.anchor = TextAnchor.MiddleCenter;
		tm.fontStyle = FontStyle.Bold;
		return tm;
	}

	private static void Destroy(GameObject go)
	{
		if (go == null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			Object.Destroy(go);
		}
		else
		{
			Object.DestroyImmediate(go);
		}
	}
}
