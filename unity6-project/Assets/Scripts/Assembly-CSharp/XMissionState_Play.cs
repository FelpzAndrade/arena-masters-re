using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005B9")]
public class XMissionState_Play : XMissionState
{
	[Token(Token = "0x60030DC")]
	[Address(RVA = "0xB32AD0", Offset = "0xB32AD0", VA = "0xB32AD0")]
	public XMissionState_Play()
	{
	}

	[Token(Token = "0x60030DD")]
	[Address(RVA = "0xB32AD8", Offset = "0xB32AD8", VA = "0xB32AD8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60030DE")]
	[Address(RVA = "0xB32B30", Offset = "0xB32B30", VA = "0xB32B30", Slot = "12")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60030DF")]
	[Address(RVA = "0xB32C28", Offset = "0xB32C28", VA = "0xB32C28", Slot = "19")]
	protected override XGameModeState GetState(MissionPlayPattern type)
	{
		return null;
	}
}
