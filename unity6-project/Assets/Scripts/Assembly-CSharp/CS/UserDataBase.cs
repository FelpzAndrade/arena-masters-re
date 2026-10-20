using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000943")]
	public class UserDataBase : DBEntry
	{
		[Token(Token = "0x4002D8C")]
		[FieldOffset(Offset = "0x24")]
		public Dictionary<string, DateTime> ApprovalWaitingClan;

		[Token(Token = "0x4002D8D")]
		[FieldOffset(Offset = "0x28")]
		[JsonIgnore]
		public Dictionary<RankType, SimpleGameRecord> RankSimpleGameRecord;

		[Token(Token = "0x4002D8E")]
		[FieldOffset(Offset = "0x2C")]
		public int DailyRelicLevel;

		[Token(Token = "0x4002D8F")]
		[FieldOffset(Offset = "0x30")]
		public int[] RelicQuickSlot;

		[Token(Token = "0x4002D90")]
		[FieldOffset(Offset = "0x34")]
		public int[] RelicQuickSlotLevel;

		[Token(Token = "0x4002D91")]
		[FieldOffset(Offset = "0x38")]
		[JsonIgnore]
		private List<int> _Titles;

		[Token(Token = "0x4002D92")]
		[FieldOffset(Offset = "0x3C")]
		[JsonIgnore]
		private ExpireList _expireList;

		[Token(Token = "0x4002D93")]
		[FieldOffset(Offset = "0x40")]
		[JsonIgnore]
		private LimitItemPurchasedList _limitItemPurchaseList;

		[Token(Token = "0x4002D94")]
		[FieldOffset(Offset = "0x44")]
		[JsonIgnore]
		private IncreasableDictionary<RankType> _rankRewarded;

		[Token(Token = "0x4002D95")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<Currency, ComplexCurrency> _currencyList;

		[Token(Token = "0x4002D96")]
		[FieldOffset(Offset = "0x4C")]
		[JsonIgnore]
		private Dictionary<int, RotationItemSet> _rotationItems;

		[Token(Token = "0x4002D97")]
		[FieldOffset(Offset = "0x50")]
		[JsonIgnore]
		private List<BoughtLimitedGoods> _boughtLimitedGoodsList;

		[Token(Token = "0x4002D98")]
		[FieldOffset(Offset = "0x54")]
		private int _emoticonSetID;

		[Token(Token = "0x4002D99")]
		[FieldOffset(Offset = "0x58")]
		private List<int> _emoticonSets;

		[Token(Token = "0x4002D9A")]
		[FieldOffset(Offset = "0x5C")]
		public Dictionary<string, int> ArenaShopBuyHistory;

		[Token(Token = "0x4002D9B")]
		[FieldOffset(Offset = "0x60")]
		[JsonIgnore]
		private PandoraBoxLastRecieveInfo _pandoraHistory;

		[Token(Token = "0x4002D9C")]
		[FieldOffset(Offset = "0x64")]
		[JsonIgnore]
		private EventGameModeClearRecord _eventModeClearRecord;

		[Token(Token = "0x4002D9D")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<int, IronsMissionState> IronsMissionStates;

		[Token(Token = "0x4002D9E")]
		[FieldOffset(Offset = "0x6C")]
		[JsonIgnore]
		private MannerRepairInfo _mannerRepairInfo;

		[Token(Token = "0x4002D9F")]
		[FieldOffset(Offset = "0x70")]
		private string Name__BackingField;

		[Token(Token = "0x4002DA0")]
		[FieldOffset(Offset = "0x74")]
		private int Level__BackingField;

		[Token(Token = "0x4002DA1")]
		[FieldOffset(Offset = "0x78")]
		private int Exp__BackingField;

		[Token(Token = "0x4002DA2")]
		[FieldOffset(Offset = "0x7C")]
		private int Stamina__BackingField;

		[Token(Token = "0x4002DA3")]
		[FieldOffset(Offset = "0x80")]
		private long StaminaLastCheckTime__BackingField;

		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0x88")]
		private int Energy__BackingField;

		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0x90")]
		private long EnergyLastCheckTime__BackingField;

		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0x98")]
		private int ArenaCoin__BackingField;

		[Token(Token = "0x4002DA7")]
		[FieldOffset(Offset = "0x9C")]
		private int FP__BackingField;

		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0xA0")]
		private int ItemInvenSlotCount__BackingField;

		[Token(Token = "0x4002DA9")]
		[FieldOffset(Offset = "0xA4")]
		private int NewMailCount__BackingField;

		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<int, int> ClearMissionStage__BackingField;

		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0xAC")]
		private int ClearTicket__BackingField;

		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<RankType, List<int>> FirstRankRewardRecordDictionary__BackingField;

		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0xB4")]
		private int TrophyRewardCoolTimePassCount__BackingField;

		[Token(Token = "0x4002DAE")]
		[FieldOffset(Offset = "0xB8")]
		private DateTime TrophyRewardLastGetTime__BackingField;

		[Token(Token = "0x4002DAF")]
		[FieldOffset(Offset = "0xC8")]
		private int TrophyRewardPoint__BackingField;

		[Token(Token = "0x4002DB0")]
		[FieldOffset(Offset = "0xCC")]
		private int ItemBooster__BackingField;

		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0xD0")]
		private int GoldBooster__BackingField;

		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0xD4")]
		private int PromstoneBooster__BackingField;

		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0xD8")]
		private GameSession GameSession__BackingField;

		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0xDC")]
		private int MedalOfHonor__BackingField;

		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0xE0")]
		private CharPartyData CharParty__BackingField;

		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0xE4")]
		private int MedalOfWarrior__BackingField;

		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0xE8")]
		private HashSet<string> UnlockFeatures__BackingField;

		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0xEC")]
		private IncreasableDictionary<string> DateStats__BackingField;

		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0xF0")]
		private IncreasableDictionary<string> DailyStats__BackingField;

		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0xF4")]
		private IncreasableDictionary<string> TotalStats__BackingField;

		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0xF8")]
		private IncreasableDictionary<string> WeeklyStats__BackingField;

		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0xFC")]
		private Dictionary<string, int> Achievements__BackingField;

		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x100")]
		private int CombatPoint__BackingField;

		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x104")]
		private List<int> DailyBox__BackingField;

		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x108")]
		private long AttendanceLastTimeStamp__BackingField;

		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x110")]
		private long EventAttendanceLastTimeStamp__BackingField;

		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x118")]
		private int TalentPoint__BackingField;

		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x11C")]
		private Dictionary<string, Dictionary<int, int>> Talent__BackingField;

		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<int, int> Relic__BackingField;

		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x124")]
		private short TitleId__BackingField;

		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x126")]
		private bool IsUseItemBooster__BackingField;

		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x127")]
		private bool IsUseGoldBooster__BackingField;

		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x128")]
		private bool IsUsePromstoneBooster__BackingField;

		[Token(Token = "0x4002DC8")]
		[FieldOffset(Offset = "0x12C")]
		private Dictionary<string, TimeStampData> TimeStamps__BackingField;

		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x130")]
		private ContinuousItem continuousItems__BackingField;

		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x134")]
		private EloImpl Elo__BackingField;

		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x138")]
		private int PromotionWeaponStone__BackingField;

		[Token(Token = "0x4002DCC")]
		[FieldOffset(Offset = "0x13C")]
		private int PromotionArmorStone__BackingField;

		[Token(Token = "0x4002DCD")]
		[FieldOffset(Offset = "0x140")]
		private int PromotionAccessoryStone__BackingField;

		[Token(Token = "0x4002DCE")]
		[FieldOffset(Offset = "0x144")]
		private int FreeRevivedCnt__BackingField;

		[Token(Token = "0x4002DCF")]
		[FieldOffset(Offset = "0x148")]
		private int ProfileIconID__BackingField;

		[Token(Token = "0x4002DD0")]
		[FieldOffset(Offset = "0x14C")]
		private List<int> ProfileIcons__BackingField;

		[Token(Token = "0x4002DD1")]
		[FieldOffset(Offset = "0x150")]
		private Dictionary<CSNotificationType, int> Notifications__BackingField;

		[Token(Token = "0x4002DD2")]
		[FieldOffset(Offset = "0x154")]
		private string ClanId__BackingField;

		[Token(Token = "0x4002DD3")]
		[FieldOffset(Offset = "0x158")]
		private int CombatPower__BackingField;

		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x15C")]
		private PlacementTestInfo PlacementTest__BackingField;

		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x160")]
		private int PointShopAdvertisementChargeCount__BackingField;

		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x168")]
		private long PointShopAdvertisementLastChargeTime__BackingField;

		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x170")]
		private int MannerGood__BackingField;

		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x174")]
		private int MannerBad__BackingField;

		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0x178")]
		private int MannerPoint__BackingField;

		[Token(Token = "0x4002DDA")]
		[FieldOffset(Offset = "0x17C")]
		private RandomOptionChangeWaitStorage RandomOptionChangeWaitStorage__BackingField;

		[Token(Token = "0x4002DDB")]
		[FieldOffset(Offset = "0x180")]
		private int Fatigue__BackingField;

		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x184")]
		private AttendanceState AttendanceState__BackingField;

		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x188")]
		private string PetId__BackingField;

		[Token(Token = "0x4002DDE")]
		[FieldOffset(Offset = "0x18C")]
		private bool PetIsNotShowed__BackingField;

		[Token(Token = "0x4002DDF")]
		[FieldOffset(Offset = "0x18D")]
		private bool UseCPQ__BackingField;

		[Token(Token = "0x4002DE0")]
		[FieldOffset(Offset = "0x18E")]
		private bool IsTransferReservation__BackingField;

		[Token(Token = "0x4002DE1")]
		[FieldOffset(Offset = "0x18F")]
		private bool IsTransferComplete__BackingField;

		[Token(Token = "0x170009CD")]
		public string Name
		{
			[Token(Token = "0x600497C")]
			[Address(RVA = "0x21E3128", Offset = "0x21E3128", VA = "0x21E3128")]
			get
			{
				return null;
			}
			[Token(Token = "0x600497D")]
			[Address(RVA = "0x21EBB08", Offset = "0x21EBB08", VA = "0x21EBB08")]
			set
			{
			}
		}

		[Token(Token = "0x170009CE")]
		public int Level
		{
			[Token(Token = "0x600497E")]
			[Address(RVA = "0x21DF87C", Offset = "0x21DF87C", VA = "0x21DF87C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600497F")]
			[Address(RVA = "0x21EBB10", Offset = "0x21EBB10", VA = "0x21EBB10")]
			set
			{
			}
		}

		[Token(Token = "0x170009CF")]
		public int Exp
		{
			[Token(Token = "0x6004980")]
			[Address(RVA = "0x21EBB18", Offset = "0x21EBB18", VA = "0x21EBB18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004981")]
			[Address(RVA = "0x21EBB20", Offset = "0x21EBB20", VA = "0x21EBB20")]
			set
			{
			}
		}

		[Token(Token = "0x170009D0")]
		public int Stamina
		{
			[Token(Token = "0x6004982")]
			[Address(RVA = "0x21DF88C", Offset = "0x21DF88C", VA = "0x21DF88C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004983")]
			[Address(RVA = "0x21EBB28", Offset = "0x21EBB28", VA = "0x21EBB28")]
			set
			{
			}
		}

		[Token(Token = "0x170009D1")]
		public long StaminaLastCheckTime
		{
			[Token(Token = "0x6004984")]
			[Address(RVA = "0x21EBB30", Offset = "0x21EBB30", VA = "0x21EBB30")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004985")]
			[Address(RVA = "0x21EBB38", Offset = "0x21EBB38", VA = "0x21EBB38")]
			set
			{
			}
		}

		[Token(Token = "0x170009D2")]
		[JsonIgnore]
		public int Gold
		{
			[Token(Token = "0x6004986")]
			[Address(RVA = "0x21EBB48", Offset = "0x21EBB48", VA = "0x21EBB48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009D3")]
		public int Energy
		{
			[Token(Token = "0x6004987")]
			[Address(RVA = "0x21DF884", Offset = "0x21DF884", VA = "0x21DF884")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004988")]
			[Address(RVA = "0x21EBE9C", Offset = "0x21EBE9C", VA = "0x21EBE9C")]
			set
			{
			}
		}

		[Token(Token = "0x170009D4")]
		public long EnergyLastCheckTime
		{
			[Token(Token = "0x6004989")]
			[Address(RVA = "0x21EBEA4", Offset = "0x21EBEA4", VA = "0x21EBEA4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600498A")]
			[Address(RVA = "0x21EBEAC", Offset = "0x21EBEAC", VA = "0x21EBEAC")]
			set
			{
			}
		}

		[Token(Token = "0x170009D5")]
		public int Crystal
		{
			[Token(Token = "0x600498B")]
			[Address(RVA = "0x21EBEBC", Offset = "0x21EBEBC", VA = "0x21EBEBC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009D6")]
		[JsonIgnore]
		public int PaidCrystal
		{
			[Token(Token = "0x600498C")]
			[Address(RVA = "0x21EBEC4", Offset = "0x21EBEC4", VA = "0x21EBEC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009D7")]
		[JsonIgnore]
		public int FreeCrystal
		{
			[Token(Token = "0x600498D")]
			[Address(RVA = "0x21EC0AC", Offset = "0x21EC0AC", VA = "0x21EC0AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009D8")]
		[JsonIgnore]
		public int PaidGold
		{
			[Token(Token = "0x600498E")]
			[Address(RVA = "0x21EC0DC", Offset = "0x21EC0DC", VA = "0x21EC0DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009D9")]
		[JsonIgnore]
		public int FreeGold
		{
			[Token(Token = "0x600498F")]
			[Address(RVA = "0x21EC10C", Offset = "0x21EC10C", VA = "0x21EC10C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009DA")]
		public int ArenaCoin
		{
			[Token(Token = "0x6004990")]
			[Address(RVA = "0x21EC13C", Offset = "0x21EC13C", VA = "0x21EC13C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004991")]
			[Address(RVA = "0x21EC144", Offset = "0x21EC144", VA = "0x21EC144")]
			set
			{
			}
		}

		[Token(Token = "0x170009DB")]
		public int FP
		{
			[Token(Token = "0x6004992")]
			[Address(RVA = "0x21EC14C", Offset = "0x21EC14C", VA = "0x21EC14C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004993")]
			[Address(RVA = "0x21EC154", Offset = "0x21EC154", VA = "0x21EC154")]
			set
			{
			}
		}

		[Token(Token = "0x170009DC")]
		public int ItemInvenSlotCount
		{
			[Token(Token = "0x6004994")]
			[Address(RVA = "0x21EC15C", Offset = "0x21EC15C", VA = "0x21EC15C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004995")]
			[Address(RVA = "0x21EBA58", Offset = "0x21EBA58", VA = "0x21EBA58")]
			set
			{
			}
		}

		[Token(Token = "0x170009DD")]
		public int NewMailCount
		{
			[Token(Token = "0x6004996")]
			[Address(RVA = "0x21EC164", Offset = "0x21EC164", VA = "0x21EC164")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004997")]
			[Address(RVA = "0x21EC16C", Offset = "0x21EC16C", VA = "0x21EC16C")]
			set
			{
			}
		}

		[Token(Token = "0x170009DE")]
		public virtual Dictionary<int, int> ClearMissionStage
		{
			[Token(Token = "0x6004998")]
			[Address(RVA = "0x21EC174", Offset = "0x21EC174", VA = "0x21EC174", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004999")]
			[Address(RVA = "0x21EC17C", Offset = "0x21EC17C", VA = "0x21EC17C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170009DF")]
		public int ClearTicket
		{
			[Token(Token = "0x600499A")]
			[Address(RVA = "0x21EC184", Offset = "0x21EC184", VA = "0x21EC184")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600499B")]
			[Address(RVA = "0x21EC18C", Offset = "0x21EC18C", VA = "0x21EC18C")]
			set
			{
			}
		}

		[Token(Token = "0x170009E0")]
		public Dictionary<RankType, List<int>> FirstRankRewardRecordDictionary
		{
			[Token(Token = "0x600499C")]
			[Address(RVA = "0x21EC194", Offset = "0x21EC194", VA = "0x21EC194")]
			get
			{
				return null;
			}
			[Token(Token = "0x600499D")]
			[Address(RVA = "0x21EBAC8", Offset = "0x21EBAC8", VA = "0x21EBAC8")]
			set
			{
			}
		}

		[Token(Token = "0x170009E1")]
		public int TrophyRewardCoolTimePassCount
		{
			[Token(Token = "0x600499E")]
			[Address(RVA = "0x21EC19C", Offset = "0x21EC19C", VA = "0x21EC19C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600499F")]
			[Address(RVA = "0x21EC1A4", Offset = "0x21EC1A4", VA = "0x21EC1A4")]
			set
			{
			}
		}

		[Token(Token = "0x170009E2")]
		public DateTime TrophyRewardLastGetTime
		{
			[Token(Token = "0x60049A0")]
			[Address(RVA = "0x21EC1AC", Offset = "0x21EC1AC", VA = "0x21EC1AC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60049A1")]
			[Address(RVA = "0x21EC1BC", Offset = "0x21EC1BC", VA = "0x21EC1BC")]
			set
			{
			}
		}

		[Token(Token = "0x170009E3")]
		public int TrophyRewardPoint
		{
			[Token(Token = "0x60049A2")]
			[Address(RVA = "0x21EC1D4", Offset = "0x21EC1D4", VA = "0x21EC1D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049A3")]
			[Address(RVA = "0x21EBAD0", Offset = "0x21EBAD0", VA = "0x21EBAD0")]
			set
			{
			}
		}

		[Token(Token = "0x170009E4")]
		public int ItemBooster
		{
			[Token(Token = "0x60049A4")]
			[Address(RVA = "0x21EC1DC", Offset = "0x21EC1DC", VA = "0x21EC1DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049A5")]
			[Address(RVA = "0x21EC1E4", Offset = "0x21EC1E4", VA = "0x21EC1E4")]
			set
			{
			}
		}

		[Token(Token = "0x170009E5")]
		public int GoldBooster
		{
			[Token(Token = "0x60049A6")]
			[Address(RVA = "0x21EC1EC", Offset = "0x21EC1EC", VA = "0x21EC1EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049A7")]
			[Address(RVA = "0x21EC1F4", Offset = "0x21EC1F4", VA = "0x21EC1F4")]
			set
			{
			}
		}

		[Token(Token = "0x170009E6")]
		public int PromstoneBooster
		{
			[Token(Token = "0x60049A8")]
			[Address(RVA = "0x21EC1FC", Offset = "0x21EC1FC", VA = "0x21EC1FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049A9")]
			[Address(RVA = "0x21EC204", Offset = "0x21EC204", VA = "0x21EC204")]
			set
			{
			}
		}

		[Token(Token = "0x170009E7")]
		public GameSession GameSession
		{
			[Token(Token = "0x60049AA")]
			[Address(RVA = "0x21EC20C", Offset = "0x21EC20C", VA = "0x21EC20C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049AB")]
			[Address(RVA = "0x21EC214", Offset = "0x21EC214", VA = "0x21EC214")]
			set
			{
			}
		}

		[Token(Token = "0x170009E8")]
		[JsonIgnore]
		public string GameId
		{
			[Token(Token = "0x60049AC")]
			[Address(RVA = "0x21EC21C", Offset = "0x21EC21C", VA = "0x21EC21C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E9")]
		[JsonIgnore]
		public bool IsFriendlyMatch
		{
			[Token(Token = "0x60049AD")]
			[Address(RVA = "0x21EC244", Offset = "0x21EC244", VA = "0x21EC244")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009EA")]
		public int MedalOfHonor
		{
			[Token(Token = "0x60049AE")]
			[Address(RVA = "0x21EC26C", Offset = "0x21EC26C", VA = "0x21EC26C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049AF")]
			[Address(RVA = "0x21EC274", Offset = "0x21EC274", VA = "0x21EC274")]
			set
			{
			}
		}

		[Token(Token = "0x170009EB")]
		public CharPartyData CharParty
		{
			[Token(Token = "0x60049B0")]
			[Address(RVA = "0x21EC27C", Offset = "0x21EC27C", VA = "0x21EC27C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049B1")]
			[Address(RVA = "0x21EBA78", Offset = "0x21EBA78", VA = "0x21EBA78")]
			set
			{
			}
		}

		[Token(Token = "0x170009EC")]
		public int MedalOfWarrior
		{
			[Token(Token = "0x60049B2")]
			[Address(RVA = "0x21EC284", Offset = "0x21EC284", VA = "0x21EC284")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049B3")]
			[Address(RVA = "0x21EC28C", Offset = "0x21EC28C", VA = "0x21EC28C")]
			set
			{
			}
		}

		[Token(Token = "0x170009ED")]
		public HashSet<string> UnlockFeatures
		{
			[Token(Token = "0x60049B4")]
			[Address(RVA = "0x21EC294", Offset = "0x21EC294", VA = "0x21EC294")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049B5")]
			[Address(RVA = "0x21EBA60", Offset = "0x21EBA60", VA = "0x21EBA60")]
			set
			{
			}
		}

		[Token(Token = "0x170009EE")]
		public virtual IncreasableDictionary<string> DateStats
		{
			[Token(Token = "0x60049B6")]
			[Address(RVA = "0x21EC29C", Offset = "0x21EC29C", VA = "0x21EC29C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049B7")]
			[Address(RVA = "0x21EC2A4", Offset = "0x21EC2A4", VA = "0x21EC2A4", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170009EF")]
		public virtual IncreasableDictionary<string> DailyStats
		{
			[Token(Token = "0x60049B8")]
			[Address(RVA = "0x21EC2AC", Offset = "0x21EC2AC", VA = "0x21EC2AC", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049B9")]
			[Address(RVA = "0x21EC2B4", Offset = "0x21EC2B4", VA = "0x21EC2B4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x170009F0")]
		public virtual IncreasableDictionary<string> TotalStats
		{
			[Token(Token = "0x60049BA")]
			[Address(RVA = "0x21EC2BC", Offset = "0x21EC2BC", VA = "0x21EC2BC", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049BB")]
			[Address(RVA = "0x21EC2C4", Offset = "0x21EC2C4", VA = "0x21EC2C4", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170009F1")]
		public virtual IncreasableDictionary<string> WeeklyStats
		{
			[Token(Token = "0x60049BC")]
			[Address(RVA = "0x21EC2CC", Offset = "0x21EC2CC", VA = "0x21EC2CC", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049BD")]
			[Address(RVA = "0x21EC2D4", Offset = "0x21EC2D4", VA = "0x21EC2D4", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170009F2")]
		public virtual Dictionary<string, int> Achievements
		{
			[Token(Token = "0x60049BE")]
			[Address(RVA = "0x21EC2DC", Offset = "0x21EC2DC", VA = "0x21EC2DC", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049BF")]
			[Address(RVA = "0x21EC2E4", Offset = "0x21EC2E4", VA = "0x21EC2E4", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x170009F3")]
		public int CombatPoint
		{
			[Token(Token = "0x60049C0")]
			[Address(RVA = "0x21EC2EC", Offset = "0x21EC2EC", VA = "0x21EC2EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049C1")]
			[Address(RVA = "0x21EC2F4", Offset = "0x21EC2F4", VA = "0x21EC2F4")]
			set
			{
			}
		}

		[Token(Token = "0x170009F4")]
		public List<int> DailyBox
		{
			[Token(Token = "0x60049C2")]
			[Address(RVA = "0x21EC2FC", Offset = "0x21EC2FC", VA = "0x21EC2FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049C3")]
			[Address(RVA = "0x21EBA68", Offset = "0x21EBA68", VA = "0x21EBA68")]
			set
			{
			}
		}

		[Token(Token = "0x170009F5")]
		public long AttendanceLastTimeStamp
		{
			[Token(Token = "0x60049C4")]
			[Address(RVA = "0x21EC304", Offset = "0x21EC304", VA = "0x21EC304")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60049C5")]
			[Address(RVA = "0x21EC314", Offset = "0x21EC314", VA = "0x21EC314")]
			set
			{
			}
		}

		[Token(Token = "0x170009F6")]
		public long EventAttendanceLastTimeStamp
		{
			[Token(Token = "0x60049C6")]
			[Address(RVA = "0x21EC320", Offset = "0x21EC320", VA = "0x21EC320")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60049C7")]
			[Address(RVA = "0x21EC330", Offset = "0x21EC330", VA = "0x21EC330")]
			set
			{
			}
		}

		[Token(Token = "0x170009F7")]
		public int TalentPoint
		{
			[Token(Token = "0x60049C8")]
			[Address(RVA = "0x21E6480", Offset = "0x21E6480", VA = "0x21E6480")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049C9")]
			[Address(RVA = "0x21EC33C", Offset = "0x21EC33C", VA = "0x21EC33C")]
			set
			{
			}
		}

		[Token(Token = "0x170009F8")]
		public Dictionary<string, Dictionary<int, int>> Talent
		{
			[Token(Token = "0x60049CA")]
			[Address(RVA = "0x21E5F4C", Offset = "0x21E5F4C", VA = "0x21E5F4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049CB")]
			[Address(RVA = "0x21EBA80", Offset = "0x21EBA80", VA = "0x21EBA80")]
			set
			{
			}
		}

		[Token(Token = "0x170009F9")]
		public Dictionary<int, int> Relic
		{
			[Token(Token = "0x60049CC")]
			[Address(RVA = "0x21EC344", Offset = "0x21EC344", VA = "0x21EC344")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049CD")]
			[Address(RVA = "0x21EBA88", Offset = "0x21EBA88", VA = "0x21EBA88")]
			set
			{
			}
		}

		[Token(Token = "0x170009FA")]
		public short TitleId
		{
			[Token(Token = "0x60049CE")]
			[Address(RVA = "0x21EC34C", Offset = "0x21EC34C", VA = "0x21EC34C")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x60049CF")]
			[Address(RVA = "0x21E9778", Offset = "0x21E9778", VA = "0x21E9778")]
			set
			{
			}
		}

		[Token(Token = "0x170009FB")]
		public List<int> Titles
		{
			[Token(Token = "0x60049D0")]
			[Address(RVA = "0x21E96C8", Offset = "0x21E96C8", VA = "0x21E96C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D1")]
			[Address(RVA = "0x21EBA90", Offset = "0x21EBA90", VA = "0x21EBA90")]
			set
			{
			}
		}

		[Token(Token = "0x170009FC")]
		public ExpireList ExpireList
		{
			[Token(Token = "0x60049D2")]
			[Address(RVA = "0x21E2E30", Offset = "0x21E2E30", VA = "0x21E2E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D3")]
			[Address(RVA = "0x21EC358", Offset = "0x21EC358", VA = "0x21EC358")]
			set
			{
			}
		}

		[Token(Token = "0x170009FD")]
		public LimitItemPurchasedList LimitItemPurchasedList
		{
			[Token(Token = "0x60049D4")]
			[Address(RVA = "0x21EC360", Offset = "0x21EC360", VA = "0x21EC360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D5")]
			[Address(RVA = "0x21EC400", Offset = "0x21EC400", VA = "0x21EC400")]
			set
			{
			}
		}

		[Token(Token = "0x170009FE")]
		public IncreasableDictionary<RankType> RankRewarded
		{
			[Token(Token = "0x60049D6")]
			[Address(RVA = "0x21EC408", Offset = "0x21EC408", VA = "0x21EC408")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D7")]
			[Address(RVA = "0x21EC4B8", Offset = "0x21EC4B8", VA = "0x21EC4B8")]
			set
			{
			}
		}

		[Token(Token = "0x170009FF")]
		public bool IsUseItemBooster
		{
			[Token(Token = "0x60049D8")]
			[Address(RVA = "0x21EC4C0", Offset = "0x21EC4C0", VA = "0x21EC4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049D9")]
			[Address(RVA = "0x21EC4C8", Offset = "0x21EC4C8", VA = "0x21EC4C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A00")]
		public bool IsUseGoldBooster
		{
			[Token(Token = "0x60049DA")]
			[Address(RVA = "0x21EC4D0", Offset = "0x21EC4D0", VA = "0x21EC4D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049DB")]
			[Address(RVA = "0x21EC4D8", Offset = "0x21EC4D8", VA = "0x21EC4D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A01")]
		public bool IsUsePromstoneBooster
		{
			[Token(Token = "0x60049DC")]
			[Address(RVA = "0x21EC4E0", Offset = "0x21EC4E0", VA = "0x21EC4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049DD")]
			[Address(RVA = "0x21EC4E8", Offset = "0x21EC4E8", VA = "0x21EC4E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A02")]
		public Dictionary<string, TimeStampData> TimeStamps
		{
			[Token(Token = "0x60049DE")]
			[Address(RVA = "0x21EC4F0", Offset = "0x21EC4F0", VA = "0x21EC4F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049DF")]
			[Address(RVA = "0x21EBA70", Offset = "0x21EBA70", VA = "0x21EBA70")]
			set
			{
			}
		}

		[Token(Token = "0x17000A03")]
		public ContinuousItem continuousItems
		{
			[Token(Token = "0x60049E0")]
			[Address(RVA = "0x21EC4F8", Offset = "0x21EC4F8", VA = "0x21EC4F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049E1")]
			[Address(RVA = "0x21EBAC0", Offset = "0x21EBAC0", VA = "0x21EBAC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A04")]
		public EloImpl Elo
		{
			[Token(Token = "0x60049E2")]
			[Address(RVA = "0x21EC500", Offset = "0x21EC500", VA = "0x21EC500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x21EBAB0", Offset = "0x21EBAB0", VA = "0x21EBAB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A05")]
		public Dictionary<int, RotationItemSet> RotationItems
		{
			[Token(Token = "0x60049E4")]
			[Address(RVA = "0x21EC508", Offset = "0x21EC508", VA = "0x21EC508")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049E5")]
			[Address(RVA = "0x21EC5B8", Offset = "0x21EC5B8", VA = "0x21EC5B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A06")]
		public List<BoughtLimitedGoods> BoughtLimitedGoodsList
		{
			[Token(Token = "0x60049E6")]
			[Address(RVA = "0x21DFC4C", Offset = "0x21DFC4C", VA = "0x21DFC4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049E7")]
			[Address(RVA = "0x21EC5C0", Offset = "0x21EC5C0", VA = "0x21EC5C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A07")]
		public int PromotionWeaponStone
		{
			[Token(Token = "0x60049E8")]
			[Address(RVA = "0x21EC5C8", Offset = "0x21EC5C8", VA = "0x21EC5C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049E9")]
			[Address(RVA = "0x21EC5D0", Offset = "0x21EC5D0", VA = "0x21EC5D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A08")]
		public int PromotionArmorStone
		{
			[Token(Token = "0x60049EA")]
			[Address(RVA = "0x21EC5D8", Offset = "0x21EC5D8", VA = "0x21EC5D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049EB")]
			[Address(RVA = "0x21EC5E0", Offset = "0x21EC5E0", VA = "0x21EC5E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A09")]
		public int PromotionAccessoryStone
		{
			[Token(Token = "0x60049EC")]
			[Address(RVA = "0x21EC5E8", Offset = "0x21EC5E8", VA = "0x21EC5E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049ED")]
			[Address(RVA = "0x21EC5F0", Offset = "0x21EC5F0", VA = "0x21EC5F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A0A")]
		public int FreeRevivedCnt
		{
			[Token(Token = "0x60049EE")]
			[Address(RVA = "0x21EC5F8", Offset = "0x21EC5F8", VA = "0x21EC5F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049EF")]
			[Address(RVA = "0x21EC600", Offset = "0x21EC600", VA = "0x21EC600")]
			set
			{
			}
		}

		[Token(Token = "0x17000A0B")]
		public int ProfileIconID
		{
			[Token(Token = "0x60049F0")]
			[Address(RVA = "0x21EC608", Offset = "0x21EC608", VA = "0x21EC608")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049F1")]
			[Address(RVA = "0x21EBA98", Offset = "0x21EBA98", VA = "0x21EBA98")]
			set
			{
			}
		}

		[Token(Token = "0x17000A0C")]
		public List<int> ProfileIcons
		{
			[Token(Token = "0x60049F2")]
			[Address(RVA = "0x21EC610", Offset = "0x21EC610", VA = "0x21EC610")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F3")]
			[Address(RVA = "0x21EBAA0", Offset = "0x21EBAA0", VA = "0x21EBAA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A0D")]
		[JsonIgnore]
		public int EmoticonSetID
		{
			[Token(Token = "0x60049F4")]
			[Address(RVA = "0x21EC618", Offset = "0x21EC618", VA = "0x21EC618")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049F5")]
			[Address(RVA = "0x21EC630", Offset = "0x21EC630", VA = "0x21EC630")]
			set
			{
			}
		}

		[Token(Token = "0x17000A0E")]
		[JsonIgnore]
		public List<int> EmoticonSets
		{
			[Token(Token = "0x60049F6")]
			[Address(RVA = "0x21EC638", Offset = "0x21EC638", VA = "0x21EC638")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F7")]
			[Address(RVA = "0x21EC754", Offset = "0x21EC754", VA = "0x21EC754")]
			set
			{
			}
		}

		[Token(Token = "0x17000A0F")]
		public Dictionary<CSNotificationType, int> Notifications
		{
			[Token(Token = "0x60049F8")]
			[Address(RVA = "0x21EC75C", Offset = "0x21EC75C", VA = "0x21EC75C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F9")]
			[Address(RVA = "0x21EBAA8", Offset = "0x21EBAA8", VA = "0x21EBAA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A10")]
		public string ClanId
		{
			[Token(Token = "0x60049FA")]
			[Address(RVA = "0x21EC764", Offset = "0x21EC764", VA = "0x21EC764")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049FB")]
			[Address(RVA = "0x21EC76C", Offset = "0x21EC76C", VA = "0x21EC76C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A11")]
		public int CombatPower
		{
			[Token(Token = "0x60049FC")]
			[Address(RVA = "0x21EC774", Offset = "0x21EC774", VA = "0x21EC774")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60049FD")]
			[Address(RVA = "0x21EC77C", Offset = "0x21EC77C", VA = "0x21EC77C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A12")]
		public PlacementTestInfo PlacementTest
		{
			[Token(Token = "0x60049FE")]
			[Address(RVA = "0x21EC784", Offset = "0x21EC784", VA = "0x21EC784")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049FF")]
			[Address(RVA = "0x21EBAD8", Offset = "0x21EBAD8", VA = "0x21EBAD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A13")]
		public int PointShopAdvertisementChargeCount
		{
			[Token(Token = "0x6004A00")]
			[Address(RVA = "0x21EC78C", Offset = "0x21EC78C", VA = "0x21EC78C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A01")]
			[Address(RVA = "0x21EC794", Offset = "0x21EC794", VA = "0x21EC794")]
			set
			{
			}
		}

		[Token(Token = "0x17000A14")]
		public long PointShopAdvertisementLastChargeTime
		{
			[Token(Token = "0x6004A02")]
			[Address(RVA = "0x21EC79C", Offset = "0x21EC79C", VA = "0x21EC79C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004A03")]
			[Address(RVA = "0x21EC7AC", Offset = "0x21EC7AC", VA = "0x21EC7AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A15")]
		public PandoraBoxLastRecieveInfo PandoraLastRecieveInfo
		{
			[Token(Token = "0x6004A05")]
			[Address(RVA = "0x21EC9DC", Offset = "0x21EC9DC", VA = "0x21EC9DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A06")]
			[Address(RVA = "0x21ECA7C", Offset = "0x21ECA7C", VA = "0x21ECA7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A16")]
		public EventGameModeClearRecord EventModeClearRecord
		{
			[Token(Token = "0x6004A07")]
			[Address(RVA = "0x21ECA84", Offset = "0x21ECA84", VA = "0x21ECA84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A08")]
			[Address(RVA = "0x21ECB24", Offset = "0x21ECB24", VA = "0x21ECB24")]
			set
			{
			}
		}

		[Token(Token = "0x17000A17")]
		[JsonIgnore]
		public bool IsClanMember
		{
			[Token(Token = "0x6004A0E")]
			[Address(RVA = "0x21ED1FC", Offset = "0x21ED1FC", VA = "0x21ED1FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A18")]
		public int MannerGood
		{
			[Token(Token = "0x6004A0F")]
			[Address(RVA = "0x21ED2AC", Offset = "0x21ED2AC", VA = "0x21ED2AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A10")]
			[Address(RVA = "0x21ED2B4", Offset = "0x21ED2B4", VA = "0x21ED2B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000A19")]
		public int MannerBad
		{
			[Token(Token = "0x6004A11")]
			[Address(RVA = "0x21ED2BC", Offset = "0x21ED2BC", VA = "0x21ED2BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A12")]
			[Address(RVA = "0x21ED2C4", Offset = "0x21ED2C4", VA = "0x21ED2C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1A")]
		public int MannerPoint
		{
			[Token(Token = "0x6004A13")]
			[Address(RVA = "0x21ED2CC", Offset = "0x21ED2CC", VA = "0x21ED2CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A14")]
			[Address(RVA = "0x21ED2D4", Offset = "0x21ED2D4", VA = "0x21ED2D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1B")]
		public MannerRepairInfo MannerRepairInfo
		{
			[Token(Token = "0x6004A15")]
			[Address(RVA = "0x21ED2DC", Offset = "0x21ED2DC", VA = "0x21ED2DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A16")]
			[Address(RVA = "0x21ED37C", Offset = "0x21ED37C", VA = "0x21ED37C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1C")]
		public RandomOptionChangeWaitStorage RandomOptionChangeWaitStorage
		{
			[Token(Token = "0x6004A17")]
			[Address(RVA = "0x21ED384", Offset = "0x21ED384", VA = "0x21ED384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A18")]
			[Address(RVA = "0x21EBAB8", Offset = "0x21EBAB8", VA = "0x21EBAB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1D")]
		public int Fatigue
		{
			[Token(Token = "0x6004A19")]
			[Address(RVA = "0x21ED38C", Offset = "0x21ED38C", VA = "0x21ED38C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A1A")]
			[Address(RVA = "0x21ED394", Offset = "0x21ED394", VA = "0x21ED394")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1E")]
		public AttendanceState AttendanceState
		{
			[Token(Token = "0x6004A1B")]
			[Address(RVA = "0x21ED39C", Offset = "0x21ED39C", VA = "0x21ED39C")]
			get
			{
				return default(AttendanceState);
			}
			[Token(Token = "0x6004A1C")]
			[Address(RVA = "0x21ED3A4", Offset = "0x21ED3A4", VA = "0x21ED3A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000A1F")]
		public string PetId
		{
			[Token(Token = "0x6004A1D")]
			[Address(RVA = "0x21ED3AC", Offset = "0x21ED3AC", VA = "0x21ED3AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A1E")]
			[Address(RVA = "0x21ED3B4", Offset = "0x21ED3B4", VA = "0x21ED3B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000A20")]
		public bool PetIsNotShowed
		{
			[Token(Token = "0x6004A1F")]
			[Address(RVA = "0x21ED3BC", Offset = "0x21ED3BC", VA = "0x21ED3BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A20")]
			[Address(RVA = "0x21ED3C4", Offset = "0x21ED3C4", VA = "0x21ED3C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000A21")]
		public bool UseCPQ
		{
			[Token(Token = "0x6004A21")]
			[Address(RVA = "0x21ED3CC", Offset = "0x21ED3CC", VA = "0x21ED3CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A22")]
			[Address(RVA = "0x21EBAE0", Offset = "0x21EBAE0", VA = "0x21EBAE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A22")]
		public bool IsTransferReservation
		{
			[Token(Token = "0x6004A23")]
			[Address(RVA = "0x21ED3D4", Offset = "0x21ED3D4", VA = "0x21ED3D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A24")]
			[Address(RVA = "0x21EBAE8", Offset = "0x21EBAE8", VA = "0x21EBAE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A23")]
		public bool IsTransferComplete
		{
			[Token(Token = "0x6004A25")]
			[Address(RVA = "0x21ED3DC", Offset = "0x21ED3DC", VA = "0x21ED3DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A26")]
			[Address(RVA = "0x21EBAF0", Offset = "0x21EBAF0", VA = "0x21EBAF0")]
			set
			{
			}
		}

		[Token(Token = "0x6004979")]
		[Address(RVA = "0x21EB378", Offset = "0x21EB378", VA = "0x21EB378")]
		public UserDataBase()
		{
		}

		[Token(Token = "0x600497A")]
		[Address(RVA = "0x21EBAF8", Offset = "0x21EBAF8", VA = "0x21EBAF8", Slot = "4")]
		protected override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x600497B")]
		[Address(RVA = "0x21EBB00", Offset = "0x21EBB00", VA = "0x21EBB00", Slot = "5")]
		protected override bool Remove()
		{
			return default(bool);
		}

		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x21EC7B8", Offset = "0x21EC7B8", VA = "0x21EC7B8")]
		public bool IsOverPointShopAdvertisementChargeTime(DateTime serverLocalNow, int resetHour)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x21ECB2C", Offset = "0x21ECB2C", VA = "0x21ECB2C")]
		public IronsMissionState GetIronsMissionState(int questId)
		{
			return null;
		}

		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x21ECC3C", Offset = "0x21ECC3C", VA = "0x21ECC3C")]
		public void SetIronsMissionState(int questId, int current, int max, MissionState state)
		{
		}

		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x21ECD98", Offset = "0x21ECD98", VA = "0x21ECD98")]
		public bool CanReceiveIronsMissionReward()
		{
			return default(bool);
		}

		[Token(Token = "0x6004A0C")]
		[Address(RVA = "0x21ECEF8", Offset = "0x21ECEF8", VA = "0x21ECEF8")]
		public bool IronsMissionIsFinished(Dictionary<int, IronsMission> missions)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A0D")]
		[Address(RVA = "0x21ED06C", Offset = "0x21ED06C", VA = "0x21ED06C")]
		public IronsMission GetProgressingIronsMission(Dictionary<int, IronsMission> missions)
		{
			return null;
		}

		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x21EBEF4", Offset = "0x21EBEF4", VA = "0x21EBEF4")]
		public ComplexCurrency GetComplexCurrency(Currency currency)
		{
			return null;
		}

		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x21EBB50", Offset = "0x21EBB50", VA = "0x21EBB50")]
		public int GetCurrency(Currency currency)
		{
			return default(int);
		}

		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x21ED3E4", Offset = "0x21ED3E4", VA = "0x21ED3E4")]
		public bool HaveReward(int PreviousSeason)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x21ED7F0", Offset = "0x21ED7F0", VA = "0x21ED7F0")]
		public void AddTotalStats(string type, int adjustCount)
		{
		}

		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x21ED978", Offset = "0x21ED978", VA = "0x21ED978")]
		public int GetDateStats(string type)
		{
			return default(int);
		}

		[Token(Token = "0x6004A2C")]
		[Address(RVA = "0x21EDAA8", Offset = "0x21EDAA8", VA = "0x21EDAA8")]
		public int GetDailyStats(string type)
		{
			return default(int);
		}

		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x21EDBD8", Offset = "0x21EDBD8", VA = "0x21EDBD8")]
		public int GetWeeklyStats(string type)
		{
			return default(int);
		}

		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x21E58F4", Offset = "0x21E58F4", VA = "0x21E58F4")]
		public int GetTotalStats(string type)
		{
			return default(int);
		}

		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x21DFDC8", Offset = "0x21DFDC8", VA = "0x21DFDC8")]
		public int GetBoughtAccountLimitedShopItem(int productId)
		{
			return default(int);
		}

		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x21EDD08", Offset = "0x21EDD08", VA = "0x21EDD08")]
		public void AddBoughtAccountLimitedShopItem(int productId)
		{
		}

		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x21EDE08", Offset = "0x21EDE08", VA = "0x21EDE08")]
		public void AddTimeStamp(string id, DateTime utcDateTime, int inc_count = 0)
		{
		}

		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x21EDFD4", Offset = "0x21EDFD4", VA = "0x21EDFD4")]
		public void AddTimeStampOnlyCount(string id, int inc_count = 0)
		{
		}

		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x21EE088", Offset = "0x21EE088", VA = "0x21EE088")]
		public void ResetTimeStampCount(string id)
		{
		}

		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x21EE170", Offset = "0x21EE170", VA = "0x21EE170")]
		public int CheckFeatureAuthorityCount()
		{
			return default(int);
		}

		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x21EE208", Offset = "0x21EE208", VA = "0x21EE208")]
		public bool CheckFeatureAuthority(XGameModeType mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x21EE324", Offset = "0x21EE324", VA = "0x21EE324")]
		public bool ContainsProfileIcon(int profileIconID)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x21EE3C4", Offset = "0x21EE3C4", VA = "0x21EE3C4")]
		public void ClearGameSession()
		{
		}

		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x21EC234", Offset = "0x21EC234", VA = "0x21EC234")]
		public bool HasGameSession()
		{
			return default(bool);
		}

		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x21EE3D0", Offset = "0x21EE3D0", VA = "0x21EE3D0")]
		public bool HaveRandomOptionChangeWaitList(string targetIID)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0x21EE420", Offset = "0x21EE420", VA = "0x21EE420")]
		public bool IsEqualRandomOptionWaitIID(string targetIID)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A3B")]
		[Address(RVA = "0x21EE4E4", Offset = "0x21EE4E4", VA = "0x21EE4E4")]
		public NetData_UserResource ToNetdataResource()
		{
			return null;
		}
	}
}
