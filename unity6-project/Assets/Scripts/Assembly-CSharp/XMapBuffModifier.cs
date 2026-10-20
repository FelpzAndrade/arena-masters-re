using Il2CppDummyDll;

[Token(Token = "0x20003A2")]
public class XMapBuffModifier
{
	[Token(Token = "0x40012E0")]
	[FieldOffset(Offset = "0x8")]
	private float m_fModSightRange;

	[Token(Token = "0x17000503")]
	public float ModSightRange
	{
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x1E2CA9C", Offset = "0x1E2CA9C", VA = "0x1E2CA9C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0x1E2C37C", Offset = "0x1E2C37C", VA = "0x1E2C37C")]
	public XMapBuffModifier()
	{
	}

	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x1E2CA1C", Offset = "0x1E2CA1C", VA = "0x1E2CA1C")]
	public XMapBuffModifier(float fModSightRange)
	{
	}

	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x1E2C3C4", Offset = "0x1E2C3C4", VA = "0x1E2C3C4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x1E2CA3C", Offset = "0x1E2CA3C", VA = "0x1E2CA3C")]
	public void Plus(XMapBuffModifier rhs)
	{
	}

	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x1E2CA68", Offset = "0x1E2CA68", VA = "0x1E2CA68")]
	public void Minus(XMapBuffModifier rhs)
	{
	}
}
