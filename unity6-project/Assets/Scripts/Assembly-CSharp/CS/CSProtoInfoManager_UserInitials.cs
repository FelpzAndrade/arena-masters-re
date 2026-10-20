using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B8F")]
	public class CSProtoInfoManager_UserInitials : Dictionary<string, UserIntialsProperty>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003A78")]
		[FieldOffset(Offset = "0x34")]
		public Dictionary<int, int> OnRegistInventoryItemsSource;

		[Token(Token = "0x4003A79")]
		[FieldOffset(Offset = "0x38")]
		public List<CSContent> OnRegistInventoryItems;

		[Token(Token = "0x6005392")]
		[Address(RVA = "0x1CCA868", Offset = "0x1CCA868", VA = "0x1CCA868")]
		public CSProtoInfoManager_UserInitials()
		{
		}

		[Token(Token = "0x6005393")]
		[Address(RVA = "0x1CCA954", Offset = "0x1CCA954", VA = "0x1CCA954", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005394")]
		[Address(RVA = "0x1CCA964", Offset = "0x1CCA964", VA = "0x1CCA964", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005395")]
		[Address(RVA = "0x1CCA968", Offset = "0x1CCA968", VA = "0x1CCA968", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005396")]
		[Address(RVA = "0x1CCAEC0", Offset = "0x1CCAEC0", VA = "0x1CCAEC0")]
		public void OnRegistInventoryItemsInit(CSProtoInfoManager_Item proto)
		{
		}

		[Token(Token = "0x6005397")]
		[Address(RVA = "0x1CCB42C", Offset = "0x1CCB42C", VA = "0x1CCB42C", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005398")]
		[Address(RVA = "0x1CCB8BC", Offset = "0x1CCB8BC", VA = "0x1CCB8BC")]
		public bool TryGetDefaultItems(int charID, out string strList)
		{
			strList = default;
			return default(bool);
		}
	}
}
