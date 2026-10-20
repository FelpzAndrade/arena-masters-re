using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000FE3")]
public class XWidget_SellBox : MonoBehaviour
{
	[Token(Token = "0x40054C2")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblItemName;

	[Token(Token = "0x40054C3")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblPrice;

	[Token(Token = "0x40054C4")]
	[FieldOffset(Offset = "0x14")]
	public Transform icon;

	[Token(Token = "0x40054C5")]
	[FieldOffset(Offset = "0x18")]
	private XItem m_item;

	[Token(Token = "0x40054C6")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_ItemIcon m_icon;

	[Token(Token = "0x40054C7")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isSelling;

	[Token(Token = "0x6007685")]
	[Address(RVA = "0x1B026D8", Offset = "0x1B026D8", VA = "0x1B026D8")]
	public XWidget_SellBox()
	{
	}

	[Token(Token = "0x6007686")]
	[Address(RVA = "0x1B026E0", Offset = "0x1B026E0", VA = "0x1B026E0")]
	public void Build(XItem item)
	{
	}

	[Token(Token = "0x6007687")]
	[Address(RVA = "0x1B02BA0", Offset = "0x1B02BA0", VA = "0x1B02BA0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6007688")]
	[Address(RVA = "0x1B02BD4", Offset = "0x1B02BD4", VA = "0x1B02BD4")]
	public void Sell()
	{
	}

	[Token(Token = "0x6007689")]
	[Address(RVA = "0x1B02E04", Offset = "0x1B02E04", VA = "0x1B02E04")]
	private void _003CSell_003Em__4E4(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x600768A")]
	[Address(RVA = "0x1B030A4", Offset = "0x1B030A4", VA = "0x1B030A4")]
	private void _003CSell_003Em__4E5()
	{
	}
}
