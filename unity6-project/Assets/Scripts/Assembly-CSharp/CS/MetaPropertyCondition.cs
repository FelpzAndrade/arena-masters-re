using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B55")]
	public enum MetaPropertyCondition
	{
		[Token(Token = "0x40038AD")]
		None = 0,
		[Token(Token = "0x40038AE")]
		Hit_Wall = 1,
		[Token(Token = "0x40038AF")]
		Hit_Actor = 2,
		[Token(Token = "0x40038B0")]
		Skill_Finish = 4,
		[Token(Token = "0x40038B1")]
		Range_Out = 8,
		[Token(Token = "0x40038B2")]
		Time_Out = 0x10,
		[Token(Token = "0x40038B3")]
		Die = 0x20,
		[Token(Token = "0x40038B4")]
		Use_skill = 0x40,
		[Token(Token = "0x40038B5")]
		Dodge = 0x80
	}
}
