using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000650")]
public class XClanMarkProtoInfo
{
	[Token(Token = "0x4001E4A")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4001E4B")]
	[FieldOffset(Offset = "0xC")]
	public string value;

	[Token(Token = "0x4001E4C")]
	[FieldOffset(Offset = "0x10")]
	public ClanMarkInfoType type;

	[Token(Token = "0x6003602")]
	[Address(RVA = "0x1AC5ED0", Offset = "0x1AC5ED0", VA = "0x1AC5ED0")]
	public XClanMarkProtoInfo()
	{
	}

	[Token(Token = "0x6003603")]
	[Address(RVA = "0x1AC5F94", Offset = "0x1AC5F94", VA = "0x1AC5F94")]
	public Color32 GetColor()
	{
		return default(Color32);
	}

	[Token(Token = "0x6003604")]
	[Address(RVA = "0x1AC6164", Offset = "0x1AC6164", VA = "0x1AC6164")]
	public string GetIconPath()
	{
		return null;
	}

	[Token(Token = "0x6003605")]
	[Address(RVA = "0x1AC622C", Offset = "0x1AC622C", VA = "0x1AC622C")]
	public void Cooking()
	{
	}
}
