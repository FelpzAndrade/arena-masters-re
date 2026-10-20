using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200034D")]
public class TankAlwaysForward : MonoBehaviour
{
	[Token(Token = "0x4001154")]
	[FieldOffset(Offset = "0xC")]
	public Material TrailMaterial;

	[Token(Token = "0x4001155")]
	[FieldOffset(Offset = "0x10")]
	public float Speed;

	[Token(Token = "0x4001156")]
	[FieldOffset(Offset = "0x14")]
	public float TrailSpeed;

	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x1D49DD0", Offset = "0x1D49DD0", VA = "0x1D49DD0")]
	public TankAlwaysForward()
	{
	}

	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x1D49DD8", Offset = "0x1D49DD8", VA = "0x1D49DD8")]
	private void FixedUpdate()
	{
	}
}
