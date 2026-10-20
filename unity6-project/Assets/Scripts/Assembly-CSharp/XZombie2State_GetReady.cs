using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x20005E5")]
public class XZombie2State_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001C77")]
	[FieldOffset(Offset = "0x20")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x4001C78")]
	[FieldOffset(Offset = "0x24")]
	private XLevelLoader m_levelLoader;

	[Token(Token = "0x4001C79")]
	[FieldOffset(Offset = "0x28")]
	private bool m_endArea;

	[Token(Token = "0x4001C7A")]
	[FieldOffset(Offset = "0x2C")]
	private XMasterClientReadyTimeout m_ReadyTimeout;

	[Token(Token = "0x4001C7B")]
	[FieldOffset(Offset = "0x30")]
	private bool isReadyTimeout;

	[Token(Token = "0x600324C")]
	[Address(RVA = "0x23D70C0", Offset = "0x23D70C0", VA = "0x23D70C0")]
	public XZombie2State_GetReady()
	{
	}

	[Token(Token = "0x600324D")]
	[Address(RVA = "0x23D7164", Offset = "0x23D7164", VA = "0x23D7164", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600324E")]
	[Address(RVA = "0x23D72C4", Offset = "0x23D72C4", VA = "0x23D72C4", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x600324F")]
	[Address(RVA = "0x23D758C", Offset = "0x23D758C", VA = "0x23D758C", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x6003250")]
	[Address(RVA = "0x23D75CC", Offset = "0x23D75CC", VA = "0x23D75CC", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6003251")]
	[Address(RVA = "0x23D75D4", Offset = "0x23D75D4", VA = "0x23D75D4", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6003252")]
	[Address(RVA = "0x23D7804", Offset = "0x23D7804", VA = "0x23D7804", Slot = "20")]
	public override void ShowReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6003253")]
	[Address(RVA = "0x23D7830", Offset = "0x23D7830", VA = "0x23D7830", Slot = "21")]
	public override void OnSyncReadyTimeoutTime(int _nCounter)
	{
	}
}
