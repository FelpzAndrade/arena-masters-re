using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A90")]
	public enum ExtraReleaseCondition
	{
		[Token(Token = "0x4003100")]
		None = 0,
		[Token(Token = "0x4003101")]
		SkillFinish = 1,
		[Token(Token = "0x4003102")]
		HitMe = 2,
		[Token(Token = "0x4003103")]
		ShieldDepletion = 3,
		[Token(Token = "0x4003104")]
		Tag = 4,
		[Token(Token = "0x4003105")]
		Max = 5
	}
}
