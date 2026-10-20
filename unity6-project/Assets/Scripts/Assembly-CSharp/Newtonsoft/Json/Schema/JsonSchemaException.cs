using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000108")]
	public class JsonSchemaException : Exception
	{
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x34")]
		private int LineNumber__BackingField;

		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x38")]
		private int LinePosition__BackingField;

		[Token(Token = "0x170001A1")]
		public int LineNumber
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0xFAEE58", Offset = "0xFAEE58", VA = "0xFAEE58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0xFAEE48", Offset = "0xFAEE48", VA = "0xFAEE48")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public int LinePosition
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0xFAEE60", Offset = "0xFAEE60", VA = "0xFAEE60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0xFAEE50", Offset = "0xFAEE50", VA = "0xFAEE50")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xFAEE30", Offset = "0xFAEE30", VA = "0xFAEE30")]
		public JsonSchemaException()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xFAEE38", Offset = "0xFAEE38", VA = "0xFAEE38")]
		public JsonSchemaException(string message)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xFAEE40", Offset = "0xFAEE40", VA = "0xFAEE40")]
		public JsonSchemaException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xF7BE24", Offset = "0xF7BE24", VA = "0xF7BE24")]
		internal JsonSchemaException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}
	}
}
