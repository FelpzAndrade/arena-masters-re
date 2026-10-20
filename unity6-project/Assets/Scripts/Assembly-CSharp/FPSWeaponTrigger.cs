using Il2CppDummyDll;
using PigeonCoopToolkit.Effects.Trails;
using UnityEngine;

[Token(Token = "0x2000349")]
public class FPSWeaponTrigger : MonoBehaviour
{
	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0xC")]
	public Transform ShellEjectionTransform;

	[Token(Token = "0x4001140")]
	[FieldOffset(Offset = "0x10")]
	public float EjectionForce;

	[Token(Token = "0x4001141")]
	[FieldOffset(Offset = "0x14")]
	public Rigidbody Shell;

	[Token(Token = "0x4001142")]
	[FieldOffset(Offset = "0x18")]
	public Transform Muzzle;

	[Token(Token = "0x4001143")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Bullet;

	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x20")]
	public float SmokeAfter;

	[Token(Token = "0x4001145")]
	[FieldOffset(Offset = "0x24")]
	public float SmokeMax;

	[Token(Token = "0x4001146")]
	[FieldOffset(Offset = "0x28")]
	public float SmokeIncrement;

	[Token(Token = "0x4001147")]
	[FieldOffset(Offset = "0x2C")]
	public SmokePlume MuzzlePlume;

	[Token(Token = "0x4001148")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MuzzleFlashObject;

	[Token(Token = "0x4001149")]
	[FieldOffset(Offset = "0x34")]
	private float _smoke;

	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x1F276FC", Offset = "0x1F276FC", VA = "0x1F276FC")]
	public FPSWeaponTrigger()
	{
	}

	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0x1F27704", Offset = "0x1F27704", VA = "0x1F27704")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x1F27790", Offset = "0x1F27790", VA = "0x1F27790")]
	public void Fire()
	{
	}

	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0x1F27AE0", Offset = "0x1F27AE0", VA = "0x1F27AE0")]
	private void LightsOff()
	{
	}
}
