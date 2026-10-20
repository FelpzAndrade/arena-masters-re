using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001DD")]
public class UIKeyBinding : MonoBehaviour
{
	[Token(Token = "0x20001DE")]
	public enum Action
	{
		[Token(Token = "0x4000757")]
		PressAndClick = 0,
		[Token(Token = "0x4000758")]
		Select = 1,
		[Token(Token = "0x4000759")]
		All = 2
	}

	[Token(Token = "0x20001DF")]
	public enum Modifier
	{
		[Token(Token = "0x400075B")]
		Any = 0,
		[Token(Token = "0x400075C")]
		Shift = 1,
		[Token(Token = "0x400075D")]
		Control = 2,
		[Token(Token = "0x400075E")]
		Alt = 3,
		[Token(Token = "0x400075F")]
		None = 4
	}

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x0")]
	private static List<UIKeyBinding> mList;

	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0xC")]
	public KeyCode keyCode;

	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x10")]
	public Modifier modifier;

	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x14")]
	public Action action;

	[NonSerialized]
	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x18")]
	private bool mIgnoreUp;

	[NonSerialized]
	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x19")]
	private bool mIsInput;

	[NonSerialized]
	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x1A")]
	private bool mPress;

	[Token(Token = "0x17000256")]
	public string captionText
	{
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x16FE350", Offset = "0x16FE350", VA = "0x16FE350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0x16FE298", Offset = "0x16FE298", VA = "0x16FE298")]
	public UIKeyBinding()
	{
	}

	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x16FE520", Offset = "0x16FE520", VA = "0x16FE520")]
	public static bool IsBound(KeyCode key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x16FE71C", Offset = "0x16FE71C", VA = "0x16FE71C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x16FE808", Offset = "0x16FE808", VA = "0x16FE808", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x16FE8F4", Offset = "0x16FE8F4", VA = "0x16FE8F4", Slot = "6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x16FEA74", Offset = "0x16FEA74", VA = "0x16FEA74", Slot = "7")]
	protected virtual void OnSubmit()
	{
	}

	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x16FEB54", Offset = "0x16FEB54", VA = "0x16FEB54", Slot = "8")]
	protected virtual bool IsModifierActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x16FF0F0", Offset = "0x16FF0F0", VA = "0x16FF0F0", Slot = "9")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x16FF4F0", Offset = "0x16FF4F0", VA = "0x16FF4F0", Slot = "10")]
	protected virtual void OnBindingPress(bool pressed)
	{
	}

	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0x16FF5EC", Offset = "0x16FF5EC", VA = "0x16FF5EC", Slot = "11")]
	protected virtual void OnBindingClick()
	{
	}

	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0x16FF6C4", Offset = "0x16FF6C4", VA = "0x16FF6C4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0x16FF858", Offset = "0x16FF858", VA = "0x16FF858")]
	public static bool GetKeyCode(string text, out KeyCode key, out Modifier modifier)
	{
		key = default;
		modifier = default;
		return default(bool);
	}
}
