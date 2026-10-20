using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x2000579")]
public class XKOFState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001B04")]
	[FieldOffset(Offset = "0x20")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x4001B05")]
	[FieldOffset(Offset = "0x24")]
	private XLevelLoader m_levelLoader;

	[Token(Token = "0x4001B06")]
	[FieldOffset(Offset = "0x28")]
	private bool m_endArea;

	[Token(Token = "0x4001B07")]
	[FieldOffset(Offset = "0x2C")]
	private XMasterClientReadyTimeout m_ReadyTimeout;

	[Token(Token = "0x4001B08")]
	[FieldOffset(Offset = "0x30")]
	private bool isReadyTimeout;

	[Token(Token = "0x6002E9A")]
	[Address(RVA = "0x1D3BC98", Offset = "0x1D3BC98", VA = "0x1D3BC98")]
	public XKOFState_GetReady()
	{
	}

	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0x1D3BD64", Offset = "0x1D3BD64", VA = "0x1D3BD64", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0x1D3BE9C", Offset = "0x1D3BE9C", VA = "0x1D3BE9C", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0x1D3C164", Offset = "0x1D3C164", VA = "0x1D3C164", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0x1D3C1A4", Offset = "0x1D3C1A4", VA = "0x1D3C1A4", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6002E9F")]
	[Address(RVA = "0x1D3C1AC", Offset = "0x1D3C1AC", VA = "0x1D3C1AC", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EA0")]
	[Address(RVA = "0x1D3C3F4", Offset = "0x1D3C3F4", VA = "0x1D3C3F4", Slot = "20")]
	public override void ShowReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x1D3C420", Offset = "0x1D3C420", VA = "0x1D3C420", Slot = "21")]
	public override void OnSyncReadyTimeoutTime(int _nCounter)
	{
	}
}
