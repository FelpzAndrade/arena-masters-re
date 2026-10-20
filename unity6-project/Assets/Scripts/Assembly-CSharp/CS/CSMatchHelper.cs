using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008C1")]
	public static class CSMatchHelper
	{
		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x2238C24", Offset = "0x2238C24", VA = "0x2238C24")]
		public static EventMatchTier GetEventMatchTier(int winsPoint)
		{
			return default(EventMatchTier);
		}

		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x2238C44", Offset = "0x2238C44", VA = "0x2238C44")]
		public static int GetEventMatchTierPoint(EventMatchTier tier)
		{
			return default(int);
		}

		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x2238C58", Offset = "0x2238C58", VA = "0x2238C58")]
		public static MatchPointRange CalcExpandEventMatchPointRang(int eventMatchPoint, int elapseSec)
		{
			return null;
		}

		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x2238DB0", Offset = "0x2238DB0", VA = "0x2238DB0")]
		public static MatchPointRange GetEventMatchPointRange(int eventMatchPoint)
		{
			return null;
		}
	}
}
