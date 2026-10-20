using System;
using Il2CppDummyDll;

[Token(Token = "0x2000472")]
public static class MeshVisible
{
	[Token(Token = "0x2000473")]
	[Flags]
	public enum HideFlag
	{
		[Token(Token = "0x4001661")]
		None = 0,
		[Token(Token = "0x4001662")]
		Stealth = 1,
		[Token(Token = "0x4001663")]
		Bush = 2,
		[Token(Token = "0x4001664")]
		EyeBandage = 4,
		[Token(Token = "0x4001665")]
		Blind = 8,
		[Token(Token = "0x4001666")]
		Hide = 0x10
	}

	[Token(Token = "0x2000474")]
	[Flags]
	public enum State
	{
		[Token(Token = "0x4001668")]
		Hide = 0,
		[Token(Token = "0x4001669")]
		Alpha = 1,
		[Token(Token = "0x400166A")]
		Show = 2
	}

	[Token(Token = "0x600257B")]
	[Address(RVA = "0x135C0C8", Offset = "0x135C0C8", VA = "0x135C0C8")]
	public static bool HasBandage(HideFlag target)
	{
		return default(bool);
	}

	[Token(Token = "0x600257C")]
	[Address(RVA = "0x135C0DC", Offset = "0x135C0DC", VA = "0x135C0DC")]
	public static bool Has(HideFlag target, HideFlag checkOption)
	{
		return default(bool);
	}

	[Token(Token = "0x600257D")]
	[Address(RVA = "0x135C0F0", Offset = "0x135C0F0", VA = "0x135C0F0")]
	public static HideFlag Apply(HideFlag option, HideFlag flag, bool val)
	{
		return default(HideFlag);
	}

	[Token(Token = "0x600257E")]
	[Address(RVA = "0x135C100", Offset = "0x135C100", VA = "0x135C100")]
	public static HideFlag Add(HideFlag option, HideFlag add)
	{
		return default(HideFlag);
	}

	[Token(Token = "0x600257F")]
	[Address(RVA = "0x135C108", Offset = "0x135C108", VA = "0x135C108")]
	public static HideFlag Remove(HideFlag option, HideFlag remove)
	{
		return default(HideFlag);
	}

	[Token(Token = "0x6002580")]
	[Address(RVA = "0x135C110", Offset = "0x135C110", VA = "0x135C110")]
	public static State GetVisible(HideFlag flag, bool isEnemy)
	{
		return default(State);
	}

	[Token(Token = "0x6002581")]
	[Address(RVA = "0x135C144", Offset = "0x135C144", VA = "0x135C144")]
	public static State GetEffectVisible(HideFlag flag, bool isEnemy)
	{
		return default(State);
	}
}
