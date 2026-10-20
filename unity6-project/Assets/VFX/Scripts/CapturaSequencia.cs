using System.IO;
using UnityEngine;

// Ferramenta de teste: fotografa a camera em tempos exatos (segundos reais depois de criada), de dentro do jogo.
// Feito porque o relogio do editor atrasa quando a janela do Unity esta sem foco (a foto saia depois do efeito acabar).
// Fotos em Captures/<nome>_<i>.png (pasta do projeto). Some sozinha no fim.
public class CapturaSequencia : MonoBehaviour
{
	public string nome = "captura";
	public float[] tempos = new float[0];
	public Camera cam;

	public System.Action acao;   // roda no 2o quadro (o 1o vem com o tempo do travamento de quem chamou) e zera o relogio

	private float m_t;
	private int m_i;
	private int m_quadros;

	public static CapturaSequencia Iniciar(string nome, float[] tempos, System.Action acao = null)
	{
		CapturaSequencia c = new GameObject("CapturaSequencia").AddComponent<CapturaSequencia>();
		c.nome = nome;
		c.tempos = tempos;
		c.cam = Camera.main != null ? Camera.main : Object.FindAnyObjectByType<Camera>();   // a camera da luta nao tem a tag MainCamera
		c.acao = acao;
		return c;
	}

	private void Update()
	{
		m_quadros++;
		if (m_quadros == 2)
		{
			acao?.Invoke();
			m_t = 0f;
		}
	}

	private void LateUpdate()
	{
		if (m_quadros < 2)
		{
			return;
		}
		m_t += m_quadros == 2 ? 0f : Time.unscaledDeltaTime;
		while (m_i < tempos.Length && m_t >= tempos[m_i])
		{
			Foto($"{nome}_{m_i}");
			m_i++;
		}
		if (m_i >= tempos.Length)
		{
			Destroy(gameObject);
		}
	}

	private void Foto(string arquivo)
	{
		RenderTexture rt = new RenderTexture(960, 540, 24);
		RenderTexture old = cam.targetTexture;
		cam.targetTexture = rt;
		cam.Render();
		cam.targetTexture = old;
		RenderTexture.active = rt;
		Texture2D tex = new Texture2D(960, 540, TextureFormat.RGB24, false);
		tex.ReadPixels(new Rect(0, 0, 960, 540), 0, 0);
		tex.Apply();
		RenderTexture.active = null;
		rt.Release();
		Directory.CreateDirectory("Captures");
		File.WriteAllBytes($"Captures/{arquivo}.png", tex.EncodeToPNG());
		Destroy(tex);
	}
}
