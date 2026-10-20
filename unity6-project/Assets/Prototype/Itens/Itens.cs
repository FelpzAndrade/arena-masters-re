using System;
using CS;
using UnityEngine;

// Tipos comuns dos equipamentos (Docs/ficha_itens_referencia.md). Os atributos sao os que o combate reconstruido ja usa
// (XCalculator: ataque, defesa, penetracao, critico, dano critico, defesa contra critico; CheckHit/CheckCritical: evasao).
public enum Slot { Arma, Peitoral, Botas, Luvas, Anel, Colar }

public enum Grade { Comum, Raro, Epico, Lendario }

public enum Atributo
{
	AtaqueFisico, AtaqueMagico, Defesa, Vida,                                // principais
	Critico, DanoCritico, Evasao, EvasaoCritico, DefesaCritico, PenetracaoFisica, PenetracaoMagica,   // secundarios
}

// habilidade dos itens magicos (chance ao causar dano)
public enum Magia { Nenhuma, Relampago, EsferaRunica }

[Serializable]
public struct StatItem
{
	public Atributo atributo;
	public float valor;   // ataque e vida: pontos; o resto: fracao (0,03 = 3%)

	public StatItem(Atributo a, float v)
	{
		atributo = a;
		valor = v;
	}
}

public static class Atributos
{
	public static readonly string[] Nomes = { "Ataque fisico", "Ataque magico", "Defesa", "Vida", "Critico", "Dano critico", "Evasao", "Evasao de critico", "Defesa contra critico", "Penetracao fisica", "Penetracao magica" };
	public static readonly string[] NomesSlot = { "Arma", "Peitoral", "Botas", "Luvas", "Anel", "Colar" };
	public static readonly string[] NomesGrade = { "Comum", "Raro", "Epico", "Lendario" };
	public static readonly Color[] CoresGrade = { new Color(0.62f, 0.62f, 0.64f), new Color(0.3f, 0.6f, 1f), new Color(0.7f, 0.35f, 1f), new Color(1f, 0.78f, 0.25f) };
	public static readonly float[] MultGrade = { 1f, 1.25f, 1.55f, 1.9f };   // custo de aprimorar (o valor do item ja vem com a grade)

	public static bool EmPontos(Atributo a) => a == Atributo.AtaqueFisico || a == Atributo.AtaqueMagico || a == Atributo.Vida;

	public static string Texto(Atributo a, float v) => EmPontos(a) ? $"{v:0}" : $"{v * 100f:0.##}%";

	// soma o atributo no status do heroi (mesmos campos que o calculo de dano le)
	public static void Somar(CharStatus s, Atributo a, float v)
	{
		switch (a)
		{
			case Atributo.AtaqueFisico: s.PhysicalDamage.value += v; break;
			case Atributo.AtaqueMagico: s.MagicalDamage.value += v; break;
			case Atributo.Defesa: s.PhysicalDefense.value += v; s.MagicalDefense.value += v; break;
			case Atributo.Vida: s.MaxHP.value += v; break;
			case Atributo.Critico: s.Critical.value += v; break;
			case Atributo.DanoCritico: s.CriticalDamage.value += v; break;
			case Atributo.Evasao: s.Agility.value += v; break;
			case Atributo.EvasaoCritico: s.Flexibility.value += v; break;
			case Atributo.DefesaCritico: s.CriticalDamageDefense.value += v; break;
			case Atributo.PenetracaoFisica: s.PhysicalPenetration.value += v; break;
			case Atributo.PenetracaoMagica: s.MagicalPenetration.value += v; break;
		}
	}
}
