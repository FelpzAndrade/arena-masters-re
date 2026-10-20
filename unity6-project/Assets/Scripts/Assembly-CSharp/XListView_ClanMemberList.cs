using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E7A")]
public class XListView_ClanMemberList : XUIListView
{
	[Token(Token = "0x2000E7B")]
	private class ClanMemListViewData
	{
		[Token(Token = "0x4004BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private CompletedClanMember Data__BackingField;

		[Token(Token = "0x4004BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int Rank__BackingField;

		[Token(Token = "0x4004BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RankListViewType ViewType__BackingField;

		[Token(Token = "0x17000DE4")]
		public CompletedClanMember Data
		{
			[Token(Token = "0x6006C23")]
			[Address(RVA = "0x1E0B98C", Offset = "0x1E0B98C", VA = "0x1E0B98C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C24")]
			[Address(RVA = "0x1E0C284", Offset = "0x1E0C284", VA = "0x1E0C284")]
			private set
			{
			}
		}

		[Token(Token = "0x17000DE5")]
		public int Rank
		{
			[Token(Token = "0x6006C25")]
			[Address(RVA = "0x1E0B984", Offset = "0x1E0B984", VA = "0x1E0B984")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6006C26")]
			[Address(RVA = "0x1E0C27C", Offset = "0x1E0C27C", VA = "0x1E0C27C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000DE6")]
		public RankListViewType ViewType
		{
			[Token(Token = "0x6006C27")]
			[Address(RVA = "0x1E0B994", Offset = "0x1E0B994", VA = "0x1E0B994")]
			get
			{
				return default(RankListViewType);
			}
			[Token(Token = "0x6006C28")]
			[Address(RVA = "0x1E0C28C", Offset = "0x1E0C28C", VA = "0x1E0C28C")]
			private set
			{
			}
		}

		[Token(Token = "0x6006C22")]
		[Address(RVA = "0x1E0B5B0", Offset = "0x1E0B5B0", VA = "0x1E0B5B0")]
		public ClanMemListViewData(CompletedClanMember data, int rank, RankListViewType viewType = RankListViewType.ThisWeek)
		{
		}
	}

	[Token(Token = "0x2000E7C")]
	public enum SortingRule
	{
		[Token(Token = "0x4004C01")]
		None = 0,
		[Token(Token = "0x4004C02")]
		Rank = 1,
		[Token(Token = "0x4004C03")]
		LastConnectTime = 2,
		[Token(Token = "0x4004C04")]
		Level = 3
	}

	[Token(Token = "0x2000E7D")]
	public enum ListType
	{
		[Token(Token = "0x4004C06")]
		OtherClanMemberList = 0,
		[Token(Token = "0x4004C07")]
		ClanMemberList = 1,
		[Token(Token = "0x4004C08")]
		JoinManageList = 2
	}

	[Token(Token = "0x2000E7E")]
	private abstract class ClanMemberComparer : IComparer<ClanMemListViewData>
	{
		protected ClanMemberComparer()
		{
		}

		[Token(Token = "0x4004C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool m_isAscending__BackingField;

		[Token(Token = "0x17000DE7")]
		public bool m_isAscending
		{
			[Token(Token = "0x6006C2A")]
			[Address(RVA = "0x1E0BD50", Offset = "0x1E0BD50", VA = "0x1E0BD50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006C2B")]
			[Address(RVA = "0x1E0BD48", Offset = "0x1E0BD48", VA = "0x1E0BD48")]
			private set
			{
			}
		}

		[Token(Token = "0x6006C29")]
		[Address(RVA = "0x1E0BD28", Offset = "0x1E0BD28", VA = "0x1E0BD28")]
		public ClanMemberComparer(bool isAscending)
		{
		}

		[Token(Token = "0x6006C2C")]
		[Address(RVA = "0x1E0BD58", Offset = "0x1E0BD58", VA = "0x1E0BD58", Slot = "4")]
		public int Compare(ClanMemListViewData c1, ClanMemListViewData c2)
		{
			return default(int);
		}

		[Token(Token = "0x6006C2D")]
		protected abstract int CompareMethod(ClanMemListViewData c1, ClanMemListViewData c2);
	}

	[Token(Token = "0x2000E7F")]
	private class ClanMemClanWarPointComparer : ClanMemberComparer
	{
		[Token(Token = "0x6006C2E")]
		[Address(RVA = "0x1E0BB0C", Offset = "0x1E0BB0C", VA = "0x1E0BB0C")]
		public ClanMemClanWarPointComparer(bool isAcending)
		{
		}

		[Token(Token = "0x6006C2F")]
		[Address(RVA = "0x1E0BDB8", Offset = "0x1E0BDB8", VA = "0x1E0BDB8", Slot = "5")]
		protected override int CompareMethod(ClanMemListViewData c1, ClanMemListViewData c2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000E80")]
	private class ClanMemLastConnectTimeComparer : ClanMemberComparer
	{
		[Token(Token = "0x6006C30")]
		[Address(RVA = "0x1E0BB2C", Offset = "0x1E0BB2C", VA = "0x1E0BB2C")]
		public ClanMemLastConnectTimeComparer(bool isAcending)
		{
		}

		[Token(Token = "0x6006C31")]
		[Address(RVA = "0x1E0BEE4", Offset = "0x1E0BEE4", VA = "0x1E0BEE4", Slot = "5")]
		protected override int CompareMethod(ClanMemListViewData c1, ClanMemListViewData c2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000E81")]
	private class ClanMemLevelComparer : ClanMemberComparer
	{
		[Token(Token = "0x6006C32")]
		[Address(RVA = "0x1E0BB4C", Offset = "0x1E0BB4C", VA = "0x1E0BB4C")]
		public ClanMemLevelComparer(bool isAcending)
		{
		}

		[Token(Token = "0x6006C33")]
		[Address(RVA = "0x1E0C1E8", Offset = "0x1E0C1E8", VA = "0x1E0C1E8", Slot = "5")]
		protected override int CompareMethod(ClanMemListViewData c1, ClanMemListViewData c2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000E82")]
	private sealed class _003CBuildData_003Ec__AnonStorey1F5
	{
		[Token(Token = "0x4004C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int currentSeaonNum;

		[Token(Token = "0x4004C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal RankListViewType viewType;

		[Token(Token = "0x6006C34")]
		[Address(RVA = "0x1E0B490", Offset = "0x1E0B490", VA = "0x1E0B490")]
		public _003CBuildData_003Ec__AnonStorey1F5()
		{
		}

		[Token(Token = "0x6006C35")]
		[Address(RVA = "0x1E0BBCC", Offset = "0x1E0BBCC", VA = "0x1E0BBCC")]
		internal int _003C_003Em__3DA(CompletedClanMember x, CompletedClanMember y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000E83")]
	private sealed class _003CRemoveData_003Ec__AnonStorey1F6
	{
		[Token(Token = "0x4004C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal CompletedClanMember data;

		[Token(Token = "0x6006C36")]
		[Address(RVA = "0x1E0BB04", Offset = "0x1E0BB04", VA = "0x1E0BB04")]
		public _003CRemoveData_003Ec__AnonStorey1F6()
		{
		}

		[Token(Token = "0x6006C37")]
		[Address(RVA = "0x1E0BC18", Offset = "0x1E0BC18", VA = "0x1E0BC18")]
		internal bool _003C_003Em__3DB(ClanMemListViewData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004BEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public XWidget_SortButton btnSortRank;

	[Token(Token = "0x4004BF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public XWidget_SortButton btnSortLastConnectTime;

	[Token(Token = "0x4004BF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public XWidget_SortButton btnSortLevel;

	[Token(Token = "0x4004BF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public SortingRule sortRule;

	[Token(Token = "0x4004BF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool isRankAscending;

	[Token(Token = "0x4004BF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool isLastConnectTimeAscending;

	[Token(Token = "0x4004BF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private ClanMemberComparer m_compare;

	[Token(Token = "0x4004BF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<ClanMemListViewData> m_dataList;

	[Token(Token = "0x4004BF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private ClanMemberGrade m_MyGrade;

	[Token(Token = "0x4004BF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public XWidget_ClanMemInfoItem m_clanInfoOrigin;

	[Token(Token = "0x4004BF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private ListType m_listType;

	[Token(Token = "0x4004BFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Action<int, CompletedClanMember> m_gradeChangeAction;

	[Token(Token = "0x4004BFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Action<CompletedClanMember> m_manageApprovalAction;

	[Token(Token = "0x4004BFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Action<CompletedClanMember> m_manageRejectAction;

	[Token(Token = "0x17000DE1")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6006C12")]
		[Address(RVA = "0x1E0A9D4", Offset = "0x1E0A9D4", VA = "0x1E0A9D4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000DE2")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6006C13")]
		[Address(RVA = "0x1E0A9DC", Offset = "0x1E0A9DC", VA = "0x1E0A9DC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000DE3")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6006C14")]
		[Address(RVA = "0x1E0AA74", Offset = "0x1E0AA74", VA = "0x1E0AA74", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006C11")]
	[Address(RVA = "0x1E0A8FC", Offset = "0x1E0A8FC", VA = "0x1E0A8FC")]
	public XListView_ClanMemberList()
	{
	}

	[Token(Token = "0x6006C15")]
	[Address(RVA = "0x1E0AB24", Offset = "0x1E0AB24", VA = "0x1E0AB24", Slot = "7")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6006C16")]
	[Address(RVA = "0x1E0AB9C", Offset = "0x1E0AB9C", VA = "0x1E0AB9C", Slot = "14")]
	protected override GameObject GetPrefabInfo()
	{
		return null;
	}

	[Token(Token = "0x6006C17")]
	[Address(RVA = "0x1E0ABF4", Offset = "0x1E0ABF4", VA = "0x1E0ABF4")]
	private void BuildSortButton(ListType listType)
	{
	}

	[Token(Token = "0x6006C18")]
	[Address(RVA = "0x1E0AF48", Offset = "0x1E0AF48", VA = "0x1E0AF48")]
	public void BuildList(ListType listType, List<CompletedClanMember> dataList, [Optional] RankListViewType viewType, [Optional] ClanMemberGrade myGrade, [Optional] Action<int, CompletedClanMember> gradeChangeAction, [Optional] Action<CompletedClanMember> manageApprovalAction, [Optional] Action<CompletedClanMember> manageRejectAction)
	{
	}

	[Token(Token = "0x6006C19")]
	[Address(RVA = "0x1E0B064", Offset = "0x1E0B064", VA = "0x1E0B064")]
	private void BuildData(List<CompletedClanMember> dataList, RankListViewType viewType)
	{
	}

	[Token(Token = "0x6006C1A")]
	[Address(RVA = "0x1E0B3D4", Offset = "0x1E0B3D4", VA = "0x1E0B3D4")]
	private void OnClick_SortButton(SortingRule sortRule, bool isAsending, XWidget_SortButton clickedSortBtn)
	{
	}

	[Token(Token = "0x6006C1B")]
	[Address(RVA = "0x1E0B6C4", Offset = "0x1E0B6C4", VA = "0x1E0B6C4")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6006C1C")]
	[Address(RVA = "0x1E0B810", Offset = "0x1E0B810", VA = "0x1E0B810", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6006C1D")]
	[Address(RVA = "0x1E0B99C", Offset = "0x1E0B99C", VA = "0x1E0B99C")]
	public void RemoveData(CompletedClanMember data)
	{
	}

	[Token(Token = "0x6006C1E")]
	[Address(RVA = "0x1E0B5E0", Offset = "0x1E0B5E0", VA = "0x1E0B5E0")]
	private ClanMemberComparer GetComparer(SortingRule sortRule, bool isAsending)
	{
		return null;
	}

	[Token(Token = "0x6006C1F")]
	[Address(RVA = "0x1E0BB6C", Offset = "0x1E0BB6C", VA = "0x1E0BB6C")]
	private void _003CBuildSortButton_003Em__3D7(bool isAcending)
	{
	}

	[Token(Token = "0x6006C20")]
	[Address(RVA = "0x1E0BB8C", Offset = "0x1E0BB8C", VA = "0x1E0BB8C")]
	private void _003CBuildSortButton_003Em__3D8(bool isAcending)
	{
	}

	[Token(Token = "0x6006C21")]
	[Address(RVA = "0x1E0BBAC", Offset = "0x1E0BBAC", VA = "0x1E0BBAC")]
	private void _003CBuildSortButton_003Em__3D9(bool isAcending)
	{
	}
}
