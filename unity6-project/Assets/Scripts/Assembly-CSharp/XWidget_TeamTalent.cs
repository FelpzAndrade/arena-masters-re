using System;
using System.Collections.Generic;
using CS;
using CS.Constant;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000FFB")]
public class XWidget_TeamTalent : XUIBaseWidget
{
	[Token(Token = "0x2000FFC")]
	private sealed class _003CRefreshAttackTalentItemList_003Ec__AnonStorey251
	{
		[Token(Token = "0x400556A")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400556B")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_TeamTalent _003C_003Ef__this;

		[Token(Token = "0x6007755")]
		[Address(RVA = "0x1B1F250", Offset = "0x1B1F250", VA = "0x1B1F250")]
		public _003CRefreshAttackTalentItemList_003Ec__AnonStorey251()
		{
		}

		[Token(Token = "0x6007756")]
		[Address(RVA = "0x1B2208C", Offset = "0x1B2208C", VA = "0x1B2208C")]
		internal bool _003C_003Em__4F6(TalentInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000FFD")]
	private sealed class _003CRefreshDefenseTalentItemList_003Ec__AnonStorey252
	{
		[Token(Token = "0x400556C")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400556D")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_TeamTalent _003C_003Ef__this;

		[Token(Token = "0x6007757")]
		[Address(RVA = "0x1B1F808", Offset = "0x1B1F808", VA = "0x1B1F808")]
		public _003CRefreshDefenseTalentItemList_003Ec__AnonStorey252()
		{
		}

		[Token(Token = "0x6007758")]
		[Address(RVA = "0x1B22150", Offset = "0x1B22150", VA = "0x1B22150")]
		internal bool _003C_003Em__4F7(TalentInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000FFE")]
	private sealed class _003CSetTalentTutorialObject_003Ec__AnonStorey253
	{
		[Token(Token = "0x400556E")]
		[FieldOffset(Offset = "0x8")]
		internal string attackItemName;

		[Token(Token = "0x400556F")]
		[FieldOffset(Offset = "0xC")]
		internal string defenseItemName;

		[Token(Token = "0x4005570")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_TeamTalent _003C_003Ef__this;

		[Token(Token = "0x6007759")]
		[Address(RVA = "0x1B21C80", Offset = "0x1B21C80", VA = "0x1B21C80")]
		public _003CSetTalentTutorialObject_003Ec__AnonStorey253()
		{
		}

		[Token(Token = "0x600775A")]
		[Address(RVA = "0x1B22214", Offset = "0x1B22214", VA = "0x1B22214")]
		internal void _003C_003Em__4F8()
		{
		}

		[Token(Token = "0x600775B")]
		[Address(RVA = "0x1B22450", Offset = "0x1B22450", VA = "0x1B22450")]
		internal void _003C_003Em__4F9()
		{
		}
	}

	[Token(Token = "0x4005545")]
	[FieldOffset(Offset = "0x1C")]
	private List<TalentInfo> attackGroup_list;

	[Token(Token = "0x4005546")]
	[FieldOffset(Offset = "0x20")]
	private List<TalentInfo> defenseGroup_list;

	[Token(Token = "0x4005547")]
	[FieldOffset(Offset = "0x24")]
	private List<int> attack_Line_number;

	[Token(Token = "0x4005548")]
	[FieldOffset(Offset = "0x28")]
	private List<int> defense_Line_number;

	[Token(Token = "0x4005549")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid attackGrid;

	[Token(Token = "0x400554A")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid defenseGrid;

	[Token(Token = "0x400554B")]
	[FieldOffset(Offset = "0x34")]
	public int talentGroupNumber;

	[Token(Token = "0x400554C")]
	[FieldOffset(Offset = "0x38")]
	private List<XWidget_TeamTalentGroup> attackGroup;

	[Token(Token = "0x400554D")]
	[FieldOffset(Offset = "0x3C")]
	private List<XWidget_TeamTalentGroup> defenseGroup;

	[Token(Token = "0x400554E")]
	[FieldOffset(Offset = "0x40")]
	private PageNumber ePageNumber;

	[Token(Token = "0x400554F")]
	[FieldOffset(Offset = "0x44")]
	private Action upgradeTalentAction;

	[Token(Token = "0x4005550")]
	[FieldOffset(Offset = "0x48")]
	public GameObject talentLevelUpEffect;

	[Token(Token = "0x4005551")]
	[FieldOffset(Offset = "0x4C")]
	public XWidget_Button btnResetPoint;

	[Token(Token = "0x4005552")]
	[FieldOffset(Offset = "0x50")]
	public XWidget_Button btnUpgrade;

	[Token(Token = "0x4005553")]
	[FieldOffset(Offset = "0x54")]
	public UILabel lblPageTP;

	[Token(Token = "0x4005554")]
	[FieldOffset(Offset = "0x58")]
	private TalentInfo m_selectItem;

	[Token(Token = "0x4005555")]
	[FieldOffset(Offset = "0x5C")]
	private bool runUpgrade;

	[Token(Token = "0x4005556")]
	[FieldOffset(Offset = "0x5D")]
	private bool runReset;

	[Token(Token = "0x4005557")]
	[FieldOffset(Offset = "0x5E")]
	private bool runBuyPage;

	[Token(Token = "0x4005558")]
	[FieldOffset(Offset = "0x60")]
	public UI2DSprite sprDetailIcon;

	[Token(Token = "0x4005559")]
	[FieldOffset(Offset = "0x64")]
	public UILabel lblDetailName;

	[Token(Token = "0x400555A")]
	[FieldOffset(Offset = "0x68")]
	public UILabel lblDetailTermsTitle;

	[Token(Token = "0x400555B")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel lblDetailTerms_TeamLevel;

	[Token(Token = "0x400555C")]
	[FieldOffset(Offset = "0x70")]
	public UILabel lblDetailTerms_LearnedTP;

	[Token(Token = "0x400555D")]
	[FieldOffset(Offset = "0x74")]
	public UILabel lblDetailNowLevelInfo;

	[Token(Token = "0x400555E")]
	[FieldOffset(Offset = "0x78")]
	public UILabel lblDetailNextLevelInfo;

	[Token(Token = "0x400555F")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel lblSkillDesc;

	[Token(Token = "0x4005560")]
	[FieldOffset(Offset = "0x80")]
	private GameObject selObject;

	[Token(Token = "0x4005561")]
	[FieldOffset(Offset = "0x84")]
	public string effectSoundKey;

	[Token(Token = "0x4005562")]
	[FieldOffset(Offset = "0x88")]
	private XUITeamTalentItem m_talentItem;

	[Token(Token = "0x4005563")]
	[FieldOffset(Offset = "0x8C")]
	private XMakeDescription skillDesc;

	[Token(Token = "0x4005564")]
	[FieldOffset(Offset = "0x90")]
	public UIGrid pageGroup;

	[Token(Token = "0x4005565")]
	[FieldOffset(Offset = "0x94")]
	private int pageCount;

	[Token(Token = "0x4005566")]
	[FieldOffset(Offset = "0x98")]
	private List<XUITeamTalentPageItem> pageItem;

	[Token(Token = "0x4005567")]
	[FieldOffset(Offset = "0x9C")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x4005568")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<TalentInfo> _003C_003Ef__am_0024cache23;

	[Token(Token = "0x4005569")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<TalentInfo> _003C_003Ef__am_0024cache24;

	[Token(Token = "0x17000EE8")]
	private string m_TalentItemPrefabPath
	{
		[Token(Token = "0x6007721")]
		[Address(RVA = "0x1B1BBA8", Offset = "0x1B1BBA8", VA = "0x1B1BBA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EE9")]
	private string m_PagePrefabPath
	{
		[Token(Token = "0x6007722")]
		[Address(RVA = "0x1B1BC20", Offset = "0x1B1BC20", VA = "0x1B1BC20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007720")]
	[Address(RVA = "0x1B1B9D0", Offset = "0x1B1B9D0", VA = "0x1B1B9D0")]
	public XWidget_TeamTalent()
	{
	}

	[Token(Token = "0x6007723")]
	[Address(RVA = "0x1B1BC98", Offset = "0x1B1BC98", VA = "0x1B1BC98")]
	private void SetActiveTalentLvUpEffect(bool bActive)
	{
	}

	[Token(Token = "0x6007724")]
	[Address(RVA = "0x1B1BD78", Offset = "0x1B1BD78", VA = "0x1B1BD78")]
	public void Build(Action upgradeTalent)
	{
	}

	[Token(Token = "0x6007725")]
	[Address(RVA = "0x1B1C804", Offset = "0x1B1C804", VA = "0x1B1C804", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6007726")]
	[Address(RVA = "0x1B1BFB4", Offset = "0x1B1BFB4", VA = "0x1B1BFB4")]
	private void BuildTalentLine()
	{
	}

	[Token(Token = "0x6007727")]
	[Address(RVA = "0x1B1C828", Offset = "0x1B1C828", VA = "0x1B1C828")]
	private void SetBaseList()
	{
	}

	[Token(Token = "0x6007728")]
	[Address(RVA = "0x1B1D7EC", Offset = "0x1B1D7EC", VA = "0x1B1D7EC")]
	public void OnClick_UpgradeStat()
	{
	}

	[Token(Token = "0x6007729")]
	[Address(RVA = "0x1B1DD48", Offset = "0x1B1DD48", VA = "0x1B1DD48")]
	private void ResetStat()
	{
	}

	[Token(Token = "0x600772A")]
	[Address(RVA = "0x1B1C534", Offset = "0x1B1C534", VA = "0x1B1C534")]
	private void SelectAttackFirstItem()
	{
	}

	[Token(Token = "0x600772B")]
	[Address(RVA = "0x1B1DFC8", Offset = "0x1B1DFC8", VA = "0x1B1DFC8")]
	public void OnClick_Page(int number)
	{
	}

	[Token(Token = "0x600772C")]
	[Address(RVA = "0x1B1E41C", Offset = "0x1B1E41C", VA = "0x1B1E41C")]
	private void BuyPage()
	{
	}

	[Token(Token = "0x600772D")]
	[Address(RVA = "0x1B1E5AC", Offset = "0x1B1E5AC", VA = "0x1B1E5AC")]
	private void TalentEventSound()
	{
	}

	[Token(Token = "0x600772E")]
	[Address(RVA = "0x1B1E6C8", Offset = "0x1B1E6C8", VA = "0x1B1E6C8")]
	public void OnClick_ResetStat()
	{
	}

	[Token(Token = "0x600772F")]
	[Address(RVA = "0x1B1E8E4", Offset = "0x1B1E8E4", VA = "0x1B1E8E4")]
	public void OnClick_ResetChecker()
	{
	}

	[Token(Token = "0x6007730")]
	[Address(RVA = "0x1B1E91C", Offset = "0x1B1E91C", VA = "0x1B1E91C")]
	private bool ResetChecker()
	{
		return default(bool);
	}

	[Token(Token = "0x6007731")]
	[Address(RVA = "0x1B1D17C", Offset = "0x1B1D17C", VA = "0x1B1D17C")]
	private void CreateTalentAttackGroupObject()
	{
	}

	[Token(Token = "0x6007732")]
	[Address(RVA = "0x1B1D4B4", Offset = "0x1B1D4B4", VA = "0x1B1D4B4")]
	private void CreateTalentDefenseGroupObject()
	{
	}

	[Token(Token = "0x6007733")]
	[Address(RVA = "0x1B1C054", Offset = "0x1B1C054", VA = "0x1B1C054")]
	private void RefreshAttackTalentItemList()
	{
	}

	[Token(Token = "0x6007734")]
	[Address(RVA = "0x1B1C2C4", Offset = "0x1B1C2C4", VA = "0x1B1C2C4")]
	private void RefreshDefenseTalentItemList()
	{
	}

	[Token(Token = "0x6007735")]
	[Address(RVA = "0x1B1CEDC", Offset = "0x1B1CEDC", VA = "0x1B1CEDC")]
	private void SetTalentLine()
	{
	}

	[Token(Token = "0x6007736")]
	[Address(RVA = "0x1B1F810", Offset = "0x1B1F810", VA = "0x1B1F810")]
	public void PlayEffect()
	{
	}

	[Token(Token = "0x6007737")]
	[Address(RVA = "0x1B1F8FC", Offset = "0x1B1F8FC", VA = "0x1B1F8FC")]
	public void RefreshTalentDetail(TalentInfo talentItem)
	{
	}

	[Token(Token = "0x6007738")]
	[Address(RVA = "0x1B20A00", Offset = "0x1B20A00", VA = "0x1B20A00")]
	public void SelectItemHighlight(XUITeamTalentItem item)
	{
	}

	[Token(Token = "0x6007739")]
	[Address(RVA = "0x1B1DB38", Offset = "0x1B1DB38", VA = "0x1B1DB38")]
	private int GetStatLevel(int id, string page)
	{
		return default(int);
	}

	[Token(Token = "0x600773A")]
	[Address(RVA = "0x1B20B4C", Offset = "0x1B20B4C", VA = "0x1B20B4C")]
	public void RefreshDetailPageTP(int pageNumber)
	{
	}

	[Token(Token = "0x600773B")]
	[Address(RVA = "0x1B200D4", Offset = "0x1B200D4", VA = "0x1B200D4")]
	public void RefreshDetailTerms(int page, TalentInfo talentInfo, int state_start_level)
	{
	}

	[Token(Token = "0x600773C")]
	[Address(RVA = "0x1B20E5C", Offset = "0x1B20E5C", VA = "0x1B20E5C")]
	private bool RefreshDetailTerms_TeamLevel(TalentInfo currentTalentInfo, TalentInfo nextTalentInfo, int nMyTeamLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x600773D")]
	[Address(RVA = "0x1B21160", Offset = "0x1B21160", VA = "0x1B21160")]
	private bool RefreshDetailTerms_LearnedTP(int page, TalentInfo currentTalentInfo, TalentInfo nextTalentInfo, XMyInfo myInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600773E")]
	[Address(RVA = "0x1B215D8", Offset = "0x1B215D8", VA = "0x1B215D8")]
	private void ShowTermsText(bool teamlevel, bool learnedTP)
	{
	}

	[Token(Token = "0x600773F")]
	[Address(RVA = "0x1B2167C", Offset = "0x1B2167C", VA = "0x1B2167C")]
	private int GetLearnedTP(TalentType talentType, string pageNumber, XMyInfo myInfo)
	{
		return default(int);
	}

	[Token(Token = "0x6007740")]
	[Address(RVA = "0x1B20448", Offset = "0x1B20448", VA = "0x1B20448")]
	private CSSkillInfo GetNextSkill(TalentInfo talentInfo, int level, string page)
	{
		return null;
	}

	[Token(Token = "0x6007741")]
	[Address(RVA = "0x1B2059C", Offset = "0x1B2059C", VA = "0x1B2059C")]
	private int GetMaxLevel(TalentInfo talentInfo, string pageNumber)
	{
		return default(int);
	}

	[Token(Token = "0x6007742")]
	[Address(RVA = "0x1B206C4", Offset = "0x1B206C4", VA = "0x1B206C4")]
	private void SetDetailSkillBuff(CSSkillInfo skillInfo, CSSkillInfo nextSkillInfo, int level, int maxLevel)
	{
	}

	[Token(Token = "0x6007743")]
	[Address(RVA = "0x1B20990", Offset = "0x1B20990", VA = "0x1B20990")]
	public void SetButtonDisable(int page, bool m_terms)
	{
	}

	[Token(Token = "0x6007744")]
	[Address(RVA = "0x1B2179C", Offset = "0x1B2179C", VA = "0x1B2179C")]
	private bool GetPageTotalStat(string pageNumber)
	{
		return default(bool);
	}

	[Token(Token = "0x6007745")]
	[Address(RVA = "0x1B1CB04", Offset = "0x1B1CB04", VA = "0x1B1CB04")]
	public void InitPageItemDetail()
	{
	}

	[Token(Token = "0x6007746")]
	[Address(RVA = "0x1B1E2B8", Offset = "0x1B1E2B8", VA = "0x1B1E2B8")]
	public void RefreshPage(int selectNumber)
	{
	}

	[Token(Token = "0x6007747")]
	[Address(RVA = "0x1B1F148", Offset = "0x1B1F148", VA = "0x1B1F148")]
	public void RefreshAllPageIcon(int selectNumber)
	{
	}

	[Token(Token = "0x6007748")]
	[Address(RVA = "0x1B1FECC", Offset = "0x1B1FECC", VA = "0x1B1FECC")]
	private CSSkillInfo GetTalentSkill(int skillID)
	{
		return null;
	}

	[Token(Token = "0x6007749")]
	[Address(RVA = "0x1B1ECBC", Offset = "0x1B1ECBC", VA = "0x1B1ECBC")]
	private GameObject SetGameObejct(GameObject obj, UIGrid grid)
	{
		return null;
	}

	[Token(Token = "0x600774A")]
	[Address(RVA = "0x1B1E2EC", Offset = "0x1B1E2EC", VA = "0x1B1E2EC")]
	private int GetGameConstValue(key key)
	{
		return default(int);
	}

	[Token(Token = "0x600774B")]
	[Address(RVA = "0x1B218F4", Offset = "0x1B218F4", VA = "0x1B218F4")]
	private string GetPageName(int number)
	{
		return null;
	}

	[Token(Token = "0x600774C")]
	[Address(RVA = "0x1B21918", Offset = "0x1B21918", VA = "0x1B21918")]
	public XUITeamTalentItem GetTalentItem(int id)
	{
		return null;
	}

	[Token(Token = "0x600774D")]
	[Address(RVA = "0x1B1DC18", Offset = "0x1B1DC18", VA = "0x1B1DC18")]
	private bool IsPossibleToUpgrade(string page, TalentInfo selectItem, int level)
	{
		return default(bool);
	}

	[Token(Token = "0x600774E")]
	[Address(RVA = "0x1B1C66C", Offset = "0x1B1C66C", VA = "0x1B1C66C")]
	private void SetTalentTutorialObject()
	{
	}

	[Token(Token = "0x600774F")]
	[Address(RVA = "0x1B21C88", Offset = "0x1B21C88", VA = "0x1B21C88")]
	private static bool _003CSetBaseList_003Em__4F0(TalentInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6007750")]
	[Address(RVA = "0x1B21CB4", Offset = "0x1B21CB4", VA = "0x1B21CB4")]
	private static bool _003CSetBaseList_003Em__4F1(TalentInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6007751")]
	[Address(RVA = "0x1B21CE4", Offset = "0x1B21CE4", VA = "0x1B21CE4")]
	private void _003COnClick_UpgradeStat_003Em__4F2(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6007752")]
	[Address(RVA = "0x1B21E9C", Offset = "0x1B21E9C", VA = "0x1B21E9C")]
	private void _003CResetStat_003Em__4F3(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6007753")]
	[Address(RVA = "0x1B21EF4", Offset = "0x1B21EF4", VA = "0x1B21EF4")]
	private void _003COnClick_Page_003Em__4F4()
	{
	}

	[Token(Token = "0x6007754")]
	[Address(RVA = "0x1B2205C", Offset = "0x1B2205C", VA = "0x1B2205C")]
	private void _003CBuyPage_003Em__4F5(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
