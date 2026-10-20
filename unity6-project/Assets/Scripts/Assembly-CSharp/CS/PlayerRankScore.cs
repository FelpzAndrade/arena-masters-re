using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200089F")]
	public class PlayerRankScore
	{
		[Token(Token = "0x4002A6E")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4002A6F")]
		[FieldOffset(Offset = "0xC")]
		public PlayerGameRecord record;

		[Token(Token = "0x4002A70")]
		[FieldOffset(Offset = "0x10")]
		public int totalScore;

		[Token(Token = "0x4002A71")]
		[FieldOffset(Offset = "0x14")]
		public int rank;

		[Token(Token = "0x4002A72")]
		[FieldOffset(Offset = "0x18")]
		public CSWinlose winLose;

		[Token(Token = "0x4002A73")]
		[FieldOffset(Offset = "0x1C")]
		public int allyElo;

		[Token(Token = "0x4002A74")]
		[FieldOffset(Offset = "0x20")]
		public int enemyElo;

		[Token(Token = "0x4002A75")]
		[FieldOffset(Offset = "0x24")]
		public bool isDisconnectWinning;

		[Token(Token = "0x4002A76")]
		[FieldOffset(Offset = "0x28")]
		public int winningRoundCount;

		[Token(Token = "0x4002A77")]
		[FieldOffset(Offset = "0x2C")]
		public bool isEscape;

		[Token(Token = "0x60045EC")]
		[Address(RVA = "0x21AE3F8", Offset = "0x21AE3F8", VA = "0x21AE3F8")]
		public PlayerRankScore()
		{
		}
	}
}
