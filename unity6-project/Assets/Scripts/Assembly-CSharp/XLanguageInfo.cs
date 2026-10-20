using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000664")]
public class XLanguageInfo
{
	[Token(Token = "0x4001E9D")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4001E9E")]
	[FieldOffset(Offset = "0xC")]
	public string strLanguage;

	[Token(Token = "0x4001E9F")]
	[FieldOffset(Offset = "0x10")]
	public string locale_key;

	[Token(Token = "0x4001EA0")]
	[FieldOffset(Offset = "0x14")]
	public string flagPath;

	[Token(Token = "0x4001EA1")]
	[FieldOffset(Offset = "0x18")]
	public string strOptionActive;

	[Token(Token = "0x4001EA2")]
	[FieldOffset(Offset = "0x1C")]
	public string strChatActive;

	[Token(Token = "0x4001EA3")]
	[FieldOffset(Offset = "0x20")]
	public string strChatChannelName;

	[Token(Token = "0x4001EA4")]
	[FieldOffset(Offset = "0x24")]
	public string strSystemLanguage;

	[Token(Token = "0x4001EA5")]
	[FieldOffset(Offset = "0x28")]
	public bool IsOptionActive;

	[Token(Token = "0x4001EA6")]
	[FieldOffset(Offset = "0x29")]
	public bool IsChatActive;

	[Token(Token = "0x6003650")]
	[Address(RVA = "0x1D3F168", Offset = "0x1D3F168", VA = "0x1D3F168")]
	public XLanguageInfo()
	{
	}

	[Token(Token = "0x6003651")]
	[Address(RVA = "0x1D3F170", Offset = "0x1D3F170", VA = "0x1D3F170")]
	public bool Cooking()
	{
		return default(bool);
	}

	[Token(Token = "0x6003652")]
	[Address(RVA = "0x1D3F19C", Offset = "0x1D3F19C", VA = "0x1D3F19C")]
	public bool GetIsActive(string str)
	{
		return default(bool);
	}
}
