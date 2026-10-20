using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E57")]
public class XUILobbyState_NormalShop : XUILobbyState
{
	[Token(Token = "0x4004B59")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_NormalShop m_shopWindow;

	[Token(Token = "0x17000DBE")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0x10A6F30", Offset = "0x10A6F30", VA = "0x10A6F30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AED")]
	[Address(RVA = "0x10A6728", Offset = "0x10A6728", VA = "0x10A6728")]
	public XUILobbyState_NormalShop()
	{
	}

	[Token(Token = "0x6006AEE")]
	[Address(RVA = "0x10A6730", Offset = "0x10A6730", VA = "0x10A6730", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AEF")]
	[Address(RVA = "0x10A6738", Offset = "0x10A6738", VA = "0x10A6738", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006AF0")]
	[Address(RVA = "0x10A67BC", Offset = "0x10A67BC", VA = "0x10A67BC")]
	private ShopSubCategory GetShopCategory()
	{
		return default(ShopSubCategory);
	}

	[Token(Token = "0x6006AF1")]
	[Address(RVA = "0x10A690C", Offset = "0x10A690C", VA = "0x10A690C", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AF2")]
	[Address(RVA = "0x10A6928", Offset = "0x10A6928", VA = "0x10A6928", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AF3")]
	[Address(RVA = "0x10A6980", Offset = "0x10A6980", VA = "0x10A6980", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AF4")]
	[Address(RVA = "0x10A6A34", Offset = "0x10A6A34", VA = "0x10A6A34", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006AF5")]
	[Address(RVA = "0x10A6BB4", Offset = "0x10A6BB4", VA = "0x10A6BB4", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006AF6")]
	[Address(RVA = "0x10A6CE0", Offset = "0x10A6CE0", VA = "0x10A6CE0", Slot = "16")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x6006AF7")]
	[Address(RVA = "0x10A6DEC", Offset = "0x10A6DEC", VA = "0x10A6DEC")]
	private void OnClickTab(ShopSubCategory subCategory)
	{
	}
}
