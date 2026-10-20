using System;
using CS;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000AC0")]
public sealed class CSEmoticonSetInfo
{
	[Serializable]
	[Token(Token = "0x2000AC1")]
	public enum GainType
	{
		[Token(Token = "0x400326A")]
		none = 0,
		[Token(Token = "0x400326B")]
		condition = 1,
		[Token(Token = "0x400326C")]
		buy = 2
	}

	[Token(Token = "0x4003255")]
	[FieldOffset(Offset = "0x8")]
	public int nId;

	[Token(Token = "0x4003256")]
	[FieldOffset(Offset = "0xC")]
	public int sub_id;

	[Token(Token = "0x4003257")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4003258")]
	[FieldOffset(Offset = "0x14")]
	public string title_icon;

	[Token(Token = "0x4003259")]
	[FieldOffset(Offset = "0x18")]
	public string icon;

	[Token(Token = "0x400325A")]
	[FieldOffset(Offset = "0x1C")]
	public string prefab;

	[Token(Token = "0x400325B")]
	[FieldOffset(Offset = "0x20")]
	public string sound;

	[Token(Token = "0x400325C")]
	[FieldOffset(Offset = "0x24")]
	public string contentsTag;

	[Token(Token = "0x400325D")]
	[FieldOffset(Offset = "0x28")]
	public string eventStr;

	[Token(Token = "0x400325E")]
	[FieldOffset(Offset = "0x2C")]
	private bool bEvent;

	[Token(Token = "0x400325F")]
	[FieldOffset(Offset = "0x30")]
	public GainType gainType;

	[Token(Token = "0x4003260")]
	[FieldOffset(Offset = "0x34")]
	public string desc;

	[Token(Token = "0x4003261")]
	[FieldOffset(Offset = "0x38")]
	public Currency coinType;

	[Token(Token = "0x4003262")]
	[FieldOffset(Offset = "0x3C")]
	public int coinPrice;

	[Token(Token = "0x4003263")]
	[FieldOffset(Offset = "0x40")]
	public Currency duplicationCoinType;

	[Token(Token = "0x4003264")]
	[FieldOffset(Offset = "0x44")]
	public int duplicationPrice;

	[Token(Token = "0x4003265")]
	[FieldOffset(Offset = "0x48")]
	public string showStartTimeStr;

	[Token(Token = "0x4003266")]
	[FieldOffset(Offset = "0x50")]
	public DateTime showStartTime;

	[Token(Token = "0x4003267")]
	[FieldOffset(Offset = "0x60")]
	public string showEndTimeStr;

	[Token(Token = "0x4003268")]
	[FieldOffset(Offset = "0x68")]
	public DateTime showEndime;

	[Token(Token = "0x6004EFC")]
	[Address(RVA = "0x21F1938", Offset = "0x21F1938", VA = "0x21F1938")]
	public CSEmoticonSetInfo()
	{
	}

	[Token(Token = "0x6004EFD")]
	[Address(RVA = "0x21F1AB0", Offset = "0x21F1AB0", VA = "0x21F1AB0")]
	public bool IsEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x6004EFE")]
	[Address(RVA = "0x21F1AB8", Offset = "0x21F1AB8", VA = "0x21F1AB8")]
	public bool IsPurchasable()
	{
		return default(bool);
	}

	[Token(Token = "0x6004EFF")]
	[Address(RVA = "0x21F1ACC", Offset = "0x21F1ACC", VA = "0x21F1ACC")]
	public bool IsTimeLimited()
	{
		return default(bool);
	}

	[Token(Token = "0x6004F00")]
	[Address(RVA = "0x21F1C08", Offset = "0x21F1C08", VA = "0x21F1C08")]
	public void Cooking()
	{
	}
}
