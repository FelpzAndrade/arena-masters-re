using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DD")]
	public interface IJEnumerable<T> : IEnumerable, IEnumerable<T> where T : JToken
	{
		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700012F")]
		[Token(Token = "0x60007D0")]
		IJEnumerable<JToken> get_Item(object key);
	}
}
