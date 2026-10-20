using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000122")]
	public class ErrorContext
	{
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x8")]
		private Exception Error__BackingField;

		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0xC")]
		private object OriginalObject__BackingField;

		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x10")]
		private object Member__BackingField;

		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x14")]
		private bool Handled__BackingField;

		[Token(Token = "0x170001C8")]
		public Exception Error
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xFBEDE8", Offset = "0xFBEDE8", VA = "0xFBEDE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0xFBEDE0", Offset = "0xFBEDE0", VA = "0xFBEDE0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C9")]
		public object OriginalObject
		{
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0xFBEDF0", Offset = "0xFBEDF0", VA = "0xFBEDF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xFBEDD0", Offset = "0xFBEDD0", VA = "0xFBEDD0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public object Member
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xFBEDF8", Offset = "0xFBEDF8", VA = "0xFBEDF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0xFBEDD8", Offset = "0xFBEDD8", VA = "0xFBEDD8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public bool Handled
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0xFBEE00", Offset = "0xFBEE00", VA = "0xFBEE00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0xFBEE08", Offset = "0xFBEE08", VA = "0xFBEE08")]
			set
			{
			}
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0xFBEDA0", Offset = "0xFBEDA0", VA = "0xFBEDA0")]
		internal ErrorContext(object originalObject, object member, Exception error)
		{
		}
	}
}
