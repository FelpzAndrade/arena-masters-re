using System;
using Il2CppDummyDll;

[Token(Token = "0x20002B2")]
[Flags]
public enum PropertyTypeFlag : byte
{
	[Token(Token = "0x4000DF0")]
	None = 0,
	[Token(Token = "0x4000DF1")]
	Game = 1,
	[Token(Token = "0x4000DF2")]
	Actor = 2,
	[Token(Token = "0x4000DF3")]
	GameAndActor = Game | Actor
}
