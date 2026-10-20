using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CS;
using UnityEngine;
using UnityEngine.UI;

// Visualizador da abertura em quadrinhos (pnlPatchOpening) usando as tabelas e o som reconstruidos.
// A UI original era NGUI (comercial, nao reconstruida); aqui a mesma montagem e feita com uGUI.
// Ritmo e parametros tirados do prefab original: NextImageShowInterval 9s, UseAutoNext, TweenAlpha 0.5s.
public class OpeningViewer : MonoBehaviour
{
	public string language = "pt-BR";
	public float nextImageShowInterval = 9f;
	public bool useAutoNext = true;
	// no prefab final o fade estava desligado (UseTweenNext 0); ligado aqui para a transicao ficar visivel
	public bool useTweenNext = true;
	public float tweenDuration = 0.5f;
	// fonte original do jogo (Assets/Font/08SeoulNamsanEB_0.ttf), atribuida pelo menu de montagem da cena
	public Font font;

	private readonly List<XDownloadPageInfo> m_pages = new List<XDownloadPageInfo>();
	private readonly Dictionary<string, Dictionary<string, Sprite>> m_atlases = new Dictionary<string, Dictionary<string, Sprite>>();
	private RectTransform m_root;
	private CanvasGroup m_group;
	private RawImage m_bg1;
	private RawImage m_bg2;
	private RectTransform m_items;
	private Text m_pageLabel;
	private Font m_font;
	private int m_index;
	private float m_elapsed;
	private bool m_tweening;

	public int PageCount => m_pages.Count;

	private void Awake()
	{
		Setup();
	}

	public void Setup()
	{
		InitGameData();
		BuildCanvas();
		LoadPages();
	}

	private IEnumerator Start()
	{
		yield return null;
		ShowPage(0);
	}

	// Mesma sequencia de inicializacao do jogo: fabrica de tabelas, carga local, gerenciador de som.
	private void InitGameData()
	{
		CSLog.Init(new CSLogger());
		XGlobal.Option = new XOption();
		XGlobal.Option.Language = language;
		XGlobal.proto = new XProtoInfoManagers();
		XGlobal.proto.Init(new XProtoInfoFactory(), ProtoInfoFrom.Client);
		XGlobal.proto.LoadFromLocalFile(string.Empty);
		XGlobal.proto.sound.Cooking(XGlobal.proto);
		XSoundManager sound = new GameObject("XSoundManager").AddComponent<XSoundManager>();
		XGlobal.sound = sound;
		sound.Init();
		sound.PlayBGM_Title();
	}

	private void LoadPages()
	{
		XProtoInfoManager_DownloadImg table = new XProtoInfoManager_DownloadImg();
		table.LoadFromLocalFile(new XFileLoader_UnityResource(XProtoInfoManagers.GetFilePath(ProtoInfoTypes.DownloadImg)));
		Dictionary<int, XDownloadEpisodeInfo> episodes = table.GetDownloadImgListsByLanguage(language);
		foreach (XDownloadEpisodeInfo episode in episodes.OrderBy(e => e.Key).Select(e => e.Value))
		{
			for (int page = 1, found = 0; found < episode.PageCount && page < 100; page++)
			{
				XDownloadPageInfo info = episode.GetPageInfo(page);
				if (info != null)
				{
					m_pages.Add(info);
					found++;
				}
			}
		}
	}

	public Camera ViewCamera { get; private set; }

	private void BuildCanvas()
	{
		Camera cam = new GameObject("Camera").AddComponent<Camera>();
		ViewCamera = cam;
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = Color.black;
		cam.orthographic = true;

		Canvas canvas = new GameObject("Canvas").AddComponent<Canvas>();
		canvas.renderMode = RenderMode.ScreenSpaceCamera;
		canvas.worldCamera = cam;
		CanvasScaler scaler = canvas.gameObject.AddComponent<CanvasScaler>();
		scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		scaler.referenceResolution = new Vector2(1280f, 720f);
		scaler.matchWidthOrHeight = 1f;

		m_root = NewRect("pnlPatchOpening", canvas.transform);
		m_group = m_root.gameObject.AddComponent<CanvasGroup>();
		// bgTable (UITable) empilha BG1 (arte 1024x512) e BG2 (faixa 1024x62), exibidos no widget Img de 1280x640 (escala 1.25)
		m_bg1 = NewRawImage("sprBG1", m_root, new Vector2(1280f, 640f));
		m_bg1.rectTransform.anchoredPosition = new Vector2(0f, 38.75f);
		m_bg2 = NewRawImage("sprBG2", m_root, new Vector2(1280f, 77.5f));
		m_bg2.rectTransform.anchoredPosition = new Vector2(0f, -320f);
		m_items = NewRect("items", m_root);

		m_font = font != null ? font : Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		m_pageLabel = NewText("lblPage", canvas.transform, 18);
		m_pageLabel.alignment = TextAnchor.LowerRight;
		m_pageLabel.color = Color.white;
		m_pageLabel.gameObject.AddComponent<Outline>().effectColor = Color.black;
		RectTransform rt = m_pageLabel.rectTransform;
		rt.anchorMin = rt.anchorMax = rt.pivot = new Vector2(1f, 0f);
		rt.anchoredPosition = new Vector2(-16f, 12f);
		rt.sizeDelta = new Vector2(500f, 30f);
	}

	private void Update()
	{
		if (m_tweening || m_pages.Count == 0)
		{
			return;
		}
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			OnClick_Next();
			return;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			OnClick_Prev();
			return;
		}
		// XPanel_PatchOpening.Update: acumula deltaTime e avanca ao atingir o intervalo
		if (useAutoNext)
		{
			m_elapsed += Time.deltaTime;
			if (m_elapsed >= nextImageShowInterval)
			{
				OnClick_Next();
			}
		}
	}

	public void OnClick_Next()
	{
		StartCoroutine(ChangePage((m_index + 1) % m_pages.Count));
	}

	public void OnClick_Prev()
	{
		StartCoroutine(ChangePage((m_index - 1 + m_pages.Count) % m_pages.Count));
	}

	private IEnumerator ChangePage(int index)
	{
		m_elapsed = 0f;
		m_tweening = true;
		if (useTweenNext)
		{
			yield return Fade(1f, 0f);
		}
		ShowPage(index);
		if (useTweenNext)
		{
			yield return Fade(0f, 1f);
		}
		m_tweening = false;
	}

	private IEnumerator Fade(float from, float to)
	{
		for (float t = 0f; t < tweenDuration; t += Time.deltaTime)
		{
			m_group.alpha = Mathf.Lerp(from, to, t / tweenDuration);
			yield return null;
		}
		m_group.alpha = to;
	}

	public void ShowPage(int index)
	{
		m_index = index;
		XDownloadPageInfo page = m_pages[index];
		SetBG(m_bg1, page.bgPath1);
		SetBG(m_bg2, page.bgPath2);
		for (int i = m_items.childCount - 1; i >= 0; i--)
		{
			if (Application.isPlaying)
			{
				Destroy(m_items.GetChild(i).gameObject);
			}
			else
			{
				DestroyImmediate(m_items.GetChild(i).gameObject);
			}
		}
		// XPanel_PatchOpening.BuildDisplayInfo: imagens em tamanho nativo, textos com fonte/contorno/rotacao
		foreach (XDownloadImgDisplayInfo info in page.GetDisplayInfos())
		{
			if (info.IsImgDisplay())
			{
				Image img = NewImage("img", m_items, Vector2.zero);
				img.sprite = LoadSprite(info.ImgPath);
				img.SetNativeSize();
				if (info.Size != Vector2.zero)
				{
					img.rectTransform.sizeDelta = info.Size;
				}
				Place(img.rectTransform, info);
			}
			else if (info.IsTextDisplay())
			{
				Text text = NewText("lbl", m_items, info.FontSize);
				text.text = NguiToRichText(info.Text);
				text.horizontalOverflow = HorizontalWrapMode.Overflow;
				text.verticalOverflow = VerticalWrapMode.Overflow;
				text.alignment = TextAnchor.MiddleCenter;
				if (info.OutlineSize > 0f)
				{
					Outline outline = text.gameObject.AddComponent<Outline>();
					outline.effectColor = info.OutlineColor;
					outline.effectDistance = new Vector2(info.OutlineSize, -info.OutlineSize);
				}
				Place(text.rectTransform, info);
			}
		}
		m_pageLabel.text = $"Arena Masters - abertura ({language})  pagina {index + 1}/{m_pages.Count}  [clique/espaco: proxima, seta esq.: anterior]";
	}

	private static void Place(RectTransform rt, XDownloadImgDisplayInfo info)
	{
		rt.anchoredPosition = info.Position;
		rt.localEulerAngles = info.Rotation;
	}

	// fundo desenhado direto da textura do atlas com o recorte do sprite como uvRect
	private void SetBG(RawImage image, string path)
	{
		Sprite sprite = string.IsNullOrEmpty(path) ? null : LoadSprite(path);
		image.gameObject.SetActive(sprite != null);
		if (sprite == null)
		{
			return;
		}
		Rect r = sprite.textureRect;
		Texture tex = sprite.texture;
		image.texture = tex;
		image.uvRect = new Rect(r.x / tex.width, r.y / tex.height, r.width / tex.width, r.height / tex.height);
	}

	// Equivalente ao XSpriteLoader.LoadInPool: "Opening/bg_main/nome" -> atlas Resources/atlas/opening/bg_main
	private Sprite LoadSprite(string path)
	{
		int slash = path.LastIndexOf('/');
		string atlasPath = "atlas/" + path.Substring(0, slash).ToLower();
		string name = path.Substring(slash + 1);
		if (!m_atlases.TryGetValue(atlasPath, out Dictionary<string, Sprite> atlas))
		{
			atlas = new Dictionary<string, Sprite>();
			GameObject prefab = Resources.Load<GameObject>(atlasPath);
			XSpriteAtlas component = prefab != null ? prefab.GetComponent<XSpriteAtlas>() : null;
			if (component != null && component.list != null)
			{
				foreach (Sprite sprite in component.list.Where(s => s != null))
				{
					// a malha de render convertida do Unity 5 nao bate com o Unity 6; recria a partir do recorte no atlas
					Sprite rebuilt = Sprite.Create(sprite.texture, sprite.rect, new Vector2(0.5f, 0.5f), sprite.pixelsPerUnit, 0, SpriteMeshType.FullRect);
					rebuilt.name = sprite.name;
					atlas[sprite.name] = rebuilt;
				}
			}
			m_atlases[atlasPath] = atlas;
		}
		atlas.TryGetValue(name, out Sprite result);
		if (result == null)
		{
			Debug.LogWarning("Sprite nao encontrado: " + path);
		}
		return result;
	}

	// Codigos BBCode do NGUI -> rich text do uGUI
	private static string NguiToRichText(string s)
	{
		s = Regex.Replace(s, @"\[([0-9A-Fa-f]{6})\]", "<color=#$1>");
		s = s.Replace("[-]", "</color>").Replace("[b]", "<b>").Replace("[/b]", "</b>").Replace("[i]", "<i>").Replace("[/i]", "</i>");
		return Regex.Replace(s, @"\[/?(u|s|sub|sup|c|url[^\]]*)\]", string.Empty);
	}

	private static RectTransform NewRect(string name, Transform parent)
	{
		RectTransform rt = new GameObject(name, typeof(RectTransform)).GetComponent<RectTransform>();
		rt.SetParent(parent, false);
		rt.anchorMin = rt.anchorMax = rt.pivot = new Vector2(0.5f, 0.5f);
		return rt;
	}

	private static Image NewImage(string name, Transform parent, Vector2 size)
	{
		RectTransform rt = NewRect(name, parent);
		rt.sizeDelta = size;
		return rt.gameObject.AddComponent<Image>();
	}

	private static RawImage NewRawImage(string name, Transform parent, Vector2 size)
	{
		RectTransform rt = NewRect(name, parent);
		rt.sizeDelta = size;
		return rt.gameObject.AddComponent<RawImage>();
	}

	private Text NewText(string name, Transform parent, int fontSize)
	{
		Text text = NewRect(name, parent).gameObject.AddComponent<Text>();
		text.font = m_font;
		text.fontSize = fontSize;
		text.supportRichText = true;
		text.color = Color.black;
		return text;
	}
}
