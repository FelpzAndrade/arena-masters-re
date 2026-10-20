using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AB1")]
	public class CSProtoInfoManager_ClanRankReward : Dictionary<ClanRankType, List<ClanRankRewardItem>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000AB2")]
		private class RankEntry
		{
			[Token(Token = "0x4003232")]
			[FieldOffset(Offset = "0x8")]
			public int rank;

			[Token(Token = "0x4003233")]
			[FieldOffset(Offset = "0xC")]
			public ClanRankRewardItem item;

			[Token(Token = "0x6004EB8")]
			[Address(RVA = "0x1FCA340", Offset = "0x1FCA340", VA = "0x1FCA340")]
			public RankEntry()
			{
			}
		}

		[Token(Token = "0x2000AB3")]
		private class PercentEntry
		{
			[Token(Token = "0x4003234")]
			[FieldOffset(Offset = "0x8")]
			public float percent;

			[Token(Token = "0x4003235")]
			[FieldOffset(Offset = "0xC")]
			public ClanRankRewardItem item;

			[Token(Token = "0x6004EB9")]
			[Address(RVA = "0x1FCA348", Offset = "0x1FCA348", VA = "0x1FCA348")]
			public PercentEntry()
			{
			}
		}

		[Token(Token = "0x2000AB4")]
		private sealed class _003CGetRankRewardItem_003Ec__AnonStorey153
		{
			[Token(Token = "0x4003236")]
			[FieldOffset(Offset = "0x8")]
			internal int tierID;

			[Token(Token = "0x6004EBA")]
			[Address(RVA = "0x1FCB0F4", Offset = "0x1FCB0F4", VA = "0x1FCB0F4")]
			public _003CGetRankRewardItem_003Ec__AnonStorey153()
			{
			}

			[Token(Token = "0x6004EBB")]
			[Address(RVA = "0x1FCB0FC", Offset = "0x1FCB0FC", VA = "0x1FCB0FC")]
			internal bool _003C_003Em__1FD(ClanRankRewardItem x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003230")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<ClanRankType, List<RankEntry>> m_rankList;

		[Token(Token = "0x4003231")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ClanRankType, List<PercentEntry>> m_percentList;

		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0x1FC1C14", Offset = "0x1FC1C14", VA = "0x1FC1C14")]
		public CSProtoInfoManager_ClanRankReward()
		{
		}

		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0x1FC99B4", Offset = "0x1FC99B4", VA = "0x1FC99B4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x1FC99C4", Offset = "0x1FC99C4", VA = "0x1FC99C4", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x1FC99C8", Offset = "0x1FC99C8", VA = "0x1FC99C8", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EB0")]
		[Address(RVA = "0x1FCA350", Offset = "0x1FCA350", VA = "0x1FCA350", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EB1")]
		[Address(RVA = "0x1FCA934", Offset = "0x1FCA934", VA = "0x1FCA934")]
		public string GetTierText(ClanRankType clanRankType, int rank, int totalRankersCount)
		{
			return null;
		}

		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x1FCA9D8", Offset = "0x1FCA9D8", VA = "0x1FCA9D8")]
		public string GetTierIcon(ClanRankType clanRankType, int rank, int totalRankersCount)
		{
			return null;
		}

		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x1FCA988", Offset = "0x1FCA988", VA = "0x1FCA988")]
		public ClanRankRewardItem GetRankRewardItem(ClanRankType clanRankType, int rank, int totalRankerCount)
		{
			return null;
		}

		[Token(Token = "0x6004EB4")]
		[Address(RVA = "0x1FCAA2C", Offset = "0x1FCAA2C", VA = "0x1FCAA2C")]
		public ClanRankRewardItem GetRankRewardItem(ClanRankType clanRankType, int rank, float percent)
		{
			return null;
		}

		[Token(Token = "0x6004EB5")]
		[Address(RVA = "0x1FCABDC", Offset = "0x1FCABDC", VA = "0x1FCABDC")]
		private ClanRankRewardItem GetRankRewardItemWithRank(ClanRankType clanRankType, int rank)
		{
			return null;
		}

		[Token(Token = "0x6004EB6")]
		[Address(RVA = "0x1FCADB4", Offset = "0x1FCADB4", VA = "0x1FCADB4")]
		private ClanRankRewardItem GetRankRewardItemWithPercent(ClanRankType clanRankType, float percent)
		{
			return null;
		}

		[Token(Token = "0x6004EB7")]
		[Address(RVA = "0x1FCAF70", Offset = "0x1FCAF70", VA = "0x1FCAF70")]
		public ClanRankRewardItem GetRankRewardItem(ClanRankType clanRankType, int tierID)
		{
			return null;
		}
	}
}
