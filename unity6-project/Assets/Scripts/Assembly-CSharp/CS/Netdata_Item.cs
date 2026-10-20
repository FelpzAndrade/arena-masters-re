using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x20009F7")]
	public class Netdata_Item
	{
		[Token(Token = "0x4002FB9")]
		[FieldOffset(Offset = "0x8")]
		public string uid;

		[Token(Token = "0x4002FBA")]
		[FieldOffset(Offset = "0xC")]
		public int id;

		[Token(Token = "0x4002FBB")]
		[FieldOffset(Offset = "0x10")]
		public int stack_count;

		[Token(Token = "0x4002FBC")]
		[FieldOffset(Offset = "0x14")]
		public bool is_showed;

		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0x18")]
		public int exp;

		[Token(Token = "0x4002FBE")]
		[FieldOffset(Offset = "0x1C")]
		public List<int> randomOptionList;

		[Token(Token = "0x6004D3A")]
		[Address(RVA = "0x2339B34", Offset = "0x2339B34", VA = "0x2339B34")]
		public Netdata_Item()
		{
		}
	}
}
