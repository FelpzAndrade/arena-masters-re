using UnityEngine;

// Encolhe o RectTransform para a area segura da tela (fora do notch, da ilha da camera e das bordas arredondadas).
// Coloque num filho de tela cheia do Canvas; tudo o que for interativo fica dentro dele.
[RequireComponent(typeof(RectTransform))]
public class AreaSegura : MonoBehaviour
{
	private Rect m_aplicada;
	private Vector2Int m_tela;

	private void OnEnable()
	{
		Aplicar();
	}

	private void Update()
	{
		if (Screen.safeArea != m_aplicada || m_tela.x != Screen.width || m_tela.y != Screen.height)
		{
			Aplicar();   // girou a tela ou mudou a resolucao
		}
	}

	private void Aplicar()
	{
		Rect area = Screen.safeArea;
		m_aplicada = area;
		m_tela = new Vector2Int(Screen.width, Screen.height);
		if (Screen.width <= 0 || Screen.height <= 0)
		{
			return;
		}
		RectTransform rt = (RectTransform)transform;
		rt.anchorMin = new Vector2(area.xMin / Screen.width, area.yMin / Screen.height);
		rt.anchorMax = new Vector2(area.xMax / Screen.width, area.yMax / Screen.height);
		rt.offsetMin = rt.offsetMax = Vector2.zero;
	}
}
