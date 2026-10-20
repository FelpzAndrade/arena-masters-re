using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x2000584")]
public class XTeamDeathMatchState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001B29")]
	[FieldOffset(Offset = "0x20")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x4001B2A")]
	[FieldOffset(Offset = "0x24")]
	private XLevelLoader m_levelLoader;

	[Token(Token = "0x4001B2B")]
	[FieldOffset(Offset = "0x28")]
	private bool m_endArea;

	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x184456C", Offset = "0x184456C", VA = "0x184456C")]
	public XTeamDeathMatchState_GetReady()
	{
	}

	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x1844610", Offset = "0x1844610", VA = "0x1844610", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x184488C", Offset = "0x184488C", VA = "0x184488C", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x18448A0", Offset = "0x18448A0", VA = "0x18448A0", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x18448E0", Offset = "0x18448E0", VA = "0x18448E0", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x18448E8", Offset = "0x18448E8", VA = "0x18448E8", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x1844B2C", Offset = "0x1844B2C", VA = "0x1844B2C")]
	private void _003CEnter_003Em__11B()
	{
	}
}
