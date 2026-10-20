using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FD5")]
public class XWidget_QuickMatchOptionPopup : XUIBaseWidget
{
	[Token(Token = "0x4005435")]
	private const int m_totlaModeCount = 6;

	[Token(Token = "0x4005436")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<string, QuickMatchThemeInfo> m_themeMapDictionary;

	[Token(Token = "0x4005437")]
	[FieldOffset(Offset = "0x20")]
	private List<int> m_teamDeathMatchSectorID_List;

	[Token(Token = "0x4005438")]
	[FieldOffset(Offset = "0x24")]
	private bool m_isCheckTeamDeathMatch;

	[Token(Token = "0x4005439")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ComboBoxTeamDeathMatch;

	[Token(Token = "0x400543A")]
	[FieldOffset(Offset = "0x2C")]
	private List<int> m_capturePointASectorID_List;

	[Token(Token = "0x400543B")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isCheckCapturePointA;

	[Token(Token = "0x400543C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ComboBoxCapturePointA;

	[Token(Token = "0x400543D")]
	[FieldOffset(Offset = "0x38")]
	private List<int> m_zombieSectorID_List;

	[Token(Token = "0x400543E")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_isCheckZombie;

	[Token(Token = "0x400543F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ComboBoxZombie;

	[Token(Token = "0x4005440")]
	[FieldOffset(Offset = "0x44")]
	private List<int> m_deathMatchSectorID_List;

	[Token(Token = "0x4005441")]
	[FieldOffset(Offset = "0x48")]
	private bool m_isCheckDeathMatch;

	[Token(Token = "0x4005442")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ComboBoxDeathMatch;

	[Token(Token = "0x4005443")]
	[FieldOffset(Offset = "0x50")]
	private List<int> m_policeVsThiefSectorID_List;

	[Token(Token = "0x4005444")]
	[FieldOffset(Offset = "0x54")]
	private bool m_isCheckPoliceVsThief;

	[Token(Token = "0x4005445")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ComboBoxPoliceVsThief;

	[Token(Token = "0x4005446")]
	[FieldOffset(Offset = "0x5C")]
	private List<int> m_hideAndSeekSectorID_List;

	[Token(Token = "0x4005447")]
	[FieldOffset(Offset = "0x60")]
	private bool m_isCheckHideAndSeek;

	[Token(Token = "0x4005448")]
	[FieldOffset(Offset = "0x64")]
	public GameObject ComboBoxHideAndSeek;

	[Token(Token = "0x4005449")]
	[FieldOffset(Offset = "0x68")]
	private bool m_isSelectedTeamDeathMatch;

	[Token(Token = "0x400544A")]
	[FieldOffset(Offset = "0x69")]
	private bool m_isSelectedCapturePointA;

	[Token(Token = "0x400544B")]
	[FieldOffset(Offset = "0x6A")]
	private bool m_isSelectedZombie;

	[Token(Token = "0x400544C")]
	[FieldOffset(Offset = "0x6B")]
	private bool m_isSelectedDeathMatch;

	[Token(Token = "0x400544D")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_isSelectedPoliceVsThief;

	[Token(Token = "0x400544E")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_isSelectedHideAndSeek;

	[Token(Token = "0x400544F")]
	[FieldOffset(Offset = "0x70")]
	private List<XGameModeType> m_gameModeTypeIgnores;

	[Token(Token = "0x4005450")]
	[FieldOffset(Offset = "0x74")]
	public XUIQuickMatchMapList quickMatchMapList;

	[Token(Token = "0x4005451")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_mapThemeIncludes;

	[Token(Token = "0x4005452")]
	[FieldOffset(Offset = "0x7C")]
	private List<int> m_mapThemeIgnores;

	[Token(Token = "0x60075F7")]
	[Address(RVA = "0x132C478", Offset = "0x132C478", VA = "0x132C478")]
	public XWidget_QuickMatchOptionPopup()
	{
	}

	[Token(Token = "0x60075F8")]
	[Address(RVA = "0x13298C8", Offset = "0x13298C8", VA = "0x13298C8")]
	public void Show()
	{
	}

	[Token(Token = "0x60075F9")]
	[Address(RVA = "0x132C7EC", Offset = "0x132C7EC", VA = "0x132C7EC")]
	private void BuildGameModeComboBox(XGameModeType gameModeType, GameObject goComboBox, out bool bActive)
	{
		bActive = default;
	}

	[Token(Token = "0x60075FA")]
	[Address(RVA = "0x132CBBC", Offset = "0x132CBBC", VA = "0x132CBBC")]
	private void SetButtonEnabled(GameObject widget, bool bEnabled)
	{
	}

	[Token(Token = "0x60075FB")]
	[Address(RVA = "0x132CA74", Offset = "0x132CA74", VA = "0x132CA74")]
	private bool CheckGameModeEnabled(XGameModeType gameModeType)
	{
		return default(bool);
	}

	[Token(Token = "0x60075FC")]
	[Address(RVA = "0x132C634", Offset = "0x132C634", VA = "0x132C634")]
	public void Build()
	{
	}

	[Token(Token = "0x60075FD")]
	[Address(RVA = "0x132E864", Offset = "0x132E864", VA = "0x132E864")]
	private void DeleteSectorId_TeamLevelLimit(List<int> sectorIdIndexList)
	{
	}

	[Token(Token = "0x60075FE")]
	[Address(RVA = "0x132CCBC", Offset = "0x132CCBC", VA = "0x132CCBC")]
	private void ModeSectorInfoCaching()
	{
	}

	[Token(Token = "0x60075FF")]
	[Address(RVA = "0x132E22C", Offset = "0x132E22C", VA = "0x132E22C")]
	private void RefrashMapList(bool isFirst = false)
	{
	}

	[Token(Token = "0x6007600")]
	[Address(RVA = "0x132ED60", Offset = "0x132ED60", VA = "0x132ED60")]
	private bool IsActiveQuickMatchThemeInfo(List<int> _quickMatchThemeInfoSectorId_List)
	{
		return default(bool);
	}

	[Token(Token = "0x6007601")]
	[Address(RVA = "0x132EBDC", Offset = "0x132EBDC", VA = "0x132EBDC")]
	private void MakeIndlueMapTheme(List<int> list)
	{
	}

	[Token(Token = "0x6007602")]
	[Address(RVA = "0x132EEB8", Offset = "0x132EEB8", VA = "0x132EEB8")]
	private void SaveLocalData()
	{
	}

	[Token(Token = "0x6007603")]
	[Address(RVA = "0x132F2D4", Offset = "0x132F2D4", VA = "0x132F2D4")]
	public void OnClick_TeamDeathMatch()
	{
	}

	[Token(Token = "0x6007604")]
	[Address(RVA = "0x132F2E8", Offset = "0x132F2E8", VA = "0x132F2E8")]
	public void OnClick_CapturePointA()
	{
	}

	[Token(Token = "0x6007605")]
	[Address(RVA = "0x132F2FC", Offset = "0x132F2FC", VA = "0x132F2FC")]
	public void OnClick_DeathMatch()
	{
	}

	[Token(Token = "0x6007606")]
	[Address(RVA = "0x132F310", Offset = "0x132F310", VA = "0x132F310")]
	public void OnClick_Zombie()
	{
	}

	[Token(Token = "0x6007607")]
	[Address(RVA = "0x132F324", Offset = "0x132F324", VA = "0x132F324")]
	public void OnClick_PoliceVsThief()
	{
	}

	[Token(Token = "0x6007608")]
	[Address(RVA = "0x132F338", Offset = "0x132F338", VA = "0x132F338")]
	public void OnClick_HideAndSeek()
	{
	}

	[Token(Token = "0x6007609")]
	[Address(RVA = "0x132F34C", Offset = "0x132F34C", VA = "0x132F34C")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x600760A")]
	[Address(RVA = "0x132F394", Offset = "0x132F394", VA = "0x132F394")]
	public void OnClick_Cancel()
	{
	}

	[Token(Token = "0x600760B")]
	[Address(RVA = "0x132FA24", Offset = "0x132FA24", VA = "0x132FA24")]
	private void OnClickMapItem(List<int> sectorID_List, bool isSelect)
	{
	}
}
