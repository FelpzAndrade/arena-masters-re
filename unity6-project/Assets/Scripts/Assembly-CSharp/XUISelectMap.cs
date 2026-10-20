using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CD6")]
public class XUISelectMap : MonoBehaviour
{
	[Token(Token = "0x4004178")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x4004179")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_MapItem[] MapItems;

	[Token(Token = "0x400417A")]
	[FieldOffset(Offset = "0x14")]
	private int m_selectedIndex;

	[Token(Token = "0x400417B")]
	[FieldOffset(Offset = "0x18")]
	public Action<int> onChange;

	[Token(Token = "0x6005CCB")]
	[Address(RVA = "0x1921D60", Offset = "0x1921D60", VA = "0x1921D60")]
	public XUISelectMap()
	{
	}

	[Token(Token = "0x6005CCC")]
	[Address(RVA = "0x191043C", Offset = "0x191043C", VA = "0x191043C")]
	public void Build(List<CSSectorInfo> sectorInfos, int selectedMapIndex, Action<int> onChangeCallback)
	{
	}

	[Token(Token = "0x6005CCD")]
	[Address(RVA = "0x19106C0", Offset = "0x19106C0", VA = "0x19106C0")]
	internal void SelectItemByIndex(int selectedMapIndex)
	{
	}
}
