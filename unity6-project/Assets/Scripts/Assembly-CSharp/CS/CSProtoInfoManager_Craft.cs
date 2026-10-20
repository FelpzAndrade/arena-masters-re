using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ABA")]
	public class CSProtoInfoManager_Craft : Dictionary<int, CraftInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003247")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<int, CraftInfo> _cacheByMaterial;

		[Token(Token = "0x6004ED8")]
		[Address(RVA = "0x1FC2390", Offset = "0x1FC2390", VA = "0x1FC2390")]
		public CSProtoInfoManager_Craft()
		{
		}

		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x1FCBB30", Offset = "0x1FCBB30", VA = "0x1FCBB30")]
		public new void Clear()
		{
		}

		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x1FCBBE4", Offset = "0x1FCBBE4", VA = "0x1FCBBE4", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x1FCC078", Offset = "0x1FCC078", VA = "0x1FCC078")]
		public CraftInfo GetCraftByMaterialId(int MaterialId)
		{
			return null;
		}

		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x1FCC130", Offset = "0x1FCC130", VA = "0x1FCC130", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EDD")]
		[Address(RVA = "0x1FCC140", Offset = "0x1FCC140", VA = "0x1FCC140", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x1FCC418", Offset = "0x1FCC418", VA = "0x1FCC418")]
		public void CookingList(List<CraftInfo> dataList)
		{
		}

		[Token(Token = "0x6004EDF")]
		[Address(RVA = "0x1FCC52C", Offset = "0x1FCC52C", VA = "0x1FCC52C", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}
	}
}
