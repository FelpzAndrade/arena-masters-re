using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XUIEnum;

[Token(Token = "0x2000465")]
public class XModuleHit : XModuleBase
{
	[Token(Token = "0x2000466")]
	public class XDelayedDamageParam
	{
		[Token(Token = "0x40015E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_fElapsedTime;

		[Token(Token = "0x40015E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m_fTime;

		[Token(Token = "0x40015E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bDone;

		[Token(Token = "0x40015E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public XModuleEntity attackerME;

		[Token(Token = "0x40015E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XModuleEntity victimME;

		[Token(Token = "0x40015E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public XModuleEntity goSkill;

		[Token(Token = "0x40015E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CSSkillInfo attackerSkillInfo;

		[Token(Token = "0x40015E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint skillUID;

		[Token(Token = "0x40015E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int nDamage;

		[Token(Token = "0x40015EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int nPureDamage;

		[Token(Token = "0x40015EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool bCritical;

		[Token(Token = "0x40015EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool bIsDropObject;

		[Token(Token = "0x40015ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool bDodged;

		[Token(Token = "0x60024C7")]
		[Address(RVA = "0xB60F34", Offset = "0xB60F34", VA = "0xB60F34")]
		public XDelayedDamageParam()
		{
		}
	}

	[Token(Token = "0x40015DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_isReady;

	[Token(Token = "0x40015DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float damageCorrectFacotr;

	[Token(Token = "0x40015DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_isTimeOverInvincible;

	[Token(Token = "0x40015DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public List<XDelayedDamageParam> m_DelayedDamageProcessData;

	[Token(Token = "0x40015E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool IsTimeOverInvincible__BackingField;

	[Token(Token = "0x1700060C")]
	public bool IsTimeOverInvincible
	{
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0xB5F094", Offset = "0xB5F094", VA = "0xB5F094")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0xB5F09C", Offset = "0xB5F09C", VA = "0xB5F09C")]
		set
		{
		}
	}

	[Token(Token = "0x60024A1")]
	[Address(RVA = "0xB5EFE0", Offset = "0xB5EFE0", VA = "0xB5EFE0")]
	public XModuleHit()
	{
	}

	[Token(Token = "0x60024A4")]
	[Address(RVA = "0xB5F0A4", Offset = "0xB5F0A4", VA = "0xB5F0A4", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60024A5")]
	[Address(RVA = "0xB5F4B0", Offset = "0xB5F4B0", VA = "0xB5F4B0", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x60024A6")]
	[Address(RVA = "0xB5F5EC", Offset = "0xB5F5EC", VA = "0xB5F5EC", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x60024A7")]
	[Address(RVA = "0xB5F5F8", Offset = "0xB5F5F8", VA = "0xB5F5F8")]
	public void OnActorNotReady()
	{
	}

	[Token(Token = "0x60024A8")]
	[Address(RVA = "0xB5F604", Offset = "0xB5F604", VA = "0xB5F604")]
	private CSCharacterInfo GetCharacterInfo(XModuleEntity me)
	{
		return null;
	}

	[Token(Token = "0x60024A9")]
	[Address(RVA = "0xB5F6E0", Offset = "0xB5F6E0", VA = "0xB5F6E0")]
	private DamageType GetDamageType(GameObject goVictim, bool isCritical)
	{
		return default(DamageType);
	}

	[Token(Token = "0x60024AA")]
	[Address(RVA = "0xB5F7EC", Offset = "0xB5F7EC", VA = "0xB5F7EC")]
	private DamageType GetHealType(GameObject goVictim, bool isCritical)
	{
		return default(DamageType);
	}

	[Token(Token = "0x60024AB")]
	[Address(RVA = "0xB5F814", Offset = "0xB5F814", VA = "0xB5F814")]
	private bool IsMine()
	{
		return default(bool);
	}

	[Token(Token = "0x60024AC")]
	[Address(RVA = "0xB5F708", Offset = "0xB5F708", VA = "0xB5F708")]
	private bool IsMine(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AD")]
	[Address(RVA = "0xB5F81C", Offset = "0xB5F81C", VA = "0xB5F81C")]
	private bool IsMine(XModuleEntity me)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0xB5F964", Offset = "0xB5F964", VA = "0xB5F964")]
	private bool IsNetPlayer(XModuleEntity me)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0xB5FB70", Offset = "0xB5FB70", VA = "0xB5FB70")]
	public void OnHitDotDamage(int nAttackerATID, int nDotDamage)
	{
	}

	[Token(Token = "0x60024B0")]
	[Address(RVA = "0xB6035C", Offset = "0xB6035C", VA = "0xB6035C")]
	public void OnHitHotHeal(int nHealTargetATID, int nHotHeal)
	{
	}

	[Token(Token = "0x60024B1")]
	[Address(RVA = "0xB607E0", Offset = "0xB607E0", VA = "0xB607E0", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x60024B2")]
	[Address(RVA = "0xB53EF0", Offset = "0xB53EF0", VA = "0xB53EF0")]
	public void OnHit(XModuleEntity skillME)
	{
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0xB608DC", Offset = "0xB608DC", VA = "0xB608DC")]
	private void HealProcess(float nHealRatioPermaxHp, XModuleEntity skillOwnerME, XModuleEntity healTargetME, XModuleEntity skillME, CSSkillInfo attackerSkillInfo, uint skillUID, bool bIsDropObject)
	{
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0xB609BC", Offset = "0xB609BC", VA = "0xB609BC")]
	public void DamageProcess(XModuleEntity victimME, XModuleEntity attackerME, XModuleEntity goSkill, CSSkillInfo attackerSkillInfo, uint skillUID, bool bIsDropObject)
	{
	}

	[Token(Token = "0x60024B5")]
	[Address(RVA = "0xB60434", Offset = "0xB60434", VA = "0xB60434")]
	private bool IsDoHit(XModuleEntity targetME)
	{
		return default(bool);
	}

	[Token(Token = "0x60024B6")]
	[Address(RVA = "0xB60F3C", Offset = "0xB60F3C", VA = "0xB60F3C")]
	private float fCalcSkillDelayedTime(CSSkillInfo attackerSkillInfo)
	{
		return default(float);
	}

	[Token(Token = "0x60024B7")]
	[Address(RVA = "0xB5F408", Offset = "0xB5F408", VA = "0xB5F408")]
	private void DelayedDoHitDamage(XModuleEntity attackerME, XModuleEntity victimME, XModuleEntity attackSkillME, CSSkillInfo attackerSkillInfo, uint skillUID, int nDamage, int nPureDamage, bool bIsDropObject, bool bCritical, bool bDodged)
	{
	}

	[Token(Token = "0x60024B8")]
	[Address(RVA = "0xB5FF54", Offset = "0xB5FF54", VA = "0xB5FF54")]
	public void DoHitEffect(XModuleEntity attackerME, XModuleEntity victimME, XModuleEntity attackSkillME, CSSkillInfo attackerSkillInfo, uint skillUID, int damage, int pureDamage, int heal, bool bCritical)
	{
	}

	[Token(Token = "0x60024B9")]
	[Address(RVA = "0xB61184", Offset = "0xB61184", VA = "0xB61184", Slot = "34")]
	public override void OnHitActor(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60024BA")]
	[Address(RVA = "0xB612F8", Offset = "0xB612F8", VA = "0xB612F8")]
	public void OnDrainProcess(XModuleEntity attackerME, XModuleEntity victimME, int nDamage, CSSkillInfo healSkillInfo)
	{
	}

	[Token(Token = "0x60024BB")]
	[Address(RVA = "0xB4DA88", Offset = "0xB4DA88", VA = "0xB4DA88")]
	public void DoHitDamage(XModuleEntity attackerME, XModuleEntity victimME, CSSkillInfo attackerSkillInfo, int nDamage, int pureDamage, bool bIsDropObject, bool bCritical, bool bDodged, bool bDotDamage = false)
	{
	}

	[Token(Token = "0x60024BC")]
	[Address(RVA = "0xB605CC", Offset = "0xB605CC", VA = "0xB605CC")]
	public void DoHitHeal(XModuleEntity healTargetME, int nHeal, bool bIsDropObject, bool bCritical, int fontSize = 20)
	{
	}

	[Token(Token = "0x60024BD")]
	[Address(RVA = "0xB61774", Offset = "0xB61774", VA = "0xB61774")]
	private void ShowDamage(XModuleEntity attackerME, XModuleEntity victimME, string strDamage, DamageType type)
	{
	}

	[Token(Token = "0x60024BE")]
	[Address(RVA = "0xB61CCC", Offset = "0xB61CCC", VA = "0xB61CCC")]
	private void ShowHealAmount(XModuleEntity healTargetME, string strHealAmount, int fontSize = 20)
	{
	}

	[Token(Token = "0x60024BF")]
	[Address(RVA = "0xB5FDB4", Offset = "0xB5FDB4", VA = "0xB5FDB4")]
	private bool CheckHitEnabled(XModuleEntity victimEntity, XModuleEntity attackerEntity, bool isDamage, bool instantDeath)
	{
		return default(bool);
	}

	[Token(Token = "0x60024C0")]
	[Address(RVA = "0xB61958", Offset = "0xB61958", VA = "0xB61958")]
	public void ApplyDamage(XModuleEntity attackerME, XModuleEntity victimME, int nDamage, [Optional] CSSkillInfo attackerSkillInfo, bool bDotDamage = false)
	{
	}

	[Token(Token = "0x60024C1")]
	[Address(RVA = "0xB61D70", Offset = "0xB61D70", VA = "0xB61D70")]
	public void ApplyHeal(XModuleEntity healTargetPlayer, int nHP)
	{
	}

	[Token(Token = "0x60024C2")]
	[Address(RVA = "0xB6225C", Offset = "0xB6225C", VA = "0xB6225C")]
	private bool CheckDieEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60024C3")]
	[Address(RVA = "0xB61F80", Offset = "0xB61F80", VA = "0xB61F80")]
	public void Die(XModuleEntity attackerME, CSSkillInfo attackerSkillInfo)
	{
	}

	[Token(Token = "0x60024C4")]
	[Address(RVA = "0xB60F44", Offset = "0xB60F44", VA = "0xB60F44")]
	private void CameraEffect(XModuleEntity attackerME, CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x60024C5")]
	[Address(RVA = "0xB623EC", Offset = "0xB623EC", VA = "0xB623EC")]
	private void OnDieEventToModule(CSSkillInfo attackerSkillInfo, XModuleEntity attackerME)
	{
	}

	[Token(Token = "0x60024C6")]
	[Address(RVA = "0xB62650", Offset = "0xB62650", VA = "0xB62650")]
	private void OnDie(XModuleEntity attacker)
	{
	}
}
