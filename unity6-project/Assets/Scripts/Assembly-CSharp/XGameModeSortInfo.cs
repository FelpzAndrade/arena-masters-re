using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200065E")]
public class XGameModeSortInfo
{
	[Token(Token = "0x4001E86")]
	[FieldOffset(Offset = "0x8")]
	public int order;

	[Token(Token = "0x4001E87")]
	[FieldOffset(Offset = "0xC")]
	public XGameModeMainCatecory mainCatecory;

	[Token(Token = "0x4001E88")]
	[FieldOffset(Offset = "0x10")]
	public XGameModeSubCatecory subCatecory;

	[Token(Token = "0x4001E89")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x4001E8A")]
	[FieldOffset(Offset = "0x18")]
	public string desc;

	[Token(Token = "0x4001E8B")]
	[FieldOffset(Offset = "0x1C")]
	public string imagePath;

	[Token(Token = "0x4001E8C")]
	[FieldOffset(Offset = "0x20")]
	public string strEffectActive;

	[Token(Token = "0x4001E8D")]
	[FieldOffset(Offset = "0x24")]
	public bool IsEffectActive;

	[Token(Token = "0x6003642")]
	[Address(RVA = "0x14132F0", Offset = "0x14132F0", VA = "0x14132F0")]
	public XGameModeSortInfo()
	{
	}

	[Token(Token = "0x6003643")]
	[Address(RVA = "0x14133D4", Offset = "0x14133D4", VA = "0x14133D4")]
	public bool Cooking()
	{
		return default(bool);
	}
}
