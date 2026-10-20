using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DE")]
	public class JArray : JContainer
	{
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x2C")]
		private IList<JToken> _values;

		[Token(Token = "0x17000130")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIsReadOnly
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xF88870", Offset = "0xF88870", VA = "0xF88870", Slot = "25")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x17000131")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0xF88878", Offset = "0xF88878", VA = "0xF88878", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		public override JTokenType Type
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xF88880", Offset = "0xF88880", VA = "0xF88880", Slot = "13")]
			get
			{
				return default(JTokenType);
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000133")]
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xF89E5C", Offset = "0xF89E5C", VA = "0xF89E5C", Slot = "15")]
		public override JToken get_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xF8A0B8", Offset = "0xF8A0B8", VA = "0xF8A0B8", Slot = "16")]
		public override void set_Item(object key, JToken value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000134")]
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xF8A31C", Offset = "0xF8A31C", VA = "0xF8A31C", Slot = "34")]
		public JToken get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xF8A368", Offset = "0xF8A368", VA = "0xF8A368", Slot = "35")]
		public void set_Item(int index, JToken value)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xF88254", Offset = "0xF88254", VA = "0xF88254")]
		public JArray()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xF88308", Offset = "0xF88308", VA = "0xF88308")]
		public JArray(JArray other)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xF88730", Offset = "0xF88730", VA = "0xF88730")]
		public JArray(params object[] content)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xF88734", Offset = "0xF88734", VA = "0xF88734")]
		public JArray(object content)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xF8881C", Offset = "0xF8881C", VA = "0xF8881C", Slot = "29")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xF88870", Offset = "0xF88870", VA = "0xF88870", Slot = "25")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_IsReadOnly()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xF88888", Offset = "0xF88888", VA = "0xF88888", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xF88AFC", Offset = "0xF88AFC", VA = "0xF88AFC", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xF88B8C", Offset = "0xF88B8C", VA = "0xF88B8C")]
		public new static JArray Load(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xF894B8", Offset = "0xF894B8", VA = "0xF894B8")]
		public new static JArray Parse(string json)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xF89570", Offset = "0xF89570", VA = "0xF89570")]
		public new static JArray FromObject(object o)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xF89604", Offset = "0xF89604", VA = "0xF89604")]
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xF89A68", Offset = "0xF89A68", VA = "0xF89A68", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xF8A3BC", Offset = "0xF8A3BC", VA = "0xF8A3BC", Slot = "31")]
		public int IndexOf(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xF8A4E0", Offset = "0xF8A4E0", VA = "0xF8A4E0", Slot = "32")]
		public void Insert(int index, JToken item)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xF8A534", Offset = "0xF8A534", VA = "0xF8A534", Slot = "33")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xF8A580", Offset = "0xF8A580", VA = "0xF8A580", Slot = "26")]
		public void Add(JToken item)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xF8A5CC", Offset = "0xF8A5CC", VA = "0xF8A5CC", Slot = "27")]
		public void Clear()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xF8A610", Offset = "0xF8A610", VA = "0xF8A610", Slot = "28")]
		public bool Contains(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xF8A65C", Offset = "0xF8A65C", VA = "0xF8A65C", Slot = "30")]
		public bool Remove(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xF8A6A8", Offset = "0xF8A6A8", VA = "0xF8A6A8", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}
	}
}
