using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200087F")]
	public class CSContentReward
	{
		[Token(Token = "0x40028E9")]
		[FieldOffset(Offset = "0x8")]
		public CSContent beforeReward;

		[Token(Token = "0x40028EA")]
		[FieldOffset(Offset = "0xC")]
		public CSContent actualReward;

		[Token(Token = "0x60045CD")]
		[Address(RVA = "0x222B8BC", Offset = "0x222B8BC", VA = "0x222B8BC")]
		public CSContentReward()
		{
		}
	}
}
