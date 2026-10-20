using Il2CppDummyDll;

[Token(Token = "0x20004C8")]
public class XChatSpamChecker
{
	[Token(Token = "0x4001819")]
	private const float CHECK_TIME = 3f;

	[Token(Token = "0x400181A")]
	private const int CHECK_MESSAGE_COUNT = 3;

	[Token(Token = "0x400181B")]
	[FieldOffset(Offset = "0x8")]
	private float[] m_LastTimes;

	[Token(Token = "0x400181C")]
	[FieldOffset(Offset = "0xC")]
	private int m_nTimeIndex;

	[Token(Token = "0x600291E")]
	[Address(RVA = "0x1AC2D9C", Offset = "0x1AC2D9C", VA = "0x1AC2D9C")]
	public XChatSpamChecker()
	{
	}

	[Token(Token = "0x600291F")]
	[Address(RVA = "0x1AC37B8", Offset = "0x1AC37B8", VA = "0x1AC37B8")]
	public bool Check(float fNowTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6002920")]
	[Address(RVA = "0x1AC4BD4", Offset = "0x1AC4BD4", VA = "0x1AC4BD4")]
	private void SetNowTime(float fNowTime)
	{
	}
}
