using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D3")]
public class UIDragResize : MonoBehaviour
{
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget target;

	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x10")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x14")]
	public int minWidth;

	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x18")]
	public int minHeight;

	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x1C")]
	public int maxWidth;

	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x20")]
	public int maxHeight;

	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x24")]
	public bool updateAnchors;

	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x28")]
	private Plane mPlane;

	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 mRayPos;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 mLocalPos;

	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x50")]
	private int mWidth;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x54")]
	private int mHeight;

	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x58")]
	private bool mDragging;

	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x16E474C", Offset = "0x16E474C", VA = "0x16E474C")]
	public UIDragResize()
	{
	}

	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x16E4778", Offset = "0x16E4778", VA = "0x16E4778")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x16E4A58", Offset = "0x16E4A58", VA = "0x16E4A58")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x16E4DEC", Offset = "0x16E4DEC", VA = "0x16E4DEC")]
	private void OnDragEnd()
	{
	}
}
