using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200088C")]
	public class raw_receipt
	{
		[Token(Token = "0x40029FA")]
		[FieldOffset(Offset = "0x8")]
		public string json;

		[Token(Token = "0x40029FB")]
		[FieldOffset(Offset = "0xC")]
		public string developerPayload;

		[Token(Token = "0x40029FC")]
		[FieldOffset(Offset = "0x10")]
		public string signature;

		[Token(Token = "0x60045CF")]
		[Address(RVA = "0x21C0950", Offset = "0x21C0950", VA = "0x21C0950")]
		public raw_receipt()
		{
		}
	}
}
