using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x200010D")]
	internal class JsonSchemaModelBuilder
	{
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x8")]
		private JsonSchemaNodeCollection _nodes;

		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels;

		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x10")]
		private JsonSchemaNode _node;

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xF7E700", Offset = "0xF7E700", VA = "0xF7E700")]
		public JsonSchemaModelBuilder()
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xF7E7CC", Offset = "0xF7E7CC", VA = "0xF7E7CC")]
		public JsonSchemaModel Build(JsonSchema schema)
		{
			return null;
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xFB2754", Offset = "0xFB2754", VA = "0xFB2754")]
		public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema)
		{
			return null;
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xFB3B88", Offset = "0xFB3B88", VA = "0xFB3B88")]
		public void AddProperties(IDictionary<string, JsonSchema> source, IDictionary<string, JsonSchemaNode> target)
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xFB40DC", Offset = "0xFB40DC", VA = "0xFB40DC")]
		public void AddProperty(IDictionary<string, JsonSchemaNode> target, string propertyName, JsonSchema schema)
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0xFB3F1C", Offset = "0xFB3F1C", VA = "0xFB3F1C")]
		public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema)
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xFB40AC", Offset = "0xFB40AC", VA = "0xFB40AC")]
		public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema)
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xFB2C68", Offset = "0xFB2C68", VA = "0xFB2C68")]
		private JsonSchemaModel BuildNodeModel(JsonSchemaNode node)
		{
			return null;
		}
	}
}
