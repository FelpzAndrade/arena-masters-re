using Il2CppDummyDll;

[Token(Token = "0x2000CE1")]
public class ProgressBarDirectionElement : UIDirectionElement
{
	[Token(Token = "0x40041A2")]
	[FieldOffset(Offset = "0x8")]
	private UIProgressBar prb;

	[Token(Token = "0x40041A3")]
	[FieldOffset(Offset = "0xC")]
	private float curr;

	[Token(Token = "0x40041A4")]
	[FieldOffset(Offset = "0x10")]
	private float to;

	[Token(Token = "0x40041A5")]
	[FieldOffset(Offset = "0x14")]
	private float speed;

	[Token(Token = "0x40041A6")]
	[FieldOffset(Offset = "0x18")]
	private bool final;

	[Token(Token = "0x40041A7")]
	[FieldOffset(Offset = "0x19")]
	private bool isFinished;

	[Token(Token = "0x6005CFF")]
	[Address(RVA = "0x20E4C8C", Offset = "0x20E4C8C", VA = "0x20E4C8C")]
	public ProgressBarDirectionElement(UIProgressBar prb, float curr, float to, float speed, bool finalState = false)
	{
	}

	[Token(Token = "0x6005D00")]
	[Address(RVA = "0x20E4CD4", Offset = "0x20E4CD4", VA = "0x20E4CD4", Slot = "4")]
	public void Start()
	{
	}

	[Token(Token = "0x6005D01")]
	[Address(RVA = "0x20E4D08", Offset = "0x20E4D08", VA = "0x20E4D08", Slot = "5")]
	public void Update()
	{
	}

	[Token(Token = "0x6005D02")]
	[Address(RVA = "0x20E4E74", Offset = "0x20E4E74", VA = "0x20E4E74", Slot = "7")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005D03")]
	[Address(RVA = "0x20E4EBC", Offset = "0x20E4EBC", VA = "0x20E4EBC", Slot = "6")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
