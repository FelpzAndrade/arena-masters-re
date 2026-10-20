using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C03")]
public class XTrapPierceMove : MonoBehaviour
{
	[Token(Token = "0x4003CBA")]
	private const float m_fIdleTime = 0.7f;

	[Token(Token = "0x4003CBB")]
	private const float m_fUpTime = 1.5f;

	[Token(Token = "0x4003CBC")]
	private const float m_fDownTime = 1.5f;

	[Token(Token = "0x4003CBD")]
	[FieldOffset(Offset = "0xC")]
	private eTrapState m_trapState;

	[Token(Token = "0x4003CBE")]
	[FieldOffset(Offset = "0x10")]
	private float m_fElapsedTime;

	[Token(Token = "0x4003CBF")]
	[FieldOffset(Offset = "0x14")]
	private BoxCollider m_boxCollider;

	[Token(Token = "0x60056E5")]
	[Address(RVA = "0x184AEE8", Offset = "0x184AEE8", VA = "0x184AEE8")]
	public XTrapPierceMove()
	{
	}

	[Token(Token = "0x60056E6")]
	[Address(RVA = "0x184AEF0", Offset = "0x184AEF0", VA = "0x184AEF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60056E7")]
	[Address(RVA = "0x184AFCC", Offset = "0x184AFCC", VA = "0x184AFCC")]
	private void Update()
	{
	}
}
