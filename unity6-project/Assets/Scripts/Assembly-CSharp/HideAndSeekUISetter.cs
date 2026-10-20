using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D25")]
public class HideAndSeekUISetter : IRecordUISetter
{
	[Token(Token = "0x4004348")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4004349")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400434A")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<XPlayer> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000D18")]
	public int BuildCount
	{
		[Token(Token = "0x6006064")]
		[Address(RVA = "0x1F52370", Offset = "0x1F52370", VA = "0x1F52370", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006063")]
	[Address(RVA = "0x1F52368", Offset = "0x1F52368", VA = "0x1F52368")]
	public HideAndSeekUISetter()
	{
	}

	[Token(Token = "0x6006065")]
	[Address(RVA = "0x1F52378", Offset = "0x1F52378", VA = "0x1F52378", Slot = "5")]
	public void SetRecordTitle(UILabel lblTitle, XTeamEnum winningTeam)
	{
	}

	[Token(Token = "0x6006066")]
	[Address(RVA = "0x1F5237C", Offset = "0x1F5237C", VA = "0x1F5237C", Slot = "6")]
	public CSWinlose GetTopTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x6006067")]
	[Address(RVA = "0x1F52418", Offset = "0x1F52418", VA = "0x1F52418", Slot = "7")]
	public CSWinlose GetBottomTitleWinLose(XPlayerManager playerManager)
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x6006068")]
	[Address(RVA = "0x1F524B4", Offset = "0x1F524B4", VA = "0x1F524B4", Slot = "8")]
	public string GetTitleWinLose_Text(CSWinlose winlose)
	{
		return null;
	}

	[Token(Token = "0x6006069")]
	[Address(RVA = "0x1F52538", Offset = "0x1F52538", VA = "0x1F52538", Slot = "9")]
	public bool IsShowBottomTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x600606A")]
	[Address(RVA = "0x1F52540", Offset = "0x1F52540", VA = "0x1F52540", Slot = "10")]
	public List<XPlayer> GetRedTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600606B")]
	[Address(RVA = "0x1F526A8", Offset = "0x1F526A8", VA = "0x1F526A8", Slot = "11")]
	public List<XPlayer> GetBlueTeamList(List<XPlayer> playerList)
	{
		return null;
	}

	[Token(Token = "0x600606C")]
	[Address(RVA = "0x1F52810", Offset = "0x1F52810", VA = "0x1F52810", Slot = "12")]
	public bool IsTeamUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600606D")]
	[Address(RVA = "0x1F52818", Offset = "0x1F52818", VA = "0x1F52818", Slot = "13")]
	public Comparison<XPlayer> Sort()
	{
		return null;
	}

	[Token(Token = "0x600606E")]
	[Address(RVA = "0x1F52910", Offset = "0x1F52910", VA = "0x1F52910")]
	private static bool _003CGetRedTeamList_003Em__2B6(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x600606F")]
	[Address(RVA = "0x1F52950", Offset = "0x1F52950", VA = "0x1F52950")]
	private static bool _003CGetBlueTeamList_003Em__2B7(XPlayer x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006070")]
	[Address(RVA = "0x1F52998", Offset = "0x1F52998", VA = "0x1F52998")]
	private static int _003CSort_003Em__2B8(XPlayer x, XPlayer y)
	{
		return default(int);
	}
}
