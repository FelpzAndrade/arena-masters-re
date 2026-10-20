using UnityEngine;

// Linha do tempo da Skill B (esfera giratoria, Docs/ficha_skills_referencia.md), reutilizavel em qualquer heroi.
// Coloque no heroi, ajuste cor/escala/altura e chame Iniciar(direcao) quando o botao for apertado.
//   0 s           corte de entrada (quem chama dispara no OnImpacto da animacao: CorteEntrada())
//   +atraso       a esfera surge ja cheia, presa no heroi, e o heroi avanca 'distancia' metros girando
//   +atraso+0,75  some seco (o prefab corta em 0,07 s); o heroi ja pode agir
// Os efeitos sao os prefabs VFX_EsferaGiratoria e VFX_CorteEntrada (Assets/VFX/Resources), pintados por EfeitoCor.
public class SkillEsferaGiratoria : MonoBehaviour
{
	[ColorUsage(false, true)] public Color cor = new Color(0.04f, 0.4f, 1f);   // azul saturado (componentes baixos = cor forte depois do tonemapping)
	public float escala = 1f;            // tamanho do efeito (1 = heroi de ~1,8 m)
	public float alturaCentro = 0.95f;   // altura do centro do corpo (onde a esfera fica)
	public float atraso = 0.2f;          // segundos entre apertar o botao e a esfera aparecer
	public float duracao = 0.75f;        // tempo da esfera na tela
	public float distancia = 4.5f;       // quanto o heroi avanca durante a esfera (na direcao da mira)
	public float raioAcerto = 1.3f;      // raio da esfera (x escala): quem estiver dentro dela no caminho leva o acerto

	public Vector3 Centro => transform.position + Vector3.up * alturaCentro;
	public float Raio => raioAcerto * escala;

	public bool Ativa => m_tempo >= 0f && m_tempo < atraso + duracao;
	public bool EsferaNaTela => m_tempo >= atraso && m_tempo < atraso + duracao;

	private float m_tempo = -1f;
	private Vector3 m_direcao;
	private bool m_esferaCriada;
	private int m_fantasmas;
	private static GameObject s_esfera, s_corte;

	public void Iniciar(Vector3 direcao)
	{
		direcao.y = 0f;
		m_direcao = direcao.sqrMagnitude > 0.001f ? direcao.normalized : transform.forward;
		m_tempo = 0f;
		m_esferaCriada = false;
		m_fantasmas = 0;
	}

	// corte de entrada na frente do heroi (chamar no OnImpacto do golpe de entrada)
	public void CorteEntrada()
	{
		s_corte ??= Resources.Load<GameObject>("VFX_CorteEntrada");
		if (s_corte != null)
		{
			Vector3 pos = transform.position + Vector3.up * alturaCentro * 0.9f;
			EfeitoCor.Criar(s_corte, pos, Quaternion.LookRotation(m_direcao.sqrMagnitude > 0f ? m_direcao : transform.forward) * Quaternion.Euler(0f, 0f, 18f), null, cor, escala * 0.8f, 0.8f);   // arco quase deitado: legivel de cima
		}
	}

	private void Update()
	{
		if (m_tempo < 0f)
		{
			return;
		}
		float dt = Time.deltaTime;   // o avanco congela no hit stop (como o resto do jogo); o efeito anda em tempo real
		m_tempo += dt;
		if (!m_esferaCriada && m_tempo >= atraso)
		{
			m_esferaCriada = true;
			s_esfera ??= Resources.Load<GameObject>("VFX_EsferaGiratoria");
			if (s_esfera != null)
			{
				GameObject go = EfeitoCor.Criar(s_esfera, transform.position + Vector3.up * alturaCentro, Quaternion.identity, transform, cor, escala, duracao + 0.6f);   // +0,6: o rastro no chao termina de sumir
				go.transform.localScale = Vector3.one * escala / Mathf.Max(0.001f, transform.lossyScale.x);
				Transform chao = go.transform.Find("Chao");
				if (chao != null)
				{
					chao.position = new Vector3(chao.position.x, transform.position.y + 0.04f, chao.position.z);   // brilho, rastro e poeira no piso
				}
			}
		}
		if (EsferaNaTela)
		{
			transform.position += m_direcao * (distancia / duracao) * dt;
			// silhuetas translucidas do heroi no caminho (Vfx.Afterimage, o mesmo da esquiva): 3, sumindo em 0,3 s
			while (m_fantasmas < 3 && m_tempo >= atraso + duracao * (0.2f + 0.25f * m_fantasmas))
			{
				m_fantasmas++;
				Vfx.Afterimage(transform, Color.Lerp(cor, Color.white, 0.45f) * 3f, 0.3f);   // claro: aparece atraves dos aneis
			}
		}
		if (m_tempo >= atraso + duracao)
		{
			m_tempo = -1f;
		}
	}
}
