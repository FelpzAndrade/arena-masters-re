using System;
using CS;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000ABD")]
public sealed class CSEmblemSetInfo
{
	[Token(Token = "0x400324F")]
	[FieldOffset(Offset = "0x8")]
	public int nId;

	[Token(Token = "0x4003250")]
	[FieldOffset(Offset = "0xC")]
	public XGameModeType m_nGameModeType;

	[Token(Token = "0x4003251")]
	[FieldOffset(Offset = "0x10")]
	public Stat.Type m_nConditionKey;

	[Token(Token = "0x4003252")]
	[FieldOffset(Offset = "0x14")]
	public int m_nConditionValue;

	[Token(Token = "0x4003253")]
	[FieldOffset(Offset = "0x18")]
	public string m_IconPath;

	[Token(Token = "0x6004EF1")]
	[Address(RVA = "0x21F171C", Offset = "0x21F171C", VA = "0x21F171C")]
	public CSEmblemSetInfo()
	{
	}

	[Token(Token = "0x6004EF2")]
	[Address(RVA = "0x21F17E8", Offset = "0x21F17E8", VA = "0x21F17E8")]
	public void Cooking()
	{
	}
}
