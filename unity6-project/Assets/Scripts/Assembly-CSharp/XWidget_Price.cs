using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C92")]
public class XWidget_Price : MonoBehaviour
{
	[Token(Token = "0x4003FF0")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblPrice;

	[Token(Token = "0x4003FF1")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprPriceIcon;

	[Token(Token = "0x4003FF2")]
	[FieldOffset(Offset = "0x14")]
	public UITable arrangeTable;

	[Token(Token = "0x4003FF3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goDiscount;

	[Token(Token = "0x6005AC5")]
	[Address(RVA = "0x131F01C", Offset = "0x131F01C", VA = "0x131F01C")]
	public XWidget_Price()
	{
	}

	[Token(Token = "0x6005AC6")]
	[Address(RVA = "0x131F024", Offset = "0x131F024", VA = "0x131F024")]
	public void Build(bool isDiscount, bool isCach, Sprite sprPrice, string strPrice)
	{
	}

	[Token(Token = "0x6005AC7")]
	[Address(RVA = "0x131F0F8", Offset = "0x131F0F8", VA = "0x131F0F8")]
	private void SetActiveDiscount(bool bActive)
	{
	}

	[Token(Token = "0x6005AC8")]
	[Address(RVA = "0x131F1D8", Offset = "0x131F1D8", VA = "0x131F1D8")]
	public void SetActive(bool bActive)
	{
	}
}
