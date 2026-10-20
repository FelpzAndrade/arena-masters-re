using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A34")]
	public class Netdata_BuyShopItem
	{
		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x8")]
		public List<CSContent> contents;

		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0xC")]
		public bool toMail;

		[Token(Token = "0x6004D87")]
		[Address(RVA = "0x233E6A8", Offset = "0x233E6A8", VA = "0x233E6A8")]
		public Netdata_BuyShopItem()
		{
		}
	}
}
