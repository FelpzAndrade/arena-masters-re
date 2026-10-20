using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Schema;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000C6")]
	public abstract class JsonConverter
	{
		[Token(Token = "0x170000E0")]
		public virtual bool CanRead
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x139D77C", Offset = "0x139D77C", VA = "0x139D77C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E1")]
		public virtual bool CanWrite
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x139D784", Offset = "0x139D784", VA = "0x139D784", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1389000", Offset = "0x1389000", VA = "0x1389000")]
		protected JsonConverter()
		{
		}

		[Token(Token = "0x6000654")]
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		[Token(Token = "0x6000655")]
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		[Token(Token = "0x6000656")]
		public abstract bool CanConvert(Type objectType);

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x139D774", Offset = "0x139D774", VA = "0x139D774", Slot = "7")]
		public virtual JsonSchema GetSchema()
		{
			return null;
		}
	}
}
