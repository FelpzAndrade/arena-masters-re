using System;
using UnityEngine;

// Linha do tempo da Skill A (explosao com tela tingida e 2a onda, Docs/ficha_skills_referencia.md), reutilizavel como
// ultimate de qualquer heroi: so troca cor, animacao e o tempo do impacto do clipe.
// Coloque no heroi e chame Iniciar(alvo) junto com a animacao; chame Impacto() no OnImpacto do clipe.
//   0             avanca ate o alvo; brilho branco curto na mao
//   impacto-0,3   a tela tinge (TintTela) subindo ate o pico no impacto
//   impacto-0,15  raio desce sobre o alvo
//   impacto       massa escura + onda + estilhacos (quem chama faz o game feel e o dano: aoImpacto)
//   impacto+0,6   a cor da tela some de uma vez
//   impacto+1,0   2a onda: 'explosoes' explosoes em sequencia em volta do alvo (aoExplosao em cada uma)
//   impacto+1,4   fumaca residual se desfazendo devagar, com brasas
// Prefabs em Assets/VFX/Resources (Arena Masters/VFX/Montar Skill A (explosao)), pintados por EfeitoCor.
public class SkillUltimateExplosao : MonoBehaviour
{
	[ColorUsage(false, true)] public Color cor = new Color(0.55f, 0.12f, 1f);   // roxo arcano
	[ColorUsage(false, true)] public Color corExplosao = new Color(1f, 0.15f, 0.7f);   // magenta da 2a onda
	public float tempoImpacto = 1.27f;   // segundos do inicio do clipe ate o OnImpacto (Aj_GolpeChao: quadro 38)
	public float distanciaAlvo = 1.4f;   // para de avancar a esta distancia do alvo
	public float raioArea = 3.2f;        // onde caem as explosoes da 2a onda
	public int explosoes = 5;
	public float escala = 1f;
	public Transform mao;                // brilho de carga (opcional)
	public bool impactoPeloRelogio;      // true = impacto em tempoImpacto sem esperar o OnImpacto (heroi sem esse evento)
	public bool moverHeroi = true;       // false = quem chama vira e aproxima o heroi (na luta, o Fighter: SkillDef.dashStop)

	public Action<Vector3> aoImpacto;    // posicao do impacto
	public Action<Vector3> aoExplosao;   // posicao de cada explosao da 2a onda

	public bool Ativa => m_t >= 0f;

	private float m_t = -1f;
	private float m_tImpacto = -1f;
	private Vector3 m_alvo;
	private bool m_carga, m_tinta, m_raio, m_fumaca;
	private int m_explodidas;
	private Vector3[] m_pontos = new Vector3[0];

	public void Iniciar(Vector3 alvo)
	{
		m_alvo = alvo;
		m_alvo.y = transform.position.y;
		m_t = 0f;
		m_tImpacto = -1f;
		m_carga = m_tinta = m_raio = m_fumaca = false;
		m_explodidas = 0;
		Vector3 d = m_alvo - transform.position;
		if (moverHeroi && d.sqrMagnitude > 0.01f)
		{
			transform.rotation = Quaternion.LookRotation(d);
		}
		// pontos da 2a onda: espalhados num anel em volta do alvo, angulos embaralhados
		m_pontos = new Vector3[explosoes];
		float a0 = UnityEngine.Random.value * Mathf.PI * 2f;
		for (int i = 0; i < explosoes; i++)
		{
			float a = a0 + i * Mathf.PI * 2f / explosoes + UnityEngine.Random.Range(-0.4f, 0.4f);
			float r = raioArea * UnityEngine.Random.Range(0.35f, 1f);
			m_pontos[i] = m_alvo + new Vector3(Mathf.Cos(a), 0f, Mathf.Sin(a)) * r;
		}
	}

	// chamar no OnImpacto da animacao
	public void Impacto()
	{
		if (m_t < 0f || m_tImpacto >= 0f)
		{
			return;
		}
		m_tImpacto = 0f;
		Criar("VFX_UltImpacto", m_alvo, cor, 1.6f);
		aoImpacto?.Invoke(m_alvo);
	}

	private void Update()
	{
		if (m_t < 0f)
		{
			return;
		}
		float dt = Time.deltaTime;          // avanco congela no hit stop, como o resto do jogo
		float real = Time.unscaledDeltaTime; // a sequencia de efeitos anda em tempo real
		m_t += real;

		// aproximacao: chega perto do alvo um pouco antes do golpe descer
		Vector3 d = m_alvo - transform.position;
		d.y = 0f;
		float falta = d.magnitude - distanciaAlvo * escala;
		if (moverHeroi && m_tImpacto < 0f && falta > 0.02f && m_t < tempoImpacto - 0.35f)
		{
			float vel = Mathf.Max(3f, falta / Mathf.Max(0.1f, tempoImpacto - 0.35f - m_t));
			transform.position += d.normalized * Mathf.Min(falta, vel * dt);
		}
		if (!m_carga && m_t >= 0.1f)
		{
			m_carga = true;
			Criar("VFX_UltCarga", mao != null ? mao.position : transform.position + Vector3.up * 1.2f, Color.white, 0.4f, mao);
		}
		if (!m_tinta && m_t >= tempoImpacto - 0.3f)
		{
			m_tinta = true;
			TintTela.Tocar(cor, 0.3f, 0.6f, 0.06f);
		}
		if (!m_raio && m_t >= tempoImpacto - 0.15f)
		{
			m_raio = true;
			Criar("VFX_UltRaio", m_alvo, Color.Lerp(cor, corExplosao, 0.4f), 0.5f);
		}
		if (m_tImpacto < 0f)
		{
			if (m_t > tempoImpacto + (impactoPeloRelogio ? 0f : 0.5f))
			{
				Impacto();   // sem evento na animacao: impacto pelo relogio
			}
			return;
		}
		m_tImpacto += real;
		while (m_explodidas < m_pontos.Length && m_tImpacto >= 1.0f + m_explodidas * 0.12f)
		{
			Vector3 p = m_pontos[m_explodidas++];
			Criar("VFX_UltExplosao", p, corExplosao, 1f);
			aoExplosao?.Invoke(p);
		}
		if (!m_fumaca && m_tImpacto >= 1.4f)
		{
			m_fumaca = true;
			Criar("VFX_UltFumaca", m_alvo, cor, 2.6f);
		}
		if (m_tImpacto >= 2.8f)
		{
			m_t = -1f;
		}
	}

	private void Criar(string nome, Vector3 pos, Color c, float vida, Transform pai = null)
	{
		GameObject prefab = Resources.Load<GameObject>(nome);
		if (prefab != null)
		{
			EfeitoCor.Criar(prefab, pos, Quaternion.identity, pai, c, escala, vida);
		}
	}
}
