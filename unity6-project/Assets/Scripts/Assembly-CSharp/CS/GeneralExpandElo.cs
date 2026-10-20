using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008FF")]
	public struct GeneralExpandElo
	{
		[Token(Token = "0x4002B6F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MIN_ELO;

		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int MAX_ELO;

		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int EXPAND_ELO;

		[Token(Token = "0x4002B72")]
		[FieldOffset(Offset = "0x0")]
		public int minElo;

		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0x4")]
		public int maxElo;

		[Token(Token = "0x600480E")]
		[Address(RVA = "0x23376A8", Offset = "0x23376A8", VA = "0x23376A8")]
		public bool IsEloMatchPoint(int _eloPt)
		{
			return default(bool);
		}

		[Token(Token = "0x600480F")]
		[Address(RVA = "0x23376D0", Offset = "0x23376D0", VA = "0x23376D0")]
		public static int GetMatchingBasicElo(int _eloPt, GameModeInstanceInfo info)
		{
			return default(int);
		}

		[Token(Token = "0x6004810")]
		[Address(RVA = "0x23377DC", Offset = "0x23377DC", VA = "0x23377DC")]
		public static GeneralExpandElo CalcGeneralEloExpand(int TargetEloPt, GameModeInstanceInfo info)
		{
			return default(GeneralExpandElo);
		}
	}
}
