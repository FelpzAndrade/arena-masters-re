using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Botao redondo de skill para tela de toque (reutilizavel, nao conhece o combate: quem usa liga os eventos).
//   toque rapido           aoTocar()               (quem usa mira sozinho, ex.: no inimigo mais perto)
//   segurar / arrastar     aoMirar(direcao)        a cada movimento; direcao na tela, comprimento 0..1 (1 = borda da area de mira)
//   soltar depois de mirar aoSoltar(direcao)       dispara na direcao mirada
//   arrastar de volta para o botao cancela (aoCancelar)
// Visual: fundo na cor da skill, icone, preenchimento radial escuro da recarga com os segundos no meio,
// anel opcional em volta (barra da ultimate) que brilha quando cheio.
public class BotaoSkill : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
	public Image fundo;
	public Image icone;
	public Image recarga;          // Filled Radial360, escuro por cima
	public TMP_Text segundos;
	public Image anel;             // opcional: Filled Radial360 em volta (carga da ultimate)
	public Image brilho;           // opcional: pulsa quando o anel enche
	public bool podeMirar = true;  // false = so toque (ataque basico, esquiva)
	public float raioMira = 140f;  // pixels de arrasto (na escala do Canvas) para a mira chegar na borda

	public System.Action aoTocar;
	public System.Action<Vector2> aoMirar;
	public System.Action<Vector2> aoSoltar;
	public System.Action aoCancelar;

	public bool Mirando { get; private set; }

	private const float TempoSegurar = 0.18f;   // segurar mais que isso (ou arrastar) entra na mira
	private int m_dedo = int.MinValue;
	private Vector2 m_inicio;
	private float m_desde;
	private Vector2 m_dir;
	private float m_maiorArrasto;
	private bool m_vazio;
	private float m_escalaCanvas = 1f;

	public void Configurar(Color cor, Sprite simbolo, bool vazio)
	{
		m_vazio = vazio;
		fundo.color = vazio ? new Color(0.15f, 0.15f, 0.18f, 0.55f) : new Color(cor.r * 0.55f, cor.g * 0.55f, cor.b * 0.55f, 0.9f);
		if (icone != null)
		{
			icone.sprite = simbolo;
			icone.color = vazio ? new Color(1f, 1f, 1f, 0.25f) : Color.white;
		}
	}

	// proporcao 0..1 da recarga que falta e os segundos (0 = pronto)
	public void Recarga(float proporcao, float seg)
	{
		if (recarga != null)
		{
			recarga.fillAmount = m_vazio ? 0f : proporcao;
		}
		if (segundos != null)
		{
			segundos.text = !m_vazio && seg > 0.05f ? (seg >= 1f ? Mathf.CeilToInt(seg).ToString() : seg.ToString("0.0")) : string.Empty;
		}
	}

	// anel em volta (ultimate): 0..1; cheio = pulsa o brilho
	public void Carga(float proporcao, bool cheia)
	{
		if (anel != null)
		{
			anel.fillAmount = proporcao;
			anel.color = cheia ? new Color(1f, 0.85f, 0.35f) : new Color(0.75f, 0.55f, 1f, 0.9f);
		}
		if (brilho != null)
		{
			brilho.enabled = cheia;
			float p = 0.55f + 0.45f * Mathf.Sin(Time.unscaledTime * 6f);
			brilho.color = new Color(1f, 0.8f, 0.35f, 0.65f * p);
			brilho.rectTransform.localScale = Vector3.one * (1.05f + 0.08f * p);
		}
	}

	public void OnPointerDown(PointerEventData e)
	{
		if (m_dedo != int.MinValue || m_vazio)
		{
			return;
		}
		m_dedo = e.pointerId;
		m_inicio = e.position;
		m_desde = Time.unscaledTime;
		m_dir = Vector2.zero;
		m_maiorArrasto = 0f;
		Mirando = false;
		Canvas c = GetComponentInParent<Canvas>();
		m_escalaCanvas = c != null ? c.scaleFactor : 1f;
		transform.localScale = Vector3.one * 0.92f;
	}

	public void OnDrag(PointerEventData e)
	{
		if (e.pointerId != m_dedo || !podeMirar)
		{
			return;
		}
		Vector2 d = (e.position - m_inicio) / (raioMira * m_escalaCanvas);
		m_maiorArrasto = Mathf.Max(m_maiorArrasto, d.magnitude);
		if (!Mirando && d.magnitude > 0.15f)
		{
			Mirando = true;
		}
		if (Mirando)
		{
			m_dir = Vector2.ClampMagnitude(d, 1f);
			aoMirar?.Invoke(m_dir);
		}
	}

	private void Update()
	{
		// segurar parado tambem mostra a mira (na frente do heroi ate arrastar)
		if (m_dedo != int.MinValue && podeMirar && !Mirando && Time.unscaledTime - m_desde > TempoSegurar)
		{
			Mirando = true;
			aoMirar?.Invoke(m_dir);
		}
	}

	public void OnPointerUp(PointerEventData e)
	{
		if (e.pointerId != m_dedo)
		{
			return;
		}
		m_dedo = int.MinValue;
		transform.localScale = Vector3.one;
		if (!Mirando)
		{
			aoTocar?.Invoke();
			return;
		}
		Mirando = false;
		// arrastou para fora e voltou o dedo para cima do botao: cancela
		if (m_maiorArrasto > 0.6f && RectTransformUtility.RectangleContainsScreenPoint((RectTransform)transform, e.position, e.pressEventCamera))
		{
			aoCancelar?.Invoke();
			return;
		}
		aoSoltar?.Invoke(m_dir);
	}
}
