using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000084")]
	public class LocalizationReader
	{
		[Token(Token = "0x6000439")]
		[Address(RVA = "0xD77020", Offset = "0xD77020", VA = "0xD77020")]
		public LocalizationReader()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xD77028", Offset = "0xD77028", VA = "0xD77028")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xD77398", Offset = "0xD77398", VA = "0xD77398")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			category = default;
			comment = default;
			key = default;
			termType = default;
			value = default;
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xD778F0", Offset = "0xD778F0", VA = "0xD778F0")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xD69124", Offset = "0xD69124", VA = "0xD69124")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xD77B84", Offset = "0xD77B84", VA = "0xD77B84")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xD77DB8", Offset = "0xD77DB8", VA = "0xD77DB8")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xD6A644", Offset = "0xD6A644", VA = "0xD6A644")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xD77850", Offset = "0xD77850", VA = "0xD77850")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xD77F40", Offset = "0xD77F40", VA = "0xD77F40")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xD77704", Offset = "0xD77704", VA = "0xD77704")]
		public static string DecodeString(string str)
		{
			return null;
		}
	}
}
