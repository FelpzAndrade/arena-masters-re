using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005BA")]
public class XMissionState_Finish : XMissionState
{
	[Token(Token = "0x4001BA0")]
	[FieldOffset(Offset = "0x18")]
	private int m_showRecordTime;

	[Token(Token = "0x60030E0")]
	[Address(RVA = "0xB31294", Offset = "0xB31294", VA = "0xB31294")]
	public XMissionState_Finish()
	{
	}

	[Token(Token = "0x60030E1")]
	[Address(RVA = "0xB312A4", Offset = "0xB312A4", VA = "0xB312A4", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60030E2")]
	[Address(RVA = "0xB312FC", Offset = "0xB312FC", VA = "0xB312FC", Slot = "19")]
	protected override XGameModeState GetState(MissionPlayPattern type)
	{
		return null;
	}
}
