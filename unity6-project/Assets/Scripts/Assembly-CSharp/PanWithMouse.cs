using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B2")]
public class PanWithMouse : MonoBehaviour
{
	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 degrees;

	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x14")]
	public float range;

	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x18")]
	private Transform mTrans;

	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x1C")]
	private Quaternion mStart;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 mRot;

	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x1B7F648", Offset = "0x1B7F648", VA = "0x1B7F648")]
	public PanWithMouse()
	{
	}

	[Token(Token = "0x6000ECB")]
	[Address(RVA = "0x1B7F6C0", Offset = "0x1B7F6C0", VA = "0x1B7F6C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0x1B7F71C", Offset = "0x1B7F71C", VA = "0x1B7F71C")]
	private void Update()
	{
	}
}
