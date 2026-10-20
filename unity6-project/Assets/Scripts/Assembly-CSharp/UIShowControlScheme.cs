using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F7")]
public class UIShowControlScheme : MonoBehaviour
{
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject target;

	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x10")]
	public bool mouse;

	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x11")]
	public bool touch;

	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x12")]
	public bool controller;

	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x179B2B4", Offset = "0x179B2B4", VA = "0x179B2B4")]
	public UIShowControlScheme()
	{
	}

	[Token(Token = "0x60010A6")]
	[Address(RVA = "0x179B2C4", Offset = "0x179B2C4", VA = "0x179B2C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x179B644", Offset = "0x179B644", VA = "0x179B644")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x179B4E0", Offset = "0x179B4E0", VA = "0x179B4E0")]
	private void OnScheme()
	{
	}
}
