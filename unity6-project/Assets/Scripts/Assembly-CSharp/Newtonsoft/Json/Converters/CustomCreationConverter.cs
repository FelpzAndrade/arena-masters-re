using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000AC")]
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		[Token(Token = "0x170000B7")]
		public override bool CanWrite
		{
			[Token(Token = "0x600057A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000575")]
		protected CustomCreationConverter()
		{
		}

		[Token(Token = "0x6000576")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000577")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		public abstract T Create(Type objectType);

		[Token(Token = "0x6000579")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
