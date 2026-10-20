using Il2CppDummyDll;

[Token(Token = "0x2000E61")]
public class XUILobbyState_ShopBuyConfirm : XUILobbyState
{
	[Token(Token = "0x4004B66")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_BuyConfirm m_pnlShopConfirm;

	[Token(Token = "0x17000DD0")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006B58")]
		[Address(RVA = "0x10AB53C", Offset = "0x10AB53C", VA = "0x10AB53C", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DD1")]
	public override bool IsBackable
	{
		[Token(Token = "0x6006B59")]
		[Address(RVA = "0x10AB544", Offset = "0x10AB544", VA = "0x10AB544", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006B55")]
	[Address(RVA = "0x10AB510", Offset = "0x10AB510", VA = "0x10AB510")]
	public XUILobbyState_ShopBuyConfirm()
	{
	}

	[Token(Token = "0x6006B56")]
	[Address(RVA = "0x10AB518", Offset = "0x10AB518", VA = "0x10AB518", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B57")]
	[Address(RVA = "0x10AB520", Offset = "0x10AB520", VA = "0x10AB520", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B5A")]
	[Address(RVA = "0x10AB59C", Offset = "0x10AB59C", VA = "0x10AB59C", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B5B")]
	[Address(RVA = "0x10AB644", Offset = "0x10AB644", VA = "0x10AB644", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B5C")]
	[Address(RVA = "0x10AB934", Offset = "0x10AB934", VA = "0x10AB934", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006B5D")]
	[Address(RVA = "0x10ABA0C", Offset = "0x10ABA0C", VA = "0x10ABA0C", Slot = "16")]
	public override void OnHide()
	{
	}
}
