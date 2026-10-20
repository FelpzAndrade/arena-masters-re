using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200090A")]
	public class QuestLogic
	{
		[Token(Token = "0x200090B")]
		private sealed class _003CGetQuestBy_003Ec__AnonStorey14B
		{
			[Token(Token = "0x4002B7F")]
			[FieldOffset(Offset = "0x8")]
			internal QuestGroup group;

			[Token(Token = "0x4002B80")]
			[FieldOffset(Offset = "0xC")]
			internal int team_level;

			[Token(Token = "0x4002B81")]
			[FieldOffset(Offset = "0x10")]
			internal List<QuestInfo> list;

			[Token(Token = "0x6004874")]
			[Address(RVA = "0x21BCD44", Offset = "0x21BCD44", VA = "0x21BCD44")]
			public _003CGetQuestBy_003Ec__AnonStorey14B()
			{
			}

			[Token(Token = "0x6004875")]
			[Address(RVA = "0x21BFB18", Offset = "0x21BFB18", VA = "0x21BFB18")]
			internal bool _003C_003Em__1EB(KeyValuePair<int, QuestInfo> e)
			{
				return default(bool);
			}

			[Token(Token = "0x6004876")]
			[Address(RVA = "0x21BFC98", Offset = "0x21BFC98", VA = "0x21BFC98")]
			internal void _003C_003Em__1EC(KeyValuePair<int, QuestInfo> f)
			{
			}
		}

		[Token(Token = "0x4002B7C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string QUEST_DONE_PREFIX;

		[Token(Token = "0x4002B7D")]
		[FieldOffset(Offset = "0x8")]
		private ProtoInfoManager_Quest m_ProtoInfoManager_Quest;

		[Token(Token = "0x4002B7E")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map13;

		[Token(Token = "0x6004864")]
		[Address(RVA = "0x21BCAC8", Offset = "0x21BCAC8", VA = "0x21BCAC8")]
		public QuestLogic(ProtoInfoManager_Quest container)
		{
		}

		[Token(Token = "0x6004866")]
		[Address(RVA = "0x21BCB78", Offset = "0x21BCB78", VA = "0x21BCB78")]
		public List<QuestInfo> GetQuestBy(int team_level, QuestGroup group)
		{
			return null;
		}

		[Token(Token = "0x6004867")]
		[Address(RVA = "0x21BCD4C", Offset = "0x21BCD4C", VA = "0x21BCD4C")]
		private bool CheckAllClearQuest(UserDataBase data, QuestInfo item)
		{
			return default(bool);
		}

		[Token(Token = "0x6004868")]
		[Address(RVA = "0x21BCFCC", Offset = "0x21BCFCC", VA = "0x21BCFCC")]
		public bool CheckCondition(UserDataBase data, List<int> ownCharIds, List<int> ownPetIds, QuestInfo questInfo, string condition, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x6004869")]
		[Address(RVA = "0x21BE81C", Offset = "0x21BE81C", VA = "0x21BE81C")]
		private string GetOneCondition(string condition, string filter)
		{
			return null;
		}

		[Token(Token = "0x600486A")]
		[Address(RVA = "0x21BE960", Offset = "0x21BE960", VA = "0x21BE960")]
		public bool TryGetCountryCondition(string condition, out string countryID, out bool isAll)
		{
			countryID = default;
			isAll = default;
			return default(bool);
		}

		[Token(Token = "0x600486B")]
		[Address(RVA = "0x21BEB54", Offset = "0x21BEB54", VA = "0x21BEB54")]
		public void GetProgressCount(UserDataBase data, QuestInfo questInfo, int id, int showOrder, out int progressCount, out int totalCount)
		{
			progressCount = default;
			totalCount = default;
		}

		[Token(Token = "0x600486C")]
		[Address(RVA = "0x21BEE14", Offset = "0x21BEE14", VA = "0x21BEE14")]
		public void GetAllClearProgressCount(UserDataBase data, QuestGroup group, out int progressCount, out int totalCount)
		{
			progressCount = default;
			totalCount = default;
		}

		[Token(Token = "0x600486D")]
		[Address(RVA = "0x21BE090", Offset = "0x21BE090", VA = "0x21BE090")]
		public void GetProgressCount(UserDataBase data, QuestInfo questInfo, string condition, out int progressCount, out int totalCount)
		{
			progressCount = default;
			totalCount = default;
		}

		[Token(Token = "0x600486E")]
		[Address(RVA = "0x21BF08C", Offset = "0x21BF08C", VA = "0x21BF08C")]
		public bool IsShowable(UserDataBase data, List<int> ownCharIds, List<int> ownPetIds, InitializeType initType, int id, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x600486F")]
		[Address(RVA = "0x21BF71C", Offset = "0x21BF71C", VA = "0x21BF71C")]
		public string GetGroupString(string showIfString)
		{
			return null;
		}

		[Token(Token = "0x6004870")]
		[Address(RVA = "0x21BF82C", Offset = "0x21BF82C", VA = "0x21BF82C")]
		public bool IsCompletable(UserDataBase data, List<int> ownCharIds, List<int> ownPetIds, int id, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x6004871")]
		[Address(RVA = "0x21BF618", Offset = "0x21BF618", VA = "0x21BF618")]
		public bool IsClearQuest(UserDataBase data, int id, InitializeType initType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004872")]
		[Address(RVA = "0x21BFA78", Offset = "0x21BFA78", VA = "0x21BFA78")]
		public IncreasableDictionary<string> GetStats(UserDataBase userData, InitializeType questInitType)
		{
			return null;
		}

		[Token(Token = "0x6004873")]
		[Address(RVA = "0x21BE7A4", Offset = "0x21BE7A4", VA = "0x21BE7A4")]
		public int GetStats(UserDataBase userData, InitializeType questInitType, string questClearKey)
		{
			return default(int);
		}
	}
}
