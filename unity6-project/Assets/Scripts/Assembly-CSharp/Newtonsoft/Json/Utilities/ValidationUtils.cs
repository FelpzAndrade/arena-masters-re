using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000171")]
	internal static class ValidationUtils
	{
		[Token(Token = "0x4000590")]
		public const string EmailAddressRegex = "^([a-zA-Z0-9_'+*$%\\^&!\\.\\-])+\\@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9:]{2,4})+$";

		[Token(Token = "0x4000591")]
		public const string CurrencyRegex = "(^\\$?(?!0,?\\d)\\d{1,3}(,?\\d{3})*(\\.\\d\\d)?)$";

		[Token(Token = "0x4000592")]
		public const string DateRegex = "^(((0?[1-9]|[12]\\d|3[01])[\\.\\-\\/](0?[13578]|1[02])[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|((0?[1-9]|[12]\\d|30)[\\.\\-\\/](0?[13456789]|1[012])[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|((0?[1-9]|1\\d|2[0-8])[\\.\\-\\/]0?2[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|(29[\\.\\-\\/]0?2[\\.\\-\\/]((1[6-9]|[2-9]\\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00|[048])))$";

		[Token(Token = "0x4000593")]
		public const string NumericRegex = "\\d*";

		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x11A1FA8", Offset = "0x11A1FA8", VA = "0x11A1FA8")]
		public static void ArgumentNotNullOrEmpty(string value, string parameterName)
		{
		}

		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x11A21A0", Offset = "0x11A21A0", VA = "0x11A21A0")]
		public static void ArgumentNotNullOrEmptyOrWhitespace(string value, string parameterName)
		{
		}

		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x11A2358", Offset = "0x11A2358", VA = "0x11A2358")]
		public static void ArgumentTypeIsEnum(Type enumType, string parameterName)
		{
		}

		[Token(Token = "0x6000DB4")]
		public static void ArgumentNotNullOrEmpty<T>(ICollection<T> collection, string parameterName)
		{
		}

		[Token(Token = "0x6000DB5")]
		public static void ArgumentNotNullOrEmpty<T>(ICollection<T> collection, string parameterName, string message)
		{
		}

		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x11A252C", Offset = "0x11A252C", VA = "0x11A252C")]
		public static void ArgumentNotNullOrEmpty(ICollection collection, string parameterName)
		{
		}

		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x11A26A0", Offset = "0x11A26A0", VA = "0x11A26A0")]
		public static void ArgumentNotNullOrEmpty(ICollection collection, string parameterName, string message)
		{
		}

		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x118F25C", Offset = "0x118F25C", VA = "0x118F25C")]
		public static void ArgumentNotNull(object value, string parameterName)
		{
		}

		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x11A281C", Offset = "0x11A281C", VA = "0x11A281C")]
		public static void ArgumentNotNegative(int value, string parameterName)
		{
		}

		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x11A28DC", Offset = "0x11A28DC", VA = "0x11A28DC")]
		public static void ArgumentNotNegative(int value, string parameterName, string message)
		{
		}

		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x11A2994", Offset = "0x11A2994", VA = "0x11A2994")]
		public static void ArgumentNotZero(int value, string parameterName)
		{
		}

		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x11A2A58", Offset = "0x11A2A58", VA = "0x11A2A58")]
		public static void ArgumentNotZero(int value, string parameterName, string message)
		{
		}

		[Token(Token = "0x6000DBD")]
		public static void ArgumentIsPositive<T>(T value, string parameterName) where T : struct, IComparable<T>
		{
		}

		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x11A2B14", Offset = "0x11A2B14", VA = "0x11A2B14")]
		public static void ArgumentIsPositive(int value, string parameterName, string message)
		{
		}

		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x11A2BCC", Offset = "0x11A2BCC", VA = "0x11A2BCC")]
		public static void ObjectNotDisposed(bool disposed, Type objectType)
		{
		}

		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x119F168", Offset = "0x119F168", VA = "0x119F168")]
		public static void ArgumentConditionTrue(bool condition, string parameterName, string message)
		{
		}
	}
}
