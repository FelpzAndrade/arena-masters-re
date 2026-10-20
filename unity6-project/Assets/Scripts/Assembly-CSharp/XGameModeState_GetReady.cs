using Il2CppDummyDll;

[Token(Token = "0x200059D")]
public class XGameModeState_GetReady : XGameModeState
{
	[Token(Token = "0x4001B67")]
	[FieldOffset(Offset = "0x14")]
	protected XMasterClientAutoStarter m_MasterClientAutoStarter;

	[Token(Token = "0x4001B68")]
	[FieldOffset(Offset = "0x18")]
	protected XPlayerCountChecker m_PlayerCountChecker;

	[Token(Token = "0x4001B69")]
	[FieldOffset(Offset = "0x1C")]
	private bool isStartCall__BackingField;

	[Token(Token = "0x17000763")]
	public bool isStartCall
	{
		[Token(Token = "0x6003014")]
		[Address(RVA = "0x1418EA4", Offset = "0x1418EA4", VA = "0x1418EA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003015")]
		[Address(RVA = "0x1418EAC", Offset = "0x1418EAC", VA = "0x1418EAC")]
		set
		{
		}
	}

	[Token(Token = "0x6003013")]
	[Address(RVA = "0x1418DE4", Offset = "0x1418DE4", VA = "0x1418DE4")]
	public XGameModeState_GetReady()
	{
	}

	[Token(Token = "0x6003016")]
	[Address(RVA = "0x1418EB4", Offset = "0x1418EB4", VA = "0x1418EB4", Slot = "15")]
	public override XGameModeStateType GetGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x6003017")]
	[Address(RVA = "0x1418EBC", Offset = "0x1418EBC", VA = "0x1418EBC", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003018")]
	[Address(RVA = "0x1419254", Offset = "0x1419254", VA = "0x1419254", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6003019")]
	[Address(RVA = "0x141942C", Offset = "0x141942C", VA = "0x141942C", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x600301A")]
	[Address(RVA = "0x1419430", Offset = "0x1419430", VA = "0x1419430", Slot = "19")]
	protected virtual void ReqRoomInfo()
	{
	}

	[Token(Token = "0x600301B")]
	[Address(RVA = "0x14195DC", Offset = "0x14195DC", VA = "0x14195DC", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x600301C")]
	[Address(RVA = "0x14198F8", Offset = "0x14198F8", VA = "0x14198F8")]
	protected bool CheckCanStart()
	{
		return default(bool);
	}

	[Token(Token = "0x600301D")]
	[Address(RVA = "0x14199DC", Offset = "0x14199DC", VA = "0x14199DC")]
	protected bool CheckPlayerCountEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600301E")]
	[Address(RVA = "0x140DBD8", Offset = "0x140DBD8", VA = "0x140DBD8")]
	internal void ResetInGameStart()
	{
	}
}
