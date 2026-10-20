using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001042")]
public class TweenClippedPanel : UITweener
{
	[Token(Token = "0x400579E")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 offsetFrom;

	[Token(Token = "0x400579F")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 offsetTo;

	[Token(Token = "0x40057A0")]
	[FieldOffset(Offset = "0x60")]
	public Vector4 regionFrom;

	[Token(Token = "0x40057A1")]
	[FieldOffset(Offset = "0x70")]
	public Vector4 regionTo;

	[Token(Token = "0x40057A2")]
	[FieldOffset(Offset = "0x80")]
	private UIPanel mPanel;

	[Token(Token = "0x17000F07")]
	public UIPanel cachedPanel
	{
		[Token(Token = "0x6007960")]
		[Address(RVA = "0x1D5C8D0", Offset = "0x1D5C8D0", VA = "0x1D5C8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F08")]
	public Vector2 valueOffset
	{
		[Token(Token = "0x6007961")]
		[Address(RVA = "0x1D5C9B8", Offset = "0x1D5C9B8", VA = "0x1D5C9B8")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6007962")]
		[Address(RVA = "0x1D5C9F4", Offset = "0x1D5C9F4", VA = "0x1D5C9F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000F09")]
	public Vector4 valueRegion
	{
		[Token(Token = "0x6007963")]
		[Address(RVA = "0x1D5CA30", Offset = "0x1D5CA30", VA = "0x1D5CA30")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6007964")]
		[Address(RVA = "0x1D5CA6C", Offset = "0x1D5CA6C", VA = "0x1D5CA6C")]
		set
		{
		}
	}

	[Token(Token = "0x600795F")]
	[Address(RVA = "0x1D5C8C8", Offset = "0x1D5C8C8", VA = "0x1D5C8C8")]
	public TweenClippedPanel()
	{
	}

	[Token(Token = "0x6007965")]
	[Address(RVA = "0x1D5CAC0", Offset = "0x1D5CAC0", VA = "0x1D5CAC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007966")]
	[Address(RVA = "0x1D5CB48", Offset = "0x1D5CB48", VA = "0x1D5CB48", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6007967")]
	[Address(RVA = "0x1D5CC64", Offset = "0x1D5CC64", VA = "0x1D5CC64", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x6007968")]
	[Address(RVA = "0x1D5CCB0", Offset = "0x1D5CCB0", VA = "0x1D5CCB0", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x6007969")]
	[Address(RVA = "0x1D5CCFC", Offset = "0x1D5CCFC", VA = "0x1D5CCFC")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x600796A")]
	[Address(RVA = "0x1D5CD38", Offset = "0x1D5CD38", VA = "0x1D5CD38")]
	private void SetCurrentValueToEnd()
	{
	}
}
