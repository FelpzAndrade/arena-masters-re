using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B4A")]
	public class CSShopItem : IShopItem
	{
		[Token(Token = "0x4003839")]
		[FieldOffset(Offset = "0x8")]
		public int nIineUp_id;

		[Token(Token = "0x400383A")]
		[FieldOffset(Offset = "0xC")]
		public ShopItemCategory nCategory;

		[Token(Token = "0x400383B")]
		[FieldOffset(Offset = "0x10")]
		public ShopSubCategory subTab;

		[Token(Token = "0x400383C")]
		[FieldOffset(Offset = "0x14")]
		public int tabOrder;

		[Token(Token = "0x400383D")]
		[FieldOffset(Offset = "0x18")]
		public string strCharge;

		[Token(Token = "0x400383E")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsCharge;

		[Token(Token = "0x400383F")]
		[FieldOffset(Offset = "0x20")]
		public string strProperty;

		[Token(Token = "0x4003840")]
		[FieldOffset(Offset = "0x24")]
		public string strDesc;

		[Token(Token = "0x4003841")]
		[FieldOffset(Offset = "0x28")]
		public string strIsSale;

		[Token(Token = "0x4003842")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsSale;

		[Token(Token = "0x4003843")]
		[FieldOffset(Offset = "0x30")]
		public int nArenaCoin;

		[Token(Token = "0x4003844")]
		[FieldOffset(Offset = "0x34")]
		public CSContentType nId_type;

		[Token(Token = "0x4003845")]
		[FieldOffset(Offset = "0x38")]
		public double discountRatio;

		[Token(Token = "0x4003846")]
		[FieldOffset(Offset = "0x40")]
		public int packageDetailID;

		[Token(Token = "0x4003847")]
		[FieldOffset(Offset = "0x44")]
		public int nID;

		[Token(Token = "0x4003848")]
		[FieldOffset(Offset = "0x48")]
		public int nCount;

		[Token(Token = "0x4003849")]
		[FieldOffset(Offset = "0x4C")]
		public int DiscountPrice;

		[Token(Token = "0x400384A")]
		[FieldOffset(Offset = "0x50")]
		public string strHideProduct;

		[Token(Token = "0x400384B")]
		[FieldOffset(Offset = "0x54")]
		public ProductLabelType productLabelType;

		[Token(Token = "0x400384C")]
		[FieldOffset(Offset = "0x58")]
		public string strFreeTimeInterval;

		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x5C")]
		public string strNewProduct;

		[Token(Token = "0x400384E")]
		[FieldOffset(Offset = "0x60")]
		public bool IsNewProduct;

		[Token(Token = "0x400384F")]
		[FieldOffset(Offset = "0x64")]
		public string strSaleStart;

		[Token(Token = "0x4003850")]
		[FieldOffset(Offset = "0x68")]
		public string strSaleEnd;

		[Token(Token = "0x4003851")]
		[FieldOffset(Offset = "0x6C")]
		public string strBuyEnabled;

		[Token(Token = "0x4003852")]
		[FieldOffset(Offset = "0x70")]
		public bool IsBuyEnabled;

		[Token(Token = "0x4003853")]
		[FieldOffset(Offset = "0x74")]
		public int rotation_id;

		[Token(Token = "0x4003854")]
		[FieldOffset(Offset = "0x78")]
		public int sale_time;

		[Token(Token = "0x4003855")]
		[FieldOffset(Offset = "0x7C")]
		public float appearance_chance;

		[Token(Token = "0x4003856")]
		[FieldOffset(Offset = "0x80")]
		public string str_reset_date;

		[Token(Token = "0x4003857")]
		[FieldOffset(Offset = "0x84")]
		private bool IsDailyReset;

		[Token(Token = "0x4003858")]
		[FieldOffset(Offset = "0x88")]
		public string show_if;

		[Token(Token = "0x4003859")]
		[FieldOffset(Offset = "0x8C")]
		public string free_time_disable;

		[Token(Token = "0x400385A")]
		[FieldOffset(Offset = "0x90")]
		public bool IsFreeTimeDisable;

		[Token(Token = "0x400385B")]
		[FieldOffset(Offset = "0x94")]
		public int show_box_id;

		[Token(Token = "0x400385C")]
		[FieldOffset(Offset = "0x98")]
		public string store_google;

		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0x9C")]
		public string store_app;

		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0xA0")]
		public string str_show_country;

		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0xA4")]
		public string str_disable_country;

		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0xA8")]
		public string str_disable_region;

		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0xAC")]
		public string strNewBadge;

		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0xB0")]
		public bool IsNewBadge;

		[Token(Token = "0x4003863")]
		[FieldOffset(Offset = "0xB4")]
		private int nProductID__BackingField;

		[Token(Token = "0x4003864")]
		[FieldOffset(Offset = "0xB8")]
		private string store_product_id__BackingField;

		[Token(Token = "0x4003865")]
		[FieldOffset(Offset = "0xBC")]
		private string strName__BackingField;

		[Token(Token = "0x4003866")]
		[FieldOffset(Offset = "0xC0")]
		private string strIcon__BackingField;

		[Token(Token = "0x4003867")]
		[FieldOffset(Offset = "0xC4")]
		private int iconSoulstoneId__BackingField;

		[Token(Token = "0x4003868")]
		[FieldOffset(Offset = "0xC8")]
		private string strSaleCostType__BackingField;

		[Token(Token = "0x4003869")]
		[FieldOffset(Offset = "0xCC")]
		private int nPrice__BackingField;

		[Token(Token = "0x400386A")]
		[FieldOffset(Offset = "0xD0")]
		private bool HideProduct__BackingField;

		[Token(Token = "0x400386B")]
		[FieldOffset(Offset = "0xD4")]
		private int premiumTicketId__BackingField;

		[Token(Token = "0x400386C")]
		[FieldOffset(Offset = "0xD8")]
		private string strRejectCondition__BackingField;

		[Token(Token = "0x400386D")]
		[FieldOffset(Offset = "0xE0")]
		private DateTime saleStartTime__BackingField;

		[Token(Token = "0x400386E")]
		[FieldOffset(Offset = "0xF0")]
		private DateTime saleEndTime__BackingField;

		[Token(Token = "0x400386F")]
		[FieldOffset(Offset = "0x100")]
		private int Available_count__BackingField;

		[Token(Token = "0x4003870")]
		[FieldOffset(Offset = "0x104")]
		private List<int> reset_date__BackingField;

		[Token(Token = "0x4003871")]
		[FieldOffset(Offset = "0x108")]
		private List<string> showCountrys__BackingField;

		[Token(Token = "0x4003872")]
		[FieldOffset(Offset = "0x10C")]
		private List<string> disableCountrys__BackingField;

		[Token(Token = "0x4003873")]
		[FieldOffset(Offset = "0x110")]
		private List<string> disableRegions__BackingField;

		[Token(Token = "0x4003874")]
		[FieldOffset(Offset = "0x114")]
		private Currency PayType__BackingField;

		[Token(Token = "0x4003875")]
		[FieldOffset(Offset = "0x118")]
		private List<CSContent> packageList__BackingField;

		[Token(Token = "0x4003876")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<CSContent> _003C_003Ef__am_0024cache3D;

		[Token(Token = "0x17000C09")]
		public ShopInfoType ShopInfoType
		{
			[Token(Token = "0x600525F")]
			[Address(RVA = "0x1CD187C", Offset = "0x1CD187C", VA = "0x1CD187C", Slot = "7")]
			get
			{
				return default(ShopInfoType);
			}
		}

		[Token(Token = "0x17000C0A")]
		public int nProductID
		{
			[Token(Token = "0x6005260")]
			[Address(RVA = "0x1CC06D0", Offset = "0x1CC06D0", VA = "0x1CC06D0", Slot = "8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005261")]
			[Address(RVA = "0x1CD1884", Offset = "0x1CD1884", VA = "0x1CD1884")]
			set
			{
			}
		}

		[Token(Token = "0x17000C0B")]
		public string store_product_id
		{
			[Token(Token = "0x6005262")]
			[Address(RVA = "0x1CC17E4", Offset = "0x1CC17E4", VA = "0x1CC17E4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005263")]
			[Address(RVA = "0x1CD188C", Offset = "0x1CD188C", VA = "0x1CD188C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C0C")]
		public string strName
		{
			[Token(Token = "0x6005264")]
			[Address(RVA = "0x1CD1894", Offset = "0x1CD1894", VA = "0x1CD1894", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005265")]
			[Address(RVA = "0x1CD189C", Offset = "0x1CD189C", VA = "0x1CD189C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C0D")]
		public string strIcon
		{
			[Token(Token = "0x6005266")]
			[Address(RVA = "0x1CD18A4", Offset = "0x1CD18A4", VA = "0x1CD18A4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005267")]
			[Address(RVA = "0x1CD18AC", Offset = "0x1CD18AC", VA = "0x1CD18AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000C0E")]
		public int iconSoulstoneId
		{
			[Token(Token = "0x6005268")]
			[Address(RVA = "0x1CD18B4", Offset = "0x1CD18B4", VA = "0x1CD18B4", Slot = "4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005269")]
			[Address(RVA = "0x1CD18BC", Offset = "0x1CD18BC", VA = "0x1CD18BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000C0F")]
		public string strSaleCostType
		{
			[Token(Token = "0x600526A")]
			[Address(RVA = "0x1CD18C4", Offset = "0x1CD18C4", VA = "0x1CD18C4", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600526B")]
			[Address(RVA = "0x1CD18CC", Offset = "0x1CD18CC", VA = "0x1CD18CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000C10")]
		public int nPrice
		{
			[Token(Token = "0x600526C")]
			[Address(RVA = "0x1CD18D4", Offset = "0x1CD18D4", VA = "0x1CD18D4", Slot = "11")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600526D")]
			[Address(RVA = "0x1CD18DC", Offset = "0x1CD18DC", VA = "0x1CD18DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000C11")]
		public CSContentType contentType
		{
			[Token(Token = "0x600526E")]
			[Address(RVA = "0x1CD18E4", Offset = "0x1CD18E4", VA = "0x1CD18E4", Slot = "12")]
			get
			{
				return default(CSContentType);
			}
		}

		[Token(Token = "0x17000C12")]
		public int contentID
		{
			[Token(Token = "0x600526F")]
			[Address(RVA = "0x1CD18EC", Offset = "0x1CD18EC", VA = "0x1CD18EC", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000C13")]
		public int contentCount
		{
			[Token(Token = "0x6005270")]
			[Address(RVA = "0x1CD18F4", Offset = "0x1CD18F4", VA = "0x1CD18F4", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000C14")]
		public bool HideProduct
		{
			[Token(Token = "0x6005271")]
			[Address(RVA = "0x1CC06C8", Offset = "0x1CC06C8", VA = "0x1CC06C8", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005272")]
			[Address(RVA = "0x1CD18FC", Offset = "0x1CD18FC", VA = "0x1CD18FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000C15")]
		public int premiumTicketId
		{
			[Token(Token = "0x6005273")]
			[Address(RVA = "0x1CD1904", Offset = "0x1CD1904", VA = "0x1CD1904", Slot = "15")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005274")]
			[Address(RVA = "0x1CD190C", Offset = "0x1CD190C", VA = "0x1CD190C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C16")]
		public string strRejectCondition
		{
			[Token(Token = "0x6005275")]
			[Address(RVA = "0x1CD1914", Offset = "0x1CD1914", VA = "0x1CD1914", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005276")]
			[Address(RVA = "0x1CD191C", Offset = "0x1CD191C", VA = "0x1CD191C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C17")]
		public DateTime saleStartTime
		{
			[Token(Token = "0x6005277")]
			[Address(RVA = "0x1CD1924", Offset = "0x1CD1924", VA = "0x1CD1924", Slot = "17")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6005278")]
			[Address(RVA = "0x1CD1934", Offset = "0x1CD1934", VA = "0x1CD1934")]
			set
			{
			}
		}

		[Token(Token = "0x17000C18")]
		public DateTime saleEndTime
		{
			[Token(Token = "0x6005279")]
			[Address(RVA = "0x1CD194C", Offset = "0x1CD194C", VA = "0x1CD194C", Slot = "18")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600527A")]
			[Address(RVA = "0x1CD195C", Offset = "0x1CD195C", VA = "0x1CD195C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C19")]
		public int Available_count
		{
			[Token(Token = "0x600527B")]
			[Address(RVA = "0x1CD1974", Offset = "0x1CD1974", VA = "0x1CD1974", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600527C")]
			[Address(RVA = "0x1CD197C", Offset = "0x1CD197C", VA = "0x1CD197C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C1A")]
		public List<int> reset_date
		{
			[Token(Token = "0x600527D")]
			[Address(RVA = "0x1CD1984", Offset = "0x1CD1984", VA = "0x1CD1984", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600527E")]
			[Address(RVA = "0x1CD198C", Offset = "0x1CD198C", VA = "0x1CD198C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C1B")]
		public bool IsGoogleStoreItem
		{
			[Token(Token = "0x600527F")]
			[Address(RVA = "0x1CD1994", Offset = "0x1CD1994", VA = "0x1CD1994", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C1C")]
		public bool IsAppStoreItem
		{
			[Token(Token = "0x6005280")]
			[Address(RVA = "0x1CD1A7C", Offset = "0x1CD1A7C", VA = "0x1CD1A7C", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C1D")]
		public List<string> showCountrys
		{
			[Token(Token = "0x6005281")]
			[Address(RVA = "0x1CC06D8", Offset = "0x1CC06D8", VA = "0x1CC06D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005282")]
			[Address(RVA = "0x1CD1B64", Offset = "0x1CD1B64", VA = "0x1CD1B64")]
			set
			{
			}
		}

		[Token(Token = "0x17000C1E")]
		public List<string> disableCountrys
		{
			[Token(Token = "0x6005283")]
			[Address(RVA = "0x1CD1B6C", Offset = "0x1CD1B6C", VA = "0x1CD1B6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005284")]
			[Address(RVA = "0x1CD1B74", Offset = "0x1CD1B74", VA = "0x1CD1B74")]
			set
			{
			}
		}

		[Token(Token = "0x17000C1F")]
		public List<string> disableRegions
		{
			[Token(Token = "0x6005285")]
			[Address(RVA = "0x1CD1B7C", Offset = "0x1CD1B7C", VA = "0x1CD1B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005286")]
			[Address(RVA = "0x1CD1B84", Offset = "0x1CD1B84", VA = "0x1CD1B84")]
			set
			{
			}
		}

		[Token(Token = "0x17000C20")]
		[XmlIgnore]
		public Currency PayType
		{
			[Token(Token = "0x6005287")]
			[Address(RVA = "0x1CD1B8C", Offset = "0x1CD1B8C", VA = "0x1CD1B8C", Slot = "24")]
			get
			{
				return default(Currency);
			}
			[Token(Token = "0x6005288")]
			[Address(RVA = "0x1CD1B94", Offset = "0x1CD1B94", VA = "0x1CD1B94")]
			set
			{
			}
		}

		[Token(Token = "0x17000C21")]
		[XmlIgnore]
		public List<CSContent> packageList
		{
			[Token(Token = "0x600528A")]
			[Address(RVA = "0x1CC136C", Offset = "0x1CC136C", VA = "0x1CC136C", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x600528B")]
			[Address(RVA = "0x1CC1374", Offset = "0x1CC1374", VA = "0x1CC1374")]
			set
			{
			}
		}

		[Token(Token = "0x600525E")]
		[Address(RVA = "0x1CD1680", Offset = "0x1CD1680", VA = "0x1CD1680")]
		public CSShopItem()
		{
		}

		[Token(Token = "0x6005289")]
		[Address(RVA = "0x1CBF5D0", Offset = "0x1CBF5D0", VA = "0x1CBF5D0", Slot = "37")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x600528C")]
		[Address(RVA = "0x1CD1C64", Offset = "0x1CD1C64", VA = "0x1CD1C64", Slot = "26")]
		public bool TryGetNextResetTime(DateTime now, out DateTime nextResetTime)
		{
			nextResetTime = default;
			return default(bool);
		}

		[Token(Token = "0x600528D")]
		[Address(RVA = "0x1CD1F68", Offset = "0x1CD1F68", VA = "0x1CD1F68", Slot = "32")]
		public int GetPresentPrice(DateTime now, int addEndTime = 0)
		{
			return default(int);
		}

		[Token(Token = "0x600528E")]
		[Address(RVA = "0x1CD1FC8", Offset = "0x1CD1FC8", VA = "0x1CD1FC8")]
		public bool IsDiscount(DateTime now, int addEndTime = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600528F")]
		[Address(RVA = "0x1CD2014", Offset = "0x1CD2014", VA = "0x1CD2014")]
		public bool IsAdvertisingItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6005290")]
		[Address(RVA = "0x1CD1B9C", Offset = "0x1CD1B9C", VA = "0x1CD1B9C", Slot = "27")]
		public bool IsCashItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6005291")]
		[Address(RVA = "0x1CD2110", Offset = "0x1CD2110", VA = "0x1CD2110")]
		public bool IsFreeItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6005292")]
		[Address(RVA = "0x1CD21C0", Offset = "0x1CD21C0", VA = "0x1CD21C0", Slot = "28")]
		public bool HasMaxValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6005293")]
		[Address(RVA = "0x1CD21EC", Offset = "0x1CD21EC", VA = "0x1CD21EC", Slot = "29")]
		public bool IsMonthlyItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6005294")]
		[Address(RVA = "0x1CD2200", Offset = "0x1CD2200", VA = "0x1CD2200", Slot = "30")]
		public bool HasSaleTime()
		{
			return default(bool);
		}

		[Token(Token = "0x6005295")]
		[Address(RVA = "0x1CC1E98", Offset = "0x1CC1E98", VA = "0x1CC1E98", Slot = "31")]
		public bool IsSaleTime(DateTime nowTime, int addEndTime = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6005296")]
		[Address(RVA = "0x1CD23B8", Offset = "0x1CD23B8", VA = "0x1CD23B8", Slot = "35")]
		public bool IsExistBonusUIFreeContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6005297")]
		[Address(RVA = "0x1CD2534", Offset = "0x1CD2534", VA = "0x1CD2534", Slot = "33")]
		public bool TryGetContent(CSContentType contentType, out CSContent content)
		{
			content = default;
			return default(bool);
		}

		[Token(Token = "0x6005298")]
		[Address(RVA = "0x1CD26B0", Offset = "0x1CD26B0", VA = "0x1CD26B0", Slot = "34")]
		public IShopItem Clone()
		{
			return null;
		}

		[Token(Token = "0x6005299")]
		[Address(RVA = "0x1CC21D4", Offset = "0x1CC21D4", VA = "0x1CC21D4", Slot = "36")]
		public bool IsSaleItemForMarket(Cash.Market market)
		{
			return default(bool);
		}

		[Token(Token = "0x600529A")]
		[Address(RVA = "0x1CC2104", Offset = "0x1CC2104", VA = "0x1CC2104")]
		public bool IsDisableCountry(string country)
		{
			return default(bool);
		}

		[Token(Token = "0x600529B")]
		[Address(RVA = "0x1CC198C", Offset = "0x1CC198C", VA = "0x1CC198C")]
		public bool IsShowCountry(string country)
		{
			return default(bool);
		}

		[Token(Token = "0x600529C")]
		[Address(RVA = "0x1CC2064", Offset = "0x1CC2064", VA = "0x1CC2064")]
		public bool IsDisableRegion(string region)
		{
			return default(bool);
		}

		[Token(Token = "0x600529D")]
		[Address(RVA = "0x1CD273C", Offset = "0x1CD273C", VA = "0x1CD273C")]
		private static bool _003CIsExistBonusUIFreeContent_003Em__20F(CSContent x)
		{
			return default(bool);
		}
	}
}
