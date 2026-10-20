using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000167")]
	internal static class ReflectionUtils
	{
		[Token(Token = "0x2000168")]
		private sealed class _003CGetFieldsAndProperties_003Ec__AnonStoreyDE
		{
			[Token(Token = "0x400057E")]
			[FieldOffset(Offset = "0x8")]
			internal BindingFlags bindingAttr;

			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x119E958", Offset = "0x119E958", VA = "0x119E958")]
			public _003CGetFieldsAndProperties_003Ec__AnonStoreyDE()
			{
			}

			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x11A002C", Offset = "0x11A002C", VA = "0x11A002C")]
			internal bool _003C_003Em__6D(MemberInfo m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000169")]
		private sealed class _003CGetChildPrivateProperties_003Ec__AnonStoreyDF
		{
			[Token(Token = "0x400057F")]
			[FieldOffset(Offset = "0x8")]
			internal PropertyInfo nonPublicProperty;

			[Token(Token = "0x6000D81")]
			[Address(RVA = "0x119FC98", Offset = "0x119FC98", VA = "0x119FC98")]
			public _003CGetChildPrivateProperties_003Ec__AnonStoreyDF()
			{
			}

			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x119FEFC", Offset = "0x119FEFC", VA = "0x119FEFC")]
			internal bool _003C_003Em__71(PropertyInfo p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x0")]
		private static Func<MemberInfo, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x4")]
		private static Func<IGrouping<string, MemberInfo>, _003C_003E__AnonType0<int, IEnumerable<MemberInfo>>> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x8")]
		private static Func<Type, IList<object>, object> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0xC")]
		private static Func<ParameterInfo, Type> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x10")]
		private static Func<FieldInfo, bool> _003C_003Ef__am_0024cache4;

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x1190674", Offset = "0x1190674", VA = "0x1190674")]
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x11998DC", Offset = "0x11998DC", VA = "0x11998DC")]
		public static Type GetObjectType(object v)
		{
			return null;
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x119C9E4", Offset = "0x119C9E4", VA = "0x119C9E4")]
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat)
		{
			return null;
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x118EE78", Offset = "0x118EE78", VA = "0x118EE78")]
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x119C9FC", Offset = "0x119C9FC", VA = "0x119C9FC")]
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			return null;
		}

		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x11967FC", Offset = "0x11967FC", VA = "0x11967FC")]
		public static bool IsInstantiatableType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x119CB80", Offset = "0x119CB80", VA = "0x119CB80")]
		public static bool HasDefaultConstructor(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x119CB88", Offset = "0x119CB88", VA = "0x119CB88")]
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x119CD2C", Offset = "0x119CD2C", VA = "0x119CD2C")]
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x119CC54", Offset = "0x119CC54", VA = "0x119CC54")]
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x1197F68", Offset = "0x1197F68", VA = "0x1197F68")]
		public static bool IsNullable(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x1197D44", Offset = "0x1197D44", VA = "0x1197D44")]
		public static bool IsNullableType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x119CD34", Offset = "0x119CD34", VA = "0x119CD34")]
		public static Type EnsureNotNullableType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x119CD64", Offset = "0x119CD64", VA = "0x119CD64")]
		public static bool IsUnitializedValue(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x119CDC8", Offset = "0x119CDC8", VA = "0x119CDC8")]
		public static object CreateUnitializedValue(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x119D14C", Offset = "0x119D14C", VA = "0x119D14C")]
		public static bool IsPropertyIndexed(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x1193A30", Offset = "0x1193A30", VA = "0x1193A30")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x11942D0", Offset = "0x11942D0", VA = "0x11942D0")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			implementingType = default;
			return default(bool);
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x119D23C", Offset = "0x119D23C", VA = "0x119D23C")]
		public static bool AssignableToTypeName(this Type type, string fullTypeName, out Type match)
		{
			match = default;
			return default(bool);
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x119D4CC", Offset = "0x119D4CC", VA = "0x119D4CC")]
		public static bool AssignableToTypeName(this Type type, string fullTypeName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x1196AC0", Offset = "0x1196AC0", VA = "0x1196AC0")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x1196398", Offset = "0x1196398", VA = "0x1196398")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			implementingType = default;
			return default(bool);
		}

		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x119D4F0", Offset = "0x119D4F0", VA = "0x119D4F0")]
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			implementingType = default;
			return default(bool);
		}

		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x1194684", Offset = "0x1194684", VA = "0x1194684")]
		public static Type GetCollectionItemType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x119D604", Offset = "0x119D604", VA = "0x119D604")]
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			keyType = default;
			valueType = default;
		}

		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x11956E4", Offset = "0x11956E4", VA = "0x11956E4")]
		public static Type GetDictionaryValueType(Type dictionaryType)
		{
			return null;
		}

		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x11956B4", Offset = "0x11956B4", VA = "0x11956B4")]
		public static Type GetDictionaryKeyType(Type dictionaryType)
		{
			return null;
		}

		[Token(Token = "0x6000D5D")]
		public static bool ItemsUnitializedValue<T>(IList<T> list)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x119DA60", Offset = "0x119DA60", VA = "0x119DA60")]
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x119DCC8", Offset = "0x119DCC8", VA = "0x119DCC8")]
		public static bool IsIndexedProperty(MemberInfo member)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x119DD98", Offset = "0x119DD98", VA = "0x119DD98")]
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x1191A80", Offset = "0x1191A80", VA = "0x1191A80")]
		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x11923A4", Offset = "0x11923A4", VA = "0x11923A4")]
		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
		}

		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x119DE74", Offset = "0x119DE74", VA = "0x119DE74")]
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x119E020", Offset = "0x119E020", VA = "0x119E020")]
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D65")]
		public static List<MemberInfo> GetFieldsAndProperties<T>(BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x119E1EC", Offset = "0x119E1EC", VA = "0x119E1EC")]
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x119ED14", Offset = "0x119ED14", VA = "0x119ED14")]
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D68")]
		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000D69")]
		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000D6A")]
		public static T[] GetAttributes<T>(ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x119EFB4", Offset = "0x119EFB4", VA = "0x119EFB4")]
		public static string GetNameAndAssessmblyName(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x11965CC", Offset = "0x11965CC", VA = "0x11965CC")]
		public static Type MakeGenericType(Type genericTypeDefinition, params Type[] innerTypes)
		{
			return null;
		}

		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x11935A8", Offset = "0x11935A8", VA = "0x11935A8")]
		public static object CreateGeneric(Type genericTypeDefinition, Type innerType, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x119F218", Offset = "0x119F218", VA = "0x119F218")]
		public static object CreateGeneric(Type genericTypeDefinition, IList<Type> innerTypes, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x1194B0C", Offset = "0x1194B0C", VA = "0x1194B0C")]
		public static object CreateGeneric(Type genericTypeDefinition, IList<Type> innerTypes, Func<Type, IList<object>, object> instanceCreator, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x119F334", Offset = "0x119F334", VA = "0x119F334")]
		public static bool IsCompatibleValue(object value, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x1196AE4", Offset = "0x1196AE4", VA = "0x1196AE4")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x119F3AC", Offset = "0x119F3AC", VA = "0x119F3AC")]
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
			assemblyName = default;
			typeName = default;
		}

		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x119F53C", Offset = "0x119F53C", VA = "0x119F53C")]
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			return null;
		}

		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x119076C", Offset = "0x119076C", VA = "0x119076C")]
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x119E960", Offset = "0x119E960", VA = "0x119E960")]
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x119F6B0", Offset = "0x119F6B0", VA = "0x119F6B0")]
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
		}

		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x119EAA4", Offset = "0x119EAA4", VA = "0x119EAA4")]
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x119F8F0", Offset = "0x119F8F0", VA = "0x119F8F0")]
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			return default(BindingFlags);
		}

		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x119F904", Offset = "0x119F904", VA = "0x119F904")]
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x119FCA0", Offset = "0x119FCA0", VA = "0x119FCA0")]
		private static string _003CGetFieldsAndProperties_003Em__6B(MemberInfo m)
		{
			return null;
		}

		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x119FCF8", Offset = "0x119FCF8", VA = "0x119FCF8")]
		private static _003C_003E__AnonType0<int, IEnumerable<MemberInfo>> _003CGetFieldsAndProperties_003Em__6C(IGrouping<string, MemberInfo> g)
		{
			return null;
		}

		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x119FDE0", Offset = "0x119FDE0", VA = "0x119FDE0")]
		private static object _003CCreateGeneric_003Em__6E(Type t, IList<object> a)
		{
			return null;
		}

		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x119FE78", Offset = "0x119FE78", VA = "0x119FE78")]
		private static Type _003CGetMemberInfoFromType_003Em__6F(ParameterInfo p)
		{
			return null;
		}

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x119FED0", Offset = "0x119FED0", VA = "0x119FED0")]
		private static bool _003CGetChildPrivateFields_003Em__70(FieldInfo f)
		{
			return default(bool);
		}
	}
}
