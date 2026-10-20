using UnityEngine;

// Luz que pisca nos braseiros. A luz quente "de verdade" das tochas esta no lightmap (e nos Light Probes, para os herois);
// aqui ficam so 3 luzes pequenas em tempo real, levadas para as tochas mais perto do ponto que a camera olha,
// para o fogo tremer na parede e no heroi. No celular, mais que 4 luzes em tempo real na tela pesa.
// Criado pelo menu Arena Masters/Mapa/Salvar arena e fazer bake (guarda a posicao das chamas).
public class LuzesBraseiros : MonoBehaviour
{
	public Vector3[] chamas = new Vector3[0];   // posicao da chama de cada tocha (mundo)
	public int maximo = 3;                      // + a direcional da sombra dos herois = 4 luzes em tempo real
	public float alcance = 6f;
	public float intensidade = 1.6f;
	public Color cor = new Color(1f, 0.55f, 0.25f);
	public Transform poeira;                    // poeira no ar (VFX_PoeiraAr): acompanha o ponto que a camera olha

	private static Vector3 s_focus;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]   // inicio de cada Play (vale com o recarregamento de codigo desligado)
	private static void Zerar() => s_focus = Vector3.zero;
	private Light[] m_lights;
	private float[] m_seed;

	// BattleManager passa o ponto que a camera olha a cada quadro
	public static void SetFocus(Vector3 focus)
	{
		s_focus = focus;
	}

	private void Start()
	{
		m_lights = new Light[maximo];
		m_seed = new float[maximo];
		for (int i = 0; i < maximo; i++)
		{
			Light l = new GameObject("luz_braseiro_" + i).AddComponent<Light>();
			l.transform.SetParent(transform, false);
			l.type = LightType.Point;
			l.color = cor;
			l.range = alcance;
			l.shadows = LightShadows.None;
			l.lightmapBakeType = LightmapBakeType.Realtime;
			l.enabled = false;
			m_lights[i] = l;
			m_seed[i] = i * 13.7f;
		}
	}

	private void LateUpdate()
	{
		if (poeira != null && s_focus != Vector3.zero)
		{
			poeira.position = s_focus;
		}
		if (chamas.Length == 0)
		{
			return;
		}
		// as 'maximo' chamas mais perto do foco (selecao simples: poucas tochas)
		int[] best = new int[maximo];
		float[] bestD = new float[maximo];
		for (int k = 0; k < maximo; k++)
		{
			best[k] = -1;
			bestD[k] = float.MaxValue;
		}
		for (int i = 0; i < chamas.Length; i++)
		{
			Vector3 d = chamas[i] - s_focus;
			d.y *= 2f;   // tocha de outro andar conta como mais longe
			float dist = d.sqrMagnitude;
			for (int k = 0; k < maximo; k++)
			{
				if (dist < bestD[k])
				{
					for (int j = maximo - 1; j > k; j--)
					{
						best[j] = best[j - 1];
						bestD[j] = bestD[j - 1];
					}
					best[k] = i;
					bestD[k] = dist;
					break;
				}
			}
		}
		float t = Time.time;
		for (int k = 0; k < maximo; k++)
		{
			Light l = m_lights[k];
			bool on = best[k] >= 0 && bestD[k] < 22f * 22f;
			l.enabled = on;
			if (!on)
			{
				continue;
			}
			int i = best[k];
			l.transform.position = chamas[i];
			// tremor de fogo: dois ruidos (lento + rapido), cada tocha com seu proprio desenho
			float n = Mathf.PerlinNoise(t * 2.1f + i * 3.3f, m_seed[k]) * 0.65f + Mathf.PerlinNoise(t * 9f + i, m_seed[k] + 5f) * 0.35f;
			l.intensity = intensidade * (0.75f + 0.5f * n);
		}
	}
}
