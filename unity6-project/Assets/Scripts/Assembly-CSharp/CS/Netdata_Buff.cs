using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000991")]
	public class Netdata_Buff
	{
		[Token(Token = "0x4002F31")]
		[FieldOffset(Offset = "0x8")]
		public int buff_id;

		[Token(Token = "0x4002F32")]
		[FieldOffset(Offset = "0xC")]
		public int parent_skill_id;

		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x10")]
		public int user_id;

		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x14")]
		public short stack_count;

		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x233E6A0", Offset = "0x233E6A0", VA = "0x233E6A0")]
		public Netdata_Buff()
		{
		}
	}
}
