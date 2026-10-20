using System;
using System.Globalization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000AE")]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x40002DF")]
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x8")]
		private DateTimeStyles _dateTimeStyles;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0xC")]
		private string _dateTimeFormat;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x10")]
		private CultureInfo _culture;

		[Token(Token = "0x170000B8")]
		public DateTimeStyles DateTimeStyles
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x13896C8", Offset = "0x13896C8", VA = "0x13896C8")]
			get
			{
				return default(DateTimeStyles);
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x13896D0", Offset = "0x13896D0", VA = "0x13896D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public string DateTimeFormat
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x13896D8", Offset = "0x13896D8", VA = "0x13896D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1389798", Offset = "0x1389798", VA = "0x1389798")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x13897B8", Offset = "0x13897B8", VA = "0x13897B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1389868", Offset = "0x1389868", VA = "0x1389868")]
			set
			{
			}
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x13896B8", Offset = "0x13896B8", VA = "0x13896B8")]
		public IsoDateTimeConverter()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1389870", Offset = "0x1389870", VA = "0x1389870", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1389BEC", Offset = "0x1389BEC", VA = "0x1389BEC", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
