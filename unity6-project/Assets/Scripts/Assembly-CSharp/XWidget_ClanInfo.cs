using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000E8B")]
public class XWidget_ClanInfo : XUIBaseWidget
{
	[Token(Token = "0x2000E8C")]
	private sealed class _003CShowTerminateInputBox_003Ec__AnonStorey1F8
	{
		[Token(Token = "0x4004C52")]
		[FieldOffset(Offset = "0x8")]
		internal string strTerminateInput;

		[Token(Token = "0x4004C53")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_ClanInfo _003C_003Ef__this;

		[Token(Token = "0x6006C92")]
		[Address(RVA = "0x15D4A20", Offset = "0x15D4A20", VA = "0x15D4A20")]
		public _003CShowTerminateInputBox_003Ec__AnonStorey1F8()
		{
		}

		[Token(Token = "0x6006C93")]
		[Address(RVA = "0x15D53F8", Offset = "0x15D53F8", VA = "0x15D53F8")]
		internal void _003C_003Em__3E4(string strInputText)
		{
		}
	}

	[Token(Token = "0x4004C3F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goBtnsMain;

	[Token(Token = "0x4004C40")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goBtnsManage;

	[Token(Token = "0x4004C41")]
	[FieldOffset(Offset = "0x24")]
	public Transform transformClanMark;

	[Token(Token = "0x4004C42")]
	[FieldOffset(Offset = "0x28")]
	private XWidget_ClanMark clanMark;

	[Token(Token = "0x4004C43")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblClanLvAndName;

	[Token(Token = "0x4004C44")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblClanRank;

	[Token(Token = "0x4004C45")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblClanMasterName;

	[Token(Token = "0x4004C46")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblClanMember;

	[Token(Token = "0x4004C47")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblClanNotice;

	[Token(Token = "0x4004C48")]
	[FieldOffset(Offset = "0x40")]
	public XWidget_ProgressBarWithTable progressClanLv;

	[Token(Token = "0x4004C49")]
	[FieldOffset(Offset = "0x44")]
	public Color ClanLevelColor;

	[Token(Token = "0x4004C4A")]
	[FieldOffset(Offset = "0x54")]
	private readonly string Path_ClanSetupPopup;

	[Token(Token = "0x4004C4B")]
	[FieldOffset(Offset = "0x58")]
	private XWidget_ClanSetup _clanSetupPopup;

	[Token(Token = "0x4004C4C")]
	[FieldOffset(Offset = "0x5C")]
	private ClanMemberGrade m_myGrade;

	[Token(Token = "0x4004C4D")]
	[FieldOffset(Offset = "0x60")]
	private Netdata_Clan m_clanData;

	[Token(Token = "0x4004C4E")]
	[FieldOffset(Offset = "0x64")]
	private Action m_leaveAction;

	[Token(Token = "0x4004C4F")]
	[FieldOffset(Offset = "0x68")]
	private Action m_rankRewardShowAction;

	[Token(Token = "0x4004C50")]
	[FieldOffset(Offset = "0x6C")]
	private Action m_rankRewardRecieveAction;

	[Token(Token = "0x4004C51")]
	[FieldOffset(Offset = "0x70")]
	private Action<Netdata_Clan> m_refreshMainData;

	[Token(Token = "0x17000DE9")]
	public XWidget_ClanSetup m_clanSetupPopup
	{
		[Token(Token = "0x6006C7C")]
		[Address(RVA = "0x15D2CE4", Offset = "0x15D2CE4", VA = "0x15D2CE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006C7B")]
	[Address(RVA = "0x15D2C58", Offset = "0x15D2C58", VA = "0x15D2C58")]
	public XWidget_ClanInfo()
	{
	}

	[Token(Token = "0x6006C7D")]
	[Address(RVA = "0x15D2E00", Offset = "0x15D2E00", VA = "0x15D2E00")]
	public void RegistLeaveCallBack(Action leaveAction)
	{
	}

	[Token(Token = "0x6006C7E")]
	[Address(RVA = "0x15D2E08", Offset = "0x15D2E08", VA = "0x15D2E08")]
	public void RegistRankRewardListShowCallBack(Action rankShowAction)
	{
	}

	[Token(Token = "0x6006C7F")]
	[Address(RVA = "0x15D2E10", Offset = "0x15D2E10", VA = "0x15D2E10")]
	public void RegistRankRewardRecieveCallBack(Action rankRecieveAction)
	{
	}

	[Token(Token = "0x6006C80")]
	[Address(RVA = "0x15D2E18", Offset = "0x15D2E18", VA = "0x15D2E18")]
	public void RegistRefreshMainDataCallBack(Action<Netdata_Clan> refreshDataAction)
	{
	}

	[Token(Token = "0x6006C81")]
	[Address(RVA = "0x15D2E20", Offset = "0x15D2E20", VA = "0x15D2E20")]
	private void BuildCommon(Netdata_Clan clanData)
	{
	}

	[Token(Token = "0x6006C82")]
	[Address(RVA = "0x15D36B0", Offset = "0x15D36B0", VA = "0x15D36B0")]
	public void Build(Netdata_Clan clanData, XPanel_Clan.ClanTab curTab, ClanMemberGrade myGrade)
	{
	}

	[Token(Token = "0x6006C83")]
	[Address(RVA = "0x15D370C", Offset = "0x15D370C", VA = "0x15D370C")]
	private void BuildButton(XPanel_Clan.ClanTab curTab)
	{
	}

	[Token(Token = "0x6006C84")]
	[Address(RVA = "0x15D376C", Offset = "0x15D376C", VA = "0x15D376C")]
	public void OnClick_ShowRankRewardListPopup()
	{
	}

	[Token(Token = "0x6006C85")]
	[Address(RVA = "0x15D3780", Offset = "0x15D3780", VA = "0x15D3780")]
	public void OnClick_ShowRankRewardRecievePopup()
	{
	}

	[Token(Token = "0x6006C86")]
	[Address(RVA = "0x15D3794", Offset = "0x15D3794", VA = "0x15D3794")]
	public void OnClick_ClanLeave()
	{
	}

	[Token(Token = "0x6006C87")]
	[Address(RVA = "0x15D3BBC", Offset = "0x15D3BBC", VA = "0x15D3BBC")]
	public void OnClick_ClanBoxOpen()
	{
	}

	[Token(Token = "0x6006C88")]
	[Address(RVA = "0x15D3D94", Offset = "0x15D3D94", VA = "0x15D3D94")]
	public void OnClick_ShowClanSetting()
	{
	}

	[Token(Token = "0x6006C89")]
	[Address(RVA = "0x15D3E6C", Offset = "0x15D3E6C", VA = "0x15D3E6C", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006C8A")]
	[Address(RVA = "0x15D3FB4", Offset = "0x15D3FB4", VA = "0x15D3FB4")]
	public void OnClick_ClanRakingReward()
	{
	}

	[Token(Token = "0x6006C8B")]
	[Address(RVA = "0x15D418C", Offset = "0x15D418C", VA = "0x15D418C")]
	public void OnClick_ClanRankingRewardRecieve()
	{
	}

	[Token(Token = "0x6006C8C")]
	[Address(RVA = "0x15D4364", Offset = "0x15D4364", VA = "0x15D4364")]
	private void RequestClanLeave()
	{
	}

	[Token(Token = "0x6006C8D")]
	[Address(RVA = "0x15D4590", Offset = "0x15D4590", VA = "0x15D4590")]
	public void OnClick_ClanTerminate()
	{
	}

	[Token(Token = "0x6006C8E")]
	[Address(RVA = "0x15D4788", Offset = "0x15D4788", VA = "0x15D4788")]
	private void ShowTerminateInputBox()
	{
	}

	[Token(Token = "0x6006C8F")]
	[Address(RVA = "0x15D4A28", Offset = "0x15D4A28", VA = "0x15D4A28")]
	private void ReqClanTerminate()
	{
	}

	[Token(Token = "0x6006C90")]
	[Address(RVA = "0x15D4BE0", Offset = "0x15D4BE0", VA = "0x15D4BE0")]
	private void _003CRequestClanLeave_003Em__3E3(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006C91")]
	[Address(RVA = "0x15D4F24", Offset = "0x15D4F24", VA = "0x15D4F24")]
	private void _003CReqClanTerminate_003Em__3E5(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
