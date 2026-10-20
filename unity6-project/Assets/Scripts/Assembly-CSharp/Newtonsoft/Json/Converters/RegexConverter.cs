using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Newtonsoft.Json.Bson;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B2")]
	public class RegexConverter : JsonConverter
	{
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x138B8C0", Offset = "0x138B8C0", VA = "0x138B8C0")]
		public RegexConverter()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x138B8C8", Offset = "0x138B8C8", VA = "0x138B8C8", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x138BF30", Offset = "0x138BF30", VA = "0x138BF30")]
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x138B9B0", Offset = "0x138B9B0", VA = "0x138B9B0")]
		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x138BCF0", Offset = "0x138BCF0", VA = "0x138BCF0")]
		private void WriteJson(JsonWriter writer, Regex regex)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x138BF44", Offset = "0x138BF44", VA = "0x138BF44", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x138C004", Offset = "0x138C004", VA = "0x138C004")]
		private object ReadBson(BsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x138C2C0", Offset = "0x138C2C0", VA = "0x138C2C0")]
		private Regex ReadJson(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x138C650", Offset = "0x138C650", VA = "0x138C650", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
