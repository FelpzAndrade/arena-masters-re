using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Etapa 2 do mapa (chamada pelo ArenaBake antes do bake): quebra a repeticao do kit e puxa as cores para a referencia.
//   cor: textura-paleta do KayKit com a pedra em marrom/ocre (tools/gen_map_textures.py -> Assets/Map/Textures)
//   chao: 3 tons sorteados por ladrilho; paredes e pilares escuros; tudo escurece em aneis longe do centro da luta
//         (13 e 21 m), para o olho ir para o meio. Sao poucos materiais (~15): o static batching continua juntando.
//   paredes: altura sorteada (92 a 110%) para a linha do topo nao ficar reta
//   decalques do URP no chao: selo grande no centro, rachaduras e manchas sorteadas nas areas andaveis
public static class ArenaVisual
{
	private const string MapDir = "Assets/Map";
	private static readonly float[] Rings = { 13f, 21f };          // distancia do centro da luta (m)
	private static readonly float[] RingDark = { 1f, 0.86f, 0.68f };
	private static readonly Color[] FloorTones =
	{
		new Color(1f, 1f, 1f),
		new Color(0.88f, 0.8f, 0.72f),   // mais terra
		new Color(1.06f, 1f, 0.86f),     // mais areia
	};
	private static readonly Color WallTone = new Color(0.52f, 0.44f, 0.4f);
	private const uint FloorLayer = 1u << 1;   // camada de renderizacao "chao" (alvo dos decalques)

	public static void Vary(GameObject root, Vector3 center)
	{
		Texture2D warm = AssetDatabase.LoadAssetAtPath<Texture2D>(MapDir + "/Textures/T_MasmorraQuente.png");
		Material shared = AssetDatabase.LoadAssetAtPath<Material>(MapDir + "/M_Masmorra.mat");
		if (warm == null || shared == null)
		{
			Debug.LogError("[Mapa] falta T_MasmorraQuente (rode tools/gen_map_textures.py) ou M_Masmorra");
			return;
		}
		shared.SetTexture("_BaseMap", warm);
		shared.mainTexture = warm;
		EditorUtility.SetDirty(shared);

		Dictionary<string, Material> cache = new Dictionary<string, Material>();
		Material Variant(string kind, int tone, int ring)
		{
			string key = kind + tone + ring;
			if (cache.TryGetValue(key, out Material m))
			{
				return m;
			}
			Color c = (kind == "Chao" ? FloorTones[tone] : kind == "Parede" ? WallTone : Color.white) * RingDark[ring];
			c.a = 1f;
			string path = $"{MapDir}/Variantes/M_{kind}_{tone}_{ring}.mat";
			m = AssetDatabase.LoadAssetAtPath<Material>(path);
			if (m == null)
			{
				Directory.CreateDirectory(MapDir + "/Variantes");
				m = new Material(shared);
				AssetDatabase.CreateAsset(m, path);
			}
			m.CopyPropertiesFromMaterial(shared);
			m.SetColor("_BaseColor", c);
			EditorUtility.SetDirty(m);
			cache[key] = m;
			return m;
		}

		System.Random rng = new System.Random(17);
		Transform floor = root.transform.Find("Piso"), walls = root.transform.Find("Paredes"), props = root.transform.Find("Props");
		foreach (Renderer r in root.GetComponentsInChildren<Renderer>(true))
		{
			Vector3 p = r.bounds.center;
			float d = new Vector2(p.x - center.x, p.z - center.z).magnitude;
			int ring = d < Rings[0] ? 0 : d < Rings[1] ? 1 : 2;
			string kind = r.transform.IsChildOf(floor) ? "Chao" : r.transform.IsChildOf(walls) ? "Parede" : "Prop";
			int tone = kind == "Chao" ? rng.Next(FloorTones.Length) : 0;
			Material m = Variant(kind, tone, ring);
			if (kind == "Chao")
			{
				r.renderingLayerMask = 1u | FloorLayer;   // decalques so pintam o chao (nao sobem na parede)
			}
			Material[] mats = r.sharedMaterials;
			for (int i = 0; i < mats.Length; i++)
			{
				if (mats[i] == shared)
				{
					mats[i] = m;
				}
			}
			r.sharedMaterials = mats;
		}
		foreach (Transform w in walls)
		{
			Vector3 s = w.localScale;
			w.localScale = new Vector3(s.x, s.y * (0.92f + (float)rng.NextDouble() * 0.18f), s.z);
		}
		AssetDatabase.SaveAssets();
		Debug.Log($"[Mapa] variacao: {cache.Count} materiais");
	}

	public static void Decals(Arena arena, Vector3 center, string rootName)
	{
		EnableDecalFeature();
		Shader sh = Shader.Find("Shader Graphs/Decal");
		Material seal = DecalMat("M_DecalSelo", sh, "T_DecalSelo", 0);
		Material crack = DecalMat("M_DecalRachadura", sh, "T_DecalRachadura", 2);
		Material stain = DecalMat("M_DecalMancha", sh, "T_DecalMancha", 1);
		GameObject root = new GameObject(rootName);

		Place(root.transform, "Selo", seal, OpenSpot(arena, center, 4.6f), 9f, 0f);
		Bounds b = arena.floor.GetComponent<MeshFilter>().sharedMesh.bounds;
		System.Random rng = new System.Random(23);
		int cracks = 0, stains = 0, tries = 0;
		while ((cracks < 34 || stains < 30) && tries++ < 4000)
		{
			float x = Mathf.Lerp(b.min.x, b.max.x, (float)rng.NextDouble());
			float z = Mathf.Lerp(b.min.z, b.max.z, (float)rng.NextDouble());
			List<float> floors = arena.FloorHeights(x, z, 0.6f);
			if (floors.Count == 0)
			{
				continue;
			}
			Vector3 p = new Vector3(x, floors[rng.Next(floors.Count)], z);
			if (new Vector2(p.x - center.x, p.z - center.z).magnitude < 5.5f)
			{
				continue;   // deixa o selo limpo
			}
			float yaw = (float)rng.NextDouble() * 360f;
			if (cracks < 34 && rng.NextDouble() < 0.55)
			{
				Place(root.transform, "Rachadura", crack, p, 2.2f + (float)rng.NextDouble() * 2.4f, yaw);
				cracks++;
			}
			else if (stains < 30)
			{
				Place(root.transform, "Mancha", stain, p, 1.8f + (float)rng.NextDouble() * 2.8f, yaw);
				stains++;
			}
		}
		Debug.Log($"[Mapa] decalques: selo + {cracks} rachaduras + {stains} manchas");
	}

	// ponto mais perto do centro da luta com chao livre num raio 'radius' (mesmo andar, sem parede): o selo nao sobe em bloco
	private static Vector3 OpenSpot(Arena arena, Vector3 center, float radius)
	{
		for (float r = 0f; r < 14f; r += 1f)
		{
			for (int k = 0; k < (r == 0f ? 1 : 12); k++)
			{
				float a = k * Mathf.PI / 6f;
				Vector3 c = center + new Vector3(Mathf.Cos(a), 0f, Mathf.Sin(a)) * r;
				bool ok = true;
				for (int j = 0; j < 16 && ok; j++)
				{
					float b = j * Mathf.PI / 8f;
					foreach (float rr in new[] { radius * 0.5f, radius })
					{
						Vector3 q = c + new Vector3(Mathf.Cos(b), 0f, Mathf.Sin(b)) * rr;
						if (!arena.FloorHeights(q.x, q.z, 0.6f).Exists(y => Mathf.Abs(y - center.y) < 0.3f))
						{
							ok = false;
							break;
						}
					}
				}
				if (ok)
				{
					return c;
				}
			}
		}
		return center;
	}

	private static Material DecalMat(string name, Shader sh, string tex, int order)
	{
		string path = $"{MapDir}/{name}.mat";
		Material m = AssetDatabase.LoadAssetAtPath<Material>(path);
		if (m == null)
		{
			m = new Material(sh);
			AssetDatabase.CreateAsset(m, path);
		}
		m.shader = sh;
		m.SetTexture("Base_Map", AssetDatabase.LoadAssetAtPath<Texture2D>($"{MapDir}/Textures/{tex}.png"));
		m.SetFloat("_DrawOrder", order);
		m.enableInstancing = true;
		EditorUtility.SetDirty(m);
		return m;
	}

	private static void Place(Transform parent, string name, Material mat, Vector3 groundPos, float size, float yaw)
	{
		DecalProjector d = new GameObject(name).AddComponent<DecalProjector>();
		d.transform.SetParent(parent, false);
		d.transform.position = groundPos + Vector3.up * 0.5f;
		d.transform.rotation = Quaternion.Euler(90f, yaw, 0f);   // projeta para baixo
		d.material = mat;
		d.size = new Vector3(size, size, 1.2f);
		d.pivot = Vector3.zero;
		d.drawDistance = 40f;
		d.renderingLayerMask = FloorLayer;
		d.fadeFactor = 1f;
	}

	// decalques precisam do recurso no renderer do URP (no celular ele escolhe a versao em tela, a mais barata)
	private static void EnableDecalFeature()
	{
		// camada de renderizacao 1 = "Chao": sem o nome definido no projeto, o URP ignora o bit e o decalque some
		SerializedObject tags = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
		SerializedProperty layers = tags.FindProperty("m_RenderingLayers");
		if (layers.arraySize < 2)
		{
			layers.arraySize = 2;
		}
		layers.GetArrayElementAtIndex(1).stringValue = "Chao";
		tags.ApplyModifiedPropertiesWithoutUndo();
		var rp = UnityEngine.Rendering.GraphicsSettings.defaultRenderPipeline as UniversalRenderPipelineAsset;
		var list = (ScriptableRendererData[])typeof(UniversalRenderPipelineAsset)
			.GetField("m_RendererDataList", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(rp);
		foreach (ScriptableRendererData data in list)
		{
			if (data == null)
			{
				continue;
			}
			DecalRendererFeature feature = data.rendererFeatures.Find(f => f is DecalRendererFeature) as DecalRendererFeature;
			if (feature == null)
			{
				feature = ScriptableObject.CreateInstance<DecalRendererFeature>();
				feature.name = "Decalques";
				AssetDatabase.AddObjectToAsset(feature, data);
				data.rendererFeatures.Add(feature);
			}
			SerializedObject so = new SerializedObject(feature);
			so.FindProperty("m_Settings.decalLayers").boolValue = true;   // decalque so na camada do chao
			so.ApplyModifiedPropertiesWithoutUndo();
			data.SetDirty();
			EditorUtility.SetDirty(data);
		}
		AssetDatabase.SaveAssets();
	}
}
