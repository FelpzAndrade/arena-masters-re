using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001005")]
public class XWidget_TitleItemGroup : MonoBehaviour
{
	[Token(Token = "0x400558E")]
	[FieldOffset(Offset = "0xC")]
	public int groupNumber;

	[Token(Token = "0x400558F")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x4005590")]
	[FieldOffset(Offset = "0x14")]
	public List<XUITitleItem> items;

	[Token(Token = "0x4005591")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Title m_title;

	[Token(Token = "0x17000EEB")]
	private string m_titleItemPrefabPath
	{
		[Token(Token = "0x6007780")]
		[Address(RVA = "0x1B25184", Offset = "0x1B25184", VA = "0x1B25184")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600777F")]
	[Address(RVA = "0x1B250D0", Offset = "0x1B250D0", VA = "0x1B250D0")]
	public XWidget_TitleItemGroup()
	{
	}

	[Token(Token = "0x6007781")]
	[Address(RVA = "0x1B251FC", Offset = "0x1B251FC", VA = "0x1B251FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007782")]
	[Address(RVA = "0x1B25518", Offset = "0x1B25518", VA = "0x1B25518")]
	public void Build(List<TitleInfo> infoList, Action<XUITitleItem> onSelect)
	{
	}
}
