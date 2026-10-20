using CS;
using UnityEngine;

// Herois do jogo original. Atributos, tempos de recarga, % de dano e efeitos das skills vem da wiki de fas
// (arena-masters-legend-begins.fandom.com, copia em wiki/herois.txt); as tabelas reais (GameData.zip) vinham do servidor.
// Tempos de preparo, alcances e duracoes que a wiki nao informa sao estimados.
public class FighterDef
{
	public string name;
	public string role;
	public Color color;
	public float moveSpeed;
	public SkillDef[] skills;              // 0 = ataque basico, 1..3 = skills A, B, C
	public SkillDef dodge;
	public SkillDef ultimate;
	public float ultMaxCharge = 10000f;    // "Rage" na wiki = m_maxCharge do XUltimateSkillCharger
	public string passiveName;
	public string passiveDesc;
	public System.Action<Fighter, Fighter, SkillDef, bool> passiveOnHit;   // dono, alvo, skill, critico
	public System.Action<CharStatus> applyStats;
	// visual: personagem KayKit (CC0) e animacoes embutidas no FBX
	public GameObject model;
	public string[] hiddenParts;
	public string animIdle;
	public string animRun;
	public string animHit;
	public string animDeath;
	public string animAirborne;
	public string animHitHeavy = "Hit_B";
	public string animGetUp = "Lie_StandUp";
	public string animCheer = "Cheer";
	public string animStrafeLeft = "Running_Strafe_Left";
	public string animStrafeRight = "Running_Strafe_Right";
	public string animBackwards = "Walking_Backwards";
	public string weapon;                  // objeto da arma para o rastro de luz

	// Axie: tanque corpo a corpo de machado (wiki: HP 80.640, ATK 3.200, DEF 22%, velocidade 7,2, peso 10)
	public static FighterDef Axie()
	{
		Color orange = new Color(1f, 0.6f, 0.2f);
		Color earth = new Color(0.85f, 0.55f, 0.25f);
		return new FighterDef
		{
			name = "Axie",
			role = "Tanque",
			color = new Color(0.85f, 0.3f, 0.2f),
			hiddenParts = new[] { "1H_Axe", "1H_Axe_Offhand", "Barbarian_Round_Shield", "Mug" },
			weapon = "2H_Axe",
			animIdle = "2H_Melee_Idle",
			animRun = "Running_A",
			animHit = "Hit_A",
			animDeath = "Death_A",
			animAirborne = "Hit_B",
			moveSpeed = 7.2f,
			applyStats = s =>
			{
				s.MaxHP.value = 80640f;
				s.PhysicalDamage.value = 3200f;
				s.MagicalDamage.value = 3200f;
				s.PhysicalDefense.value = 0.22f;
				s.MagicalDefense.value = 0.22f;
				s.Weight.value = 10f;
			},
			passiveName = "Apoio de Combate",
			passiveDesc = "Com a Forca da Terra ativa, cada acerto reduz 1s da Corneta de Guerra (recarga 4s)",
			passiveOnHit = (self, target, sd, crit) =>
			{
				if (self.passiveTimer <= 0f && self.HasBuff(BuffLibrary.ForcaDaTerra))
				{
					self.passiveTimer = 4f;
					self.cooldowns[3] = Mathf.Max(0f, self.cooldowns[3] - 1f);
				}
			},
			skills = new[]
			{
				// Machado do Guerreiro Barbaro: golpes rapidos, 110% cada
				new SkillDef
				{
					name = "Machado Barbaro", vfx = "slash", anim = "1H_Melee_Attack_Slice_Diagonal", damageRatio = 1.1f, cooldown = 0.25f, windup = 0.15f, recovery = 0.15f, ultimateCharge = 250f,
					range = 2.4f, angle = 120f, color = orange, hitstop = 0.05f, beatenDuration = 0.25f,
					combo = new[]
					{
						new SkillDef
						{
							name = "Machado Barbaro", vfx = "slash", anim = "1H_Melee_Attack_Slice_Horizontal", damageRatio = 1.1f, cooldown = 0.25f, windup = 0.15f, recovery = 0.15f, ultimateCharge = 250f,
							range = 2.4f, angle = 120f, color = orange, hitstop = 0.05f, beatenDuration = 0.25f,
						},
						new SkillDef
						{
							name = "Machado Barbaro", vfx = "slash", anim = "2H_Melee_Attack_Slice", damageRatio = 1.1f, cooldown = 0.45f, windup = 0.22f, recovery = 0.3f, ultimateCharge = 250f,
							range = 2.6f, angle = 140f, knockbackDistance = 1.5f, color = new Color(1f, 0.4f, 0.1f), hitstop = 0.09f, shake = 0.15f,
						},
					},
				},
				// A - Golpe da Terra (3s): 400%, Forca da Terra (DEF +5% e velocidade, acumula 2x, 3s), deixa o inimigo lento
				new SkillDef
				{
					name = "Golpe da Terra", vfx = "slam", anim = "2H_Melee_Attack_Chop", damageRatio = 4f, cooldown = 3f, windup = 0.35f, recovery = 0.3f,
					range = 3f, angle = 120f, color = earth, hitstop = 0.1f, shake = 0.3f,
					procs =
					{
						new BuffProc { timing = ProcTimingType.None, buff = BuffLibrary.ForcaDaTerra, onSelf = true },
						new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.LentidaoCurta },
					},
				},
				// B - Investida do Bufalo (8s): corre ate o inimigo e da uma cabecada, inconsciente 1s, 300%
				new SkillDef
				{
					name = "Investida do Bufalo", vfx = "slash", anim = "Running_B", damageRatio = 3f, cooldown = 8f, windup = 0.35f, recovery = 0.35f,
					range = 2.2f, angle = 120f, dashDistance = 6f, color = new Color(1f, 0.35f, 0.15f), hitstop = 0.12f, shake = 0.3f, cancelable = false,
					procs = { new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Inconsciente(1f) } },
				},
				// C - Corneta de Guerra (12s): barreira de 3s que absorve 10% da vida maxima
				new SkillDef
				{
					name = "Corneta de Guerra", vfx = "barrier", anim = "Cheer", damageRatio = 0f, cooldown = 12f, windup = 0.3f, recovery = 0.3f,
					range = 3f, angle = 360f, color = new Color(1f, 0.85f, 0.4f),
					procs = { new BuffProc { timing = ProcTimingType.None, buff = BuffLibrary.BarreiraCorneta, onSelf = true } },
				},
			},
			dodge = new SkillDef { name = "Rolamento", vfx = "dust", anim = "Dodge_Forward", cooldown = 4f, windup = 0f, recovery = 0.3f, dashDistance = 4.5f, damageRatio = 0f },
			// Divisor de Terra: onda de choque em linha reta (1500%) que joga os inimigos para os lados e levanta uma linha de pedras
			ultimate = new SkillDef
			{
				name = "Divisor de Terra", vfx = "terrasplitter", anim = "2H_Melee_Attack_Chop", damageRatio = 15f, cooldown = 1f, windup = 0.6f, recovery = 0.5f,
				range = 10f, angle = 14f, lineWidth = 2.6f, pushSideways = true, knockbackDistance = 3f, rockWall = true,
				superArmor = true, cancelable = false, color = new Color(1f, 0.5f, 0.15f), hitstop = 0.18f, shake = 0.6f,
			},
		};
	}

	// Spark: atacante a distancia de raios (wiki: HP 72.000, ATK 3.200, DEF 5%, critico 7,5%, velocidade 7, peso 10)
	public static FighterDef Spark()
	{
		Color red = new Color(1f, 0.3f, 0.25f);
		Color cyan = new Color(0.45f, 0.85f, 1f);
		BuffProc eletrocutar = new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.Eletrocutado };
		return new FighterDef
		{
			name = "Spark",
			role = "Atacante",
			color = new Color(0.35f, 0.55f, 1f),
			hiddenParts = new[] { "Spellbook", "Spellbook_open", "1H_Wand" },
			weapon = "2H_Staff",
			animIdle = "Idle",
			animRun = "Running_A",
			animHit = "Hit_A",
			animDeath = "Death_B",
			animAirborne = "Hit_B",
			moveSpeed = 7f,
			applyStats = s =>
			{
				s.MaxHP.value = 72000f;
				s.PhysicalDamage.value = 3200f;
				s.MagicalDamage.value = 3200f;
				s.PhysicalDefense.value = 0.05f;
				s.MagicalDefense.value = 0.05f;
				s.Critical.value = 0.075f;
				s.Weight.value = 10f;
			},
			// Eletrocutar: a ficha da wiki ja mostra o critico de 7,5% vindo da passiva; a lentidao forte vem pelo proc das skills
			passiveName = "Eletrocutar",
			passiveDesc = "+7,5% de critico; Raio Penetrante, Relampago e Onda de Raios deixam o alvo muito lento",
			skills = new[]
			{
				// Relampago do Caos: raio vermelho em linha reta, 100%
				new SkillDef
				{
					name = "Relampago do Caos", vfx = "bolt", anim = "Spellcast_Shoot", damageType = (SkillDamageTypes)2, damageRatio = 1f, cooldown = 0.3f,
					windup = 0.16f, recovery = 0.2f, range = 10f, projectileSpeed = 24f, ultimateCharge = 250f, projectileRadius = 0.5f, color = red, hitstop = 0.04f,
				},
				// A - Raio Penetrante (3,5s): raios em linha reta que atravessam os inimigos, 440%
				new SkillDef
				{
					name = "Raio Penetrante", vfx = "beam", anim = "Spellcasting", damageType = (SkillDamageTypes)2, damageRatio = 4.4f, cooldown = 3.5f,
					windup = 0.3f, recovery = 0.25f, range = 10f, angle = 12f, lineWidth = 1.4f, color = cyan, hitstop = 0.08f, shake = 0.15f,
					procs = { eletrocutar },
				},
				// B - Relampago (5s): 3 raios na area mirada (280% x3); com alvo ganha Carga de Poder (+10% dano magico, 3x, 4s); acelera
				new SkillDef
				{
					name = "Relampago", vfx = "lightning", anim = "Spellcast_Raise", damageType = (SkillDamageTypes)2, damageRatio = 2.8f, cooldown = 5f,
					windup = 0.45f, hitCount = 3, hitInterval = 0.3f, recovery = 0.25f, range = 2.2f, angle = 360f, areaAtTarget = true, castRange = 9f,
					color = cyan, hitstop = 0.06f, shake = 0.2f,
					procs =
					{
						eletrocutar,
						new BuffProc { timing = ProcTimingType.Hit, rate = 100, buff = BuffLibrary.CargaDePoder, onSelf = true },
						new BuffProc { timing = ProcTimingType.None, buff = BuffLibrary.Pressa, onSelf = true },
					},
				},
				// C - Onda de Raios (10s): ondas que empurram os inimigos, 260%; acelera
				new SkillDef
				{
					name = "Onda de Raios", vfx = "wave", anim = "Spellcast_Shoot", damageType = (SkillDamageTypes)2, damageRatio = 2.6f, cooldown = 10f,
					windup = 0.3f, recovery = 0.3f, range = 5f, angle = 110f, knockbackDistance = 4f, color = cyan, hitstop = 0.1f, shake = 0.3f,
					procs = { eletrocutar, new BuffProc { timing = ProcTimingType.None, buff = BuffLibrary.Pressa, onSelf = true } },
				},
			},
			dodge = new SkillDef { name = "Disparada", vfx = "dust", anim = "Dodge_Forward", cooldown = 4f, windup = 0f, recovery = 0.2f, dashDistance = 5f, damageRatio = 0f },
			// Ruptura Caotica: fenda a frente que suga os inimigos para o centro e da dano continuo (3,33 vezes/s, 90%)
			ultimate = new SkillDef
			{
				name = "Ruptura Caotica", vfx = "rupture", anim = "Spellcast_Long", damageType = (SkillDamageTypes)2, damageRatio = 0.9f, cooldown = 1f,
				windup = 0.45f, hitCount = 10, hitInterval = 0.3f, recovery = 0.35f, range = 3.6f, angle = 360f, areaAtTarget = true, castRange = 5f,
				pullDistance = 1.1f, superArmor = true, cancelable = false, color = new Color(0.7f, 0.45f, 1f), hitstop = 0.03f, shake = 0.12f,
			},
		};
	}
}
