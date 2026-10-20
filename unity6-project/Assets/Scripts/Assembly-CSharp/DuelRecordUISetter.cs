using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D24")]
public class DuelRecordUISetter : IRecordUISetter
{
	[Token(Token = "0x4004344")]
	[FieldOffset(Offset = "0x8")]
	private readonly int ROUND;

	[Token(Token = "0x4004345")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4004346")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4004347")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<XPlayer> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x17000D17")]
	public int BuildCount
	{
		[Token(Token = "0x6006056")]
		[Address(RVA = "0x1E67880", Offset = "0x1E67880", VA = "0x1E67880", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006055")]
	[Address(RVA = "0x1E67870", Offset = "0x1E67870", VA = "0x1E67870")]
	public DuelRecordUISetter()
	{
	}

	[Token(Token = "0x6006057")]
	[Address(RVA = "0x1E67888", Offset = "0x1E67888", VA = "0x1E67888", Slot = "10")]
	public List<XPlayer> GetRedTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x6006058")]
	[Address(RVA = "0x1E679F0", Offset = "0x1E679F0", VA = "0x1E679F0", Slot = "11")]
	public List<XPlayer> GetBlueTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x6006059")]
	[Address(RVA = "0x1E67B58", Offset = "0x1E67B58", VA = "0x1E67B58", Slot = "12")]
	public bool IsTeamUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600605A")]
	[Address(RVA = "0x1E67B60", Offset = "0x1E67B60", VA = "0x1E67B60", Slot = "6")]
	public CSWinlose GetTopTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600605B")]
	[Address(RVA = "0x1E67BFC", Offset = "0x1E67BFC", VA = "0x1E67BFC", Slot = "7")]
	public CSWinlose GetBottomTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600605C")]
	[Address(RVA = "0x1E67C98", Offset = "0x1E67C98", VA = "0x1E67C98", Slot = "5")]
	public void SetRecordTitle(UILabel lblTitle, XTeamEnum winningTeam)
	{
	}

	[Token(Token = "0x600605D")]
	[Address(RVA = "0x1E67C9C", Offset = "0x1E67C9C", VA = "0x1E67C9C", Slot = "13")]
	public Comparison<XPlayer> Sort()
	{
		return null;
	}

	[Token(Token = "0x600605E")]
	[Address(RVA = "0x1E67D94", Offset = "0x1E67D94", VA = "0x1E67D94", Slot = "8")]
	public string GetTitleWinLose_Text(CSWinlose winlose)
	{
		return null;
	}

	[Token(Token = "0x600605F")]
	[Address(RVA = "0x1E67EBC", Offset = "0x1E67EBC", VA = "0x1E67EBC", Slot = "9")]
	public bool IsShowBottomTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x6006060")]
	[Address(RVA = "0x1E67EC4", Offset = "0x1E67EC4", VA = "0x1E67EC4")]
	private static bool _003CGetRedTeamList_003Em__2B3(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006061")]
	[Address(RVA = "0x1E67F04", Offset = "0x1E67F04", VA = "0x1E67F04")]
	private static bool _003CGetBlueTeamList_003Em__2B4(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006062")]
	[Address(RVA = "0x1E67F4C", Offset = "0x1E67F4C", VA = "0x1E67F4C")]
	private static int _003CSort_003Em__2B5(XPlayer x, XPlayer y)
	{
		return default(int);
	}
}
