using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B74")]
	public class CSProtoInfoManager_Stage : Dictionary<int, CSStageInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x40039FB")]
		[FieldOffset(Offset = "0x34")]
		public Dictionary<int, List<CSStageInfo>> missions;

		[Token(Token = "0x40039FC")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> missionClearIndice;

		[Token(Token = "0x40039FD")]
		[FieldOffset(Offset = "0x3C")]
		public Dictionary<int, List<CSStageInfo>> specials;

		[Token(Token = "0x40039FE")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<int, List<CSStageInfo>> skytowers;

		[Token(Token = "0x600531F")]
		[Address(RVA = "0x1CC4B74", Offset = "0x1CC4B74", VA = "0x1CC4B74")]
		public CSProtoInfoManager_Stage()
		{
		}

		[Token(Token = "0x6005320")]
		[Address(RVA = "0x1CC4C90", Offset = "0x1CC4C90", VA = "0x1CC4C90", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005321")]
		[Address(RVA = "0x1CC4CA0", Offset = "0x1CC4CA0", VA = "0x1CC4CA0", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005322")]
		[Address(RVA = "0x1CC4CA4", Offset = "0x1CC4CA4", VA = "0x1CC4CA4", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005323")]
		[Address(RVA = "0x1CC5BC0", Offset = "0x1CC5BC0", VA = "0x1CC5BC0")]
		public int GetOpenedStage(int clearedStageIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6005324")]
		[Address(RVA = "0x1CC5B8C", Offset = "0x1CC5B8C", VA = "0x1CC5B8C")]
		public Dictionary<int, List<CSStageInfo>> GetStagesByMode(CSStageGameModeType type)
		{
			return null;
		}

		[Token(Token = "0x6005325")]
		[Address(RVA = "0x1CC5C78", Offset = "0x1CC5C78", VA = "0x1CC5C78")]
		public Dictionary<int, List<CSStageInfo>> GetStagesByMode(XGameModeType type)
		{
			return null;
		}

		[Token(Token = "0x6005326")]
		[Address(RVA = "0x1CC5CAC", Offset = "0x1CC5CAC", VA = "0x1CC5CAC", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005327")]
		[Address(RVA = "0x1CC6088", Offset = "0x1CC6088", VA = "0x1CC6088")]
		public CSStageInfo GetInfo(int index)
		{
			return null;
		}

		[Token(Token = "0x6005328")]
		[Address(RVA = "0x1CC624C", Offset = "0x1CC624C", VA = "0x1CC624C")]
		public List<CSStageInfo> GetDefaultsInModeGroups(CSStageGameModeType type)
		{
			return null;
		}

		[Token(Token = "0x6005329")]
		[Address(RVA = "0x1CC64D8", Offset = "0x1CC64D8", VA = "0x1CC64D8")]
		public CSStageInfo GetDefaultInModeGroups(CSStageGameModeType type, int group)
		{
			return null;
		}

		[Token(Token = "0x600532A")]
		[Address(RVA = "0x1CC6728", Offset = "0x1CC6728", VA = "0x1CC6728")]
		public CSStageInfo GetDefault(XGameModeType type)
		{
			return null;
		}

		[Token(Token = "0x600532B")]
		[Address(RVA = "0x1CC65C4", Offset = "0x1CC65C4", VA = "0x1CC65C4")]
		public List<CSStageInfo> GetListInModeGroups(CSStageGameModeType type, int group)
		{
			return null;
		}

		[Token(Token = "0x600532C")]
		[Address(RVA = "0x1CC689C", Offset = "0x1CC689C", VA = "0x1CC689C")]
		public int GetMissionTotalStar(int group)
		{
			return default(int);
		}

		[Token(Token = "0x600532D")]
		[Address(RVA = "0x1CC69A4", Offset = "0x1CC69A4", VA = "0x1CC69A4")]
		public CSStageInfo GetFirstStage(CSStageGameModeType type)
		{
			return null;
		}
	}
}
