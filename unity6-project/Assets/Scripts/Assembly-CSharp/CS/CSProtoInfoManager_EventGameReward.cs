using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AD3")]
	public class CSProtoInfoManager_EventGameReward : Dictionary<int, EventGameRewardGroup>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004F55")]
		[Address(RVA = "0x1FC230C", Offset = "0x1FC230C", VA = "0x1FC230C")]
		public CSProtoInfoManager_EventGameReward()
		{
		}

		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x1FD0D88", Offset = "0x1FD0D88", VA = "0x1FD0D88", Slot = "41")]
		public bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x1FD0D90", Offset = "0x1FD0D90", VA = "0x1FD0D90", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x1FD0DA0", Offset = "0x1FD0DA0", VA = "0x1FD0DA0", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x1FD1114", Offset = "0x1FD1114", VA = "0x1FD1114", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}
	}
}
