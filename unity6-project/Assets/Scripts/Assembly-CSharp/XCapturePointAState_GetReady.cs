using System;
using Il2CppDummyDll;

[Token(Token = "0x200050A")]
public class XCapturePointAState_GetReady : XPVPGameModeState_GetReady
{
	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0x1D")]
	private bool readyFinish;

	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x1E")]
	private bool isReadyTimeout;

	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0x20")]
	private float readyTime;

	[Token(Token = "0x40019AD")]
	[FieldOffset(Offset = "0x24")]
	private XTeamDeathMatchGameStarter m_GameStarter;

	[Token(Token = "0x40019AE")]
	[FieldOffset(Offset = "0x28")]
	private XMasterClientReadyTimeout m_ReadyTimeout;

	[Token(Token = "0x40019AF")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x6002B6F")]
	[Address(RVA = "0x1AA72C4", Offset = "0x1AA72C4", VA = "0x1AA72C4")]
	public XCapturePointAState_GetReady()
	{
	}

	[Token(Token = "0x6002B70")]
	[Address(RVA = "0x1AA7388", Offset = "0x1AA7388", VA = "0x1AA7388", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002B71")]
	[Address(RVA = "0x1AA74B4", Offset = "0x1AA74B4", VA = "0x1AA74B4", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B72")]
	[Address(RVA = "0x1AA76FC", Offset = "0x1AA76FC", VA = "0x1AA76FC", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002B73")]
	[Address(RVA = "0x1AA79E0", Offset = "0x1AA79E0", VA = "0x1AA79E0", Slot = "20")]
	public override void ShowReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6002B74")]
	[Address(RVA = "0x1AA7A0C", Offset = "0x1AA7A0C", VA = "0x1AA7A0C", Slot = "21")]
	public override void OnSyncReadyTimeoutTime(int _nCounter)
	{
	}

	[Token(Token = "0x6002B75")]
	[Address(RVA = "0x1AA7A38", Offset = "0x1AA7A38", VA = "0x1AA7A38")]
	internal void OnReadyTimeout()
	{
	}

	[Token(Token = "0x6002B76")]
	[Address(RVA = "0x1AA7C9C", Offset = "0x1AA7C9C", VA = "0x1AA7C9C")]
	private static void _003COnReadyTimeout_003Em__111()
	{
	}
}
