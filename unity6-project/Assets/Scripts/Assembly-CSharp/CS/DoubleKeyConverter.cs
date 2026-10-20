using System;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008D9")]
	public class DoubleKeyConverter : TypeConverter
	{
		[Token(Token = "0x6004739")]
		[Address(RVA = "0x1CDB824", Offset = "0x1CDB824", VA = "0x1CDB824")]
		public DoubleKeyConverter()
		{
		}

		[Token(Token = "0x600473A")]
		[Address(RVA = "0x1CDB82C", Offset = "0x1CDB82C", VA = "0x1CDB82C", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		[Token(Token = "0x600473B")]
		[Address(RVA = "0x1CDB834", Offset = "0x1CDB834", VA = "0x1CDB834", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}
	}
}
