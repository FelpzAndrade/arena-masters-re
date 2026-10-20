using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000E94")]
public class XWidget_ClanMain : XUIBaseWidget, IClanPanel
{
	[Token(Token = "0x2000E95")]
	private sealed class _003CRefreshMemberList_003Ec__AnonStorey1FD
	{
		[Token(Token = "0x4004CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal bool moveMainTab;

		[Token(Token = "0x4004CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_ClanMain _003C_003Ef__this;

		[Token(Token = "0x6006CED")]
		[Address(RVA = "0x15DCE48", Offset = "0x15DCE48", VA = "0x15DCE48")]
		public _003CRefreshMemberList_003Ec__AnonStorey1FD()
		{
		}

		[Token(Token = "0x6006CEE")]
		[Address(RVA = "0x15DFEC8", Offset = "0x15DFEC8", VA = "0x15DFEC8")]
		internal void _003C_003Em__3ED(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E96")]
	private sealed class _003CBuildClanBox_003Ec__AnonStorey1FE
	{
		[Token(Token = "0x4004CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal ClanWar clanData;

		[Token(Token = "0x4004CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_ClanMain _003C_003Ef__this;

		[Token(Token = "0x6006CEF")]
		[Address(RVA = "0x15DD380", Offset = "0x15DD380", VA = "0x15DD380")]
		public _003CBuildClanBox_003Ec__AnonStorey1FE()
		{
		}

		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0x15DF59C", Offset = "0x15DF59C", VA = "0x15DF59C")]
		internal void _003C_003Em__3EE()
		{
		}

		[Token(Token = "0x6006CF1")]
		[Address(RVA = "0x15DF5EC", Offset = "0x15DF5EC", VA = "0x15DF5EC")]
		internal void _003C_003Em__3EF()
		{
		}
	}

	[Token(Token = "0x2000E97")]
	private sealed class _003CBuildClanBox_003Ec__AnonStorey1FF
	{
		[Token(Token = "0x4004CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int groupId;

		[Token(Token = "0x4004CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_ClanMain _003C_003Ef__this;

		[Token(Token = "0x6006CF2")]
		[Address(RVA = "0x15DD388", Offset = "0x15DD388", VA = "0x15DD388")]
		public _003CBuildClanBox_003Ec__AnonStorey1FF()
		{
		}

		[Token(Token = "0x6006CF3")]
		[Address(RVA = "0x15DF63C", Offset = "0x15DF63C", VA = "0x15DF63C")]
		internal void _003C_003Em__3F0()
		{
		}
	}

	[Token(Token = "0x2000E98")]
	private sealed class _003CRequestGetClanBoxReward_003Ec__AnonStorey200
	{
		[Token(Token = "0x4004CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int season;

		[Token(Token = "0x4004CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int beforeGold;

		[Token(Token = "0x4004CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_ClanMain _003C_003Ef__this;

		[Token(Token = "0x4004CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Action _003C_003Ef__am_0024cache3;

		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0x15DDB9C", Offset = "0x15DDB9C", VA = "0x15DDB9C")]
		public _003CRequestGetClanBoxReward_003Ec__AnonStorey200()
		{
		}

		[Token(Token = "0x6006CF5")]
		[Address(RVA = "0x15E00F4", Offset = "0x15E00F4", VA = "0x15E00F4")]
		internal void _003C_003Em__3F1(ApiReturnCode result, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x6006CF6")]
		[Address(RVA = "0x15E051C", Offset = "0x15E051C", VA = "0x15E051C")]
		private static void _003C_003Em__3F8()
		{
		}
	}

	[Token(Token = "0x2000E99")]
	private sealed class _003COnClick_ApprovalJoin_003Ec__AnonStorey201
	{
		[Token(Token = "0x4004CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string UserNickName;

		[Token(Token = "0x4004CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal CompletedClanMember clanMember;

		[Token(Token = "0x4004CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_ClanMain _003C_003Ef__this;

		[Token(Token = "0x6006CF7")]
		[Address(RVA = "0x15DE088", Offset = "0x15DE088", VA = "0x15DE088")]
		public _003COnClick_ApprovalJoin_003Ec__AnonStorey201()
		{
		}

		[Token(Token = "0x6006CF8")]
		[Address(RVA = "0x15DF66C", Offset = "0x15DF66C", VA = "0x15DF66C")]
		internal void _003C_003Em__3F4(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E9A")]
	private sealed class _003COnClick_RejectJoin_003Ec__AnonStorey202
	{
		[Token(Token = "0x4004CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string UserNickName;

		[Token(Token = "0x4004CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal CompletedClanMember clanMember;

		[Token(Token = "0x4004CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_ClanMain _003C_003Ef__this;

		[Token(Token = "0x6006CF9")]
		[Address(RVA = "0x15DE30C", Offset = "0x15DE30C", VA = "0x15DE30C")]
		public _003COnClick_RejectJoin_003Ec__AnonStorey202()
		{
		}

		[Token(Token = "0x6006CFA")]
		[Address(RVA = "0x15DFAF0", Offset = "0x15DFAF0", VA = "0x15DFAF0")]
		internal void _003C_003Em__3F5(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004C87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Transform BtnClanWarParentTr;

	[Token(Token = "0x4004C88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject BtnClanWar;

	[Token(Token = "0x4004C89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Transform rankRewardPopupParent;

	[Token(Token = "0x4004C8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XWidget_RankRewardList widgetRankingRewardPopup;

	[Token(Token = "0x4004C8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private XPanel_Clan.ClanTab m_curShowedTab;

	[Token(Token = "0x4004C8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XWiget_GridBuilder m_rankTabBuilder;

	[Token(Token = "0x4004C8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private ClanRankType m_curShowRankingType;

	[Token(Token = "0x4004C8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XWidget_ToggleTab[] m_rankingTypeTabs;

	[Token(Token = "0x4004C8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public XListView_ClanMemberList m_clanMemListView;

	[Token(Token = "0x4004C90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public XListView_ClanMemberList m_joinManageListView;

	[Token(Token = "0x4004C91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public XListView_ClanList m_clanRankingListView;

	[Token(Token = "0x4004C92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public XWidget_ClanBoxOpenButton clanBox;

	[Token(Token = "0x4004C93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private readonly string Path_ClanMemPopup;

	[Token(Token = "0x4004C94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly string Path_ClanMemGradeChangePopup;

	[Token(Token = "0x4004C95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XWidget_ClanMemListPopup _clanMemPopup;

	[Token(Token = "0x4004C96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XWidget_ClanMemGradeChange _clanMemGradeChangePopup;

	[Token(Token = "0x4004C97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public XUIClanOnlineCount OnlineCount;

	[Token(Token = "0x4004C98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string Path_TrophyRewardDetailPopup;

	[Token(Token = "0x4004C99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private XWidget_RewardDetailPopup _rewardBoxDetailPopup;

	[Token(Token = "0x4004C9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string Path_BoxDirection;

	[Token(Token = "0x4004C9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private XWidget_BoxDirection _boxDirection;

	[Token(Token = "0x4004C9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public XWidget_ClanInfo m_leftClanInfo;

	[Token(Token = "0x4004C9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Netdata_Clan m_clanData;

	[Token(Token = "0x4004C9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Action<Netdata_Clan> m_refreshClanMain;

	[Token(Token = "0x4004C9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public CompletedClanMember m_myClanMemberInfo;

	[Token(Token = "0x4004CA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Predicate<CompletedClanMember> _003C_003Ef__am_0024cache19;

	[Token(Token = "0x17000DF0")]
	public XWidget_ClanMemListPopup m_clanMemPopup
	{
		[Token(Token = "0x6006CC8")]
		[Address(RVA = "0x15DB538", Offset = "0x15DB538", VA = "0x15DB538")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF1")]
	public XWidget_ClanMemGradeChange m_clanMemGradeChangePopup
	{
		[Token(Token = "0x6006CC9")]
		[Address(RVA = "0x15DB638", Offset = "0x15DB638", VA = "0x15DB638")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF2")]
	public XWidget_RewardDetailPopup rewardBoxDetailPopup
	{
		[Token(Token = "0x6006CCA")]
		[Address(RVA = "0x15DB738", Offset = "0x15DB738", VA = "0x15DB738")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF3")]
	public XWidget_BoxDirection boxDirection
	{
		[Token(Token = "0x6006CCB")]
		[Address(RVA = "0x15DB854", Offset = "0x15DB854", VA = "0x15DB854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF4")]
	public CompletedClanMember MyClanMemberInfo
	{
		[Token(Token = "0x6006CCC")]
		[Address(RVA = "0x15DBA38", Offset = "0x15DBA38", VA = "0x15DBA38", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF5")]
	public XPanel_Clan.ClanTab FirstSelectTab
	{
		[Token(Token = "0x6006CCD")]
		[Address(RVA = "0x15DBA40", Offset = "0x15DBA40", VA = "0x15DBA40", Slot = "18")]
		get
		{
			return default(XPanel_Clan.ClanTab);
		}
	}

	[Token(Token = "0x6006CC6")]
	[Address(RVA = "0x15DB308", Offset = "0x15DB308", VA = "0x15DB308")]
	public XWidget_ClanMain()
	{
	}

	[Token(Token = "0x6006CC7")]
	[Address(RVA = "0x15DB3D0", Offset = "0x15DB3D0", VA = "0x15DB3D0", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006CCE")]
	[Address(RVA = "0x15DBA48", Offset = "0x15DBA48", VA = "0x15DBA48", Slot = "25")]
	public List<XPanel_Clan.ClanTab> GetBuildTabEnums()
	{
		return null;
	}

	[Token(Token = "0x6006CCF")]
	[Address(RVA = "0x15DBB20", Offset = "0x15DBB20", VA = "0x15DBB20", Slot = "20")]
	public void Build(Netdata_Clan buildData, CompletedClanMember myClanMemberInfo, Action<Netdata_Clan> refreshClanMain)
	{
	}

	[Token(Token = "0x6006CD0")]
	[Address(RVA = "0x15DC880", Offset = "0x15DC880", VA = "0x15DC880")]
	private void Refresh(Netdata_Clan buildData)
	{
	}

	[Token(Token = "0x6006CD1")]
	[Address(RVA = "0x15DCC50", Offset = "0x15DCC50", VA = "0x15DCC50")]
	private void RefreshMemberList(bool moveMainTab = true)
	{
	}

	[Token(Token = "0x6006CD2")]
	[Address(RVA = "0x15DCE50", Offset = "0x15DCE50", VA = "0x15DCE50", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006CD3")]
	[Address(RVA = "0x15DD0D8", Offset = "0x15DD0D8", VA = "0x15DD0D8", Slot = "26")]
	public void Show()
	{
	}

	[Token(Token = "0x6006CD4")]
	[Address(RVA = "0x15DD260", Offset = "0x15DD260", VA = "0x15DD260", Slot = "22")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6006CD5")]
	[Address(RVA = "0x15DD338", Offset = "0x15DD338", VA = "0x15DD338", Slot = "23")]
	public void OnClick_ListRefresh()
	{
	}

	[Token(Token = "0x6006CD6")]
	[Address(RVA = "0x15DD33C", Offset = "0x15DD33C", VA = "0x15DD33C", Slot = "21")]
	public void OnClick_Search()
	{
	}

	[Token(Token = "0x6006CD7")]
	[Address(RVA = "0x15DBD60", Offset = "0x15DBD60", VA = "0x15DBD60")]
	private void BuildLeftInfo()
	{
	}

	[Token(Token = "0x6006CD8")]
	[Address(RVA = "0x15DBDA8", Offset = "0x15DBDA8", VA = "0x15DBDA8")]
	private void BuildClanBox(ClanWar clanData, CompletedClanMember myClanMemberInfo)
	{
	}

	[Token(Token = "0x6006CD9")]
	[Address(RVA = "0x15DD390", Offset = "0x15DD390", VA = "0x15DD390")]
	private void ShowClanBoxShowBox(int groupId)
	{
	}

	[Token(Token = "0x6006CDA")]
	[Address(RVA = "0x15DD8BC", Offset = "0x15DD8BC", VA = "0x15DD8BC")]
	private void RequestGetClanBoxReward(int season)
	{
	}

	[Token(Token = "0x6006CDB")]
	[Address(RVA = "0x15DD340", Offset = "0x15DD340", VA = "0x15DD340")]
	private ClanMemberGrade GetGrade(CompletedClanMember memberData)
	{
		return default(ClanMemberGrade);
	}

	[Token(Token = "0x6006CDC")]
	[Address(RVA = "0x15DC8CC", Offset = "0x15DC8CC", VA = "0x15DC8CC", Slot = "24")]
	public bool OnClick_Tab(XPanel_Clan.ClanTab tabEnum, [Optional] Action tabSelectEndCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x6006CDD")]
	[Address(RVA = "0x15DDBA4", Offset = "0x15DDBA4", VA = "0x15DDBA4")]
	public void OnClick_Detail(ClanMetaData clanData)
	{
	}

	[Token(Token = "0x6006CDE")]
	[Address(RVA = "0x15DDDD4", Offset = "0x15DDDD4", VA = "0x15DDDD4")]
	private void ShowClanMemberPopup(string clanName, List<CompletedClanMember> memList)
	{
	}

	[Token(Token = "0x6006CDF")]
	[Address(RVA = "0x15DD040", Offset = "0x15DD040", VA = "0x15DD040")]
	private void SetActiveListView(bool show)
	{
	}

	[Token(Token = "0x6006CE0")]
	[Address(RVA = "0x15DC5F8", Offset = "0x15DC5F8", VA = "0x15DC5F8")]
	private void ShowClanMemberListView(XListView_ClanMemberList.ListType listType, [Optional] List<CompletedClanMember> forceBuildList)
	{
	}

	[Token(Token = "0x6006CE1")]
	[Address(RVA = "0x15DDE0C", Offset = "0x15DDE0C", VA = "0x15DDE0C")]
	private void OnClick_ApprovalJoin(CompletedClanMember clanMember)
	{
	}

	[Token(Token = "0x6006CE2")]
	[Address(RVA = "0x15DE090", Offset = "0x15DE090", VA = "0x15DE090")]
	private void OnClick_RejectJoin(CompletedClanMember clanMember)
	{
	}

	[Token(Token = "0x6006CE3")]
	[Address(RVA = "0x15DE314", Offset = "0x15DE314", VA = "0x15DE314")]
	public void ShowClanMemGradeChangePopup(int rank, CompletedClanMember clanMemData)
	{
	}

	[Token(Token = "0x6006CE4")]
	[Address(RVA = "0x15DE664", Offset = "0x15DE664", VA = "0x15DE664")]
	private void OnClick_RankTab(ClanRankType type)
	{
	}

	[Token(Token = "0x6006CE5")]
	[Address(RVA = "0x15DEBF0", Offset = "0x15DEBF0", VA = "0x15DEBF0")]
	private void OnClick_ShowRankRewardList()
	{
	}

	[Token(Token = "0x6006CE6")]
	[Address(RVA = "0x15DEEA0", Offset = "0x15DEEA0", VA = "0x15DEEA0")]
	private void OnClick_RecieveReward()
	{
	}

	[Token(Token = "0x6006CE7")]
	[Address(RVA = "0x15DF078", Offset = "0x15DF078", VA = "0x15DF078")]
	public void RemoveMember(CompletedClanMember clanMember)
	{
	}

	[Token(Token = "0x6006CE8")]
	[Address(RVA = "0x15DF158", Offset = "0x15DF158", VA = "0x15DF158")]
	private void _003CBuild_003Em__3EC()
	{
	}

	[Token(Token = "0x6006CE9")]
	[Address(RVA = "0x15DF1F4", Offset = "0x15DF1F4", VA = "0x15DF1F4")]
	private void _003COnClick_Tab_003Em__3F2(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006CEA")]
	[Address(RVA = "0x15DF3F8", Offset = "0x15DF3F8", VA = "0x15DF3F8")]
	private void _003COnClick_Detail_003Em__3F3(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006CEB")]
	[Address(RVA = "0x15DF548", Offset = "0x15DF548", VA = "0x15DF548")]
	private static bool _003CShowClanMemGradeChangePopup_003Em__3F6(CompletedClanMember x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006CEC")]
	[Address(RVA = "0x15DF594", Offset = "0x15DF594", VA = "0x15DF594")]
	private void _003CShowClanMemGradeChangePopup_003Em__3F7()
	{
	}
}
