using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DF0")]
public class XPanel_InvenExtend : MonoBehaviour
{
	[Token(Token = "0x40048DE")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblInvenCountCurrent;

	[Token(Token = "0x40048DF")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblInvenCountAfter;

	[Token(Token = "0x40048E0")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblPrice;

	[Token(Token = "0x6006724")]
	[Address(RVA = "0xFF7318", Offset = "0xFF7318", VA = "0xFF7318")]
	public XPanel_InvenExtend()
	{
	}

	[Token(Token = "0x6006725")]
	[Address(RVA = "0xFF7320", Offset = "0xFF7320", VA = "0xFF7320")]
	public void Build()
	{
	}

	[Token(Token = "0x6006726")]
	[Address(RVA = "0xFF7578", Offset = "0xFF7578", VA = "0xFF7578")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006727")]
	[Address(RVA = "0xFF75AC", Offset = "0xFF75AC", VA = "0xFF75AC")]
	public void OnClick_BuyItemInvenSlot()
	{
	}

	[Token(Token = "0x6006728")]
	[Address(RVA = "0xFF7AE8", Offset = "0xFF7AE8", VA = "0xFF7AE8")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x6006729")]
	[Address(RVA = "0xFF7BBC", Offset = "0xFF7BBC", VA = "0xFF7BBC")]
	private void _003COnClick_BuyItemInvenSlot_003Em__385(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
