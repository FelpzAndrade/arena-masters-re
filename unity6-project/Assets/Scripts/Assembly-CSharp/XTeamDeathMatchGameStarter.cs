using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005D6")]
public class XTeamDeathMatchGameStarter
{
	[Token(Token = "0x4001C3C")]
	private const float START_DELAY_TIME = 1f;

	[Token(Token = "0x4001C3D")]
	[FieldOffset(Offset = "0x8")]
	private GameModeInfo m_GameModeInfo;

	[Token(Token = "0x4001C3E")]
	[FieldOffset(Offset = "0xC")]
	private XPVPGameModeState_GetReady m_GameModeState;

	[Token(Token = "0x4001C3F")]
	[FieldOffset(Offset = "0x10")]
	private XPlayerCountChecker m_PlayerCountChecker;

	[Token(Token = "0x60031C4")]
	[Address(RVA = "0x18410C8", Offset = "0x18410C8", VA = "0x18410C8")]
	public XTeamDeathMatchGameStarter(XPVPGameModeState_GetReady modeState)
	{
	}

	[Token(Token = "0x60031C5")]
	[Address(RVA = "0x184116C", Offset = "0x184116C", VA = "0x184116C")]
	public void RequestGameStart(GameModeInfo gameModeInfo)
	{
	}

	[Token(Token = "0x60031C6")]
	[Address(RVA = "0x18415B8", Offset = "0x18415B8", VA = "0x18415B8")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x60031C7")]
	[Address(RVA = "0x1841584", Offset = "0x1841584", VA = "0x1841584")]
	private bool CheckCanStart()
	{
		return default(bool);
	}
}
