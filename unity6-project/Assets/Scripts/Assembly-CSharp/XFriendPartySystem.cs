using System;
using System.Collections.Generic;
using CS;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20004AE")]
public class XFriendPartySystem : IPartyOperationResListener, IPhotonPlayerConnectListener
{
	[Token(Token = "0x20004AF")]
	private enum RefuseType
	{
		[Token(Token = "0x4001760")]
		MatchWait = 1,
		[Token(Token = "0x4001761")]
		NotLobby = 2,
		[Token(Token = "0x4001762")]
		GroupPlayWait = 3,
		[Token(Token = "0x4001763")]
		UserRefuse = 4
	}

	[Token(Token = "0x20004B0")]
	private sealed class _003CReceiveGameInviation_003Ec__AnonStorey101
	{
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x8")]
		internal string sponsor;

		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x10")]
		internal long partyKey;

		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x18")]
		internal XFriendPartySystem _003C_003Ef__this;

		[Token(Token = "0x6002878")]
		[Address(RVA = "0x19B7430", Offset = "0x19B7430", VA = "0x19B7430")]
		public _003CReceiveGameInviation_003Ec__AnonStorey101()
		{
		}

		[Token(Token = "0x6002879")]
		[Address(RVA = "0x19BC69C", Offset = "0x19BC69C", VA = "0x19BC69C")]
		internal void _003C_003Em__DC()
		{
		}

		[Token(Token = "0x600287A")]
		[Address(RVA = "0x19BC704", Offset = "0x19BC704", VA = "0x19BC704")]
		internal void _003C_003Em__DD()
		{
		}
	}

	[Token(Token = "0x20004B1")]
	private sealed class _003CReceiveAcceptPartyInviation_003Ec__AnonStorey102
	{
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x8")]
		internal string accepter;

		[Token(Token = "0x600287B")]
		[Address(RVA = "0x19B7AA8", Offset = "0x19B7AA8", VA = "0x19B7AA8")]
		public _003CReceiveAcceptPartyInviation_003Ec__AnonStorey102()
		{
		}

		[Token(Token = "0x600287C")]
		[Address(RVA = "0x19BC58C", Offset = "0x19BC58C", VA = "0x19BC58C")]
		internal void _003C_003Em__DE(IFriendPartyListener listener)
		{
		}
	}

	[Token(Token = "0x20004B2")]
	private sealed class _003CReceiveRefuseGameInvitation_003Ec__AnonStorey103
	{
		[Token(Token = "0x4001768")]
		[FieldOffset(Offset = "0x8")]
		internal string refuser;

		[Token(Token = "0x600287D")]
		[Address(RVA = "0x19B7DA4", Offset = "0x19B7DA4", VA = "0x19B7DA4")]
		public _003CReceiveRefuseGameInvitation_003Ec__AnonStorey103()
		{
		}

		[Token(Token = "0x600287E")]
		[Address(RVA = "0x19BC734", Offset = "0x19BC734", VA = "0x19BC734")]
		internal void _003C_003Em__DF(IFriendPartyListener listner)
		{
		}
	}

	[Token(Token = "0x20004B3")]
	private sealed class _003CStartPartyGame_003Ec__AnonStorey104
	{
		[Token(Token = "0x4001769")]
		[FieldOffset(Offset = "0x8")]
		internal int sectorID;

		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0xC")]
		internal XGameModeType gameMode;

		[Token(Token = "0x400176B")]
		[FieldOffset(Offset = "0x10")]
		internal MatchType matchType;

		[Token(Token = "0x600287F")]
		[Address(RVA = "0x19B89C8", Offset = "0x19B89C8", VA = "0x19B89C8")]
		public _003CStartPartyGame_003Ec__AnonStorey104()
		{
		}

		[Token(Token = "0x6002880")]
		[Address(RVA = "0x19BC844", Offset = "0x19BC844", VA = "0x19BC844")]
		internal void _003C_003Em__E2()
		{
		}
	}

	[Token(Token = "0x20004B4")]
	private sealed class _003COnChangePartyInfoStateNotify_003Ec__AnonStorey105
	{
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x8")]
		internal XGameModeType gameMode;

		[Token(Token = "0x6002881")]
		[Address(RVA = "0x19B98C4", Offset = "0x19B98C4", VA = "0x19B98C4")]
		public _003COnChangePartyInfoStateNotify_003Ec__AnonStorey105()
		{
		}

		[Token(Token = "0x6002882")]
		[Address(RVA = "0x19BC390", Offset = "0x19BC390", VA = "0x19BC390")]
		internal void _003C_003Em__E7(IFriendPartyListener listner)
		{
		}
	}

	[Token(Token = "0x20004B5")]
	private sealed class _003COnUpdatePartyMemberInfo_003Ec__AnonStorey106
	{
		[Token(Token = "0x400176D")]
		[FieldOffset(Offset = "0x8")]
		internal NetMatchPlayerInfo player;

		[Token(Token = "0x6002883")]
		[Address(RVA = "0x19B9A40", Offset = "0x19B9A40", VA = "0x19B9A40")]
		public _003COnUpdatePartyMemberInfo_003Ec__AnonStorey106()
		{
		}

		[Token(Token = "0x6002884")]
		[Address(RVA = "0x19BC4A0", Offset = "0x19BC4A0", VA = "0x19BC4A0")]
		internal bool _003C_003Em__E8(NetMatchPlayerInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004B6")]
	private sealed class _003CAddPlayerInRoomWithReady_003Ec__AnonStorey107
	{
		[Token(Token = "0x400176E")]
		[FieldOffset(Offset = "0x8")]
		internal XPlayer player;

		[Token(Token = "0x6002885")]
		[Address(RVA = "0x19BA3AC", Offset = "0x19BA3AC", VA = "0x19BA3AC")]
		public _003CAddPlayerInRoomWithReady_003Ec__AnonStorey107()
		{
		}

		[Token(Token = "0x6002886")]
		[Address(RVA = "0x19BC2AC", Offset = "0x19BC2AC", VA = "0x19BC2AC")]
		internal bool _003C_003Em__E9(NetMatchPlayerInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x8")]
	private HashSet<string> m_hsRefuser;

	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0xC")]
	private HashSet<string> m_hsEnterFriendName;

	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x10")]
	private List<string> m_liLatelyPlayer;

	[Token(Token = "0x4001751")]
	[FieldOffset(Offset = "0x14")]
	private FriendPartyRoomJoiner m_RoomJoiner;

	[Token(Token = "0x4001752")]
	[FieldOffset(Offset = "0x18")]
	private PeriodUpdaterPuase m_RoomVisible;

	[Token(Token = "0x4001753")]
	[FieldOffset(Offset = "0x1C")]
	private List<IFriendPartyListener> m_Listeners;

	[Token(Token = "0x4001754")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float TimeOutSec;

	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x20")]
	private IGroupInviteMsgPopup GroupInvitePopup;

	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x24")]
	private DTPartyInfo PartyData__BackingField;

	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x4")]
	private static Action<IFriendPartyListener> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x8")]
	private static Action<IFriendPartyListener> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4001759")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x10")]
	private static Func<NetMatchPlayerInfo, string> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x400175B")]
	[FieldOffset(Offset = "0x14")]
	private static Func<NetMatchPlayerInfo, int> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x18")]
	private static Action<IFriendPartyListener> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x1C")]
	private static Action<IFriendPartyListener> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x400175E")]
	[FieldOffset(Offset = "0x20")]
	private static Action _003C_003Ef__am_0024cache10;

	[Token(Token = "0x17000668")]
	public DTPartyInfo PartyData
	{
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x19B6B60", Offset = "0x19B6B60", VA = "0x19B6B60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x19B6B68", Offset = "0x19B6B68", VA = "0x19B6B68")]
		private set
		{
		}
	}

	[Token(Token = "0x6002833")]
	[Address(RVA = "0x19B6890", Offset = "0x19B6890", VA = "0x19B6890")]
	public XFriendPartySystem()
	{
	}

	[Token(Token = "0x6002837")]
	[Address(RVA = "0x19B6B70", Offset = "0x19B6B70", VA = "0x19B6B70")]
	public void ClearInviteUI()
	{
	}

	[Token(Token = "0x6002838")]
	[Address(RVA = "0x19B6B7C", Offset = "0x19B6B7C", VA = "0x19B6B7C")]
	public void InitInviteUI(IGroupInviteMsgPopup inviteUI)
	{
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0x19B6B84", Offset = "0x19B6B84", VA = "0x19B6B84")]
	public void Clear()
	{
	}

	[Token(Token = "0x600283A")]
	[Address(RVA = "0x19B6C9C", Offset = "0x19B6C9C", VA = "0x19B6C9C")]
	public void Update(float delta)
	{
	}

	[Token(Token = "0x600283B")]
	[Address(RVA = "0x19B6D10", Offset = "0x19B6D10", VA = "0x19B6D10")]
	public bool IsMaster(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600283C")]
	[Address(RVA = "0x19B6DE0", Offset = "0x19B6DE0", VA = "0x19B6DE0")]
	public void AttachListener(IFriendPartyListener listener)
	{
	}

	[Token(Token = "0x600283D")]
	[Address(RVA = "0x19B6EB8", Offset = "0x19B6EB8", VA = "0x19B6EB8")]
	public void DetachListener(IFriendPartyListener listener)
	{
	}

	[Token(Token = "0x600283E")]
	[Address(RVA = "0x19B6F9C", Offset = "0x19B6F9C", VA = "0x19B6F9C")]
	public void DetachListenerAll()
	{
	}

	[Token(Token = "0x600283F")]
	[Address(RVA = "0x19B7034", Offset = "0x19B7034", VA = "0x19B7034")]
	public bool IsExistPartyData()
	{
		return default(bool);
	}

	[Token(Token = "0x6002840")]
	[Address(RVA = "0x19B7044", Offset = "0x19B7044", VA = "0x19B7044")]
	public void UpdatePartyData(DTPartyInfo partyData)
	{
	}

	[Token(Token = "0x6002841")]
	[Address(RVA = "0x198E9D0", Offset = "0x198E9D0", VA = "0x198E9D0")]
	public bool TryGetPartyData(out DTPartyInfo outPartyData)
	{
		outPartyData = default;
		return default(bool);
	}

	[Token(Token = "0x6002842")]
	[Address(RVA = "0x198E9F0", Offset = "0x198E9F0", VA = "0x198E9F0")]
	public bool InviteFriendToParty(string friendName, long partyKey)
	{
		return default(bool);
	}

	[Token(Token = "0x6002843")]
	[Address(RVA = "0x19B7140", Offset = "0x19B7140", VA = "0x19B7140")]
	public void ReceiveGameInviation(string sponsor, long partyKey)
	{
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0x19B75A0", Offset = "0x19B75A0", VA = "0x19B75A0")]
	public bool AcceptGameInviation(string sponsor, long partyKey)
	{
		return default(bool);
	}

	[Token(Token = "0x6002845")]
	[Address(RVA = "0x19B781C", Offset = "0x19B781C", VA = "0x19B781C")]
	internal void ReceiveAcceptPartyInviation(string accepter)
	{
	}

	[Token(Token = "0x6002846")]
	[Address(RVA = "0x19B7438", Offset = "0x19B7438", VA = "0x19B7438")]
	private void RefuseGameInviation(string sponsor, int refuseType)
	{
	}

	[Token(Token = "0x6002847")]
	[Address(RVA = "0x19B7AB0", Offset = "0x19B7AB0", VA = "0x19B7AB0")]
	public void ReceiveRefuseGameInvitation(string refuser, int refuseType)
	{
	}

	[Token(Token = "0x6002848")]
	[Address(RVA = "0x19B7DAC", Offset = "0x19B7DAC", VA = "0x19B7DAC")]
	public void NotifyCreatedRoom(string sender, string roomName)
	{
	}

	[Token(Token = "0x6002849")]
	[Address(RVA = "0x19B80E0", Offset = "0x19B80E0", VA = "0x19B80E0")]
	internal void ReceiveNotifyCreatedRoom(string senderer, string roomName)
	{
	}

	[Token(Token = "0x600284A")]
	[Address(RVA = "0x19B8110", Offset = "0x19B8110", VA = "0x19B8110")]
	internal void ReserveVisibleRoom()
	{
	}

	[Token(Token = "0x600284B")]
	[Address(RVA = "0x19B8114", Offset = "0x19B8114", VA = "0x19B8114")]
	public void RunVisibleRoom()
	{
	}

	[Token(Token = "0x600284C")]
	[Address(RVA = "0x198E4B8", Offset = "0x198E4B8", VA = "0x198E4B8")]
	public bool CreateParty(XGameModeType gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x600284D")]
	[Address(RVA = "0x19B838C", Offset = "0x19B838C", VA = "0x19B838C")]
	public bool LeaveParty()
	{
		return default(bool);
	}

	[Token(Token = "0x600284E")]
	[Address(RVA = "0x19B84F4", Offset = "0x19B84F4", VA = "0x19B84F4", Slot = "4")]
	public void OnCreateParty(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x600284F")]
	[Address(RVA = "0x19B86E8", Offset = "0x19B86E8", VA = "0x19B86E8", Slot = "5")]
	public void OnJoinParty(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6002850")]
	[Address(RVA = "0x19B87D0", Offset = "0x19B87D0", VA = "0x19B87D0", Slot = "6")]
	public void OnLeaveParty()
	{
	}

	[Token(Token = "0x6002851")]
	[Address(RVA = "0x19B87D4", Offset = "0x19B87D4", VA = "0x19B87D4", Slot = "7")]
	public void OnLeavePartyNotify(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6002852")]
	[Address(RVA = "0x198ECD0", Offset = "0x198ECD0", VA = "0x198ECD0")]
	public bool StartPartyGame(int sectorID, XGameModeType gameMode, MatchType matchType)
	{
		return default(bool);
	}

	[Token(Token = "0x6002853")]
	[Address(RVA = "0x19B89D0", Offset = "0x19B89D0", VA = "0x19B89D0", Slot = "8")]
	public void OnStartPartyGame(bool isSuccess)
	{
	}

	[Token(Token = "0x6002854")]
	[Address(RVA = "0x19B8AA8", Offset = "0x19B8AA8", VA = "0x19B8AA8", Slot = "9")]
	public void OnStartPartyGameNotify(action createOrJoin, string roomName, int sectorID, XGameModeType gameMode, MatchType matchType)
	{
	}

	[Token(Token = "0x6002855")]
	[Address(RVA = "0x19B9274", Offset = "0x19B9274", VA = "0x19B9274", Slot = "10")]
	public void OnBreakPartyNotify()
	{
	}

	[Token(Token = "0x6002856")]
	[Address(RVA = "0x19B9460", Offset = "0x19B9460", VA = "0x19B9460", Slot = "11")]
	public void OnUpdatePartyNotify(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6002857")]
	[Address(RVA = "0x19B9464", Offset = "0x19B9464", VA = "0x19B9464", Slot = "12")]
	public void OnUpdatePlayerState()
	{
	}

	[Token(Token = "0x6002858")]
	[Address(RVA = "0x19B9468", Offset = "0x19B9468", VA = "0x19B9468")]
	public bool ChangeReadyState(bool isReady)
	{
		return default(bool);
	}

	[Token(Token = "0x6002859")]
	[Address(RVA = "0x19B95D8", Offset = "0x19B95D8", VA = "0x19B95D8", Slot = "13")]
	public void OnChangeReadyState()
	{
	}

	[Token(Token = "0x600285A")]
	[Address(RVA = "0x19B95DC", Offset = "0x19B95DC", VA = "0x19B95DC")]
	public bool ChangePartyInfoState(XGameModeType gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x600285B")]
	[Address(RVA = "0x19B974C", Offset = "0x19B974C", VA = "0x19B974C", Slot = "14")]
	public void OnChangePartyInfoState()
	{
	}

	[Token(Token = "0x600285C")]
	[Address(RVA = "0x19B9750", Offset = "0x19B9750", VA = "0x19B9750")]
	private void OnChangeGameMode(XGameModeType gameMode)
	{
	}

	[Token(Token = "0x600285D")]
	[Address(RVA = "0x19B977C", Offset = "0x19B977C", VA = "0x19B977C", Slot = "16")]
	public void OnChangePartyInfoStateNotify(XGameModeType gameMode)
	{
	}

	[Token(Token = "0x600285E")]
	[Address(RVA = "0x19B98CC", Offset = "0x19B98CC", VA = "0x19B98CC", Slot = "15")]
	public void OnUpdatePartyMemberInfo(NetMatchPlayerInfo player)
	{
	}

	[Token(Token = "0x600285F")]
	[Address(RVA = "0x19B9A48", Offset = "0x19B9A48", VA = "0x19B9A48")]
	public void OnInGameStart()
	{
	}

	[Token(Token = "0x6002860")]
	[Address(RVA = "0x19B9A74", Offset = "0x19B9A74", VA = "0x19B9A74")]
	public bool CheckMustVisibleTheRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6002861")]
	[Address(RVA = "0x19B9D00", Offset = "0x19B9D00", VA = "0x19B9D00")]
	public bool IsWaitingForFriendToEnterRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6002862")]
	[Address(RVA = "0x19B9F58", Offset = "0x19B9F58", VA = "0x19B9F58", Slot = "19")]
	public void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002863")]
	[Address(RVA = "0x19B9F5C", Offset = "0x19B9F5C", VA = "0x19B9F5C", Slot = "17")]
	public void OnPhotonPlayerConnected(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002864")]
	[Address(RVA = "0x19B9F60", Offset = "0x19B9F60", VA = "0x19B9F60")]
	internal void AddPlayerInRoomWithReady(XPlayer player)
	{
	}

	[Token(Token = "0x6002865")]
	[Address(RVA = "0x19BA3B4", Offset = "0x19BA3B4", VA = "0x19BA3B4", Slot = "18")]
	public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
	{
	}

	[Token(Token = "0x6002866")]
	[Address(RVA = "0x19BAE04", Offset = "0x19BAE04", VA = "0x19BAE04", Slot = "20")]
	public void OnDisconnectedFromPhoton()
	{
	}

	[Token(Token = "0x6002867")]
	[Address(RVA = "0x19BAFF4", Offset = "0x19BAFF4", VA = "0x19BAFF4", Slot = "21")]
	public void OnDisconnectedFromPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6002868")]
	[Address(RVA = "0x19BAE08", Offset = "0x19BAE08", VA = "0x19BAE08")]
	private void ProcessDisconnectedFromPhoton()
	{
	}

	[Token(Token = "0x6002869")]
	[Address(RVA = "0x19BAFF8", Offset = "0x19BAFF8", VA = "0x19BAFF8", Slot = "22")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x600286A")]
	[Address(RVA = "0x19BB5DC", Offset = "0x19BB5DC", VA = "0x19BB5DC")]
	public bool IsLatelyPlayedFriend(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600286B")]
	[Address(RVA = "0x19BB67C", Offset = "0x19BB67C", VA = "0x19BB67C")]
	internal bool TryResponseError(OperationResponse response)
	{
		return default(bool);
	}

	[Token(Token = "0x600286C")]
	[Address(RVA = "0x19BB9B0", Offset = "0x19BB9B0", VA = "0x19BB9B0")]
	internal void CleanupEscapedMembers(XPlayerManager clonePlayerManager)
	{
	}

	[Token(Token = "0x600286D")]
	[Address(RVA = "0x19BAA04", Offset = "0x19BAA04", VA = "0x19BAA04")]
	private void ShowFriendExitPopup(string leavePlayers)
	{
	}

	[Token(Token = "0x600286E")]
	[Address(RVA = "0x19BBB80", Offset = "0x19BBB80", VA = "0x19BBB80")]
	private void _003CXFriendPartySystem_003Em__DA(float deltaTime)
	{
	}

	[Token(Token = "0x600286F")]
	[Address(RVA = "0x19BBB84", Offset = "0x19BBB84", VA = "0x19BBB84")]
	private void _003CUpdatePartyData_003Em__DB(IFriendPartyListener listner)
	{
	}

	[Token(Token = "0x6002870")]
	[Address(RVA = "0x19BBC90", Offset = "0x19BBC90", VA = "0x19BBC90")]
	private static void _003COnCreateParty_003Em__E0(IFriendPartyListener listner)
	{
	}

	[Token(Token = "0x6002871")]
	[Address(RVA = "0x19BBD94", Offset = "0x19BBD94", VA = "0x19BBD94")]
	private static void _003COnLeavePartyNotify_003Em__E1(IFriendPartyListener listner)
	{
	}

	[Token(Token = "0x6002872")]
	[Address(RVA = "0x19BBE98", Offset = "0x19BBE98", VA = "0x19BBE98")]
	private static void _003CStartPartyGame_003Em__E3()
	{
	}

	[Token(Token = "0x6002873")]
	[Address(RVA = "0x19BBF64", Offset = "0x19BBF64", VA = "0x19BBF64")]
	private static string _003COnStartPartyGameNotify_003Em__E4(NetMatchPlayerInfo item)
	{
		return null;
	}

	[Token(Token = "0x6002874")]
	[Address(RVA = "0x19BBF90", Offset = "0x19BBF90", VA = "0x19BBF90")]
	private static int _003COnStartPartyGameNotify_003Em__E5(NetMatchPlayerInfo item)
	{
		return default(int);
	}

	[Token(Token = "0x6002875")]
	[Address(RVA = "0x19BBFBC", Offset = "0x19BBFBC", VA = "0x19BBFBC")]
	private static void _003COnBreakPartyNotify_003Em__E6(IFriendPartyListener listner)
	{
	}

	[Token(Token = "0x6002876")]
	[Address(RVA = "0x19BC0C0", Offset = "0x19BC0C0", VA = "0x19BC0C0")]
	private static void _003CProcessDisconnectedFromPhoton_003Em__EA(IFriendPartyListener listner)
	{
	}

	[Token(Token = "0x6002877")]
	[Address(RVA = "0x19BC1C8", Offset = "0x19BC1C8", VA = "0x19BC1C8")]
	private static void _003CShowFriendExitPopup_003Em__EB()
	{
	}
}
