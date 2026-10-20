using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B0D")]
	public class CSProtoInfoManager_ItemSet : Dictionary<int, ItemSetInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x600513E")]
		[Address(RVA = "0x1CB4E2C", Offset = "0x1CB4E2C", VA = "0x1CB4E2C")]
		public CSProtoInfoManager_ItemSet()
		{
		}

		[Token(Token = "0x600513F")]
		[Address(RVA = "0x1CB4EB0", Offset = "0x1CB4EB0", VA = "0x1CB4EB0", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005140")]
		[Address(RVA = "0x1CB4EC0", Offset = "0x1CB4EC0", VA = "0x1CB4EC0", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005141")]
		[Address(RVA = "0x1CB4EC4", Offset = "0x1CB4EC4", VA = "0x1CB4EC4", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005142")]
		[Address(RVA = "0x1CB5E74", Offset = "0x1CB5E74", VA = "0x1CB5E74", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005143")]
		[Address(RVA = "0x1CB61E0", Offset = "0x1CB61E0", VA = "0x1CB61E0")]
		public ItemSetInfo GetInfo(int id)
		{
			return null;
		}

		[Token(Token = "0x6005144")]
		[Address(RVA = "0x1CB628C", Offset = "0x1CB628C", VA = "0x1CB628C")]
		private void _003CLoadFromLocalFile_003Em__208(ItemSetInfo e)
		{
		}
	}
}
