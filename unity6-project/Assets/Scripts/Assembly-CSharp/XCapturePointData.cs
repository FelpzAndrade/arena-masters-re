using CS;
using Il2CppDummyDll;

[Token(Token = "0x200050F")]
public class XCapturePointData
{
	[Token(Token = "0x40019B7")]
	[FieldOffset(Offset = "0x8")]
	public XTeamEnum m_TeamEnum;

	[Token(Token = "0x40019B8")]
	[FieldOffset(Offset = "0xC")]
	public XTeamEnum m_CapturingTeamEnum;

	[Token(Token = "0x40019B9")]
	[FieldOffset(Offset = "0x10")]
	public float m_Value;

	[Token(Token = "0x6002B93")]
	[Address(RVA = "0x1AA9BEC", Offset = "0x1AA9BEC", VA = "0x1AA9BEC")]
	public XCapturePointData()
	{
	}

	[Token(Token = "0x6002B94")]
	[Address(RVA = "0x1AA5E90", Offset = "0x1AA5E90", VA = "0x1AA5E90")]
	public void IncValue(float fDelta, float fMax)
	{
	}

	[Token(Token = "0x6002B95")]
	[Address(RVA = "0x1AA5E6C", Offset = "0x1AA5E6C", VA = "0x1AA5E6C")]
	public void DecValue(float fDelta, float fMin)
	{
	}

	[Token(Token = "0x6002B96")]
	[Address(RVA = "0x1AA9BF4", Offset = "0x1AA9BF4", VA = "0x1AA9BF4")]
	public float CalcInteractionProgressBarValue(float fTotalTime)
	{
		return default(float);
	}
}
