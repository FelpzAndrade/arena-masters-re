using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20006BC")]
public static class ShopHelper
{
	[Token(Token = "0x20006BD")]
	private sealed class _003CRequestBuyNormalItem_003Ec__AnonStorey132
	{
		[Token(Token = "0x4002051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal NetCallback callback;

		[Token(Token = "0x600383D")]
		[Address(RVA = "0x20F5CCC", Offset = "0x20F5CCC", VA = "0x20F5CCC")]
		public _003CRequestBuyNormalItem_003Ec__AnonStorey132()
		{
		}

		[Token(Token = "0x600383E")]
		[Address(RVA = "0x20F5CD4", Offset = "0x20F5CD4", VA = "0x20F5CD4")]
		internal void _003C_003Em__192(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x6003838")]
	[Address(RVA = "0x20F4D30", Offset = "0x20F4D30", VA = "0x20F4D30")]
	public static List<PackageShopInfo> GetCategoryInfos(CSProtoInfoManager_PackageShop protoPackageShop, XMyInfo myInfo, Dictionary<string, CSMailData> mailItemDictionary, PackageShopCategory category, string strRegion, string strCountry, DateTime curLocalDateTime)
	{
		return null;
	}

	[Token(Token = "0x6003839")]
	[Address(RVA = "0x20F5128", Offset = "0x20F5128", VA = "0x20F5128")]
	public static void RequestBuyShopItem(IShopItem item, [Optional] NetCallback callback, bool freeBuy = false)
	{
	}

	[Token(Token = "0x600383A")]
	[Address(RVA = "0x20F5270", Offset = "0x20F5270", VA = "0x20F5270")]
	public static void RequestBuyCashItemForEditor(IShopItem item, NetCallback callback)
	{
	}

	[Token(Token = "0x600383B")]
	[Address(RVA = "0x20F55F0", Offset = "0x20F55F0", VA = "0x20F55F0")]
	public static void RequestBuyCashItemByToy(IShopItem item, NetCallback callback)
	{
	}

	[Token(Token = "0x600383C")]
	[Address(RVA = "0x20F5900", Offset = "0x20F5900", VA = "0x20F5900")]
	private static void RequestBuyNormalItem(IShopItem item, NetCallback callback, bool freeBuy)
	{
	}
}
