using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000110")]
	public class JsonSchemaResolver
	{
		[Token(Token = "0x2000111")]
		private sealed class _003CGetSchema_003Ec__AnonStoreyC8
		{
			[Token(Token = "0x40004AA")]
			[FieldOffset(Offset = "0x8")]
			internal string id;

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xFB4698", Offset = "0xFB4698", VA = "0xFB4698")]
			public _003CGetSchema_003Ec__AnonStoreyC8()
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xFB46A0", Offset = "0xFB46A0", VA = "0xFB46A0")]
			internal bool _003C_003Em__43(JsonSchema s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x8")]
		private IList<JsonSchema> LoadedSchemas__BackingField;

		[Token(Token = "0x170001C1")]
		public IList<JsonSchema> LoadedSchemas
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xFA933C", Offset = "0xFA933C", VA = "0xFA933C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0xFB4570", Offset = "0xFB4570", VA = "0xFB4570")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xFA751C", Offset = "0xFA751C", VA = "0xFA751C")]
		public JsonSchemaResolver()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xFB4578", Offset = "0xFB4578", VA = "0xFB4578", Slot = "4")]
		public virtual JsonSchema GetSchema(string id)
		{
			return null;
		}
	}
}
