using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C54")]
public class XPanel_RewardPopup : MonoBehaviour
{
	[Token(Token = "0x4003E6E")]
	[FieldOffset(Offset = "0xC")]
	public UIBasicSprite sprBackGround;

	[Token(Token = "0x4003E6F")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblTitle;

	[Token(Token = "0x4003E70")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x4003E71")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblMail;

	[Token(Token = "0x4003E72")]
	[FieldOffset(Offset = "0x1C")]
	public string soundKey;

	[Token(Token = "0x600592A")]
	[Address(RVA = "0xAB8B04", Offset = "0xAB8B04", VA = "0xAB8B04")]
	public XPanel_RewardPopup()
	{
	}

	[Token(Token = "0x600592B")]
	[Address(RVA = "0xAB8B90", Offset = "0xAB8B90", VA = "0xAB8B90")]
	private XWidget_ContentIcon.Option GetContentOption()
	{
		return default(XWidget_ContentIcon.Option);
	}

	[Token(Token = "0x600592C")]
	[Address(RVA = "0xAB8BC4", Offset = "0xAB8BC4", VA = "0xAB8BC4")]
	public void Build(string title, Netdata_BuyShopItem acquisitions, bool Mail)
	{
	}

	[Token(Token = "0x600592D")]
	[Address(RVA = "0xAB90B4", Offset = "0xAB90B4", VA = "0xAB90B4")]
	public void Build(string title, CSContent reward, bool Mail = false)
	{
	}

	[Token(Token = "0x600592E")]
	[Address(RVA = "0xAB8EF0", Offset = "0xAB8EF0", VA = "0xAB8EF0")]
	private void BuildPanel(string title, bool Mail)
	{
	}

	[Token(Token = "0x600592F")]
	[Address(RVA = "0xAB8DB4", Offset = "0xAB8DB4", VA = "0xAB8DB4")]
	private void BuildBackGround(int count)
	{
	}

	[Token(Token = "0x6005930")]
	[Address(RVA = "0xAB91FC", Offset = "0xAB91FC", VA = "0xAB91FC")]
	public void Hide()
	{
	}
}
