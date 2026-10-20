using TMPro;
using UnityEngine;

// Celular: 60 FPS, tela sempre acesa. Build de desenvolvimento: FPS e milissegundos por quadro no canto (media de 0,5 s,
// e o pior quadro do periodo), por cima de tudo e fora do notch. Liga sozinho no inicio do jogo (nada na cena).
public class ContadorFPS : MonoBehaviour
{
	private TextMeshProUGUI m_txt;
	private float m_tempo, m_pior;
	private int m_quadros;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void Iniciar()
	{
		if (Application.isMobilePlatform)
		{
			Application.targetFrameRate = 60;            // o padrao do celular e 30
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
		}
		if (!Debug.isDebugBuild || Application.isEditor || FindAnyObjectByType<ContadorFPS>() != null)
		{
			return;
		}
		Canvas c = new GameObject("ContadorFPS").AddComponent<Canvas>();
		c.renderMode = RenderMode.ScreenSpaceOverlay;
		c.sortingOrder = 1000;
		DontDestroyOnLoad(c.gameObject);
		RectTransform area = new GameObject("Area", typeof(RectTransform)).GetComponent<RectTransform>();
		area.SetParent(c.transform, false);
		area.anchorMin = Vector2.zero;
		area.anchorMax = Vector2.one;
		area.offsetMin = area.offsetMax = Vector2.zero;
		area.gameObject.AddComponent<AreaSegura>();
		TextMeshProUGUI t = new GameObject("Txt", typeof(RectTransform)).AddComponent<TextMeshProUGUI>();
		t.rectTransform.SetParent(area, false);
		t.rectTransform.anchorMin = t.rectTransform.anchorMax = new Vector2(0f, 0f);
		t.rectTransform.pivot = Vector2.zero;
		t.rectTransform.anchoredPosition = new Vector2(12f, 8f);
		t.rectTransform.sizeDelta = new Vector2(420f, 40f);
		t.fontSize = Mathf.Max(18f, Screen.height / 40f);
		t.outlineWidth = 0.25f;
		t.outlineColor = Color.black;
		t.raycastTarget = false;
		c.gameObject.AddComponent<ContadorFPS>().m_txt = t;
	}

	private void Update()
	{
		float dt = Time.unscaledDeltaTime;
		m_tempo += dt;
		m_quadros++;
		m_pior = Mathf.Max(m_pior, dt);
		if (m_tempo < 0.5f)
		{
			return;
		}
		float fps = m_quadros / m_tempo;
		m_txt.text = $"{fps:0} FPS  {1000f * m_tempo / m_quadros:0.0} ms  (pior {m_pior * 1000f:0} ms)";
		m_txt.color = fps >= 55f ? new Color(0.5f, 1f, 0.5f) : fps >= 30f ? new Color(1f, 0.85f, 0.3f) : new Color(1f, 0.4f, 0.35f);
		m_tempo = 0f;
		m_quadros = 0;
		m_pior = 0f;
	}
}
