using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x200095E")]
	public class GameRecord : IncreasableDictionary<GameRecordType>
	{
		[Token(Token = "0x17000A80")]
		[JsonIgnore]
		public int TotalPlayCount
		{
			[Token(Token = "0x6004B52")]
			[Address(RVA = "0x2336E2C", Offset = "0x2336E2C", VA = "0x2336E2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A81")]
		[JsonIgnore]
		public int CurrentConsecutiveWin
		{
			[Token(Token = "0x6004B53")]
			[Address(RVA = "0x2336EB8", Offset = "0x2336EB8", VA = "0x2336EB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A82")]
		[JsonIgnore]
		public int CurrentConsecutiveLose
		{
			[Token(Token = "0x6004B54")]
			[Address(RVA = "0x2336F44", Offset = "0x2336F44", VA = "0x2336F44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A83")]
		[JsonIgnore]
		public int BestScore
		{
			[Token(Token = "0x6004B55")]
			[Address(RVA = "0x2336FD0", Offset = "0x2336FD0", VA = "0x2336FD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A84")]
		[JsonIgnore]
		public int BestRank
		{
			[Token(Token = "0x6004B56")]
			[Address(RVA = "0x233705C", Offset = "0x233705C", VA = "0x233705C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004B4C")]
		[Address(RVA = "0x23365F0", Offset = "0x23365F0", VA = "0x23365F0")]
		public GameRecord()
		{
		}

		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x2336674", Offset = "0x2336674", VA = "0x2336674")]
		public void Adjust(int Score, CSWinlose WinLose, int Kill, int Death, int Rank, int Assist, CSPlayerState playerState, int tagZombieToHuman, int zombieInfectCnt, bool isMVP, bool isPerfectWin, bool isPlacementTest)
		{
		}

		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x2336C70", Offset = "0x2336C70", VA = "0x2336C70")]
		public void Adjust_MaxScore(int score)
		{
		}

		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x233684C", Offset = "0x233684C", VA = "0x233684C")]
		public void Adjust_WinLose(CSWinlose WinLose)
		{
		}

		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x2336D34", Offset = "0x2336D34", VA = "0x2336D34")]
		public void Adjust_BestLadderRank(int rank)
		{
		}

		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x2336BD8", Offset = "0x2336BD8", VA = "0x2336BD8")]
		protected void Adjust_GameResultRank(int rank)
		{
		}

		[Token(Token = "0x6004B57")]
		[Address(RVA = "0x23370E8", Offset = "0x23370E8", VA = "0x23370E8")]
		public bool HasRank()
		{
			return default(bool);
		}
	}
}
