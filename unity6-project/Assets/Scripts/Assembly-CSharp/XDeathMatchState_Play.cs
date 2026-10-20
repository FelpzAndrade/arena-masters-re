using Il2CppDummyDll;

[Token(Token = "0x2000566")]
public class XDeathMatchState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x4001AC5")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0x28")]
	private string endCountDownSoundKey;

	[Token(Token = "0x6002E02")]
	[Address(RVA = "0x19A7768", Offset = "0x19A7768", VA = "0x19A7768")]
	public XDeathMatchState_Play()
	{
	}

	[Token(Token = "0x6002E03")]
	[Address(RVA = "0x19A7818", Offset = "0x19A7818", VA = "0x19A7818", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002E04")]
	[Address(RVA = "0x19A7BD4", Offset = "0x19A7BD4", VA = "0x19A7BD4", Slot = "7")]
	public override void Update()
	{
	}
}
