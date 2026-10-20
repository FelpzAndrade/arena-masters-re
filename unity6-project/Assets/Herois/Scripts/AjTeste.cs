using UnityEngine;

// Liga o Aj (Animator do Mixamo) aos sistemas que ja existem, so na cena VFX_Test. Nao tem logica de combate propria.
//   Espaco  Skill B (Redemoinho + SkillEsferaGiratoria)
//   J       ataque basico: cada toque avanca um golpe do combo (Ataque1..4); 0,8 s sem tocar volta para o Ataque1
//   T       volta o Aj e o boneco para o lugar inicial
// O Animator chama OnImpacto (evento do clipe) no quadro do golpe; aqui ele vira efeito + game feel do combate_spec.md:
// hit stop, tremida, flash branco no boneco, numero de dano e contador de combo.
[RequireComponent(typeof(Animator))]
public class AjTeste : MonoBehaviour
{
	public BonecoTreino boneco;
	public ComboCounter combo;
	public float alcanceGolpe = 2.2f;

	private Animator m_anim;
	private SkillEsferaGiratoria m_skillB;
	private Vector3 m_inicio, m_inicioBoneco;
	private string m_acao = "";
	private int m_impactos;
	private int m_passo;
	private float m_semTocar = 99f;
	private static GameObject s_impacto;

	private void Awake()
	{
		m_anim = GetComponent<Animator>();
		m_anim.applyRootMotion = false;
		m_skillB = GetComponent<SkillEsferaGiratoria>();
		m_inicio = transform.position;
		if (boneco != null)
		{
			m_inicioBoneco = boneco.transform.position;
		}
	}

	private void Update()
	{
		m_semTocar += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SkillB();
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			Atacar();
		}
		if (Input.GetKeyDown(KeyCode.T))
		{
			Resetar();
		}
		Andar();
	}

	// WASD/setas: anda pela cena (parado durante a skill); a velocidade escolhe parado/andando/correndo no Animator
	private void Andar()
	{
		Vector3 dir = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		float vel = 0f;
		if (dir.sqrMagnitude > 0.01f && !m_skillB.Ativa)
		{
			dir.Normalize();
			vel = 5f;
			transform.position += dir * vel * Time.deltaTime;
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 15f);
		}
		m_anim.SetFloat("Velocidade", vel, 0.08f, Time.deltaTime);
	}

	// botoes na tela: funcionam mesmo se a janela Game nao estiver com o foco do teclado
	private void OnGUI()
	{
		GUI.skin.button.fontSize = 22;
		float w = 170f, h = 56f, x = Screen.width - w - 20f, y = Screen.height - 3f * (h + 10f) - 20f;
		if (GUI.Button(new Rect(x, y, w, h), "Skill B (Espaco)"))
		{
			SkillB();
		}
		if (GUI.Button(new Rect(x, y + h + 10f, w, h), "Ataque (J)"))
		{
			Atacar();
		}
		if (GUI.Button(new Rect(x, y + 2f * (h + 10f), w, h), "Voltar (T)"))
		{
			Resetar();
		}
		GUI.Label(new Rect(20f, 20f, 600f, 30f), "WASD anda | Espaco Skill B | J ataque | T volta");
	}

	public void Resetar()
	{
		transform.position = m_inicio;
		if (boneco != null)
		{
			boneco.transform.position = m_inicioBoneco;
		}
		OlharBoneco();
	}

	public void SkillB()
	{
		OlharBoneco();
		m_acao = "Redemoinho";
		m_impactos = 0;
		m_anim.SetTrigger("Redemoinho");
		m_skillB.Iniciar(transform.forward);
	}

	public void Atacar()
	{
		if (m_semTocar > 0.8f)
		{
			m_passo = 0;
		}
		m_semTocar = 0f;
		OlharBoneco();
		m_acao = AjCombo[m_passo];
		m_impactos = 0;
		m_anim.SetTrigger(m_acao);
		m_passo = (m_passo + 1) % AjCombo.Length;
	}

	private static readonly string[] AjCombo = { "Ataque1", "Ataque2", "Ataque3", "Ataque4" };

	// evento dos clipes (Animation Event "OnImpacto")
	public void OnImpacto()
	{
		m_impactos++;
		if (m_acao == "Redemoinho")
		{
			if (m_impactos == 1)
			{
				m_skillB.CorteEntrada();
				Acertar(alcanceGolpe, 1340, 0.05f, 0.12f);
			}
			else if (m_skillB.EsferaNaTela)
			{
				Acertar(m_skillB.raioAcerto * m_skillB.escala + 0.6f, 980, 0.05f, 0.1f);
			}
			return;
		}
		Acertar(alcanceGolpe, m_acao == "Ataque4" ? 860 : 520, 0.05f, m_acao == "Ataque4" ? 0.14f : 0.08f);
	}

	private void Acertar(float alcance, int dano, float hitStop, float tremida)
	{
		if (boneco == null)
		{
			return;
		}
		Vector3 d = boneco.transform.position - transform.position;
		d.y = 0f;
		if (d.magnitude > alcance)
		{
			return;
		}
		bool critico = Random.value < 0.2f;
		HitStop.Request(hitStop);
		CameraShake.Add(tremida);
		s_impacto ??= Resources.Load<GameObject>("VFX_ImpactoGolpe");
		if (s_impacto != null)
		{
			Vector3 p = boneco.transform.position + Vector3.up * boneco.altura * 0.6f - d.normalized * 0.3f;
			EfeitoCor.Criar(s_impacto, p, Quaternion.identity, null, Color.white, critico ? 1.3f : 1f, 0.5f);
		}
		boneco.Acertar(critico ? Mathf.RoundToInt(dano * 1.8f) : dano, critico, transform.position);
		if (combo != null)
		{
			combo.Hit();
		}
	}

	private void OlharBoneco()
	{
		if (boneco == null || m_skillB.Ativa)
		{
			return;
		}
		Vector3 d = boneco.transform.position - transform.position;
		d.y = 0f;
		if (d.sqrMagnitude > 0.01f)
		{
			transform.rotation = Quaternion.LookRotation(d);
		}
	}
}
