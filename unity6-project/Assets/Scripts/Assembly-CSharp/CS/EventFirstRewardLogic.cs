using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200092A")]
	public class EventFirstRewardLogic
	{
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x8")]
		private EventGameRewardGroup rewardGroup;

		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0xC")]
		private EventGameModeClearRecord record;

		[Token(Token = "0x4002D64")]
		[FieldOffset(Offset = "0x10")]
		private int eventModeGroupID;

		[Token(Token = "0x4002D65")]
		[FieldOffset(Offset = "0x14")]
		private RewardType FIRST_REWARD_TYPE;

		[Token(Token = "0x4002D66")]
		[FieldOffset(Offset = "0x18")]
		private ConditionType CONDITION_TYPE;

		[Token(Token = "0x6004919")]
		[Address(RVA = "0x1CDC69C", Offset = "0x1CDC69C", VA = "0x1CDC69C")]
		public EventFirstRewardLogic(EventGameModeClearRecord record, int eventModeGroupID, int rewardGroupID, CSProtoInfoManager_EventGameReward protoEventGameReward)
		{
		}

		[Token(Token = "0x600491A")]
		[Address(RVA = "0x1CDC898", Offset = "0x1CDC898", VA = "0x1CDC898")]
		public void GetExistRecievableFirstReward(out bool isExistReceiveReward, out CSContent representReward)
		{
			isExistReceiveReward = default;
			representReward = default;
		}

		[Token(Token = "0x600491B")]
		[Address(RVA = "0x1CDCB9C", Offset = "0x1CDCB9C", VA = "0x1CDCB9C")]
		public List<CSContent> GetRewardContents(int conditionCount)
		{
			return null;
		}

		[Token(Token = "0x600491C")]
		[Address(RVA = "0x1CDCE20", Offset = "0x1CDCE20", VA = "0x1CDCE20")]
		public void GetProgress(out bool isExistFirstRewards, out int curCount, out int maxCount)
		{
			curCount = default;
			isExistFirstRewards = default;
			maxCount = default;
		}

		[Token(Token = "0x600491D")]
		[Address(RVA = "0x1CDCB68", Offset = "0x1CDCB68", VA = "0x1CDCB68")]
		public int GetLastReceiveFirstRecieveValue()
		{
			return default(int);
		}

		[Token(Token = "0x600491E")]
		[Address(RVA = "0x1CDCA08", Offset = "0x1CDCA08", VA = "0x1CDCA08")]
		public void GetWinProgress(out int progressCount, out int progressMaxWin)
		{
			progressCount = default;
			progressMaxWin = default;
		}

		[Token(Token = "0x600491F")]
		[Address(RVA = "0x1CDD4D8", Offset = "0x1CDD4D8", VA = "0x1CDD4D8")]
		public bool IsRecieveMaxFirstConditionReward()
		{
			return default(bool);
		}

		[Token(Token = "0x6004920")]
		[Address(RVA = "0x1CDD538", Offset = "0x1CDD538", VA = "0x1CDD538")]
		public bool IsExistRecievableFirstReward()
		{
			return default(bool);
		}
	}
}
