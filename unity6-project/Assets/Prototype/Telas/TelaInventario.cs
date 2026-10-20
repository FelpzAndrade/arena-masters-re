using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Inventario (Etapas 3 e 4 da fase do celular): aba Equipamentos (heroi no meio com os 6 slots em volta, bolsa com filtro
// por slot, detalhe com comparacao contra o equipado: verde melhora, vermelho piora; Equipar e Aprimorar com ouro) e
// aba Reliquias (3 vagas da equipe, lista das 6, detalhe do nivel atual e do proximo, Equipar na vaga e Aprimorar).
// Tudo vem de Progresso (JSON local). Feita para toque: alvos grandes, sem arrastar.
public class TelaInventario : MonoBehaviour
{
	private static readonly Slot[] Esquerda = { Slot.Arma, Slot.Peitoral, Slot.Botas };
	private static readonly Slot[] Direita = { Slot.Luvas, Slot.Anel, Slot.Colar };

	private string m_heroi;
	private FighterDef m_def;
	private System.Action m_aoFechar;
	private bool m_abaReliquias;
	private int m_filtro = -1;               // -1 = todos; senao (int)Slot
	private string m_selecionado;            // uid do item ou id da reliquia
	private int m_vagaReliquia;              // vaga escolhida para equipar reliquia

	private RectTransform m_raiz, m_conteudo;
	private TextMeshProUGUI m_ouro, m_poder, m_titulo;
	private Vitrine m_vitrine;

	public static TelaInventario Abrir(string heroi, FighterDef def, System.Action aoFechar)
	{
		Canvas canvas = new GameObject("TelaInventario").AddComponent<Canvas>();
		canvas.renderMode = RenderMode.ScreenSpaceOverlay;
		canvas.sortingOrder = 60;
		CanvasScaler sc = canvas.gameObject.AddComponent<CanvasScaler>();
		sc.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		sc.referenceResolution = new Vector2(1280f, 720f);
		sc.matchWidthOrHeight = 1f;
		canvas.gameObject.AddComponent<GraphicRaycaster>();
		TelaInventario t = canvas.gameObject.AddComponent<TelaInventario>();
		t.m_heroi = heroi;
		t.m_def = def;
		t.m_aoFechar = aoFechar;
		t.Montar(canvas.transform);
		return t;
	}

	private void Montar(Transform canvas)
	{
		Image fundo = Rect("Fundo", canvas, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero).gameObject.AddComponent<Image>();
		fundo.color = new Color(0.07f, 0.055f, 0.065f, 1f);
		m_raiz = Rect("Area", fundo.transform, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
		m_raiz.gameObject.AddComponent<AreaSegura>();
		m_titulo = Texto(m_raiz, new Vector2(0f, 1f), new Vector2(370f, -34f), new Vector2(420f, 44f), "", 22f, TextAlignmentOptions.Left, new Color(1f, 0.85f, 0.5f));
		m_ouro = Texto(m_raiz, new Vector2(1f, 1f), new Vector2(-400f, -34f), new Vector2(260f, 40f), "", 24f, TextAlignmentOptions.Right, new Color(1f, 0.85f, 0.35f));
		m_poder = Texto(m_raiz, new Vector2(0.5f, 1f), new Vector2(60f, -34f), new Vector2(300f, 40f), "", 20f, TextAlignmentOptions.Center, Color.white);
		Botao(m_raiz, new Vector2(0f, 1f), new Vector2(70f, -34f), new Vector2(120f, 50f), "Voltar", new Color(0.3f, 0.25f, 0.28f), Fechar);
		Botao(m_raiz, new Vector2(1f, 1f), new Vector2(-205f, -34f), new Vector2(110f, 50f), "Itens", new Color(0.3f, 0.3f, 0.45f), () => { m_abaReliquias = false; m_selecionado = null; Redesenhar(); });
		Botao(m_raiz, new Vector2(1f, 1f), new Vector2(-75f, -34f), new Vector2(130f, 50f), "Reliquias", new Color(0.35f, 0.3f, 0.2f), () => { m_abaReliquias = true; m_selecionado = null; Redesenhar(); });
		RawImage v = Rect("Vitrine", m_raiz, new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(300f, -10f), new Vector2(380f, 380f)).gameObject.AddComponent<RawImage>();
		m_vitrine = Vitrine.Criar(v, 8.4f, 512);
		m_vitrine.Trocar(BattleManager.ModeloVitrine(m_def));
		Redesenhar();
	}

	private void Fechar()
	{
		Destroy(gameObject);   // a vitrine apaga camera, luz e modelo sozinha
		m_aoFechar?.Invoke();
	}

	// refaz tudo o que muda (simples e barato: poucas dezenas de objetos)
	private void Redesenhar()
	{
		if (m_conteudo != null)
		{
			Destroy(m_conteudo.gameObject);
		}
		m_conteudo = Rect("Conteudo", m_raiz, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
		m_titulo.text = (m_abaReliquias ? "RELIQUIAS DA EQUIPE" : "EQUIPAMENTOS  ") + (m_abaReliquias ? "" : m_heroi);
		m_ouro.text = $"Ouro  {Progresso.Atual.ouro:N0}".Replace(",", ".");
		CS.CharStatus s = new CS.CharStatus();
		m_def.applyStats(s);
		Progresso.Aplicar(m_heroi, s);
		m_poder.text = $"Poder total  {BattleManager.Poder(s):N0}".Replace(",", ".");
		m_vitrine.gameObject.SetActive(!m_abaReliquias);
		if (m_abaReliquias)
		{
			DesenharReliquias();
		}
		else
		{
			DesenharEquipamentos();
		}
	}

	// ---------- equipamentos ----------

	private void DesenharEquipamentos()
	{
		for (int i = 0; i < 3; i++)
		{
			SlotEquipado(Esquerda[i], new Vector2(75f, 120f - i * 120f));
			SlotEquipado(Direita[i], new Vector2(525f, 120f - i * 120f));
		}
		// filtros
		Botao(m_conteudo, new Vector2(0f, 1f), new Vector2(660f, -96f), new Vector2(76f, 46f), "Todos", m_filtro < 0 ? new Color(0.5f, 0.4f, 0.2f) : new Color(0.2f, 0.18f, 0.2f), () => { m_filtro = -1; Redesenhar(); });
		for (int i = 0; i < 6; i++)
		{
			int f = i;
			RectTransform b = Botao(m_conteudo, new Vector2(0f, 1f), new Vector2(740f + i * 56f, -96f), new Vector2(50f, 46f), "", m_filtro == i ? new Color(0.5f, 0.4f, 0.2f) : new Color(0.2f, 0.18f, 0.2f), () => { m_filtro = f; Redesenhar(); });
			Icone(b, IconeSlot((Slot)i), 34f, Color.white);
		}
		// bolsa (grade com rolagem)
		RectTransform lista = Rolagem(new Vector2(660f, -126f), new Vector2(590f, 250f), 86f);
		foreach (Progresso.ItemSalvo c in Progresso.Atual.itens)
		{
			ItemDef d = Progresso.Def(c);
			if (d == null || (m_filtro >= 0 && (int)d.slot != m_filtro))
			{
				continue;
			}
			string uid = c.uid;
			RectTransform cel = Celula(lista, d.icone, d.grade, c.nivel, c.uid == m_selecionado, () => { m_selecionado = uid; Redesenhar(); });
			string dono = Progresso.UsadoPor(c.uid);
			if (dono != null)
			{
				Texto(cel, new Vector2(0.5f, 1f), new Vector2(0f, -10f), new Vector2(80f, 18f), dono == m_heroi ? "EQUIPADO" : dono, 11f, TextAlignmentOptions.Center, dono == m_heroi ? new Color(0.5f, 1f, 0.5f) : new Color(1f, 1f, 1f, 0.6f));
			}
		}
		DetalheItem();
	}

	private void SlotEquipado(Slot slot, Vector2 pos)
	{
		Progresso.ItemSalvo c = Progresso.Equipado(m_heroi, slot);
		ItemDef d = Progresso.Def(c);
		RectTransform cel = Celula(m_conteudo, d != null ? d.icone : IconeSlot(slot), d != null ? d.grade : Grade.Comum, c?.nivel ?? 0, c != null && c.uid == m_selecionado, () =>
		{
			m_filtro = (int)slot;
			m_selecionado = c?.uid;
			Redesenhar();
		}, new Vector2(0f, 0.5f), pos, d == null);
		Texto(cel, new Vector2(0.5f, 0f), new Vector2(0f, -12f), new Vector2(110f, 20f), Atributos.NomesSlot[(int)slot], 13f, TextAlignmentOptions.Center, new Color(1f, 1f, 1f, 0.65f));
	}

	private void DetalheItem()
	{
		RectTransform p = Painel(new Vector2(660f, -390f), new Vector2(590f, 300f));
		Progresso.ItemSalvo c = Progresso.Copia(m_selecionado);
		ItemDef d = Progresso.Def(c);
		if (d == null)
		{
			Texto(p, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(560f, 60f), "Toque num item para ver os atributos", 18f, TextAlignmentOptions.Center, new Color(1f, 1f, 1f, 0.5f));
			return;
		}
		Color cg = Atributos.CoresGrade[(int)d.grade];
		Texto(p, new Vector2(0f, 1f), new Vector2(290f, -24f), new Vector2(560f, 34f), $"{d.nome}  <size=75%>+{c.nivel}</size>", 24f, TextAlignmentOptions.Left, cg);
		Texto(p, new Vector2(0f, 1f), new Vector2(290f, -52f), new Vector2(560f, 24f), $"{Atributos.NomesGrade[(int)d.grade]} . {Atributos.NomesSlot[(int)d.slot]} . {d.Tipo}", 15f, TextAlignmentOptions.Left, new Color(1f, 1f, 1f, 0.7f));
		// comparacao com o que o heroi usa nesse slot
		Progresso.ItemSalvo eq = Progresso.Equipado(m_heroi, d.slot);
		bool mesmo = eq != null && eq.uid == c.uid;
		Dictionary<Atributo, float> novo = Somar(Progresso.StatsDe(c)), atual = Somar(eq != null && !mesmo ? Progresso.StatsDe(eq) : new List<StatItem>());
		HashSet<Atributo> todos = new HashSet<Atributo>(novo.Keys);
		todos.UnionWith(atual.Keys);
		System.Text.StringBuilder sb = new System.Text.StringBuilder();
		foreach (Atributo a in todos)
		{
			novo.TryGetValue(a, out float vn);
			atual.TryGetValue(a, out float va);
			string linha = $"{Atributos.Nomes[(int)a]}: <b>{Atributos.Texto(a, vn)}</b>";
			if (!mesmo && eq != null && Mathf.Abs(vn - va) > 0.00001f)
			{
				float dif = vn - va;
				linha += $"  <color={(dif > 0 ? "#6CFF6C" : "#FF6060")}>{(dif > 0 ? "+" : "-")}{Atributos.Texto(a, Mathf.Abs(dif))}</color>";
			}
			sb.AppendLine(linha);
		}
		if (d.conjunto != null)
		{
			int n = Progresso.PecasDoConjunto(m_heroi, d.conjunto);
			sb.AppendLine($"<color=#FFB060>Conjunto {d.conjunto.nome} ({n}/3 equipadas)</color>");
			sb.AppendLine($"<size=85%>2 pecas: {Lista(d.conjunto.bonus2)}   3 pecas: {Lista(d.conjunto.bonus3)}</size>");
		}
		if (d.magia != Magia.Nenhuma)
		{
			sb.AppendLine($"<color=#B48CFF>{d.descricaoMagia}</color>");
		}
		TextMeshProUGUI st = Texto(p, new Vector2(0f, 1f), new Vector2(200f, -190f), new Vector2(380f, 220f), sb.ToString(), 15f, TextAlignmentOptions.TopLeft, Color.white);
		st.enableWordWrapping = true;
		// botoes
		string dono = Progresso.UsadoPor(c.uid);
		if (dono == m_heroi)
		{
			Botao(p, new Vector2(1f, 1f), new Vector2(-95f, -150f), new Vector2(170f, 56f), "Tirar", new Color(0.35f, 0.3f, 0.32f), () => { Progresso.Desequipar(m_heroi, d.slot); Redesenhar(); });
		}
		else
		{
			Botao(p, new Vector2(1f, 1f), new Vector2(-95f, -150f), new Vector2(170f, 56f), dono != null ? "Pegar de " + dono : "Equipar", new Color(0.2f, 0.5f, 0.3f), () => { Progresso.Equipar(m_heroi, c.uid); Redesenhar(); });
		}
		bool max = c.nivel >= ItemDef.NivelMaximo;
		int custo = d.CustoAprimorar(c.nivel);
		bool pode = !max && Progresso.Atual.ouro >= custo;
		Botao(p, new Vector2(1f, 1f), new Vector2(-95f, -220f), new Vector2(170f, 56f), max ? "Nivel maximo" : $"Aprimorar\n<size=75%>{custo:N0} de ouro</size>".Replace(",", "."), pode ? new Color(0.55f, 0.4f, 0.12f) : new Color(0.25f, 0.22f, 0.2f), () =>
		{
			if (Progresso.Aprimorar(c.uid))
			{
				Redesenhar();
			}
		});
	}

	// ---------- reliquias ----------

	private void DesenharReliquias()
	{
		string[] vagas = Progresso.Atual.reliquiasEquipadas;
		Texto(m_conteudo, new Vector2(0f, 1f), new Vector2(240f, -96f), new Vector2(420f, 30f), "Vagas (valem para todos os herois):", 17f, TextAlignmentOptions.Left, new Color(1f, 1f, 1f, 0.75f));
		for (int i = 0; i < 3; i++)
		{
			int vaga = i;
			ReliquiaDef r = !string.IsNullOrEmpty(vagas[i]) && Progresso.Reliquias.TryGetValue(vagas[i], out ReliquiaDef rr) ? rr : null;
			RectTransform cel = Celula(m_conteudo, r != null ? r.icone : "reliquia", Grade.Lendario, r != null ? Progresso.NivelReliquia(r.id) : 0, m_vagaReliquia == i, () =>
			{
				m_vagaReliquia = vaga;
				m_selecionado = r?.id;
				Redesenhar();
			}, new Vector2(0f, 1f), new Vector2(90f + i * 120f, -180f), r == null, r != null ? r.cor : Color.gray, true);
			Texto(cel, new Vector2(0.5f, 0f), new Vector2(0f, -12f), new Vector2(110f, 20f), "Vaga " + (i + 1), 13f, TextAlignmentOptions.Center, new Color(1f, 1f, 1f, 0.65f));
		}
		Texto(m_conteudo, new Vector2(0f, 1f), new Vector2(240f, -270f), new Vector2(420f, 30f), "Todas as reliquias:", 17f, TextAlignmentOptions.Left, new Color(1f, 1f, 1f, 0.75f));
		int k = 0;
		foreach (ReliquiaDef r in Progresso.Reliquias.Values)
		{
			string id = r.id;
			RectTransform cel = Celula(m_conteudo, r.icone, Grade.Lendario, Progresso.NivelReliquia(r.id), m_selecionado == r.id, () => { m_selecionado = id; Redesenhar(); },
				new Vector2(0f, 1f), new Vector2(90f + (k % 3) * 120f, -350f - (k / 3) * 120f), false, r.cor, true);
			if (System.Array.IndexOf(vagas, r.id) >= 0)
			{
				Texto(cel, new Vector2(0.5f, 1f), new Vector2(0f, -10f), new Vector2(80f, 18f), "EM USO", 11f, TextAlignmentOptions.Center, new Color(0.5f, 1f, 0.5f));
			}
			k++;
		}
		DetalheReliquia();
	}

	private void DetalheReliquia()
	{
		RectTransform p = Painel(new Vector2(560f, -110f), new Vector2(680f, 520f));
		ReliquiaDef r = !string.IsNullOrEmpty(m_selecionado) && Progresso.Reliquias.TryGetValue(m_selecionado, out ReliquiaDef rr) ? rr : null;
		if (r == null)
		{
			Texto(p, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(640f, 60f), "Toque numa reliquia. Toque numa vaga para escolher onde ela entra.", 18f, TextAlignmentOptions.Center, new Color(1f, 1f, 1f, 0.5f));
			return;
		}
		int nivel = Progresso.NivelReliquia(r.id);
		Texto(p, new Vector2(0f, 1f), new Vector2(330f, -30f), new Vector2(640f, 40f), $"{r.nome}  <size=70%>nivel {nivel}/{ReliquiaDef.NivelMaximo}</size>", 26f, TextAlignmentOptions.Left, Color.Lerp(r.cor, Color.white, 0.4f));
		Texto(p, new Vector2(0f, 1f), new Vector2(330f, -66f), new Vector2(640f, 26f), $"Recarga {r.recarga:0} s", 17f, TextAlignmentOptions.Left, new Color(1f, 1f, 1f, 0.7f));
		string prox = nivel < ReliquiaDef.NivelMaximo ? $"\n\n<color=#9AA0B0>Proximo nivel:</color>\n{r.Texto(nivel + 1)}" : "";
		TextMeshProUGUI t = Texto(p, new Vector2(0f, 1f), new Vector2(330f, -170f), new Vector2(640f, 180f), $"<color=#9AA0B0>Agora:</color>\n{r.Texto(nivel)}{prox}", 18f, TextAlignmentOptions.TopLeft, Color.white);
		t.enableWordWrapping = true;
		int vagaAtual = System.Array.IndexOf(Progresso.Atual.reliquiasEquipadas, r.id);
		if (vagaAtual >= 0)
		{
			Botao(p, new Vector2(0f, 0f), new Vector2(120f, 50f), new Vector2(200f, 60f), $"Tirar da vaga {vagaAtual + 1}", new Color(0.35f, 0.3f, 0.32f), () => { Progresso.TirarReliquia(vagaAtual); Redesenhar(); });
		}
		if (vagaAtual != m_vagaReliquia)
		{
			Botao(p, new Vector2(0f, 0f), new Vector2(340f, 50f), new Vector2(200f, 60f), $"Equipar na vaga {m_vagaReliquia + 1}", new Color(0.2f, 0.5f, 0.3f), () => { Progresso.EquiparReliquia(m_vagaReliquia, r.id); Redesenhar(); });
		}
		bool max = nivel >= ReliquiaDef.NivelMaximo;
		int custo = ReliquiaDef.CustoAprimorar(nivel);
		bool pode = !max && Progresso.Atual.ouro >= custo;
		Botao(p, new Vector2(1f, 0f), new Vector2(-120f, 50f), new Vector2(200f, 60f), max ? "Nivel maximo" : $"Aprimorar\n<size=75%>{custo:N0} de ouro</size>".Replace(",", "."), pode ? new Color(0.55f, 0.4f, 0.12f) : new Color(0.25f, 0.22f, 0.2f), () =>
		{
			if (Progresso.AprimorarReliquia(r.id))
			{
				Redesenhar();
			}
		});
	}

	// ---------- pecas de interface ----------

	private static string IconeSlot(Slot s) => s switch
	{
		Slot.Arma => "item_espada",
		Slot.Peitoral => "item_peitoral",
		Slot.Botas => "item_botas",
		Slot.Luvas => "item_luvas",
		Slot.Anel => "item_anel",
		_ => "item_colar",
	};

	private static Dictionary<Atributo, float> Somar(List<StatItem> l)
	{
		Dictionary<Atributo, float> r = new Dictionary<Atributo, float>();
		foreach (StatItem s in l)
		{
			r[s.atributo] = (r.TryGetValue(s.atributo, out float v) ? v : 0f) + s.valor;
		}
		return r;
	}

	private static string Lista(List<StatItem> l)
	{
		List<string> p = new List<string>();
		foreach (StatItem s in l)
		{
			p.Add($"+{Atributos.Texto(s.atributo, s.valor)} {Atributos.Nomes[(int)s.atributo].ToLower()}");
		}
		return string.Join(", ", p);
	}

	// quadrado de item: borda na cor da grade, icone, +nivel; vazio = icone apagado do slot
	private RectTransform Celula(Transform pai, string icone, Grade grade, int nivel, bool marcado, System.Action aoTocar,
		Vector2? ancora = null, Vector2? pos = null, bool vazio = false, Color? corIcone = null, bool reliquia = false)
	{
		Vector2 a = ancora ?? new Vector2(0.5f, 0.5f);
		RectTransform rt = Rect("Item", pai, a, a, pos ?? Vector2.zero, new Vector2(96f, 96f));
		Image borda = rt.gameObject.AddComponent<Image>();
		borda.sprite = TelaEscolhaHeroi.SpriteRedondo();
		borda.type = Image.Type.Sliced;
		borda.pixelsPerUnitMultiplier = 6f;
		Color cg = vazio ? new Color(0.3f, 0.3f, 0.32f) : reliquia ? (corIcone ?? Color.white) * 0.6f : Atributos.CoresGrade[(int)grade];
		cg.a = 1f;
		borda.color = marcado ? Color.white : cg;
		Image miolo = Rect("Miolo", rt, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero).gameObject.AddComponent<Image>();
		miolo.rectTransform.offsetMin = new Vector2(5f, 5f);
		miolo.rectTransform.offsetMax = new Vector2(-5f, -5f);
		miolo.sprite = TelaEscolhaHeroi.SpriteRedondo();
		miolo.type = Image.Type.Sliced;
		miolo.pixelsPerUnitMultiplier = 7f;
		miolo.color = new Color(cg.r * 0.22f + 0.05f, cg.g * 0.22f + 0.04f, cg.b * 0.22f + 0.05f, 1f);
		miolo.raycastTarget = false;
		Icone(rt, icone, 62f, vazio ? new Color(1f, 1f, 1f, 0.2f) : reliquia ? Color.Lerp(corIcone ?? Color.white, Color.white, 0.35f) : Color.white);
		if (!vazio && nivel > 0)
		{
			Texto(rt, new Vector2(1f, 0f), new Vector2(-24f, 16f), new Vector2(46f, 22f), reliquia ? "Nv" + nivel : "+" + nivel, 15f, TextAlignmentOptions.Right, Color.white).fontStyle = FontStyles.Bold;
		}
		rt.gameObject.AddComponent<Button>().onClick.AddListener(() => aoTocar());
		return rt;
	}

	private static Image Icone(Transform pai, string icone, float tam, Color cor)
	{
		Image i = Rect("Icone", pai, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(tam, tam)).gameObject.AddComponent<Image>();
		i.sprite = ControlesToque.Icone(icone);
		i.color = cor;
		i.raycastTarget = false;
		return i;
	}

	private RectTransform Rolagem(Vector2 pos, Vector2 tam, float celula)
	{
		RectTransform caixa = Rect("Bolsa", m_conteudo, new Vector2(0f, 1f), new Vector2(0f, 1f), pos, tam);
		caixa.pivot = new Vector2(0f, 1f);
		caixa.anchoredPosition = pos;
		caixa.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.3f);
		caixa.gameObject.AddComponent<RectMask2D>();
		ScrollRect sr = caixa.gameObject.AddComponent<ScrollRect>();
		sr.horizontal = false;
		RectTransform lista = Rect("Lista", caixa, new Vector2(0f, 1f), new Vector2(1f, 1f), Vector2.zero, Vector2.zero);
		lista.pivot = new Vector2(0.5f, 1f);
		lista.offsetMin = lista.offsetMax = Vector2.zero;
		GridLayoutGroup g = lista.gameObject.AddComponent<GridLayoutGroup>();
		g.cellSize = new Vector2(celula, celula);
		g.spacing = new Vector2(10f, 22f);
		g.padding = new RectOffset(10, 10, 12, 12);
		lista.gameObject.AddComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
		sr.content = lista;
		return lista;
	}

	private RectTransform Painel(Vector2 pos, Vector2 tam)
	{
		RectTransform p = Rect("Detalhe", m_conteudo, new Vector2(0f, 1f), new Vector2(0f, 1f), pos, tam);
		p.pivot = new Vector2(0f, 1f);
		p.anchoredPosition = pos;
		Image i = p.gameObject.AddComponent<Image>();
		i.sprite = TelaEscolhaHeroi.SpriteRedondo();
		i.type = Image.Type.Sliced;
		i.pixelsPerUnitMultiplier = 5f;
		i.color = new Color(0f, 0f, 0f, 0.45f);
		return p;
	}

	private static RectTransform Botao(Transform pai, Vector2 ancora, Vector2 pos, Vector2 tam, string txt, Color cor, System.Action aoTocar)
	{
		RectTransform rt = Rect("Botao", pai, ancora, ancora, pos, tam);
		Image i = rt.gameObject.AddComponent<Image>();
		i.sprite = TelaEscolhaHeroi.SpriteRedondo();
		i.type = Image.Type.Sliced;
		i.pixelsPerUnitMultiplier = 5f;
		i.color = cor;
		rt.gameObject.AddComponent<Button>().onClick.AddListener(() => aoTocar());
		if (!string.IsNullOrEmpty(txt))
		{
			Texto(rt, new Vector2(0.5f, 0.5f), Vector2.zero, tam - new Vector2(8f, 4f), txt, 18f, TextAlignmentOptions.Center, Color.white).fontStyle = FontStyles.Bold;
		}
		return rt;
	}

	private static TextMeshProUGUI Texto(Transform pai, Vector2 ancora, Vector2 pos, Vector2 tam, string txt, float tamanho, TextAlignmentOptions al, Color cor)
	{
		TextMeshProUGUI t = Rect("Txt", pai, ancora, ancora, pos, tam).gameObject.AddComponent<TextMeshProUGUI>();
		t.text = txt;
		t.fontSize = tamanho;
		t.alignment = al;
		t.color = cor;
		t.raycastTarget = false;
		t.enableWordWrapping = false;
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
