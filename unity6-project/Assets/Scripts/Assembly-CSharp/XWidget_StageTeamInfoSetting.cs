using CS;
using CS.Constant;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FEE")]
public class XWidget_StageTeamInfoSetting : MonoBehaviour
{
	[Token(Token = "0x40054F4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PREFAB_PATH;

	[Token(Token = "0x40054F5")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder relicBuilder;

	[Token(Token = "0x40054F6")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder talentBuilder;

	[Token(Token = "0x40054F7")]
	[FieldOffset(Offset = "0x14")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x40054F8")]
	[FieldOffset(Offset = "0x18")]
	private XUITeamTalentPageItem[] talentPages;

	[Token(Token = "0x40054F9")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_SelectRelic[] relickQuickSlots;

	[Token(Token = "0x40054FA")]
	[FieldOffset(Offset = "0x20")]
	private XGameModeType m_gameMode;

	[Token(Token = "0x40054FB")]
	[FieldOffset(Offset = "0x24")]
	private bool m_RandomMode;

	[Token(Token = "0x60076B7")]
	[Address(RVA = "0x1B0C3BC", Offset = "0x1B0C3BC", VA = "0x1B0C3BC")]
	public XWidget_StageTeamInfoSetting()
	{
	}

	[Token(Token = "0x60076B9")]
	[Address(RVA = "0x1B0C454", Offset = "0x1B0C454", VA = "0x1B0C454")]
	public static XWidget_StageTeamInfoSetting Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60076BA")]
	[Address(RVA = "0x1B0C5F4", Offset = "0x1B0C5F4", VA = "0x1B0C5F4")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60076BB")]
	[Address(RVA = "0x1B0C610", Offset = "0x1B0C610", VA = "0x1B0C610")]
	public void Build(XGameModeType gameMode, bool bRandomMode)
	{
	}

	[Token(Token = "0x60076BC")]
	[Address(RVA = "0x1B0C634", Offset = "0x1B0C634", VA = "0x1B0C634")]
	private void BuildTalent()
	{
	}

	[Token(Token = "0x60076BD")]
	[Address(RVA = "0x1B0C9E4", Offset = "0x1B0C9E4", VA = "0x1B0C9E4")]
	public void BuildRelic()
	{
	}

	[Token(Token = "0x60076BE")]
	[Address(RVA = "0x1B0D058", Offset = "0x1B0D058", VA = "0x1B0D058")]
	private bool CheckExitRelic(int checkRelicID)
	{
		return default(bool);
	}

	[Token(Token = "0x60076BF")]
	[Address(RVA = "0x1B0D1C8", Offset = "0x1B0D1C8", VA = "0x1B0D1C8")]
	private void RefreshTalentPage(int selectPage)
	{
	}

	[Token(Token = "0x60076C0")]
	[Address(RVA = "0x1B0D23C", Offset = "0x1B0D23C", VA = "0x1B0D23C")]
	private void RefreshRelicSkill(int relicID)
	{
	}

	[Token(Token = "0x60076C1")]
	[Address(RVA = "0x1B0D240", Offset = "0x1B0D240", VA = "0x1B0D240")]
	private void ChangeTeamTalentPage(int selectPage)
	{
	}

	[Token(Token = "0x60076C2")]
	[Address(RVA = "0x1B0D488", Offset = "0x1B0D488", VA = "0x1B0D488")]
	private void ChangeRelicSkill(int relicIndex)
	{
	}

	[Token(Token = "0x60076C3")]
	[Address(RVA = "0x1B0D60C", Offset = "0x1B0D60C", VA = "0x1B0D60C")]
	private CharPartyId GetCurPartyId()
	{
		return default(CharPartyId);
	}

	[Token(Token = "0x60076C4")]
	[Address(RVA = "0x1B0CD14", Offset = "0x1B0CD14", VA = "0x1B0CD14")]
	private XPartyLocalData GetPartyLocalData()
	{
		return null;
	}

	[Token(Token = "0x60076C5")]
	[Address(RVA = "0x1B0CE1C", Offset = "0x1B0CE1C", VA = "0x1B0CE1C")]
	private void SelectTalentPage(int selectTalentPage)
	{
	}

	[Token(Token = "0x60076C6")]
	[Address(RVA = "0x1B0CF28", Offset = "0x1B0CF28", VA = "0x1B0CF28")]
	private void SetRelicTutorialObject()
	{
	}

	[Token(Token = "0x60076C7")]
	[Address(RVA = "0x1B0D6E0", Offset = "0x1B0D6E0", VA = "0x1B0D6E0")]
	public void ButtonOnclickGoToRelicSetting()
	{
	}

	[Token(Token = "0x60076C8")]
	[Address(RVA = "0x1B0DA94", Offset = "0x1B0DA94", VA = "0x1B0DA94")]
	public void ButtonOnclickGoToTalentSetting()
	{
	}

	[Token(Token = "0x60076C9")]
	[Address(RVA = "0x1B0D7C4", Offset = "0x1B0D7C4", VA = "0x1B0D7C4")]
	private bool UnlockCheckAndNoti(key key)
	{
		return default(bool);
	}
}
