using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000B42")]
public sealed class CSSectorInfo
{
	[Token(Token = "0x40037C3")]
	public const int MAX_SPECIAL_ITEM = 10;

	[Token(Token = "0x40037C4")]
	[FieldOffset(Offset = "0x8")]
	public int nSectorID;

	[Token(Token = "0x40037C5")]
	[FieldOffset(Offset = "0xC")]
	public int nLevel;

	[Token(Token = "0x40037C6")]
	[FieldOffset(Offset = "0x10")]
	public string strName;

	[Token(Token = "0x40037C7")]
	[FieldOffset(Offset = "0x14")]
	public CSSectorType nType;

	[Token(Token = "0x40037C8")]
	[FieldOffset(Offset = "0x18")]
	public string contentsTag;

	[Token(Token = "0x40037C9")]
	[FieldOffset(Offset = "0x1C")]
	public string strSceneName;

	[Token(Token = "0x40037CA")]
	[FieldOffset(Offset = "0x20")]
	public string strVignettingTexture;

	[Token(Token = "0x40037CB")]
	[FieldOffset(Offset = "0x24")]
	public string strPrefab;

	[Token(Token = "0x40037CC")]
	[FieldOffset(Offset = "0x28")]
	public string strLoadingImage;

	[Token(Token = "0x40037CD")]
	[FieldOffset(Offset = "0x2C")]
	public string strBGM;

	[Token(Token = "0x40037CE")]
	[FieldOffset(Offset = "0x30")]
	public string strEffectBGM;

	[Token(Token = "0x40037CF")]
	[FieldOffset(Offset = "0x34")]
	public int effectBGMDelay;

	[Token(Token = "0x40037D0")]
	[FieldOffset(Offset = "0x38")]
	public string strMapTheme;

	[Token(Token = "0x40037D1")]
	[FieldOffset(Offset = "0x3C")]
	public string strThemeThumbnailImage;

	[Token(Token = "0x40037D2")]
	[FieldOffset(Offset = "0x40")]
	public string strItemIDs;

	[Token(Token = "0x40037D3")]
	[FieldOffset(Offset = "0x44")]
	public List<List<int>> ItemGroupList;

	[Token(Token = "0x40037D4")]
	[FieldOffset(Offset = "0x48")]
	public string strMaxItems;

	[Token(Token = "0x40037D5")]
	[FieldOffset(Offset = "0x4C")]
	public List<int> nMaxItemSpawnsList;

	[Token(Token = "0x40037D6")]
	[FieldOffset(Offset = "0x50")]
	public string strItemPoints;

	[Token(Token = "0x40037D7")]
	[FieldOffset(Offset = "0x54")]
	public List<List<int>> ItemPointGroupList;

	[Token(Token = "0x40037D8")]
	[FieldOffset(Offset = "0x58")]
	public string strItemsSpawnTimes;

	[Token(Token = "0x40037D9")]
	[FieldOffset(Offset = "0x5C")]
	public List<float> fItemsSpawnTimeList;

	[Token(Token = "0x40037DA")]
	[FieldOffset(Offset = "0x60")]
	public string strSItemID_1;

	[Token(Token = "0x40037DB")]
	[FieldOffset(Offset = "0x64")]
	public List<int> SItemList_1;

	[Token(Token = "0x40037DC")]
	[FieldOffset(Offset = "0x68")]
	public int nSItemPoint_1;

	[Token(Token = "0x40037DD")]
	[FieldOffset(Offset = "0x6C")]
	public float fSItemSpawnTime_1;

	[Token(Token = "0x40037DE")]
	[FieldOffset(Offset = "0x70")]
	public string strSItemID_2;

	[Token(Token = "0x40037DF")]
	[FieldOffset(Offset = "0x74")]
	public List<int> SItemList_2;

	[Token(Token = "0x40037E0")]
	[FieldOffset(Offset = "0x78")]
	public int nSItemPoint_2;

	[Token(Token = "0x40037E1")]
	[FieldOffset(Offset = "0x7C")]
	public float fSItemSpawnTime_2;

	[Token(Token = "0x40037E2")]
	[FieldOffset(Offset = "0x80")]
	public string strSItemID_3;

	[Token(Token = "0x40037E3")]
	[FieldOffset(Offset = "0x84")]
	public List<int> SItemList_3;

	[Token(Token = "0x40037E4")]
	[FieldOffset(Offset = "0x88")]
	public int nSItemPoint_3;

	[Token(Token = "0x40037E5")]
	[FieldOffset(Offset = "0x8C")]
	public float fSItemSpawnTime_3;

	[Token(Token = "0x40037E6")]
	[FieldOffset(Offset = "0x90")]
	public string strSItemID_4;

	[Token(Token = "0x40037E7")]
	[FieldOffset(Offset = "0x94")]
	public List<int> SItemList_4;

	[Token(Token = "0x40037E8")]
	[FieldOffset(Offset = "0x98")]
	public int nSItemPoint_4;

	[Token(Token = "0x40037E9")]
	[FieldOffset(Offset = "0x9C")]
	public float fSItemSpawnTime_4;

	[Token(Token = "0x40037EA")]
	[FieldOffset(Offset = "0xA0")]
	public string strSItemID_5;

	[Token(Token = "0x40037EB")]
	[FieldOffset(Offset = "0xA4")]
	public List<int> SItemList_5;

	[Token(Token = "0x40037EC")]
	[FieldOffset(Offset = "0xA8")]
	public int nSItemPoint_5;

	[Token(Token = "0x40037ED")]
	[FieldOffset(Offset = "0xAC")]
	public float fSItemSpawnTime_5;

	[Token(Token = "0x40037EE")]
	[FieldOffset(Offset = "0xB0")]
	public string strSItemID_6;

	[Token(Token = "0x40037EF")]
	[FieldOffset(Offset = "0xB4")]
	public List<int> SItemList_6;

	[Token(Token = "0x40037F0")]
	[FieldOffset(Offset = "0xB8")]
	public int nSItemPoint_6;

	[Token(Token = "0x40037F1")]
	[FieldOffset(Offset = "0xBC")]
	public float fSItemSpawnTime_6;

	[Token(Token = "0x40037F2")]
	[FieldOffset(Offset = "0xC0")]
	public string strSItemID_7;

	[Token(Token = "0x40037F3")]
	[FieldOffset(Offset = "0xC4")]
	public List<int> SItemList_7;

	[Token(Token = "0x40037F4")]
	[FieldOffset(Offset = "0xC8")]
	public int nSItemPoint_7;

	[Token(Token = "0x40037F5")]
	[FieldOffset(Offset = "0xCC")]
	public float fSItemSpawnTime_7;

	[Token(Token = "0x40037F6")]
	[FieldOffset(Offset = "0xD0")]
	public string strSItemID_8;

	[Token(Token = "0x40037F7")]
	[FieldOffset(Offset = "0xD4")]
	public List<int> SItemList_8;

	[Token(Token = "0x40037F8")]
	[FieldOffset(Offset = "0xD8")]
	public int nSItemPoint_8;

	[Token(Token = "0x40037F9")]
	[FieldOffset(Offset = "0xDC")]
	public float fSItemSpawnTime_8;

	[Token(Token = "0x40037FA")]
	[FieldOffset(Offset = "0xE0")]
	public string strSItemID_9;

	[Token(Token = "0x40037FB")]
	[FieldOffset(Offset = "0xE4")]
	public List<int> SItemList_9;

	[Token(Token = "0x40037FC")]
	[FieldOffset(Offset = "0xE8")]
	public int nSItemPoint_9;

	[Token(Token = "0x40037FD")]
	[FieldOffset(Offset = "0xEC")]
	public float fSItemSpawnTime_9;

	[Token(Token = "0x40037FE")]
	[FieldOffset(Offset = "0xF0")]
	public string strSItemID_10;

	[Token(Token = "0x40037FF")]
	[FieldOffset(Offset = "0xF4")]
	public List<int> SItemList_10;

	[Token(Token = "0x4003800")]
	[FieldOffset(Offset = "0xF8")]
	public int nSItemPoint_10;

	[Token(Token = "0x4003801")]
	[FieldOffset(Offset = "0xFC")]
	public float fSItemSpawnTime_10;

	[Token(Token = "0x4003802")]
	[FieldOffset(Offset = "0x100")]
	[XmlIgnore]
	public string localizeKeyName;

	[Token(Token = "0x4003803")]
	[FieldOffset(Offset = "0x104")]
	public float fMinY;

	[Token(Token = "0x4003804")]
	[FieldOffset(Offset = "0x108")]
	public float fCameraMinY;

	[Token(Token = "0x4003805")]
	[FieldOffset(Offset = "0x10C")]
	public string strPointObjectSpawns;

	[Token(Token = "0x4003806")]
	[FieldOffset(Offset = "0x110")]
	public HashSet<int> PointObjectSpawnIndexSet;

	[Token(Token = "0x4003807")]
	[FieldOffset(Offset = "0x114")]
	public int nFirstPointObjectID;

	[Token(Token = "0x4003808")]
	[FieldOffset(Offset = "0x118")]
	public int nPointObjectID_NA;

	[Token(Token = "0x4003809")]
	[FieldOffset(Offset = "0x11C")]
	public int nPointObjectID_Red;

	[Token(Token = "0x400380A")]
	[FieldOffset(Offset = "0x120")]
	public int nPointObjectID_Blue;

	[Token(Token = "0x400380B")]
	[FieldOffset(Offset = "0x124")]
	public string strMiniMapImagePath;

	[Token(Token = "0x6005244")]
	[Address(RVA = "0x21F64C4", Offset = "0x21F64C4", VA = "0x21F64C4")]
	public CSSectorInfo()
	{
	}

	[Token(Token = "0x6005245")]
	[Address(RVA = "0x21F6760", Offset = "0x21F6760", VA = "0x21F6760")]
	public List<int> GetSpecialItemList(int nIndex)
	{
		return null;
	}

	[Token(Token = "0x6005246")]
	[Address(RVA = "0x21F67F8", Offset = "0x21F67F8", VA = "0x21F67F8")]
	public int GetSpecialItemPoint(int nIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6005247")]
	[Address(RVA = "0x21F6890", Offset = "0x21F6890", VA = "0x21F6890")]
	public float GetSpecialItemSpawnTime(int nIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6005248")]
	[Address(RVA = "0x21F6338", Offset = "0x21F6338", VA = "0x21F6338")]
	public bool IsEnterPossible(int teamLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6005249")]
	[Address(RVA = "0x21F6930", Offset = "0x21F6930", VA = "0x21F6930")]
	public bool IsPvp()
	{
		return default(bool);
	}

	[Token(Token = "0x600524A")]
	[Address(RVA = "0x21F5C14", Offset = "0x21F5C14", VA = "0x21F5C14")]
	public bool Cooking()
	{
		return default(bool);
	}

	[Token(Token = "0x600524B")]
	[Address(RVA = "0x21F7924", Offset = "0x21F7924", VA = "0x21F7924")]
	private void Cooking_Theme()
	{
	}

	[Token(Token = "0x600524C")]
	[Address(RVA = "0x21F6940", Offset = "0x21F6940", VA = "0x21F6940")]
	private void Cooking_Items()
	{
	}

	[Token(Token = "0x600524D")]
	[Address(RVA = "0x21F7A88", Offset = "0x21F7A88", VA = "0x21F7A88")]
	private string[] DivideGroupString(string str)
	{
		return null;
	}

	[Token(Token = "0x600524E")]
	[Address(RVA = "0x21F77D8", Offset = "0x21F77D8", VA = "0x21F77D8")]
	private void Cooking_PointObjectSpawns()
	{
	}

	[Token(Token = "0x600524F")]
	[Address(RVA = "0x21F6EF4", Offset = "0x21F6EF4", VA = "0x21F6EF4")]
	private void Cooking_SpecialItems()
	{
	}
}
