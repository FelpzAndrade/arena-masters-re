using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x200059F")]
public class XPVEGameModeState_GetReady : XGameModeState_GetReady
{
	[Token(Token = "0x4001B6A")]
	[FieldOffset(Offset = "0x1D")]
	private bool m_bStateChanged;

	[Token(Token = "0x4001B6B")]
	[FieldOffset(Offset = "0x20")]
	protected XLevelLoader m_levelLoader;

	[Token(Token = "0x6003025")]
	[Address(RVA = "0x1C95D2C", Offset = "0x1C95D2C", VA = "0x1C95D2C")]
	public XPVEGameModeState_GetReady()
	{
	}

	[Token(Token = "0x6003026")]
	[Address(RVA = "0x1C95D34", Offset = "0x1C95D34", VA = "0x1C95D34", Slot = "4")]
	public override void SetGameMode(XGameMode owner)
	{
	}

	[Token(Token = "0x6003027")]
	[Address(RVA = "0x1C95DEC", Offset = "0x1C95DEC", VA = "0x1C95DEC", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003028")]
	[Address(RVA = "0x1C95ED0", Offset = "0x1C95ED0", VA = "0x1C95ED0", Slot = "7")]
	public override void Update()
	{
	}
}
