using Il2CppDummyDll;

[Token(Token = "0x20005F5")]
public class XZombieTagState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001CA3")]
	[FieldOffset(Offset = "0x20")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x4001CA4")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientReadyTimeout m_ReadyTimeout;

	[Token(Token = "0x60032C3")]
	[Address(RVA = "0x23E030C", Offset = "0x23E030C", VA = "0x23E030C")]
	public XZombieTagState_GetReady()
	{
	}

	[Token(Token = "0x60032C4")]
	[Address(RVA = "0x23E03A8", Offset = "0x23E03A8", VA = "0x23E03A8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60032C5")]
	[Address(RVA = "0x23E05F8", Offset = "0x23E05F8", VA = "0x23E05F8", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x60032C6")]
	[Address(RVA = "0x23E0600", Offset = "0x23E0600", VA = "0x23E0600", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x60032C7")]
	[Address(RVA = "0x23E0608", Offset = "0x23E0608", VA = "0x23E0608", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x23E0610", Offset = "0x23E0610", VA = "0x23E0610", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}
}
