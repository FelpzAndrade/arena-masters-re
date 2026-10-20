using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200011B")]
	public class DefaultContractResolver : IContractResolver
	{
		[Token(Token = "0x200011C")]
		private sealed class _003CCreateISerializableContract_003Ec__AnonStoreyCA
		{
			[Token(Token = "0x40004CE")]
			[FieldOffset(Offset = "0x8")]
			internal MethodCall<object, object> methodCall;

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xFBBE38", Offset = "0xFBBE38", VA = "0xFBBE38")]
			public _003CCreateISerializableContract_003Ec__AnonStoreyCA()
			{
			}

			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0xFBDC4C", Offset = "0xFBDC4C", VA = "0xFBDC4C")]
			internal object _003C_003Em__4A(object[] args)
			{
				return null;
			}
		}

		[Token(Token = "0x200011D")]
		private sealed class _003CCreateShouldSerializeTest_003Ec__AnonStoreyCB
		{
			[Token(Token = "0x40004CF")]
			[FieldOffset(Offset = "0x8")]
			internal MethodCall<object, object> shouldSerializeCall;

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0xFBD8C4", Offset = "0xFBD8C4", VA = "0xFBD8C4")]
			public _003CCreateShouldSerializeTest_003Ec__AnonStoreyCB()
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xFBDCF0", Offset = "0xFBDCF0", VA = "0xFBDCF0")]
			internal bool _003C_003Em__4C(object o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200011E")]
		private sealed class _003CSetIsSpecifiedActions_003Ec__AnonStoreyCC
		{
			[Token(Token = "0x40004D0")]
			[FieldOffset(Offset = "0x8")]
			internal Func<object, object> specifiedPropertyGet;

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0xFBD8CC", Offset = "0xFBD8CC", VA = "0xFBD8CC")]
			public _003CSetIsSpecifiedActions_003Ec__AnonStoreyCC()
			{
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0xFBDDD4", Offset = "0xFBDDD4", VA = "0xFBDDD4")]
			internal bool _003C_003Em__4D(object o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IContractResolver _instance;

		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x4")]
		private static readonly IList<JsonConverter> BuiltInConverters;

		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<ResolverContractKey, JsonContract> _sharedContractCache;

		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0xC")]
		private static readonly object _typeContractCacheLock;

		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<ResolverContractKey, JsonContract> _instanceContractCache;

		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0xC")]
		private readonly bool _sharedCache;

		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x10")]
		private BindingFlags DefaultMembersSearchFlags__BackingField;

		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x14")]
		private bool SerializeCompilerGeneratedMembers__BackingField;

		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x10")]
		private static Func<MemberInfo, bool> _003C_003Ef__am_0024cache8;

		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x14")]
		private static Func<MemberInfo, bool> _003C_003Ef__am_0024cache9;

		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x18")]
		private static Func<ConstructorInfo, bool> _003C_003Ef__am_0024cacheA;

		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x1C")]
		private static Func<ConstructorInfo, bool> _003C_003Ef__am_0024cacheB;

		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x20")]
		private static Func<JsonProperty, int> _003C_003Ef__am_0024cacheC;

		[Token(Token = "0x170001C4")]
		internal static IContractResolver Instance
		{
			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xF6E750", Offset = "0xF6E750", VA = "0xF6E750")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		public bool DynamicCodeGeneration
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xFB62AC", Offset = "0xFB62AC", VA = "0xFB62AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C6")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0xFB634C", Offset = "0xFB634C", VA = "0xFB634C")]
			get
			{
				return default(BindingFlags);
			}
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xFB6108", Offset = "0xFB6108", VA = "0xFB6108")]
			set
			{
			}
		}

		[Token(Token = "0x170001C7")]
		public bool SerializeCompilerGeneratedMembers
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0xFB6354", Offset = "0xFB6354", VA = "0xFB6354")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0xFB635C", Offset = "0xFB635C", VA = "0xFB635C")]
			set
			{
			}
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0xFB60E0", Offset = "0xFB60E0", VA = "0xFB60E0")]
		public DefaultContractResolver()
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0xFB60AC", Offset = "0xFB60AC", VA = "0xFB60AC")]
		public DefaultContractResolver(bool shareCache)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0xFB6364", Offset = "0xFB6364", VA = "0xFB6364")]
		private Dictionary<ResolverContractKey, JsonContract> GetCache()
		{
			return null;
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0xFB6430", Offset = "0xFB6430", VA = "0xFB6430")]
		private void UpdateCache(Dictionary<ResolverContractKey, JsonContract> cache)
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0xFB64FC", Offset = "0xFB64FC", VA = "0xFB64FC", Slot = "5")]
		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0xFB6808", Offset = "0xFB6808", VA = "0xFB6808", Slot = "6")]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0xFB7158", Offset = "0xFB7158", VA = "0xFB7158")]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0xFB7394", Offset = "0xFB7394", VA = "0xFB7394", Slot = "7")]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0xFB7B24", Offset = "0xFB7B24", VA = "0xFB7B24")]
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xFB7F74", Offset = "0xFB7F74", VA = "0xFB7F74")]
		private ConstructorInfo GetParametrizedConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xFB8154", Offset = "0xFB8154", VA = "0xFB8154", Slot = "8")]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xFB8740", Offset = "0xFB8740", VA = "0xFB8740", Slot = "9")]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0xFB95C0", Offset = "0xFB95C0", VA = "0xFB95C0", Slot = "10")]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0xFB966C", Offset = "0xFB966C", VA = "0xFB966C")]
		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0xFB7878", Offset = "0xFB7878", VA = "0xFB7878")]
		private void InitializeContract(JsonContract contract)
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0xFB979C", Offset = "0xFB979C", VA = "0xFB979C")]
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0xFB98F8", Offset = "0xFB98F8", VA = "0xFB98F8")]
		private void GetCallbackMethodsForType(Type type, out MethodInfo onSerializing, out MethodInfo onSerialized, out MethodInfo onDeserializing, out MethodInfo onDeserialized, out MethodInfo onError)
		{
			onDeserialized = default;
			onDeserializing = default;
			onError = default;
			onSerialized = default;
			onSerializing = default;
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0xFBAF54", Offset = "0xFBAF54", VA = "0xFBAF54", Slot = "11")]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0xFBB484", Offset = "0xFBB484", VA = "0xFBB484", Slot = "12")]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0xFBB9B8", Offset = "0xFBB9B8", VA = "0xFBB9B8", Slot = "13")]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0xFBBA5C", Offset = "0xFBBA5C", VA = "0xFBBA5C", Slot = "14")]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0xFBBB00", Offset = "0xFBBB00", VA = "0xFBBB00", Slot = "15")]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0xFBBE48", Offset = "0xFBBE48", VA = "0xFBBE48", Slot = "16")]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0xFBBEEC", Offset = "0xFBBEEC", VA = "0xFBBEEC", Slot = "17")]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0xFBC3A0", Offset = "0xFBC3A0", VA = "0xFBC3A0")]
		internal static bool CanConvertToString(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0xFB9E90", Offset = "0xFB9E90", VA = "0xFB9E90")]
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0xFBC6C8", Offset = "0xFBC6C8", VA = "0xFBC6C8")]
		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0xFBC9B8", Offset = "0xFBC9B8", VA = "0xFBC9B8", Slot = "18")]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0xFBCE5C", Offset = "0xFBCE5C", VA = "0xFBCE5C", Slot = "19")]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0xFBCEF0", Offset = "0xFBCEF0", VA = "0xFBCEF0", Slot = "20")]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0xFB8CA8", Offset = "0xFB8CA8", VA = "0xFB8CA8")]
		private void SetPropertySettingsFromAttributes(JsonProperty property, ICustomAttributeProvider attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess, out bool hasExplicitAttribute)
		{
			allowNonPublicAccess = default;
			hasExplicitAttribute = default;
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0xFBD0E4", Offset = "0xFBD0E4", VA = "0xFBD0E4")]
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xFBD444", Offset = "0xFBD444", VA = "0xFBD444")]
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0xFBD8E4", Offset = "0xFBD8E4", VA = "0xFBD8E4", Slot = "21")]
		protected internal virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0xFBD8EC", Offset = "0xFBD8EC", VA = "0xFBD8EC")]
		private static bool _003CGetSerializableMembers_003Em__46(MemberInfo m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0xFBD908", Offset = "0xFBD908", VA = "0xFBD908")]
		private static bool _003CGetSerializableMembers_003Em__47(MemberInfo m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0xFBD924", Offset = "0xFBD924", VA = "0xFBD924")]
		private static bool _003CCreateObjectContract_003Em__48(ConstructorInfo c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0xFBDA38", Offset = "0xFBDA38", VA = "0xFBDA38")]
		private static bool _003CGetAttributeConstructor_003Em__49(ConstructorInfo c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0xFBDB4C", Offset = "0xFBDB4C", VA = "0xFBDB4C")]
		private static int _003CCreateProperties_003Em__4B(JsonProperty p)
		{
			return default(int);
		}
	}
}
