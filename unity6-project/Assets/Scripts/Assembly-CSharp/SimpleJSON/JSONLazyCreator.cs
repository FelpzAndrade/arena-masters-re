using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x20010CE")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4005CA5")]
		[FieldOffset(Offset = "0x8")]
		private JSONNode m_Node;

		[Token(Token = "0x4005CA6")]
		[FieldOffset(Offset = "0xC")]
		private string m_Key;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F95")]
		[Token(Token = "0x6007EE8")]
		[Address(RVA = "0x21008D4", Offset = "0x21008D4", VA = "0x21008D4", Slot = "5")]
		public override JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6007EE9")]
		[Address(RVA = "0x2100970", Offset = "0x2100970", VA = "0x2100970", Slot = "6")]
		public override void set_Item(int aIndex, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000F96")]
		[Token(Token = "0x6007EEA")]
		[Address(RVA = "0x2100A4C", Offset = "0x2100A4C", VA = "0x2100A4C", Slot = "7")]
		public override JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6007EEB")]
		[Address(RVA = "0x2100AE8", Offset = "0x2100AE8", VA = "0x2100AE8", Slot = "8")]
		public override void set_Item(string aKey, JSONNode value)
		{
		}

		[Token(Token = "0x17000F97")]
		public override int AsInt
		{
			[Token(Token = "0x6007EF2")]
			[Address(RVA = "0x2100F28", Offset = "0x2100F28", VA = "0x2100F28", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007EF3")]
			[Address(RVA = "0x2100FC4", Offset = "0x2100FC4", VA = "0x2100FC4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000F98")]
		public override float AsFloat
		{
			[Token(Token = "0x6007EF4")]
			[Address(RVA = "0x2101060", Offset = "0x2101060", VA = "0x2101060", Slot = "22")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6007EF5")]
			[Address(RVA = "0x21010FC", Offset = "0x21010FC", VA = "0x21010FC", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000F99")]
		public override double AsDouble
		{
			[Token(Token = "0x6007EF6")]
			[Address(RVA = "0x2101198", Offset = "0x2101198", VA = "0x2101198", Slot = "24")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6007EF7")]
			[Address(RVA = "0x210124C", Offset = "0x210124C", VA = "0x210124C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000F9A")]
		public override bool AsBool
		{
			[Token(Token = "0x6007EF8")]
			[Address(RVA = "0x21012F8", Offset = "0x21012F8", VA = "0x21012F8", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007EF9")]
			[Address(RVA = "0x2101394", Offset = "0x2101394", VA = "0x2101394", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000F9B")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6007EFA")]
			[Address(RVA = "0x2101430", Offset = "0x2101430", VA = "0x2101430", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F9C")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6007EFB")]
			[Address(RVA = "0x21014C8", Offset = "0x21014C8", VA = "0x21014C8", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007EE5")]
		[Address(RVA = "0x20FB524", Offset = "0x20FB524", VA = "0x20FB524")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6007EE6")]
		[Address(RVA = "0x20FD108", Offset = "0x20FD108", VA = "0x20FD108")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6007EE7")]
		[Address(RVA = "0x2100824", Offset = "0x2100824", VA = "0x2100824")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6007EEC")]
		[Address(RVA = "0x2100BCC", Offset = "0x2100BCC", VA = "0x2100BCC", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6007EED")]
		[Address(RVA = "0x2100CA8", Offset = "0x2100CA8", VA = "0x2100CA8", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6007EEE")]
		[Address(RVA = "0x2100D8C", Offset = "0x2100D8C", VA = "0x2100D8C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6007EEF")]
		[Address(RVA = "0x2100DB8", Offset = "0x2100DB8", VA = "0x2100DB8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6007EF0")]
		[Address(RVA = "0x2100DC8", Offset = "0x2100DC8", VA = "0x2100DC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007EF1")]
		[Address(RVA = "0x2100E78", Offset = "0x2100E78", VA = "0x2100E78", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6007EFC")]
		[Address(RVA = "0x2101560", Offset = "0x2101560", VA = "0x2101560")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6007EFD")]
		[Address(RVA = "0x2101584", Offset = "0x2101584", VA = "0x2101584")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}
	}
}
