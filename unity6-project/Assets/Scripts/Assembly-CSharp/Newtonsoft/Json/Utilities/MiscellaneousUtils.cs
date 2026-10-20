using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000165")]
	internal static class MiscellaneousUtils
	{
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x118DCF8", Offset = "0x118DCF8", VA = "0x118DCF8")]
		public static bool ValueEquals(object objA, object objB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x119A2D8", Offset = "0x119A2D8", VA = "0x119A2D8")]
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			return null;
		}

		[Token(Token = "0x6000D30")]
		public static bool TryAction<T>(Creator<T> creator, out T output)
		{
			output = default;
			return default(bool);
		}

		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x119C3C0", Offset = "0x119C3C0", VA = "0x119C3C0")]
		public static string ToString(object value)
		{
			return null;
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x119C510", Offset = "0x119C510", VA = "0x119C510")]
		public static byte[] HexToBytes(string hex)
		{
			return null;
		}

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x119C6E0", Offset = "0x119C6E0", VA = "0x119C6E0")]
		public static string BytesToHex(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x119C6E8", Offset = "0x119C6E8", VA = "0x119C6E8")]
		public static string BytesToHex(byte[] bytes, bool removeDashes)
		{
			return null;
		}

		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x119C82C", Offset = "0x119C82C", VA = "0x119C82C")]
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			return default(int);
		}

		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x119C8E4", Offset = "0x119C8E4", VA = "0x119C8E4")]
		public static string GetPrefix(string qualifiedName)
		{
			return null;
		}

		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x119C9B4", Offset = "0x119C9B4", VA = "0x119C9B4")]
		public static string GetLocalName(string qualifiedName)
		{
			return null;
		}

		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x119C914", Offset = "0x119C914", VA = "0x119C914")]
		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
			localName = default;
			prefix = default;
		}
	}
}
