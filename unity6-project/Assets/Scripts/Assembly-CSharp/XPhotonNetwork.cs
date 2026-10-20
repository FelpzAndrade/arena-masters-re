using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon;
using UnityEngine;
using XCasualModeLogic;
using XCasualModeLogic.PoliceVsThief;

[Token(Token = "0x200084C")]
public class XPhotonNetwork : Photon.MonoBehaviour
{
	[Token(Token = "0x200084D")]
	public class PhotonDebugLog : CSPoolEntry
	{
		[Token(Token = "0x40023E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40023E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float time;

		[Token(Token = "0x40023E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x60044E3")]
		[Address(RVA = "0xB20008", Offset = "0xB20008", VA = "0xB20008")]
		public PhotonDebugLog()
		{
		}

		[Token(Token = "0x60044E4")]
		[Address(RVA = "0xB20010", Offset = "0xB20010", VA = "0xB20010", Slot = "4")]
		public void OnCleanupInObjectPool()
		{
		}
	}

	[Token(Token = "0x40023D2")]
	private const float m_fHideAndSeekJudgmentTime = 0.5f;

	[Token(Token = "0x40023D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public List<XPhotonStats> m_rpcBytes_Send;

	[Token(Token = "0x40023D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	public List<XPhotonStats> m_rpcBytes_Recv;

	[Token(Token = "0x40023D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XMatchMakingJoiner m_MatchMakingJoiner;

	[Token(Token = "0x40023D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private XPhotonNetworkRoundTrip netRoundTrip;

	[Token(Token = "0x40023D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Queue<PhotonDebugLog> m_quDebugPhotonEventLog;

	[Token(Token = "0x40023D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private HashSet<IPhotonPlayerConnectListener> m_PlayerConnectListener;

	[Token(Token = "0x40023D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Regulator ProfileUpdate;

	[Token(Token = "0x40023DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private XPhotonNetworkRequestHello m_netRequestHello;

	[Token(Token = "0x40023DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private double m_lastTime;

	[Token(Token = "0x40023DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_wrapCount;

	[Token(Token = "0x40023DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly double m_wrapSize;

	[Token(Token = "0x40023DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action m_onLeftRoonComplete;

	[Token(Token = "0x40023DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool m_isDisableHideAndSeekJudgmentTime;

	[Token(Token = "0x40023E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_fHideAndSeekJudgmentElapsedTime;

	[Token(Token = "0x40023E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private ICasualModeEventReceiver casualModeEventReceiver;

	[Token(Token = "0x40023E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XPhotonErrorHandler ErrorHandler;

	[Token(Token = "0x40023E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapE;

	[Token(Token = "0x40023E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Func<Hashtable, MatchPlayerInfo> _003C_003Ef__am_0024cache11;

	[Token(Token = "0x40023E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache12;

	[Token(Token = "0x40023E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache13;

	[Token(Token = "0x17000966")]
	public XPhotonNetworkRequestHello NetRequestHello
	{
		[Token(Token = "0x6004433")]
		[Address(RVA = "0xB0B534", Offset = "0xB0B534", VA = "0xB0B534")]
		private get
		{
			return null;
		}
		[Token(Token = "0x6004434")]
		[Address(RVA = "0xB091F0", Offset = "0xB091F0", VA = "0xB091F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000967")]
	public float ServerTime
	{
		[Token(Token = "0x6004435")]
		[Address(RVA = "0xB03218", Offset = "0xB03218", VA = "0xB03218")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6004432")]
	[Address(RVA = "0xB0B2A8", Offset = "0xB0B2A8", VA = "0xB0B2A8")]
	public XPhotonNetwork()
	{
	}

	[Token(Token = "0x6004436")]
	[Address(RVA = "0xB03170", Offset = "0xB03170", VA = "0xB03170")]
	public void AddStats_Send(string name, PhotonTargets target, params object[] args)
	{
	}

	[Token(Token = "0x6004437")]
	[Address(RVA = "0xB031A4", Offset = "0xB031A4", VA = "0xB031A4")]
	public void AddStats_Send(string name, params object[] args)
	{
	}

	[Token(Token = "0x6004438")]
	[Address(RVA = "0xB031D8", Offset = "0xB031D8", VA = "0xB031D8")]
	public void AddStats_Recv(string name, params object[] args)
	{
	}

	[Token(Token = "0x6004439")]
	[Address(RVA = "0xB03624", Offset = "0xB03624", VA = "0xB03624")]
	public void PushSendPhotonEventLog(string name)
	{
	}

	[Token(Token = "0x600443A")]
	[Address(RVA = "0xB05200", Offset = "0xB05200", VA = "0xB05200")]
	public void PushRecvPhotonEventLog(string name)
	{
	}

	[Token(Token = "0x600443B")]
	[Address(RVA = "0xB0B808", Offset = "0xB0B808", VA = "0xB0B808")]
	public void UpdatePhotonEventLogCount()
	{
	}

	[Token(Token = "0x600443C")]
	[Address(RVA = "0xB095C0", Offset = "0xB095C0", VA = "0xB095C0")]
	public string GetRPCDebugLog()
	{
		return null;
	}

	[Token(Token = "0x600443D")]
	[Address(RVA = "0xB0BB3C", Offset = "0xB0BB3C", VA = "0xB0BB3C")]
	private Queue<string> MakeErrorList()
	{
		return null;
	}

	[Token(Token = "0x600443E")]
	[Address(RVA = "0xB0BE1C", Offset = "0xB0BE1C", VA = "0xB0BE1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600443F")]
	[Address(RVA = "0xB0C0E4", Offset = "0xB0C0E4", VA = "0xB0C0E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6004440")]
	[Address(RVA = "0xAF467C", Offset = "0xAF467C", VA = "0xAF467C")]
	public int GetPing()
	{
		return default(int);
	}

	[Token(Token = "0x6004441")]
	[Address(RVA = "0xB0D2D8", Offset = "0xB0D2D8", VA = "0xB0D2D8")]
	private void OnConnectedToPhoton()
	{
	}

	[Token(Token = "0x6004442")]
	[Address(RVA = "0xB0D610", Offset = "0xB0D610", VA = "0xB0D610")]
	private void OnEvent(byte eventCode, object content, int senderId)
	{
	}

	[Token(Token = "0x6004443")]
	[Address(RVA = "0xB0D998", Offset = "0xB0D998", VA = "0xB0D998")]
	private void OnJoinedLobby()
	{
	}

	[Token(Token = "0x6004444")]
	[Address(RVA = "0xB0DAF4", Offset = "0xB0DAF4", VA = "0xB0DAF4")]
	private void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x6004445")]
	[Address(RVA = "0xB0DCA4", Offset = "0xB0DCA4", VA = "0xB0DCA4")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6004446")]
	[Address(RVA = "0xB0DE50", Offset = "0xB0DE50", VA = "0xB0DE50")]
	private void OnPhotonRandomJoinFailed()
	{
	}

	[Token(Token = "0x6004447")]
	[Address(RVA = "0xB0DFAC", Offset = "0xB0DFAC", VA = "0xB0DFAC")]
	private void OnCreatedRoom()
	{
	}

	[Token(Token = "0x6004448")]
	[Address(RVA = "0xB0E108", Offset = "0xB0E108", VA = "0xB0E108")]
	private void OnPhotonCreateRoomFailed(object[] codeAndMsg)
	{
	}

	[Token(Token = "0x6004449")]
	[Address(RVA = "0xB0E26C", Offset = "0xB0E26C", VA = "0xB0E26C")]
	private void OnPhotonJoinRoomFailed(object[] result)
	{
	}

	[Token(Token = "0x600444A")]
	[Address(RVA = "0xB0E3D0", Offset = "0xB0E3D0", VA = "0xB0E3D0")]
	private void OnJoinedRoom()
	{
	}

	[Token(Token = "0x600444B")]
	[Address(RVA = "0xB0E678", Offset = "0xB0E678", VA = "0xB0E678")]
	private void OnWebRpcResponse(OperationResponse response)
	{
	}

	[Token(Token = "0x600444C")]
	[Address(RVA = "0xB0E900", Offset = "0xB0E900", VA = "0xB0E900")]
	private void OnMatchMakingSuccess(OperationResponse response)
	{
	}

	[Token(Token = "0x600444D")]
	[Address(RVA = "0xB0F70C", Offset = "0xB0F70C", VA = "0xB0F70C")]
	private void OnMatchMakingTimeout(OperationResponse response)
	{
	}

	[Token(Token = "0x600444E")]
	[Address(RVA = "0xAFD340", Offset = "0xAFD340", VA = "0xAFD340")]
	public void InitGame()
	{
	}

	[Token(Token = "0x600444F")]
	[Address(RVA = "0xB090CC", Offset = "0xB090CC", VA = "0xB090CC")]
	public void SyncToMasterClient()
	{
	}

	[Token(Token = "0x6004450")]
	[Address(RVA = "0xB0FE20", Offset = "0xB0FE20", VA = "0xB0FE20")]
	[PunRPC]
	public void _SyncToMasterClient(int nTargetPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004451")]
	[Address(RVA = "0xB0FE8C", Offset = "0xB0FE8C", VA = "0xB0FE8C")]
	public void SetEnableMatchMakingJoiner(bool isEnable)
	{
	}

	[Token(Token = "0x6004452")]
	[Address(RVA = "0xB0FEB8", Offset = "0xB0FEB8", VA = "0xB0FEB8")]
	[PunRPC]
	private void _HelloToMasterClient(int nTargetPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004453")]
	[Address(RVA = "0xB0FF24", Offset = "0xB0FF24", VA = "0xB0FF24")]
	[PunRPC]
	private void _DefectorRejoined(int target_photon_id, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004454")]
	[Address(RVA = "0xB100D0", Offset = "0xB100D0", VA = "0xB100D0")]
	[PunRPC]
	public void _WelcomeAgain(NetData_Record[] records, NetData_TeamInfo[] teamInfos, int MasterClientPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004455")]
	[Address(RVA = "0xB10218", Offset = "0xB10218", VA = "0xB10218")]
	[PunRPC]
	public void _RequestHelloAll(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004456")]
	[Address(RVA = "0xB10274", Offset = "0xB10274", VA = "0xB10274")]
	private void OnFailedToConnectToPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6004457")]
	[Address(RVA = "0xB10624", Offset = "0xB10624", VA = "0xB10624")]
	private void OnConnectionFail(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6004458")]
	[Address(RVA = "0xB10A58", Offset = "0xB10A58", VA = "0xB10A58")]
	private void OnDisconnectedFromPhoton()
	{
	}

	[Token(Token = "0x6004459")]
	[Address(RVA = "0xB10E38", Offset = "0xB10E38", VA = "0xB10E38")]
	private void OnDisconnectedFromPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x600445A")]
	[Address(RVA = "0xB11510", Offset = "0xB11510", VA = "0xB11510")]
	public void OnPhotonPlayerConnected(PhotonPlayer player)
	{
	}

	[Token(Token = "0x600445B")]
	[Address(RVA = "0xB116D8", Offset = "0xB116D8", VA = "0xB116D8")]
	public void OnPhotonPlayerDisconnected(PhotonPlayer player)
	{
	}

	[Token(Token = "0x600445C")]
	[Address(RVA = "0xAFA1DC", Offset = "0xAFA1DC", VA = "0xAFA1DC")]
	public bool LeaveRoom(Action onLeftRoomComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x600445D")]
	[Address(RVA = "0xB11E18", Offset = "0xB11E18", VA = "0xB11E18")]
	public void OnLeftRoom()
	{
	}

	[Token(Token = "0x600445E")]
	[Address(RVA = "0xB11E44", Offset = "0xB11E44", VA = "0xB11E44")]
	public void OnReceivedRoomListUpdate()
	{
	}

	[Token(Token = "0x600445F")]
	[Address(RVA = "0xB11F2C", Offset = "0xB11F2C", VA = "0xB11F2C")]
	public RoomInfo[] GetRoomList()
	{
		return null;
	}

	[Token(Token = "0x6004460")]
	[Address(RVA = "0xB11FCC", Offset = "0xB11FCC", VA = "0xB11FCC")]
	public void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6004461")]
	[Address(RVA = "0xB12404", Offset = "0xB12404", VA = "0xB12404")]
	public void OnPhotonInstantiate(PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6004462")]
	[Address(RVA = "0xB12408", Offset = "0xB12408", VA = "0xB12408")]
	public void OnUpdatedFriendList()
	{
	}

	[Token(Token = "0x6004463")]
	[Address(RVA = "0xAFD7F4", Offset = "0xAFD7F4", VA = "0xAFD7F4")]
	public void ChangeGameModeState(XGameModeStateType nGameModeState)
	{
	}

	[Token(Token = "0x6004464")]
	[Address(RVA = "0xB12648", Offset = "0xB12648", VA = "0xB12648")]
	[PunRPC]
	public void _ChangeGameModeState(int nGameModeState, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004465")]
	[Address(RVA = "0xB08AC8", Offset = "0xB08AC8", VA = "0xB08AC8")]
	public void GameFinishWithoutWebServer()
	{
	}

	[Token(Token = "0x6004466")]
	[Address(RVA = "0xB127F4", Offset = "0xB127F4", VA = "0xB127F4")]
	[PunRPC]
	public void _GameFinishWithoutWebServer(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004467")]
	[Address(RVA = "0xAFA840", Offset = "0xAFA840", VA = "0xAFA840")]
	public void C_ReqRoomInfo()
	{
	}

	[Token(Token = "0x6004468")]
	[Address(RVA = "0xB12B34", Offset = "0xB12B34", VA = "0xB12B34")]
	[PunRPC]
	public void _C_ReqRoomInfo(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004469")]
	[Address(RVA = "0xAFDF00", Offset = "0xAFDF00", VA = "0xAFDF00")]
	public void MC_SyncRoomInfo()
	{
	}

	[Token(Token = "0x600446A")]
	[Address(RVA = "0xB12BF4", Offset = "0xB12BF4", VA = "0xB12BF4")]
	[PunRPC]
	public void _MC_SyncRoomInfo(short nGameModeType, short nGameModeState, float startTime, short wrapCount, float remainedTime, NetData_DropObjectSpawnedInfo[] dropObjectSpawnedInfos, NetData_GimmickWorkingInfo gimmickWorkingInfo, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600446B")]
	[Address(RVA = "0xAFC47C", Offset = "0xAFC47C", VA = "0xAFC47C")]
	public void SendMsg(string strMsg, float duration = 1f, bool isTitleMessage = false, string msgSoundName = "", bool isUseLocaleKey = false)
	{
	}

	[Token(Token = "0x600446C")]
	[Address(RVA = "0xB13188", Offset = "0xB13188", VA = "0xB13188")]
	[PunRPC]
	public void _SendMsg(string strMsg, float duration, bool isTitleMessage, string msgSoundName, bool isUseLocaleKey, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600446D")]
	[Address(RVA = "0xAFCC34", Offset = "0xAFCC34", VA = "0xAFCC34")]
	public void SendIngameCustonMessage(string strMsgKey, float duration)
	{
	}

	[Token(Token = "0x600446E")]
	[Address(RVA = "0xB135D8", Offset = "0xB135D8", VA = "0xB135D8")]
	[PunRPC]
	public void _SendIngameCustonMessage(string strMsgKey, float duration, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600446F")]
	[Address(RVA = "0xAFD114", Offset = "0xAFD114", VA = "0xAFD114")]
	public void ShowRelayMatchGameStartUI(int round)
	{
	}

	[Token(Token = "0x6004470")]
	[Address(RVA = "0xB13838", Offset = "0xB13838", VA = "0xB13838")]
	[PunRPC]
	public void _ShowRelayMatchGameStartUI(int round, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004471")]
	[Address(RVA = "0xB13A38", Offset = "0xB13A38", VA = "0xB13A38")]
	private bool CheckMIAndIsInGame(PhotonMessageInfo mi)
	{
		return default(bool);
	}

	[Token(Token = "0x6004472")]
	[Address(RVA = "0xB13AE8", Offset = "0xB13AE8", VA = "0xB13AE8")]
	private void ShowMessage(bool isTitleMessage, string strMsg)
	{
	}

	[Token(Token = "0x6004473")]
	[Address(RVA = "0xAFAFC8", Offset = "0xAFAFC8", VA = "0xAFAFC8")]
	public void SendWhiteMsg(string strMsg, bool isTitleMessage = false)
	{
	}

	[Token(Token = "0x6004474")]
	[Address(RVA = "0xB13D20", Offset = "0xB13D20", VA = "0xB13D20")]
	[PunRPC]
	public void _SendWhiteMsg(string strMsg, bool isTitleMessage, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004475")]
	[Address(RVA = "0xAFACAC", Offset = "0xAFACAC", VA = "0xAFACAC")]
	public void SendWhiteMsg(string strMsgKey, int nCount, bool isTitleMessage = false)
	{
	}

	[Token(Token = "0x6004476")]
	[Address(RVA = "0xB13EDC", Offset = "0xB13EDC", VA = "0xB13EDC")]
	[PunRPC]
	public void _SendWhiteMsg(string strMsgKey, int nCount, bool isTitleMessage, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004477")]
	[Address(RVA = "0xAFB580", Offset = "0xAFB580", VA = "0xAFB580")]
	internal void SendReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6004478")]
	[Address(RVA = "0xB1416C", Offset = "0xB1416C", VA = "0xB1416C")]
	[PunRPC]
	public void _SendReadyTimeoutMessage(int _nCounter, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004479")]
	[Address(RVA = "0xAFB7B4", Offset = "0xAFB7B4", VA = "0xAFB7B4")]
	internal void SendReadyTimeout()
	{
	}

	[Token(Token = "0x600447A")]
	[Address(RVA = "0xB143AC", Offset = "0xB143AC", VA = "0xB143AC")]
	[PunRPC]
	public void _SendReadyTimeout(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600447B")]
	[Address(RVA = "0xAFB908", Offset = "0xAFB908", VA = "0xAFB908")]
	internal void SendUpdatedPing(int ping)
	{
	}

	[Token(Token = "0x600447C")]
	[Address(RVA = "0xB1454C", Offset = "0xB1454C", VA = "0xB1454C")]
	[PunRPC]
	public void _SendUpdatedPing(short ping, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600447D")]
	[Address(RVA = "0xAFBC6C", Offset = "0xAFBC6C", VA = "0xAFBC6C")]
	public void RequestChat(XChatMsgType chatMsgType, string strName, string strMsg)
	{
	}

	[Token(Token = "0x600447E")]
	[Address(RVA = "0xB14758", Offset = "0xB14758", VA = "0xB14758")]
	[PunRPC]
	public void _Chat(int chatMsgType, string strName, string strMsg, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600447F")]
	[Address(RVA = "0xAFBEA4", Offset = "0xAFBEA4", VA = "0xAFBEA4")]
	public void RequestIngameChat(int id1, int id2, string strName, string strMsg)
	{
	}

	[Token(Token = "0x6004480")]
	[Address(RVA = "0xB14B98", Offset = "0xB14B98", VA = "0xB14B98")]
	[PunRPC]
	public void _IngameChat(int id1, int id2, string strName, string strMsg, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004481")]
	[Address(RVA = "0xB15070", Offset = "0xB15070", VA = "0xB15070")]
	public void SetWinnerPlayer(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6004482")]
	[Address(RVA = "0xB152BC", Offset = "0xB152BC", VA = "0xB152BC")]
	[PunRPC]
	public void _SetWinnerPlayer(int nWinnerPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004483")]
	[Address(RVA = "0xB154B4", Offset = "0xB154B4", VA = "0xB154B4")]
	public void SetWinnerTeam(int nWinnerTeamID)
	{
	}

	[Token(Token = "0x6004484")]
	[Address(RVA = "0xB15700", Offset = "0xB15700", VA = "0xB15700")]
	[PunRPC]
	public void _SetWinnerTeam(int nWinnerTeamID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004485")]
	[Address(RVA = "0xAFEBB4", Offset = "0xAFEBB4", VA = "0xAFEBB4")]
	public void SetTeam(int nTargetPhotonID, int nTeamID)
	{
	}

	[Token(Token = "0x6004486")]
	[Address(RVA = "0xB158F8", Offset = "0xB158F8", VA = "0xB158F8")]
	[PunRPC]
	public void _SetTeam(int nTargetPhotonID, int nTeamID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004487")]
	[Address(RVA = "0xB09228", Offset = "0xB09228", VA = "0xB09228")]
	public void DivideTeam(NetData_PlayerTeamSetting netDataPlayerTeam)
	{
	}

	[Token(Token = "0x6004488")]
	[Address(RVA = "0xB15B58", Offset = "0xB15B58", VA = "0xB15B58")]
	[PunRPC]
	public void _DivideTeam(NetData_PlayerTeamSetting netDataPlayerTeam, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004489")]
	[Address(RVA = "0xB00518", Offset = "0xB00518", VA = "0xB00518")]
	public void SetMasterZombie(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x600448A")]
	[Address(RVA = "0xB15FA0", Offset = "0xB15FA0", VA = "0xB15FA0")]
	[PunRPC]
	public void _SetMasterZombie(int nTargetPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600448B")]
	[Address(RVA = "0xB161B4", Offset = "0xB161B4", VA = "0xB161B4")]
	private bool IsDisableHideAndSeekJudgmentTime()
	{
		return default(bool);
	}

	[Token(Token = "0x600448C")]
	[Address(RVA = "0xB0D1F4", Offset = "0xB0D1F4", VA = "0xB0D1F4")]
	private void UpdateHideAndSeekJudgmentTime(float deltaTime)
	{
	}

	[Token(Token = "0x600448D")]
	[Address(RVA = "0xB0083C", Offset = "0xB0083C", VA = "0xB0083C")]
	public void SetTagger(int nTargetPhotonID, bool ignoreJudgementTime, int itemID)
	{
	}

	[Token(Token = "0x600448E")]
	[Address(RVA = "0xB161BC", Offset = "0xB161BC", VA = "0xB161BC")]
	private void TaggerCustomEvent(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x600448F")]
	[Address(RVA = "0xB16554", Offset = "0xB16554", VA = "0xB16554")]
	[PunRPC]
	public void _SetTagger(int nTargetPhotonID, int itemID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004490")]
	[Address(RVA = "0xB00C9C", Offset = "0xB00C9C", VA = "0xB00C9C")]
	public void RequestTaggerChooseToMasterClient(int ignoreChoosePhotonID, int itemID, bool isDieEvent)
	{
	}

	[Token(Token = "0x6004491")]
	[Address(RVA = "0xB167D4", Offset = "0xB167D4", VA = "0xB167D4")]
	[PunRPC]
	public void _RequestTaggerChooseToMasterClient(int ignoreChoosePhotonID, int itemID, bool isDieEvent, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004492")]
	[Address(RVA = "0xB01C40", Offset = "0xB01C40", VA = "0xB01C40")]
	public void Annihilation_StartRound(int nRound)
	{
	}

	[Token(Token = "0x6004493")]
	[Address(RVA = "0xB16ACC", Offset = "0xB16ACC", VA = "0xB16ACC")]
	[PunRPC]
	public void _Annihilation_StartRound(int nRound, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004494")]
	[Address(RVA = "0xB02FD0", Offset = "0xB02FD0", VA = "0xB02FD0")]
	public void Annihilation_SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6004495")]
	[Address(RVA = "0xB170E4", Offset = "0xB170E4", VA = "0xB170E4")]
	[PunRPC]
	public void _Annihilation_SendLoseLifePlayer(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004496")]
	[Address(RVA = "0xB013C8", Offset = "0xB013C8", VA = "0xB013C8")]
	public void StartRound(int nRound)
	{
	}

	[Token(Token = "0x6004497")]
	[Address(RVA = "0xB17618", Offset = "0xB17618", VA = "0xB17618")]
	[PunRPC]
	public void _StartRound(int nRound, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6004498")]
	[Address(RVA = "0xB0166C", Offset = "0xB0166C", VA = "0xB0166C")]
	public void SendRoundResult(int nRound, int nPhotonID_0, short result_0, int nPhotonID_1, short result_1)
	{
	}

	[Token(Token = "0x6004499")]
	[Address(RVA = "0xB1782C", Offset = "0xB1782C", VA = "0xB1782C")]
	[PunRPC]
	public void _SendRoundResult(int nRound, int nPhotonID_0, short result_0, int nPhotonID_1, short result_1, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600449A")]
	[Address(RVA = "0xB01ED4", Offset = "0xB01ED4", VA = "0xB01ED4")]
	public void Annihilation_SendRoundResult(int nRound, short result_TeamA, short result_TeamB)
	{
	}

	[Token(Token = "0x600449B")]
	[Address(RVA = "0xB17C08", Offset = "0xB17C08", VA = "0xB17C08")]
	[PunRPC]
	public void _Annihilation_SendRoundResult(int nRound, short result_TeamA, short result_TeamB, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600449C")]
	[Address(RVA = "0xB02AD0", Offset = "0xB02AD0", VA = "0xB02AD0")]
	public void Annihilation_SyncGameTime(float remain_Time)
	{
	}

	[Token(Token = "0x600449D")]
	[Address(RVA = "0xB18334", Offset = "0xB18334", VA = "0xB18334")]
	[PunRPC]
	public void _Annihilation_SyncGameTime(float remain_Time, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600449E")]
	[Address(RVA = "0xB02D5C", Offset = "0xB02D5C", VA = "0xB02D5C")]
	public void Annihilation_SyncGameState(int state)
	{
	}

	[Token(Token = "0x600449F")]
	[Address(RVA = "0xB18958", Offset = "0xB18958", VA = "0xB18958")]
	[PunRPC]
	public void _Annihilation_SyncGameState(int state, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044A0")]
	[Address(RVA = "0xAFDC58", Offset = "0xAFDC58", VA = "0xAFDC58")]
	public void SyncPlayerInfo()
	{
	}

	[Token(Token = "0x60044A1")]
	[Address(RVA = "0xB192A0", Offset = "0xB192A0", VA = "0xB192A0")]
	[PunRPC]
	public void _SyncPlayerInfo(NetData_PlayerInfo playerInfo, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044A2")]
	[Address(RVA = "0xB02A64", Offset = "0xB02A64", VA = "0xB02A64")]
	public void RegisterCasualModeEventReciever(ICasualModeEventReceiver reciever)
	{
	}

	[Token(Token = "0x60044A3")]
	[Address(RVA = "0xB02A94", Offset = "0xB02A94", VA = "0xB02A94")]
	public void RemoveCasualModeEventReciever()
	{
	}

	[Token(Token = "0x60044A4")]
	[Address(RVA = "0xB02308", Offset = "0xB02308", VA = "0xB02308")]
	public void CasualMode_StartRound(int round)
	{
	}

	[Token(Token = "0x60044A5")]
	[Address(RVA = "0xB1969C", Offset = "0xB1969C", VA = "0xB1969C")]
	[PunRPC]
	public void _CasualMode_StartRound(int round)
	{
	}

	[Token(Token = "0x60044A6")]
	[Address(RVA = "0xB024A0", Offset = "0xB024A0", VA = "0xB024A0")]
	public void CasualMode_EndRound(int round, XTeamEnum winTeam)
	{
	}

	[Token(Token = "0x60044A7")]
	[Address(RVA = "0xB197B0", Offset = "0xB197B0", VA = "0xB197B0")]
	[PunRPC]
	public void _CasualMode_EndRound(int round, XTeamEnum winTeam)
	{
	}

	[Token(Token = "0x60044A8")]
	[Address(RVA = "0xB026A0", Offset = "0xB026A0", VA = "0xB026A0")]
	public void CasualMode_EndMode(XTeamEnum winTeam)
	{
	}

	[Token(Token = "0x60044A9")]
	[Address(RVA = "0xB198D0", Offset = "0xB198D0", VA = "0xB198D0")]
	[PunRPC]
	public void _CasualMode_EndMode(XTeamEnum winTeam)
	{
	}

	[Token(Token = "0x60044AA")]
	[Address(RVA = "0xB02848", Offset = "0xB02848", VA = "0xB02848")]
	public void CasualMode_SetPlayerRecord(string aid, PlayerProperty prop, object v)
	{
	}

	[Token(Token = "0x60044AB")]
	[Address(RVA = "0xB199D8", Offset = "0xB199D8", VA = "0xB199D8")]
	[PunRPC]
	public void _CasualMode_SetPlayerRecord(string aid, PlayerProperty prop, object v)
	{
	}

	[Token(Token = "0x60044AC")]
	[Address(RVA = "0xB19D2C", Offset = "0xB19D2C", VA = "0xB19D2C")]
	private void ApplyProperty(XPlayer player, PlayerProperty prop, object v)
	{
	}

	[Token(Token = "0x60044AD")]
	[Address(RVA = "0xAFE784", Offset = "0xAFE784", VA = "0xAFE784")]
	public void MC_SpawnDropObject(int nSpawnID, int nCharID, int groupIndex)
	{
	}

	[Token(Token = "0x60044AE")]
	[Address(RVA = "0xB1A034", Offset = "0xB1A034", VA = "0xB1A034")]
	[PunRPC]
	public void _MC_SpawnDropObject(int nSpawnID, int nCharID, int groupIndex, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044AF")]
	[Address(RVA = "0xAFEF1C", Offset = "0xAFEF1C", VA = "0xAFEF1C")]
	public void MC_OnEnterGimmickWorkingState(int nGimmickIndex, XMapGimmickWorkingState gimmickState)
	{
	}

	[Token(Token = "0x60044B0")]
	[Address(RVA = "0xB1A300", Offset = "0xB1A300", VA = "0xB1A300")]
	[PunRPC]
	private void MC_OnEnterGimmickWorkingState(int nGimmickIndex, XMapGimmickWorkingState gimmickState, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044B1")]
	[Address(RVA = "0xB001E8", Offset = "0xB001E8", VA = "0xB001E8")]
	public void M_CapturePointA_SyncGameModeData([Optional] PhotonPlayer photonPlayaer)
	{
	}

	[Token(Token = "0x60044B2")]
	[Address(RVA = "0xB1A5A0", Offset = "0xB1A5A0", VA = "0xB1A5A0")]
	[PunRPC]
	public void _M_CapturePointA_SyncGameModeData(NetData_CapturePointAGameModeData gameModeNetData, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044B3")]
	[Address(RVA = "0xAFF9F0", Offset = "0xAFF9F0", VA = "0xAFF9F0")]
	public void C_ReqInteractionCapturePoint(int nPointObjectIndex)
	{
	}

	[Token(Token = "0x60044B4")]
	[Address(RVA = "0xB1A7EC", Offset = "0xB1A7EC", VA = "0xB1A7EC")]
	[PunRPC]
	public void _C_ReqInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044B5")]
	[Address(RVA = "0xAFFDEC", Offset = "0xAFFDEC", VA = "0xAFFDEC")]
	public void C_ReqCancelInteractionCapturePoint(int nPointObjectIndex)
	{
	}

	[Token(Token = "0x60044B6")]
	[Address(RVA = "0xB1A968", Offset = "0xB1A968", VA = "0xB1A968")]
	[PunRPC]
	public void _C_ReqCancelInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044B7")]
	[Address(RVA = "0xAFF288", Offset = "0xAFF288", VA = "0xAFF288")]
	public void M_InteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x60044B8")]
	[Address(RVA = "0xB1AAE4", Offset = "0xB1AAE4", VA = "0xB1AAE4")]
	[PunRPC]
	public void _M_InteractionCapturePoint(int nPointObjectIndex, int nPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044B9")]
	[Address(RVA = "0xAFF690", Offset = "0xAFF690", VA = "0xAFF690")]
	public void M_CancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x60044BA")]
	[Address(RVA = "0xB1AC60", Offset = "0xB1AC60", VA = "0xB1AC60")]
	[PunRPC]
	public void _M_CancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044BB")]
	[Address(RVA = "0xB0107C", Offset = "0xB0107C", VA = "0xB0107C")]
	public void M_ZombieTag_SyncGameModeData()
	{
	}

	[Token(Token = "0x60044BC")]
	[Address(RVA = "0xB1ADDC", Offset = "0xB1ADDC", VA = "0xB1ADDC")]
	[PunRPC]
	public void _M_ZombieTag_SyncGameModeData(NetData_ZombieTagGameModeData gameModeNetData, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044BD")]
	[Address(RVA = "0xB0A4C8", Offset = "0xB0A4C8", VA = "0xB0A4C8")]
	public void CheckMyTeamToMasterClient()
	{
	}

	[Token(Token = "0x60044BE")]
	[Address(RVA = "0xB1B028", Offset = "0xB1B028", VA = "0xB1B028")]
	[PunRPC]
	public void _CheckMyTeamToMasterClient(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044BF")]
	[Address(RVA = "0xB1B244", Offset = "0xB1B244", VA = "0xB1B244")]
	[PunRPC]
	public void _RecvMyTeamFromMasterClient(byte teamInfo, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044C0")]
	[Address(RVA = "0xB0A5E8", Offset = "0xB0A5E8", VA = "0xB0A5E8")]
	public void FriendlyTeamSetting(byte teamInfo, PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x60044C1")]
	[Address(RVA = "0xB1B32C", Offset = "0xB1B32C", VA = "0xB1B32C")]
	[PunRPC]
	public void _FriendlyTeamSetting(byte teamInfo, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044C2")]
	[Address(RVA = "0xB0A844", Offset = "0xB0A844", VA = "0xB0A844")]
	public void AddAreaOfEffectBuff(int buffID, BuffTargetType eBuffTargetType)
	{
	}

	[Token(Token = "0x60044C3")]
	[Address(RVA = "0xB1B454", Offset = "0xB1B454", VA = "0xB1B454")]
	[PunRPC]
	public void _AddAreaOfEffectBuff(int buffID, BuffTargetType eBuffTargetType, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60044C4")]
	[Address(RVA = "0xB1B60C", Offset = "0xB1B60C", VA = "0xB1B60C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60044C5")]
	[Address(RVA = "0xB1B8C0", Offset = "0xB1B8C0", VA = "0xB1B8C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60044C6")]
	[Address(RVA = "0xB1BAE4", Offset = "0xB1BAE4", VA = "0xB1BAE4")]
	private void OnJoinMatch(OperationResponse response)
	{
	}

	[Token(Token = "0x60044C7")]
	[Address(RVA = "0xB1BDB8", Offset = "0xB1BDB8", VA = "0xB1BDB8")]
	private void OnCancelMatch(OperationResponse response)
	{
	}

	[Token(Token = "0x60044C8")]
	[Address(RVA = "0xB1C1F4", Offset = "0xB1C1F4", VA = "0xB1C1F4")]
	private void OnCreateClanParty(OperationResponse response)
	{
	}

	[Token(Token = "0x60044C9")]
	[Address(RVA = "0xB1C4D4", Offset = "0xB1C4D4", VA = "0xB1C4D4")]
	private void OnJoinClanParty(OperationResponse response)
	{
	}

	[Token(Token = "0x60044CA")]
	[Address(RVA = "0xB1C7B4", Offset = "0xB1C7B4", VA = "0xB1C7B4")]
	public void OnUpdateClanPartyNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044CB")]
	[Address(RVA = "0xB1CA94", Offset = "0xB1CA94", VA = "0xB1CA94")]
	private void OnLeaveClanParty(OperationResponse response)
	{
	}

	[Token(Token = "0x60044CC")]
	[Address(RVA = "0xB1CBEC", Offset = "0xB1CBEC", VA = "0xB1CBEC")]
	private void OnLeaveClanPartyNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044CD")]
	[Address(RVA = "0xB1CED0", Offset = "0xB1CED0", VA = "0xB1CED0")]
	public void OnGetClanPartyList(OperationResponse response)
	{
	}

	[Token(Token = "0x60044CE")]
	[Address(RVA = "0xB1D1B0", Offset = "0xB1D1B0", VA = "0xB1D1B0")]
	public void OnStartClanWar(OperationResponse response)
	{
	}

	[Token(Token = "0x60044CF")]
	[Address(RVA = "0xB1D294", Offset = "0xB1D294", VA = "0xB1D294")]
	public void OnClanMatchStartNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D0")]
	[Address(RVA = "0xB1D3EC", Offset = "0xB1D3EC", VA = "0xB1D3EC")]
	public void OnClanMatchCancelNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D1")]
	[Address(RVA = "0xB1D674", Offset = "0xB1D674", VA = "0xB1D674")]
	public void OnClanPartyBreakNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D2")]
	[Address(RVA = "0xB1D7DC", Offset = "0xB1D7DC", VA = "0xB1D7DC")]
	public void OnRefreshClanParty(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D3")]
	[Address(RVA = "0xB1DABC", Offset = "0xB1DABC", VA = "0xB1DABC")]
	public void OnCreateParty(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D4")]
	[Address(RVA = "0xB1DD9C", Offset = "0xB1DD9C", VA = "0xB1DD9C")]
	public void OnJoinParty(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D5")]
	[Address(RVA = "0xB1E07C", Offset = "0xB1E07C", VA = "0xB1E07C")]
	public void OnLeaveParty(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D6")]
	[Address(RVA = "0xB1E1D4", Offset = "0xB1E1D4", VA = "0xB1E1D4")]
	public void OnLeavePartyNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D7")]
	[Address(RVA = "0xB1E4B4", Offset = "0xB1E4B4", VA = "0xB1E4B4")]
	public void OnStartPartyGame(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D8")]
	[Address(RVA = "0xB1E5DC", Offset = "0xB1E5DC", VA = "0xB1E5DC")]
	public void OnStartPartyGameNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044D9")]
	[Address(RVA = "0xB1E8FC", Offset = "0xB1E8FC", VA = "0xB1E8FC")]
	public void OnBreakPartyNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044DA")]
	[Address(RVA = "0xB1EA54", Offset = "0xB1EA54", VA = "0xB1EA54")]
	public void OnUpdatePartyNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044DB")]
	[Address(RVA = "0xB1ED34", Offset = "0xB1ED34", VA = "0xB1ED34")]
	public void OnUpdatePlayerState(OperationResponse response)
	{
	}

	[Token(Token = "0x60044DC")]
	[Address(RVA = "0xB1EE8C", Offset = "0xB1EE8C", VA = "0xB1EE8C")]
	public void OnChangeReadyState(OperationResponse response)
	{
	}

	[Token(Token = "0x60044DD")]
	[Address(RVA = "0xB1EFE4", Offset = "0xB1EFE4", VA = "0xB1EFE4")]
	public void OnChangePartyInfoState(OperationResponse response)
	{
	}

	[Token(Token = "0x60044DE")]
	[Address(RVA = "0xB1F13C", Offset = "0xB1F13C", VA = "0xB1F13C")]
	public void OnChangePartyInfoStateNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044DF")]
	[Address(RVA = "0xB1F2CC", Offset = "0xB1F2CC", VA = "0xB1F2CC")]
	public void OnUpdatePartyMemberInfoNotify(OperationResponse response)
	{
	}

	[Token(Token = "0x60044E0")]
	[Address(RVA = "0xB1F5AC", Offset = "0xB1F5AC", VA = "0xB1F5AC")]
	private static MatchPlayerInfo _003COnMatchMakingSuccess_003Em__1DA(Hashtable item)
	{
		return null;
	}

	[Token(Token = "0x60044E1")]
	[Address(RVA = "0xB1FD18", Offset = "0xB1FD18", VA = "0xB1FD18")]
	private static void _003C_GameFinishWithoutWebServer_003Em__1DB()
	{
	}

	[Token(Token = "0x60044E2")]
	[Address(RVA = "0xB1FDE4", Offset = "0xB1FDE4", VA = "0xB1FDE4")]
	private static void _003COnJoinMatch_003Em__1DC()
	{
	}
}
