using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x200010C")]
	internal class JsonSchemaModel
	{
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x8")]
		private bool Required__BackingField;

		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0xC")]
		private JsonSchemaType Type__BackingField;

		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x10")]
		private int? MinimumLength__BackingField;

		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x18")]
		private int? MaximumLength__BackingField;

		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x20")]
		private double? DivisibleBy__BackingField;

		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x30")]
		private double? Minimum__BackingField;

		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x40")]
		private double? Maximum__BackingField;

		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x50")]
		private bool ExclusiveMinimum__BackingField;

		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x51")]
		private bool ExclusiveMaximum__BackingField;

		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x54")]
		private int? MinimumItems__BackingField;

		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x5C")]
		private int? MaximumItems__BackingField;

		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x64")]
		private IList<string> Patterns__BackingField;

		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x68")]
		private IList<JsonSchemaModel> Items__BackingField;

		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x6C")]
		private IDictionary<string, JsonSchemaModel> Properties__BackingField;

		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x70")]
		private IDictionary<string, JsonSchemaModel> PatternProperties__BackingField;

		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x74")]
		private JsonSchemaModel AdditionalProperties__BackingField;

		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x78")]
		private bool AllowAdditionalProperties__BackingField;

		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x7C")]
		private IList<JToken> Enum__BackingField;

		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x80")]
		private JsonSchemaType Disallow__BackingField;

		[Token(Token = "0x170001A8")]
		public bool Required
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0xF82D48", Offset = "0xF82D48", VA = "0xF82D48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0xFB1D04", Offset = "0xFB1D04", VA = "0xFB1D04")]
			set
			{
			}
		}

		[Token(Token = "0x170001A9")]
		public JsonSchemaType Type
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0xF82964", Offset = "0xF82964", VA = "0xF82964")]
			get
			{
				return default(JsonSchemaType);
			}
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xFB1CF4", Offset = "0xFB1CF4", VA = "0xFB1CF4")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public int? MinimumLength
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0xF823C4", Offset = "0xF823C4", VA = "0xF823C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0xFB1D0C", Offset = "0xFB1D0C", VA = "0xFB1D0C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public int? MaximumLength
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0xF823B0", Offset = "0xF823B0", VA = "0xF823B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0xFB1D18", Offset = "0xFB1D18", VA = "0xFB1D18")]
			set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public double? DivisibleBy
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0xF82410", Offset = "0xF82410", VA = "0xF82410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xFB1D24", Offset = "0xFB1D24", VA = "0xFB1D24")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public double? Minimum
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0xF823F8", Offset = "0xF823F8", VA = "0xF823F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0xFB1D3C", Offset = "0xFB1D3C", VA = "0xFB1D3C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public double? Maximum
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xF823E0", Offset = "0xF823E0", VA = "0xF823E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xFB1D54", Offset = "0xFB1D54", VA = "0xFB1D54")]
			set
			{
			}
		}

		[Token(Token = "0x170001AF")]
		public bool ExclusiveMinimum
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xF82408", Offset = "0xF82408", VA = "0xF82408")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0xFB1D6C", Offset = "0xFB1D6C", VA = "0xFB1D6C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public bool ExclusiveMaximum
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xF823F0", Offset = "0xF823F0", VA = "0xF823F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xFB1D74", Offset = "0xFB1D74", VA = "0xFB1D74")]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		public int? MinimumItems
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0xF82138", Offset = "0xF82138", VA = "0xF82138")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0xFB1D7C", Offset = "0xFB1D7C", VA = "0xFB1D7C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B2")]
		public int? MaximumItems
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0xF82124", Offset = "0xF82124", VA = "0xF82124")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0xFB1D88", Offset = "0xFB1D88", VA = "0xFB1D88")]
			set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public IList<string> Patterns
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xF823D8", Offset = "0xF823D8", VA = "0xF823D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0xFB1D94", Offset = "0xFB1D94", VA = "0xFB1D94")]
			set
			{
			}
		}

		[Token(Token = "0x170001B4")]
		public IList<JsonSchemaModel> Items
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0xF7B8E0", Offset = "0xF7B8E0", VA = "0xF7B8E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0xFB1D9C", Offset = "0xFB1D9C", VA = "0xFB1D9C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B5")]
		public IDictionary<string, JsonSchemaModel> Properties
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0xF7B8C0", Offset = "0xF7B8C0", VA = "0xF7B8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xFB1DA4", Offset = "0xFB1DA4", VA = "0xFB1DA4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		public IDictionary<string, JsonSchemaModel> PatternProperties
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0xF7B8C8", Offset = "0xF7B8C8", VA = "0xF7B8C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0xFB1DAC", Offset = "0xFB1DAC", VA = "0xFB1DAC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public JsonSchemaModel AdditionalProperties
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0xF7B8D8", Offset = "0xF7B8D8", VA = "0xF7B8D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0xFB1DB4", Offset = "0xFB1DB4", VA = "0xFB1DB4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		public bool AllowAdditionalProperties
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0xF7B8D0", Offset = "0xF7B8D0", VA = "0xF7B8D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0xFB1CFC", Offset = "0xFB1CFC", VA = "0xFB1CFC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public IList<JToken> Enum
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0xF7C800", Offset = "0xF7C800", VA = "0xF7C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0xFB1DBC", Offset = "0xFB1DBC", VA = "0xFB1DBC")]
			set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public JsonSchemaType Disallow
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0xF7CAC0", Offset = "0xF7CAC0", VA = "0xF7CAC0")]
			get
			{
				return default(JsonSchemaType);
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0xFB1DC4", Offset = "0xFB1DC4", VA = "0xFB1DC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xFB1CC4", Offset = "0xFB1CC4", VA = "0xFB1CC4")]
		public JsonSchemaModel()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xFB1DCC", Offset = "0xFB1DCC", VA = "0xFB1DCC")]
		public static JsonSchemaModel Create(IList<JsonSchema> schemata)
		{
			return null;
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xFB2120", Offset = "0xFB2120", VA = "0xFB2120")]
		private static void Combine(JsonSchemaModel model, JsonSchema schema)
		{
		}
	}
}
