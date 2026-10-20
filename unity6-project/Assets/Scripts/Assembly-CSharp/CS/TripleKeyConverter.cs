using System;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008DA")]
	public class TripleKeyConverter : TypeConverter
	{
		[Token(Token = "0x600473C")]
		[Address(RVA = "0x21EA234", Offset = "0x21EA234", VA = "0x21EA234")]
		public TripleKeyConverter()
		{
		}

		[Token(Token = "0x600473D")]
		[Address(RVA = "0x21EA23C", Offset = "0x21EA23C", VA = "0x21EA23C", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		[Token(Token = "0x600473E")]
		[Address(RVA = "0x21EA244", Offset = "0x21EA244", VA = "0x21EA244", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}
	}
}
