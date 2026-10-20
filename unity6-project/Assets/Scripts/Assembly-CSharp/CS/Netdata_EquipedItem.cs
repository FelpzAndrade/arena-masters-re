using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000990")]
	public struct Netdata_EquipedItem
	{
		[Token(Token = "0x4002F2C")]
		[FieldOffset(Offset = "0x0")]
		public string iid;

		[Token(Token = "0x4002F2D")]
		[FieldOffset(Offset = "0x4")]
		public int item_id;

		[Token(Token = "0x4002F2E")]
		[FieldOffset(Offset = "0x8")]
		public int ench_lv;

		[Token(Token = "0x4002F2F")]
		[FieldOffset(Offset = "0xC")]
		public int ench_xp;

		[Token(Token = "0x4002F30")]
		[FieldOffset(Offset = "0x10")]
		public List<int> randomOptionList;
	}
}
