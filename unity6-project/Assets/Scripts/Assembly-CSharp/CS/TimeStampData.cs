using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200091B")]
	public class TimeStampData
	{
		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0x8")]
		private DateTime Time__BackingField;

		[Token(Token = "0x4002D0C")]
		[FieldOffset(Offset = "0x18")]
		private int Count__BackingField;

		[Token(Token = "0x170009C1")]
		public DateTime Time
		{
			[Token(Token = "0x60048CA")]
			[Address(RVA = "0x21E926C", Offset = "0x21E926C", VA = "0x21E926C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60048CB")]
			[Address(RVA = "0x21E927C", Offset = "0x21E927C", VA = "0x21E927C")]
			set
			{
			}
		}

		[Token(Token = "0x170009C2")]
		public int Count
		{
			[Token(Token = "0x60048CC")]
			[Address(RVA = "0x21E9294", Offset = "0x21E9294", VA = "0x21E9294")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60048CD")]
			[Address(RVA = "0x21E929C", Offset = "0x21E929C", VA = "0x21E929C")]
			set
			{
			}
		}

		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x21E9264", Offset = "0x21E9264", VA = "0x21E9264")]
		public TimeStampData()
		{
		}
	}
}
