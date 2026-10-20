using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000243")]
[ExecuteInEditMode]
public class AnimatedWidget : MonoBehaviour
{
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0xC")]
	public float width;

	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x10")]
	public float height;

	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x14")]
	private UIWidget mWidget;

	[Token(Token = "0x600138C")]
	[Address(RVA = "0x20BC184", Offset = "0x20BC184", VA = "0x20BC184")]
	public AnimatedWidget()
	{
	}

	[Token(Token = "0x600138D")]
	[Address(RVA = "0x20BC198", Offset = "0x20BC198", VA = "0x20BC198")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600138E")]
	[Address(RVA = "0x20BC228", Offset = "0x20BC228", VA = "0x20BC228")]
	private void LateUpdate()
	{
	}
}
