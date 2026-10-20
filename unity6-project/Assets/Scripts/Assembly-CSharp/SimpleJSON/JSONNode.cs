using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x20010C3")]
	public class JSONNode
	{
		[Token(Token = "0x20010C4")]
		private sealed class _003C_003Ec__IteratorB5 : IDisposable
		{
			[Token(Token = "0x4005C84")]
			[FieldOffset(Offset = "0x8")]
			internal int _0024PC;

			[Token(Token = "0x4005C85")]
			[FieldOffset(Offset = "0xC")]
			internal JSONNode _0024current;

			[Token(Token = "0x17000F80")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6007E91")]
				[Address(RVA = "0x2103428", Offset = "0x2103428", VA = "0x2103428", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F81")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007E92")]
				[Address(RVA = "0x2103430", Offset = "0x2103430", VA = "0x2103430", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6007E90")]
			[Address(RVA = "0x2101834", Offset = "0x2101834", VA = "0x2101834")]
			public _003C_003Ec__IteratorB5()
			{
			}

			[Token(Token = "0x6007E91")]
			[Address(RVA = "0x2103428", Offset = "0x2103428", VA = "0x2103428", Slot = "10")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007E92")]
			[Address(RVA = "0x2103430", Offset = "0x2103430", VA = "0x2103430", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007E93")]
			[Address(RVA = "0x2103438", Offset = "0x2103438", VA = "0x2103438", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007E94")]
			[Address(RVA = "0x210343C", Offset = "0x210343C", VA = "0x210343C", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007E95")]
			[Address(RVA = "0x21034F8", Offset = "0x21034F8", VA = "0x21034F8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007E96")]
			[Address(RVA = "0x2103508", Offset = "0x2103508", VA = "0x2103508", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6007E97")]
			[Address(RVA = "0x2103514", Offset = "0x2103514", VA = "0x2103514", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20010C5")]
		private sealed class _003C_003Ec__IteratorB6 : IDisposable
		{
			[Token(Token = "0x4005C86")]
			[FieldOffset(Offset = "0x8")]
			internal IEnumerator<JSONNode> _003C_0024s_519_003E__0;

			[Token(Token = "0x4005C87")]
			[FieldOffset(Offset = "0xC")]
			internal JSONNode _003CC_003E__1;

			[Token(Token = "0x4005C88")]
			[FieldOffset(Offset = "0x10")]
			internal IEnumerator<JSONNode> _003C_0024s_520_003E__2;

			[Token(Token = "0x4005C89")]
			[FieldOffset(Offset = "0x14")]
			internal JSONNode _003CD_003E__3;

			[Token(Token = "0x4005C8A")]
			[FieldOffset(Offset = "0x18")]
			internal int _0024PC;

			[Token(Token = "0x4005C8B")]
			[FieldOffset(Offset = "0x1C")]
			internal JSONNode _0024current;

			[Token(Token = "0x4005C8C")]
			[FieldOffset(Offset = "0x20")]
			internal JSONNode _003C_003Ef__this;

			[Token(Token = "0x17000F82")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6007E99")]
				[Address(RVA = "0x21035A8", Offset = "0x21035A8", VA = "0x21035A8", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F83")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007E9A")]
				[Address(RVA = "0x21035B0", Offset = "0x21035B0", VA = "0x21035B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6007E98")]
			[Address(RVA = "0x21018E8", Offset = "0x21018E8", VA = "0x21018E8")]
			public _003C_003Ec__IteratorB6()
			{
			}

			[Token(Token = "0x6007E99")]
			[Address(RVA = "0x21035A8", Offset = "0x21035A8", VA = "0x21035A8", Slot = "10")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007E9A")]
			[Address(RVA = "0x21035B0", Offset = "0x21035B0", VA = "0x21035B0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007E9B")]
			[Address(RVA = "0x21035B8", Offset = "0x21035B8", VA = "0x21035B8", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007E9C")]
			[Address(RVA = "0x21035BC", Offset = "0x21035BC", VA = "0x21035BC", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6007E9D")]
			[Address(RVA = "0x2103698", Offset = "0x2103698", VA = "0x2103698", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007E9E")]
			[Address(RVA = "0x2103D50", Offset = "0x2103D50", VA = "0x2103D50", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6007E9F")]
			[Address(RVA = "0x2103F20", Offset = "0x2103F20", VA = "0x2103F20", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F73")]
		[Token(Token = "0x6007E5F")]
		[Address(RVA = "0x21015B0", Offset = "0x21015B0", VA = "0x21015B0", Slot = "5")]
		public virtual JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6007E60")]
		[Address(RVA = "0x21015B8", Offset = "0x21015B8", VA = "0x21015B8", Slot = "6")]
		public virtual void set_Item(int aIndex, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F74")]
		[Token(Token = "0x6007E61")]
		[Address(RVA = "0x21015BC", Offset = "0x21015BC", VA = "0x21015BC", Slot = "7")]
		public virtual JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6007E62")]
		[Address(RVA = "0x21015C4", Offset = "0x21015C4", VA = "0x21015C4", Slot = "8")]
		public virtual void set_Item(string aKey, JSONNode value)
		{
		}

		[Token(Token = "0x17000F75")]
		public virtual string Value
		{
			[Token(Token = "0x6007E63")]
			[Address(RVA = "0x21015C8", Offset = "0x21015C8", VA = "0x21015C8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007E64")]
			[Address(RVA = "0x2101678", Offset = "0x2101678", VA = "0x2101678", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000F76")]
		public virtual int Count
		{
			[Token(Token = "0x6007E65")]
			[Address(RVA = "0x210167C", Offset = "0x210167C", VA = "0x210167C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000F77")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007E6A")]
			[Address(RVA = "0x2101790", Offset = "0x2101790", VA = "0x2101790", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F78")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6007E6B")]
			[Address(RVA = "0x210183C", Offset = "0x210183C", VA = "0x210183C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F79")]
		public virtual int AsInt
		{
			[Token(Token = "0x6007E6E")]
			[Address(RVA = "0x21019E0", Offset = "0x21019E0", VA = "0x21019E0", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007E6F")]
			[Address(RVA = "0x2101A4C", Offset = "0x2101A4C", VA = "0x2101A4C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000F7A")]
		public virtual long AsLong
		{
			[Token(Token = "0x6007E70")]
			[Address(RVA = "0x2101AA8", Offset = "0x2101AA8", VA = "0x2101AA8", Slot = "20")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6007E71")]
			[Address(RVA = "0x2101B24", Offset = "0x2101B24", VA = "0x2101B24", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000F7B")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6007E72")]
			[Address(RVA = "0x2101B80", Offset = "0x2101B80", VA = "0x2101B80", Slot = "22")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6007E73")]
			[Address(RVA = "0x2101BF8", Offset = "0x2101BF8", VA = "0x2101BF8", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000F7C")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6007E74")]
			[Address(RVA = "0x2101C54", Offset = "0x2101C54", VA = "0x2101C54", Slot = "24")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6007E75")]
			[Address(RVA = "0x2101CCC", Offset = "0x2101CCC", VA = "0x2101CCC", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000F7D")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6007E76")]
			[Address(RVA = "0x2101D28", Offset = "0x2101D28", VA = "0x2101D28", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007E77")]
			[Address(RVA = "0x2101EA8", Offset = "0x2101EA8", VA = "0x2101EA8", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000F7E")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6007E78")]
			[Address(RVA = "0x2101F84", Offset = "0x2101F84", VA = "0x2101F84", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F7F")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6007E79")]
			[Address(RVA = "0x2102038", Offset = "0x2102038", VA = "0x2102038", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E5D")]
		[Address(RVA = "0x20FB400", Offset = "0x20FB400", VA = "0x20FB400")]
		public JSONNode()
		{
		}

		[Token(Token = "0x6007E5E")]
		[Address(RVA = "0x21015AC", Offset = "0x21015AC", VA = "0x21015AC", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6007E66")]
		[Address(RVA = "0x2101684", Offset = "0x2101684", VA = "0x2101684", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6007E67")]
		[Address(RVA = "0x2101778", Offset = "0x2101778", VA = "0x2101778", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6007E68")]
		[Address(RVA = "0x2101780", Offset = "0x2101780", VA = "0x2101780", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6007E69")]
		[Address(RVA = "0x2101788", Offset = "0x2101788", VA = "0x2101788", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6007E6C")]
		[Address(RVA = "0x21018F0", Offset = "0x21018F0", VA = "0x21018F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007E6D")]
		[Address(RVA = "0x2101968", Offset = "0x2101968", VA = "0x2101968", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6007E7A")]
		[Address(RVA = "0x21020EC", Offset = "0x21020EC", VA = "0x21020EC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E7B")]
		[Address(RVA = "0x2100DC0", Offset = "0x2100DC0", VA = "0x2100DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6007E7C")]
		[Address(RVA = "0x20FE42C", Offset = "0x20FE42C", VA = "0x20FE42C")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6007E7D")]
		[Address(RVA = "0x20FA0E4", Offset = "0x20FA0E4", VA = "0x20FA0E4")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6007E7E")]
		[Address(RVA = "0x21021A8", Offset = "0x21021A8", VA = "0x21021A8", Slot = "30")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6007E7F")]
		[Address(RVA = "0x21021AC", Offset = "0x21021AC", VA = "0x21021AC")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6007E80")]
		[Address(RVA = "0x2102278", Offset = "0x2102278", VA = "0x2102278")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6007E81")]
		[Address(RVA = "0x2102320", Offset = "0x2102320", VA = "0x2102320")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6007E82")]
		[Address(RVA = "0x21023C8", Offset = "0x21023C8", VA = "0x21023C8")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6007E83")]
		[Address(RVA = "0x2102470", Offset = "0x2102470", VA = "0x2102470")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6007E84")]
		[Address(RVA = "0x2102664", Offset = "0x2102664", VA = "0x2102664")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6007E85")]
		[Address(RVA = "0x210289C", Offset = "0x210289C", VA = "0x210289C")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6007E86")]
		[Address(RVA = "0x2102DC0", Offset = "0x2102DC0", VA = "0x2102DC0")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6007E87")]
		[Address(RVA = "0x2102E68", Offset = "0x2102E68", VA = "0x2102E68")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6007E88")]
		[Address(RVA = "0x2102F10", Offset = "0x2102F10", VA = "0x2102F10")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6007E89")]
		[Address(RVA = "0x2102FB8", Offset = "0x2102FB8", VA = "0x2102FB8")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6007E8A")]
		[Address(RVA = "0x210312C", Offset = "0x210312C", VA = "0x210312C")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6007E8B")]
		[Address(RVA = "0x2103284", Offset = "0x2103284", VA = "0x2103284")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6007E8C")]
		[Address(RVA = "0x2102114", Offset = "0x2102114", VA = "0x2102114")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6007E8D")]
		[Address(RVA = "0x21033B8", Offset = "0x21033B8", VA = "0x21033B8")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6007E8E")]
		[Address(RVA = "0x20FFDE4", Offset = "0x20FFDE4", VA = "0x20FFDE4")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E8F")]
		[Address(RVA = "0x2102100", Offset = "0x2102100", VA = "0x2102100")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}
	}
}
