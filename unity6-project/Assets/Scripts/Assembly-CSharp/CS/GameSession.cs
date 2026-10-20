using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000962")]
	public class GameSession
	{
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0x8")]
		public bool IsPrivateRoom;

		[Token(Token = "0x4002E5C")]
		[FieldOffset(Offset = "0xC")]
		public RoomType RoomType;

		[Token(Token = "0x4002E5D")]
		[FieldOffset(Offset = "0x10")]
		private string GameId__BackingField;

		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x14")]
		private MatchType MatchType__BackingField;

		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x18")]
		private XGameModeType Mode__BackingField;

		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x1C")]
		private int Season__BackingField;

		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0x20")]
		private int AllyELO__BackingField;

		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x24")]
		private int EnemyELO__BackingField;

		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x28")]
		private CharPartyId CharPartyId__BackingField;

		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x2C")]
		private int SectorId__BackingField;

		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x30")]
		private DateTime StartTimeUtc__BackingField;

		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x40")]
		private DateTime StartTime__BackingField;

		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x50")]
		private PlayerGameRecord Record__BackingField;

		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x54")]
		private int Rank__BackingField;

		[Token(Token = "0x4002E69")]
		[FieldOffset(Offset = "0x58")]
		private int RewardRank__BackingField;

		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x5C")]
		private int PlayerCount__BackingField;

		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x60")]
		private bool IsCompleted__BackingField;

		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x64")]
		private int TrophyPoint__BackingField;

		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x68")]
		private int ClanBoxPoint__BackingField;

		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x6C")]
		private CSWinlose WinLose__BackingField;

		[Token(Token = "0x4002E6F")]
		[FieldOffset(Offset = "0x70")]
		private FriendlySessionData FriendlySession__BackingField;

		[Token(Token = "0x4002E70")]
		[FieldOffset(Offset = "0x78")]
		private long GameTimeStamp__BackingField;

		[Token(Token = "0x4002E71")]
		[FieldOffset(Offset = "0x80")]
		private ApiReturnCode FailCause__BackingField;

		[Token(Token = "0x4002E72")]
		[FieldOffset(Offset = "0x84")]
		private int EnterModeInstanceID__BackingField;

		[Token(Token = "0x4002E73")]
		[FieldOffset(Offset = "0x88")]
		private int EnterEventModeID__BackingField;

		[Token(Token = "0x17000A90")]
		public string GameId
		{
			[Token(Token = "0x6004B70")]
			[Address(RVA = "0x2337494", Offset = "0x2337494", VA = "0x2337494")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B71")]
			[Address(RVA = "0x233744C", Offset = "0x233744C", VA = "0x233744C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A91")]
		public MatchType MatchType
		{
			[Token(Token = "0x6004B72")]
			[Address(RVA = "0x233749C", Offset = "0x233749C", VA = "0x233749C")]
			get
			{
				return default(MatchType);
			}
			[Token(Token = "0x6004B73")]
			[Address(RVA = "0x2337454", Offset = "0x2337454", VA = "0x2337454")]
			set
			{
			}
		}

		[Token(Token = "0x17000A92")]
		public XGameModeType Mode
		{
			[Token(Token = "0x6004B74")]
			[Address(RVA = "0x23374A4", Offset = "0x23374A4", VA = "0x23374A4")]
			get
			{
				return default(XGameModeType);
			}
			[Token(Token = "0x6004B75")]
			[Address(RVA = "0x233745C", Offset = "0x233745C", VA = "0x233745C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A93")]
		public int Season
		{
			[Token(Token = "0x6004B76")]
			[Address(RVA = "0x23374AC", Offset = "0x23374AC", VA = "0x23374AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B77")]
			[Address(RVA = "0x2337464", Offset = "0x2337464", VA = "0x2337464")]
			set
			{
			}
		}

		[Token(Token = "0x17000A94")]
		public int AllyELO
		{
			[Token(Token = "0x6004B78")]
			[Address(RVA = "0x23374B4", Offset = "0x23374B4", VA = "0x23374B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B79")]
			[Address(RVA = "0x233746C", Offset = "0x233746C", VA = "0x233746C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A95")]
		public int EnemyELO
		{
			[Token(Token = "0x6004B7A")]
			[Address(RVA = "0x23374BC", Offset = "0x23374BC", VA = "0x23374BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B7B")]
			[Address(RVA = "0x2337474", Offset = "0x2337474", VA = "0x2337474")]
			set
			{
			}
		}

		[Token(Token = "0x17000A96")]
		public CharPartyId CharPartyId
		{
			[Token(Token = "0x6004B7C")]
			[Address(RVA = "0x23374C4", Offset = "0x23374C4", VA = "0x23374C4")]
			get
			{
				return default(CharPartyId);
			}
			[Token(Token = "0x6004B7D")]
			[Address(RVA = "0x233747C", Offset = "0x233747C", VA = "0x233747C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A97")]
		public int SectorId
		{
			[Token(Token = "0x6004B7E")]
			[Address(RVA = "0x23374CC", Offset = "0x23374CC", VA = "0x23374CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B7F")]
			[Address(RVA = "0x2337484", Offset = "0x2337484", VA = "0x2337484")]
			set
			{
			}
		}

		[Token(Token = "0x17000A98")]
		public DateTime StartTimeUtc
		{
			[Token(Token = "0x6004B80")]
			[Address(RVA = "0x23374D4", Offset = "0x23374D4", VA = "0x23374D4")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004B81")]
			[Address(RVA = "0x23372B8", Offset = "0x23372B8", VA = "0x23372B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A99")]
		public DateTime StartTime
		{
			[Token(Token = "0x6004B82")]
			[Address(RVA = "0x23374E4", Offset = "0x23374E4", VA = "0x23374E4")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004B83")]
			[Address(RVA = "0x23372D0", Offset = "0x23372D0", VA = "0x23372D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9A")]
		public PlayerGameRecord Record
		{
			[Token(Token = "0x6004B84")]
			[Address(RVA = "0x23374F4", Offset = "0x23374F4", VA = "0x23374F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B85")]
			[Address(RVA = "0x23372B0", Offset = "0x23372B0", VA = "0x23372B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9B")]
		public int Rank
		{
			[Token(Token = "0x6004B86")]
			[Address(RVA = "0x23374FC", Offset = "0x23374FC", VA = "0x23374FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B87")]
			[Address(RVA = "0x2337504", Offset = "0x2337504", VA = "0x2337504")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9C")]
		public int RewardRank
		{
			[Token(Token = "0x6004B88")]
			[Address(RVA = "0x233750C", Offset = "0x233750C", VA = "0x233750C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B89")]
			[Address(RVA = "0x2337514", Offset = "0x2337514", VA = "0x2337514")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9D")]
		public int PlayerCount
		{
			[Token(Token = "0x6004B8A")]
			[Address(RVA = "0x233751C", Offset = "0x233751C", VA = "0x233751C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B8B")]
			[Address(RVA = "0x2337524", Offset = "0x2337524", VA = "0x2337524")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9E")]
		public bool IsCompleted
		{
			[Token(Token = "0x6004B8C")]
			[Address(RVA = "0x233752C", Offset = "0x233752C", VA = "0x233752C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B8D")]
			[Address(RVA = "0x23372E8", Offset = "0x23372E8", VA = "0x23372E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9F")]
		public int TrophyPoint
		{
			[Token(Token = "0x6004B8E")]
			[Address(RVA = "0x2337534", Offset = "0x2337534", VA = "0x2337534")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B8F")]
			[Address(RVA = "0x233753C", Offset = "0x233753C", VA = "0x233753C")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA0")]
		public int ClanBoxPoint
		{
			[Token(Token = "0x6004B90")]
			[Address(RVA = "0x2337544", Offset = "0x2337544", VA = "0x2337544")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B91")]
			[Address(RVA = "0x2337300", Offset = "0x2337300", VA = "0x2337300")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA1")]
		public CSWinlose WinLose
		{
			[Token(Token = "0x6004B92")]
			[Address(RVA = "0x233754C", Offset = "0x233754C", VA = "0x233754C")]
			get
			{
				return default(CSWinlose);
			}
			[Token(Token = "0x6004B93")]
			[Address(RVA = "0x2337554", Offset = "0x2337554", VA = "0x2337554")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA2")]
		public FriendlySessionData FriendlySession
		{
			[Token(Token = "0x6004B94")]
			[Address(RVA = "0x233748C", Offset = "0x233748C", VA = "0x233748C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B95")]
			[Address(RVA = "0x23372F0", Offset = "0x23372F0", VA = "0x23372F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA3")]
		public long GameTimeStamp
		{
			[Token(Token = "0x6004B96")]
			[Address(RVA = "0x233755C", Offset = "0x233755C", VA = "0x233755C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004B97")]
			[Address(RVA = "0x2337564", Offset = "0x2337564", VA = "0x2337564")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA4")]
		public ApiReturnCode FailCause
		{
			[Token(Token = "0x6004B98")]
			[Address(RVA = "0x2337574", Offset = "0x2337574", VA = "0x2337574")]
			get
			{
				return default(ApiReturnCode);
			}
			[Token(Token = "0x6004B99")]
			[Address(RVA = "0x23372F8", Offset = "0x23372F8", VA = "0x23372F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA5")]
		public int EnterModeInstanceID
		{
			[Token(Token = "0x6004B9A")]
			[Address(RVA = "0x233757C", Offset = "0x233757C", VA = "0x233757C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B9B")]
			[Address(RVA = "0x2337584", Offset = "0x2337584", VA = "0x2337584")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA6")]
		public int EnterEventModeID
		{
			[Token(Token = "0x6004B9C")]
			[Address(RVA = "0x233758C", Offset = "0x233758C", VA = "0x233758C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B9D")]
			[Address(RVA = "0x2337594", Offset = "0x2337594", VA = "0x2337594")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA7")]
		[JsonIgnore]
		public bool IsFriendlyMatch
		{
			[Token(Token = "0x6004B9E")]
			[Address(RVA = "0x233759C", Offset = "0x233759C", VA = "0x233759C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004B6E")]
		[Address(RVA = "0x233715C", Offset = "0x233715C", VA = "0x233715C")]
		public GameSession()
		{
		}

		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x2337308", Offset = "0x2337308", VA = "0x2337308")]
		public GameSession(string _gameID, MatchType _matchType, XGameModeType _mode, int _season, int _allyElo, int _enemyElo, CharPartyId _partyID, bool friendly_match = false, int _sectorID = 0, bool isPrivateRoom = false, RoomType roomType = RoomType.None)
		{
		}

		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x23375C0", Offset = "0x23375C0", VA = "0x23375C0")]
		public GameKey GetGameKey()
		{
			return default(GameKey);
		}
	}
}
