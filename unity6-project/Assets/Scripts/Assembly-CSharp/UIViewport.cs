using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000295")]
[ExecuteInEditMode]
public class UIViewport : MonoBehaviour
{
	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0xC")]
	public Camera sourceCamera;

	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x10")]
	public Transform topLeft;

	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x14")]
	public Transform bottomRight;

	[Token(Token = "0x4000C66")]
	[FieldOffset(Offset = "0x18")]
	public float fullSize;

	[Token(Token = "0x4000C67")]
	[FieldOffset(Offset = "0x1C")]
	private Camera mCam;

	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x17AB000", Offset = "0x17AB000", VA = "0x17AB000")]
	public UIViewport()
	{
	}

	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x17AB010", Offset = "0x17AB010", VA = "0x17AB010")]
	private void Start()
	{
	}

	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x17AB0F4", Offset = "0x17AB0F4", VA = "0x17AB0F4")]
	private void LateUpdate()
	{
	}
}
