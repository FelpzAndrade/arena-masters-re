using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000DD3")]
public interface IClanPanel
{
	[Token(Token = "0x17000D5C")]
	XPanel_Clan.ClanTab FirstSelectTab
	{
		[Token(Token = "0x60065F9")]
		get;
	}

	[Token(Token = "0x17000D5D")]
	CompletedClanMember MyClanMemberInfo
	{
		[Token(Token = "0x60065FA")]
		get;
	}

	[Token(Token = "0x60065FB")]
	void Build(Netdata_Clan buildData, CompletedClanMember myClanMemberInfo, Action<Netdata_Clan> refreshClanMain);

	[Token(Token = "0x60065FC")]
	void OnClick_Search();

	[Token(Token = "0x60065FD")]
	void OnClick_Help();

	[Token(Token = "0x60065FE")]
	void OnClick_ListRefresh();

	[Token(Token = "0x60065FF")]
	bool OnClick_Tab(XPanel_Clan.ClanTab tabEnum, [Optional] Action tabSelectEndCallback);

	[Token(Token = "0x6006600")]
	List<XPanel_Clan.ClanTab> GetBuildTabEnums();

	[Token(Token = "0x6006601")]
	void Show();

	[Token(Token = "0x6006602")]
	void Hide();
}
