using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DD0")]
public class XPanel_Clan : XUIBasePanel, IClanListener
{
	[Token(Token = "0x2000DD1")]
	public enum ClanTab
	{
		[Token(Token = "0x40047F7")]
		Join = 0,
		[Token(Token = "0x40047F8")]
		JoinRequestList = 1,
		[Token(Token = "0x40047F9")]
		ClanMain = 2,
		[Token(Token = "0x40047FA")]
		ClanManage = 3
	}

	[Token(Token = "0x2000DD2")]
	private sealed class _003CBuildTab_003Ec__AnonStorey1C4
	{
		[Token(Token = "0x40047FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XWidget_ToggleTab tab;

		[Token(Token = "0x40047FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal ClanTab enumValue;

		[Token(Token = "0x40047FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_Clan _003C_003Ef__this;

		[Token(Token = "0x60065F7")]
		[Address(RVA = "0x16AEE48", Offset = "0x16AEE48", VA = "0x16AEE48")]
		public _003CBuildTab_003Ec__AnonStorey1C4()
		{
		}

		[Token(Token = "0x60065F8")]
		[Address(RVA = "0x16AFD74", Offset = "0x16AFD74", VA = "0x16AFD74")]
		internal void _003C_003Em__358()
		{
		}
	}

	[Token(Token = "0x40047EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string Path_ClanJoin;

	[Token(Token = "0x40047EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private readonly string Path_ClanMain;

	[Token(Token = "0x40047EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XWidget_ClanJoin _widgetClanJoin;

	[Token(Token = "0x40047ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private XWidget_ClanMain _clanMain;

	[Token(Token = "0x40047EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XWiget_GridBuilder m_tabBuilder;

	[Token(Token = "0x40047EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject goTutorialClanInfo;

	[Token(Token = "0x40047F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XTutorialObjContainer tutoContainer;

	[Token(Token = "0x40047F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private IClanPanel m_curShowPanel;

	[Token(Token = "0x40047F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<ClanTab, XWidget_ToggleTab> m_tab;

	[Token(Token = "0x40047F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private XWidget_ToggleTab selectedTab;

	[Token(Token = "0x40047F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string m_myNickName;

	[Token(Token = "0x40047F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private ClanTab SelectTabType__BackingField;

	[Token(Token = "0x17000D58")]
	public XWidget_ClanJoin m_widgetClanJoin
	{
		[Token(Token = "0x60065E1")]
		[Address(RVA = "0x16AD63C", Offset = "0x16AD63C", VA = "0x16AD63C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D59")]
	public XWidget_ClanMain m_clanMain
	{
		[Token(Token = "0x60065E2")]
		[Address(RVA = "0x16AD73C", Offset = "0x16AD73C", VA = "0x16AD73C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D5A")]
	public int TabCount
	{
		[Token(Token = "0x60065E3")]
		[Address(RVA = "0x16AD83C", Offset = "0x16AD83C", VA = "0x16AD83C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000D5B")]
	public ClanTab SelectTabType
	{
		[Token(Token = "0x60065E4")]
		[Address(RVA = "0x16AD8D4", Offset = "0x16AD8D4", VA = "0x16AD8D4")]
		get
		{
			return default(ClanTab);
		}
		[Token(Token = "0x60065E5")]
		[Address(RVA = "0x16AD8DC", Offset = "0x16AD8DC", VA = "0x16AD8DC")]
		private set
		{
		}
	}

	[Token(Token = "0x60065E0")]
	[Address(RVA = "0x16AD51C", Offset = "0x16AD51C", VA = "0x16AD51C")]
	public XPanel_Clan()
	{
	}

	[Token(Token = "0x60065E6")]
	[Address(RVA = "0x16AD8E4", Offset = "0x16AD8E4", VA = "0x16AD8E4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60065E7")]
	[Address(RVA = "0x16ADA28", Offset = "0x16ADA28", VA = "0x16ADA28")]
	private void GetMyClanAction(Netdata_Clan clanNetData)
	{
	}

	[Token(Token = "0x60065E8")]
	[Address(RVA = "0x16ADD00", Offset = "0x16ADD00", VA = "0x16ADD00")]
	private void OnClanKick()
	{
	}

	[Token(Token = "0x60065E9")]
	[Address(RVA = "0x16AE1E8", Offset = "0x16AE1E8", VA = "0x16AE1E8")]
	public void Show()
	{
	}

	[Token(Token = "0x60065EA")]
	[Address(RVA = "0x16AE2E0", Offset = "0x16AE2E0", VA = "0x16AE2E0", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60065EB")]
	[Address(RVA = "0x16AE3C0", Offset = "0x16AE3C0", VA = "0x16AE3C0")]
	public void Build(Netdata_Clan clanNetData, string myNickname, bool isRefresh = false)
	{
	}

	[Token(Token = "0x60065EC")]
	[Address(RVA = "0x16AE4E4", Offset = "0x16AE4E4", VA = "0x16AE4E4")]
	public void Build(Netdata_Clan myClanData, string myNickname, CompletedClanMember myClanMemberInfo, bool isRefresh)
	{
	}

	[Token(Token = "0x60065ED")]
	[Address(RVA = "0x16AEE04", Offset = "0x16AEE04", VA = "0x16AEE04")]
	private void RefreshClanPage(Netdata_Clan clan)
	{
	}

	[Token(Token = "0x60065EE")]
	[Address(RVA = "0x16AE9D4", Offset = "0x16AE9D4", VA = "0x16AE9D4")]
	private void BuildTab(Netdata_Clan clan, List<ClanTab> tabEnumList)
	{
	}

	[Token(Token = "0x60065EF")]
	[Address(RVA = "0x16AEE50", Offset = "0x16AEE50", VA = "0x16AEE50")]
	public void OnClick_Tab(XWidget_ToggleTab clickedTab, ClanTab clickedTabEnum, [Optional] Action tabSelectEndCallback)
	{
	}

	[Token(Token = "0x60065F0")]
	[Address(RVA = "0x16AF180", Offset = "0x16AF180", VA = "0x16AF180")]
	private void SetClanTutorialObject()
	{
	}

	[Token(Token = "0x60065F1")]
	[Address(RVA = "0x16AED14", Offset = "0x16AED14", VA = "0x16AED14")]
	private void SetActiveTutorialInfo(bool isShow)
	{
	}

	[Token(Token = "0x60065F2")]
	[Address(RVA = "0x16AF97C", Offset = "0x16AF97C", VA = "0x16AF97C")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x60065F3")]
	[Address(RVA = "0x16ADB48", Offset = "0x16ADB48", VA = "0x16ADB48", Slot = "19")]
	public void OnUpdateClanData(Netdata_Clan clanData)
	{
	}

	[Token(Token = "0x60065F4")]
	[Address(RVA = "0x16AFA54", Offset = "0x16AFA54", VA = "0x16AFA54")]
	public static TimeSpan GetClanRejoinCoolTime(long clanLeaveTimeTick)
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x60065F5")]
	[Address(RVA = "0x16AFD68", Offset = "0x16AFD68", VA = "0x16AFD68")]
	private void _003CBuild_003Em__357(Netdata_Clan newClanData)
	{
	}

	[Token(Token = "0x60065F6")]
	[Address(RVA = "0x16AFD6C", Offset = "0x16AFD6C", VA = "0x16AFD6C")]
	private void _003CSetClanTutorialObject_003Em__359()
	{
	}
}
