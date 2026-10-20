using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000AAD")]
	public class CSProtoInfoManager_ClanBoxReward : Dictionary<int, List<CSClanBoxReward>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x34")]
		private List<KeyValuePair<int, CSClanBoxReward>> groupList;

		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x38")]
		private List<int> groupTrophySumTable;

		[Token(Token = "0x6004E9D")]
		[Address(RVA = "0x1FC20CC", Offset = "0x1FC20CC", VA = "0x1FC20CC")]
		public CSProtoInfoManager_ClanBoxReward()
		{
		}

		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x1FC8B54", Offset = "0x1FC8B54", VA = "0x1FC8B54", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E9F")]
		[Address(RVA = "0x1FC8B64", Offset = "0x1FC8B64", VA = "0x1FC8B64", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004EA0")]
		[Address(RVA = "0x1FC8B68", Offset = "0x1FC8B68", VA = "0x1FC8B68", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x1FC8EB0", Offset = "0x1FC8EB0", VA = "0x1FC8EB0", Slot = "45")]
		public virtual void LoadFromServer(JToken source)
		{
		}

		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x1FC8EB4", Offset = "0x1FC8EB4", VA = "0x1FC8EB4", Slot = "46")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x1FC94D4", Offset = "0x1FC94D4", VA = "0x1FC94D4")]
		public List<CSClanBoxReward> GetRewards(int score)
		{
			return null;
		}

		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x1FC95D0", Offset = "0x1FC95D0", VA = "0x1FC95D0")]
		public CSClanBoxReward GetRewardGroup(int score)
		{
			return null;
		}

		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x1FC973C", Offset = "0x1FC973C", VA = "0x1FC973C")]
		public CSClanBoxReward GetProgressGroup(int score)
		{
			return null;
		}

		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x1FC989C", Offset = "0x1FC989C", VA = "0x1FC989C")]
		public List<int> GetGroupTrophySumTable()
		{
			return null;
		}

		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x1FC98A4", Offset = "0x1FC98A4", VA = "0x1FC98A4")]
		public int GetGroupTrophyMaxScore()
		{
			return default(int);
		}

		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x1FC992C", Offset = "0x1FC992C", VA = "0x1FC992C")]
		public int GetGroupTrophyMinScore()
		{
			return default(int);
		}
	}
}
