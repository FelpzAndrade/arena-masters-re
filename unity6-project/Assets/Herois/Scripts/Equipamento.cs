using UnityEngine;

// Equipamento de heroi Humanoid (reutilizavel): cria um "socket" (objeto vazio) filho de cada osso e poe a peca dentro.
// Para outro heroi: adicione o componente, escolha as pecas (prefabs de Assets/Herois/<Heroi>/Equipamento) e ajuste
// posicao/rotacao/escala de cada encaixe; o resto (ponta da lamina, rastro) vem junto.
//   Equipar()          cria sockets e pecas (roda sozinho no Awake; no editor, menu do componente)
//   Rastro(bool)       liga/desliga o rastro da lamina (so durante os golpes)
//   PontaDaLamina      ponto na ponta da arma (efeitos de corte saem dali)
// Heroi que ja vem com a arma no modelo (ex.: Cavaleiro do KayKit): deixe encaixes vazio e preencha armaDoModelo.
[RequireComponent(typeof(Animator))]
public class Equipamento : MonoBehaviour
{
	[System.Serializable]
	public class Encaixe
	{
		public string nome = "Peca";
		public HumanBodyBones osso = HumanBodyBones.RightHand;
		public GameObject peca;              // prefab (pivo da peca = ponto de pega)
		public Vector3 posicao;              // no espaco do osso
		public Vector3 rotacao;
		public float escala = 1f;
		public bool arma;                    // a arma ganha a ponta da lamina e o rastro
		public Vector3 ponta = new Vector3(0f, 1.6f, 0f);   // ponta da lamina no espaco da peca
	}

	public Encaixe[] encaixes = new Encaixe[0];
	[ColorUsage(false, true)] public Color corRastro = new Color(0.4f, 0.75f, 1.6f);
	public float larguraRastro = 0.18f;
	public string armaDoModelo = "";                       // nome do objeto da arma que o modelo ja traz
	public Vector3 pontaDoModelo = new Vector3(0f, 1.4f, 0f);   // ponta da lamina no espaco dessa arma

	public Transform PontaDaLamina { get; private set; }

	private TrailRenderer m_rastro;

	private void Awake()
	{
		Equipar();
		Rastro(false);
	}

	[ContextMenu("Equipar")]
	public void Equipar()
	{
		Animator anim = GetComponent<Animator>();
		if (!string.IsNullOrEmpty(armaDoModelo))
		{
			foreach (Transform t in GetComponentsInChildren<Transform>(true))
			{
				if (t.name == armaDoModelo)
				{
					ArmaPronta(t, pontaDoModelo);
				}
			}
		}
		foreach (Encaixe e in encaixes)
		{
			Transform osso = anim.GetBoneTransform(e.osso);
			if (osso == null || e.peca == null)
			{
				continue;
			}
			string nomeSocket = "Socket_" + e.nome;
			Transform velho = osso.Find(nomeSocket);
			if (velho != null)
			{
				DestroyImmediate(velho.gameObject);
			}
			Transform socket = new GameObject(nomeSocket).transform;
			socket.SetParent(osso, false);
			socket.localPosition = e.posicao;
			socket.localRotation = Quaternion.Euler(e.rotacao);
			// a escala do osso pode nao ser 1 (rig do Mixamo vem em centimetros): compensa para a peca ter o tamanho pedido
			socket.localScale = Vector3.one * (e.escala / Mathf.Max(0.0001f, osso.lossyScale.x));
			GameObject p = Instantiate(e.peca, socket, false);
			p.name = e.nome;
			if (e.arma)
			{
				ArmaPronta(p.transform, e.ponta);
			}
		}
	}

	private void ArmaPronta(Transform arma, Vector3 ponta)
	{
		Transform velha = arma.Find("PontaDaLamina");
		if (velha != null)
		{
			DestroyImmediate(velha.gameObject);
		}
		Transform velho = arma.Find("RastroLamina");
		if (velho != null)
		{
			DestroyImmediate(velho.gameObject);
		}
		PontaDaLamina = new GameObject("PontaDaLamina").transform;
		PontaDaLamina.SetParent(arma, false);
		PontaDaLamina.localPosition = ponta;
		CriarRastro(arma, ponta);
	}

	public void Rastro(bool ligado)
	{
		if (m_rastro == null)
		{
			return;
		}
		if (!ligado)
		{
			m_rastro.emitting = false;
			return;
		}
		if (!m_rastro.emitting)
		{
			m_rastro.Clear();
			m_rastro.emitting = true;
		}
	}

	// faixa da metade da lamina ate a ponta, mesmo material do rastro de arma dos herois da luta
	private void CriarRastro(Transform arma, Vector3 ponta)
	{
		GameObject go = new GameObject("RastroLamina");
		go.transform.SetParent(arma, false);
		go.transform.localPosition = ponta * 0.72f;
		m_rastro = go.AddComponent<TrailRenderer>();
		m_rastro.time = 0.16f;
		m_rastro.minVertexDistance = 0.04f;
		m_rastro.widthMultiplier = larguraRastro;
		m_rastro.widthCurve = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 0f));
		m_rastro.material = Vfx.ParticleMaterial(Resources.Load<Texture2D>("VFX/trace_04"), true);
		Gradient g = new Gradient();
		g.SetKeys(
			new[] { new GradientColorKey(corRastro, 0f), new GradientColorKey(corRastro, 1f) },
			new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(0f, 1f) });
		m_rastro.colorGradient = g;
		m_rastro.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
		m_rastro.emitting = false;
	}
}
