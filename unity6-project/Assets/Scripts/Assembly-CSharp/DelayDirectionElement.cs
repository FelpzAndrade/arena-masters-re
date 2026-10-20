using Il2CppDummyDll;

[Token(Token = "0x2000CE5")]
public class DelayDirectionElement : UIDirectionElement
{
		protected DelayDirectionElement()
		{
		}

	[Token(Token = "0x40041B7")]
	[FieldOffset(Offset = "0x8")]
	protected float delay;

	[Token(Token = "0x40041B8")]
	[FieldOffset(Offset = "0xC")]
	protected float elapsed;

	[Token(Token = "0x40041B9")]
	[FieldOffset(Offset = "0x10")]
	protected bool isFinished;

	[Token(Token = "0x6005D15")]
	[Address(RVA = "0x1E6369C", Offset = "0x1E6369C", VA = "0x1E6369C")]
	public DelayDirectionElement(float delay)
	{
	}

	[Token(Token = "0x6005D16")]
	[Address(RVA = "0x1E636BC", Offset = "0x1E636BC", VA = "0x1E636BC", Slot = "8")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6005D17")]
	[Address(RVA = "0x1E636CC", Offset = "0x1E636CC", VA = "0x1E636CC", Slot = "9")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6005D18")]
	[Address(RVA = "0x1E63714", Offset = "0x1E63714", VA = "0x1E63714", Slot = "10")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x6005D19")]
	[Address(RVA = "0x1E63720", Offset = "0x1E63720", VA = "0x1E63720", Slot = "11")]
	public virtual bool IsFinished()
	{
		return default(bool);
	}
}
