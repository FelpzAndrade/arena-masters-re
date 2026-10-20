using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D40")]
public class XWidget_RadioButton : MonoBehaviour
{
	[Token(Token = "0x4004431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWidget_ToggleButton[] Btns;

	[Token(Token = "0x4004432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public Action<string, byte> RadioClickAction;

	[Token(Token = "0x6006174")]
	[Address(RVA = "0x132FCEC", Offset = "0x132FCEC", VA = "0x132FCEC")]
	public XWidget_RadioButton()
	{
	}

	[Token(Token = "0x6006175")]
	[Address(RVA = "0x131AFCC", Offset = "0x131AFCC", VA = "0x131AFCC")]
	public void Init()
	{
	}

	[Token(Token = "0x6006176")]
	[Address(RVA = "0x131AFD4", Offset = "0x131AFD4", VA = "0x131AFD4")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x6006177")]
	[Address(RVA = "0x131CABC", Offset = "0x131CABC", VA = "0x131CABC")]
	public void AllDeactiveBtns([Optional] Action reset)
	{
	}

	[Token(Token = "0x6006178")]
	[Address(RVA = "0x131CEE0", Offset = "0x131CEE0", VA = "0x131CEE0")]
	public void SelectBtn(byte index, Action active, Action reset)
	{
	}
}
