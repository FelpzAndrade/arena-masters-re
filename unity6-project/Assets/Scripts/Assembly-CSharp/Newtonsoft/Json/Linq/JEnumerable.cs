using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000E3")]
	public struct JEnumerable<T> where T : JToken
	{
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly JEnumerable<T> Empty;

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<T> _enumerable;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000147")]
		[Token(Token = "0x600084A")]
		public IJEnumerable<JToken> get_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		public JEnumerable(IEnumerable<T> enumerable)
		{
			this = default;
		}

		[Token(Token = "0x6000848")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600084C")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
