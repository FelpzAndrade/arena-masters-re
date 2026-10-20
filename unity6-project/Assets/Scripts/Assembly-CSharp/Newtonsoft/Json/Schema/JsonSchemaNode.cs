using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x200010E")]
	internal class JsonSchemaNode
	{
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x8")]
		private string Id__BackingField;

		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0xC")]
		private ReadOnlyCollection<JsonSchema> Schemas__BackingField;

		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, JsonSchemaNode> Properties__BackingField;

		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<string, JsonSchemaNode> PatternProperties__BackingField;

		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x18")]
		private List<JsonSchemaNode> Items__BackingField;

		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x1C")]
		private JsonSchemaNode AdditionalProperties__BackingField;

		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x0")]
		private static Func<JsonSchema, string> _003C_003Ef__am_0024cache6;

		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x4")]
		private static Func<string, string> _003C_003Ef__am_0024cache7;

		[Token(Token = "0x170001BB")]
		public string Id
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0xFB4520", Offset = "0xFB4520", VA = "0xFB4520")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0xFB42D8", Offset = "0xFB42D8", VA = "0xFB42D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BC")]
		public ReadOnlyCollection<JsonSchema> Schemas
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xFB3678", Offset = "0xFB3678", VA = "0xFB3678")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xFB42B8", Offset = "0xFB42B8", VA = "0xFB42B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BD")]
		public Dictionary<string, JsonSchemaNode> Properties
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xFB3B80", Offset = "0xFB3B80", VA = "0xFB3B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xFB42C0", Offset = "0xFB42C0", VA = "0xFB42C0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BE")]
		public Dictionary<string, JsonSchemaNode> PatternProperties
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xFB3F14", Offset = "0xFB3F14", VA = "0xFB3F14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xFB42C8", Offset = "0xFB42C8", VA = "0xFB42C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public List<JsonSchemaNode> Items
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xFB42A0", Offset = "0xFB42A0", VA = "0xFB42A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xFB42D0", Offset = "0xFB42D0", VA = "0xFB42D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public JsonSchemaNode AdditionalProperties
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0xFB42A8", Offset = "0xFB42A8", VA = "0xFB42A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xFB42B0", Offset = "0xFB42B0", VA = "0xFB42B0")]
			set
			{
			}
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xFB39B8", Offset = "0xFB39B8", VA = "0xFB39B8")]
		public JsonSchemaNode(JsonSchema schema)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xFB42E0", Offset = "0xFB42E0", VA = "0xFB42E0")]
		private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xFB3920", Offset = "0xFB3920", VA = "0xFB3920")]
		public JsonSchemaNode Combine(JsonSchema schema)
		{
			return null;
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xFB3680", Offset = "0xFB3680", VA = "0xFB3680")]
		public static string GetId(IEnumerable<JsonSchema> schemata)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xFB4528", Offset = "0xFB4528", VA = "0xFB4528")]
		private static string _003CGetId_003Em__41(JsonSchema s)
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xFB4548", Offset = "0xFB4548", VA = "0xFB4548")]
		private static string _003CGetId_003Em__42(string id)
		{
			return null;
		}
	}
}
