using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B84")]
	public class TierTableInfo
	{
		[Token(Token = "0x4003A2F")]
		[FieldOffset(Offset = "0x8")]
		public TierRank Tier;

		[Token(Token = "0x4003A30")]
		[FieldOffset(Offset = "0xC")]
		public int MinScore;

		[Token(Token = "0x4003A31")]
		[FieldOffset(Offset = "0x10")]
		public int MaxScore;

		[Token(Token = "0x4003A32")]
		[FieldOffset(Offset = "0x14")]
		public string TrophyPath;

		[Token(Token = "0x600536B")]
		[Address(RVA = "0x21E91A0", Offset = "0x21E91A0", VA = "0x21E91A0")]
		public TierTableInfo()
		{
		}
	}
}
