using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace PigeonCoopToolkit.Utillities
{
	[Token(Token = "0x2000341")]
	public class CircularBuffer<T>
	{
		[Token(Token = "0x2000342")]
		private sealed class _003CGetEnumerator_003Ec__Iterator2A : IDisposable
		{
			[Token(Token = "0x4001131")]
			[FieldOffset(Offset = "0x0")]
			internal long _003Cversion_003E__0;

			[Token(Token = "0x4001132")]
			[FieldOffset(Offset = "0x0")]
			internal int _003Ci_003E__1;

			[Token(Token = "0x4001133")]
			[FieldOffset(Offset = "0x0")]
			internal int _0024PC;

			[Token(Token = "0x4001134")]
			[FieldOffset(Offset = "0x0")]
			internal T _0024current;

			[Token(Token = "0x4001135")]
			[FieldOffset(Offset = "0x0")]
			internal CircularBuffer<T> _003C_003Ef__this;

			[Token(Token = "0x170004AF")]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[Token(Token = "0x6001BB7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004B0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001BB8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001BB6")]
			public _003CGetEnumerator_003Ec__Iterator2A()
			{
			}

			[Token(Token = "0x6001BB7")]
			[DebuggerHidden]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
			{
				return (T)default;
			}

			[Token(Token = "0x6001BB8")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001BB9")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001BBA")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001BBB")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x0")]
		private T[] _buffer;

		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x0")]
		private int _position;

		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x0")]
		private long _version;

		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x0")]
		private int Capacity__BackingField;

		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x0")]
		private int Count__BackingField;

		[Token(Token = "0x170004AB")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly
		{
			[Token(Token = "0x6001BA5")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CT_003E_002Eget_IsReadOnly();
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170004AC")]
		[Token(Token = "0x6001BA7")]
		public T get_Item(int index)
		{
			return (T)default;
		}

		[Token(Token = "0x6001BA8")]
		public void set_Item(int index, T value)
		{
		}

		[Token(Token = "0x170004AD")]
		public int Capacity
		{
			[Token(Token = "0x6001BA9")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001BAA")]
			private set
			{
			}
		}

		[Token(Token = "0x170004AE")]
		public int Count
		{
			[Token(Token = "0x6001BAB")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001BAC")]
			private set
			{
			}
		}

		[Token(Token = "0x6001BA4")]
		public CircularBuffer(int capacity)
		{
		}

		[Token(Token = "0x6001BA5")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002Eget_IsReadOnly()
		{
			return default(bool);
		}

		[Token(Token = "0x6001BA6")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001BAD")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6001BAE")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001BAF")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BB0")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6001BB1")]
		[DebuggerHidden]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001BB2")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6001BB3")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6001BB4")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BB5")]
		public void RemoveAt(int index)
		{
		}
	}
}
