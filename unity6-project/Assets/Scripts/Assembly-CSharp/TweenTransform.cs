using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024F")]
public class TweenTransform : UITweener
{
	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x50")]
	public Transform from;

	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x54")]
	public Transform to;

	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x58")]
	public bool parentWhenFinished;

	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x5C")]
	private Transform mTrans;

	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 mPos;

	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x6C")]
	private Quaternion mRot;

	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 mScale;

	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x1D5FB70", Offset = "0x1D5FB70", VA = "0x1D5FB70")]
	public TweenTransform()
	{
	}

	[Token(Token = "0x60013FF")]
	[Address(RVA = "0x1D5FB78", Offset = "0x1D5FB78", VA = "0x1D5FB78", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6001400")]
	[Address(RVA = "0x1D601F8", Offset = "0x1D601F8", VA = "0x1D601F8")]
	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
		return null;
	}

	[Token(Token = "0x6001401")]
	[Address(RVA = "0x1D60218", Offset = "0x1D60218", VA = "0x1D60218")]
	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
		return null;
	}
}
