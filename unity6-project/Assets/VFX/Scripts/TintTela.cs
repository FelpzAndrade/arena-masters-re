using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Tela inteira tingida (ultimate, Docs/ficha_skills_referencia.md, Skill A): um Volume global de prioridade alta com
// Color Adjustments (filtro de cor + leve escurecida) cujo peso sobe aos poucos e cai de uma vez.
// Uso: TintTela.Tocar(cor, subida, segura). Reutilizavel em qualquer heroi (so troca a cor). Anda em tempo real.
public class TintTela : MonoBehaviour
{
	private static TintTela s_instancia;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]   // inicio de cada Play (vale com o recarregamento de codigo desligado)
	private static void Zerar() => s_instancia = null;

	private Volume m_volume;
	private ColorAdjustments m_cor;
	private float m_t = -1f, m_subida, m_segura, m_queda;

	// subida: segundos ate o pico; segura: segundos no pico (contando da subida); queda: segundos para sumir (curto = "de uma vez")
	public static void Tocar(Color cor, float subida = 0.3f, float segura = 0.6f, float queda = 0.06f)
	{
		if (s_instancia == null)
		{
			s_instancia = new GameObject("TintTela").AddComponent<TintTela>();
		}
		s_instancia.Iniciar(cor, subida, segura, queda);
	}

	private void Iniciar(Color cor, float subida, float segura, float queda)
	{
		if (m_volume == null)
		{
			VolumeProfile profile = ScriptableObject.CreateInstance<VolumeProfile>();
			m_cor = profile.Add<ColorAdjustments>(true);
			m_volume = gameObject.AddComponent<Volume>();
			m_volume.isGlobal = true;
			m_volume.priority = 50f;   // acima do pos-processamento da arena (prioridade 1)
			m_volume.sharedProfile = profile;
		}
		// filtro: puxa tudo para a cor (multiplica); um pouco de saturacao e escurecida dao o "peso" do golpe
		// o vermelho do filtro e cortado pela metade: o chao quente da arena ja e avermelhado e puxaria o roxo para magenta
		Color filtro = Color.Lerp(Color.white, new Color(cor.r * 0.8f, cor.g * 1.5f, cor.b * 1.6f), 0.85f);
		m_cor.colorFilter.Override(filtro);
		m_cor.saturation.Override(25f);
		m_cor.contrast.Override(18f);
		m_cor.postExposure.Override(1.1f);   // a arena usa +1,4: o tingido escurece um pouco a tela
		m_subida = subida;
		m_segura = segura;
		m_queda = queda;
		m_t = 0f;
		m_volume.weight = 0f;
	}

	private void Update()
	{
		if (m_t < 0f)
		{
			return;
		}
		m_t += Time.unscaledDeltaTime;
		float w;
		if (m_t < m_subida)
		{
			float k = m_t / m_subida;
			w = k * k;                                         // comeca devagar e acelera ate o pico
		}
		else if (m_t < m_subida + m_segura)
		{
			w = 1f;
		}
		else
		{
			w = 1f - Mathf.Clamp01((m_t - m_subida - m_segura) / m_queda);
			if (w <= 0f)
			{
				m_t = -1f;
			}
		}
		m_volume.weight = w;
	}
}
