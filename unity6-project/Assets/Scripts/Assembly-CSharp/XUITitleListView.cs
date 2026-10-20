using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F62")]
public class XUITitleListView : XUIListView
{
	[Token(Token = "0x40050D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int numberOnAline;

	[Token(Token = "0x40050D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int DEFATULT_SHOW_COUNT;

	[Token(Token = "0x40050D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<TitleInfo> m_list;

	[Token(Token = "0x40050D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Action<XUITitleItem> m_OnSelect;

	[Token(Token = "0x17000E98")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007252")]
		[Address(RVA = "0x1938AAC", Offset = "0x1938AAC", VA = "0x1938AAC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E99")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007253")]
		[Address(RVA = "0x1938B24", Offset = "0x1938B24", VA = "0x1938B24", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E9A")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007254")]
		[Address(RVA = "0x1938B2C", Offset = "0x1938B2C", VA = "0x1938B2C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007251")]
	[Address(RVA = "0x19389C4", Offset = "0x19389C4", VA = "0x19389C4")]
	public XUITitleListView()
	{
	}

	[Token(Token = "0x6007255")]
	[Address(RVA = "0x1938BD4", Offset = "0x1938BD4", VA = "0x1938BD4")]
	public void Build(List<TitleInfo> list, [Optional] Action<XUITitleItem> onSelect)
	{
	}

	[Token(Token = "0x6007256")]
	[Address(RVA = "0x1938CD8", Offset = "0x1938CD8", VA = "0x1938CD8", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6007257")]
	[Address(RVA = "0x1938E94", Offset = "0x1938E94", VA = "0x1938E94")]
	public XUITitleItem FindTitleItem(int titleId)
	{
		return null;
	}
}
