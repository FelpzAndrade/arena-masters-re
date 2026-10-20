using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FDB")]
public class XWidget_RelicItemGroup : MonoBehaviour
{
	[Token(Token = "0x4005496")]
	[FieldOffset(Offset = "0xC")]
	private int groupNumber;

	[Token(Token = "0x4005497")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x4005498")]
	[FieldOffset(Offset = "0x14")]
	public List<XUIRelicItem> items;

	[Token(Token = "0x4005499")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Relic m_relic;

	[Token(Token = "0x17000EE2")]
	private string m_relicItemPrefabPath
	{
		[Token(Token = "0x6007651")]
		[Address(RVA = "0x1341D54", Offset = "0x1341D54", VA = "0x1341D54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007650")]
	[Address(RVA = "0x1341CA0", Offset = "0x1341CA0", VA = "0x1341CA0")]
	public XWidget_RelicItemGroup()
	{
	}

	[Token(Token = "0x6007652")]
	[Address(RVA = "0x1341DCC", Offset = "0x1341DCC", VA = "0x1341DCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007653")]
	[Address(RVA = "0x13420E8", Offset = "0x13420E8", VA = "0x13420E8")]
	public void Build(List<RelicInfo> infoList, Action<RelicInfo, bool> action, Action<XUIRelicItem> m_selObj, RelicInfo initItem)
	{
	}
}
