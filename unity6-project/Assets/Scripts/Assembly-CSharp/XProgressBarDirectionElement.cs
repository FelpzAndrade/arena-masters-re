using Il2CppDummyDll;

[Token(Token = "0x2000CE2")]
public class XProgressBarDirectionElement : UIDirectionElement
{
	[Token(Token = "0x40041A8")]
	[FieldOffset(Offset = "0x8")]
	private XWidget_ProgressBar prb;

	[Token(Token = "0x40041A9")]
	[FieldOffset(Offset = "0xC")]
	private int targetValue;

	[Token(Token = "0x6005D04")]
	[Address(RVA = "0x1C8583C", Offset = "0x1C8583C", VA = "0x1C8583C")]
	public XProgressBarDirectionElement(XWidget_ProgressBar prb, int targetVal)
	{
	}

	[Token(Token = "0x6005D05")]
	[Address(RVA = "0x1C85864", Offset = "0x1C85864", VA = "0x1C85864", Slot = "4")]
	public void Start()
	{
	}

	[Token(Token = "0x6005D06")]
	[Address(RVA = "0x1C8589C", Offset = "0x1C8589C", VA = "0x1C8589C", Slot = "5")]
	public void Update()
	{
	}

	[Token(Token = "0x6005D07")]
	[Address(RVA = "0x1C858CC", Offset = "0x1C858CC", VA = "0x1C858CC", Slot = "7")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005D08")]
	[Address(RVA = "0x1C858A0", Offset = "0x1C858A0", VA = "0x1C858A0", Slot = "6")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
