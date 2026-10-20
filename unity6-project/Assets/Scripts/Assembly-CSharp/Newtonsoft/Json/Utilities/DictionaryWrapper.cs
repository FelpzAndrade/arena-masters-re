using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000154")]
	internal class DictionaryWrapper<TKey, TValue>
	{
		[Token(Token = "0x2000155")]
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IEnumerator, IDictionaryEnumerator
		{
			[Token(Token = "0x4000568")]
			[FieldOffset(Offset = "0x0")]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			[Token(Token = "0x1700022D")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6000CDD")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Token(Token = "0x1700022E")]
			public object Key
			{
				[Token(Token = "0x6000CDE")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022F")]
			public object Value
			{
				[Token(Token = "0x6000CDF")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000230")]
			public object Current
			{
				[Token(Token = "0x6000CE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CDC")]
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				this = default;
			}

			[Token(Token = "0x6000CE1")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CE2")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary _dictionary;

		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TKey, TValue> _genericDictionary;

		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x0")]
		private static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x17000221")]
		private bool System_002ECollections_002EIDictionary_002EIsFixedSize
		{
			[Token(Token = "0x6000CC1")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x17000222")]
		private ICollection System_002ECollections_002EIDictionary_002EKeys
		{
			[Token(Token = "0x6000CC2")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Keys();
			}
		}

		[Token(Token = "0x17000223")]
		private ICollection System_002ECollections_002EIDictionary_002EValues
		{
			[Token(Token = "0x6000CC3")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Values();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000224")]
		[Token(Token = "0x6000CC4")]
		private object get_System_002ECollections_002EIDictionary_002EItem(object key)
		{
			return System_002ECollections_002EIDictionary_002Eget_Item(key);
		}

		[Token(Token = "0x6000CC5")]
		private void set_System_002ECollections_002EIDictionary_002EItem(object key, object value)
		{
			System_002ECollections_002EIDictionary_002Eset_Item(key, value);
		}

		[Token(Token = "0x17000225")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x6000CC7")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x17000226")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x6000CC8")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x17000227")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6000CCB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000228")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6000CCE")]
			get
			{
				return null;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000229")]
		[Token(Token = "0x6000CCF")]
		public TValue get_Item(TKey key)
		{
			return (TValue)default;
		}

		[Token(Token = "0x6000CD0")]
		public void set_Item(TKey key, TValue value)
		{
		}

		[Token(Token = "0x1700022A")]
		public int Count
		{
			[Token(Token = "0x6000CD5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700022B")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000CD6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700022C")]
		public object UnderlyingDictionary
		{
			[Token(Token = "0x6000CDA")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CBB")]
		public DictionaryWrapper(IDictionary dictionary)
		{
		}

		[Token(Token = "0x6000CBC")]
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
		}

		[Token(Token = "0x6000CBD")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000CBE")]
		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		[Token(Token = "0x6000CBF")]
		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC0")]
		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000CC1")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsFixedSize()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC2")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x6000CC3")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x6000CC4")]
		private object System_002ECollections_002EIDictionary_002Eget_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x6000CC5")]
		private void System_002ECollections_002EIDictionary_002Eset_Item(object key, object value)
		{
		}

		[Token(Token = "0x6000CC6")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000CC7")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC8")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x6000CC9")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000CCA")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CCC")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CCD")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default;
			return default(bool);
		}

		[Token(Token = "0x6000CD1")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000CD2")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000CD3")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD4")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000CD7")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD8")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000CD9")]
		public void Remove(object key)
		{
		}

		[Token(Token = "0x6000CDB")]
		private static KeyValuePair<TKey, TValue> _003CGetEnumerator_003Em__5E(DictionaryEntry de)
		{
			return default(KeyValuePair<TKey, TValue>);
		}
	}
}
