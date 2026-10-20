using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000114")]
	public static class SchemaExtensions
	{
		[Token(Token = "0x2000115")]
		private sealed class _003CIsValid_003Ec__AnonStoreyC9
		{
			[Token(Token = "0x40004B8")]
			[FieldOffset(Offset = "0x8")]
			internal bool valid;

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xFB5CCC", Offset = "0xFB5CCC", VA = "0xFB5CCC")]
			public _003CIsValid_003Ec__AnonStoreyC9()
			{
			}

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0xFB5F48", Offset = "0xFB5F48", VA = "0xFB5F48")]
			internal void _003C_003Em__45(object sender, ValidationEventArgs args)
			{
			}
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xFB5BC4", Offset = "0xFB5BC4", VA = "0xFB5BC4")]
		public static bool IsValid(this JToken source, JsonSchema schema)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xFB5F2C", Offset = "0xFB5F2C", VA = "0xFB5F2C")]
		public static void Validate(this JToken source, JsonSchema schema)
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xFB5CE8", Offset = "0xFB5CE8", VA = "0xFB5CE8")]
		public static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
		{
		}
	}
}
