using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B35")]
	public class CSRandomOptionData : CharStatus
	{
		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0xB0")]
		public int nID;

		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0xB4")]
		public int optionGroup;

		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0xB8")]
		public EquipmentSlot optionPartType;

		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0xBC")]
		public string strStat;

		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0xC0")]
		public float value;

		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0xC4")]
		public float ratio;

		[Token(Token = "0x6005215")]
		[Address(RVA = "0x1CD0120", Offset = "0x1CD0120", VA = "0x1CD0120")]
		public CSRandomOptionData()
		{
		}

		[Token(Token = "0x6005216")]
		[Address(RVA = "0x1CBC950", Offset = "0x1CBC950", VA = "0x1CBC950")]
		public void Cooking()
		{
		}
	}
}
