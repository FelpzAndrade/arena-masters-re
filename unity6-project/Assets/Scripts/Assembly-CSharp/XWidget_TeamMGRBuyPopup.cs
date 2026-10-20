using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FF5")]
public class XWidget_TeamMGRBuyPopup : XUIBaseWidget
{
	[Token(Token = "0x400551F")]
	[FieldOffset(Offset = "0x1C")]
	public Transform iconParent;

	[Token(Token = "0x4005520")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_ContentIcon m_itemIcon;

	[Token(Token = "0x4005521")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_ContentIcon.Option m_option;

	[Token(Token = "0x4005522")]
	[FieldOffset(Offset = "0x28")]
	public UI2DSprite sprCurrency;

	[Token(Token = "0x4005523")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblBuy;

	[Token(Token = "0x4005524")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblTitle;

	[Token(Token = "0x4005525")]
	[FieldOffset(Offset = "0x34")]
	private Action onClick;

	[Token(Token = "0x60076F8")]
	[Address(RVA = "0x1B18A9C", Offset = "0x1B18A9C", VA = "0x1B18A9C")]
	public XWidget_TeamMGRBuyPopup()
	{
	}

	[Token(Token = "0x60076F9")]
	[Address(RVA = "0x1B15E6C", Offset = "0x1B15E6C", VA = "0x1B15E6C")]
	public void Show(string title, CSContent content, Currency currency, int price, Action onClick)
	{
	}

	[Token(Token = "0x60076FA")]
	[Address(RVA = "0x1B18AAC", Offset = "0x1B18AAC", VA = "0x1B18AAC")]
	private void BuildTitle(string title)
	{
	}

	[Token(Token = "0x60076FB")]
	[Address(RVA = "0x1B18CDC", Offset = "0x1B18CDC", VA = "0x1B18CDC")]
	private void Buildprice(Currency currency, int price)
	{
	}

	[Token(Token = "0x60076FC")]
	[Address(RVA = "0x1B18AD8", Offset = "0x1B18AD8", VA = "0x1B18AD8")]
	private void BuildIcon(CSContent content)
	{
	}

	[Token(Token = "0x60076FD")]
	[Address(RVA = "0x1B18EA0", Offset = "0x1B18EA0", VA = "0x1B18EA0")]
	public void OnClickBuy()
	{
	}

	[Token(Token = "0x60076FE")]
	[Address(RVA = "0x1B18EF8", Offset = "0x1B18EF8", VA = "0x1B18EF8")]
	public void OnClickClose()
	{
	}
}
