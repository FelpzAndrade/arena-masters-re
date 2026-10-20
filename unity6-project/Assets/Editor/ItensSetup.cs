using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Menu "Arena Masters/Itens/Criar itens e reliquias": 18 equipamentos (3 por slot, com o conjunto Vigilia Rubra de 3 pecas
// e 2 itens magicos) e as 6 reliquias da proposta aprovada (Assets/Prototype/Resources/Itens e /Reliquias).
// Rodar de novo atualiza os valores sem trocar os arquivos (referencias continuam valendo). Numeros = estimativa.
public static class ItensSetup
{
	const string PastaItens = "Assets/Prototype/Resources/Itens";
	const string PastaReliquias = "Assets/Prototype/Resources/Reliquias";

	static StatItem S(Atributo a, float v) => new StatItem(a, v);

	[MenuItem("Arena Masters/Itens/Criar itens e reliquias")]
	public static void Criar()
	{
		System.IO.Directory.CreateDirectory(PastaItens);
		System.IO.Directory.CreateDirectory(PastaReliquias);

		ConjuntoDef vigilia = Asset<ConjuntoDef>($"{PastaItens}/Conjunto_VigiliaRubra.asset");
		vigilia.nome = "Vigilia Rubra";
		vigilia.bonus2 = new List<StatItem> { S(Atributo.Critico, 0.03f) };
		vigilia.bonus3 = new List<StatItem> { S(Atributo.Defesa, 0.05f), S(Atributo.DanoCritico, 0.08f) };
		vigilia.bonus4 = new List<StatItem> { S(Atributo.Critico, 0.03f) };
		EditorUtility.SetDirty(vigilia);

		// Arma
		Item("espada_aventureiro", "Espada do Aventureiro", Slot.Arma, Grade.Comum, "item_espada", S(Atributo.AtaqueFisico, 160), S(Atributo.EvasaoCritico, 0.01f));
		Item("cajado_brasa", "Cajado de Brasa Velha", Slot.Arma, Grade.Raro, "item_cajado", S(Atributo.AtaqueMagico, 200), S(Atributo.Critico, 0.02f), S(Atributo.PenetracaoMagica, 0.02f));
		ItemDef lamina = Item("lamina_relampago", "Lamina do Relampago Errante", Slot.Arma, Grade.Epico, "item_espada", S(Atributo.AtaqueFisico, 240),
			S(Atributo.Critico, 0.025f), S(Atributo.DanoCritico, 0.05f), S(Atributo.PenetracaoFisica, 0.02f));
		lamina.magia = Magia.Relampago;
		lamina.chanceMagia = 0.08f;
		lamina.esperaMagia = 3f;
		lamina.descricaoMagia = "8% de chance ao causar dano: um raio cai no alvo (250% do ATK magico). Espera de 3 s.";
		// Peitoral
		Item("gibao_couro", "Gibao de Couro Curtido", Slot.Peitoral, Grade.Comum, "item_peitoral", S(Atributo.Defesa, 0.02f), S(Atributo.DefesaCritico, 0.02f));
		Item("couraca_vigilia", "Couraca da Vigilia Rubra", Slot.Peitoral, Grade.Raro, "item_peitoral", S(Atributo.Defesa, 0.03f), S(Atributo.Critico, 0.015f), S(Atributo.Vida, 800)).conjunto = vigilia;
		Item("manto_guardiao", "Manto do Guardiao de Pedra", Slot.Peitoral, Grade.Epico, "item_peitoral", S(Atributo.Vida, 4000),
			S(Atributo.DefesaCritico, 0.05f), S(Atributo.Evasao, 0.01f), S(Atributo.Defesa, 0.01f));
		// Botas
		Item("botas_viajante", "Botas de Viajante", Slot.Botas, Grade.Comum, "item_botas", S(Atributo.Defesa, 0.012f), S(Atributo.Evasao, 0.008f));
		Item("grevas_vigilia", "Grevas da Vigilia Rubra", Slot.Botas, Grade.Raro, "item_botas", S(Atributo.Vida, 2500), S(Atributo.Evasao, 0.01f), S(Atributo.DanoCritico, 0.03f)).conjunto = vigilia;
		Item("passos_vento", "Passos do Vento Cortante", Slot.Botas, Grade.Lendario, "item_botas", S(Atributo.Defesa, 0.03f),
			S(Atributo.Evasao, 0.02f), S(Atributo.EvasaoCritico, 0.03f), S(Atributo.Critico, 0.02f), S(Atributo.PenetracaoFisica, 0.02f), S(Atributo.DanoCritico, 0.05f));
		// Luvas
		Item("luvas_esgrimista", "Luvas de Esgrimista", Slot.Luvas, Grade.Comum, "item_luvas", S(Atributo.Defesa, 0.015f), S(Atributo.Critico, 0.01f));
		Item("manoplas_vigilia", "Manoplas da Vigilia Rubra", Slot.Luvas, Grade.Raro, "item_luvas", S(Atributo.Defesa, 0.02f), S(Atributo.Critico, 0.015f), S(Atributo.PenetracaoFisica, 0.015f)).conjunto = vigilia;
		Item("garras_cacador", "Garras do Cacador Noturno", Slot.Luvas, Grade.Epico, "item_luvas", S(Atributo.Vida, 3000),
			S(Atributo.DanoCritico, 0.06f), S(Atributo.PenetracaoFisica, 0.03f), S(Atributo.Critico, 0.02f), S(Atributo.EvasaoCritico, 0.015f));
		// Anel
		Item("anel_cobre", "Anel de Cobre Simples", Slot.Anel, Grade.Comum, "item_anel", S(Atributo.AtaqueFisico, 80), S(Atributo.DanoCritico, 0.02f));
		Item("anel_sabio", "Anel do Sabio Cinzento", Slot.Anel, Grade.Raro, "item_anel", S(Atributo.AtaqueMagico, 110), S(Atributo.PenetracaoMagica, 0.02f), S(Atributo.Critico, 0.015f));
		Item("anel_rainha", "Anel da Rainha Escarlate", Slot.Anel, Grade.Lendario, "item_anel", S(Atributo.AtaqueFisico, 180),
			S(Atributo.Critico, 0.03f), S(Atributo.DanoCritico, 0.08f), S(Atributo.PenetracaoFisica, 0.03f), S(Atributo.Evasao, 0.015f), S(Atributo.EvasaoCritico, 0.02f));
		// Colar
		Item("colar_lobo", "Colar de Dente de Lobo", Slot.Colar, Grade.Comum, "item_colar", S(Atributo.Vida, 1500), S(Atributo.DefesaCritico, 0.02f));
		Item("pingente_aurora", "Pingente da Aurora", Slot.Colar, Grade.Epico, "item_colar", S(Atributo.Vida, 3500),
			S(Atributo.Defesa, 0.015f), S(Atributo.DefesaCritico, 0.04f), S(Atributo.EvasaoCritico, 0.02f));
		ItemDef esfera = Item("colar_esfera", "Colar da Esfera Runica", Slot.Colar, Grade.Epico, "item_colar", S(Atributo.Vida, 3000),
			S(Atributo.Critico, 0.02f), S(Atributo.DanoCritico, 0.04f), S(Atributo.Evasao, 0.01f));
		esfera.magia = Magia.EsferaRunica;
		esfera.chanceMagia = 0.06f;
		esfera.esperaMagia = 6f;
		esfera.descricaoMagia = "6% de chance ao causar dano: uma esfera runica gira em volta do heroi por 1,5 s (2 acertos de 80%). Espera de 6 s.";

		// Reliquias (valores do nivel 1 e quanto sobe por nivel, ate o 10)
		Reliquia("calice", "Calice da Fonte Serena", TipoReliquia.Calice, "rel_calice", new Color(0.4f, 1.6f, 0.9f), 50f, 0.06f, 0.0045f, 0f, 0f, 0f, 0f, 0f,
			"Cura {v} da vida maxima.");
		Reliquia("egide", "Egide do Bastiao", TipoReliquia.Egide, "rel_egide", new Color(1.6f, 1.3f, 0.5f), 45f, 0.06f, 0.005f, 0.03f, 0.0025f, 5f, 0f, 0f,
			"Barreira que absorve {v} da vida maxima por {d}, com +{v2} de defesa.");
		Reliquia("estandarte", "Estandarte da Furia", TipoReliquia.Estandarte, "rel_estandarte", new Color(1.8f, 0.5f, 0.3f), 45f, 0.05f, 0.01f, 0f, 0f, 8f, 0f, 5f,
			"Planta um estandarte: dentro de {r} voce causa +{v} de dano por {d}.");
		Reliquia("pilar", "Pilar do Inverno Eterno", TipoReliquia.Pilar, "rel_pilar", new Color(0.5f, 1.2f, 2f), 40f, 0.2f, 0.02f, 0f, 0f, 4f, 0.11f, 4f,
			"Pilar de gelo: inimigos a ate {r} ficam {v} mais lentos por {d}.");
		Reliquia("vento", "Sapatilhas do Vento Fugaz", TipoReliquia.Vento, "rel_vento", new Color(0.7f, 1.8f, 1.4f), 20f, 0.4f, 0.03f, 0f, 0f, 1.5f, 0.1f, 0f,
			"+{v} de velocidade por {d} (diminuindo aos poucos) e tira as lentidoes.");
		Reliquia("totem", "Totem do Espirito Guardiao", TipoReliquia.Totem, "rel_totem", new Color(0.8f, 0.6f, 2f), 55f, 0.6f, 0.06f, 0f, 0f, 8f, 0f, 8f,
			"Invoca um espirito parado por {d} que atira no inimigo a ate {r}: {v} do ATK por tiro, 1 por segundo.");

		AssetDatabase.SaveAssets();
		Debug.Log("[Itens] 18 itens, 1 conjunto e 6 reliquias criados/atualizados");
	}

	static ItemDef Item(string id, string nome, Slot slot, Grade grade, string icone, StatItem principal, params StatItem[] sec)
	{
		ItemDef d = Asset<ItemDef>($"{PastaItens}/{id}.asset");
		d.id = id;
		d.nome = nome;
		d.slot = slot;
		d.grade = grade;
		d.icone = icone;
		d.principal = principal;
		d.secundarios = new List<StatItem>(sec);
		d.conjunto = null;
		d.magia = Magia.Nenhuma;
		d.chanceMagia = 0f;
		d.descricaoMagia = "";
		EditorUtility.SetDirty(d);
		return d;
	}

	static void Reliquia(string id, string nome, TipoReliquia tipo, string icone, Color cor, float recarga, float v, float vNivel, float v2, float v2Nivel, float dur, float durNivel, float raio, string desc)
	{
		ReliquiaDef r = Asset<ReliquiaDef>($"{PastaReliquias}/{id}.asset");
		r.id = id;
		r.nome = nome;
		r.tipo = tipo;
		r.icone = icone;
		r.cor = cor;
		r.recarga = recarga;
		r.valor = v;
		r.valorPorNivel = vNivel;
		r.valor2 = v2;
		r.valor2PorNivel = v2Nivel;
		r.duracao = dur;
		r.duracaoPorNivel = durNivel;
		r.raio = raio;
		r.descricao = desc;
		EditorUtility.SetDirty(r);
	}

	static T Asset<T>(string caminho) where T : ScriptableObject
	{
		T a = AssetDatabase.LoadAssetAtPath<T>(caminho);
		if (a == null)
		{
			a = ScriptableObject.CreateInstance<T>();
			AssetDatabase.CreateAsset(a, caminho);
		}
		return a;
	}
}
