using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000136")]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x14")]
		private JsonSerializerProxy _internalSerializer;

		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x18")]
		private List<object> _serializeStack;

		[Token(Token = "0x170001FB")]
		private List<object> SerializeStack
		{
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x1189004", Offset = "0x1189004", VA = "0x1189004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x1188FFC", Offset = "0x1188FFC", VA = "0x1188FFC")]
		public JsonSerializerInternalWriter(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x11890AC", Offset = "0x11890AC", VA = "0x11890AC")]
		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x1189924", Offset = "0x1189924", VA = "0x1189924")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x11891A0", Offset = "0x11891A0", VA = "0x11891A0")]
		private JsonContract GetContractSafe(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x1189A80", Offset = "0x1189A80", VA = "0x1189A80")]
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x1189310", Offset = "0x1189310", VA = "0x1189310")]
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x118D4B8", Offset = "0x118D4B8", VA = "0x118D4B8")]
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract contract)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x118D898", Offset = "0x118D898", VA = "0x118D898")]
		private void WriteMemberInfoProperty(JsonWriter writer, object memberValue, JsonProperty property, JsonContract contract)
		{
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x118E358", Offset = "0x118E358", VA = "0x118E358")]
		private bool CheckForCircularReference(object value, ReferenceLoopHandling? referenceLoopHandling, JsonContract contract)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x118E118", Offset = "0x118E118", VA = "0x118E118")]
		private void WriteReference(JsonWriter writer, object value)
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x118E914", Offset = "0x118E914", VA = "0x118E914")]
		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			s = default;
			return default(bool);
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x118A50C", Offset = "0x118A50C", VA = "0x118A50C")]
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x118A66C", Offset = "0x118A66C", VA = "0x118A66C")]
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x118A144", Offset = "0x118A144", VA = "0x118A144")]
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x118DCE0", Offset = "0x118DCE0", VA = "0x118DCE0")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x118D884", Offset = "0x118D884", VA = "0x118D884")]
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x118EFA8", Offset = "0x118EFA8", VA = "0x118EFA8")]
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x118A2E8", Offset = "0x118A2E8", VA = "0x118A2E8")]
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract)
		{
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x118C068", Offset = "0x118C068", VA = "0x118C068")]
		private void SerializeList(JsonWriter writer, IWrappedCollection values, JsonArrayContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x118D004", Offset = "0x118D004", VA = "0x118D004")]
		[SecuritySafeCritical]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract)
		{
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x1189CEC", Offset = "0x1189CEC", VA = "0x1189CEC")]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x118B060", Offset = "0x118B060", VA = "0x118B060")]
		private void SerializeDictionary(JsonWriter writer, IWrappedDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x118EFBC", Offset = "0x118EFBC", VA = "0x118EFBC")]
		private string GetPropertyName(DictionaryEntry entry)
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x118EE04", Offset = "0x118EE04", VA = "0x118EE04")]
		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x118EC6C", Offset = "0x118EC6C", VA = "0x118EC6C")]
		private bool ShouldSerialize(JsonProperty property, object target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x118ED38", Offset = "0x118ED38", VA = "0x118ED38")]
		private bool IsSpecified(JsonProperty property, object target)
		{
			return default(bool);
		}
	}
}
