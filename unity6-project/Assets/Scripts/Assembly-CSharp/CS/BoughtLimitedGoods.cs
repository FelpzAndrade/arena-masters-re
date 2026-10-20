using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000946")]
	public class BoughtLimitedGoods
	{
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0x8")]
		public ShopInfoType ShopInfoType;

		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0xC")]
		private int ProductId__BackingField;

		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x10")]
		private DateTime ExpireTime__BackingField;

		[Token(Token = "0x17000A34")]
		public int ProductId
		{
			[Token(Token = "0x6004A5F")]
			[Address(RVA = "0x23E7C48", Offset = "0x23E7C48", VA = "0x23E7C48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A60")]
			[Address(RVA = "0x23E7C50", Offset = "0x23E7C50", VA = "0x23E7C50")]
			set
			{
			}
		}

		[Token(Token = "0x17000A35")]
		public DateTime ExpireTime
		{
			[Token(Token = "0x6004A61")]
			[Address(RVA = "0x23E7C58", Offset = "0x23E7C58", VA = "0x23E7C58")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004A62")]
			[Address(RVA = "0x23E7C68", Offset = "0x23E7C68", VA = "0x23E7C68")]
			set
			{
			}
		}

		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x23E7C40", Offset = "0x23E7C40", VA = "0x23E7C40")]
		public BoughtLimitedGoods()
		{
		}
	}
}
