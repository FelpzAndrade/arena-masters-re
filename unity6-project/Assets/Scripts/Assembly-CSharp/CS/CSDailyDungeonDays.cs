using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B6E")]
	[Flags]
	public enum CSDailyDungeonDays
	{
		[Token(Token = "0x40039A7")]
		None = 0,
		[Token(Token = "0x40039A8")]
		Monday = 1,
		[Token(Token = "0x40039A9")]
		Tuesday = 2,
		[Token(Token = "0x40039AA")]
		Wednesday = 4,
		[Token(Token = "0x40039AB")]
		Thursday = 8,
		[Token(Token = "0x40039AC")]
		Friday = 0x10,
		[Token(Token = "0x40039AD")]
		Saturday = 0x20,
		[Token(Token = "0x40039AE")]
		Sunday = 0x40,
		[Token(Token = "0x40039AF")]
		All = 0xFF
	}
}
