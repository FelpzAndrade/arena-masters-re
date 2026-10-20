using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005BF")]
public class XPlayerCountChecker
{
	[Token(Token = "0x60030FF")]
	[Address(RVA = "0xB27710", Offset = "0xB27710", VA = "0xB27710")]
	public XPlayerCountChecker()
	{
	}

	[Token(Token = "0x6003100")]
	[Address(RVA = "0xB27718", Offset = "0xB27718", VA = "0xB27718")]
	private bool IsFriendlyMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6003101")]
	[Address(RVA = "0xB277E4", Offset = "0xB277E4", VA = "0xB277E4")]
	private bool IsDeveloperMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6003102")]
	[Address(RVA = "0xB278A8", Offset = "0xB278A8", VA = "0xB278A8")]
	private bool IsEventMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6003103")]
	[Address(RVA = "0xB27984", Offset = "0xB27984", VA = "0xB27984")]
	public bool Check(GameModeInfo gameModeInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6003104")]
	[Address(RVA = "0xB280C0", Offset = "0xB280C0", VA = "0xB280C0")]
	private int CalcMinPlayerCount(GameModeInfo gameModeInfo, bool bEventMatch, bool bFriendlyMatch, bool bDeveloperMode, Room room)
	{
		return default(int);
	}

	[Token(Token = "0x6003105")]
	[Address(RVA = "0xB27B64", Offset = "0xB27B64", VA = "0xB27B64")]
	private bool CheckPlayerCountEnabled(GameModeInfo gameModeInfo, bool bEventMatch, bool bFriendlyMatch, bool bDeveloperMode, out string strMsg)
	{
		strMsg = default;
		return default(bool);
	}
}
