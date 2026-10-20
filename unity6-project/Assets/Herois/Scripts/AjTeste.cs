using UnityEngine;

// Liga o Aj (Animator do Mixamo) aos sistemas que ja existem, so na cena VFX_Test. Nao tem logica de combate propria.
//   Espaco  Skill B (Redemoinho + SkillEsferaGiratoria)
//   J       ataque basico: cada toque avanca um golpe do combo (Ataque1..4); 0,8 s sem tocar volta para o Ataque1
//   T       volta o Aj e o boneco para o lugar inicial
//   U       enche a barra da ultimate (teste do brilho maximo da espada)
// Com EspadaBrilho (Cavaleiro): a espada brilha forte na Skill B e no inicio da ultimate, e fica no maximo com a barra cheia.
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
	private bool m_acertouCaminho;
	private SkillUltimateExplosao m_ult;
	private Equipamento m_equip;
	private static GameObject s_faiscaPonta;
	private int m_passo;
	private float m_semTocar = 99f;
	private static GameObject s_impacto;
	private EspadaBrilho m_espada;
	private float m_carga;                  // barra da ultimate (10.000 cheia, carga = dano causado; estimativa para o teste)
	private const float CargaCheia = 10000f;

	private void Awake()
	{
		m_anim = GetComponent<Animator>();
		m_anim.applyRootMotion = false;
		m_skillB = GetComponent<SkillEsferaGiratoria>();
		m_equip = GetComponent<Equipamento>();
		m_ult = GetComponent<SkillUltimateExplosao>();
		m_espada = GetComponent<EspadaBrilho>();
		if (m_ult != null)
		{
			m_ult.mao = m_anim.GetBoneTransform(HumanBodyBones.RightHand);
			m_ult.aoImpacto = UltImpacto;
			m_ult.aoExplosao = UltExplosao;
		}
		m_inicio = transform.position;
		if (boneco != null)
		{
			m_inicioBoneco = boneco.transform.position;
		}
	}

	// Start (nao Awake): o Equipamento cria a espada e a ponta da lamina no Awake dele
	private void Start()
	{
		if (m_equip != null)
		{
			m_skillB.pontaDaLamina = m_equip.PontaDaLamina;
			if (m_ult != null && m_equip.PontaDaLamina != null)
			{
				m_ult.mao = m_equip.PontaDaLamina;   // brilho de carga da ultimate na ponta da espada
			}
		}
	}

	private void Update()
	{
		m_semTocar += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SkillB(MiraDoMouse());
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			Atacar();
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			Ultimate();
		}
		if (Input.GetKeyDown(KeyCode.T))
		{
			Resetar();
		}
		if (Input.GetKeyDown(KeyCode.U))
		{
			Carregar(CargaCheia);
		}
		Andar();
		AcertoNoCaminho();
		if (m_equip != null)
		{
			// rastro so durante golpe (qualquer estado fora da locomocao, menos tomar dano/morrer) ou com a esfera girando
			AnimatorStateInfo st = m_anim.GetCurrentAnimatorStateInfo(0);
			bool golpe = !st.IsName("Locomocao") && !st.IsName("TomarDano") && !st.IsName("Morrer") || m_anim.IsInTransition(0) && !m_anim.GetNextAnimatorStateInfo(0).IsName("Locomocao");
			m_equip.Rastro(golpe || m_skillB.EsferaNaTela);
		}
	}

	// a esfera acerta quem estiver dentro dela no caminho (uma vez por alvo a cada uso)
	private void AcertoNoCaminho()
	{
		if (!m_skillB.EsferaNaTela || m_acertouCaminho || boneco == null)
		{
			return;
		}
		Vector3 d = boneco.transform.position + Vector3.up * boneco.altura * 0.5f - m_skillB.Centro;
		if (d.magnitude <= m_skillB.Raio + 0.4f)
		{
			m_acertouCaminho = true;
			Acertar(99f, 980, 0.05f, 0.1f);
		}
	}

	// ponto do chao sob o mouse (plano na altura do heroi); null se o mouse estiver fora da tela
	private Vector3? MiraDoMouse()
	{
		Camera cam = Camera.main;
		Vector3 m = Input.mousePosition;
		if (cam == null || m.x < 0f || m.y < 0f || m.x > Screen.width || m.y > Screen.height)
		{
			return null;
		}
		Ray ray = cam.ScreenPointToRay(m);
		Plane chao = new Plane(Vector3.up, transform.position);
		return chao.Raycast(ray, out float dist) ? ray.GetPoint(dist) : (Vector3?)null;
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
		float w = 170f, h = 56f, x = Screen.width - w - 20f, y = Screen.height - 4f * (h + 10f) - 20f;
		if (GUI.Button(new Rect(x, y, w, h), "Ultimate (R)"))
		{
			Ultimate();
		}
		y += h + 10f;
		if (GUI.Button(new Rect(x, y, w, h), "Skill B (Espaco)"))
		{
			SkillB(null);
		}
		if (GUI.Button(new Rect(x, y + h + 10f, w, h), "Ataque (J)"))
		{
			Atacar();
		}
		if (GUI.Button(new Rect(x, y + 2f * (h + 10f), w, h), "Voltar (T)"))
		{
			Resetar();
		}
		GUI.Label(new Rect(20f, 20f, 700f, 30f), "WASD anda | Espaco Skill B | R ultimate | J ataque | T volta | U enche a ultimate");
		GUI.Label(new Rect(20f, 48f, 400f, 30f), m_carga >= CargaCheia ? "Ultimate PRONTA" : $"Ultimate {m_carga / CargaCheia * 100f:0}%");
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
		SkillB(null);
	}

	// mira: ponto do chao para onde a esfera vai (null = na direcao do boneco)
	public void SkillB(Vector3? mira)
	{
		if (m_skillB.Ativa)
		{
			return;
		}
		if (mira.HasValue)
		{
			Vector3 d = mira.Value - transform.position;
			d.y = 0f;
			if (d.sqrMagnitude > 0.04f)
			{
				transform.rotation = Quaternion.LookRotation(d);
			}
		}
		else
		{
			OlharBoneco();
		}
		m_acao = "Redemoinho";
		m_impactos = 0;
		m_acertouCaminho = false;
		m_anim.SetTrigger("Redemoinho");
		m_skillB.Iniciar(transform.forward);
		if (m_espada != null)
		{
			m_espada.Pico(m_skillB.atraso + m_skillB.duracao);
		}
	}

	// Skill A da ficha como ultimate: avanca, tela tinge, impacto pesado, 2a onda e fumaca (SkillUltimateExplosao)
	public void Ultimate()
	{
		if (m_ult == null || m_ult.Ativa || m_skillB.Ativa || boneco == null)
		{
			return;
		}
		m_acao = "GolpeChao";
		m_anim.SetTrigger("GolpeChao");
		m_ult.Iniciar(boneco.transform.position);
		m_carga = 0f;
		if (m_espada != null)
		{
			m_espada.ultimatePronta = false;
			m_espada.Pico(m_ult.tempoImpacto);
		}
	}

	// impacto principal: hit stop de ultimate, tremida forte e varios numeros em sequencia (multi-hit)
	private void UltImpacto(Vector3 pos)
	{
		HitStop.Request(0.12f);
		CameraShake.Add(0.45f);
		StartCoroutine(Rajada(new[] { 2400, 2650, 2380, 3120 }, 0.1f));
	}

	private System.Collections.IEnumerator Rajada(int[] danos, float intervalo)
	{
		foreach (int dano in danos)
		{
			bool critico = Random.value < 0.25f;
			boneco.Acertar(critico ? Mathf.RoundToInt(dano * 1.8f) : dano, critico, transform.position);
			if (combo != null)
			{
				combo.Hit();
			}
			yield return new WaitForSecondsRealtime(intervalo);
		}
	}

	// cada explosao da 2a onda: tremida fraca e dano se o boneco estiver perto
	private void UltExplosao(Vector3 pos)
	{
		CameraShake.Add(0.14f);
		Vector3 d = boneco.transform.position - pos;
		d.y = 0f;
		if (d.magnitude < 2.4f)
		{
			boneco.Acertar(Random.Range(700, 900), false, pos);
			if (combo != null)
			{
				combo.Hit();
			}
		}
	}

	private void Carregar(float quanto)
	{
		m_carga = Mathf.Min(CargaCheia, m_carga + quanto);
		if (m_espada != null)
		{
			m_espada.ultimatePronta = m_carga >= CargaCheia;
		}
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
		FaiscaNaPonta();
		if (m_acao == "GolpeChao")
		{
			m_ult.Impacto();
			return;
		}
		if (m_acao == "Redemoinho")
		{
			if (m_impactos == 1)
			{
				m_skillB.CorteEntrada();
				Acertar(alcanceGolpe, 1340, 0.05f, 0.12f);
			}
			return;   // o giro acerta pelo caminho (AcertoNoCaminho), nao num quadro fixo
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
		Carregar(critico ? dano * 1.8f : dano);
		if (combo != null)
		{
			combo.Hit();
		}
	}

	// clarao pequeno na ponta da lamina no quadro do golpe (usa o mesmo clarao do corte de entrada, cor da skill)
	private void FaiscaNaPonta()
	{
		if (m_equip == null || m_equip.PontaDaLamina == null)
		{
			return;
		}
		s_faiscaPonta ??= Resources.Load<GameObject>("VFX_UltCarga");
		if (s_faiscaPonta != null)
		{
			EfeitoCor.Criar(s_faiscaPonta, m_equip.PontaDaLamina.position, Quaternion.identity, null, m_skillB.cor, 0.8f, 0.4f);
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
