using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000248")]
public class TweenFOV : UITweener
{
	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x50")]
	public float from;

	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x54")]
	public float to;

	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x58")]
	private Camera mCam;

	[Token(Token = "0x170002FA")]
	public Camera cachedCamera
	{
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x1D5DD64", Offset = "0x1D5DD64", VA = "0x1D5DD64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FB")]
	public float fov
	{
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x1D5DE4C", Offset = "0x1D5DE4C", VA = "0x1D5DE4C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x1D5DE7C", Offset = "0x1D5DE7C", VA = "0x1D5DE7C")]
		set
		{
		}
	}

	[Token(Token = "0x170002FC")]
	public float value
	{
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x1D5DE50", Offset = "0x1D5DE50", VA = "0x1D5DE50")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x1D5DE80", Offset = "0x1D5DE80", VA = "0x1D5DE80")]
		set
		{
		}
	}

	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x1D5DD4C", Offset = "0x1D5DD4C", VA = "0x1D5DD4C")]
	public TweenFOV()
	{
	}

	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x1D5DEB4", Offset = "0x1D5DEB4", VA = "0x1D5DEB4", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x1D5DEDC", Offset = "0x1D5DEDC", VA = "0x1D5DEDC")]
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x1D5DFDC", Offset = "0x1D5DFDC", VA = "0x1D5DFDC", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x1D5DFF4", Offset = "0x1D5DFF4", VA = "0x1D5DFF4", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x1D5E00C", Offset = "0x1D5E00C", VA = "0x1D5E00C")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x1D5E014", Offset = "0x1D5E014", VA = "0x1D5E014")]
	private void SetCurrentValueToEnd()
	{
	}
}
