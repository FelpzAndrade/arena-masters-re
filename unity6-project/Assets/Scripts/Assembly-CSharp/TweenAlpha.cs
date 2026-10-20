using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000246")]
public class TweenAlpha : UITweener
{
	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x50")]
	public float from;

	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x54")]
	public float to;

	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x58")]
	private bool mCached;

	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x5C")]
	private UIRect mRect;

	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x60")]
	private Material mMat;

	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x64")]
	private SpriteRenderer mSr;

	[Token(Token = "0x170002F6")]
	public float alpha
	{
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x1D5BFF4", Offset = "0x1D5BFF4", VA = "0x1D5BFF4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600139A")]
		[Address(RVA = "0x1D5C208", Offset = "0x1D5C208", VA = "0x1D5C208")]
		set
		{
		}
	}

	[Token(Token = "0x170002F7")]
	public float value
	{
		[Token(Token = "0x600139C")]
		[Address(RVA = "0x1D5BFF8", Offset = "0x1D5BFF8", VA = "0x1D5BFF8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600139D")]
		[Address(RVA = "0x1D5C20C", Offset = "0x1D5C20C", VA = "0x1D5C20C")]
		set
		{
		}
	}

	[Token(Token = "0x6001398")]
	[Address(RVA = "0x1D5BFE0", Offset = "0x1D5BFE0", VA = "0x1D5BFE0")]
	public TweenAlpha()
	{
	}

	[Token(Token = "0x600139B")]
	[Address(RVA = "0x1D5C468", Offset = "0x1D5C468", VA = "0x1D5C468")]
	private void Cache()
	{
	}

	[Token(Token = "0x600139E")]
	[Address(RVA = "0x1D5C6BC", Offset = "0x1D5C6BC", VA = "0x1D5C6BC", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600139F")]
	[Address(RVA = "0x1D5C798", Offset = "0x1D5C798", VA = "0x1D5C798")]
	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		return null;
	}

	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x1D5C898", Offset = "0x1D5C898", VA = "0x1D5C898", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x1D5C8B0", Offset = "0x1D5C8B0", VA = "0x1D5C8B0", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}
}
