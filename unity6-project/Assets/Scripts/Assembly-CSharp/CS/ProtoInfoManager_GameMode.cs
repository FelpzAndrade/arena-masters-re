using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AEB")]
	public class ProtoInfoManager_GameMode : Dictionary<XGameModeType, GameModeInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x600508E")]
		[Address(RVA = "0x21AEE90", Offset = "0x21AEE90", VA = "0x21AEE90")]
		public ProtoInfoManager_GameMode()
		{
		}

		[Token(Token = "0x600508F")]
		[Address(RVA = "0x21AEF14", Offset = "0x21AEF14", VA = "0x21AEF14", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005090")]
		[Address(RVA = "0x21AEF24", Offset = "0x21AEF24", VA = "0x21AEF24", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005091")]
		[Address(RVA = "0x21AEF28", Offset = "0x21AEF28", VA = "0x21AEF28", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005092")]
		[Address(RVA = "0x21AF1B0", Offset = "0x21AF1B0", VA = "0x21AF1B0", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005093")]
		[Address(RVA = "0x21AF6D0", Offset = "0x21AF6D0", VA = "0x21AF6D0")]
		public int GetGameModeMaxPlayer(XGameModeType nGameModeType, int defaultMaxPlayer = 6)
		{
			return default(int);
		}

		[Token(Token = "0x6005094")]
		[Address(RVA = "0x21AF79C", Offset = "0x21AF79C", VA = "0x21AF79C")]
		public string GetGameModeSpriteName(XGameModeType mode)
		{
			return null;
		}

		[Token(Token = "0x6005095")]
		[Address(RVA = "0x21AF9A4", Offset = "0x21AF9A4", VA = "0x21AF9A4")]
		public bool IsTwoTeamMode(XGameModeType mode)
		{
			return default(bool);
		}
	}
}
