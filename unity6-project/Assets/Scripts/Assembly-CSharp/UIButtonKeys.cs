using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C3")]
[ExecuteInEditMode]
public class UIButtonKeys : UIKeyNavigation
{
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x2C")]
	public UIButtonKeys selectOnClick;

	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x30")]
	public UIButtonKeys selectOnUp;

	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x34")]
	public UIButtonKeys selectOnDown;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x38")]
	public UIButtonKeys selectOnLeft;

	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x3C")]
	public UIButtonKeys selectOnRight;

	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x16C1194", Offset = "0x16C1194", VA = "0x16C1194")]
	public UIButtonKeys()
	{
	}

	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x16C1240", Offset = "0x16C1240", VA = "0x16C1240", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0x16C125C", Offset = "0x16C125C", VA = "0x16C125C")]
	public void Upgrade()
	{
	}
}
