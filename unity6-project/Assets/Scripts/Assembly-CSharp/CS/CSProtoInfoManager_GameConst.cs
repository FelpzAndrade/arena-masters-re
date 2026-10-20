using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS.Constant;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AE2")]
	public class CSProtoInfoManager_GameConst : Dictionary<key, string>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000AE3")]
		private class GameConstantKeyComparer : IEqualityComparer<key>
		{
			[Token(Token = "0x600506A")]
			[Address(RVA = "0x1FD2F70", Offset = "0x1FD2F70", VA = "0x1FD2F70")]
			public GameConstantKeyComparer()
			{
			}

			[Token(Token = "0x600506B")]
			[Address(RVA = "0x1FDC140", Offset = "0x1FDC140", VA = "0x1FDC140", Slot = "4")]
			public bool Equals(key t1, key t2)
			{
				return default(bool);
			}

			[Token(Token = "0x600506C")]
			[Address(RVA = "0x1FDC150", Offset = "0x1FDC150", VA = "0x1FDC150", Slot = "5")]
			public int GetHashCode(key type)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000AE4")]
		private sealed class _003CCookingDuelShopChargeInfo_003Ec__AnonStorey154
		{
			[Token(Token = "0x40034D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal KeyValuePair<string, List<int>> kvp;

			[Token(Token = "0x600506D")]
			[Address(RVA = "0x1FD6DA4", Offset = "0x1FD6DA4", VA = "0x1FD6DA4")]
			public _003CCookingDuelShopChargeInfo_003Ec__AnonStorey154()
			{
			}

			[Token(Token = "0x600506E")]
			[Address(RVA = "0x1FDC00C", Offset = "0x1FDC00C", VA = "0x1FDC00C")]
			internal bool _003C_003Em__200(KeyValuePair<key, string> e)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400348D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minCriticaDamage;

		[Token(Token = "0x400348E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int starRefenrece1;

		[Token(Token = "0x400348F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int starRefenrece2;

		[Token(Token = "0x4003490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<int> monsterScore;

		[Token(Token = "0x4003491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float beatenThresholdValue;

		[Token(Token = "0x4003492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float noneBattleMoveSpeed;

		[Token(Token = "0x4003493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float maxTagCooltimeReduction;

		[Token(Token = "0x4003494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float maxSkillCooltimeReduction;

		[Token(Token = "0x4003495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float deathsDoorThreshold;

		[Token(Token = "0x4003496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int maxItemStackCount;

		[Token(Token = "0x4003497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int respawnTimePenaltyDeathCount;

		[Token(Token = "0x4003498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int gold_stage_effect_count;

		[Token(Token = "0x4003499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int refine_stage_effect_count;

		[Token(Token = "0x400349A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int ult_toller;

		[Token(Token = "0x400349B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int zombieModeHitPoint;

		[Token(Token = "0x400349C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int zombieModeKillPoint;

		[Token(Token = "0x400349D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int zombieModeAssistPoint;

		[Token(Token = "0x400349E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int zombieModeBoxPoint;

		[Token(Token = "0x400349F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int zombieModeStayAsHumanPer2SecPoint;

		[Token(Token = "0x40034A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int zombieModeWonAsHumanPoint;

		[Token(Token = "0x40034A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float pvp_balance_physicaldamage;

		[Token(Token = "0x40034A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float pvp_balance_magicaldamage;

		[Token(Token = "0x40034A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float pvp_balance_physicaldefense_fix;

		[Token(Token = "0x40034A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float pvp_balance_magicalDefense_fix;

		[Token(Token = "0x40034A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float PvP_balance_maxhp;

		[Token(Token = "0x40034A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<int> equipMatContributionTable;

		[Token(Token = "0x40034A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public List<int> refinedMaxLevelOnRarity;

		[Token(Token = "0x40034A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<int> refinePriceTable;

		[Token(Token = "0x40034A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public List<float> refineRatioTable;

		[Token(Token = "0x40034AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public TimeSpan dailyBoxResetTime1;

		[Token(Token = "0x40034AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TimeSpan dailyBoxResetTime2;

		[Token(Token = "0x40034AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<int> storeChargePriceTable;

		[Token(Token = "0x40034AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public List<int> levelLimitOnGradeTable;

		[Token(Token = "0x40034AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<int> fusionPriceTable;

		[Token(Token = "0x40034AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public List<int> promotionStoneTable;

		[Token(Token = "0x40034B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<int> promotionGoldTable;

		[Token(Token = "0x40034B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public List<int> duelStallPriceList;

		[Token(Token = "0x40034B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<int> pvpStallPriceList;

		[Token(Token = "0x40034B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public List<int> mischaStallPriceList;

		[Token(Token = "0x40034B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public TimeSpan MischaShop_ResetTime1;

		[Token(Token = "0x40034B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public TimeSpan MischaShop_ResetTime2;

		[Token(Token = "0x40034B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public readonly DateTime StandardServiceDay;

		[Token(Token = "0x40034B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private DateTime SeasonStartTime__BackingField;

		[Token(Token = "0x40034B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private DateTime SeasonTwoWeekStartTime__BackingField;

		[Token(Token = "0x40034B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private short DefaultELO__BackingField;

		[Token(Token = "0x40034BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int PriceOfClanCreate__BackingField;

		[Token(Token = "0x40034BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int ClanMaxMemberCount__BackingField;

		[Token(Token = "0x40034BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int ClanCreateDefaultMark__BackingField;

		[Token(Token = "0x40034BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int ClanCreateDefaultColor__BackingField;

		[Token(Token = "0x40034BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int ClanJoinReqMaxCount__BackingField;

		[Token(Token = "0x40034BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int ClanSubMasterMaxCount__BackingField;

		[Token(Token = "0x40034C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private string ClanTerminateInput__BackingField;

		[Token(Token = "0x40034C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int ClanUseabelLevel__BackingField;

		[Token(Token = "0x40034C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private int ClanwarOpenLevel__BackingField;

		[Token(Token = "0x40034C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int MaxProfileIconID__BackingField;

		[Token(Token = "0x40034C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private int ProfileIconAcquireGold__BackingField;

		[Token(Token = "0x40034C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int ClanApprovalExpireHour__BackingField;

		[Token(Token = "0x40034C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private int MaxMannerPoint__BackingField;

		[Token(Token = "0x40034C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int MannerGoodPoint__BackingField;

		[Token(Token = "0x40034C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int MannerNormalPoint__BackingField;

		[Token(Token = "0x40034C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int MannerBadPoint__BackingField;

		[Token(Token = "0x40034CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private int MinMannerPoint__BackingField;

		[Token(Token = "0x40034CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int MannerPointPerGood__BackingField;

		[Token(Token = "0x40034CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int MannerPointPerBad__BackingField;

		[Token(Token = "0x40034CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int WarningMannerBadCount__BackingField;

		[Token(Token = "0x40034CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int RefreshWarningMannerTime__BackingField;

		[Token(Token = "0x40034CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private int MannerRepairPoint__BackingField;

		[Token(Token = "0x40034D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int MannerRepairLimit__BackingField;

		[Token(Token = "0x40034D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private int NormalBattleMaxRewardCount__BackingField;

		[Token(Token = "0x40034D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private MannerPointOptions MannerPoint__BackingField;

		[Token(Token = "0x40034D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private AttendanceOptions Attendance__BackingField;

		[Token(Token = "0x40034D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Func<KeyValuePair<key, string>, bool> _003C_003Ef__am_0024cache47;

		[Token(Token = "0x17000B43")]
		public int PointShopAdvertisementChargeMaxCount
		{
			[Token(Token = "0x6004F97")]
			[Address(RVA = "0x1FD305C", Offset = "0x1FD305C", VA = "0x1FD305C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B44")]
		public int PointShopAdvertisementChargeDailyResetTimeHour
		{
			[Token(Token = "0x6004F98")]
			[Address(RVA = "0x1FD30CC", Offset = "0x1FD30CC", VA = "0x1FD30CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B45")]
		public DateTime SeasonStartTime
		{
			[Token(Token = "0x6004F9C")]
			[Address(RVA = "0x1FD57F4", Offset = "0x1FD57F4", VA = "0x1FD57F4")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004F9D")]
			[Address(RVA = "0x1FD5804", Offset = "0x1FD5804", VA = "0x1FD5804")]
			set
			{
			}
		}

		[Token(Token = "0x17000B46")]
		public DateTime SeasonTwoWeekStartTime
		{
			[Token(Token = "0x6004F9E")]
			[Address(RVA = "0x1FD581C", Offset = "0x1FD581C", VA = "0x1FD581C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004F9F")]
			[Address(RVA = "0x1FD582C", Offset = "0x1FD582C", VA = "0x1FD582C")]
			set
			{
			}
		}

		[Token(Token = "0x17000B47")]
		public short DefaultELO
		{
			[Token(Token = "0x6004FA0")]
			[Address(RVA = "0x1FD5844", Offset = "0x1FD5844", VA = "0x1FD5844")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x6004FA1")]
			[Address(RVA = "0x1FD5850", Offset = "0x1FD5850", VA = "0x1FD5850")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B48")]
		public int CharToSoulStoneCount
		{
			[Token(Token = "0x6004FCB")]
			[Address(RVA = "0x1FD8CB0", Offset = "0x1FD8CB0", VA = "0x1FD8CB0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B49")]
		public int PetToSoulDustCount
		{
			[Token(Token = "0x6004FCC")]
			[Address(RVA = "0x1FD8CDC", Offset = "0x1FD8CDC", VA = "0x1FD8CDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4A")]
		public int DefaultItemInvenSlot
		{
			[Token(Token = "0x6004FCD")]
			[Address(RVA = "0x1FD8D08", Offset = "0x1FD8D08", VA = "0x1FD8D08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4B")]
		public int MaxItemInvenSlot
		{
			[Token(Token = "0x6004FCE")]
			[Address(RVA = "0x1FD8D40", Offset = "0x1FD8D40", VA = "0x1FD8D40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4C")]
		public int ItemInvenSlotInc
		{
			[Token(Token = "0x6004FCF")]
			[Address(RVA = "0x1FD8D78", Offset = "0x1FD8D78", VA = "0x1FD8D78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4D")]
		public int InstantRespawnPrice
		{
			[Token(Token = "0x6004FD3")]
			[Address(RVA = "0x1FD90EC", Offset = "0x1FD90EC", VA = "0x1FD90EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4E")]
		public int StageRevivePrice
		{
			[Token(Token = "0x6004FD4")]
			[Address(RVA = "0x1FD9118", Offset = "0x1FD9118", VA = "0x1FD9118")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4F")]
		public int FreeStageReviveCnt
		{
			[Token(Token = "0x6004FD5")]
			[Address(RVA = "0x1FD9144", Offset = "0x1FD9144", VA = "0x1FD9144")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B50")]
		public int SkillInitRequireGold
		{
			[Token(Token = "0x6004FD6")]
			[Address(RVA = "0x1FD9170", Offset = "0x1FD9170", VA = "0x1FD9170")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B51")]
		public int ReturnUserDay
		{
			[Token(Token = "0x6004FD7")]
			[Address(RVA = "0x1FD919C", Offset = "0x1FD919C", VA = "0x1FD919C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B52")]
		public int ReturnUserReset
		{
			[Token(Token = "0x6004FD8")]
			[Address(RVA = "0x1FD91C8", Offset = "0x1FD91C8", VA = "0x1FD91C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B53")]
		public int GetFriendsPoint
		{
			[Token(Token = "0x6004FDD")]
			[Address(RVA = "0x1FD9488", Offset = "0x1FD9488", VA = "0x1FD9488")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B54")]
		public int GiveFriendsPoint
		{
			[Token(Token = "0x6004FDE")]
			[Address(RVA = "0x1FD94C0", Offset = "0x1FD94C0", VA = "0x1FD94C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B55")]
		public int MaxFriendsPoint
		{
			[Token(Token = "0x6004FDF")]
			[Address(RVA = "0x1FD94F8", Offset = "0x1FD94F8", VA = "0x1FD94F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B56")]
		public uint FriendsPointTimeLimit
		{
			[Token(Token = "0x6004FE0")]
			[Address(RVA = "0x1FD9530", Offset = "0x1FD9530", VA = "0x1FD9530")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000B57")]
		public int MaxFriendCount
		{
			[Token(Token = "0x6004FE1")]
			[Address(RVA = "0x1FD9580", Offset = "0x1FD9580", VA = "0x1FD9580")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B58")]
		public int TutorialApplyPlayCount
		{
			[Token(Token = "0x6004FE2")]
			[Address(RVA = "0x1FD9588", Offset = "0x1FD9588", VA = "0x1FD9588")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B59")]
		public int TutorialCharacterID
		{
			[Token(Token = "0x6004FE3")]
			[Address(RVA = "0x1FD95C0", Offset = "0x1FD95C0", VA = "0x1FD95C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B5A")]
		public float TutorialNpcStatusBaseRatio
		{
			[Token(Token = "0x6004FE4")]
			[Address(RVA = "0x1FD9604", Offset = "0x1FD9604", VA = "0x1FD9604")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B5B")]
		public float TutorialNpcStatusCorrectionRatio
		{
			[Token(Token = "0x6004FE5")]
			[Address(RVA = "0x1FD965C", Offset = "0x1FD965C", VA = "0x1FD965C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B5C")]
		public float TutorialNpcStatusMaxHPBaseRatio
		{
			[Token(Token = "0x6004FE6")]
			[Address(RVA = "0x1FD96B4", Offset = "0x1FD96B4", VA = "0x1FD96B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B5D")]
		public float TutorialNpcStatusMaxHPRatio
		{
			[Token(Token = "0x6004FE7")]
			[Address(RVA = "0x1FD9710", Offset = "0x1FD9710", VA = "0x1FD9710")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B5E")]
		public float TutorialNpcCooltimeRatio
		{
			[Token(Token = "0x6004FE8")]
			[Address(RVA = "0x1FD9768", Offset = "0x1FD9768", VA = "0x1FD9768")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B5F")]
		public int TutorialLotteryID
		{
			[Token(Token = "0x6004FE9")]
			[Address(RVA = "0x1FD97B0", Offset = "0x1FD97B0", VA = "0x1FD97B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B60")]
		public int RankLoadingWaitTime
		{
			[Token(Token = "0x6004FEA")]
			[Address(RVA = "0x1FD97F4", Offset = "0x1FD97F4", VA = "0x1FD97F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B61")]
		public int BannedCount
		{
			[Token(Token = "0x6004FEB")]
			[Address(RVA = "0x1FD982C", Offset = "0x1FD982C", VA = "0x1FD982C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B62")]
		public int MatchingPingBounds
		{
			[Token(Token = "0x6004FEC")]
			[Address(RVA = "0x1FD9864", Offset = "0x1FD9864", VA = "0x1FD9864")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B63")]
		public bool UsePingMatch
		{
			[Token(Token = "0x6004FED")]
			[Address(RVA = "0x1FD989C", Offset = "0x1FD989C", VA = "0x1FD989C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B64")]
		public int PingGroup1
		{
			[Token(Token = "0x6004FEE")]
			[Address(RVA = "0x1FD98E4", Offset = "0x1FD98E4", VA = "0x1FD98E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B65")]
		public int PingGroup2
		{
			[Token(Token = "0x6004FEF")]
			[Address(RVA = "0x1FD991C", Offset = "0x1FD991C", VA = "0x1FD991C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B66")]
		public int PingGroup3
		{
			[Token(Token = "0x6004FF0")]
			[Address(RVA = "0x1FD9954", Offset = "0x1FD9954", VA = "0x1FD9954")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B67")]
		public int PingGroup4
		{
			[Token(Token = "0x6004FF1")]
			[Address(RVA = "0x1FD998C", Offset = "0x1FD998C", VA = "0x1FD998C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B68")]
		public int MatchingSupplementationPoint
		{
			[Token(Token = "0x6004FF2")]
			[Address(RVA = "0x1FD99D0", Offset = "0x1FD99D0", VA = "0x1FD99D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B69")]
		public int MatchingSupplementationPing
		{
			[Token(Token = "0x6004FF3")]
			[Address(RVA = "0x1FD9A08", Offset = "0x1FD9A08", VA = "0x1FD9A08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B6A")]
		public int MaxLevelArenaCoinCount
		{
			[Token(Token = "0x6004FF4")]
			[Address(RVA = "0x1FD9A40", Offset = "0x1FD9A40", VA = "0x1FD9A40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B6B")]
		public int TutoIDForPandorabox
		{
			[Token(Token = "0x6004FF5")]
			[Address(RVA = "0x1FD9A78", Offset = "0x1FD9A78", VA = "0x1FD9A78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B6C")]
		public int ClanRankRatioBronze
		{
			[Token(Token = "0x6004FF6")]
			[Address(RVA = "0x1FD9AB0", Offset = "0x1FD9AB0", VA = "0x1FD9AB0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B6D")]
		public int ClanRankRatioSilver
		{
			[Token(Token = "0x6004FF7")]
			[Address(RVA = "0x1FD9AE8", Offset = "0x1FD9AE8", VA = "0x1FD9AE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B6E")]
		public int ClanRankRatioGold
		{
			[Token(Token = "0x6004FF8")]
			[Address(RVA = "0x1FD9B20", Offset = "0x1FD9B20", VA = "0x1FD9B20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B6F")]
		public int ClanRankRatioDiamond
		{
			[Token(Token = "0x6004FF9")]
			[Address(RVA = "0x1FD9B58", Offset = "0x1FD9B58", VA = "0x1FD9B58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B70")]
		public int ClanRejoinCoolTime
		{
			[Token(Token = "0x6004FFA")]
			[Address(RVA = "0x1FD9B90", Offset = "0x1FD9B90", VA = "0x1FD9B90")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B71")]
		public bool UseLobbyButtonBanner
		{
			[Token(Token = "0x6004FFB")]
			[Address(RVA = "0x1FD9BC8", Offset = "0x1FD9BC8", VA = "0x1FD9BC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B72")]
		public int BroadcastingSuccessiveVictories
		{
			[Token(Token = "0x6004FFC")]
			[Address(RVA = "0x1FD9C10", Offset = "0x1FD9C10", VA = "0x1FD9C10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B73")]
		public float Broadcasting_OutputTime_General
		{
			[Token(Token = "0x6004FFD")]
			[Address(RVA = "0x1FD9C48", Offset = "0x1FD9C48", VA = "0x1FD9C48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B74")]
		public float Broadcasting_OutputTime_Showoff
		{
			[Token(Token = "0x6004FFE")]
			[Address(RVA = "0x1FD9C94", Offset = "0x1FD9C94", VA = "0x1FD9C94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B75")]
		public float Broadcasting_OutputTime_Notice
		{
			[Token(Token = "0x6004FFF")]
			[Address(RVA = "0x1FD9CE0", Offset = "0x1FD9CE0", VA = "0x1FD9CE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000B76")]
		public int HttpMaxConnectionPerServer
		{
			[Token(Token = "0x6005000")]
			[Address(RVA = "0x1FD9D2C", Offset = "0x1FD9D2C", VA = "0x1FD9D2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B77")]
		public bool HttpKeepAlive
		{
			[Token(Token = "0x6005001")]
			[Address(RVA = "0x1FD9D64", Offset = "0x1FD9D64", VA = "0x1FD9D64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B78")]
		public int HttpMaxConnectionIdleTime
		{
			[Token(Token = "0x6005002")]
			[Address(RVA = "0x1FD9DAC", Offset = "0x1FD9DAC", VA = "0x1FD9DAC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B79")]
		public bool SeasonRankTest
		{
			[Token(Token = "0x6005003")]
			[Address(RVA = "0x1FD5DB4", Offset = "0x1FD5DB4", VA = "0x1FD5DB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B7A")]
		public int SeasonRankTestMinutes
		{
			[Token(Token = "0x6005004")]
			[Address(RVA = "0x1FD5DFC", Offset = "0x1FD5DFC", VA = "0x1FD5DFC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7B")]
		public bool AntiHackAbuseDetectCheck
		{
			[Token(Token = "0x6005005")]
			[Address(RVA = "0x1FD9DE4", Offset = "0x1FD9DE4", VA = "0x1FD9DE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B7C")]
		public int AntiHackAbuseDetectPoint
		{
			[Token(Token = "0x6005006")]
			[Address(RVA = "0x1FD9E2C", Offset = "0x1FD9E2C", VA = "0x1FD9E2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7D")]
		public int AntiHackAbuseDetectMinTime
		{
			[Token(Token = "0x6005007")]
			[Address(RVA = "0x1FD9E64", Offset = "0x1FD9E64", VA = "0x1FD9E64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7E")]
		public int RoomCountConditionMin
		{
			[Token(Token = "0x6005008")]
			[Address(RVA = "0x1FD9E9C", Offset = "0x1FD9E9C", VA = "0x1FD9E9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7F")]
		public int RoomCountConditionMax
		{
			[Token(Token = "0x6005009")]
			[Address(RVA = "0x1FD9ED4", Offset = "0x1FD9ED4", VA = "0x1FD9ED4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B80")]
		public int PriceOfSkillPoint
		{
			[Token(Token = "0x6005015")]
			[Address(RVA = "0x1FDB114", Offset = "0x1FDB114", VA = "0x1FDB114")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B81")]
		public int OncePriceOfSkillPoint
		{
			[Token(Token = "0x6005016")]
			[Address(RVA = "0x1FDB1AC", Offset = "0x1FDB1AC", VA = "0x1FDB1AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B82")]
		public int MaxCountOfSkillPointPurchase
		{
			[Token(Token = "0x6005017")]
			[Address(RVA = "0x1FDB244", Offset = "0x1FDB244", VA = "0x1FDB244")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B83")]
		public int OpenTalent
		{
			[Token(Token = "0x6005018")]
			[Address(RVA = "0x1FDB2DC", Offset = "0x1FDB2DC", VA = "0x1FDB2DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B84")]
		public int EnchantOptionQuantity
		{
			[Token(Token = "0x6005019")]
			[Address(RVA = "0x1FDB374", Offset = "0x1FDB374", VA = "0x1FDB374")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B85")]
		public int PriceOfClanCreate
		{
			[Token(Token = "0x600501A")]
			[Address(RVA = "0x1FDB3AC", Offset = "0x1FDB3AC", VA = "0x1FDB3AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600501B")]
			[Address(RVA = "0x1FD6B88", Offset = "0x1FD6B88", VA = "0x1FD6B88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B86")]
		public int ClanMaxMemberCount
		{
			[Token(Token = "0x600501C")]
			[Address(RVA = "0x1FDB3B4", Offset = "0x1FDB3B4", VA = "0x1FDB3B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600501D")]
			[Address(RVA = "0x1FD6B90", Offset = "0x1FD6B90", VA = "0x1FD6B90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B87")]
		public int ClanCreateDefaultMark
		{
			[Token(Token = "0x600501E")]
			[Address(RVA = "0x1FDB3BC", Offset = "0x1FDB3BC", VA = "0x1FDB3BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600501F")]
			[Address(RVA = "0x1FD6B98", Offset = "0x1FD6B98", VA = "0x1FD6B98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B88")]
		public int ClanCreateDefaultColor
		{
			[Token(Token = "0x6005020")]
			[Address(RVA = "0x1FDB3C4", Offset = "0x1FDB3C4", VA = "0x1FDB3C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005021")]
			[Address(RVA = "0x1FD6BA0", Offset = "0x1FD6BA0", VA = "0x1FD6BA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B89")]
		public int ClanJoinReqMaxCount
		{
			[Token(Token = "0x6005022")]
			[Address(RVA = "0x1FDB3CC", Offset = "0x1FDB3CC", VA = "0x1FDB3CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005023")]
			[Address(RVA = "0x1FD6BA8", Offset = "0x1FD6BA8", VA = "0x1FD6BA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B8A")]
		public int ClanSubMasterMaxCount
		{
			[Token(Token = "0x6005024")]
			[Address(RVA = "0x1FDB3D4", Offset = "0x1FDB3D4", VA = "0x1FDB3D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005025")]
			[Address(RVA = "0x1FD6BB0", Offset = "0x1FD6BB0", VA = "0x1FD6BB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B8B")]
		public string ClanTerminateInput
		{
			[Token(Token = "0x6005026")]
			[Address(RVA = "0x1FDB3DC", Offset = "0x1FDB3DC", VA = "0x1FDB3DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005027")]
			[Address(RVA = "0x1FD6BB8", Offset = "0x1FD6BB8", VA = "0x1FD6BB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B8C")]
		public int ClanUseabelLevel
		{
			[Token(Token = "0x6005028")]
			[Address(RVA = "0x1FDB3E4", Offset = "0x1FDB3E4", VA = "0x1FDB3E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005029")]
			[Address(RVA = "0x1FD6BC0", Offset = "0x1FD6BC0", VA = "0x1FD6BC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B8D")]
		public int ClanwarOpenLevel
		{
			[Token(Token = "0x600502A")]
			[Address(RVA = "0x1FDB3EC", Offset = "0x1FDB3EC", VA = "0x1FDB3EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600502B")]
			[Address(RVA = "0x1FD6BC8", Offset = "0x1FD6BC8", VA = "0x1FD6BC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B8E")]
		public int MaxProfileIconID
		{
			[Token(Token = "0x600502C")]
			[Address(RVA = "0x1FDB3F4", Offset = "0x1FDB3F4", VA = "0x1FDB3F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600502D")]
			[Address(RVA = "0x1FD6BD0", Offset = "0x1FD6BD0", VA = "0x1FD6BD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B8F")]
		public int ProfileIconAcquireGold
		{
			[Token(Token = "0x600502E")]
			[Address(RVA = "0x1FDB3FC", Offset = "0x1FDB3FC", VA = "0x1FDB3FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600502F")]
			[Address(RVA = "0x1FD6BD8", Offset = "0x1FD6BD8", VA = "0x1FD6BD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B90")]
		public int ClanApprovalExpireHour
		{
			[Token(Token = "0x6005030")]
			[Address(RVA = "0x1FDB404", Offset = "0x1FDB404", VA = "0x1FDB404")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005031")]
			[Address(RVA = "0x1FD6B80", Offset = "0x1FD6B80", VA = "0x1FD6B80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B91")]
		public int MaxMannerPoint
		{
			[Token(Token = "0x6005032")]
			[Address(RVA = "0x1FDB40C", Offset = "0x1FDB40C", VA = "0x1FDB40C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005033")]
			[Address(RVA = "0x1FD6A50", Offset = "0x1FD6A50", VA = "0x1FD6A50")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B92")]
		public int MannerGoodPoint
		{
			[Token(Token = "0x6005034")]
			[Address(RVA = "0x1FDB414", Offset = "0x1FDB414", VA = "0x1FDB414")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005035")]
			[Address(RVA = "0x1FD6A58", Offset = "0x1FD6A58", VA = "0x1FD6A58")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B93")]
		public int MannerNormalPoint
		{
			[Token(Token = "0x6005036")]
			[Address(RVA = "0x1FDB41C", Offset = "0x1FDB41C", VA = "0x1FDB41C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005037")]
			[Address(RVA = "0x1FD6A60", Offset = "0x1FD6A60", VA = "0x1FD6A60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B94")]
		public int MannerBadPoint
		{
			[Token(Token = "0x6005038")]
			[Address(RVA = "0x1FDB424", Offset = "0x1FDB424", VA = "0x1FDB424")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005039")]
			[Address(RVA = "0x1FD6A68", Offset = "0x1FD6A68", VA = "0x1FD6A68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B95")]
		public int MinMannerPoint
		{
			[Token(Token = "0x600503A")]
			[Address(RVA = "0x1FDB42C", Offset = "0x1FDB42C", VA = "0x1FDB42C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600503B")]
			[Address(RVA = "0x1FD6A70", Offset = "0x1FD6A70", VA = "0x1FD6A70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B96")]
		public int MannerPointPerGood
		{
			[Token(Token = "0x600503C")]
			[Address(RVA = "0x1FDB434", Offset = "0x1FDB434", VA = "0x1FDB434")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600503D")]
			[Address(RVA = "0x1FD6A78", Offset = "0x1FD6A78", VA = "0x1FD6A78")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B97")]
		public int MannerPointPerBad
		{
			[Token(Token = "0x600503E")]
			[Address(RVA = "0x1FDB43C", Offset = "0x1FDB43C", VA = "0x1FDB43C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600503F")]
			[Address(RVA = "0x1FD6A80", Offset = "0x1FD6A80", VA = "0x1FD6A80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B98")]
		public int WarningMannerBadCount
		{
			[Token(Token = "0x6005040")]
			[Address(RVA = "0x1FDB444", Offset = "0x1FDB444", VA = "0x1FDB444")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005041")]
			[Address(RVA = "0x1FD6A88", Offset = "0x1FD6A88", VA = "0x1FD6A88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B99")]
		public int RefreshWarningMannerTime
		{
			[Token(Token = "0x6005042")]
			[Address(RVA = "0x1FDB44C", Offset = "0x1FDB44C", VA = "0x1FDB44C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005043")]
			[Address(RVA = "0x1FD6A90", Offset = "0x1FD6A90", VA = "0x1FD6A90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9A")]
		public int MannerRepairPoint
		{
			[Token(Token = "0x6005044")]
			[Address(RVA = "0x1FDB454", Offset = "0x1FDB454", VA = "0x1FDB454")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005045")]
			[Address(RVA = "0x1FD6A98", Offset = "0x1FD6A98", VA = "0x1FD6A98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9B")]
		public int MannerRepairLimit
		{
			[Token(Token = "0x6005046")]
			[Address(RVA = "0x1FDB45C", Offset = "0x1FDB45C", VA = "0x1FDB45C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005047")]
			[Address(RVA = "0x1FD6AA0", Offset = "0x1FD6AA0", VA = "0x1FD6AA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9C")]
		public int NormalBattleMaxRewardCount
		{
			[Token(Token = "0x6005048")]
			[Address(RVA = "0x1FDB464", Offset = "0x1FDB464", VA = "0x1FDB464")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005049")]
			[Address(RVA = "0x1FD6AA8", Offset = "0x1FD6AA8", VA = "0x1FD6AA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B9D")]
		public int NewbieLevel
		{
			[Token(Token = "0x600504A")]
			[Address(RVA = "0x1FDB46C", Offset = "0x1FDB46C", VA = "0x1FDB46C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B9E")]
		public int NewbieLosingStreakCount
		{
			[Token(Token = "0x600504B")]
			[Address(RVA = "0x1FDB4A4", Offset = "0x1FDB4A4", VA = "0x1FDB4A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B9F")]
		public int NewbieLosingStreakCareBuff
		{
			[Token(Token = "0x600504C")]
			[Address(RVA = "0x1FDB4DC", Offset = "0x1FDB4DC", VA = "0x1FDB4DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA0")]
		public int NewbieCareReviveBuff
		{
			[Token(Token = "0x600504D")]
			[Address(RVA = "0x1FDB514", Offset = "0x1FDB514", VA = "0x1FDB514")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA1")]
		public int VeryVeryNewbieLevel
		{
			[Token(Token = "0x600504E")]
			[Address(RVA = "0x1FDB54C", Offset = "0x1FDB54C", VA = "0x1FDB54C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA2")]
		public int VeryVeryNewbieCareBuff
		{
			[Token(Token = "0x600504F")]
			[Address(RVA = "0x1FDB584", Offset = "0x1FDB584", VA = "0x1FDB584")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA3")]
		public int TeamDeathMatchDeathBuff
		{
			[Token(Token = "0x6005050")]
			[Address(RVA = "0x1FDB5BC", Offset = "0x1FDB5BC", VA = "0x1FDB5BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA4")]
		public int PrivateRoomKillIncremnetValue
		{
			[Token(Token = "0x6005051")]
			[Address(RVA = "0x1FDB5F4", Offset = "0x1FDB5F4", VA = "0x1FDB5F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA5")]
		public int PrivateRoomTimeIncrementValue
		{
			[Token(Token = "0x6005052")]
			[Address(RVA = "0x1FDB62C", Offset = "0x1FDB62C", VA = "0x1FDB62C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA6")]
		public int PrivateRoomKillMax
		{
			[Token(Token = "0x6005053")]
			[Address(RVA = "0x1FDB664", Offset = "0x1FDB664", VA = "0x1FDB664")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA7")]
		public int PrivateRoomKillMin
		{
			[Token(Token = "0x6005054")]
			[Address(RVA = "0x1FDB69C", Offset = "0x1FDB69C", VA = "0x1FDB69C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA8")]
		public int PrivateRoomTimeMax
		{
			[Token(Token = "0x6005055")]
			[Address(RVA = "0x1FDB6D4", Offset = "0x1FDB6D4", VA = "0x1FDB6D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BA9")]
		public int PrivateRoomTimeMin
		{
			[Token(Token = "0x6005056")]
			[Address(RVA = "0x1FDB70C", Offset = "0x1FDB70C", VA = "0x1FDB70C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BAA")]
		public string LobbyCharImages
		{
			[Token(Token = "0x6005057")]
			[Address(RVA = "0x1FDB744", Offset = "0x1FDB744", VA = "0x1FDB744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAB")]
		public MannerPointOptions MannerPoint
		{
			[Token(Token = "0x6005065")]
			[Address(RVA = "0x1FDBEE0", Offset = "0x1FDBEE0", VA = "0x1FDBEE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005066")]
			[Address(RVA = "0x1FD53E4", Offset = "0x1FD53E4", VA = "0x1FD53E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000BAC")]
		public AttendanceOptions Attendance
		{
			[Token(Token = "0x6005067")]
			[Address(RVA = "0x1FDBEE8", Offset = "0x1FDBEE8", VA = "0x1FDBEE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005068")]
			[Address(RVA = "0x1FD53EC", Offset = "0x1FD53EC", VA = "0x1FD53EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6004F95")]
		[Address(RVA = "0x1FC15E0", Offset = "0x1FC15E0", VA = "0x1FC15E0")]
		public CSProtoInfoManager_GameConst()
		{
		}

		[Token(Token = "0x6004F96")]
		[Address(RVA = "0x1FD2F78", Offset = "0x1FD2F78", VA = "0x1FD2F78")]
		public bool UsePointShopAdvertisementChargeByCountry(string country)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x1FD30D4", Offset = "0x1FD30D4", VA = "0x1FD30D4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0x1FD30E4", Offset = "0x1FD30E4", VA = "0x1FD30E4", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x1FD30E8", Offset = "0x1FD30E8", VA = "0x1FD30E8", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FA2")]
		[Address(RVA = "0x1FD585C", Offset = "0x1FD585C", VA = "0x1FD585C")]
		public int GetSeason(DateTime Time)
		{
			return default(int);
		}

		[Token(Token = "0x6004FA3")]
		[Address(RVA = "0x1FD59EC", Offset = "0x1FD59EC", VA = "0x1FD59EC")]
		private int GetOneWeekSeason(DateTime time)
		{
			return default(int);
		}

		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0x1FD5AF0", Offset = "0x1FD5AF0", VA = "0x1FD5AF0")]
		private int GetTwoWeekSeason(DateTime time)
		{
			return default(int);
		}

		[Token(Token = "0x6004FA5")]
		[Address(RVA = "0x1FD5D00", Offset = "0x1FD5D00", VA = "0x1FD5D00")]
		private int CalcGetSeason(TimeSpan tsTime, int seasonDay)
		{
			return default(int);
		}

		[Token(Token = "0x6004FA6")]
		[Address(RVA = "0x1FD5E34", Offset = "0x1FD5E34", VA = "0x1FD5E34")]
		public DateTime GetNextSeasonTime(DateTime localNow)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004FA7")]
		[Address(RVA = "0x1FD600C", Offset = "0x1FD600C", VA = "0x1FD600C")]
		private DateTime GetNextOneWeekSeasonTime(DateTime localNow)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x1FD605C", Offset = "0x1FD605C", VA = "0x1FD605C")]
		private DateTime GetNextTwoWeekSeasonTime(DateTime localNow)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x1FD6148", Offset = "0x1FD6148", VA = "0x1FD6148")]
		private DateTime GetNextSeasonTime(DateTime startTime, DateTime localNow, int SeasonDay)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x1FD623C", Offset = "0x1FD623C", VA = "0x1FD623C")]
		private DateTime CalcGetNextSeasonTime(DateTime startTime, TimeSpan tsGap, int seasonDay)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x1FD63C4", Offset = "0x1FD63C4", VA = "0x1FD63C4", Slot = "45")]
		public virtual int GetBoxSeason(DateTime localTime)
		{
			return default(int);
		}

		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x1FD63E8", Offset = "0x1FD63E8", VA = "0x1FD63E8")]
		public DateTime GetBoxSeasonEndTime(int season)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x1FD4168", Offset = "0x1FD4168", VA = "0x1FD4168")]
		private bool CookingIngameFactor()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0x1FD642C", Offset = "0x1FD642C", VA = "0x1FD642C")]
		private bool CookingFactor(key k, ref float val)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x1FD53F4", Offset = "0x1FD53F4", VA = "0x1FD53F4")]
		private bool CookingClan()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0x1FD5118", Offset = "0x1FD5118", VA = "0x1FD5118")]
		private bool CookingETC()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB1")]
		[Address(RVA = "0x1FD6BE0", Offset = "0x1FD6BE0", VA = "0x1FD6BE0")]
		private bool CookingMiscahShopResetTime()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x1FD6C20", Offset = "0x1FD6C20", VA = "0x1FD6C20")]
		private void SetResetTime(key key, ref TimeSpan value, int defaultTime)
		{
		}

		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x1FD4DC0", Offset = "0x1FD4DC0", VA = "0x1FD4DC0")]
		private bool CookingRank()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x1FD65D4", Offset = "0x1FD65D4", VA = "0x1FD65D4")]
		private bool CookingFactor(key k, ref int val)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x1FD6774", Offset = "0x1FD6774", VA = "0x1FD6774")]
		private bool CookingListFactor(string key_prefix, List<int> list)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x1FD3228", Offset = "0x1FD3228", VA = "0x1FD3228")]
		private bool CookingDailyBoxInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x1FD39CC", Offset = "0x1FD39CC", VA = "0x1FD39CC")]
		private bool CookingDuelShopChargeInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x1FD45E0", Offset = "0x1FD45E0", VA = "0x1FD45E0")]
		private bool CookingRarityRelativeTable()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x1FD6DAC", Offset = "0x1FD6DAC", VA = "0x1FD6DAC")]
		private bool CookingRefinedMaxLevelOnGrade()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x1FD7710", Offset = "0x1FD7710", VA = "0x1FD7710")]
		public int GetMaxRarityLevel(ItemRarity itemRarity, List<int> randomOptionList)
		{
			return default(int);
		}

		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x1FD4884", Offset = "0x1FD4884", VA = "0x1FD4884")]
		private bool CookingPromotionTable()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x1FD77E0", Offset = "0x1FD77E0", VA = "0x1FD77E0")]
		public int GetMonsterScore(int grade)
		{
			return default(int);
		}

		[Token(Token = "0x6004FBD")]
		[Address(RVA = "0x1FD7AB8", Offset = "0x1FD7AB8", VA = "0x1FD7AB8")]
		public bool HasCharacterNextLevel(int level)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x1FD7BE0", Offset = "0x1FD7BE0", VA = "0x1FD7BE0")]
		public bool HasCharacterNextLevel(int currLevel, int maxLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x1FD7BF0", Offset = "0x1FD7BF0", VA = "0x1FD7BF0")]
		public int GetCharacterMaxLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x1FD7D08", Offset = "0x1FD7D08", VA = "0x1FD7D08")]
		public bool HasPetNextLevel(int level)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x1FD7E30", Offset = "0x1FD7E30", VA = "0x1FD7E30")]
		public bool HasPetNextLevel(int currLevel, int maxLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x1FD7E40", Offset = "0x1FD7E40", VA = "0x1FD7E40")]
		public int GetPetMaxLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x1FD7F58", Offset = "0x1FD7F58", VA = "0x1FD7F58")]
		public int GetTeamMaxLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x1FD8070", Offset = "0x1FD8070", VA = "0x1FD8070")]
		public int GetStoreChargePrice(int chargeCount)
		{
			return default(int);
		}

		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x1FD81C4", Offset = "0x1FD81C4", VA = "0x1FD81C4")]
		public int GetDuelStallChargePrice(int chargeCount)
		{
			return default(int);
		}

		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x1FD82BC", Offset = "0x1FD82BC", VA = "0x1FD82BC")]
		public int GetCombatStallChargePrice(int chargeCount)
		{
			return default(int);
		}

		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x1FD83B4", Offset = "0x1FD83B4", VA = "0x1FD83B4")]
		public int GetMischaStallChargePrice(int chargeCount)
		{
			return default(int);
		}

		[Token(Token = "0x6004FC8")]
		private bool CookingRairityTable<T>(string[] rairitys, List<T> table, string prefix, T defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x1FD745C", Offset = "0x1FD745C", VA = "0x1FD745C")]
		private bool CookingFusionPrice(string[] rairitys)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x1FD84AC", Offset = "0x1FD84AC", VA = "0x1FD84AC", Slot = "46")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FD0")]
		[Address(RVA = "0x1FD8DB0", Offset = "0x1FD8DB0", VA = "0x1FD8DB0")]
		public int GetItemInvenSlotIncCrystalPrice(int nNextSlotCount)
		{
			return default(int);
		}

		[Token(Token = "0x6004FD1")]
		[Address(RVA = "0x1FD8ED4", Offset = "0x1FD8ED4", VA = "0x1FD8ED4")]
		public int GetPassedServiceDays()
		{
			return default(int);
		}

		[Token(Token = "0x6004FD2")]
		[Address(RVA = "0x1FD8FE0", Offset = "0x1FD8FE0", VA = "0x1FD8FE0")]
		public int GetPassedServiceDays(DateTime now)
		{
			return default(int);
		}

		[Token(Token = "0x6004FD9")]
		[Address(RVA = "0x1FD3094", Offset = "0x1FD3094", VA = "0x1FD3094")]
		private int GetValue(key k, int Default)
		{
			return default(int);
		}

		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x1FD91F4", Offset = "0x1FD91F4", VA = "0x1FD91F4")]
		private float GetValue(key k, float Default)
		{
			return default(float);
		}

		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x1FD92FC", Offset = "0x1FD92FC", VA = "0x1FD92FC")]
		private double GetValue(key k, double Default)
		{
			return default(double);
		}

		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x1FD9340", Offset = "0x1FD9340", VA = "0x1FD9340")]
		private bool GetValue(key k, bool Default)
		{
			return default(bool);
		}

		[Token(Token = "0x600500A")]
		[Address(RVA = "0x1FD9F0C", Offset = "0x1FD9F0C", VA = "0x1FD9F0C")]
		public int GetBuyCurrencyPrice(int count)
		{
			return default(int);
		}

		[Token(Token = "0x600500B")]
		[Address(RVA = "0x1FD9FC0", Offset = "0x1FD9FC0", VA = "0x1FD9FC0")]
		public int GetMaterialExpContribution(CSItemInfo itemInfo)
		{
			return default(int);
		}

		[Token(Token = "0x600500C")]
		[Address(RVA = "0x1FDA1C4", Offset = "0x1FDA1C4", VA = "0x1FDA1C4")]
		public int GetRefineCost(ItemRarity targetRairity, EquipmentSlot targetSlot, [Optional] DateTime? serverLocalNow, [Optional] CSHotTimeEventList hottimes)
		{
			return default(int);
		}

		[Token(Token = "0x600500D")]
		[Address(RVA = "0x1FDA464", Offset = "0x1FDA464", VA = "0x1FDA464")]
		private float GetRefinePriceRatio(ItemRarity targetRairity)
		{
			return default(float);
		}

		[Token(Token = "0x600500E")]
		[Address(RVA = "0x1FDA540", Offset = "0x1FDA540", VA = "0x1FDA540")]
		private float GetRefinePriceRatioForTargetSlot(EquipmentSlot slot)
		{
			return default(float);
		}

		[Token(Token = "0x600500F")]
		[Address(RVA = "0x1FDA5A4", Offset = "0x1FDA5A4", VA = "0x1FDA5A4")]
		public int GetFusionCost(ItemRarity rarity)
		{
			return default(int);
		}

		[Token(Token = "0x6005010")]
		[Address(RVA = "0x1FDA840", Offset = "0x1FDA840", VA = "0x1FDA840")]
		public int GetPromotionStoneCost(ItemRarity rarity)
		{
			return default(int);
		}

		[Token(Token = "0x6005011")]
		[Address(RVA = "0x1FDAADC", Offset = "0x1FDAADC", VA = "0x1FDAADC")]
		public int GetPromotionGoldCost(ItemRarity rarity)
		{
			return default(int);
		}

		[Token(Token = "0x6005012")]
		[Address(RVA = "0x1FDAD78", Offset = "0x1FDAD78", VA = "0x1FDAD78")]
		public int GetRandomOptionMaxCount(ItemRarity rarity)
		{
			return default(int);
		}

		[Token(Token = "0x6005013")]
		[Address(RVA = "0x1FDAF08", Offset = "0x1FDAF08", VA = "0x1FDAF08")]
		public int GetTranscendencePrice(ItemRarity rarity, List<int> targetRandomOptionList)
		{
			return default(int);
		}

		[Token(Token = "0x6005014")]
		[Address(RVA = "0x1FDB01C", Offset = "0x1FDB01C", VA = "0x1FDB01C")]
		public void GetChangeRandomoptionPrice(out int gold, out int stone)
		{
			gold = default;
			stone = default;
		}

		[Token(Token = "0x6005058")]
		[Address(RVA = "0x1FDB7CC", Offset = "0x1FDB7CC", VA = "0x1FDB7CC")]
		public string GetOpenTimeConst(string modeType, string dayKeyType)
		{
			return null;
		}

		[Token(Token = "0x6005059")]
		[Address(RVA = "0x1FDB9F4", Offset = "0x1FDB9F4", VA = "0x1FDB9F4")]
		public bool TryGetValue(string key_str, out string v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x600505A")]
		[Address(RVA = "0x1FD6D54", Offset = "0x1FD6D54", VA = "0x1FD6D54")]
		public bool TryGetValue(string key_str, out int v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x600505B")]
		[Address(RVA = "0x1FD9380", Offset = "0x1FD9380", VA = "0x1FD9380")]
		public bool TryGetValue(key key_str, out bool v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x600505C")]
		[Address(RVA = "0x1FDBB6C", Offset = "0x1FDBB6C", VA = "0x1FDBB6C")]
		public bool TryGetValue(string key_str, out bool v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x600505D")]
		[Address(RVA = "0x1FD6C88", Offset = "0x1FD6C88", VA = "0x1FD6C88")]
		public bool TryGetValue(key key_str, out int v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x600505E")]
		[Address(RVA = "0x1FDBC58", Offset = "0x1FDBC58", VA = "0x1FDBC58")]
		public bool TryGetValue(string key_str, out float v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x600505F")]
		[Address(RVA = "0x1FD9230", Offset = "0x1FD9230", VA = "0x1FD9230")]
		public bool TryGetValue(key key_str, out float v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x6005060")]
		[Address(RVA = "0x1FD8E80", Offset = "0x1FD8E80", VA = "0x1FD8E80")]
		public bool TryGetValue(string key_str, out double v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x6005061")]
		[Address(RVA = "0x1FD6AB0", Offset = "0x1FD6AB0", VA = "0x1FD6AB0")]
		public bool TryGetValue(key key_str, out double v)
		{
			v = default;
			return default(bool);
		}

		[Token(Token = "0x6005062")]
		[Address(RVA = "0x1FDBCA8", Offset = "0x1FDBCA8", VA = "0x1FDBCA8")]
		public void SetConst(key _key, string _value)
		{
		}

		[Token(Token = "0x6005063")]
		[Address(RVA = "0x1FDBDB4", Offset = "0x1FDBDB4", VA = "0x1FDBDB4")]
		public void SetConst(key _key, int _value)
		{
		}

		[Token(Token = "0x6005064")]
		[Address(RVA = "0x1FDBEB4", Offset = "0x1FDBEB4", VA = "0x1FDBEB4")]
		public int GetUlockRankLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6005069")]
		[Address(RVA = "0x1FDBEF0", Offset = "0x1FDBEF0", VA = "0x1FDBEF0")]
		private static bool _003CCookingDailyBoxInfo_003Em__1FF(KeyValuePair<key, string> e)
		{
			return default(bool);
		}
	}
}
