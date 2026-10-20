using System;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200014B")]
	internal static class ConvertUtils
	{
		[Token(Token = "0x200014C")]
		internal struct TypeConvertKey : IEquatable<TypeConvertKey>
		{
			[Token(Token = "0x4000559")]
			[FieldOffset(Offset = "0x0")]
			private readonly Type _initialType;

			[Token(Token = "0x400055A")]
			[FieldOffset(Offset = "0x4")]
			private readonly Type _targetType;

			[Token(Token = "0x1700021E")]
			public Type InitialType
			{
				[Token(Token = "0x6000CA9")]
				[Address(RVA = "0x1199CD0", Offset = "0x1199CD0", VA = "0x1199CD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700021F")]
			public Type TargetType
			{
				[Token(Token = "0x6000CAA")]
				[Address(RVA = "0x1199CD8", Offset = "0x1199CD8", VA = "0x1199CD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x1199CC4", Offset = "0x1199CC4", VA = "0x1199CC4")]
			public TypeConvertKey(Type initialType, Type targetType)
			{
				this = default;
			}

			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x1199D74", Offset = "0x1199D74", VA = "0x1199D74", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x1199E6C", Offset = "0x1199E6C", VA = "0x1199E6C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x1199E74", Offset = "0x1199E74", VA = "0x1199E74", Slot = "4")]
			public bool Equals(TypeConvertKey other)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200014D")]
		private sealed class _003CCreateCastConverter_003Ec__AnonStoreyD2
		{
			[Token(Token = "0x400055B")]
			[FieldOffset(Offset = "0x8")]
			internal MethodCall<object, object> call;

			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x119763C", Offset = "0x119763C", VA = "0x119763C")]
			public _003CCreateCastConverter_003Ec__AnonStoreyD2()
			{
			}

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x1199A28", Offset = "0x1199A28", VA = "0x1199A28")]
			internal object _003C_003Em__59(object o)
			{
				return null;
			}
		}

		[Token(Token = "0x200014E")]
		private sealed class _003CTryConvert_003Ec__AnonStoreyD3<T>
		{
			[Token(Token = "0x400055C")]
			[FieldOffset(Offset = "0x0")]
			internal object initialValue;

			[Token(Token = "0x6000CB0")]
			public _003CTryConvert_003Ec__AnonStoreyD3()
			{
			}

			[Token(Token = "0x6000CB1")]
			internal T _003C_003Em__5A()
			{
				return (T)default;
			}
		}

		[Token(Token = "0x200014F")]
		private sealed class _003CTryConvert_003Ec__AnonStoreyD4
		{
			[Token(Token = "0x400055D")]
			[FieldOffset(Offset = "0x8")]
			internal object initialValue;

			[Token(Token = "0x400055E")]
			[FieldOffset(Offset = "0xC")]
			internal CultureInfo culture;

			[Token(Token = "0x400055F")]
			[FieldOffset(Offset = "0x10")]
			internal Type targetType;

			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x1199710", Offset = "0x1199710", VA = "0x1199710")]
			public _003CTryConvert_003Ec__AnonStoreyD4()
			{
			}

			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x1199B4C", Offset = "0x1199B4C", VA = "0x1199B4C")]
			internal object _003C_003Em__5B()
			{
				return null;
			}
		}

		[Token(Token = "0x2000150")]
		private sealed class _003CTryConvertOrCast_003Ec__AnonStoreyD5<T>
		{
			[Token(Token = "0x4000560")]
			[FieldOffset(Offset = "0x0")]
			internal object initialValue;

			[Token(Token = "0x6000CB4")]
			public _003CTryConvertOrCast_003Ec__AnonStoreyD5()
			{
			}

			[Token(Token = "0x6000CB5")]
			internal T _003C_003Em__5C()
			{
				return (T)default;
			}
		}

		[Token(Token = "0x2000151")]
		private sealed class _003CTryConvertOrCast_003Ec__AnonStoreyD6
		{
			[Token(Token = "0x4000561")]
			[FieldOffset(Offset = "0x8")]
			internal object initialValue;

			[Token(Token = "0x4000562")]
			[FieldOffset(Offset = "0xC")]
			internal CultureInfo culture;

			[Token(Token = "0x4000563")]
			[FieldOffset(Offset = "0x10")]
			internal Type targetType;

			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x1199A20", Offset = "0x1199A20", VA = "0x1199A20")]
			public _003CTryConvertOrCast_003Ec__AnonStoreyD6()
			{
			}

			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x1199C08", Offset = "0x1199C08", VA = "0x1199C08")]
			internal object _003C_003Em__5D()
			{
				return null;
			}
		}

		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters;

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x1197168", Offset = "0x1197168", VA = "0x1197168")]
		private static Func<object, object> CreateCastConverter(TypeConvertKey t)
		{
			return null;
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x1197644", Offset = "0x1197644", VA = "0x1197644")]
		public static bool CanConvertType(Type initialType, Type targetType, bool allowTypeNameToString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x1197EB4", Offset = "0x1197EB4", VA = "0x1197EB4")]
		private static bool IsComponentConverter(TypeConverter converter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C99")]
		public static T Convert<T>(object initialValue)
		{
			return (T)default;
		}

		[Token(Token = "0x6000C9A")]
		public static T Convert<T>(object initialValue, CultureInfo culture)
		{
			return (T)default;
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x1198020", Offset = "0x1198020", VA = "0x1198020")]
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000C9C")]
		public static bool TryConvert<T>(object initialValue, out T convertedValue)
		{
			convertedValue = default;
			return default(bool);
		}

		[Token(Token = "0x6000C9D")]
		public static bool TryConvert<T>(object initialValue, CultureInfo culture, out T convertedValue)
		{
			convertedValue = default;
			return default(bool);
		}

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x11995E4", Offset = "0x11995E4", VA = "0x11995E4")]
		public static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object convertedValue)
		{
			convertedValue = default;
			return default(bool);
		}

		[Token(Token = "0x6000C9F")]
		public static T ConvertOrCast<T>(object initialValue)
		{
			return (T)default;
		}

		[Token(Token = "0x6000CA0")]
		public static T ConvertOrCast<T>(object initialValue, CultureInfo culture)
		{
			return (T)default;
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x1199718", Offset = "0x1199718", VA = "0x1199718")]
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000CA2")]
		public static bool TryConvertOrCast<T>(object initialValue, out T convertedValue)
		{
			convertedValue = default;
			return default(bool);
		}

		[Token(Token = "0x6000CA3")]
		public static bool TryConvertOrCast<T>(object initialValue, CultureInfo culture, out T convertedValue)
		{
			convertedValue = default;
			return default(bool);
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x11998F4", Offset = "0x11998F4", VA = "0x11998F4")]
		public static bool TryConvertOrCast(object initialValue, CultureInfo culture, Type targetType, out object convertedValue)
		{
			convertedValue = default;
			return default(bool);
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x1199280", Offset = "0x1199280", VA = "0x1199280")]
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x118EBCC", Offset = "0x118EBCC", VA = "0x118EBCC")]
		internal static TypeConverter GetConverter(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x11991C4", Offset = "0x11991C4", VA = "0x11991C4")]
		public static bool IsInteger(object value)
		{
			return default(bool);
		}
	}
}
