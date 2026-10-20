using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E85")]
public class XWidget_ButtonCommon : XWidget_Button
{
	[Token(Token = "0x2000E86")]
	public enum ButtonType
	{
		[Token(Token = "0x4004C15")]
		None = 0,
		[Token(Token = "0x4004C16")]
		Red = 1,
		[Token(Token = "0x4004C17")]
		Yellow = 2,
		[Token(Token = "0x4004C18")]
		Blue = 3
	}

	[Token(Token = "0x4004C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UI2DSprite sprTopGlow1;

	[Token(Token = "0x4004C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UI2DSprite sprTopGlow2;

	[Token(Token = "0x4004C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UI2DSprite sprBottomGlow1;

	[Token(Token = "0x4004C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UI2DSprite sprBottomGlow2;

	[Token(Token = "0x4004C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public UI2DSprite sprBG;

	[Token(Token = "0x4004C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ButtonType m_btnType__BackingField;

	[Token(Token = "0x17000DE8")]
	public ButtonType m_btnType
	{
		[Token(Token = "0x6006C3E")]
		[Address(RVA = "0x15C45F0", Offset = "0x15C45F0", VA = "0x15C45F0")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6006C3F")]
		[Address(RVA = "0x15C45F8", Offset = "0x15C45F8", VA = "0x15C45F8")]
		private set
		{
		}
	}

	[Token(Token = "0x6006C3D")]
	[Address(RVA = "0x15C45DC", Offset = "0x15C45DC", VA = "0x15C45DC")]
	public XWidget_ButtonCommon()
	{
	}

	[Token(Token = "0x6006C40")]
	[Address(RVA = "0x15C4600", Offset = "0x15C4600", VA = "0x15C4600", Slot = "4")]
	public override void Build(string title, Action onClick, [Optional][DefaultParameterValue(false)] bool isDisable, [Optional] Action onDisableClick)
	{
	}

	[Token(Token = "0x6006C41")]
	[Address(RVA = "0x15C4678", Offset = "0x15C4678", VA = "0x15C4678")]
	private void BuildButtonType()
	{
	}

	[Token(Token = "0x6006C42")]
	[Address(RVA = "0x15C4A44", Offset = "0x15C4A44", VA = "0x15C4A44")]
	private void BuildGlow(ButtonType btnType, Color color)
	{
	}

	[Token(Token = "0x6006C43")]
	[Address(RVA = "0x15C4B9C", Offset = "0x15C4B9C", VA = "0x15C4B9C")]
	public void Build(ButtonType type, string title, Action onClick, [Optional][DefaultParameterValue(false)] bool isDisable, [Optional] Action onDisableClick)
	{
	}

	[Token(Token = "0x6006C44")]
	[Address(RVA = "0x15C4978", Offset = "0x15C4978", VA = "0x15C4978")]
	private void SetAnchor(ButtonType btnType)
	{
	}
}
