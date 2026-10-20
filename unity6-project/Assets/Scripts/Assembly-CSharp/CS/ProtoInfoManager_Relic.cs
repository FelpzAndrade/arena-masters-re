using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B40")]
	public class ProtoInfoManager_Relic : Dictionary<int, List<RelicInfo>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x600523A")]
		[Address(RVA = "0x21B276C", Offset = "0x21B276C", VA = "0x21B276C")]
		public ProtoInfoManager_Relic()
		{
		}

		[Token(Token = "0x600523B")]
		[Address(RVA = "0x21B27F0", Offset = "0x21B27F0", VA = "0x21B27F0", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x600523C")]
		[Address(RVA = "0x21B2800", Offset = "0x21B2800", VA = "0x21B2800", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x600523D")]
		[Address(RVA = "0x21B2804", Offset = "0x21B2804", VA = "0x21B2804", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x600523E")]
		[Address(RVA = "0x21B2B9C", Offset = "0x21B2B9C", VA = "0x21B2B9C", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x600523F")]
		[Address(RVA = "0x21B31C4", Offset = "0x21B31C4", VA = "0x21B31C4")]
		public RelicInfo FindRelicInfoBy(int relicId, int relicLevel)
		{
			return null;
		}

		[Token(Token = "0x6005240")]
		[Address(RVA = "0x21B3384", Offset = "0x21B3384", VA = "0x21B3384")]
		public RelicInfo FindNextRelicInfoBy(int id, int level)
		{
			return null;
		}

		[Token(Token = "0x6005241")]
		[Address(RVA = "0x21B338C", Offset = "0x21B338C", VA = "0x21B338C")]
		public List<RelicInfo> GetRelicInfoBy()
		{
			return null;
		}

		[Token(Token = "0x6005242")]
		[Address(RVA = "0x21B35DC", Offset = "0x21B35DC", VA = "0x21B35DC")]
		public int GetRelicIDByPieceID(int relicPieceID)
		{
			return default(int);
		}

		[Token(Token = "0x6005243")]
		[Address(RVA = "0x21B3838", Offset = "0x21B3838", VA = "0x21B3838")]
		public int GetRelicMaxLevel(int relicId)
		{
			return default(int);
		}
	}
}
