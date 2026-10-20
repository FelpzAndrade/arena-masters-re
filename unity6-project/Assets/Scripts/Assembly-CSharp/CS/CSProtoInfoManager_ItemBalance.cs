using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B07")]
	public class CSProtoInfoManager_ItemBalance : Dictionary<ItemRarity, ItemBalanceInfoRarity>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6005125")]
		[Address(RVA = "0x1CB2FF8", Offset = "0x1CB2FF8", VA = "0x1CB2FF8")]
		public CSProtoInfoManager_ItemBalance()
		{
		}

		[Token(Token = "0x6005126")]
		[Address(RVA = "0x1CB307C", Offset = "0x1CB307C", VA = "0x1CB307C", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005127")]
		[Address(RVA = "0x1CB308C", Offset = "0x1CB308C", VA = "0x1CB308C", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005128")]
		[Address(RVA = "0x1CB3090", Offset = "0x1CB3090", VA = "0x1CB3090", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005129")]
		[Address(RVA = "0x1CB3098", Offset = "0x1CB3098", VA = "0x1CB3098", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x600512A")]
		[Address(RVA = "0x1CB3418", Offset = "0x1CB3418", VA = "0x1CB3418")]
		protected void AddItemBalanceRarity(CSItemBalanceInfo itemBalanceInfo)
		{
		}

		[Token(Token = "0x600512B")]
		[Address(RVA = "0x1CB34C0", Offset = "0x1CB34C0", VA = "0x1CB34C0")]
		private void InputData(ItemRarity rarity, float ratio, int iXP)
		{
		}

		[Token(Token = "0x600512C")]
		[Address(RVA = "0x1CB37C4", Offset = "0x1CB37C4", VA = "0x1CB37C4")]
		public int CalcItemLevel(ItemRarity itemRarity, int itemXP, List<int> randomOptionList, CSProtoInfoManager_GameConst gameConst)
		{
			return default(int);
		}

		[Token(Token = "0x600512D")]
		[Address(RVA = "0x1CB3E98", Offset = "0x1CB3E98", VA = "0x1CB3E98")]
		public int CalcNeedItemExp(ItemRarity itemRarity, int level)
		{
			return default(int);
		}

		[Token(Token = "0x600512E")]
		[Address(RVA = "0x1CB40DC", Offset = "0x1CB40DC", VA = "0x1CB40DC")]
		public int GetMaxRarityLevel(ItemRarity itemRarity, List<int> randomOptionList, CSProtoInfoManager_GameConst gameConst)
		{
			return default(int);
		}

		[Token(Token = "0x600512F")]
		[Address(RVA = "0x1CB3AD4", Offset = "0x1CB3AD4", VA = "0x1CB3AD4")]
		public int GetMaxRarityEXP(ItemRarity itemRarity, List<int> randomOptionList, CSProtoInfoManager_GameConst gameConst)
		{
			return default(int);
		}

		[Token(Token = "0x6005130")]
		[Address(RVA = "0x1CB4108", Offset = "0x1CB4108", VA = "0x1CB4108")]
		public float GetItemPerformanceRatio(ItemRarity itemRarity, int lev)
		{
			return default(float);
		}
	}
}
