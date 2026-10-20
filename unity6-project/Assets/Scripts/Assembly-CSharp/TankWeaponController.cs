using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000351")]
public class TankWeaponController : MonoBehaviour
{
	[Token(Token = "0x400116B")]
	[FieldOffset(Offset = "0xC")]
	public TankProjectile ProjectilePrefab;

	[Token(Token = "0x400116C")]
	[FieldOffset(Offset = "0x10")]
	public Transform Nozzle;

	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x1D4ADA0", Offset = "0x1D4ADA0", VA = "0x1D4ADA0")]
	public TankWeaponController()
	{
	}

	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x1D4ADA8", Offset = "0x1D4ADA8", VA = "0x1D4ADA8")]
	private void Update()
	{
	}
}
