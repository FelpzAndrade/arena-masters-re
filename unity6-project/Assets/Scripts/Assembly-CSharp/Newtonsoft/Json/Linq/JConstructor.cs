using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DF")]
	public class JConstructor : JContainer
	{
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x2C")]
		private string _name;

		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x30")]
		private IList<JToken> _values;

		[Token(Token = "0x17000135")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0xF8ACD4", Offset = "0xF8ACD4", VA = "0xF8ACD4", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		public string Name
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0xF8ABA4", Offset = "0xF8ABA4", VA = "0xF8ABA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0xF8ACDC", Offset = "0xF8ACDC", VA = "0xF8ACDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public override JTokenType Type
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0xF8ACE4", Offset = "0xF8ACE4", VA = "0xF8ACE4", Slot = "13")]
			get
			{
				return default(JTokenType);
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000138")]
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xF8B238", Offset = "0xF8B238", VA = "0xF8B238", Slot = "15")]
		public override JToken get_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xF8B494", Offset = "0xF8B494", VA = "0xF8B494", Slot = "16")]
		public override void set_Item(object key, JToken value)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xF8AA30", Offset = "0xF8AA30", VA = "0xF8AA30")]
		public JConstructor()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xF8AADC", Offset = "0xF8AADC", VA = "0xF8AADC")]
		public JConstructor(JConstructor other)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xF8ABAC", Offset = "0xF8ABAC", VA = "0xF8ABAC")]
		public JConstructor(string name, params object[] content)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xF8ABB0", Offset = "0xF8ABB0", VA = "0xF8ABB0")]
		public JConstructor(string name, object content)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xF8AC00", Offset = "0xF8AC00", VA = "0xF8AC00")]
		public JConstructor(string name)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xF8ACEC", Offset = "0xF8ACEC", VA = "0xF8ACEC", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xF8AE14", Offset = "0xF8AE14", VA = "0xF8AE14", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xF8AEA4", Offset = "0xF8AEA4", VA = "0xF8AEA4", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xF8B6F8", Offset = "0xF8B6F8", VA = "0xF8B6F8", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xF8B738", Offset = "0xF8B738", VA = "0xF8B738")]
		public new static JConstructor Load(JsonReader reader)
		{
			return null;
		}
	}
}
