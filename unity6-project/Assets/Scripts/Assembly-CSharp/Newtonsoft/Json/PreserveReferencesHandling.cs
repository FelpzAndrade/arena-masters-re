using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000101")]
	[Flags]
	public enum PreserveReferencesHandling
	{
		[Token(Token = "0x400042C")]
		None = 0,
		[Token(Token = "0x400042D")]
		Objects = 1,
		[Token(Token = "0x400042E")]
		Arrays = 2,
		[Token(Token = "0x400042F")]
		All = Objects | Arrays
	}
}
