using Il2CppDummyDll;

[Token(Token = "0x2000559")]
public class XClassicState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001AA3")]
	[FieldOffset(Offset = "0x20")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x4001AA4")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientReadyTimeout m_ReadyTimeout;

	[Token(Token = "0x4001AA5")]
	[FieldOffset(Offset = "0x28")]
	private bool isReadyTimeout;

	[Token(Token = "0x6002DA0")]
	[Address(RVA = "0x1986FBC", Offset = "0x1986FBC", VA = "0x1986FBC")]
	public XClassicState_GetReady()
	{
	}

	[Token(Token = "0x6002DA1")]
	[Address(RVA = "0x1987058", Offset = "0x1987058", VA = "0x1987058", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002DA2")]
	[Address(RVA = "0x19871B8", Offset = "0x19871B8", VA = "0x19871B8", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x19877D4", Offset = "0x19877D4", VA = "0x19877D4", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x19877DC", Offset = "0x19877DC", VA = "0x19877DC", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x19877E4", Offset = "0x19877E4", VA = "0x19877E4", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x1987A14", Offset = "0x1987A14", VA = "0x1987A14", Slot = "20")]
	public override void ShowReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6002DA7")]
	[Address(RVA = "0x1987A40", Offset = "0x1987A40", VA = "0x1987A40", Slot = "21")]
	public override void OnSyncReadyTimeoutTime(int _nCounter)
	{
	}
}
