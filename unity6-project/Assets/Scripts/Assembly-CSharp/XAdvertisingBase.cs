using System;
using Il2CppDummyDll;

[Token(Token = "0x2000367")]
public class XAdvertisingBase
{
	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x8")]
	protected string appID_Android;

	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0xC")]
	protected string zoneID_Android;

	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x10")]
	protected string appID_IOS;

	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0x14")]
	protected string zoneID_IOS;

	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x18")]
	protected string appID;

	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x1C")]
	protected string zoneID;

	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x20")]
	protected Action m_showFinishedAction;

	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x1EDCC00", Offset = "0x1EDCC00", VA = "0x1EDCC00")]
	public XAdvertisingBase()
	{
	}

	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x1EDCD1C", Offset = "0x1EDCD1C", VA = "0x1EDCD1C", Slot = "4")]
	public virtual void AddAdvertising(string zoneID)
	{
	}

	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x1EDCD20", Offset = "0x1EDCD20", VA = "0x1EDCD20", Slot = "5")]
	public virtual void OnInit(bool isDev, Action showFinishedAction)
	{
	}

	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x1EDCD24", Offset = "0x1EDCD24", VA = "0x1EDCD24", Slot = "6")]
	public virtual bool OnIsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x1EDCD2C", Offset = "0x1EDCD2C", VA = "0x1EDCD2C", Slot = "7")]
	public virtual void OnShow()
	{
	}

	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x1EDCD30", Offset = "0x1EDCD30", VA = "0x1EDCD30", Slot = "8")]
	public virtual void OnFinished()
	{
	}

	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x1EDCD34", Offset = "0x1EDCD34", VA = "0x1EDCD34")]
	protected void GiveReward()
	{
	}
}
