using UnityEditor;
using UnityEngine;
using B = VfxMachadoBuilder;
using C = VfxCornetaBuilder;

// Monta os efeitos da esquiva (os dois herois) so com Particle System + shaders proprios.
// Menu: Arena Masters/VFX/Montar Esquiva. Precisa do M_PoeiraTerra (Montar Golpe da Terra antes).
//   Resources/M_Fantasma         material das imagens fantasma (shader ArenaMasters/VFX/Fantasma); o jogo copia a malha
//                                do boneco 3 vezes durante a corrida da esquiva (Vfx.Afterimage) e cada copia some em 0,3 s
//   Resources/VFX_EsquivaPoeira  poeira chutada para tras na saida e no pouso, com um anel fraco no chao
// Particulas vivas no maximo: 7 + 1 = 8 por poeira (saida + pouso = 16).
public static class VfxEsquivaBuilder
{
	private const string Root = "Assets/VFX";

	[MenuItem("Arena Masters/VFX/Montar Esquiva")]
	public static void Build()
	{
		Shader ghost = Shader.Find("ArenaMasters/VFX/Fantasma");
		Material dust = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_PoeiraTerra.mat");
		Material wave = AssetDatabase.LoadAssetAtPath<Material>(Root + "/Materials/M_OndaTerra.mat");
		if (ghost == null || dust == null || wave == null)
		{
			Debug.LogError("[VFX] faltam o shader Fantasma ou os materiais do Golpe da Terra");
			return;
		}
		Material ghostMat = new Material(ghost);
		ghostMat.SetFloat("_Base", 0.04f);       // meio quase apagado: so o contorno marca a silhueta
		ghostMat.SetFloat("_RimPower", 2f);
		B.SaveAsset(ghostMat, Root + "/Resources/M_Fantasma.mat");

		GameObject go = new GameObject("VFX_EsquivaPoeira");
		Kick(go.transform, dust);
		Ring(go.transform, wave);
		B.SavePrefab(go, Root + "/Resources/VFX_EsquivaPoeira.prefab");

		AssetDatabase.SaveAssets();
		Debug.Log("[VFX] Esquiva montada: M_Fantasma e VFX_EsquivaPoeira");
	}

	// poeira saindo para tras (-Z) rente ao chao; o prefab nasce nos pes virado para onde o heroi corre
	private static void Kick(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Poeira", mat, 7);
		ps.transform.localPosition = new Vector3(0f, 0.35f, -0.2f);
		ParticleSystem.MainModule main = ps.main;
		main.duration = 0.8f;
		main.startLifetime = new ParticleSystem.MinMaxCurve(0.45f, 0.75f);
		main.startSize = new ParticleSystem.MinMaxCurve(0.45f, 0.75f);
		main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
		main.startColor = new Color(1f, 1f, 1f, 0.7f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 7);
		ParticleSystem.ShapeModule shape = ps.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Circle;
		shape.radius = 0.3f;
		shape.rotation = new Vector3(90f, 0f, 0f);
		ParticleSystem.VelocityOverLifetimeModule v = ps.velocityOverLifetime;
		v.enabled = true;
		v.space = ParticleSystemSimulationSpace.Local;
		v.x = new ParticleSystem.MinMaxCurve(-0.8f, 0.8f);   // os 3 eixos precisam do mesmo modo de curva
		v.y = new ParticleSystem.MinMaxCurve(0.3f, 0.9f);
		v.z = new ParticleSystem.MinMaxCurve(-3.5f, -1.5f);
		ParticleSystem.LimitVelocityOverLifetimeModule lim = ps.limitVelocityOverLifetime;
		lim.enabled = true;
		lim.limit = 0f;
		lim.dampen = 0.15f;
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.5f, 0.3f, 1.1f, 1f, 1.6f));
		ParticleSystem.ColorOverLifetimeModule c = ps.colorOverLifetime;
		c.enabled = true;
		c.color = B.Fade(Color.white, 0.4f);
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.4f, 0f, 1f, 1f));
	}

	private static void Ring(Transform parent, Material mat)
	{
		ParticleSystem ps = B.NewSystem(parent, "Anel", mat, 1);
		ps.transform.localPosition = new Vector3(0f, 0.04f, 0f);
		ParticleSystem.MainModule main = ps.main;
		main.startLifetime = 0.3f;
		main.startSize = 1.8f;
		main.startColor = new Color(1f, 1f, 1f, 0.45f);
		main.simulationSpace = ParticleSystemSimulationSpace.World;
		B.Burst(ps, 0f, 1);
		ParticleSystem.SizeOverLifetimeModule s = ps.sizeOverLifetime;
		s.enabled = true;
		s.size = new ParticleSystem.MinMaxCurve(1f, B.Curve(0f, 0.3f, 1f, 1f));
		C.DissolveStreams(ps, B.Curve(0f, 0f, 0.4f, 0f, 1f, 1f));
		ps.GetComponent<ParticleSystemRenderer>().renderMode = ParticleSystemRenderMode.HorizontalBillboard;
	}
}
