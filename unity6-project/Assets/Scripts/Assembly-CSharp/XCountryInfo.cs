using System.Xml.Serialization;
using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000654")]
public class XCountryInfo
{
	[Token(Token = "0x4001E50")]
	private const string DEFAULT_TITLE_UI = "Title/logo";

	[Token(Token = "0x4001E51")]
	[FieldOffset(Offset = "0x8")]
	[XmlAttribute("country_code")]
	public string countryCode;

	[Token(Token = "0x4001E52")]
	[FieldOffset(Offset = "0xC")]
	[XmlAttribute("region_server_key")]
	public string regionServerKey;

	[Token(Token = "0x4001E53")]
	[FieldOffset(Offset = "0x10")]
	[XmlAttribute("ingame_region_server_key")]
	public string inGameRegionServerKey;

	[Token(Token = "0x4001E54")]
	[FieldOffset(Offset = "0x14")]
	[XmlAttribute("flag_icon")]
	public string flagIcon;

	[Token(Token = "0x4001E55")]
	[FieldOffset(Offset = "0x18")]
	[XmlAttribute("default_language")]
	public string defaultLanguage;

	[Token(Token = "0x4001E56")]
	[FieldOffset(Offset = "0x1C")]
	[XmlAttribute("use_grade_icon")]
	public string gradeIcon;

	[Token(Token = "0x4001E57")]
	[FieldOffset(Offset = "0x20")]
	[XmlAttribute("title_ui")]
	public string titleUI;

	[Token(Token = "0x4001E58")]
	[FieldOffset(Offset = "0x24")]
	[XmlAttribute("sub_tutile_ui")]
	public string subTitleUI;

	[Token(Token = "0x4001E59")]
	[FieldOffset(Offset = "0x28")]
	[XmlAttribute("matching_supplementation")]
	public string matchingSupplementation;

	[Token(Token = "0x4001E5A")]
	[FieldOffset(Offset = "0x2C")]
	[XmlAttribute("pay_law")]
	public string payLaw;

	[Token(Token = "0x4001E5B")]
	[FieldOffset(Offset = "0x30")]
	public bool IsActive;

	[Token(Token = "0x4001E5C")]
	[FieldOffset(Offset = "0x31")]
	public bool IsLogoEffect;

	[Token(Token = "0x4001E5D")]
	[FieldOffset(Offset = "0x32")]
	private bool IsMatchingSupplementation__BackingField;

	[Token(Token = "0x4001E5E")]
	[FieldOffset(Offset = "0x33")]
	private bool IsPayLaw__BackingField;

	[Token(Token = "0x170007DF")]
	public bool IsMatchingSupplementation
	{
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x19A16FC", Offset = "0x19A16FC", VA = "0x19A16FC")]
		get
		{
			return IsMatchingSupplementation__BackingField;
		}
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x19A1704", Offset = "0x19A1704", VA = "0x19A1704")]
		set
		{
			IsMatchingSupplementation__BackingField = value;
		}
	}

	[Token(Token = "0x170007E0")]
	public bool IsPayLaw
	{
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x19A170C", Offset = "0x19A170C", VA = "0x19A170C")]
		get
		{
			return IsPayLaw__BackingField;
		}
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x19A1714", Offset = "0x19A1714", VA = "0x19A1714")]
		set
		{
			IsPayLaw__BackingField = value;
		}
	}

	[Token(Token = "0x6003612")]
	[Address(RVA = "0x19A15E0", Offset = "0x19A15E0", VA = "0x19A15E0")]
	public XCountryInfo()
	{
		// titleUI e payLaw recebem literais que o pseudo-C nao resolve; valores coerentes com Cooking()
		regionServerKey = string.Empty;
		inGameRegionServerKey = string.Empty;
		titleUI = "Title/logo";
		matchingSupplementation = string.Empty;
		payLaw = "FALSE";
	}

	[Token(Token = "0x6003617")]
	[Address(RVA = "0x19A171C", Offset = "0x19A171C", VA = "0x19A171C")]
	public bool Cooking()
	{
		IsMatchingSupplementation = matchingSupplementation.ToUpper() == "TRUE";
		IsPayLaw = payLaw.ToUpper() == "TRUE";
		countryCode = countryCode.ToUpper();
		regionServerKey = regionServerKey.ToLower();
		inGameRegionServerKey = inGameRegionServerKey.ToLower();
		if (titleUI != "Title/logo")
		{
			IsLogoEffect = false;
		}
		return true;
	}
}
