using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x20004D0")]
public class XGameData
{
	[Token(Token = "0x20004D1")]
	private sealed class _003CGetMatchPlayerInfo_003Ec__AnonStorey10F
	{
		[Token(Token = "0x4001859")]
		[FieldOffset(Offset = "0x8")]
		internal string nickName;

		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x13DDA50", Offset = "0x13DDA50", VA = "0x13DDA50")]
		public _003CGetMatchPlayerInfo_003Ec__AnonStorey10F()
		{
		}

		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x13DDA58", Offset = "0x13DDA58", VA = "0x13DDA58")]
		internal bool _003C_003Em__F6(MatchPlayerInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004D2")]
	private sealed class _003CTryGetTeam_003Ec__AnonStorey110
	{
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x8")]
		internal string nickname;

		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x13DDB1C", Offset = "0x13DDB1C", VA = "0x13DDB1C")]
		public _003CTryGetTeam_003Ec__AnonStorey110()
		{
		}

		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x13DDB24", Offset = "0x13DDB24", VA = "0x13DDB24")]
		internal bool _003C_003Em__F8(MatchPlayerInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400183B")]
	[FieldOffset(Offset = "0x8")]
	private GameModeInfo m_GameModeInfo;

	[Token(Token = "0x400183C")]
	[FieldOffset(Offset = "0xC")]
	private bool m_AIMode;

	[Token(Token = "0x400183D")]
	[FieldOffset(Offset = "0xD")]
	public bool bInGame;

	[Token(Token = "0x400183E")]
	[FieldOffset(Offset = "0x10")]
	private EventGameModeInfo m_EventGameModeInfo;

	[Token(Token = "0x400183F")]
	[FieldOffset(Offset = "0x14")]
	private GameModeInstanceInfo m_GameModeInstanceInfo;

	[Token(Token = "0x4001840")]
	[FieldOffset(Offset = "0x18")]
	private MatchType m_MatchType;

	[Token(Token = "0x4001841")]
	[FieldOffset(Offset = "0x1C")]
	private int m_nSectorID;

	[Token(Token = "0x4001842")]
	[FieldOffset(Offset = "0x20")]
	public int m_nInstantRespawnCount;

	[Token(Token = "0x4001843")]
	[FieldOffset(Offset = "0x24")]
	public bool isGameEvaluateShow;

	[Token(Token = "0x4001844")]
	[FieldOffset(Offset = "0x28")]
	public string m_strLobbyCharImagePrefab;

	[Token(Token = "0x4001845")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_bFriendlyMatch;

	[Token(Token = "0x4001846")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_isSpectatorMode;

	[Token(Token = "0x4001847")]
	[FieldOffset(Offset = "0x2E")]
	private bool m_bNewbieMatch;

	[Token(Token = "0x4001848")]
	[FieldOffset(Offset = "0x30")]
	public string strFriendlyRoomName;

	[Token(Token = "0x4001849")]
	[FieldOffset(Offset = "0x34")]
	public string strFriendlyPassword;

	[Token(Token = "0x400184A")]
	[FieldOffset(Offset = "0x38")]
	public string GameStartProcessingReason;

	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_gameStartProcessing;

	[Token(Token = "0x400184C")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_isCanUseAuto;

	[Token(Token = "0x400184D")]
	[FieldOffset(Offset = "0x40")]
	private CSStageInfo m_stageInfo;

	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x44")]
	private LevelData m_stageLevelData;

	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x48")]
	private List<MatchPlayerInfo> m_liMatchPlayerInfo;

	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x4C")]
	private XPlayer f_Player;

	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<string, byte> m_friendlyMatchTeamInfoList;

	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x54")]
	private XGameModeType LastSelectedGameMode__BackingField;

	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x58")]
	private bool LastSelectedRandomMode__BackingField;

	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x59")]
	private bool IsCustomGame__BackingField;

	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x5A")]
	private bool FatigueWarning__BackingField;

	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x5C")]
	private int HideAndSeekModeTaggerID__BackingField;

	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x0")]
	private static Func<MatchPlayerInfo, string> _003C_003Ef__am_0024cache1C;

	[Token(Token = "0x4001858")]
	[FieldOffset(Offset = "0x4")]
	private static Func<MatchPlayerInfo, string> _003C_003Ef__am_0024cache1D;

	[Token(Token = "0x1700067C")]
	public int CurrentRankingSeason
	{
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x19BE698", Offset = "0x19BE698", VA = "0x19BE698")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700067D")]
	public GameModeInfo GameModeInfo
	{
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x19A69FC", Offset = "0x19A69FC", VA = "0x19A69FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x19BE7EC", Offset = "0x19BE7EC", VA = "0x19BE7EC")]
		set
		{
		}
	}

	[Token(Token = "0x1700067E")]
	public bool Multiplay
	{
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x19BE7F4", Offset = "0x19BE7F4", VA = "0x19BE7F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700067F")]
	public bool AIMode
	{
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x1987FFC", Offset = "0x1987FFC", VA = "0x1987FFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000680")]
	public XGameModeType LastSelectedGameMode
	{
		[Token(Token = "0x6002953")]
		[Address(RVA = "0x19BE678", Offset = "0x19BE678", VA = "0x19BE678")]
		get
		{
			return default(XGameModeType);
		}
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x19BE680", Offset = "0x19BE680", VA = "0x19BE680")]
		private set
		{
		}
	}

	[Token(Token = "0x17000681")]
	public bool LastSelectedRandomMode
	{
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x19BE688", Offset = "0x19BE688", VA = "0x19BE688")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x19BE690", Offset = "0x19BE690", VA = "0x19BE690")]
		private set
		{
		}
	}

	[Token(Token = "0x17000682")]
	public bool GameStartProcessing
	{
		[Token(Token = "0x6002957")]
		[Address(RVA = "0x198C5C8", Offset = "0x198C5C8", VA = "0x198C5C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002958")]
		[Address(RVA = "0x1983944", Offset = "0x1983944", VA = "0x1983944")]
		set
		{
		}
	}

	[Token(Token = "0x17000683")]
	public bool IsSpectatorMode
	{
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x19BE668", Offset = "0x19BE668", VA = "0x19BE668")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600295A")]
		[Address(RVA = "0x19BEA94", Offset = "0x19BEA94", VA = "0x19BEA94")]
		set
		{
		}
	}

	[Token(Token = "0x17000684")]
	public bool FriendlyMatch
	{
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x19874A0", Offset = "0x19874A0", VA = "0x19874A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000685")]
	public bool NewbieMatch
	{
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x19BE660", Offset = "0x19BE660", VA = "0x19BE660")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000686")]
	public bool IsCustomGame
	{
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x19BEA9C", Offset = "0x19BEA9C", VA = "0x19BEA9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x19BEAA4", Offset = "0x19BEAA4", VA = "0x19BEAA4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000687")]
	public XGameModeType GameModeType
	{
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x19A4B64", Offset = "0x19A4B64", VA = "0x19A4B64")]
		get
		{
			return default(XGameModeType);
		}
	}

	[Token(Token = "0x17000688")]
	public MatchType MatchType
	{
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x19A4B78", Offset = "0x19A4B78", VA = "0x19A4B78")]
		get
		{
			return default(MatchType);
		}
	}

	[Token(Token = "0x17000689")]
	public GameModeInstanceInfo GameModeInstanceInfo
	{
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x1998314", Offset = "0x1998314", VA = "0x1998314")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700068A")]
	public EventGameModeInfo EventGameModeInfo
	{
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x19A4B80", Offset = "0x19A4B80", VA = "0x19A4B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700068B")]
	public int SectorID
	{
		[Token(Token = "0x6002978")]
		[Address(RVA = "0x19BE658", Offset = "0x19BE658", VA = "0x19BE658")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700068C")]
	public bool CanUseAuto
	{
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x19BE650", Offset = "0x19BE650", VA = "0x19BE650")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700068D")]
	public CSStageInfo StageInfo
	{
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x19BE648", Offset = "0x19BE648", VA = "0x19BE648")]
		get
		{
			return null;
		}
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x19BEEF8", Offset = "0x19BEEF8", VA = "0x19BEEF8")]
		set
		{
		}
	}

	[Token(Token = "0x1700068E")]
	public LevelData StageLevelData
	{
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x19ADF2C", Offset = "0x19ADF2C", VA = "0x19ADF2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700068F")]
	public int InstantRespawnCount
	{
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x19BE670", Offset = "0x19BE670", VA = "0x19BE670")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x19BFF20", Offset = "0x19BFF20", VA = "0x19BFF20")]
		set
		{
		}
	}

	[Token(Token = "0x17000690")]
	public bool FatigueWarning
	{
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x19C0F2C", Offset = "0x19C0F2C", VA = "0x19C0F2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x19C0F24", Offset = "0x19C0F24", VA = "0x19C0F24")]
		set
		{
		}
	}

	[Token(Token = "0x17000691")]
	public int HideAndSeekModeTaggerID
	{
		[Token(Token = "0x600299B")]
		[Address(RVA = "0x19C1378", Offset = "0x19C1378", VA = "0x19C1378")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x19C1380", Offset = "0x19C1380", VA = "0x19C1380")]
		set
		{
		}
	}

	[Token(Token = "0x6002948")]
	[Address(RVA = "0x19BE41C", Offset = "0x19BE41C", VA = "0x19BE41C")]
	public XGameData()
	{
	}

	[Token(Token = "0x6002949")]
	[Address(RVA = "0x19BE5AC", Offset = "0x19BE5AC", VA = "0x19BE5AC")]
	public void SetGameDataForLobby(XGameData prevData)
	{
	}

	[Token(Token = "0x600294F")]
	[Address(RVA = "0x19BE99C", Offset = "0x19BE99C", VA = "0x19BE99C")]
	public bool IsPVPMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6002950")]
	[Address(RVA = "0x19BE9EC", Offset = "0x19BE9EC", VA = "0x19BE9EC")]
	public bool IsPvpMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002951")]
	[Address(RVA = "0x19BEA20", Offset = "0x19BEA20", VA = "0x19BEA20")]
	public bool IsPvpType()
	{
		return default(bool);
	}

	[Token(Token = "0x6002952")]
	[Address(RVA = "0x19BEA84", Offset = "0x19BEA84", VA = "0x19BEA84")]
	public bool IsStage()
	{
		return default(bool);
	}

	[Token(Token = "0x600295F")]
	[Address(RVA = "0x199831C", Offset = "0x199831C", VA = "0x199831C")]
	public bool IsGameModeLadder()
	{
		return default(bool);
	}

	[Token(Token = "0x6002960")]
	[Address(RVA = "0x1987478", Offset = "0x1987478", VA = "0x1987478")]
	public bool IsUseMatchServer()
	{
		return default(bool);
	}

	[Token(Token = "0x6002961")]
	[Address(RVA = "0x19BEAAC", Offset = "0x19BEAAC", VA = "0x19BEAAC")]
	internal bool IsFreeForAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6002962")]
	[Address(RVA = "0x19BEACC", Offset = "0x19BEACC", VA = "0x19BEACC")]
	public bool IsTeamDeathMatchMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002963")]
	[Address(RVA = "0x19A6F64", Offset = "0x19A6F64", VA = "0x19A6F64")]
	internal void SetCustomGame(bool isCustomGame)
	{
	}

	[Token(Token = "0x6002964")]
	[Address(RVA = "0x19BEAF0", Offset = "0x19BEAF0", VA = "0x19BEAF0")]
	public bool IsDeathMatchMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002965")]
	[Address(RVA = "0x19BEB10", Offset = "0x19BEB10", VA = "0x19BEB10")]
	public bool IsZombieMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002966")]
	[Address(RVA = "0x19BEB34", Offset = "0x19BEB34", VA = "0x19BEB34")]
	public void ClearFriedlyRoomInfo()
	{
	}

	[Token(Token = "0x6002967")]
	[Address(RVA = "0x19BEC44", Offset = "0x19BEC44", VA = "0x19BEC44")]
	private void ClearRecord()
	{
	}

	[Token(Token = "0x6002968")]
	[Address(RVA = "0x19BEC50", Offset = "0x19BEC50", VA = "0x19BEC50")]
	public void InitForLobby()
	{
	}

	[Token(Token = "0x6002969")]
	[Address(RVA = "0x19A6E18", Offset = "0x19A6E18", VA = "0x19A6E18")]
	public void InitForGame(bool previous_game_continue)
	{
	}

	[Token(Token = "0x600296A")]
	[Address(RVA = "0x19B9264", Offset = "0x19B9264", VA = "0x19B9264")]
	public void SelectGameMode(MatchType matchType, XGameModeType nGameModeType, bool AIMode = false)
	{
	}

	[Token(Token = "0x600296B")]
	[Address(RVA = "0x19BEC5C", Offset = "0x19BEC5C", VA = "0x19BEC5C")]
	public void SelectGameMode(XGameModeType nGameModeType, bool AIMode = false)
	{
	}

	[Token(Token = "0x600296C")]
	[Address(RVA = "0x19BEDB0", Offset = "0x19BEDB0", VA = "0x19BEDB0")]
	public void SelectGameMode(GameModeInfo gameModeInfo, bool AIMode = false)
	{
	}

	[Token(Token = "0x600296E")]
	[Address(RVA = "0x19BEFF0", Offset = "0x19BEFF0", VA = "0x19BEFF0")]
	public bool IsGameModeNA()
	{
		return default(bool);
	}

	[Token(Token = "0x6002970")]
	[Address(RVA = "0x19B924C", Offset = "0x19B924C", VA = "0x19B924C")]
	public void SelectGameModeInstanceInfo(GameModeInstanceInfo gameModeInstanceInfo)
	{
	}

	[Token(Token = "0x6002971")]
	[Address(RVA = "0x19BF014", Offset = "0x19BF014", VA = "0x19BF014")]
	public void SelectEventMode(EventGameModeInfo eventGameModeInfo)
	{
	}

	[Token(Token = "0x6002972")]
	[Address(RVA = "0x19BF01C", Offset = "0x19BF01C", VA = "0x19BF01C")]
	public void SelectFriendlyMatch(bool bFriendlyMatch)
	{
	}

	[Token(Token = "0x6002973")]
	[Address(RVA = "0x19BF030", Offset = "0x19BF030", VA = "0x19BF030")]
	public void SetLastSelectedRandomMode(bool lastSelectedRandomMode)
	{
	}

	[Token(Token = "0x6002974")]
	[Address(RVA = "0x19BF038", Offset = "0x19BF038", VA = "0x19BF038")]
	public void SelectNewbieMatch(bool bNewbieMatch)
	{
	}

	[Token(Token = "0x6002975")]
	[Address(RVA = "0x19B9244", Offset = "0x19B9244", VA = "0x19B9244")]
	public void SelectSectorId(int sector_id)
	{
	}

	[Token(Token = "0x600297D")]
	[Address(RVA = "0x19BF040", Offset = "0x19BF040", VA = "0x19BF040")]
	private string[] GetCharactersInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x600297E")]
	[Address(RVA = "0x19BF150", Offset = "0x19BF150", VA = "0x19BF150")]
	private string GetPlayerNickName(int index)
	{
		return null;
	}

	[Token(Token = "0x600297F")]
	[Address(RVA = "0x19BF288", Offset = "0x19BF288", VA = "0x19BF288")]
	private int GetOtherPlayerIndex(string aid)
	{
		return default(int);
	}

	[Token(Token = "0x6002980")]
	[Address(RVA = "0x19BF3E8", Offset = "0x19BF3E8", VA = "0x19BF3E8")]
	public MatchPlayerInfo GetMatchPlayerInfo(string nickName)
	{
		return null;
	}

	[Token(Token = "0x6002981")]
	[Address(RVA = "0x19BF508", Offset = "0x19BF508", VA = "0x19BF508")]
	private short GetPlayerELO(int index)
	{
		return default(short);
	}

	[Token(Token = "0x6002982")]
	[Address(RVA = "0x19AC6FC", Offset = "0x19AC6FC", VA = "0x19AC6FC")]
	public XPlayer SetBlankPlayerData()
	{
		return null;
	}

	[Token(Token = "0x6002983")]
	[Address(RVA = "0x19BF5F0", Offset = "0x19BF5F0", VA = "0x19BF5F0")]
	internal void SetMatchPlayerInfo(List<MatchPlayerInfo> liMatchPlayerInfo)
	{
	}

	[Token(Token = "0x6002984")]
	[Address(RVA = "0x19BF5F8", Offset = "0x19BF5F8", VA = "0x19BF5F8")]
	private void SetNotReadyPlayerList()
	{
	}

	[Token(Token = "0x6002985")]
	[Address(RVA = "0x19BF8D0", Offset = "0x19BF8D0", VA = "0x19BF8D0")]
	public List<MatchPlayerInfo> GetMatchPlayerInfoList()
	{
		return null;
	}

	[Token(Token = "0x6002986")]
	[Address(RVA = "0x19974D0", Offset = "0x19974D0", VA = "0x19974D0")]
	public string ConsolePrintPhotonTeam()
	{
		return null;
	}

	[Token(Token = "0x6002987")]
	[Address(RVA = "0x19BF8D8", Offset = "0x19BF8D8", VA = "0x19BF8D8")]
	public int GetMatchingPlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002988")]
	[Address(RVA = "0x19BF96C", Offset = "0x19BF96C", VA = "0x19BF96C")]
	internal void Clear()
	{
	}

	[Token(Token = "0x6002989")]
	[Address(RVA = "0x19BFA54", Offset = "0x19BFA54", VA = "0x19BFA54")]
	private void ClearMatchingPlayerInfo()
	{
	}

	[Token(Token = "0x600298A")]
	[Address(RVA = "0x19BFAEC", Offset = "0x19BFAEC", VA = "0x19BFAEC")]
	internal string GetMatchingTeamInfo()
	{
		return null;
	}

	[Token(Token = "0x600298B")]
	[Address(RVA = "0x19BFDD0", Offset = "0x19BFDD0", VA = "0x19BFDD0")]
	internal string GetRoomPlayers()
	{
		return null;
	}

	[Token(Token = "0x600298E")]
	[Address(RVA = "0x19BFF28", Offset = "0x19BFF28", VA = "0x19BFF28")]
	internal bool TryGetTeam(string nickname, out XTeamEnum team)
	{
		team = default;
		return default(bool);
	}

	[Token(Token = "0x600298F")]
	[Address(RVA = "0x19C00DC", Offset = "0x19C00DC", VA = "0x19C00DC")]
	internal List<string> GetMatchingPlayersAID()
	{
		return null;
	}

	[Token(Token = "0x6002990")]
	[Address(RVA = "0x19C02A8", Offset = "0x19C02A8", VA = "0x19C02A8")]
	internal bool CheckValideByRoomInfo(Room room)
	{
		return default(bool);
	}

	[Token(Token = "0x6002991")]
	[Address(RVA = "0x19C0AEC", Offset = "0x19C0AEC", VA = "0x19C0AEC")]
	internal void SetRoomData(Room room)
	{
	}

	[Token(Token = "0x6002994")]
	[Address(RVA = "0x19C0F34", Offset = "0x19C0F34", VA = "0x19C0F34")]
	public bool CharTagEnable(bool forUI = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002995")]
	[Address(RVA = "0x19C0F70", Offset = "0x19C0F70", VA = "0x19C0F70")]
	public XTeamEnum GiveTeamInfoInMasterClient()
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002996")]
	[Address(RVA = "0x19C1140", Offset = "0x19C1140", VA = "0x19C1140")]
	public void SetFriendlyTeamInfo(string nickName, byte teamInfo)
	{
	}

	[Token(Token = "0x6002997")]
	[Address(RVA = "0x19C1250", Offset = "0x19C1250", VA = "0x19C1250")]
	public XTeamEnum GetFriendlyTeamInfo(string nickName)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002998")]
	[Address(RVA = "0x19C1314", Offset = "0x19C1314", VA = "0x19C1314")]
	public bool CheckBalanceTeamInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6002999")]
	[Address(RVA = "0x19C0FC0", Offset = "0x19C0FC0", VA = "0x19C0FC0")]
	private byte GetTeamCount(XTeamEnum team)
	{
		return default(byte);
	}

	[Token(Token = "0x600299A")]
	[Address(RVA = "0x19C134C", Offset = "0x19C134C", VA = "0x19C134C")]
	public float GetCurrentGameModeRespawnHp()
	{
		return default(float);
	}

	[Token(Token = "0x600299D")]
	[Address(RVA = "0x19C1388", Offset = "0x19C1388", VA = "0x19C1388")]
	public bool IsReviveMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600299E")]
	[Address(RVA = "0x19C1440", Offset = "0x19C1440", VA = "0x19C1440")]
	public bool IsHeadStoneMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600299F")]
	[Address(RVA = "0x19C14F8", Offset = "0x19C14F8", VA = "0x19C14F8")]
	private static string _003CGetMatchingTeamInfo_003Em__F7(MatchPlayerInfo item)
	{
		return null;
	}

	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x19C1610", Offset = "0x19C1610", VA = "0x19C1610")]
	private static string _003CGetMatchingPlayersAID_003Em__F9(MatchPlayerInfo item)
	{
		return null;
	}
}
