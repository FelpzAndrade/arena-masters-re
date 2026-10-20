using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000E14")]
public class XPanel_Ranking : XUIBasePanel
{
	[Token(Token = "0x2000E15")]
	public enum Category
	{
		[Token(Token = "0x40049E7")]
		NONE = 0,
		[Token(Token = "0x40049E8")]
		DUEL = 1,
		[Token(Token = "0x40049E9")]
		TEAM = 2,
		[Token(Token = "0x40049EA")]
		CLAN = 3
	}

	[Token(Token = "0x2000E16")]
	private sealed class _003CBuildStatic_003Ec__AnonStorey1E2
	{
		[Token(Token = "0x40049EB")]
		[FieldOffset(Offset = "0x8")]
		internal Category category;

		[Token(Token = "0x40049EC")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068AA")]
		[Address(RVA = "0x101F448", Offset = "0x101F448", VA = "0x101F448")]
		public _003CBuildStatic_003Ec__AnonStorey1E2()
		{
		}

		[Token(Token = "0x60068AB")]
		[Address(RVA = "0x10214EC", Offset = "0x10214EC", VA = "0x10214EC")]
		internal void _003C_003Em__3B2()
		{
		}

		[Token(Token = "0x60068AC")]
		[Address(RVA = "0x1021520", Offset = "0x1021520", VA = "0x1021520")]
		internal void _003C_003Em__3B3()
		{
		}
	}

	[Token(Token = "0x2000E17")]
	private sealed class _003CBuildStatic_003Ec__AnonStorey1E3
	{
		[Token(Token = "0x40049ED")]
		[FieldOffset(Offset = "0x8")]
		internal RankListViewType type;

		[Token(Token = "0x40049EE")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068AD")]
		[Address(RVA = "0x101F450", Offset = "0x101F450", VA = "0x101F450")]
		public _003CBuildStatic_003Ec__AnonStorey1E3()
		{
		}

		[Token(Token = "0x60068AE")]
		[Address(RVA = "0x1021554", Offset = "0x1021554", VA = "0x1021554")]
		internal void _003C_003Em__3B4()
		{
		}
	}

	[Token(Token = "0x2000E18")]
	private sealed class _003CGetRankingList_003Ec__AnonStorey1E4
	{
		[Token(Token = "0x40049EF")]
		[FieldOffset(Offset = "0x8")]
		internal RankType rankType;

		[Token(Token = "0x40049F0")]
		[FieldOffset(Offset = "0xC")]
		internal RankListViewType viewType;

		[Token(Token = "0x40049F1")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068AF")]
		[Address(RVA = "0x1020250", Offset = "0x1020250", VA = "0x1020250")]
		public _003CGetRankingList_003Ec__AnonStorey1E4()
		{
		}

		[Token(Token = "0x60068B0")]
		[Address(RVA = "0x1021A90", Offset = "0x1021A90", VA = "0x1021A90")]
		internal void _003C_003Em__3B7(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E19")]
	private sealed class _003CGetRanker_003Ec__AnonStorey1E5
	{
		[Token(Token = "0x40049F2")]
		[FieldOffset(Offset = "0x8")]
		internal int ptCount;

		[Token(Token = "0x40049F3")]
		[FieldOffset(Offset = "0xC")]
		internal RankType rankType;

		[Token(Token = "0x40049F4")]
		[FieldOffset(Offset = "0x10")]
		internal RankListViewType viewType;

		[Token(Token = "0x40049F5")]
		[FieldOffset(Offset = "0x14")]
		internal Action Callback;

		[Token(Token = "0x40049F6")]
		[FieldOffset(Offset = "0x18")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068B1")]
		[Address(RVA = "0x10208F8", Offset = "0x10208F8", VA = "0x10208F8")]
		public _003CGetRanker_003Ec__AnonStorey1E5()
		{
		}

		[Token(Token = "0x60068B2")]
		[Address(RVA = "0x1021588", Offset = "0x1021588", VA = "0x1021588")]
		internal void _003C_003Em__3B8(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E1A")]
	private sealed class _003CReqCheckRewardReceive_003Ec__AnonStorey1E6
	{
		[Token(Token = "0x40049F7")]
		[FieldOffset(Offset = "0x8")]
		internal RankType rankType;

		[Token(Token = "0x40049F8")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068B3")]
		[Address(RVA = "0x1020A2C", Offset = "0x1020A2C", VA = "0x1020A2C")]
		public _003CReqCheckRewardReceive_003Ec__AnonStorey1E6()
		{
		}

		[Token(Token = "0x60068B4")]
		[Address(RVA = "0x102258C", Offset = "0x102258C", VA = "0x102258C")]
		internal void _003C_003Em__3B9(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E1B")]
	private sealed class _003COnClickRecieveReward_003Ec__AnonStorey1E7
	{
		[Token(Token = "0x40049F9")]
		[FieldOffset(Offset = "0x8")]
		internal RankType rankType;

		[Token(Token = "0x40049FA")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068B5")]
		[Address(RVA = "0x1021004", Offset = "0x1021004", VA = "0x1021004")]
		public _003COnClickRecieveReward_003Ec__AnonStorey1E7()
		{
		}

		[Token(Token = "0x60068B6")]
		[Address(RVA = "0x1021C68", Offset = "0x1021C68", VA = "0x1021C68")]
		internal void _003C_003Em__3BA(ApiReturnCode result, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x60068B7")]
		[Address(RVA = "0x10220E0", Offset = "0x10220E0", VA = "0x10220E0")]
		internal void _003C_003Em__3BB(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E1C")]
	private sealed class _003CRequestClanRankingList_003Ec__AnonStorey1E8
	{
		[Token(Token = "0x40049FB")]
		[FieldOffset(Offset = "0x8")]
		internal RankListViewType viewType;

		[Token(Token = "0x40049FC")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068B8")]
		[Address(RVA = "0xAB16A8", Offset = "0xAB16A8", VA = "0xAB16A8")]
		public _003CRequestClanRankingList_003Ec__AnonStorey1E8()
		{
		}

		[Token(Token = "0x60068B9")]
		[Address(RVA = "0xAB16B0", Offset = "0xAB16B0", VA = "0xAB16B0")]
		internal void _003C_003Em__3BC(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E1D")]
	private sealed class _003CRequestMyClanRankData_003Ec__AnonStorey1E9
	{
		[Token(Token = "0x40049FD")]
		[FieldOffset(Offset = "0x8")]
		internal RankListViewType viewType;

		[Token(Token = "0x40049FE")]
		[FieldOffset(Offset = "0xC")]
		internal Action Callback;

		[Token(Token = "0x40049FF")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_Ranking _003C_003Ef__this;

		[Token(Token = "0x60068BA")]
		[Address(RVA = "0xAB17EC", Offset = "0xAB17EC", VA = "0xAB17EC")]
		public _003CRequestMyClanRankData_003Ec__AnonStorey1E9()
		{
		}

		[Token(Token = "0x60068BB")]
		[Address(RVA = "0xAB17F4", Offset = "0xAB17F4", VA = "0xAB17F4")]
		internal void _003C_003Em__3BD(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x40049CD")]
	[FieldOffset(Offset = "0x10")]
	private readonly string Path_FirstRankRewardPopup;

	[Token(Token = "0x40049CE")]
	[FieldOffset(Offset = "0x14")]
	private XPanel_FirstRankReward _widgetFirstRankReward;

	[Token(Token = "0x40049CF")]
	[FieldOffset(Offset = "0x18")]
	public XWiget_GridBuilder gridMainTab;

	[Token(Token = "0x40049D0")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<Category, XWidget_ToggleTab> m_modeTabs;

	[Token(Token = "0x40049D1")]
	[FieldOffset(Offset = "0x20")]
	public XWiget_GridBuilder gridRakingListType;

	[Token(Token = "0x40049D2")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_ToggleTab[] rankingListTabs;

	[Token(Token = "0x40049D3")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_RankingInfo myRankingInfo;

	[Token(Token = "0x40049D4")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblRemainTime;

	[Token(Token = "0x40049D5")]
	[FieldOffset(Offset = "0x30")]
	public UIProgressBar prbRemainTime;

	[Token(Token = "0x40049D6")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_Button btnRecieveReward;

	[Token(Token = "0x40049D7")]
	[FieldOffset(Offset = "0x38")]
	public XUIRankingList rankingList;

	[Token(Token = "0x40049D8")]
	[FieldOffset(Offset = "0x3C")]
	public XUIClanRankingList clanRankingList;

	[Token(Token = "0x40049D9")]
	[FieldOffset(Offset = "0x40")]
	private Category m_Category;

	[Token(Token = "0x40049DA")]
	[FieldOffset(Offset = "0x44")]
	private RankListViewType m_rankListViewType;

	[Token(Token = "0x40049DB")]
	[FieldOffset(Offset = "0x48")]
	private Netdata_Ranker m_myRankerData;

	[Token(Token = "0x40049DC")]
	[FieldOffset(Offset = "0x4C")]
	private ClanRankMetaData m_clanRankData;

	[Token(Token = "0x40049DD")]
	[FieldOffset(Offset = "0x50")]
	private int m_totalRanker;

	[Token(Token = "0x40049DE")]
	[FieldOffset(Offset = "0x54")]
	private readonly int PAGE;

	[Token(Token = "0x40049DF")]
	[FieldOffset(Offset = "0x58")]
	private DateTime seasonStartTime;

	[Token(Token = "0x40049E0")]
	[FieldOffset(Offset = "0x68")]
	private DateTime nextSeasonStartTime;

	[Token(Token = "0x40049E1")]
	[FieldOffset(Offset = "0x78")]
	private readonly string empty;

	[Token(Token = "0x40049E2")]
	[FieldOffset(Offset = "0x7C")]
	private bool isReqMyRankingData;

	[Token(Token = "0x40049E3")]
	[FieldOffset(Offset = "0x80")]
	private int clanRankNum;

	[Token(Token = "0x40049E4")]
	[FieldOffset(Offset = "0x84")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x40049E5")]
	[FieldOffset(Offset = "0x88")]
	private int m_lastTotalMin;

	[Token(Token = "0x17000D85")]
	private XPanel_FirstRankReward widgetFirstRankReward
	{
		[Token(Token = "0x6006885")]
		[Address(RVA = "0x101D58C", Offset = "0x101D58C", VA = "0x101D58C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006884")]
	[Address(RVA = "0x101D4B0", Offset = "0x101D4B0", VA = "0x101D4B0")]
	public XPanel_Ranking()
	{
	}

	[Token(Token = "0x6006886")]
	[Address(RVA = "0x101D68C", Offset = "0x101D68C", VA = "0x101D68C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006887")]
	[Address(RVA = "0x101D83C", Offset = "0x101D83C", VA = "0x101D83C")]
	public void Build()
	{
	}

	[Token(Token = "0x6006888")]
	[Address(RVA = "0x101E138", Offset = "0x101E138", VA = "0x101E138")]
	private void Build(RankingList data)
	{
	}

	[Token(Token = "0x6006889")]
	[Address(RVA = "0x101E3E8", Offset = "0x101E3E8", VA = "0x101E3E8")]
	private void Build(ClanRankingList data)
	{
	}

	[Token(Token = "0x600688A")]
	[Address(RVA = "0x101E498", Offset = "0x101E498", VA = "0x101E498")]
	public void Show(RankType rankType)
	{
	}

	[Token(Token = "0x600688B")]
	[Address(RVA = "0x101ED40", Offset = "0x101ED40", VA = "0x101ED40", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600688C")]
	[Address(RVA = "0x101EE24", Offset = "0x101EE24", VA = "0x101EE24")]
	private void CheckHideFriendTab()
	{
	}

	[Token(Token = "0x600688D")]
	[Address(RVA = "0x101EEC4", Offset = "0x101EEC4", VA = "0x101EEC4")]
	private void SelectMainTab(Category category, bool clickClanTap = false)
	{
	}

	[Token(Token = "0x600688E")]
	[Address(RVA = "0x101E62C", Offset = "0x101E62C", VA = "0x101E62C")]
	private Category GetCategoryFromRankType(RankType rankType)
	{
		return default(Category);
	}

	[Token(Token = "0x600688F")]
	[Address(RVA = "0x101F2C8", Offset = "0x101F2C8", VA = "0x101F2C8")]
	private RankType GetRankTypeFromCategory(Category category)
	{
		return default(RankType);
	}

	[Token(Token = "0x6006890")]
	[Address(RVA = "0x101F2F4", Offset = "0x101F2F4", VA = "0x101F2F4")]
	private MatchType GetMatchTypeFromCategory(Category category)
	{
		return default(MatchType);
	}

	[Token(Token = "0x6006891")]
	[Address(RVA = "0x101F320", Offset = "0x101F320", VA = "0x101F320")]
	public string GetCategoryTypeString(Category category)
	{
		return null;
	}

	[Token(Token = "0x6006892")]
	[Address(RVA = "0x101D8FC", Offset = "0x101D8FC", VA = "0x101D8FC")]
	private void BuildStatic()
	{
	}

	[Token(Token = "0x6006893")]
	[Address(RVA = "0x101E644", Offset = "0x101E644", VA = "0x101E644")]
	private void SelectShowRankingList(RankListViewType viewType, bool clickSameMainTab = false)
	{
	}

	[Token(Token = "0x6006894")]
	[Address(RVA = "0x101F6C0", Offset = "0x101F6C0", VA = "0x101F6C0")]
	private void TabSelect(RankListViewType viewType)
	{
	}

	[Token(Token = "0x6006895")]
	[Address(RVA = "0x101D8B0", Offset = "0x101D8B0", VA = "0x101D8B0")]
	private void InitEmpty()
	{
	}

	[Token(Token = "0x6006896")]
	[Address(RVA = "0x101FDC0", Offset = "0x101FDC0", VA = "0x101FDC0")]
	private void GetRankingList(RankType rankType, RankListViewType viewType)
	{
	}

	[Token(Token = "0x6006897")]
	[Address(RVA = "0x1020258", Offset = "0x1020258", VA = "0x1020258")]
	private void RequestRankingList(Category category, RankListViewType viewType)
	{
	}

	[Token(Token = "0x6006898")]
	[Address(RVA = "0x1020310", Offset = "0x1020310", VA = "0x1020310")]
	private void GetRanker(RankType rankType, RankListViewType viewType, int ptCount, Action Callback)
	{
	}

	[Token(Token = "0x6006899")]
	[Address(RVA = "0x101F760", Offset = "0x101F760", VA = "0x101F760")]
	private void RequestMyRankData(Category category, RankListViewType ViewType, Action Callback)
	{
	}

	[Token(Token = "0x600689A")]
	[Address(RVA = "0x1020900", Offset = "0x1020900", VA = "0x1020900")]
	private void ReserveUpdate()
	{
	}

	[Token(Token = "0x600689B")]
	[Address(RVA = "0x102090C", Offset = "0x102090C", VA = "0x102090C")]
	private void Update()
	{
	}

	[Token(Token = "0x600689C")]
	[Address(RVA = "0x101E3BC", Offset = "0x101E3BC", VA = "0x101E3BC")]
	private void BuildRankingList(RankingList rankingData)
	{
	}

	[Token(Token = "0x600689D")]
	[Address(RVA = "0x101E464", Offset = "0x101E464", VA = "0x101E464")]
	private void BuildRankingList(ClanRankingList rankingData)
	{
	}

	[Token(Token = "0x600689E")]
	[Address(RVA = "0x101E934", Offset = "0x101E934", VA = "0x101E934")]
	private void ReqCheckRewardReceive()
	{
	}

	[Token(Token = "0x600689F")]
	[Address(RVA = "0x1020A34", Offset = "0x1020A34", VA = "0x1020A34")]
	private XRankingDataCache.RankReceiveType ConvertIsReceivedReward(bool isReceived)
	{
		return default(XRankingDataCache.RankReceiveType);
	}

	[Token(Token = "0x60068A0")]
	[Address(RVA = "0x101E91C", Offset = "0x101E91C", VA = "0x101E91C")]
	private bool IsRankMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x60068A1")]
	[Address(RVA = "0x1020A44", Offset = "0x1020A44", VA = "0x1020A44")]
	public void OnClickShowRewardsList()
	{
	}

	[Token(Token = "0x60068A2")]
	[Address(RVA = "0x1020BFC", Offset = "0x1020BFC", VA = "0x1020BFC")]
	public void OnClickRecieveReward()
	{
	}

	[Token(Token = "0x60068A3")]
	[Address(RVA = "0x102100C", Offset = "0x102100C", VA = "0x102100C")]
	public void OnClick_FirstRankReward()
	{
	}

	[Token(Token = "0x60068A4")]
	[Address(RVA = "0x1021040", Offset = "0x1021040", VA = "0x1021040")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x60068A5")]
	[Address(RVA = "0x101F458", Offset = "0x101F458", VA = "0x101F458")]
	private void SetRankingTutorilObject()
	{
	}

	[Token(Token = "0x60068A6")]
	[Address(RVA = "0x1021118", Offset = "0x1021118", VA = "0x1021118")]
	private void RequestClanRankingList(Category category, RankListViewType viewType)
	{
	}

	[Token(Token = "0x60068A7")]
	[Address(RVA = "0x101F8F4", Offset = "0x101F8F4", VA = "0x101F8F4")]
	private void RequestMyClanRankData(Category category, RankListViewType viewType, Action Callback)
	{
	}

	[Token(Token = "0x60068A8")]
	[Address(RVA = "0x10214A0", Offset = "0x10214A0", VA = "0x10214A0")]
	private void _003CSelectShowRankingList_003Em__3B5()
	{
	}

	[Token(Token = "0x60068A9")]
	[Address(RVA = "0x10214C8", Offset = "0x10214C8", VA = "0x10214C8")]
	private void _003CSelectShowRankingList_003Em__3B6()
	{
	}
}
