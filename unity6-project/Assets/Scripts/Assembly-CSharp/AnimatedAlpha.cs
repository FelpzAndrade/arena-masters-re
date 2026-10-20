using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000241")]
[ExecuteInEditMode]
public class AnimatedAlpha : MonoBehaviour
{
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0xC")]
	public float alpha;

	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x10")]
	private UIWidget mWidget;

	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x14")]
	private UIPanel mPanel;

	[Token(Token = "0x6001386")]
	[Address(RVA = "0x20BBE00", Offset = "0x20BBE00", VA = "0x20BBE00")]
	public AnimatedAlpha()
	{
	}

	[Token(Token = "0x6001387")]
	[Address(RVA = "0x20BBE10", Offset = "0x20BBE10", VA = "0x20BBE10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001388")]
	[Address(RVA = "0x20BBEBC", Offset = "0x20BBEBC", VA = "0x20BBEBC")]
	private void LateUpdate()
	{
	}
}
