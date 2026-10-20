using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000141")]
	[Flags]
	public enum TypeNameHandling
	{
		[Token(Token = "0x4000540")]
		None = 0,
		[Token(Token = "0x4000541")]
		Objects = 1,
		[Token(Token = "0x4000542")]
		Arrays = 2,
		[Token(Token = "0x4000543")]
		Auto = 4,
		[Token(Token = "0x4000544")]
		All = Objects | Arrays
	}
}
