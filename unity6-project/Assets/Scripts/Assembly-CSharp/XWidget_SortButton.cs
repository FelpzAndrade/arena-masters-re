using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EAC")]
public class XWidget_SortButton : XWidget_Button
{
	[Token(Token = "0x4004D0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UISprite sprArrow;

	[Token(Token = "0x4004D0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UISprite sprArrowActive;

	[Token(Token = "0x4004D0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private new Action<bool> m_onClick;

	[Token(Token = "0x4004D0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool IsAsecnding__BackingField;

	[Token(Token = "0x17000DFB")]
	public bool IsAsecnding
	{
		[Token(Token = "0x6006D64")]
		[Address(RVA = "0x1B0BB80", Offset = "0x1B0BB80", VA = "0x1B0BB80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006D65")]
		[Address(RVA = "0x1B0BB88", Offset = "0x1B0BB88", VA = "0x1B0BB88")]
		private set
		{
		}
	}

	[Token(Token = "0x6006D63")]
	[Address(RVA = "0x1B0BB78", Offset = "0x1B0BB78", VA = "0x1B0BB78")]
	public XWidget_SortButton()
	{
	}

	[Token(Token = "0x6006D66")]
	[Address(RVA = "0x1B0BB90", Offset = "0x1B0BB90", VA = "0x1B0BB90")]
	public void Build(string sortName, bool initAscending, [Optional][DefaultParameterValue(true)] bool isActive, [Optional] Action<bool> onClick)
	{
	}

	[Token(Token = "0x6006D67")]
	[Address(RVA = "0x1B0BCA0", Offset = "0x1B0BCA0", VA = "0x1B0BCA0", Slot = "5")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6006D68")]
	[Address(RVA = "0x1B0BC38", Offset = "0x1B0BC38", VA = "0x1B0BC38")]
	private void SetSprArrow()
	{
	}

	[Token(Token = "0x6006D69")]
	[Address(RVA = "0x1B0BDC8", Offset = "0x1B0BDC8", VA = "0x1B0BDC8")]
	public void SetActive(GameObject goActive)
	{
	}

	[Token(Token = "0x6006D6A")]
	[Address(RVA = "0x1B0BC6C", Offset = "0x1B0BC6C", VA = "0x1B0BC6C")]
	private void SetSprArrowActive()
	{
	}
}
