using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;
using XCasualModeLogic;
using XCasualModeLogic.PoliceVsThief;

[Token(Token = "0x2000841")]
public class XPhotonManager
{
	[Token(Token = "0x2000842")]
	public class PhotonNetworkOffline : IPhotonNetwork
	{
		[Token(Token = "0x40023B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool offlineMode__BackingField;

		[Token(Token = "0x17000938")]
		public bool connected
		{
			[Token(Token = "0x6004227")]
			[Address(RVA = "0xAF20A4", Offset = "0xAF20A4", VA = "0xAF20A4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000939")]
		public int RoundTripTime
		{
			[Token(Token = "0x600422C")]
			[Address(RVA = "0xAF20C0", Offset = "0xAF20C0", VA = "0xAF20C0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700093A")]
		public ClientState connectionStateDetailed
		{
			[Token(Token = "0x600422E")]
			[Address(RVA = "0xAF20D0", Offset = "0xAF20D0", VA = "0xAF20D0", Slot = "14")]
			get
			{
				return default(ClientState);
			}
		}

		[Token(Token = "0x1700093B")]
		public bool offlineMode
		{
			[Token(Token = "0x600422F")]
			[Address(RVA = "0xAF20D8", Offset = "0xAF20D8", VA = "0xAF20D8", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004230")]
			[Address(RVA = "0xAF20E0", Offset = "0xAF20E0", VA = "0xAF20E0", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x1700093C")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x6004251")]
			[Address(RVA = "0xAF226C", Offset = "0xAF226C", VA = "0xAF226C", Slot = "45")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700093D")]
		public bool isMasterClient
		{
			[Token(Token = "0x6004252")]
			[Address(RVA = "0xAF2274", Offset = "0xAF2274", VA = "0xAF2274", Slot = "47")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700093E")]
		public bool isMessageQueueRunning
		{
			[Token(Token = "0x6004253")]
			[Address(RVA = "0xAF227C", Offset = "0xAF227C", VA = "0xAF227C", Slot = "48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004254")]
			[Address(RVA = "0xAF2284", Offset = "0xAF2284", VA = "0xAF2284", Slot = "49")]
			set
			{
			}
		}

		[Token(Token = "0x1700093F")]
		public PhotonPlayer player
		{
			[Token(Token = "0x6004256")]
			[Address(RVA = "0xAF2290", Offset = "0xAF2290", VA = "0xAF2290", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000940")]
		public PhotonPlayer[] playerList
		{
			[Token(Token = "0x6004257")]
			[Address(RVA = "0xAF2298", Offset = "0xAF2298", VA = "0xAF2298", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000941")]
		public PhotonPlayer[] otherPlayer
		{
			[Token(Token = "0x6004258")]
			[Address(RVA = "0xAF2324", Offset = "0xAF2324", VA = "0xAF2324", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000942")]
		public Room room
		{
			[Token(Token = "0x6004259")]
			[Address(RVA = "0xAF23B0", Offset = "0xAF23B0", VA = "0xAF23B0", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000943")]
		public int PlayerCountInThisRoom
		{
			[Token(Token = "0x6004261")]
			[Address(RVA = "0xAF24D4", Offset = "0xAF24D4", VA = "0xAF24D4", Slot = "62")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000944")]
		public float Time
		{
			[Token(Token = "0x6004262")]
			[Address(RVA = "0xAF2620", Offset = "0xAF2620", VA = "0xAF2620", Slot = "46")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6004226")]
		[Address(RVA = "0xAF209C", Offset = "0xAF209C", VA = "0xAF209C")]
		public PhotonNetworkOffline()
		{
		}

		[Token(Token = "0x6004228")]
		[Address(RVA = "0xAF20AC", Offset = "0xAF20AC", VA = "0xAF20AC", Slot = "4")]
		public XPhotonNetwork GetPhotonNetwork()
		{
			return null;
		}

		[Token(Token = "0x6004229")]
		[Address(RVA = "0xAF20B4", Offset = "0xAF20B4", VA = "0xAF20B4", Slot = "6")]
		public void ConnectToMasterServer()
		{
		}

		[Token(Token = "0x600422A")]
		[Address(RVA = "0xAF20B8", Offset = "0xAF20B8", VA = "0xAF20B8", Slot = "7")]
		public void TryConnectToMasterServer()
		{
		}

		[Token(Token = "0x600422B")]
		[Address(RVA = "0xAF20BC", Offset = "0xAF20BC", VA = "0xAF20BC", Slot = "8")]
		public void DisconnectToMasterServer()
		{
		}

		[Token(Token = "0x600422D")]
		[Address(RVA = "0xAF20C8", Offset = "0xAF20C8", VA = "0xAF20C8", Slot = "13")]
		public int GetPing()
		{
			return default(int);
		}

		[Token(Token = "0x6004231")]
		[Address(RVA = "0xAF20E8", Offset = "0xAF20E8", VA = "0xAF20E8", Slot = "12")]
		public void UpdateUsername()
		{
		}

		[Token(Token = "0x6004232")]
		[Address(RVA = "0xAF20EC", Offset = "0xAF20EC", VA = "0xAF20EC", Slot = "15")]
		public RoomInfo[] GetRoomList()
		{
			return null;
		}

		[Token(Token = "0x6004233")]
		[Address(RVA = "0xAF2178", Offset = "0xAF2178", VA = "0xAF2178", Slot = "16")]
		public bool TryGetRoomInfo(string roomName, out RoomInfo roomInfo)
		{
			roomInfo = default;
			return default(bool);
		}

		[Token(Token = "0x6004234")]
		[Address(RVA = "0xAF2188", Offset = "0xAF2188", VA = "0xAF2188", Slot = "17")]
		public bool CreateRoom(string roomName, MatchType matchType, XGameModeType nGameModeType, int gameModeInstanceId, int nSectorID, bool isNewbie, string friendlyRoomName = "", string friendlyPassword = "", string friendlyMasterName = "")
		{
			return default(bool);
		}

		[Token(Token = "0x6004235")]
		[Address(RVA = "0xAF2190", Offset = "0xAF2190", VA = "0xAF2190", Slot = "18")]
		public bool CreatePartyRoom(string roomName, GameModeInstanceInfo gameModeInstInfo, int nSectorID, int roomElo, bool isVisible)
		{
			return default(bool);
		}

		[Token(Token = "0x6004236")]
		[Address(RVA = "0xAF2198", Offset = "0xAF2198", VA = "0xAF2198", Slot = "19")]
		public bool CreateCustomRoom(string roomName, CustomRoomInfo roomInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6004237")]
		[Address(RVA = "0xAF21A0", Offset = "0xAF21A0", VA = "0xAF21A0", Slot = "20")]
		public bool JoinRoom(string strRoomName)
		{
			return default(bool);
		}

		[Token(Token = "0x6004238")]
		[Address(RVA = "0xAF21A8", Offset = "0xAF21A8", VA = "0xAF21A8", Slot = "21")]
		public bool JoinRoomForce(string strRoomName)
		{
			return default(bool);
		}

		[Token(Token = "0x6004239")]
		[Address(RVA = "0xAF21B0", Offset = "0xAF21B0", VA = "0xAF21B0", Slot = "22")]
		public bool ReJoinRoom(string strRoomName)
		{
			return default(bool);
		}

		[Token(Token = "0x600423A")]
		[Address(RVA = "0xAF21B8", Offset = "0xAF21B8", VA = "0xAF21B8", Slot = "23")]
		public bool JoinFriendlyMatch(XGameModeType mode, int gameModeInstanceId, int nSectorID, string friendlyRoomName, string friendlyPhotonRoomName, string friendlyPassword, string friendlyMasterName)
		{
			return default(bool);
		}

		[Token(Token = "0x600423B")]
		[Address(RVA = "0xAF21C0", Offset = "0xAF21C0", VA = "0xAF21C0", Slot = "24")]
		public bool JoinMatch(GameModeInstanceInfo gameModeInstanceInfo, int sectorID, int eloPt, Action OnCancel)
		{
			return default(bool);
		}

		[Token(Token = "0x600423C")]
		[Address(RVA = "0xAF21C8", Offset = "0xAF21C8", VA = "0xAF21C8", Slot = "25")]
		public bool JoinMatch(GameModeInstanceInfo gameModeInstanceInfo, int nSectorID, int eloPt, bool isNewbie)
		{
			return default(bool);
		}

		[Token(Token = "0x600423D")]
		[Address(RVA = "0xAF21D0", Offset = "0xAF21D0", VA = "0xAF21D0", Slot = "26")]
		public bool CancelMatch()
		{
			return default(bool);
		}

		[Token(Token = "0x600423E")]
		[Address(RVA = "0xAF21D8", Offset = "0xAF21D8", VA = "0xAF21D8", Slot = "27")]
		public bool MatchGameStart()
		{
			return default(bool);
		}

		[Token(Token = "0x600423F")]
		[Address(RVA = "0xAF21E0", Offset = "0xAF21E0", VA = "0xAF21E0", Slot = "28")]
		public bool LeaveMatchRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x6004240")]
		[Address(RVA = "0xAF21E8", Offset = "0xAF21E8", VA = "0xAF21E8", Slot = "29")]
		public bool CreateClanParty(GameModeInstanceInfo gameModeInstinfo, string clanID, NetMatchPlayerInfo player)
		{
			return default(bool);
		}

		[Token(Token = "0x6004241")]
		[Address(RVA = "0xAF21F0", Offset = "0xAF21F0", VA = "0xAF21F0", Slot = "30")]
		public bool JoinClanParty(long partyKey, XGameModeType nGameModeType, string clanID, NetMatchPlayerInfo player)
		{
			return default(bool);
		}

		[Token(Token = "0x6004242")]
		[Address(RVA = "0xAF21F8", Offset = "0xAF21F8", VA = "0xAF21F8", Slot = "31")]
		public bool LeaveClanParty()
		{
			return default(bool);
		}

		[Token(Token = "0x6004243")]
		[Address(RVA = "0xAF2200", Offset = "0xAF2200", VA = "0xAF2200", Slot = "32")]
		public bool RefreshClanParty(long partyKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6004244")]
		[Address(RVA = "0xAF2208", Offset = "0xAF2208", VA = "0xAF2208", Slot = "33")]
		public bool GetClanPartyList(string clanID, long getTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x6004245")]
		[Address(RVA = "0xAF2210", Offset = "0xAF2210", VA = "0xAF2210", Slot = "34")]
		public bool StartClanwar()
		{
			return default(bool);
		}

		[Token(Token = "0x6004246")]
		[Address(RVA = "0xAF2218", Offset = "0xAF2218", VA = "0xAF2218", Slot = "35")]
		public bool UpdateUserList()
		{
			return default(bool);
		}

		[Token(Token = "0x6004247")]
		[Address(RVA = "0xAF2220", Offset = "0xAF2220", VA = "0xAF2220")]
		public bool UpdatePartyList(string clanID)
		{
			return default(bool);
		}

		[Token(Token = "0x6004248")]
		[Address(RVA = "0xAF2228", Offset = "0xAF2228", VA = "0xAF2228")]
		public bool UpdatePartyPlayer(NetMatchPlayerInfo player)
		{
			return default(bool);
		}

		[Token(Token = "0x6004249")]
		[Address(RVA = "0xAF2230", Offset = "0xAF2230", VA = "0xAF2230", Slot = "36")]
		public bool ChangeReadyState(bool isReady)
		{
			return default(bool);
		}

		[Token(Token = "0x600424A")]
		[Address(RVA = "0xAF2238", Offset = "0xAF2238", VA = "0xAF2238", Slot = "37")]
		public bool ChangePartyInfoState(XGameModeType gameMode)
		{
			return default(bool);
		}

		[Token(Token = "0x600424B")]
		[Address(RVA = "0xAF2240", Offset = "0xAF2240", VA = "0xAF2240", Slot = "39")]
		public void ProcessRoomSelectorHistory(XGameModeType nGameModeType, CSWinlose winlose, int nRank)
		{
		}

		[Token(Token = "0x600424C")]
		[Address(RVA = "0xAF2244", Offset = "0xAF2244", VA = "0xAF2244", Slot = "40")]
		public int FindFriendlyRoomSectorId(XGameModeType mode, string strRoomName)
		{
			return default(int);
		}

		[Token(Token = "0x600424D")]
		[Address(RVA = "0xAF224C", Offset = "0xAF224C", VA = "0xAF224C", Slot = "41")]
		public int RecommendSectorId(GameModeInstanceInfo gameModeInstanceInfo, EventGameModeInfo eventGameModeInfo, bool isQuickMatch, XQuickMatchOptionData quickMatchOption)
		{
			return default(int);
		}

		[Token(Token = "0x600424E")]
		[Address(RVA = "0xAF2254", Offset = "0xAF2254", VA = "0xAF2254", Slot = "42")]
		public XGameModeType RecommendPVPGameMode(XQuickMatchOptionData quickMatchOption)
		{
			return default(XGameModeType);
		}

		[Token(Token = "0x600424F")]
		[Address(RVA = "0xAF225C", Offset = "0xAF225C", VA = "0xAF225C", Slot = "43")]
		public int GetModeTotalRoomCount(MatchType matchType, XGameModeType mode)
		{
			return default(int);
		}

		[Token(Token = "0x6004250")]
		[Address(RVA = "0xAF2264", Offset = "0xAF2264", VA = "0xAF2264", Slot = "44")]
		public int GetModeWaitingRoomCount(MatchType matchType, XGameModeType mode)
		{
			return default(int);
		}

		[Token(Token = "0x6004255")]
		[Address(RVA = "0xAF2288", Offset = "0xAF2288", VA = "0xAF2288", Slot = "50")]
		public PhotonPlayer Find(int ID)
		{
			return null;
		}

		[Token(Token = "0x600425A")]
		[Address(RVA = "0xAF23B8", Offset = "0xAF23B8", VA = "0xAF23B8", Slot = "56")]
		public void LoadLevel(int nLevelNumber)
		{
		}

		[Token(Token = "0x600425B")]
		[Address(RVA = "0xAF23C4", Offset = "0xAF23C4", VA = "0xAF23C4", Slot = "55")]
		public void LoadLevel(string strSceneName)
		{
		}

		[Token(Token = "0x600425C")]
		[Address(RVA = "0xAF23D0", Offset = "0xAF23D0", VA = "0xAF23D0", Slot = "57")]
		public GameObject InstantiateSceneObject(string prefabName, int actorID, int level, XTeamEnum team, Vector3 position, Quaternion rotation, byte group, bool isSceneObject)
		{
			return null;
		}

		[Token(Token = "0x600425D")]
		[Address(RVA = "0xAF23D8", Offset = "0xAF23D8", VA = "0xAF23D8", Slot = "58")]
		public GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group)
		{
			return null;
		}

		[Token(Token = "0x600425E")]
		[Address(RVA = "0xAF23E0", Offset = "0xAF23E0", VA = "0xAF23E0", Slot = "59")]
		public void UpdateRoomProperties(bool player_count_update = false)
		{
		}

		[Token(Token = "0x600425F")]
		[Address(RVA = "0xAF23E4", Offset = "0xAF23E4", VA = "0xAF23E4", Slot = "60")]
		public int GetMyPhotonID()
		{
			return default(int);
		}

		[Token(Token = "0x6004260")]
		[Address(RVA = "0xAF24B0", Offset = "0xAF24B0", VA = "0xAF24B0", Slot = "61")]
		public bool LeaveRoom(Action onLeftComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x6004263")]
		[Address(RVA = "0xAF262C", Offset = "0xAF262C", VA = "0xAF262C", Slot = "63")]
		public void VisibleRoom()
		{
		}

		[Token(Token = "0x6004264")]
		[Address(RVA = "0xAF2630", Offset = "0xAF2630", VA = "0xAF2630", Slot = "64")]
		public void InvisibleRoom()
		{
		}

		[Token(Token = "0x6004265")]
		[Address(RVA = "0xAF2634", Offset = "0xAF2634", VA = "0xAF2634", Slot = "65")]
		public void CloseRoom()
		{
		}

		[Token(Token = "0x6004266")]
		[Address(RVA = "0xAF2638", Offset = "0xAF2638", VA = "0xAF2638", Slot = "66")]
		public void OpenRoom()
		{
		}

		[Token(Token = "0x6004267")]
		[Address(RVA = "0xAF263C", Offset = "0xAF263C", VA = "0xAF263C", Slot = "67")]
		public void C_ReqRoomInfo()
		{
		}

		[Token(Token = "0x6004268")]
		[Address(RVA = "0xAF2640", Offset = "0xAF2640", VA = "0xAF2640", Slot = "69")]
		public void SendWhiteMsg(string strMsg, bool isTitleMessage = false, float duration = 1f)
		{
		}

		[Token(Token = "0x6004269")]
		[Address(RVA = "0xAF2768", Offset = "0xAF2768", VA = "0xAF2768", Slot = "70")]
		public void SendWhiteMsg(string strMsgKey, int nCount, bool isTitleMessage = false, float duration = 1f)
		{
		}

		[Token(Token = "0x600426A")]
		[Address(RVA = "0xAF2664", Offset = "0xAF2664", VA = "0xAF2664")]
		private void HandleMessage(bool isTitleMessage, string strMsg, float duration)
		{
		}

		[Token(Token = "0x600426B")]
		[Address(RVA = "0xAF287C", Offset = "0xAF287C", VA = "0xAF287C")]
		private void ShowMessage(bool isTitleMessage, string strMsg, float duration, string msgSoundName = "")
		{
		}

		[Token(Token = "0x600426C")]
		[Address(RVA = "0xAF2ABC", Offset = "0xAF2ABC", VA = "0xAF2ABC", Slot = "116")]
		public void SendReadyTimeoutMessage(int _nCounter)
		{
		}

		[Token(Token = "0x600426D")]
		[Address(RVA = "0xAF2AC0", Offset = "0xAF2AC0", VA = "0xAF2AC0", Slot = "117")]
		public void SendReadyTimeout()
		{
		}

		[Token(Token = "0x600426E")]
		[Address(RVA = "0xAF2AC4", Offset = "0xAF2AC4", VA = "0xAF2AC4", Slot = "118")]
		public void SendUpdatedPing(int ping)
		{
		}

		[Token(Token = "0x600426F")]
		[Address(RVA = "0xAF2AC8", Offset = "0xAF2AC8", VA = "0xAF2AC8", Slot = "71")]
		public void SystemMessageToChat(string strMsg)
		{
		}

		[Token(Token = "0x6004270")]
		[Address(RVA = "0xAF2ACC", Offset = "0xAF2ACC", VA = "0xAF2ACC", Slot = "72")]
		public void Chat(XChatMsgType chatMsgType, string strName, string strMsg)
		{
		}

		[Token(Token = "0x6004271")]
		[Address(RVA = "0xAF2DC4", Offset = "0xAF2DC4", VA = "0xAF2DC4", Slot = "74")]
		public void SendMsg(string strMsg, bool isTitleMessage = false, float duration = 1f, string msgSoundName = "", bool isUseLocalKey = false)
		{
		}

		[Token(Token = "0x6004272")]
		[Address(RVA = "0xAF2EB8", Offset = "0xAF2EB8", VA = "0xAF2EB8")]
		private void SendMsg(bool isTitleMessage, string strMsg, float duration, string msgSoundName)
		{
		}

		[Token(Token = "0x6004273")]
		[Address(RVA = "0xAF3058", Offset = "0xAF3058", VA = "0xAF3058", Slot = "75")]
		public void SendIngameCustomMessage(string strMsgKey, float duration)
		{
		}

		[Token(Token = "0x6004274")]
		[Address(RVA = "0xAF3114", Offset = "0xAF3114", VA = "0xAF3114")]
		private void ShowIngameCustomMessage(string strMsgKey, float duration)
		{
		}

		[Token(Token = "0x6004275")]
		[Address(RVA = "0xAF31F8", Offset = "0xAF31F8", VA = "0xAF31F8", Slot = "76")]
		public void ShowRelayMatchGameStartUI(int round)
		{
		}

		[Token(Token = "0x6004276")]
		[Address(RVA = "0xAF32AC", Offset = "0xAF32AC", VA = "0xAF32AC")]
		private void _ShowRelayMatchGameStartUI(int round)
		{
		}

		[Token(Token = "0x6004277")]
		[Address(RVA = "0xAF3388", Offset = "0xAF3388", VA = "0xAF3388", Slot = "77")]
		public void InitGame()
		{
		}

		[Token(Token = "0x6004278")]
		[Address(RVA = "0xAF338C", Offset = "0xAF338C", VA = "0xAF338C", Slot = "78")]
		public void ChangeGameModeState(XGameModeStateType nGameModeState)
		{
		}

		[Token(Token = "0x6004279")]
		[Address(RVA = "0xAF3390", Offset = "0xAF3390", VA = "0xAF3390", Slot = "79")]
		public void SyncPlayerInfo()
		{
		}

		[Token(Token = "0x600427A")]
		[Address(RVA = "0xAF3394", Offset = "0xAF3394", VA = "0xAF3394", Slot = "80")]
		public void MC_SyncRoomInfo()
		{
		}

		[Token(Token = "0x600427B")]
		[Address(RVA = "0xAF3398", Offset = "0xAF3398", VA = "0xAF3398", Slot = "81")]
		public void MC_SpawnDropObject(int nSpawnID, int nCharID, int groupIndex)
		{
		}

		[Token(Token = "0x600427C")]
		[Address(RVA = "0xAF339C", Offset = "0xAF339C", VA = "0xAF339C", Slot = "82")]
		public void SetTeam(int nTargetPhotonID, int nTeamID)
		{
		}

		[Token(Token = "0x600427D")]
		[Address(RVA = "0xAF33A0", Offset = "0xAF33A0", VA = "0xAF33A0", Slot = "83")]
		public void MC_OnEnterGimmickWorkingState(int nGimmickIndex, XMapGimmickWorkingState gimmickState)
		{
		}

		[Token(Token = "0x600427E")]
		[Address(RVA = "0xAF33A4", Offset = "0xAF33A4", VA = "0xAF33A4", Slot = "84")]
		public void M_InteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
		{
		}

		[Token(Token = "0x600427F")]
		[Address(RVA = "0xAF33A8", Offset = "0xAF33A8", VA = "0xAF33A8", Slot = "85")]
		public void M_CancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
		{
		}

		[Token(Token = "0x6004280")]
		[Address(RVA = "0xAF33AC", Offset = "0xAF33AC", VA = "0xAF33AC", Slot = "86")]
		public void C_ReqInteractionCapturePoint(int nPointObjectIndex)
		{
		}

		[Token(Token = "0x6004281")]
		[Address(RVA = "0xAF33B0", Offset = "0xAF33B0", VA = "0xAF33B0", Slot = "87")]
		public void C_ReqCancelInteractionCapturePoint(int nPointObjectIndex)
		{
		}

		[Token(Token = "0x6004282")]
		[Address(RVA = "0xAF33B4", Offset = "0xAF33B4", VA = "0xAF33B4", Slot = "88")]
		public void M_CapturePointA_SyncGameModeData([Optional] PhotonPlayer photonPlayaer)
		{
		}

		[Token(Token = "0x6004283")]
		[Address(RVA = "0xAF33B8", Offset = "0xAF33B8", VA = "0xAF33B8", Slot = "89")]
		public void SetMasterZombie(int nTargetPhotonID)
		{
		}

		[Token(Token = "0x6004284")]
		[Address(RVA = "0xAF33BC", Offset = "0xAF33BC", VA = "0xAF33BC", Slot = "90")]
		public void SetTagger(int nTargetPhotonID, bool ignoreJudgementTime, int ItemID)
		{
		}

		[Token(Token = "0x6004285")]
		[Address(RVA = "0xAF33C0", Offset = "0xAF33C0", VA = "0xAF33C0", Slot = "91")]
		public void RequestTaggerChooseToMasterClient(int itemID = 0, bool isDieEvent = false)
		{
		}

		[Token(Token = "0x6004286")]
		[Address(RVA = "0xAF33C4", Offset = "0xAF33C4", VA = "0xAF33C4", Slot = "92")]
		public void M_ZombieTag_SyncGameModeData()
		{
		}

		[Token(Token = "0x6004287")]
		[Address(RVA = "0xAF33C8", Offset = "0xAF33C8", VA = "0xAF33C8", Slot = "93")]
		public void StartRound(int nRound)
		{
		}

		[Token(Token = "0x6004288")]
		[Address(RVA = "0xAF33CC", Offset = "0xAF33CC", VA = "0xAF33CC", Slot = "94")]
		public void SendRoundResult(int nRound, int nPhotonID_0, short result_0, int nPhotonID_1, short result_1)
		{
		}

		[Token(Token = "0x6004289")]
		[Address(RVA = "0xAF33D0", Offset = "0xAF33D0", VA = "0xAF33D0", Slot = "96")]
		public void Annihilation_StartRound(int nRound)
		{
		}

		[Token(Token = "0x600428A")]
		[Address(RVA = "0xAF33D4", Offset = "0xAF33D4", VA = "0xAF33D4", Slot = "97")]
		public void Annihilation_SendRoundResult(int nRound, short result_TeamA, short result_TeamB)
		{
		}

		[Token(Token = "0x600428B")]
		[Address(RVA = "0xAF33D8", Offset = "0xAF33D8", VA = "0xAF33D8", Slot = "98")]
		public void Annihilation_SyncGameTime(float remain_Time)
		{
		}

		[Token(Token = "0x600428C")]
		[Address(RVA = "0xAF33DC", Offset = "0xAF33DC", VA = "0xAF33DC", Slot = "99")]
		public void Annihilation_SyncGameState(int gameState)
		{
		}

		[Token(Token = "0x600428D")]
		[Address(RVA = "0xAF33E0", Offset = "0xAF33E0", VA = "0xAF33E0", Slot = "95")]
		public void Annihilation_SendLoseLifePlayer()
		{
		}

		[Token(Token = "0x600428E")]
		[Address(RVA = "0xAF33E4", Offset = "0xAF33E4", VA = "0xAF33E4", Slot = "106")]
		public void AddStats_Send(string name, PhotonTargets target, params object[] args)
		{
		}

		[Token(Token = "0x600428F")]
		[Address(RVA = "0xAF33E8", Offset = "0xAF33E8", VA = "0xAF33E8", Slot = "107")]
		public void AddStats_Send(string name, params object[] args)
		{
		}

		[Token(Token = "0x6004290")]
		[Address(RVA = "0xAF33EC", Offset = "0xAF33EC", VA = "0xAF33EC", Slot = "108")]
		public void AddStats_Recv(string name, params object[] args)
		{
		}

		[Token(Token = "0x6004291")]
		[Address(RVA = "0xAF33F0", Offset = "0xAF33F0", VA = "0xAF33F0", Slot = "38")]
		public bool WebRpc(string name, Dictionary<int, object> param)
		{
			return default(bool);
		}

		[Token(Token = "0x6004292")]
		[Address(RVA = "0xAF33F8", Offset = "0xAF33F8", VA = "0xAF33F8", Slot = "109")]
		public void InGameRaiseEvent(InGameRaiseEventContent Content, bool sendReliable, RaiseEventOptions options)
		{
		}

		[Token(Token = "0x6004293")]
		[Address(RVA = "0xAF342C", Offset = "0xAF342C", VA = "0xAF342C", Slot = "110")]
		public void OnInGameRaiseEvent(Dictionary<byte, object> data, int senderId)
		{
		}

		[Token(Token = "0x6004294")]
		[Address(RVA = "0xAF38DC", Offset = "0xAF38DC", VA = "0xAF38DC", Slot = "111")]
		public void WebHttpRaiseEvent(WebHttpRaiseEventContent eventContent, bool sendReliable, RaiseEventOptions options)
		{
		}

		[Token(Token = "0x6004295")]
		[Address(RVA = "0xAF3918", Offset = "0xAF3918", VA = "0xAF3918", Slot = "112")]
		public void OnWebHttpRaiseEvent(Dictionary<byte, object> data, int senderId)
		{
		}

		[Token(Token = "0x6004296")]
		[Address(RVA = "0xAF39D4", Offset = "0xAF39D4", VA = "0xAF39D4")]
		private void OnInGameFinish(Dictionary<byte, object> contentData)
		{
		}

		[Token(Token = "0x6004297")]
		[Address(RVA = "0xAF3AA4", Offset = "0xAF3AA4", VA = "0xAF3AA4", Slot = "113")]
		public void OnCustomRaiseEventErrorInfo(Dictionary<byte, object> dicContent)
		{
		}

		[Token(Token = "0x6004298")]
		[Address(RVA = "0xAF3AA8", Offset = "0xAF3AA8", VA = "0xAF3AA8", Slot = "114")]
		public void ReconnectAndRejoin()
		{
		}

		[Token(Token = "0x6004299")]
		[Address(RVA = "0xAF3AAC", Offset = "0xAF3AAC", VA = "0xAF3AAC", Slot = "115")]
		public bool ChangeMasterClient()
		{
			return default(bool);
		}

		[Token(Token = "0x600429A")]
		[Address(RVA = "0xAF3AB4", Offset = "0xAF3AB4", VA = "0xAF3AB4", Slot = "119")]
		public string GetRoomName()
		{
			return null;
		}

		[Token(Token = "0x600429B")]
		[Address(RVA = "0xAF3B64", Offset = "0xAF3B64", VA = "0xAF3B64", Slot = "120")]
		public void SyncToMasterClient()
		{
		}

		[Token(Token = "0x600429C")]
		[Address(RVA = "0xAF3B68", Offset = "0xAF3B68", VA = "0xAF3B68")]
		public void RequestHello(PhotonPlayer player)
		{
		}

		[Token(Token = "0x600429D")]
		[Address(RVA = "0xAF3B6C", Offset = "0xAF3B6C", VA = "0xAF3B6C", Slot = "121")]
		public void SendOutgoingCommands()
		{
		}

		[Token(Token = "0x600429E")]
		[Address(RVA = "0xAF3B70", Offset = "0xAF3B70", VA = "0xAF3B70", Slot = "122")]
		public void SetPhotonReqestHello(XPhotonNetworkRequestHello requestHello)
		{
		}

		[Token(Token = "0x600429F")]
		[Address(RVA = "0xAF3B74", Offset = "0xAF3B74", VA = "0xAF3B74", Slot = "123")]
		public void DivideTeam(NetData_PlayerTeamSetting netDataPlayerTeam)
		{
		}

		[Token(Token = "0x60042A0")]
		[Address(RVA = "0xAF3B78", Offset = "0xAF3B78", VA = "0xAF3B78", Slot = "124")]
		public string GetRPCDebugLog()
		{
			return null;
		}

		[Token(Token = "0x60042A1")]
		[Address(RVA = "0xAF3C28", Offset = "0xAF3C28", VA = "0xAF3C28")]
		public void SetPreloadedOtherPhotonPlayers(PhotonPlayer[] otherPlayers)
		{
		}

		[Token(Token = "0x60042A2")]
		[Address(RVA = "0xAF3C2C", Offset = "0xAF3C2C", VA = "0xAF3C2C", Slot = "125")]
		public void ResetAuthValues()
		{
		}

		[Token(Token = "0x60042A3")]
		[Address(RVA = "0xAF3C30", Offset = "0xAF3C30", VA = "0xAF3C30")]
		public void AddDamageLog(string modUserNickName)
		{
		}

		[Token(Token = "0x60042A4")]
		[Address(RVA = "0xAF3C34", Offset = "0xAF3C34", VA = "0xAF3C34", Slot = "68")]
		public ModUserLog GetModUserLog()
		{
			return null;
		}

		[Token(Token = "0x60042A5")]
		[Address(RVA = "0xAF3CBC", Offset = "0xAF3CBC", VA = "0xAF3CBC", Slot = "126")]
		public bool FindFriends(string[] firendsAID)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A6")]
		[Address(RVA = "0xAF3CC4", Offset = "0xAF3CC4", VA = "0xAF3CC4", Slot = "127")]
		public List<FriendInfo> FriendsInfo()
		{
			return null;
		}

		[Token(Token = "0x60042A7")]
		[Address(RVA = "0xAF3D60", Offset = "0xAF3D60", VA = "0xAF3D60", Slot = "128")]
		public bool CreateParty(NetMatchPlayerInfo player, XGameModeType gameMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A8")]
		[Address(RVA = "0xAF3D68", Offset = "0xAF3D68", VA = "0xAF3D68", Slot = "129")]
		public bool JoinParty(long partyKey, NetMatchPlayerInfo player)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A9")]
		[Address(RVA = "0xAF3D70", Offset = "0xAF3D70", VA = "0xAF3D70", Slot = "130")]
		public bool LeaveParty()
		{
			return default(bool);
		}

		[Token(Token = "0x60042AA")]
		[Address(RVA = "0xAF3D78", Offset = "0xAF3D78", VA = "0xAF3D78", Slot = "131")]
		public bool StartPartyGame(int sectorID, XGameModeType gameMode, MatchType matchType = MatchType.Normal)
		{
			return default(bool);
		}

		[Token(Token = "0x60042AB")]
		[Address(RVA = "0xAF3D80", Offset = "0xAF3D80", VA = "0xAF3D80", Slot = "132")]
		public void UpdateRoomPropertiesLeavePlayer(string nickname)
		{
		}

		[Token(Token = "0x60042AC")]
		[Address(RVA = "0xAF3D84", Offset = "0xAF3D84", VA = "0xAF3D84", Slot = "133")]
		public void UpdateRoomPropertiesRoomPlayer(string playerName)
		{
		}

		[Token(Token = "0x60042AD")]
		[Address(RVA = "0xAF3D88", Offset = "0xAF3D88", VA = "0xAF3D88", Slot = "73")]
		public void IngameChat(int id1, int id2, string strName, string strMsg)
		{
		}

		[Token(Token = "0x60042AE")]
		[Address(RVA = "0xAF3D8C", Offset = "0xAF3D8C", VA = "0xAF3D8C", Slot = "100")]
		public void CasualMode_StartRound(int round)
		{
		}

		[Token(Token = "0x60042AF")]
		[Address(RVA = "0xAF3D90", Offset = "0xAF3D90", VA = "0xAF3D90", Slot = "101")]
		public void CasualMode_EndRound(int round, XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x60042B0")]
		[Address(RVA = "0xAF3D94", Offset = "0xAF3D94", VA = "0xAF3D94", Slot = "102")]
		public void CasualMode_EndMode(XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x60042B1")]
		[Address(RVA = "0xAF3D98", Offset = "0xAF3D98", VA = "0xAF3D98", Slot = "103")]
		public void CasualMode_SetPlayerRecord(string aid, PlayerProperty prop, object v)
		{
		}

		[Token(Token = "0x60042B2")]
		[Address(RVA = "0xAF3D9C", Offset = "0xAF3D9C", VA = "0xAF3D9C", Slot = "104")]
		public void CasualMode_RegisterEventReceiver(ICasualModeEventReceiver receiver)
		{
		}

		[Token(Token = "0x60042B3")]
		[Address(RVA = "0xAF3DA0", Offset = "0xAF3DA0", VA = "0xAF3DA0", Slot = "105")]
		public void CasualMode_RemoveEventReceiver()
		{
		}

		[Token(Token = "0x60042B4")]
		[Address(RVA = "0xAF3DA4", Offset = "0xAF3DA4", VA = "0xAF3DA4", Slot = "134")]
		public void SetInterestGroups(byte group, bool enabled)
		{
		}

		[Token(Token = "0x60042B5")]
		[Address(RVA = "0xAF3DA8", Offset = "0xAF3DA8", VA = "0xAF3DA8", Slot = "135")]
		public void CheckMyTeamToMasterClient()
		{
		}

		[Token(Token = "0x60042B6")]
		[Address(RVA = "0xAF3DAC", Offset = "0xAF3DAC", VA = "0xAF3DAC", Slot = "136")]
		public void SendToMyTeamInfoInFriendlyMatch(byte teamInfo, [Optional] PhotonPlayer targetPlayer)
		{
		}

		[Token(Token = "0x60042B7")]
		[Address(RVA = "0xAF3DB0", Offset = "0xAF3DB0", VA = "0xAF3DB0", Slot = "137")]
		public void AddAreaOfEffectBuff(int buffID, BuffTargetType eBuffTargetType)
		{
		}

		[Token(Token = "0x60042B8")]
		[Address(RVA = "0xAF3DB4", Offset = "0xAF3DB4", VA = "0xAF3DB4", Slot = "138")]
		public void OnComplteGame()
		{
		}
	}

	[Token(Token = "0x2000843")]
	public class PhotonNetworkWrapper : IPhotonNetwork
	{
		[Token(Token = "0x2000844")]
		private sealed class _003CCoroutinInGameFinish_003Ec__Iterator8D : IDisposable
		{
			[Token(Token = "0x40023BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float fDelayTime;

			[Token(Token = "0x40023BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int _0024PC;

			[Token(Token = "0x40023BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object _0024current;

			[Token(Token = "0x40023BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal float _003C_0024_003EfDelayTime;

			[Token(Token = "0x17000955")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x600435C")]
				[Address(RVA = "0xB0AFD8", Offset = "0xB0AFD8", VA = "0xB0AFD8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000956")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600435D")]
				[Address(RVA = "0xB0AFE0", Offset = "0xB0AFE0", VA = "0xB0AFE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600435B")]
			[Address(RVA = "0xB08CE8", Offset = "0xB08CE8", VA = "0xB08CE8")]
			public _003CCoroutinInGameFinish_003Ec__Iterator8D()
			{
			}

			[Token(Token = "0x600435C")]
			[Address(RVA = "0xB0AFD8", Offset = "0xB0AFD8", VA = "0xB0AFD8", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600435D")]
			[Address(RVA = "0xB0AFE0", Offset = "0xB0AFE0", VA = "0xB0AFE0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600435E")]
			[Address(RVA = "0xB0AFE8", Offset = "0xB0AFE8", VA = "0xB0AFE8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600435F")]
			[Address(RVA = "0xB0B208", Offset = "0xB0B208", VA = "0xB0B208", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6004360")]
			[Address(RVA = "0xB0B214", Offset = "0xB0B214", VA = "0xB0B214", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000845")]
		private sealed class _003CCoroutinFinishExitDuringTheGame_003Ec__Iterator8E : IDisposable
		{
			[Token(Token = "0x40023BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float fDelayTime;

			[Token(Token = "0x40023C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal XPlayerManager _003CplayerManager_003E__0;

			[Token(Token = "0x40023C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int _0024PC;

			[Token(Token = "0x40023C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal object _0024current;

			[Token(Token = "0x40023C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal float _003C_0024_003EfDelayTime;

			[Token(Token = "0x17000957")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6004362")]
				[Address(RVA = "0xB0AB70", Offset = "0xB0AB70", VA = "0xB0AB70", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000958")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004363")]
				[Address(RVA = "0xB0AB78", Offset = "0xB0AB78", VA = "0xB0AB78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004361")]
			[Address(RVA = "0xB08CF0", Offset = "0xB08CF0", VA = "0xB08CF0")]
			public _003CCoroutinFinishExitDuringTheGame_003Ec__Iterator8E()
			{
			}

			[Token(Token = "0x6004362")]
			[Address(RVA = "0xB0AB70", Offset = "0xB0AB70", VA = "0xB0AB70", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004363")]
			[Address(RVA = "0xB0AB78", Offset = "0xB0AB78", VA = "0xB0AB78", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004364")]
			[Address(RVA = "0xB0AB80", Offset = "0xB0AB80", VA = "0xB0AB80", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004365")]
			[Address(RVA = "0xB0AF38", Offset = "0xB0AF38", VA = "0xB0AF38", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6004366")]
			[Address(RVA = "0xB0AF44", Offset = "0xB0AF44", VA = "0xB0AF44", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40023B4")]
		public const int RetryWebHttpInGameFinishCountMax = 10;

		[Token(Token = "0x40023B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ExitGames.Client.Photon.Hashtable properties;

		[Token(Token = "0x40023B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private XRoomSelector m_RoomSelector;

		[Token(Token = "0x40023B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ModUserLog modUserLog;

		[Token(Token = "0x40023B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Action OnCancel__BackingField;

		[Token(Token = "0x40023B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int RetryWebHttpInGameFinishCount__BackingField;

		[Token(Token = "0x40023BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private XPhotonNetwork m_photonNetwork__BackingField;

		[Token(Token = "0x17000945")]
		public Action OnCancel
		{
			[Token(Token = "0x60042BA")]
			[Address(RVA = "0xAF3EB0", Offset = "0xAF3EB0", VA = "0xAF3EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042BB")]
			[Address(RVA = "0xAF3EB8", Offset = "0xAF3EB8", VA = "0xAF3EB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000946")]
		public int RetryWebHttpInGameFinishCount
		{
			[Token(Token = "0x60042BC")]
			[Address(RVA = "0xAF3EC0", Offset = "0xAF3EC0", VA = "0xAF3EC0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60042BD")]
			[Address(RVA = "0xAF3EA8", Offset = "0xAF3EA8", VA = "0xAF3EA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000947")]
		public bool connected
		{
			[Token(Token = "0x60042BE")]
			[Address(RVA = "0xAF3EC8", Offset = "0xAF3EC8", VA = "0xAF3EC8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000948")]
		public int RoundTripTime
		{
			[Token(Token = "0x60042C2")]
			[Address(RVA = "0xAF4470", Offset = "0xAF4470", VA = "0xAF4470", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000949")]
		public ClientState connectionStateDetailed
		{
			[Token(Token = "0x60042C4")]
			[Address(RVA = "0xAF46A4", Offset = "0xAF46A4", VA = "0xAF46A4", Slot = "14")]
			get
			{
				return default(ClientState);
			}
		}

		[Token(Token = "0x1700094A")]
		public bool offlineMode
		{
			[Token(Token = "0x60042C5")]
			[Address(RVA = "0xAF4744", Offset = "0xAF4744", VA = "0xAF4744", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60042C6")]
			[Address(RVA = "0xAF47E4", Offset = "0xAF47E4", VA = "0xAF47E4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x1700094B")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x60042E5")]
			[Address(RVA = "0xAF92A8", Offset = "0xAF92A8", VA = "0xAF92A8", Slot = "45")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700094C")]
		public bool isMasterClient
		{
			[Token(Token = "0x60042E6")]
			[Address(RVA = "0xAF9348", Offset = "0xAF9348", VA = "0xAF9348", Slot = "47")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700094D")]
		public bool isMessageQueueRunning
		{
			[Token(Token = "0x60042E7")]
			[Address(RVA = "0xAF9548", Offset = "0xAF9548", VA = "0xAF9548", Slot = "48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60042E8")]
			[Address(RVA = "0xAF95E8", Offset = "0xAF95E8", VA = "0xAF95E8", Slot = "49")]
			set
			{
			}
		}

		[Token(Token = "0x1700094E")]
		public PhotonPlayer player
		{
			[Token(Token = "0x60042EA")]
			[Address(RVA = "0xAF969C", Offset = "0xAF969C", VA = "0xAF969C", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094F")]
		public PhotonPlayer[] playerList
		{
			[Token(Token = "0x60042EB")]
			[Address(RVA = "0xAF973C", Offset = "0xAF973C", VA = "0xAF973C", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000950")]
		public PhotonPlayer[] otherPlayer
		{
			[Token(Token = "0x60042EC")]
			[Address(RVA = "0xAF97DC", Offset = "0xAF97DC", VA = "0xAF97DC", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000951")]
		public Room room
		{
			[Token(Token = "0x60042ED")]
			[Address(RVA = "0xAF987C", Offset = "0xAF987C", VA = "0xAF987C", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000952")]
		public int PlayerCountInThisRoom
		{
			[Token(Token = "0x60042F5")]
			[Address(RVA = "0xAFA28C", Offset = "0xAFA28C", VA = "0xAFA28C", Slot = "62")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000953")]
		public XPhotonNetwork m_photonNetwork
		{
			[Token(Token = "0x600432B")]
			[Address(RVA = "0xB031DC", Offset = "0xB031DC", VA = "0xB031DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600432C")]
			[Address(RVA = "0xB031E4", Offset = "0xB031E4", VA = "0xB031E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000954")]
		public float Time
		{
			[Token(Token = "0x600432D")]
			[Address(RVA = "0xB031EC", Offset = "0xB031EC", VA = "0xB031EC", Slot = "46")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60042B9")]
		[Address(RVA = "0xAF3DB8", Offset = "0xAF3DB8", VA = "0xAF3DB8")]
		public PhotonNetworkWrapper()
		{
		}

		[Token(Token = "0x60042BF")]
		[Address(RVA = "0xAF3F68", Offset = "0xAF3F68", VA = "0xAF3F68", Slot = "6")]
		public void ConnectToMasterServer()
		{
		}

		[Token(Token = "0x60042C0")]
		[Address(RVA = "0xAF4224", Offset = "0xAF4224", VA = "0xAF4224", Slot = "7")]
		public void TryConnectToMasterServer()
		{
		}

		[Token(Token = "0x60042C1")]
		[Address(RVA = "0xAF438C", Offset = "0xAF438C", VA = "0xAF438C", Slot = "8")]
		public void DisconnectToMasterServer()
		{
		}

		[Token(Token = "0x60042C3")]
		[Address(RVA = "0xAF453C", Offset = "0xAF453C", VA = "0xAF453C", Slot = "13")]
		public int GetPing()
		{
			return default(int);
		}

		[Token(Token = "0x60042C7")]
		[Address(RVA = "0xAF488C", Offset = "0xAF488C", VA = "0xAF488C", Slot = "12")]
		public void UpdateUsername()
		{
		}

		[Token(Token = "0x60042C8")]
		[Address(RVA = "0xAF4A38", Offset = "0xAF4A38", VA = "0xAF4A38", Slot = "15")]
		public RoomInfo[] GetRoomList()
		{
			return null;
		}

		[Token(Token = "0x60042C9")]
		[Address(RVA = "0xAF4AD8", Offset = "0xAF4AD8", VA = "0xAF4AD8", Slot = "16")]
		public bool TryGetRoomInfo(string roomName, out RoomInfo roomInfo)
		{
			roomInfo = default;
			return default(bool);
		}

		[Token(Token = "0x60042CA")]
		[Address(RVA = "0xAF4C54", Offset = "0xAF4C54", VA = "0xAF4C54", Slot = "20")]
		public bool JoinRoom(string strRoomName)
		{
			return default(bool);
		}

		[Token(Token = "0x60042CB")]
		[Address(RVA = "0xAF504C", Offset = "0xAF504C", VA = "0xAF504C", Slot = "21")]
		public bool JoinRoomForce(string strRoomName)
		{
			return default(bool);
		}

		[Token(Token = "0x60042CC")]
		[Address(RVA = "0xAF5168", Offset = "0xAF5168", VA = "0xAF5168", Slot = "22")]
		public bool ReJoinRoom(string strRoomName)
		{
			return default(bool);
		}

		[Token(Token = "0x60042CD")]
		[Address(RVA = "0xAF5210", Offset = "0xAF5210", VA = "0xAF5210", Slot = "114")]
		public void ReconnectAndRejoin()
		{
		}

		[Token(Token = "0x60042CE")]
		[Address(RVA = "0xAF52B0", Offset = "0xAF52B0", VA = "0xAF52B0", Slot = "23")]
		public bool JoinFriendlyMatch(XGameModeType mode, int gameModeInstanceId, int nSectorID, string friendlyRoomName, string friendlyPhotonRoomName, string friendlyPassword, string friendlyMasterName)
		{
			return default(bool);
		}

		[Token(Token = "0x60042CF")]
		[Address(RVA = "0xAF5758", Offset = "0xAF5758", VA = "0xAF5758", Slot = "17")]
		public bool CreateRoom(string roomName, MatchType nMatchType, XGameModeType nGameModeType, int gameModeInstanceId, int nSectorID, bool isNewbie, string friendlyRoomName = "", string friendlyPassword = "", string friendlyMasterName = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60042D0")]
		[Address(RVA = "0xAF638C", Offset = "0xAF638C", VA = "0xAF638C", Slot = "18")]
		public bool CreatePartyRoom(string roomName, GameModeInstanceInfo gameModeInstInfo, int nSectorID, int roomElo, bool isVisible)
		{
			return default(bool);
		}

		[Token(Token = "0x60042D1")]
		[Address(RVA = "0xAF694C", Offset = "0xAF694C", VA = "0xAF694C", Slot = "19")]
		public bool CreateCustomRoom(string roomName, CustomRoomInfo roomInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60042D2")]
		[Address(RVA = "0xAF4E88", Offset = "0xAF4E88", VA = "0xAF4E88")]
		private void SetCreationDesc(XGameModeType nGameModeType)
		{
		}

		[Token(Token = "0x60042D3")]
		[Address(RVA = "0xAF717C", Offset = "0xAF717C", VA = "0xAF717C", Slot = "24")]
		public bool JoinMatch(GameModeInstanceInfo gameModeInstanceInfo, int sectorID, int eloPt, Action OnCancel)
		{
			return default(bool);
		}

		[Token(Token = "0x60042D4")]
		[Address(RVA = "0xAF786C", Offset = "0xAF786C", VA = "0xAF786C", Slot = "25")]
		public bool JoinMatch(GameModeInstanceInfo gameModeInstanceInfo, int nSectorID, int eloPt, bool isNewbieMatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60042D5")]
		[Address(RVA = "0xAF7A14", Offset = "0xAF7A14", VA = "0xAF7A14", Slot = "26")]
		public bool CancelMatch()
		{
			return default(bool);
		}

		[Token(Token = "0x60042D6")]
		[Address(RVA = "0xAF7AD4", Offset = "0xAF7AD4", VA = "0xAF7AD4", Slot = "27")]
		public bool MatchGameStart()
		{
			return default(bool);
		}

		[Token(Token = "0x60042D7")]
		[Address(RVA = "0xAF7BE4", Offset = "0xAF7BE4", VA = "0xAF7BE4", Slot = "28")]
		public bool LeaveMatchRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x60042D8")]
		[Address(RVA = "0xAF7D74", Offset = "0xAF7D74", VA = "0xAF7D74", Slot = "29")]
		public bool CreateClanParty(GameModeInstanceInfo gameModeInstinfo, string clanID, NetMatchPlayerInfo player)
		{
			return default(bool);
		}

		[Token(Token = "0x60042D9")]
		[Address(RVA = "0xAF8454", Offset = "0xAF8454", VA = "0xAF8454", Slot = "30")]
		public bool JoinClanParty(long partyKey, XGameModeType nGameModeType, string clanID, NetMatchPlayerInfo player)
		{
			return default(bool);
		}

		[Token(Token = "0x60042DA")]
		[Address(RVA = "0xAF8774", Offset = "0xAF8774", VA = "0xAF8774", Slot = "32")]
		public bool RefreshClanParty(long partyKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60042DB")]
		[Address(RVA = "0xAF88A0", Offset = "0xAF88A0", VA = "0xAF88A0", Slot = "31")]
		public bool LeaveClanParty()
		{
			return default(bool);
		}

		[Token(Token = "0x60042DC")]
		[Address(RVA = "0xAF8964", Offset = "0xAF8964", VA = "0xAF8964", Slot = "33")]
		public bool GetClanPartyList(string clanID, long getTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x60042DD")]
		[Address(RVA = "0xAF8AE8", Offset = "0xAF8AE8", VA = "0xAF8AE8", Slot = "34")]
		public bool StartClanwar()
		{
			return default(bool);
		}

		[Token(Token = "0x60042DE")]
		[Address(RVA = "0xAF8BAC", Offset = "0xAF8BAC", VA = "0xAF8BAC", Slot = "35")]
		public bool UpdateUserList()
		{
			return default(bool);
		}

		[Token(Token = "0x60042DF")]
		[Address(RVA = "0xAF8BB4", Offset = "0xAF8BB4", VA = "0xAF8BB4", Slot = "39")]
		public void ProcessRoomSelectorHistory(XGameModeType nGameModeType, CSWinlose winlose, int nRank)
		{
		}

		[Token(Token = "0x60042E0")]
		[Address(RVA = "0xAF8BEC", Offset = "0xAF8BEC", VA = "0xAF8BEC", Slot = "40")]
		public int FindFriendlyRoomSectorId(XGameModeType mode, string strRoomName)
		{
			return default(int);
		}

		[Token(Token = "0x60042E1")]
		[Address(RVA = "0xAF8C18", Offset = "0xAF8C18", VA = "0xAF8C18", Slot = "41")]
		public int RecommendSectorId(GameModeInstanceInfo gameModeInstanceInfo, EventGameModeInfo eventGameModeInfo, bool isQuickMatch, XQuickMatchOptionData quickMatchOption)
		{
			return default(int);
		}

		[Token(Token = "0x60042E2")]
		[Address(RVA = "0xAF8C54", Offset = "0xAF8C54", VA = "0xAF8C54", Slot = "42")]
		public XGameModeType RecommendPVPGameMode(XQuickMatchOptionData quickMatchOption)
		{
			return default(XGameModeType);
		}

		[Token(Token = "0x60042E3")]
		[Address(RVA = "0xAF8C80", Offset = "0xAF8C80", VA = "0xAF8C80", Slot = "43")]
		public int GetModeTotalRoomCount(MatchType matchType, XGameModeType mode)
		{
			return default(int);
		}

		[Token(Token = "0x60042E4")]
		[Address(RVA = "0xAF8F2C", Offset = "0xAF8F2C", VA = "0xAF8F2C", Slot = "44")]
		public int GetModeWaitingRoomCount(MatchType matchType, XGameModeType mode)
		{
			return default(int);
		}

		[Token(Token = "0x60042E9")]
		[Address(RVA = "0xAF9690", Offset = "0xAF9690", VA = "0xAF9690", Slot = "50")]
		public PhotonPlayer Find(int ID)
		{
			return null;
		}

		[Token(Token = "0x60042EE")]
		[Address(RVA = "0xAF991C", Offset = "0xAF991C", VA = "0xAF991C", Slot = "56")]
		public void LoadLevel(int nLevelNumber)
		{
		}

		[Token(Token = "0x60042EF")]
		[Address(RVA = "0xAF99C4", Offset = "0xAF99C4", VA = "0xAF99C4", Slot = "55")]
		public void LoadLevel(string strSceneName)
		{
		}

		[Token(Token = "0x60042F0")]
		[Address(RVA = "0xAF9A6C", Offset = "0xAF9A6C", VA = "0xAF9A6C", Slot = "57")]
		public GameObject InstantiateSceneObject(string prefabName, int actorID, int level, XTeamEnum team, Vector3 position, Quaternion rotation, byte group, bool isSceneObject)
		{
			return null;
		}

		[Token(Token = "0x60042F1")]
		[Address(RVA = "0xAF9CE8", Offset = "0xAF9CE8", VA = "0xAF9CE8", Slot = "58")]
		public GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group)
		{
			return null;
		}

		[Token(Token = "0x60042F2")]
		[Address(RVA = "0xAF9DE4", Offset = "0xAF9DE4", VA = "0xAF9DE4", Slot = "59")]
		public void UpdateRoomProperties(bool player_count_update = false)
		{
		}

		[Token(Token = "0x60042F3")]
		[Address(RVA = "0xAF9ED4", Offset = "0xAF9ED4", VA = "0xAF9ED4", Slot = "60")]
		public int GetMyPhotonID()
		{
			return default(int);
		}

		[Token(Token = "0x60042F4")]
		[Address(RVA = "0xAFA064", Offset = "0xAFA064", VA = "0xAFA064", Slot = "61")]
		public bool LeaveRoom(Action onLeftComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x60042F6")]
		[Address(RVA = "0xAFA478", Offset = "0xAFA478", VA = "0xAFA478", Slot = "63")]
		public void VisibleRoom()
		{
		}

		[Token(Token = "0x60042F7")]
		[Address(RVA = "0xAFA5B4", Offset = "0xAFA5B4", VA = "0xAFA5B4", Slot = "64")]
		public void InvisibleRoom()
		{
		}

		[Token(Token = "0x60042F8")]
		[Address(RVA = "0xAFA680", Offset = "0xAFA680", VA = "0xAFA680", Slot = "65")]
		public void CloseRoom()
		{
		}

		[Token(Token = "0x60042F9")]
		[Address(RVA = "0xAFA74C", Offset = "0xAFA74C", VA = "0xAFA74C", Slot = "66")]
		public void OpenRoom()
		{
		}

		[Token(Token = "0x60042FA")]
		[Address(RVA = "0xAFA818", Offset = "0xAFA818", VA = "0xAFA818", Slot = "67")]
		public void C_ReqRoomInfo()
		{
		}

		[Token(Token = "0x60042FB")]
		[Address(RVA = "0xAFA9B0", Offset = "0xAFA9B0", VA = "0xAFA9B0", Slot = "69")]
		public void SendWhiteMsg(string strMsg, bool isTitleMessage = false, float duration = 1f)
		{
		}

		[Token(Token = "0x60042FC")]
		[Address(RVA = "0xAFAB9C", Offset = "0xAFAB9C", VA = "0xAFAB9C", Slot = "70")]
		public void SendWhiteMsg(string strMsgKey, int nCount, bool isTitleMessage = false, float duration = 1f)
		{
		}

		[Token(Token = "0x60042FD")]
		[Address(RVA = "0xAFAA90", Offset = "0xAFAA90", VA = "0xAFAA90")]
		private void HandleWhiteMessage(bool isTitleMessage, string strMsg, string strMsgKey, float duration, bool isUseLocalKey, int nCount = 0)
		{
		}

		[Token(Token = "0x60042FE")]
		[Address(RVA = "0xAFB26C", Offset = "0xAFB26C", VA = "0xAFB26C")]
		private void ShowMessage(bool isTitleMessage, string strMsg, float duration)
		{
		}

		[Token(Token = "0x60042FF")]
		[Address(RVA = "0xAFB4AC", Offset = "0xAFB4AC", VA = "0xAFB4AC", Slot = "116")]
		public void SendReadyTimeoutMessage(int _nCounter)
		{
		}

		[Token(Token = "0x6004300")]
		[Address(RVA = "0xAFB78C", Offset = "0xAFB78C", VA = "0xAFB78C", Slot = "117")]
		public void SendReadyTimeout()
		{
		}

		[Token(Token = "0x6004301")]
		[Address(RVA = "0xAFB8D8", Offset = "0xAFB8D8", VA = "0xAFB8D8", Slot = "118")]
		public void SendUpdatedPing(int ping)
		{
		}

		[Token(Token = "0x6004302")]
		[Address(RVA = "0xAFBB54", Offset = "0xAFBB54", VA = "0xAFBB54", Slot = "71")]
		public void SystemMessageToChat(string strMsg)
		{
		}

		[Token(Token = "0x6004303")]
		[Address(RVA = "0xAFBC24", Offset = "0xAFBC24", VA = "0xAFBC24", Slot = "72")]
		public void Chat(XChatMsgType chatMsgType, string strName, string strMsg)
		{
		}

		[Token(Token = "0x6004304")]
		[Address(RVA = "0xAFBE54", Offset = "0xAFBE54", VA = "0xAFBE54", Slot = "73")]
		public void IngameChat(int id1, int id2, string strName, string strMsg)
		{
		}

		[Token(Token = "0x6004305")]
		[Address(RVA = "0xAFC0F4", Offset = "0xAFC0F4", VA = "0xAFC0F4", Slot = "74")]
		public void SendMsg(string strMsg, bool isTitleMessage = false, float duration = 1f, string msgSoundName = "", bool isUseLocalKey = false)
		{
		}

		[Token(Token = "0x6004306")]
		[Address(RVA = "0xAFC96C", Offset = "0xAFC96C", VA = "0xAFC96C", Slot = "75")]
		public void SendIngameCustomMessage(string strMsgKey, float duration)
		{
		}

		[Token(Token = "0x6004307")]
		[Address(RVA = "0xAFCAC4", Offset = "0xAFCAC4", VA = "0xAFCAC4")]
		private void ShowCustomMessage(string strMsgKey, float duration)
		{
		}

		[Token(Token = "0x6004308")]
		[Address(RVA = "0xAFCEEC", Offset = "0xAFCEEC", VA = "0xAFCEEC", Slot = "76")]
		public void ShowRelayMatchGameStartUI(int round)
		{
		}

		[Token(Token = "0x6004309")]
		[Address(RVA = "0xAFD038", Offset = "0xAFD038", VA = "0xAFD038")]
		private void _ShowRelayMatchGameStartUI(int round)
		{
		}

		[Token(Token = "0x600430A")]
		[Address(RVA = "0xAFC290", Offset = "0xAFC290", VA = "0xAFC290")]
		private void ShowMessage(bool isTitleMessage, string strMsg, float duration, string msgSoundName)
		{
		}

		[Token(Token = "0x600430B")]
		[Address(RVA = "0xAFD318", Offset = "0xAFD318", VA = "0xAFD318", Slot = "77")]
		public void InitGame()
		{
		}

		[Token(Token = "0x600430C")]
		[Address(RVA = "0xAFD67C", Offset = "0xAFD67C", VA = "0xAFD67C", Slot = "78")]
		public void ChangeGameModeState(XGameModeStateType nGameModeState)
		{
		}

		[Token(Token = "0x600430D")]
		[Address(RVA = "0xAFDAF4", Offset = "0xAFDAF4", VA = "0xAFDAF4", Slot = "79")]
		public void SyncPlayerInfo()
		{
		}

		[Token(Token = "0x600430E")]
		[Address(RVA = "0xAFDED8", Offset = "0xAFDED8", VA = "0xAFDED8", Slot = "80")]
		public void MC_SyncRoomInfo()
		{
		}

		[Token(Token = "0x600430F")]
		[Address(RVA = "0xAFE73C", Offset = "0xAFE73C", VA = "0xAFE73C", Slot = "81")]
		public void MC_SpawnDropObject(int nSpawnID, int nCharID, int groupIndex)
		{
		}

		[Token(Token = "0x6004310")]
		[Address(RVA = "0xAFEB7C", Offset = "0xAFEB7C", VA = "0xAFEB7C", Slot = "82")]
		public void SetTeam(int nTargetPhotonID, int nTeamID)
		{
		}

		[Token(Token = "0x6004311")]
		[Address(RVA = "0xAFEEE4", Offset = "0xAFEEE4", VA = "0xAFEEE4", Slot = "83")]
		public void MC_OnEnterGimmickWorkingState(int nGimmickIndex, XMapGimmickWorkingState gimmickState)
		{
		}

		[Token(Token = "0x6004312")]
		[Address(RVA = "0xAFF250", Offset = "0xAFF250", VA = "0xAFF250", Slot = "84")]
		public void M_InteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
		{
		}

		[Token(Token = "0x6004313")]
		[Address(RVA = "0xAFF658", Offset = "0xAFF658", VA = "0xAFF658", Slot = "85")]
		public void M_CancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
		{
		}

		[Token(Token = "0x6004314")]
		[Address(RVA = "0xAFF9C0", Offset = "0xAFF9C0", VA = "0xAFF9C0", Slot = "86")]
		public void C_ReqInteractionCapturePoint(int nPointObjectIndex)
		{
		}

		[Token(Token = "0x6004315")]
		[Address(RVA = "0xAFFDBC", Offset = "0xAFFDBC", VA = "0xAFFDBC", Slot = "87")]
		public void C_ReqCancelInteractionCapturePoint(int nPointObjectIndex)
		{
		}

		[Token(Token = "0x6004316")]
		[Address(RVA = "0xB001B8", Offset = "0xB001B8", VA = "0xB001B8", Slot = "88")]
		public void M_CapturePointA_SyncGameModeData([Optional] PhotonPlayer photonPlayaer)
		{
		}

		[Token(Token = "0x6004317")]
		[Address(RVA = "0xB004E8", Offset = "0xB004E8", VA = "0xB004E8", Slot = "89")]
		public void SetMasterZombie(int nTargetPhotonID)
		{
		}

		[Token(Token = "0x6004318")]
		[Address(RVA = "0xB007F4", Offset = "0xB007F4", VA = "0xB007F4", Slot = "90")]
		public void SetTagger(int nTargetPhotonID, bool ignoreJudgementTime, int itemID)
		{
		}

		[Token(Token = "0x6004319")]
		[Address(RVA = "0xB00C4C", Offset = "0xB00C4C", VA = "0xB00C4C", Slot = "91")]
		public void RequestTaggerChooseToMasterClient(int itemID = 0, bool isDieEvent = false)
		{
		}

		[Token(Token = "0x600431A")]
		[Address(RVA = "0xB01054", Offset = "0xB01054", VA = "0xB01054", Slot = "92")]
		public void M_ZombieTag_SyncGameModeData()
		{
		}

		[Token(Token = "0x600431B")]
		[Address(RVA = "0xB01398", Offset = "0xB01398", VA = "0xB01398", Slot = "93")]
		public void StartRound(int nRound)
		{
		}

		[Token(Token = "0x600431C")]
		[Address(RVA = "0xB01614", Offset = "0xB01614", VA = "0xB01614", Slot = "94")]
		public void SendRoundResult(int nRound, int nPhotonID_0, short result_0, int nPhotonID_1, short result_1)
		{
		}

		[Token(Token = "0x600431D")]
		[Address(RVA = "0xB01C10", Offset = "0xB01C10", VA = "0xB01C10", Slot = "96")]
		public void Annihilation_StartRound(int nRound)
		{
		}

		[Token(Token = "0x600431E")]
		[Address(RVA = "0xB01E8C", Offset = "0xB01E8C", VA = "0xB01E8C", Slot = "97")]
		public void Annihilation_SendRoundResult(int nRound, short result_TeamA, short result_TeamB)
		{
		}

		[Token(Token = "0x600431F")]
		[Address(RVA = "0xB022D8", Offset = "0xB022D8", VA = "0xB022D8", Slot = "100")]
		public void CasualMode_StartRound(int round)
		{
		}

		[Token(Token = "0x6004320")]
		[Address(RVA = "0xB02468", Offset = "0xB02468", VA = "0xB02468", Slot = "101")]
		public void CasualMode_EndRound(int round, XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x6004321")]
		[Address(RVA = "0xB02670", Offset = "0xB02670", VA = "0xB02670", Slot = "102")]
		public void CasualMode_EndMode(XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x6004322")]
		[Address(RVA = "0xB02800", Offset = "0xB02800", VA = "0xB02800", Slot = "103")]
		public void CasualMode_SetPlayerRecord(string aid, PlayerProperty prop, object v)
		{
		}

		[Token(Token = "0x6004323")]
		[Address(RVA = "0xB02A3C", Offset = "0xB02A3C", VA = "0xB02A3C", Slot = "104")]
		public void CasualMode_RegisterEventReceiver(ICasualModeEventReceiver receiver)
		{
		}

		[Token(Token = "0x6004324")]
		[Address(RVA = "0xB02A6C", Offset = "0xB02A6C", VA = "0xB02A6C", Slot = "105")]
		public void CasualMode_RemoveEventReceiver()
		{
		}

		[Token(Token = "0x6004325")]
		[Address(RVA = "0xB02AA0", Offset = "0xB02AA0", VA = "0xB02AA0", Slot = "98")]
		public void Annihilation_SyncGameTime(float remain_Time)
		{
		}

		[Token(Token = "0x6004326")]
		[Address(RVA = "0xB02D2C", Offset = "0xB02D2C", VA = "0xB02D2C", Slot = "99")]
		public void Annihilation_SyncGameState(int gameState)
		{
		}

		[Token(Token = "0x6004327")]
		[Address(RVA = "0xB02FA8", Offset = "0xB02FA8", VA = "0xB02FA8", Slot = "95")]
		public void Annihilation_SendLoseLifePlayer()
		{
		}

		[Token(Token = "0x6004328")]
		[Address(RVA = "0xB03140", Offset = "0xB03140", VA = "0xB03140", Slot = "106")]
		public void AddStats_Send(string name, PhotonTargets target, params object[] args)
		{
		}

		[Token(Token = "0x6004329")]
		[Address(RVA = "0xB03174", Offset = "0xB03174", VA = "0xB03174", Slot = "107")]
		public void AddStats_Send(string name, params object[] args)
		{
		}

		[Token(Token = "0x600432A")]
		[Address(RVA = "0xB031A8", Offset = "0xB031A8", VA = "0xB031A8", Slot = "108")]
		public void AddStats_Recv(string name, params object[] args)
		{
		}

		[Token(Token = "0x600432E")]
		[Address(RVA = "0xAF4564", Offset = "0xAF4564", VA = "0xAF4564", Slot = "4")]
		public XPhotonNetwork GetPhotonNetwork()
		{
			return null;
		}

		[Token(Token = "0x600432F")]
		[Address(RVA = "0xAF61F0", Offset = "0xAF61F0", VA = "0xAF61F0")]
		private RoomOptions MakeRoomOptions(bool isVisible, bool isOpen, byte maxPlayers, ExitGames.Client.Photon.Hashtable customRoomProperties, string[] propsToListInLobby, string pluginName, int emptyRoomTtl = 0)
		{
			return null;
		}

		[Token(Token = "0x6004330")]
		[Address(RVA = "0xB03330", Offset = "0xB03330", VA = "0xB03330", Slot = "38")]
		public bool WebRpc(string name, Dictionary<int, object> param)
		{
			return default(bool);
		}

		[Token(Token = "0x6004331")]
		[Address(RVA = "0xB034A8", Offset = "0xB034A8", VA = "0xB034A8", Slot = "109")]
		public void InGameRaiseEvent(InGameRaiseEventContent Content, bool sendReliable, RaiseEventOptions options)
		{
		}

		[Token(Token = "0x6004332")]
		[Address(RVA = "0xB03790", Offset = "0xB03790", VA = "0xB03790", Slot = "110")]
		public void OnInGameRaiseEvent(Dictionary<byte, object> data, int senderId)
		{
		}

		[Token(Token = "0x6004333")]
		[Address(RVA = "0xB0681C", Offset = "0xB0681C", VA = "0xB0681C", Slot = "111")]
		public void WebHttpRaiseEvent(WebHttpRaiseEventContent Content, bool sendReliable, RaiseEventOptions options)
		{
		}

		[Token(Token = "0x6004334")]
		[Address(RVA = "0xB06AF0", Offset = "0xB06AF0", VA = "0xB06AF0", Slot = "112")]
		public void OnWebHttpRaiseEvent(Dictionary<byte, object> data, int senderId)
		{
		}

		[Token(Token = "0x6004335")]
		[Address(RVA = "0xB07714", Offset = "0xB07714", VA = "0xB07714", Slot = "113")]
		public void OnCustomRaiseEventErrorInfo(Dictionary<byte, object> dicContent)
		{
		}

		[Token(Token = "0x6004336")]
		[Address(RVA = "0xB077E8", Offset = "0xB077E8", VA = "0xB077E8")]
		private void OnCustomRaiseEventErrorInGameStart(CustomRaiseEventError content)
		{
		}

		[Token(Token = "0x6004337")]
		[Address(RVA = "0xB079AC", Offset = "0xB079AC", VA = "0xB079AC")]
		private void OnCustomRaiseEventErrorInGameFinish(CustomRaiseEventError content)
		{
		}

		[Token(Token = "0x6004338")]
		[Address(RVA = "0xB06A2C", Offset = "0xB06A2C", VA = "0xB06A2C")]
		private string MakeURIContent(string url, string content)
		{
			return null;
		}

		[Token(Token = "0x6004339")]
		[Address(RVA = "0xB07AFC", Offset = "0xB07AFC", VA = "0xB07AFC", Slot = "115")]
		public bool ChangeMasterClient()
		{
			return default(bool);
		}

		[Token(Token = "0x600433A")]
		[Address(RVA = "0xB080AC", Offset = "0xB080AC", VA = "0xB080AC")]
		private bool TryGetFindNextMasterClient(int curMasterID, int playerCount, out PhotonPlayer newMasterClientPhotonPlayer, out XPlayer player)
		{
			newMasterClientPhotonPlayer = default;
			player = default;
			return default(bool);
		}

		[Token(Token = "0x600433B")]
		[Address(RVA = "0xB08404", Offset = "0xB08404", VA = "0xB08404", Slot = "119")]
		public string GetRoomName()
		{
			return null;
		}

		[Token(Token = "0x600433C")]
		[Address(RVA = "0xB05DA8", Offset = "0xB05DA8", VA = "0xB05DA8")]
		internal void OnPlayerKick(string playerName, byte photonID)
		{
		}

		[Token(Token = "0x600433D")]
		[Address(RVA = "0xB05FEC", Offset = "0xB05FEC", VA = "0xB05FEC")]
		internal void OnPlayerBan(string playerName, byte photonID)
		{
		}

		[Token(Token = "0x600433E")]
		[Address(RVA = "0xB06328", Offset = "0xB06328", VA = "0xB06328")]
		internal void OnPlayerBanForSpeedHack(string playerName, byte photonID, SpeedHackLogData logData)
		{
		}

		[Token(Token = "0x600433F")]
		[Address(RVA = "0xB070E8", Offset = "0xB070E8", VA = "0xB070E8")]
		private void OnFinishExitDuringTheGame(Dictionary<byte, object> contentData)
		{
		}

		[Token(Token = "0x6004340")]
		[Address(RVA = "0xB06C64", Offset = "0xB06C64", VA = "0xB06C64")]
		private void OnInGameFinish(Dictionary<byte, object> contentData)
		{
		}

		[Token(Token = "0x6004341")]
		[Address(RVA = "0xB089CC", Offset = "0xB089CC", VA = "0xB089CC")]
		private bool RetryWebHttpInGameFinish(IEnumerator action)
		{
			return default(bool);
		}

		[Token(Token = "0x6004342")]
		[Address(RVA = "0xB08A1C", Offset = "0xB08A1C", VA = "0xB08A1C")]
		[DebuggerHidden]
		private IEnumerator CoroutinInGameFinish(float fDelayTime)
		{
			return null;
		}

		[Token(Token = "0x6004343")]
		[Address(RVA = "0xB08920", Offset = "0xB08920", VA = "0xB08920")]
		[DebuggerHidden]
		private IEnumerator CoroutinFinishExitDuringTheGame(float fDelayTime)
		{
			return null;
		}

		[Token(Token = "0x6004344")]
		[Address(RVA = "0xB084E4", Offset = "0xB084E4", VA = "0xB084E4")]
		private void UpdateRoomPropertiesBanPlayer(string playerName)
		{
		}

		[Token(Token = "0x6004345")]
		[Address(RVA = "0xB08CF8", Offset = "0xB08CF8", VA = "0xB08CF8", Slot = "133")]
		public void UpdateRoomPropertiesRoomPlayer(string playerName)
		{
		}

		[Token(Token = "0x6004346")]
		[Address(RVA = "0xB090A4", Offset = "0xB090A4", VA = "0xB090A4", Slot = "120")]
		public void SyncToMasterClient()
		{
		}

		[Token(Token = "0x6004347")]
		[Address(RVA = "0xB09128", Offset = "0xB09128", VA = "0xB09128", Slot = "121")]
		public void SendOutgoingCommands()
		{
		}

		[Token(Token = "0x6004348")]
		[Address(RVA = "0xB091C8", Offset = "0xB091C8", VA = "0xB091C8", Slot = "122")]
		public void SetPhotonReqestHello(XPhotonNetworkRequestHello requestHello)
		{
		}

		[Token(Token = "0x6004349")]
		[Address(RVA = "0xB091F8", Offset = "0xB091F8", VA = "0xB091F8", Slot = "123")]
		public void DivideTeam(NetData_PlayerTeamSetting netDataPlayerTeam)
		{
		}

		[Token(Token = "0x600434A")]
		[Address(RVA = "0xB09438", Offset = "0xB09438", VA = "0xB09438", Slot = "124")]
		public string GetRPCDebugLog()
		{
			return null;
		}

		[Token(Token = "0x600434B")]
		[Address(RVA = "0xB09730", Offset = "0xB09730", VA = "0xB09730", Slot = "125")]
		public void ResetAuthValues()
		{
		}

		[Token(Token = "0x600434C")]
		[Address(RVA = "0xB097D4", Offset = "0xB097D4", VA = "0xB097D4", Slot = "68")]
		public ModUserLog GetModUserLog()
		{
			return null;
		}

		[Token(Token = "0x600434D")]
		[Address(RVA = "0xB097DC", Offset = "0xB097DC", VA = "0xB097DC", Slot = "126")]
		public bool FindFriends(string[] firendsAID)
		{
			return default(bool);
		}

		[Token(Token = "0x600434E")]
		[Address(RVA = "0xB09884", Offset = "0xB09884", VA = "0xB09884", Slot = "127")]
		public List<FriendInfo> FriendsInfo()
		{
			return null;
		}

		[Token(Token = "0x600434F")]
		[Address(RVA = "0xB09924", Offset = "0xB09924", VA = "0xB09924", Slot = "128")]
		public bool CreateParty(NetMatchPlayerInfo player, XGameModeType gameMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6004350")]
		[Address(RVA = "0xB09B28", Offset = "0xB09B28", VA = "0xB09B28", Slot = "129")]
		public bool JoinParty(long partyKey, NetMatchPlayerInfo player)
		{
			return default(bool);
		}

		[Token(Token = "0x6004351")]
		[Address(RVA = "0xB09D40", Offset = "0xB09D40", VA = "0xB09D40", Slot = "130")]
		public bool LeaveParty()
		{
			return default(bool);
		}

		[Token(Token = "0x6004352")]
		[Address(RVA = "0xB09E04", Offset = "0xB09E04", VA = "0xB09E04", Slot = "131")]
		public bool StartPartyGame(int sectorID, XGameModeType gameMode, MatchType matchType = MatchType.Normal)
		{
			return default(bool);
		}

		[Token(Token = "0x6004353")]
		[Address(RVA = "0xB09FE4", Offset = "0xB09FE4", VA = "0xB09FE4", Slot = "36")]
		public bool ChangeReadyState(bool isReady)
		{
			return default(bool);
		}

		[Token(Token = "0x6004354")]
		[Address(RVA = "0xB0A134", Offset = "0xB0A134", VA = "0xB0A134", Slot = "37")]
		public bool ChangePartyInfoState(XGameModeType gameMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6004355")]
		[Address(RVA = "0xB0A284", Offset = "0xB0A284", VA = "0xB0A284", Slot = "132")]
		public void UpdateRoomPropertiesLeavePlayer(string leavePlayersName)
		{
		}

		[Token(Token = "0x6004356")]
		[Address(RVA = "0xB0A3F0", Offset = "0xB0A3F0", VA = "0xB0A3F0", Slot = "134")]
		public void SetInterestGroups(byte group, bool enabled)
		{
		}

		[Token(Token = "0x6004357")]
		[Address(RVA = "0xB0A4A0", Offset = "0xB0A4A0", VA = "0xB0A4A0", Slot = "135")]
		public void CheckMyTeamToMasterClient()
		{
		}

		[Token(Token = "0x6004358")]
		[Address(RVA = "0xB0A5B0", Offset = "0xB0A5B0", VA = "0xB0A5B0", Slot = "136")]
		public void SendToMyTeamInfoInFriendlyMatch(byte teamInfo, [Optional] PhotonPlayer targetPlayer)
		{
		}

		[Token(Token = "0x6004359")]
		[Address(RVA = "0xB0A80C", Offset = "0xB0A80C", VA = "0xB0A80C", Slot = "137")]
		public void AddAreaOfEffectBuff(int buffID, BuffTargetType eBuffTargetType)
		{
		}

		[Token(Token = "0x600435A")]
		[Address(RVA = "0xB0AA14", Offset = "0xB0AA14", VA = "0xB0AA14", Slot = "138")]
		public void OnComplteGame()
		{
		}
	}

	[Token(Token = "0x2000846")]
	public interface IPhotonNetwork
	{
		[Token(Token = "0x17000959")]
		bool connected
		{
			[Token(Token = "0x6004368")]
			get;
		}

		[Token(Token = "0x1700095A")]
		int RoundTripTime
		{
			[Token(Token = "0x600436C")]
			get;
		}

		[Token(Token = "0x1700095B")]
		bool offlineMode
		{
			[Token(Token = "0x600436D")]
			get;
			[Token(Token = "0x600436E")]
			set;
		}

		[Token(Token = "0x1700095C")]
		ClientState connectionStateDetailed
		{
			[Token(Token = "0x6004371")]
			get;
		}

		[Token(Token = "0x1700095D")]
		int PlayersInRoomsCount
		{
			[Token(Token = "0x6004390")]
			get;
		}

		[Token(Token = "0x1700095E")]
		float Time
		{
			[Token(Token = "0x6004391")]
			get;
		}

		[Token(Token = "0x1700095F")]
		bool isMasterClient
		{
			[Token(Token = "0x6004392")]
			get;
		}

		[Token(Token = "0x17000960")]
		bool isMessageQueueRunning
		{
			[Token(Token = "0x6004393")]
			get;
			[Token(Token = "0x6004394")]
			set;
		}

		[Token(Token = "0x17000961")]
		PhotonPlayer player
		{
			[Token(Token = "0x6004396")]
			get;
		}

		[Token(Token = "0x17000962")]
		PhotonPlayer[] playerList
		{
			[Token(Token = "0x6004397")]
			get;
		}

		[Token(Token = "0x17000963")]
		PhotonPlayer[] otherPlayer
		{
			[Token(Token = "0x6004398")]
			get;
		}

		[Token(Token = "0x17000964")]
		Room room
		{
			[Token(Token = "0x6004399")]
			get;
		}

		[Token(Token = "0x17000965")]
		int PlayerCountInThisRoom
		{
			[Token(Token = "0x60043A1")]
			get;
		}

		[Token(Token = "0x6004367")]
		XPhotonNetwork GetPhotonNetwork();

		[Token(Token = "0x6004369")]
		void ConnectToMasterServer();

		[Token(Token = "0x600436A")]
		void TryConnectToMasterServer();

		[Token(Token = "0x600436B")]
		void DisconnectToMasterServer();

		[Token(Token = "0x600436F")]
		void UpdateUsername();

		[Token(Token = "0x6004370")]
		int GetPing();

		[Token(Token = "0x6004372")]
		RoomInfo[] GetRoomList();

		[Token(Token = "0x6004373")]
		bool TryGetRoomInfo(string roomName, out RoomInfo roomInfo);

		[Token(Token = "0x6004374")]
		bool CreateRoom(string roomName, MatchType nMatchType, XGameModeType nGameModeType, int gameModeInstanceId, int nSectorID, bool isNewbie, string friendlyRoomName = "", string friendlyPassword = "", string friendlyMasterName = "");

		[Token(Token = "0x6004375")]
		bool CreatePartyRoom(string roomName, GameModeInstanceInfo gameModeInstInfo, int nSectorID, int roomElo, bool isVisible);

		[Token(Token = "0x6004376")]
		bool CreateCustomRoom(string roomName, CustomRoomInfo roomInfo);

		[Token(Token = "0x6004377")]
		bool JoinRoom(string strRoomName);

		[Token(Token = "0x6004378")]
		bool JoinRoomForce(string strRoomName);

		[Token(Token = "0x6004379")]
		bool ReJoinRoom(string strRoomName);

		[Token(Token = "0x600437A")]
		bool JoinFriendlyMatch(XGameModeType mode, int gameModeInstanceId, int nSectorID, string friendlyRoomName, string friendlyPhotonRoomName, string friendlyPassword, string friendlyMasterName);

		[Token(Token = "0x600437B")]
		bool JoinMatch(GameModeInstanceInfo gameModeInstanceInfo, int sectorID, int eloPt, Action OnCancel);

		[Token(Token = "0x600437C")]
		bool JoinMatch(GameModeInstanceInfo gameModeInstanceInfo, int nSectorID, int eloPt, bool isNewbie);

		[Token(Token = "0x600437D")]
		bool CancelMatch();

		[Token(Token = "0x600437E")]
		bool MatchGameStart();

		[Token(Token = "0x600437F")]
		bool LeaveMatchRoom();

		[Token(Token = "0x6004380")]
		bool CreateClanParty(GameModeInstanceInfo gameModeInstinfo, string clanID, NetMatchPlayerInfo player);

		[Token(Token = "0x6004381")]
		bool JoinClanParty(long partyKey, XGameModeType nGameModeType, string clanID, NetMatchPlayerInfo player);

		[Token(Token = "0x6004382")]
		bool LeaveClanParty();

		[Token(Token = "0x6004383")]
		bool RefreshClanParty(long partyKey);

		[Token(Token = "0x6004384")]
		bool GetClanPartyList(string clanID, long getTimeStamp);

		[Token(Token = "0x6004385")]
		bool StartClanwar();

		[Token(Token = "0x6004386")]
		bool UpdateUserList();

		[Token(Token = "0x6004387")]
		bool ChangeReadyState(bool isReady);

		[Token(Token = "0x6004388")]
		bool ChangePartyInfoState(XGameModeType gameMode);

		[Token(Token = "0x6004389")]
		bool WebRpc(string name, Dictionary<int, object> param);

		[Token(Token = "0x600438A")]
		void ProcessRoomSelectorHistory(XGameModeType nGameModeType, CSWinlose winlose, int nRank);

		[Token(Token = "0x600438B")]
		int FindFriendlyRoomSectorId(XGameModeType mode, string strRoomName);

		[Token(Token = "0x600438C")]
		int RecommendSectorId(GameModeInstanceInfo gameModeInstanceInfo, EventGameModeInfo eventGameModeInfo, bool isQuickMatch, XQuickMatchOptionData quickMatchOption);

		[Token(Token = "0x600438D")]
		XGameModeType RecommendPVPGameMode(XQuickMatchOptionData quickMatchOption);

		[Token(Token = "0x600438E")]
		int GetModeTotalRoomCount(MatchType matchType, XGameModeType mode);

		[Token(Token = "0x600438F")]
		int GetModeWaitingRoomCount(MatchType matchType, XGameModeType mode);

		[Token(Token = "0x6004395")]
		PhotonPlayer Find(int ID);

		[Token(Token = "0x600439A")]
		void LoadLevel(string strSceneName);

		[Token(Token = "0x600439B")]
		void LoadLevel(int nLevelNumber);

		[Token(Token = "0x600439C")]
		GameObject InstantiateSceneObject(string prefabName, int actorID, int level, XTeamEnum team, Vector3 position, Quaternion rotation, byte group, bool isSceneObject);

		[Token(Token = "0x600439D")]
		GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group);

		[Token(Token = "0x600439E")]
		void UpdateRoomProperties(bool player_count_update = false);

		[Token(Token = "0x600439F")]
		int GetMyPhotonID();

		[Token(Token = "0x60043A0")]
		bool LeaveRoom(Action onLeftComplete);

		[Token(Token = "0x60043A2")]
		void VisibleRoom();

		[Token(Token = "0x60043A3")]
		void InvisibleRoom();

		[Token(Token = "0x60043A4")]
		void CloseRoom();

		[Token(Token = "0x60043A5")]
		void OpenRoom();

		[Token(Token = "0x60043A6")]
		void C_ReqRoomInfo();

		[Token(Token = "0x60043A7")]
		ModUserLog GetModUserLog();

		[Token(Token = "0x60043A8")]
		void SendWhiteMsg(string strMsg, bool isTitleMessage = false, float duration = 1f);

		[Token(Token = "0x60043A9")]
		void SendWhiteMsg(string strMsgKey, int nCount, bool isTitleMessage = false, float duration = 1f);

		[Token(Token = "0x60043AA")]
		void SystemMessageToChat(string strMsg);

		[Token(Token = "0x60043AB")]
		void Chat(XChatMsgType chatMsgType, string strName, string strMsg);

		[Token(Token = "0x60043AC")]
		void IngameChat(int profileId, int titleId, string strName, string strMsg);

		[Token(Token = "0x60043AD")]
		void SendMsg(string strMsg, bool isTitleMessage = false, float duration = 1f, string msgSoundName = "", bool isUseLocalKey = false);

		[Token(Token = "0x60043AE")]
		void SendIngameCustomMessage(string strMsgKey, float duration);

		[Token(Token = "0x60043AF")]
		void ShowRelayMatchGameStartUI(int round);

		[Token(Token = "0x60043B0")]
		void InitGame();

		[Token(Token = "0x60043B1")]
		void ChangeGameModeState(XGameModeStateType nGameModeState);

		[Token(Token = "0x60043B2")]
		void SyncPlayerInfo();

		[Token(Token = "0x60043B3")]
		void MC_SyncRoomInfo();

		[Token(Token = "0x60043B4")]
		void MC_SpawnDropObject(int nSpawnID, int nCharID, int groupIndex);

		[Token(Token = "0x60043B5")]
		void SetTeam(int nTargetPhotonID, int nTeamID);

		[Token(Token = "0x60043B6")]
		void MC_OnEnterGimmickWorkingState(int nGimmickIndex, XMapGimmickWorkingState gimmickState);

		[Token(Token = "0x60043B7")]
		void M_InteractionCapturePoint(int nPointObjectIndex, int nPhotonID);

		[Token(Token = "0x60043B8")]
		void M_CancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID);

		[Token(Token = "0x60043B9")]
		void C_ReqInteractionCapturePoint(int nPointObjectIndex);

		[Token(Token = "0x60043BA")]
		void C_ReqCancelInteractionCapturePoint(int nPointObjectIndex);

		[Token(Token = "0x60043BB")]
		void M_CapturePointA_SyncGameModeData([Optional] PhotonPlayer targetPlayer);

		[Token(Token = "0x60043BC")]
		void SetMasterZombie(int nTargetPhotonID);

		[Token(Token = "0x60043BD")]
		void SetTagger(int nTargetPhotonID, bool ignoreJudgementTime = false, int itemID = 0);

		[Token(Token = "0x60043BE")]
		void RequestTaggerChooseToMasterClient(int itemID = 0, bool isDieEvent = false);

		[Token(Token = "0x60043BF")]
		void M_ZombieTag_SyncGameModeData();

		[Token(Token = "0x60043C0")]
		void StartRound(int nRound);

		[Token(Token = "0x60043C1")]
		void SendRoundResult(int nRound, int nPhotonID_0, short result_0, int nPhotonID_1, short result_1);

		[Token(Token = "0x60043C2")]
		void Annihilation_SendLoseLifePlayer();

		[Token(Token = "0x60043C3")]
		void Annihilation_StartRound(int nRound);

		[Token(Token = "0x60043C4")]
		void Annihilation_SendRoundResult(int nRound, short result_TeamA, short result_TeamB);

		[Token(Token = "0x60043C5")]
		void Annihilation_SyncGameTime(float remain_Time);

		[Token(Token = "0x60043C6")]
		void Annihilation_SyncGameState(int gameState);

		[Token(Token = "0x60043C7")]
		void CasualMode_StartRound(int round);

		[Token(Token = "0x60043C8")]
		void CasualMode_EndRound(int round, XTeamEnum winTeam);

		[Token(Token = "0x60043C9")]
		void CasualMode_EndMode(XTeamEnum winTeam);

		[Token(Token = "0x60043CA")]
		void CasualMode_SetPlayerRecord(string aid, PlayerProperty prop, object v);

		[Token(Token = "0x60043CB")]
		void CasualMode_RegisterEventReceiver(ICasualModeEventReceiver receiver);

		[Token(Token = "0x60043CC")]
		void CasualMode_RemoveEventReceiver();

		[Token(Token = "0x60043CD")]
		void AddStats_Send(string name, PhotonTargets target, params object[] args);

		[Token(Token = "0x60043CE")]
		void AddStats_Send(string name, params object[] args);

		[Token(Token = "0x60043CF")]
		void AddStats_Recv(string name, params object[] args);

		[Token(Token = "0x60043D0")]
		void InGameRaiseEvent(InGameRaiseEventContent Content, bool sendReliable, RaiseEventOptions options);

		[Token(Token = "0x60043D1")]
		void OnInGameRaiseEvent(Dictionary<byte, object> content, int senderId);

		[Token(Token = "0x60043D2")]
		void WebHttpRaiseEvent(WebHttpRaiseEventContent eventContent, bool sendReliable, RaiseEventOptions options);

		[Token(Token = "0x60043D3")]
		void OnWebHttpRaiseEvent(Dictionary<byte, object> content, int senderId);

		[Token(Token = "0x60043D4")]
		void OnCustomRaiseEventErrorInfo(Dictionary<byte, object> dicContent);

		[Token(Token = "0x60043D5")]
		void ReconnectAndRejoin();

		[Token(Token = "0x60043D6")]
		bool ChangeMasterClient();

		[Token(Token = "0x60043D7")]
		void SendReadyTimeoutMessage(int _nCounter);

		[Token(Token = "0x60043D8")]
		void SendReadyTimeout();

		[Token(Token = "0x60043D9")]
		void SendUpdatedPing(int ping);

		[Token(Token = "0x60043DA")]
		string GetRoomName();

		[Token(Token = "0x60043DB")]
		void SyncToMasterClient();

		[Token(Token = "0x60043DC")]
		void SendOutgoingCommands();

		[Token(Token = "0x60043DD")]
		void SetPhotonReqestHello(XPhotonNetworkRequestHello requestHello);

		[Token(Token = "0x60043DE")]
		void DivideTeam(NetData_PlayerTeamSetting netDataPlayerTeam);

		[Token(Token = "0x60043DF")]
		string GetRPCDebugLog();

		[Token(Token = "0x60043E0")]
		void ResetAuthValues();

		[Token(Token = "0x60043E1")]
		bool FindFriends(string[] firendsAID);

		[Token(Token = "0x60043E2")]
		List<FriendInfo> FriendsInfo();

		[Token(Token = "0x60043E3")]
		bool CreateParty(NetMatchPlayerInfo player, XGameModeType gameMode);

		[Token(Token = "0x60043E4")]
		bool JoinParty(long partyKey, NetMatchPlayerInfo player);

		[Token(Token = "0x60043E5")]
		bool LeaveParty();

		[Token(Token = "0x60043E6")]
		bool StartPartyGame(int sectorID, XGameModeType gameMode, MatchType matchType = MatchType.Normal);

		[Token(Token = "0x60043E7")]
		void UpdateRoomPropertiesLeavePlayer(string nickname);

		[Token(Token = "0x60043E8")]
		void UpdateRoomPropertiesRoomPlayer(string playerName);

		[Token(Token = "0x60043E9")]
		void SetInterestGroups(byte group, bool enabled);

		[Token(Token = "0x60043EA")]
		void CheckMyTeamToMasterClient();

		[Token(Token = "0x60043EB")]
		void SendToMyTeamInfoInFriendlyMatch(byte teamInfo, [Optional] PhotonPlayer targetPlayer);

		[Token(Token = "0x60043EC")]
		void AddAreaOfEffectBuff(int buffID, BuffTargetType eBuffTargetType);

		[Token(Token = "0x60043ED")]
		void OnComplteGame();
	}

	[Token(Token = "0x2000847")]
	public class ModUserLogEntry
	{
		[Token(Token = "0x40023C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float curDamageRatioSum;

		[Token(Token = "0x40023C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<float> damageRatioSumList;

		[Token(Token = "0x40023C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<int, float> ignoredCoolTimes;

		[Token(Token = "0x40023C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Dictionary<int, int> ignoredAnimationCount;

		[Token(Token = "0x40023C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int ultUseCount;

		[Token(Token = "0x40023C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int ultBuffCount;

		[Token(Token = "0x60043EE")]
		[Address(RVA = "0xAF0B64", Offset = "0xAF0B64", VA = "0xAF0B64")]
		public ModUserLogEntry()
		{
		}

		[Token(Token = "0x60043EF")]
		[Address(RVA = "0xAF0F88", Offset = "0xAF0F88", VA = "0xAF0F88")]
		public bool IsModUser(ModUserLog.Param param)
		{
			return default(bool);
		}

		[Token(Token = "0x60043F0")]
		[Address(RVA = "0xAF1A4C", Offset = "0xAF1A4C", VA = "0xAF1A4C")]
		private bool IsDamageMod(int damageToller)
		{
			return default(bool);
		}

		[Token(Token = "0x60043F1")]
		[Address(RVA = "0xAF1B78", Offset = "0xAF1B78", VA = "0xAF1B78")]
		private bool IsCoolTimeMod()
		{
			return default(bool);
		}

		[Token(Token = "0x60043F2")]
		[Address(RVA = "0xAF1C20", Offset = "0xAF1C20", VA = "0xAF1C20")]
		private bool IsAniTimeMod(int toller)
		{
			return default(bool);
		}

		[Token(Token = "0x60043F3")]
		[Address(RVA = "0xAF1EB0", Offset = "0xAF1EB0", VA = "0xAF1EB0")]
		public bool IsUltMod(int ultToller, float playTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60043F4")]
		[Address(RVA = "0xAF1F18", Offset = "0xAF1F18", VA = "0xAF1F18")]
		private int GetUltUsePerMin(float playTime)
		{
			return default(int);
		}

		[Token(Token = "0x60043F5")]
		[Address(RVA = "0xAF1FF4", Offset = "0xAF1FF4", VA = "0xAF1FF4")]
		private void PushCurrentToList()
		{
		}

		[Token(Token = "0x60043F6")]
		[Address(RVA = "0xAF2090", Offset = "0xAF2090", VA = "0xAF2090")]
		private void ClearCurrent()
		{
		}

		[Token(Token = "0x60043F7")]
		[Address(RVA = "0xAF1EF4", Offset = "0xAF1EF4", VA = "0xAF1EF4")]
		public bool ValidateDamageRatioSum(float damageRatio, int toller)
		{
			return default(bool);
		}

		[Token(Token = "0x60043F8")]
		[Address(RVA = "0xAF0A88", Offset = "0xAF0A88", VA = "0xAF0A88")]
		public void OnDie()
		{
		}

		[Token(Token = "0x60043F9")]
		[Address(RVA = "0xAF07F4", Offset = "0xAF07F4", VA = "0xAF07F4")]
		public void OnUseSkillIgnoringCooltime(int skillID, float ignoredCool)
		{
		}

		[Token(Token = "0x60043FA")]
		[Address(RVA = "0xAF091C", Offset = "0xAF091C", VA = "0xAF091C")]
		public void OnUseSkillIgnoringAnimationTime(int skillID)
		{
		}

		[Token(Token = "0x60043FB")]
		[Address(RVA = "0xAF0A3C", Offset = "0xAF0A3C", VA = "0xAF0A3C")]
		public void OnDamage(float damageRatio)
		{
		}

		[Token(Token = "0x60043FC")]
		[Address(RVA = "0xAF0B50", Offset = "0xAF0B50", VA = "0xAF0B50")]
		public void OnRecover(float recoveredRatio)
		{
		}

		[Token(Token = "0x60043FD")]
		[Address(RVA = "0xAF0AD0", Offset = "0xAF0AD0", VA = "0xAF0AD0")]
		public void OnUseUlt()
		{
		}

		[Token(Token = "0x60043FE")]
		[Address(RVA = "0xAF0B0C", Offset = "0xAF0B0C", VA = "0xAF0B0C")]
		public void OnChargeUlt()
		{
		}

		[Token(Token = "0x60043FF")]
		[Address(RVA = "0xAF12D4", Offset = "0xAF12D4", VA = "0xAF12D4")]
		public string Log(ModUserLog.Param param)
		{
			return null;
		}
	}

	[Token(Token = "0x2000848")]
	public class ModUserLog
	{
		[Token(Token = "0x2000849")]
		public struct Param
		{
			[Token(Token = "0x40023CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int damageToller;

			[Token(Token = "0x40023CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int ultToller;

			[Token(Token = "0x40023CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int aniCountToller;

			[Token(Token = "0x40023CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float playTime;
		}

		[Token(Token = "0x40023CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Dictionary<string, ModUserLogEntry> log;

		[Token(Token = "0x6004400")]
		[Address(RVA = "0xAF05F0", Offset = "0xAF05F0", VA = "0xAF05F0")]
		public ModUserLog()
		{
		}

		[Token(Token = "0x6004401")]
		[Address(RVA = "0xAF069C", Offset = "0xAF069C", VA = "0xAF069C")]
		public void OnUseSkillIgnoringCooltime(string nickName, int skillID, float ignoredCool)
		{
		}

		[Token(Token = "0x6004402")]
		[Address(RVA = "0xAF08EC", Offset = "0xAF08EC", VA = "0xAF08EC")]
		public void OnUseSkillIgnoringAnimationTime(string nickName, int skillID)
		{
		}

		[Token(Token = "0x6004403")]
		[Address(RVA = "0xAF0A08", Offset = "0xAF0A08", VA = "0xAF0A08")]
		public void OnDamage(string nickName, float damageRatio)
		{
		}

		[Token(Token = "0x6004404")]
		[Address(RVA = "0xAF0A50", Offset = "0xAF0A50", VA = "0xAF0A50")]
		public void OnDie(string nickName)
		{
		}

		[Token(Token = "0x6004405")]
		[Address(RVA = "0xAF0AA4", Offset = "0xAF0AA4", VA = "0xAF0AA4")]
		public void OnUseUlt(string nickName)
		{
		}

		[Token(Token = "0x6004406")]
		[Address(RVA = "0xAF0AE0", Offset = "0xAF0AE0", VA = "0xAF0AE0")]
		public void OnChargeUlt(string nickName)
		{
		}

		[Token(Token = "0x6004407")]
		[Address(RVA = "0xAF0B1C", Offset = "0xAF0B1C", VA = "0xAF0B1C")]
		public void OnRecover(string nickName, float recoveredRatio)
		{
		}

		[Token(Token = "0x6004408")]
		[Address(RVA = "0xAF06D4", Offset = "0xAF06D4", VA = "0xAF06D4")]
		private ModUserLogEntry GetEntry(string nickName)
		{
			return null;
		}

		[Token(Token = "0x6004409")]
		[Address(RVA = "0xAF0C78", Offset = "0xAF0C78", VA = "0xAF0C78")]
		public bool ModUserDetected(Param param)
		{
			return default(bool);
		}

		[Token(Token = "0x600440A")]
		[Address(RVA = "0xAF0D4C", Offset = "0xAF0D4C", VA = "0xAF0D4C")]
		public Dictionary<string, ModUserLogEntry> GetModUserSuspect(Param setting)
		{
			return null;
		}

		[Token(Token = "0x600440B")]
		[Address(RVA = "0xAF1004", Offset = "0xAF1004", VA = "0xAF1004")]
		public List<string> Log(Param param)
		{
			return null;
		}
	}

	[Token(Token = "0x40023B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private IPhotonNetwork m_instance;

	[Token(Token = "0x40023B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private IConnectProcessor Connector__BackingField;

	[Token(Token = "0x17000936")]
	public IConnectProcessor Connector
	{
		[Token(Token = "0x6004217")]
		[Address(RVA = "0xAEEF24", Offset = "0xAEEF24", VA = "0xAEEF24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004218")]
		[Address(RVA = "0xAEEF1C", Offset = "0xAEEF1C", VA = "0xAEEF1C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000937")]
	public IPhotonNetwork instance
	{
		[Token(Token = "0x600421A")]
		[Address(RVA = "0xAE12A4", Offset = "0xAE12A4", VA = "0xAE12A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004216")]
	[Address(RVA = "0xAEEE58", Offset = "0xAEEE58", VA = "0xAEEE58")]
	public XPhotonManager()
	{
	}

	[Token(Token = "0x6004219")]
	[Address(RVA = "0xAEEF2C", Offset = "0xAEEF2C", VA = "0xAEEF2C")]
	public void Init(IPhotonNetwork instance)
	{
	}

	[Token(Token = "0x600421B")]
	[Address(RVA = "0xAEEF34", Offset = "0xAEEF34", VA = "0xAEEF34")]
	public void ChangeReconnector(GameFlowTypes type)
	{
	}

	[Token(Token = "0x600421C")]
	[Address(RVA = "0xAEF044", Offset = "0xAEF044", VA = "0xAEF044")]
	private IConnectProcessor GetReconnetor(GameFlowTypes type)
	{
		return null;
	}

	[Token(Token = "0x600421D")]
	[Address(RVA = "0xAEF19C", Offset = "0xAEF19C", VA = "0xAEF19C")]
	public void HandleError(object[] args)
	{
	}

	[Token(Token = "0x600421E")]
	[Address(RVA = "0xAEF4D0", Offset = "0xAEF4D0", VA = "0xAEF4D0")]
	internal void PluginReportedError(object[] args)
	{
	}

	[Token(Token = "0x600421F")]
	[Address(RVA = "0xAEF808", Offset = "0xAEF808", VA = "0xAEF808")]
	public int GetPing()
	{
		return default(int);
	}

	[Token(Token = "0x6004220")]
	[Address(RVA = "0xAEF9C0", Offset = "0xAEF9C0", VA = "0xAEF9C0")]
	public int GetPingGroup()
	{
		return default(int);
	}

	[Token(Token = "0x6004221")]
	[Address(RVA = "0xAEFC20", Offset = "0xAEFC20", VA = "0xAEFC20")]
	public int GetMatchPing()
	{
		return default(int);
	}

	[Token(Token = "0x6004222")]
	[Address(RVA = "0xAEFE34", Offset = "0xAEFE34", VA = "0xAEFE34")]
	public int GetRankPingGroup()
	{
		return default(int);
	}

	[Token(Token = "0x6004223")]
	[Address(RVA = "0xAF0100", Offset = "0xAF0100", VA = "0xAF0100")]
	public int GetRankMatchPing()
	{
		return default(int);
	}

	[Token(Token = "0x6004224")]
	[Address(RVA = "0xAF021C", Offset = "0xAF021C", VA = "0xAF021C")]
	public bool IsPhotonConnected()
	{
		return default(bool);
	}

	[Token(Token = "0x6004225")]
	[Address(RVA = "0xAF0328", Offset = "0xAF0328", VA = "0xAF0328")]
	public void TryToReconnect()
	{
	}
}
