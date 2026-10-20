using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B3A")]
	public class CSProtoInfoManager_RankReward : Dictionary<RankType, List<CSRankRewardItem>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000B3B")]
		private class RankEntry
		{
			[Token(Token = "0x40037A9")]
			[FieldOffset(Offset = "0x8")]
			public int rank;

			[Token(Token = "0x40037AA")]
			[FieldOffset(Offset = "0xC")]
			public CSRankRewardItem item;

			[Token(Token = "0x6005232")]
			[Address(RVA = "0x1CBE09C", Offset = "0x1CBE09C", VA = "0x1CBE09C")]
			public RankEntry()
			{
			}
		}

		[Token(Token = "0x2000B3C")]
		private class PercentEntry
		{
			[Token(Token = "0x40037AB")]
			[FieldOffset(Offset = "0x8")]
			public float percent;

			[Token(Token = "0x40037AC")]
			[FieldOffset(Offset = "0xC")]
			public CSRankRewardItem item;

			[Token(Token = "0x6005233")]
			[Address(RVA = "0x1CBE0A4", Offset = "0x1CBE0A4", VA = "0x1CBE0A4")]
			public PercentEntry()
			{
			}
		}

		[Token(Token = "0x2000B3D")]
		private sealed class _003CGetRankRewardItem_003Ec__AnonStorey158
		{
			[Token(Token = "0x40037AD")]
			[FieldOffset(Offset = "0x8")]
			internal int tierID;

			[Token(Token = "0x6005234")]
			[Address(RVA = "0x1CBEDD4", Offset = "0x1CBEDD4", VA = "0x1CBEDD4")]
			public _003CGetRankRewardItem_003Ec__AnonStorey158()
			{
			}

			[Token(Token = "0x6005235")]
			[Address(RVA = "0x1CBEDDC", Offset = "0x1CBEDDC", VA = "0x1CBEDDC")]
			internal bool _003C_003Em__20C(CSRankRewardItem x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40037A7")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<RankType, List<RankEntry>> m_rankList;

		[Token(Token = "0x40037A8")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<RankType, List<PercentEntry>> m_percentList;

		[Token(Token = "0x6005227")]
		[Address(RVA = "0x1CBD2C4", Offset = "0x1CBD2C4", VA = "0x1CBD2C4")]
		public CSProtoInfoManager_RankReward()
		{
		}

		[Token(Token = "0x6005228")]
		[Address(RVA = "0x1CBD3B0", Offset = "0x1CBD3B0", VA = "0x1CBD3B0", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005229")]
		[Address(RVA = "0x1CBD3C0", Offset = "0x1CBD3C0", VA = "0x1CBD3C0", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x600522A")]
		[Address(RVA = "0x1CBD3C4", Offset = "0x1CBD3C4", VA = "0x1CBD3C4", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x600522B")]
		[Address(RVA = "0x1CBE0AC", Offset = "0x1CBE0AC", VA = "0x1CBE0AC", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x600522C")]
		[Address(RVA = "0x1CBE690", Offset = "0x1CBE690", VA = "0x1CBE690")]
		public string GetTierText(RankType rankType, int rank, int totalRankersCount)
		{
			return null;
		}

		[Token(Token = "0x600522D")]
		[Address(RVA = "0x1CBE894", Offset = "0x1CBE894", VA = "0x1CBE894")]
		public string GetTierIcon(RankType rankType, int rank, int totalRankersCount)
		{
			return null;
		}

		[Token(Token = "0x600522E")]
		[Address(RVA = "0x1CBE6B8", Offset = "0x1CBE6B8", VA = "0x1CBE6B8")]
		public CSRankRewardItem GetRankRewardItem(RankType rankType, int rank, int totalRankerCount)
		{
			return null;
		}

		[Token(Token = "0x600522F")]
		[Address(RVA = "0x1CBE8BC", Offset = "0x1CBE8BC", VA = "0x1CBE8BC")]
		private CSRankRewardItem GetRankRewardItemWithRank(RankType rankType, int rank)
		{
			return null;
		}

		[Token(Token = "0x6005230")]
		[Address(RVA = "0x1CBEA94", Offset = "0x1CBEA94", VA = "0x1CBEA94")]
		private CSRankRewardItem GetRankRewardItemWithPercent(RankType rankType, float percent)
		{
			return null;
		}

		[Token(Token = "0x6005231")]
		[Address(RVA = "0x1CBEC50", Offset = "0x1CBEC50", VA = "0x1CBEC50")]
		public CSRankRewardItem GetRankRewardItem(RankType rankType, int tierID)
		{
			return null;
		}
	}
}
