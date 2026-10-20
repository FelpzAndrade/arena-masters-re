using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000C4")]
	public abstract class JsonContainerAttribute : Attribute
	{
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x8")]
		internal bool? _isReference;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xC")]
		private string Id__BackingField;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x10")]
		private string Title__BackingField;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x14")]
		private string Description__BackingField;

		[Token(Token = "0x170000DC")]
		public string Id
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x139838C", Offset = "0x139838C", VA = "0x139838C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1398384", Offset = "0x1398384", VA = "0x1398384")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public string Title
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1398394", Offset = "0x1398394", VA = "0x1398394")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x139839C", Offset = "0x139839C", VA = "0x139839C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public string Description
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x13983A4", Offset = "0x13983A4", VA = "0x13983A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x13983AC", Offset = "0x13983AC", VA = "0x13983AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool IsReference
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x13983B4", Offset = "0x13983B4", VA = "0x13983B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x139847C", Offset = "0x139847C", VA = "0x139847C")]
			set
			{
			}
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1398304", Offset = "0x1398304", VA = "0x1398304")]
		protected JsonContainerAttribute()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x139834C", Offset = "0x139834C", VA = "0x139834C")]
		protected JsonContainerAttribute(string id)
		{
		}
	}
}
