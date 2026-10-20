using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E6")]
[ExecuteInEditMode]
public class XUIRotatableGroup : MonoBehaviour
{
	[Token(Token = "0x20006E7")]
	private enum State
	{
		[Token(Token = "0x400210D")]
		None = 0,
		[Token(Token = "0x400210E")]
		Rotating = 1,
		[Token(Token = "0x400210F")]
		Dragging = 2
	}

	[Token(Token = "0x40020FE")]
	[FieldOffset(Offset = "0xC")]
	public List<XUIRotatableGroupElement> Elements;

	[Token(Token = "0x40020FF")]
	[FieldOffset(Offset = "0x10")]
	public float Radius;

	[Token(Token = "0x4002100")]
	[FieldOffset(Offset = "0x14")]
	public float RotateDuration;

	[Token(Token = "0x4002101")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve AnimationCurve;

	[Token(Token = "0x4002102")]
	[FieldOffset(Offset = "0x1C")]
	public float DragSensitivity;

	[Token(Token = "0x4002103")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_Pivot;

	[Token(Token = "0x4002104")]
	[FieldOffset(Offset = "0x24")]
	private float m_AngleStep;

	[Token(Token = "0x4002105")]
	[FieldOffset(Offset = "0x28")]
	private int m_Index;

	[Token(Token = "0x4002106")]
	[FieldOffset(Offset = "0x2C")]
	private State m_State;

	[Token(Token = "0x4002107")]
	[FieldOffset(Offset = "0x30")]
	private float m_StartAngle;

	[Token(Token = "0x4002108")]
	[FieldOffset(Offset = "0x34")]
	private float m_TargetAngle;

	[Token(Token = "0x4002109")]
	[FieldOffset(Offset = "0x38")]
	private float m_AngleMagnitude;

	[Token(Token = "0x400210A")]
	[FieldOffset(Offset = "0x3C")]
	private float m_TimeElapsed;

	[Token(Token = "0x400210B")]
	[FieldOffset(Offset = "0x40")]
	private float m_rotateDuration;

	[Token(Token = "0x60039C0")]
	[Address(RVA = "0x191EFAC", Offset = "0x191EFAC", VA = "0x191EFAC")]
	public XUIRotatableGroup()
	{
	}

	[Token(Token = "0x60039C1")]
	[Address(RVA = "0x191F078", Offset = "0x191F078", VA = "0x191F078")]
	public void Init()
	{
	}

	[Token(Token = "0x60039C2")]
	[Address(RVA = "0x191F794", Offset = "0x191F794", VA = "0x191F794")]
	public void InitElements()
	{
	}

	[Token(Token = "0x60039C3")]
	[Address(RVA = "0x191F8B8", Offset = "0x191F8B8", VA = "0x191F8B8")]
	public void PlaceToFront(XUIRotatableGroupElement element)
	{
	}

	[Token(Token = "0x60039C4")]
	[Address(RVA = "0x191FA84", Offset = "0x191FA84", VA = "0x191FA84")]
	private void placeToFront(int targetIndex)
	{
	}

	[Token(Token = "0x60039C5")]
	[Address(RVA = "0x191FDCC", Offset = "0x191FDCC", VA = "0x191FDCC")]
	private void Start()
	{
	}

	[Token(Token = "0x60039C6")]
	[Address(RVA = "0x191FDD0", Offset = "0x191FDD0", VA = "0x191FDD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60039C7")]
	[Address(RVA = "0x191F8E0", Offset = "0x191F8E0", VA = "0x191F8E0")]
	private int getIndexOf(XUIRotatableGroupElement element)
	{
		return default(int);
	}

	[Token(Token = "0x60039C8")]
	[Address(RVA = "0x191FBBC", Offset = "0x191FBBC", VA = "0x191FBBC")]
	private void setRotation(int targetIndex, float angleMagnitude, float rotateDuration)
	{
	}

	[Token(Token = "0x60039C9")]
	[Address(RVA = "0x191FDF8", Offset = "0x191FDF8", VA = "0x191FDF8")]
	private void updateRotation()
	{
	}

	[Token(Token = "0x60039CA")]
	[Address(RVA = "0x191F270", Offset = "0x191F270", VA = "0x191F270")]
	private void refreshGroup()
	{
	}

	[Token(Token = "0x60039CB")]
	[Address(RVA = "0x191F590", Offset = "0x191F590", VA = "0x191F590")]
	private void arrageElements()
	{
	}

	[Token(Token = "0x60039CC")]
	[Address(RVA = "0x191FFD4", Offset = "0x191FFD4", VA = "0x191FFD4")]
	private void resetElementsAngle()
	{
	}

	[Token(Token = "0x60039CD")]
	[Address(RVA = "0x1920108", Offset = "0x1920108", VA = "0x1920108")]
	private int getClosestIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60039CE")]
	[Address(RVA = "0x1920204", Offset = "0x1920204", VA = "0x1920204")]
	public void OnDragStart()
	{
	}

	[Token(Token = "0x60039CF")]
	[Address(RVA = "0x1920210", Offset = "0x1920210", VA = "0x1920210")]
	public void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60039D0")]
	[Address(RVA = "0x19202BC", Offset = "0x19202BC", VA = "0x19202BC")]
	public void OnDragEnd()
	{
	}
}
