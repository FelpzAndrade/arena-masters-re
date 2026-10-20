using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C0")]
public class UIButtonActivate : MonoBehaviour
{
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0xC")]
	public GameObject target;

	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x10")]
	public bool state;

	[Token(Token = "0x6000F03")]
	[Address(RVA = "0x16BFDFC", Offset = "0x16BFDFC", VA = "0x16BFDFC")]
	public UIButtonActivate()
	{
	}

	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x16BFE0C", Offset = "0x16BFE0C", VA = "0x16BFE0C")]
	private void OnClick()
	{
	}
}
