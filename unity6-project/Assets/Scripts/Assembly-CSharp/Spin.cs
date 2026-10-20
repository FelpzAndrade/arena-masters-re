using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B6")]
public class Spin : MonoBehaviour
{
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 rotationsPerSecond;

	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x18")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x1C")]
	private Rigidbody mRb;

	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x20")]
	private Transform mTrans;

	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x1D43074", Offset = "0x1D43074", VA = "0x1D43074")]
	public Spin()
	{
	}

	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x1D430D4", Offset = "0x1D430D4", VA = "0x1D430D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x1D4316C", Offset = "0x1D4316C", VA = "0x1D4316C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x1D43468", Offset = "0x1D43468", VA = "0x1D43468")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x1D4325C", Offset = "0x1D4325C", VA = "0x1D4325C")]
	public void ApplyDelta(float delta)
	{
	}
}
