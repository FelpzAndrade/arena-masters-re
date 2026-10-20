using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000133")]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		[Token(Token = "0x2000134")]
		internal enum PropertyPresence
		{
			[Token(Token = "0x400051C")]
			None = 0,
			[Token(Token = "0x400051D")]
			Null = 1,
			[Token(Token = "0x400051E")]
			Value = 2
		}

		[Token(Token = "0x2000135")]
		private sealed class _003CCreateAndPopulateList_003Ec__AnonStoreyCD
		{
			[Token(Token = "0x400051F")]
			[FieldOffset(Offset = "0x8")]
			internal string reference;

			[Token(Token = "0x4000520")]
			[FieldOffset(Offset = "0xC")]
			internal JsonArrayContract contract;

			[Token(Token = "0x4000521")]
			[FieldOffset(Offset = "0x10")]
			internal JsonReader reader;

			[Token(Token = "0x4000522")]
			[FieldOffset(Offset = "0x14")]
			internal JsonSerializerInternalReader _003C_003Ef__this;

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0xFC9398", Offset = "0xFC9398", VA = "0xFC9398")]
			public _003CCreateAndPopulateList_003Ec__AnonStoreyCD()
			{
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0xFCB9B8", Offset = "0xFCB9B8", VA = "0xFCB9B8")]
			internal void _003C_003Em__4E(IList l, bool isTemporaryListReference)
			{
			}
		}

		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x14")]
		private JsonSerializerProxy _internalSerializer;

		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x18")]
		private JsonFormatterConverter _formatterConverter;

		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x0")]
		private static Func<ParameterInfo, ParameterInfo> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x4")]
		private static Func<ParameterInfo, object> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x8")]
		private static Func<KeyValuePair<ParameterInfo, object>, string> _003C_003Ef__am_0024cache4;

		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0xC")]
		private static Func<JsonProperty, JsonProperty> _003C_003Ef__am_0024cache5;

		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x10")]
		private static Func<JsonProperty, PropertyPresence> _003C_003Ef__am_0024cache6;

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0xF6F0D0", Offset = "0xF6F0D0", VA = "0xF6F0D0")]
		public JsonSerializerInternalReader(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0xF6F0D4", Offset = "0xF6F0D4", VA = "0xF6F0D4")]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0xFC4168", Offset = "0xFC4168", VA = "0xFC4168")]
		private JsonContract GetContractSafe(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0xFC42BC", Offset = "0xFC42BC", VA = "0xFC42BC")]
		private JsonContract GetContractSafe(Type type, object value)
		{
			return null;
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0xF6FBEC", Offset = "0xF6FBEC", VA = "0xF6FBEC")]
		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0xFC48FC", Offset = "0xFC48FC", VA = "0xFC48FC")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0xFC49A0", Offset = "0xFC49A0", VA = "0xFC49A0")]
		private JsonFormatterConverter GetFormatterConverter()
		{
			return null;
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0xFC4A4C", Offset = "0xFC4A4C", VA = "0xFC4A4C")]
		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0xFC4C98", Offset = "0xFC4C98", VA = "0xFC4C98")]
		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0xFC4F20", Offset = "0xFC4F20", VA = "0xFC4F20")]
		private object CreateValueProperty(JsonReader reader, JsonProperty property, object target, bool gottenCurrentValue, object currentValue)
		{
			return null;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0xFC481C", Offset = "0xFC481C", VA = "0xFC481C")]
		private object CreateValueNonProperty(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0xFC51C8", Offset = "0xFC51C8", VA = "0xFC51C8")]
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue)
		{
			return null;
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0xFC515C", Offset = "0xFC515C", VA = "0xFC515C")]
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter)
		{
			return null;
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0xFC5C20", Offset = "0xFC5C20", VA = "0xFC5C20")]
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue)
		{
			return null;
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0xFC855C", Offset = "0xFC855C", VA = "0xFC855C")]
		private JsonArrayContract EnsureArrayContract(Type objectType, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0xFC2298", Offset = "0xFC2298", VA = "0xFC2298")]
		private void CheckedRead(JsonReader reader)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0xFC70F8", Offset = "0xFC70F8", VA = "0xFC70F8")]
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string reference)
		{
			return null;
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0xFC74BC", Offset = "0xFC74BC", VA = "0xFC74BC")]
		private bool HasDefinedType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0xFC71B4", Offset = "0xFC71B4", VA = "0xFC71B4")]
		private object EnsureType(object value, CultureInfo culture, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0xFC8948", Offset = "0xFC8948", VA = "0xFC8948")]
		private string FormatValueForPrint(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xFC8A8C", Offset = "0xFC8A8C", VA = "0xFC8A8C")]
		private void SetPropertyValue(JsonProperty property, JsonReader reader, object target)
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xFC912C", Offset = "0xFC912C", VA = "0xFC912C")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0xFC9140", Offset = "0xFC9140", VA = "0xFC9140")]
		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0xFC763C", Offset = "0xFC763C", VA = "0xFC763C")]
		private object CreateAndPopulateDictionary(JsonReader reader, JsonDictionaryContract contract, string id)
		{
			return null;
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0xFC238C", Offset = "0xFC238C", VA = "0xFC238C")]
		private object PopulateDictionary(IWrappedDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, string id)
		{
			return null;
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0xFC8820", Offset = "0xFC8820", VA = "0xFC8820")]
		private object CreateAndPopulateList(JsonReader reader, string reference, JsonArrayContract contract)
		{
			return null;
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0xFC93A0", Offset = "0xFC93A0", VA = "0xFC93A0")]
		private bool ReadForTypeArrayHack(JsonReader reader, Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0xFC1ACC", Offset = "0xFC1ACC", VA = "0xFC1ACC")]
		private object PopulateList(IWrappedCollection wrappedList, JsonReader reader, string reference, JsonArrayContract contract)
		{
			return null;
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0xFC7D3C", Offset = "0xFC7D3C", VA = "0xFC7D3C")]
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, string id)
		{
			return null;
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0xFC7938", Offset = "0xFC7938", VA = "0xFC7938")]
		private object CreateAndPopulateObject(JsonReader reader, JsonObjectContract contract, string id)
		{
			return null;
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0xFC951C", Offset = "0xFC951C", VA = "0xFC951C")]
		private object CreateObjectFromNonDefaultConstructor(JsonReader reader, JsonObjectContract contract, ConstructorInfo constructorInfo, string id)
		{
			return null;
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xFCAFF8", Offset = "0xFCAFF8", VA = "0xFCAFF8")]
		private IDictionary<JsonProperty, object> ResolvePropertyAndConstructorValues(JsonObjectContract contract, JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0xFC442C", Offset = "0xFC442C", VA = "0xFC442C")]
		private bool ReadForType(JsonReader reader, Type t, JsonConverter propertyConverter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0xFC2F98", Offset = "0xFC2F98", VA = "0xFC2F98")]
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, string id)
		{
			return null;
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0xFCB79C", Offset = "0xFCB79C", VA = "0xFCB79C")]
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties)
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0xFC92F8", Offset = "0xFC92F8", VA = "0xFC92F8")]
		private void HandleError(JsonReader reader, int initialDepth)
		{
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0xFCB8C8", Offset = "0xFCB8C8", VA = "0xFCB8C8")]
		private static ParameterInfo _003CCreateObjectFromNonDefaultConstructor_003Em__4F(ParameterInfo p)
		{
			return null;
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0xFCB8D0", Offset = "0xFCB8D0", VA = "0xFCB8D0")]
		private static object _003CCreateObjectFromNonDefaultConstructor_003Em__50(ParameterInfo p)
		{
			return null;
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0xFCB8D8", Offset = "0xFCB8D8", VA = "0xFCB8D8")]
		private static string _003CCreateObjectFromNonDefaultConstructor_003Em__51(KeyValuePair<ParameterInfo, object> kv)
		{
			return null;
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0xFCB9A8", Offset = "0xFCB9A8", VA = "0xFCB9A8")]
		private static JsonProperty _003CPopulateObject_003Em__52(JsonProperty m)
		{
			return null;
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0xFCB9B0", Offset = "0xFCB9B0", VA = "0xFCB9B0")]
		private static PropertyPresence _003CPopulateObject_003Em__53(JsonProperty m)
		{
			return default(PropertyPresence);
		}
	}
}
