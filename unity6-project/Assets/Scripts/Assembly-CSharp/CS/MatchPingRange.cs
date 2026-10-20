using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008FD")]
	public class MatchPingRange
	{
		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x8")]
		public int minPing;

		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0xC")]
		public int maxPing;

		[Token(Token = "0x6004804")]
		[Address(RVA = "0x233BD4C", Offset = "0x233BD4C", VA = "0x233BD4C")]
		public MatchPingRange()
		{
		}

		[Token(Token = "0x6004805")]
		[Address(RVA = "0x233BD54", Offset = "0x233BD54", VA = "0x233BD54")]
		public bool IsMatchPing(int _ping)
		{
			return default(bool);
		}
	}
}
