using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000893")]
	public class PlayerTimeRecord
	{
		[Token(Token = "0x4002A26")]
		[FieldOffset(Offset = "0x8")]
		public long diff;

		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x10")]
		public int invalidCnt;

		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x14")]
		public Queue<long> diffTimeQueue;

		[Token(Token = "0x4002A29")]
		[FieldOffset(Offset = "0x18")]
		public Queue<int> pingQueue;

		[Token(Token = "0x60045D5")]
		[Address(RVA = "0x21AE400", Offset = "0x21AE400", VA = "0x21AE400")]
		public PlayerTimeRecord()
		{
		}
	}
}
