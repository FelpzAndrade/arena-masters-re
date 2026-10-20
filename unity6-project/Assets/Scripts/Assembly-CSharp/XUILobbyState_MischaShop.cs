using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E53")]
public class XUILobbyState_MischaShop : XUILobbyState
{
	[Token(Token = "0x4004B52")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_MischaShop m_pnlMischaShop;

	[Token(Token = "0x6006AC7")]
	[Address(RVA = "0x10A4C18", Offset = "0x10A4C18", VA = "0x10A4C18")]
	public XUILobbyState_MischaShop()
	{
	}

	[Token(Token = "0x6006AC8")]
	[Address(RVA = "0x10A4C20", Offset = "0x10A4C20", VA = "0x10A4C20", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AC9")]
	[Address(RVA = "0x10A4C28", Offset = "0x10A4C28", VA = "0x10A4C28", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006ACA")]
	[Address(RVA = "0x10A4CAC", Offset = "0x10A4CAC", VA = "0x10A4CAC", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006ACB")]
	[Address(RVA = "0x10A4D04", Offset = "0x10A4D04", VA = "0x10A4D04", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006ACC")]
	[Address(RVA = "0x10A4D20", Offset = "0x10A4D20", VA = "0x10A4D20")]
	private ShopSubCategory GetShopCategory()
	{
		return default(ShopSubCategory);
	}

	[Token(Token = "0x6006ACD")]
	[Address(RVA = "0x10A4E70", Offset = "0x10A4E70", VA = "0x10A4E70", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006ACE")]
	[Address(RVA = "0x10A4F24", Offset = "0x10A4F24", VA = "0x10A4F24", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006ACF")]
	[Address(RVA = "0x10A5040", Offset = "0x10A5040", VA = "0x10A5040", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006AD0")]
	[Address(RVA = "0x10A516C", Offset = "0x10A516C", VA = "0x10A516C", Slot = "16")]
	public override void OnHide()
	{
	}
}
