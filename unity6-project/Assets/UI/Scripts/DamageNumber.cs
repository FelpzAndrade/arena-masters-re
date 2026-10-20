using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Numero de dano (e textos curtos) que saltam sobre o personagem. Reutilizavel: a luta (BattleManager) e a cena VFX_Test.
// Uso: DamageNumber.Show(posicao, "5200", cor, DamageNumber.Estilo.Golpe) e, uma vez por quadro, DamageNumber.Tick(camera).
//   Estilo.Golpe   (combate_spec.md, elemento 4): TextMeshPro com fonte extra-negrito do jogo (Resources/FonteDano SDF)
//                  e contorno escuro de verdade (shader); pulo de escala, sobe e some em 0,6 s
//   Estilo.Critico igual, 1,6x maior e laranja
//   Estilo.Simples o texto antigo da luta (TextMesh, sobe 0,9 s, sem pulo nem contorno)
// Anda em tempo real: aparece normal durante o hit stop.
public static class DamageNumber
{
	public enum Estilo { Simples, Golpe, Critico }

	public static Font font;   // fonte do estilo Simples; sem ela, usa a padrao do Unity

	private class Item
	{
		public Transform t;
		public TextMesh mesh;      // Simples
		public TextMeshPro tmp;    // Golpe / Critico
		public Estilo estilo;
		public float age, life, scale;
		public Color color;
		public Vector3 origem;     // onde o numero foi pedido (antes do empilhamento)
	}

	private static readonly List<Item> s_items = new List<Item>();

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]   // inicio de cada Play (vale com o recarregamento de codigo desligado)
	private static void Zerar() => s_items.Clear();   // os textos eram da cena anterior (as fontes ficam em cache)
	private static TMP_FontAsset s_tmpFont;
	private static Material s_tmpMat;

	public static void Show(Vector3 pos, string text, Color color, Estilo estilo)
	{
		Item it = new Item
		{
			estilo = estilo,
			life = estilo == Estilo.Simples ? 0.9f : 0.6f,
			scale = estilo == Estilo.Critico ? 1.6f : 1f,
			color = estilo == Estilo.Critico ? new Color(1f, 0.42f, 0.1f) : color,   // critico: laranja (o normal vem de quem chama)
		};
		if (estilo == Estilo.Simples || !LoadTmp())
		{
			it.mesh = MakeMesh(text, it.color);
			it.t = it.mesh.transform;
		}
		else
		{
			it.tmp = new GameObject("dano").AddComponent<TextMeshPro>();
			it.tmp.font = s_tmpFont;
			it.tmp.fontSharedMaterial = s_tmpMat;
			it.tmp.text = text;
			it.tmp.fontSize = 5f;
			it.tmp.fontStyle = FontStyles.Bold;
			it.tmp.alignment = TextAlignmentOptions.Center;
			it.tmp.textWrappingMode = TextWrappingModes.NoWrap;
			it.tmp.color = it.color;
			it.t = it.tmp.transform;
		}
		if (estilo != Estilo.Simples)
		{
			// varios ao mesmo tempo no mesmo alvo: cada novo nasce acima do anterior e alternando de lado (nao sobrepoe)
			int vizinhos = 0;
			float topo = float.MinValue;
			foreach (Item o in s_items)
			{
				if (o.estilo != Estilo.Simples && o.t != null && o.age < 0.45f)
				{
					Vector3 d = o.origem - pos;
					d.y = 0f;
					if (d.magnitude < 1.2f)
					{
						vizinhos++;
						topo = Mathf.Max(topo, o.t.position.y);   // onde o vizinho esta agora (ele ja subiu)
					}
				}
			}
			it.origem = pos;
			if (vizinhos > 0)
			{
				pos.y = Mathf.Max(pos.y, topo + 0.45f);
				pos += Vector3.right * (vizinhos % 2 == 1 ? 0.3f : -0.3f);
			}
		}
		it.t.position = pos;
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
			if (it.age >= it.life || it.t == null)
			{
				Destroy(it.t != null ? it.t.gameObject : null);
				s_items.RemoveAt(i);
				continue;
			}
			it.t.position += Vector3.up * dt * (it.estilo == Estilo.Simples ? 1.5f : 1.2f);
			Apply(it, cam);
		}
	}

	public static void Clear()
	{
		foreach (Item it in s_items)
		{
			Destroy(it.t != null ? it.t.gameObject : null);
		}
		s_items.Clear();
	}

	private static void Apply(Item it, Camera cam)
	{
		if (cam != null)
		{
			it.t.rotation = cam.transform.rotation;
		}
		float alpha;
		float s = it.scale;
		if (it.estilo == Estilo.Simples)
		{
			alpha = Mathf.Clamp01((it.life - it.age) / 0.4f);
		}
		else
		{
			// pulo: 0,6 -> 1,3 em 0,08 s, assenta em 1 ate 0,16 s; some nos ultimos 0,25 s
			float t = it.age;
			s *= t < 0.08f ? Mathf.Lerp(0.6f, 1.3f, t / 0.08f) : t < 0.16f ? Mathf.Lerp(1.3f, 1f, (t - 0.08f) / 0.08f) : 1f;
			alpha = Mathf.Clamp01((it.life - it.age) / 0.25f);
		}
		it.t.localScale = Vector3.one * s;
		Color c = it.color;
		c.a = alpha;
		if (it.mesh != null)
		{
			it.mesh.color = c;
		}
		else
		{
			it.tmp.color = c;   // a cor de vertice tambem apaga o contorno junto
		}
	}

	// fonte e material com contorno preto grosso (uma vez so; todos os numeros dividem o mesmo material)
	private static bool LoadTmp()
	{
		if (s_tmpMat != null)
		{
			return true;
		}
		s_tmpFont = Resources.Load<TMP_FontAsset>("FonteDano SDF");
		if (s_tmpFont == null)
		{
			return false;
		}
		s_tmpMat = new Material(s_tmpFont.material) { name = "FonteDano Contorno" };
		s_tmpMat.EnableKeyword("OUTLINE_ON");
		s_tmpMat.SetFloat("_OutlineWidth", 0.3f);
		s_tmpMat.SetColor("_OutlineColor", Color.black);
		s_tmpMat.SetFloat("_FaceDilate", 0.15f);
		return true;
	}

	private static TextMesh MakeMesh(string text, Color color)
	{
		if (font == null)
		{
			font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		}
		TextMesh tm = new GameObject("dano").AddComponent<TextMesh>();
		tm.font = font;
		tm.GetComponent<MeshRenderer>().sharedMaterial = font.material;
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
