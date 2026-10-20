using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FE5")]
public class XWidget_ShopBonusBuyCashPopup : XWidget_ShopBonusBuyPopup
{
	[Token(Token = "0x40054CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UILabel lblBottomMessage;

	[Token(Token = "0x6007697")]
	[Address(RVA = "0x1B04124", Offset = "0x1B04124", VA = "0x1B04124")]
	public XWidget_ShopBonusBuyCashPopup()
	{
	}

	[Token(Token = "0x6007698")]
	[Address(RVA = "0x1B04144", Offset = "0x1B04144", VA = "0x1B04144", Slot = "7")]
	public override void Build(IShopItem item, bool buy_free, [Optional] Action buyAction, [Optional] Action onClose)
	{
	}
}
