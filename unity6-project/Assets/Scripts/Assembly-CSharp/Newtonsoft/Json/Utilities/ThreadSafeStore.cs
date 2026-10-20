using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000170")]
	internal class ThreadSafeStore<TKey, TValue>
	{
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _lock;

		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> _store;

		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TKey, TValue> _creator;

		[Token(Token = "0x6000DAE")]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		[Token(Token = "0x6000DAF")]
		public TValue Get(TKey key)
		{
			return (TValue)default;
		}

		[Token(Token = "0x6000DB0")]
		private TValue AddValue(TKey key)
		{
			return (TValue)default;
		}
	}
}
