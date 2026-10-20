using Il2CppDummyDll;

[Token(Token = "0x20005A2")]
public class XGameModeState_CountDown : XGameModeState
{
	[Token(Token = "0x4001B6D")]
	[FieldOffset(Offset = "0x14")]
	protected float m_fTimeRemaining;

	[Token(Token = "0x4001B6E")]
	[FieldOffset(Offset = "0x18")]
	protected XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001B6F")]
	[FieldOffset(Offset = "0x1C")]
	protected int m_CountDown;

	[Token(Token = "0x6003031")]
	[Address(RVA = "0x1414534", Offset = "0x1414534", VA = "0x1414534")]
	public XGameModeState_CountDown()
	{
	}

	[Token(Token = "0x6003032")]
	[Address(RVA = "0x14145D0", Offset = "0x14145D0", VA = "0x14145D0", Slot = "15")]
	public override XGameModeStateType GetGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x6003033")]
	[Address(RVA = "0x14145D8", Offset = "0x14145D8", VA = "0x14145D8", Slot = "19")]
	protected virtual void InitCoundDown()
	{
	}

	[Token(Token = "0x6003034")]
	[Address(RVA = "0x14146C8", Offset = "0x14146C8", VA = "0x14146C8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003035")]
	[Address(RVA = "0x14148D8", Offset = "0x14148D8", VA = "0x14148D8", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6003036")]
	[Address(RVA = "0x14148DC", Offset = "0x14148DC", VA = "0x14148DC")]
	private void UpdateTimer()
	{
	}
}
