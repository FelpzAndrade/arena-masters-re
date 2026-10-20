using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A9C")]
	public enum AniCategoryType
	{
		[Token(Token = "0x4003173")]
		Lobby = 0,
		[Token(Token = "0x4003174")]
		InGame = 1,
		[Token(Token = "0x4003175")]
		InGameStage = 2,
		[Token(Token = "0x4003176")]
		InGameResult = 3,
		[Token(Token = "0x4003177")]
		InGameTutorial = 4,
		[Token(Token = "0x4003178")]
		End = InGameTutorial
	}
}
