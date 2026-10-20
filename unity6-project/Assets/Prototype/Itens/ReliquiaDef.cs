using UnityEngine;

// Reliquia da equipe (Docs/ficha_itens_referencia.md, parte 2): habilidade ativa com recarga, botao no centro-baixo da luta.
// Valores no nivel 1; cada nivel acima soma o "porNivel" (nivel 1 a 10, aprimorar custa 3.000 x nivel de ouro, estimativa).
public enum TipoReliquia { Calice, Egide, Estandarte, Pilar, Vento, Totem }

public class ReliquiaDef : ScriptableObject
{
	public string id;
	public string nome;
	public TipoReliquia tipo;
	public string icone = "rel_calice";
	[ColorUsage(false, true)] public Color cor = Color.white;
	public float recarga = 45f;
	public float valor = 0.06f;          // efeito principal no nivel 1 (cura/barreira/dano/lentidao/velocidade/% do ATK)
	public float valorPorNivel = 0.0045f;
	public float valor2;                 // efeito secundario (DEF da Egide)
	public float valor2PorNivel;
	public float duracao = 5f;
	public float duracaoPorNivel;
	public float raio = 5f;
	[TextArea] public string descricao;  // {v} {v2} {d} {r} trocados pelos valores do nivel

	public const int NivelMaximo = 10;

	public float Valor(int nivel) => valor + valorPorNivel * (nivel - 1);
	public float Valor2(int nivel) => valor2 + valor2PorNivel * (nivel - 1);
	public float Duracao(int nivel) => duracao + duracaoPorNivel * (nivel - 1);
	public static int CustoAprimorar(int nivel) => 3000 * nivel;

	public string Texto(int nivel)
	{
		return descricao.Replace("{v}", $"{Valor(nivel) * 100f:0.##}%").Replace("{v2}", $"{Valor2(nivel) * 100f:0.##}%")
			.Replace("{d}", $"{Duracao(nivel):0.#} s").Replace("{r}", $"{raio:0.#} m");
	}
}
