using System.Globalization;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008B1")]
	public static class CSStringHelper
	{
		[Token(Token = "0x6004675")]
		[Address(RVA = "0x1CD6D0C", Offset = "0x1CD6D0C", VA = "0x1CD6D0C")]
		public static string AddComma(int num)
		{
			return null;
		}

		[Token(Token = "0x6004676")]
		[Address(RVA = "0x1CD6DF8", Offset = "0x1CD6DF8", VA = "0x1CD6DF8")]
		public static string AddCommaByLanguage(int num, [Optional] CultureInfo cultureInfo)
		{
			return null;
		}

		[Token(Token = "0x6004677")]
		[Address(RVA = "0x1CD6F58", Offset = "0x1CD6F58", VA = "0x1CD6F58")]
		public static string AddCommaByLanguage(float num, [Optional] CultureInfo cultureInfo)
		{
			return null;
		}

		[Token(Token = "0x6004678")]
		[Address(RVA = "0x1CD7054", Offset = "0x1CD7054", VA = "0x1CD7054")]
		public static string Truncate(this string value, int maxLength)
		{
			return null;
		}

		[Token(Token = "0x6004679")]
		[Address(RVA = "0x1CD714C", Offset = "0x1CD714C", VA = "0x1CD714C")]
		public static string GetSubstringAtLast(this string value, int subStrLength)
		{
			return null;
		}

		[Token(Token = "0x600467A")]
		[Address(RVA = "0x1CD7194", Offset = "0x1CD7194", VA = "0x1CD7194")]
		public static string MakeChannelPrefix(ConnectEnum.ServerType serverType)
		{
			return null;
		}

		[Token(Token = "0x600467B")]
		[Address(RVA = "0x1CD720C", Offset = "0x1CD720C", VA = "0x1CD720C")]
		public static string MakeClanChannelPrefix(ConnectEnum.ServerType serverType)
		{
			return null;
		}

		[Token(Token = "0x600467C")]
		[Address(RVA = "0x1CD7284", Offset = "0x1CD7284", VA = "0x1CD7284")]
		public static string MakeClanInviteChannelPrefix(ConnectEnum.ServerType serverType)
		{
			return null;
		}

		[Token(Token = "0x600467D")]
		[Address(RVA = "0x1CD72FC", Offset = "0x1CD72FC", VA = "0x1CD72FC")]
		public static string ReplaceBBCodeBracket(string str)
		{
			return null;
		}

		[Token(Token = "0x600467E")]
		[Address(RVA = "0x1CD73E4", Offset = "0x1CD73E4", VA = "0x1CD73E4")]
		public static string TrimSpace(string str, char[] removal)
		{
			return null;
		}
	}
}
