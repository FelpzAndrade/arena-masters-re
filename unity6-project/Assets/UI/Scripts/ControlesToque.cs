using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;

// Controles de celular da luta (reutilizavel, nao conhece o combate):
//   joystick flutuante no canto inferior esquerdo (On-Screen Stick do Input System, gamepad virtual: <Gamepad>/leftStick;
//   o dedo pode comecar em qualquer ponto da area, a base aparece onde o dedo tocou)
//   botoes redondos no canto inferior direito: ataque grande no meio, esquiva e skills A/B/C em leque, ultimate no alto
//   com a barra de carga em volta; vaga das reliquias no centro-baixo (vazia ate a Etapa 4)
// Tudo dentro de AreaSegura (notch). Multitoque pelo InputSystemUIInputModule (cada dedo e um ponteiro).
// Uso: ControlesToque.Criar(canvas) e ligar os eventos de Botao(slot): 0 ataque, 1..3 skills, 4 esquiva, 5 ultimate.
public class ControlesToque : MonoBehaviour
{
	public const int Ataque = 0, Esquiva = 4, Ultimate = 5;
	public RectTransform areaReliquias;
	public RectTransform joystick;

	private readonly Dictionary<int, BotaoSkill> m_botoes = new Dictionary<int, BotaoSkill>();
	private static readonly Dictionary<string, Sprite> s_sprites = new Dictionary<string, Sprite>();

	public BotaoSkill Botao(int slot) => m_botoes.TryGetValue(slot, out BotaoSkill b) ? b : null;

	// botoes das reliquias no centro-baixo (so toque, sem mira); teclas 1, 2, 3 no PC
	public BotaoSkill[] CriarReliquias(int quantas, bool mostrarTeclas)
	{
		BotaoSkill[] r = new BotaoSkill[quantas];
		for (int i = 0; i < quantas; i++)
		{
			float x = (i - (quantas - 1) * 0.5f) * 104f;
			Criar(areaReliquias, 100 + i, new Vector2(x, 0f), 84f, false, mostrarTeclas ? (i + 1).ToString() : null, new Vector2(0.5f, 0.5f));
			r[i] = m_botoes[100 + i];
		}
		return r;
	}

	public static Sprite SpriteDe(string recurso)
	{
		if (!s_sprites.TryGetValue(recurso, out Sprite s) || s == null)
		{
			Texture2D t = Resources.Load<Texture2D>(recurso);
			s = t != null ? Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f), 100f) : null;
			s_sprites[recurso] = s;
		}
		return s;
	}

	public static Sprite Icone(string tipo) => SpriteDe("Icones/" + tipo) ?? SpriteDe("Icones/vazio");

	public static ControlesToque Criar(Canvas canvas, bool mostrarTeclas)
	{
		if (canvas.GetComponent<GraphicRaycaster>() == null)
		{
			canvas.gameObject.AddComponent<GraphicRaycaster>();
		}
		if (EventSystem.current == null && Object.FindAnyObjectByType<EventSystem>() == null)
		{
			GameObject es = new GameObject("EventSystem");
			es.AddComponent<EventSystem>();
			es.AddComponent<InputSystemUIInputModule>();   // varios dedos ao mesmo tempo (joystick + botao)
		}
		RectTransform raiz = Rect("Controles", canvas.transform, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
		raiz.offsetMin = raiz.offsetMax = Vector2.zero;
		raiz.gameObject.AddComponent<AreaSegura>();
		ControlesToque c = raiz.gameObject.AddComponent<ControlesToque>();
		c.MontarJoystick(raiz);
		c.MontarBotoes(raiz, mostrarTeclas);
		c.areaReliquias = Rect("Reliquias", raiz, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 70f), new Vector2(360f, 110f));
		return c;
	}

	// ---------- joystick ----------

	private void MontarJoystick(RectTransform raiz)
	{
		// area de toque do lado esquerdo (o On-Screen Stick com origem dinamica aceita o dedo dentro de dynamicOriginRange)
		RectTransform area = Rect("AreaJoystick", raiz, Vector2.zero, Vector2.zero, new Vector2(230f, 190f), new Vector2(10f, 10f));
		RectTransform baseJ = Rect("Base", area, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(190f, 190f));
		Image b = baseJ.gameObject.AddComponent<Image>();
		b.sprite = SpriteDe("UI/T_Anel");
		b.color = new Color(1f, 1f, 1f, 0.35f);
		b.raycastTarget = false;
		Image bf = Rect("Fundo", baseJ, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(180f, 180f)).gameObject.AddComponent<Image>();
		bf.sprite = SpriteDe("UI/T_Circulo");
		bf.color = new Color(0f, 0f, 0f, 0.25f);
		bf.raycastTarget = false;
		joystick = Rect("Alavanca", area, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(86f, 86f));
		Image k = joystick.gameObject.AddComponent<Image>();
		k.sprite = SpriteDe("UI/T_Circulo");
		k.color = new Color(1f, 1f, 1f, 0.75f);
		OnScreenStick stick = joystick.gameObject.AddComponent<OnScreenStick>();
		stick.controlPath = "<Gamepad>/leftStick";
		stick.behaviour = OnScreenStick.Behaviour.ExactPositionWithDynamicOrigin;
		stick.movementRange = 85f;
		stick.dynamicOriginRange = 260f;
		joystick.gameObject.AddComponent<BaseDoJoystick>().baseVisual = baseJ;
	}

	// ---------- botoes ----------

	private void MontarBotoes(RectTransform raiz, bool teclas)
	{
		RectTransform canto = Rect("Botoes", raiz, new Vector2(1f, 0f), new Vector2(1f, 0f), new Vector2(-10f, 10f), new Vector2(460f, 420f));
		canto.pivot = new Vector2(1f, 0f);
		// posicoes em relacao ao canto inferior direito (x negativo = para a esquerda): ataque grande embaixo, esquiva e
		// skills em leque em volta dele, ultimate no alto a direita (com o anel de carga cabe dentro da tela)
		Criar(canto, Ataque, new Vector2(-150f, 140f), 150f, false, teclas ? "J" : null);
		Criar(canto, Esquiva, new Vector2(-330f, 70f), 96f, false, teclas ? "Espaco" : null);
		Criar(canto, 1, new Vector2(-335f, 200f), 96f, true, teclas ? "K" : null);
		Criar(canto, 2, new Vector2(-270f, 312f), 96f, true, teclas ? "L" : null);
		Criar(canto, 3, new Vector2(-175f, 342f), 96f, true, teclas ? "I" : null);
		Criar(canto, Ultimate, new Vector2(-70f, 300f), 104f, true, teclas ? "R" : null);
	}

	private void Criar(RectTransform pai, int slot, Vector2 pos, float tamanho, bool mira, string tecla, Vector2? ancora = null)
	{
		Vector2 a = ancora ?? new Vector2(1f, 0f);
		RectTransform rt = Rect("Botao" + slot, pai, a, a, pos, new Vector2(tamanho, tamanho));
		BotaoSkill b = rt.gameObject.AddComponent<BotaoSkill>();
		b.podeMirar = mira;
		if (slot == Ultimate)
		{
			b.brilho = Imagem("Brilho", rt, "UI/T_Brilho", 1.75f, Color.clear, false);
			b.brilho.enabled = false;
			b.anel = Imagem("Carga", rt, "UI/T_Anel", 1.22f, Color.white, false);
			b.anel.type = Image.Type.Filled;
			b.anel.fillMethod = Image.FillMethod.Radial360;
			b.anel.fillOrigin = (int)Image.Origin360.Top;
			Imagem("CargaFundo", rt, "UI/T_Anel", 1.22f, new Color(0f, 0f, 0f, 0.45f), false).transform.SetSiblingIndex(b.anel.transform.GetSiblingIndex());
		}
		b.fundo = rt.gameObject.AddComponent<Image>();
		b.fundo.sprite = SpriteDe("UI/T_Circulo");
		Imagem("Borda", rt, "UI/T_Anel", 1f, new Color(1f, 1f, 1f, 0.55f), false);
		b.icone = Imagem("Icone", rt, "Icones/vazio", 0.62f, Color.white, false);
		b.recarga = Imagem("Recarga", rt, "UI/T_Circulo", 1f, new Color(0f, 0f, 0f, 0.62f), false);
		b.recarga.type = Image.Type.Filled;
		b.recarga.fillMethod = Image.FillMethod.Radial360;
		b.recarga.fillOrigin = (int)Image.Origin360.Top;
		b.recarga.fillClockwise = false;
		b.recarga.fillAmount = 0f;
		TextMeshProUGUI s = Rect("Segundos", rt, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero).gameObject.AddComponent<TextMeshProUGUI>();
		s.rectTransform.offsetMin = s.rectTransform.offsetMax = Vector2.zero;
		s.alignment = TextAlignmentOptions.Center;
		s.fontSize = tamanho * 0.34f;
		s.fontStyle = FontStyles.Bold;
		s.outlineWidth = 0.25f;
		s.outlineColor = Color.black;
		s.raycastTarget = false;
		b.segundos = s;
		if (!string.IsNullOrEmpty(tecla))
		{
			TextMeshProUGUI t = Rect("Tecla", rt, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, -12f), new Vector2(120f, 22f)).gameObject.AddComponent<TextMeshProUGUI>();
			t.text = tecla;
			t.fontSize = 15f;
			t.alignment = TextAlignmentOptions.Center;
			t.color = new Color(1f, 1f, 1f, 0.7f);
			t.raycastTarget = false;
		}
		m_botoes[slot] = b;
	}

	private static Image Imagem(string nome, RectTransform pai, string recurso, float escala, Color cor, bool raycast)
	{
		RectTransform rt = Rect(nome, pai, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, pai.sizeDelta * escala);
		Image i = rt.gameObject.AddComponent<Image>();
		i.sprite = SpriteDe(recurso);
		i.color = cor;
		i.raycastTarget = raycast;
		return i;
	}

	private static RectTransform Rect(string nome, Transform pai, Vector2 ancoraMin, Vector2 ancoraMax, Vector2 pos, Vector2 tamanho)
	{
		RectTransform rt = new GameObject(nome, typeof(RectTransform)).GetComponent<RectTransform>();
		rt.SetParent(pai, false);
		rt.anchorMin = ancoraMin;
		rt.anchorMax = ancoraMax;
		rt.pivot = new Vector2(0.5f, 0.5f);
		rt.anchoredPosition = pos;
		rt.sizeDelta = tamanho;
		return rt;
	}
}

// a base do joystick aparece onde o dedo tocou e volta para o lugar quando solta
public class BaseDoJoystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public RectTransform baseVisual;
	private Vector2 m_repouso;

	private void Start()
	{
		m_repouso = baseVisual.anchoredPosition;
	}

	public void OnPointerDown(PointerEventData e)
	{
		RectTransform pai = (RectTransform)baseVisual.parent;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle(pai, e.position, e.pressEventCamera, out Vector2 local))
		{
			baseVisual.anchoredPosition = local;
		}
	}

	public void OnPointerUp(PointerEventData e)
	{
		baseVisual.anchoredPosition = m_repouso;
	}
}
