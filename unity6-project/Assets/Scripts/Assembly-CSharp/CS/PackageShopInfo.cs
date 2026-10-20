using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B1A")]
	public class PackageShopInfo : IShopItem
	{
		[Token(Token = "0x4003697")]
		[FieldOffset(Offset = "0x8")]
		public PackageShopCategory nCategory;

		[Token(Token = "0x4003698")]
		[FieldOffset(Offset = "0xC")]
		public PackageShopTabCategory subTab;

		[Token(Token = "0x4003699")]
		[FieldOffset(Offset = "0x10")]
		public int tabOrder;

		[Token(Token = "0x400369A")]
		[FieldOffset(Offset = "0x14")]
		public int nIineUp_id;

		[Token(Token = "0x400369B")]
		[FieldOffset(Offset = "0x18")]
		public PackagePrefabType package_icon_viewType;

		[Token(Token = "0x400369C")]
		[FieldOffset(Offset = "0x1C")]
		public string strNewProduct;

		[Token(Token = "0x400369D")]
		[FieldOffset(Offset = "0x20")]
		public bool IsNewProduct;

		[Token(Token = "0x400369E")]
		[FieldOffset(Offset = "0x24")]
		public string strSaleStart;

		[Token(Token = "0x400369F")]
		[FieldOffset(Offset = "0x28")]
		public string strSaleEnd;

		[Token(Token = "0x40036A0")]
		[FieldOffset(Offset = "0x2C")]
		public string str_reset_date;

		[Token(Token = "0x40036A1")]
		[FieldOffset(Offset = "0x30")]
		private bool IsDailyReset;

		[Token(Token = "0x40036A2")]
		[FieldOffset(Offset = "0x34")]
		public int datailID;

		[Token(Token = "0x40036A3")]
		[FieldOffset(Offset = "0x38")]
		public string store_google;

		[Token(Token = "0x40036A4")]
		[FieldOffset(Offset = "0x3C")]
		public string store_app;

		[Token(Token = "0x40036A5")]
		[FieldOffset(Offset = "0x40")]
		public string strHideProduct;

		[Token(Token = "0x40036A6")]
		[FieldOffset(Offset = "0x44")]
		public string str_limited_edition_localkey;

		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0x48")]
		public string str_show_country;

		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0x4C")]
		public string str_disable_country;

		[Token(Token = "0x40036A9")]
		[FieldOffset(Offset = "0x50")]
		public string str_disable_region;

		[Token(Token = "0x40036AA")]
		[FieldOffset(Offset = "0x54")]
		public string strUseProductDes;

		[Token(Token = "0x40036AB")]
		[FieldOffset(Offset = "0x58")]
		public string strShowBonusUI;

		[Token(Token = "0x40036AC")]
		[FieldOffset(Offset = "0x5C")]
		private int nProductID__BackingField;

		[Token(Token = "0x40036AD")]
		[FieldOffset(Offset = "0x60")]
		private string store_product_id__BackingField;

		[Token(Token = "0x40036AE")]
		[FieldOffset(Offset = "0x64")]
		private string strName__BackingField;

		[Token(Token = "0x40036AF")]
		[FieldOffset(Offset = "0x68")]
		private string strIcon__BackingField;

		[Token(Token = "0x40036B0")]
		[FieldOffset(Offset = "0x6C")]
		private int iconSoulstoneId__BackingField;

		[Token(Token = "0x40036B1")]
		[FieldOffset(Offset = "0x70")]
		private string strSaleCostType__BackingField;

		[Token(Token = "0x40036B2")]
		[FieldOffset(Offset = "0x74")]
		private int nPrice__BackingField;

		[Token(Token = "0x40036B3")]
		[FieldOffset(Offset = "0x78")]
		private CSContentType contentType__BackingField;

		[Token(Token = "0x40036B4")]
		[FieldOffset(Offset = "0x7C")]
		private int contentID__BackingField;

		[Token(Token = "0x40036B5")]
		[FieldOffset(Offset = "0x80")]
		private int contentCount__BackingField;

		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x84")]
		private int premiumTicketId__BackingField;

		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x88")]
		private string strRejectCondition__BackingField;

		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x90")]
		private DateTime saleStartTime__BackingField;

		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0xA0")]
		private DateTime saleEndTime__BackingField;

		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0xB0")]
		private int Available_count__BackingField;

		[Token(Token = "0x40036BB")]
		[FieldOffset(Offset = "0xB4")]
		private List<int> reset_date__BackingField;

		[Token(Token = "0x40036BC")]
		[FieldOffset(Offset = "0xB8")]
		private bool HideProduct__BackingField;

		[Token(Token = "0x40036BD")]
		[FieldOffset(Offset = "0xBC")]
		private Currency PayType__BackingField;

		[Token(Token = "0x40036BE")]
		[FieldOffset(Offset = "0xC0")]
		private List<string> showCountrys__BackingField;

		[Token(Token = "0x40036BF")]
		[FieldOffset(Offset = "0xC4")]
		private List<string> disableCountrys__BackingField;

		[Token(Token = "0x40036C0")]
		[FieldOffset(Offset = "0xC8")]
		private List<string> disableRegions__BackingField;

		[Token(Token = "0x40036C1")]
		[FieldOffset(Offset = "0xCC")]
		private bool IsUsedProductDes__BackingField;

		[Token(Token = "0x40036C2")]
		[FieldOffset(Offset = "0xD0")]
		private List<CSContent> packageList__BackingField;

		[Token(Token = "0x17000BEB")]
		public ShopInfoType ShopInfoType
		{
			[Token(Token = "0x6005186")]
			[Address(RVA = "0x21ABBE0", Offset = "0x21ABBE0", VA = "0x21ABBE0", Slot = "7")]
			get
			{
				return default(ShopInfoType);
			}
		}

		[Token(Token = "0x17000BEC")]
		public int nProductID
		{
			[Token(Token = "0x6005187")]
			[Address(RVA = "0x21ABBE8", Offset = "0x21ABBE8", VA = "0x21ABBE8", Slot = "8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005188")]
			[Address(RVA = "0x21ABBF0", Offset = "0x21ABBF0", VA = "0x21ABBF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000BED")]
		public string store_product_id
		{
			[Token(Token = "0x6005189")]
			[Address(RVA = "0x21ABBF8", Offset = "0x21ABBF8", VA = "0x21ABBF8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600518A")]
			[Address(RVA = "0x21ABC00", Offset = "0x21ABC00", VA = "0x21ABC00")]
			set
			{
			}
		}

		[Token(Token = "0x17000BEE")]
		public string strName
		{
			[Token(Token = "0x600518B")]
			[Address(RVA = "0x21ABC08", Offset = "0x21ABC08", VA = "0x21ABC08", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600518C")]
			[Address(RVA = "0x21ABC10", Offset = "0x21ABC10", VA = "0x21ABC10")]
			set
			{
			}
		}

		[Token(Token = "0x17000BEF")]
		public string strIcon
		{
			[Token(Token = "0x600518D")]
			[Address(RVA = "0x21ABC18", Offset = "0x21ABC18", VA = "0x21ABC18", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600518E")]
			[Address(RVA = "0x21ABC20", Offset = "0x21ABC20", VA = "0x21ABC20")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF0")]
		public int iconSoulstoneId
		{
			[Token(Token = "0x600518F")]
			[Address(RVA = "0x21ABC28", Offset = "0x21ABC28", VA = "0x21ABC28", Slot = "4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005190")]
			[Address(RVA = "0x21ABC30", Offset = "0x21ABC30", VA = "0x21ABC30")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF1")]
		public string strSaleCostType
		{
			[Token(Token = "0x6005191")]
			[Address(RVA = "0x21ABC38", Offset = "0x21ABC38", VA = "0x21ABC38", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005192")]
			[Address(RVA = "0x21ABC40", Offset = "0x21ABC40", VA = "0x21ABC40")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF2")]
		public int nPrice
		{
			[Token(Token = "0x6005193")]
			[Address(RVA = "0x21ABC48", Offset = "0x21ABC48", VA = "0x21ABC48", Slot = "11")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005194")]
			[Address(RVA = "0x21ABC50", Offset = "0x21ABC50", VA = "0x21ABC50")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF3")]
		public CSContentType contentType
		{
			[Token(Token = "0x6005195")]
			[Address(RVA = "0x21ABC58", Offset = "0x21ABC58", VA = "0x21ABC58", Slot = "12")]
			get
			{
				return default(CSContentType);
			}
			[Token(Token = "0x6005196")]
			[Address(RVA = "0x21ABC60", Offset = "0x21ABC60", VA = "0x21ABC60")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF4")]
		public int contentID
		{
			[Token(Token = "0x6005197")]
			[Address(RVA = "0x21ABC68", Offset = "0x21ABC68", VA = "0x21ABC68", Slot = "13")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005198")]
			[Address(RVA = "0x21ABC70", Offset = "0x21ABC70", VA = "0x21ABC70")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF5")]
		public int contentCount
		{
			[Token(Token = "0x6005199")]
			[Address(RVA = "0x21ABC78", Offset = "0x21ABC78", VA = "0x21ABC78", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600519A")]
			[Address(RVA = "0x21ABC80", Offset = "0x21ABC80", VA = "0x21ABC80")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF6")]
		public int premiumTicketId
		{
			[Token(Token = "0x600519B")]
			[Address(RVA = "0x21ABC88", Offset = "0x21ABC88", VA = "0x21ABC88", Slot = "15")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600519C")]
			[Address(RVA = "0x21ABC90", Offset = "0x21ABC90", VA = "0x21ABC90")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF7")]
		public string strRejectCondition
		{
			[Token(Token = "0x600519D")]
			[Address(RVA = "0x21ABC98", Offset = "0x21ABC98", VA = "0x21ABC98", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x600519E")]
			[Address(RVA = "0x21ABCA0", Offset = "0x21ABCA0", VA = "0x21ABCA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF8")]
		public DateTime saleStartTime
		{
			[Token(Token = "0x600519F")]
			[Address(RVA = "0x21ABCA8", Offset = "0x21ABCA8", VA = "0x21ABCA8", Slot = "17")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60051A0")]
			[Address(RVA = "0x21ABCB8", Offset = "0x21ABCB8", VA = "0x21ABCB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF9")]
		public DateTime saleEndTime
		{
			[Token(Token = "0x60051A1")]
			[Address(RVA = "0x21ABCD0", Offset = "0x21ABCD0", VA = "0x21ABCD0", Slot = "18")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60051A2")]
			[Address(RVA = "0x21ABCE0", Offset = "0x21ABCE0", VA = "0x21ABCE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000BFA")]
		public int Available_count
		{
			[Token(Token = "0x60051A3")]
			[Address(RVA = "0x21ABCF8", Offset = "0x21ABCF8", VA = "0x21ABCF8", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60051A4")]
			[Address(RVA = "0x21ABD00", Offset = "0x21ABD00", VA = "0x21ABD00")]
			set
			{
			}
		}

		[Token(Token = "0x17000BFB")]
		public List<int> reset_date
		{
			[Token(Token = "0x60051A5")]
			[Address(RVA = "0x21ABD08", Offset = "0x21ABD08", VA = "0x21ABD08", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051A6")]
			[Address(RVA = "0x21ABD10", Offset = "0x21ABD10", VA = "0x21ABD10")]
			set
			{
			}
		}

		[Token(Token = "0x17000BFC")]
		public bool IsGoogleStoreItem
		{
			[Token(Token = "0x60051A7")]
			[Address(RVA = "0x21ABD18", Offset = "0x21ABD18", VA = "0x21ABD18", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BFD")]
		public bool IsAppStoreItem
		{
			[Token(Token = "0x60051A8")]
			[Address(RVA = "0x21ABE00", Offset = "0x21ABE00", VA = "0x21ABE00", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BFE")]
		public bool HideProduct
		{
			[Token(Token = "0x60051A9")]
			[Address(RVA = "0x21ABEE8", Offset = "0x21ABEE8", VA = "0x21ABEE8", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051AA")]
			[Address(RVA = "0x21ABEF0", Offset = "0x21ABEF0", VA = "0x21ABEF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000BFF")]
		[XmlIgnore]
		public Currency PayType
		{
			[Token(Token = "0x60051AB")]
			[Address(RVA = "0x21ABEF8", Offset = "0x21ABEF8", VA = "0x21ABEF8", Slot = "24")]
			get
			{
				return default(Currency);
			}
			[Token(Token = "0x60051AC")]
			[Address(RVA = "0x21ABF00", Offset = "0x21ABF00", VA = "0x21ABF00")]
			set
			{
			}
		}

		[Token(Token = "0x17000C00")]
		public List<string> showCountrys
		{
			[Token(Token = "0x60051AD")]
			[Address(RVA = "0x21ABF08", Offset = "0x21ABF08", VA = "0x21ABF08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051AE")]
			[Address(RVA = "0x21ABF10", Offset = "0x21ABF10", VA = "0x21ABF10")]
			set
			{
			}
		}

		[Token(Token = "0x17000C01")]
		public List<string> disableCountrys
		{
			[Token(Token = "0x60051AF")]
			[Address(RVA = "0x21ABF18", Offset = "0x21ABF18", VA = "0x21ABF18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B0")]
			[Address(RVA = "0x21ABF20", Offset = "0x21ABF20", VA = "0x21ABF20")]
			set
			{
			}
		}

		[Token(Token = "0x17000C02")]
		public List<string> disableRegions
		{
			[Token(Token = "0x60051B1")]
			[Address(RVA = "0x21ABF28", Offset = "0x21ABF28", VA = "0x21ABF28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B2")]
			[Address(RVA = "0x21ABF30", Offset = "0x21ABF30", VA = "0x21ABF30")]
			set
			{
			}
		}

		[Token(Token = "0x17000C03")]
		[XmlIgnore]
		public bool IsUsedProductDes
		{
			[Token(Token = "0x60051B3")]
			[Address(RVA = "0x21ABF38", Offset = "0x21ABF38", VA = "0x21ABF38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051B4")]
			[Address(RVA = "0x21ABF40", Offset = "0x21ABF40", VA = "0x21ABF40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C04")]
		[XmlIgnore]
		public List<CSContent> packageList
		{
			[Token(Token = "0x60051B6")]
			[Address(RVA = "0x21ACAF4", Offset = "0x21ACAF4", VA = "0x21ACAF4", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B7")]
			[Address(RVA = "0x21ACAFC", Offset = "0x21ACAFC", VA = "0x21ACAFC")]
			set
			{
			}
		}

		[Token(Token = "0x6005185")]
		[Address(RVA = "0x21ABA64", Offset = "0x21ABA64", VA = "0x21ABA64")]
		public PackageShopInfo()
		{
		}

		[Token(Token = "0x60051B5")]
		[Address(RVA = "0x21ABF48", Offset = "0x21ABF48", VA = "0x21ABF48", Slot = "37")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x21ACB04", Offset = "0x21ACB04", VA = "0x21ACB04", Slot = "26")]
		public bool TryGetNextResetTime(DateTime now, out DateTime nextResetTime)
		{
			nextResetTime = default;
			return default(bool);
		}

		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x21ACE08", Offset = "0x21ACE08", VA = "0x21ACE08", Slot = "27")]
		public bool IsCashItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60051BA")]
		[Address(RVA = "0x21ACED0", Offset = "0x21ACED0", VA = "0x21ACED0", Slot = "28")]
		public bool HasMaxValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x21ACEFC", Offset = "0x21ACEFC", VA = "0x21ACEFC", Slot = "29")]
		public bool IsMonthlyItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x21ACF10", Offset = "0x21ACF10", VA = "0x21ACF10", Slot = "30")]
		public bool HasSaleTime()
		{
			return default(bool);
		}

		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x21AD0C8", Offset = "0x21AD0C8", VA = "0x21AD0C8", Slot = "31")]
		public bool IsSaleTime(DateTime nowTime, int addEndTime = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60051BE")]
		[Address(RVA = "0x21AD294", Offset = "0x21AD294", VA = "0x21AD294", Slot = "32")]
		public int GetPresentPrice(DateTime now, int addEndTime = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60051BF")]
		[Address(RVA = "0x21AD29C", Offset = "0x21AD29C", VA = "0x21AD29C", Slot = "33")]
		public bool TryGetContent(CSContentType contentType, out CSContent content)
		{
			content = default;
			return default(bool);
		}

		[Token(Token = "0x60051C0")]
		[Address(RVA = "0x21AD418", Offset = "0x21AD418", VA = "0x21AD418", Slot = "34")]
		public IShopItem Clone()
		{
			return null;
		}

		[Token(Token = "0x60051C1")]
		[Address(RVA = "0x21AD4A4", Offset = "0x21AD4A4", VA = "0x21AD4A4", Slot = "35")]
		public bool IsExistBonusUIFreeContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60051C2")]
		[Address(RVA = "0x21AD4AC", Offset = "0x21AD4AC", VA = "0x21AD4AC", Slot = "36")]
		public bool IsSaleItemForMarket(Cash.Market market)
		{
			return default(bool);
		}

		[Token(Token = "0x60051C3")]
		[Address(RVA = "0x21AD518", Offset = "0x21AD518", VA = "0x21AD518")]
		public bool IsDisableCountry(string country)
		{
			return default(bool);
		}

		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x21AD5B8", Offset = "0x21AD5B8", VA = "0x21AD5B8")]
		public bool IsShowCountry(string country)
		{
			return default(bool);
		}

		[Token(Token = "0x60051C5")]
		[Address(RVA = "0x21AD658", Offset = "0x21AD658", VA = "0x21AD658")]
		public bool IsDisableRegion(string region)
		{
			return default(bool);
		}
	}
}
