using Il2CppDummyDll;

[Token(Token = "0x2000E49")]
public class XUILobbyState_GachaShopBuy : XUILobbyState
{
	[Token(Token = "0x4004B46")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_ShopBuy m_pnlShopBuy;

	[Token(Token = "0x17000DB1")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006A68")]
		[Address(RVA = "0x10A0BB8", Offset = "0x10A0BB8", VA = "0x10A0BB8", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006A66")]
	[Address(RVA = "0x10A0BA8", Offset = "0x10A0BA8", VA = "0x10A0BA8")]
	public XUILobbyState_GachaShopBuy()
	{
	}

	[Token(Token = "0x6006A67")]
	[Address(RVA = "0x10A0BB0", Offset = "0x10A0BB0", VA = "0x10A0BB0", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A69")]
	[Address(RVA = "0x10A0BC0", Offset = "0x10A0BC0", VA = "0x10A0BC0", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A6A")]
	[Address(RVA = "0x10A0BDC", Offset = "0x10A0BDC", VA = "0x10A0BDC", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A6B")]
	[Address(RVA = "0x10A0CB4", Offset = "0x10A0CB4", VA = "0x10A0CB4", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A6C")]
	[Address(RVA = "0x10A10A4", Offset = "0x10A10A4", VA = "0x10A10A4")]
	private bool TryShowArenaShopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A6D")]
	[Address(RVA = "0x10A120C", Offset = "0x10A120C", VA = "0x10A120C")]
	private bool IsArenaShopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A6E")]
	[Address(RVA = "0x10A135C", Offset = "0x10A135C", VA = "0x10A135C", Slot = "16")]
	public override void OnHide()
	{
	}
}
