using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E5C")]
public class XUILobbyState_PointShop : XUILobbyState
{
	[Token(Token = "0x4004B61")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_PointShop m_pvpShopWindow;

	[Token(Token = "0x17000DC3")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B24")]
		[Address(RVA = "0x10A8788", Offset = "0x10A8788", VA = "0x10A8788", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006B21")]
	[Address(RVA = "0x10A86F4", Offset = "0x10A86F4", VA = "0x10A86F4")]
	public XUILobbyState_PointShop()
	{
	}

	[Token(Token = "0x6006B22")]
	[Address(RVA = "0x10A86FC", Offset = "0x10A86FC", VA = "0x10A86FC", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B23")]
	[Address(RVA = "0x10A8704", Offset = "0x10A8704", VA = "0x10A8704", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B25")]
	[Address(RVA = "0x10A8880", Offset = "0x10A8880", VA = "0x10A8880", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B26")]
	[Address(RVA = "0x10A88D8", Offset = "0x10A88D8", VA = "0x10A88D8", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B27")]
	[Address(RVA = "0x10A88F4", Offset = "0x10A88F4", VA = "0x10A88F4")]
	private ShopSubCategory GetShopCategory()
	{
		return default(ShopSubCategory);
	}

	[Token(Token = "0x6006B28")]
	[Address(RVA = "0x10A8A44", Offset = "0x10A8A44", VA = "0x10A8A44", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B29")]
	[Address(RVA = "0x10A8AF8", Offset = "0x10A8AF8", VA = "0x10A8AF8", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B2A")]
	[Address(RVA = "0x10A8C78", Offset = "0x10A8C78", VA = "0x10A8C78", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006B2B")]
	[Address(RVA = "0x10A8DA4", Offset = "0x10A8DA4", VA = "0x10A8DA4")]
	private void OnClickTab(ShopSubCategory subCategory)
	{
	}

	[Token(Token = "0x6006B2C")]
	[Address(RVA = "0x10A8EA4", Offset = "0x10A8EA4", VA = "0x10A8EA4", Slot = "16")]
	public override void OnHide()
	{
	}
}
