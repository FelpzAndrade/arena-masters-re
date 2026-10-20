using Il2CppDummyDll;

[Token(Token = "0x20005CC")]
public class XSoloState_GetReady : XPVEGameModeState_GetReady
{
	[Token(Token = "0x4001C22")]
	[FieldOffset(Offset = "0x24")]
	private bool m_bStateChanged;

	[Token(Token = "0x600319D")]
	[Address(RVA = "0x1824BF8", Offset = "0x1824BF8", VA = "0x1824BF8")]
	public XSoloState_GetReady()
	{
	}

	[Token(Token = "0x600319E")]
	[Address(RVA = "0x1824C00", Offset = "0x1824C00", VA = "0x1824C00", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600319F")]
	[Address(RVA = "0x1824C0C", Offset = "0x1824C0C", VA = "0x1824C0C", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x60031A0")]
	[Address(RVA = "0x18252FC", Offset = "0x18252FC", VA = "0x18252FC", Slot = "19")]
	protected override void ReqRoomInfo()
	{
	}
}
