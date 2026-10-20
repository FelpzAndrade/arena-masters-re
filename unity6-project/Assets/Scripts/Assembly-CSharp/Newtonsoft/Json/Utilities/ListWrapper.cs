using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000163")]
	internal class ListWrapper<T> : CollectionWrapper<T>
	{
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x0")]
		private readonly IList<T> _genericList;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000235")]
		[Token(Token = "0x6000D19")]
		public T get_Item(int index)
		{
			return (T)default;
		}

		[Token(Token = "0x6000D1A")]
		public void set_Item(int index, T value)
		{
		}

		[Token(Token = "0x17000236")]
		public override int Count
		{
			[Token(Token = "0x6000D1F")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000237")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000D20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000238")]
		public object UnderlyingList
		{
			[Token(Token = "0x6000D23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D14")]
		public ListWrapper(IList list)
		{
		}

		[Token(Token = "0x6000D15")]
		public ListWrapper(IList<T> list)
		{
		}

		[Token(Token = "0x6000D16")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000D17")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000D18")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000D1B")]
		public override void Add(T item)
		{
		}

		[Token(Token = "0x6000D1C")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000D1D")]
		public override bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D1E")]
		public override void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000D21")]
		public override bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D22")]
		public override IEnumerator<T> GetEnumerator()
		{
			return null;
		}
	}
}
