using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F1C")]
public class XUIEmoticonListView : XUIListView
{
	[Token(Token = "0x4004FF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int numberOnAline;

	[Token(Token = "0x4004FF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int DEFATULT_SHOW_COUNT;

	[Token(Token = "0x4004FFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int usingID;

	[Token(Token = "0x4004FFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int selectedID;

	[Token(Token = "0x4004FFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<CSEmoticonSetInfo> m_list;

	[Token(Token = "0x4004FFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Action<XUIEmoticonItem> m_OnSelect;

	[Token(Token = "0x17000E46")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60070A4")]
		[Address(RVA = "0x1A3EE2C", Offset = "0x1A3EE2C", VA = "0x1A3EE2C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E47")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60070A5")]
		[Address(RVA = "0x1A3EEA4", Offset = "0x1A3EEA4", VA = "0x1A3EEA4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E48")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60070A6")]
		[Address(RVA = "0x1A3EEAC", Offset = "0x1A3EEAC", VA = "0x1A3EEAC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60070A3")]
	[Address(RVA = "0x1A3ED44", Offset = "0x1A3ED44", VA = "0x1A3ED44")]
	public XUIEmoticonListView()
	{
	}

	[Token(Token = "0x60070A7")]
	[Address(RVA = "0x1A3EF54", Offset = "0x1A3EF54", VA = "0x1A3EF54")]
	public void Build(List<CSEmoticonSetInfo> list, int selectedID, int usingID, [Optional] Action<XUIEmoticonItem> onSelect)
	{
	}

	[Token(Token = "0x60070A8")]
	[Address(RVA = "0x1A3F068", Offset = "0x1A3F068", VA = "0x1A3F068", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x60070A9")]
	[Address(RVA = "0x1A3F230", Offset = "0x1A3F230", VA = "0x1A3F230")]
	public XUIEmoticonItem FindEmoticonItem(int titleId)
	{
		return null;
	}
}
