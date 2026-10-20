using Il2CppDummyDll;

[Token(Token = "0x20005F4")]
public class XZombieTagCountDownMessageSender
{
	[Token(Token = "0x4001CA0")]
	[FieldOffset(Offset = "0x8")]
	private int m_nCountDown;

	[Token(Token = "0x4001CA1")]
	[FieldOffset(Offset = "0xC")]
	private int m_lastSend;

	[Token(Token = "0x4001CA2")]
	[FieldOffset(Offset = "0x10")]
	private bool sendSuddenDeath;

	[Token(Token = "0x60032BF")]
	[Address(RVA = "0x23DBD60", Offset = "0x23DBD60", VA = "0x23DBD60")]
	public XZombieTagCountDownMessageSender()
	{
	}

	[Token(Token = "0x60032C0")]
	[Address(RVA = "0x23DBD70", Offset = "0x23DBD70", VA = "0x23DBD70")]
	public void InitCountDown(int nCountDown)
	{
	}

	[Token(Token = "0x60032C1")]
	[Address(RVA = "0x23DBD78", Offset = "0x23DBD78", VA = "0x23DBD78")]
	public void Update(int nTimeRemaining)
	{
	}

	[Token(Token = "0x60032C2")]
	[Address(RVA = "0x23DBDB4", Offset = "0x23DBDB4", VA = "0x23DBDB4")]
	private void SendMsg(int nCount)
	{
	}
}
