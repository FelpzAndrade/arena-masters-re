using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200023A")]
[ExecuteInEditMode]
public class UISnapshotPoint : MonoBehaviour
{
	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0xC")]
	public bool isOrthographic;

	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x10")]
	public float nearClip;

	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x14")]
	public float farClip;

	[Token(Token = "0x40009C6")]
	[FieldOffset(Offset = "0x18")]
	public int fieldOfView;

	[Token(Token = "0x40009C7")]
	[FieldOffset(Offset = "0x1C")]
	public float orthoSize;

	[Token(Token = "0x40009C8")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D thumbnail;

	[Token(Token = "0x600132E")]
	[Address(RVA = "0x179C688", Offset = "0x179C688", VA = "0x179C688")]
	public UISnapshotPoint()
	{
	}

	[Token(Token = "0x600132F")]
	[Address(RVA = "0x179C6C4", Offset = "0x179C6C4", VA = "0x179C6C4")]
	private void Start()
	{
	}
}
