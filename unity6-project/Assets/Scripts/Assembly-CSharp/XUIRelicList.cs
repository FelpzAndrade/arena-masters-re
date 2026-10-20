using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F55")]
public class XUIRelicList : XUIListView
{
	[Token(Token = "0x4005074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int numberOnAline;

	[Token(Token = "0x4005075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private List<RelicInfo> m_list;

	[Token(Token = "0x4005076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Action<RelicInfo, bool> m_action;

	[Token(Token = "0x4005077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Action<XUIRelicItem> m_selObj;

	[Token(Token = "0x4005078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public XWidget_Relic widgetRelic;

	[Token(Token = "0x4005079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private RelicInfo m_initInfo;

	[Token(Token = "0x17000E8A")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60071D8")]
		[Address(RVA = "0x1918300", Offset = "0x1918300", VA = "0x1918300", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E8B")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60071D9")]
		[Address(RVA = "0x1918378", Offset = "0x1918378", VA = "0x1918378", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E8C")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60071DA")]
		[Address(RVA = "0x1918380", Offset = "0x1918380", VA = "0x1918380", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60071D7")]
	[Address(RVA = "0x1918220", Offset = "0x1918220", VA = "0x1918220")]
	public XUIRelicList()
	{
	}

	[Token(Token = "0x60071DB")]
	[Address(RVA = "0x1918428", Offset = "0x1918428", VA = "0x1918428")]
	public void Build(List<RelicInfo> list, Action<RelicInfo, bool> action, RelicInfo InitInfo, [Optional] Action<XUIRelicItem> obj)
	{
	}

	[Token(Token = "0x60071DC")]
	[Address(RVA = "0x1918444", Offset = "0x1918444", VA = "0x1918444", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x60071DD")]
	[Address(RVA = "0x191860C", Offset = "0x191860C", VA = "0x191860C")]
	public XUIRelicItem GetRelicUIItem(int relicId)
	{
		return null;
	}
}
