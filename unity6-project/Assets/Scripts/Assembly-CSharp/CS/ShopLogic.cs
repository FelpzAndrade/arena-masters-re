using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200090C")]
	public static class ShopLogic
	{
		[Token(Token = "0x200090D")]
		private sealed class _003CAddBoughtPeriodLimitedGood_003Ec__AnonStorey14C
		{
			[Token(Token = "0x4002B82")]
			[FieldOffset(Offset = "0x8")]
			internal IShopItem shopItem;

			[Token(Token = "0x4002B83")]
			[FieldOffset(Offset = "0x10")]
			internal DateTime dateTime;

			[Token(Token = "0x600487F")]
			[Address(RVA = "0x21E02D4", Offset = "0x21E02D4", VA = "0x21E02D4")]
			public _003CAddBoughtPeriodLimitedGood_003Ec__AnonStorey14C()
			{
			}

			[Token(Token = "0x6004880")]
			[Address(RVA = "0x21E10A8", Offset = "0x21E10A8", VA = "0x21E10A8")]
			internal DateTime _003C_003Em__1ED()
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6004877")]
		[Address(RVA = "0x21DF31C", Offset = "0x21DF31C", VA = "0x21DF31C")]
		public static bool IsShowed(CSShopItem shopItem, UserDataBase userData, List<int> ownCharIds)
		{
			return default(bool);
		}

		[Token(Token = "0x6004878")]
		[Address(RVA = "0x21DF620", Offset = "0x21DF620", VA = "0x21DF620")]
		public static bool CheckChargeable(CSProtoInfoManagers proto, IShopItem shopItem, UserDataBase userData)
		{
			return default(bool);
		}

		[Token(Token = "0x6004879")]
		[Address(RVA = "0x21DF894", Offset = "0x21DF894", VA = "0x21DF894")]
		public static bool IsPeriodLimitedGoods(IShopItem shopItem)
		{
			return default(bool);
		}

		[Token(Token = "0x600487A")]
		[Address(RVA = "0x21DFAE0", Offset = "0x21DFAE0", VA = "0x21DFAE0")]
		public static int GetBoughtCount(IShopItem shopItem, UserDataBase user, DateTime localNowTime)
		{
			return default(int);
		}

		[Token(Token = "0x600487B")]
		[Address(RVA = "0x21DFEC4", Offset = "0x21DFEC4", VA = "0x21DFEC4")]
		public static void AddBoughtPeriodLimitedGood(List<BoughtLimitedGoods> list, DateTime dateTime, IShopItem shopItem)
		{
		}

		[Token(Token = "0x600487C")]
		[Address(RVA = "0x21E02DC", Offset = "0x21E02DC", VA = "0x21E02DC")]
		public static List<BoughtLimitedGoods> GetBoughtPeriodLimitedGoods(List<BoughtLimitedGoods> list, DateTime now, IShopItem shopItem)
		{
			return null;
		}

		[Token(Token = "0x600487D")]
		[Address(RVA = "0x21DFCFC", Offset = "0x21DFCFC", VA = "0x21DFCFC")]
		public static int GetBoughtPeriodLimitedGoodsCount(List<BoughtLimitedGoods> list, DateTime now, IShopItem shopItem)
		{
			return default(int);
		}

		[Token(Token = "0x600487E")]
		[Address(RVA = "0x21E08C0", Offset = "0x21E08C0", VA = "0x21E08C0")]
		public static bool CheckShopItemBuyCondition(CSProtoInfoManager_PackageShop protoPackageShop, IShopItem shopItem, List<int> characterInventoryIDList, List<int> itemInventoryIDList, List<CSMailData> mailList)
		{
			return default(bool);
		}
	}
}
