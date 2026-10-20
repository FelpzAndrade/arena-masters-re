using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200016B")]
	internal static class StringUtils
	{
		[Token(Token = "0x200016C")]
		private delegate void ActionLine(TextWriter textWriter, string line);

		[Token(Token = "0x200016D")]
		private sealed class _003CIndent_003Ec__AnonStoreyE0
		{
			[Token(Token = "0x4000588")]
			[FieldOffset(Offset = "0x8")]
			internal char indentChar;

			[Token(Token = "0x4000589")]
			[FieldOffset(Offset = "0xC")]
			internal int indentation;

			[Token(Token = "0x6000DA7")]
			[Address(RVA = "0x11A0FE4", Offset = "0x11A0FE4", VA = "0x11A0FE4")]
			public _003CIndent_003Ec__AnonStoreyE0()
			{
			}

			[Token(Token = "0x6000DA8")]
			[Address(RVA = "0x11A1D18", Offset = "0x11A1D18", VA = "0x11A1D18")]
			internal void _003C_003Em__72(TextWriter tw, string line)
			{
			}
		}

		[Token(Token = "0x200016E")]
		private sealed class _003CNumberLines_003Ec__AnonStoreyE1
		{
			[Token(Token = "0x400058A")]
			[FieldOffset(Offset = "0x8")]
			internal int lineNumber;

			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0x11A13BC", Offset = "0x11A13BC", VA = "0x11A13BC")]
			public _003CNumberLines_003Ec__AnonStoreyE1()
			{
			}

			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x11A1DC0", Offset = "0x11A1DC0", VA = "0x11A1DC0")]
			internal void _003C_003Em__73(TextWriter tw, string line)
			{
			}
		}

		[Token(Token = "0x200016F")]
		private sealed class _003CForgivingCaseSensitiveFind_003Ec__AnonStoreyE2<TSource>
		{
			[Token(Token = "0x400058B")]
			[FieldOffset(Offset = "0x0")]
			internal Func<TSource, string> valueSelector;

			[Token(Token = "0x400058C")]
			[FieldOffset(Offset = "0x0")]
			internal string testValue;

			[Token(Token = "0x6000DAB")]
			public _003CForgivingCaseSensitiveFind_003Ec__AnonStoreyE2()
			{
			}

			[Token(Token = "0x6000DAC")]
			internal bool _003C_003Em__74(TSource s)
			{
				return default(bool);
			}

			[Token(Token = "0x6000DAD")]
			internal bool _003C_003Em__75(TSource s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000583")]
		public const string CarriageReturnLineFeed = "\r\n";

		[Token(Token = "0x4000584")]
		public const string Empty = "";

		[Token(Token = "0x4000585")]
		public const char CarriageReturn = '\r';

		[Token(Token = "0x4000586")]
		public const char LineFeed = '\n';

		[Token(Token = "0x4000587")]
		public const char Tab = '\t';

		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x118E838", Offset = "0x118E838", VA = "0x118E838")]
		public static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x11A05E4", Offset = "0x11A05E4", VA = "0x11A05E4")]
		public static bool ContainsWhiteSpace(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x11A0730", Offset = "0x11A0730", VA = "0x11A0730")]
		public static bool IsWhiteSpace(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x11A0890", Offset = "0x11A0890", VA = "0x11A0890")]
		public static string EnsureEndsWith(string target, string value)
		{
			return null;
		}

		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x11A0B54", Offset = "0x11A0B54", VA = "0x11A0B54")]
		public static bool IsNullOrEmptyOrWhiteSpace(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x11A0C10", Offset = "0x11A0C10", VA = "0x11A0C10")]
		public static void IfNotNullOrEmpty(string value, Action<string> action)
		{
		}

		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x11A0C2C", Offset = "0x11A0C2C", VA = "0x11A0C2C")]
		private static void IfNotNullOrEmpty(string value, Action<string> trueAction, Action<string> falseAction)
		{
		}

		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x11A0D40", Offset = "0x11A0D40", VA = "0x11A0D40")]
		public static string Indent(string s, int indentation)
		{
			return null;
		}

		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x11A0D5C", Offset = "0x11A0D5C", VA = "0x11A0D5C")]
		public static string Indent(string s, int indentation, char indentChar)
		{
			return null;
		}

		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x11A1000", Offset = "0x11A1000", VA = "0x11A1000")]
		private static void ActionTextReaderLine(TextReader textReader, TextWriter textWriter, ActionLine lineAction)
		{
		}

		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x11A118C", Offset = "0x11A118C", VA = "0x11A118C")]
		public static string NumberLines(string s)
		{
			return null;
		}

		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x11A13C4", Offset = "0x11A13C4", VA = "0x11A13C4")]
		public static string NullEmptyString(string s)
		{
			return null;
		}

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x11A1478", Offset = "0x11A1478", VA = "0x11A1478")]
		public static string ReplaceNewLines(string s, string replacement)
		{
			return null;
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x11A15D8", Offset = "0x11A15D8", VA = "0x11A15D8")]
		public static string Truncate(string s, int maximumLength)
		{
			return null;
		}

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x11A166C", Offset = "0x11A166C", VA = "0x11A166C")]
		public static string Truncate(string s, int maximumLength, string suffix)
		{
			return null;
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x119BA70", Offset = "0x119BA70", VA = "0x119BA70")]
		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x119B95C", Offset = "0x119B95C", VA = "0x119B95C")]
		public static int? GetLength(string value)
		{
			return null;
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x119B580", Offset = "0x119B580", VA = "0x119B580")]
		public static string ToCharAsUnicode(char c)
		{
			return null;
		}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x11A188C", Offset = "0x11A188C", VA = "0x11A188C")]
		public static void WriteCharAsUnicode(TextWriter writer, char c)
		{
		}

		[Token(Token = "0x6000DA1")]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return (TSource)default;
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x11A1AA0", Offset = "0x11A1AA0", VA = "0x11A1AA0")]
		public static string ToCamelCase(string s)
		{
			return null;
		}
	}
}
