using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A8A")]
	public enum ProcTimingType
	{
		[Token(Token = "0x40030D7")]
		None = 0,
		[Token(Token = "0x40030D8")]
		Hit = 1,
		[Token(Token = "0x40030D9")]
		HitMe = 2,
		[Token(Token = "0x40030DA")]
		Kill = 3,
		[Token(Token = "0x40030DB")]
		Die = 4,
		[Token(Token = "0x40030DC")]
		CriHit = 5,
		[Token(Token = "0x40030DD")]
		CriHitMe = 6,
		[Token(Token = "0x40030DE")]
		Loop = 7,
		[Token(Token = "0x40030DF")]
		EnterNewSector = 8,
		[Token(Token = "0x40030E0")]
		Combat = 9
	}
}
