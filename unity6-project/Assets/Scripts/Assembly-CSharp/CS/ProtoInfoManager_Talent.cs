using System.Collections.Generic;
using CS.Collection;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B78")]
	public class ProtoInfoManager_Talent : multi_sorted_dictionary<int, TalentInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6005331")]
		[Address(RVA = "0x21B7E3C", Offset = "0x21B7E3C", VA = "0x21B7E3C")]
		public ProtoInfoManager_Talent()
		{
		}

		[Token(Token = "0x6005332")]
		[Address(RVA = "0x21B7EC0", Offset = "0x21B7EC0", VA = "0x21B7EC0", Slot = "36")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005333")]
		[Address(RVA = "0x21B7ED0", Offset = "0x21B7ED0", VA = "0x21B7ED0", Slot = "38")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005334")]
		[Address(RVA = "0x21B7ED4", Offset = "0x21B7ED4", VA = "0x21B7ED4", Slot = "40")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005335")]
		[Address(RVA = "0x21B7EDC", Offset = "0x21B7EDC", VA = "0x21B7EDC", Slot = "41")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005336")]
		[Address(RVA = "0x21B8394", Offset = "0x21B8394", VA = "0x21B8394")]
		public List<TalentInfo> GetTalentInfoListBy(int index)
		{
			return null;
		}

		[Token(Token = "0x6005337")]
		[Address(RVA = "0x21B85E4", Offset = "0x21B85E4", VA = "0x21B85E4")]
		public TalentInfo GetTalentInfo(int id, int level)
		{
			return null;
		}

		[Token(Token = "0x6005338")]
		[Address(RVA = "0x21B8840", Offset = "0x21B8840", VA = "0x21B8840")]
		public int GetTalentMaxLevel(int id)
		{
			return default(int);
		}

		[Token(Token = "0x6005339")]
		[Address(RVA = "0x21B8A8C", Offset = "0x21B8A8C", VA = "0x21B8A8C")]
		public TalentInfo GetNextTalentInfo(int id, int level)
		{
			return null;
		}

		[Token(Token = "0x600533A")]
		[Address(RVA = "0x21B8A94", Offset = "0x21B8A94", VA = "0x21B8A94")]
		public List<TalentInfo> GetPassiveTalentInfo()
		{
			return null;
		}
	}
}
