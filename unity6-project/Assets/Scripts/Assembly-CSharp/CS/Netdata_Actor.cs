using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200098D")]
	public class Netdata_Actor
	{
		[Token(Token = "0x4002F22")]
		[FieldOffset(Offset = "0x8")]
		public string uid;

		[Token(Token = "0x4002F23")]
		[FieldOffset(Offset = "0xC")]
		public int id;

		[Token(Token = "0x4002F24")]
		[FieldOffset(Offset = "0x10")]
		public int grade;

		[Token(Token = "0x4002F25")]
		[FieldOffset(Offset = "0x14")]
		public int used_skill_point;

		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x4002F27")]
		[FieldOffset(Offset = "0x1C")]
		public Netdata_EquipedItem[] equiped_items;

		[Token(Token = "0x4002F28")]
		[FieldOffset(Offset = "0x20")]
		public bool is_showed;

		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x233E518", Offset = "0x233E518", VA = "0x233E518")]
		public Netdata_Actor()
		{
		}
	}
}
