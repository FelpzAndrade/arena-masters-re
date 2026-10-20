using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F7D")]
public class XWidget_DifficultItem : MonoBehaviour
{
	[Token(Token = "0x40051C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblDifficulty;

	[Token(Token = "0x40051C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblUnlockLv;

	[Token(Token = "0x40051C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject goUnlockRoot;

	[Token(Token = "0x40051C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XWidget_Button btnClick;

	[Token(Token = "0x600734C")]
	[Address(RVA = "0x15EFE60", Offset = "0x15EFE60", VA = "0x15EFE60")]
	public XWidget_DifficultItem()
	{
	}

	[Token(Token = "0x600734D")]
	[Address(RVA = "0x15EFE68", Offset = "0x15EFE68", VA = "0x15EFE68")]
	public void Build(CSStageDifficulty difficulty, int unlockLv, [Optional] Action onClick)
	{
	}

	[Token(Token = "0x600734E")]
	[Address(RVA = "0x15F0048", Offset = "0x15F0048", VA = "0x15F0048")]
	public void BuildUnlockText(string localeKey, params object[] param)
	{
	}
}
