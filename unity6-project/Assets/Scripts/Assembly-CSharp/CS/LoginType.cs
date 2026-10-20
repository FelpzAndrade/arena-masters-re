using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x200089B")]
	public enum LoginType
	{
		[Token(Token = "0x4002A64")]
		None = 0,
		[Token(Token = "0x4002A65")]
		Device = 1,
		[Token(Token = "0x4002A66")]
		Google = 2,
		[Token(Token = "0x4002A67")]
		Facebook = 3,
		[Token(Token = "0x4002A68")]
		Editor = 99
	}
}
