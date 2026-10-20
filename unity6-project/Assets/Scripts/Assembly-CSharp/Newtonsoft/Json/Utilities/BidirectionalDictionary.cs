using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000143")]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		[Token(Token = "0x6000C46")]
		public BidirectionalDictionary()
		{
		}

		[Token(Token = "0x6000C47")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
		{
		}

		[Token(Token = "0x6000C48")]
		public void Add(TFirst first, TSecond second)
		{
		}

		[Token(Token = "0x6000C49")]
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			second = default;
			return default(bool);
		}

		[Token(Token = "0x6000C4A")]
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			first = default;
			return default(bool);
		}
	}
}
