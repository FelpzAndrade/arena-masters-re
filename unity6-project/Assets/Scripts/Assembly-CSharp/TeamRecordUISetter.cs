using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D27")]
public class TeamRecordUISetter : IRecordUISetter
{
	[Token(Token = "0x400434B")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400434C")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400434D")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<XPlayer> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000D1A")]
	public int BuildCount
	{
		[Token(Token = "0x600607C")]
		[Address(RVA = "0x1D4BC04", Offset = "0x1D4BC04", VA = "0x1D4BC04", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600607B")]
	[Address(RVA = "0x1D4BBFC", Offset = "0x1D4BBFC", VA = "0x1D4BBFC")]
	public TeamRecordUISetter()
	{
	}

	[Token(Token = "0x600607D")]
	[Address(RVA = "0x1D4BC0C", Offset = "0x1D4BC0C", VA = "0x1D4BC0C", Slot = "10")]
	public List<XPlayer> GetRedTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600607E")]
	[Address(RVA = "0x1D4BDAC", Offset = "0x1D4BDAC", VA = "0x1D4BDAC", Slot = "11")]
	public List<XPlayer> GetBlueTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600607F")]
	[Address(RVA = "0x1D4BF4C", Offset = "0x1D4BF4C", VA = "0x1D4BF4C", Slot = "12")]
	public bool IsTeamUI()
	{
		return default(bool);
	}

	[Token(Token = "0x6006080")]
	[Address(RVA = "0x1D4BF54", Offset = "0x1D4BF54", VA = "0x1D4BF54", Slot = "6")]
	public CSWinlose GetTopTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x6006081")]
	[Address(RVA = "0x1D4BFF0", Offset = "0x1D4BFF0", VA = "0x1D4BFF0", Slot = "7")]
	public CSWinlose GetBottomTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x6006082")]
	[Address(RVA = "0x1D4C08C", Offset = "0x1D4C08C", VA = "0x1D4C08C", Slot = "5")]
	public void SetRecordTitle(UILabel lblTitle, XTeamEnum winningTeam)
	{
	}

	[Token(Token = "0x6006083")]
	[Address(RVA = "0x1D4C090", Offset = "0x1D4C090", VA = "0x1D4C090", Slot = "13")]
	public Comparison<XPlayer> Sort()
	{
		return null;
	}

	[Token(Token = "0x6006084")]
	[Address(RVA = "0x1D4C188", Offset = "0x1D4C188", VA = "0x1D4C188", Slot = "8")]
	public string GetTitleWinLose_Text(CSWinlose winlose)
	{
		return null;
	}

	[Token(Token = "0x6006085")]
	[Address(RVA = "0x1D4C2B0", Offset = "0x1D4C2B0", VA = "0x1D4C2B0", Slot = "9")]
	public bool IsShowBottomTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x6006086")]
	[Address(RVA = "0x1D4C2B8", Offset = "0x1D4C2B8", VA = "0x1D4C2B8")]
	private static bool _003CGetRedTeamList_003Em__2B9(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006087")]
	[Address(RVA = "0x1D4C2F8", Offset = "0x1D4C2F8", VA = "0x1D4C2F8")]
	private static bool _003CGetBlueTeamList_003Em__2BA(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006088")]
	[Address(RVA = "0x1D4C340", Offset = "0x1D4C340", VA = "0x1D4C340")]
	private static int _003CSort_003Em__2BB(XPlayer x, XPlayer y)
	{
		return default(int);
	}
}
