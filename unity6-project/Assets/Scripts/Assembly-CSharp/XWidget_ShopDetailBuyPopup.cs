using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FE8")]
public class XWidget_ShopDetailBuyPopup : XWidget_ShopBuyPopupBase
{
	[Token(Token = "0x40054DF")]
	[FieldOffset(Offset = "0x44")]
	public XWidget_DisplayShowBox showboxDisplay;

	[Token(Token = "0x40054E0")]
	[FieldOffset(Offset = "0x48")]
	public UIBasicSprite sprBG;

	[Token(Token = "0x40054E1")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel lblAdDesc;

	[Token(Token = "0x60076A9")]
	[Address(RVA = "0x1B0649C", Offset = "0x1B0649C", VA = "0x1B0649C")]
	public XWidget_ShopDetailBuyPopup()
	{
	}

	[Token(Token = "0x60076AA")]
	[Address(RVA = "0x1B064A4", Offset = "0x1B064A4", VA = "0x1B064A4")]
	public void Build(CSShopItem shopItem, bool buyFree, List<ShowBoxInfo> showboxList, Action buyAction, Action onClose)
	{
	}
}
