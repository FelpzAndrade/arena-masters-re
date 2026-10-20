using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS.ranking
{
	[Token(Token = "0x2000A20")]
	public class RankerDetail
	{
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0x8")]
		public int selected;

		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0xC")]
		public List<Netdata_Char> charInven;

		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x21C05CC", Offset = "0x21C05CC", VA = "0x21C05CC")]
		public RankerDetail()
		{
		}
	}
}
