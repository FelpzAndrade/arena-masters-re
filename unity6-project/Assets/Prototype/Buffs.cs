using System.Collections.Generic;
using CS;
using UnityEngine;

// Buffs do prototipo. Os modificadores de atributo usam a classe original CSBuffInfo (herda CharStatus),
// somados ao status do lutador pelo CharStatus.Merge reconstruido. Regras de duracao, linha/rank,
// tiques e gatilhos seguem o XModuleBuff/XBuff do jogo (ver decomp/buff_rules.md).
public class BuffDef
{
	public int id;
	public string name;
	public BuffType type = BuffType.Buff;
	public float duration = 3f;
	public string line;                    // buffs da mesma linha nao acumulam: o de maior rank vence
	public int rank = 1;
	public MotionControlType control = MotionControlType.None;
	public float slowRatio;                // reducao de velocidade (Slow)
	public float dotPerMaxHp;              // dano por tique em fracao da vida maxima (m_fDotDamagePerMaxHP)
	public float hotPerMaxHp;              // cura por tique (m_fHotHealPerMaxHP)
	public float shieldPerMaxHp;           // barreira que absorve dano (XShieldBuff), em fracao da vida maxima
	public float period = 1f;              // intervalo do tique (m_fPeriod)
	public int maxStack = 1;               // XBuff.Reapply: mesmo buff reaplicado acumula ate o maximo e renova o tempo
	public bool clearOnDie = true;         // strClearOnDie: so esses saem quando o lutador morre
	public Color color = Color.white;
	public string auraTexture = "magic_02";
	public string auraPrefab;              // efeito proprio (Assets/VFX/Resources) no lugar da aura de textura
	public CSBuffInfo stats = new CSBuffInfo();

	public BuffDef WithStats(System.Action<CSBuffInfo> apply)
	{
		apply(stats);
		return this;
	}
}

// gatilho de buff ligado a uma skill (m_nProcTimingType / m_nProcRate)
public class BuffProc
{
	public ProcTimingType timing = ProcTimingType.Hit;
	public int rate = 100;                 // chance em %
	public BuffDef buff;
	public bool onSelf;                    // aplica no proprio lutador em vez do alvo
}

public class ActiveBuff
{
	public BuffDef def;
	public Fighter source;
	public float remaining;
	public float tickTimer;
	public int stack = 1;
	public int tickDamage;                 // % da vida maxima x stack, fixado na aplicacao (XBuff 0x1A99238)
	public float shield;                   // quanto a barreira ainda absorve
	public GameObject aura;
}

public static class BuffLibrary
{
	public static readonly BuffDef Furia = new BuffDef
	{
		id = 1001, name = "Furia", type = BuffType.Buff, duration = 6f, line = "furia",
		color = new Color(1f, 0.35f, 0.15f), auraTexture = "flame_01",
	}.WithStats(s => { s.PhysicalDamage.ratio = 0.3f; s.MovingSpeed.ratio = 0.2f; });

	public static readonly BuffDef Sangramento = new BuffDef
	{
		id = 1002, name = "Sangramento", type = BuffType.Debuff, duration = 4f, line = "sangramento",
		dotPerMaxHp = 0.008f, period = 1f, maxStack = 3, color = new Color(0.8f, 0.05f, 0.05f), auraTexture = "spark_05",
	};

	public static readonly BuffDef Atordoado = new BuffDef
	{
		id = 1003, name = "Atordoado", type = BuffType.Debuff, duration = 1.1f, line = "controle",
		control = MotionControlType.Stun, color = new Color(1f, 0.9f, 0.3f), auraTexture = "star_04",
	};

	public static readonly BuffDef Enfraquecido = new BuffDef
	{
		id = 2001, name = "Enfraquecido", type = BuffType.Debuff, duration = 4f, line = "enfraquecer",
		color = new Color(0.6f, 0.3f, 0.9f), auraTexture = "smoke_07",
	}.WithStats(s => { s.MagicalDefense.value = -0.15f; s.PhysicalDefense.value = -0.1f; });

	public static readonly BuffDef Lentidao = new BuffDef
	{
		id = 2002, name = "Lentidao", type = BuffType.Debuff, duration = 3f, line = "lentidao",
		control = MotionControlType.Slow, slowRatio = 0.4f, color = new Color(0.4f, 0.7f, 1f), auraTexture = "twirl_03",
	};

	public static readonly BuffDef EscudoArcano = new BuffDef
	{
		id = 2003, name = "Escudo Arcano", type = BuffType.Buff, duration = 3f, line = "escudo",
		color = new Color(0.5f, 0.6f, 1f), auraTexture = "circle_03",
	}.WithStats(s => { s.MagicalDefense.value = 0.3f; s.PhysicalDefense.value = 0.2f; });

	// ---- herois da wiki ----

	// Axie, Golpe da Terra: DEF +5% e velocidade, acumula 2x, 3s
	public static readonly BuffDef ForcaDaTerra = new BuffDef
	{
		id = 3001, name = "Forca da Terra", type = BuffType.Buff, duration = 3f, line = "forca_terra", maxStack = 2,
		color = new Color(0.85f, 0.6f, 0.3f), auraTexture = "dirt_02",
	}.WithStats(s => { s.PhysicalDefense.value = 0.05f; s.MagicalDefense.value = 0.05f; s.MovingSpeed.ratio = 0.1f; });

	public static readonly BuffDef LentidaoCurta = new BuffDef
	{
		id = 3002, name = "Lento", type = BuffType.Debuff, duration = 1.5f, line = "lentidao",
		control = MotionControlType.Slow, slowRatio = 0.3f, color = new Color(0.4f, 0.7f, 1f), auraTexture = "twirl_03",
	};

	// Axie, Corneta de Guerra: barreira de 10% da vida maxima por 3s
	public static readonly BuffDef BarreiraCorneta = new BuffDef
	{
		id = 3003, name = "Barreira", type = BuffType.Buff, duration = 3f, line = "barreira", shieldPerMaxHp = 0.1f,
		color = new Color(1f, 0.85f, 0.4f), auraTexture = "circle_03", auraPrefab = "VFX_EscudoCorneta",
	};

	// Spark, passiva Eletrocutar: deixa muito lento
	public static readonly BuffDef Eletrocutado = new BuffDef
	{
		id = 3004, name = "Eletrocutado", type = BuffType.Debuff, duration = 1.5f, line = "lentidao", rank = 2,
		control = MotionControlType.Slow, slowRatio = 0.55f, color = new Color(0.45f, 0.85f, 1f), auraTexture = "spark_04",
	};

	// Spark, Relampago: +10% de dano magico, acumula 3x, 4s
	public static readonly BuffDef CargaDePoder = new BuffDef
	{
		id = 3005, name = "Carga de Poder", type = BuffType.Buff, duration = 4f, line = "carga_poder", maxStack = 3,
		color = new Color(0.5f, 0.8f, 1f), auraTexture = "spark_05",
	}.WithStats(s => { s.MagicalDamageAmp.value = 0.1f; });

	public static readonly BuffDef Pressa = new BuffDef
	{
		id = 3006, name = "Pressa", type = BuffType.Buff, duration = 1.5f, line = "pressa",
		color = new Color(0.6f, 1f, 0.8f), auraTexture = "trace_02",
	}.WithStats(s => { s.MovingSpeed.ratio = 0.2f; });

	// "Inconsciente" da wiki = atordoamento (Stun) com a duracao de cada skill
	private static readonly Dictionary<float, BuffDef> s_stuns = new Dictionary<float, BuffDef>();

	public static BuffDef Inconsciente(float duration)
	{
		if (!s_stuns.TryGetValue(duration, out BuffDef b))
		{
			b = new BuffDef
			{
				id = 3100 + s_stuns.Count, name = "Inconsciente", type = BuffType.Debuff, duration = duration, line = "controle",
				control = MotionControlType.Stun, color = new Color(1f, 0.9f, 0.3f), auraTexture = "star_04",
			};
			s_stuns[duration] = b;
		}
		return b;
	}

	public static readonly BuffDef Queimadura = new BuffDef
	{
		id = 2004, name = "Queimadura Arcana", type = BuffType.Debuff, duration = 3f, line = "queimadura",
		dotPerMaxHp = 0.012f, period = 0.5f, color = new Color(1f, 0.4f, 0.9f), auraTexture = "flame_01",
	};
}
