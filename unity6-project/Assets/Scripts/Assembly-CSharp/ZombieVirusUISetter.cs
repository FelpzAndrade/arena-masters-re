using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D28")]
public class ZombieVirusUISetter : IRecordUISetter
{
	[Token(Token = "0x400434E")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400434F")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4004350")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<XPlayer> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000D1B")]
	public int BuildCount
	{
		[Token(Token = "0x600608A")]
		[Address(RVA = "0x23E36C0", Offset = "0x23E36C0", VA = "0x23E36C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006089")]
	[Address(RVA = "0x23E36B8", Offset = "0x23E36B8", VA = "0x23E36B8")]
	public ZombieVirusUISetter()
	{
	}

	[Token(Token = "0x600608B")]
	[Address(RVA = "0x23E36C8", Offset = "0x23E36C8", VA = "0x23E36C8", Slot = "10")]
	public List<XPlayer> GetRedTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600608C")]
	[Address(RVA = "0x23E3830", Offset = "0x23E3830", VA = "0x23E3830", Slot = "11")]
	public List<XPlayer> GetBlueTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600608D")]
	[Address(RVA = "0x23E3998", Offset = "0x23E3998", VA = "0x23E3998", Slot = "12")]
	public bool IsTeamUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600608E")]
	[Address(RVA = "0x23E39A0", Offset = "0x23E39A0", VA = "0x23E39A0", Slot = "6")]
	public CSWinlose GetTopTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600608F")]
	[Address(RVA = "0x23E3A3C", Offset = "0x23E3A3C", VA = "0x23E3A3C", Slot = "7")]
	public CSWinlose GetBottomTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x6006090")]
	[Address(RVA = "0x23E3A44", Offset = "0x23E3A44", VA = "0x23E3A44", Slot = "5")]
	public void SetRecordTitle(UILabel lblTitle, XTeamEnum winningTeam)
	{
	}

	[Token(Token = "0x6006091")]
	[Address(RVA = "0x23E3A48", Offset = "0x23E3A48", VA = "0x23E3A48", Slot = "13")]
	public Comparison<XPlayer> Sort()
	{
		return null;
	}

	[Token(Token = "0x6006092")]
	[Address(RVA = "0x23E3B40", Offset = "0x23E3B40", VA = "0x23E3B40", Slot = "8")]
	public string GetTitleWinLose_Text(CSWinlose winlose)
	{
		return null;
	}

	[Token(Token = "0x6006093")]
	[Address(RVA = "0x23E3C48", Offset = "0x23E3C48", VA = "0x23E3C48", Slot = "9")]
	public bool IsShowBottomTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x6006094")]
	[Address(RVA = "0x23E3C50", Offset = "0x23E3C50", VA = "0x23E3C50")]
	private static bool _003CGetRedTeamList_003Em__2BC(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006095")]
	[Address(RVA = "0x23E3C90", Offset = "0x23E3C90", VA = "0x23E3C90")]
	private static bool _003CGetBlueTeamList_003Em__2BD(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006096")]
	[Address(RVA = "0x23E3CD8", Offset = "0x23E3CD8", VA = "0x23E3CD8")]
	private static int _003CSort_003Em__2BE(XPlayer x, XPlayer y)
	{
		return default(int);
	}
}
