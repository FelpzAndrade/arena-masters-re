using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D26")]
public interface IRecordUISetter
{
	[Token(Token = "0x17000D19")]
	int BuildCount
	{
		[Token(Token = "0x6006071")]
		get;
	}

	[Token(Token = "0x6006072")]
	void SetRecordTitle(UILabel lblTitle, XTeamEnum winningTeam);

	[Token(Token = "0x6006073")]
	CSWinlose GetTopTitleWinLose(XPlayerManager playerManager);

	[Token(Token = "0x6006074")]
	CSWinlose GetBottomTitleWinLose(XPlayerManager playerManager);

	[Token(Token = "0x6006075")]
	string GetTitleWinLose_Text(CSWinlose winlose);

	[Token(Token = "0x6006076")]
	bool IsShowBottomTitle();

	[Token(Token = "0x6006077")]
	List<XPlayer> GetRedTeamList(List<XPlayer> playerList);

	[Token(Token = "0x6006078")]
	List<XPlayer> GetBlueTeamList(List<XPlayer> playerList);

	[Token(Token = "0x6006079")]
	bool IsTeamUI();

	[Token(Token = "0x600607A")]
	Comparison<XPlayer> Sort();
}
