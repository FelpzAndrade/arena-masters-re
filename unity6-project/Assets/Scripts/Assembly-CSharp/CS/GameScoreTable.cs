using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200089E")]
	public struct GameScoreTable
	{
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0x0")]
		public int scoreKill;

		[Token(Token = "0x4002A6A")]
		[FieldOffset(Offset = "0x4")]
		public int scoreDeath;

		[Token(Token = "0x4002A6B")]
		[FieldOffset(Offset = "0x8")]
		public int scoreAssist;

		[Token(Token = "0x4002A6C")]
		[FieldOffset(Offset = "0xC")]
		public int scoreVictory;

		[Token(Token = "0x4002A6D")]
		[FieldOffset(Offset = "0x10")]
		public int scoreDefeat;
	}
}
