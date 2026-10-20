using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AE")]
public class LagRotation : MonoBehaviour
{
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0xC")]
	public float speed;

	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x10")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x14")]
	private Transform mTrans;

	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x18")]
	private Quaternion mRelative;

	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x28")]
	private Quaternion mAbsolute;

	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0xDD4C44", Offset = "0xDD4C44", VA = "0xDD4C44")]
	public LagRotation()
	{
	}

	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0xDD4C58", Offset = "0xDD4C58", VA = "0xDD4C58")]
	public void OnRepositionEnd()
	{
	}

	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0xDD4C64", Offset = "0xDD4C64", VA = "0xDD4C64")]
	private void Interpolate(float delta)
	{
	}

	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0xDD4E80", Offset = "0xDD4E80", VA = "0xDD4E80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0xDD4F04", Offset = "0xDD4F04", VA = "0xDD4F04")]
	private void Update()
	{
	}
}
