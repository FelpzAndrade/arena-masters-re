using Il2CppDummyDll;

[Token(Token = "0x200024A")]
public class TweenHeight : UITweener
{
	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x50")]
	public int from;

	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x54")]
	public int to;

	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x58")]
	public bool updateTable;

	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x5C")]
	private UIWidget mWidget;

	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x60")]
	private UITable mTable;

	[Token(Token = "0x170002FE")]
	public UIWidget cachedWidget
	{
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x1D5E030", Offset = "0x1D5E030", VA = "0x1D5E030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FF")]
	public int height
	{
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x1D5E118", Offset = "0x1D5E118", VA = "0x1D5E118")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x1D5E148", Offset = "0x1D5E148", VA = "0x1D5E148")]
		set
		{
		}
	}

	[Token(Token = "0x17000300")]
	public int value
	{
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x1D5E11C", Offset = "0x1D5E11C", VA = "0x1D5E11C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x1D5E14C", Offset = "0x1D5E14C", VA = "0x1D5E14C")]
		set
		{
		}
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x1D5E01C", Offset = "0x1D5E01C", VA = "0x1D5E01C")]
	public TweenHeight()
	{
	}

	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x1D5E180", Offset = "0x1D5E180", VA = "0x1D5E180", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x1D5E3C0", Offset = "0x1D5E3C0", VA = "0x1D5E3C0")]
	public static TweenHeight Begin(UIWidget widget, float duration, int height)
	{
		return null;
	}

	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x1D5E4D4", Offset = "0x1D5E4D4", VA = "0x1D5E4D4", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x1D5E4EC", Offset = "0x1D5E4EC", VA = "0x1D5E4EC", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x1D5E504", Offset = "0x1D5E504", VA = "0x1D5E504")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x1D5E50C", Offset = "0x1D5E50C", VA = "0x1D5E50C")]
	private void SetCurrentValueToEnd()
	{
	}
}
