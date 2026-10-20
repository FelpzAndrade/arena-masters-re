using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CD7")]
public class XUISelectMode : MonoBehaviour
{
	[Token(Token = "0x400417C")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x400417D")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_ModeItem[] ModeItems;

	[Token(Token = "0x400417E")]
	[FieldOffset(Offset = "0x14")]
	private int m_selectedIndex;

	[Token(Token = "0x400417F")]
	[FieldOffset(Offset = "0x18")]
	private bool m_isPrivate;

	[Token(Token = "0x4004180")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int> onChange;

	[Token(Token = "0x6005CCE")]
	[Address(RVA = "0x1921D68", Offset = "0x1921D68", VA = "0x1921D68")]
	public XUISelectMode()
	{
	}

	[Token(Token = "0x6005CCF")]
	[Address(RVA = "0x19100C4", Offset = "0x19100C4", VA = "0x19100C4")]
	public void Build(List<GameModeInstanceInfo> modeInstanceInfos, int selectedModeIndex, bool isPrivate, Action<int> onChangeCallback)
	{
	}

	[Token(Token = "0x6005CD0")]
	[Address(RVA = "0x1910658", Offset = "0x1910658", VA = "0x1910658")]
	internal void SelectItemByIndex(int selectedModeIndex)
	{
	}
}
