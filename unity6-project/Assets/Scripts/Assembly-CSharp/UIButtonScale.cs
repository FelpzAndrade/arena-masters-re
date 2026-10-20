using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C8")]
public class UIButtonScale : MonoBehaviour
{
	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0xC")]
	public Transform tweenTarget;

	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 hover;

	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 pressed;

	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 mScale;

	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x38")]
	private bool mStarted;

	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x16C2EC8", Offset = "0x16C2EC8", VA = "0x16C2EC8")]
	public UIButtonScale()
	{
	}

	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x16C2F68", Offset = "0x16C2F68", VA = "0x16C2F68")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x16C3088", Offset = "0x16C3088", VA = "0x16C3088")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x16C3248", Offset = "0x16C3248", VA = "0x16C3248")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x16C33C8", Offset = "0x16C33C8", VA = "0x16C33C8")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x16C3150", Offset = "0x16C3150", VA = "0x16C3150")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x16C35B4", Offset = "0x16C35B4", VA = "0x16C35B4")]
	private void OnSelect(bool isSelected)
	{
	}
}
