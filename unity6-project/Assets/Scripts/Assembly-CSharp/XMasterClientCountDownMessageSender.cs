using Il2CppDummyDll;

[Token(Token = "0x20005A0")]
public class XMasterClientCountDownMessageSender
{
	[Token(Token = "0x4001B6C")]
	[FieldOffset(Offset = "0x8")]
	protected int m_nCountDown;

	[Token(Token = "0x6003029")]
	[Address(RVA = "0x1E2D048", Offset = "0x1E2D048", VA = "0x1E2D048")]
	public XMasterClientCountDownMessageSender()
	{
	}

	[Token(Token = "0x600302A")]
	[Address(RVA = "0x1E2D050", Offset = "0x1E2D050", VA = "0x1E2D050", Slot = "4")]
	public virtual void InitCountDown(int nCountDown)
	{
	}

	[Token(Token = "0x600302B")]
	[Address(RVA = "0x1E2D058", Offset = "0x1E2D058", VA = "0x1E2D058", Slot = "5")]
	public virtual void Update(int nTimeRemaining, bool bIsMasterClient, bool isTitle = true, string msgSoundName = "")
	{
	}

	[Token(Token = "0x600302C")]
	[Address(RVA = "0x1E2D0A4", Offset = "0x1E2D0A4", VA = "0x1E2D0A4")]
	private void SendMsg(int nCount, bool isTitle, string msgSoundName)
	{
	}
}
