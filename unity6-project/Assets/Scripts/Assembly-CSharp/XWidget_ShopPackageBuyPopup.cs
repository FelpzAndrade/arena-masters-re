using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FEA")]
public class XWidget_ShopPackageBuyPopup : XWidget_ShopBuyPopupBase
{
	[Token(Token = "0x40054E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UILabel lblBuyDesc;

	[Token(Token = "0x40054E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UILabel lblBottomMessage;

	[Token(Token = "0x60076AD")]
	[Address(RVA = "0x1B06A50", Offset = "0x1B06A50", VA = "0x1B06A50")]
	public XWidget_ShopPackageBuyPopup()
	{
	}

	[Token(Token = "0x60076AE")]
	[Address(RVA = "0x1B06A58", Offset = "0x1B06A58", VA = "0x1B06A58", Slot = "7")]
	public override void Build(IShopItem item, bool buy_free, [Optional] Action buyAction, [Optional] Action onClose)
	{
	}

	[Token(Token = "0x60076AF")]
	[Address(RVA = "0x1B06C94", Offset = "0x1B06C94", VA = "0x1B06C94", Slot = "4")]
	protected override string GetPriceStringFormat()
	{
		return null;
	}

	[Token(Token = "0x60076B0")]
	[Address(RVA = "0x1B06D0C", Offset = "0x1B06D0C", VA = "0x1B06D0C", Slot = "5")]
	protected override string GetTopText()
	{
		return null;
	}
}
