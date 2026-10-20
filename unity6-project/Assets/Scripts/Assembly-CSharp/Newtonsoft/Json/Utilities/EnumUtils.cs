using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000156")]
	internal static class EnumUtils
	{
		[Token(Token = "0x2000157")]
		private sealed class _003CTryParse_003Ec__AnonStoreyD7<T> where T : struct
		{
			[Token(Token = "0x400056B")]
			[FieldOffset(Offset = "0x0")]
			internal string enumMemberName;

			[Token(Token = "0x400056C")]
			[FieldOffset(Offset = "0x0")]
			internal bool ignoreCase;

			[Token(Token = "0x6000CF2")]
			public _003CTryParse_003Ec__AnonStoreyD7()
			{
			}

			[Token(Token = "0x6000CF3")]
			internal T _003C_003Em__5F()
			{
				return (T)default;
			}
		}

		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x0")]
		private static Func<FieldInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x4")]
		private static Func<FieldInfo, bool> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6000CE3")]
		public static T Parse<T>(string enumMemberName) where T : struct
		{
			return (T)default;
		}

		[Token(Token = "0x6000CE4")]
		public static T Parse<T>(string enumMemberName, bool ignoreCase) where T : struct
		{
			return (T)default;
		}

		[Token(Token = "0x6000CE5")]
		public static bool TryParse<T>(string enumMemberName, bool ignoreCase, out T value) where T : struct
		{
			value = default;
			return default(bool);
		}

		[Token(Token = "0x6000CE6")]
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			return null;
		}

		[Token(Token = "0x6000CE7")]
		public static EnumValues<ulong> GetNamesAndValues<T>() where T : struct
		{
			return null;
		}

		[Token(Token = "0x6000CE8")]
		public static EnumValues<TUnderlyingType> GetNamesAndValues<TEnum, TUnderlyingType>() where TEnum : struct where TUnderlyingType : struct
		{
			return null;
		}

		[Token(Token = "0x6000CE9")]
		public static EnumValues<TUnderlyingType> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
		{
			return null;
		}

		[Token(Token = "0x6000CEA")]
		public static IList<T> GetValues<T>()
		{
			return null;
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x119A4D8", Offset = "0x119A4D8", VA = "0x119A4D8")]
		public static IList<object> GetValues(Type enumType)
		{
			return null;
		}

		[Token(Token = "0x6000CEC")]
		public static IList<string> GetNames<T>()
		{
			return null;
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x119AA74", Offset = "0x119AA74", VA = "0x119AA74")]
		public static IList<string> GetNames(Type enumType)
		{
			return null;
		}

		[Token(Token = "0x6000CEE")]
		public static TEnumType GetMaximumValue<TEnumType>(Type enumType) where TEnumType : IConvertible, IComparable<TEnumType>
		{
			return (TEnumType)default;
		}

		[Token(Token = "0x6000CEF")]
		private static bool _003CGetFlagsValues_00601_003Em__60<T>(EnumValue<ulong> v) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x119B00C", Offset = "0x119B00C", VA = "0x119B00C")]
		private static bool _003CGetValues_003Em__61(FieldInfo field)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x119B038", Offset = "0x119B038", VA = "0x119B038")]
		private static bool _003CGetNames_003Em__62(FieldInfo field)
		{
			return default(bool);
		}
	}
}
