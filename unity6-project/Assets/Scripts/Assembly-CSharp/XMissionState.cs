using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005B5")]
public class XMissionState : XGameModeState
{
	[Token(Token = "0x4001B98")]
	[FieldOffset(Offset = "0x14")]
	protected XGameModeState m_state;

	[Token(Token = "0x1700076A")]
	public XGameModeState SubState
	{
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0xB30934", Offset = "0xB30934", VA = "0xB30934")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60030B8")]
	[Address(RVA = "0xB3092C", Offset = "0xB3092C", VA = "0xB3092C")]
	public XMissionState()
	{
	}

	[Token(Token = "0x60030BA")]
	[Address(RVA = "0xB3093C", Offset = "0xB3093C", VA = "0xB3093C", Slot = "4")]
	public override void SetGameMode(XGameMode owner)
	{
	}

	[Token(Token = "0x60030BB")]
	[Address(RVA = "0xB30AA4", Offset = "0xB30AA4", VA = "0xB30AA4", Slot = "16")]
	public override void SetEnterStateAction(Action enterStateAction)
	{
	}

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0xB30B04", Offset = "0xB30B04", VA = "0xB30B04", Slot = "19")]
	protected virtual XGameModeState GetState(MissionPlayPattern type)
	{
		return null;
	}

	[Token(Token = "0x60030BD")]
	[Address(RVA = "0xB30B0C", Offset = "0xB30B0C", VA = "0xB30B0C", Slot = "15")]
	public override XGameModeStateType GetGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x60030BE")]
	[Address(RVA = "0xB30B64", Offset = "0xB30B64", VA = "0xB30B64", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60030BF")]
	[Address(RVA = "0xB30BBC", Offset = "0xB30BBC", VA = "0xB30BBC", Slot = "10")]
	public override bool CheckEnterable()
	{
		return default(bool);
	}

	[Token(Token = "0x60030C0")]
	[Address(RVA = "0xB30C14", Offset = "0xB30C14", VA = "0xB30C14", Slot = "11")]
	public override bool CheckExitable()
	{
		return default(bool);
	}

	[Token(Token = "0x60030C1")]
	[Address(RVA = "0xB30C6C", Offset = "0xB30C6C", VA = "0xB30C6C", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60030C2")]
	[Address(RVA = "0xB30CC4", Offset = "0xB30CC4", VA = "0xB30CC4", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x60030C3")]
	[Address(RVA = "0xB30D1C", Offset = "0xB30D1C", VA = "0xB30D1C", Slot = "12")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60030C4")]
	[Address(RVA = "0xB30D7C", Offset = "0xB30D7C", VA = "0xB30D7C", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x60030C5")]
	[Address(RVA = "0xB30DD4", Offset = "0xB30DD4", VA = "0xB30DD4", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x60030C6")]
	[Address(RVA = "0xB30E34", Offset = "0xB30E34", VA = "0xB30E34", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x60030C7")]
	[Address(RVA = "0xB30E94", Offset = "0xB30E94", VA = "0xB30E94", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}
}
