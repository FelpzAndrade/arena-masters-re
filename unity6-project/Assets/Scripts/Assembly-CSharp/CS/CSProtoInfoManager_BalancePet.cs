using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A87")]
	public class CSProtoInfoManager_BalancePet : Dictionary<int, CSBalancePetInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x1FC21B8", Offset = "0x1FC21B8", VA = "0x1FC21B8")]
		public CSProtoInfoManager_BalancePet()
		{
		}

		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x1FC41C4", Offset = "0x1FC41C4", VA = "0x1FC41C4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x1FC41D4", Offset = "0x1FC41D4", VA = "0x1FC41D4", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x1FC41D8", Offset = "0x1FC41D8", VA = "0x1FC41D8", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x1FC41E0", Offset = "0x1FC41E0", VA = "0x1FC41E0", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x1FC4624", Offset = "0x1FC4624", VA = "0x1FC4624")]
		public int CalcNeedNextLevelSoulDust(int curLv)
		{
			return default(int);
		}

		[Token(Token = "0x6004E1F")]
		[Address(RVA = "0x1FC46EC", Offset = "0x1FC46EC", VA = "0x1FC46EC")]
		public int CalcNeedNextLevelGold(int curLv)
		{
			return default(int);
		}
	}
}
