using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C6")]
public class UIButtonOffset : MonoBehaviour
{
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0xC")]
	public Transform tweenTarget;

	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 hover;

	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 pressed;

	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x28")]
	public float duration;

	[NonSerialized]
	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 mPos;

	[NonSerialized]
	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x38")]
	private bool mStarted;

	[NonSerialized]
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x39")]
	private bool mPressed;

	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x16C1DE4", Offset = "0x16C1DE4", VA = "0x16C1DE4")]
	public UIButtonOffset()
	{
	}

	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x16C1E60", Offset = "0x16C1E60", VA = "0x16C1E60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x16C1F80", Offset = "0x16C1F80", VA = "0x16C1F80")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x16C2140", Offset = "0x16C2140", VA = "0x16C2140")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x16C22C0", Offset = "0x16C22C0", VA = "0x16C22C0")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x16C2048", Offset = "0x16C2048", VA = "0x16C2048")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x16C24B0", Offset = "0x16C24B0", VA = "0x16C24B0")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x16C2560", Offset = "0x16C2560", VA = "0x16C2560")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x16C25D8", Offset = "0x16C25D8", VA = "0x16C25D8")]
	private void OnSelect(bool isSelected)
	{
	}
}
