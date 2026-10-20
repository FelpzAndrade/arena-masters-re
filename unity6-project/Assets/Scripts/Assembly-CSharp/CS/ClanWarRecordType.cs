using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000882")]
	public enum ClanWarRecordType
	{
		[Token(Token = "0x400290B")]
		None = 0,
		[Token(Token = "0x400290C")]
		Win = 1,
		[Token(Token = "0x400290D")]
		Draw = 2,
		[Token(Token = "0x400290E")]
		Lose = 3,
		[Token(Token = "0x400290F")]
		CurrentConsecutiveLose = 4,
		[Token(Token = "0x4002910")]
		CurrentConsecutiveWin = 5,
		[Token(Token = "0x4002911")]
		MaxConsecutiveWin = 6,
		[Token(Token = "0x4002912")]
		WinRate = 7
	}
}
