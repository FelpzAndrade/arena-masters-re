using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ADE")]
	public class ProtoInfoXmlException : Exception
	{
		[Token(Token = "0x4003301")]
		[FieldOffset(Offset = "0x34")]
		private string FileName__BackingField;

		[Token(Token = "0x4003302")]
		[FieldOffset(Offset = "0x38")]
		private string Cursor__BackingField;

		[Token(Token = "0x4003303")]
		[FieldOffset(Offset = "0x3C")]
		private int LineNumber__BackingField;

		[Token(Token = "0x4003304")]
		[FieldOffset(Offset = "0x40")]
		private int LinePosition__BackingField;

		[Token(Token = "0x17000B3F")]
		public string FileName
		{
			[Token(Token = "0x6004F86")]
			[Address(RVA = "0x21B9B24", Offset = "0x21B9B24", VA = "0x21B9B24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F87")]
			[Address(RVA = "0x21B9B04", Offset = "0x21B9B04", VA = "0x21B9B04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B40")]
		public string Cursor
		{
			[Token(Token = "0x6004F88")]
			[Address(RVA = "0x21B9B2C", Offset = "0x21B9B2C", VA = "0x21B9B2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F89")]
			[Address(RVA = "0x21B9B0C", Offset = "0x21B9B0C", VA = "0x21B9B0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B41")]
		public int LineNumber
		{
			[Token(Token = "0x6004F8A")]
			[Address(RVA = "0x21B9B34", Offset = "0x21B9B34", VA = "0x21B9B34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004F8B")]
			[Address(RVA = "0x21B9B14", Offset = "0x21B9B14", VA = "0x21B9B14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B42")]
		public int LinePosition
		{
			[Token(Token = "0x6004F8C")]
			[Address(RVA = "0x21B9B3C", Offset = "0x21B9B3C", VA = "0x21B9B3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004F8D")]
			[Address(RVA = "0x21B9B1C", Offset = "0x21B9B1C", VA = "0x21B9B1C")]
			private set
			{
			}
		}

		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x21B9A00", Offset = "0x21B9A00", VA = "0x21B9A00")]
		public ProtoInfoXmlException(string FileName, string Cursor, int LineNumber, int LinePosition)
		{
		}
	}
}
