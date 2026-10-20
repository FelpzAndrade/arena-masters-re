using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200013A")]
	internal static class JsonTypeReflector
	{
		[Token(Token = "0x4000528")]
		public const string IdPropertyName = "$id";

		[Token(Token = "0x4000529")]
		public const string RefPropertyName = "$ref";

		[Token(Token = "0x400052A")]
		public const string TypePropertyName = "$type";

		[Token(Token = "0x400052B")]
		public const string ValuePropertyName = "$value";

		[Token(Token = "0x400052C")]
		public const string ArrayValuesPropertyName = "$values";

		[Token(Token = "0x400052D")]
		public const string ShouldSerializePrefix = "ShouldSerialize";

		[Token(Token = "0x400052E")]
		public const string SpecifiedPostfix = "Specified";

		[Token(Token = "0x400052F")]
		private const string MetadataTypeAttributeTypeName = "System.ComponentModel.DataAnnotations.MetadataTypeAttribute, System.ComponentModel.DataAnnotations, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<ICustomAttributeProvider, Type> JsonConverterTypeCache;

		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x4")]
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x8")]
		private static Type _cachedMetadataTypeAttributeType;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0xC")]
		private static bool? _dynamicCodeGeneration;

		[Token(Token = "0x1700020B")]
		public static bool DynamicCodeGeneration
		{
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x119164C", Offset = "0x119164C", VA = "0x119164C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700020C")]
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x119181C", Offset = "0x119181C", VA = "0x119181C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x118FFF0", Offset = "0x118FFF0", VA = "0x118FFF0")]
		public static JsonContainerAttribute GetJsonContainerAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x11900B0", Offset = "0x11900B0", VA = "0x11900B0")]
		public static JsonObjectAttribute GetJsonObjectAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x119018C", Offset = "0x119018C", VA = "0x119018C")]
		public static JsonArrayAttribute GetJsonArrayAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x1190268", Offset = "0x1190268", VA = "0x1190268")]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x1190390", Offset = "0x1190390", VA = "0x1190390")]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x1190AB8", Offset = "0x1190AB8", VA = "0x1190AB8")]
		public static MemberSerialization GetObjectMemberSerialization(Type objectType)
		{
			return default(MemberSerialization);
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x1190BAC", Offset = "0x1190BAC", VA = "0x1190BAC")]
		private static Type GetJsonConverterType(ICustomAttributeProvider attributeProvider)
		{
			return null;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x1190C98", Offset = "0x1190C98", VA = "0x1190C98")]
		private static Type GetJsonConverterTypeFromAttribute(ICustomAttributeProvider attributeProvider)
		{
			return null;
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x1190D70", Offset = "0x1190D70", VA = "0x1190D70")]
		public static JsonConverter GetJsonConverter(ICustomAttributeProvider attributeProvider, Type targetConvertedType)
		{
			return null;
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x11910B0", Offset = "0x11910B0", VA = "0x11910B0")]
		public static TypeConverter GetTypeConverter(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x1191158", Offset = "0x1191158", VA = "0x1191158")]
		private static Type GetAssociatedMetadataType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x1191244", Offset = "0x1191244", VA = "0x1191244")]
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x1191434", Offset = "0x1191434", VA = "0x1191434")]
		private static Type GetMetadataTypeAttributeType()
		{
			return null;
		}

		[Token(Token = "0x6000C24")]
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000C25")]
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000C26")]
		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider) where T : Attribute
		{
			return null;
		}
	}
}
