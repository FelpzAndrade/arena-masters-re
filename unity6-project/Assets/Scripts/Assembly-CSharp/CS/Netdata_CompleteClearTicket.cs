using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20009D4")]
	public class Netdata_CompleteClearTicket
	{
		[Token(Token = "0x4002FB1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x4002FB2")]
		[FieldOffset(Offset = "0x8")]
		public List<Netdata_CompleteMission> compleateDataList;

		[Token(Token = "0x6004D15")]
		[Address(RVA = "0x233F710", Offset = "0x233F710", VA = "0x233F710")]
		public Netdata_CompleteClearTicket()
		{
		}
	}
}
