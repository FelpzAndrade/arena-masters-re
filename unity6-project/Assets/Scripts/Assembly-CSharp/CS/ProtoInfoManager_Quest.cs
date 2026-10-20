using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B34")]
	public class ProtoInfoManager_Quest : Dictionary<int, QuestInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x400378C")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<int, List<int>> clearGroupCache;

		[Token(Token = "0x400378D")]
		[FieldOffset(Offset = "0x38")]
		public List<int> noneAchievementCache;

		[Token(Token = "0x600520F")]
		[Address(RVA = "0x21B1878", Offset = "0x21B1878", VA = "0x21B1878")]
		public ProtoInfoManager_Quest()
		{
		}

		[Token(Token = "0x6005210")]
		[Address(RVA = "0x21B1964", Offset = "0x21B1964", VA = "0x21B1964", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005211")]
		[Address(RVA = "0x21B1974", Offset = "0x21B1974", VA = "0x21B1974", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005212")]
		[Address(RVA = "0x21B1978", Offset = "0x21B1978", VA = "0x21B1978", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005213")]
		[Address(RVA = "0x21B2170", Offset = "0x21B2170", VA = "0x21B2170")]
		public List<int> GetClearGroup(int groupUID)
		{
			return null;
		}

		[Token(Token = "0x6005214")]
		[Address(RVA = "0x21B2290", Offset = "0x21B2290", VA = "0x21B2290", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}
	}
}
