using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000E0")]
	public abstract class JContainer : JToken
	{
		[Token(Token = "0x20000E1")]
		private class JTokenReferenceEqualityComparer : IEqualityComparer<JToken>
		{
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly JTokenReferenceEqualityComparer Instance;

			[Token(Token = "0x600083A")]
			[Address(RVA = "0xF90F9C", Offset = "0xF90F9C", VA = "0xF90F9C")]
			public JTokenReferenceEqualityComparer()
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0xF91038", Offset = "0xF91038", VA = "0xF91038", Slot = "4")]
			public bool Equals(JToken x, JToken y)
			{
				return default(bool);
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0xF91044", Offset = "0xF91044", VA = "0xF91044", Slot = "5")]
			public int GetHashCode(JToken obj)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000E2")]
		private sealed class _003CDescendants_003Ec__Iterator1D : IDisposable
		{
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x8")]
			internal IEnumerator<JToken> _003C_0024s_76_003E__0;

			[Token(Token = "0x40003BB")]
			[FieldOffset(Offset = "0xC")]
			internal JToken _003Co_003E__1;

			[Token(Token = "0x40003BC")]
			[FieldOffset(Offset = "0x10")]
			internal JContainer _003Cc_003E__2;

			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x14")]
			internal IEnumerator<JToken> _003C_0024s_77_003E__3;

			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x18")]
			internal JToken _003Cd_003E__4;

			[Token(Token = "0x40003BF")]
			[FieldOffset(Offset = "0x1C")]
			internal int _0024PC;

			[Token(Token = "0x40003C0")]
			[FieldOffset(Offset = "0x20")]
			internal JToken _0024current;

			[Token(Token = "0x40003C1")]
			[FieldOffset(Offset = "0x24")]
			internal JContainer _003C_003Ef__this;

			[Token(Token = "0x17000145")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x600083F")]
				[Address(RVA = "0xF90518", Offset = "0xF90518", VA = "0xF90518", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000146")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000840")]
				[Address(RVA = "0xF90520", Offset = "0xF90520", VA = "0xF90520", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0xF8CA7C", Offset = "0xF8CA7C", VA = "0xF8CA7C")]
			public _003CDescendants_003Ec__Iterator1D()
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0xF90518", Offset = "0xF90518", VA = "0xF90518", Slot = "10")]
			[DebuggerHidden]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0xF90520", Offset = "0xF90520", VA = "0xF90520", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0xF90528", Offset = "0xF90528", VA = "0xF90528", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0xF9052C", Offset = "0xF9052C", VA = "0xF9052C", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0xF90608", Offset = "0xF90608", VA = "0xF90608", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0xF90D2C", Offset = "0xF90D2C", VA = "0xF90D2C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0xF90F08", Offset = "0xF90F08", VA = "0xF90F08", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x24")]
		private object _syncRoot;

		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x28")]
		private bool _busy;

		// C# has no syntax for parameterized property 'System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000139")]
		[Token(Token = "0x6000801")]
		[Address(RVA = "0xF8BC74", Offset = "0xF8BC74", VA = "0xF8BC74", Slot = "34")]
		private JToken get_System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem(int index)
		{
			return System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Item(index);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xF8BCC0", Offset = "0xF8BCC0", VA = "0xF8BCC0", Slot = "35")]
		private void set_System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem(int index, JToken value)
		{
			System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eset_Item(index, value);
		}

		[Token(Token = "0x1700013A")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIsReadOnly
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0xF8BE44", Offset = "0xF8BE44", VA = "0xF8BE44", Slot = "25")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x1700013B")]
		private bool System_002ECollections_002EIList_002EIsFixedSize
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0xF8C234", Offset = "0xF8C234", VA = "0xF8C234", Slot = "36")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x1700013C")]
		private bool System_002ECollections_002EIList_002EIsReadOnly
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0xF8C23C", Offset = "0xF8C23C", VA = "0xF8C23C", Slot = "37")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsReadOnly();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IList.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700013D")]
		[Token(Token = "0x6000812")]
		[Address(RVA = "0xF8C2E0", Offset = "0xF8C2E0", VA = "0xF8C2E0", Slot = "38")]
		private object get_System_002ECollections_002EIList_002EItem(int index)
		{
			return System_002ECollections_002EIList_002Eget_Item(index);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xF8C32C", Offset = "0xF8C32C", VA = "0xF8C32C", Slot = "39")]
		private void set_System_002ECollections_002EIList_002EItem(int index, object value)
		{
			System_002ECollections_002EIList_002Eset_Item(index, value);
		}

		[Token(Token = "0x1700013E")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0xF8C3DC", Offset = "0xF8C3DC", VA = "0xF8C3DC", Slot = "48")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x1700013F")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0xF8C3E4", Offset = "0xF8C3E4", VA = "0xF8C3E4", Slot = "49")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x17000140")]
		protected abstract IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000817")]
			get;
		}

		[Token(Token = "0x17000141")]
		public override bool HasValues
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0xF8C660", Offset = "0xF8C660", VA = "0xF8C660", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000142")]
		public override JToken First
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0xF8C7A0", Offset = "0xF8C7A0", VA = "0xF8C7A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000143")]
		public override JToken Last
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0xF8C854", Offset = "0xF8C854", VA = "0xF8C854", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		public int Count
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0xF8BFF4", Offset = "0xF8BFF4", VA = "0xF8BFF4", Slot = "47")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xF88300", Offset = "0xF88300", VA = "0xF88300")]
		internal JContainer()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xF883B8", Offset = "0xF883B8", VA = "0xF883B8")]
		internal JContainer(JContainer other)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xF8BBD0", Offset = "0xF8BBD0", VA = "0xF8BBD0", Slot = "31")]
		private int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xF8BBD4", Offset = "0xF8BBD4", VA = "0xF8BBD4", Slot = "32")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xF8BC28", Offset = "0xF8BC28", VA = "0xF8BC28", Slot = "33")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xF8BC74", Offset = "0xF8BC74", VA = "0xF8BC74", Slot = "34")]
		private JToken System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xF8BCC0", Offset = "0xF8BCC0", VA = "0xF8BCC0", Slot = "35")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eset_Item(int index, JToken value)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xF8BD14", Offset = "0xF8BD14", VA = "0xF8BD14", Slot = "26")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xF8BD60", Offset = "0xF8BD60", VA = "0xF8BD60", Slot = "27")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xF8BDA4", Offset = "0xF8BDA4", VA = "0xF8BDA4", Slot = "28")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xF8BDF0", Offset = "0xF8BDF0", VA = "0xF8BDF0", Slot = "29")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xF8BE44", Offset = "0xF8BE44", VA = "0xF8BE44", Slot = "25")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_IsReadOnly()
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xF8BE4C", Offset = "0xF8BE4C", VA = "0xF8BE4C", Slot = "30")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xF8BE98", Offset = "0xF8BE98", VA = "0xF8BE98", Slot = "40")]
		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xF8C124", Offset = "0xF8C124", VA = "0xF8C124", Slot = "41")]
		private void System_002ECollections_002EIList_002EClear()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xF8C168", Offset = "0xF8C168", VA = "0xF8C168", Slot = "42")]
		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xF8C1B8", Offset = "0xF8C1B8", VA = "0xF8C1B8", Slot = "43")]
		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xF8C1D8", Offset = "0xF8C1D8", VA = "0xF8C1D8", Slot = "44")]
		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xF8C234", Offset = "0xF8C234", VA = "0xF8C234", Slot = "36")]
		private bool System_002ECollections_002EIList_002Eget_IsFixedSize()
		{
			return default(bool);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xF8C23C", Offset = "0xF8C23C", VA = "0xF8C23C", Slot = "37")]
		private bool System_002ECollections_002EIList_002Eget_IsReadOnly()
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xF8C244", Offset = "0xF8C244", VA = "0xF8C244", Slot = "45")]
		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xF8C294", Offset = "0xF8C294", VA = "0xF8C294", Slot = "46")]
		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xF8C2E0", Offset = "0xF8C2E0", VA = "0xF8C2E0", Slot = "38")]
		private object System_002ECollections_002EIList_002Eget_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xF8C32C", Offset = "0xF8C32C", VA = "0xF8C32C", Slot = "39")]
		private void System_002ECollections_002EIList_002Eset_Item(int index, object value)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xF8C388", Offset = "0xF8C388", VA = "0xF8C388", Slot = "50")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xF8C3DC", Offset = "0xF8C3DC", VA = "0xF8C3DC", Slot = "48")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xF8C3E4", Offset = "0xF8C3E4", VA = "0xF8C3E4", Slot = "49")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xF8C4A4", Offset = "0xF8C4A4", VA = "0xF8C4A4")]
		internal void CheckReentrancy()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xF88948", Offset = "0xF88948", VA = "0xF88948")]
		internal bool ContentsEqual(JContainer container)
		{
			return default(bool);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xF8C908", Offset = "0xF8C908", VA = "0xF8C908", Slot = "20")]
		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		[Token(Token = "0x600081E")]
		public override IEnumerable<T> Values<T>()
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xF8C9D0", Offset = "0xF8C9D0", VA = "0xF8C9D0")]
		[DebuggerHidden]
		public IEnumerable<JToken> Descendants()
		{
			return null;
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xF8CA84", Offset = "0xF8CA84", VA = "0xF8CA84")]
		internal bool IsMultiContent(object content)
		{
			return default(bool);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xF8CBBC", Offset = "0xF8CBBC", VA = "0xF8CBBC")]
		internal JToken EnsureParentToken(JToken item)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xF8A3C0", Offset = "0xF8A3C0", VA = "0xF8A3C0")]
		internal int IndexOfItem(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xF8CCD0", Offset = "0xF8CCD0", VA = "0xF8CCD0", Slot = "52")]
		internal virtual void InsertItem(int index, JToken item)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xF8D24C", Offset = "0xF8D24C", VA = "0xF8D24C", Slot = "53")]
		internal virtual void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xF8D840", Offset = "0xF8D840", VA = "0xF8D840", Slot = "54")]
		internal virtual bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xF8D898", Offset = "0xF8D898", VA = "0xF8D898", Slot = "55")]
		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xF8D9D4", Offset = "0xF8D9D4", VA = "0xF8D9D4", Slot = "56")]
		internal virtual void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xF8E19C", Offset = "0xF8E19C", VA = "0xF8E19C", Slot = "57")]
		internal virtual void ClearItems()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xF8E5C8", Offset = "0xF8E5C8", VA = "0xF8E5C8", Slot = "58")]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xF8E63C", Offset = "0xF8E63C", VA = "0xF8E63C", Slot = "59")]
		internal virtual bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xF8E65C", Offset = "0xF8E65C", VA = "0xF8E65C", Slot = "60")]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xF8E07C", Offset = "0xF8E07C", VA = "0xF8E07C")]
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xF8EB30", Offset = "0xF8EB30", VA = "0xF8EB30", Slot = "61")]
		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xF8ED9C", Offset = "0xF8ED9C", VA = "0xF8ED9C", Slot = "62")]
		public virtual void Add(object content)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xF8F2A0", Offset = "0xF8F2A0", VA = "0xF8F2A0")]
		public void AddFirst(object content)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xF8EED8", Offset = "0xF8EED8", VA = "0xF8EED8")]
		internal void AddInternal(int index, object content)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xF8F2AC", Offset = "0xF8F2AC", VA = "0xF8F2AC")]
		internal JToken CreateFromContent(object content)
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xF8F394", Offset = "0xF8F394", VA = "0xF8F394")]
		public JsonWriter CreateWriter()
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xF8F4FC", Offset = "0xF8F4FC", VA = "0xF8F4FC")]
		public void ReplaceAll(object content)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xF8F574", Offset = "0xF8F574", VA = "0xF8F574")]
		public void RemoveAll()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xF89108", Offset = "0xF89108", VA = "0xF89108")]
		internal void ReadTokenFrom(JsonReader r)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xF8F5B8", Offset = "0xF8F5B8", VA = "0xF8F5B8")]
		internal void ReadContentFrom(JsonReader r)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xF8A6AC", Offset = "0xF8A6AC", VA = "0xF8A6AC")]
		internal int ContentsHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xF8BEEC", Offset = "0xF8BEEC", VA = "0xF8BEEC")]
		private JToken EnsureValue(object value)
		{
			return null;
		}
	}
}
