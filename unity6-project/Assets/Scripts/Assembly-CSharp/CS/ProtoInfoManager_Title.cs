using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B82")]
	public class ProtoInfoManager_Title : Dictionary<int, TitleInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003A28")]
		[FieldOffset(Offset = "0x0")]
		private static Func<TitleInfo, int> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6005361")]
		[Address(RVA = "0x21B8CE4", Offset = "0x21B8CE4", VA = "0x21B8CE4")]
		public ProtoInfoManager_Title()
		{
		}

		[Token(Token = "0x6005362")]
		[Address(RVA = "0x21B8D68", Offset = "0x21B8D68", VA = "0x21B8D68", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005363")]
		[Address(RVA = "0x21B8D78", Offset = "0x21B8D78", VA = "0x21B8D78", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005364")]
		[Address(RVA = "0x21B8D7C", Offset = "0x21B8D7C", VA = "0x21B8D7C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005365")]
		[Address(RVA = "0x21B8D84", Offset = "0x21B8D84", VA = "0x21B8D84", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005366")]
		[Address(RVA = "0x21B926C", Offset = "0x21B926C", VA = "0x21B926C")]
		public bool IsExist(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6005367")]
		[Address(RVA = "0x21B92F8", Offset = "0x21B92F8", VA = "0x21B92F8")]
		public TitleInfo Find(int id)
		{
			return null;
		}

		[Token(Token = "0x6005368")]
		[Address(RVA = "0x21B95B4", Offset = "0x21B95B4", VA = "0x21B95B4")]
		public List<TitleInfo> ExportToList()
		{
			return null;
		}

		[Token(Token = "0x6005369")]
		[Address(RVA = "0x21B975C", Offset = "0x21B975C", VA = "0x21B975C")]
		public List<TitleInfo> ExportToSortedList()
		{
			return null;
		}

		[Token(Token = "0x600536A")]
		[Address(RVA = "0x21B99E0", Offset = "0x21B99E0", VA = "0x21B99E0")]
		private static int _003CExportToSortedList_003Em__214(TitleInfo x)
		{
			return default(int);
		}
	}
}
