using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000247")]
public class TweenColor : UITweener
{
	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x50")]
	public Color from;

	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x60")]
	public Color to;

	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x70")]
	private bool mCached;

	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x74")]
	private UIWidget mWidget;

	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0x78")]
	private Material mMat;

	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x7C")]
	private Light mLight;

	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x80")]
	private SpriteRenderer mSr;

	[Token(Token = "0x170002F8")]
	public Color color
	{
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x1D5D048", Offset = "0x1D5D048", VA = "0x1D5D048")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x1D5D2A4", Offset = "0x1D5D2A4", VA = "0x1D5D2A4")]
		set
		{
		}
	}

	[Token(Token = "0x170002F9")]
	public Color value
	{
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x1D5D058", Offset = "0x1D5D058", VA = "0x1D5D058")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x1D5D2C4", Offset = "0x1D5D2C4", VA = "0x1D5D2C4")]
		set
		{
		}
	}

	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x1D5CD74", Offset = "0x1D5CD74", VA = "0x1D5CD74")]
	public TweenColor()
	{
	}

	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x1D5CDDC", Offset = "0x1D5CDDC", VA = "0x1D5CDDC")]
	private void Cache()
	{
	}

	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x1D5D598", Offset = "0x1D5D598", VA = "0x1D5D598", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x1D5D604", Offset = "0x1D5D604", VA = "0x1D5D604")]
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return null;
	}

	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x1D5D72C", Offset = "0x1D5D72C", VA = "0x1D5D72C", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x1D5D764", Offset = "0x1D5D764", VA = "0x1D5D764", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x1D5D79C", Offset = "0x1D5D79C", VA = "0x1D5D79C")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x60013AD")]
	[Address(RVA = "0x1D5D7C0", Offset = "0x1D5D7C0", VA = "0x1D5D7C0")]
	private void SetCurrentValueToEnd()
	{
	}
}
