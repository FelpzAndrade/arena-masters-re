using UnityEngine;

// Brilho da espada (assinatura do Cavaleiro). Muda so o _Brilho da camada "Brilho Lamina" da espada, por
// MaterialPropertyBlock (nao cria copia de material), sem luz em tempo real.
//   parado          pulso devagar (ciclo de 2 s, +-15%)
//   Pico(segundos)  sobe forte (2,6x) durante o golpe e volta ao normal em 0,3 s depois
//   ultimatePronta  brilho maximo (3,2x) ate a ultimate ser usada: da para ver de longe que ela esta pronta
public class EspadaBrilho : MonoBehaviour
{
	public Renderer lamina;
	public int indiceMaterial = 2;          // camada do brilho na lista de materiais da espada
	public float ciclo = 2f;
	public float variacao = 0.15f;
	public float forte = 2.6f;
	public float maximo = 3.2f;
	public float volta = 0.3f;
	public bool ultimatePronta;
	public GameObject avisoPronta;          // VFX_LaminaPronta (halo + faiscas fortes), ligado so com a ultimate pronta
	[Range(0f, 1f)] public float carga01;   // passiva Lamina Carregada: com mais cargas o brilho parado fica mais forte (ate 1,8x)

	private static readonly int Brilho = Shader.PropertyToID("_Brilho");
	private MaterialPropertyBlock m_mpb;
	private float m_picoAte = -99f;
	private float m_atual = 1f;

	public float Atual => m_atual;

	public void Pico(float segundos)
	{
		m_picoAte = Mathf.Max(m_picoAte, Time.time + segundos);
	}

	private void LateUpdate()
	{
		if (lamina == null)
		{
			return;
		}
		float pulso = (1f + 0.8f * carga01) * (1f + variacao * Mathf.Sin(Time.time * Mathf.PI * 2f / ciclo));
		float alvo = pulso;
		float depois = Time.time - m_picoAte;
		if (depois < 0f)
		{
			alvo = forte;
		}
		else if (depois < volta)
		{
			alvo = Mathf.Lerp(forte, pulso, depois / volta);
		}
		if (ultimatePronta)
		{
			alvo = Mathf.Max(alvo, maximo);
		}
		m_atual = alvo;
		if (avisoPronta != null && avisoPronta.activeSelf != ultimatePronta)
		{
			avisoPronta.SetActive(ultimatePronta);
		}
		m_mpb ??= new MaterialPropertyBlock();
		lamina.GetPropertyBlock(m_mpb, indiceMaterial);
		m_mpb.SetFloat(Brilho, m_atual);
		lamina.SetPropertyBlock(m_mpb, indiceMaterial);
	}
}
