using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B1")]
	public class KeyValuePairConverter : JsonConverter
	{
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x138B150", Offset = "0x138B150", VA = "0x138B150")]
		public KeyValuePairConverter()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x138B158", Offset = "0x138B158", VA = "0x138B158", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x138B394", Offset = "0x138B394", VA = "0x138B394", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x138B760", Offset = "0x138B760", VA = "0x138B760", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
