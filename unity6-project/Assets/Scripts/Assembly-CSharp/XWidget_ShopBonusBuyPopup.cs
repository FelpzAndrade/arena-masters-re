using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FE6")]
public class XWidget_ShopBonusBuyPopup : XWidget_ShopBuyPopupBase
{
	[Token(Token = "0x40054CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int itemIconHeight;

	[Token(Token = "0x40054CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UI2DSprite sprBounsItemIcon;

	[Token(Token = "0x40054CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UILabel lblOriginCount;

	[Token(Token = "0x40054D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UILabel lblBonusCount;

	[Token(Token = "0x6007699")]
	[Address(RVA = "0x1B04134", Offset = "0x1B04134", VA = "0x1B04134")]
	public XWidget_ShopBonusBuyPopup()
	{
	}

	[Token(Token = "0x600769A")]
	[Address(RVA = "0x1B04288", Offset = "0x1B04288", VA = "0x1B04288", Slot = "7")]
	public override void Build(IShopItem item, bool buy_free, [Optional] Action buyAction, [Optional] Action onClose)
	{
	}

	[Token(Token = "0x600769B")]
	[Address(RVA = "0x1B047A0", Offset = "0x1B047A0", VA = "0x1B047A0", Slot = "6")]
	protected override void BuildItemIcon(IShopItem item)
	{
	}
}
