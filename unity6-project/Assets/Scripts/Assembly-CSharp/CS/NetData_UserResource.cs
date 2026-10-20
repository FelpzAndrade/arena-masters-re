using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A5E")]
	public class NetData_UserResource
	{
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x8")]
		public int gold;

		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0xC")]
		public int clearTicket;

		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x10")]
		public int fp;

		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x14")]
		public int energy;

		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0x18")]
		public long energy_time;

		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0x20")]
		public int medal_of_honor;

		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x24")]
		public int medal_of_warrior;

		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x28")]
		public int promotion_weapon_stone;

		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0x2C")]
		public int promotion_armor_stone;

		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0x30")]
		public int promotion_accessory_stone;

		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x34")]
		public int itemBooster;

		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x38")]
		public int goldBooster;

		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x3C")]
		public int promstoneBooster;

		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x40")]
		public int talent_point;

		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x44")]
		public int arenaCoint;

		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<Currency, ComplexCurrency> currencyList;

		[Token(Token = "0x6004DBE")]
		[Address(RVA = "0x234055C", Offset = "0x234055C", VA = "0x234055C")]
		public NetData_UserResource()
		{
		}
	}
}
