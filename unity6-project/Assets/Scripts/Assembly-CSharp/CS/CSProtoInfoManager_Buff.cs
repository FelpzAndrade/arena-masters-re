using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A95")]
	public class CSProtoInfoManager_Buff : Dictionary<int, CSBuffInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004E33")]
		[Address(RVA = "0x1FC1450", Offset = "0x1FC1450", VA = "0x1FC1450")]
		public CSProtoInfoManager_Buff()
		{
		}

		[Token(Token = "0x6004E34")]
		[Address(RVA = "0x1FC47B4", Offset = "0x1FC47B4", VA = "0x1FC47B4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E35")]
		[Address(RVA = "0x1FC47C4", Offset = "0x1FC47C4", VA = "0x1FC47C4", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E36")]
		[Address(RVA = "0x1FC47C8", Offset = "0x1FC47C8", VA = "0x1FC47C8", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x1FC4924", Offset = "0x1FC4924", VA = "0x1FC4924", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E38")]
		[Address(RVA = "0x1FC4CE0", Offset = "0x1FC4CE0", VA = "0x1FC4CE0")]
		private void _003CLoadFromLocalFile_003Em__A0(CSBuffInfo e)
		{
		}
	}
}
