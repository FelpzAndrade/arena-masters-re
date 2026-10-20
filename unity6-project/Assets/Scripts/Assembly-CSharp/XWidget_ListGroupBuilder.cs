using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F9E")]
public class XWidget_ListGroupBuilder : MonoBehaviour
{
	[Token(Token = "0x40052A9")]
	[FieldOffset(Offset = "0xC")]
	private string m_itemPrefabName;

	[Token(Token = "0x40052AA")]
	[FieldOffset(Offset = "0x10")]
	private int m_numberOnALine;

	[Token(Token = "0x40052AB")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid grid;

	[Token(Token = "0x40052AC")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> itemList;

	[Token(Token = "0x600746B")]
	[Address(RVA = "0x1459E94", Offset = "0x1459E94", VA = "0x1459E94")]
	public XWidget_ListGroupBuilder()
	{
	}

	[Token(Token = "0x600746C")]
	[Address(RVA = "0x1459F40", Offset = "0x1459F40", VA = "0x1459F40")]
	public void Init(string ItemPrefabName, int numberOnALine)
	{
	}

	[Token(Token = "0x600746D")]
	[Address(RVA = "0x145A1C8", Offset = "0x145A1C8", VA = "0x145A1C8")]
	public List<GameObject> GetGridList()
	{
		return null;
	}

	[Token(Token = "0x600746E")]
	public void Action<T>(Action<T> action) where T : MonoBehaviour
	{
	}
}
