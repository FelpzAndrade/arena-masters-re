using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000F9A")]
public class XWidget_LadderReadyView : XUIBaseWidget
{
	[Token(Token = "0x4005291")]
	[FieldOffset(Offset = "0x1C")]
	private readonly string Path_TrophyRewardDetailPopup;

	[Token(Token = "0x4005292")]
	[FieldOffset(Offset = "0x20")]
	private readonly string Path_FirstRankRewardPopup;

	[Token(Token = "0x4005293")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_RewardDetailPopup _rewardBoxDetailPopup;

	[Token(Token = "0x4005294")]
	[FieldOffset(Offset = "0x28")]
	private XPanel_FirstRankReward _widgetFirstRankReward;

	[Token(Token = "0x4005295")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_RankingInfo myRankingInfo;

	[Token(Token = "0x4005296")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblGameDesc;

	[Token(Token = "0x4005297")]
	[FieldOffset(Offset = "0x34")]
	private Netdata_Ranker m_myRankerData;

	[Token(Token = "0x4005298")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_ToggleTab seasonDataTab;

	[Token(Token = "0x4005299")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_ToggleTab totalDataTab;

	[Token(Token = "0x400529A")]
	[FieldOffset(Offset = "0x40")]
	private XWidget_ToggleTab selectedTab;

	[Token(Token = "0x400529B")]
	[FieldOffset(Offset = "0x44")]
	private RankType m_RankType;

	[Token(Token = "0x400529C")]
	[FieldOffset(Offset = "0x48")]
	public XWidget_ItemDetailToolTip itemToolTip;

	[Token(Token = "0x400529D")]
	[FieldOffset(Offset = "0x4C")]
	public Transform toolTipTransform;

	[Token(Token = "0x400529E")]
	[FieldOffset(Offset = "0x50")]
	public Transform centerTransform;

	[Token(Token = "0x400529F")]
	[FieldOffset(Offset = "0x54")]
	public XWidget_TrophyReward TrophyReward;

	[Token(Token = "0x40052A0")]
	[FieldOffset(Offset = "0x58")]
	public XWidget_Button btnRecieveReward;

	[Token(Token = "0x40052A1")]
	[FieldOffset(Offset = "0x5C")]
	private int totalPlayerCnt;

	[Token(Token = "0x40052A2")]
	[FieldOffset(Offset = "0x60")]
	private bool isReqMyRankingData;

	[Token(Token = "0x17000ECD")]
	public XWidget_RewardDetailPopup rewardBoxDetailPopup
	{
		[Token(Token = "0x6007446")]
		[Address(RVA = "0x1457324", Offset = "0x1457324", VA = "0x1457324")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ECE")]
	private XPanel_FirstRankReward widgetFirstRankReward
	{
		[Token(Token = "0x6007447")]
		[Address(RVA = "0x1457440", Offset = "0x1457440", VA = "0x1457440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007445")]
	[Address(RVA = "0x1457284", Offset = "0x1457284", VA = "0x1457284")]
	public XWidget_LadderReadyView()
	{
	}

	[Token(Token = "0x6007448")]
	[Address(RVA = "0x145755C", Offset = "0x145755C", VA = "0x145755C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007449")]
	[Address(RVA = "0x1457560", Offset = "0x1457560", VA = "0x1457560")]
	public void ShowRewardBoxDetailPopup()
	{
	}

	[Token(Token = "0x600744A")]
	[Address(RVA = "0x145758C", Offset = "0x145758C", VA = "0x145758C")]
	public void Build(GameModeInstanceInfo modeInfo)
	{
	}

	[Token(Token = "0x600744B")]
	[Address(RVA = "0x1457E84", Offset = "0x1457E84", VA = "0x1457E84")]
	private void SetTrophyReward()
	{
	}

	[Token(Token = "0x600744C")]
	[Address(RVA = "0x1457C24", Offset = "0x1457C24", VA = "0x1457C24")]
	private void SelectRankDataTab(bool seasonSelect)
	{
	}

	[Token(Token = "0x600744D")]
	[Address(RVA = "0x14586F4", Offset = "0x14586F4", VA = "0x14586F4")]
	private void RefreshRankInfo(bool isPt)
	{
	}

	[Token(Token = "0x600744E")]
	[Address(RVA = "0x14585E8", Offset = "0x14585E8", VA = "0x14585E8")]
	private bool IsPlacementTestEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x600744F")]
	[Address(RVA = "0x14578B0", Offset = "0x14578B0", VA = "0x14578B0")]
	private void RequestMyRankData(RankType rankType, bool showTotalRank)
	{
	}

	[Token(Token = "0x6007450")]
	[Address(RVA = "0x14588B8", Offset = "0x14588B8", VA = "0x14588B8")]
	public void Show()
	{
	}

	[Token(Token = "0x6007451")]
	[Address(RVA = "0x1458904", Offset = "0x1458904", VA = "0x1458904", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6007452")]
	[Address(RVA = "0x145890C", Offset = "0x145890C", VA = "0x145890C")]
	public void OnClick_GoToRanking()
	{
	}

	[Token(Token = "0x6007453")]
	[Address(RVA = "0x14589E8", Offset = "0x14589E8", VA = "0x14589E8")]
	public void OnClick_ShowRewardList()
	{
	}

	[Token(Token = "0x6007454")]
	[Address(RVA = "0x1457C9C", Offset = "0x1457C9C", VA = "0x1457C9C")]
	private void ReqCheckRewardReceive()
	{
	}

	[Token(Token = "0x6007455")]
	[Address(RVA = "0x1458AF4", Offset = "0x1458AF4", VA = "0x1458AF4")]
	public void OnClickRecieveReward()
	{
	}

	[Token(Token = "0x6007456")]
	[Address(RVA = "0x1458CDC", Offset = "0x1458CDC", VA = "0x1458CDC")]
	public void OnClick_FirstRankReward()
	{
	}

	[Token(Token = "0x6007457")]
	[Address(RVA = "0x1458D14", Offset = "0x1458D14", VA = "0x1458D14")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6007458")]
	[Address(RVA = "0x1458DEC", Offset = "0x1458DEC", VA = "0x1458DEC")]
	private void _003CBuild_003Em__4B9()
	{
	}

	[Token(Token = "0x6007459")]
	[Address(RVA = "0x1458DF4", Offset = "0x1458DF4", VA = "0x1458DF4")]
	private void _003CBuild_003Em__4BA()
	{
	}

	[Token(Token = "0x600745A")]
	[Address(RVA = "0x1458DFC", Offset = "0x1458DFC", VA = "0x1458DFC")]
	private void _003CRequestMyRankData_003Em__4BB(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x600745B")]
	[Address(RVA = "0x1458FC4", Offset = "0x1458FC4", VA = "0x1458FC4")]
	private void _003CReqCheckRewardReceive_003Em__4BC(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x600745C")]
	[Address(RVA = "0x14590B0", Offset = "0x14590B0", VA = "0x14590B0")]
	private void _003COnClickRecieveReward_003Em__4BD(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
