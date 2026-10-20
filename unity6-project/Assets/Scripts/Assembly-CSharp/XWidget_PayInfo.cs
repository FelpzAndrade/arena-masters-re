using Il2CppDummyDll;

[Token(Token = "0x2000FC8")]
public class XWidget_PayInfo : XUIBaseWidget
{
	[Token(Token = "0x40053EE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblPayCrystal;

	[Token(Token = "0x40053EF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblPayGold;

	[Token(Token = "0x40053F0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblFreeCrystal;

	[Token(Token = "0x40053F1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblFreeGold;

	[Token(Token = "0x600759C")]
	[Address(RVA = "0x1316DC8", Offset = "0x1316DC8", VA = "0x1316DC8")]
	public XWidget_PayInfo()
	{
	}

	[Token(Token = "0x600759D")]
	[Address(RVA = "0x130CB44", Offset = "0x130CB44", VA = "0x130CB44")]
	public void Show(int payCrystal, int payGold, int freeCrystal, int freeGold)
	{
	}

	[Token(Token = "0x600759E")]
	[Address(RVA = "0x1316DD0", Offset = "0x1316DD0", VA = "0x1316DD0", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600759F")]
	[Address(RVA = "0x1316DD8", Offset = "0x1316DD8", VA = "0x1316DD8")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x60075A0")]
	[Address(RVA = "0x1316E1C", Offset = "0x1316E1C", VA = "0x1316E1C")]
	public void OnClick_Confirm()
	{
	}
}
