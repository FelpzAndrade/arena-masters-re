using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005C3")]
public class XPlayerManager : Dictionary<string, XPlayer>, IPhotonPlayerConnectListener
{
	[Token(Token = "0x20005C4")]
	private sealed class _003CActiveReadyPlayerCount_003Ec__AnonStorey120
	{
		[Token(Token = "0x4001C0C")]
		[FieldOffset(Offset = "0x8")]
		internal Func<XPlayer, bool> condition;

		[Token(Token = "0x6003181")]
		[Address(RVA = "0xB2DF24", Offset = "0xB2DF24", VA = "0xB2DF24")]
		public _003CActiveReadyPlayerCount_003Ec__AnonStorey120()
		{
		}

		[Token(Token = "0x6003182")]
		[Address(RVA = "0xB30078", Offset = "0xB30078", VA = "0xB30078")]
		internal bool _003C_003Em__139(KeyValuePair<string, XPlayer> player)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001BF9")]
	[FieldOffset(Offset = "0x34")]
	private XGameMode m_gamemode;

	[Token(Token = "0x4001BFA")]
	[FieldOffset(Offset = "0x38")]
	public XGameModeType type;

	[Token(Token = "0x4001BFB")]
	[FieldOffset(Offset = "0x3C")]
	private string m_hostName;

	[Token(Token = "0x4001BFC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int teamKinds;

	[Token(Token = "0x4001BFD")]
	[FieldOffset(Offset = "0x40")]
	public int[] teamCount;

	[Token(Token = "0x4001BFE")]
	[FieldOffset(Offset = "0x44")]
	public int[] teamKillCount;

	[Token(Token = "0x4001BFF")]
	[FieldOffset(Offset = "0x48")]
	public int[] teamAssistCount;

	[Token(Token = "0x4001C00")]
	[FieldOffset(Offset = "0x4C")]
	public int[] teamDeathCount;

	[Token(Token = "0x4001C01")]
	[FieldOffset(Offset = "0x50")]
	private bool m_needUpdateMyTeam;

	[Token(Token = "0x4001C02")]
	[FieldOffset(Offset = "0x51")]
	private bool forceWin;

	[Token(Token = "0x4001C03")]
	[FieldOffset(Offset = "0x54")]
	private CSWinlose winlose;

	[Token(Token = "0x4001C04")]
	[FieldOffset(Offset = "0x58")]
	private XTeamEnum WinningTeam__BackingField;

	[Token(Token = "0x4001C05")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x4001C06")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XPlayer, int> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x4001C07")]
	[FieldOffset(Offset = "0xC")]
	private static Func<KeyValuePair<string, XPlayer>, bool> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x4001C08")]
	[FieldOffset(Offset = "0x10")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x4001C09")]
	[FieldOffset(Offset = "0x14")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cache10;

	[Token(Token = "0x4001C0A")]
	[FieldOffset(Offset = "0x18")]
	private static Func<XPlayer, string> _003C_003Ef__am_0024cache11;

	[Token(Token = "0x4001C0B")]
	[FieldOffset(Offset = "0x1C")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cache12;

	[Token(Token = "0x17000774")]
	public virtual XPlayer MyPlayer
	{
		[Token(Token = "0x6003113")]
		[Address(RVA = "0xB289C0", Offset = "0xB289C0", VA = "0xB289C0", Slot = "46")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003114")]
		[Address(RVA = "0xB28D6C", Offset = "0xB28D6C", VA = "0xB28D6C", Slot = "47")]
		set
		{
		}
	}

	[Token(Token = "0x17000775")]
	public XPlayerRecord MyPlayerRecord
	{
		[Token(Token = "0x6003116")]
		[Address(RVA = "0xACE2F4", Offset = "0xACE2F4", VA = "0xACE2F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000776")]
	public CSPlayerState MyPlayerState
	{
		[Token(Token = "0x6003117")]
		[Address(RVA = "0xB29138", Offset = "0xB29138", VA = "0xB29138")]
		get
		{
			return default(CSPlayerState);
		}
		[Token(Token = "0x6003118")]
		[Address(RVA = "0xB291D8", Offset = "0xB291D8", VA = "0xB291D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000777")]
	public int MyRank
	{
		[Token(Token = "0x6003123")]
		[Address(RVA = "0xB0AE28", Offset = "0xB0AE28", VA = "0xB0AE28")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000778")]
	public CSWinlose Winlose
	{
		[Token(Token = "0x6003126")]
		[Address(RVA = "0xAB5EB8", Offset = "0xAB5EB8", VA = "0xAB5EB8")]
		get
		{
			return default(CSWinlose);
		}
		[Token(Token = "0x6003127")]
		[Address(RVA = "0xB2A3CC", Offset = "0xB2A3CC", VA = "0xB2A3CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000779")]
	public XTeamEnum WinningTeam
	{
		[Token(Token = "0x6003128")]
		[Address(RVA = "0xAB6C08", Offset = "0xAB6C08", VA = "0xAB6C08")]
		get
		{
			return default(XTeamEnum);
		}
		[Token(Token = "0x6003129")]
		[Address(RVA = "0xB2A3D4", Offset = "0xB2A3D4", VA = "0xB2A3D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700077A")]
	public bool IsMyPerfectWin
	{
		[Token(Token = "0x600315F")]
		[Address(RVA = "0xB2ED00", Offset = "0xB2ED00", VA = "0xB2ED00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600310D")]
	[Address(RVA = "0xB28114", Offset = "0xB28114", VA = "0xB28114")]
	public XPlayerManager()
	{
	}

	[Token(Token = "0x600310F")]
	[Address(RVA = "0xB28324", Offset = "0xB28324", VA = "0xB28324")]
	public string ConsolePrintPlayerTeam()
	{
		return null;
	}

	[Token(Token = "0x6003110")]
	[Address(RVA = "0xAB5C50", Offset = "0xAB5C50", VA = "0xAB5C50")]
	public List<XPlayer> GetXPlayerList()
	{
		return null;
	}

	[Token(Token = "0x6003111")]
	[Address(RVA = "0xB28568", Offset = "0xB28568", VA = "0xB28568")]
	public List<string> GetXPlayerNameList()
	{
		return null;
	}

	[Token(Token = "0x6003112")]
	[Address(RVA = "0xB287D4", Offset = "0xB287D4", VA = "0xB287D4")]
	public void Init(XGameMode gamemode)
	{
	}

	[Token(Token = "0x6003115")]
	[Address(RVA = "0xB28F10", Offset = "0xB28F10", VA = "0xB28F10")]
	private bool isInitMyPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6003119")]
	[Address(RVA = "0xB29278", Offset = "0xB29278", VA = "0xB29278")]
	public void AddMatchPlayerInfo(List<MatchPlayerInfo> matchplayerInfo)
	{
	}

	[Token(Token = "0x600311A")]
	[Address(RVA = "0xB2935C", Offset = "0xB2935C", VA = "0xB2935C")]
	private void AddMatchPlayerInfo(MatchPlayerInfo info)
	{
	}

	[Token(Token = "0x600311B")]
	[Address(RVA = "0xB29504", Offset = "0xB29504", VA = "0xB29504")]
	public void GetELO(out int AllyELO, out int EnemyELO)
	{
		AllyELO = default;
		EnemyELO = default;
	}

	[Token(Token = "0x600311C")]
	[Address(RVA = "0xB29994", Offset = "0xB29994", VA = "0xB29994")]
	private void GetELOByTeamMatch(out int allyELO, out int enemyELO)
	{
		allyELO = default;
		enemyELO = default;
	}

	[Token(Token = "0x600311D")]
	[Address(RVA = "0xB29DA4", Offset = "0xB29DA4", VA = "0xB29DA4")]
	internal int GetEnterPlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x600311E")]
	[Address(RVA = "0xB29518", Offset = "0xB29518", VA = "0xB29518")]
	private void GetELOByDeathMatch(out int allyELO, out int enemyELO)
	{
		allyELO = default;
		enemyELO = default;
	}

	[Token(Token = "0x600311F")]
	[Address(RVA = "0xB29E28", Offset = "0xB29E28", VA = "0xB29E28")]
	public int GetPing()
	{
		return default(int);
	}

	[Token(Token = "0x6003120")]
	[Address(RVA = "0xB0828C", Offset = "0xB0828C", VA = "0xB0828C")]
	public XPlayer FindFromPhotonID(int nPhotonID)
	{
		return null;
	}

	[Token(Token = "0x6003121")]
	[Address(RVA = "0xB19C68", Offset = "0xB19C68", VA = "0xB19C68")]
	public XPlayer FindFromAID(string aid)
	{
		return null;
	}

	[Token(Token = "0x6003122")]
	[Address(RVA = "0xB14EB0", Offset = "0xB14EB0", VA = "0xB14EB0")]
	public XPlayer FindFromNickName(string nick)
	{
		return null;
	}

	[Token(Token = "0x6003124")]
	[Address(RVA = "0xB2A250", Offset = "0xB2A250", VA = "0xB2A250")]
	public bool GetForceWin()
	{
		return default(bool);
	}

	[Token(Token = "0x6003125")]
	[Address(RVA = "0xB2A258", Offset = "0xB2A258", VA = "0xB2A258")]
	public void SetForceWin(bool state)
	{
	}

	[Token(Token = "0x600312A")]
	[Address(RVA = "0xB2A3DC", Offset = "0xB2A3DC", VA = "0xB2A3DC")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600312B")]
	[Address(RVA = "0xB2A468", Offset = "0xB2A468", VA = "0xB2A468", Slot = "40")]
	public void OnPhotonPlayerConnected(PhotonPlayer photonPlayer)
	{
	}

	[Token(Token = "0x600312C")]
	[Address(RVA = "0xB0FA70", Offset = "0xB0FA70", VA = "0xB0FA70")]
	public XPlayer AddEntryStandByPlayer(PhotonPlayer photonPlayer)
	{
		return null;
	}

	[Token(Token = "0x600312D")]
	[Address(RVA = "0xB2A840", Offset = "0xB2A840", VA = "0xB2A840")]
	private void UpdateUIInfo()
	{
	}

	[Token(Token = "0x600312E")]
	[Address(RVA = "0xB2AA58", Offset = "0xB2AA58", VA = "0xB2AA58")]
	private List<XPlayer> GetTeamMemberList()
	{
		return null;
	}

	[Token(Token = "0x600312F")]
	[Address(RVA = "0xB2AB78", Offset = "0xB2AB78", VA = "0xB2AB78")]
	protected List<XPlayer> GetTeamMemberList(XGameModeType gamemodeType, XGameModeStateType stateType)
	{
		return null;
	}

	[Token(Token = "0x6003130")]
	[Address(RVA = "0xB2ADC4", Offset = "0xB2ADC4", VA = "0xB2ADC4", Slot = "41")]
	public void OnPhotonPlayerDisconnected(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6003131")]
	[Address(RVA = "0xB2B16C", Offset = "0xB2B16C", VA = "0xB2B16C")]
	public XPlayer AddPlayerInRoom(int ActorID, NetData_PlayerInfo _netDataPlayerInfo)
	{
		return null;
	}

	[Token(Token = "0x6003132")]
	[Address(RVA = "0xB2B364", Offset = "0xB2B364", VA = "0xB2B364")]
	public XPlayer AddPlayerInRoom(string aid, int netUID, bool isLocal, bool isMaster, NetData_PlayerInfo _netDataPlayerInfo)
	{
		return null;
	}

	[Token(Token = "0x6003133")]
	[Address(RVA = "0xB2BC54", Offset = "0xB2BC54", VA = "0xB2BC54")]
	public XPlayer AddNotReadyPlayerInRoom(string aid, NetData_PlayerInfo _netDataPlayerInfo)
	{
		return null;
	}

	[Token(Token = "0x6003134")]
	[Address(RVA = "0xB2A6E4", Offset = "0xB2A6E4", VA = "0xB2A6E4")]
	private bool ShouldShowJoinMessage(string nickname)
	{
		return default(bool);
	}

	[Token(Token = "0x6003135")]
	[Address(RVA = "0xB2ACB8", Offset = "0xB2ACB8", VA = "0xB2ACB8")]
	public List<XPlayer> GetMyTeamList()
	{
		return null;
	}

	[Token(Token = "0x6003136")]
	[Address(RVA = "0xB2C020", Offset = "0xB2C020", VA = "0xB2C020")]
	public XPlayer FindAliveTeamMember()
	{
		return null;
	}

	[Token(Token = "0x6003137")]
	[Address(RVA = "0xB2C12C", Offset = "0xB2C12C", VA = "0xB2C12C")]
	public XPlayer FindTaggerMember()
	{
		return null;
	}

	[Token(Token = "0x6003138")]
	[Address(RVA = "0xB2C238", Offset = "0xB2C238", VA = "0xB2C238")]
	private bool IsSpectator(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x6003139")]
	[Address(RVA = "0xB2C2CC", Offset = "0xB2C2CC", VA = "0xB2C2CC")]
	private bool IsTagger(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x600313A")]
	[Address(RVA = "0xB2C358", Offset = "0xB2C358", VA = "0xB2C358")]
	private bool IsMyTeam(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x600313B")]
	[Address(RVA = "0xB2C488", Offset = "0xB2C488", VA = "0xB2C488")]
	public List<XPlayer> GetEnemyTeamList()
	{
		return null;
	}

	[Token(Token = "0x600313C")]
	[Address(RVA = "0xB2C594", Offset = "0xB2C594", VA = "0xB2C594")]
	private bool IsEnemyTeam(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x600313D")]
	[Address(RVA = "0xB2BF3C", Offset = "0xB2BF3C", VA = "0xB2BF3C")]
	private bool IsMyPlayer(string nickname)
	{
		return default(bool);
	}

	[Token(Token = "0x600313E")]
	[Address(RVA = "0xB23DF8", Offset = "0xB23DF8", VA = "0xB23DF8")]
	public bool AddEscapedPlayerRecord(NetData_Record val)
	{
		return default(bool);
	}

	[Token(Token = "0x600313F")]
	[Address(RVA = "0xB23D10", Offset = "0xB23D10", VA = "0xB23D10")]
	public bool SetPlayerRecord(NetData_Record val)
	{
		return default(bool);
	}

	[Token(Token = "0x6003140")]
	[Address(RVA = "0xB242F0", Offset = "0xB242F0", VA = "0xB242F0")]
	public void UpdatePlayerRecordTeamInfo(NetData_TeamInfo val)
	{
	}

	[Token(Token = "0x6003141")]
	[Address(RVA = "0xB29470", Offset = "0xB29470", VA = "0xB29470")]
	private void AddOnPlayerManager(string aid, XPlayer player)
	{
	}

	[Token(Token = "0x6003142")]
	[Address(RVA = "0xB195C8", Offset = "0xB195C8", VA = "0xB195C8")]
	public void SetFrom_NetData_PlayerInfo(string name, NetData_PlayerInfo info)
	{
	}

	[Token(Token = "0x6003143")]
	[Address(RVA = "0xB2A95C", Offset = "0xB2A95C", VA = "0xB2A95C")]
	public void UpdateTeamHPBar()
	{
	}

	[Token(Token = "0x6003144")]
	[Address(RVA = "0xB15D44", Offset = "0xB15D44", VA = "0xB15D44")]
	public void UpdatePlayerTeam()
	{
	}

	[Token(Token = "0x6003145")]
	[Address(RVA = "0xB2C6C4", Offset = "0xB2C6C4", VA = "0xB2C6C4")]
	private void RefreshTeamKillAssistDeathCount()
	{
	}

	[Token(Token = "0x6003146")]
	[Address(RVA = "0xB2B958", Offset = "0xB2B958", VA = "0xB2B958")]
	private void PushCharInfo(XPlayer player, NetData_PlayerInfo _netDataPlayerInfo)
	{
	}

	[Token(Token = "0x6003147")]
	[Address(RVA = "0xB2CABC", Offset = "0xB2CABC", VA = "0xB2CABC")]
	public void ChangeHost(string playerName)
	{
	}

	[Token(Token = "0x6003148")]
	[Address(RVA = "0xB2CC80", Offset = "0xB2CC80", VA = "0xB2CC80")]
	public void SetPlayerDisconnect(string playerName)
	{
	}

	[Token(Token = "0x6003149")]
	[Address(RVA = "0xB2CE64", Offset = "0xB2CE64", VA = "0xB2CE64")]
	public bool RemovePlayer(string playerName)
	{
		return default(bool);
	}

	[Token(Token = "0x600314A")]
	[Address(RVA = "0xB2CEF0", Offset = "0xB2CEF0", VA = "0xB2CEF0")]
	public XPlayerManager Clone()
	{
		return null;
	}

	[Token(Token = "0x600314B")]
	[Address(RVA = "0xB2D28C", Offset = "0xB2D28C", VA = "0xB2D28C")]
	public XPlayer GetPlayerRecordBy(string aid)
	{
		return null;
	}

	[Token(Token = "0x600314C")]
	[Address(RVA = "0xB11CD8", Offset = "0xB11CD8", VA = "0xB11CD8")]
	public void SetSync(string name, float hp, float ultCharge)
	{
	}

	[Token(Token = "0x600314D")]
	[Address(RVA = "0xB2D480", Offset = "0xB2D480", VA = "0xB2D480")]
	public bool IsEscaped(string aid, out XPlayer player)
	{
		player = default;
		return default(bool);
	}

	[Token(Token = "0x600314E")]
	[Address(RVA = "0xB2D6D8", Offset = "0xB2D6D8", VA = "0xB2D6D8")]
	public bool IsReadyState()
	{
		return default(bool);
	}

	[Token(Token = "0x600314F")]
	[Address(RVA = "0xB2112C", Offset = "0xB2112C", VA = "0xB2112C")]
	public List<NetData_Record> GetEscapedPlayersRecord()
	{
		return null;
	}

	[Token(Token = "0x6003150")]
	[Address(RVA = "0xB214C4", Offset = "0xB214C4", VA = "0xB214C4")]
	public List<NetData_TeamInfo> GetPlayerTeamInfos()
	{
		return null;
	}

	[Token(Token = "0x6003151")]
	[Address(RVA = "0xB2D774", Offset = "0xB2D774", VA = "0xB2D774")]
	public List<string> GetPlayerAIDList()
	{
		return null;
	}

	[Token(Token = "0x6003152")]
	[Address(RVA = "0xB08F64", Offset = "0xB08F64", VA = "0xB08F64")]
	public int PlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003153")]
	[Address(RVA = "0xB2A260", Offset = "0xB2A260", VA = "0xB2A260")]
	public int ActivePlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003154")]
	[Address(RVA = "0xB16368", Offset = "0xB16368", VA = "0xB16368")]
	public List<XPlayer> GetPlayerLastState(CSPlayerState lastState)
	{
		return null;
	}

	[Token(Token = "0x6003155")]
	[Address(RVA = "0xB2D91C", Offset = "0xB2D91C", VA = "0xB2D91C")]
	public int BeStateCount(CSPlayerState lastState)
	{
		return default(int);
	}

	[Token(Token = "0x6003156")]
	[Address(RVA = "0xB2DA94", Offset = "0xB2DA94", VA = "0xB2DA94")]
	public int BeNotStateCount(CSPlayerState lastState)
	{
		return default(int);
	}

	[Token(Token = "0x6003157")]
	[Address(RVA = "0xB2DC0C", Offset = "0xB2DC0C", VA = "0xB2DC0C")]
	public int ActiveReadyPlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003158")]
	[Address(RVA = "0xB2DDEC", Offset = "0xB2DDEC", VA = "0xB2DDEC")]
	public int ActiveReadyPlayerCount(Func<XPlayer, bool> condition)
	{
		return default(int);
	}

	[Token(Token = "0x6003159")]
	[Address(RVA = "0xB2DF2C", Offset = "0xB2DF2C", VA = "0xB2DF2C")]
	public bool IsAllEscaped(XTeamEnum enemyTeam)
	{
		return default(bool);
	}

	[Token(Token = "0x600315A")]
	[Address(RVA = "0xB2E0B4", Offset = "0xB2E0B4", VA = "0xB2E0B4")]
	public void DefectorRejoined(int target_photon_id)
	{
	}

	[Token(Token = "0x600315B")]
	[Address(RVA = "0xB2E464", Offset = "0xB2E464", VA = "0xB2E464")]
	public XPlayer SelectRandomRecord(Func<XPlayer, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600315C")]
	[Address(RVA = "0xB2E7AC", Offset = "0xB2E7AC", VA = "0xB2E7AC")]
	public int GetAverageLevel()
	{
		return default(int);
	}

	[Token(Token = "0x600315D")]
	[Address(RVA = "0xB2E9F0", Offset = "0xB2E9F0", VA = "0xB2E9F0")]
	public void RefreshRecords()
	{
	}

	[Token(Token = "0x600315E")]
	[Address(RVA = "0xB2E9F4", Offset = "0xB2E9F4", VA = "0xB2E9F4")]
	public int GetMyIndexInTeam()
	{
		return default(int);
	}

	[Token(Token = "0x6003160")]
	[Address(RVA = "0xB2EF70", Offset = "0xB2EF70", VA = "0xB2EF70")]
	private bool GetPlayerByNickName(string PlayerName, out XPlayer outPlayer)
	{
		outPlayer = default;
		return default(bool);
	}

	[Token(Token = "0x6003161")]
	[Address(RVA = "0xB2F12C", Offset = "0xB2F12C", VA = "0xB2F12C")]
	public bool IsMyStateSpectator()
	{
		return default(bool);
	}

	[Token(Token = "0x6003162")]
	[Address(RVA = "0xB2F150", Offset = "0xB2F150", VA = "0xB2F150")]
	internal void OnEvent(RaiseEventContentCode code, string nickName)
	{
	}

	[Token(Token = "0x6003163")]
	[Address(RVA = "0xB058C8", Offset = "0xB058C8", VA = "0xB058C8")]
	internal void OnRecordEvent(RecordEvent recordEvent, string[] nickName)
	{
	}

	[Token(Token = "0x6003164")]
	[Address(RVA = "0xB0536C", Offset = "0xB0536C", VA = "0xB0536C")]
	internal void OnRecordEvent(RecordEvent recordEvent, string nickName)
	{
	}

	[Token(Token = "0x6003165")]
	[Address(RVA = "0xB06700", Offset = "0xB06700", VA = "0xB06700")]
	internal void OnRecordEvent(RecordEvent recordEvent, string nickName, short value)
	{
	}

	[Token(Token = "0x6003166")]
	[Address(RVA = "0xB05ABC", Offset = "0xB05ABC", VA = "0xB05ABC")]
	internal void OnChangePlayerState(string actorName, CSPlayerState playerState)
	{
	}

	[Token(Token = "0x6003167")]
	[Address(RVA = "0xB2F17C", Offset = "0xB2F17C", VA = "0xB2F17C")]
	private void CheckTeamSpectator(CSPlayerState prevState, CSPlayerState curState)
	{
	}

	[Token(Token = "0x6003168")]
	[Address(RVA = "0xB05B20", Offset = "0xB05B20", VA = "0xB05B20")]
	internal void OnGetAllPlayerRecord(RoomPlayersRecord roomPlayersRecord)
	{
	}

	[Token(Token = "0x6003169")]
	[Address(RVA = "0xB2F2CC", Offset = "0xB2F2CC", VA = "0xB2F2CC")]
	internal void SetHost(int masterClientPhotonID)
	{
	}

	[Token(Token = "0x600316A")]
	[Address(RVA = "0xB14690", Offset = "0xB14690", VA = "0xB14690")]
	internal void UpdatPlayerPing(string name, int ping)
	{
	}

	[Token(Token = "0x600316B")]
	[Address(RVA = "0xAF3788", Offset = "0xAF3788", VA = "0xAF3788")]
	public void DivideTeam(NetData_PlayerTeamSetting netDataPlayerTeam)
	{
	}

	[Token(Token = "0x600316C")]
	[Address(RVA = "0xB2F460", Offset = "0xB2F460", VA = "0xB2F460")]
	public List<string> GetAllPlayersAID()
	{
		return null;
	}

	[Token(Token = "0x600316D")]
	[Address(RVA = "0xB2F910", Offset = "0xB2F910", VA = "0xB2F910")]
	public int GetPhotonPlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x600316E")]
	[Address(RVA = "0xB2BB58", Offset = "0xB2BB58", VA = "0xB2BB58")]
	private void UpdatePlayerLoadingState(XPlayer player)
	{
	}

	[Token(Token = "0x600316F")]
	[Address(RVA = "0xB2FA6C", Offset = "0xB2FA6C", VA = "0xB2FA6C")]
	public NetData_PlayerInfo MakeNetDataPlayerInfo(string name, int charId, int skinId, short level, int secondId, int secondSkinId, short secondLevel, XTeamEnum team, int relicId, short relicLevel, int elo, string countryCode, bool isPlacementTest, short profileIconId, short titleId, int petId)
	{
		return null;
	}

	[Token(Token = "0x6003170")]
	[Address(RVA = "0xB2FB90", Offset = "0xB2FB90", VA = "0xB2FB90")]
	internal bool IsAllReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6003171")]
	[Address(RVA = "0xB2FD74", Offset = "0xB2FD74", VA = "0xB2FD74", Slot = "42")]
	public void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6003172")]
	[Address(RVA = "0xB2FD78", Offset = "0xB2FD78", VA = "0xB2FD78", Slot = "43")]
	public void OnDisconnectedFromPhoton()
	{
	}

	[Token(Token = "0x6003173")]
	[Address(RVA = "0xB2FD7C", Offset = "0xB2FD7C", VA = "0xB2FD7C", Slot = "44")]
	public void OnDisconnectedFromPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6003174")]
	[Address(RVA = "0xB2FD80", Offset = "0xB2FD80", VA = "0xB2FD80", Slot = "45")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6003175")]
	[Address(RVA = "0xB2FD84", Offset = "0xB2FD84", VA = "0xB2FD84")]
	private static bool _003CGetPing_003Em__131(XPlayer item)
	{
		return default(bool);
	}

	[Token(Token = "0x6003176")]
	[Address(RVA = "0xB2FDB0", Offset = "0xB2FDB0", VA = "0xB2FDB0")]
	private static int _003CGetPing_003Em__132(XPlayer item)
	{
		return default(int);
	}

	[Token(Token = "0x6003177")]
	[Address(RVA = "0xB2FDD0", Offset = "0xB2FDD0", VA = "0xB2FDD0")]
	private bool _003CGetTeamMemberList_003Em__133(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x6003178")]
	[Address(RVA = "0xB2FE3C", Offset = "0xB2FE3C", VA = "0xB2FE3C")]
	private bool _003CGetMyTeamList_003Em__134(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x6003179")]
	[Address(RVA = "0xB2FE40", Offset = "0xB2FE40", VA = "0xB2FE40")]
	private bool _003CFindAliveTeamMember_003Em__135(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x600317A")]
	[Address(RVA = "0xB2FE78", Offset = "0xB2FE78", VA = "0xB2FE78")]
	private bool _003CFindTaggerMember_003Em__136(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x600317B")]
	[Address(RVA = "0xB2FE7C", Offset = "0xB2FE7C", VA = "0xB2FE7C")]
	private bool _003CGetEnemyTeamList_003Em__137(XPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x600317C")]
	[Address(RVA = "0xB2FE80", Offset = "0xB2FE80", VA = "0xB2FE80")]
	private static bool _003CActiveReadyPlayerCount_003Em__138(KeyValuePair<string, XPlayer> player)
	{
		return default(bool);
	}

	[Token(Token = "0x600317D")]
	[Address(RVA = "0xB2FF68", Offset = "0xB2FF68", VA = "0xB2FF68")]
	private static int _003CGetAverageLevel_003Em__13A(KeyValuePair<string, XPlayer> each)
	{
		return default(int);
	}

	[Token(Token = "0x600317E")]
	[Address(RVA = "0xB30008", Offset = "0xB30008", VA = "0xB30008")]
	private static bool _003CGetAllPlayersAID_003Em__13B(XPlayer item)
	{
		return default(bool);
	}

	[Token(Token = "0x600317F")]
	[Address(RVA = "0xB30028", Offset = "0xB30028", VA = "0xB30028")]
	private static string _003CGetAllPlayersAID_003Em__13C(XPlayer item)
	{
		return null;
	}

	[Token(Token = "0x6003180")]
	[Address(RVA = "0xB30048", Offset = "0xB30048", VA = "0xB30048")]
	private static bool _003CIsAllReady_003Em__13D(XPlayer item)
	{
		return default(bool);
	}
}
