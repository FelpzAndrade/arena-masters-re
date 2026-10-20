using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008D7")]
	public struct DoubleKey
	{
		[Token(Token = "0x4002AF0")]
		[FieldOffset(Offset = "0x0")]
		public int Key1;

		[Token(Token = "0x4002AF1")]
		[FieldOffset(Offset = "0x4")]
		public int Key2;

		[Token(Token = "0x600472F")]
		[Address(RVA = "0x1CDB6D4", Offset = "0x1CDB6D4", VA = "0x1CDB6D4")]
		public DoubleKey(int Key1, int Key2)
		{
			this = default;
		}

		[Token(Token = "0x6004730")]
		[Address(RVA = "0x1CDB7F0", Offset = "0x1CDB7F0", VA = "0x1CDB7F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
