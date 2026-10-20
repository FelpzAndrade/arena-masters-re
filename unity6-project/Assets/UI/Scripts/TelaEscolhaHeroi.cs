using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;

// Ficha de um heroi para a tela de escolha (montada por quem conhece o combate).
public class FichaHeroi
{
	public string nome;
	public string classe;
	public Color cor;
	public int poder;
	public List<(string rotulo, string valor)> atributos = new List<(string, string)>();
	public List<(string icone, Color cor, string nome, string resumo)> skills = new List<(string, Color, string, string)>();
	public string passiva;
	public System.Func<GameObject> montarModelo;   // modelo ja pintado e tocando a pose parada (pivo nos pes)
}

// Tela de escolha de heroi antes da luta (reutilizavel, nao conhece o combate):
// lista de herois a esquerda, modelo girando no meio (camera propria numa camada so dele, RenderTexture),
// ficha a direita (classe, atributos, skills, passiva, poder total) e o botao LUTAR. Feita para toque (botoes grandes).
public class TelaEscolhaHeroi : MonoBehaviour
{
	public System.Action<string> aoConfirmar;   // nome do heroi escolhido
	public System.Action<string> aoEquipamentos;   // abrir o inventario do heroi selecionado (opcional)

	private List<FichaHeroi> m_fichas;
	private int m_atual = -1;
	private Vitrine m_vitrine;
	private readonly List<Image> m_cartoes = new List<Image>();
	private TextMeshProUGUI m_nome, m_classe, m_atributos, m_skills, m_poder;

	public string Escolhido => m_atual >= 0 ? m_fichas[m_atual].nome : null;

	public static TelaEscolhaHeroi Criar(List<FichaHeroi> fichas, string inicial, System.Action<string> aoConfirmar, System.Action<string> aoEquipamentos = null)
	{
		if (Object.FindAnyObjectByType<EventSystem>() == null)
		{
			GameObject es = new GameObject("EventSystem");
			es.AddComponent<EventSystem>();
			es.AddComponent<InputSystemUIInputModule>();
		}
		Canvas canvas = new GameObject("TelaEscolha").AddComponent<Canvas>();
		canvas.renderMode = RenderMode.ScreenSpaceOverlay;
		canvas.sortingOrder = 50;
		CanvasScaler sc = canvas.gameObject.AddComponent<CanvasScaler>();
		sc.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		sc.referenceResolution = new Vector2(1280f, 720f);
		sc.matchWidthOrHeight = 1f;
		canvas.gameObject.AddComponent<GraphicRaycaster>();
		TelaEscolhaHeroi t = canvas.gameObject.AddComponent<TelaEscolhaHeroi>();
		t.m_fichas = fichas;
		t.aoConfirmar = aoConfirmar;
		t.aoEquipamentos = aoEquipamentos;
		t.Montar(canvas.transform);
		int i = fichas.FindIndex(f => f.nome == inicial);
		t.Selecionar(i >= 0 ? i : 0);
		return t;
	}

	private void Montar(Transform canvas)
	{
		// fundo escuro com degrade (a arena fica atras, sem camera ainda)
		Image fundo = Rect("Fundo", canvas, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero).gameObject.AddComponent<Image>();
		fundo.color = new Color(0.08f, 0.06f, 0.07f, 1f);
		RectTransform area = Rect("Area", fundo.transform, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
		area.gameObject.AddComponent<AreaSegura>();

		Texto(area, "Titulo", new Vector2(0.5f, 1f), new Vector2(0f, -40f), new Vector2(800f, 50f), "ESCOLHA SEU HEROI", 34f, TextAlignmentOptions.Center, new Color(1f, 0.85f, 0.5f));

		// lista de herois (cartoes grandes para o dedo)
		for (int i = 0; i < m_fichas.Count; i++)
		{
			int idx = i;
			RectTransform c = Rect("Cartao" + i, area, new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(150f, 150f - i * 130f), new Vector2(240f, 112f));
			Image img = c.gameObject.AddComponent<Image>();
			img.sprite = SpriteRedondo();
			img.type = Image.Type.Sliced;
			img.pixelsPerUnitMultiplier = 5f;   // cantos pequenos (retangulo arredondado, nao oval)
			c.gameObject.AddComponent<Button>().onClick.AddListener(() => Selecionar(idx));
			m_cartoes.Add(img);
			Texto(c, "Nome", new Vector2(0.5f, 0.5f), new Vector2(0f, 14f), new Vector2(220f, 40f), m_fichas[i].nome, 28f, TextAlignmentOptions.Center, Color.white);
			Texto(c, "Classe", new Vector2(0.5f, 0.5f), new Vector2(0f, -22f), new Vector2(220f, 30f), m_fichas[i].classe, 18f, TextAlignmentOptions.Center, new Color(1f, 1f, 1f, 0.7f));
		}

		// vitrine do modelo (girando)
		RawImage vitrine = Rect("Vitrine", area, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(-110f, -20f), new Vector2(560f, 560f)).gameObject.AddComponent<RawImage>();
		m_vitrine = Vitrine.Criar(vitrine);
		Image chao = Rect("Base", area, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(-110f, -250f), new Vector2(380f, 70f)).gameObject.AddComponent<Image>();
		chao.sprite = SpriteRedondo();
		chao.color = new Color(1f, 1f, 1f, 0.06f);
		chao.transform.SetSiblingIndex(vitrine.transform.GetSiblingIndex());

		// ficha
		RectTransform ficha = Rect("Ficha", area, new Vector2(1f, 0.5f), new Vector2(1f, 0.5f), new Vector2(-230f, 20f), new Vector2(420f, 560f));
		Image ff = ficha.gameObject.AddComponent<Image>();
		ff.sprite = SpriteRedondo();
		ff.type = Image.Type.Sliced;
		ff.pixelsPerUnitMultiplier = 5f;
		ff.color = new Color(0f, 0f, 0f, 0.45f);
		m_nome = Texto(ficha, "Nome", new Vector2(0.5f, 1f), new Vector2(0f, -36f), new Vector2(390f, 46f), "", 36f, TextAlignmentOptions.Left, Color.white);
		m_classe = Texto(ficha, "Classe", new Vector2(0.5f, 1f), new Vector2(0f, -72f), new Vector2(390f, 28f), "", 20f, TextAlignmentOptions.Left, new Color(1f, 1f, 1f, 0.75f));
		m_atributos = Texto(ficha, "Atributos", new Vector2(0.5f, 1f), new Vector2(0f, -150f), new Vector2(390f, 120f), "", 19f, TextAlignmentOptions.TopLeft, Color.white);
		m_skills = Texto(ficha, "Skills", new Vector2(0.5f, 1f), new Vector2(0f, -360f), new Vector2(390f, 290f), "", 16f, TextAlignmentOptions.TopLeft, new Color(0.92f, 0.92f, 0.95f));
		m_skills.richText = true;
		m_poder = Texto(area, "Poder", new Vector2(0.5f, 0f), new Vector2(-110f, 52f), new Vector2(560f, 50f), "", 30f, TextAlignmentOptions.Center, new Color(1f, 0.85f, 0.45f));

		// LUTAR
		RectTransform lutar = Rect("Lutar", area, new Vector2(1f, 0f), new Vector2(1f, 0f), new Vector2(-150f, 56f), new Vector2(250f, 84f));
		Image li = lutar.gameObject.AddComponent<Image>();
		li.sprite = SpriteRedondo();
		li.type = Image.Type.Sliced;
		li.pixelsPerUnitMultiplier = 4f;
		li.color = new Color(0.85f, 0.45f, 0.12f);
		lutar.gameObject.AddComponent<Button>().onClick.AddListener(Confirmar);
		Texto(lutar, "Txt", new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(240f, 80f), "LUTAR", 38f, TextAlignmentOptions.Center, Color.white).fontStyle = FontStyles.Bold;

		if (aoEquipamentos != null)
		{
			RectTransform eq = Rect("Equipamentos", area, new Vector2(1f, 0f), new Vector2(1f, 0f), new Vector2(-420f, 56f), new Vector2(250f, 70f));
			Image ei = eq.gameObject.AddComponent<Image>();
			ei.sprite = SpriteRedondo();
			ei.type = Image.Type.Sliced;
			ei.pixelsPerUnitMultiplier = 4f;
			ei.color = new Color(0.25f, 0.22f, 0.35f);
			eq.gameObject.AddComponent<Button>().onClick.AddListener(() => aoEquipamentos(Escolhido));
			Texto(eq, "Txt", new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(240f, 66f), "EQUIPAMENTOS", 24f, TextAlignmentOptions.Center, Color.white).fontStyle = FontStyles.Bold;
		}
	}

	public void Selecionar(int i)
	{
		if (i == m_atual)
		{
			return;
		}
		m_atual = i;
		FichaHeroi f = m_fichas[i];
		for (int k = 0; k < m_cartoes.Count; k++)
		{
			Color c = m_fichas[k].cor;
			m_cartoes[k].color = k == i ? new Color(c.r * 0.7f, c.g * 0.7f, c.b * 0.7f, 0.95f) : new Color(0.15f, 0.13f, 0.14f, 0.85f);
			m_cartoes[k].transform.localScale = Vector3.one * (k == i ? 1.06f : 1f);
		}
		m_nome.text = f.nome;
		m_nome.color = Color.Lerp(f.cor, Color.white, 0.35f);
		m_classe.text = f.classe;
		System.Text.StringBuilder a = new System.Text.StringBuilder();
		foreach ((string r, string v) in f.atributos)
		{
			a.Append($"{r}: <b>{v}</b>\n");
		}
		m_atributos.text = a.ToString();
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		foreach ((string icone, Color cor, string nome, string resumo) in f.skills)
		{
			s.Append($"<color=#{ColorUtility.ToHtmlStringRGB(Color.Lerp(cor, Color.white, 0.45f))}><b>{nome}</b></color>  <size=85%>{resumo}</size>\n");
		}
		if (!string.IsNullOrEmpty(f.passiva))
		{
			s.Append($"<color=#FFD27A><b>Passiva</b></color>  <size=85%>{f.passiva}</size>");
		}
		m_skills.text = s.ToString();
		m_poder.text = $"PODER TOTAL  {f.poder:N0}".Replace(",", ".");
		TrocarModelo(f);
	}

	private void TrocarModelo(FichaHeroi f)
	{
		m_vitrine.Trocar(f.montarModelo?.Invoke());
	}

	private void Confirmar()
	{
		string nome = Escolhido;
		Fechar();
		aoConfirmar?.Invoke(nome);
	}

	public void Fechar()
	{
		Destroy(gameObject);   // a vitrine apaga camera, luz e modelo sozinha
	}

	private static Sprite s_redondo;

	// retangulo de cantos arredondados (fatiado: estica sem deformar os cantos)
	public static Sprite SpriteRedondo()
	{
		if (s_redondo == null)
		{
			Texture2D c = Resources.Load<Texture2D>("UI/T_Circulo");
			s_redondo = Sprite.Create(c, new Rect(0, 0, c.width, c.height), new Vector2(0.5f, 0.5f), 100f, 0, SpriteMeshType.FullRect, new Vector4(c.width * 0.45f, c.height * 0.45f, c.width * 0.45f, c.height * 0.45f));
		}
		return s_redondo;
	}

	private static TextMeshProUGUI Texto(Transform pai, string nome, Vector2 ancora, Vector2 pos, Vector2 tam, string txt, float tamanho, TextAlignmentOptions al, Color cor)
	{
		TextMeshProUGUI t = Rect(nome, pai, ancora, ancora, pos, tam).gameObject.AddComponent<TextMeshProUGUI>();
		t.text = txt;
		t.fontSize = tamanho;
		t.alignment = al;
		t.color = cor;
		t.raycastTarget = false;
		return t;
	}

	private static RectTransform Rect(string nome, Transform pai, Vector2 min, Vector2 max, Vector2 pos, Vector2 tam)
	{
		RectTransform rt = new GameObject(nome, typeof(RectTransform)).GetComponent<RectTransform>();
		rt.SetParent(pai, false);
		rt.anchorMin = min;
		rt.anchorMax = max;
		rt.pivot = new Vector2(0.5f, 0.5f);
		rt.anchoredPosition = pos;
		rt.sizeDelta = tam;
		if (min != max)
		{
			rt.offsetMin = rt.offsetMax = Vector2.zero;
		}
		return rt;
	}
}
