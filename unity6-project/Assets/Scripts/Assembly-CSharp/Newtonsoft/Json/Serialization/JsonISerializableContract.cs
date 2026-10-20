using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200012B")]
	public class JsonISerializableContract : JsonContract
	{
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x38")]
		private ObjectConstructor<object> ISerializableCreator__BackingField;

		[Token(Token = "0x170001DE")]
		public ObjectConstructor<object> ISerializableCreator
		{
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0xFC1304", Offset = "0xFC1304", VA = "0xFC1304")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0xFBBE40", Offset = "0xFBBE40", VA = "0xFBBE40")]
			set
			{
			}
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0xFBBE34", Offset = "0xFBBE34", VA = "0xFBBE34")]
		public JsonISerializableContract(Type underlyingType)
		{
		}
	}
}
