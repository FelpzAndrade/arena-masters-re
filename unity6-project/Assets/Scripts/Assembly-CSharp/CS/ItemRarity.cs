using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AFE")]
	public enum ItemRarity
	{
		[Token(Token = "0x400360A")]
		None = -1,
		[Token(Token = "0x400360B")]
		Common = 0,
		[Token(Token = "0x400360C")]
		Uncommon = 1,
		[Token(Token = "0x400360D")]
		Rare = 2,
		[Token(Token = "0x400360E")]
		Epic = 3,
		[Token(Token = "0x400360F")]
		Legend = 4,
		[Token(Token = "0x4003610")]
		Ancient = 5
	}
}
