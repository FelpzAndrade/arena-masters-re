using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001048")]
public class TrueParallax : MonoBehaviour
{
	[Token(Token = "0x40057C5")]
	private const float _lerpFactor = 0.4f;

	[Token(Token = "0x40057C6")]
	[FieldOffset(Offset = "0xC")]
	public float Speed;

	[Token(Token = "0x40057C7")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 MaxOffset;

	[Token(Token = "0x40057C8")]
	[FieldOffset(Offset = "0x0")]
	public static bool UseGyroscope;

	[Token(Token = "0x40057C9")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 _defaultAcceleration;

	[Token(Token = "0x40057CA")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 _maxPosition;

	[Token(Token = "0x40057CB")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 _minPosition;

	[Token(Token = "0x40057CC")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 _defaultPostion;

	[Token(Token = "0x40057CD")]
	[FieldOffset(Offset = "0x4C")]
	private bool IsGyroEnabled__BackingField;

	[Token(Token = "0x17000F0A")]
	public bool IsGyroEnabled
	{
		[Token(Token = "0x6007978")]
		[Address(RVA = "0x1D57CC0", Offset = "0x1D57CC0", VA = "0x1D57CC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007979")]
		[Address(RVA = "0x1D57CC8", Offset = "0x1D57CC8", VA = "0x1D57CC8")]
		private set
		{
		}
	}

	[Token(Token = "0x6007976")]
	[Address(RVA = "0x1D57BE0", Offset = "0x1D57BE0", VA = "0x1D57BE0")]
	public TrueParallax()
	{
	}

	[Token(Token = "0x600797A")]
	[Address(RVA = "0x1D57CD0", Offset = "0x1D57CD0", VA = "0x1D57CD0")]
	private void Start()
	{
	}

	[Token(Token = "0x600797B")]
	[Address(RVA = "0x1D57FC0", Offset = "0x1D57FC0", VA = "0x1D57FC0")]
	private void Update()
	{
	}
}
