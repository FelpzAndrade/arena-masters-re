using Il2CppDummyDll;

[Token(Token = "0x20005D1")]
public class XSpecialState_GetReady : XPVEGameModeState_GetReady
{
	[Token(Token = "0x4001C2F")]
	[FieldOffset(Offset = "0x24")]
	private bool m_bStateChanged;

	[Token(Token = "0x60031B0")]
	[Address(RVA = "0x182C9EC", Offset = "0x182C9EC", VA = "0x182C9EC")]
	public XSpecialState_GetReady()
	{
	}

	[Token(Token = "0x60031B1")]
	[Address(RVA = "0x182C9F4", Offset = "0x182C9F4", VA = "0x182C9F4", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60031B2")]
	[Address(RVA = "0x182CA00", Offset = "0x182CA00", VA = "0x182CA00", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x60031B3")]
	[Address(RVA = "0x182CB2C", Offset = "0x182CB2C", VA = "0x182CB2C", Slot = "19")]
	protected override void ReqRoomInfo()
	{
	}
}
