using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C9B")]
public class XWidget_Selectable_Label : MonoBehaviour
{
	[Token(Token = "0x400402E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWidget_OnPress widgetPress;

	[Token(Token = "0x400402F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblFirst;

	[Token(Token = "0x4004030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblSecond;

	[Token(Token = "0x4004031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject spriteCheck;

	[Token(Token = "0x4004032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject goEffect;

	[Token(Token = "0x4004033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_isSelected;

	[Token(Token = "0x4004034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Action<bool, int> m_selectAction;

	[Token(Token = "0x4004035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_index;

	[Token(Token = "0x17000CC4")]
	public bool IsSelected
	{
		[Token(Token = "0x6005B11")]
		[Address(RVA = "0x1346A74", Offset = "0x1346A74", VA = "0x1346A74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000CC5")]
	public int Index
	{
		[Token(Token = "0x6005B12")]
		[Address(RVA = "0x1304BA4", Offset = "0x1304BA4", VA = "0x1304BA4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005B10")]
	[Address(RVA = "0x1346A6C", Offset = "0x1346A6C", VA = "0x1346A6C")]
	public XWidget_Selectable_Label()
	{
	}

	[Token(Token = "0x6005B13")]
	[Address(RVA = "0x13042A0", Offset = "0x13042A0", VA = "0x13042A0")]
	public void Show(string first, string second, [Optional][DefaultParameterValue(0)] int index, [Optional] Action<bool, int> selectAction)
	{
	}

	[Token(Token = "0x6005B14")]
	[Address(RVA = "0x13047C0", Offset = "0x13047C0", VA = "0x13047C0")]
	public void SetUseGradationLabel(bool apply, Color topColor, Color bottomColor)
	{
	}

	[Token(Token = "0x6005B15")]
	[Address(RVA = "0x1346A7C", Offset = "0x1346A7C", VA = "0x1346A7C")]
	private void ShowCheckedSprite()
	{
	}

	[Token(Token = "0x6005B16")]
	[Address(RVA = "0x1304580", Offset = "0x1304580", VA = "0x1304580")]
	public void SetSelect(bool isSelect)
	{
	}

	[Token(Token = "0x6005B17")]
	[Address(RVA = "0x1306D34", Offset = "0x1306D34", VA = "0x1306D34")]
	public void ShowEffect(bool isShow)
	{
	}

	[Token(Token = "0x6005B18")]
	[Address(RVA = "0x1346B58", Offset = "0x1346B58", VA = "0x1346B58")]
	public void OnClick_Check()
	{
	}
}
