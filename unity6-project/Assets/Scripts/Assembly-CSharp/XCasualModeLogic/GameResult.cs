using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using XCasualModeLogic.PoliceVsThief;

namespace XCasualModeLogic
{
	[Token(Token = "0x2000543")]
	public class GameResult
	{
		[Token(Token = "0x2000544")]
		public struct RoundResult
		{
			[Token(Token = "0x4001A54")]
			[FieldOffset(Offset = "0x0")]
			public int round;

			[Token(Token = "0x4001A55")]
			[FieldOffset(Offset = "0x4")]
			public XTeamEnum winTeam;
		}

		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x8")]
		public List<RoundResult> roundResult;

		[Token(Token = "0x4001A52")]
		[FieldOffset(Offset = "0xC")]
		public IncreasableDictionary<XTeamEnum> winCount;

		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x10")]
		public int totalRound;

		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x1AA9C10", Offset = "0x1AA9C10", VA = "0x1AA9C10")]
		public GameResult()
		{
		}

		[Token(Token = "0x6002CE5")]
		[Address(RVA = "0x1AA9CF0", Offset = "0x1AA9CF0", VA = "0x1AA9CF0")]
		public void AddRoundResult(int round, XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x6002CE6")]
		[Address(RVA = "0x1AA9E38", Offset = "0x1AA9E38", VA = "0x1AA9E38")]
		public int GetWinCount(XTeamEnum team)
		{
			return default(int);
		}

		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x1AA9EDC", Offset = "0x1AA9EDC", VA = "0x1AA9EDC")]
		public bool IsFinish(List<IPlayer> players)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CE8")]
		[Address(RVA = "0x1AAA3D8", Offset = "0x1AAA3D8", VA = "0x1AAA3D8")]
		private int GetObtainableMaxSafeScoreWhileRemainRound(XTeamEnum team)
		{
			return default(int);
		}

		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x1AAA4F0", Offset = "0x1AAA4F0", VA = "0x1AAA4F0")]
		public XTeamEnum WinTeam(List<IPlayer> players)
		{
			return default(XTeamEnum);
		}
	}
}
