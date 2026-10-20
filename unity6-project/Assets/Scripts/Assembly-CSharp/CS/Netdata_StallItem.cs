using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A2F")]
	public class Netdata_StallItem
	{
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0xC")]
		public int stall_ID;

		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x10")]
		public string coinType;

		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x14")]
		public bool isSale;

		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x18")]
		public int price;

		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x1C")]
		public int shopProduct_ID;

		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x20")]
		public StallType stallType;

		[Token(Token = "0x4003009")]
		[FieldOffset(Offset = "0x24")]
		public CSContentType contentType;

		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0x28")]
		public int contentId;

		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x2C")]
		public int count;

		[Token(Token = "0x6004D7D")]
		[Address(RVA = "0x23404AC", Offset = "0x23404AC", VA = "0x23404AC")]
		public Netdata_StallItem()
		{
		}
	}
}
