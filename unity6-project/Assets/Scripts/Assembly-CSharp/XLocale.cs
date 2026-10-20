using System.Globalization;
using I2.Loc;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000632")]
public class XLocale
{
	[Token(Token = "0x4001DD1")]
	[FieldOffset(Offset = "0x8")]
	private string m_strLanguage;

	[Token(Token = "0x4001DD2")]
	[FieldOffset(Offset = "0xC")]
	private string m_strProtoLanguage;

	[Token(Token = "0x4001DD3")]
	[FieldOffset(Offset = "0x10")]
	private UIFont m_localizedFont;

	[Token(Token = "0x4001DD4")]
	[FieldOffset(Offset = "0x14")]
	private IGetLocaleInfo localeGetter;

	[Token(Token = "0x4001DD5")]
	[FieldOffset(Offset = "0x18")]
	private CultureInfo cultureInfo;

	[Token(Token = "0x170007C3")]
	public string CurrentLangString
	{
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x1E1DB60", Offset = "0x1E1DB60", VA = "0x1E1DB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C4")]
	public CultureInfo CultureInfo
	{
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x1E1DB68", Offset = "0x1E1DB68", VA = "0x1E1DB68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003524")]
	[Address(RVA = "0x1E1CA8C", Offset = "0x1E1CA8C", VA = "0x1E1CA8C")]
	public XLocale(IGetLocaleInfo getter)
	{
	}

	[Token(Token = "0x6003525")]
	[Address(RVA = "0x1E1CBB0", Offset = "0x1E1CBB0", VA = "0x1E1CBB0")]
	public SystemLanguage GetSystemLanguage()
	{
		return default(SystemLanguage);
	}

	[Token(Token = "0x6003526")]
	[Address(RVA = "0x1E1CBBC", Offset = "0x1E1CBBC", VA = "0x1E1CBBC")]
	public bool IsSystemLanaguageKorean()
	{
		return default(bool);
	}

	[Token(Token = "0x6003527")]
	[Address(RVA = "0x1E1CBE4", Offset = "0x1E1CBE4", VA = "0x1E1CBE4")]
	public static string SystemLanguageToLang(SystemLanguage systemLanguage)
	{
		return null;
	}

	[Token(Token = "0x6003528")]
	[Address(RVA = "0x1E1CD84", Offset = "0x1E1CD84", VA = "0x1E1CD84")]
	public void SetLocale(string strLangString = "")
	{
	}

	[Token(Token = "0x6003529")]
	[Address(RVA = "0x1E1D2A8", Offset = "0x1E1D2A8", VA = "0x1E1D2A8")]
	public UIFont GetLocalizedFont()
	{
		return null;
	}

	[Token(Token = "0x600352A")]
	[Address(RVA = "0x1E1D014", Offset = "0x1E1D014", VA = "0x1E1D014")]
	private void SetLocalizedFont(string language)
	{
	}

	[Token(Token = "0x600352B")]
	[Address(RVA = "0x1E1D2B0", Offset = "0x1E1D2B0", VA = "0x1E1D2B0")]
	private UIFont LoadFont(string name)
	{
		return null;
	}

	[Token(Token = "0x600352C")]
	[Address(RVA = "0x1E1D48C", Offset = "0x1E1D48C", VA = "0x1E1D48C")]
	public void ChangeLocale(string strLangString)
	{
	}

	[Token(Token = "0x600352D")]
	[Address(RVA = "0x1E1CEF8", Offset = "0x1E1CEF8", VA = "0x1E1CEF8")]
	public void SetI2Localization(string strlang)
	{
	}

	[Token(Token = "0x600352E")]
	[Address(RVA = "0x1E1D6B8", Offset = "0x1E1D6B8", VA = "0x1E1D6B8")]
	public void ChangeProtoInfoStrings()
	{
	}

	[Token(Token = "0x6003530")]
	[Address(RVA = "0x1E1D75C", Offset = "0x1E1D75C", VA = "0x1E1D75C")]
	public void SetCultureInfo(string language)
	{
	}

	[Token(Token = "0x6003532")]
	[Address(RVA = "0x1E1DB70", Offset = "0x1E1DB70", VA = "0x1E1DB70")]
	public static void LoadLocalizationSource()
	{
	}

	[Token(Token = "0x6003533")]
	[Address(RVA = "0x1E1DC70", Offset = "0x1E1DC70", VA = "0x1E1DC70")]
	public static LanguageSource GetLocalizationSource()
	{
		return null;
	}
}
