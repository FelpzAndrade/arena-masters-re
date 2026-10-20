using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B0A")]
	public class CSProtoInfoManager_ItemDictionary : Dictionary<int, CSItemDictionaryInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6005135")]
		[Address(RVA = "0x1CB44A4", Offset = "0x1CB44A4", VA = "0x1CB44A4")]
		public CSProtoInfoManager_ItemDictionary()
		{
		}

		[Token(Token = "0x6005136")]
		[Address(RVA = "0x1CB4528", Offset = "0x1CB4528", VA = "0x1CB4528", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005137")]
		[Address(RVA = "0x1CB4538", Offset = "0x1CB4538", VA = "0x1CB4538", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005138")]
		[Address(RVA = "0x1CB453C", Offset = "0x1CB453C", VA = "0x1CB453C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005139")]
		[Address(RVA = "0x1CB47C4", Offset = "0x1CB47C4", VA = "0x1CB47C4", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}
	}
}
