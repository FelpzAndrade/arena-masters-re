using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A7B")]
	public class CSArenaShopItem
	{
		[Serializable]
		[Token(Token = "0x2000A7C")]
		public enum Category
		{
			[Token(Token = "0x40030AD")]
			None = 0,
			[Token(Token = "0x40030AE")]
			Skin = 1,
			[Token(Token = "0x40030AF")]
			Equipment = 2,
			[Token(Token = "0x40030B0")]
			Etc = 3,
			[Token(Token = "0x40030B1")]
			Goods = 4
		}

		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0xC")]
		public Category category;

		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x10")]
		public int tabOrder;

		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x14")]
		public int displayOrder;

		[Token(Token = "0x40030A1")]
		[FieldOffset(Offset = "0x18")]
		public Currency payType;

		[Token(Token = "0x40030A2")]
		[FieldOffset(Offset = "0x1C")]
		public int payValue;

		[Token(Token = "0x40030A3")]
		[FieldOffset(Offset = "0x20")]
		public CSContentType contentType;

		[Token(Token = "0x40030A4")]
		[FieldOffset(Offset = "0x24")]
		public int contentId;

		[Token(Token = "0x40030A5")]
		[FieldOffset(Offset = "0x28")]
		public int count;

		[Token(Token = "0x40030A6")]
		[FieldOffset(Offset = "0x2C")]
		public string str_show_country;

		[Token(Token = "0x40030A7")]
		[FieldOffset(Offset = "0x30")]
		public string str_disable_country;

		[Token(Token = "0x40030A8")]
		[FieldOffset(Offset = "0x34")]
		public string str_disable_region;

		[Token(Token = "0x40030A9")]
		[FieldOffset(Offset = "0x38")]
		private List<string> showCountrys__BackingField;

		[Token(Token = "0x40030AA")]
		[FieldOffset(Offset = "0x3C")]
		private List<string> disableCountrys__BackingField;

		[Token(Token = "0x40030AB")]
		[FieldOffset(Offset = "0x40")]
		private List<string> disableRegions__BackingField;

		[Token(Token = "0x17000AFF")]
		public List<string> showCountrys
		{
			[Token(Token = "0x6004DE2")]
			[Address(RVA = "0x23EE6D4", Offset = "0x23EE6D4", VA = "0x23EE6D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DE3")]
			[Address(RVA = "0x23EE6DC", Offset = "0x23EE6DC", VA = "0x23EE6DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000B00")]
		public List<string> disableCountrys
		{
			[Token(Token = "0x6004DE4")]
			[Address(RVA = "0x23EE6E4", Offset = "0x23EE6E4", VA = "0x23EE6E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DE5")]
			[Address(RVA = "0x23EE6EC", Offset = "0x23EE6EC", VA = "0x23EE6EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000B01")]
		public List<string> disableRegions
		{
			[Token(Token = "0x6004DE6")]
			[Address(RVA = "0x23EE6F4", Offset = "0x23EE6F4", VA = "0x23EE6F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DE7")]
			[Address(RVA = "0x23EE6FC", Offset = "0x23EE6FC", VA = "0x23EE6FC")]
			set
			{
			}
		}

		[Token(Token = "0x6004DE1")]
		[Address(RVA = "0x23EE5D8", Offset = "0x23EE5D8", VA = "0x23EE5D8")]
		public CSArenaShopItem()
		{
		}

		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x23EE704", Offset = "0x23EE704", VA = "0x23EE704")]
		public CSContent GetContent()
		{
			return null;
		}

		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x23EE7BC", Offset = "0x23EE7BC", VA = "0x23EE7BC")]
		public bool IsItemType()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x23EE7D0", Offset = "0x23EE7D0", VA = "0x23EE7D0")]
		public bool IsGachaType()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x23EE7E4", Offset = "0x23EE7E4", VA = "0x23EE7E4")]
		public bool IsArenaCoinItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x23EE7F8", Offset = "0x23EE7F8", VA = "0x23EE7F8")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x23EEC6C", Offset = "0x23EEC6C", VA = "0x23EEC6C")]
		public bool IsDisableCountry(string country)
		{
			return default(bool);
		}

		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x23EED0C", Offset = "0x23EED0C", VA = "0x23EED0C")]
		public bool IsShowCountry(string country)
		{
			return default(bool);
		}

		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x23EEDAC", Offset = "0x23EEDAC", VA = "0x23EEDAC")]
		public bool IsDisableRegion(string region)
		{
			return default(bool);
		}
	}
}
