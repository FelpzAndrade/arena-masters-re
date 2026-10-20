using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FE9")]
public class XWidget_ShopNormalBuyPopup : XWidget_ShopBuyPopupBase
{
	[Token(Token = "0x40054E2")]
	[FieldOffset(Offset = "0x44")]
	public Transform iconParent;

	[Token(Token = "0x40054E3")]
	[FieldOffset(Offset = "0x48")]
	private XWidget_ContentIcon m_itemIcon;

	[Token(Token = "0x40054E4")]
	[FieldOffset(Offset = "0x4C")]
	private XWidget_ContentIcon.Option m_option;

	[Token(Token = "0x60076AB")]
	[Address(RVA = "0x1B066AC", Offset = "0x1B066AC", VA = "0x1B066AC")]
	public XWidget_ShopNormalBuyPopup()
	{
	}

	[Token(Token = "0x60076AC")]
	[Address(RVA = "0x1B066BC", Offset = "0x1B066BC", VA = "0x1B066BC", Slot = "6")]
	protected override void BuildItemIcon(IShopItem item)
	{
	}
}
