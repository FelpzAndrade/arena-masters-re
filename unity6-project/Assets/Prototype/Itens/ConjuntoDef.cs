using System.Collections.Generic;
using UnityEngine;

// Conjunto de equipamentos: bonus quando o heroi usa 2, 3 ou 4 pecas dele ao mesmo tempo (os bonus somam).
public class ConjuntoDef : ScriptableObject
{
	public string nome;
	public List<StatItem> bonus2 = new List<StatItem>();
	public List<StatItem> bonus3 = new List<StatItem>();
	public List<StatItem> bonus4 = new List<StatItem>();   // pronto para uma 4a peca (o conjunto inicial tem 3)

	public List<StatItem> Bonus(int pecas)
	{
		List<StatItem> r = new List<StatItem>();
		if (pecas >= 2)
		{
			r.AddRange(bonus2);
		}
		if (pecas >= 3)
		{
			r.AddRange(bonus3);
		}
		if (pecas >= 4)
		{
			r.AddRange(bonus4);
		}
		return r;
	}
}
