using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000971")]
	public class RandomBox<T>
	{
		[Token(Token = "0x4002EB6")]
		[FieldOffset(Offset = "0x0")]
		private int _cursor;

		[Token(Token = "0x4002EB7")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, T> _list;

		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0x0")]
		private Random _rnd;

		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x0")]
		private T _lastAdded;

		[Token(Token = "0x6004C11")]
		public RandomBox()
		{
		}

		[Token(Token = "0x6004C12")]
		public void Add(int Ratio, T Item)
		{
		}

		[Token(Token = "0x6004C13")]
		public T Pop()
		{
			return (T)default;
		}
	}
}
