using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F06")]
public class XListView_Shop : XUIListView
{
	[Token(Token = "0x2000F07")]
	private sealed class _003CGetShopItem_003Ec__AnonStorey226
	{
		[Token(Token = "0x4004FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int shopItemID;

		[Token(Token = "0x4004FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XUIShopItem shopItem;

		[Token(Token = "0x6007023")]
		[Address(RVA = "0x1E162C0", Offset = "0x1E162C0", VA = "0x1E162C0")]
		public _003CGetShopItem_003Ec__AnonStorey226()
		{
		}

		[Token(Token = "0x6007024")]
		[Address(RVA = "0x1E162C8", Offset = "0x1E162C8", VA = "0x1E162C8")]
		internal void _003C_003Em__459(XUIShopItem item)
		{
		}
	}

	[Token(Token = "0x4004FA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int numberOnALine;

	[Token(Token = "0x4004FA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int m_buildItemSettingCount;

	[Token(Token = "0x4004FA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string m_itemPrefabName;

	[Token(Token = "0x4004FA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private List<CSShopItem> m_dataList;

	[Token(Token = "0x4004FA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<int, RotationItemSet> m_rotationSet;

	[Token(Token = "0x4004FA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Action m_onClickAction;

	[Token(Token = "0x4004FA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Action m_onRefresh;

	[Token(Token = "0x4004FA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Action<string, int> m_onPackageDetailShow;

	[Token(Token = "0x4004FA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public XWidget_ListGroupBuilder listGroup;

	[Token(Token = "0x17000E2A")]
	public bool IsEmpty
	{
		[Token(Token = "0x600701A")]
		[Address(RVA = "0x1E15A50", Offset = "0x1E15A50", VA = "0x1E15A50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E2B")]
	protected override int InfoListCount
	{
		[Token(Token = "0x600701B")]
		[Address(RVA = "0x1E15AF8", Offset = "0x1E15AF8", VA = "0x1E15AF8", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E2C")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x600701C")]
		[Address(RVA = "0x1E15BE8", Offset = "0x1E15BE8", VA = "0x1E15BE8", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E2D")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x600701D")]
		[Address(RVA = "0x1E15BF0", Offset = "0x1E15BF0", VA = "0x1E15BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007019")]
	[Address(RVA = "0x1E15978", Offset = "0x1E15978", VA = "0x1E15978")]
	public XListView_Shop()
	{
	}

	[Token(Token = "0x600701E")]
	[Address(RVA = "0x1E15BF8", Offset = "0x1E15BF8", VA = "0x1E15BF8", Slot = "7")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x600701F")]
	[Address(RVA = "0x1E15C88", Offset = "0x1E15C88", VA = "0x1E15C88", Slot = "14")]
	protected override GameObject GetPrefabInfo()
	{
		return null;
	}

	[Token(Token = "0x6007020")]
	[Address(RVA = "0x1E15D98", Offset = "0x1E15D98", VA = "0x1E15D98")]
	public void BuildList(List<CSShopItem> buildInfoSortList, Dictionary<int, RotationItemSet> rotationItemSet, [Optional] Action onClickAction, [Optional] Action onRefresh, [Optional] Action<string, int> onPackageDetailShow)
	{
	}

	[Token(Token = "0x6007021")]
	[Address(RVA = "0x1E15DF0", Offset = "0x1E15DF0", VA = "0x1E15DF0", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6007022")]
	[Address(RVA = "0x1E160C4", Offset = "0x1E160C4", VA = "0x1E160C4")]
	public XUIShopItem GetShopItem(int shopItemID)
	{
		return null;
	}
}
