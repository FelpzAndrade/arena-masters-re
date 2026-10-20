using System;
using System.Collections.Generic;
using System.IO;
using CS;
using UnityEngine;

// Progresso do jogador salvo em JSON local (Application.persistentDataPath/progresso.json), sem servidor:
// ouro, bolsa de itens (cada copia com seu nivel de aprimoramento), equipamento de cada heroi (6 slots),
// reliquias (nivel) e as 3 vagas de reliquia da equipe.
public static class Progresso
{
	[Serializable]
	public class ItemSalvo
	{
		public string uid;     // copia unica (o mesmo item pode ter varias copias)
		public string id;      // ItemDef.id
		public int nivel;      // +0 a +10
	}

	[Serializable]
	public class EquipHeroi
	{
		public string heroi;
		public string[] slots = new string[6];   // uid por Slot (vazio = nada)
	}

	[Serializable]
	public class ReliquiaSalva
	{
		public string id;
		public int nivel = 1;
	}

	[Serializable]
	public class Dados
	{
		public int versao = 1;
		public int ouro = 5000;
		public int vitorias, derrotas;
		public int proximoUid = 1;
		public List<ItemSalvo> itens = new List<ItemSalvo>();
		public List<EquipHeroi> equip = new List<EquipHeroi>();
		public List<ReliquiaSalva> reliquias = new List<ReliquiaSalva>();
		public string[] reliquiasEquipadas = new string[3];
	}

	private static Dados s_dados;
	private static Dictionary<string, ItemDef> s_itens;
	private static Dictionary<string, ReliquiaDef> s_reliquias;
	public static bool semSalvar;            // testes: mexe so na memoria (TesteEquipamento)

	public static string Caminho => Path.Combine(Application.persistentDataPath, "progresso.json");

	public static Dados Atual
	{
		get
		{
			if (s_dados == null)
			{
				Carregar();
			}
			return s_dados;
		}
		set => s_dados = value;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]   // inicio de cada Play: le de novo do disco
	private static void Zerar()
	{
		s_dados = null;
		semSalvar = false;
	}

	public static Dictionary<string, ItemDef> Itens
	{
		get
		{
			if (s_itens == null)
			{
				s_itens = new Dictionary<string, ItemDef>();
				foreach (ItemDef d in Resources.LoadAll<ItemDef>("Itens"))
				{
					s_itens[d.id] = d;
				}
			}
			return s_itens;
		}
	}

	public static Dictionary<string, ReliquiaDef> Reliquias
	{
		get
		{
			if (s_reliquias == null)
			{
				s_reliquias = new Dictionary<string, ReliquiaDef>();
				foreach (ReliquiaDef d in Resources.LoadAll<ReliquiaDef>("Reliquias"))
				{
					s_reliquias[d.id] = d;
				}
			}
			return s_reliquias;
		}
	}

	public static void Carregar()
	{
		try
		{
			s_dados = File.Exists(Caminho) ? JsonUtility.FromJson<Dados>(File.ReadAllText(Caminho)) : null;
		}
		catch (Exception e)
		{
			Debug.LogWarning("[Progresso] arquivo ilegivel, comecando de novo: " + e.Message);
			s_dados = null;
		}
		if (s_dados == null)
		{
			s_dados = Inicial();
			Salvar();
		}
		Completar(s_dados);
	}

	public static void Salvar()
	{
		if (semSalvar || s_dados == null)
		{
			return;
		}
		File.WriteAllText(Caminho, JsonUtility.ToJson(s_dados, true));
	}

	// primeira vez: 5.000 de ouro e um item Comum de cada slot na bolsa; todas as reliquias no nivel 1, 3 equipadas
	public static Dados Inicial()
	{
		Dados d = new Dados();
		foreach (ItemDef i in Itens.Values)
		{
			if (i.grade == Grade.Comum)
			{
				Novo(d, i.id);
			}
		}
		d.reliquiasEquipadas = new[] { "calice", "egide", "vento" };
		return d;
	}

	// reliquias novas (criadas depois do arquivo salvo) entram no nivel 1
	private static void Completar(Dados d)
	{
		foreach (ReliquiaDef r in Reliquias.Values)
		{
			if (!d.reliquias.Exists(x => x.id == r.id))
			{
				d.reliquias.Add(new ReliquiaSalva { id = r.id, nivel = 1 });
			}
		}
		if (d.reliquiasEquipadas == null || d.reliquiasEquipadas.Length != 3)
		{
			d.reliquiasEquipadas = new string[3];
		}
	}

	public static ItemSalvo Novo(Dados d, string id)
	{
		ItemSalvo s = new ItemSalvo { uid = "i" + d.proximoUid++, id = id, nivel = 0 };
		d.itens.Add(s);
		return s;
	}

	public static ItemDef Def(ItemSalvo s) => s != null && Itens.TryGetValue(s.id, out ItemDef d) ? d : null;

	public static ItemSalvo Copia(string uid) => string.IsNullOrEmpty(uid) ? null : Atual.itens.Find(i => i.uid == uid);

	public static EquipHeroi EquipDe(string heroi)
	{
		EquipHeroi e = Atual.equip.Find(x => x.heroi == heroi);
		if (e == null)
		{
			e = new EquipHeroi { heroi = heroi };
			Atual.equip.Add(e);
		}
		if (e.slots == null || e.slots.Length != 6)
		{
			e.slots = new string[6];
		}
		return e;
	}

	public static ItemSalvo Equipado(string heroi, Slot slot) => Copia(EquipDe(heroi).slots[(int)slot]);

	// heroi que esta usando esta copia (null = na bolsa)
	public static string UsadoPor(string uid)
	{
		foreach (EquipHeroi e in Atual.equip)
		{
			if (e.slots != null && Array.IndexOf(e.slots, uid) >= 0)
			{
				return e.heroi;
			}
		}
		return null;
	}

	public static void Equipar(string heroi, string uid)
	{
		ItemSalvo s = Copia(uid);
		ItemDef d = Def(s);
		if (d == null)
		{
			return;
		}
		foreach (EquipHeroi e in Atual.equip)
		{
			for (int i = 0; i < e.slots.Length; i++)
			{
				if (e.slots[i] == uid)
				{
					e.slots[i] = null;   // a copia sai de quem estava usando
				}
			}
		}
		EquipDe(heroi).slots[(int)d.slot] = uid;
		Salvar();
	}

	public static void Desequipar(string heroi, Slot slot)
	{
		EquipDe(heroi).slots[(int)slot] = null;
		Salvar();
	}

	public static bool Aprimorar(string uid)
	{
		ItemSalvo s = Copia(uid);
		ItemDef d = Def(s);
		if (d == null || s.nivel >= ItemDef.NivelMaximo || Atual.ouro < d.CustoAprimorar(s.nivel))
		{
			return false;
		}
		Atual.ouro -= d.CustoAprimorar(s.nivel);
		s.nivel++;
		Salvar();
		return true;
	}

	// atributos do item no nivel dele (principal com aprimoramento + secundarios)
	public static List<StatItem> StatsDe(ItemSalvo s)
	{
		List<StatItem> r = new List<StatItem>();
		ItemDef d = Def(s);
		if (d == null)
		{
			return r;
		}
		r.Add(new StatItem(d.principal.atributo, d.Principal(s.nivel)));
		r.AddRange(d.secundarios);
		return r;
	}

	// tudo o que o equipamento do heroi soma: itens + bonus de conjunto
	public static List<StatItem> BonusDoHeroi(string heroi)
	{
		List<StatItem> r = new List<StatItem>();
		Dictionary<ConjuntoDef, int> pecas = new Dictionary<ConjuntoDef, int>();
		foreach (string uid in EquipDe(heroi).slots)
		{
			ItemSalvo s = Copia(uid);
			ItemDef d = Def(s);
			if (d == null)
			{
				continue;
			}
			r.AddRange(StatsDe(s));
			if (d.conjunto != null)
			{
				pecas[d.conjunto] = pecas.TryGetValue(d.conjunto, out int n) ? n + 1 : 1;
			}
		}
		foreach (KeyValuePair<ConjuntoDef, int> c in pecas)
		{
			r.AddRange(c.Key.Bonus(c.Value));
		}
		return r;
	}

	public static int PecasDoConjunto(string heroi, ConjuntoDef c)
	{
		int n = 0;
		foreach (string uid in EquipDe(heroi).slots)
		{
			if (Def(Copia(uid))?.conjunto == c && c != null)
			{
				n++;
			}
		}
		return n;
	}

	public static void Aplicar(string heroi, CharStatus s)
	{
		foreach (StatItem b in BonusDoHeroi(heroi))
		{
			Atributos.Somar(s, b.atributo, b.valor);
		}
	}

	public static List<ItemDef> MagiasDoHeroi(string heroi)
	{
		List<ItemDef> r = new List<ItemDef>();
		foreach (string uid in EquipDe(heroi).slots)
		{
			ItemDef d = Def(Copia(uid));
			if (d != null && d.magia != Magia.Nenhuma)
			{
				r.Add(d);
			}
		}
		return r;
	}

	// ---------- fim de luta ----------

	// vitoria: 3.000 de ouro + 1 item (60% Comum, 28% Raro, 10% Epico, 2% Lendario); derrota: 1.000 e 30% de um Comum
	public static (int ouro, ItemDef item) Recompensa(bool vitoria)
	{
		int ouro = vitoria ? 3000 : 1000;
		Atual.ouro += ouro;
		if (vitoria)
		{
			Atual.vitorias++;
		}
		else
		{
			Atual.derrotas++;
		}
		ItemDef item = null;
		if (vitoria || UnityEngine.Random.value < 0.3f)
		{
			float r = UnityEngine.Random.value;
			Grade g = !vitoria ? Grade.Comum : r < 0.6f ? Grade.Comum : r < 0.88f ? Grade.Raro : r < 0.98f ? Grade.Epico : Grade.Lendario;
			List<ItemDef> opcoes = new List<ItemDef>();
			foreach (ItemDef d in Itens.Values)
			{
				if (d.grade == g)
				{
					opcoes.Add(d);
				}
			}
			if (opcoes.Count > 0)
			{
				item = opcoes[UnityEngine.Random.Range(0, opcoes.Count)];
				Novo(Atual, item.id);
			}
		}
		Salvar();
		return (ouro, item);
	}

	// ---------- reliquias ----------

	public static ReliquiaSalva ReliquiaSalvaDe(string id) => Atual.reliquias.Find(r => r.id == id);

	public static int NivelReliquia(string id) => ReliquiaSalvaDe(id)?.nivel ?? 1;

	public static bool AprimorarReliquia(string id)
	{
		ReliquiaSalva r = ReliquiaSalvaDe(id);
		if (r == null || r.nivel >= ReliquiaDef.NivelMaximo || Atual.ouro < ReliquiaDef.CustoAprimorar(r.nivel))
		{
			return false;
		}
		Atual.ouro -= ReliquiaDef.CustoAprimorar(r.nivel);
		r.nivel++;
		Salvar();
		return true;
	}

	// coloca a reliquia na vaga (se ja estava em outra vaga, troca de lugar)
	public static void EquiparReliquia(int vaga, string id)
	{
		string[] v = Atual.reliquiasEquipadas;
		int antes = Array.IndexOf(v, id);
		if (antes >= 0)
		{
			v[antes] = v[vaga];
		}
		v[vaga] = id;
		Salvar();
	}

	public static void TirarReliquia(int vaga)
	{
		Atual.reliquiasEquipadas[vaga] = null;
		Salvar();
	}
}
