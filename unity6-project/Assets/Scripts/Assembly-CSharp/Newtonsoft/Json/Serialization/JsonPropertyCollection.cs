using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000130")]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Type _type;

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0xFB839C", Offset = "0xFB839C", VA = "0xFB839C")]
		public JsonPropertyCollection(Type type)
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0xFC135C", Offset = "0xFC135C", VA = "0xFC135C", Slot = "37")]
		protected override string GetKeyForItem(JsonProperty item)
		{
			return null;
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0xFB847C", Offset = "0xFB847C", VA = "0xFB847C")]
		public void AddProperty(JsonProperty property)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0xFB8448", Offset = "0xFB8448", VA = "0xFB8448")]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0xFC137C", Offset = "0xFC137C", VA = "0xFC137C")]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			return null;
		}
	}
}
