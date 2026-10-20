using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000D11")]
public class XPanel_GameRecords : XCommonBackUI
{
	[Token(Token = "0x2000D12")]
	private enum RadioDicState
	{
		[Token(Token = "0x40042C9")]
		manner = 0,
		[Token(Token = "0x40042CA")]
		friend = 1,
		[Token(Token = "0x40042CB")]
		end = 2
	}

	[Token(Token = "0x2000D13")]
	private sealed class _003CMannerProcess_003Ec__AnonStorey199
	{
		[Token(Token = "0x40042CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal bool isCotainBad;

		[Token(Token = "0x40042CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_GameRecords _003C_003Ef__this;

		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0xFE3D04", Offset = "0xFE3D04", VA = "0xFE3D04")]
		public _003CMannerProcess_003Ec__AnonStorey199()
		{
		}

		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0xFE54EC", Offset = "0xFE54EC", VA = "0xFE54EC")]
		internal void _003C_003Em__2A9(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x40042AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIPanel panelRoot;

	[Token(Token = "0x40042AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Transform transformCenter;

	[Token(Token = "0x40042AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform trasformRight_PVP;

	[Token(Token = "0x40042AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Transform trasformRight_PVE;

	[Token(Token = "0x40042AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject goRoot;

	[Token(Token = "0x40042AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GameObject goResultTitle;

	[Token(Token = "0x40042B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel lblTop;

	[Token(Token = "0x40042B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UILabel lblBottom;

	[Token(Token = "0x40042B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public XWidget_Builder playerRecordBuilder;

	[Token(Token = "0x40042B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public GameObject goRootTeamRecord;

	[Token(Token = "0x40042B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject goDefaultTeamRecord;

	[Token(Token = "0x40042B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UIGrid grid_ATeamRecords;

	[Token(Token = "0x40042B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIGrid grid_BTeamRecords;

	[Token(Token = "0x40042B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UIGrid grid_DefaultRecords;

	[Token(Token = "0x40042B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject onResultButton;

	[Token(Token = "0x40042B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Action m_resultButtonClickAction;

	[Token(Token = "0x40042BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject goNonRecommend;

	[Token(Token = "0x40042BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public GameObject backgroundCollider;

	[Token(Token = "0x40042BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject btnGoPvPMissionResult;

	[Token(Token = "0x40042BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public UILabel lblGoPvPMissionResult;

	[Token(Token = "0x40042BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Action m_goPvPMissionResultAction;

	[Token(Token = "0x40042BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool m_FinalResult;

	[Token(Token = "0x40042C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private IRecordUISetter recordSetting;

	[Token(Token = "0x40042C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public GameObject goBackGroundCollider;

	[Token(Token = "0x40042C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TweenPosition tweenPos;

	[Token(Token = "0x40042C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool finalRecordBuilded;

	[Token(Token = "0x40042C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UIBasicSprite sprBG;

	[Token(Token = "0x40042C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Dictionary<string, RadioState>[] m_stateDictioary;

	[Token(Token = "0x40042C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UILabel lblNormalTitle;

	[Token(Token = "0x40042C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public GameObject btnClear;

	[Token(Token = "0x6005F8C")]
	[Address(RVA = "0xFE1248", Offset = "0xFE1248", VA = "0xFE1248")]
	public XPanel_GameRecords()
	{
	}

	[Token(Token = "0x6005F8D")]
	[Address(RVA = "0xFE13DC", Offset = "0xFE13DC", VA = "0xFE13DC", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F8E")]
	[Address(RVA = "0xFE1488", Offset = "0xFE1488", VA = "0xFE1488")]
	public void StartTweenPos()
	{
	}

	[Token(Token = "0x6005F8F")]
	[Address(RVA = "0xFE150C", Offset = "0xFE150C", VA = "0xFE150C")]
	public void Init(IRecordUISetter recordSetting)
	{
	}

	[Token(Token = "0x6005F90")]
	[Address(RVA = "0xFE1774", Offset = "0xFE1774", VA = "0xFE1774")]
	private static void RefreshBadMannerClickCount()
	{
	}

	[Token(Token = "0x6005F91")]
	[Address(RVA = "0xFE15E0", Offset = "0xFE15E0", VA = "0xFE15E0")]
	public void SetLayout(bool bFinalResult, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005F92")]
	[Address(RVA = "0xFE22F0", Offset = "0xFE22F0", VA = "0xFE22F0")]
	private void SetRecordList(bool bFinalResult, bool isTeamActive)
	{
	}

	[Token(Token = "0x6005F93")]
	[Address(RVA = "0xFE2340", Offset = "0xFE2340", VA = "0xFE2340")]
	private void SetRoot(bool bFinalResult, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005F94")]
	[Address(RVA = "0xFE1A04", Offset = "0xFE1A04", VA = "0xFE1A04")]
	private void SetTitle(bool bFinalResult, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005F95")]
	[Address(RVA = "0xFE2614", Offset = "0xFE2614", VA = "0xFE2614")]
	private void SetTitle(UILabel lbl, CSWinlose winlose, string text)
	{
	}

	[Token(Token = "0x6005F96")]
	[Address(RVA = "0xFE290C", Offset = "0xFE290C", VA = "0xFE290C")]
	public void SetBackgroundCollider(bool bVisible)
	{
	}

	[Token(Token = "0x6005F97")]
	[Address(RVA = "0xFE29F8", Offset = "0xFE29F8", VA = "0xFE29F8")]
	public void ShowIngameButtons()
	{
	}

	[Token(Token = "0x6005F98")]
	[Address(RVA = "0xFE2C80", Offset = "0xFE2C80", VA = "0xFE2C80")]
	public void ShowGoResultButtons()
	{
	}

	[Token(Token = "0x6005F99")]
	[Address(RVA = "0xFE2C88", Offset = "0xFE2C88", VA = "0xFE2C88")]
	public void SetGoResultButtonClickAction([Optional] Action clickAction)
	{
	}

	[Token(Token = "0x6005F9A")]
	[Address(RVA = "0xFE2C90", Offset = "0xFE2C90", VA = "0xFE2C90")]
	public void ShowMissionPvPButton(bool isSuccess, Action ShowGameResultAction)
	{
	}

	[Token(Token = "0x6005F9B")]
	[Address(RVA = "0xFE2A00", Offset = "0xFE2A00", VA = "0xFE2A00")]
	private void EnableIngameButtons(bool value)
	{
	}

	[Token(Token = "0x6005F9C")]
	[Address(RVA = "0xFE2E40", Offset = "0xFE2E40", VA = "0xFE2E40")]
	private bool EnableGameModeButton(bool isGetReady)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F9D")]
	[Address(RVA = "0xFE2F30", Offset = "0xFE2F30", VA = "0xFE2F30")]
	public void Show()
	{
	}

	[Token(Token = "0x6005F9E")]
	[Address(RVA = "0xFE31F4", Offset = "0xFE31F4", VA = "0xFE31F4", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6005F9F")]
	[Address(RVA = "0xFE141C", Offset = "0xFE141C", VA = "0xFE141C")]
	public void OnClick_GoResult()
	{
	}

	[Token(Token = "0x6005FA0")]
	[Address(RVA = "0xFE3CD8", Offset = "0xFE3CD8", VA = "0xFE3CD8")]
	private void ResultButtonClickActionFunc()
	{
	}

	[Token(Token = "0x6005FA1")]
	[Address(RVA = "0xFE32BC", Offset = "0xFE32BC", VA = "0xFE32BC")]
	private void MannerProcess()
	{
	}

	[Token(Token = "0x6005FA2")]
	[Address(RVA = "0xFE37EC", Offset = "0xFE37EC", VA = "0xFE37EC")]
	private void FriendProcess()
	{
	}

	[Token(Token = "0x6005FA3")]
	[Address(RVA = "0xFE3D0C", Offset = "0xFE3D0C", VA = "0xFE3D0C")]
	public void ShowNonRecommendPopup()
	{
	}

	[Token(Token = "0x6005FA4")]
	[Address(RVA = "0xFE3D3C", Offset = "0xFE3D3C", VA = "0xFE3D3C")]
	public void OnClick_NonRecommendOK()
	{
	}

	[Token(Token = "0x6005FA5")]
	[Address(RVA = "0xFE3E94", Offset = "0xFE3E94", VA = "0xFE3E94")]
	public void OnClick_NonRecommendPopupHide()
	{
	}

	[Token(Token = "0x6005FA6")]
	[Address(RVA = "0xFE3EC4", Offset = "0xFE3EC4", VA = "0xFE3EC4")]
	public void OnClick_MissionPvPResult()
	{
	}

	[Token(Token = "0x6005FA7")]
	[Address(RVA = "0xFE3ED8", Offset = "0xFE3ED8", VA = "0xFE3ED8")]
	public void OnClickGameClearButton()
	{
	}

	[Token(Token = "0x6005FA8")]
	[Address(RVA = "0xFE21F4", Offset = "0xFE21F4", VA = "0xFE21F4")]
	private IRecordUISetter GetRecordSetter()
	{
		return null;
	}

	[Token(Token = "0x6005FA9")]
	[Address(RVA = "0xFE3EDC", Offset = "0xFE3EDC", VA = "0xFE3EDC")]
	public void BuildRecordPanels(XPlayerManager playerManager, bool bFinish = false)
	{
	}

	[Token(Token = "0x6005FAA")]
	[Address(RVA = "0xFE4184", Offset = "0xFE4184", VA = "0xFE4184")]
	private void BuildTeamRecord(List<XPlayer> playerList, XGameModeType mode, bool isReady, bool bFinish = false)
	{
	}

	[Token(Token = "0x6005FAB")]
	[Address(RVA = "0xFE4D44", Offset = "0xFE4D44", VA = "0xFE4D44")]
	private void StateDicClear()
	{
	}

	[Token(Token = "0x6005FAC")]
	[Address(RVA = "0xFE49E4", Offset = "0xFE49E4", VA = "0xFE49E4")]
	private void BuildAllRecord(List<XPlayer> playerList, XGameModeType mode, bool isShowReadyForamt, bool bFinish = false)
	{
	}

	[Token(Token = "0x6005FAD")]
	[Address(RVA = "0xFE4E10", Offset = "0xFE4E10", VA = "0xFE4E10")]
	private void BuildRecordWidget(XWidget_PlayerRecord widget, Transform parent, int siblingIdx, XPlayer player, XGameModeType mode, bool isShowReadyForamt, bool bFinish, bool enableSpriteIcon, bool isTeamMode)
	{
	}

	[Token(Token = "0x6005FAE")]
	[Address(RVA = "0xFE4F8C", Offset = "0xFE4F8C", VA = "0xFE4F8C")]
	private void MannerAction(string userNickName, byte mannerState)
	{
	}

	[Token(Token = "0x6005FAF")]
	[Address(RVA = "0xFE5144", Offset = "0xFE5144", VA = "0xFE5144")]
	private void FriendAction(string userAid, byte friendState)
	{
	}

	[Token(Token = "0x6005FB0")]
	[Address(RVA = "0xFE5304", Offset = "0xFE5304", VA = "0xFE5304")]
	private void ShowNotification(RadioState state)
	{
	}

	[Token(Token = "0x6005FB1")]
	[Address(RVA = "0xFE54C0", Offset = "0xFE54C0", VA = "0xFE54C0")]
	private void _003CFriendProcess_003Em__2AA(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
