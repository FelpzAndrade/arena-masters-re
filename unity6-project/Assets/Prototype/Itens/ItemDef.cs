using System.Collections.Generic;
using UnityEngine;

// Um equipamento (ScriptableObject em Prototype/Resources/Itens, criado pelo menu Arena Masters/Itens/Criar itens iniciais).
// Valores no +0 ja com a grade; cada nivel de aprimoramento (+1 a +10) da +8% do atributo principal.
public class ItemDef : ScriptableObject
{
	public string id;
	public string nome;
	public Slot slot;
	public Grade grade;
	public string icone = "item_espada";        // Resources/Icones/<icone>
	public StatItem principal;
	public List<StatItem> secundarios = new List<StatItem>();
	public ConjuntoDef conjunto;                // tipo "de conjunto"
	public Magia magia;                         // tipo "magico"
	public float chanceMagia;                   // chance ao causar dano (0,08 = 8%)
	public float esperaMagia = 3f;              // segundos minimos entre dois disparos
	[TextArea] public string descricaoMagia;

	public const int NivelMaximo = 10;
	public const float BonusPorNivel = 0.08f;

	public float Principal(int nivel) => principal.valor * (1f + BonusPorNivel * nivel);

	// ouro para ir do nivel atual ao proximo: 500 x (nivel+1)^2 x grade (estimativa)
	public int CustoAprimorar(int nivel) => Mathf.RoundToInt(500f * (nivel + 1) * (nivel + 1) * Atributos.MultGrade[(int)grade] / 10f) * 10;

	public string Tipo => magia != Magia.Nenhuma ? "Magico" : conjunto != null ? "Conjunto" : "Normal";
}
