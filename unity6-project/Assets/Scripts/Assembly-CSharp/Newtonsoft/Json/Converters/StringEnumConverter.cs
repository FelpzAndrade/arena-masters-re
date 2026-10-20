using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B3")]
	public class StringEnumConverter : JsonConverter
	{
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<Type, BidirectionalDictionary<string, string>> _enumMemberNamesPerType;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0xC")]
		private bool CamelCaseText__BackingField;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x0")]
		private static Func<EnumMemberAttribute, string> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x170000BB")]
		public bool CamelCaseText
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x138C7CC", Offset = "0x138C7CC", VA = "0x138C7CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x138C7D4", Offset = "0x138C7D4", VA = "0x138C7D4")]
			set
			{
			}
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x138C720", Offset = "0x138C720", VA = "0x138C720")]
		public StringEnumConverter()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x138C7DC", Offset = "0x138C7DC", VA = "0x138C7DC", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x138D284", Offset = "0x138D284", VA = "0x138D284", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x138CA88", Offset = "0x138CA88", VA = "0x138CA88")]
		private BidirectionalDictionary<string, string> GetEnumNameMap(Type t)
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x138D8BC", Offset = "0x138D8BC", VA = "0x138D8BC", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x138D914", Offset = "0x138D914", VA = "0x138D914")]
		private static string _003CGetEnumNameMap_003Em__2C(EnumMemberAttribute a)
		{
			return null;
		}
	}
}
