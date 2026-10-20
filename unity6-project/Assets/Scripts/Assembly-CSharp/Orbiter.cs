using Il2CppDummyDll;
using PigeonCoopToolkit.Effects.Trails;
using UnityEngine;

[Token(Token = "0x200034B")]
public class Orbiter : MonoBehaviour
{
	[Token(Token = "0x400114D")]
	[FieldOffset(Offset = "0xC")]
	public float TankCollisionOrbitRadius;

	[Token(Token = "0x400114E")]
	[FieldOffset(Offset = "0x10")]
	public float TankCollisionRotationSpeed;

	[Token(Token = "0x400114F")]
	[FieldOffset(Offset = "0x14")]
	public Trail Trail;

	[Token(Token = "0x4001150")]
	[FieldOffset(Offset = "0x18")]
	private TankController _tankBeingController;

	[Token(Token = "0x4001151")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 _pos;

	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x1B76E78", Offset = "0x1B76E78", VA = "0x1B76E78")]
	public Orbiter()
	{
	}

	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x1B76E90", Offset = "0x1B76E90", VA = "0x1B76E90")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x1B76EC8", Offset = "0x1B76EC8", VA = "0x1B76EC8")]
	private void Update()
	{
	}
}
