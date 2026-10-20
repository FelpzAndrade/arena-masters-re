using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20009D5")]
	public class Netdata_CompleteSkyTower
	{
		[Token(Token = "0x4002FB3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x4002FB4")]
		[FieldOffset(Offset = "0x8")]
		public CSExpReward teamExp;

		[Token(Token = "0x4002FB5")]
		[FieldOffset(Offset = "0xC")]
		public int gold;

		[Token(Token = "0x4002FB6")]
		[FieldOffset(Offset = "0x10")]
		public CSContentReward firstClear;

		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x14")]
		public bool isMail;

		[Token(Token = "0x6004D17")]
		[Address(RVA = "0x233FD84", Offset = "0x233FD84", VA = "0x233FD84")]
		public Netdata_CompleteSkyTower()
		{
		}
	}
}
