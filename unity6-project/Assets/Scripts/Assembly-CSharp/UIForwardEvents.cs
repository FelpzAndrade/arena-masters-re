using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D7")]
public class UIForwardEvents : MonoBehaviour
{
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0xC")]
	public GameObject target;

	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x10")]
	public bool onHover;

	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x11")]
	public bool onPress;

	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x12")]
	public bool onClick;

	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x13")]
	public bool onDoubleClick;

	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x14")]
	public bool onSelect;

	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x15")]
	public bool onDrag;

	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x16")]
	public bool onDrop;

	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x17")]
	public bool onSubmit;

	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x18")]
	public bool onScroll;

	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x16F1B94", Offset = "0x16F1B94", VA = "0x16F1B94")]
	public UIForwardEvents()
	{
	}

	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x16F1B9C", Offset = "0x16F1B9C", VA = "0x16F1B9C")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x16F1CE0", Offset = "0x16F1CE0", VA = "0x16F1CE0")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x16F1E24", Offset = "0x16F1E24", VA = "0x16F1E24")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x16F1F2C", Offset = "0x16F1F2C", VA = "0x16F1F2C")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x16F2034", Offset = "0x16F2034", VA = "0x16F2034")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x16F2178", Offset = "0x16F2178", VA = "0x16F2178")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x16F22C4", Offset = "0x16F22C4", VA = "0x16F22C4")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x16F23DC", Offset = "0x16F23DC", VA = "0x16F23DC")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x16F24E4", Offset = "0x16F24E4", VA = "0x16F24E4")]
	private void OnScroll(float delta)
	{
	}
}
