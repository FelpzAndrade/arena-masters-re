using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;
using C = VfxCornetaBuilder;

// Monta todos os efeitos do Spark so com Particle System + shader proprio (sem Cartoon FX e sem luz em tempo real).
// Menu: Arena Masters/VFX/Montar Spark. Refaz materiais, malhas e prefabs (atualiza no lugar, mantem GUID).
//   VFX_RaioCaos / VFX_RaioCaosSaida / VFX_RaioCaosImpacto  projetil vermelho do ataque basico (preso no projetil), saida e acerto
//   VFX_RaioPenetrante   feixe eletrico de 10 m (malha em cruz esticada, raio rolando), faiscas pela linha
//   VFX_Relampago        um raio caindo do ceu no ponto do acerto, anel e faiscas no chao (o jogo solta 3)
//   VFX_OndaRaios        3 arcos eletricos abrindo em leque de 110 graus, faiscas
//   VFX_Ruptura / VFX_RupturaPulso  fenda roxa da ultimate (3,4 s: redemoinho, vazio, particulas sugadas, arcos, colapso) e pulso a cada dano
//   VFX_ChoqueImpacto    acerto eletrico no alvo (skills sem projetil)
//   VFX_Eletrocutado / VFX_CargaPoder / VFX_Pressa  auras dos buffs (BuffDef.auraPrefab)
// Particulas vivas no maximo: projetil 15, saida 7, acerto 14, feixe 24, relampago 23 (x3), onda 24, fenda 20, pulso 5,
// choque 11, eletrocutado 8, carga 10, pressa 6.
public static class VfxSparkBuilder
{
	private const string Root = "Assets/VFX";
	private static readonly Color Cyan = new Color(0.55f, 0.9f, 1f);
	private static readonly Color Red = new Color(1f, 0.35f, 0.3f);
	private static readonly Color Violet = new Color(0.75f, 0.45f, 1f);

	private static Shader s_shader;
	private static Texture2D s_noise;

	[MenuItem("Arena Masters/VFX/Montar Spark")]
	public static void Build()
	{
		s_shader = Shader.Find("ArenaMasters/VFX/Particula Dissolve");
		s_noise = Tex("T_Noise");
		Texture2D spark = Tex("T_Spark"), ring = Tex("T_Ring"), bolt = Tex("T_Bolt"), boltV = Tex("T_BoltV"), swirl = Tex("T_Swirl");
		if (s_shader == null || s_noise == null || spark == null || ring == null || bolt == null || boltV == null || swirl == null)
		{
			Debug.LogError("[VFX] faltam shader ou texturas em Assets/VFX (rode tools/gen_vfx_textures.py)");
			return;
		}
		C.SetClamp(boltV);
		C.SetClamp(swirl);

		Material redSpark = Mat("M_FaiscaVermelha", spark, new Color(3f, 0.7f, 0.5f), new Color(4f, 2.6f, 2.2f), 1f, 0f);
		Material cyanSpark = Mat("M_FaiscaCiano", spark, new Color(0.8f, 2.2f, 3.2f), new Color(2.6f, 3.6f, 4f), 1f, 0f);
		Material violetSpark = Mat("M_FaiscaRoxa", spark, new Color(2f, 0.9f, 3.2f), new Color(3.4f, 2.6f, 4f), 1f, 0f);
		Material redRing = Mat("M_AnelVermelho", ring, new Color(2.6f, 0.6f, 0.4f), new Color(4f, 2.4f, 2f), 1.5f, 0.03f);
		Material cyanRing = Mat("M_AnelCiano", ring, new Color(0.6f, 1.8f, 3f), new Color(2.4f, 3.4f, 4f), 1.5f, 0.03f);
		Material violetRing = Mat("M_AnelRoxo", ring, new Color(1.8f, 0.7f, 3f), new Color(3.2f, 2.4f, 4f), 1.5f, 0.03f);
		Material arc = Mat("M_ArcoEletrico", bolt, new Color(0.6f, 1.6f, 3f), new Color(3f, 3.8f, 4.5f), 1.2f, 0.06f);
		arc.SetVector("_NoiseScroll", new Vector4(-3f, 0.5f, 0f, 0f));
		EditorUtility.SetDirty(arc);
		Material redArc = Mat("M_ArcoVermelho", bolt, new Color(2.6f, 0.5f, 0.4f), new Color(4f, 3f, 2.6f), 1.2f, 0.06f);
		Material violetArc = Mat("M_ArcoRoxo", bolt, new Color(1.8f, 0.6f, 3f), new Color(3.6f, 3f, 4.5f), 1.2f, 0.06f);
		Material beam = Mat("M_Feixe", bolt, new Color(0.5f, 1.6f, 3f), new Color(3f, 4f, 4.5f), 1.2f, 0.08f);
		beam.SetTextureScale("_MainTex", new Vector2(4f, 1f));         // 4 repeticoes do raio ao longo dos 10 m
		beam.SetVector("_MainScroll", new Vector4(-6f, 0f, 0f, 0f));   // o raio corre do cajado para a frente
		beam.SetVector("_NoiseScroll", new Vector4(-4f, 1f, 0f, 0f));
		beam = B.SaveAsset(beam, Root + "/Materials/M_Feixe.mat");
		Material sky = Mat("M_RaioCeu", boltV, new Color(0.6f, 1.7f, 3.2f), new Color(3.4f, 4f, 4.5f), 1.2f, 0.04f);
		Material rift = Mat("M_Fenda", swirl, new Color(1.4f, 0.5f, 2.6f), new Color(3f, 2f, 4f), 1.5f, 0.04f);
		Material voidMat = Mat("M_Vazio", spark, new Color(0.03f, 0f, 0.06f), new Color(0f, 0f, 0f), 1f, 0f);
		voidMat.SetFloat("_Additive", 0f);                              // escurece o chao (nao soma luz)
		voidMat = B.SaveAsset(voidMat, Root + "/Materials/M_Vazio.mat");

		Mesh cross = B.SaveAsset(BuildBeamMesh(), Root + "/Meshes/M_FeixeCruz.asset");
		Mesh fan = B.SaveAsset(BuildFanArc(110f, 0.82f), Root + "/Meshes/M_ArcoOnda.asset");

		// ---------- Relampago do Caos (basico) ----------
		GameObject go = new GameObject("VFX_RaioCaos");
		Loop(go.transform, "Nucleo", redSpark, 4, 0.1f, 0.85f, 35f, Red, true);
		TrailSparks(go.transform, redSpark);
		Crackle(go.transform, redArc, 3, 0.6f, 0.08f, 25f, Vector3.zero, 0.25f);
		B.SavePrefab(go, Root + "/Resources/VFX_RaioCaos.prefab");

		go = new GameObject("VFX_RaioCaosSaida");
		Flash(go.transform, redSpark, Vector3.zero, 1.1f, Red);
		Burst(go.transform, redSpark, 6, 3f, 6f, 0.15f, 0.25f, Red, 180f);
		B.SavePrefab(go, Root + "/Resources/VFX_RaioCaosSaida.prefab");

		go = new GameObject("VFX_RaioCaosImpacto");
		Flash(go.transform, redSpark, Vector3.zero, 1.7f, Red);
		Burst(go.transform, redSpark, 12, 4f, 9f, 0.2f, 0.4f, Red, 180f);
		Ring(go.transform, redRing, Vector3.zero, 1.6f, 0.25f, false);
		B.SavePrefab(go, Root + "/Resources/VFX_RaioCaosImpacto.prefab");

		// ---------- Raio Penetrante ----------
		go = new GameObject("VFX_RaioPenetrante");
		Beam(go.transform, "Feixe", beam, cross, 1.4f, 0.4f);
		Beam(go.transform, "Miolo", beam, cross, 0.55f, 0.28f);
		Flash(go.transform, cyanSpark, Vector3.zero, 1.6f, Cyan);
		Flash(go.transform, cyanSpark, new Vector3(0f, 0f, 10f), 2f, Cyan);
		LineSparks(go.transform, cyanSpark);
		B.SavePrefab(go, Root + "/Resources/VFX_RaioPenetrante.prefab");

		// ---------- Relampago (do ceu) ----------
		go = new GameObject("VFX_Relampago");
		SkyBolt(go.transform, sky);
		Flash(go.transform, cyanSpark, new Vector3(0f, 0.5f, 0f), 2.4f, Cyan);
		Ring(go.transform, cyanRing, new Vector3(0f, 0.05f, 0f), 3.6f, 0.35f, true);
		GroundArcs(go.transform, arc);
		UpSparks(go.transform, cyanSpark, 16);
		B.SavePrefab(go, Root + "/Resources/VFX_Relampago.prefab");

		// ---------- Onda de Raios ----------
		go = new GameObject("VFX_OndaRaios");
		FanWaves(go.transform, arc, fan);
		Flash(go.transform, cyanSpark, new Vector3(0f, 0.9f, 0.6f), 1.5f, Cyan);
		ConeSparks(go.transform, cyanSpark);
		B.SavePrefab(go, Root + "/Resources/VFX_OndaRaios.prefab");

		// ---------- Ruptura Caotica (ultimate) ----------
		go = new GameObject("VFX_Ruptura");
		RiftDisc(go.transform, "Redemoinho", rift, 9.6f, -2.6f, 0.06f);   // bracos visiveis ate ~0,75 do raio: cobre a area de 3,6 m
		RiftDisc(go.transform, "Vazio", voidMat, 3.6f, 0f, 0.03f);
		Suction(go.transform, violetSpark);
		Crackle(go.transform, violetArc, 2, 2.6f, 0.12f, 6f, new Vector3(0f, 0.1f, 0f), 2.4f, true);
		Collapse(go.transform, violetSpark, violetRing);
		B.SavePrefab(go, Root + "/Resources/VFX_Ruptura.prefab");

		go = new GameObject("VFX_RupturaPulso");
		Ring(go.transform, violetRing, new Vector3(0f, 0.08f, 0f), 4.2f, 0.3f, true);
		UpSparks(go.transform, violetSpark, 4);
		B.SavePrefab(go, Root + "/Resources/VFX_RupturaPulso.prefab");

		// ---------- acerto eletrico ----------
		go = new GameObject("VFX_ChoqueImpacto");
		Flash(go.transform, cyanSpark, Vector3.zero, 1.3f, Cyan);
		Burst(go.transform, cyanSpark, 8, 3f, 7f, 0.15f, 0.35f, Cyan, 180f);
		Crackle(go.transform, arc, 2, 0.9f, 0.1f, 0f, Vector3.zero, 0.3f, false, 2);
		B.SavePrefab(go, Root + "/Resources/VFX_ChoqueImpacto.prefab");

		// ---------- auras dos buffs (presas no lutador: centro do corpo em y = 0, pes em y = -0,95) ----------
		go = new GameObject("VFX_Eletrocutado");
		Crackle(go.transform, arc, 3, 0.9f, 0.09f, 9f, new Vector3(0f, 0.1f, 0f), 0.45f);
		AuraSparks(go.transform, cyanSpark, 5, -1.2f, new Vector3(0f, 0.3f, 0f), 0.35f);
		B.SavePrefab(go, Root + "/Resources/VFX_Eletrocutado.prefab");

		go = new GameObject("VFX_CargaPoder");
		OrbitMotes(go.transform, cyanSpark);
		B.SavePrefab(go, Root + "/Resources/VFX_CargaPoder.prefab");

		go = new GameObject("VFX_Pressa");
		SpeedLines(go.transform, cyanSpark);
		B.SavePrefab(go, Root + "/Resources/VFX_Pressa.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Spark montado: 15 prefabs em Assets/VFX/Resources");
	}

	private static Texture2D Tex(string name) => AssetDatabase.LoadAssetAtPath<Texture2D>(Root + "/Textures/" + name + ".png");

	private static Material Mat(string name, Texture2D tex, Color color, Color core, float corePower, float distortion)
	{
		Material m = new Material(s_shader);
		m.SetTexture("_MainTex", tex);
		m.SetTexture("_NoiseTex", s_noise);
		m.SetColor("_Color", color);
		m.SetColor("_CoreColor", core);
		m.SetFloat("_CorePower", corePower);
		m.SetFloat("_Distortion", distortion);
		m.SetColor("_EdgeColor", core * 0.8f);
		return B.SaveAsset(m, Root + "/Materials/" + name + ".mat");
	}

	// duas faixas em cruz (deitada e em pe) de z = 0 a 1: o feixe aparece de cima e de lado. u = ao longo, v = atravessando
	private static Mesh BuildBeamMesh()
	{
		Vector3[] v =
		{
			new Vector3(-0.5f, 0f, 0f), new Vector3(0.5f, 0f, 0f), new Vector3(-0.5f, 0f, 1f), new Vector3(0.5f, 0f, 1f),
			new Vector3(0f, -0.5f, 0f), new Vector3(0f, 0.5f, 0f), new Vector3(0f, -0.5f, 1f), new Vector3(0f, 0.5f, 1f),
		};
		Vector2[] uv =
		{
			new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(1f, 0f), new Vector2(1f, 1f),
			new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(1f, 0f), new Vector2(1f, 1f),
		};
		Mesh mesh = new Mesh { name = "M_FeixeCruz", vertices = v, uv = uv, triangles = new[] { 0, 2, 1, 1, 2, 3, 4, 6, 5, 5, 6, 7 } };
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();
		return mesh;
	}

	// faixa em arco no plano XZ (raio interno 'inner', externo 1), centrada em +Z. u = ao longo do arco, v = atravessando
	private static Mesh BuildFanArc(float degrees, float inner)
	{
		const int segments = 32;
		List<Vector3> verts = new List<Vector3>();
		List<Vector2> uvs = new List<Vector2>();
		List<int> tris = new List<int>();
		for (int i = 0; i <= segments; i++)
		{
			float u = i / (float)segments;
			float a = (u - 0.5f) * degrees * Mathf.Deg2Rad;
			Vector3 dir = new Vector3(Mathf.Sin(a), 0f, Mathf.Cos(a));
			verts.Add(dir * inner);
			verts.Add(dir);
			uvs.Add(new Vector2(u * 3f, 0f));   // o raio repete 3 vezes ao longo do arco
			uvs.Add(new Vector2(u * 3f, 1f));
			if (i < segments)
			{
				int b = i * 2;
				tris.AddRange(new[] { b, b + 1, b + 3, b, b + 3, b + 2 });
			}
		}
		Mesh mesh = new Mesh { name = "M_ArcoOnda" };
		mesh.SetVertices(verts);
		mesh.SetUVs(0, uvs);
		mesh.SetTriangles(tris, 0);
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();
		return mesh;
	}

	// ---------- pecas ----------

	private static void Flash(Transform parent, Material mat, Vector3 pos, float size, Color color)
	{
		ParticleSystem ps = B.NewSystem(parent, "Clarao", mat, 1);
		ps.transform.localPosition = pos;
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.13f;
		main.startSize = size;
		main.startColor = color;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.2f);
	}

	// faiscas esticadas espirrando; arc = abertura do cone (180 = meia esfera para +Z, 360 = esfera)
	private static void Burst(Transform parent, Material mat, int count, float speedMin, float speedMax, float lifeMin, float lifeMax, Color color, float arc)
	{
		ParticleSystem ps = B.NewSystem(parent, "Faiscas", mat, count);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(lifeMin, lifeMax);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(speedMin, speedMax);
		main.startColor = color;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, count);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = arc >= 360f ? ParticleSystemShapeType.Sphere : ParticleSystemShapeType.Hemisphere;
		shape.radius = 0.15f;
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.1f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		Stretch(ps, 0.05f, 1.5f);
	}

	private static void Stretch(ParticleSystem ps, float velocityScale, float lengthScale)
	{
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = velocityScale;
		r.lengthScale = lengthScale;
	}

	private static void Ring(Transform parent, Material mat, Vector3 pos, float size, float life, bool ground)
	{
		ParticleSystem ps = B.NewSystem(parent, ground ? "AnelChao" : "Anel", mat, 1);
		ps.transform.localPosition = pos;
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = life;
		main.startSize = size;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.15f, 0.4f, 0.85f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f));
		if (ground)
		{
			ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
		}
	}

	// sistema em laco (nucleo do projetil)
	private static void Loop(Transform parent, string name, Material mat, int max, float life, float size, float rate, Color color, bool local)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, max);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = life;
		main.startSize = new ParticleSystem.MinMaxCurve(size * 0.8f, size * 1.2f);
		main.startColor = color;
		main.simulationSpace = local ? ParticleSystemSimulationSpace.Local : ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = rate;
		B.Burst(ps, 0f, 1);
	}

	// faiscas que ficam para tras do projetil (mundo, por distancia)
	private static void TrailSparks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Rastro", mat, 8);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.18f, 0.3f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.18f, 0.35f);
		main.startColor = Red;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 0f;
		em.rateOverDistance = 3f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = 0.12f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0f));
	}

	// arcos eletricos curtos piscando (raio horizontal em giro aleatorio); rate 0 = so um estouro de 'burst'
	private static void Crackle(Transform parent, Material mat, int max, float size, float life, float rate, Vector3 pos, float radius, bool ground = false, int burst = 0)
	{
		ParticleSystem ps = B.NewSystem(parent, "Arcos", mat, max);
		ps.transform.localPosition = pos;
		ParticleSystem.MainModule main = ps.main;
		main.loop = rate > 0f;
		main.duration = ground ? 3.3f : 1f;
		main.startLifetime = life;
		main.startSize = new ParticleSystem.MinMaxCurve(size * 0.7f, size * 1.2f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		if (ground)
		{
			main.loop = false;   // fenda: arcos so enquanto ela existe
		}
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = rate;
		if (burst > 0)
		{
			B.Burst(ps, 0f, burst);
		}
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ground ? ParticleSystemShapeType.Circle : ParticleSystemShapeType.Sphere;
		shape.radius = radius;
		if (ground)
		{
			shape.rotation = new Vector3(90f, 0f, 0f);
			ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
		}
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.6f));
	}

	// feixe: malha em cruz esticada para 10 m na frente (+Z); acende, treme e queima no dissolve
	private static void Beam(Transform parent, string name, Material mat, Mesh mesh, float width, float life)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, 1);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = life;
		main.startSize3D = true;
		main.startSizeX = width;
		main.startSizeY = width;
		main.startSizeZ = 10f;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.separateAxes = true;
		AnimationCurve thick = B.Curve(0f, 0.3f, 0.08f, 1.15f, 0.3f, 0.9f, 0.5f, 1.05f, 1f, 0.5f);
		s.x = new ParticleSystem.MinMaxCurve(1f, thick);
		s.y = new ParticleSystem.MinMaxCurve(1f, thick);
		s.z = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.2f, 0.12f, 1f, 1f, 1f));   // estica do cajado ate o fim em 0,05 s
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.55f, 0f, 1f, 1f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Mesh;
		r.mesh = mesh;
		r.alignment = ParticleSystemRenderSpace.Local;
	}

	private static void LineSparks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "FaiscasLinha", mat, 20);
		ps.transform.localPosition = new Vector3(0f, 0f, 5f);
		ParticleSystem.MainModule main = ps.main;
		main.startDelay = 0.03f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.2f, 0.45f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(1.5f, 4f);
		main.startColor = Cyan;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 20);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Box;
		shape.scale = new Vector3(0.6f, 0.4f, 10f);
		shape.randomDirectionAmount = 1f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		Stretch(ps, 0.06f, 1.5f);
	}

	// raio vertical do ceu (billboard em pe, 9 m); dois raios piscando seguidos
	private static void SkyBolt(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "RaioCeu", mat, 2);
		ps.transform.localPosition = new Vector3(0f, 4.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.16f;
		main.startSize3D = true;
		main.startSizeX = new ParticleSystem.MinMaxCurve(2f, 2.5f);
		main.startSizeY = 9f;
		main.startSizeZ = 1f;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.SetBursts(new[] { new ParticleSystem.Burst(0f, 1), new ParticleSystem.Burst(0.06f, 1) });
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
			new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(0.4f, 0.35f), new GradientAlphaKey(1f, 0.55f), new GradientAlphaKey(0f, 1f) });
		c.color = g;   // pisca: acende, apaga um pouco, acende de novo, some
		// streams obrigatorios: sem eles o avanco do corte (UV.w) vale 1 e a textura em Clamp sai inteira da particula
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.3f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.VerticalBillboard;
	}

	private static void GroundArcs(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "ArcosChao", mat, 3);
		ps.transform.localPosition = new Vector3(0f, 0.06f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.12f, 0.2f);
		main.startSize = new ParticleSystem.MinMaxCurve(1.4f, 2.2f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.SetBursts(new[] { new ParticleSystem.Burst(0f, 2), new ParticleSystem.Burst(0.08f, 1) });
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.7f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}

	private static void UpSparks(Transform parent, Material mat, int count)
	{
		ParticleSystem ps = B.NewSystem(parent, "FaiscasSobe", mat, count);
		ps.transform.localPosition = new Vector3(0f, 0.1f, 0f);
		ps.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.3f, 0.55f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(4f, 8f);
		main.startColor = Color.white;
		main.gravityModifier = 1f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, count);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 50f;
		shape.radius = 0.4f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		Stretch(ps, 0.05f, 1.5f);
	}

	// 3 arcos eletricos abrindo no chao (malha em leque), um atras do outro
	private static void FanWaves(Transform parent, Material mat, Mesh fan)
	{
		ParticleSystem ps = B.NewSystem(parent, "Ondas", mat, 3);
		ps.transform.localPosition = new Vector3(0f, 0.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.38f;
		main.startSize = 5.2f;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.SetBursts(new[] { new ParticleSystem.Burst(0f, 1), new ParticleSystem.Burst(0.07f, 1), new ParticleSystem.Burst(0.14f, 1) });
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.12f, 0.45f, 0.8f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.4f, 0f, 1f, 1f));
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Mesh;
		r.mesh = fan;
		r.alignment = ParticleSystemRenderSpace.Local;
	}

	private static void ConeSparks(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Faiscas", mat, 20);
		ps.transform.localPosition = new Vector3(0f, 0.6f, 0.5f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.25f, 0.45f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.11f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(8f, 13f);
		main.startColor = Cyan;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 20);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 55f;
		shape.radius = 0.2f;
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.08f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0.2f));
		Stretch(ps, 0.05f, 1.6f);
	}

	// disco deitado da fenda: aparece pelo dissolve, gira, segura 3 s e some
	private static void RiftDisc(Transform parent, string name, Material mat, float size, float spin, float y)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, 1);
		ps.transform.localPosition = new Vector3(0f, y, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 3.4f;
		main.startLifetime = 3.4f;
		main.startSize = size;
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.3f, 0.08f, 1.05f, 0.14f, 1f, 0.92f, 1f, 1f, 0.2f));
		if (spin != 0f)
		{
			ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
			rot.enabled = true;
			rot.z = new ParticleSystem.MinMaxCurve(spin);
		}
		C.DissolveStreams(ps, B.Curve(0f, 1f, 0.08f, 0f, 0.9f, 0f, 1f, 1f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}

	// particulas puxadas da borda para o centro, girando (mostra a fenda sugando)
	private static void Suction(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Sugadas", mat, 14);
		ps.transform.localPosition = new Vector3(0f, 0.25f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 3.1f;
		main.startLifetime = 0.7f;
		main.startSize = new ParticleSystem.MinMaxCurve(0.08f, 0.16f);
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 18f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 3.4f;
		shape.radiusThickness = 0.1f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.2f, 0.6f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.orbitalX = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.orbitalY = new ParticleSystem.MinMaxCurve(2f, 3f);
		v.orbitalZ = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.radial = new ParticleSystem.MinMaxCurve(-5.5f, -4f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.4f, 0.3f, 1f, 1f, 0f));
		Stretch(ps, 0.05f, 1.4f);
	}

	// colapso no fim da fenda (3,25 s): clarao e anel grande
	private static void Collapse(Transform parent, Material sparkMat, Material ringMat)
	{
		ParticleSystem f = B.NewSystem(parent, "Colapso", sparkMat, 1);
		f.transform.localPosition = new Vector3(0f, 0.6f, 0f);
		ParticleSystem.MainModule main = f.main;
		main.duration = 3.5f;
		main.startLifetime = 0.2f;
		main.startSize = 3.4f;
		main.startColor = Violet;
		f.emission.SetBursts(new[] { new ParticleSystem.Burst(3.25f, 1) });
		ParticleSystem.SizeOverLifetimeModule s = f.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.5f, 0.3f, 1.1f, 1f, 1.3f));
		ParticleSystem.ColorOverLifetimeModule c = f.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.2f);

		ParticleSystem r = B.NewSystem(parent, "ColapsoAnel", ringMat, 1);
		r.transform.localPosition = new Vector3(0f, 0.08f, 0f);
		ParticleSystem.MainModule rm = r.main;
		rm.duration = 3.6f;
		rm.startLifetime = 0.4f;
		rm.startSize = 8f;
		rm.startColor = Color.white;
		rm.simulationSpace = ParticleSystemSimulationSpace.Local;
		r.emission.SetBursts(new[] { new ParticleSystem.Burst(3.25f, 1) });
		ParticleSystem.SizeOverLifetimeModule rs = r.sizeOverLifetime;
		rs.enabled = true;
		rs.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.2f, 0.4f, 0.85f, 1f, 1f));
		C.DissolveStreams(r, B.Curve(0f, 0f, 0.3f, 0f, 1f, 1f));
		r.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}

	// faiscas em laco em volta do corpo (aura): gravity < 0 sobe, > 0 cai
	private static void AuraSparks(Transform parent, Material mat, int max, float gravity, Vector3 pos, float radius)
	{
		ParticleSystem ps = B.NewSystem(parent, "Faiscas", mat, max);
		ps.transform.localPosition = pos;
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.3f, 0.5f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.04f, 0.08f);
		main.startColor = Color.white;
		main.gravityModifier = -gravity;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = max * 2.2f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;
		shape.radius = radius;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 1f, 1f, 0f));
	}

	// Carga de Poder: pontos de luz girando em volta do Spark e subindo
	private static void OrbitMotes(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Pontos", mat, 10);
		ps.transform.localPosition = new Vector3(0f, -0.6f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.9f, 1.2f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.07f, 0.13f);
		main.startColor = Cyan;
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 8f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.55f;
		shape.radiusThickness = 0f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.y = new ParticleSystem.MinMaxCurve(0.9f, 1.4f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.orbitalX = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.orbitalY = new ParticleSystem.MinMaxCurve(3.5f, 4.5f);
		v.orbitalZ = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.3f, 0.2f, 1f, 0.8f, 1f, 1f, 0f));
	}

	// Pressa: linhas de vento passando pelas pernas, de frente para tras
	private static void SpeedLines(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Vento", mat, 6);
		ps.transform.localPosition = new Vector3(0f, -0.55f, 0.5f);
		ParticleSystem.MainModule main = ps.main;
		main.loop = true;
		main.duration = 1f;
		main.startLifetime = 0.18f;
		main.startSize = new ParticleSystem.MinMaxCurve(0.05f, 0.08f);
		main.startColor = new Color(0.7f, 1f, 0.9f, 0.8f);
		main.simulationSpace = ParticleSystemSimulationSpace.Local;
		ParticleSystem.EmissionModule em = ps.emission;
		em.rateOverTime = 26f;
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.4f;
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.y = new ParticleSystem.MinMaxCurve(0f, 0f);
		v.z = new ParticleSystem.MinMaxCurve(-9f, -6f);
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.3f);
		Stretch(ps, 0.05f, 2.5f);
	}
}
