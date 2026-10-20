using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FD3")]
public class XWidget_QuickMatchMap : MonoBehaviour
{
	[Token(Token = "0x4005428")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblMapName;

	[Token(Token = "0x4005429")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprMap;

	[Token(Token = "0x400542A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject activeDisableObject;

	[Token(Token = "0x400542B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject lockDisableObject;

	[Token(Token = "0x400542C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblRequireLevel;

	[Token(Token = "0x400542D")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle uiToggle;

	[Token(Token = "0x400542E")]
	[FieldOffset(Offset = "0x24")]
	private Action<List<int>, bool> clickAction;

	[Token(Token = "0x400542F")]
	[FieldOffset(Offset = "0x28")]
	private List<int> m_sectorID_List;

	[Token(Token = "0x4005430")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_isSelect;

	[Token(Token = "0x4005431")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_isLock;

	[Token(Token = "0x60075F0")]
	[Address(RVA = "0x132BA38", Offset = "0x132BA38", VA = "0x132BA38")]
	public XWidget_QuickMatchMap()
	{
	}

	[Token(Token = "0x60075F1")]
	[Address(RVA = "0x132BA40", Offset = "0x132BA40", VA = "0x132BA40")]
	public void Build(QuickMatchThemeInfo quickMatchSectorInfo, Action<List<int>, bool> action)
	{
	}

	[Token(Token = "0x60075F2")]
	[Address(RVA = "0x132BD1C", Offset = "0x132BD1C", VA = "0x132BD1C")]
	public void OnClickItem()
	{
	}
}
