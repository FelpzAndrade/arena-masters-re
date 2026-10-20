using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C74")]
public class XWidget_DragDrop : UIDragDropItem
{
	[Token(Token = "0x4003F30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Transform m_originParent;

	[Token(Token = "0x4003F31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 m_originVector;

	[Token(Token = "0x4003F32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Action m_dropFailDelegate;

	[Token(Token = "0x4003F33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject m_dragOBJ;

	[Token(Token = "0x4003F34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool dragEndCombackPos;

	[Token(Token = "0x4003F35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float dragScrollAngle;

	[Token(Token = "0x4003F36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Action<object> m_onDragStart;

	[Token(Token = "0x60059E0")]
	[Address(RVA = "0x15F0EE8", Offset = "0x15F0EE8", VA = "0x15F0EE8")]
	public XWidget_DragDrop()
	{
	}

	[Token(Token = "0x60059E1")]
	[Address(RVA = "0x15CAD90", Offset = "0x15CAD90", VA = "0x15CAD90")]
	public void Build(GameObject dragObject, [Optional] Action dropFailDelegate, [Optional] Action<object> onDragStart)
	{
	}

	[Token(Token = "0x60059E2")]
	[Address(RVA = "0x15CB064", Offset = "0x15CB064", VA = "0x15CB064")]
	public void RegistDropFailDelegate(Action dropFailDelegate)
	{
	}

	[Token(Token = "0x60059E3")]
	[Address(RVA = "0x15F0FA0", Offset = "0x15F0FA0", VA = "0x15F0FA0", Slot = "10")]
	protected override void OnDragStart()
	{
	}

	[Token(Token = "0x60059E4")]
	[Address(RVA = "0x15F1200", Offset = "0x15F1200", VA = "0x15F1200", Slot = "11")]
	public override void StartDragging()
	{
	}

	[Token(Token = "0x60059E5")]
	[Address(RVA = "0x15F1668", Offset = "0x15F1668", VA = "0x15F1668", Slot = "18")]
	protected override void OnDragDropEnd()
	{
	}

	[Token(Token = "0x60059E6")]
	[Address(RVA = "0x15F1714", Offset = "0x15F1714", VA = "0x15F1714", Slot = "17")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}
}
