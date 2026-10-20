using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B15")]
	public interface IShopItem
	{
		[Token(Token = "0x17000BD4")]
		int iconSoulstoneId
		{
			[Token(Token = "0x6005160")]
			get;
		}

		[Token(Token = "0x17000BD5")]
		string strIcon
		{
			[Token(Token = "0x6005161")]
			get;
		}

		[Token(Token = "0x17000BD6")]
		string strName
		{
			[Token(Token = "0x6005162")]
			get;
		}

		[Token(Token = "0x17000BD7")]
		ShopInfoType ShopInfoType
		{
			[Token(Token = "0x6005163")]
			get;
		}

		[Token(Token = "0x17000BD8")]
		int nProductID
		{
			[Token(Token = "0x6005164")]
			get;
		}

		[Token(Token = "0x17000BD9")]
		string store_product_id
		{
			[Token(Token = "0x6005165")]
			get;
		}

		[Token(Token = "0x17000BDA")]
		string strSaleCostType
		{
			[Token(Token = "0x6005166")]
			get;
		}

		[Token(Token = "0x17000BDB")]
		int nPrice
		{
			[Token(Token = "0x6005167")]
			get;
		}

		[Token(Token = "0x17000BDC")]
		CSContentType contentType
		{
			[Token(Token = "0x6005168")]
			get;
		}

		[Token(Token = "0x17000BDD")]
		int contentID
		{
			[Token(Token = "0x6005169")]
			get;
		}

		[Token(Token = "0x17000BDE")]
		int contentCount
		{
			[Token(Token = "0x600516A")]
			get;
		}

		[Token(Token = "0x17000BDF")]
		int premiumTicketId
		{
			[Token(Token = "0x600516B")]
			get;
		}

		[Token(Token = "0x17000BE0")]
		string strRejectCondition
		{
			[Token(Token = "0x600516C")]
			get;
		}

		[Token(Token = "0x17000BE1")]
		DateTime saleStartTime
		{
			[Token(Token = "0x600516D")]
			get;
		}

		[Token(Token = "0x17000BE2")]
		DateTime saleEndTime
		{
			[Token(Token = "0x600516E")]
			get;
		}

		[Token(Token = "0x17000BE3")]
		int Available_count
		{
			[Token(Token = "0x600516F")]
			get;
		}

		[Token(Token = "0x17000BE4")]
		List<int> reset_date
		{
			[Token(Token = "0x6005170")]
			get;
		}

		[Token(Token = "0x17000BE5")]
		bool HideProduct
		{
			[Token(Token = "0x6005171")]
			get;
		}

		[Token(Token = "0x17000BE6")]
		bool IsGoogleStoreItem
		{
			[Token(Token = "0x6005172")]
			get;
		}

		[Token(Token = "0x17000BE7")]
		bool IsAppStoreItem
		{
			[Token(Token = "0x6005173")]
			get;
		}

		[Token(Token = "0x17000BE8")]
		Currency PayType
		{
			[Token(Token = "0x6005174")]
			get;
		}

		[Token(Token = "0x17000BE9")]
		List<CSContent> packageList
		{
			[Token(Token = "0x6005175")]
			get;
		}

		[Token(Token = "0x6005176")]
		bool TryGetNextResetTime(DateTime now, out DateTime nextResetTime);

		[Token(Token = "0x6005177")]
		bool IsCashItem();

		[Token(Token = "0x6005178")]
		bool HasMaxValue();

		[Token(Token = "0x6005179")]
		bool IsMonthlyItem();

		[Token(Token = "0x600517A")]
		bool HasSaleTime();

		[Token(Token = "0x600517B")]
		bool IsSaleTime(DateTime nowTime, int addEndTime = 0);

		[Token(Token = "0x600517C")]
		int GetPresentPrice(DateTime now, int addEndTime = 0);

		[Token(Token = "0x600517D")]
		bool TryGetContent(CSContentType contentType, out CSContent content);

		[Token(Token = "0x600517E")]
		IShopItem Clone();

		[Token(Token = "0x600517F")]
		bool IsExistBonusUIFreeContent();

		[Token(Token = "0x6005180")]
		bool IsSaleItemForMarket(Cash.Market market);

		[Token(Token = "0x6005181")]
		bool Cooking();
	}
}
