using Il2CppDummyDll;

namespace CS.ranking
{
	[Token(Token = "0x2000A21")]
	public class reward
	{
		[Token(Token = "0x2000A22")]
		public enum type
		{
			[Token(Token = "0x4002FFA")]
			Crystal = 0,
			[Token(Token = "0x4002FFB")]
			MedalOfHonor = 1,
			[Token(Token = "0x4002FFC")]
			PortraitID = 2,
			[Token(Token = "0x4002FFD")]
			end = 3
		}

		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x8")]
		public int rank;

		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0xC")]
		public int score;

		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x10")]
		public int count_of_rankers;

		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x14")]
		public int[] value;

		[Token(Token = "0x6004D6F")]
		[Address(RVA = "0x21C0684", Offset = "0x21C0684", VA = "0x21C0684")]
		public reward()
		{
		}
	}
}
