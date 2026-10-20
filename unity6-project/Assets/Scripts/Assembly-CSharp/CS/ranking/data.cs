using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS.ranking
{
	[Token(Token = "0x2000A1F")]
	public class data
	{
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0x8")]
		public XGameModeType mode;

		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0xC")]
		public int count_of_rankers;

		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x10")]
		public bool last_reward;

		[Token(Token = "0x4002FF1")]
		[FieldOffset(Offset = "0x14")]
		public record mine;

		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0x18")]
		public List<record> top_rankers;

		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x21C02A8", Offset = "0x21C02A8", VA = "0x21C02A8")]
		public data()
		{
		}
	}
}
