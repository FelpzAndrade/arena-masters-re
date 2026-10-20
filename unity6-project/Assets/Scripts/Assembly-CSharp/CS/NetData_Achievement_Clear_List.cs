using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000988")]
	public class NetData_Achievement_Clear_List
	{
		[Token(Token = "0x4002F1E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NetData_Achievement_Clear_List Empty;

		[Token(Token = "0x4002F1F")]
		[FieldOffset(Offset = "0x8")]
		public List<int> m_cleared_quest;

		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x233E2F4", Offset = "0x233E2F4", VA = "0x233E2F4")]
		public NetData_Achievement_Clear_List(List<int> l)
		{
		}
	}
}
