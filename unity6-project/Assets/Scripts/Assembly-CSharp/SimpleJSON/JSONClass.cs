using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x20010C9")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x20010CA")]
		private sealed class _003C_003Ec__IteratorB9 : IDisposable
		{
			[Token(Token = "0x4005C99")]
			[FieldOffset(Offset = "0x8")]
			internal Dictionary<string, JSONNode>.Enumerator _003C_0024s_527_003E__0;

			[Token(Token = "0x4005C9A")]
			[FieldOffset(Offset = "0x1C")]
			internal KeyValuePair<string, JSONNode> _003CN_003E__1;

			[Token(Token = "0x4005C9B")]
			[FieldOffset(Offset = "0x24")]
			internal int _0024PC;

			[Token(Token = "0x4005C9C")]
			[FieldOffset(Offset = "0x28")]
			internal JSONNode _0024current;

			[Token(Token = "0x4005C9D")]
			[FieldOffset(Offset = "0x2C")]
			internal JSONClass _003C_003Ef__this;

			[Token(Token = "0x17000F90")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6007ECC")]
				[Address(RVA = "0x20FF360", Offset = "0x20FF360", VA = "0x20FF360", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F91")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007ECD")]
				[Address(RVA = "0x20FF368", Offset = "0x20FF368", VA = "0x20FF368", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6007ECB")]
			[Address(RVA = "0x20FDD08", Offset = "0x20FDD08", VA = "0x20FDD08")]
			public _003C_003Ec__IteratorB9()
			{
			}

			[Token(Token = "0x6007ECC")]
			[Address(RVA = "0x20FF360", Offset = "0x20FF360", VA = "0x20FF360", Slot = "10")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007ECD")]
			[Address(RVA = "0x20FF368", Offset = "0x20FF368", VA = "0x20FF368", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007ECE")]
			[Address(RVA = "0x20FF370", Offset = "0x20FF370", VA = "0x20FF370", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007ECF")]
			[Address(RVA = "0x20FF374", Offset = "0x20FF374", VA = "0x20FF374", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007ED0")]
			[Address(RVA = "0x20FF450", Offset = "0x20FF450", VA = "0x20FF450", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007ED1")]
			[Address(RVA = "0x20FF6D8", Offset = "0x20FF6D8", VA = "0x20FF6D8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6007ED2")]
			[Address(RVA = "0x20FF828", Offset = "0x20FF828", VA = "0x20FF828", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20010CB")]
		private sealed class _003CGetEnumerator_003Ec__IteratorBA : IDisposable
		{
			[Token(Token = "0x4005C9E")]
			[FieldOffset(Offset = "0x8")]
			internal Dictionary<string, JSONNode>.Enumerator _003C_0024s_528_003E__0;

			[Token(Token = "0x4005C9F")]
			[FieldOffset(Offset = "0x1C")]
			internal KeyValuePair<string, JSONNode> _003CN_003E__1;

			[Token(Token = "0x4005CA0")]
			[FieldOffset(Offset = "0x24")]
			internal int _0024PC;

			[Token(Token = "0x4005CA1")]
			[FieldOffset(Offset = "0x28")]
			internal object _0024current;

			[Token(Token = "0x4005CA2")]
			[FieldOffset(Offset = "0x2C")]
			internal JSONClass _003C_003Ef__this;

			[Token(Token = "0x17000F92")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6007ED4")]
				[Address(RVA = "0x20FF8BC", Offset = "0x20FF8BC", VA = "0x20FF8BC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F93")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007ED5")]
				[Address(RVA = "0x20FF8C4", Offset = "0x20FF8C4", VA = "0x20FF8C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6007ED3")]
			[Address(RVA = "0x20FDDB4", Offset = "0x20FDDB4", VA = "0x20FDDB4")]
			public _003CGetEnumerator_003Ec__IteratorBA()
			{
			}

			[Token(Token = "0x6007ED4")]
			[Address(RVA = "0x20FF8BC", Offset = "0x20FF8BC", VA = "0x20FF8BC", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007ED5")]
			[Address(RVA = "0x20FF8C4", Offset = "0x20FF8C4", VA = "0x20FF8C4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007ED6")]
			[Address(RVA = "0x20FF8CC", Offset = "0x20FF8CC", VA = "0x20FF8CC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007ED7")]
			[Address(RVA = "0x20FFB64", Offset = "0x20FFB64", VA = "0x20FFB64", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6007ED8")]
			[Address(RVA = "0x20FFCB4", Offset = "0x20FFCB4", VA = "0x20FFCB4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20010CC")]
		private sealed class _003CRemove_003Ec__AnonStorey25D
		{
			[Token(Token = "0x4005CA3")]
			[FieldOffset(Offset = "0x8")]
			internal JSONNode aNode;

			[Token(Token = "0x6007ED9")]
			[Address(RVA = "0x20FDC54", Offset = "0x20FDC54", VA = "0x20FDC54")]
			public _003CRemove_003Ec__AnonStorey25D()
			{
			}

			[Token(Token = "0x6007EDA")]
			[Address(RVA = "0x20FFD48", Offset = "0x20FFD48", VA = "0x20FFD48")]
			internal bool _003C_003Em__53F(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4005C98")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, JSONNode> m_Dict;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F8C")]
		[Token(Token = "0x6007EBD")]
		[Address(RVA = "0x20FCFF4", Offset = "0x20FCFF4", VA = "0x20FCFF4", Slot = "7")]
		public override JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6007EBE")]
		[Address(RVA = "0x20FD130", Offset = "0x20FD130", VA = "0x20FD130", Slot = "8")]
		public override void set_Item(string aKey, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F8D")]
		[Token(Token = "0x6007EBF")]
		[Address(RVA = "0x20FD240", Offset = "0x20FD240", VA = "0x20FD240", Slot = "5")]
		public override JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6007EC0")]
		[Address(RVA = "0x20FD358", Offset = "0x20FD358", VA = "0x20FD358", Slot = "6")]
		public override void set_Item(int aIndex, JSONNode value)
		{
		}

		[Token(Token = "0x17000F8E")]
		public override int Count
		{
			[Token(Token = "0x6007EC1")]
			[Address(RVA = "0x20FD4A0", Offset = "0x20FD4A0", VA = "0x20FD4A0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000F8F")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007EC6")]
			[Address(RVA = "0x20FDC5C", Offset = "0x20FDC5C", VA = "0x20FDC5C", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007EBC")]
		[Address(RVA = "0x20FCF48", Offset = "0x20FCF48", VA = "0x20FCF48")]
		public JSONClass()
		{
		}

		[Token(Token = "0x6007EC2")]
		[Address(RVA = "0x20FD538", Offset = "0x20FD538", VA = "0x20FD538", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6007EC3")]
		[Address(RVA = "0x20FD74C", Offset = "0x20FD74C", VA = "0x20FD74C", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6007EC4")]
		[Address(RVA = "0x20FD860", Offset = "0x20FD860", VA = "0x20FD860", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6007EC5")]
		[Address(RVA = "0x20FD9C4", Offset = "0x20FD9C4", VA = "0x20FD9C4", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6007EC7")]
		[Address(RVA = "0x20FDD10", Offset = "0x20FDD10", VA = "0x20FDD10", Slot = "31")]
		[DebuggerHidden]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6007EC8")]
		[Address(RVA = "0x20FDDBC", Offset = "0x20FDDBC", VA = "0x20FDDBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007EC9")]
		[Address(RVA = "0x20FE87C", Offset = "0x20FE87C", VA = "0x20FE87C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6007ECA")]
		[Address(RVA = "0x20FEF94", Offset = "0x20FEF94", VA = "0x20FEF94", Slot = "30")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
