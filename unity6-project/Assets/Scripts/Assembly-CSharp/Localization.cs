using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000215")]
public static class Localization
{
	[Token(Token = "0x2000216")]
	public delegate byte[] LoadFunction(string path);

	[Token(Token = "0x2000217")]
	public delegate void OnLocalizeNotification();

	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x0")]
	public static LoadFunction loadFunction;

	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x4")]
	public static OnLocalizeNotification onLocalize;

	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x8")]
	public static bool localizationHasBeenSet;

	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0xC")]
	private static string[] mLanguages;

	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, string> mOldDictionary;

	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<string, string[]> mDictionary;

	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<string, string> mReplacement;

	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x1C")]
	private static int mLanguageIndex;

	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x20")]
	private static string mLanguage;

	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x24")]
	private static bool mMerging;

	[Token(Token = "0x170002A1")]
	public static Dictionary<string, string[]> dictionary
	{
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x1354944", Offset = "0x1354944", VA = "0x1354944")]
		get
		{
			return null;
		}
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x1354FB8", Offset = "0x1354FB8", VA = "0x1354FB8")]
		set
		{
		}
	}

	[Token(Token = "0x170002A2")]
	public static string[] knownLanguages
	{
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x1355094", Offset = "0x1355094", VA = "0x1355094")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A3")]
	public static string language
	{
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x1355200", Offset = "0x1355200", VA = "0x1355200")]
		get
		{
			return null;
		}
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x1355750", Offset = "0x1355750", VA = "0x1355750")]
		set
		{
		}
	}

	[Token(Token = "0x170002A4")]
	public static bool isActive
	{
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x13592C8", Offset = "0x13592C8", VA = "0x13592C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600116E")]
	[Address(RVA = "0x1354AB0", Offset = "0x1354AB0", VA = "0x1354AB0")]
	private static bool LoadDictionary(string value)
	{
		return default(bool);
	}

	[Token(Token = "0x600116F")]
	[Address(RVA = "0x13553E8", Offset = "0x13553E8", VA = "0x13553E8")]
	private static bool LoadAndSelect(string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001170")]
	[Address(RVA = "0x1355EDC", Offset = "0x1355EDC", VA = "0x1355EDC")]
	public static void Load(TextAsset asset)
	{
	}

	[Token(Token = "0x6001171")]
	[Address(RVA = "0x13559F4", Offset = "0x13559F4", VA = "0x13559F4")]
	public static void Set(string languageName, byte[] bytes)
	{
	}

	[Token(Token = "0x6001172")]
	[Address(RVA = "0x1356260", Offset = "0x1356260", VA = "0x1356260")]
	public static void ReplaceKey(string key, string val)
	{
	}

	[Token(Token = "0x6001173")]
	[Address(RVA = "0x1356418", Offset = "0x1356418", VA = "0x1356418")]
	public static void ClearReplacements()
	{
	}

	[Token(Token = "0x6001174")]
	[Address(RVA = "0x13564FC", Offset = "0x13564FC", VA = "0x13564FC")]
	public static bool LoadCSV(TextAsset asset, bool merge = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001175")]
	[Address(RVA = "0x1355944", Offset = "0x1355944", VA = "0x1355944")]
	public static bool LoadCSV(byte[] bytes, bool merge = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001176")]
	[Address(RVA = "0x1357664", Offset = "0x1357664", VA = "0x1357664")]
	private static bool HasLanguage(string languageName)
	{
		return default(bool);
	}

	[Token(Token = "0x6001177")]
	[Address(RVA = "0x13565D0", Offset = "0x13565D0", VA = "0x13565D0")]
	private static bool LoadCSV(byte[] bytes, TextAsset asset, bool merge = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001178")]
	[Address(RVA = "0x135782C", Offset = "0x135782C", VA = "0x135782C")]
	private static void AddCSV(BetterList<string> newValues, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
	}

	[Token(Token = "0x6001179")]
	[Address(RVA = "0x1357D94", Offset = "0x1357D94", VA = "0x1357D94")]
	private static string[] ExtractStrings(BetterList<string> added, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
		return null;
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0x1355AF0", Offset = "0x1355AF0", VA = "0x1355AF0")]
	private static bool SelectLanguage(string language)
	{
		return default(bool);
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x1355FEC", Offset = "0x1355FEC", VA = "0x1355FEC")]
	public static void Set(string languageName, Dictionary<string, string> dictionary)
	{
	}

	[Token(Token = "0x600117C")]
	[Address(RVA = "0x13581E0", Offset = "0x13581E0", VA = "0x13581E0")]
	public static void Set(string key, string value)
	{
	}

	[Token(Token = "0x600117D")]
	[Address(RVA = "0x13583C0", Offset = "0x13583C0", VA = "0x13583C0")]
	public static string Get(string key)
	{
		return null;
	}

	[Token(Token = "0x600117E")]
	[Address(RVA = "0x13591D4", Offset = "0x13591D4", VA = "0x13591D4")]
	public static string Format(string key, params object[] parameters)
	{
		return null;
	}

	[Token(Token = "0x6001180")]
	[Address(RVA = "0x13592D0", Offset = "0x13592D0", VA = "0x13592D0")]
	public static string Localize(string key)
	{
		return null;
	}

	[Token(Token = "0x6001181")]
	[Address(RVA = "0x1359370", Offset = "0x1359370", VA = "0x1359370")]
	public static bool Exists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6001182")]
	[Address(RVA = "0x13596F0", Offset = "0x13596F0", VA = "0x13596F0")]
	public static void Set(string language, string key, string text)
	{
	}
}
