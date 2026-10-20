using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;
using C = VfxCornetaBuilder;

// Monta os efeitos do Divisor de Terra (ultimate do Axie) so com Particle System + shader proprio.
// Menu: Arena Masters/VFX/Montar Divisor de Terra. Precisa dos materiais do Golpe da Terra (Montar Golpe da Terra antes).
//   Resources/VFX_DivisorTrecho  um trecho da onda de choque (o jogo solta um a cada 1,6 m, em sequencia, ao longo da linha):
//                                rachadura com lava, brilho, poeira, pedrinhas e brasas
//   Resources/M_PilarPedra       malha da pedra pontuda que sobe do chao (obstaculo da muralha; pivo na base, 1 m de altura)
// Particulas vivas no maximo: 6 trechos x (1 + 1 + 5 + 3 + 3) = 78.
public static class VfxDivisorBuilder
{
	private const string Root = "Assets/VFX";
	private static readonly Color Lava = new Color(1f, 0.55f, 0.2f);

	[MenuItem("Arena Masters/VFX/Montar Divisor de Terra")]
	public static void Build()
	{
		Material crack = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_RachaduraTerra.mat");
		Material glow = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_BrilhoTerra.mat");
		Material dust = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_PoeiraTerra.mat");
		Material rock = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_PedraTerra.mat");
		Material spark = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_FaiscaTerra.mat");
		if (crack == null || glow == null || dust == null || rock == null || spark == null)
		{
			Debug.LogError("[VFX] faltam os materiais do Golpe da Terra (menu Arena Masters/VFX/Montar Golpe da Terra)");
			return;
		}
		B.SaveAsset(BuildPillar(), Root + "/Resources/M_PilarPedra.asset");

		GameObject seg = new GameObject("VFX_DivisorTrecho");
		Ground(seg.transform, "Rachadura", crack, 1.6f, 4f, 0.03f, true);      // maior que a pedra: rachaduras saem por baixo dela
		Ground(seg.transform, "Brilho", glow, 0.7f, 4f, 0.05f, false);
		Dust(seg.transform, dust);
		Chips(seg.transform, rock);
		Embers(seg.transform, spark);
		B.SavePrefab(seg, Root + "/Resources/VFX_DivisorTrecho.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Divisor de Terra montado: VFX_DivisorTrecho e M_PilarPedra");
	}

	// pedra pontuda facetada: aneis irregulares que afinam ate uma ponta torta (normais por face = visual low-poly)
	private static Mesh BuildPillar()
	{
		System.Random rng = new System.Random(5);
		float R(float a, float b) => a + (float)rng.NextDouble() * (b - a);
		const int n = 7;
		float[] heights = { -0.15f, 0.45f, 0.8f };
		float[] radii = { 0.5f, 0.4f, 0.2f };
		List<Vector3[]> rings = new List<Vector3[]>();
		for (int k = 0; k < heights.Length; k++)
		{
			Vector3[] ring = new Vector3[n];
			Vector2 shift = new Vector2(R(-0.06f, 0.06f), R(-0.06f, 0.06f)) * k;
			for (int i = 0; i < n; i++)
			{
				float a = (i + R(-0.2f, 0.2f)) * Mathf.PI * 2f / n;
				float r = radii[k] * R(0.8f, 1.15f);
				ring[i] = new Vector3(Mathf.Cos(a) * r + shift.x, heights[k] + R(-0.05f, 0.05f), Mathf.Sin(a) * r + shift.y);
			}
			rings.Add(ring);
		}
		Vector3 apex = new Vector3(R(-0.1f, 0.1f), 1f, R(-0.1f, 0.1f));
		List<Vector3> verts = new List<Vector3>();
		List<int> tris = new List<int>();
		void Tri(Vector3 a, Vector3 b, Vector3 c)
		{
			tris.Add(verts.Count); verts.Add(a);
			tris.Add(verts.Count); verts.Add(b);
			tris.Add(verts.Count); verts.Add(c);
		}
		for (int k = 0; k + 1 < rings.Count; k++)
		{
			for (int i = 0; i < n; i++)
			{
				int j = (i + 1) % n;
				Tri(rings[k][i], rings[k + 1][i], rings[k][j]);
				Tri(rings[k][j], rings[k + 1][i], rings[k + 1][j]);
			}
		}
		Vector3[] top = rings[rings.Count - 1];
		for (int i = 0; i < n; i++)
		{
			Tri(top[i], apex, top[(i + 1) % n]);
		}
		Mesh mesh = new Mesh { name = "M_PilarPedra" };
		mesh.SetVertices(verts);
		mesh.SetTriangles(tris, 0);
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();
		return mesh;
	}

	private static void Ground(Transform parent, string name, Material mat, float life, float size, float y, bool cools)
	{
		ParticleSystem ps = B.NewSystem(parent, name, mat, 1);
		ps.transform.localPosition = new Vector3(0f, y, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = life;
		main.startLifetime = life;
		main.startSize = new ParticleSystem.MinMaxCurve(size * 0.85f, size * 1.15f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);   // cada trecho com rachaduras diferentes
		main.startColor = Color.white;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 1);
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.7f, 0.06f, 1f, 1f, 1f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		if (cools)
		{
			// lava esfria: miolo apaga, a terra rachada fica e se desfaz no dissolve
			Gradient g = new Gradient();
			g.SetKeys(
				new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(new Color(0.45f, 0.3f, 0.25f), 0.25f), new GradientColorKey(new Color(0.15f, 0.12f, 0.1f), 0.5f) },
				new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) });
			c.color = g;
			C.DissolveStreams(ps, B.Curve(0f, 0.4f, 0.05f, 0f, 0.6f, 0f, 1f, 1f));
		}
		else
		{
			c.color = B.Fade(Color.white, 0.15f);
			C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0.5f));
		}
	}

	private static void Dust(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Poeira", mat, 5);
		ps.transform.localPosition = new Vector3(0f, 0.5f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 1.4f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.8f, 1.2f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.7f, 1.1f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(1.5f, 3f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.75f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 5);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.4f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.12f;
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.World;
		v.x = new ParticleSystem.MinMaxCurve(0f, 0f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.6f, 1.1f);
		v.z = new ParticleSystem.MinMaxCurve(0f, 0f);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.6f, 0.3f, 1.2f, 1f, 1.8f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.6f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.35f, 0f, 1f, 1f));
	}

	private static void Chips(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Pedras", mat, 3);
		ps.transform.localPosition = new Vector3(0f, 0.1f, 0f);
		ps.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);   // cone para cima
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.7f, 1f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.2f, 0.4f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(4f, 7f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.gravityModifier = 1.6f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 3);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 35f;
		shape.radius = 0.4f;
		ParticleSystem.RotationOverLifetimeModule rot = ps.rotationOverLifetime;
		rot.enabled = true;
		rot.z = new ParticleSystem.MinMaxCurve(-9f, 9f);
		ParticleSystem.TextureSheetAnimationModule sheet = ps.textureSheetAnimation;
		sheet.enabled = true;
		sheet.numTilesX = 2;
		sheet.numTilesY = 2;
		sheet.frameOverTime = new ParticleSystem.MinMaxCurve(0f, 0.999f);   // sorteia uma das 4 pedras e fica nela
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.85f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 1f, 0f));
	}

	private static void Embers(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Brasas", mat, 3);
		ps.transform.localPosition = new Vector3(0f, 0.1f, 0f);
		ps.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.4f, 0.7f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.06f, 0.11f);
		main.startSpeed = new ParticleSystem.MinMaxCurve(3f, 6f);
		main.startColor = Lava;
		main.gravityModifier = 0.8f;
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 3);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Cone;
		shape.angle = 45f;
		shape.radius = 0.3f;
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.5f);
		ParticleSystemRenderer r = ps.GetComponent<ParticleSystemRenderer>();
		r.renderMode = ParticleSystemRenderMode.Stretch;
		r.velocityScale = 0.05f;
		r.lengthScale = 1.5f;
	}
}
