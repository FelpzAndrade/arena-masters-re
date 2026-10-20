using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200047D")]
public class XModuleMyEffect : XModuleBase
{
	[Token(Token = "0x4001699")]
	[FieldOffset(Offset = "0x10")]
	private bool m_bInited;

	[Token(Token = "0x400169A")]
	[FieldOffset(Offset = "0x14")]
	protected GameObject m_TargetEffect;

	[Token(Token = "0x400169B")]
	[FieldOffset(Offset = "0x18")]
	public XModuleEntity m_skillTarget;

	[Token(Token = "0x400169C")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_skillUID;

	[Token(Token = "0x400169D")]
	[FieldOffset(Offset = "0x20")]
	public XModuleEntity m_curTarget;

	[Token(Token = "0x400169E")]
	[FieldOffset(Offset = "0x24")]
	protected bool m_effect_enable;

	[Token(Token = "0x600260C")]
	[Address(RVA = "0xB785C0", Offset = "0xB785C0", VA = "0xB785C0")]
	public XModuleMyEffect()
	{
	}

	[Token(Token = "0x600260D")]
	[Address(RVA = "0xB785D0", Offset = "0xB785D0", VA = "0xB785D0", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x600260E")]
	[Address(RVA = "0xB7881C", Offset = "0xB7881C", VA = "0xB7881C", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x600260F")]
	[Address(RVA = "0xB78A4C", Offset = "0xB78A4C", VA = "0xB78A4C", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x6002610")]
	[Address(RVA = "0xB78A94", Offset = "0xB78A94", VA = "0xB78A94", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x6002611")]
	[Address(RVA = "0xB78B00", Offset = "0xB78B00", VA = "0xB78B00", Slot = "31")]
	public override void OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x6002612")]
	[Address(RVA = "0xB78B70", Offset = "0xB78B70", VA = "0xB78B70", Slot = "30")]
	public override void OnSkillFinished(XSkill skill)
	{
	}

	[Token(Token = "0x6002613")]
	[Address(RVA = "0xB78B04", Offset = "0xB78B04", VA = "0xB78B04")]
	private void OnSkillEnd(XSkill skill)
	{
	}

	[Token(Token = "0x6002614")]
	[Address(RVA = "0xB78B74", Offset = "0xB78B74", VA = "0xB78B74", Slot = "59")]
	public virtual XModuleEntity FindNearestEnemy(XModuleEntity owner, float fDistance)
	{
		return null;
	}

	[Token(Token = "0x6002615")]
	[Address(RVA = "0xB78820", Offset = "0xB78820", VA = "0xB78820")]
	private void UpdateTargetEffectPosition()
	{
	}

	[Token(Token = "0x6002616")]
	[Address(RVA = "0xB785D4", Offset = "0xB785D4", VA = "0xB785D4")]
	protected void InitTargetEffect()
	{
	}

	[Token(Token = "0x6002617")]
	[Address(RVA = "0xB78C50", Offset = "0xB78C50", VA = "0xB78C50")]
	protected void EnableTargetEffect(bool val)
	{
	}

	[Token(Token = "0x6002618")]
	[Address(RVA = "0xB78CA0", Offset = "0xB78CA0", VA = "0xB78CA0", Slot = "60")]
	protected virtual void DestroyTargetEffect()
	{
	}

	[Token(Token = "0x6002619")]
	[Address(RVA = "0xB78A50", Offset = "0xB78A50", VA = "0xB78A50")]
	public void TurnOffEffect()
	{
	}
}
