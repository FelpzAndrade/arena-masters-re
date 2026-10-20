using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D22")]
public class CooperationUISetter : IRecordUISetter
{
	[Token(Token = "0x400433E")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400433F")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4004340")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<XPlayer> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000D15")]
	public int BuildCount
	{
		[Token(Token = "0x600603A")]
		[Address(RVA = "0x20D2D6C", Offset = "0x20D2D6C", VA = "0x20D2D6C", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006039")]
	[Address(RVA = "0x20D2D64", Offset = "0x20D2D64", VA = "0x20D2D64")]
	public CooperationUISetter()
	{
	}

	[Token(Token = "0x600603B")]
	[Address(RVA = "0x20D2D74", Offset = "0x20D2D74", VA = "0x20D2D74", Slot = "5")]
	public void SetRecordTitle(UILabel lblTitle, XTeamEnum winningTeam)
	{
	}

	[Token(Token = "0x600603C")]
	[Address(RVA = "0x20D2D78", Offset = "0x20D2D78", VA = "0x20D2D78", Slot = "6")]
	public CSWinlose GetTopTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600603D")]
	[Address(RVA = "0x20D2E14", Offset = "0x20D2E14", VA = "0x20D2E14", Slot = "7")]
	public CSWinlose GetBottomTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600603E")]
	[Address(RVA = "0x20D2EB0", Offset = "0x20D2EB0", VA = "0x20D2EB0", Slot = "8")]
	public string GetTitleWinLose_Text(CSWinlose winlose)
	{
		return null;
	}

	[Token(Token = "0x600603F")]
	[Address(RVA = "0x20D2F34", Offset = "0x20D2F34", VA = "0x20D2F34", Slot = "9")]
	public bool IsShowBottomTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x6006040")]
	[Address(RVA = "0x20D2F3C", Offset = "0x20D2F3C", VA = "0x20D2F3C", Slot = "10")]
	public List<XPlayer> GetRedTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x6006041")]
	[Address(RVA = "0x20D30A4", Offset = "0x20D30A4", VA = "0x20D30A4", Slot = "11")]
	public List<XPlayer> GetBlueTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x6006042")]
	[Address(RVA = "0x20D320C", Offset = "0x20D320C", VA = "0x20D320C", Slot = "12")]
	public bool IsTeamUI()
	{
		return default(bool);
	}

	[Token(Token = "0x6006043")]
	[Address(RVA = "0x20D3214", Offset = "0x20D3214", VA = "0x20D3214", Slot = "13")]
	public Comparison<XPlayer> Sort()
	{
		return null;
	}

	[Token(Token = "0x6006044")]
	[Address(RVA = "0x20D330C", Offset = "0x20D330C", VA = "0x20D330C")]
	private static bool _003CGetRedTeamList_003Em__2AD(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006045")]
	[Address(RVA = "0x20D334C", Offset = "0x20D334C", VA = "0x20D334C")]
	private static bool _003CGetBlueTeamList_003Em__2AE(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006046")]
	[Address(RVA = "0x20D3394", Offset = "0x20D3394", VA = "0x20D3394")]
	private static int _003CSort_003Em__2AF(XPlayer x, XPlayer y)
	{
		return default(int);
	}
}
