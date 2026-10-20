using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000891")]
	public enum CSPlayerState
	{
		[Token(Token = "0x4002A12")]
		None = 0,
		[Token(Token = "0x4002A13")]
		ZombieHost = 1,
		[Token(Token = "0x4002A14")]
		Zombie = 2,
		[Token(Token = "0x4002A15")]
		Human = 3,
		[Token(Token = "0x4002A16")]
		TeamSpectator = 4,
		[Token(Token = "0x4002A17")]
		Spectator = 5,
		[Token(Token = "0x4002A18")]
		Tagger = 6
	}
}
