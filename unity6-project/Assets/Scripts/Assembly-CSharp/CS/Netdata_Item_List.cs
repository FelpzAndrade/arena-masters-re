using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x20009F6")]
	public class Netdata_Item_List
	{
		[Token(Token = "0x4002FB8")]
		[FieldOffset(Offset = "0x8")]
		public List<Netdata_Item> liNetItem;

		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x233FFF4", Offset = "0x233FFF4", VA = "0x233FFF4")]
		public Netdata_Item_List()
		{
		}
	}
}
