using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000064")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x2000065")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x40001AD")]
			[FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x40001AE")]
			[FieldOffset(Offset = "0x4")]
			public string GoogleCode;
		}

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xD61988", Offset = "0xD61988", VA = "0xD61988")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xD620CC", Offset = "0xD620CC", VA = "0xD620CC")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xD629A0", Offset = "0xD629A0", VA = "0xD629A0")]
		public static string GetClosestLanguage(string Filter)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xD61ECC", Offset = "0xD61ECC", VA = "0xD61ECC")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xD62E24", Offset = "0xD62E24", VA = "0xD62E24")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xD6306C", Offset = "0xD6306C", VA = "0xD6306C")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xD631FC", Offset = "0xD631FC", VA = "0xD631FC")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
			Language = default;
			code = default;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xD6342C", Offset = "0xD6342C", VA = "0xD6342C")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xD6380C", Offset = "0xD6380C", VA = "0xD6380C")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}
	}
}
