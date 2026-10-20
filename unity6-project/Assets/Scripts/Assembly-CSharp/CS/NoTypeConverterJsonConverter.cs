using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CS
{
	[Token(Token = "0x20008DB")]
	public class NoTypeConverterJsonConverter<T> : JsonConverter
	{
		[Token(Token = "0x20008DC")]
		private class NoTypeConverterContractResolver : DefaultContractResolver
		{
			[Token(Token = "0x6004744")]
			public NoTypeConverterContractResolver()
			{
			}

			[Token(Token = "0x6004745")]
			protected override JsonContract CreateContract(Type objectType)
			{
				return null;
			}
		}

		[Token(Token = "0x4002AF5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IContractResolver resolver;

		[Token(Token = "0x600473F")]
		public NoTypeConverterJsonConverter()
		{
		}

		[Token(Token = "0x6004741")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004742")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6004743")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}
	}
}
