using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024B")]
public class TweenOrthoSize : UITweener
{
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x50")]
	public float from;

	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0x54")]
	public float to;

	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x58")]
	private Camera mCam;

	[Token(Token = "0x17000301")]
	public Camera cachedCamera
	{
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x1D5E528", Offset = "0x1D5E528", VA = "0x1D5E528")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000302")]
	public float orthoSize
	{
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x1D5E610", Offset = "0x1D5E610", VA = "0x1D5E610")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x1D5E640", Offset = "0x1D5E640", VA = "0x1D5E640")]
		set
		{
		}
	}

	[Token(Token = "0x17000303")]
	public float value
	{
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x1D5E614", Offset = "0x1D5E614", VA = "0x1D5E614")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x1D5E644", Offset = "0x1D5E644", VA = "0x1D5E644")]
		set
		{
		}
	}

	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x1D5E514", Offset = "0x1D5E514", VA = "0x1D5E514")]
	public TweenOrthoSize()
	{
	}

	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x1D5E678", Offset = "0x1D5E678", VA = "0x1D5E678", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x1D5E6A0", Offset = "0x1D5E6A0", VA = "0x1D5E6A0")]
	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x1D5E7A0", Offset = "0x1D5E7A0", VA = "0x1D5E7A0", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x1D5E7B8", Offset = "0x1D5E7B8", VA = "0x1D5E7B8", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}
}
