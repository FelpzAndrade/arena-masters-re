using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000FD6")]
public class QuickMatchThemeInfo
{
	[Token(Token = "0x4005453")]
	[FieldOffset(Offset = "0x8")]
	public string strSectorName;

	[Token(Token = "0x4005454")]
	[FieldOffset(Offset = "0xC")]
	public List<int> sectorId_List;

	[Token(Token = "0x4005455")]
	[FieldOffset(Offset = "0x10")]
	public string strThemeThumbnailImagePath;

	[Token(Token = "0x4005456")]
	[FieldOffset(Offset = "0x14")]
	public bool isActive;

	[Token(Token = "0x4005457")]
	[FieldOffset(Offset = "0x15")]
	public bool isSelect;

	[Token(Token = "0x4005458")]
	[FieldOffset(Offset = "0x16")]
	public bool isLock;

	[Token(Token = "0x4005459")]
	[FieldOffset(Offset = "0x18")]
	public int requireLevel;

	[Token(Token = "0x600760C")]
	[Address(RVA = "0x20E9EEC", Offset = "0x20E9EEC", VA = "0x20E9EEC")]
	public QuickMatchThemeInfo()
	{
	}
}
