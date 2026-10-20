using UnityEngine;
using UnityEngine.UI;

// Contador de combo na tela ("2 Hit"), combate_spec.md elemento 5. Coloque num objeto da cena e chame Hit() a cada acerto.
// Aparece a partir do 2o acerto, da um pulo de escala a cada acerto e zera depois de 'resetAfter' segundos sem acertar.
// Cria o proprio Canvas (tela, canto direito). Anda em tempo real (nao para no hit stop).
public class ComboCounter : MonoBehaviour
{
	public float resetAfter = 1.5f;                       // segundos sem acertar para o combo voltar a zero
	public Color color = new Color(1f, 0.8f, 0.25f);
	public Font font;

	public int Count { get; private set; }

	private Text m_text;
	private float m_idle;
	private float m_pop;

	public void Hit()
	{
		Count++;
		m_idle = 0f;
		m_pop = 1f;
		if (m_text == null)
		{
			Build();
		}
		m_text.text = Count + " <size=34>Hit</size>";
		m_text.enabled = Count >= 2;
	}

	private void Update()
	{
		if (m_text == null || Count == 0)
		{
			return;
		}
		float dt = Time.unscaledDeltaTime;
		m_idle += dt;
		if (m_idle >= resetAfter)
		{
			Count = 0;
			m_text.enabled = false;
			return;
		}
		m_pop = Mathf.Max(0f, m_pop - dt * 7f);
		m_text.transform.localScale = Vector3.one * (1f + 0.35f * m_pop * m_pop);
		Color c = color;
		c.a = Mathf.Clamp01((resetAfter - m_idle) / 0.3f);   // apaga no fim
		m_text.color = c;
	}

	private void Build()
	{
		GameObject canvasGo = new GameObject("Combo (tela)");
		canvasGo.transform.SetParent(transform, false);
		Canvas canvas = canvasGo.AddComponent<Canvas>();
		canvas.renderMode = RenderMode.ScreenSpaceOverlay;
		canvas.sortingOrder = 50;
		canvasGo.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		m_text = new GameObject("Combo").AddComponent<Text>();
		m_text.transform.SetParent(canvasGo.transform, false);
		m_text.font = font != null ? font : Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		m_text.fontSize = 56;
		m_text.fontStyle = FontStyle.BoldAndItalic;
		m_text.alignment = TextAnchor.MiddleRight;
		m_text.supportRichText = true;
		m_text.horizontalOverflow = HorizontalWrapMode.Overflow;
		Outline outline = m_text.gameObject.AddComponent<Outline>();
		outline.effectColor = new Color(0.1f, 0.05f, 0.02f, 0.9f);
		outline.effectDistance = new Vector2(2.5f, -2.5f);
		RectTransform rt = m_text.rectTransform;
		rt.anchorMin = rt.anchorMax = new Vector2(0.92f, 0.62f);
		rt.pivot = new Vector2(1f, 0.5f);
		rt.sizeDelta = new Vector2(400f, 90f);
		m_text.enabled = false;
	}
}
