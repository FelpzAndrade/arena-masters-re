using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS.Collection
{
	[Token(Token = "0x2000872")]
	public class multi_sorted_dictionary<key, value> : SortedDictionary<key, List<value>>
	{
		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000975")]
		[Token(Token = "0x60045A2")]
		public List<value> get_Item(key k)
		{
			return null;
		}

		[Token(Token = "0x17000976")]
		public IEnumerable<key> keys
		{
			[Token(Token = "0x60045A3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600459E")]
		public multi_sorted_dictionary()
		{
		}

		[Token(Token = "0x600459F")]
		public void Add(key k, value v)
		{
		}

		[Token(Token = "0x60045A0")]
		public new bool ContainsKey(key k)
		{
			return default(bool);
		}

		[Token(Token = "0x60045A1")]
		public new bool TryGetValue(key k, out List<value> v)
		{
			v = default;
			return default(bool);
		}
	}
}
