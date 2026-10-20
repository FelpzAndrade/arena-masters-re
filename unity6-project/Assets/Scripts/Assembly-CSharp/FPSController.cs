using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000348")]
public class FPSController : MonoBehaviour
{
	[Token(Token = "0x400113C")]
	[FieldOffset(Offset = "0xC")]
	public Animator CamAnimator;

	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x10")]
	public Animator WeaponAnimator;

	[Token(Token = "0x400113E")]
	[FieldOffset(Offset = "0x14")]
	public float moveSpeed;

	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x1F273C4", Offset = "0x1F273C4", VA = "0x1F273C4")]
	public FPSController()
	{
	}

	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0x1F273CC", Offset = "0x1F273CC", VA = "0x1F273CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x1F273D0", Offset = "0x1F273D0", VA = "0x1F273D0")]
	private void Update()
	{
	}
}
