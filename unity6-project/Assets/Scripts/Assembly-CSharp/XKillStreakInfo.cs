using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000D71")]
public sealed class XKillStreakInfo
{
	[Token(Token = "0x4004558")]
	[FieldOffset(Offset = "0x8")]
	public int nId;

	[Token(Token = "0x4004559")]
	[FieldOffset(Offset = "0xC")]
	public int nKillCount;

	[Token(Token = "0x400455A")]
	[FieldOffset(Offset = "0x10")]
	public string strFriendly_text;

	[Token(Token = "0x400455B")]
	[FieldOffset(Offset = "0x14")]
	public string strEnemy_text;

	[Token(Token = "0x400455C")]
	[FieldOffset(Offset = "0x18")]
	public string strShutDown;

	[Token(Token = "0x400455D")]
	[FieldOffset(Offset = "0x1C")]
	public bool isShutDown;

	[Token(Token = "0x60062B4")]
	[Address(RVA = "0x1D38280", Offset = "0x1D38280", VA = "0x1D38280")]
	public XKillStreakInfo()
	{
	}

	[Token(Token = "0x60062B5")]
	[Address(RVA = "0x1D38374", Offset = "0x1D38374", VA = "0x1D38374")]
	public bool Cooking()
	{
		return default(bool);
	}
}
