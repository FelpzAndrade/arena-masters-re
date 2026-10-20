using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A84")]
	public class CSProtoInfoManager_Balance : Dictionary<int, CSBalanceInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004E0E")]
		[Address(RVA = "0x1FC1A04", Offset = "0x1FC1A04", VA = "0x1FC1A04")]
		public CSProtoInfoManager_Balance()
		{
		}

		[Token(Token = "0x6004E0F")]
		[Address(RVA = "0x1FC39E0", Offset = "0x1FC39E0", VA = "0x1FC39E0", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E10")]
		[Address(RVA = "0x1FC39F0", Offset = "0x1FC39F0", VA = "0x1FC39F0", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E11")]
		[Address(RVA = "0x1FC39F4", Offset = "0x1FC39F4", VA = "0x1FC39F4", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E12")]
		[Address(RVA = "0x1FC39FC", Offset = "0x1FC39FC", VA = "0x1FC39FC", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E13")]
		[Address(RVA = "0x1FC3EFC", Offset = "0x1FC3EFC", VA = "0x1FC3EFC")]
		public int CalcNeedNextLevelSoulStone(int curLv)
		{
			return default(int);
		}

		[Token(Token = "0x6004E14")]
		[Address(RVA = "0x1FC3FC4", Offset = "0x1FC3FC4", VA = "0x1FC3FC4")]
		public int CalcNeedNextLevelGold(int curLv)
		{
			return default(int);
		}

		[Token(Token = "0x6004E15")]
		[Address(RVA = "0x1FC408C", Offset = "0x1FC408C", VA = "0x1FC408C")]
		public int GetLevelUpSkillPoint(int curLv, int afterv)
		{
			return default(int);
		}
	}
}
