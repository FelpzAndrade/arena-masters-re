using Il2CppDummyDll;

[Token(Token = "0x200056D")]
public class XDuelState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x4001AD9")]
	[FieldOffset(Offset = "0x1D")]
	private bool readyFinish;

	[Token(Token = "0x4001ADA")]
	[FieldOffset(Offset = "0x20")]
	private float readyTime;

	[Token(Token = "0x4001ADB")]
	[FieldOffset(Offset = "0x24")]
	private XPlayer f_Player;

	[Token(Token = "0x6002E29")]
	[Address(RVA = "0x19AC304", Offset = "0x19AC304", VA = "0x19AC304")]
	public XDuelState_GetReady()
	{
	}

	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0x19AC3A0", Offset = "0x19AC3A0", VA = "0x19AC3A0", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0x19AC3A8", Offset = "0x19AC3A8", VA = "0x19AC3A8", Slot = "7")]
	public override void Update()
	{
	}
}
