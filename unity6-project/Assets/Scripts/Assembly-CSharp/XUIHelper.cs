using System.Globalization;
using System;
using System.Runtime.InteropServices;
using System.Text;
using CS;
using Il2CppDummyDll;
using NPA;
using UnityEngine;

[Token(Token = "0x20006C6")]
public static class XUIHelper
{
	[Token(Token = "0x4002058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static StringBuilder builder;

	[Token(Token = "0x600385D")]
	[Address(RVA = "0x107C0D8", Offset = "0x107C0D8", VA = "0x107C0D8")]
	public static void SetLobbyBackground(LobbyBackground backgroundType)
	{
	}

	[Token(Token = "0x600385E")]
	[Address(RVA = "0x107C244", Offset = "0x107C244", VA = "0x107C244")]
	public static string GetGameModeNameText(XGameModeType gameModeType)
	{
		return null;
	}

	[Token(Token = "0x600385F")]
	[Address(RVA = "0x107C45C", Offset = "0x107C45C", VA = "0x107C45C")]
	public static void SetLabelText(GameObject widget, string text)
	{
	}

	[Token(Token = "0x6003860")]
	[Address(RVA = "0x107C614", Offset = "0x107C614", VA = "0x107C614")]
	public static string GetLabelText(GameObject widget)
	{
		return null;
	}

	[Token(Token = "0x6003861")]
	[Address(RVA = "0x107C7E0", Offset = "0x107C7E0", VA = "0x107C7E0")]
	public static void SetLabelColor(GameObject widget, Color color)
	{
	}

	[Token(Token = "0x6003862")]
	[Address(RVA = "0x107C8FC", Offset = "0x107C8FC", VA = "0x107C8FC")]
	public static void SetChildSprite(GameObject parent, string widgetName, string strSpriteName)
	{
	}

	[Token(Token = "0x6003863")]
	[Address(RVA = "0x107CAF4", Offset = "0x107CAF4", VA = "0x107CAF4")]
	public static void SetSprite(GameObject widget, string strSpriteName)
	{
	}

	[Token(Token = "0x6003864")]
	[Address(RVA = "0x107CC0C", Offset = "0x107CC0C", VA = "0x107CC0C")]
	public static void SetButtonSprite(GameObject widget, string strSpriteName)
	{
	}

	[Token(Token = "0x6003865")]
	[Address(RVA = "0x107CD18", Offset = "0x107CD18", VA = "0x107CD18")]
	public static void SetSpriteColor(GameObject widget, Color color)
	{
	}

	[Token(Token = "0x6003866")]
	[Address(RVA = "0x107CE4C", Offset = "0x107CE4C", VA = "0x107CE4C")]
	public static void SetChildLabelText(GameObject parent, string widgetName, string text)
	{
	}

	[Token(Token = "0x6003867")]
	[Address(RVA = "0x107D044", Offset = "0x107D044", VA = "0x107D044")]
	public static string GetChildLabelText(GameObject parent, string widgetName)
	{
		return null;
	}

	[Token(Token = "0x6003868")]
	[Address(RVA = "0x107D250", Offset = "0x107D250", VA = "0x107D250")]
	public static void SetChildButtonText(GameObject parent, string widgetName, string text)
	{
	}

	[Token(Token = "0x6003869")]
	[Address(RVA = "0x107D470", Offset = "0x107D470", VA = "0x107D470")]
	public static string GetChildButtonText(GameObject parent, string widgetName)
	{
		return null;
	}

	[Token(Token = "0x600386A")]
	[Address(RVA = "0x107D698", Offset = "0x107D698", VA = "0x107D698")]
	public static string GetChildInputText(GameObject parent, string widgetName)
	{
		return null;
	}

	[Token(Token = "0x600386B")]
	[Address(RVA = "0x107D8C0", Offset = "0x107D8C0", VA = "0x107D8C0")]
	public static void SetChildWidgetActive(GameObject parent, string widgetName, bool bActive)
	{
	}

	[Token(Token = "0x600386C")]
	[Address(RVA = "0x107DA98", Offset = "0x107DA98", VA = "0x107DA98")]
	public static void SetChildButtonEnabled(GameObject parent, string widgetName, bool bEnabled)
	{
	}

	[Token(Token = "0x600386D")]
	[Address(RVA = "0x107DCC8", Offset = "0x107DCC8", VA = "0x107DCC8")]
	public static void SetButtonEnabled(GameObject widget, bool bEnabled)
	{
	}

	[Token(Token = "0x600386E")]
	[Address(RVA = "0x107E1CC", Offset = "0x107E1CC", VA = "0x107E1CC")]
	public static void SetComboBoxChecked(GameObject widget, bool bChecked)
	{
	}

	[Token(Token = "0x600386F")]
	[Address(RVA = "0x107E27C", Offset = "0x107E27C", VA = "0x107E27C")]
	public static bool IsComboBoxChecked(GameObject widget)
	{
		return default(bool);
	}

	[Token(Token = "0x6003870")]
	[Address(RVA = "0x107E324", Offset = "0x107E324", VA = "0x107E324")]
	public static bool IsChildComboBoxChecked(GameObject parent, string widgetName)
	{
		return default(bool);
	}

	[Token(Token = "0x6003871")]
	[Address(RVA = "0x107E528", Offset = "0x107E528", VA = "0x107E528")]
	public static GameObject CreateFromPrefab(GameObject goParent, string strPrefabName, string strObjectName, bool bSetVisible = true)
	{
		return null;
	}

	[Token(Token = "0x6003872")]
	[Address(RVA = "0x107EAC8", Offset = "0x107EAC8", VA = "0x107EAC8")]
	public static void AttachChild(GameObject goChild)
	{
	}

	[Token(Token = "0x6003873")]
	[Address(RVA = "0x107ECB4", Offset = "0x107ECB4", VA = "0x107ECB4")]
	public static GameObject FindUICamera()
	{
		return null;
	}

	[Token(Token = "0x6003874")]
	[Address(RVA = "0x107EED8", Offset = "0x107EED8", VA = "0x107EED8")]
	public static GameObject FindUI3DCamera()
	{
		return null;
	}

	[Token(Token = "0x6003875")]
	[Address(RVA = "0x107F03C", Offset = "0x107F03C", VA = "0x107F03C")]
	public static GameObject FindUI3DCameraWithTag()
	{
		return null;
	}

	[Token(Token = "0x6003876")]
	[Address(RVA = "0x107F1A0", Offset = "0x107F1A0", VA = "0x107F1A0")]
	public static GameObject FindDirectionLightWithTag()
	{
		return null;
	}

	[Token(Token = "0x6003877")]
	[Address(RVA = "0x107F304", Offset = "0x107F304", VA = "0x107F304")]
	public static string GetWinLoseString(CSWinlose winLose)
	{
		return null;
	}

	[Token(Token = "0x6003878")]
	[Address(RVA = "0x107F42C", Offset = "0x107F42C", VA = "0x107F42C")]
	public static ItemGroupType GetItemGroupType(CSItemInfo itemInfo)
	{
		return default(ItemGroupType);
	}

	[Token(Token = "0x6003879")]
	[Address(RVA = "0x107F478", Offset = "0x107F478", VA = "0x107F478")]
	public static string GetContentChangeString(CSContent[] beforeRewards, CSContent[] afterRewards, string NJKey = "UI/UI_CWH_Duplicate_Skin_ArenaCoin_NJ")
	{
		return null;
	}

	[Token(Token = "0x600387A")]
	[Address(RVA = "0x107FA50", Offset = "0x107FA50", VA = "0x107FA50")]
	public static string GetContentName(CSContent content, bool includeCount = true, bool includeColor = true)
	{
		return null;
	}

	[Token(Token = "0x600387B")]
	[Address(RVA = "0x1080CFC", Offset = "0x1080CFC", VA = "0x1080CFC")]
	public static string GetContentTypeString(CSContentType type)
	{
		return null;
	}

	[Token(Token = "0x600387C")]
	[Address(RVA = "0x1080D24", Offset = "0x1080D24", VA = "0x1080D24")]
	public static string GetPriceString(IShopItem item, int defaultPrice)
	{
		return null;
	}

	[Token(Token = "0x600387D")]
	[Address(RVA = "0x1081410", Offset = "0x1081410", VA = "0x1081410")]
	public static string GetPriceString(int price)
	{
		return null;
	}

	[Token(Token = "0x600387E")]
	[Address(RVA = "0x1081300", Offset = "0x1081300", VA = "0x1081300")]
	public static string GetPriceStringWon(int price)
	{
		return null;
	}

	[Token(Token = "0x600387F")]
	[Address(RVA = "0x10814FC", Offset = "0x10814FC", VA = "0x10814FC")]
	public static string GetCountString(int count)
	{
		return null;
	}

	[Token(Token = "0x6003880")]
	[Address(RVA = "0x10815A4", Offset = "0x10815A4", VA = "0x10815A4")]
	public static string GetRankSpriteString(int rank)
	{
		return null;
	}

	[Token(Token = "0x6003881")]
	[Address(RVA = "0x1081684", Offset = "0x1081684", VA = "0x1081684")]
	public static string GetRankSprite1to6String(int rank)
	{
		return null;
	}

	[Token(Token = "0x6003882")]
	[Address(RVA = "0x1081844", Offset = "0x1081844", VA = "0x1081844")]
	public static string GetContentNameWithCount1(CSContent content)
	{
		return null;
	}

	[Token(Token = "0x6003883")]
	[Address(RVA = "0x10819C8", Offset = "0x10819C8", VA = "0x10819C8")]
	public static string GetContentNameWithCount(CSContent content)
	{
		return null;
	}

	[Token(Token = "0x6003884")]
	[Address(RVA = "0x1081B3C", Offset = "0x1081B3C", VA = "0x1081B3C")]
	public static string GetString(CSStageDifficulty type)
	{
		return null;
	}

	[Token(Token = "0x6003885")]
	[Address(RVA = "0x1081C88", Offset = "0x1081C88", VA = "0x1081C88")]
	public static Color RGBToColor(byte r, byte g, byte b)
	{
		return default(Color);
	}

	[Token(Token = "0x6003886")]
	[Address(RVA = "0x1081CE0", Offset = "0x1081CE0", VA = "0x1081CE0")]
	public static Color HexToColor(string hexString)
	{
		if (string.IsNullOrEmpty(hexString))
		{
			return Color.white;
		}
		string hex = hexString.Replace("0x", string.Empty).Replace("#", string.Empty);
		byte r = byte.MaxValue;
		byte g = byte.MaxValue;
		byte b = byte.MaxValue;
		byte a = byte.MaxValue;
		if (hex.Length > 1)
		{
			r = byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
		}
		if (hex.Length > 3)
		{
			g = byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
		}
		if (hex.Length > 5)
		{
			b = byte.Parse(hex.Substring(4, 2), NumberStyles.HexNumber);
		}
		if (hex.Length == 8)
		{
			a = byte.Parse(hex.Substring(6, 2), NumberStyles.HexNumber);
		}
		return new Color32(r, g, b, a);
	}

	[Token(Token = "0x6003887")]
	[Address(RVA = "0x1080BF4", Offset = "0x1080BF4", VA = "0x1080BF4")]
	public static string ColorToHexString(Color32 color)
	{
		return null;
	}

	[Token(Token = "0x6003888")]
	[Address(RVA = "0x1081FC0", Offset = "0x1081FC0", VA = "0x1081FC0")]
	public static string GetRarityString(ItemRarity rarity, bool useBracket = false)
	{
		return null;
	}

	[Token(Token = "0x6003889")]
	[Address(RVA = "0x1082114", Offset = "0x1082114", VA = "0x1082114")]
	public static string GetRarityWord(ItemRarity rarity)
	{
		return null;
	}

	[Token(Token = "0x600388A")]
	[Address(RVA = "0x1082264", Offset = "0x1082264", VA = "0x1082264")]
	public static string GetRewardTypeWord(ShowBoxRewardType rewardType)
	{
		return null;
	}

	[Token(Token = "0x600388B")]
	[Address(RVA = "0x1082578", Offset = "0x1082578", VA = "0x1082578")]
	public static string GetRewardTypeIconPath(ShowBoxRewardType rewardType)
	{
		return null;
	}

	[Token(Token = "0x600388C")]
	[Address(RVA = "0x1082620", Offset = "0x1082620", VA = "0x1082620")]
	public static string GetBBCodeText(Color color, string str)
	{
		return null;
	}

	[Token(Token = "0x600388D")]
	[Address(RVA = "0x108276C", Offset = "0x108276C", VA = "0x108276C")]
	public static string GetColorBBCodeToItemRarity(ItemRarity rarity)
	{
		return null;
	}

	[Token(Token = "0x600388E")]
	[Address(RVA = "0x10828A4", Offset = "0x10828A4", VA = "0x10828A4")]
	public static Color GetColor(CSStageDifficulty type)
	{
		return default(Color);
	}

	[Token(Token = "0x600388F")]
	[Address(RVA = "0x1080910", Offset = "0x1080910", VA = "0x1080910")]
	public static Color GetRarityColor(ItemRarity rarity)
	{
		return default(Color);
	}

	[Token(Token = "0x6003890")]
	[Address(RVA = "0x1082B30", Offset = "0x1082B30", VA = "0x1082B30")]
	public static Color GetRaritySpriteColor(ItemRarity rarity)
	{
		return default(Color);
	}

	[Token(Token = "0x6003891")]
	[Address(RVA = "0x1082E1C", Offset = "0x1082E1C", VA = "0x1082E1C")]
	public static Color GetTextDisableColor(bool disable)
	{
		return default(Color);
	}

	[Token(Token = "0x6003892")]
	[Address(RVA = "0x1082F30", Offset = "0x1082F30", VA = "0x1082F30")]
	public static string GetItemTypeString(CSItemInfo info)
	{
		return null;
	}

	[Token(Token = "0x6003893")]
	[Address(RVA = "0x108341C", Offset = "0x108341C", VA = "0x108341C")]
	public static bool IsGivedSkinTreasureForNJ(CSContent content)
	{
		return default(bool);
	}

	[Token(Token = "0x6003894")]
	[Address(RVA = "0x1083598", Offset = "0x1083598", VA = "0x1083598")]
	public static string GetRankTypeString(RankType rankType)
	{
		return null;
	}

	[Token(Token = "0x6003895")]
	[Address(RVA = "0x10836C0", Offset = "0x10836C0", VA = "0x10836C0")]
	public static string GeClanWarTypeString()
	{
		return null;
	}

	[Token(Token = "0x6003896")]
	[Address(RVA = "0x1083744", Offset = "0x1083744", VA = "0x1083744")]
	public static string GetGameModeString(XGameModeType mode)
	{
		return null;
	}

	[Token(Token = "0x6003897")]
	[Address(RVA = "0x10839E4", Offset = "0x10839E4", VA = "0x10839E4")]
	public static string GetFeatureTypeString(FeatureType type)
	{
		return null;
	}

	[Token(Token = "0x6003898")]
	[Address(RVA = "0x1083B68", Offset = "0x1083B68", VA = "0x1083B68")]
	public static string GetDaysString(CSDailyDungeonDays days)
	{
		return null;
	}

	[Token(Token = "0x6003899")]
	[Address(RVA = "0x108419C", Offset = "0x108419C", VA = "0x108419C")]
	public static string GetStageFullName(CSStageInfo info)
	{
		return null;
	}

	[Token(Token = "0x600389A")]
	[Address(RVA = "0x1084330", Offset = "0x1084330", VA = "0x1084330")]
	public static string GetStageName(CSStageInfo info)
	{
		return null;
	}

	[Token(Token = "0x600389B")]
	[Address(RVA = "0x10845D0", Offset = "0x10845D0", VA = "0x10845D0")]
	public static char ToChar(int index)
	{
		return default(char);
	}

	[Token(Token = "0x600389C")]
	[Address(RVA = "0x1084678", Offset = "0x1084678", VA = "0x1084678")]
	public static Color GetConstFontColor(string value)
	{
		return default(Color);
	}

	[Token(Token = "0x600389D")]
	[Address(RVA = "0x1084818", Offset = "0x1084818", VA = "0x1084818")]
	public static string ToErrorCodeNumberString(ApiReturnCode code)
	{
		return null;
	}

	[Token(Token = "0x600389E")]
	[Address(RVA = "0x108492C", Offset = "0x108492C", VA = "0x108492C")]
	public static string ToErrorCodeNumberString(ApiReturnCode code, string errMessage)
	{
		return null;
	}

	[Token(Token = "0x600389F")]
	[Address(RVA = "0x1084A44", Offset = "0x1084A44", VA = "0x1084A44")]
	public static bool TryResponseError(ApiReturnCode errno)
	{
		return default(bool);
	}

	[Token(Token = "0x60038A0")]
	[Address(RVA = "0x1084C5C", Offset = "0x1084C5C", VA = "0x1084C5C")]
	public static string GetErrorMessageByApiReturnCode(ApiReturnCode errno)
	{
		return null;
	}

	[Token(Token = "0x60038A1")]
	[Address(RVA = "0x1084E44", Offset = "0x1084E44", VA = "0x1084E44")]
	public static bool TryResponseError(NPErrorCode errno)
	{
		return default(bool);
	}

	[Token(Token = "0x60038A2")]
	[Address(RVA = "0x1085054", Offset = "0x1085054", VA = "0x1085054")]
	public static string GetErrorMessageByNPErrorCode(NPErrorCode errno)
	{
		return null;
	}

	[Token(Token = "0x60038A3")]
	[Address(RVA = "0x10851F8", Offset = "0x10851F8", VA = "0x10851F8")]
	public static string GetTimeString(TimeSpan time)
	{
		return null;
	}

	[Token(Token = "0x60038A4")]
	[Address(RVA = "0x10854B4", Offset = "0x10854B4", VA = "0x10854B4")]
	public static string GetTimeStringLong(TimeSpan time)
	{
		return null;
	}

	[Token(Token = "0x60038A5")]
	[Address(RVA = "0x1085764", Offset = "0x1085764", VA = "0x1085764")]
	public static string GetTimeStringDateTime(DateTime time)
	{
		return null;
	}

	[Token(Token = "0x60038A6")]
	[Address(RVA = "0x108593C", Offset = "0x108593C", VA = "0x108593C")]
	public static string GetTimeStringLongSymbol(TimeSpan time)
	{
		return null;
	}

	[Token(Token = "0x60038A7")]
	[Address(RVA = "0x1085BBC", Offset = "0x1085BBC", VA = "0x1085BBC")]
	public static string GetTimeStringShort(TimeSpan time)
	{
		return null;
	}

	[Token(Token = "0x60038A8")]
	[Address(RVA = "0x1085D90", Offset = "0x1085D90", VA = "0x1085D90")]
	public static string GetRewardTimeStringLong(TimeSpan time)
	{
		return null;
	}

	[Token(Token = "0x60038A9")]
	[Address(RVA = "0x1085F88", Offset = "0x1085F88", VA = "0x1085F88")]
	public static void SetNGUISound(bool val)
	{
	}

	[Token(Token = "0x60038AA")]
	[Address(RVA = "0x1086064", Offset = "0x1086064", VA = "0x1086064")]
	public static void RemainSeasonTimeValue(int m_lastTotalMin, DateTime nextSeasonTime, UIProgressBar prbRemainTime, UILabel lblRemainTime)
	{
	}

	[Token(Token = "0x60038AB")]
	[Address(RVA = "0x1086398", Offset = "0x1086398", VA = "0x1086398")]
	public static void BuildRankText(UILabel lblRank, int rank, bool useRankAddLocale = true, int defaultFontSize = 24, int topRankFontSize = 30)
	{
	}

	[Token(Token = "0x60038AC")]
	[Address(RVA = "0x10868F4", Offset = "0x10868F4", VA = "0x10868F4")]
	public static void DamageTypeIcon(SkillDamageTypes type, UILabel lblType, GameObject goSprMagic, GameObject goSprPhysic)
	{
	}

	[Token(Token = "0x60038AD")]
	[Address(RVA = "0x1086C4C", Offset = "0x1086C4C", VA = "0x1086C4C")]
	public static void SetClanGradeIcon(UI2DSprite sprite, ClanMemberGrade grade)
	{
	}

	[Token(Token = "0x60038AE")]
	[Address(RVA = "0x1086DBC", Offset = "0x1086DBC", VA = "0x1086DBC")]
	public static void SetCharacterIcon(UI2DSprite sprite, int characterId)
	{
	}

	[Token(Token = "0x60038AF")]
	[Address(RVA = "0x1086F80", Offset = "0x1086F80", VA = "0x1086F80")]
	public static void SetRelicIcon(UI2DSprite sprite, int id, int level)
	{
	}

	[Token(Token = "0x60038B0")]
	[Address(RVA = "0x1087158", Offset = "0x1087158", VA = "0x1087158")]
	public static void SetCharacterPortraitFrame(int titleId, UI2DSprite sprPortraitFrame)
	{
	}

	[Token(Token = "0x60038B1")]
	[Address(RVA = "0x10873B8", Offset = "0x10873B8", VA = "0x10873B8")]
	public static string GetProfileIconSprite(int profileIconId)
	{
		return null;
	}

	[Token(Token = "0x60038B2")]
	[Address(RVA = "0x1087460", Offset = "0x1087460", VA = "0x1087460")]
	public static string GetEmoticonSetIconSprite(int emoticonSetIconId)
	{
		return null;
	}

	[Token(Token = "0x60038B3")]
	[Address(RVA = "0x10875DC", Offset = "0x10875DC", VA = "0x10875DC")]
	public static string GetPackageItemIconSprite(int productID)
	{
		return null;
	}

	[Token(Token = "0x60038B4")]
	[Address(RVA = "0x108768C", Offset = "0x108768C", VA = "0x108768C")]
	public static void SetProfileIcon(UI2DSprite sprite, int profileIconId)
	{
	}

	[Token(Token = "0x60038B5")]
	[Address(RVA = "0x10877F8", Offset = "0x10877F8", VA = "0x10877F8")]
	public static void SetDeathProfileIcon(UI2DSprite sprite)
	{
	}

	[Token(Token = "0x60038B6")]
	[Address(RVA = "0x108792C", Offset = "0x108792C", VA = "0x108792C")]
	public static Sprite GetCharIconSprite(CSCharacterInfo characterInfo, [Optional] SkinInfo skinInfo)
	{
		return null;
	}

	[Token(Token = "0x60038B7")]
	[Address(RVA = "0x1087A5C", Offset = "0x1087A5C", VA = "0x1087A5C")]
	public static string GetCharUltIconSprite(CSCharacterInfo characterInfo, [Optional] SkinInfo skinInfo)
	{
		return null;
	}

	[Token(Token = "0x60038B8")]
	[Address(RVA = "0x1087A94", Offset = "0x1087A94", VA = "0x1087A94")]
	public static string GetCharTitle(CSCharacterInfo characterInfo, [Optional] SkinInfo skinInfo)
	{
		return null;
	}

	[Token(Token = "0x60038B9")]
	[Address(RVA = "0x1087ACC", Offset = "0x1087ACC", VA = "0x1087ACC")]
	public static void SetCharacterTitleAndName(UILabel label, string title, string name)
	{
	}

	[Token(Token = "0x60038BA")]
	[Address(RVA = "0x1087BBC", Offset = "0x1087BBC", VA = "0x1087BBC")]
	public static void InitGetCharacterDirection(Transform parentTransform, ref XPanel_CardDirectionRoot cardDirectionRoot)
	{
	}

	[Token(Token = "0x60038BB")]
	[Address(RVA = "0x1087EB8", Offset = "0x1087EB8", VA = "0x1087EB8")]
	public static void InitGetPetDirection(Transform parentTransform, ref XPanel_PetDirectionRoot petDirectionRoot)
	{
	}

	[Token(Token = "0x60038BC")]
	[Address(RVA = "0x10881B4", Offset = "0x10881B4", VA = "0x10881B4")]
	public static bool IsGameRecordsShowEnabled(XGameState gameState)
	{
		return default(bool);
	}

	[Token(Token = "0x60038BD")]
	[Address(RVA = "0x107BFDC", Offset = "0x107BFDC", VA = "0x107BFDC")]
	public static bool IsPauseMenuShowEnabled(XGameState gameState, bool bMultiplay, bool bAIMode, XGameModeStateType gameModeStateType, bool isTutorialProgress = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60038BE")]
	[Address(RVA = "0x1088298", Offset = "0x1088298", VA = "0x1088298")]
	public static void SetImageNumber(int number, XWiget_GridBuilder gridBuilder, ImageNumberColor color)
	{
	}

	[Token(Token = "0x60038BF")]
	[Address(RVA = "0x10885DC", Offset = "0x10885DC", VA = "0x10885DC")]
	public static void SetSoulStoneIcon(UI2DSprite sprite, CSShopItem item)
	{
	}

	[Token(Token = "0x60038C0")]
	[Address(RVA = "0x1088758", Offset = "0x1088758", VA = "0x1088758")]
	public static void SetSoulStoneOrSoulDustIcon(UI2DSprite sprite, CSItemInfo info)
	{
	}

	[Token(Token = "0x60038C1")]
	[Address(RVA = "0x10889C0", Offset = "0x10889C0", VA = "0x10889C0")]
	public static string GetShopSubCategoryString(ShopSubCategory subCategory)
	{
		return null;
	}

	[Token(Token = "0x60038C2")]
	[Address(RVA = "0x1088B0C", Offset = "0x1088B0C", VA = "0x1088B0C")]
	public static string MakeDayOfWeekString(RankType rankType, bool isContainBracket = true)
	{
		return null;
	}

	[Token(Token = "0x60038C3")]
	[Address(RVA = "0x1088E58", Offset = "0x1088E58", VA = "0x1088E58")]
	public static void TryGetMannerUI(CSProtoInfoManager_GameConst protoConst, int myMannerPoint, out Color color, out bool IsGoodUI)
	{
		IsGoodUI = default;
		color = default;
	}

	[Token(Token = "0x60038C4")]
	[Address(RVA = "0x1089158", Offset = "0x1089158", VA = "0x1089158")]
	public static bool CheckValidGameFlow(GameFlowTypes type)
	{
		return default(bool);
	}

	[Token(Token = "0x60038C5")]
	[Address(RVA = "0x1089238", Offset = "0x1089238", VA = "0x1089238")]
	public static string LocalizationUIString(string key, string defaultStr)
	{
		return null;
	}

	[Token(Token = "0x60038C6")]
	[Address(RVA = "0x1089304", Offset = "0x1089304", VA = "0x1089304")]
	public static bool TryGetCharacterInfo(CSContent content, out int charID, out int skinID)
	{
		charID = default;
		skinID = default;
		return default(bool);
	}
}
