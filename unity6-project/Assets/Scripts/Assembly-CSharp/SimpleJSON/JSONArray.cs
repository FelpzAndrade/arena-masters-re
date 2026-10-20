using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x20010C6")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x20010C7")]
		private sealed class _003C_003Ec__IteratorB7 : IDisposable
		{
			[Token(Token = "0x4005C8E")]
			[FieldOffset(Offset = "0x8")]
			internal List<JSONNode>.Enumerator _003C_0024s_523_003E__0;

			[Token(Token = "0x4005C8F")]
			[FieldOffset(Offset = "0x18")]
			internal JSONNode _003CN_003E__1;

			[Token(Token = "0x4005C90")]
			[FieldOffset(Offset = "0x1C")]
			internal int _0024PC;

			[Token(Token = "0x4005C91")]
			[FieldOffset(Offset = "0x20")]
			internal JSONNode _0024current;

			[Token(Token = "0x4005C92")]
			[FieldOffset(Offset = "0x24")]
			internal JSONArray _003C_003Ef__this;

			[Token(Token = "0x17000F88")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6007EAF")]
				[Address(RVA = "0x20FC5F0", Offset = "0x20FC5F0", VA = "0x20FC5F0", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F89")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007EB0")]
				[Address(RVA = "0x20FC5F8", Offset = "0x20FC5F8", VA = "0x20FC5F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6007EAE")]
			[Address(RVA = "0x20FBB40", Offset = "0x20FBB40", VA = "0x20FBB40")]
			public _003C_003Ec__IteratorB7()
			{
			}

			[Token(Token = "0x6007EAF")]
			[Address(RVA = "0x20FC5F0", Offset = "0x20FC5F0", VA = "0x20FC5F0", Slot = "10")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007EB0")]
			[Address(RVA = "0x20FC5F8", Offset = "0x20FC5F8", VA = "0x20FC5F8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007EB1")]
			[Address(RVA = "0x20FC600", Offset = "0x20FC600", VA = "0x20FC600", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007EB2")]
			[Address(RVA = "0x20FC604", Offset = "0x20FC604", VA = "0x20FC604", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007EB3")]
			[Address(RVA = "0x20FC6E0", Offset = "0x20FC6E0", VA = "0x20FC6E0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007EB4")]
			[Address(RVA = "0x20FC930", Offset = "0x20FC930", VA = "0x20FC930", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6007EB5")]
			[Address(RVA = "0x20FCA78", Offset = "0x20FCA78", VA = "0x20FCA78", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20010C8")]
		private sealed class _003CGetEnumerator_003Ec__IteratorB8 : IDisposable
		{
			[Token(Token = "0x4005C93")]
			[FieldOffset(Offset = "0x8")]
			internal List<JSONNode>.Enumerator _003C_0024s_524_003E__0;

			[Token(Token = "0x4005C94")]
			[FieldOffset(Offset = "0x18")]
			internal JSONNode _003CN_003E__1;

			[Token(Token = "0x4005C95")]
			[FieldOffset(Offset = "0x1C")]
			internal int _0024PC;

			[Token(Token = "0x4005C96")]
			[FieldOffset(Offset = "0x20")]
			internal object _0024current;

			[Token(Token = "0x4005C97")]
			[FieldOffset(Offset = "0x24")]
			internal JSONArray _003C_003Ef__this;

			[Token(Token = "0x17000F8A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6007EB7")]
				[Address(RVA = "0x20FCB0C", Offset = "0x20FCB0C", VA = "0x20FCB0C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F8B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007EB8")]
				[Address(RVA = "0x20FCB14", Offset = "0x20FCB14", VA = "0x20FCB14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6007EB6")]
			[Address(RVA = "0x20FBBEC", Offset = "0x20FBBEC", VA = "0x20FBBEC")]
			public _003CGetEnumerator_003Ec__IteratorB8()
			{
			}

			[Token(Token = "0x6007EB7")]
			[Address(RVA = "0x20FCB0C", Offset = "0x20FCB0C", VA = "0x20FCB0C", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007EB8")]
			[Address(RVA = "0x20FCB14", Offset = "0x20FCB14", VA = "0x20FCB14", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007EB9")]
			[Address(RVA = "0x20FCB1C", Offset = "0x20FCB1C", VA = "0x20FCB1C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007EBA")]
			[Address(RVA = "0x20FCD6C", Offset = "0x20FCD6C", VA = "0x20FCD6C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6007EBB")]
			[Address(RVA = "0x20FCEB4", Offset = "0x20FCEB4", VA = "0x20FCEB4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4005C8D")]
		[FieldOffset(Offset = "0x8")]
		private List<JSONNode> m_List;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F84")]
		[Token(Token = "0x6007EA1")]
		[Address(RVA = "0x20FB408", Offset = "0x20FB408", VA = "0x20FB408", Slot = "5")]
		public override JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6007EA2")]
		[Address(RVA = "0x20FB54C", Offset = "0x20FB54C", VA = "0x20FB54C", Slot = "6")]
		public override void set_Item(int aIndex, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F85")]
		[Token(Token = "0x6007EA3")]
		[Address(RVA = "0x20FB664", Offset = "0x20FB664", VA = "0x20FB664", Slot = "7")]
		public override JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6007EA4")]
		[Address(RVA = "0x20FB700", Offset = "0x20FB700", VA = "0x20FB700", Slot = "8")]
		public override void set_Item(string aKey, JSONNode value)
		{
		}

		[Token(Token = "0x17000F86")]
		public override int Count
		{
			[Token(Token = "0x6007EA5")]
			[Address(RVA = "0x20FB7A0", Offset = "0x20FB7A0", VA = "0x20FB7A0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000F87")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007EA9")]
			[Address(RVA = "0x20FBA94", Offset = "0x20FBA94", VA = "0x20FBA94", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007EA0")]
		[Address(RVA = "0x20FB354", Offset = "0x20FB354", VA = "0x20FB354")]
		public JSONArray()
		{
		}

		[Token(Token = "0x6007EA6")]
		[Address(RVA = "0x20FB838", Offset = "0x20FB838", VA = "0x20FB838", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6007EA7")]
		[Address(RVA = "0x20FB8D8", Offset = "0x20FB8D8", VA = "0x20FB8D8", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6007EA8")]
		[Address(RVA = "0x20FB9F0", Offset = "0x20FB9F0", VA = "0x20FB9F0", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6007EAA")]
		[Address(RVA = "0x20FBB48", Offset = "0x20FBB48", VA = "0x20FBB48", Slot = "31")]
		[DebuggerHidden]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6007EAB")]
		[Address(RVA = "0x20FBBF4", Offset = "0x20FBBF4", VA = "0x20FBBF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007EAC")]
		[Address(RVA = "0x20FBFBC", Offset = "0x20FBFBC", VA = "0x20FBFBC", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6007EAD")]
		[Address(RVA = "0x20FC430", Offset = "0x20FC430", VA = "0x20FC430", Slot = "30")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
