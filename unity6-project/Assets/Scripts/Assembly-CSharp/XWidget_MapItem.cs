using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CD8")]
public class XWidget_MapItem : MonoBehaviour
{
	[Token(Token = "0x4004181")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprMap;

	[Token(Token = "0x4004182")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite sprSel;

	[Token(Token = "0x4004183")]
	[FieldOffset(Offset = "0x14")]
	public UIBasicSprite sprLock;

	[Token(Token = "0x4004184")]
	[FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprDisable;

	[Token(Token = "0x4004185")]
	[FieldOffset(Offset = "0x1C")]
	public Action<int> onClick;

	[Token(Token = "0x4004186")]
	[FieldOffset(Offset = "0x20")]
	private int m_Index;

	[Token(Token = "0x6005CD1")]
	[Address(RVA = "0x145DC28", Offset = "0x145DC28", VA = "0x145DC28")]
	public XWidget_MapItem()
	{
	}

	[Token(Token = "0x6005CD2")]
	[Address(RVA = "0x145DC30", Offset = "0x145DC30", VA = "0x145DC30")]
	public void Build(int index, CSSectorInfo sectorInfo, Action<int> acClickCallback)
	{
	}

	[Token(Token = "0x6005CD3")]
	[Address(RVA = "0x145DD34", Offset = "0x145DD34", VA = "0x145DD34")]
	public void SelectedItem(bool isSelected)
	{
	}

	[Token(Token = "0x6005CD4")]
	[Address(RVA = "0x145DD78", Offset = "0x145DD78", VA = "0x145DD78")]
	public void OnClick()
	{
	}
}
