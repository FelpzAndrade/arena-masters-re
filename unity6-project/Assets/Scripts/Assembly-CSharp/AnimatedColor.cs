using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000242")]
[ExecuteInEditMode]
public class AnimatedColor : MonoBehaviour
{
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0xC")]
	public Color color;

	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x1C")]
	private UIWidget mWidget;

	[Token(Token = "0x6001389")]
	[Address(RVA = "0x20BC068", Offset = "0x20BC068", VA = "0x20BC068")]
	public AnimatedColor()
	{
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x20BC0B0", Offset = "0x20BC0B0", VA = "0x20BC0B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600138B")]
	[Address(RVA = "0x20BC140", Offset = "0x20BC140", VA = "0x20BC140")]
	private void LateUpdate()
	{
	}
}
