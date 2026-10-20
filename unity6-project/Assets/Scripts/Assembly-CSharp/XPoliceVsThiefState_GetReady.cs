using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x200053C")]
public class XPoliceVsThiefState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001A3D")]
	[FieldOffset(Offset = "0x20")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x4001A3E")]
	[FieldOffset(Offset = "0x24")]
	private XLevelLoader m_levelLoader;

	[Token(Token = "0x4001A3F")]
	[FieldOffset(Offset = "0x28")]
	private bool m_endArea;

	[Token(Token = "0x4001A40")]
	[FieldOffset(Offset = "0x2C")]
	private XMasterClientReadyTimeout m_ReadyTimeout;

	[Token(Token = "0x4001A41")]
	[FieldOffset(Offset = "0x30")]
	private bool isReadyTimeout;

	[Token(Token = "0x6002CB4")]
	[Address(RVA = "0x1C83540", Offset = "0x1C83540", VA = "0x1C83540")]
	public XPoliceVsThiefState_GetReady()
	{
	}

	[Token(Token = "0x6002CB5")]
	[Address(RVA = "0x1C835EC", Offset = "0x1C835EC", VA = "0x1C835EC", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002CB6")]
	[Address(RVA = "0x1C83AC4", Offset = "0x1C83AC4", VA = "0x1C83AC4", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0x1C83D98", Offset = "0x1C83D98", VA = "0x1C83D98", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0x1C83DD8", Offset = "0x1C83DD8", VA = "0x1C83DD8", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6002CB9")]
	[Address(RVA = "0x1C83EBC", Offset = "0x1C83EBC", VA = "0x1C83EBC", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0x1C840EC", Offset = "0x1C840EC", VA = "0x1C840EC", Slot = "20")]
	public override void ShowReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6002CBB")]
	[Address(RVA = "0x1C84118", Offset = "0x1C84118", VA = "0x1C84118", Slot = "21")]
	public override void OnSyncReadyTimeoutTime(int _nCounter)
	{
	}
}
