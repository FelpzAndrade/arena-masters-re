using CS;
using Il2CppDummyDll;

[Token(Token = "0x200047B")]
public class XMyNewbieBuffChecker
{
	[Token(Token = "0x4001695")]
	[FieldOffset(Offset = "0x8")]
	private int m_MyTeamLevel;

	[Token(Token = "0x4001696")]
	[FieldOffset(Offset = "0xC")]
	private int m_NewbieLevel;

	[Token(Token = "0x4001697")]
	[FieldOffset(Offset = "0x10")]
	private int m_VeryVeryNewbieLevel;

	[Token(Token = "0x4001698")]
	[FieldOffset(Offset = "0x14")]
	private int m_NewbieLosingStreakCount;

	[Token(Token = "0x60025FF")]
	[Address(RVA = "0xB732A4", Offset = "0xB732A4", VA = "0xB732A4")]
	public XMyNewbieBuffChecker()
	{
	}

	[Token(Token = "0x6002600")]
	[Address(RVA = "0xB75DF8", Offset = "0xB75DF8", VA = "0xB75DF8")]
	public void Init(int myTeamLevel, int newbieLevel, int veryVeryNewbieLevel, int newbieLosingStreakCount)
	{
	}

	[Token(Token = "0x6002601")]
	[Address(RVA = "0xB75250", Offset = "0xB75250", VA = "0xB75250")]
	public bool CheckTeamDeathMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002602")]
	[Address(RVA = "0xBA5970", Offset = "0xBA5970", VA = "0xBA5970")]
	private bool CheckNewbieLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6002603")]
	[Address(RVA = "0xBA5988", Offset = "0xBA5988", VA = "0xBA5988")]
	private bool CheckVeryVeryNewbieLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6002604")]
	[Address(RVA = "0xB75098", Offset = "0xB75098", VA = "0xB75098")]
	public bool CheckNewbieCareBuff_OnRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002605")]
	[Address(RVA = "0xBA59A0", Offset = "0xBA59A0", VA = "0xBA59A0")]
	private bool CheckPVPMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6002606")]
	[Address(RVA = "0xBA5ABC", Offset = "0xBA5ABC", VA = "0xBA5ABC")]
	private bool CheckVeryVeryNewbieOrLosingStreakCareGameMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002607")]
	[Address(RVA = "0xB7521C", Offset = "0xB7521C", VA = "0xB7521C")]
	public bool CheckVeryVeryNewbie()
	{
		return default(bool);
	}

	[Token(Token = "0x6002608")]
	[Address(RVA = "0xB750D0", Offset = "0xB750D0", VA = "0xB750D0")]
	public bool CheckLosingStreakCareBuff()
	{
		return default(bool);
	}

	[Token(Token = "0x6002609")]
	[Address(RVA = "0xBA5CB8", Offset = "0xBA5CB8", VA = "0xBA5CB8")]
	public static void ProcessNewbieConsecutiveLose(int nMyTeamLevel, XGameModeType gameModeType, CSWinlose gameWinlose, bool isMultiplay)
	{
	}
}
