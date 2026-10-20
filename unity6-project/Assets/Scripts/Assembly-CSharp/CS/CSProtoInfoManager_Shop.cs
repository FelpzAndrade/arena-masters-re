using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B4C")]
	public class CSProtoInfoManager_Shop : Dictionary<int, CSShopItem>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000B4D")]
		private sealed class _003CLoadFromList_003Ec__AnonStorey15A
		{
			[Token(Token = "0x400387E")]
			[FieldOffset(Offset = "0x8")]
			internal Cash.Market market;

			[Token(Token = "0x60052AD")]
			[Address(RVA = "0x1CC1364", Offset = "0x1CC1364", VA = "0x1CC1364")]
			public _003CLoadFromList_003Ec__AnonStorey15A()
			{
			}

			[Token(Token = "0x60052AE")]
			[Address(RVA = "0x1CC21A4", Offset = "0x1CC21A4", VA = "0x1CC21A4")]
			internal bool _003C_003Em__210(CSShopItem item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003878")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<DoubleKey, List<string>> countryDic;

		[Token(Token = "0x4003879")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<int, CSShopItem> FreeShopItems;

		[Token(Token = "0x400387A")]
		[FieldOffset(Offset = "0x3C")]
		public Dictionary<int, CSShopItem> NewShopItems;

		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, CSShopItem> BuffShopItems;

		[Token(Token = "0x400387C")]
		[FieldOffset(Offset = "0x44")]
		public Dictionary<int, RandomBox<CSShopItem>> RotationItems;

		[Token(Token = "0x400387D")]
		[FieldOffset(Offset = "0x48")]
		public List<CSShopItem> dataList;

		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x1CBEE10", Offset = "0x1CBEE10", VA = "0x1CBEE10")]
		public CSProtoInfoManager_Shop()
		{
		}

		[Token(Token = "0x60052A1")]
		[Address(RVA = "0x1CBEF70", Offset = "0x1CBEF70", VA = "0x1CBEF70", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x1CBEF80", Offset = "0x1CBEF80", VA = "0x1CBEF80", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x1CBEF84", Offset = "0x1CBEF84", VA = "0x1CBEF84", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60052A4")]
		[Address(RVA = "0x1CC06E0", Offset = "0x1CC06E0", VA = "0x1CC06E0")]
		private void ClearData()
		{
		}

		[Token(Token = "0x60052A5")]
		[Address(RVA = "0x1CC083C", Offset = "0x1CC083C", VA = "0x1CC083C", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60052A6")]
		[Address(RVA = "0x1CC0B18", Offset = "0x1CC0B18", VA = "0x1CC0B18")]
		public void LoadFromList(List<CSShopItem> list)
		{
		}

		[Token(Token = "0x60052A7")]
		[Address(RVA = "0x1CC137C", Offset = "0x1CC137C", VA = "0x1CC137C")]
		public CSShopItem GetShopItem(int nProductID)
		{
			return null;
		}

		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x1CC1440", Offset = "0x1CC1440", VA = "0x1CC1440")]
		public List<CSShopItem> GetBuffItemList()
		{
			return null;
		}

		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x1CC1600", Offset = "0x1CC1600", VA = "0x1CC1600")]
		public CSShopItem GetShopItemBy_StoreProductId(string store_product_id)
		{
			return null;
		}

		[Token(Token = "0x60052AA")]
		[Address(RVA = "0x1CC17EC", Offset = "0x1CC17EC", VA = "0x1CC17EC")]
		public bool IsAllowCountry(int shopItemID, string strCountry)
		{
			return default(bool);
		}

		[Token(Token = "0x60052AB")]
		[Address(RVA = "0x1CC1A2C", Offset = "0x1CC1A2C", VA = "0x1CC1A2C")]
		public Dictionary<ShopSubCategory, List<CSShopItem>> GetShopItemList(List<int> ownedCharList, string contry, string region, ShopItemCategory categoty, UserDataBase userData, DateTime localNow)
		{
			return null;
		}

		[Token(Token = "0x60052AC")]
		[Address(RVA = "0x1CC1DA4", Offset = "0x1CC1DA4", VA = "0x1CC1DA4")]
		public bool IsShowItem(UserDataBase userData, DateTime localNow, CSShopItem item, string myRegion, string myCountry, List<int> ownCharList)
		{
			return default(bool);
		}
	}
}
