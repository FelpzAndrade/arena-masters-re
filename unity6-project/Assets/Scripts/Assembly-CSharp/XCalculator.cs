using UnityEngine;
using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200107B")]
public class XCalculator
{
	[Token(Token = "0x200107C")]
	public class SkillParam
	{
		[Token(Token = "0x40058D0")]
		[FieldOffset(Offset = "0x8")]
		public float gameModeDamageMod;

		[Token(Token = "0x40058D1")]
		[FieldOffset(Offset = "0xC")]
		public IActor attacker;

		[Token(Token = "0x40058D2")]
		[FieldOffset(Offset = "0x10")]
		public IActor victim;

		[Token(Token = "0x40058D3")]
		[FieldOffset(Offset = "0x14")]
		public CSSkillInfo skillInfo;

		[Token(Token = "0x6007C60")]
		[Address(RVA = "0x1A9CF30", Offset = "0x1A9CF30", VA = "0x1A9CF30")]
		public SkillParam()
		{
			gameModeDamageMod = 1f;
		}

		[Token(Token = "0x6007C61")]
		[Address(RVA = "0x1A9B27C", Offset = "0x1A9B27C", VA = "0x1A9B27C")]
		public CharStatus MakeAttackerSkillModifier()
		{
			CharStatus modifier = CharStatus.New();
			if (skillInfo == null || attacker == null)
			{
				return modifier;
			}
			modifier.Merge(attacker.Status, 1f);
			modifier.Merge(skillInfo, 1f);
			XModuleActor.CharacterStatus original = attacker.OriginalStatus;
			if (original == null || original.SkillSpecialized == null)
			{
				return modifier;
			}
			// especializacao de skill so vale nos modos que a habilitam
			GameModeInstanceInfo instanceInfo = XGlobal.GameData.GameModeInstanceInfo;
			Room room = XGlobal.PhotonManager.instance.room;
			if (!XGameHelper.UseSkillSpecialize(instanceInfo, room))
			{
				return modifier;
			}
			XGlobal.proto.SkillSpecialization.MergeTotalSpecializeStatusGrowth_Skill(modifier, skillInfo, attacker.OriginalStatus.SkillSpecialized);
			return modifier;
		}

		[Token(Token = "0x6007C62")]
		[Address(RVA = "0x1A9CA94", Offset = "0x1A9CA94", VA = "0x1A9CA94")]
		public float GetTotalDamageRatio()
		{
			XModuleActor.CharacterStatus original = attacker.OriginalStatus;
			if (original.SkillSpecialized == null)
			{
				return 0f;
			}
			return XGlobal.proto.SkillSpecialization.GetTotalDamageRatio(skillInfo, attacker.OriginalStatus.SkillSpecialized, (SpecializeType)0);
		}
	}

	[Token(Token = "0x6007C57")]
	[Address(RVA = "0x1A9AF80", Offset = "0x1A9AF80", VA = "0x1A9AF80")]
	public XCalculator()
	{
	}

	[Token(Token = "0x6007C58")]
	[Address(RVA = "0x1A9AF88", Offset = "0x1A9AF88", VA = "0x1A9AF88")]
	public static bool CheckHit(SkillParam param)
	{
		CharStatus modifier = param.MakeAttackerSkillModifier();
		float accuracy = param.attacker == null ? 1f : modifier.Accuracy.Calc() + 1f;
		float agility = param.victim.Status.Agility.Calc();
		bool hit = XHelper.DiceRate((accuracy - agility) * 100f);
		modifier?.Dispose();
		return hit;
	}

	[Token(Token = "0x6007C59")]
	[Address(RVA = "0x1A9B740", Offset = "0x1A9B740", VA = "0x1A9B740")]
	public static bool CheckCritical(SkillParam param)
	{
		if (param.attacker == null)
		{
			return false;
		}
		CharStatus modifier = param.MakeAttackerSkillModifier();
		float critical = modifier.Critical.Calc();
		float flexibility = param.victim.Status.Flexibility.Calc();
		bool result = XHelper.DiceRate((critical - flexibility) * 100f);
		modifier?.Dispose();
		return result;
	}

	[Token(Token = "0x6007C5A")]
	[Address(RVA = "0x1A9BA40", Offset = "0x1A9BA40", VA = "0x1A9BA40")]
	public static float CalcCriticalDamageRatio(SkillParam param, float minCriticaDamage)
	{
		CharStatus modifier = param.MakeAttackerSkillModifier();
		float criticalDamage = param.attacker == null ? 2f : modifier.CriticalDamage.Calc() + 2f;
		float defense = param.victim.Status.CriticalDamageDefense.Calc();
		float ratio = Mathf.Max(criticalDamage - defense, 0f);
		modifier?.Dispose();
		return Mathf.Max(minCriticaDamage, ratio);
	}

	[Token(Token = "0x6007C5B")]
	[Address(RVA = "0x1A9BD70", Offset = "0x1A9BD70", VA = "0x1A9BD70")]
	public static int CalcSkillHealRatioPerMaxHp(XModuleActor actor, float healPercent)
	{
		return (int)(actor.FinalMaxHP * healPercent);
	}

	[Token(Token = "0x6007C5C")]
	[Address(RVA = "0x1A9BDB8", Offset = "0x1A9BDB8", VA = "0x1A9BDB8")]
	public static int CalcSkillDamage(SkillParam param, float correctFactor, out float pureAttackDmg)
	{
		pureAttackDmg = 0f;
		CSSkillInfo skill = param.skillInfo;
		if (skill.damageRatio == 0f || param.attacker == null)
		{
			return 0;
		}
		CharStatus modifier = param.MakeAttackerSkillModifier();
		float defenseOnDeathsDoor = param.victim.Status.AmplyDefenseOnDeathsDoor.Calc();
		float damageOnDeathsDoor = param.attacker.Status.AmplyDamageOnDeathsDoor.Calc();
		float attack;
		float amp;
		float defense;
		float penetration;
		float fixedDefense;
		int result = 0;
		switch (skill.DamageType)
		{
			case (SkillDamageTypes)1:
				attack = modifier.PhysicalDamage.Calc();
				amp = modifier.PhysicalDamageAmp.Calc();
				defense = param.victim.Status.PhysicalDefense.Calc();
				penetration = modifier.PhysicalPenetration.Calc();
				fixedDefense = param.victim.Status.PhysicalDefense_Fix.Calc();
				break;
			case (SkillDamageTypes)2:
				attack = modifier.MagicalDamage.Calc();
				amp = modifier.MagicalDamageAmp.Calc();
				defense = param.victim.Status.MagicalDefense.Calc();
				penetration = modifier.MagicalPenetration.Calc();
				fixedDefense = param.victim.Status.MagicalDefense_Fix.Calc();
				break;
			default:
				CSLog.Error("invalid skill damage type : " + skill.DamageType + " / " + skill.nID);
				modifier?.Dispose();
				return 0;
		}
		// alvo "a beira da morte": soma os bonus de defesa (alvo) e de dano (atacante)
		if (param.victim.IsDeathDoor())
		{
			defense = defenseOnDeathsDoor + defense;
			amp = damageOnDeathsDoor + amp;
		}
		pureAttackDmg = attack;
		float totalDamageRatio = param.GetTotalDamageRatio();
		if (pureAttackDmg != 0f)
		{
			float defenseRate = Math.Min(0.8f, Math.Max(0f, defense - penetration));
			// o ARM (VFP) arredonda cada operacao para float; os casts reproduzem o resultado bit a bit
			float damage = (float)((float)((float)((float)(totalDamageRatio + skill.damageRatio) * (float)(attack - (float)(fixedDefense * correctFactor))) * (float)(amp + 1f)) * (float)(1f - defenseRate));
			damage = (float)(damage * param.gameModeDamageMod);
			result = damage > 0f ? (int)damage : 1;
		}
		modifier?.Dispose();
		return result;
	}

	[Token(Token = "0x6007C5D")]
	[Address(RVA = "0x1A9CD08", Offset = "0x1A9CD08", VA = "0x1A9CD08")]
	public static float CalcMotionControlTime(float fTime, float fToughness)
	{
		return Math.Min(200f, (1f - fToughness) * fTime);
	}

	[Token(Token = "0x6007C5E")]
	[Address(RVA = "0x1A9CD34", Offset = "0x1A9CD34", VA = "0x1A9CD34")]
	public static float CalcMotionControlAirborneTime(float fHeight, float fWeight)
	{
		float time = Math.Min(20f, (fWeight / -10f + 2f) * fHeight) / XGameConst.AIRBORNE_SPEED;
		return time + time;
	}

	[Token(Token = "0x6007C5F")]
	[Address(RVA = "0x1A9CE34", Offset = "0x1A9CE34", VA = "0x1A9CE34")]
	public static float CalcMotionControlKnockbackTime(float fDistance, float fWeight)
	{
		return Math.Min(50f, (fWeight / -10f + 2f) * fDistance) / XGameConst.KNOCKBACK_SPEED;
	}
}
