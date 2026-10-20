using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000AF")]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x138A38C", Offset = "0x138A38C", VA = "0x138A38C")]
		public JavaScriptDateTimeConverter()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x138A394", Offset = "0x138A394", VA = "0x138A394", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x138A778", Offset = "0x138A778", VA = "0x138A778", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
