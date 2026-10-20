using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000F02")]
public class XNewBadgeCheckData
{
	[Token(Token = "0x4004F9D")]
	[FieldOffset(Offset = "0x8")]
	public bool eventbanner_NewSelect;

	[Token(Token = "0x4004F9E")]
	[FieldOffset(Offset = "0xC")]
	public List<int> select_id_list;

	[Token(Token = "0x4004F9F")]
	[FieldOffset(Offset = "0x10")]
	public List<int> shopProduct_select;

	[Token(Token = "0x600700E")]
	[Address(RVA = "0x1ECF504", Offset = "0x1ECF504", VA = "0x1ECF504")]
	public XNewBadgeCheckData()
	{
	}

	[Token(Token = "0x600700F")]
	[Address(RVA = "0x1ECF5C8", Offset = "0x1ECF5C8", VA = "0x1ECF5C8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6007010")]
	[Address(RVA = "0x1ECF760", Offset = "0x1ECF760", VA = "0x1ECF760")]
	public void ClearShopNewBadge()
	{
	}

	[Token(Token = "0x6007011")]
	[Address(RVA = "0x1ECF800", Offset = "0x1ECF800", VA = "0x1ECF800")]
	public void RegistShowNewShopItem(int productID)
	{
	}
}
