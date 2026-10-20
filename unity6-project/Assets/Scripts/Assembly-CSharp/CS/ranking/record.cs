using Il2CppDummyDll;

namespace CS.ranking
{
	[Token(Token = "0x2000A1E")]
	public class record
	{
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x8")]
		public string nickname;

		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0xC")]
		public int rank;

		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x14")]
		public int score;

		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0x18")]
		public int[] WLD;

		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x1C")]
		public int[] kd;

		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x21C0374", Offset = "0x21C0374", VA = "0x21C0374")]
		public record()
		{
		}
	}
}
