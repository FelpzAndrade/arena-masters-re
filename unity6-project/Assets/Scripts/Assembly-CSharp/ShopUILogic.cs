using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200103A")]
public static class ShopUILogic
{
	[Token(Token = "0x6007917")]
	[Address(RVA = "0x20F84CC", Offset = "0x20F84CC", VA = "0x20F84CC")]
	public static void SetStallIcon(XWidget_ContentIcon icon, IShopItem shopItem, XWidget_ContentIcon.Option option, [Optional] Action<object> clickCallBack)
	{
	}

	[Token(Token = "0x6007918")]
	[Address(RVA = "0x20F89B8", Offset = "0x20F89B8", VA = "0x20F89B8")]
	public static bool SetBonus(UI2DSprite sprBonusItemIcon, UILabel lblBonusCount, IShopItem shopItem)
	{
		return default(bool);
	}
}
