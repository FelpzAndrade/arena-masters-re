using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FE7")]
public class XWidget_ShopBuyPopupBase : MonoBehaviour
{
	[Token(Token = "0x40054D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblTopTitle;

	[Token(Token = "0x40054D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject goArenaCoin;

	[Token(Token = "0x40054D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject goFreeText;

	[Token(Token = "0x40054D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject goPrice;

	[Token(Token = "0x40054D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblBuyPrice;

	[Token(Token = "0x40054D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblArenaCoinGet;

	[Token(Token = "0x40054D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UI2DSprite sprPriceIcon;

	[Token(Token = "0x40054D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UITable priceTable;

	[Token(Token = "0x40054D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UI2DSprite sprItemIcon;

	[Token(Token = "0x40054DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UI2DSprite sprHeroIcon;

	[Token(Token = "0x40054DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected IShopItem m_info;

	[Token(Token = "0x40054DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Action m_buyAction;

	[Token(Token = "0x40054DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected Action m_onCloseAction;

	[Token(Token = "0x40054DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject goBtnBuy;

	[Token(Token = "0x600769C")]
	[Address(RVA = "0x1B04450", Offset = "0x1B04450", VA = "0x1B04450")]
	public XWidget_ShopBuyPopupBase()
	{
	}

	[Token(Token = "0x600769D")]
	[Address(RVA = "0x1B04C30", Offset = "0x1B04C30", VA = "0x1B04C30", Slot = "4")]
	protected virtual string GetPriceStringFormat()
	{
		return null;
	}

	[Token(Token = "0x600769E")]
	[Address(RVA = "0x1B04CB4", Offset = "0x1B04CB4", VA = "0x1B04CB4", Slot = "5")]
	protected virtual string GetTopText()
	{
		return null;
	}

	[Token(Token = "0x600769F")]
	[Address(RVA = "0x1B04DBC", Offset = "0x1B04DBC", VA = "0x1B04DBC")]
	private void BuildPrice(bool buyFree, string strSaleType, int presentPrice)
	{
	}

	[Token(Token = "0x60076A0")]
	[Address(RVA = "0x1B05344", Offset = "0x1B05344", VA = "0x1B05344", Slot = "6")]
	protected virtual void BuildItemIcon(IShopItem item)
	{
	}

	[Token(Token = "0x60076A1")]
	[Address(RVA = "0x1B05560", Offset = "0x1B05560", VA = "0x1B05560")]
	protected void BuildHeroIcon(IShopItem item)
	{
	}

	[Token(Token = "0x60076A2")]
	[Address(RVA = "0x1B04458", Offset = "0x1B04458", VA = "0x1B04458", Slot = "7")]
	public virtual void Build(IShopItem item, bool buy_free, [Optional] Action buyAction, [Optional] Action onClose)
	{
	}

	[Token(Token = "0x60076A3")]
	[Address(RVA = "0x1B057C8", Offset = "0x1B057C8", VA = "0x1B057C8")]
	private bool TryCheckMaxResource(IShopItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x60076A4")]
	[Address(RVA = "0x1B05E20", Offset = "0x1B05E20", VA = "0x1B05E20")]
	private bool TryGetCheckAndMaxResource(IShopItem item, out int check, out int max)
	{
		check = default;
		max = default;
		return default(bool);
	}

	[Token(Token = "0x60076A5")]
	[Address(RVA = "0x1B06318", Offset = "0x1B06318", VA = "0x1B06318")]
	private string GetErrorMessage(CSContentType type)
	{
		return null;
	}

	[Token(Token = "0x60076A6")]
	[Address(RVA = "0x1B05B24", Offset = "0x1B05B24", VA = "0x1B05B24")]
	protected void BuildArenaCoinContain(IShopItem shopItem)
	{
	}

	[Token(Token = "0x60076A7")]
	[Address(RVA = "0x1B0643C", Offset = "0x1B0643C", VA = "0x1B0643C")]
	public void OnClick_Buy()
	{
	}

	[Token(Token = "0x60076A8")]
	[Address(RVA = "0x1B06450", Offset = "0x1B06450", VA = "0x1B06450")]
	public void OnClick_Close()
	{
	}
}
