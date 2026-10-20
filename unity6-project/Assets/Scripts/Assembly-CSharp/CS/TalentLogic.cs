using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000903")]
	public static class TalentLogic
	{
		[Token(Token = "0x4002B75")]
		[FieldOffset(Offset = "0x0")]
		private static Action<KeyValuePair<string, Dictionary<int, int>>> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6004826")]
		[Address(RVA = "0x21E5EB0", Offset = "0x21E5EB0", VA = "0x21E5EB0")]
		public static int CountOfPage(UserDataBase userData)
		{
			return default(int);
		}

		[Token(Token = "0x6004827")]
		[Address(RVA = "0x21E5F54", Offset = "0x21E5F54", VA = "0x21E5F54")]
		public static List<int> GetPassiveTalentId(ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return null;
		}

		[Token(Token = "0x6004828")]
		[Address(RVA = "0x21E60B4", Offset = "0x21E60B4", VA = "0x21E60B4")]
		public static int CountOfStatBy(UserDataBase userData, string page_name, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(int);
		}

		[Token(Token = "0x6004829")]
		[Address(RVA = "0x21E644C", Offset = "0x21E644C", VA = "0x21E644C")]
		public static int GetRemainPoint(UserDataBase userData, string pageNumber, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(int);
		}

		[Token(Token = "0x600482A")]
		[Address(RVA = "0x21E6488", Offset = "0x21E6488", VA = "0x21E6488")]
		public static int GetTotalPoint(UserDataBase userData)
		{
			return default(int);
		}

		[Token(Token = "0x600482B")]
		[Address(RVA = "0x21E64A8", Offset = "0x21E64A8", VA = "0x21E64A8")]
		public static bool ChangePageName(UserDataBase userData, string old_name, string new_name)
		{
			return default(bool);
		}

		[Token(Token = "0x600482C")]
		[Address(RVA = "0x21E68F8", Offset = "0x21E68F8", VA = "0x21E68F8")]
		public static bool IsExistPage(UserDataBase userData, string page_name, bool ExpectValue = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600482D")]
		[Address(RVA = "0x21E6ADC", Offset = "0x21E6ADC", VA = "0x21E6ADC")]
		public static bool IsExistStatBy(UserDataBase userData, string page_name, int stat_id, int stat_level)
		{
			return default(bool);
		}

		[Token(Token = "0x600482E")]
		[Address(RVA = "0x21E6EFC", Offset = "0x21E6EFC", VA = "0x21E6EFC")]
		public static bool IsExistStatBy(UserDataBase userData, string page_name, int stat_id)
		{
			return default(bool);
		}

		[Token(Token = "0x600482F")]
		[Address(RVA = "0x21E70C0", Offset = "0x21E70C0", VA = "0x21E70C0")]
		public static bool IsExistGroupBy(UserDataBase userData, string page_name, int group_number, TalentType type, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x6004830")]
		[Address(RVA = "0x21E72D8", Offset = "0x21E72D8", VA = "0x21E72D8")]
		public static int GetLearnedTP(UserDataBase userData, string page_name, TalentType talentType, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(int);
		}

		[Token(Token = "0x6004831")]
		[Address(RVA = "0x21E7514", Offset = "0x21E7514", VA = "0x21E7514")]
		public static int GetStatLevel(UserDataBase userData, string page_name, int stat_id)
		{
			return default(int);
		}

		[Token(Token = "0x6004832")]
		[Address(RVA = "0x21E7700", Offset = "0x21E7700", VA = "0x21E7700")]
		public static bool IsMaxStat(UserDataBase userData, string page_name, int stat_id, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x6004833")]
		[Address(RVA = "0x21E7D64", Offset = "0x21E7D64", VA = "0x21E7D64")]
		public static int IsMaxStatsCount(UserDataBase userData, string page_name, int stat_id, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(int);
		}

		[Token(Token = "0x6004834")]
		[Address(RVA = "0x21E7A9C", Offset = "0x21E7A9C", VA = "0x21E7A9C")]
		public static KeyValuePair<int, int>? GetMyStatBy(UserDataBase userData, string page_name, int stat_id)
		{
			return null;
		}

		[Token(Token = "0x6004835")]
		[Address(RVA = "0x21E7E54", Offset = "0x21E7E54", VA = "0x21E7E54")]
		public static int RemainPointBy(UserDataBase userData, string page_name, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(int);
		}

		[Token(Token = "0x6004836")]
		[Address(RVA = "0x21E7E88", Offset = "0x21E7E88", VA = "0x21E7E88")]
		public static bool CheckPrerequisite(UserDataBase userData, string page_name, int stat_id, int level, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x6004837")]
		[Address(RVA = "0x21E8180", Offset = "0x21E8180", VA = "0x21E8180")]
		public static bool IsCheckStatLevel(int next_level, int level)
		{
			return default(bool);
		}

		[Token(Token = "0x6004838")]
		[Address(RVA = "0x21E8190", Offset = "0x21E8190", VA = "0x21E8190")]
		public static bool IsPossibleToUpgradeStat(UserDataBase userData, string page_name, int stat_id, int curr_level, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x6004839")]
		[Address(RVA = "0x21E8408", Offset = "0x21E8408", VA = "0x21E8408")]
		public static bool UpgradeStat(UserDataBase userData, string page_name, int stat_id, int level, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x600483A")]
		[Address(RVA = "0x21E86FC", Offset = "0x21E86FC", VA = "0x21E86FC")]
		public static bool ResetStat(UserDataBase userData, string page_name, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x600483B")]
		[Address(RVA = "0x21E8A10", Offset = "0x21E8A10", VA = "0x21E8A10")]
		public static void ResetDefault(UserDataBase userData)
		{
		}

		[Token(Token = "0x600483C")]
		[Address(RVA = "0x21E8BEC", Offset = "0x21E8BEC", VA = "0x21E8BEC")]
		public static bool AddPage(UserDataBase user, CSProtoInfoManager_GameConst const_data, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x600483D")]
		[Address(RVA = "0x21E8804", Offset = "0x21E8804", VA = "0x21E8804")]
		public static bool AddBaseTalent(UserDataBase userData, string pageName, ProtoInfoManager_Talent protoInfoManager_Talent)
		{
			return default(bool);
		}

		[Token(Token = "0x600483E")]
		[Address(RVA = "0x21E9024", Offset = "0x21E9024", VA = "0x21E9024")]
		public static bool IsPossibleToTalent(TalentInfo talentInfo, bool bLearn, int nLevel, int nConditionLevel, int talentPoint, int attackLearnedTP, int defenceLearnedTP)
		{
			return default(bool);
		}

		[Token(Token = "0x600483F")]
		[Address(RVA = "0x21E9084", Offset = "0x21E9084", VA = "0x21E9084")]
		public static bool CheckLock(TalentInfo talentInfo, int nMyTeamLevel, int attackLearnedTP, int defenceLearnedTP)
		{
			return default(bool);
		}

		[Token(Token = "0x6004840")]
		[Address(RVA = "0x21E90E0", Offset = "0x21E90E0", VA = "0x21E90E0")]
		private static void _003CResetDefault_003Em__1E8(KeyValuePair<string, Dictionary<int, int>> e)
		{
		}
	}
}
