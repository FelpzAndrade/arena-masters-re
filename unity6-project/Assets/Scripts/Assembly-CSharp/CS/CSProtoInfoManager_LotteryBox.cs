using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B11")]
	public class CSProtoInfoManager_LotteryBox : Dictionary<int, CSLotteryBox>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x600514D")]
		[Address(RVA = "0x1CB6330", Offset = "0x1CB6330", VA = "0x1CB6330")]
		public CSProtoInfoManager_LotteryBox()
		{
		}

		[Token(Token = "0x600514E")]
		[Address(RVA = "0x1CB63B4", Offset = "0x1CB63B4", VA = "0x1CB63B4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x600514F")]
		[Address(RVA = "0x1CB63C4", Offset = "0x1CB63C4", VA = "0x1CB63C4", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005150")]
		[Address(RVA = "0x1CB63C8", Offset = "0x1CB63C8", VA = "0x1CB63C8", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005151")]
		[Address(RVA = "0x1CB63D0", Offset = "0x1CB63D0", VA = "0x1CB63D0", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005152")]
		[Address(RVA = "0x1CB69CC", Offset = "0x1CB69CC", VA = "0x1CB69CC")]
		public CSLotteryBox GetInfo(int id)
		{
			return null;
		}
	}
}
