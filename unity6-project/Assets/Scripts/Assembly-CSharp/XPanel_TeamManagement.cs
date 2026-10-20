using CS.Constant;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E32")]
public class XPanel_TeamManagement : XUIBasePanel
{
	[Token(Token = "0x2000E33")]
	public enum ManagementTabType
	{
		[Token(Token = "0x4004AB3")]
		Profile = 0,
		[Token(Token = "0x4004AB4")]
		Talent = 1,
		[Token(Token = "0x4004AB5")]
		Relic = 2,
		[Token(Token = "0x4004AB6")]
		BattleRecord = 3,
		[Token(Token = "0x4004AB7")]
		Title = 4,
		[Token(Token = "0x4004AB8")]
		VIP = 5,
		[Token(Token = "0x4004AB9")]
		Emoticon = 6
	}

	[Token(Token = "0x4004A9B")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_NewBadge profileNewBadge;

	[Token(Token = "0x4004A9C")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_NewBadge potentialityNewBadge;

	[Token(Token = "0x4004A9D")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_NewBadge relicNewBadge;

	[Token(Token = "0x4004A9E")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_NewBadge titleNewBadge;

	[Token(Token = "0x4004A9F")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_NewBadge recordNewBadge;

	[Token(Token = "0x4004AA0")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_NewBadge emoticonNewBadge;

	[Token(Token = "0x4004AA1")]
	[FieldOffset(Offset = "0x28")]
	private readonly string Path_BattleRecord;

	[Token(Token = "0x4004AA2")]
	[FieldOffset(Offset = "0x2C")]
	private readonly string Path_TeamProfile;

	[Token(Token = "0x4004AA3")]
	[FieldOffset(Offset = "0x30")]
	private readonly string Path_TeamRelic;

	[Token(Token = "0x4004AA4")]
	[FieldOffset(Offset = "0x34")]
	private readonly string Path_TeamTalent;

	[Token(Token = "0x4004AA5")]
	[FieldOffset(Offset = "0x38")]
	private readonly string Path_TeamTitle;

	[Token(Token = "0x4004AA6")]
	[FieldOffset(Offset = "0x3C")]
	private readonly string Path_TeamEmoticon;

	[Token(Token = "0x4004AA7")]
	[FieldOffset(Offset = "0x40")]
	private XWidget_BattleRecord _widgetBattleRecord;

	[Token(Token = "0x4004AA8")]
	[FieldOffset(Offset = "0x44")]
	private XWidget_Title _widgetTitle;

	[Token(Token = "0x4004AA9")]
	[FieldOffset(Offset = "0x48")]
	private XWidget_TeamProfile _widgetProfile;

	[Token(Token = "0x4004AAA")]
	[FieldOffset(Offset = "0x4C")]
	private XWidget_Relic _widgetRelic;

	[Token(Token = "0x4004AAB")]
	[FieldOffset(Offset = "0x50")]
	private XWidget_TeamTalent _widgetTalent;

	[Token(Token = "0x4004AAC")]
	[FieldOffset(Offset = "0x54")]
	private XWidget_TeamEmoticon _widgetEmoticon;

	[Token(Token = "0x4004AAD")]
	[FieldOffset(Offset = "0x58")]
	private XUIBaseWidget m_currentTabUI;

	[Token(Token = "0x4004AAE")]
	[FieldOffset(Offset = "0x5C")]
	public XWidget_ToggleTab[] tabs;

	[Token(Token = "0x4004AAF")]
	[FieldOffset(Offset = "0x60")]
	private ManagementTabType tab_type;

	[Token(Token = "0x4004AB0")]
	[FieldOffset(Offset = "0x64")]
	public GameObject goTalentLock;

	[Token(Token = "0x4004AB1")]
	[FieldOffset(Offset = "0x68")]
	public GameObject goRelicLock;

	[Token(Token = "0x17000D9D")]
	private XWidget_BattleRecord widgetBattleRecord
	{
		[Token(Token = "0x600697C")]
		[Address(RVA = "0xACE8A8", Offset = "0xACE8A8", VA = "0xACE8A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D9E")]
	private XWidget_TeamProfile widgetProfile
	{
		[Token(Token = "0x600697D")]
		[Address(RVA = "0xACE9A8", Offset = "0xACE9A8", VA = "0xACE9A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D9F")]
	private XWidget_Relic widgetRelic
	{
		[Token(Token = "0x600697E")]
		[Address(RVA = "0xACEAA8", Offset = "0xACEAA8", VA = "0xACEAA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA0")]
	private XWidget_TeamTalent widgetTalent
	{
		[Token(Token = "0x600697F")]
		[Address(RVA = "0xACEBA8", Offset = "0xACEBA8", VA = "0xACEBA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA1")]
	private XWidget_Title widgetTitle
	{
		[Token(Token = "0x6006980")]
		[Address(RVA = "0xACECA8", Offset = "0xACECA8", VA = "0xACECA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA2")]
	private XWidget_TeamEmoticon widgetEmoticon
	{
		[Token(Token = "0x6006981")]
		[Address(RVA = "0xACEDA8", Offset = "0xACEDA8", VA = "0xACEDA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA3")]
	public ManagementTabType TabType
	{
		[Token(Token = "0x6006982")]
		[Address(RVA = "0xACEEA8", Offset = "0xACEEA8", VA = "0xACEEA8")]
		get
		{
			return default(ManagementTabType);
		}
	}

	[Token(Token = "0x600697B")]
	[Address(RVA = "0xACE7B8", Offset = "0xACE7B8", VA = "0xACE7B8")]
	public XPanel_TeamManagement()
	{
	}

	[Token(Token = "0x6006983")]
	[Address(RVA = "0xACEEB0", Offset = "0xACEEB0", VA = "0xACEEB0")]
	public void Build()
	{
	}

	[Token(Token = "0x6006984")]
	[Address(RVA = "0xACF430", Offset = "0xACF430", VA = "0xACF430")]
	public void Show()
	{
	}

	[Token(Token = "0x6006985")]
	[Address(RVA = "0xACF5D8", Offset = "0xACF5D8", VA = "0xACF5D8")]
	private void RefeshTab()
	{
	}

	[Token(Token = "0x6006986")]
	[Address(RVA = "0xACF5E0", Offset = "0xACF5E0", VA = "0xACF5E0")]
	private void RefreshAllBadge()
	{
	}

	[Token(Token = "0x6006987")]
	[Address(RVA = "0xACF61C", Offset = "0xACF61C", VA = "0xACF61C")]
	public void RefreshProfileBadge()
	{
	}

	[Token(Token = "0x6006988")]
	[Address(RVA = "0xACF648", Offset = "0xACF648", VA = "0xACF648")]
	public void RefreshPotentialityBadge()
	{
	}

	[Token(Token = "0x6006989")]
	[Address(RVA = "0xACF674", Offset = "0xACF674", VA = "0xACF674")]
	public void RefreshRelicBadge()
	{
	}

	[Token(Token = "0x600698A")]
	[Address(RVA = "0xACF70C", Offset = "0xACF70C", VA = "0xACF70C")]
	public void RefreshTitleBadge()
	{
	}

	[Token(Token = "0x600698B")]
	[Address(RVA = "0xACF738", Offset = "0xACF738", VA = "0xACF738")]
	public void RefreshRecordBadge()
	{
	}

	[Token(Token = "0x600698C")]
	[Address(RVA = "0xACF764", Offset = "0xACF764", VA = "0xACF764")]
	public void RefreshEmoticonBadge()
	{
	}

	[Token(Token = "0x600698D")]
	[Address(RVA = "0xACEF10", Offset = "0xACEF10", VA = "0xACEF10")]
	public void OnClickTabs(int type)
	{
	}

	[Token(Token = "0x600698E")]
	[Address(RVA = "0xACF790", Offset = "0xACF790", VA = "0xACF790")]
	public void OnClick_TabProfile()
	{
	}

	[Token(Token = "0x600698F")]
	[Address(RVA = "0xACF7A4", Offset = "0xACF7A4", VA = "0xACF7A4")]
	public void OnClick_TabTalent()
	{
	}

	[Token(Token = "0x6006990")]
	[Address(RVA = "0xACFBB4", Offset = "0xACFBB4", VA = "0xACFBB4")]
	public void OnClick_TabRelic()
	{
	}

	[Token(Token = "0x6006991")]
	[Address(RVA = "0xACFDA0", Offset = "0xACFDA0", VA = "0xACFDA0")]
	public void OnClick_TabRecord()
	{
	}

	[Token(Token = "0x6006992")]
	[Address(RVA = "0xACFDB4", Offset = "0xACFDB4", VA = "0xACFDB4")]
	public void OnClick_TabTitle()
	{
	}

	[Token(Token = "0x6006993")]
	[Address(RVA = "0xACFE10", Offset = "0xACFE10", VA = "0xACFE10")]
	public void OnClick_TabEmoticon()
	{
	}

	[Token(Token = "0x6006994")]
	[Address(RVA = "0xACF39C", Offset = "0xACF39C", VA = "0xACF39C")]
	public void BuildTabLock()
	{
	}

	[Token(Token = "0x6006995")]
	[Address(RVA = "0xACF990", Offset = "0xACF990", VA = "0xACF990")]
	private bool LevelCheck(key key)
	{
		return default(bool);
	}

	[Token(Token = "0x6006996")]
	[Address(RVA = "0xACFA88", Offset = "0xACFA88", VA = "0xACFA88")]
	private int GetConstValue(key key)
	{
		return default(int);
	}

	[Token(Token = "0x6006997")]
	[Address(RVA = "0xACEF64", Offset = "0xACEF64", VA = "0xACEF64")]
	public void BuildTabType(ManagementTabType tabs)
	{
	}

	[Token(Token = "0x6006998")]
	[Address(RVA = "0xACFE24", Offset = "0xACFE24", VA = "0xACFE24")]
	private void WidgetHide()
	{
	}

	[Token(Token = "0x6006999")]
	[Address(RVA = "0xACFF28", Offset = "0xACFF28", VA = "0xACFF28")]
	public void OnClick_Help()
	{
	}
}
