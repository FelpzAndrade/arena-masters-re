using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C6E")]
public class XWidget_BeforeAfter : MonoBehaviour
{
	[Token(Token = "0x4003F06")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_KeyValueLabel before;

	[Token(Token = "0x4003F07")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_KeyValueLabel after;

	[Token(Token = "0x4003F08")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goSprArrow;

	[Token(Token = "0x60059B3")]
	[Address(RVA = "0x15BC26C", Offset = "0x15BC26C", VA = "0x15BC26C")]
	public XWidget_BeforeAfter()
	{
	}

	[Token(Token = "0x60059B4")]
	[Address(RVA = "0x15BC274", Offset = "0x15BC274", VA = "0x15BC274")]
	public void Show(string beforeKey, string beforeValue, string afterKey, string afterValue, bool showArrow)
	{
	}
}
