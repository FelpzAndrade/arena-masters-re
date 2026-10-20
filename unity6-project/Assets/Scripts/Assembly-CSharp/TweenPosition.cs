using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024C")]
public class TweenPosition : UITweener
{
	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 from;

	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 to;

	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool worldSpace;

	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0x6C")]
	private Transform mTrans;

	[Token(Token = "0x4000A29")]
	[FieldOffset(Offset = "0x70")]
	private UIRect mRect;

	[Token(Token = "0x17000304")]
	public Transform cachedTransform
	{
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x1D5E7D8", Offset = "0x1D5E7D8", VA = "0x1D5E7D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000305")]
	public Vector3 position
	{
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x1D5E8A8", Offset = "0x1D5E8A8", VA = "0x1D5E8A8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x1D5E940", Offset = "0x1D5E940", VA = "0x1D5E940")]
		set
		{
		}
	}

	[Token(Token = "0x17000306")]
	public Vector3 value
	{
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x1D5E8B8", Offset = "0x1D5E8B8", VA = "0x1D5E8B8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x1D5E958", Offset = "0x1D5E958", VA = "0x1D5E958")]
		set
		{
		}
	}

	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x1D5E7D0", Offset = "0x1D5E7D0", VA = "0x1D5E7D0")]
	public TweenPosition()
	{
	}

	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x1D5EB0C", Offset = "0x1D5EB0C", VA = "0x1D5EB0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x1D5EB94", Offset = "0x1D5EB94", VA = "0x1D5EB94", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x1D5EC34", Offset = "0x1D5EC34", VA = "0x1D5EC34")]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x1D5ED50", Offset = "0x1D5ED50", VA = "0x1D5ED50")]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
	{
		return null;
	}

	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x1D5EE74", Offset = "0x1D5EE74", VA = "0x1D5EE74", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x1D5EEA8", Offset = "0x1D5EEA8", VA = "0x1D5EEA8", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x1D5EEDC", Offset = "0x1D5EEDC", VA = "0x1D5EEDC")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x1D5EEFC", Offset = "0x1D5EEFC", VA = "0x1D5EEFC")]
	private void SetCurrentValueToEnd()
	{
	}
}
