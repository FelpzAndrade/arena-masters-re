using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000175")]
public class ScrollingUVs_Layers : MonoBehaviour
{
	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 uvAnimationRate;

	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x14")]
	public string textureName;

	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 uvOffset;

	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x20EF67C", Offset = "0x20EF67C", VA = "0x20EF67C")]
	public ScrollingUVs_Layers()
	{
	}

	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x20EF758", Offset = "0x20EF758", VA = "0x20EF758")]
	private void LateUpdate()
	{
	}
}
