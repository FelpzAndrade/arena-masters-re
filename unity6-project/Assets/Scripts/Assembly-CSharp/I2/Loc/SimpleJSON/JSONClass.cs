using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000076")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000077")]
		private sealed class _003C_003Ec__Iterator18 : IDisposable
		{
			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x8")]
			internal Dictionary<string, JSONNode>.Enumerator _003C_0024s_35_003E__0;

			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x1C")]
			internal KeyValuePair<string, JSONNode> _003CN_003E__1;

			[Token(Token = "0x400020C")]
			[FieldOffset(Offset = "0x24")]
			internal int _0024PC;

			[Token(Token = "0x400020D")]
			[FieldOffset(Offset = "0x28")]
			internal JSONNode _0024current;

			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x2C")]
			internal JSONClass _003C_003Ef__this;

			[Token(Token = "0x1700007A")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x60003CD")]
				[Address(RVA = "0xD83BCC", Offset = "0xD83BCC", VA = "0xD83BCC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700007B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60003CE")]
				[Address(RVA = "0xD83BD4", Offset = "0xD83BD4", VA = "0xD83BD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xD82574", Offset = "0xD82574", VA = "0xD82574")]
			public _003C_003Ec__Iterator18()
			{
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xD83BCC", Offset = "0xD83BCC", VA = "0xD83BCC", Slot = "9")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xD83BD4", Offset = "0xD83BD4", VA = "0xD83BD4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xD83BDC", Offset = "0xD83BDC", VA = "0xD83BDC", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xD83BE0", Offset = "0xD83BE0", VA = "0xD83BE0", Slot = "7")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xD83CBC", Offset = "0xD83CBC", VA = "0xD83CBC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xD83F44", Offset = "0xD83F44", VA = "0xD83F44", Slot = "10")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xD84094", Offset = "0xD84094", VA = "0xD84094", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000078")]
		private sealed class _003CGetEnumerator_003Ec__Iterator19 : IDisposable
		{
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x8")]
			internal Dictionary<string, JSONNode>.Enumerator _003C_0024s_36_003E__0;

			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x1C")]
			internal KeyValuePair<string, JSONNode> _003CN_003E__1;

			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x24")]
			internal int _0024PC;

			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x28")]
			internal object _0024current;

			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x2C")]
			internal JSONClass _003C_003Ef__this;

			[Token(Token = "0x1700007C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x60003D5")]
				[Address(RVA = "0xD84128", Offset = "0xD84128", VA = "0xD84128", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700007D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60003D6")]
				[Address(RVA = "0xD84130", Offset = "0xD84130", VA = "0xD84130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xD82620", Offset = "0xD82620", VA = "0xD82620")]
			public _003CGetEnumerator_003Ec__Iterator19()
			{
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xD84128", Offset = "0xD84128", VA = "0xD84128", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xD84130", Offset = "0xD84130", VA = "0xD84130", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0xD84138", Offset = "0xD84138", VA = "0xD84138", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xD843D0", Offset = "0xD843D0", VA = "0xD843D0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xD84520", Offset = "0xD84520", VA = "0xD84520", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000079")]
		private sealed class _003CRemove_003Ec__AnonStoreyC2
		{
			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x8")]
			internal JSONNode aNode;

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xD824C0", Offset = "0xD824C0", VA = "0xD824C0")]
			public _003CRemove_003Ec__AnonStoreyC2()
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xD845B4", Offset = "0xD845B4", VA = "0xD845B4")]
			internal bool _003C_003Em__2B(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, JSONNode> m_Dict;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000076")]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xD81860", Offset = "0xD81860", VA = "0xD81860", Slot = "7")]
		public override JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xD8199C", Offset = "0xD8199C", VA = "0xD8199C", Slot = "8")]
		public override void set_Item(string aKey, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000077")]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xD81AAC", Offset = "0xD81AAC", VA = "0xD81AAC", Slot = "5")]
		public override JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xD81BC4", Offset = "0xD81BC4", VA = "0xD81BC4", Slot = "6")]
		public override void set_Item(int aIndex, JSONNode value)
		{
		}

		[Token(Token = "0x17000078")]
		public override int Count
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xD81D0C", Offset = "0xD81D0C", VA = "0xD81D0C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000079")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xD824C8", Offset = "0xD824C8", VA = "0xD824C8", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xD817B4", Offset = "0xD817B4", VA = "0xD817B4")]
		public JSONClass()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xD81DA4", Offset = "0xD81DA4", VA = "0xD81DA4", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xD81FB8", Offset = "0xD81FB8", VA = "0xD81FB8", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xD820CC", Offset = "0xD820CC", VA = "0xD820CC", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xD82230", Offset = "0xD82230", VA = "0xD82230", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xD8257C", Offset = "0xD8257C", VA = "0xD8257C", Slot = "29")]
		[DebuggerHidden]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xD82628", Offset = "0xD82628", VA = "0xD82628", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xD830E8", Offset = "0xD830E8", VA = "0xD830E8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xD83800", Offset = "0xD83800", VA = "0xD83800", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
