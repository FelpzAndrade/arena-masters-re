using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000073")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000074")]
		private sealed class _003C_003Ec__Iterator16 : IDisposable
		{
			[Token(Token = "0x40001FF")]
			[FieldOffset(Offset = "0x8")]
			internal List<JSONNode>.Enumerator _003C_0024s_31_003E__0;

			[Token(Token = "0x4000200")]
			[FieldOffset(Offset = "0x18")]
			internal JSONNode _003CN_003E__1;

			[Token(Token = "0x4000201")]
			[FieldOffset(Offset = "0x1C")]
			internal int _0024PC;

			[Token(Token = "0x4000202")]
			[FieldOffset(Offset = "0x20")]
			internal JSONNode _0024current;

			[Token(Token = "0x4000203")]
			[FieldOffset(Offset = "0x24")]
			internal JSONArray _003C_003Ef__this;

			[Token(Token = "0x17000072")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x60003B0")]
				[Address(RVA = "0xD80E5C", Offset = "0xD80E5C", VA = "0xD80E5C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000073")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0xD80E64", Offset = "0xD80E64", VA = "0xD80E64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xD803AC", Offset = "0xD803AC", VA = "0xD803AC")]
			public _003C_003Ec__Iterator16()
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xD80E5C", Offset = "0xD80E5C", VA = "0xD80E5C", Slot = "9")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xD80E64", Offset = "0xD80E64", VA = "0xD80E64", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xD80E6C", Offset = "0xD80E6C", VA = "0xD80E6C", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xD80E70", Offset = "0xD80E70", VA = "0xD80E70", Slot = "7")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xD80F4C", Offset = "0xD80F4C", VA = "0xD80F4C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xD8119C", Offset = "0xD8119C", VA = "0xD8119C", Slot = "10")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xD812E4", Offset = "0xD812E4", VA = "0xD812E4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000075")]
		private sealed class _003CGetEnumerator_003Ec__Iterator17 : IDisposable
		{
			[Token(Token = "0x4000204")]
			[FieldOffset(Offset = "0x8")]
			internal List<JSONNode>.Enumerator _003C_0024s_32_003E__0;

			[Token(Token = "0x4000205")]
			[FieldOffset(Offset = "0x18")]
			internal JSONNode _003CN_003E__1;

			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0x1C")]
			internal int _0024PC;

			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x20")]
			internal object _0024current;

			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x24")]
			internal JSONArray _003C_003Ef__this;

			[Token(Token = "0x17000074")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0xD81378", Offset = "0xD81378", VA = "0xD81378", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000075")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60003B9")]
				[Address(RVA = "0xD81380", Offset = "0xD81380", VA = "0xD81380", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xD80458", Offset = "0xD80458", VA = "0xD80458")]
			public _003CGetEnumerator_003Ec__Iterator17()
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xD81378", Offset = "0xD81378", VA = "0xD81378", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xD81380", Offset = "0xD81380", VA = "0xD81380", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xD81388", Offset = "0xD81388", VA = "0xD81388", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xD815D8", Offset = "0xD815D8", VA = "0xD815D8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xD81720", Offset = "0xD81720", VA = "0xD81720", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x8")]
		private List<JSONNode> m_List;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700006E")]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD7FC74", Offset = "0xD7FC74", VA = "0xD7FC74", Slot = "5")]
		public override JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD7FDB8", Offset = "0xD7FDB8", VA = "0xD7FDB8", Slot = "6")]
		public override void set_Item(int aIndex, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700006F")]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xD7FED0", Offset = "0xD7FED0", VA = "0xD7FED0", Slot = "7")]
		public override JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xD7FF6C", Offset = "0xD7FF6C", VA = "0xD7FF6C", Slot = "8")]
		public override void set_Item(string aKey, JSONNode value)
		{
		}

		[Token(Token = "0x17000070")]
		public override int Count
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xD8000C", Offset = "0xD8000C", VA = "0xD8000C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xD80300", Offset = "0xD80300", VA = "0xD80300", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xD7FBC0", Offset = "0xD7FBC0", VA = "0xD7FBC0")]
		public JSONArray()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD800A4", Offset = "0xD800A4", VA = "0xD800A4", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xD80144", Offset = "0xD80144", VA = "0xD80144", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xD8025C", Offset = "0xD8025C", VA = "0xD8025C", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD803B4", Offset = "0xD803B4", VA = "0xD803B4", Slot = "29")]
		[DebuggerHidden]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xD80460", Offset = "0xD80460", VA = "0xD80460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xD80828", Offset = "0xD80828", VA = "0xD80828", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xD80C9C", Offset = "0xD80C9C", VA = "0xD80C9C", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
