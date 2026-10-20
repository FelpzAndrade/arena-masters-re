using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000920")]
	public class StatDesc : Attribute
	{
		[Token(Token = "0x4002D44")]
		[FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0xC")]
		public int Format;

		[Token(Token = "0x4002D46")]
		[FieldOffset(Offset = "0x10")]
		public bool IsRate;

		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x21E50BC", Offset = "0x21E50BC", VA = "0x21E50BC")]
		public StatDesc()
		{
		}
	}
}
