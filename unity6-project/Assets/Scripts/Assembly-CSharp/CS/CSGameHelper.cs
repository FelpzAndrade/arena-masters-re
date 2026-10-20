using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008AB")]
	public static class CSGameHelper
	{
		[Token(Token = "0x6004635")]
		[Address(RVA = "0x222F3A8", Offset = "0x222F3A8", VA = "0x222F3A8")]
		public static Dictionary<XGameModeType, int> GetUnlockNeedLevels(CSProtoInfoManager_GameConst gameConst)
		{
			return null;
		}

		[Token(Token = "0x6004636")]
		[Address(RVA = "0x222F7C0", Offset = "0x222F7C0", VA = "0x222F7C0")]
		public static bool CheckQuestShowIf99(string condition)
		{
			return default(bool);
		}

		[Token(Token = "0x6004637")]
		[Address(RVA = "0x222F6DC", Offset = "0x222F6DC", VA = "0x222F6DC")]
		public static int GetUnlockNeedLevel(CSProtoInfoManager_GameConst gameConst, XGameModeType type)
		{
			return default(int);
		}

		[Token(Token = "0x6004638")]
		[Address(RVA = "0x222F860", Offset = "0x222F860", VA = "0x222F860")]
		public static int GetUnlockNeedLevel(CSProtoInfoManager_GameConst gameConst, string type)
		{
			return default(int);
		}

		[Token(Token = "0x6004639")]
		[Address(RVA = "0x22300C0", Offset = "0x22300C0", VA = "0x22300C0")]
		public static void BuildUnlockFeature(CSProtoInfoManagers proto, UserDataBase user)
		{
		}

		[Token(Token = "0x600463A")]
		[Address(RVA = "0x222DE44", Offset = "0x222DE44", VA = "0x222DE44")]
		public static void SplitKeyAndCount(string text, out string key, out int count, char seperator = ':')
		{
			count = default;
			key = default;
		}

		[Token(Token = "0x600463B")]
		[Address(RVA = "0x22305EC", Offset = "0x22305EC", VA = "0x22305EC")]
		public static void SplitKeyAndCount(string text, out int key, out int count, char seperator = ':')
		{
			count = default;
			key = default;
		}

		[Token(Token = "0x600463C")]
		[Address(RVA = "0x22307F0", Offset = "0x22307F0", VA = "0x22307F0")]
		public static int CalculateMaterialExpContribution(CSItemInfo itemInfo, int exp, CSProtoInfoManager_GameConst gameConst)
		{
			return default(int);
		}

		[Token(Token = "0x600463D")]
		[Address(RVA = "0x2230908", Offset = "0x2230908", VA = "0x2230908")]
		public static CharStatus GetPassiveSkillStatus(CSCharacterInfo charinfo, SkillSpecialized skillSpecialized, ProtoInfoManager_SkillSpecialization protoSkillSpecilaize)
		{
			return null;
		}

		[Token(Token = "0x600463E")]
		[Address(RVA = "0x2230A88", Offset = "0x2230A88", VA = "0x2230A88")]
		public static bool HasLevel(ItemType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600463F")]
		[Address(RVA = "0x2230AAC", Offset = "0x2230AAC", VA = "0x2230AAC")]
		public static bool IsStackable(ItemType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004640")]
		[Address(RVA = "0x2230AD0", Offset = "0x2230AD0", VA = "0x2230AD0")]
		public static bool IsUnCheckInvenSpace(ItemType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004641")]
		[Address(RVA = "0x2230AE0", Offset = "0x2230AE0", VA = "0x2230AE0")]
		public static bool CanBeMaterial(ItemType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004642")]
		[Address(RVA = "0x2230AF8", Offset = "0x2230AF8", VA = "0x2230AF8")]
		public static bool IsImmutable(CSContentType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004643")]
		[Address(RVA = "0x2230B2C", Offset = "0x2230B2C", VA = "0x2230B2C")]
		public static bool CanBeConsumeFusionItem(ItemType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004644")]
		[Address(RVA = "0x2230B3C", Offset = "0x2230B3C", VA = "0x2230B3C")]
		public static bool CanBeTranscendenceItem(ItemType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004645")]
		[Address(RVA = "0x2230B4C", Offset = "0x2230B4C", VA = "0x2230B4C")]
		public static CSWinlose Reverse(CSWinlose winlose)
		{
			return default(CSWinlose);
		}

		[Token(Token = "0x6004646")]
		[Address(RVA = "0x2230B7C", Offset = "0x2230B7C", VA = "0x2230B7C")]
		public static bool IsLadder(MatchType matchType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004647")]
		[Address(RVA = "0x2230B90", Offset = "0x2230B90", VA = "0x2230B90")]
		public static RankType GetRankType(XGameModeType gameModeType, bool isLadder)
		{
			return default(RankType);
		}

		[Token(Token = "0x6004648")]
		[Address(RVA = "0x2230BC4", Offset = "0x2230BC4", VA = "0x2230BC4")]
		public static RankType GetRankType(MatchType matchType, XGameModeType gameModeType)
		{
			return default(RankType);
		}

		[Token(Token = "0x6004649")]
		[Address(RVA = "0x2230C10", Offset = "0x2230C10", VA = "0x2230C10")]
		public static XGameModeType GetRankGameMode(RankType rankType)
		{
			return default(XGameModeType);
		}

		[Token(Token = "0x600464A")]
		[Address(RVA = "0x2230DEC", Offset = "0x2230DEC", VA = "0x2230DEC")]
		public static XGameModeType GetClanWarGameMode()
		{
			return default(XGameModeType);
		}

		[Token(Token = "0x600464B")]
		[Address(RVA = "0x2230DF4", Offset = "0x2230DF4", VA = "0x2230DF4")]
		public static bool IsPVPPattern(MissionPlayPattern pattern)
		{
			return default(bool);
		}

		[Token(Token = "0x600464C")]
		[Address(RVA = "0x2230E08", Offset = "0x2230E08", VA = "0x2230E08")]
		public static bool IsDeathMatchPattern(MissionPlayPattern pattern)
		{
			return default(bool);
		}

		[Token(Token = "0x600464D")]
		[Address(RVA = "0x2230E1C", Offset = "0x2230E1C", VA = "0x2230E1C")]
		public static bool NotEnoughResource(ApiReturnCode code)
		{
			return default(bool);
		}

		[Token(Token = "0x600464E")]
		[Address(RVA = "0x2230E58", Offset = "0x2230E58", VA = "0x2230E58")]
		public static ApiReturnCode CheckCost(UserDataBase userData, Currency type, int cost)
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x600464F")]
		[Address(RVA = "0x2230F68", Offset = "0x2230F68", VA = "0x2230F68")]
		public static int FindCharIDByName(string char_name, CSProtoInfoManager_Character protoInfoManager_Character)
		{
			return default(int);
		}

		[Token(Token = "0x6004650")]
		[Address(RVA = "0x2231134", Offset = "0x2231134", VA = "0x2231134")]
		public static int GetWinStreakExpandMatchPoint(int winStreak)
		{
			return default(int);
		}

		[Token(Token = "0x6004651")]
		[Address(RVA = "0x223115C", Offset = "0x223115C", VA = "0x223115C")]
		public static int GetLoseStreakExpandMatchPoint(int loseStreak)
		{
			return default(int);
		}

		[Token(Token = "0x6004652")]
		[Address(RVA = "0x2231188", Offset = "0x2231188", VA = "0x2231188")]
		public static bool TryGetBetterOption(CSProtoInfoManager_RandomOption protoRandOp, EquipmentSlot slot, int currentOpID, List<int> checkOpIDs, out List<int> betterIDs)
		{
			betterIDs = default;
			return default(bool);
		}

		[Token(Token = "0x6004653")]
		[Address(RVA = "0x2231544", Offset = "0x2231544", VA = "0x2231544")]
		public static bool TryGetBetterOption(CSProtoInfoManager_RandomOption protoRandOp, EquipmentSlot slot, int currentOpID, List<int> checkOpIDs, out Dictionary<int, bool> betterIDs)
		{
			betterIDs = default;
			return default(bool);
		}

		[Token(Token = "0x6004654")]
		[Address(RVA = "0x2231914", Offset = "0x2231914", VA = "0x2231914")]
		public static int GetClanWarPoint(int elo, CSProtoInfoManager_TrophyReward info, CSProtoInfoManager_GameConst gameConst)
		{
			return default(int);
		}

		[Token(Token = "0x6004655")]
		[Address(RVA = "0x22319CC", Offset = "0x22319CC", VA = "0x22319CC")]
		public static bool IsTrophyPointGetRankType(RankType rankType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004656")]
		[Address(RVA = "0x22319E0", Offset = "0x22319E0", VA = "0x22319E0")]
		public static bool IsClanBoxPoinGetMatchType(MatchType matchType)
		{
			return default(bool);
		}
	}
}
