using Il2CppDummyDll;

[Token(Token = "0x2000510")]
public class XGameModeData_CapturePointA : XGameModeData
{
	[Token(Token = "0x40019BA")]
	[FieldOffset(Offset = "0x8")]
	public XCapturePointData m_CapturePointData;

	[Token(Token = "0x40019BB")]
	[FieldOffset(Offset = "0xC")]
	public float m_ATeamElapsedTime;

	[Token(Token = "0x40019BC")]
	[FieldOffset(Offset = "0x10")]
	public float m_BTeamElapsedTime;

	[Token(Token = "0x40019BD")]
	[FieldOffset(Offset = "0x14")]
	public float m_RestElapsedTime;

	[Token(Token = "0x40019BE")]
	[FieldOffset(Offset = "0x18")]
	public int m_ATeamScore;

	[Token(Token = "0x40019BF")]
	[FieldOffset(Offset = "0x1C")]
	public int m_BTeamScore;

	[Token(Token = "0x40019C0")]
	[FieldOffset(Offset = "0x20")]
	public int m_round;

	[Token(Token = "0x6002B97")]
	[Address(RVA = "0x1401770", Offset = "0x1401770", VA = "0x1401770")]
	public XGameModeData_CapturePointA()
	{
	}

	[Token(Token = "0x6002B98")]
	[Address(RVA = "0x140536C", Offset = "0x140536C", VA = "0x140536C")]
	public int CalcChecksum()
	{
		return default(int);
	}

	[Token(Token = "0x6002B99")]
	[Address(RVA = "0x140555C", Offset = "0x140555C", VA = "0x140555C")]
	public void SetFromNetData(NetData_CapturePointAGameModeData gameModeNetData)
	{
	}
}
