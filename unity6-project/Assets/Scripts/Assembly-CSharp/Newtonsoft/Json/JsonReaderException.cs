using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000CE")]
	public class JsonReaderException : Exception
	{
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x34")]
		private int LineNumber__BackingField;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x38")]
		private int LinePosition__BackingField;

		[Token(Token = "0x170000F4")]
		public int LineNumber
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xF6D858", Offset = "0xF6D858", VA = "0xF6D858")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xF6D848", Offset = "0xF6D848", VA = "0xF6D848")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public int LinePosition
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xF6D860", Offset = "0xF6D860", VA = "0xF6D860")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xF6D850", Offset = "0xF6D850", VA = "0xF6D850")]
			private set
			{
			}
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xF6D810", Offset = "0xF6D810", VA = "0xF6D810")]
		public JsonReaderException()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xF6D55C", Offset = "0xF6D55C", VA = "0xF6D55C")]
		public JsonReaderException(string message)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xF6D818", Offset = "0xF6D818", VA = "0xF6D818")]
		public JsonReaderException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xF6D820", Offset = "0xF6D820", VA = "0xF6D820")]
		internal JsonReaderException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}
	}
}
