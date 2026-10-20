using System.Collections.Generic;
using UnityEngine;

// Cenario de masmorra (KayKit Dungeon Remastered, CC0) gerado a partir do navmesh original da DuelArena:
// piso em ladrilhos nas areas andaveis, paredes onde acaba o mapa, barreiras na beira dos fossos,
// obstaculos onde o navmesh tem buracos na mesma altura, tochas com luz e props encostados nas paredes.
public static class DungeonDecor
{
	private const float Margin = 0.6f; // characterRadius do RecastGraph: o navmesh fica 0.6m para dentro do chao real

	// renderers do cenario com os limites pre-calculados, para esconder o que tapa a camera
	public static readonly List<(Renderer renderer, Bounds bounds)> Occluders = new List<(Renderer, Bounds)>();

	// maxTorches: luzes de tocha (em tempo real so cabem poucas; no bake o ArenaBake pede muitas, espalhadas a cada 6 m)
	public static GameObject Build(Arena arena, int seed, int maxTorches = 18)
	{
		Occluders.Clear();
		System.Random rng = new System.Random(seed);
		GameObject root = new GameObject(RootName);
		Dictionary<string, GameObject> cache = new Dictionary<string, GameObject>();
		GameObject Prefab(string name)
		{
			if (!cache.TryGetValue(name, out GameObject p))
			{
				p = Resources.Load<GameObject>("KayKitDungeon/" + name);
				cache[name] = p;
			}
			return p;
		}
		GameObject Place(string name, Vector3 pos, float yaw, Transform parent)
		{
			GameObject prefab = Prefab(name);
			if (prefab == null)
			{
				return null;
			}
			GameObject go = Object.Instantiate(prefab, pos, Quaternion.Euler(0f, yaw, 0f), parent);
			go.name = name;
			return go;
		}

		Transform floor = new GameObject("Piso").transform;
		floor.SetParent(root.transform, false);
		Transform walls = new GameObject("Paredes").transform;
		walls.SetParent(root.transform, false);
		Transform props = new GameObject("Props").transform;
		props.SetParent(root.transform, false);

		BuildFloor(arena, rng, Place, floor);
		BuildEdges(arena, rng, Place, walls, props, maxTorches);
		HideNavmesh(arena);
		foreach (Renderer r in root.GetComponentsInChildren<Renderer>())
		{
			Occluders.Add((r, r.bounds));
		}
		if (Application.isPlaying)
		{
			StaticBatchingUtility.Combine(floor.gameObject);
			StaticBatchingUtility.Combine(walls.gameObject);
		}
		return root;
	}

	public const string RootName = "Cenario (KayKit Dungeon)";
	public static bool Baked { get; private set; }

	// cenario ja salvo na cena com lightmap (menu Arena Masters/Mapa/Salvar arena e fazer bake): usa ele em vez de montar.
	// A sombra em tempo real fica so para os herois (a do cenario esta no lightmap), o que poupa ~1000 objetos no mapa de sombra.
	public static GameObject UseBaked(Arena arena)
	{
		Occluders.Clear();
		Baked = false;
		GameObject root = GameObject.Find(RootName);
		if (root == null)
		{
			return null;
		}
		Baked = true;
		HideNavmesh(arena);
		foreach (Renderer r in root.GetComponentsInChildren<Renderer>())
		{
			r.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
			Occluders.Add((r, r.bounds));
		}
		return root;
	}

	private static void HideNavmesh(Arena arena)
	{
		arena.floor.GetComponent<MeshRenderer>().enabled = false;
		foreach (LineRenderer line in arena.floor.GetComponentsInChildren<LineRenderer>())
		{
			line.enabled = false;
		}
	}

	// ladrilhos de 2m em cada altura de chao encontrada (o mapa tem varios niveis)
	private static void BuildFloor(Arena arena, System.Random rng, System.Func<string, Vector3, float, Transform, GameObject> place, Transform parent)
	{
		Bounds b = arena.floor.GetComponent<MeshFilter>().sharedMesh.bounds;
		string[] tiles = { "floor_tile_small", "floor_tile_small", "floor_tile_small", "floor_tile_small_broken_A", "floor_tile_small_weeds_A" };
		for (float x = Mathf.Floor(b.min.x / 2f) * 2f - 1f; x <= b.max.x + 2f; x += 2f)
		{
			for (float z = Mathf.Floor(b.min.z / 2f) * 2f - 1f; z <= b.max.z + 2f; z += 2f)
			{
				foreach (float y in arena.FloorHeights(x, z, Margin + 0.4f))
				{
					string tile = tiles[rng.Next(tiles.Length)];
					place(tile, new Vector3(x, y - 0.05f, z), 90f * rng.Next(4), parent);
				}
			}
		}
	}

	private static void BuildEdges(Arena arena, System.Random rng, System.Func<string, Vector3, float, Transform, GameObject> place, Transform walls, Transform props, int maxTorches)
	{
		HashSet<Vector2Int> used = new HashSet<Vector2Int>();
		bool Claim(Vector3 p, float cell)
		{
			Vector2Int key = new Vector2Int(Mathf.RoundToInt(p.x / cell), Mathf.RoundToInt(p.z / cell));
			return used.Add(key);
		}
		int wallCount = 0;
		int lights = 0;
		List<Vector3> torches = new List<Vector3>();
		bool FarFromTorches(Vector3 p)
		{
			foreach (Vector3 t in torches)
			{
				if ((t - p).sqrMagnitude < 6f * 6f)
				{
					return false;
				}
			}
			return true;
		}
		string[] obstacles = { "crates_stacked", "barrel_large", "box_stacked", "keg", "pillar", "rubble_half" };
		string[] wallVariants = { "wall", "wall", "wall", "wall_arched", "wall_broken", "wall_pillar" };
		foreach ((Vector3 a, Vector3 c, Vector3 outward) in arena.BoundaryEdges())
		{
			Vector3 dir = c - a;
			float length = dir.magnitude;
			if (length < 0.3f)
			{
				continue;
			}
			dir /= length;
			float yaw = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg - 90f;
			int pieces = Mathf.Max(1, Mathf.RoundToInt(length / 4f));
			for (int i = 0; i < pieces; i++)
			{
				Vector3 mid = Vector3.Lerp(a, c, (i + 0.5f) / pieces) + Vector3.down * Arena.CenterHeight;
				Vector3 probe = mid + outward * (Margin + 1.2f);
				float? other = arena.FloorBelow(probe, mid.y + 0.5f);
				if (other == null)
				{
					// fim do mapa: parede de masmorra encostada na borda real do chao
					Vector3 pos = mid + outward * (Margin + 0.5f);
					if (!Claim(pos, 1.6f))
					{
						continue;
					}
					GameObject wall = place(wallVariants[rng.Next(wallVariants.Length)], pos, yaw, walls);
					if (wall != null && Vector3.Dot(wall.transform.forward, outward) > 0f)
					{
						wall.transform.Rotate(0f, 180f, 0f);
					}
					wallCount++;
					if (lights < maxTorches && (maxTorches > 18 ? FarFromTorches(pos) : wallCount % 3 == 0))
					{
						Vector3 torchPos = pos - outward * 0.55f + Vector3.up * 2.4f;
						GameObject torch = place("torch_mounted", torchPos, 0f, props);
						if (torch != null)
						{
							torch.transform.rotation = Quaternion.LookRotation(-outward);
							Light l = new GameObject("luz_tocha").AddComponent<Light>();
							l.transform.SetParent(torch.transform, false);
							l.transform.localPosition = new Vector3(0f, 0.7f, 0.4f);
							l.type = LightType.Point;
							l.color = new Color(1f, 0.62f, 0.3f);
							l.range = 10f;
							l.intensity = 4f;   // URP: queda da luz fisica, precisa de mais intensidade
							lights++;
							torches.Add(pos);
						}
					}
					else if (wallCount % 7 == 0)
					{
						GameObject banner = place(rng.Next(2) == 0 ? "banner_patternA_red" : "banner_shield_red", pos - outward * 0.5f, 0f, props);
						if (banner != null)
						{
							banner.transform.rotation = Quaternion.LookRotation(-outward);
						}
					}
					else if (rng.NextDouble() < 0.18)
					{
						string[] small = { "barrel_small", "box_large", "chest", "candle_triple", "barrel_large" };
						place(small[rng.Next(small.Length)], pos - outward * 1.1f, (float)rng.NextDouble() * 360f, props);
					}
				}
				else if (mid.y - other.Value > 1.2f)
				{
					// beira de fosso/desnivel: grade baixa para nao parecer que da para andar
					Vector3 pos = mid + outward * (Margin + 0.25f);
					if (!Claim(pos, 1.4f))
					{
						continue;
					}
					GameObject barrier = place(rng.NextDouble() < 0.25 ? "barrier_column" : "barrier", pos, yaw, walls);
					if (barrier != null && Vector3.Dot(barrier.transform.forward, outward) > 0f)
					{
						barrier.transform.Rotate(0f, 180f, 0f);
					}
				}
				else
				{
					// buraco no navmesh na mesma altura = obstaculo do mapa original (caixa, pilar, estatua...)
					Vector3 pos = mid + outward * (Margin + 0.9f);
					if (!Claim(pos, 2.2f))
					{
						continue;
					}
					place(obstacles[rng.Next(obstacles.Length)], new Vector3(pos.x, other.Value, pos.z), (float)rng.NextDouble() * 360f, props);
				}
			}
		}
	}

	// esconde (deixando so a sombra) o que estiver acima do nivel dos lutadores perto deles
	// e as paredes altas entre a camera e o ponto focal
	public static void UpdateOcclusion(Vector3 focus, Vector3 cameraPos)
	{
		Vector2 f = new Vector2(focus.x, focus.z);
		Vector2 c = new Vector2(cameraPos.x, cameraPos.z);
		float floorY = focus.y - Arena.CenterHeight;
		foreach ((Renderer r, Bounds b) in Occluders)
		{
			if (r == null)
			{
				continue;
			}
			Vector2 center = new Vector2(b.center.x, b.center.z);
			bool above = b.min.y > floorY + 2.5f && (center - f).sqrMagnitude < 14f * 14f;
			bool between = false;
			if (!above && b.max.y > floorY + 2.2f)
			{
				Vector2 seg = c - f;
				float t = Mathf.Clamp01(Vector2.Dot(center - f, seg) / seg.sqrMagnitude);
				float dist = (f + seg * t - center).magnitude;
				between = t > 0.05f && dist < Mathf.Max(b.extents.x, b.extents.z) + 1.5f;
			}
			if (Baked)
			{
				// cenario com lightmap: a sombra dele ja esta assada, entao so some de vista
				if (r.forceRenderingOff != (above || between))
				{
					r.forceRenderingOff = above || between;
				}
				continue;
			}
			UnityEngine.Rendering.ShadowCastingMode mode = above || between
				? UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly
				: UnityEngine.Rendering.ShadowCastingMode.On;
			if (r.shadowCastingMode != mode)
			{
				r.shadowCastingMode = mode;
			}
		}
	}
}
