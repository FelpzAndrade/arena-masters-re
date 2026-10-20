using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000C0")]
	[Flags]
	public enum DefaultValueHandling
	{
		[Token(Token = "0x4000301")]
		Include = 0,
		[Token(Token = "0x4000302")]
		Ignore = 1,
		[Token(Token = "0x4000303")]
		Populate = 2,
		[Token(Token = "0x4000304")]
		IgnoreAndPopulate = Ignore | Populate
	}
}
