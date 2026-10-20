using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000AB")]
	public class BsonObjectIdConverter : JsonConverter
	{
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1388FF8", Offset = "0x1388FF8", VA = "0x1388FF8")]
		public BsonObjectIdConverter()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1389008", Offset = "0x1389008", VA = "0x1389008", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x138913C", Offset = "0x138913C", VA = "0x138913C", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x13893E8", Offset = "0x13893E8", VA = "0x13893E8", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
