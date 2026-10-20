using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B2A")]
	public class CSProtoInfoManager_PvpReward : Dictionary<int, List<CSPvpRewardInfo>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000B2B")]
		private struct TeamLevelRange
		{
			[Token(Token = "0x4003706")]
			[FieldOffset(Offset = "0x0")]
			public int min;

			[Token(Token = "0x4003707")]
			[FieldOffset(Offset = "0x4")]
			public int max;
		}

		[Token(Token = "0x4003705")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<int, TeamLevelRange> teamLevelRangeDictionary;

		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x1CBAA3C", Offset = "0x1CBAA3C", VA = "0x1CBAA3C")]
		public CSProtoInfoManager_PvpReward()
		{
		}

		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x1CBAAF4", Offset = "0x1CBAAF4", VA = "0x1CBAAF4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005200")]
		[Address(RVA = "0x1CBAB04", Offset = "0x1CBAB04", VA = "0x1CBAB04", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005201")]
		[Address(RVA = "0x1CBAB08", Offset = "0x1CBAB08", VA = "0x1CBAB08", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005202")]
		[Address(RVA = "0x1CBB298", Offset = "0x1CBB298", VA = "0x1CBB298", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005203")]
		[Address(RVA = "0x1CBB8A4", Offset = "0x1CBB8A4", VA = "0x1CBB8A4")]
		public List<CSPvpRewardInfo> GetList(int groupID)
		{
			return null;
		}

		[Token(Token = "0x6005204")]
		[Address(RVA = "0x1CBB948", Offset = "0x1CBB948", VA = "0x1CBB948")]
		public int GetCurrentRewardGroupID(int teamLevel)
		{
			return default(int);
		}

		[Token(Token = "0x6005205")]
		[Address(RVA = "0x1CBBC34", Offset = "0x1CBBC34", VA = "0x1CBBC34")]
		public int GetMinTeamLevel(int groupID)
		{
			return default(int);
		}

		[Token(Token = "0x6005206")]
		[Address(RVA = "0x1CBBCF8", Offset = "0x1CBBCF8", VA = "0x1CBBCF8")]
		public int GetMaxGroupID()
		{
			return default(int);
		}

		[Token(Token = "0x6005207")]
		[Address(RVA = "0x1CBBFB4", Offset = "0x1CBBFB4", VA = "0x1CBBFB4")]
		public CSPvpRewardInfo GetCurrentReward(int groupID, int ClearCount)
		{
			return null;
		}

		[Token(Token = "0x6005208")]
		[Address(RVA = "0x1CBC09C", Offset = "0x1CBC09C", VA = "0x1CBC09C")]
		public CSPvpRewardInfo GetFirstReward(int groupID)
		{
			return null;
		}
	}
}
