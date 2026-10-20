using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005B8")]
public class XMissionState_CountDown : XMissionState
{
	[Token(Token = "0x60030D8")]
	[Address(RVA = "0xB30EEC", Offset = "0xB30EEC", VA = "0xB30EEC")]
	public XMissionState_CountDown()
	{
	}

	[Token(Token = "0x60030D9")]
	[Address(RVA = "0xB30EF4", Offset = "0xB30EF4", VA = "0xB30EF4", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60030DA")]
	[Address(RVA = "0xB31050", Offset = "0xB31050", VA = "0xB31050", Slot = "12")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60030DB")]
	[Address(RVA = "0xB31148", Offset = "0xB31148", VA = "0xB31148", Slot = "19")]
	protected override XGameModeState GetState(MissionPlayPattern type)
	{
		return null;
	}
}
