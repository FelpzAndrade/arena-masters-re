using System;
using CS;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000672")]
public sealed class PackageDetailInfo
{
	[Token(Token = "0x4001EE3")]
	[FieldOffset(Offset = "0x8")]
	public int nID;

	[Token(Token = "0x4001EE4")]
	[FieldOffset(Offset = "0xC")]
	public int number;

	[Token(Token = "0x4001EE5")]
	[FieldOffset(Offset = "0x10")]
	public CSContentType contentType;

	[Token(Token = "0x4001EE6")]
	[FieldOffset(Offset = "0x14")]
	public int contentID;

	[Token(Token = "0x4001EE7")]
	[FieldOffset(Offset = "0x18")]
	public int contentCount;

	[Token(Token = "0x4001EE8")]
	[FieldOffset(Offset = "0x1C")]
	public ProductType productType;

	[Token(Token = "0x4001EE9")]
	[FieldOffset(Offset = "0x20")]
	public string strDesc1;

	[Token(Token = "0x4001EEA")]
	[FieldOffset(Offset = "0x24")]
	public string strDesc2;

	[Token(Token = "0x4001EEB")]
	[FieldOffset(Offset = "0x28")]
	public string strDesc3;

	[Token(Token = "0x4001EEC")]
	[FieldOffset(Offset = "0x2C")]
	public string strContentName;

	[Token(Token = "0x4001EED")]
	[FieldOffset(Offset = "0x30")]
	public string strContentIconPath;

	[Token(Token = "0x4001EEE")]
	[FieldOffset(Offset = "0x34")]
	public int show_order;

	[Token(Token = "0x4001EEF")]
	[FieldOffset(Offset = "0x38")]
	public string link;

	[Token(Token = "0x600367C")]
	[Address(RVA = "0x1B77338", Offset = "0x1B77338", VA = "0x1B77338")]
	public PackageDetailInfo()
	{
	}

	[Token(Token = "0x600367D")]
	[Address(RVA = "0x1B7744C", Offset = "0x1B7744C", VA = "0x1B7744C")]
	public CSContent GetContent()
	{
		return null;
	}
}
