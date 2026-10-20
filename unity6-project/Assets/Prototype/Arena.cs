using System;
using System.Collections.Generic;
using UnityEngine;

// Chao da arena montado a partir do navmesh original da DuelArena (A* Pathfinding RecastGraph, graph0_extra.binary).
public class Arena
{
	public const float CenterHeight = 1f; // capsula: pivot no meio, 2m de altura
	private const int FloorLayer = 0;
	public readonly GameObject floor;
	public readonly Vector3 center;
	public readonly List<Vector3> triangleCenters = new List<Vector3>();
	// obstaculos temporarios (pedras do Divisor de Terra): centro, raio e tempo restante
	public readonly List<(Vector3 center, float radius, float life)> blockers = new List<(Vector3, float, float)>();

	public bool IsBlocked(Vector3 from, Vector3 to)
	{
		foreach ((Vector3 center, float radius, float life) b in blockers)
		{
			Vector2 c = new Vector2(b.center.x, b.center.z);
			bool inside = (new Vector2(to.x, to.z) - c).sqrMagnitude < b.radius * b.radius;
			bool wasInside = (new Vector2(from.x, from.z) - c).sqrMagnitude < b.radius * b.radius;
			if (inside && !wasInside)
			{
				return true;
			}
		}
		return false;
	}

	public void UpdateBlockers(float dt)
	{
		for (int i = blockers.Count - 1; i >= 0; i--)
		{
			(Vector3 center, float radius, float life) b = blockers[i];
			b.life -= dt;
			if (b.life <= 0f)
			{
				blockers.RemoveAt(i);
				continue;
			}
			blockers[i] = b;
		}
	}
	private readonly MeshCollider m_collider;
	private Vector3[] m_verts;
	private int[] m_tris;
	private List<int>[] m_neighbors;

	[Serializable]
	private class NavmeshJson
	{
		public float[] verts;
		public int[] tris;
	}

	public Arena()
	{
		NavmeshJson data = JsonUtility.FromJson<NavmeshJson>(Resources.Load<TextAsset>("duel_arena_navmesh").text);
		Vector3[] verts = new Vector3[data.verts.Length / 3];
		for (int i = 0; i < verts.Length; i++)
		{
			verts[i] = new Vector3(data.verts[i * 3], data.verts[i * 3 + 1], data.verts[i * 3 + 2]);
		}
		int[] tris = data.tris;
		Mesh mesh = new Mesh { name = "DuelArenaNavmesh", vertices = verts, triangles = tris };
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();
		center = mesh.bounds.center;
		m_verts = verts;
		m_tris = tris;
		BuildAdjacency();
		for (int i = 0; i < tris.Length; i += 3)
		{
			triangleCenters.Add((verts[tris[i]] + verts[tris[i + 1]] + verts[tris[i + 2]]) / 3f);
		}

		floor = new GameObject("DuelArena (navmesh original)");
		floor.layer = FloorLayer;
		floor.AddComponent<MeshFilter>().sharedMesh = mesh;
		floor.AddComponent<MeshRenderer>().sharedMaterial = MakeMaterial(new Color(0.27f, 0.32f, 0.24f));
		m_collider = floor.AddComponent<MeshCollider>();
		m_collider.sharedMesh = mesh;

		// contorno das bordas para enxergar o formato do chao
		GameObject edges = new GameObject("Bordas");
		edges.transform.SetParent(floor.transform, false);
		List<Vector3> pts = new List<Vector3>();
		foreach (KeyValuePair<(int, int), int> e in BoundaryEdges(tris))
		{
			pts.Add(verts[e.Key.Item1] + Vector3.up * 0.03f);
			pts.Add(verts[e.Key.Item2] + Vector3.up * 0.03f);
		}
		BuildEdgeLines(edges.transform, pts);
	}

	private static Dictionary<(int, int), int> BoundaryEdges(int[] tris)
	{
		Dictionary<(int, int), int> count = new Dictionary<(int, int), int>();
		for (int i = 0; i < tris.Length; i += 3)
		{
			for (int k = 0; k < 3; k++)
			{
				int a = tris[i + k], b = tris[i + (k + 1) % 3];
				(int, int) key = a < b ? (a, b) : (b, a);
				count[key] = count.TryGetValue(key, out int c) ? c + 1 : 1;
			}
		}
		Dictionary<(int, int), int> result = new Dictionary<(int, int), int>();
		foreach (KeyValuePair<(int, int), int> kv in count)
		{
			if (kv.Value == 1)
			{
				result.Add(kv.Key, 1);
			}
		}
		return result;
	}

	private static void BuildEdgeLines(Transform parent, List<Vector3> pts)
	{
		Material mat = MakeMaterial(new Color(0.95f, 0.85f, 0.5f));
		for (int i = 0; i < pts.Count; i += 2)
		{
			LineRenderer seg = new GameObject("borda").AddComponent<LineRenderer>();
			seg.transform.SetParent(parent, false);
			seg.widthMultiplier = 0.1f;
			seg.material = mat;
			seg.positionCount = 2;
			seg.SetPosition(0, pts[i]);
			seg.SetPosition(1, pts[i + 1]);
		}
	}

	private void BuildAdjacency()
	{
		int n = m_tris.Length / 3;
		m_neighbors = new List<int>[n];
		Dictionary<(int, int), int> owner = new Dictionary<(int, int), int>();
		for (int t = 0; t < n; t++)
		{
			m_neighbors[t] = new List<int>();
		}
		for (int t = 0; t < n; t++)
		{
			for (int k = 0; k < 3; k++)
			{
				int a = m_tris[t * 3 + k], b = m_tris[t * 3 + (k + 1) % 3];
				(int, int) key = a < b ? (a, b) : (b, a);
				if (owner.TryGetValue(key, out int other))
				{
					m_neighbors[t].Add(other);
					m_neighbors[other].Add(t);
				}
				else
				{
					owner[key] = t;
				}
			}
		}
	}

	// Triangulo do navmesh que contem o ponto (no plano XZ), preferindo o de altura mais proxima.
	public int FindTriangle(Vector3 p)
	{
		int best = -1;
		float bestDy = float.MaxValue;
		for (int t = 0; t < m_tris.Length / 3; t++)
		{
			Vector3 a = m_verts[m_tris[t * 3]], b = m_verts[m_tris[t * 3 + 1]], c = m_verts[m_tris[t * 3 + 2]];
			if (!InTriangleXZ(p, a, b, c))
			{
				continue;
			}
			float dy = Mathf.Abs((a.y + b.y + c.y) / 3f + CenterHeight - p.y);
			if (dy < bestDy)
			{
				bestDy = dy;
				best = t;
			}
		}
		if (best < 0)
		{
			float bestD = float.MaxValue;
			for (int t = 0; t < triangleCenters.Count; t++)
			{
				float d = (triangleCenters[t] - p).sqrMagnitude;
				if (d < bestD)
				{
					bestD = d;
					best = t;
				}
			}
		}
		return best;
	}

	private static bool InTriangleXZ(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
	{
		float d1 = (p.x - b.x) * (a.z - b.z) - (a.x - b.x) * (p.z - b.z);
		float d2 = (p.x - c.x) * (b.z - c.z) - (b.x - c.x) * (p.z - c.z);
		float d3 = (p.x - a.x) * (c.z - a.z) - (c.x - a.x) * (p.z - a.z);
		bool neg = d1 < 0f || d2 < 0f || d3 < 0f;
		bool pos = d1 > 0f || d2 > 0f || d3 > 0f;
		return !(neg && pos);
	}

	// A* sobre a adjacencia dos triangulos do navmesh original; devolve pontos de passagem ate o destino.
	public List<Vector3> FindPath(Vector3 from, Vector3 to)
	{
		List<Vector3> path = new List<Vector3>();
		int start = FindTriangle(from), goal = FindTriangle(to);
		if (start < 0 || goal < 0)
		{
			return path;
		}
		Dictionary<int, int> came = new Dictionary<int, int>();
		Dictionary<int, float> g = new Dictionary<int, float> { [start] = 0f };
		SortedSet<(float, int)> open = new SortedSet<(float, int)> { (0f, start) };
		while (open.Count > 0)
		{
			(float _, int cur) = open.Min;
			open.Remove(open.Min);
			if (cur == goal)
			{
				break;
			}
			foreach (int nb in m_neighbors[cur])
			{
				float cost = g[cur] + Vector3.Distance(triangleCenters[cur], triangleCenters[nb]);
				if (!g.TryGetValue(nb, out float old) || cost < old)
				{
					if (g.ContainsKey(nb))
					{
						open.Remove((old + Vector3.Distance(triangleCenters[nb], triangleCenters[goal]), nb));
					}
					g[nb] = cost;
					came[nb] = cur;
					open.Add((cost + Vector3.Distance(triangleCenters[nb], triangleCenters[goal]), nb));
				}
			}
		}
		if (!came.ContainsKey(goal) && start != goal)
		{
			return path;
		}
		for (int t = goal; t != start; t = came[t])
		{
			path.Add(triangleCenters[t] + Vector3.up * CenterHeight);
		}
		path.Reverse();
		path.Add(to);
		return path;
	}

	// Alturas de chao do navmesh em (x,z), uma por nivel; aceita pontos ate 'margin' fora do navmesh
	// (o navmesh fica characterRadius para dentro do chao real).
	public List<float> FloorHeights(float x, float z, float margin)
	{
		List<float> heights = new List<float>();
		Vector2 p = new Vector2(x, z);
		for (int t = 0; t < m_tris.Length / 3; t++)
		{
			Vector3 a = m_verts[m_tris[t * 3]], b = m_verts[m_tris[t * 3 + 1]], c = m_verts[m_tris[t * 3 + 2]];
			Vector3 closest = ClosestOnTriangleXZ(p, a, b, c);
			if ((new Vector2(closest.x, closest.z) - p).sqrMagnitude > margin * margin)
			{
				continue;
			}
			if (!heights.Exists(h => Mathf.Abs(h - closest.y) < 1f))
			{
				heights.Add(closest.y);
			}
		}
		return heights;
	}

	// ponto do triangulo mais proximo de p no plano XZ, com a altura interpolada
	private static Vector3 ClosestOnTriangleXZ(Vector2 p, Vector3 a, Vector3 b, Vector3 c)
	{
		Vector3 p3 = new Vector3(p.x, 0f, p.y);
		if (InTriangleXZ(p3, a, b, c))
		{
			Vector3 n = Vector3.Cross(b - a, c - a);
			float y = Mathf.Abs(n.y) < 1e-5f ? a.y : a.y - (n.x * (p.x - a.x) + n.z * (p.y - a.z)) / n.y;
			return new Vector3(p.x, y, p.y);
		}
		Vector3 best = a;
		float bestD = float.MaxValue;
		foreach ((Vector3 u, Vector3 v) in new[] { (a, b), (b, c), (c, a) })
		{
			Vector2 uv = new Vector2(v.x - u.x, v.z - u.z);
			float t = Mathf.Clamp01(Vector2.Dot(p - new Vector2(u.x, u.z), uv) / Mathf.Max(1e-6f, uv.sqrMagnitude));
			Vector3 q = Vector3.Lerp(u, v, t);
			float d = (new Vector2(q.x, q.z) - p).sqrMagnitude;
			if (d < bestD)
			{
				bestD = d;
				best = q;
			}
		}
		return best;
	}

	// bordas do navmesh (arestas de um unico triangulo) com a direcao "para fora" no plano XZ
	public IEnumerable<(Vector3 a, Vector3 b, Vector3 outward)> BoundaryEdges()
	{
		Dictionary<(int, int), int> owner = new Dictionary<(int, int), int>();
		Dictionary<(int, int), int> count = new Dictionary<(int, int), int>();
		for (int t = 0; t < m_tris.Length / 3; t++)
		{
			for (int k = 0; k < 3; k++)
			{
				int a = m_tris[t * 3 + k], b = m_tris[t * 3 + (k + 1) % 3];
				(int, int) key = a < b ? (a, b) : (b, a);
				count[key] = count.TryGetValue(key, out int n) ? n + 1 : 1;
				owner[key] = t;
			}
		}
		foreach (KeyValuePair<(int, int), int> kv in count)
		{
			if (kv.Value != 1)
			{
				continue;
			}
			Vector3 a = m_verts[kv.Key.Item1], b = m_verts[kv.Key.Item2];
			Vector3 mid = (a + b) * 0.5f;
			Vector3 toCenter = triangleCenters[owner[kv.Key]] - mid;
			Vector3 normal = Vector3.Cross(Vector3.up, b - a).normalized;
			if (Vector3.Dot(normal, toCenter) > 0f)
			{
				normal = -normal;
			}
			yield return (a + Vector3.up * CenterHeight, b + Vector3.up * CenterHeight, normal);
		}
	}

	// altura do chao do navmesh abaixo de 'fromY' em p (null se nao houver chao)
	public float? FloorBelow(Vector3 p, float fromY)
	{
		if (m_collider.Raycast(new Ray(new Vector3(p.x, fromY, p.z), Vector3.down), out RaycastHit hit, 60f))
		{
			return hit.point.y;
		}
		return null;
	}

	// Ponto do chao mais proximo abaixo de pos, ja com a altura do centro do personagem.
	public Vector3 Snap(Vector3 pos)
	{
		if (m_collider.Raycast(new Ray(pos + Vector3.up * 4f, Vector3.down), out RaycastHit hit, 30f))
		{
			return hit.point + Vector3.up * CenterHeight;
		}
		return pos;
	}

	// Movimento so e aceito se houver chao no destino com degrau pequeno (fica preso nas bordas do navmesh).
	public bool TryGetFloor(Vector3 target, float currentCenterY, out Vector3 snapped)
	{
		snapped = target;
		if (!m_collider.Raycast(new Ray(new Vector3(target.x, currentCenterY + 2f, target.z), Vector3.down), out RaycastHit hit, 6f))
		{
			return false;
		}
		if (Mathf.Abs(hit.point.y + CenterHeight - currentCenterY) > 1.3f)
		{
			return false;
		}
		snapped = hit.point + Vector3.up * CenterHeight;
		return true;
	}

	// regiao conectada de cada triangulo (ilhas do navmesh tem ids diferentes)
	private int[] m_component;

	public int RegionOf(Vector3 p)
	{
		if (m_component == null)
		{
			MainRegion();
		}
		int t = FindTriangle(p);
		return t >= 0 ? m_component[t] : -1;
	}

	// Maior regiao conectada do navmesh (o piso principal); evita nascer em fossos/plataformas isoladas.
	private HashSet<int> m_mainRegion;

	private HashSet<int> MainRegion()
	{
		if (m_mainRegion != null)
		{
			return m_mainRegion;
		}
		int n = m_tris.Length / 3;
		int[] comp = new int[n];
		for (int i = 0; i < n; i++)
		{
			comp[i] = -1;
		}
		int bestComp = -1, bestSize = 0;
		for (int i = 0, id = 0; i < n; i++)
		{
			if (comp[i] >= 0)
			{
				continue;
			}
			int size = 0;
			Stack<int> stack = new Stack<int>();
			stack.Push(i);
			comp[i] = id;
			while (stack.Count > 0)
			{
				int t = stack.Pop();
				size++;
				foreach (int nb in m_neighbors[t])
				{
					if (comp[nb] < 0)
					{
						comp[nb] = id;
						stack.Push(nb);
					}
				}
			}
			if (size > bestSize)
			{
				bestSize = size;
				bestComp = id;
			}
			id++;
		}
		m_component = comp;
		m_mainRegion = new HashSet<int>();
		for (int i = 0; i < n; i++)
		{
			if (comp[i] == bestComp)
			{
				m_mainRegion.Add(i);
			}
		}
		return m_mainRegion;
	}

	// Pontos de nascimento: triangulos da regiao principal mais proximos de pontos opostos em volta do centro.
	public Vector3 SpawnPoint(Vector3 offset)
	{
		Vector3 want = center + offset;
		Vector3 best = center;
		float bestD = float.MaxValue;
		HashSet<int> main = MainRegion();
		for (int t = 0; t < triangleCenters.Count; t++)
		{
			if (!main.Contains(t))
			{
				continue;
			}
			Vector3 c = triangleCenters[t];
			float d = (new Vector2(c.x, c.z) - new Vector2(want.x, want.z)).sqrMagnitude;
			if (d < bestD)
			{
				bestD = d;
				best = c;
			}
		}
		return Snap(best);
	}

	public static Material MakeMaterial(Color color) => Vfx.MaterialLit(color);
}
