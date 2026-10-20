using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x20002FE")]
public class HighlightOwnedGameObj : Photon.MonoBehaviour
{
	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x10")]
	public GameObject PointerPrefab;

	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x14")]
	public float Offset;

	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x18")]
	private Transform markerTransform;

	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x1F52BC4", Offset = "0x1F52BC4", VA = "0x1F52BC4")]
	public HighlightOwnedGameObj()
	{
	}

	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x1F52BD4", Offset = "0x1F52BD4", VA = "0x1F52BD4")]
	private void Update()
	{
	}
}
