using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000112")]
	[Flags]
	public enum JsonSchemaType
	{
		[Token(Token = "0x40004AC")]
		None = 0,
		[Token(Token = "0x40004AD")]
		String = 1,
		[Token(Token = "0x40004AE")]
		Float = 2,
		[Token(Token = "0x40004AF")]
		Integer = 4,
		[Token(Token = "0x40004B0")]
		Boolean = 8,
		[Token(Token = "0x40004B1")]
		Object = 0x10,
		[Token(Token = "0x40004B2")]
		Array = 0x20,
		[Token(Token = "0x40004B3")]
		Null = 0x40,
		[Token(Token = "0x40004B4")]
		Any = String | Float | Integer | Boolean | Object | Array | Null
	}
}
