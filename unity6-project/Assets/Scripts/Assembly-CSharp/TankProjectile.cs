using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200034F")]
public class TankProjectile : MonoBehaviour
{
	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0xC")]
	public float Speed;

	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x10")]
	public float Lifetime;

	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0x1D4A858", Offset = "0x1D4A858", VA = "0x1D4A858")]
	public TankProjectile()
	{
	}

	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x1D4A860", Offset = "0x1D4A860", VA = "0x1D4A860")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x1D4A8EC", Offset = "0x1D4A8EC", VA = "0x1D4A8EC")]
	private void DestroySelf()
	{
	}

	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x1D4A9A4", Offset = "0x1D4A9A4", VA = "0x1D4A9A4")]
	private void Update()
	{
	}
}
