using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000249")]
public class TweenFill : UITweener
{
	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0x50")]
	public float from;

	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x54")]
	public float to;

	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0x58")]
	private bool mCached;

	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x5C")]
	private UIBasicSprite mSprite;

	[Token(Token = "0x170002FD")]
	public float value
	{
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x1D5D888", Offset = "0x1D5D888", VA = "0x1D5D888")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x1D5D988", Offset = "0x1D5D988", VA = "0x1D5D988")]
		set
		{
		}
	}

	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x1D5D7E4", Offset = "0x1D5D7E4", VA = "0x1D5D7E4")]
	public TweenFill()
	{
	}

	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x1D5D7F8", Offset = "0x1D5D7F8", VA = "0x1D5D7F8")]
	private void Cache()
	{
	}

	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x1D5DB40", Offset = "0x1D5DB40", VA = "0x1D5DB40", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x1D5DC1C", Offset = "0x1D5DC1C", VA = "0x1D5DC1C")]
	public static TweenFill Begin(GameObject go, float duration, float fill)
	{
		return null;
	}

	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x1D5DD1C", Offset = "0x1D5DD1C", VA = "0x1D5DD1C", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x1D5DD34", Offset = "0x1D5DD34", VA = "0x1D5DD34", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}
}
