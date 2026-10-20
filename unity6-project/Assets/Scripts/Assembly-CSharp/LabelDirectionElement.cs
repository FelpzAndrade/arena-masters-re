using Il2CppDummyDll;

[Token(Token = "0x2000CE4")]
public class LabelDirectionElement : UIDirectionElement
{
	[Token(Token = "0x40041AC")]
	[FieldOffset(Offset = "0x8")]
	private UILabel lbl;

	[Token(Token = "0x40041AD")]
	[FieldOffset(Offset = "0xC")]
	private int from;

	[Token(Token = "0x40041AE")]
	[FieldOffset(Offset = "0x10")]
	private int to;

	[Token(Token = "0x40041AF")]
	[FieldOffset(Offset = "0x14")]
	private float speed;

	[Token(Token = "0x40041B0")]
	[FieldOffset(Offset = "0x18")]
	private string format;

	[Token(Token = "0x40041B1")]
	[FieldOffset(Offset = "0x1C")]
	private int cur;

	[Token(Token = "0x40041B2")]
	[FieldOffset(Offset = "0x20")]
	private bool isFinished;

	[Token(Token = "0x40041B3")]
	[FieldOffset(Offset = "0x21")]
	private bool m_isReverse;

	[Token(Token = "0x40041B4")]
	[FieldOffset(Offset = "0x22")]
	private bool final;

	[Token(Token = "0x40041B5")]
	[FieldOffset(Offset = "0x24")]
	private string prefix;

	[Token(Token = "0x40041B6")]
	[FieldOffset(Offset = "0x28")]
	private string wholeFormat;

	[Token(Token = "0x6005D0E")]
	[Address(RVA = "0xDD4238", Offset = "0xDD4238", VA = "0xDD4238")]
	public LabelDirectionElement(UILabel lbl, int from, int to, float speed, float limitDuration, string format, bool final = false, bool isReverse = false, string wholeFormat = "{0}")
	{
	}

	[Token(Token = "0x6005D0F")]
	[Address(RVA = "0xDD4384", Offset = "0xDD4384", VA = "0xDD4384")]
	public LabelDirectionElement(UILabel lbl, int from, int to, float speed, string format, bool final = false, string prefix = "", bool isReverse = false, float limitDuration = -1f, string wholeFormat = "{0}")
	{
	}

	[Token(Token = "0x6005D10")]
	[Address(RVA = "0xDD4648", Offset = "0xDD4648", VA = "0xDD4648", Slot = "4")]
	public void Start()
	{
	}

	[Token(Token = "0x6005D11")]
	[Address(RVA = "0xDD4688", Offset = "0xDD4688", VA = "0xDD4688", Slot = "5")]
	public void Update()
	{
	}

	[Token(Token = "0x6005D12")]
	[Address(RVA = "0xDD4804", Offset = "0xDD4804", VA = "0xDD4804", Slot = "7")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005D13")]
	[Address(RVA = "0xDD452C", Offset = "0xDD452C", VA = "0xDD452C")]
	private void SetText(string text)
	{
	}

	[Token(Token = "0x6005D14")]
	[Address(RVA = "0xDD484C", Offset = "0xDD484C", VA = "0xDD484C", Slot = "6")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
