using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008FC")]
	public class MatchPointRange
	{
		[Token(Token = "0x4002B69")]
		[FieldOffset(Offset = "0x8")]
		public int minPoint;

		[Token(Token = "0x4002B6A")]
		[FieldOffset(Offset = "0xC")]
		public int maxPoint;

		[Token(Token = "0x6004802")]
		[Address(RVA = "0x233BD7C", Offset = "0x233BD7C", VA = "0x233BD7C")]
		public MatchPointRange()
		{
		}

		[Token(Token = "0x6004803")]
		[Address(RVA = "0x233BD84", Offset = "0x233BD84", VA = "0x233BD84")]
		public bool IsMatchPoint(int _matchPoint)
		{
			return default(bool);
		}
	}
}
