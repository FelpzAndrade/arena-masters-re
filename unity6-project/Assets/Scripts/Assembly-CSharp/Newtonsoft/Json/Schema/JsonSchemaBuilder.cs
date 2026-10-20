using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000105")]
	internal class JsonSchemaBuilder
	{
		[Token(Token = "0x2000106")]
		private sealed class _003CMapType_003Ec__AnonStoreyC6
		{
			[Token(Token = "0x400045E")]
			[FieldOffset(Offset = "0x8")]
			internal JsonSchemaType type;

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xFAEBA8", Offset = "0xFAEBA8", VA = "0xFAEBA8")]
			public _003CMapType_003Ec__AnonStoreyC6()
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xFAEBB0", Offset = "0xFAEBB0", VA = "0xFAEBB0")]
			internal bool _003C_003Em__3F(KeyValuePair<string, JsonSchemaType> kv)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x8")]
		private JsonReader _reader;

		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0xC")]
		private readonly IList<JsonSchema> _stack;

		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonSchemaResolver _resolver;

		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x14")]
		private JsonSchema _currentSchema;

		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map2;

		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map3;

		[Token(Token = "0x170001A0")]
		private JsonSchema CurrentSchema
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0xFA9504", Offset = "0xFA9504", VA = "0xFA9504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xFA76B8", Offset = "0xFA76B8", VA = "0xFA76B8")]
		public JsonSchemaBuilder(JsonSchemaResolver resolver)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xFA9188", Offset = "0xFA9188", VA = "0xFA9188")]
		private void Push(JsonSchema value)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xFA9344", Offset = "0xFA9344", VA = "0xFA9344")]
		private JsonSchema Pop()
		{
			return null;
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xFA776C", Offset = "0xFA776C", VA = "0xFA776C")]
		internal JsonSchema Parse(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xFA950C", Offset = "0xFA950C", VA = "0xFA950C")]
		private JsonSchema BuildSchema()
		{
			return null;
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xFA9F58", Offset = "0xFA9F58", VA = "0xFA9F58")]
		private void ProcessSchemaProperty(string propertyName)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xFAE73C", Offset = "0xFAE73C", VA = "0xFAE73C")]
		private void ProcessExtends()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xFAE370", Offset = "0xFAE370", VA = "0xFAE370")]
		private void ProcessEnum()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xFAD664", Offset = "0xFAD664", VA = "0xFAD664")]
		private void ProcessOptions()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xFAD638", Offset = "0xFAD638", VA = "0xFAD638")]
		private void ProcessDefault()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xFACF6C", Offset = "0xFACF6C", VA = "0xFACF6C")]
		private void ProcessIdentity()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xFAC9AC", Offset = "0xFAC9AC", VA = "0xFAC9AC")]
		private void ProcessAdditionalProperties()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xFACAD8", Offset = "0xFACAD8", VA = "0xFACAD8")]
		private void ProcessPatternProperties()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xFAC518", Offset = "0xFAC518", VA = "0xFAC518")]
		private void ProcessItems()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xFABE98", Offset = "0xFABE98", VA = "0xFABE98")]
		private void ProcessProperties()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xFAB7A4", Offset = "0xFAB7A4", VA = "0xFAB7A4")]
		private JsonSchemaType? ProcessType()
		{
			return null;
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xFAE764", Offset = "0xFAE764", VA = "0xFAE764")]
		internal static JsonSchemaType MapType(string type)
		{
			return default(JsonSchemaType);
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xFAEA04", Offset = "0xFAEA04", VA = "0xFAEA04")]
		internal static string MapType(JsonSchemaType type)
		{
			return null;
		}
	}
}
