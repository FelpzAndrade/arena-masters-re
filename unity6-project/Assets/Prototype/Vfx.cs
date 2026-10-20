using System.Collections.Generic;
using UnityEngine;

// Efeitos de skill com o ParticleSystem do Unity e texturas do Kenney Particle Pack (CC0, Resources/VFX).
public static class Vfx
{
	private struct Live
	{
		public ParticleSystem ps;
		public LineRenderer line;
		public GameObject prefab;
		public ParticleSystem[] systems;
		public float life;
		public float total;
	}

	private static readonly List<Live> s_live = new List<Live>();
	private static readonly Dictionary<string, Material> s_materials = new Dictionary<string, Material>();

	private static readonly Dictionary<string, GameObject> s_prefabs = new Dictionary<string, GameObject>();

	public static int LiveCount => s_live.Count;

	// prefabs do Cartoon FX Remaster (atribuidos pelo PrototypeSetup); sem eles fica so o efeito proprio
	public static void Register(GameObject[] prefabs)
	{
		s_prefabs.Clear();
		if (prefabs == null)
		{
			return;
		}
		foreach (GameObject p in prefabs)
		{
			if (p != null)
			{
				s_prefabs[p.name] = p;
			}
		}
	}

	private static bool Cfx(string name, Vector3 pos, float scale, float life, float yaw = 0f)
	{
		if (!s_prefabs.TryGetValue(name, out GameObject prefab))
		{
			return false;
		}
		Spawn(prefab, pos, Quaternion.Euler(0f, yaw, 0f), scale, life);
		return true;
	}

	private static void Spawn(GameObject prefab, Vector3 pos, Quaternion rot, float scale, float life, float delay = 0f)
	{
		GameObject go = Object.Instantiate(prefab, pos, rot);
		go.transform.localScale = Vector3.one * scale;
		foreach (Light light in go.GetComponentsInChildren<Light>())
		{
			light.enabled = false;   // prefabs do Cartoon FX trazem luz em tempo real: clareava demais a arena (e pesa no celular)
		}
		ParticleSystem[] systems = go.GetComponentsInChildren<ParticleSystem>();
		foreach (ParticleSystem ps in systems)
		{
			ParticleSystem.MainModule main = ps.main;
			main.scalingMode = ParticleSystemScalingMode.Hierarchy;
			if (delay > 0f)
			{
				// atraso por instancia (onda que percorre uma linha): reinicia com startDelay
				ps.Stop(false, ParticleSystemStopBehavior.StopEmittingAndClear);
				main.startDelay = main.startDelay.constant + delay;
				ps.Play(false);
			}
		}
		life += delay;
		if (!Application.isPlaying)
		{
			foreach (ParticleSystem ps in systems)
			{
				ps.Simulate(0f, false, true, false);
			}
		}
		s_live.Add(new Live { prefab = go, systems = systems, life = life, total = life });
	}

	// efeitos proprios (Particle System + shader ArenaMasters/VFX), prefabs em Assets/VFX/Resources
	private static void Own(string name, Vector3 pos, Quaternion rot, float scale, float life, float delay = 0f)
	{
		if (!s_own.TryGetValue(name, out GameObject prefab))
		{
			prefab = Resources.Load<GameObject>(name);
			s_own[name] = prefab;
		}
		if (prefab == null)
		{
			Debug.LogWarning("[VFX] prefab nao encontrado: " + name + " (menu Arena Masters/VFX/Montar Machado Barbaro)");
			return;
		}
		Spawn(prefab, pos, rot, scale, life, delay);
	}

	private static readonly Dictionary<string, GameObject> s_own = new Dictionary<string, GameObject>();

	// carrega os efeitos proprios no inicio da luta: as particulas andam em tempo nao escalado, entao um travamento
	// na primeira vez que o efeito aparece (carregar prefab, criar material) faria a animacao pular esse tempo
	public static void Preload()
	{
		foreach (string name in new[] { "VFX_MachadoBarbaro", "VFX_MachadoImpacto", "VFX_CornetaGuerra", "VFX_EscudoCorneta", "VFX_GolpeTerra", "VFX_ForcaTerra", "VFX_BufaloCorrida", "VFX_BufaloImpacto", "VFX_DivisorTrecho", "VFX_EsquivaPoeira",
			"VFX_RaioCaos", "VFX_RaioCaosSaida", "VFX_RaioCaosImpacto", "VFX_RaioPenetrante", "VFX_Relampago", "VFX_OndaRaios", "VFX_Ruptura", "VFX_RupturaPulso", "VFX_ChoqueImpacto" })
		{
			if (!s_own.ContainsKey(name))
			{
				s_own[name] = Resources.Load<GameObject>(name);
			}
		}
		if (s_pillar == null)
		{
			s_pillar = Resources.Load<Mesh>("M_PilarPedra");
			s_pillarMat = Arena.MakeMaterial(new Color(0.45f, 0.38f, 0.31f));
		}
	}

	// Machado Barbaro: corte em arco na frente; roll inclina o arco (180 = golpe espelhado, da direita pra esquerda)
	public static void AxeSlash(Vector3 pos, Vector3 facing, float range, float roll)
	{
		Own("VFX_MachadoBarbaro", pos, Quaternion.LookRotation(facing) * Quaternion.Euler(0f, 0f, roll), range / 2.4f, 1.1f);
	}

	// Corneta de Guerra: grito com ondas de choque no chao (groundPos = pes do Axie)
	public static void WarHorn(Vector3 groundPos)
	{
		Own("VFX_CornetaGuerra", groundPos, Quaternion.identity, 1f, 1.3f);
	}

	// Golpe da Terra: rachadura, poeira e pedras onde o machado bate (~1,1 m na frente para alcance 3 m)
	public static void EarthSlam(Vector3 groundPos, Vector3 facing, float range)
	{
		float k = range / 3f;
		Own("VFX_GolpeTerra", groundPos + facing * (1.1f * k), Quaternion.LookRotation(facing), k, 1.9f);
	}

	// esquiva: poeira chutada para tras nos pes (saida e pouso); facing = para onde o heroi corre
	public static void DodgeDust(Vector3 groundPos, Vector3 facing, float scale)
	{
		Own("VFX_EsquivaPoeira", groundPos, Quaternion.LookRotation(facing), scale, 0.9f);
	}

	// imagem fantasma: copia a malha do boneco nesta pose (BakeMesh) com o shader Fantasma e some em 'life' segundos
	private class Ghost
	{
		public GameObject root;
		public List<Mesh> meshes;
		public List<Renderer> renderers;
		public float life, total;
		public Color color;
	}

	private static readonly List<Ghost> s_ghosts = new List<Ghost>();
	private static Material s_ghostMat;
	private static MaterialPropertyBlock s_ghostBlock;

	public static void Afterimage(Transform visual, Color color, float life)
	{
		if (visual == null)
		{
			return;
		}
		if (s_ghostMat == null)
		{
			s_ghostMat = Resources.Load<Material>("M_Fantasma");   // menu Arena Masters/VFX/Montar Esquiva
			s_ghostBlock = new MaterialPropertyBlock();
		}
		if (s_ghostMat == null)
		{
			return;
		}
		Ghost g = new Ghost { root = new GameObject("fantasma"), meshes = new List<Mesh>(), renderers = new List<Renderer>(), life = life, total = life, color = color };
		foreach (Renderer r in visual.GetComponentsInChildren<Renderer>())
		{
			if (!r.enabled || !r.gameObject.activeInHierarchy || r is ParticleSystemRenderer || r is TrailRenderer)
			{
				continue;
			}
			Mesh mesh;
			Matrix4x4 m;
			if (r is SkinnedMeshRenderer smr)
			{
				mesh = new Mesh();
				smr.BakeMesh(mesh, true);
				g.meshes.Add(mesh);
				m = Matrix4x4.TRS(smr.transform.position, smr.transform.rotation, Vector3.one);
			}
			else if (r.TryGetComponent(out MeshFilter mf) && mf.sharedMesh != null)
			{
				mesh = mf.sharedMesh;                // arma presa no osso: copia a malha como esta
				m = r.transform.localToWorldMatrix;
			}
			else
			{
				continue;
			}
			GameObject part = new GameObject(r.name);
			part.transform.SetParent(g.root.transform, false);
			part.transform.SetPositionAndRotation(m.GetColumn(3), m.rotation);
			part.transform.localScale = m.lossyScale;
			part.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer mr = part.AddComponent<MeshRenderer>();
			mr.sharedMaterial = s_ghostMat;
			mr.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
			mr.receiveShadows = false;
			g.renderers.Add(mr);
		}
		s_ghosts.Add(g);
		UpdateGhost(g);
	}

	private static void UpdateGhost(Ghost g)
	{
		float k = Mathf.Clamp01(g.life / g.total);
		s_ghostBlock.SetColor("_Color", g.color);
		s_ghostBlock.SetFloat("_Alpha", k * k * 0.7f);   // some rapido no comeco e devagar no fim
		foreach (Renderer r in g.renderers)
		{
			r.SetPropertyBlock(s_ghostBlock);
		}
	}

	private static void UpdateGhosts(float dt)
	{
		for (int i = s_ghosts.Count - 1; i >= 0; i--)
		{
			Ghost g = s_ghosts[i];
			g.life -= dt;
			if (g.life > 0f && g.root != null)
			{
				UpdateGhost(g);
				continue;
			}
			DestroyGhost(g);
			s_ghosts.RemoveAt(i);
		}
	}

	private static void DestroyGhost(Ghost g)
	{
		foreach (Mesh m in g.meshes)
		{
			Object.DestroyImmediate(m);
		}
		if (g.root != null)
		{
			Object.DestroyImmediate(g.root);
		}
	}

	// Investida do Bufalo: rastro preso no Axie durante a corrida e explosao na cabecada (pos = ponto do impacto, altura do peito)
	public static void BufaloRun(Transform owner, float life)
	{
		OwnAttached(owner, "VFX_BufaloCorrida", life);
	}

	public static void BufaloImpact(Vector3 pos, Vector3 facing)
	{
		Own("VFX_BufaloImpacto", pos, Quaternion.LookRotation(facing), 1f, 1.2f);
	}

	// aura de efeito proprio presa no lutador enquanto o buff durar (removida em DestroyAura)
	public static GameObject OwnAura(Transform owner, string name)
	{
		return OwnAttached(owner, name, 9999f);
	}

	private static GameObject OwnAttached(Transform owner, string name, float life)
	{
		if (!s_own.TryGetValue(name, out GameObject prefab))
		{
			prefab = Resources.Load<GameObject>(name);
			s_own[name] = prefab;
		}
		if (prefab == null)
		{
			Debug.LogWarning("[VFX] prefab nao encontrado: " + name);
			return null;
		}
		GameObject go = Object.Instantiate(prefab, owner);
		go.transform.localPosition = Vector3.zero;
		ParticleSystem[] systems = go.GetComponentsInChildren<ParticleSystem>();
		if (!Application.isPlaying)
		{
			foreach (ParticleSystem ps in systems)
			{
				ps.Simulate(0f, false, true, false);
			}
		}
		s_live.Add(new Live { prefab = go, systems = systems, life = life, total = life });
		return go;
	}

	public static void AxeImpact(Vector3 pos)
	{
		Own("VFX_MachadoImpacto", pos, Quaternion.identity, 1f, 0.5f);
	}

	public static void Clear()
	{
		s_live.Clear();
		s_materials.Clear();
		s_rocks.Clear();
		foreach (Ghost g in s_ghosts)
		{
			DestroyGhost(g);
		}
		s_ghosts.Clear();
		s_ghostMat = null;
		s_pillar = null;
		s_pillarMat = null;
		s_own.Clear();
	}

	// ---------- efeitos de skill ----------

	public static void Slash(Vector3 pos, Vector3 facing, Color color, float radius)
	{
		Cfx("CFXR _SLASH_", pos + facing * radius * 0.5f + Vector3.up * 0.6f, 0.7f, 1f);
		ParticleSystem ps = Single("slash_02", pos + facing * radius * 0.45f, color, radius * 2f, 0.22f, true, Angle(facing) + 90f);
		Grow(ps, 0.7f, 1.15f);
		Sparks(pos + facing * radius * 0.6f, color, 14, 5f, 0.35f);
	}

	public static void Spin(Vector3 pos, Color color, float radius, bool magic)
	{
		Cfx(magic ? "CFXR4 Sword Trail ICE (360 Spiral)" : "CFXR4 Sword Trail PLAIN (360 Spiral)", pos, radius * 0.55f, 1.2f);
		ParticleSystem ps = Single(magic ? "twirl_02" : "twirl_01", pos, color, radius * 2.2f, 0.45f, true, 0f);
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(-12f);
		Grow(ps, 0.5f, 1.1f);
		ParticleSystem ring = Burst(magic ? "star_01" : "spark_04", pos, color, 24, 0.5f, 0.25f, 0.5f, true);
		ParticleSystem.ShapeModule shape = ring.shape;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = radius * 0.6f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.MainModule main = ring.main;
		main.startSpeed = new ParticleSystem.MinMaxCurve(3f, 6f);
	}

	public static void Slam(Vector3 groundPos, Color color, float radius)
	{
		Cfx("CFXR2 Ground Hit", groundPos, radius * 0.6f, 2f);
		Cfx("CFXR _BOOM_", groundPos + Vector3.up * 1.4f, 0.8f, 1.2f);
		ParticleSystem wave = Single("circle_05", groundPos + Vector3.up * 0.08f, color, radius * 2.6f, 0.4f, true, 0f);
		Grow(wave, 0.2f, 1f);
		Decal("scorch_01", groundPos + Vector3.up * 0.04f, new Color(0.15f, 0.1f, 0.08f, 0.85f), radius * 1.6f, 3f);
		ParticleSystem dust = Burst("smoke_03", groundPos + Vector3.up * 0.3f, new Color(0.65f, 0.55f, 0.45f, 0.8f), 18, 0.8f, 0.8f, 1.6f, false);
		ParticleSystem.ShapeModule shape = dust.shape;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = radius * 0.5f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		Sparks(groundPos + Vector3.up * 0.5f, color, 20, 7f, 0.5f);
	}

	// Raio Penetrante: feixe eletrico de 'length' metros (prefab feito para 10 m)
	public static void Beam(Vector3 from, Vector3 dir, float length, Color color)
	{
		Own("VFX_RaioPenetrante", from, Quaternion.LookRotation(dir), length / 10f, 0.7f);
	}

	public static void MagicBurst(Vector3 groundPos, Color color, float radius)
	{
		Cfx("CFXR4 Firework 1 Cyan-Purple (HDR)", groundPos + Vector3.up * 0.5f, radius * 0.3f, 2f);
		ParticleSystem circle = Single("symbol_02", groundPos + Vector3.up * 0.06f, color, radius * 2.4f, 0.5f, true, 0f);
		Grow(circle, 1f, 1.25f);
		Flash(groundPos + Vector3.up * 1f, color, radius * 1.8f);
		ParticleSystem up = Burst("magic_04", groundPos + Vector3.up * 0.3f, color, 30, 0.7f, 0.25f, 0.6f, true);
		ParticleSystem.MainModule main = up.main;
		main.startSpeed = new ParticleSystem.MinMaxCurve(2f, 7f);
		ParticleSystem.ShapeModule shape = up.shape;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 35f;
		shape.radius = radius * 0.5f;
		shape.rotation = new Vector3(-90f, 0f, 0f);
		Burst("smoke_07", groundPos + Vector3.up * 0.8f, new Color(0.5f, 0.35f, 0.6f, 0.6f), 10, 1f, 1f, 2f, false);
	}

	// ---------- herois da wiki ----------

	public static void Barrier(Vector3 pos, Color color)
	{
		Cfx("CFXR3 Shield Leaves A (Lit)", pos + Vector3.down * 0.9f, 1.2f, 1.5f);
		ParticleSystem ring = Single("circle_03", pos + Vector3.down * 0.9f, color, 3f, 0.6f, true, 0f);
		Grow(ring, 0.4f, 1.2f);
		Burst("star_06", pos + Vector3.up * 0.5f, color, 14, 0.7f, 0.2f, 0.5f, true);
	}

	// Relampago: um raio caindo do ceu no ponto do acerto (o jogo solta um por golpe)
	public static void Lightning(Vector3 groundPos, Color color, float radius)
	{
		Own("VFX_Relampago", groundPos, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f), radius / 2.2f, 0.7f);
	}

	// Onda de Raios: arcos eletricos em leque a partir dos pes (prefab feito para alcance 5 m)
	public static void Wave(Vector3 pos, Vector3 facing, Color color, float range)
	{
		Own("VFX_OndaRaios", pos + Vector3.down * Arena.CenterHeight, Quaternion.LookRotation(facing), range / 5f, 0.8f);
	}

	// Ruptura Caotica: pulso a cada dano (a fenda inteira nasce em RuptureRift, no inicio da skill)
	public static void Rupture(Vector3 groundPos, Color color, float radius)
	{
		Own("VFX_RupturaPulso", groundPos, Quaternion.identity, radius / 3.6f, 0.6f);
	}

	public static void RuptureRift(Vector3 groundPos, float radius)
	{
		Own("VFX_Ruptura", groundPos, Quaternion.identity, radius / 3.6f, 3.8f);
	}

	// acerto eletrico no alvo (skills magicas sem projetil)
	public static void ElectricHit(Vector3 pos, bool critical)
	{
		Own("VFX_ChoqueImpacto", pos, Quaternion.identity, critical ? 1.4f : 1f, 0.6f);
	}

	// Divisor de Terra: a onda corre pela linha (um trecho a cada 1,6 m, 28 m/s) e levanta as pedras nos mesmos
	// pontos dos obstaculos do Fighter (Arena.blockers: d = 2, 3,6 ... ate o alcance)
	public static void TerraSplitter(Vector3 groundPos, Vector3 facing, Color color, float range)
	{
		const float waveSpeed = 28f;
		Quaternion rot = Quaternion.LookRotation(facing);
		Own("VFX_DivisorTrecho", groundPos + facing * 0.9f, rot, 1.4f, 1.7f);   // onde o machado bate: trecho maior
		for (float d = 2f; d <= range; d += 1.6f)
		{
			Vector3 p = groundPos + facing * d;
			Own("VFX_DivisorTrecho", p, rot, 1f, 1.7f, d / waveSpeed);
			Rock(p, 4f, d / waveSpeed);
		}
	}

	// pedra que sobe do chao e afunda no fim (visual do obstaculo do Arena.blockers)
	private class RockAnim
	{
		public Transform t;
		public float age, delay, total, height, groundY, pivot;   // pivot: base ate o pivo (0 na malha, meia altura no cubo)
	}

	private static readonly List<RockAnim> s_rocks = new List<RockAnim>();
	private static Mesh s_pillar;
	private static Material s_pillarMat;

	private static void Rock(Vector3 groundPos, float life, float delay)
	{
		if (s_pillar == null)
		{
			s_pillar = Resources.Load<Mesh>("M_PilarPedra");   // pedra pontuda (menu Arena Masters/VFX/Montar Divisor de Terra)
			s_pillarMat = Arena.MakeMaterial(new Color(0.45f, 0.38f, 0.31f));
		}
		GameObject rock;
		if (s_pillar != null)
		{
			rock = new GameObject("pedra");
			rock.AddComponent<MeshFilter>().sharedMesh = s_pillar;
			rock.AddComponent<MeshRenderer>().sharedMaterial = s_pillarMat;
		}
		else
		{
			rock = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Object.DestroyImmediate(rock.GetComponent<Collider>());
			rock.name = "pedra";
		}
		float h = Random.Range(1.3f, 1.9f);
		rock.transform.position = groundPos + Vector3.down * (h + 0.2f);
		rock.transform.rotation = Quaternion.Euler(Random.Range(-12f, 12f), Random.Range(0f, 360f), Random.Range(-12f, 12f));
		float w = Random.Range(1.2f, 1.6f);
		rock.transform.localScale = new Vector3(w, h, w * Random.Range(0.85f, 1.15f));
		s_rocks.Add(new RockAnim { t = rock.transform, age = 0f, delay = delay, total = life, height = h, groundY = groundPos.y, pivot = s_pillar != null ? 0f : h * 0.5f });
	}

	// espera o atraso, salta do chao em 0,12 s passando um pouco da altura, assenta, e afunda nos ultimos 0,4 s
	private static void UpdateRocks(float dt)
	{
		for (int i = s_rocks.Count - 1; i >= 0; i--)
		{
			RockAnim r = s_rocks[i];
			r.age += dt;
			float t = r.age - r.delay;
			if (r.t == null || t >= r.total)
			{
				if (r.t != null)
				{
					if (Application.isPlaying)
					{
						Object.Destroy(r.t.gameObject);
					}
					else
					{
						Object.DestroyImmediate(r.t.gameObject);
					}
				}
				s_rocks.RemoveAt(i);
				continue;
			}
			float up = 0f;
			if (t > 0f)
			{
				up = t < 0.12f ? t / 0.12f * 1.08f : Mathf.Lerp(1.08f, 1f, (t - 0.12f) / 0.1f);
				up *= Mathf.Clamp01((r.total - t) / 0.4f);
			}
			Vector3 p = r.t.position;
			// base 0,2 m enterrada (pedra inclinada nao mostra o fundo); some toda embaixo do chao antes de subir
			r.t.position = new Vector3(p.x, r.groundY - 0.2f - (1f - up) * (r.height + 0.2f) + r.pivot, p.z);
		}
	}

	// aviso no chao durante a preparacao da skill (o jogo original tambem marcava areas)
	public static void Telegraph(Vector3 groundPos, Color color, float radius, float duration, bool magic)
	{
		color.a = 0.55f;
		ParticleSystem ps = Single(magic ? "symbol_01" : "circle_01", groundPos + Vector3.up * 0.05f, color, radius * 2f, duration, true, 0f);
		Grow(ps, 0.3f, 1f);
		if (magic)
		{
			ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
			rot.enabled = true;
			rot.z = new ParticleSystem.MinMaxCurve(2f);
		}
	}

	public static void Dust(Vector3 groundPos)
	{
		Burst("smoke_01", groundPos + Vector3.up * 0.3f, new Color(0.7f, 0.65f, 0.55f, 0.7f), 8, 0.6f, 0.5f, 1f, false);
	}

	public static void Teleport(Vector3 pos, Color color)
	{
		Cfx("CFXR Magic Poof", pos, 1f, 1.5f);
		Burst("magic_05", pos, color, 20, 0.5f, 0.2f, 0.5f, true);
		Burst("smoke_07", pos, new Color(0.6f, 0.5f, 0.7f, 0.6f), 6, 0.6f, 0.8f, 1.4f, false);
		Flash(pos, color, 1.4f);
	}

	public static void Hit(Vector3 pos, Color color, bool critical, bool magic = false)
	{
		Cfx(magic ? "CFXR Impact Glowing HDR (Blue)" : "CFXR4 Sword Hit PLAIN (Cross)", pos, magic ? 0.8f : 1f, 1.2f);
		if (critical)
		{
			Cfx("CFXR _POW_", pos + Vector3.up * 1.2f, 0.7f, 1.2f);
		}
		Sparks(pos, critical ? new Color(1f, 0.85f, 0.2f) : color, critical ? 26 : 12, critical ? 8f : 5f, 0.3f);
		Flash(pos, critical ? new Color(1f, 0.9f, 0.4f) : Color.white, critical ? 2.4f : 1.1f);
		if (critical)
		{
			ParticleSystem star = Single("star_04", pos, new Color(1f, 0.9f, 0.3f), 2.2f, 0.3f, false, 0f);
			Grow(star, 0.4f, 1.3f);
		}
	}

	public static void Death(Vector3 pos)
	{
		Cfx("CFXR2 Souls Escape", pos, 1f, 2.5f);
		Burst("smoke_03", pos, new Color(0.4f, 0.4f, 0.45f, 0.8f), 16, 1.2f, 1.2f, 2.2f, false);
		Burst("star_01", pos + Vector3.up, new Color(1f, 0.9f, 0.5f), 12, 0.8f, 0.3f, 0.6f, true);
	}

	// projetil: nucleo brilhante + rastro de particulas (seguem o objeto do projetil)
	// projetil do Relampago do Caos: prefab em laco preso no projetil (some com ReleaseProjectileVisual)
	public static void ProjectileVisual(GameObject owner, Color color)
	{
		if (!s_own.TryGetValue("VFX_RaioCaos", out GameObject prefab))
		{
			prefab = Resources.Load<GameObject>("VFX_RaioCaos");
			s_own["VFX_RaioCaos"] = prefab;
		}
		if (prefab == null)
		{
			return;
		}
		GameObject go = Object.Instantiate(prefab, owner.transform);
		go.transform.localPosition = Vector3.zero;
		s_live.Add(new Live { prefab = go, systems = go.GetComponentsInChildren<ParticleSystem>(), life = 9999f, total = 9999f });
	}

	// solta o efeito do projetil no mundo: para de emitir e o rastro some sozinho (sem sumir de uma vez)
	public static void ReleaseProjectileVisual(GameObject owner)
	{
		for (int i = s_live.Count - 1; i >= 0; i--)
		{
			Live l = s_live[i];
			if (l.prefab == null || l.prefab.transform.parent != owner.transform)
			{
				continue;
			}
			l.prefab.transform.SetParent(null, true);
			foreach (ParticleSystem ps in l.systems)
			{
				ps.Stop(false, ParticleSystemStopBehavior.StopEmitting);
			}
			l.life = l.total = 0.4f;
			s_live[i] = l;
		}
	}

	public static void Muzzle(Vector3 pos, Color color)
	{
		Own("VFX_RaioCaosSaida", pos, Quaternion.identity, 1f, 0.4f);
	}

	public static void Impact(Vector3 pos, Color color)
	{
		Own("VFX_RaioCaosImpacto", pos, Quaternion.identity, 1f, 0.6f);
	}

	// aura em volta do lutador enquanto o buff durar (removida em DestroyAura)
	public static GameObject Aura(Transform owner, string tex, Color color, bool overHead)
	{
		ParticleSystem ps = Create(tex, owner.position, true, 9999f);
		ps.transform.SetParent(owner, true);
		ps.transform.localPosition = overHead ? new Vector3(0f, 1.5f, 0f) : new Vector3(0f, -0.4f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.5f, 0.9f);
		main.startSize = new ParticleSystem.MinMaxCurve(overHead ? 0.3f : 0.25f, overHead ? 0.5f : 0.6f);
		color.a = 0.85f;
		main.startColor = color;
		main.startSpeed = new ParticleSystem.MinMaxCurve(0.2f, overHead ? 0.4f : 1.2f);
		main.simulationSpace = overHead ? ParticleSystemSimulationSpace.Local : ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = overHead ? 6f : 14f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = overHead ? 0.35f : 0.55f;
		shape.rotation = new Vector3(overHead ? 90f : -90f, 0f, 0f);
		if (overHead)
		{
			ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
			rot.enabled = true;
			rot.z = new ParticleSystem.MinMaxCurve(4f);
		}
		ps.Play();
		return ps.gameObject;
	}

	public static void DestroyAura(GameObject aura)
	{
		if (aura == null)
		{
			return;
		}
		int i = s_live.FindIndex(l => (l.ps != null && l.ps.gameObject == aura) || l.prefab == aura);
		if (i >= 0)
		{
			s_live.RemoveAt(i);
		}
		if (Application.isPlaying)
		{
			Object.Destroy(aura);
		}
		else
		{
			Object.DestroyImmediate(aura);
		}
	}

	// ---------- base ----------

	public static void Update(float dt)
	{
		UpdateRocks(dt);
		UpdateGhosts(Time.unscaledDeltaTime > 0f && Application.isPlaying ? Time.unscaledDeltaTime : dt);   // fantasma some no tempo real (anda no hit stop)
		for (int i = s_live.Count - 1; i >= 0; i--)
		{
			Live l = s_live[i];
			l.life -= dt;
			if (l.ps != null && !Application.isPlaying)
			{
				l.ps.Simulate(dt, true, false, false);
			}
			if (l.systems != null && l.prefab != null && !Application.isPlaying)
			{
				foreach (ParticleSystem ps in l.systems)
				{
					if (ps != null)
					{
						ps.Simulate(dt, false, false, false);
					}
				}
			}
			if (l.line != null)
			{
				float a = Mathf.Clamp01(l.life / l.total);
				Color c = l.line.startColor;
				c.a = a;
				l.line.startColor = l.line.endColor = c;
				l.line.widthMultiplier = 0.9f * (0.4f + a * 0.6f);
			}
			if (l.life <= 0f)
			{
				Object go = l.prefab != null ? l.prefab : l.ps != null ? (Object)l.ps.gameObject : (l.line != null ? l.line.gameObject : null);
				if (go != null)
				{
					if (Application.isPlaying)
					{
						Object.Destroy(go);
					}
					else
					{
						Object.DestroyImmediate(go);
					}
				}
				s_live.RemoveAt(i);
				continue;
			}
			s_live[i] = l;
		}
	}

	private static float Angle(Vector3 dir) => Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;

	private static Material Mat(string tex, bool additive)
	{
		string key = tex + (additive ? "+" : "a");
		if (!s_materials.TryGetValue(key, out Material m))
		{
			m = ParticleMaterial(Resources.Load<Texture2D>("VFX/" + tex), additive);
			s_materials[key] = m;
		}
		return m;
	}

	// material de particula com o shader proprio (funciona no URP): brilho = cinza da textura, cor = cor da particula
	public static Material ParticleMaterial(Texture2D tex, bool additive)
	{
		Material m = new Material(Shader.Find("ArenaMasters/VFX/Particula Dissolve")) { mainTexture = tex };
		m.SetColor("_Color", Color.black);
		m.SetColor("_CoreColor", Color.white);
		m.SetFloat("_CorePower", 1f);
		m.SetFloat("_Distortion", 0f);
		m.SetFloat("_Additive", additive ? 1f : 0f);
		return m;
	}

	private static ParticleSystem Create(string tex, Vector3 pos, bool additive, float life)
	{
		GameObject go = new GameObject("vfx_" + tex);
		go.transform.position = pos;
		ParticleSystem ps = go.AddComponent<ParticleSystem>();
		ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
		ParticleSystem.MainModule main = ps.main;
		main.loop = false;
		main.playOnAwake = false;
		main.duration = 0.1f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		main.startSpeed = 0f;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 0f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = false;
		ParticleSystem.ColorOverLifetimeModule col = ps.colorOverLifetime;
		col.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 0.6f), new GradientAlphaKey(0f, 1f) });
		col.color = g;
		ParticleSystemRenderer r = go.GetComponent<ParticleSystemRenderer>();
		r.material = Mat(tex, additive);
		s_live.Add(new Live { ps = ps, life = life + 0.1f, total = life });
		return ps;
	}

	// um unico sprite grande (corte, redemoinho, onda de choque, circulo magico)
	private static ParticleSystem Single(string tex, Vector3 pos, Color color, float size, float life, bool horizontal, float yaw)
	{
		ParticleSystem ps = Create(tex, pos, true, life);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = life;
		main.startSize = size;
		main.startColor = color;
		main.startRotation = yaw * Mathf.Deg2Rad;
		ps.GetComponent<ParticleSystemRenderer>().renderMode = horizontal ? ParticleSystemRenderMode.HorizontalBillboard : ParticleSystemRenderMode.Billboard;
		ps.Emit(1);
		return ps;
	}

	private static ParticleSystem Burst(string tex, Vector3 pos, Color color, int count, float life, float minSize, float maxSize, bool additive)
	{
		ParticleSystem ps = Create(tex, pos, additive, life);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(life * 0.6f, life);
		main.startSize = new ParticleSystem.MinMaxCurve(minSize, maxSize);
		main.startColor = color;
		main.startSpeed = new ParticleSystem.MinMaxCurve(0.5f, 2.5f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 0.3f;
		ps.Emit(count);
		return ps;
	}

	private static void Sparks(Vector3 pos, Color color, int count, float speed, float life)
	{
		ParticleSystem ps = Burst("spark_01", pos, color, count, life, 0.15f, 0.4f, true);
		ParticleSystem.MainModule main = ps.main;
		main.startSpeed = new ParticleSystem.MinMaxCurve(speed * 0.5f, speed);
		main.gravityModifier = 1.2f;
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.Stretch;
		ps.GetComponent<ParticleSystemRenderer>().velocityScale = 0.08f;
		ps.Clear();
		ps.Emit(count);
	}

	private static void Flash(Vector3 pos, Color color, float size)
	{
		ParticleSystem ps = Single("light_01", pos, color, size, 0.15f, false, 0f);
		Grow(ps, 0.6f, 1.2f);
	}

	private static void Decal(string tex, Vector3 pos, Color color, float size, float life)
	{
		ParticleSystem ps = Create(tex, pos, false, life);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = life;
		main.startSize = size;
		main.startColor = color;
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
		ps.Emit(1);
	}

	private static void Grow(ParticleSystem ps, float from, float to)
	{
		ParticleSystem.SizeOverLifetimeModule size = ps.sizeOverLifetime;
		size.enabled = true;
		size.size = new ParticleSystem.MinMaxCurve(1f, AnimationCurve.Linear(0f, from, 1f, to));
	}
}
