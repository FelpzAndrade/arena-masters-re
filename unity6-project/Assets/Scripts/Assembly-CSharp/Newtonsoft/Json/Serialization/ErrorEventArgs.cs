using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000123")]
	public class ErrorEventArgs : EventArgs
	{
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x8")]
		private object CurrentObject__BackingField;

		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0xC")]
		private ErrorContext ErrorContext__BackingField;

		[Token(Token = "0x170001CC")]
		public object CurrentObject
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0xFBEED4", Offset = "0xFBEED4", VA = "0xFBEED4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0xFBEEC4", Offset = "0xFBEEC4", VA = "0xFBEEC4")]
			private set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public ErrorContext ErrorContext
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0xFBEEDC", Offset = "0xFBEEDC", VA = "0xFBEEDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xFBEECC", Offset = "0xFBEECC", VA = "0xFBEECC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xFBEE10", Offset = "0xFBEE10", VA = "0xFBEE10")]
		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
		}
	}
}
