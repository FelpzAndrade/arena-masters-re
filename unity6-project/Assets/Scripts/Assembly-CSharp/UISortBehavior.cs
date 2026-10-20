using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000176")]
public class UISortBehavior : MonoBehaviour
{
	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0xC")]
	public ParticleSystem particleSystem;

	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x10")]
	public UIWidget widgetBehindOfMe;

	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x179C7C0", Offset = "0x179C7C0", VA = "0x179C7C0")]
	public UISortBehavior()
	{
	}

	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x179C7C8", Offset = "0x179C7C8", VA = "0x179C7C8")]
	private void LateUpdate()
	{
	}
}
