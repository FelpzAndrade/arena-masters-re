using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008F0")]
	public class AchievementLogic
	{
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x23E4F10", Offset = "0x23E4F10", VA = "0x23E4F10")]
		public AchievementLogic()
		{
		}

		[Token(Token = "0x600479F")]
		[Address(RVA = "0x23E4F18", Offset = "0x23E4F18", VA = "0x23E4F18")]
		public bool IsShowble(UserDataBase data, int questId, ProtoInfoManager_Quest proto)
		{
			return default(bool);
		}

		[Token(Token = "0x60047A0")]
		[Address(RVA = "0x23E515C", Offset = "0x23E515C", VA = "0x23E515C")]
		public int GetQuestIdFromUserDataAchievements(UserDataBase userData, string achieveGroup)
		{
			return default(int);
		}

		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x23E5294", Offset = "0x23E5294", VA = "0x23E5294")]
		public bool ItemClearCheck(List<int> m_achieveClearItemList, int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x23E5384", Offset = "0x23E5384", VA = "0x23E5384")]
		public bool AchievementClearList(List<int> achievementList)
		{
			return default(bool);
		}

		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x23E5424", Offset = "0x23E5424", VA = "0x23E5424")]
		public int GetNoticeStateAchievementItem(List<int> clear_list, List<int> cache_list, Dictionary<int, QuestInfo> protoInfoManager_Quest)
		{
			return default(int);
		}

		[Token(Token = "0x60047A4")]
		[Address(RVA = "0x23E56B4", Offset = "0x23E56B4", VA = "0x23E56B4")]
		public bool CheckConditionCacheList(int id, List<int> cache_list)
		{
			return default(bool);
		}

		[Token(Token = "0x60047A5")]
		[Address(RVA = "0x23E55F4", Offset = "0x23E55F4", VA = "0x23E55F4")]
		public QuestInfo GetQuestInfo(int questId, Dictionary<int, QuestInfo> questProto)
		{
			return null;
		}
	}
}
