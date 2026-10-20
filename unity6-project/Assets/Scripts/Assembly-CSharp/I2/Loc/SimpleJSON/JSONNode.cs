using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000070")]
	public class JSONNode
	{
		[Token(Token = "0x2000071")]
		private sealed class _003C_003Ec__Iterator14 : IDisposable
		{
			[Token(Token = "0x40001F5")]
			[FieldOffset(Offset = "0x8")]
			internal int _0024PC;

			[Token(Token = "0x40001F6")]
			[FieldOffset(Offset = "0xC")]
			internal JSONNode _0024current;

			[Token(Token = "0x1700006A")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0xD87BBC", Offset = "0xD87BBC", VA = "0xD87BBC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700006B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000393")]
				[Address(RVA = "0xD87BC4", Offset = "0xD87BC4", VA = "0xD87BC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0xD860A0", Offset = "0xD860A0", VA = "0xD860A0")]
			public _003C_003Ec__Iterator14()
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0xD87BBC", Offset = "0xD87BBC", VA = "0xD87BBC", Slot = "9")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0xD87BC4", Offset = "0xD87BC4", VA = "0xD87BC4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0xD87BCC", Offset = "0xD87BCC", VA = "0xD87BCC", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0xD87BD0", Offset = "0xD87BD0", VA = "0xD87BD0", Slot = "7")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000396")]
			[Address(RVA = "0xD87C8C", Offset = "0xD87C8C", VA = "0xD87C8C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0xD87C9C", Offset = "0xD87C9C", VA = "0xD87C9C", Slot = "10")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0xD87CA8", Offset = "0xD87CA8", VA = "0xD87CA8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000072")]
		private sealed class _003C_003Ec__Iterator15 : IDisposable
		{
			[Token(Token = "0x40001F7")]
			[FieldOffset(Offset = "0x8")]
			internal IEnumerator<JSONNode> _003C_0024s_27_003E__0;

			[Token(Token = "0x40001F8")]
			[FieldOffset(Offset = "0xC")]
			internal JSONNode _003CC_003E__1;

			[Token(Token = "0x40001F9")]
			[FieldOffset(Offset = "0x10")]
			internal IEnumerator<JSONNode> _003C_0024s_28_003E__2;

			[Token(Token = "0x40001FA")]
			[FieldOffset(Offset = "0x14")]
			internal JSONNode _003CD_003E__3;

			[Token(Token = "0x40001FB")]
			[FieldOffset(Offset = "0x18")]
			internal int _0024PC;

			[Token(Token = "0x40001FC")]
			[FieldOffset(Offset = "0x1C")]
			internal JSONNode _0024current;

			[Token(Token = "0x40001FD")]
			[FieldOffset(Offset = "0x20")]
			internal JSONNode _003C_003Ef__this;

			[Token(Token = "0x1700006C")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0xD87D3C", Offset = "0xD87D3C", VA = "0xD87D3C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700006D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600039B")]
				[Address(RVA = "0xD87D44", Offset = "0xD87D44", VA = "0xD87D44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000399")]
			[Address(RVA = "0xD86154", Offset = "0xD86154", VA = "0xD86154")]
			public _003C_003Ec__Iterator15()
			{
			}

			[Token(Token = "0x600039A")]
			[Address(RVA = "0xD87D3C", Offset = "0xD87D3C", VA = "0xD87D3C", Slot = "9")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0xD87D44", Offset = "0xD87D44", VA = "0xD87D44", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0xD87D4C", Offset = "0xD87D4C", VA = "0xD87D4C", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0xD87D50", Offset = "0xD87D50", VA = "0xD87D50", Slot = "7")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0xD87E2C", Offset = "0xD87E2C", VA = "0xD87E2C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0xD884E4", Offset = "0xD884E4", VA = "0xD884E4", Slot = "10")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xD886B4", Offset = "0xD886B4", VA = "0xD886B4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700005E")]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xD85E1C", Offset = "0xD85E1C", VA = "0xD85E1C", Slot = "5")]
		public virtual JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xD85E24", Offset = "0xD85E24", VA = "0xD85E24", Slot = "6")]
		public virtual void set_Item(int aIndex, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700005F")]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD85E28", Offset = "0xD85E28", VA = "0xD85E28", Slot = "7")]
		public virtual JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xD85E30", Offset = "0xD85E30", VA = "0xD85E30", Slot = "8")]
		public virtual void set_Item(string aKey, JSONNode value)
		{
		}

		[Token(Token = "0x17000060")]
		public virtual string Value
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0xD85E34", Offset = "0xD85E34", VA = "0xD85E34", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0xD85EE4", Offset = "0xD85EE4", VA = "0xD85EE4", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public virtual int Count
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xD85EE8", Offset = "0xD85EE8", VA = "0xD85EE8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0xD85FFC", Offset = "0xD85FFC", VA = "0xD85FFC", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0xD860A8", Offset = "0xD860A8", VA = "0xD860A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xD8624C", Offset = "0xD8624C", VA = "0xD8624C", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xD862B8", Offset = "0xD862B8", VA = "0xD862B8", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xD86314", Offset = "0xD86314", VA = "0xD86314", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xD8638C", Offset = "0xD8638C", VA = "0xD8638C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xD863E8", Offset = "0xD863E8", VA = "0xD863E8", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xD86460", Offset = "0xD86460", VA = "0xD86460", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xD864BC", Offset = "0xD864BC", VA = "0xD864BC", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xD8663C", Offset = "0xD8663C", VA = "0xD8663C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xD86718", Offset = "0xD86718", VA = "0xD86718", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xD867CC", Offset = "0xD867CC", VA = "0xD867CC", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xD7FC6C", Offset = "0xD7FC6C", VA = "0xD7FC6C")]
		public JSONNode()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xD85E18", Offset = "0xD85E18", VA = "0xD85E18", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xD85EF0", Offset = "0xD85EF0", VA = "0xD85EF0", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD85FE4", Offset = "0xD85FE4", VA = "0xD85FE4", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xD85FEC", Offset = "0xD85FEC", VA = "0xD85FEC", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xD85FF4", Offset = "0xD85FF4", VA = "0xD85FF4", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD8615C", Offset = "0xD8615C", VA = "0xD8615C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xD861D4", Offset = "0xD861D4", VA = "0xD861D4", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xD86880", Offset = "0xD86880", VA = "0xD86880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xD8562C", Offset = "0xD8562C", VA = "0xD8562C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xD82C98", Offset = "0xD82C98", VA = "0xD82C98")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xD7E950", Offset = "0xD7E950", VA = "0xD7E950")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xD8693C", Offset = "0xD8693C", VA = "0xD8693C", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xD86940", Offset = "0xD86940", VA = "0xD86940")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xD86A0C", Offset = "0xD86A0C", VA = "0xD86A0C")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xD86AB4", Offset = "0xD86AB4", VA = "0xD86AB4")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xD86B5C", Offset = "0xD86B5C", VA = "0xD86B5C")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xD86C04", Offset = "0xD86C04", VA = "0xD86C04")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xD86DF8", Offset = "0xD86DF8", VA = "0xD86DF8")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xD87030", Offset = "0xD87030", VA = "0xD87030")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xD87554", Offset = "0xD87554", VA = "0xD87554")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xD875FC", Offset = "0xD875FC", VA = "0xD875FC")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xD876A4", Offset = "0xD876A4", VA = "0xD876A4")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xD8774C", Offset = "0xD8774C", VA = "0xD8774C")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xD878C0", Offset = "0xD878C0", VA = "0xD878C0")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xD87A18", Offset = "0xD87A18", VA = "0xD87A18")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xD868A8", Offset = "0xD868A8", VA = "0xD868A8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xD87B4C", Offset = "0xD87B4C", VA = "0xD87B4C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xD84650", Offset = "0xD84650", VA = "0xD84650")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xD86894", Offset = "0xD86894", VA = "0xD86894")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}
	}
}
