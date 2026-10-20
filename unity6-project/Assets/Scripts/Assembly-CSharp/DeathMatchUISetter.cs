using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D23")]
public class DeathMatchUISetter : IRecordUISetter
{
	[Token(Token = "0x4004341")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4004342")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4004343")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<XPlayer> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000D16")]
	public int BuildCount
	{
		[Token(Token = "0x6006048")]
		[Address(RVA = "0x1E62EA0", Offset = "0x1E62EA0", VA = "0x1E62EA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006047")]
	[Address(RVA = "0x1E62E98", Offset = "0x1E62E98", VA = "0x1E62E98")]
	public DeathMatchUISetter()
	{
	}

	[Token(Token = "0x6006049")]
	[Address(RVA = "0x1E62EA8", Offset = "0x1E62EA8", VA = "0x1E62EA8", Slot = "10")]
	public List<XPlayer> GetRedTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600604A")]
	[Address(RVA = "0x1E63010", Offset = "0x1E63010", VA = "0x1E63010", Slot = "11")]
	public List<XPlayer> GetBlueTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600604B")]
	[Address(RVA = "0x1E63178", Offset = "0x1E63178", VA = "0x1E63178", Slot = "12")]
	public bool IsTeamUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600604C")]
	[Address(RVA = "0x1E63180", Offset = "0x1E63180", VA = "0x1E63180", Slot = "6")]
	public CSWinlose GetTopTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600604D")]
	[Address(RVA = "0x1E6321C", Offset = "0x1E6321C", VA = "0x1E6321C", Slot = "7")]
	public CSWinlose GetBottomTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600604E")]
	[Address(RVA = "0x1E632B8", Offset = "0x1E632B8", VA = "0x1E632B8", Slot = "5")]
	public void SetRecordTitle(UILabel lblTitle, XTeamEnum winningTeam)
	{
	}

	[Token(Token = "0x600604F")]
	[Address(RVA = "0x1E632BC", Offset = "0x1E632BC", VA = "0x1E632BC", Slot = "13")]
	public Comparison<XPlayer> Sort()
	{
		return null;
	}

	[Token(Token = "0x6006050")]
	[Address(RVA = "0x1E633B4", Offset = "0x1E633B4", VA = "0x1E633B4", Slot = "8")]
	public string GetTitleWinLose_Text(CSWinlose winlose)
	{
		return null;
	}

	[Token(Token = "0x6006051")]
	[Address(RVA = "0x1E63438", Offset = "0x1E63438", VA = "0x1E63438", Slot = "9")]
	public bool IsShowBottomTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x6006052")]
	[Address(RVA = "0x1E63440", Offset = "0x1E63440", VA = "0x1E63440")]
	private static bool _003CGetRedTeamList_003Em__2B0(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006053")]
	[Address(RVA = "0x1E63480", Offset = "0x1E63480", VA = "0x1E63480")]
	private static bool _003CGetBlueTeamList_003Em__2B1(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006054")]
	[Address(RVA = "0x1E634C8", Offset = "0x1E634C8", VA = "0x1E634C8")]
	private static int _003CSort_003Em__2B2(XPlayer x, XPlayer y)
	{
		return default(int);
	}
}
