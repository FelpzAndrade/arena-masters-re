using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200014A")]
	internal class CollectionWrapper<T>
	{
		protected CollectionWrapper()
		{
		}

		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x0")]
		private readonly IList _list;

		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x0")]
		private readonly ICollection<T> _genericCollection;

		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		[Token(Token = "0x17000217")]
		private bool System_002ECollections_002EIList_002EIsFixedSize
		{
			[Token(Token = "0x6000C83")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsFixedSize();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IList.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000218")]
		[Token(Token = "0x6000C85")]
		private object get_System_002ECollections_002EIList_002EItem(int index)
		{
			return System_002ECollections_002EIList_002Eget_Item(index);
		}

		[Token(Token = "0x6000C86")]
		private void set_System_002ECollections_002EIList_002EItem(int index, object value)
		{
			System_002ECollections_002EIList_002Eset_Item(index, value);
		}

		[Token(Token = "0x17000219")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x6000C88")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x1700021A")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x6000C89")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x1700021B")]
		public virtual int Count
		{
			[Token(Token = "0x6000C8E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700021C")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6000C8F")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700021D")]
		public object UnderlyingCollection
		{
			[Token(Token = "0x6000C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C7B")]
		public CollectionWrapper(IList list)
		{
		}

		[Token(Token = "0x6000C7C")]
		public CollectionWrapper(ICollection<T> list)
		{
		}

		[Token(Token = "0x6000C7D")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000C7E")]
		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C7F")]
		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C80")]
		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C81")]
		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x6000C82")]
		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		[Token(Token = "0x6000C83")]
		private bool System_002ECollections_002EIList_002Eget_IsFixedSize()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C84")]
		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		[Token(Token = "0x6000C85")]
		private object System_002ECollections_002EIList_002Eget_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x6000C86")]
		private void System_002ECollections_002EIList_002Eset_Item(int index, object value)
		{
		}

		[Token(Token = "0x6000C87")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000C88")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C89")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x6000C8A")]
		public virtual void Add(T item)
		{
		}

		[Token(Token = "0x6000C8B")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x6000C8C")]
		public virtual bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8D")]
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000C90")]
		public virtual bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C91")]
		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000C92")]
		private static void VerifyValueType(object value)
		{
		}

		[Token(Token = "0x6000C93")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}
	}
}
