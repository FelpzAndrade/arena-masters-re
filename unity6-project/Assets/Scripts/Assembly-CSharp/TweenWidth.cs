using Il2CppDummyDll;

[Token(Token = "0x2000251")]
public class TweenWidth : UITweener
{
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x50")]
	public int from;

	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x54")]
	public int to;

	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x58")]
	public bool updateTable;

	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x5C")]
	private UIWidget mWidget;

	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x60")]
	private UITable mTable;

	[Token(Token = "0x17000310")]
	public UIWidget cachedWidget
	{
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x1D608CC", Offset = "0x1D608CC", VA = "0x1D608CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000311")]
	public int width
	{
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x1D609B4", Offset = "0x1D609B4", VA = "0x1D609B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x1D609E4", Offset = "0x1D609E4", VA = "0x1D609E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000312")]
	public int value
	{
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x1D609B8", Offset = "0x1D609B8", VA = "0x1D609B8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x1D609E8", Offset = "0x1D609E8", VA = "0x1D609E8")]
		set
		{
		}
	}

	[Token(Token = "0x600140C")]
	[Address(RVA = "0x1D608B8", Offset = "0x1D608B8", VA = "0x1D608B8")]
	public TweenWidth()
	{
	}

	[Token(Token = "0x6001412")]
	[Address(RVA = "0x1D60A1C", Offset = "0x1D60A1C", VA = "0x1D60A1C", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6001413")]
	[Address(RVA = "0x1D60C5C", Offset = "0x1D60C5C", VA = "0x1D60C5C")]
	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		return null;
	}

	[Token(Token = "0x6001414")]
	[Address(RVA = "0x1D60D70", Offset = "0x1D60D70", VA = "0x1D60D70", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x6001415")]
	[Address(RVA = "0x1D60D88", Offset = "0x1D60D88", VA = "0x1D60D88", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x6001416")]
	[Address(RVA = "0x1D60DA0", Offset = "0x1D60DA0", VA = "0x1D60DA0")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x6001417")]
	[Address(RVA = "0x1D60DA8", Offset = "0x1D60DA8", VA = "0x1D60DA8")]
	private void SetCurrentValueToEnd()
	{
	}
}
