using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B03")]
	public class CSProtoInfoManager_Item : Dictionary<int, CSItemInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x400363B")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<string, FusionDescription> fusionDescTable;

		[Token(Token = "0x6005111")]
		[Address(RVA = "0x1CB17C4", Offset = "0x1CB17C4", VA = "0x1CB17C4")]
		public CSProtoInfoManager_Item()
		{
		}

		[Token(Token = "0x6005112")]
		[Address(RVA = "0x1CB1874", Offset = "0x1CB1874", VA = "0x1CB1874", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005113")]
		[Address(RVA = "0x1CB1878", Offset = "0x1CB1878", VA = "0x1CB1878", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005114")]
		[Address(RVA = "0x1CB1888", Offset = "0x1CB1888", VA = "0x1CB1888", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005115")]
		[Address(RVA = "0x1CB1BA0", Offset = "0x1CB1BA0", VA = "0x1CB1BA0")]
		private bool CookItemPassiveSkillInfo(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005116")]
		[Address(RVA = "0x1CB1D98", Offset = "0x1CB1D98", VA = "0x1CB1D98", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005117")]
		[Address(RVA = "0x1CB1AA8", Offset = "0x1CB1AA8", VA = "0x1CB1AA8")]
		protected void AddFusionDesc(CSItemInfo itemInfo, CSProtoInfoManager_GameConst gameConst)
		{
		}

		[Token(Token = "0x6005118")]
		[Address(RVA = "0x1CB22D4", Offset = "0x1CB22D4", VA = "0x1CB22D4")]
		private void AddFusionDesc(CSProtoInfoManager_GameConst gameConst, EquipmentSlot slotType, ItemRarity fusionTargetRarityType, int id, float fusionRatio)
		{
		}

		[Token(Token = "0x6005119")]
		[Address(RVA = "0x1CB2620", Offset = "0x1CB2620", VA = "0x1CB2620")]
		public int FindSoulStoneItemID(int nCharID)
		{
			return default(int);
		}

		[Token(Token = "0x600511A")]
		[Address(RVA = "0x1CB292C", Offset = "0x1CB292C", VA = "0x1CB292C")]
		public CSItemInfo FindSoulStoneItemInfo(int nCharID)
		{
			return null;
		}

		[Token(Token = "0x600511B")]
		[Address(RVA = "0x1CB2AAC", Offset = "0x1CB2AAC", VA = "0x1CB2AAC")]
		public int FindSoulDustItemID(int nPetID)
		{
			return default(int);
		}

		[Token(Token = "0x600511C")]
		[Address(RVA = "0x1CB2DB8", Offset = "0x1CB2DB8", VA = "0x1CB2DB8")]
		public CSItemInfo GetInfo(int id)
		{
			return null;
		}

		[Token(Token = "0x600511D")]
		[Address(RVA = "0x1CB2474", Offset = "0x1CB2474", VA = "0x1CB2474")]
		private string GetFusionKey(EquipmentSlot slotType, ItemRarity rarityType)
		{
			return null;
		}

		[Token(Token = "0x600511E")]
		[Address(RVA = "0x1CB2E64", Offset = "0x1CB2E64", VA = "0x1CB2E64")]
		public FusionDescription GetFusionDesc(EquipmentSlot slotType, ItemRarity rarityType)
		{
			return null;
		}

		[Token(Token = "0x600511F")]
		[Address(RVA = "0x1CB2F34", Offset = "0x1CB2F34", VA = "0x1CB2F34")]
		public CSItemInfo GetNextRarityItem(CSItemInfo item)
		{
			return null;
		}
	}
}
