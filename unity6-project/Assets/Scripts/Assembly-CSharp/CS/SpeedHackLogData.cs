using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000895")]
	public class SpeedHackLogData
	{
		[Token(Token = "0x4002A2B")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4002A2C")]
		[FieldOffset(Offset = "0x10")]
		public long diff;

		[Token(Token = "0x4002A2D")]
		[FieldOffset(Offset = "0x18")]
		public long[] diffTimeList;

		[Token(Token = "0x4002A2E")]
		[FieldOffset(Offset = "0x1C")]
		public int[] pingList;

		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x21E31A4", Offset = "0x21E31A4", VA = "0x21E31A4")]
		public SpeedHackLogData(string name, PlayerTimeRecord record)
		{
		}

		[Token(Token = "0x60045D8")]
		[Address(RVA = "0x21E3298", Offset = "0x21E3298", VA = "0x21E3298")]
		public SpeedHackLogData(string name, int diff)
		{
		}

		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x21E32C4", Offset = "0x21E32C4", VA = "0x21E32C4")]
		public SpeedHackLogData()
		{
		}
	}
}
