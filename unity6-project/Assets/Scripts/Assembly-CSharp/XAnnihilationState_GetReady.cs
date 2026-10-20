using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x200054A")]
public class XAnnihilationState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001A6A")]
	[FieldOffset(Offset = "0x20")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x4001A6B")]
	[FieldOffset(Offset = "0x24")]
	private XLevelLoader m_levelLoader;

	[Token(Token = "0x4001A6C")]
	[FieldOffset(Offset = "0x28")]
	private bool m_endArea;

	[Token(Token = "0x4001A6D")]
	[FieldOffset(Offset = "0x2C")]
	private XMasterClientReadyTimeout m_ReadyTimeout;

	[Token(Token = "0x4001A6E")]
	[FieldOffset(Offset = "0x30")]
	private bool isReadyTimeout;

	[Token(Token = "0x6002D14")]
	[Address(RVA = "0x1EE5FB4", Offset = "0x1EE5FB4", VA = "0x1EE5FB4")]
	public XAnnihilationState_GetReady()
	{
	}

	[Token(Token = "0x6002D15")]
	[Address(RVA = "0x1EE6058", Offset = "0x1EE6058", VA = "0x1EE6058", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002D16")]
	[Address(RVA = "0x1EE61B8", Offset = "0x1EE61B8", VA = "0x1EE61B8", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x1EE6480", Offset = "0x1EE6480", VA = "0x1EE6480", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002D18")]
	[Address(RVA = "0x1EE64C0", Offset = "0x1EE64C0", VA = "0x1EE64C0", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6002D19")]
	[Address(RVA = "0x1EE64C8", Offset = "0x1EE64C8", VA = "0x1EE64C8", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D1A")]
	[Address(RVA = "0x1EE66F8", Offset = "0x1EE66F8", VA = "0x1EE66F8", Slot = "20")]
	public override void ShowReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6002D1B")]
	[Address(RVA = "0x1EE6724", Offset = "0x1EE6724", VA = "0x1EE6724", Slot = "21")]
	public override void OnSyncReadyTimeoutTime(int _nCounter)
	{
	}
}
