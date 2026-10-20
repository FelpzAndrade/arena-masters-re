using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000117")]
	public class ValidationEventArgs : EventArgs
	{
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x8")]
		private readonly JsonSchemaException _ex;

		[Token(Token = "0x170001C2")]
		public JsonSchemaException Exception
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0xFB5F54", Offset = "0xFB5F54", VA = "0xFB5F54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C3")]
		public string Message
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xFB5F5C", Offset = "0xFB5F5C", VA = "0xFB5F5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xF7BF0C", Offset = "0xF7BF0C", VA = "0xF7BF0C")]
		internal ValidationEventArgs(JsonSchemaException ex)
		{
		}
	}
}
