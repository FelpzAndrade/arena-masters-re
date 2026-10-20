using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000113")]
	internal class JsonSchemaWriter
	{
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x8")]
		private readonly JsonWriter _writer;

		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0xC")]
		private readonly JsonSchemaResolver _resolver;

		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x0")]
		private static Func<JsonSchemaType, bool> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xFA7B14", Offset = "0xFA7B14", VA = "0xFA7B14")]
		public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xFB476C", Offset = "0xFB476C", VA = "0xFB476C")]
		private void ReferenceOrWriteSchema(JsonSchema schema)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xFA7BBC", Offset = "0xFA7BBC", VA = "0xFA7BBC")]
		public void WriteSchema(JsonSchema schema)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0xFB51F0", Offset = "0xFB51F0", VA = "0xFB51F0")]
		private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<string, JsonSchema> properties)
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xFB564C", Offset = "0xFB564C", VA = "0xFB564C")]
		private void WriteItems(JsonSchema schema)
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xFB4A00", Offset = "0xFB4A00", VA = "0xFB4A00")]
		private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type)
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xFB4960", Offset = "0xFB4960", VA = "0xFB4960")]
		private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value)
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xFB5BB4", Offset = "0xFB5BB4", VA = "0xFB5BB4")]
		private static bool _003CWriteType_003Em__44(JsonSchemaType v)
		{
			return default(bool);
		}
	}
}
