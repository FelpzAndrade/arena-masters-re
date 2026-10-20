using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B51")]
	public enum SkillBuffTiming
	{
		[Token(Token = "0x400389A")]
		Use = 0,
		[Token(Token = "0x400389B")]
		Hit = 1,
		[Token(Token = "0x400389C")]
		Finish = 2,
		[Token(Token = "0x400389D")]
		CriHit = 3,
		[Token(Token = "0x400389E")]
		HitSuccess = 4,
		[Token(Token = "0x400389F")]
		CriSuccess = 5
	}
}
