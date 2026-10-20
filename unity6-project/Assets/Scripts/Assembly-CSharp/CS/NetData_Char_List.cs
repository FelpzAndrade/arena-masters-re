using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200098B")]
	public class NetData_Char_List
	{
		[Token(Token = "0x4002F20")]
		[FieldOffset(Offset = "0x8")]
		public List<Netdata_Char> liNetChar;

		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x233E804", Offset = "0x233E804", VA = "0x233E804")]
		public NetData_Char_List()
		{
		}

		[Token(Token = "0x6004CC6")]
		[Address(RVA = "0x233E8B0", Offset = "0x233E8B0", VA = "0x233E8B0")]
		public NetData_Char_List(List<Netdata_Char> liNetDataChar)
		{
		}
	}
}
