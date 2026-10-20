using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004FA")]
public class XSpectatorController
{
	[Token(Token = "0x4001931")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_cameraTr;

	[Token(Token = "0x4001932")]
	[FieldOffset(Offset = "0xC")]
	private Vector3[] m_colliderVertices;

	[Token(Token = "0x4001933")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 m_originPos;

	[Token(Token = "0x4001934")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 dragOrigin;

	[Token(Token = "0x4001935")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 vOldPos;

	[Token(Token = "0x4001936")]
	[FieldOffset(Offset = "0x30")]
	private float oldDistance;

	[Token(Token = "0x4001937")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isFree;

	[Token(Token = "0x6002AFC")]
	[Address(RVA = "0x182CC88", Offset = "0x182CC88", VA = "0x182CC88")]
	public XSpectatorController(Transform cameraTr, BoxCollider collider)
	{
	}

	[Token(Token = "0x6002AFD")]
	[Address(RVA = "0x182D4D0", Offset = "0x182D4D0", VA = "0x182D4D0")]
	public void SetFreeMove(bool isFree)
	{
	}

	[Token(Token = "0x6002AFE")]
	[Address(RVA = "0x182D4D8", Offset = "0x182D4D8", VA = "0x182D4D8")]
	public void HandleObserverMove()
	{
	}

	[Token(Token = "0x6002AFF")]
	[Address(RVA = "0x182D8B8", Offset = "0x182D8B8", VA = "0x182D8B8")]
	private void ForceMoveForStuck()
	{
	}

	[Token(Token = "0x6002B00")]
	[Address(RVA = "0x182D50C", Offset = "0x182D50C", VA = "0x182D50C")]
	private void KeyboardMove()
	{
	}

	[Token(Token = "0x6002B01")]
	[Address(RVA = "0x182DBB4", Offset = "0x182DBB4", VA = "0x182DBB4")]
	private Vector3 HandleKeaboardMoveInput(KeyCode code, Vector3 dir)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002B02")]
	[Address(RVA = "0x182D898", Offset = "0x182D898", VA = "0x182D898")]
	private void MouseMove()
	{
	}

	[Token(Token = "0x6002B03")]
	[Address(RVA = "0x182E024", Offset = "0x182E024", VA = "0x182E024")]
	private void MouseDragMove()
	{
	}

	[Token(Token = "0x6002B04")]
	[Address(RVA = "0x182E5B8", Offset = "0x182E5B8", VA = "0x182E5B8")]
	private void MouseScrollMove()
	{
	}

	[Token(Token = "0x6002B05")]
	[Address(RVA = "0x182D89C", Offset = "0x182D89C", VA = "0x182D89C")]
	private void TouchMove()
	{
	}

	[Token(Token = "0x6002B06")]
	[Address(RVA = "0x182E7F8", Offset = "0x182E7F8", VA = "0x182E7F8")]
	private void TouchSwipeMove()
	{
	}

	[Token(Token = "0x6002B07")]
	[Address(RVA = "0x182EB58", Offset = "0x182EB58", VA = "0x182EB58")]
	private void TouchZoomMove()
	{
	}

	[Token(Token = "0x6002B08")]
	[Address(RVA = "0x182DC08", Offset = "0x182DC08", VA = "0x182DC08")]
	private void Move(Vector3 vMove)
	{
	}

	[Token(Token = "0x6002B09")]
	[Address(RVA = "0x182EEFC", Offset = "0x182EEFC", VA = "0x182EEFC")]
	private Vector3 MakeSlidingMove(Vector3 vPos, Vector3 boundVec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002B0A")]
	[Address(RVA = "0x182DAB0", Offset = "0x182DAB0", VA = "0x182DAB0")]
	private bool CheckBound(Vector3 vPos, out int boundIndex)
	{
		boundIndex = default;
		return default(bool);
	}

	[Token(Token = "0x6002B0B")]
	[Address(RVA = "0x182F090", Offset = "0x182F090", VA = "0x182F090")]
	private bool isLeft(Vector3 a, Vector3 b, Vector3 c)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B0C")]
	[Address(RVA = "0x182CE30", Offset = "0x182CE30", VA = "0x182CE30")]
	private Vector3[] GetBoxColliderBound(BoxCollider col)
	{
		return null;
	}

	[Token(Token = "0x6002B0D")]
	[Address(RVA = "0x182F168", Offset = "0x182F168", VA = "0x182F168")]
	private Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
	{
		return default(Vector3);
	}
}
