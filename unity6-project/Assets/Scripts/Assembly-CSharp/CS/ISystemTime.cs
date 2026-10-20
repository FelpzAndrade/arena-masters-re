using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B9E")]
	public interface ISystemTime
	{
		[Token(Token = "0x17000C6E")]
		DateTime Now
		{
			[Token(Token = "0x6005422")]
			get;
			[Token(Token = "0x6005423")]
			set;
		}

		[Token(Token = "0x17000C6F")]
		DateTime UtcNow
		{
			[Token(Token = "0x6005424")]
			get;
			[Token(Token = "0x6005425")]
			set;
		}
	}
}
