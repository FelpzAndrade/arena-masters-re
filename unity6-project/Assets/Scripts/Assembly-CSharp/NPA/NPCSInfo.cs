using System.Collections.Generic;
using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x20010A5")]
	public class NPCSInfo : Dictionary<string, string>
	{
		[Token(Token = "0x4005A88")]
		[FieldOffset(Offset = "0x34")]
		public string[] questionInfos;

		[Token(Token = "0x6007D24")]
		[Address(RVA = "0x11DDAF0", Offset = "0x11DDAF0", VA = "0x11DDAF0")]
		public NPCSInfo()
		{
		}
	}
}
