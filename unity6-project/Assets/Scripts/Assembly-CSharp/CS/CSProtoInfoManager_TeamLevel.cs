using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B7B")]
	public class CSProtoInfoManager_TeamLevel : Dictionary<int, CSTeamLevelInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003A14")]
		[FieldOffset(Offset = "0x0")]
		public static int MaxLevel;

		[Token(Token = "0x4003A15")]
		[FieldOffset(Offset = "0x34")]
		public List<int> ExpTable;

		[Token(Token = "0x600533E")]
		[Address(RVA = "0x1CC6AF4", Offset = "0x1CC6AF4", VA = "0x1CC6AF4")]
		public CSProtoInfoManager_TeamLevel()
		{
		}

		[Token(Token = "0x6005340")]
		[Address(RVA = "0x1CC6C30", Offset = "0x1CC6C30", VA = "0x1CC6C30", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005341")]
		[Address(RVA = "0x1CC6C40", Offset = "0x1CC6C40", VA = "0x1CC6C40")]
		public bool CookingExpTable()
		{
			return default(bool);
		}

		[Token(Token = "0x6005342")]
		[Address(RVA = "0x1CC6DB8", Offset = "0x1CC6DB8", VA = "0x1CC6DB8")]
		public int CalcLevel(int nXP)
		{
			return default(int);
		}

		[Token(Token = "0x6005343")]
		[Address(RVA = "0x1CC6EFC", Offset = "0x1CC6EFC", VA = "0x1CC6EFC")]
		public int CalcExpLimit(int level, int maxLevel)
		{
			return default(int);
		}

		[Token(Token = "0x6005344")]
		[Address(RVA = "0x1CC6F34", Offset = "0x1CC6F34", VA = "0x1CC6F34")]
		public int CalcNeedNextLevelExp(int level)
		{
			return default(int);
		}

		[Token(Token = "0x6005345")]
		[Address(RVA = "0x1CC7020", Offset = "0x1CC7020", VA = "0x1CC7020")]
		public int CalcNeedExpOnCurLev(int level)
		{
			return default(int);
		}

		[Token(Token = "0x6005346")]
		[Address(RVA = "0x1CC70EC", Offset = "0x1CC70EC", VA = "0x1CC70EC")]
		public int CalcExpOnCurLev(int nXP)
		{
			return default(int);
		}

		[Token(Token = "0x6005347")]
		[Address(RVA = "0x1CC712C", Offset = "0x1CC712C", VA = "0x1CC712C")]
		public int MaxExp()
		{
			return default(int);
		}

		[Token(Token = "0x6005348")]
		[Address(RVA = "0x1CC71EC", Offset = "0x1CC71EC", VA = "0x1CC71EC")]
		public float CalcExpPercentage(int nXP)
		{
			return default(float);
		}

		[Token(Token = "0x6005349")]
		[Address(RVA = "0x1CC7364", Offset = "0x1CC7364", VA = "0x1CC7364")]
		public int CalcMaxSTA(int level)
		{
			return default(int);
		}

		[Token(Token = "0x600534A")]
		[Address(RVA = "0x1CC7628", Offset = "0x1CC7628", VA = "0x1CC7628")]
		public int CalcMaxEnergy(int level)
		{
			return default(int);
		}

		[Token(Token = "0x600534B")]
		[Address(RVA = "0x1CC7500", Offset = "0x1CC7500", VA = "0x1CC7500")]
		public CSTeamLevelInfo GetInfo(int level)
		{
			return null;
		}

		[Token(Token = "0x600534C")]
		[Address(RVA = "0x1CC77C4", Offset = "0x1CC77C4", VA = "0x1CC77C4")]
		public int GetTeamLevelTalentPoint(int teamLevel)
		{
			return default(int);
		}

		[Token(Token = "0x600534D")]
		[Address(RVA = "0x1CC7968", Offset = "0x1CC7968", VA = "0x1CC7968", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x600534E")]
		[Address(RVA = "0x1CC796C", Offset = "0x1CC796C", VA = "0x1CC796C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x600534F")]
		[Address(RVA = "0x1CC7AB0", Offset = "0x1CC7AB0", VA = "0x1CC7AB0", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005350")]
		[Address(RVA = "0x1CC7E1C", Offset = "0x1CC7E1C", VA = "0x1CC7E1C")]
		private void _003CLoadFromLocalFile_003Em__213(CSTeamLevelInfo e)
		{
		}
	}
}
