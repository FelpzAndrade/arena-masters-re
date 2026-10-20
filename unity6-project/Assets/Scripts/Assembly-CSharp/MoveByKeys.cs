using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x2000305")]
public class MoveByKeys : Photon.MonoBehaviour
{
	[Token(Token = "0x400100B")]
	[FieldOffset(Offset = "0x10")]
	public float Speed;

	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0x14")]
	public float JumpForce;

	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x18")]
	public float JumpTimeout;

	[Token(Token = "0x400100E")]
	[FieldOffset(Offset = "0x1C")]
	private bool isSprite;

	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0x20")]
	private float jumpingTime;

	[Token(Token = "0x4001010")]
	[FieldOffset(Offset = "0x24")]
	private Rigidbody body;

	[Token(Token = "0x4001011")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D body2d;

	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x135C824", Offset = "0x135C824", VA = "0x135C824")]
	public MoveByKeys()
	{
	}

	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x135C848", Offset = "0x135C848", VA = "0x135C848")]
	public void Start()
	{
	}

	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x135C958", Offset = "0x135C958", VA = "0x135C958")]
	public void FixedUpdate()
	{
	}
}
