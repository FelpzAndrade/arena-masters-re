using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x200020E")]
public class BetterList<T>
{
	[Token(Token = "0x200020F")]
	public delegate int CompareFunc(T left, T right);

	[Token(Token = "0x2000210")]
	private sealed class _003CGetEnumerator_003Ec__Iterator25 : IDisposable
	{
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x0")]
		internal int _003Ci_003E__0;

		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x0")]
		internal int _0024PC;

		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x0")]
		internal T _0024current;

		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x0")]
		internal BetterList<T> _003C_003Ef__this;

		[Token(Token = "0x17000297")]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[Token(Token = "0x6001130")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000298")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001131")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600112F")]
		public _003CGetEnumerator_003Ec__Iterator25()
		{
		}

		[Token(Token = "0x6001130")]
		[DebuggerHidden]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
		{
			return (T)default;
		}

		[Token(Token = "0x6001131")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001132")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001133")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001134")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x0")]
	public T[] buffer;

	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x0")]
	public int size;

	// C# has no syntax for parameterized property 'Item'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: Token(Token = "0x17000296"), DebuggerHidden]
	[Token(Token = "0x600111C")]
	public T get_Item(int i)
	{
		return (T)default;
	}

	[Token(Token = "0x600111D")]
	public void set_Item(int i, T value)
	{
	}

	[Token(Token = "0x600111A")]
	public BetterList()
	{
	}

	[Token(Token = "0x600111B")]
	[DebuggerStepThrough]
	[DebuggerHidden]

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600111E")]
	private void AllocateMore()
	{
	}

	[Token(Token = "0x600111F")]
	private void Trim()
	{
	}

	[Token(Token = "0x6001120")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001121")]
	public void Release()
	{
	}

	[Token(Token = "0x6001122")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6001123")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x6001124")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6001125")]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x6001126")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6001127")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x6001128")]
	public T Pop()
	{
		return (T)default;
	}

	[Token(Token = "0x6001129")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x600112A")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public void Sort(CompareFunc comparer)
	{
	}
}
