using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000453")]
public class XModuleBuff : XModuleBase
{
	[Token(Token = "0x2000454")]
	private sealed class _003CApplyMF_003Ec__AnonStorey100
	{
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor user;

		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0xC")]
		internal XBuff buff;

		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleBuff _003C_003Ef__this;

		[Token(Token = "0x60023D4")]
		[Address(RVA = "0xB4CACC", Offset = "0xB4CACC", VA = "0xB4CACC")]
		public _003CApplyMF_003Ec__AnonStorey100()
		{
		}

		[Token(Token = "0x60023D5")]
		[Address(RVA = "0xB4FD10", Offset = "0xB4FD10", VA = "0xB4FD10")]
		internal void _003C_003Em__D5()
		{
		}
	}

	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x10")]
	private List<XBuff> m_listBuff;

	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x14")]
	private XBuff m_mFBuff;

	[Token(Token = "0x4001549")]
	[FieldOffset(Offset = "0x18")]
	private bool m_beatenEnable;

	[Token(Token = "0x400154A")]
	[FieldOffset(Offset = "0x19")]
	private bool m_bInvincible;

	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x1A")]
	private bool m_bImmunTrapPierce;

	[Token(Token = "0x400154C")]
	[FieldOffset(Offset = "0x1B")]
	private bool m_bInvisible;

	[Token(Token = "0x400154D")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_binBush;

	[Token(Token = "0x400154E")]
	[FieldOffset(Offset = "0x1D")]
	private bool m_bImmunMapItem;

	[Token(Token = "0x400154F")]
	[FieldOffset(Offset = "0x1E")]
	private bool m_bGhost;

	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0x20")]
	private PeriodUpdater updater;

	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x24")]
	private uint m_LastHitMeSkillUID;

	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x28")]
	private uint m_LastHitActorSkillUID;

	[Token(Token = "0x4001553")]
	[FieldOffset(Offset = "0x2C")]
	private int m_initLayer;

	[Token(Token = "0x4001554")]
	[FieldOffset(Offset = "0x30")]
	private float m_InvisibleAlpha;

	[Token(Token = "0x4001555")]
	[FieldOffset(Offset = "0x34")]
	private List<int> m_blindBuffList;

	[Token(Token = "0x4001556")]
	[FieldOffset(Offset = "0x38")]
	private XHelper.UIDChecker m_timingSelfColiderUIDChecker;

	[Token(Token = "0x4001557")]
	[FieldOffset(Offset = "0x3C")]
	private int? m_reservedID;

	[Token(Token = "0x4001558")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XBuff, bool> _003C_003Ef__am_0024cache11;

	[Token(Token = "0x4001559")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XBuff, bool> _003C_003Ef__am_0024cache12;

	[Token(Token = "0x400155A")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XBuff, bool> _003C_003Ef__am_0024cache13;

	[Token(Token = "0x17000602")]
	public bool IsInvincible
	{
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0xB4E790", Offset = "0xB4E790", VA = "0xB4E790")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000603")]
	public bool IsImmunTrapPierce
	{
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0xB4E798", Offset = "0xB4E798", VA = "0xB4E798")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000604")]
	public bool IsImmunMapItem
	{
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0xB4E7A0", Offset = "0xB4E7A0", VA = "0xB4E7A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002388")]
	[Address(RVA = "0xB4562C", Offset = "0xB4562C", VA = "0xB4562C")]
	public XModuleBuff()
	{
	}

	[Token(Token = "0x6002389")]
	[Address(RVA = "0xB45740", Offset = "0xB45740", VA = "0xB45740")]
	public List<XBuff> GetBuffList()
	{
		return null;
	}

	[Token(Token = "0x600238A")]
	[Address(RVA = "0xB45748", Offset = "0xB45748", VA = "0xB45748")]
	private void RemoveReleasedBuffOnList()
	{
	}

	[Token(Token = "0x600238B")]
	[Address(RVA = "0xB458E0", Offset = "0xB458E0", VA = "0xB458E0")]
	private void CheckDelete(Func<XBuff, bool> condition)
	{
	}

	[Token(Token = "0x600238C")]
	[Address(RVA = "0xB45A34", Offset = "0xB45A34", VA = "0xB45A34")]
	public void ReleaseBuffWithTrigging(XBuff buff)
	{
	}

	[Token(Token = "0x600238D")]
	[Address(RVA = "0xB45BB8", Offset = "0xB45BB8", VA = "0xB45BB8")]
	private void ReleaseBuffWithSync(XBuff buff)
	{
	}

	[Token(Token = "0x600238E")]
	[Address(RVA = "0xB4608C", Offset = "0xB4608C", VA = "0xB4608C")]
	public void ReleaseBuffFromRPC(int id)
	{
	}

	[Token(Token = "0x600238F")]
	[Address(RVA = "0xB45C58", Offset = "0xB45C58", VA = "0xB45C58")]
	private void ReleaseBuff(XModuleActor owner, XBuff buff)
	{
	}

	[Token(Token = "0x6002390")]
	[Address(RVA = "0xB47568", Offset = "0xB47568", VA = "0xB47568")]
	private void LostAllBuffOnDie()
	{
	}

	[Token(Token = "0x6002391")]
	[Address(RVA = "0xB3A504", Offset = "0xB3A504", VA = "0xB3A504")]
	public void LostBuffGracefully(int nBuffID)
	{
	}

	[Token(Token = "0x6002392")]
	[Address(RVA = "0xB476BC", Offset = "0xB476BC", VA = "0xB476BC")]
	public void LostAllBuffGracefully()
	{
	}

	[Token(Token = "0x6002393")]
	[Address(RVA = "0xB477E0", Offset = "0xB477E0", VA = "0xB477E0", Slot = "18")]
	public override void OnAfterActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x6002394")]
	[Address(RVA = "0xB47B80", Offset = "0xB47B80", VA = "0xB47B80")]
	private void RecreateBuffOnRevive()
	{
	}

	[Token(Token = "0x6002395")]
	[Address(RVA = "0xB48270", Offset = "0xB48270", VA = "0xB48270", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x6002396")]
	[Address(RVA = "0xB483F4", Offset = "0xB483F4", VA = "0xB483F4", Slot = "24")]
	public override void OnActorTag()
	{
	}

	[Token(Token = "0x6002397")]
	[Address(RVA = "0xB4852C", Offset = "0xB4852C", VA = "0xB4852C")]
	public void ReserveAddBuffOnRespawn(int nID)
	{
	}

	[Token(Token = "0x6002398")]
	[Address(RVA = "0xB4828C", Offset = "0xB4828C", VA = "0xB4828C")]
	public void AddReservedBuff()
	{
	}

	[Token(Token = "0x6002399")]
	[Address(RVA = "0xB48AAC", Offset = "0xB48AAC", VA = "0xB48AAC", Slot = "59")]
	public virtual void AddBuff(Vector3 colPosition, Vector3 colDirection, int nID)
	{
	}

	[Token(Token = "0x600239A")]
	[Address(RVA = "0xB4958C", Offset = "0xB4958C", VA = "0xB4958C", Slot = "60")]
	public virtual void AddBuff(XModuleActor user, XModuleEntity col, int nID, CSSkillInfo usingSkillInfo, bool isModeBuff = false)
	{
	}

	[Token(Token = "0x600239B")]
	[Address(RVA = "0xB48D34", Offset = "0xB48D34", VA = "0xB48D34")]
	protected void GainBuff(XModuleActor user, Vector3 colPos, Vector3 colDir, CSBuffInfo buffInfo, CSSkillInfo usingSkillInfo)
	{
	}

	[Token(Token = "0x600239C")]
	[Address(RVA = "0xB49C04", Offset = "0xB49C04", VA = "0xB49C04")]
	public void GainNewBuff(XModuleActor user, Vector3 colPos, Vector3 colDir, CSBuffInfo buffinfo, CSSkillInfo usingSkillInfo, float duration)
	{
	}

	[Token(Token = "0x600239D")]
	[Address(RVA = "0xB4A6C0", Offset = "0xB4A6C0", VA = "0xB4A6C0")]
	public void ReapplyBuffFromRPC(XModuleActor user, Vector3 colPos, Vector3 colDir, int buffInfoID, CSSkillInfo usingSkillInfo, int stackCount)
	{
	}

	[Token(Token = "0x600239E")]
	[Address(RVA = "0xB49A50", Offset = "0xB49A50", VA = "0xB49A50")]
	private void ReapplyBuff(XModuleActor user, Vector3 colPos, Vector3 colDir, XBuff buff, CSSkillInfo usingSkillInfo, int stackCount)
	{
	}

	[Token(Token = "0x600239F")]
	[Address(RVA = "0xB4AFB0", Offset = "0xB4AFB0", VA = "0xB4AFB0")]
	private void ClearBuffList()
	{
	}

	[Token(Token = "0x60023A0")]
	[Address(RVA = "0xB4B128", Offset = "0xB4B128", VA = "0xB4B128")]
	public void SyncBuff(Netdata_Buff[] buff)
	{
	}

	[Token(Token = "0x60023A1")]
	[Address(RVA = "0xB4BCD0", Offset = "0xB4BCD0", VA = "0xB4BCD0")]
	public Netdata_Buff[] ToNetData()
	{
		return null;
	}

	[Token(Token = "0x60023A2")]
	[Address(RVA = "0xB49FB4", Offset = "0xB49FB4", VA = "0xB49FB4")]
	private void ApplyBuffWithEffect(XModuleActor owner, Vector3 colPos, Vector3 colDir, XBuff buff)
	{
	}

	[Token(Token = "0x60023A3")]
	[Address(RVA = "0xB4A960", Offset = "0xB4A960", VA = "0xB4A960")]
	private void ReapplyBuffWithEffect(XModuleActor owner, Vector3 colPos, Vector3 colDir, XBuff buff)
	{
	}

	[Token(Token = "0x60023A4")]
	[Address(RVA = "0xB4BF30", Offset = "0xB4BF30", VA = "0xB4BF30")]
	private void ApplyBuff(XModuleActor owner, Vector3 colPos, Vector3 colDir, XBuff buff)
	{
	}

	[Token(Token = "0x60023A5")]
	[Address(RVA = "0xB4C92C", Offset = "0xB4C92C", VA = "0xB4C92C")]
	private void AddAdjustSkill(XBuff buff)
	{
	}

	[Token(Token = "0x60023A6")]
	[Address(RVA = "0xB46454", Offset = "0xB46454", VA = "0xB46454")]
	private void ApplyMF(XModuleActor user, Vector3 colPos, Vector3 colDir, XBuff buff, bool bGain)
	{
	}

	[Token(Token = "0x60023A7")]
	[Address(RVA = "0xB33CE0", Offset = "0xB33CE0", VA = "0xB33CE0")]
	public void ReleaseCurrentMFBuff()
	{
	}

	[Token(Token = "0x60023A8")]
	[Address(RVA = "0xB4725C", Offset = "0xB4725C", VA = "0xB4725C")]
	private void RefreshModelScale()
	{
	}

	[Token(Token = "0x60023A9")]
	[Address(RVA = "0xB469E8", Offset = "0xB469E8", VA = "0xB469E8")]
	private void ApplyAttribute(XBuff buff, bool bGain)
	{
	}

	[Token(Token = "0x60023AA")]
	[Address(RVA = "0xB4CAEC", Offset = "0xB4CAEC", VA = "0xB4CAEC")]
	private void UpdateBlind(XBuff buff, bool bGain)
	{
	}

	[Token(Token = "0x60023AB")]
	[Address(RVA = "0xB4B998", Offset = "0xB4B998", VA = "0xB4B998")]
	private void UpdateGhost()
	{
	}

	[Token(Token = "0x60023AC")]
	[Address(RVA = "0xB4B920", Offset = "0xB4B920", VA = "0xB4B920")]
	private void UpdateVisible()
	{
	}

	[Token(Token = "0x60023AD")]
	[Address(RVA = "0xB4CEF8", Offset = "0xB4CEF8", VA = "0xB4CEF8")]
	public void EnableGhost(bool b)
	{
	}

	[Token(Token = "0x60023AE")]
	[Address(RVA = "0xB4C190", Offset = "0xB4C190", VA = "0xB4C190")]
	private void ApplyEraseBuff(XBuff buff)
	{
	}

	[Token(Token = "0x60023AF")]
	[Address(RVA = "0xB47CDC", Offset = "0xB47CDC", VA = "0xB47CDC")]
	protected void AddBuffEffect(XBuff buff, bool reapply)
	{
	}

	[Token(Token = "0x60023B0")]
	[Address(RVA = "0xB46DB0", Offset = "0xB46DB0", VA = "0xB46DB0")]
	private void AddBuffEffectOnLost(XBuff buff)
	{
	}

	[Token(Token = "0x60023B1")]
	[Address(RVA = "0xB4D100", Offset = "0xB4D100", VA = "0xB4D100", Slot = "61")]
	protected virtual GameObject _AddBuffEffect(CSBuffEffectInfo be, bool bCheckInvisible)
	{
		return null;
	}

	[Token(Token = "0x60023B2")]
	[Address(RVA = "0xB4C5D0", Offset = "0xB4C5D0", VA = "0xB4C5D0")]
	private void ApplyInstantDeath(XBuff buff)
	{
	}

	[Token(Token = "0x60023B3")]
	[Address(RVA = "0xB46A48", Offset = "0xB46A48", VA = "0xB46A48")]
	private void DeleteBuffEffect(XBuff buff)
	{
	}

	[Token(Token = "0x60023B4")]
	[Address(RVA = "0xB4DDC0", Offset = "0xB4DDC0", VA = "0xB4DDC0", Slot = "29")]
	public override void SetVisible(bool isInvisible, bool isEnemy)
	{
	}

	[Token(Token = "0x60023B5")]
	[Address(RVA = "0xB4DDE0", Offset = "0xB4DDE0", VA = "0xB4DDE0")]
	public void SetVisibleBuffEffect(bool val)
	{
	}

	[Token(Token = "0x60023B6")]
	[Address(RVA = "0xB4E048", Offset = "0xB4E048", VA = "0xB4E048", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60023B7")]
	[Address(RVA = "0xB4E180", Offset = "0xB4E180", VA = "0xB4E180")]
	private void BuffListUpdate(float dt)
	{
	}

	[Token(Token = "0x60023B8")]
	[Address(RVA = "0xB461C8", Offset = "0xB461C8", VA = "0xB461C8")]
	private void ApplyFlags(XBuff buff, bool bGain)
	{
	}

	[Token(Token = "0x60023B9")]
	[Address(RVA = "0xB3A29C", Offset = "0xB3A29C", VA = "0xB3A29C")]
	public XBuff GetHaveBuff(int nBuffID)
	{
		return null;
	}

	[Token(Token = "0x60023BA")]
	[Address(RVA = "0xB39028", Offset = "0xB39028", VA = "0xB39028")]
	public bool HasBuff(int nBuffID)
	{
		return default(bool);
	}

	[Token(Token = "0x60023BB")]
	[Address(RVA = "0xB4E2D4", Offset = "0xB4E2D4", VA = "0xB4E2D4")]
	public bool HasIdleRotationBuff()
	{
		return default(bool);
	}

	[Token(Token = "0x60023BC")]
	[Address(RVA = "0xB46F80", Offset = "0xB46F80", VA = "0xB46F80")]
	private void ApplyChangeCharModel(XBuff buff, bool bGain)
	{
	}

	[Token(Token = "0x60023BD")]
	[Address(RVA = "0xB4E730", Offset = "0xB4E730", VA = "0xB4E730")]
	public void ReleaseChangeModelBuff()
	{
	}

	[Token(Token = "0x60023BE")]
	[Address(RVA = "0xB4E490", Offset = "0xB4E490", VA = "0xB4E490")]
	private XBuff GetChangeModelBuff(out CSCharacterInfo changedModelStatus)
	{
		changedModelStatus = default;
		return null;
	}

	[Token(Token = "0x60023BF")]
	[Address(RVA = "0xB4B9A0", Offset = "0xB4B9A0", VA = "0xB4B9A0")]
	private void GetChangeModel(out CSCharacterInfo characterInfo, out SkinInfo skinInfo)
	{
		characterInfo = default;
		skinInfo = default;
	}

	[Token(Token = "0x60023C3")]
	[Address(RVA = "0xB4E7A8", Offset = "0xB4E7A8", VA = "0xB4E7A8", Slot = "62")]
	public virtual float CalcDurationTime(XModuleActor user, CSBuffInfo buffInfo, CSSkillInfo usingSkillInfo)
	{
		return default(float);
	}

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0xB364C4", Offset = "0xB364C4", VA = "0xB364C4")]
	internal void MergeBuffStatus(CharStatus status)
	{
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0xB4EC30", Offset = "0xB4EC30", VA = "0xB4EC30")]
	protected void OnTrigger(XModuleActor user, XModuleEntity attackSkillME, CSSkillInfo skillInfo, HitTarget target, SkillBuffTiming timing)
	{
	}

	[Token(Token = "0x60023C6")]
	[Address(RVA = "0xB4ED3C", Offset = "0xB4ED3C", VA = "0xB4ED3C", Slot = "27")]
	public override void OnAfterSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x60023C7")]
	[Address(RVA = "0xB4EED4", Offset = "0xB4EED4", VA = "0xB4EED4", Slot = "31")]
	public override void OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x60023C8")]
	[Address(RVA = "0xB4EED8", Offset = "0xB4EED8", VA = "0xB4EED8")]
	private void DeleteBuffOnSkillEnd(XSkill skill)
	{
	}

	[Token(Token = "0x60023C9")]
	[Address(RVA = "0xB4F06C", Offset = "0xB4F06C", VA = "0xB4F06C", Slot = "30")]
	public override void OnSkillFinished(XSkill skill)
	{
	}

	[Token(Token = "0x60023CA")]
	[Address(RVA = "0xB4F0E4", Offset = "0xB4F0E4", VA = "0xB4F0E4", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60023CB")]
	[Address(RVA = "0xB4F8F0", Offset = "0xB4F8F0", VA = "0xB4F8F0", Slot = "34")]
	public override void OnHitActor(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60023CC")]
	[Address(RVA = "0xB487BC", Offset = "0xB487BC", VA = "0xB487BC")]
	private void ApplyMyPlayerState(CSBuffInfo buffInfo, bool bGain)
	{
	}

	[Token(Token = "0x60023CD")]
	[Address(RVA = "0xB4C738", Offset = "0xB4C738", VA = "0xB4C738")]
	private void ApplyMetaProperties(XBuff buff)
	{
	}

	[Token(Token = "0x60023CE")]
	[Address(RVA = "0xB4FBFC", Offset = "0xB4FBFC", VA = "0xB4FBFC", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x60023CF")]
	[Address(RVA = "0xB4FC50", Offset = "0xB4FC50", VA = "0xB4FC50", Slot = "36")]
	public override void OnBeforeActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60023D0")]
	[Address(RVA = "0xB4FC54", Offset = "0xB4FC54", VA = "0xB4FC54")]
	private void _003COnAfterActorInit_003Em__D4(float delta)
	{
	}

	[Token(Token = "0x60023D1")]
	[Address(RVA = "0xB4FC58", Offset = "0xB4FC58", VA = "0xB4FC58")]
	private static bool _003COnAfterSkillStart_003Em__D6(XBuff _buff)
	{
		return default(bool);
	}

	[Token(Token = "0x60023D2")]
	[Address(RVA = "0xB4FC94", Offset = "0xB4FC94", VA = "0xB4FC94")]
	private static bool _003COnHitMe_003Em__D7(XBuff _buff)
	{
		return default(bool);
	}

	[Token(Token = "0x60023D3")]
	[Address(RVA = "0xB4FCD4", Offset = "0xB4FCD4", VA = "0xB4FCD4")]
	private static bool _003COnHitActor_003Em__D8(XBuff _buff)
	{
		return default(bool);
	}
}
