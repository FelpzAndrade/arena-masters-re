using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B7F")]
	public class CSProtoInfoManager_TimeInterval : Dictionary<string, CSTimeInterval>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6005356")]
		[Address(RVA = "0x1CC7EC0", Offset = "0x1CC7EC0", VA = "0x1CC7EC0")]
		public CSProtoInfoManager_TimeInterval()
		{
		}

		[Token(Token = "0x6005357")]
		[Address(RVA = "0x1CC7F44", Offset = "0x1CC7F44", VA = "0x1CC7F44", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005358")]
		[Address(RVA = "0x1CC7F54", Offset = "0x1CC7F54", VA = "0x1CC7F54", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005359")]
		[Address(RVA = "0x1CC7F58", Offset = "0x1CC7F58", VA = "0x1CC7F58", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x600535A")]
		[Address(RVA = "0x1CC81C8", Offset = "0x1CC81C8", VA = "0x1CC81C8", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x600535B")]
		[Address(RVA = "0x1CC84E0", Offset = "0x1CC84E0", VA = "0x1CC84E0")]
		public CSTimeInterval GetTimeInterval(string strID)
		{
			return null;
		}

		[Token(Token = "0x600535C")]
		[Address(RVA = "0x1CC85A4", Offset = "0x1CC85A4", VA = "0x1CC85A4", Slot = "46")]
		public virtual void CookingList(List<CSTimeInterval> list)
		{
		}
	}
}
