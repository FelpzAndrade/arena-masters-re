using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DEC")]
public class XPanel_GameReadyView : XUIBasePanel, IFriendPartyListener
{
	[Token(Token = "0x2000DED")]
	private sealed class _003CShowNormal_003Ec__AnonStorey1D1
	{
		[Token(Token = "0x40048C5")]
		[FieldOffset(Offset = "0x8")]
		internal int modeInstaceID;

		[Token(Token = "0x6006707")]
		[Address(RVA = "0xFDC178", Offset = "0xFDC178", VA = "0xFDC178")]
		public _003CShowNormal_003Ec__AnonStorey1D1()
		{
		}

		[Token(Token = "0x6006708")]
		[Address(RVA = "0xFE1214", Offset = "0xFE1214", VA = "0xFE1214")]
		internal bool _003C_003Em__381(GameModeInstanceInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40048A0")]
	[FieldOffset(Offset = "0x10")]
	public Transform groupInviteInfoParent;

	[Token(Token = "0x40048A1")]
	[FieldOffset(Offset = "0x14")]
	private XWidget_GroupInviteParty groupPartyInviteInfo;

	[Token(Token = "0x40048A2")]
	[FieldOffset(Offset = "0x18")]
	public Transform partyViewTransform;

	[Token(Token = "0x40048A3")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_PartyViewer partyViewer;

	[Token(Token = "0x40048A4")]
	[FieldOffset(Offset = "0x20")]
	public Transform teamSettingParent;

	[Token(Token = "0x40048A5")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_StageTeamInfoSetting teamSetting;

	[Token(Token = "0x40048A6")]
	[FieldOffset(Offset = "0x28")]
	public UI2DSprite sprCost;

	[Token(Token = "0x40048A7")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblCost;

	[Token(Token = "0x40048A8")]
	[FieldOffset(Offset = "0x30")]
	public UITable tableCost;

	[Token(Token = "0x40048A9")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_Button btnStart;

	[Token(Token = "0x40048AA")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_Button btnGroupStart;

	[Token(Token = "0x40048AB")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblBtnStart;

	[Token(Token = "0x40048AC")]
	[FieldOffset(Offset = "0x40")]
	private XUIBaseWidget m_currentInfo;

	[Token(Token = "0x40048AD")]
	[FieldOffset(Offset = "0x44")]
	private readonly string Path_PVPEventInfo;

	[Token(Token = "0x40048AE")]
	[FieldOffset(Offset = "0x48")]
	private readonly string Path_PVPInfo;

	[Token(Token = "0x40048AF")]
	[FieldOffset(Offset = "0x4C")]
	private readonly string Path_LadderInfo;

	[Token(Token = "0x40048B0")]
	[FieldOffset(Offset = "0x50")]
	private readonly string Path_PVEInfo;

	[Token(Token = "0x40048B1")]
	[FieldOffset(Offset = "0x54")]
	private readonly string Path_GroupInviteListPopup;

	[Token(Token = "0x40048B2")]
	[FieldOffset(Offset = "0x58")]
	private XWidget_PVPEventReadyView _pvpEventInfo;

	[Token(Token = "0x40048B3")]
	[FieldOffset(Offset = "0x5C")]
	private XWidget_PVPReadyView _pvpInfo;

	[Token(Token = "0x40048B4")]
	[FieldOffset(Offset = "0x60")]
	private XWidget_LadderReadyView _ladderInfo;

	[Token(Token = "0x40048B5")]
	[FieldOffset(Offset = "0x64")]
	private XWidget_PVEReadyView _pveInfo;

	[Token(Token = "0x40048B6")]
	[FieldOffset(Offset = "0x68")]
	private XPanel_GroupInviteListPopup _groupInviteListPopup;

	[Token(Token = "0x40048B7")]
	[FieldOffset(Offset = "0x6C")]
	private XGameStarter m_gameStarter;

	[Token(Token = "0x40048B8")]
	[FieldOffset(Offset = "0x70")]
	private bool m_isModeLock;

	[Token(Token = "0x40048B9")]
	[FieldOffset(Offset = "0x71")]
	private bool m_isLadder;

	[Token(Token = "0x40048BA")]
	[FieldOffset(Offset = "0x72")]
	private bool m_isRandomMode;

	[Token(Token = "0x40048BB")]
	[FieldOffset(Offset = "0x74")]
	private string strOnClickUnlockStartButton;

	[Token(Token = "0x40048BC")]
	[FieldOffset(Offset = "0x78")]
	private string m_friendlyRoomTitle;

	[Token(Token = "0x40048BD")]
	[FieldOffset(Offset = "0x7C")]
	private string m_friendlyPhotonRoomTitle;

	[Token(Token = "0x40048BE")]
	[FieldOffset(Offset = "0x80")]
	private string m_friendlyPassword;

	[Token(Token = "0x40048BF")]
	[FieldOffset(Offset = "0x84")]
	private int m_friendlySectorID;

	[Token(Token = "0x40048C0")]
	[FieldOffset(Offset = "0x88")]
	private bool m_isFriendlyJoin;

	[Token(Token = "0x40048C1")]
	[FieldOffset(Offset = "0x89")]
	private bool m_isGroupPlay;

	[Token(Token = "0x40048C2")]
	[FieldOffset(Offset = "0x8A")]
	private bool m_isFriendlyMake;

	[Token(Token = "0x40048C3")]
	[FieldOffset(Offset = "0x8C")]
	private int m_customRoomSetting;

	[Token(Token = "0x40048C4")]
	[FieldOffset(Offset = "0x90")]
	private bool IsAIMode__BackingField;

	[Token(Token = "0x17000D64")]
	protected override int BackableStackCount
	{
		[Token(Token = "0x60066C4")]
		[Address(RVA = "0xFDA148", Offset = "0xFDA148", VA = "0xFDA148", Slot = "18")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000D65")]
	public XWidget_GroupInviteParty GroupIniviteParty
	{
		[Token(Token = "0x60066C5")]
		[Address(RVA = "0xFDA150", Offset = "0xFDA150", VA = "0xFDA150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D66")]
	private XWidget_PVPEventReadyView pvpEventInfo
	{
		[Token(Token = "0x60066C8")]
		[Address(RVA = "0xFDA654", Offset = "0xFDA654", VA = "0xFDA654")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D67")]
	private XWidget_PVPReadyView pvpInfo
	{
		[Token(Token = "0x60066C9")]
		[Address(RVA = "0xFDA754", Offset = "0xFDA754", VA = "0xFDA754")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D68")]
	private XWidget_LadderReadyView ladderInfo
	{
		[Token(Token = "0x60066CA")]
		[Address(RVA = "0xFDA854", Offset = "0xFDA854", VA = "0xFDA854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D69")]
	public XWidget_PVEReadyView pveInfo
	{
		[Token(Token = "0x60066CB")]
		[Address(RVA = "0xFDA954", Offset = "0xFDA954", VA = "0xFDA954")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D6A")]
	public XPanel_GroupInviteListPopup GroupInviteListPopup
	{
		[Token(Token = "0x60066CC")]
		[Address(RVA = "0xFDA338", Offset = "0xFDA338", VA = "0xFDA338")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D6B")]
	public bool IsAIMode
	{
		[Token(Token = "0x60066CD")]
		[Address(RVA = "0xFDAA54", Offset = "0xFDAA54", VA = "0xFDAA54")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60066CE")]
		[Address(RVA = "0xFDAA5C", Offset = "0xFDAA5C", VA = "0xFDAA5C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000D6C")]
	public bool IsRandomMode
	{
		[Token(Token = "0x60066CF")]
		[Address(RVA = "0xFDAA64", Offset = "0xFDAA64", VA = "0xFDAA64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60066D0")]
		[Address(RVA = "0xFDAA6C", Offset = "0xFDAA6C", VA = "0xFDAA6C")]
		set
		{
		}
	}

	[Token(Token = "0x60066C3")]
	[Address(RVA = "0xFD9FE0", Offset = "0xFD9FE0", VA = "0xFD9FE0")]
	public XPanel_GameReadyView()
	{
	}

	[Token(Token = "0x60066C6")]
	[Address(RVA = "0xFDA158", Offset = "0xFDA158", VA = "0xFDA158")]
	private void SetCurrentInfo(XUIBaseWidget widget)
	{
	}

	[Token(Token = "0x60066C7")]
	[Address(RVA = "0xFDA160", Offset = "0xFDA160", VA = "0xFDA160")]
	private void WidgetHide()
	{
	}

	[Token(Token = "0x60066D1")]
	[Address(RVA = "0xFDAA74", Offset = "0xFDAA74", VA = "0xFDAA74")]
	public bool IsFriendlyMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x60066D2")]
	[Address(RVA = "0xFDAA98", Offset = "0xFDAA98", VA = "0xFDAA98")]
	public void SetRandomModeData()
	{
	}

	[Token(Token = "0x60066D3")]
	[Address(RVA = "0xFDAAA4", Offset = "0xFDAAA4", VA = "0xFDAAA4")]
	public void SetFriendlyJoinData(string roomTitle, string photonRoomTitle, int sectorID)
	{
	}

	[Token(Token = "0x60066D4")]
	[Address(RVA = "0xFDAABC", Offset = "0xFDAABC", VA = "0xFDAABC")]
	public void SetFriendlyMakeData(string roomTitle, string password, int sectorID)
	{
	}

	[Token(Token = "0x60066D5")]
	[Address(RVA = "0xFDAAD4", Offset = "0xFDAAD4", VA = "0xFDAAD4")]
	internal void SetCustomRoomInfo(CustomRoomInfo roomInfo)
	{
	}

	[Token(Token = "0x60066D6")]
	[Address(RVA = "0xFDAB70", Offset = "0xFDAB70", VA = "0xFDAB70")]
	private void SetGameStarter(GameModeInstanceInfo gameModeInstanceInfo)
	{
	}

	[Token(Token = "0x60066D7")]
	[Address(RVA = "0xFDABC4", Offset = "0xFDABC4", VA = "0xFDABC4")]
	private void SetGameStarter(GameModeInstanceInfo gameModeInstanceInfo, int sectorID, bool isAIMode)
	{
	}

	[Token(Token = "0x60066D8")]
	[Address(RVA = "0xFDACEC", Offset = "0xFDACEC", VA = "0xFDACEC")]
	public void ShowPVEDetail(CSStageInfo stageInfo, UserDataBase userData, XGameModeType gameModeType, bool isAIMode = false)
	{
	}

	[Token(Token = "0x60066D9")]
	[Address(RVA = "0xFDB6FC", Offset = "0xFDB6FC", VA = "0xFDB6FC")]
	public void ShowEvent(int eventModeID)
	{
	}

	[Token(Token = "0x60066DA")]
	[Address(RVA = "0xFDBD6C", Offset = "0xFDBD6C", VA = "0xFDBD6C")]
	public void RefreshEventStartButton()
	{
	}

	[Token(Token = "0x60066DB")]
	[Address(RVA = "0xFDBFCC", Offset = "0xFDBFCC", VA = "0xFDBFCC")]
	public void ShowNormal(bool isAIMode, int modeInstaceID)
	{
	}

	[Token(Token = "0x60066DC")]
	[Address(RVA = "0xFDC5C8", Offset = "0xFDC5C8", VA = "0xFDC5C8")]
	public void ShowNormal(bool isAIMode, XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x60066DD")]
	[Address(RVA = "0xFDC180", Offset = "0xFDC180", VA = "0xFDC180")]
	public void BuildNormal(bool isAIMode, GameModeInstanceInfo instanceInfo)
	{
	}

	[Token(Token = "0x60066DE")]
	[Address(RVA = "0xFDC9D4", Offset = "0xFDC9D4", VA = "0xFDC9D4")]
	public void BuildCustomRoom()
	{
	}

	[Token(Token = "0x60066DF")]
	[Address(RVA = "0xFDCDAC", Offset = "0xFDCDAC", VA = "0xFDCDAC")]
	public void ShowLadder(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x60066E0")]
	[Address(RVA = "0xFDD07C", Offset = "0xFDD07C", VA = "0xFDD07C")]
	public void ResetData()
	{
	}

	[Token(Token = "0x60066E1")]
	[Address(RVA = "0xFDCEEC", Offset = "0xFDCEEC", VA = "0xFDCEEC")]
	private void ChangeMode(GameModeInstanceInfo gameModeInstanceInfo, string strUnlock, bool isLock)
	{
	}

	[Token(Token = "0x60066E2")]
	[Address(RVA = "0xFDD2E8", Offset = "0xFDD2E8", VA = "0xFDD2E8")]
	private void SendChangePartyGameMode(GameModeInstanceInfo gameModeInstanceInfo)
	{
	}

	[Token(Token = "0x60066E3")]
	[Address(RVA = "0xFDB318", Offset = "0xFDB318", VA = "0xFDB318")]
	private void BuildCommon(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x60066E4")]
	[Address(RVA = "0xFDD8A0", Offset = "0xFDD8A0", VA = "0xFDD8A0")]
	private void ShowStartFailNoti()
	{
	}

	[Token(Token = "0x60066E5")]
	[Address(RVA = "0xFDD6B4", Offset = "0xFDD6B4", VA = "0xFDD6B4")]
	private void BuildTeamSetting(XGameModeType gameModeType, bool isRandomMode)
	{
	}

	[Token(Token = "0x60066E6")]
	[Address(RVA = "0xFDD4E4", Offset = "0xFDD4E4", VA = "0xFDD4E4")]
	private void BuildPartyViewer()
	{
	}

	[Token(Token = "0x60066E7")]
	[Address(RVA = "0xFDB4EC", Offset = "0xFDB4EC", VA = "0xFDB4EC")]
	private void BuildCost(Currency enterCostType, int enterCostCount, string costText)
	{
	}

	[Token(Token = "0x60066E8")]
	[Address(RVA = "0xFDC610", Offset = "0xFDC610", VA = "0xFDC610")]
	private void BuildGroupParty(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x60066E9")]
	[Address(RVA = "0xFDCCC0", Offset = "0xFDCCC0", VA = "0xFDCCC0")]
	private void DisableGroupPartyInviteInfo()
	{
	}

	[Token(Token = "0x60066EA")]
	[Address(RVA = "0xFDDA08", Offset = "0xFDDA08", VA = "0xFDDA08")]
	public XGameModeType GetGameModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x60066EB")]
	[Address(RVA = "0xFDDA5C", Offset = "0xFDDA5C", VA = "0xFDDA5C")]
	public int GetGameModeInstanceID()
	{
		return default(int);
	}

	[Token(Token = "0x60066EC")]
	[Address(RVA = "0xFDDB80", Offset = "0xFDDB80", VA = "0xFDDB80")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60066ED")]
	[Address(RVA = "0xFDDC64", Offset = "0xFDDC64", VA = "0xFDDC64")]
	public void OnClick_ShowGroupInviteListPopup()
	{
	}

	[Token(Token = "0x60066EE")]
	[Address(RVA = "0xFDDF54", Offset = "0xFDDF54", VA = "0xFDDF54")]
	public void OnClickStart()
	{
	}

	[Token(Token = "0x60066EF")]
	[Address(RVA = "0xFDF19C", Offset = "0xFDF19C", VA = "0xFDF19C")]
	private void GetMissionReward()
	{
	}

	[Token(Token = "0x60066F0")]
	[Address(RVA = "0xFDF2D0", Offset = "0xFDF2D0", VA = "0xFDF2D0")]
	public void GetMissionRewardDelegate(Action aciont)
	{
	}

	[Token(Token = "0x60066F1")]
	[Address(RVA = "0xFDE800", Offset = "0xFDE800", VA = "0xFDE800")]
	private void ProcessingStartGame()
	{
	}

	[Token(Token = "0x60066F2")]
	[Address(RVA = "0xFDFE44", Offset = "0xFDFE44", VA = "0xFDFE44")]
	private void GoToInventory()
	{
	}

	[Token(Token = "0x60066F3")]
	[Address(RVA = "0xFDF588", Offset = "0xFDF588", VA = "0xFDF588")]
	private bool StartGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60066F4")]
	[Address(RVA = "0xFDFFF4", Offset = "0xFDFFF4", VA = "0xFDFFF4")]
	private bool StartPVPGame(Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x60066F5")]
	[Address(RVA = "0xFDF3BC", Offset = "0xFDF3BC", VA = "0xFDF3BC")]
	public bool StartFriendlyGame(string roomName, string friendlyPassword, string masterName = "")
	{
		return default(bool);
	}

	[Token(Token = "0x60066F6")]
	[Address(RVA = "0xFDFF18", Offset = "0xFDFF18", VA = "0xFDFF18")]
	private void SetStartInput(bool enable)
	{
	}

	[Token(Token = "0x60066F7")]
	[Address(RVA = "0xFE0148", Offset = "0xFE0148", VA = "0xFE0148")]
	public void ShowAndNotBuild()
	{
	}

	[Token(Token = "0x60066F8")]
	[Address(RVA = "0xFE03F0", Offset = "0xFE03F0", VA = "0xFE03F0")]
	private void PartyMasterLeave()
	{
	}

	[Token(Token = "0x60066F9")]
	[Address(RVA = "0xFE05D4", Offset = "0xFE05D4", VA = "0xFE05D4", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x60066FA")]
	[Address(RVA = "0xFE0930", Offset = "0xFE0930", VA = "0xFE0930", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60066FB")]
	[Address(RVA = "0xFE0B80", Offset = "0xFE0B80", VA = "0xFE0B80", Slot = "26")]
	public void OnBreakParty()
	{
	}

	[Token(Token = "0x60066FC")]
	[Address(RVA = "0xFE0C00", Offset = "0xFE0C00", VA = "0xFE0C00", Slot = "20")]
	public void OnDisconnectFromPhoton()
	{
	}

	[Token(Token = "0x60066FD")]
	[Address(RVA = "0xFE0C80", Offset = "0xFE0C80", VA = "0xFE0C80", Slot = "24")]
	public void OnCreatePary()
	{
	}

	[Token(Token = "0x60066FE")]
	[Address(RVA = "0xFDC884", Offset = "0xFDC884", VA = "0xFDC884")]
	private void BuildGroupStartButton(DTPartyInfo partyInfo, bool isModeLock)
	{
	}

	[Token(Token = "0x60066FF")]
	[Address(RVA = "0xFE0DD4", Offset = "0xFE0DD4", VA = "0xFE0DD4", Slot = "19")]
	public void OnUpdatePartyInfo(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6006700")]
	[Address(RVA = "0xFE0F04", Offset = "0xFE0F04", VA = "0xFE0F04", Slot = "21")]
	public void OnChangeGameModeInfo(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6006701")]
	[Address(RVA = "0xFE0F08", Offset = "0xFE0F08", VA = "0xFE0F08", Slot = "22")]
	public void OnReciveAccept(string accepter)
	{
	}

	[Token(Token = "0x6006702")]
	[Address(RVA = "0xFE0F0C", Offset = "0xFE0F0C", VA = "0xFE0F0C", Slot = "23")]
	public void OnReciveRefuse(string refuser)
	{
	}

	[Token(Token = "0x6006703")]
	[Address(RVA = "0xFE0F10", Offset = "0xFE0F10", VA = "0xFE0F10", Slot = "25")]
	public void OnLeaveParty()
	{
	}

	[Token(Token = "0x6006704")]
	[Address(RVA = "0xFE0F14", Offset = "0xFE0F14", VA = "0xFE0F14")]
	private void _003CStartGame_003Em__382()
	{
	}

	[Token(Token = "0x6006705")]
	[Address(RVA = "0xFE1030", Offset = "0xFE1030", VA = "0xFE1030")]
	private void _003CStartFriendlyGame_003Em__383()
	{
	}

	[Token(Token = "0x6006706")]
	[Address(RVA = "0xFE113C", Offset = "0xFE113C", VA = "0xFE113C")]
	private void _003CBack_003Em__384()
	{
	}
}
