using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AC6")]
	public class CSProtoInfoManager_Event : Dictionary<int, CSEventInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004F10")]
		[Address(RVA = "0x1FC1B90", Offset = "0x1FC1B90", VA = "0x1FC1B90")]
		public CSProtoInfoManager_Event()
		{
		}

		[Token(Token = "0x6004F11")]
		[Address(RVA = "0x1FCCD58", Offset = "0x1FCCD58", VA = "0x1FCCD58", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x1FCCD68", Offset = "0x1FCCD68", VA = "0x1FCCD68", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004F13")]
		[Address(RVA = "0x1FCCD6C", Offset = "0x1FCCD6C", VA = "0x1FCCD6C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F14")]
		[Address(RVA = "0x1FCCFF4", Offset = "0x1FCCFF4", VA = "0x1FCCFF4", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F15")]
		[Address(RVA = "0x1FCD30C", Offset = "0x1FCD30C", VA = "0x1FCD30C")]
		public CSEventInfo GetEventInfo(int nID)
		{
			return null;
		}

		[Token(Token = "0x6004F16")]
		[Address(RVA = "0x1FCD3D0", Offset = "0x1FCD3D0", VA = "0x1FCD3D0", Slot = "46")]
		public virtual void CookingList(List<CSEventInfo> list)
		{
		}
	}
}
