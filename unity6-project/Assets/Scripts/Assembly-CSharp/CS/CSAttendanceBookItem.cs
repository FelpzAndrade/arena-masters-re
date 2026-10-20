using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A7F")]
	public class CSAttendanceBookItem
	{
		[Token(Token = "0x40030B4")]
		[FieldOffset(Offset = "0x8")]
		public int index;

		[Token(Token = "0x40030B5")]
		[FieldOffset(Offset = "0xC")]
		public int day;

		[Token(Token = "0x40030B6")]
		[FieldOffset(Offset = "0x10")]
		public CSContentType type;

		[Token(Token = "0x40030B7")]
		[FieldOffset(Offset = "0x14")]
		public int contentId;

		[Token(Token = "0x40030B8")]
		[FieldOffset(Offset = "0x18")]
		public int amount;

		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x23EEF98", Offset = "0x23EEF98", VA = "0x23EEF98")]
		public CSAttendanceBookItem()
		{
		}
	}
}
