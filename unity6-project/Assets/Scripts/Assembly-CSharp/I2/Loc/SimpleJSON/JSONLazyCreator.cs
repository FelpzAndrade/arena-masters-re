using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x200007B")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x8")]
		private JSONNode m_Node;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0xC")]
		private string m_Key;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700007F")]
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xD85140", Offset = "0xD85140", VA = "0xD85140", Slot = "5")]
		public override JSONNode get_Item(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xD851DC", Offset = "0xD851DC", VA = "0xD851DC", Slot = "6")]
		public override void set_Item(int aIndex, JSONNode value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000080")]
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xD852B8", Offset = "0xD852B8", VA = "0xD852B8", Slot = "7")]
		public override JSONNode get_Item(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD85354", Offset = "0xD85354", VA = "0xD85354", Slot = "8")]
		public override void set_Item(string aKey, JSONNode value)
		{
		}

		[Token(Token = "0x17000081")]
		public override int AsInt
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xD85794", Offset = "0xD85794", VA = "0xD85794", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xD85830", Offset = "0xD85830", VA = "0xD85830", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public override float AsFloat
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xD858CC", Offset = "0xD858CC", VA = "0xD858CC", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xD85968", Offset = "0xD85968", VA = "0xD85968", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public override double AsDouble
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xD85A04", Offset = "0xD85A04", VA = "0xD85A04", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xD85AB8", Offset = "0xD85AB8", VA = "0xD85AB8", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public override bool AsBool
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xD85B64", Offset = "0xD85B64", VA = "0xD85B64", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xD85C00", Offset = "0xD85C00", VA = "0xD85C00", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xD85C9C", Offset = "0xD85C9C", VA = "0xD85C9C", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xD85D34", Offset = "0xD85D34", VA = "0xD85D34", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xD7FD90", Offset = "0xD7FD90", VA = "0xD7FD90")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xD81974", Offset = "0xD81974", VA = "0xD81974")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xD85090", Offset = "0xD85090", VA = "0xD85090")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xD85438", Offset = "0xD85438", VA = "0xD85438", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xD85514", Offset = "0xD85514", VA = "0xD85514", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD855F8", Offset = "0xD855F8", VA = "0xD855F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xD85624", Offset = "0xD85624", VA = "0xD85624", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xD85634", Offset = "0xD85634", VA = "0xD85634", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD856E4", Offset = "0xD856E4", VA = "0xD856E4", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD85DCC", Offset = "0xD85DCC", VA = "0xD85DCC")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD85DF0", Offset = "0xD85DF0", VA = "0xD85DF0")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}
	}
}
