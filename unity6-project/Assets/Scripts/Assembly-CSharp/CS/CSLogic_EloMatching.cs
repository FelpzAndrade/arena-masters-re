using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008FE")]
	public class CSLogic_EloMatching
	{
		[Token(Token = "0x4002B6D")]
		[FieldOffset(Offset = "0x0")]
		private static List<int> liEloExpandSoloRankTable;

		[Token(Token = "0x4002B6E")]
		[FieldOffset(Offset = "0x4")]
		private static List<int> liEloExpandTeamRankTable;

		[Token(Token = "0x6004806")]
		[Address(RVA = "0x2237BF0", Offset = "0x2237BF0", VA = "0x2237BF0")]
		public CSLogic_EloMatching()
		{
		}

		[Token(Token = "0x6004808")]
		[Address(RVA = "0x2237F3C", Offset = "0x2237F3C", VA = "0x2237F3C")]
		public static MatchPointRange CalcEloExpand(int baseElo, int elapsedSec, RankType rankType)
		{
			return null;
		}

		[Token(Token = "0x6004809")]
		[Address(RVA = "0x2238204", Offset = "0x2238204", VA = "0x2238204")]
		public static int GetMaxExpandEloValue(RankType rankType)
		{
			return default(int);
		}

		[Token(Token = "0x600480A")]
		[Address(RVA = "0x223806C", Offset = "0x223806C", VA = "0x223806C")]
		public static List<int> GetEloExpandRankTable(RankType rankType)
		{
			return null;
		}

		[Token(Token = "0x600480B")]
		[Address(RVA = "0x22383B0", Offset = "0x22383B0", VA = "0x22383B0")]
		public static int CalcExpandEloValue(int baseElo, int elapsedSec, List<int> table, int maxExpandElo)
		{
			return default(int);
		}

		[Token(Token = "0x600480C")]
		[Address(RVA = "0x2238484", Offset = "0x2238484", VA = "0x2238484")]
		public static int GetExpandValue(int elapsedSec, List<int> table)
		{
			return default(int);
		}
	}
}
