using System;
using System.Collections.Generic;
using CS;
using CS.ranking;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XJsonHelper;

[Token(Token = "0x2001081")]
public class XMyInfo : UserDataBase
{
	[Serializable]
	[Token(Token = "0x2001082")]
	public class TestTT : NetData_Userdata
	{
		[Token(Token = "0x4005909")]
		[FieldOffset(Offset = "0x15C")]
		private Serialization<int> _profile_icons;

		[Token(Token = "0x400590A")]
		[FieldOffset(Offset = "0x160")]
		private Serialization<string> _unlock_feautres;

		[Token(Token = "0x400590B")]
		[FieldOffset(Offset = "0x164")]
		private Serialization<int> _Titles;

		[Token(Token = "0x400590C")]
		[FieldOffset(Offset = "0x168")]
		private Serialization<string, int> _DateStats;

		[Token(Token = "0x400590D")]
		[FieldOffset(Offset = "0x16C")]
		private Serialization<string, int> _DailyStats;

		[Token(Token = "0x400590E")]
		[FieldOffset(Offset = "0x170")]
		private Serialization<string, int> _TotalStats;

		[Token(Token = "0x400590F")]
		[FieldOffset(Offset = "0x174")]
		private Serialization<string, int> _WeeklyStats;

		[Token(Token = "0x4005910")]
		[FieldOffset(Offset = "0x178")]
		private Serialization<string, int> _Achievements;

		[Token(Token = "0x4005911")]
		[FieldOffset(Offset = "0x17C")]
		private Serialization<string, Serialization<int, int>> _talent;

		[Token(Token = "0x4005912")]
		[FieldOffset(Offset = "0x180")]
		private Serialization<string, int> _Relic;

		[Token(Token = "0x6007CBE")]
		[Address(RVA = "0xBA5884", Offset = "0xBA5884", VA = "0xBA5884")]
		public TestTT()
		{
		}

		[Token(Token = "0x6007CBF")]
		[Address(RVA = "0xBA588C", Offset = "0xBA588C", VA = "0xBA588C")]
		public void Sync()
		{
		}
	}

	[Token(Token = "0x2001083")]
	private sealed class _003CIsUnlockablePeriodSkin_003Ec__AnonStorey25C
	{
		[Token(Token = "0x4005913")]
		[FieldOffset(Offset = "0x8")]
		internal int skinID;

		[Token(Token = "0x4005914")]
		[FieldOffset(Offset = "0xC")]
		internal XMyInfo _003C_003Ef__this;

		[Token(Token = "0x6007CC0")]
		[Address(RVA = "0xBA022C", Offset = "0xBA022C", VA = "0xBA022C")]
		public _003CIsUnlockablePeriodSkin_003Ec__AnonStorey25C()
		{
		}

		[Token(Token = "0x6007CC1")]
		[Address(RVA = "0xBA5824", Offset = "0xBA5824", VA = "0xBA5824")]
		internal bool _003C_003Em__53D(SkinInfo skinInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40058EA")]
	[FieldOffset(Offset = "0x190")]
	public XCacheGameRecords GameRecord;

	[Token(Token = "0x40058EB")]
	[FieldOffset(Offset = "0x194")]
	public XMyGameResource m_GameResource;

	[Token(Token = "0x40058EC")]
	[FieldOffset(Offset = "0x198")]
	public XCharacterInventory m_CharacterInventory;

	[Token(Token = "0x40058ED")]
	[FieldOffset(Offset = "0x19C")]
	public XCharacterInventory m_CharacterInventoryNotowned;

	[Token(Token = "0x40058EE")]
	[FieldOffset(Offset = "0x1A0")]
	public XPetInventory m_PetInventory;

	[Token(Token = "0x40058EF")]
	[FieldOffset(Offset = "0x1A4")]
	public XPetInventory m_PetInventoryNotowned;

	[Token(Token = "0x40058F0")]
	[FieldOffset(Offset = "0x1A8")]
	public XCharParty m_SelCharParty;

	[Token(Token = "0x40058F1")]
	[FieldOffset(Offset = "0x1AC")]
	public XItemInventory m_ItemInventory;

	[Token(Token = "0x40058F2")]
	[FieldOffset(Offset = "0x1B0")]
	public CSContent AttendanceReward;

	[Token(Token = "0x40058F3")]
	[FieldOffset(Offset = "0x1B4")]
	public int CharMaxCount;

	[Token(Token = "0x40058F4")]
	[FieldOffset(Offset = "0x1B8")]
	public int PetMaxCount;

	[Token(Token = "0x40058F5")]
	[FieldOffset(Offset = "0x1BC")]
	public int energyDelta;

	[Token(Token = "0x40058F6")]
	[FieldOffset(Offset = "0x1C0")]
	public Dictionary<int, Netdata_StallItem> m_stallItemList;

	[Token(Token = "0x40058F7")]
	[FieldOffset(Offset = "0x1C4")]
	public data RankingData;

	[Token(Token = "0x40058F8")]
	[FieldOffset(Offset = "0x1C8")]
	public data RankingData_Last;

	[Token(Token = "0x40058F9")]
	[FieldOffset(Offset = "0x1CC")]
	public XCacheNewQeustNotiInfo cacheQuestNotiInfo;

	[Token(Token = "0x40058FA")]
	[FieldOffset(Offset = "0x1D0")]
	public XCacheNewTitleNotiInfo cacheTitleNotiInfo;

	[Token(Token = "0x40058FB")]
	[FieldOffset(Offset = "0x1D4")]
	public List<int> m_achieveClearItemList;

	[Token(Token = "0x40058FC")]
	[FieldOffset(Offset = "0x1D8")]
	public List<int> cache_achieveClearItemList;

	[Token(Token = "0x40058FD")]
	[FieldOffset(Offset = "0x1DC")]
	public bool AchievementNotice;

	[Token(Token = "0x40058FE")]
	[FieldOffset(Offset = "0x1E0")]
	public QuestInfo myLastQuest;

	[Token(Token = "0x40058FF")]
	[FieldOffset(Offset = "0x1E4")]
	public CSStageInfo lastPlayMissionInfo;

	[Token(Token = "0x4005900")]
	[FieldOffset(Offset = "0x1E8")]
	public bool failure_mission_game;

	[Token(Token = "0x4005901")]
	[FieldOffset(Offset = "0x1E9")]
	public bool IsGetExpireEventGameModeReward;

	[Token(Token = "0x4005902")]
	[FieldOffset(Offset = "0x1EC")]
	private CharStatus m_talentStatus;

	[Token(Token = "0x4005903")]
	[FieldOffset(Offset = "0x1F0")]
	public IncreasableDictionary<string> WeeklyStats_Before;

	[Token(Token = "0x4005904")]
	[FieldOffset(Offset = "0x1F4")]
	private XRankingDataCache m_rankingDataCache;

	[Token(Token = "0x4005905")]
	[FieldOffset(Offset = "0x1F8")]
	private long LoginServerUtcTimeTick__BackingField;

	[Token(Token = "0x4005906")]
	[FieldOffset(Offset = "0x200")]
	private Dictionary<RankType, GameRecord> RankRecord__BackingField;

	[Token(Token = "0x4005907")]
	[FieldOffset(Offset = "0x204")]
	private bool IsEnabled__BackingField;

	[Token(Token = "0x4005908")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache1E;

	[Token(Token = "0x17000F59")]
	public long LoginServerUtcTimeTick
	{
		[Token(Token = "0x6007C67")]
		[Address(RVA = "0xB9E450", Offset = "0xB9E450", VA = "0xB9E450")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007C68")]
		[Address(RVA = "0xB9E460", Offset = "0xB9E460", VA = "0xB9E460")]
		set
		{
		}
	}

	[Token(Token = "0x17000F5A")]
	public Dictionary<RankType, GameRecord> RankRecord
	{
		[Token(Token = "0x6007C69")]
		[Address(RVA = "0xB9E46C", Offset = "0xB9E46C", VA = "0xB9E46C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007C6A")]
		[Address(RVA = "0xB9E440", Offset = "0xB9E440", VA = "0xB9E440")]
		private set
		{
		}
	}

	[Token(Token = "0x17000F5B")]
	public bool IsEnabled
	{
		[Token(Token = "0x6007C6B")]
		[Address(RVA = "0xB9E474", Offset = "0xB9E474", VA = "0xB9E474")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007C6C")]
		[Address(RVA = "0xB9E448", Offset = "0xB9E448", VA = "0xB9E448")]
		set
		{
		}
	}

	[Token(Token = "0x17000F5C")]
	public int MaxStamina
	{
		[Token(Token = "0x6007C84")]
		[Address(RVA = "0xB9EBD8", Offset = "0xB9EBD8", VA = "0xB9EBD8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000F5D")]
	public int MaxEnergy
	{
		[Token(Token = "0x6007C85")]
		[Address(RVA = "0xB9ECF4", Offset = "0xB9ECF4", VA = "0xB9ECF4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007C66")]
	[Address(RVA = "0xB9E0E8", Offset = "0xB9E0E8", VA = "0xB9E0E8")]
	public XMyInfo()
	{
	}

	[Token(Token = "0x6007C6D")]
	[Address(RVA = "0xB9E47C", Offset = "0xB9E47C", VA = "0xB9E47C")]
	public void CacheRankList(RankType rankType, RankListViewType viewType, RankingList rankList)
	{
	}

	[Token(Token = "0x6007C6E")]
	[Address(RVA = "0xB9E4B4", Offset = "0xB9E4B4", VA = "0xB9E4B4")]
	public void CacheMyRankData(RankType rankType, RankListViewType viewType, XRankingDataCache.MyRankData data)
	{
	}

	[Token(Token = "0x6007C6F")]
	[Address(RVA = "0xB9E4EC", Offset = "0xB9E4EC", VA = "0xB9E4EC")]
	public void CacheClanRankList(RankListViewType viewType, ClanRankingList rankList)
	{
	}

	[Token(Token = "0x6007C70")]
	[Address(RVA = "0xB9E518", Offset = "0xB9E518", VA = "0xB9E518")]
	public void CacheMyClanRankData(RankListViewType viewType, XRankingDataCache.MyClanRankData data)
	{
	}

	[Token(Token = "0x6007C71")]
	[Address(RVA = "0xB9E544", Offset = "0xB9E544", VA = "0xB9E544")]
	public RankingList GetCachedRankList(RankType ranktype, RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x6007C72")]
	[Address(RVA = "0xB9E570", Offset = "0xB9E570", VA = "0xB9E570")]
	public XRankingDataCache.MyRankData GetCachedMyRankData(RankType ranktype, RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x6007C73")]
	[Address(RVA = "0xB9E59C", Offset = "0xB9E59C", VA = "0xB9E59C")]
	public void ReceiveCachedMyRankDateReward(RankType ranktype, RankListViewType viewType, XRankingDataCache.RankReceiveType receiveType)
	{
	}

	[Token(Token = "0x6007C74")]
	[Address(RVA = "0xB9E5E0", Offset = "0xB9E5E0", VA = "0xB9E5E0")]
	public bool IsCacheMyRankDataReceivedReward(RankType ranktype, RankListViewType viewType)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C75")]
	[Address(RVA = "0xB9E628", Offset = "0xB9E628", VA = "0xB9E628")]
	public ClanRankingList GetCachedClanRankList(RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x6007C76")]
	[Address(RVA = "0xB9E654", Offset = "0xB9E654", VA = "0xB9E654")]
	public XRankingDataCache.MyClanRankData GetCachedMyClanRankData(RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x6007C77")]
	[Address(RVA = "0xB9E680", Offset = "0xB9E680", VA = "0xB9E680")]
	public void ReceiveCachedMyClanRankDateReward(RankListViewType viewType, XRankingDataCache.RankReceiveType receiveType)
	{
	}

	[Token(Token = "0x6007C78")]
	[Address(RVA = "0xB9E6C4", Offset = "0xB9E6C4", VA = "0xB9E6C4")]
	public void ClearCurrentRankList()
	{
	}

	[Token(Token = "0x6007C79")]
	[Address(RVA = "0xB9E6F0", Offset = "0xB9E6F0", VA = "0xB9E6F0")]
	public int GetWeeklyStats_Before(string type)
	{
		return default(int);
	}

	[Token(Token = "0x6007C7A")]
	[Address(RVA = "0xB9E7D0", Offset = "0xB9E7D0", VA = "0xB9E7D0")]
	public CharStatus GetTalentStatus()
	{
		return null;
	}

	[Token(Token = "0x6007C7B")]
	[Address(RVA = "0xB9E7D8", Offset = "0xB9E7D8", VA = "0xB9E7D8")]
	public void ReLoginClear()
	{
	}

	[Token(Token = "0x6007C7C")]
	[Address(RVA = "0xB9E838", Offset = "0xB9E838", VA = "0xB9E838")]
	public void SetQuestLastInitTimeByServerLocal()
	{
	}

	[Token(Token = "0x6007C7D")]
	[Address(RVA = "0xB9E940", Offset = "0xB9E940", VA = "0xB9E940")]
	public XModuleActor GetChar(string cid)
	{
		return null;
	}

	[Token(Token = "0x6007C7E")]
	[Address(RVA = "0xB9E96C", Offset = "0xB9E96C", VA = "0xB9E96C")]
	public XModuleActor GetChar(string cid, int charID)
	{
		return null;
	}

	[Token(Token = "0x6007C7F")]
	[Address(RVA = "0xB9E9C0", Offset = "0xB9E9C0", VA = "0xB9E9C0")]
	public XModuleActor GetChar(int charId)
	{
		return null;
	}

	[Token(Token = "0x6007C80")]
	[Address(RVA = "0xB9E9EC", Offset = "0xB9E9EC", VA = "0xB9E9EC")]
	public XModuleActor GetPet(int charId)
	{
		return null;
	}

	[Token(Token = "0x6007C81")]
	[Address(RVA = "0xB87348", Offset = "0xB87348", VA = "0xB87348")]
	public XModuleActor GetPet(string pid)
	{
		return null;
	}

	[Token(Token = "0x6007C82")]
	[Address(RVA = "0xB9EA44", Offset = "0xB9EA44", VA = "0xB9EA44")]
	public XModuleActor GetPet(string cid, int charID)
	{
		return null;
	}

	[Token(Token = "0x6007C83")]
	[Address(RVA = "0xB9EA98", Offset = "0xB9EA98", VA = "0xB9EA98")]
	public void Cooking()
	{
	}

	[Token(Token = "0x6007C86")]
	[Address(RVA = "0xB9EE10", Offset = "0xB9EE10", VA = "0xB9EE10")]
	public bool IsExistPreviousGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6007C87")]
	[Address(RVA = "0xB9EECC", Offset = "0xB9EECC", VA = "0xB9EECC")]
	public bool IsPreviousGameIsFriendly()
	{
		return default(bool);
	}

	[Token(Token = "0x6007C88")]
	[Address(RVA = "0xB9EFE8", Offset = "0xB9EFE8", VA = "0xB9EFE8")]
	public bool CanReceiveRankingReward(RankType rankType)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C89")]
	[Address(RVA = "0xB9F178", Offset = "0xB9F178", VA = "0xB9F178")]
	private bool IsRankingRewardReceived(RankType rankType, int prevSeason)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C8A")]
	[Address(RVA = "0xB9F0F4", Offset = "0xB9F0F4", VA = "0xB9F0F4")]
	private bool IsJoinedPrevSeason(RankType rankType, int prevSeason)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C8B")]
	[Address(RVA = "0xB9F254", Offset = "0xB9F254", VA = "0xB9F254")]
	public Dictionary<int, int> GettableOrUpgradeRelicList(ProtoInfoManager_Relic protoRelic)
	{
		return null;
	}

	[Token(Token = "0x6007C8C")]
	[Address(RVA = "0xB9F4F8", Offset = "0xB9F4F8", VA = "0xB9F4F8")]
	public bool IsGetTalent()
	{
		return default(bool);
	}

	[Token(Token = "0x6007C8D")]
	[Address(RVA = "0xB9F950", Offset = "0xB9F950", VA = "0xB9F950")]
	public bool IsGetTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x6007C8E")]
	[Address(RVA = "0xB9FB48", Offset = "0xB9FB48", VA = "0xB9FB48")]
	public bool HasSkinByItemID(int itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C8F")]
	[Address(RVA = "0xB9FCCC", Offset = "0xB9FCCC", VA = "0xB9FCCC")]
	public bool HasSkinBySkinID(int skinID)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C90")]
	[Address(RVA = "0xB9FD00", Offset = "0xB9FD00", VA = "0xB9FD00")]
	public int GetHaveSkinCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007C91")]
	[Address(RVA = "0xB9FF28", Offset = "0xB9FF28", VA = "0xB9FF28")]
	public bool IsUnlockableSkin(int skinID)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C92")]
	[Address(RVA = "0xBA008C", Offset = "0xBA008C", VA = "0xBA008C")]
	public bool IsUnlockablePeriodSkin(int skinID)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C93")]
	[Address(RVA = "0xBA0234", Offset = "0xBA0234", VA = "0xBA0234")]
	public bool IsUpgradeSkill()
	{
		return default(bool);
	}

	[Token(Token = "0x6007C94")]
	[Address(RVA = "0xBA0548", Offset = "0xBA0548", VA = "0xBA0548")]
	public int GetTotalSkillPoint()
	{
		return default(int);
	}

	[Token(Token = "0x6007C95")]
	[Address(RVA = "0xBA0850", Offset = "0xBA0850", VA = "0xBA0850")]
	public void MaxCharCount(int count)
	{
	}

	[Token(Token = "0x6007C96")]
	[Address(RVA = "0xBA0858", Offset = "0xBA0858", VA = "0xBA0858")]
	public void StateAchievementNotice(bool state)
	{
	}

	[Token(Token = "0x6007C97")]
	[Address(RVA = "0xBA0860", Offset = "0xBA0860", VA = "0xBA0860")]
	public string GetDuelCharactersInfo()
	{
		return null;
	}

	[Token(Token = "0x6007C98")]
	[Address(RVA = "0xBA0DF8", Offset = "0xBA0DF8", VA = "0xBA0DF8")]
	public QuestInfo LastAchievementItem()
	{
		return null;
	}

	[Token(Token = "0x6007C99")]
	[Address(RVA = "0xBA0E00", Offset = "0xBA0E00", VA = "0xBA0E00")]
	public void CacheAchievementListClear()
	{
	}

	[Token(Token = "0x6007C9A")]
	[Address(RVA = "0xBA0E98", Offset = "0xBA0E98", VA = "0xBA0E98")]
	public void CacheAchieveRemove(int id)
	{
	}

	[Token(Token = "0x6007C9B")]
	[Address(RVA = "0xBA0F38", Offset = "0xBA0F38", VA = "0xBA0F38")]
	public int GetOwnedCount(CSContent content)
	{
		return default(int);
	}

	[Token(Token = "0x6007C9C")]
	[Address(RVA = "0xBA0FAC", Offset = "0xBA0FAC", VA = "0xBA0FAC")]
	public int GetOwnedCount(CSContentType contentType)
	{
		return default(int);
	}

	[Token(Token = "0x6007C9D")]
	[Address(RVA = "0xBA1068", Offset = "0xBA1068", VA = "0xBA1068")]
	public int GetELO(GameModeInstanceInfo info, EventGameModeInfo eventModeInfo)
	{
		return default(int);
	}

	[Token(Token = "0x6007C9E")]
	[Address(RVA = "0xBA11A8", Offset = "0xBA11A8", VA = "0xBA11A8")]
	public int GetELO(MatchType matchType, XGameModeType gameMode, int eventGroupID = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6007C9F")]
	[Address(RVA = "0xBA137C", Offset = "0xBA137C", VA = "0xBA137C")]
	public int GetEventModeELO(int eventGroupID)
	{
		return default(int);
	}

	[Token(Token = "0x6007CA0")]
	[Address(RVA = "0xBA13B4", Offset = "0xBA13B4", VA = "0xBA13B4")]
	public int GetMatchingELO(GameModeInstanceInfo info, EventGameModeInfo eventModeInfo)
	{
		return default(int);
	}

	[Token(Token = "0x6007CA1")]
	[Address(RVA = "0xBA14B4", Offset = "0xBA14B4", VA = "0xBA14B4")]
	public int GetSelectRelicID()
	{
		return default(int);
	}

	[Token(Token = "0x6007CA2")]
	[Address(RVA = "0xBA1614", Offset = "0xBA1614", VA = "0xBA1614")]
	public int GetSelectRelicLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6007CA3")]
	[Address(RVA = "0xBA1778", Offset = "0xBA1778", VA = "0xBA1778")]
	internal void SetRankRecord(RankType rankType, GameRecord seasonRecord)
	{
	}

	[Token(Token = "0x6007CA4")]
	[Address(RVA = "0xBA1820", Offset = "0xBA1820", VA = "0xBA1820")]
	public bool TryGetRankRecord(RankType rankType, out GameRecord seasonRecord)
	{
		seasonRecord = default;
		return default(bool);
	}

	[Token(Token = "0x6007CA5")]
	[Address(RVA = "0xBA18C8", Offset = "0xBA18C8", VA = "0xBA18C8")]
	internal int GetConsecutiveWin(MatchType matchType, XGameModeType mode)
	{
		return default(int);
	}

	[Token(Token = "0x6007CA6")]
	[Address(RVA = "0xBA18F0", Offset = "0xBA18F0", VA = "0xBA18F0")]
	internal int GetConsecutiveWin(RankType rankType)
	{
		return default(int);
	}

	[Token(Token = "0x6007CA7")]
	[Address(RVA = "0xBA1944", Offset = "0xBA1944", VA = "0xBA1944")]
	internal int GetConsecutiveLose(MatchType matchType, XGameModeType mode)
	{
		return default(int);
	}

	[Token(Token = "0x6007CA8")]
	[Address(RVA = "0xBA196C", Offset = "0xBA196C", VA = "0xBA196C")]
	internal int GetConsecutiveLose(RankType rankType)
	{
		return default(int);
	}

	[Token(Token = "0x6007CA9")]
	[Address(RVA = "0xBA19C0", Offset = "0xBA19C0", VA = "0xBA19C0")]
	public void UpdateUserData(NetData_Userdata data)
	{
	}

	[Token(Token = "0x6007CAA")]
	[Address(RVA = "0xBA2AA0", Offset = "0xBA2AA0", VA = "0xBA2AA0")]
	public void PatchNetDataUserDataByDiff(JObject diffJObj)
	{
	}

	[Token(Token = "0x6007CAB")]
	[Address(RVA = "0xBA352C", Offset = "0xBA352C", VA = "0xBA352C")]
	public void RefreshBadMannerWarning()
	{
	}

	[Token(Token = "0x6007CAC")]
	[Address(RVA = "0xBA31D4", Offset = "0xBA31D4", VA = "0xBA31D4")]
	public void CheckAchievement()
	{
	}

	[Token(Token = "0x6007CAD")]
	[Address(RVA = "0xBA3C40", Offset = "0xBA3C40", VA = "0xBA3C40")]
	private void UnlockAchievement_Record(GameRecordType gameRecordType, int achievementKeyValue, string achievementKey)
	{
	}

	[Token(Token = "0x6007CAE")]
	[Address(RVA = "0xBA426C", Offset = "0xBA426C", VA = "0xBA426C")]
	internal bool IsPlacementTest(RankType rankType)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CAF")]
	[Address(RVA = "0xBA3E0C", Offset = "0xBA3E0C", VA = "0xBA3E0C")]
	private void UnlockAchievement_Stat(int achievementKeyValue, string statKey, string achievementKey)
	{
	}

	[Token(Token = "0x6007CB0")]
	[Address(RVA = "0xBA40A0", Offset = "0xBA40A0", VA = "0xBA40A0")]
	private int GetRecordInfoValue(GameRecordType recordType)
	{
		return default(int);
	}

	[Token(Token = "0x6007CB1")]
	[Address(RVA = "0xBA4330", Offset = "0xBA4330", VA = "0xBA4330")]
	private void SetComplexCurrency(Currency currencyType, int value)
	{
	}

	[Token(Token = "0x6007CB2")]
	[Address(RVA = "0xBA449C", Offset = "0xBA449C", VA = "0xBA449C")]
	public void SetGold(int Gold)
	{
	}

	[Token(Token = "0x6007CB3")]
	[Address(RVA = "0xBA44A8", Offset = "0xBA44A8", VA = "0xBA44A8")]
	public void SetFreeCrystal(int Crystal)
	{
	}

	[Token(Token = "0x6007CB4")]
	[Address(RVA = "0xBA44B4", Offset = "0xBA44B4", VA = "0xBA44B4")]
	public void UpdateUserResource(NetData_UserResource data)
	{
	}

	[Token(Token = "0x6007CB5")]
	[Address(RVA = "0xBA486C", Offset = "0xBA486C", VA = "0xBA486C")]
	public void PatchNetDataUserResourceByDiff(JObject diffJObj)
	{
	}

	[Token(Token = "0x6007CB6")]
	[Address(RVA = "0xBA4970", Offset = "0xBA4970", VA = "0xBA4970")]
	public void SetCombatPowerToServer()
	{
	}

	[Token(Token = "0x6007CB7")]
	[Address(RVA = "0xBA4BAC", Offset = "0xBA4BAC", VA = "0xBA4BAC")]
	private int CalCombatPower()
	{
		return default(int);
	}

	[Token(Token = "0x6007CB8")]
	[Address(RVA = "0xBA2BA4", Offset = "0xBA2BA4", VA = "0xBA2BA4")]
	public NetData_Userdata ToNetDataUserData()
	{
		return null;
	}

	[Token(Token = "0x6007CB9")]
	[Address(RVA = "0xBA4D64", Offset = "0xBA4D64", VA = "0xBA4D64")]
	internal int GetCharLevel(int charID)
	{
		return default(int);
	}

	[Token(Token = "0x6007CBA")]
	[Address(RVA = "0xBA4D84", Offset = "0xBA4D84", VA = "0xBA4D84")]
	public bool TryGetViewActors(IComparer<XModuleActor> compare, out List<XModuleActor> ownedViewList, out List<XModuleActor> notOwnedViewList)
	{
		notOwnedViewList = default;
		ownedViewList = default;
		return default(bool);
	}

	[Token(Token = "0x6007CBB")]
	[Address(RVA = "0xBA531C", Offset = "0xBA531C", VA = "0xBA531C")]
	public bool TryGetViewPets(IComparer<XModuleActor> compare, out List<XModuleActor> ownedViewList, out List<XModuleActor> notOwnedViewList)
	{
		notOwnedViewList = default;
		ownedViewList = default;
		return default(bool);
	}

	[Token(Token = "0x6007CBC")]
	[Address(RVA = "0xBA56D0", Offset = "0xBA56D0", VA = "0xBA56D0")]
	private bool _003CIsUnlockableSkin_003Em__53C(SkinInfo skinInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CBD")]
	[Address(RVA = "0xBA5730", Offset = "0xBA5730", VA = "0xBA5730")]
	private static void _003CSetCombatPowerToServer_003Em__53E(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
