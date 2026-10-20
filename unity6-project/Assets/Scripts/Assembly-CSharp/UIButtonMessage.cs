using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C4")]
public class UIButtonMessage : MonoBehaviour
{
	[Token(Token = "0x20001C5")]
	public enum Trigger
	{
		[Token(Token = "0x40006A8")]
		OnClick = 0,
		[Token(Token = "0x40006A9")]
		OnMouseOver = 1,
		[Token(Token = "0x40006AA")]
		OnMouseOut = 2,
		[Token(Token = "0x40006AB")]
		OnPress = 3,
		[Token(Token = "0x40006AC")]
		OnRelease = 4,
		[Token(Token = "0x40006AD")]
		OnDoubleClick = 5
	}

	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0xC")]
	public GameObject target;

	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x10")]
	public string functionName;

	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x14")]
	public Trigger trigger;

	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x18")]
	public bool includeChildren;

	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x19")]
	private bool mStarted;

	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x16C18EC", Offset = "0x16C18EC", VA = "0x16C18EC")]
	public UIButtonMessage()
	{
	}

	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x16C18F4", Offset = "0x16C18F4", VA = "0x16C18F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x16C1900", Offset = "0x16C1900", VA = "0x16C1900")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x16C19C8", Offset = "0x16C19C8", VA = "0x16C19C8")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x16C1C58", Offset = "0x16C1C58", VA = "0x16C1C58")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x16C1CA8", Offset = "0x16C1CA8", VA = "0x16C1CA8")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x16C1D7C", Offset = "0x16C1D7C", VA = "0x16C1D7C")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x16C1DB0", Offset = "0x16C1DB0", VA = "0x16C1DB0")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x16C1A18", Offset = "0x16C1A18", VA = "0x16C1A18")]
	private void Send()
	{
	}
}
