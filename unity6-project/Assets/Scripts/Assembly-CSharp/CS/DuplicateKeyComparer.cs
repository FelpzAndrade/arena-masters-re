using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008E1")]
	public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
	{
		[Token(Token = "0x6004748")]
		public DuplicateKeyComparer()
		{
		}

		[Token(Token = "0x6004749")]
		public int Compare(TKey x, TKey y)
		{
			return default(int);
		}
	}
}
