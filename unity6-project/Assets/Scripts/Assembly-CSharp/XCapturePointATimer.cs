using Il2CppDummyDll;

[Token(Token = "0x2000506")]
public class XCapturePointATimer
{
	[Token(Token = "0x4001996")]
	[FieldOffset(Offset = "0x8")]
	private float m_fElapsedTime;

	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0xC")]
	private float m_fGoalTime;

	[Token(Token = "0x6002B53")]
	[Address(RVA = "0x1AA49B4", Offset = "0x1AA49B4", VA = "0x1AA49B4")]
	public XCapturePointATimer()
	{
	}

	[Token(Token = "0x6002B54")]
	[Address(RVA = "0x1AA5530", Offset = "0x1AA5530", VA = "0x1AA5530")]
	public void Update(float fDeltaTime)
	{
	}

	[Token(Token = "0x6002B55")]
	[Address(RVA = "0x1AA4A14", Offset = "0x1AA4A14", VA = "0x1AA4A14")]
	public void SetGoalTime(float fTime)
	{
	}

	[Token(Token = "0x6002B56")]
	[Address(RVA = "0x1AA4BF8", Offset = "0x1AA4BF8", VA = "0x1AA4BF8")]
	public void SetElapsedTime(float fTime)
	{
	}

	[Token(Token = "0x6002B57")]
	[Address(RVA = "0x1AA5554", Offset = "0x1AA5554", VA = "0x1AA5554")]
	public float GetElapsedTime()
	{
		return default(float);
	}

	[Token(Token = "0x6002B58")]
	[Address(RVA = "0x1AA555C", Offset = "0x1AA555C", VA = "0x1AA555C")]
	public bool IsDone()
	{
		return default(bool);
	}
}
