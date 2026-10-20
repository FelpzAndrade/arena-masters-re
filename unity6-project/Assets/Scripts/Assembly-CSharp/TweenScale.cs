using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024E")]
public class TweenScale : UITweener
{
	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 from;

	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 to;

	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x68")]
	public bool updateTable;

	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x6C")]
	private Transform mTrans;

	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x70")]
	private UITable mTable;

	[Token(Token = "0x1700030A")]
	public Transform cachedTransform
	{
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x1D5F5D4", Offset = "0x1D5F5D4", VA = "0x1D5F5D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030B")]
	public Vector3 value
	{
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x1D5F6A4", Offset = "0x1D5F6A4", VA = "0x1D5F6A4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x1D5F6E0", Offset = "0x1D5F6E0", VA = "0x1D5F6E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700030C")]
	public Vector3 scale
	{
		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x1D5F730", Offset = "0x1D5F730", VA = "0x1D5F730")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x1D5F740", Offset = "0x1D5F740", VA = "0x1D5F740")]
		set
		{
		}
	}

	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x1D5F570", Offset = "0x1D5F570", VA = "0x1D5F570")]
	public TweenScale()
	{
	}

	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x1D5F758", Offset = "0x1D5F758", VA = "0x1D5F758", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x1D5F9AC", Offset = "0x1D5F9AC", VA = "0x1D5F9AC")]
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return null;
	}

	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x1D5FAC8", Offset = "0x1D5FAC8", VA = "0x1D5FAC8", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x1D5FAFC", Offset = "0x1D5FAFC", VA = "0x1D5FAFC", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x1D5FB30", Offset = "0x1D5FB30", VA = "0x1D5FB30")]
	private void SetCurrentValueToStart()
	{
	}

	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x1D5FB50", Offset = "0x1D5FB50", VA = "0x1D5FB50")]
	private void SetCurrentValueToEnd()
	{
	}
}
