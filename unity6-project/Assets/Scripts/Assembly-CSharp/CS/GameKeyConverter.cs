using System;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200095D")]
	public class GameKeyConverter : TypeConverter
	{
		[Token(Token = "0x6004B49")]
		[Address(RVA = "0x2334448", Offset = "0x2334448", VA = "0x2334448")]
		public GameKeyConverter()
		{
		}

		[Token(Token = "0x6004B4A")]
		[Address(RVA = "0x2334450", Offset = "0x2334450", VA = "0x2334450", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x2334458", Offset = "0x2334458", VA = "0x2334458", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}
	}
}
