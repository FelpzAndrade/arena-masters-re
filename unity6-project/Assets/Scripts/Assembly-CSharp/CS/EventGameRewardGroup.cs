using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AD1")]
	public class EventGameRewardGroup
	{
		[Token(Token = "0x40032C8")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x40032C9")]
		[FieldOffset(Offset = "0xC")]
		private ConditionType m_milestoneConditionType;

		[Token(Token = "0x40032CA")]
		[FieldOffset(Offset = "0x10")]
		private ConditionType m_firstConditionType;

		[Token(Token = "0x40032CB")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<DoubleKey, SortedDictionary<int, EventGameRewardInfo>> RewardDic;

		[Token(Token = "0x40032CC")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ConditionType, int> MaxDic;

		[Token(Token = "0x40032CD")]
		[FieldOffset(Offset = "0x1C")]
		private int MilestoneMaxConditionCount__BackingField;

		[Token(Token = "0x40032CE")]
		[FieldOffset(Offset = "0x20")]
		private int FirstMaxConditionCount__BackingField;

		[Token(Token = "0x17000B36")]
		public ConditionType PresentMilestoneConditionType
		{
			[Token(Token = "0x6004F44")]
			[Address(RVA = "0x1CDF63C", Offset = "0x1CDF63C", VA = "0x1CDF63C")]
			get
			{
				return default(ConditionType);
			}
		}

		[Token(Token = "0x17000B37")]
		public ConditionType PresentFirstConditionType
		{
			[Token(Token = "0x6004F45")]
			[Address(RVA = "0x1CDC890", Offset = "0x1CDC890", VA = "0x1CDC890")]
			get
			{
				return default(ConditionType);
			}
		}

		[Token(Token = "0x17000B38")]
		public int MilestoneMaxConditionCount
		{
			[Token(Token = "0x6004F46")]
			[Address(RVA = "0x1CDF644", Offset = "0x1CDF644", VA = "0x1CDF644")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004F47")]
			[Address(RVA = "0x1CDF64C", Offset = "0x1CDF64C", VA = "0x1CDF64C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B39")]
		public int FirstMaxConditionCount
		{
			[Token(Token = "0x6004F48")]
			[Address(RVA = "0x1CDD4D0", Offset = "0x1CDD4D0", VA = "0x1CDD4D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004F49")]
			[Address(RVA = "0x1CDF654", Offset = "0x1CDF654", VA = "0x1CDF654")]
			private set
			{
			}
		}

		[Token(Token = "0x6004F43")]
		[Address(RVA = "0x1CDF55C", Offset = "0x1CDF55C", VA = "0x1CDF55C")]
		public EventGameRewardGroup()
		{
		}

		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x1CDF65C", Offset = "0x1CDF65C", VA = "0x1CDF65C")]
		private SortedDictionary<int, EventGameRewardInfo> GetRewardDic(RewardType type, ConditionType condition)
		{
			return null;
		}

		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x1CDF7C4", Offset = "0x1CDF7C4", VA = "0x1CDF7C4")]
		public SortedDictionary<int, EventGameRewardInfo> CloneRewardDic(RewardType type, ConditionType condition)
		{
			return null;
		}

		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x1CDFAA4", Offset = "0x1CDFAA4", VA = "0x1CDFAA4")]
		public void RecordConditionCount(RewardType type, ConditionType condition, int conditionCount)
		{
		}

		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x1CDFC40", Offset = "0x1CDFC40", VA = "0x1CDFC40")]
		public bool Add(EventGameRewardInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F4E")]
		[Address(RVA = "0x1CDCC8C", Offset = "0x1CDCC8C", VA = "0x1CDCC8C")]
		public bool TryGetReward(RewardType type, ConditionType condition, int value, out List<CSContent> rewards, out int rewardID)
		{
			rewardID = default;
			rewards = default;
			return default(bool);
		}

		[Token(Token = "0x6004F4F")]
		[Address(RVA = "0x1CDD254", Offset = "0x1CDD254", VA = "0x1CDD254")]
		public bool TryGetNextReward(RewardType type, ConditionType condition, int checkValue, int nextSkipCount, out int nextValue, out List<CSContent> rewards, out int rewardID)
		{
			nextValue = default;
			rewardID = default;
			rewards = default;
			return default(bool);
		}

		[Token(Token = "0x6004F50")]
		[Address(RVA = "0x1CDFFB0", Offset = "0x1CDFFB0", VA = "0x1CDFFB0")]
		public int GetMax(ConditionType condition)
		{
			return default(int);
		}

		[Token(Token = "0x6004F51")]
		[Address(RVA = "0x1CDCE84", Offset = "0x1CDCE84", VA = "0x1CDCE84")]
		public bool TryGetStepProgress(RewardType type, ConditionType condition, int win, out int curRewardCount, out int maxRewardCount)
		{
			curRewardCount = default;
			maxRewardCount = default;
			return default(bool);
		}

		[Token(Token = "0x6004F52")]
		[Address(RVA = "0x1CE0090", Offset = "0x1CE0090", VA = "0x1CE0090")]
		public bool TryGetStepReward(RewardType type, ConditionType condition, int step, out int conditionValue, out List<CSContent> rewards)
		{
			conditionValue = default;
			rewards = default;
			return default(bool);
		}
	}
}
