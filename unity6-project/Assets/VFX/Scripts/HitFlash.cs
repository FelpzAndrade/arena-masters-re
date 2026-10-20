using UnityEngine;

// Flash branco no personagem atingido. Coloque no objeto do personagem e chame Play() no acerto.
// Usa MaterialPropertyBlock (nao cria material novo): clareia a cor e, se o shader tiver emissao, acende em branco.
// Roda em tempo real, entao aparece mesmo durante o hit stop.
public class HitFlash : MonoBehaviour
{
	public float duration = 0.1f;                    // quanto tempo o flash dura (segundos reais)
	[ColorUsage(false, true)] public Color color = Color.white;
	public float intensity = 0.45f;                  // brilho da emissao no pico (acima de ~0,7 o bloom estoura o boneco)

	private static readonly int s_color = Shader.PropertyToID("_Color");
	private static readonly int s_baseColor = Shader.PropertyToID("_BaseColor");   // URP Lit
	private static readonly int s_emission = Shader.PropertyToID("_EmissionColor");

	private Renderer[] m_renderers;
	private MaterialPropertyBlock m_block;
	private float m_left;

	// opcional: escolhe quais renderers piscam (sem isso, pega todos os filhos)
	public void Init(Renderer[] renderers)
	{
		m_renderers = renderers;
		foreach (Renderer r in renderers)
		{
			foreach (Material m in r.sharedMaterials)
			{
				if (m != null && m.HasProperty(s_emission))
				{
					m.EnableKeyword("_EMISSION");
				}
			}
		}
	}

	public void Play()
	{
		if (m_renderers == null)
		{
			Init(GetComponentsInChildren<Renderer>());
		}
		m_left = duration;
		Apply();
	}

	private void Update()
	{
		if (Application.isPlaying)
		{
			Tick(Time.unscaledDeltaTime);
		}
	}

	// fora do Play (captura em modo de edicao) quem simula chama Tick com o passo da simulacao
	public void Tick(float dt)
	{
		if (m_left <= 0f)
		{
			return;
		}
		m_left -= dt;
		Apply();
	}

	private void Apply()
	{
		m_block ??= new MaterialPropertyBlock();
		float k = Mathf.Clamp01(m_left / duration);
		k *= k;   // apaga rapido no comeco e devagar no fim
		foreach (Renderer r in m_renderers)
		{
			if (r == null)
			{
				continue;
			}
			if (k <= 0f)
			{
				r.SetPropertyBlock(null);
				continue;
			}
			Material m = r.sharedMaterial;
			m_block.Clear();
			int main = m != null && m.HasProperty(s_baseColor) ? s_baseColor : s_color;
			if (m != null && m.HasProperty(main))
			{
				m_block.SetColor(main, Color.Lerp(m.color, color, k * 0.5f));
			}
			if (m != null && m.HasProperty(s_emission))
			{
				m_block.SetColor(s_emission, color * (k * intensity));
			}
			r.SetPropertyBlock(m_block);
		}
	}
}
