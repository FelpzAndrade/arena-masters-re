using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E78")]
public class XListView_ClanList : XUIListView
{
	[Token(Token = "0x2000E79")]
	public enum ListType
	{
		[Token(Token = "0x4004BEC")]
		Display = 0,
		[Token(Token = "0x4004BED")]
		Join = 1,
		[Token(Token = "0x4004BEE")]
		CancelJoin = 2
	}

	[Token(Token = "0x4004BE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<ClanMetaData> m_dataList;

	[Token(Token = "0x4004BE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private List<ClanMetaData> m_buildDataList;

	[Token(Token = "0x4004BE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Action<ClanMetaData> m_onDetail;

	[Token(Token = "0x4004BE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Action<Netdata_Clan> m_onSwitchClanMain;

	[Token(Token = "0x4004BE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Action m_onRefresh;

	[Token(Token = "0x4004BE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private ListType m_listType;

	[Token(Token = "0x4004BEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Comparison<ClanMetaData> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x17000DDE")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6006C05")]
		[Address(RVA = "0x1E09E90", Offset = "0x1E09E90", VA = "0x1E09E90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000DDF")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6006C06")]
		[Address(RVA = "0x1E09E98", Offset = "0x1E09E98", VA = "0x1E09E98", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000DE0")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6006C07")]
		[Address(RVA = "0x1E09F30", Offset = "0x1E09F30", VA = "0x1E09F30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006C04")]
	[Address(RVA = "0x1E09DA0", Offset = "0x1E09DA0", VA = "0x1E09DA0")]
	public XListView_ClanList()
	{
	}

	[Token(Token = "0x6006C08")]
	[Address(RVA = "0x1E09FA8", Offset = "0x1E09FA8", VA = "0x1E09FA8")]
	public void BuildList(ListType type, List<ClanMetaData> dataList, Action<ClanMetaData> onDetail, Action<Netdata_Clan> onSwitchClanMain, [Optional] Action onRefresh)
	{
	}

	[Token(Token = "0x6006C09")]
	[Address(RVA = "0x1E0A0C4", Offset = "0x1E0A0C4", VA = "0x1E0A0C4")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6006C0A")]
	[Address(RVA = "0x1E0A228", Offset = "0x1E0A228", VA = "0x1E0A228")]
	public void ReBuildListForExceptOne(ClanMetaData data)
	{
	}

	[Token(Token = "0x6006C0B")]
	[Address(RVA = "0x1E0A2FC", Offset = "0x1E0A2FC", VA = "0x1E0A2FC", Slot = "10")]
	public override void BuildList()
	{
	}

	[Token(Token = "0x6006C0C")]
	[Address(RVA = "0x1E0A444", Offset = "0x1E0A444", VA = "0x1E0A444")]
	public ClanMetaData FindClanData(ClanMetaData data)
	{
		return null;
	}

	[Token(Token = "0x6006C0D")]
	[Address(RVA = "0x1E0A44C", Offset = "0x1E0A44C", VA = "0x1E0A44C", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6006C0E")]
	[Address(RVA = "0x1E0A66C", Offset = "0x1E0A66C", VA = "0x1E0A66C")]
	private void RemoveData(ClanMetaData data)
	{
	}

	[Token(Token = "0x6006C0F")]
	[Address(RVA = "0x1E0A73C", Offset = "0x1E0A73C", VA = "0x1E0A73C")]
	public GameObject GetItem(int index)
	{
		return null;
	}

	[Token(Token = "0x6006C10")]
	[Address(RVA = "0x1E0A818", Offset = "0x1E0A818", VA = "0x1E0A818")]
	private static int _003CBuildList_003Em__3D6(ClanMetaData x, ClanMetaData y)
	{
		return default(int);
	}
}
