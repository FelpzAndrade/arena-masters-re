using System;
using CS;
using UnityEngine;

// Definicao de skill do prototipo. Os numeros sao estimados: as tabelas reais (skill.xml) vinham do servidor.
[Serializable]
public class SkillDef
{
	public string name;
	public System.Collections.Generic.List<BuffProc> procs = new System.Collections.Generic.List<BuffProc>();
	public string vfx;                // efeito: slash, spin, slam, beam, burst, magicspin, dust, teleport
	public string anim;               // clipe KayKit tocado durante a skill (ajustado ao tempo windup+recovery)
	public SkillDamageTypes damageType = (SkillDamageTypes)1;
	public float damageRatio = 1f;
	public float cooldown = 1f;
	public float windup = 0.2f;       // tempo ate o golpe sair
	public float recovery = 0.25f;    // tempo travado depois do golpe
	public float range = 2f;          // alcance (ou raio da area se areaAtTarget)
	public float angle = 90f;         // abertura do cone em graus (360 = em volta)
	public bool areaAtTarget;         // area centrada no alvo (magia a distancia)
	public float castRange;           // alcance maximo para mirar a area
	public float dashDistance;        // avanco durante a skill
	// controles de movimento aplicados no acerto (distancia d do buff MF: fMotionControlDistance)
	public float knockbackDistance;   // Knockback: empurra para longe
	public float airborneHeight;      // Airborne: joga para cima no lugar
	public float throwupDistance;     // Throwup: joga para cima e para longe (8 u/s)
	public float throwDistance;       // Throw: arremesso baixo e longo (12,5 u/s)
	public float beatenDuration;      // Beaten: "apanhando" curto (CSSkillInfo.beatenDuration / beatenDistance)
	public float beatenDistance = 0.3f;
	public float blinkDistance;       // teleporte (sem dano)
	public float lineWidth;           // > 0: golpe em linha reta (retangulo de 'range' x 'lineWidth') que atravessa
	public bool pushSideways;         // empurra para o lado da linha (Divisor de Terra)
	public bool rockWall;             // levanta pedras ao longo da linha que bloqueiam a passagem
	// carga da ultimate no 1o acerto de cada uso: CSSkillInfo.ultimateCharge (0x240), somado em XUltimateSkillCharger.ChargeOnHit.
	// O valor de cada skill vinha da tabela do servidor; aqui e estimado (barra de 10.000 = "Rage" da wiki).
	public float ultimateCharge = 700f;
	public float pullDistance;        // > 0: puxa o alvo para o centro da area a cada acerto (MotionControlType.Pull)
	// fluidez (inspirado no original: ComboSkillData, IsCurrentSkillMovable, IsCancelable, XSkillProjectile)
	public SkillDef[] combo;          // golpes seguintes do combo (apertando de novo dentro da janela)
	public float comboWindow = 0.7f;
	public bool movable;              // da para andar durante a skill (metade da velocidade)
	public bool cancelable = true;    // a esquiva interrompe a skill
	public float projectileSpeed;     // > 0: o golpe sai como projetil que pode ser esquivado
	public float projectileRadius = 0.5f;
	public int projectileCount = 1;
	public float projectileSpread;    // graus entre projeteis
	public float hitstop = 0.05f;     // congela o jogo no impacto (peso do golpe)
	public int hitCount = 1;          // golpes repetidos depois do windup (ultimates)
	public float hitInterval = 0.3f;
	public float areaJitter;          // espalha cada golpe de area em volta da mira (chuva)
	public bool superArmor;           // nao e interrompida nem empurrada (ultimates)
	public float shake;               // tremor de camera no impacto
	public Color color = Color.white;
	// bonus da skill aplicados como atributos (CSSkillInfo herda de CharStatus no jogo)
	public float bonusAttackRatio;
	public float bonusCritical;

	public CSSkillInfo BuildInfo(int id)
	{
		CSSkillInfo info = new CSSkillInfo();
		info.nID = id;
		info.DamageType = damageType;
		info.damageRatio = damageRatio;
		info.PhysicalDamage.ratio = bonusAttackRatio;
		info.MagicalDamage.ratio = bonusAttackRatio;
		info.Critical.value = bonusCritical;
		return info;
	}
}
