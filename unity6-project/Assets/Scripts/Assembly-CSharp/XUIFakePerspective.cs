using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E2")]
public class XUIFakePerspective : MonoBehaviour
{
	[Token(Token = "0x40020DE")]
	[FieldOffset(Offset = "0xC")]
	public float PositionZero;

	[Token(Token = "0x40020DF")]
	[FieldOffset(Offset = "0x10")]
	public float ScaleRate;

	[Token(Token = "0x40020E0")]
	[FieldOffset(Offset = "0x14")]
	public bool Transparentizing;

	[Token(Token = "0x40020E1")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 scaleOrigin;

	[Token(Token = "0x40020E2")]
	[FieldOffset(Offset = "0x24")]
	private UIPanel panel;

	[Token(Token = "0x60039A0")]
	[Address(RVA = "0x1A43538", Offset = "0x1A43538", VA = "0x1A43538")]
	public XUIFakePerspective()
	{
	}

	[Token(Token = "0x60039A1")]
	[Address(RVA = "0x1A43560", Offset = "0x1A43560", VA = "0x1A43560")]
	private void Start()
	{
	}

	[Token(Token = "0x60039A2")]
	[Address(RVA = "0x1A43688", Offset = "0x1A43688", VA = "0x1A43688")]
	private void Update()
	{
	}
}
