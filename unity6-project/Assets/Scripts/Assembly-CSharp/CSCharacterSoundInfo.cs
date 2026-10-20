using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000AA8")]
public sealed class CSCharacterSoundInfo
{
	[Token(Token = "0x4003212")]
	[FieldOffset(Offset = "0x8")]
	public int nID;

	[Token(Token = "0x4003213")]
	[FieldOffset(Offset = "0xC")]
	public int nSkin_id;

	[Token(Token = "0x4003214")]
	[FieldOffset(Offset = "0x10")]
	public string strDieSound;

	[Token(Token = "0x4003215")]
	[FieldOffset(Offset = "0x14")]
	public string strDieVoice;

	[Token(Token = "0x4003216")]
	[FieldOffset(Offset = "0x18")]
	public string strBeatenVoice;

	[Token(Token = "0x4003217")]
	[FieldOffset(Offset = "0x1C")]
	public float strBeatenVoiceCooltime;

	[Token(Token = "0x4003218")]
	[FieldOffset(Offset = "0x20")]
	public float strBeatenVoiceRatio;

	[Token(Token = "0x4003219")]
	[FieldOffset(Offset = "0x24")]
	public string strBattleStartvoice;

	[Token(Token = "0x400321A")]
	[FieldOffset(Offset = "0x28")]
	public string strMultikillVoice;

	[Token(Token = "0x400321B")]
	[FieldOffset(Offset = "0x2C")]
	public string strShutdownVoice;

	[Token(Token = "0x400321C")]
	[FieldOffset(Offset = "0x30")]
	public string strCharSpecVoice;

	[Token(Token = "0x400321D")]
	[FieldOffset(Offset = "0x34")]
	public string strcharReadyVoice;

	[Token(Token = "0x6004E90")]
	[Address(RVA = "0x21F1330", Offset = "0x21F1330", VA = "0x21F1330")]
	public CSCharacterSoundInfo()
	{
	}

	[Token(Token = "0x6004E91")]
	[Address(RVA = "0x21F147C", Offset = "0x21F147C", VA = "0x21F147C")]
	public bool Cooking()
	{
		return default(bool);
	}
}
