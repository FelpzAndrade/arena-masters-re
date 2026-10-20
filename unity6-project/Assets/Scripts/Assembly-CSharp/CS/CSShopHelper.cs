using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008AC")]
	public static class CSShopHelper
	{
		[Token(Token = "0x6004657")]
		[Address(RVA = "0x1CD14E8", Offset = "0x1CD14E8", VA = "0x1CD14E8")]
		public static bool TryGetShopItemInfoByStoreProductID(CSProtoInfoManager_PackageShop packageShop, CSProtoInfoManager_Shop shop, string productID, out IShopItem item)
		{
			item = default;
			return default(bool);
		}

		[Token(Token = "0x6004658")]
		[Address(RVA = "0x1CD1604", Offset = "0x1CD1604", VA = "0x1CD1604")]
		public static bool TryGetShopItemInfo(CSProtoInfoManager_PackageShop packageShop, CSProtoInfoManager_Shop shop, int productID, out IShopItem item)
		{
			item = default;
			return default(bool);
		}
	}
}
