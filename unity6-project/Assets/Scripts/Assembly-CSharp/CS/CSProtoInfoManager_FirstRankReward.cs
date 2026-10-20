using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AD9")]
	public class CSProtoInfoManager_FirstRankReward : Dictionary<int, CSFirstRankReward>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x40032F5")]
		[FieldOffset(Offset = "0x34")]
		private List<CSFirstRankReward> duelFirstRankReward;

		[Token(Token = "0x40032F6")]
		[FieldOffset(Offset = "0x38")]
		private List<CSFirstRankReward> teamFirstRankReward;

		[Token(Token = "0x6004F6B")]
		[Address(RVA = "0x1FC1FFC", Offset = "0x1FC1FFC", VA = "0x1FC1FFC")]
		public CSProtoInfoManager_FirstRankReward()
		{
		}

		[Token(Token = "0x6004F6C")]
		[Address(RVA = "0x1FD1118", Offset = "0x1FD1118", VA = "0x1FD1118", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F6D")]
		[Address(RVA = "0x1FD1128", Offset = "0x1FD1128", VA = "0x1FD1128", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004F6E")]
		[Address(RVA = "0x1FD112C", Offset = "0x1FD112C", VA = "0x1FD112C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F6F")]
		[Address(RVA = "0x1FD1134", Offset = "0x1FD1134", VA = "0x1FD1134", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F70")]
		[Address(RVA = "0x1FD16F8", Offset = "0x1FD16F8", VA = "0x1FD16F8")]
		public List<CSFirstRankReward> GetFirstRankRewardList(RankType rankType)
		{
			return null;
		}

		[Token(Token = "0x6004F71")]
		[Address(RVA = "0x1FD171C", Offset = "0x1FD171C", VA = "0x1FD171C")]
		public CSFirstRankReward GetFirstRankRewardItemInfo_ByID(RankType rankType, int ID)
		{
			return null;
		}

		[Token(Token = "0x6004F72")]
		[Address(RVA = "0x1FD1864", Offset = "0x1FD1864", VA = "0x1FD1864")]
		public CSFirstRankReward GetFirstRankRewardItemInfo(RankType rankType, int elo)
		{
			return null;
		}

		[Token(Token = "0x6004F73")]
		[Address(RVA = "0x1FD19E4", Offset = "0x1FD19E4", VA = "0x1FD19E4")]
		public int GetNextFirstRankRewardNeedScore(RankType rankType, int elo)
		{
			return default(int);
		}
	}
}
