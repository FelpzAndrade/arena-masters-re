using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B23")]
	public class PremiumTicketContent
	{
		[Token(Token = "0x40036E1")]
		[FieldOffset(Offset = "0x8")]
		public ProvideMeans provideMeans;

		[Token(Token = "0x40036E2")]
		[FieldOffset(Offset = "0xC")]
		public CSContentType contentType;

		[Token(Token = "0x40036E3")]
		[FieldOffset(Offset = "0x10")]
		public int nCount;

		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x21AE4E0", Offset = "0x21AE4E0", VA = "0x21AE4E0")]
		public PremiumTicketContent()
		{
		}
	}
}
