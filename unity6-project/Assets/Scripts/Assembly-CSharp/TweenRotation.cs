using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024D")]
public class TweenRotation : UITweener
{
	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 from;

	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 to;

	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x68")]
	public bool quaternionLerp;

	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x6C")]
	private Transform mTrans;

	[Token(Token = "0x17000307")]
	public Transform cachedTransform
	{
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x1D5EF24", Offset = "0x1D5EF24", VA = "0x1D5EF24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000308")]
	public Quaternion rotation
	{
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x1D5EFF4", Offset = "0x1D5EFF4", VA = "0x1D5EFF4")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x1D5F040", Offset = "0x1D5F040", VA = "0x1D5F040")]
		set
		{
		}
	}

	[Token(Token = "0x17000309")]
	public Quaternion value
	{
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x1D5F004", Offset = "0x1D5F004", VA = "0x1D5F004")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x1D5F060", Offset = "0x1D5F060", VA = "0x1D5F060")]
		set
		{
		}
	}

	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x1D5EF1C", Offset = "0x1D5EF1C", VA = "0x1D5EF1C")]
	public TweenRotation()
	{
	}

	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x1D5F0B4", Offset = "0x1D5F0B4", VA = "0x1D5F0B4", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x1D5F2A8", Offset = "0x1D5F2A8", VA = "0x1D5F2A8")]
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x1D5F418", Offset = "0x1D5F418", VA = "0x1D5F418", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x1D5F474", Offset = "0x1D5F474", VA = "0x1D5F474", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x1D5F4D0", Offset = "0x1D5F4D0", VA = "0x1D5F4D0")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x1D5F520", Offset = "0x1D5F520", VA = "0x1D5F520")]
	private void SetCurrentValueToEnd()
	{
	}
}
