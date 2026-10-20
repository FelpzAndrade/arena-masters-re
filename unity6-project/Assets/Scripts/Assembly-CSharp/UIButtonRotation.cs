using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C7")]
public class UIButtonRotation : MonoBehaviour
{
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0xC")]
	public Transform tweenTarget;

	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 hover;

	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 pressed;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion mRot;

	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x3C")]
	private bool mStarted;

	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x16C26AC", Offset = "0x16C26AC", VA = "0x16C26AC")]
	public UIButtonRotation()
	{
	}

	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x16C2714", Offset = "0x16C2714", VA = "0x16C2714")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x16C2838", Offset = "0x16C2838", VA = "0x16C2838")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x16C2A20", Offset = "0x16C2A20", VA = "0x16C2A20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x16C2BA4", Offset = "0x16C2BA4", VA = "0x16C2BA4")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x16C2900", Offset = "0x16C2900", VA = "0x16C2900")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x16C2DF4", Offset = "0x16C2DF4", VA = "0x16C2DF4")]
	private void OnSelect(bool isSelected)
	{
	}
}
