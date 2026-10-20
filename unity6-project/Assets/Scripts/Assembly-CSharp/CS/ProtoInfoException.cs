using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ADD")]
	public class ProtoInfoException : Exception
	{
		[Token(Token = "0x40032FF")]
		[FieldOffset(Offset = "0x34")]
		private string FileName__BackingField;

		[Token(Token = "0x4003300")]
		[FieldOffset(Offset = "0x38")]
		private string Cursor__BackingField;

		[Token(Token = "0x17000B3D")]
		public string FileName
		{
			[Token(Token = "0x6004F81")]
			[Address(RVA = "0x21AEE80", Offset = "0x21AEE80", VA = "0x21AEE80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F82")]
			[Address(RVA = "0x21AEE70", Offset = "0x21AEE70", VA = "0x21AEE70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B3E")]
		public string Cursor
		{
			[Token(Token = "0x6004F83")]
			[Address(RVA = "0x21AEE88", Offset = "0x21AEE88", VA = "0x21AEE88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F84")]
			[Address(RVA = "0x21AEE78", Offset = "0x21AEE78", VA = "0x21AEE78")]
			private set
			{
			}
		}

		[Token(Token = "0x6004F80")]
		[Address(RVA = "0x21AED7C", Offset = "0x21AED7C", VA = "0x21AED7C")]
		public ProtoInfoException(string FileName, string Cursor)
		{
		}
	}
}
