using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B87")]
	public class CSProtoInfoManager_TrophyReward : Dictionary<int, CSTrophyReward>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003A49")]
		[FieldOffset(Offset = "0x34")]
		public List<int> TierTable;

		[Token(Token = "0x4003A4A")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<TierRank, TierTableInfo> TierTableInfoDictionary;

		[Token(Token = "0x6005370")]
		[Address(RVA = "0x1CC87F8", Offset = "0x1CC87F8", VA = "0x1CC87F8")]
		public CSProtoInfoManager_TrophyReward()
		{
		}

		[Token(Token = "0x6005371")]
		[Address(RVA = "0x1CC88E4", Offset = "0x1CC88E4", VA = "0x1CC88E4")]
		public void CookingTierTable()
		{
		}

		[Token(Token = "0x6005372")]
		[Address(RVA = "0x1CC8AE8", Offset = "0x1CC8AE8", VA = "0x1CC8AE8")]
		private void CookingTierTableInfo(CSTrophyReward thisVal)
		{
		}

		[Token(Token = "0x6005373")]
		[Address(RVA = "0x1CC8D48", Offset = "0x1CC8D48", VA = "0x1CC8D48", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005374")]
		[Address(RVA = "0x1CC8D58", Offset = "0x1CC8D58", VA = "0x1CC8D58", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005375")]
		[Address(RVA = "0x1CC8D5C", Offset = "0x1CC8D5C", VA = "0x1CC8D5C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005376")]
		[Address(RVA = "0x1CC8D70", Offset = "0x1CC8D70", VA = "0x1CC8D70", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005377")]
		[Address(RVA = "0x1CC937C", Offset = "0x1CC937C", VA = "0x1CC937C")]
		public CSTrophyReward GetTrophyReward(int elo, bool isRookie)
		{
			return null;
		}

		[Token(Token = "0x6005378")]
		[Address(RVA = "0x1CC95BC", Offset = "0x1CC95BC", VA = "0x1CC95BC")]
		public TierRank GetTier(int elo)
		{
			return default(TierRank);
		}

		[Token(Token = "0x6005379")]
		[Address(RVA = "0x1CC97DC", Offset = "0x1CC97DC", VA = "0x1CC97DC")]
		public CSTrophyReward GetReward(int id)
		{
			return null;
		}
	}
}
