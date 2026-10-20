using Il2CppDummyDll;

namespace CS.Util
{
	[Token(Token = "0x200089C")]
	public static class Enumer
	{
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x21EEBD4", Offset = "0x21EEBD4", VA = "0x21EEBD4")]
		public static string concat(string str1, string str2, char infix = '_')
		{
			return null;
		}

		[Token(Token = "0x60045DB")]
		[Address(RVA = "0x21EECA8", Offset = "0x21EECA8", VA = "0x21EECA8")]
		public static string concat(string str1, string str2, string str3, char infix = '_')
		{
			return null;
		}

		[Token(Token = "0x60045DC")]
		[Address(RVA = "0x21EEF10", Offset = "0x21EEF10", VA = "0x21EEF10")]
		public static string concat(string[] str, char infix = '_')
		{
			return null;
		}

		[Token(Token = "0x60045DD")]
		public static T? combine<T>(string str1, string str2, bool silently = false) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60045DE")]
		public static T? combine<T>(string str1, string str2, string str3, bool silently = false) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60045DF")]
		public static T? combine<T>(string str1, string str2, string str3, string str4, bool silently = false) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60045E0")]
		public static T? combine<T>(string[] str, bool silently = false) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60045E1")]
		public static T? parse<T>(string str, bool silently = false) where T : struct
		{
			return null;
		}
	}
}
