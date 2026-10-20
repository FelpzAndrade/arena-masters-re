using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A5F")]
	public class NetData_Userdata
	{
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0xC")]
		public int profile_icon_id;

		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x14")]
		public int exp;

		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x18")]
		public int skill_point;

		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x1C")]
		public int item_inven_count;

		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x20")]
		public long now_time;

		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x28")]
		public long now_time_local;

		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x30")]
		public int new_mail_count;

		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x34")]
		public int new_item_count;

		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x38")]
		public List<int> profile_icons;

		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x3C")]
		public int emoticon_set_id;

		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x40")]
		public List<int> emoticon_sets;

		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x44")]
		public HashSet<string> unlock_feautres;

		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x48")]
		public IncreasableDictionary<string> DateStats;

		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x4C")]
		public IncreasableDictionary<string> DailyStats;

		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x50")]
		public IncreasableDictionary<string> TotalStats;

		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x54")]
		public IncreasableDictionary<string> WeeklyStats;

		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, int> Achievements;

		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x5C")]
		public int CombatPoint;

		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, Dictionary<int, int>> talent;

		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x64")]
		public Dictionary<int, int> Relic;

		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x68")]
		public List<int> Titles;

		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x6C")]
		public int[] RelicQuickSlot;

		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x70")]
		public int[] RelicQuickSlotLevel;

		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x74")]
		public Dictionary<GameKey, GameRecord> TotalRecords;

		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x78")]
		public List<int> DailyBox;

		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x7C")]
		public Dictionary<string, TimeStampData> TimeStamps;

		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x80")]
		public string game_id;

		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x88")]
		public DateTime game_write_time;

		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x98")]
		public string game_mode;

		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x9C")]
		public int game_sector_id;

		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0xA0")]
		public ContinuousItem continuousItems;

		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0xA4")]
		public Dictionary<int, int> ClearMissionStage;

		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0xA8")]
		public List<string> party1_party;

		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0xAC")]
		public List<string> party2_party;

		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0xB0")]
		public List<string> party3_party;

		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0xB4")]
		public EloImpl Elo;

		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0xB8")]
		public short title_id;

		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0xBC")]
		public int free_revived_cnt;

		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<CSNotificationType, int> Notifications;

		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0xC4")]
		public Dictionary<GameKey, SeasonELO> elo_list;

		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0xC8")]
		public IncreasableDictionary<RankType> RankRewarded;

		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0xCC")]
		public GameSession GameSession;

		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0xD0")]
		public List<BoughtLimitedGoods> boughtLimitedGoodsList;

		[Token(Token = "0x4003056")]
		[FieldOffset(Offset = "0xD4")]
		public ExpireList expireList;

		[Token(Token = "0x4003057")]
		[FieldOffset(Offset = "0xD8")]
		public long eventAttendanceLastTimeStamp;

		[Token(Token = "0x4003058")]
		[FieldOffset(Offset = "0xE0")]
		public string ClanId;

		[Token(Token = "0x4003059")]
		[FieldOffset(Offset = "0xE4")]
		public Dictionary<string, DateTime> ApprovalWaitingClan;

		[Token(Token = "0x400305A")]
		[FieldOffset(Offset = "0xE8")]
		public Dictionary<RankType, SimpleGameRecord> RankSimpleGameRecord;

		[Token(Token = "0x400305B")]
		[FieldOffset(Offset = "0xEC")]
		public Dictionary<RankType, List<int>> FirstRankRewardRecordDictionary;

		[Token(Token = "0x400305C")]
		[FieldOffset(Offset = "0xF0")]
		public int TrophyRewardCoolTimePassCount;

		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0xF8")]
		public DateTime TrophyRewardLastGetTime;

		[Token(Token = "0x400305E")]
		[FieldOffset(Offset = "0x108")]
		public int TrophyRewardPoint;

		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x10C")]
		public int CombatPower;

		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x110")]
		public Dictionary<string, int> ArenaShopBuyHistory;

		[Token(Token = "0x4003061")]
		[FieldOffset(Offset = "0x114")]
		public Dictionary<int, IronsMissionState> IronsMissionStates;

		[Token(Token = "0x4003062")]
		[FieldOffset(Offset = "0x118")]
		public RandomOptionChangeWaitStorage RandomOptionChangeWaitStorage;

		[Token(Token = "0x4003063")]
		[FieldOffset(Offset = "0x11C")]
		public PandoraBoxLastRecieveInfo PandoraLastRecieveInfo;

		[Token(Token = "0x4003064")]
		[FieldOffset(Offset = "0x120")]
		public PlacementTestInfo PlacementTest;

		[Token(Token = "0x4003065")]
		[FieldOffset(Offset = "0x124")]
		public int PointShopAdvertisementChargeCount;

		[Token(Token = "0x4003066")]
		[FieldOffset(Offset = "0x128")]
		public long PointShopAdvertisementLastChargeTime;

		[Token(Token = "0x4003067")]
		[FieldOffset(Offset = "0x130")]
		public EventGameModeClearRecord EventModeClearRecord;

		[Token(Token = "0x4003068")]
		[FieldOffset(Offset = "0x134")]
		public int MPGood;

		[Token(Token = "0x4003069")]
		[FieldOffset(Offset = "0x138")]
		public int MPBad;

		[Token(Token = "0x400306A")]
		[FieldOffset(Offset = "0x13C")]
		public int MannerPoint;

		[Token(Token = "0x400306B")]
		[FieldOffset(Offset = "0x140")]
		public int Fatigue;

		[Token(Token = "0x400306C")]
		[FieldOffset(Offset = "0x144")]
		public bool UseCPQ;

		[Token(Token = "0x400306D")]
		[FieldOffset(Offset = "0x148")]
		public AttendanceState AttenanceState;

		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x14C")]
		public string PetId;

		[Token(Token = "0x400306F")]
		[FieldOffset(Offset = "0x150")]
		public bool PetIsNotShowed;

		[Token(Token = "0x4003070")]
		[FieldOffset(Offset = "0x154")]
		public MannerRepairInfo MannerRepairInfo;

		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x158")]
		public bool IsTransferReservation;

		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x159")]
		public bool IsTransferComplete;

		[Token(Token = "0x6004DBF")]
		[Address(RVA = "0x2340554", Offset = "0x2340554", VA = "0x2340554")]
		public NetData_Userdata()
		{
		}
	}
}
