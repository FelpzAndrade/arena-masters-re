using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B6B")]
	public enum MissionPlayPattern
	{
		[Token(Token = "0x400398E")]
		None = 0,
		[Token(Token = "0x400398F")]
		Adventure = 1,
		[Token(Token = "0x4003990")]
		Escort = 2,
		[Token(Token = "0x4003991")]
		Cooperation = 3,
		[Token(Token = "0x4003992")]
		AIDeathMatch = 100,
		[Token(Token = "0x4003993")]
		AITeamDeathMatch = 101,
		[Token(Token = "0x4003994")]
		AIDuelDeathMatch = 102,
		[Token(Token = "0x4003995")]
		AICapturePointA = 103
	}
}
