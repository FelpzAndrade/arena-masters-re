using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001CE")]
public class UIDragDropItem : MonoBehaviour
{
	[Token(Token = "0x20001CF")]
	public enum Restriction
	{
		[Token(Token = "0x40006DC")]
		None = 0,
		[Token(Token = "0x40006DD")]
		Horizontal = 1,
		[Token(Token = "0x40006DE")]
		Vertical = 2,
		[Token(Token = "0x40006DF")]
		PressAndHold = 3
	}

	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0xC")]
	public Restriction restriction;

	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x10")]
	public bool cloneOnDrag;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public float pressAndHoldDelay;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x18")]
	public bool interactable;

	[NonSerialized]
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x1C")]
	protected Transform mTrans;

	[NonSerialized]
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x20")]
	protected Transform mParent;

	[NonSerialized]
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x24")]
	protected Collider mCollider;

	[NonSerialized]
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x28")]
	protected Collider2D mCollider2D;

	[NonSerialized]
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x2C")]
	protected UIButton mButton;

	[NonSerialized]
	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x30")]
	protected UIRoot mRoot;

	[NonSerialized]
	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0x34")]
	protected UIGrid mGrid;

	[NonSerialized]
	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x38")]
	protected UITable mTable;

	[NonSerialized]
	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x3C")]
	protected float mDragStartTime;

	[NonSerialized]
	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x40")]
	protected UIDragScrollView mDragScrollView;

	[NonSerialized]
	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x44")]
	protected bool mPressed;

	[NonSerialized]
	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x45")]
	protected bool mDragging;

	[NonSerialized]
	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x48")]
	protected UICamera.MouseOrTouch mTouch;

	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x0")]
	public static List<UIDragDropItem> draggedItems;

	[Token(Token = "0x6000F52")]
	[Address(RVA = "0x16DF4F0", Offset = "0x16DF4F0", VA = "0x16DF4F0")]
	public UIDragDropItem()
	{
	}

	[Token(Token = "0x6000F54")]
	[Address(RVA = "0x16DF5B8", Offset = "0x16DF5B8", VA = "0x16DF5B8", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000F55")]
	[Address(RVA = "0x16DF6A4", Offset = "0x16DF6A4", VA = "0x16DF6A4", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x16DF6A8", Offset = "0x16DF6A8", VA = "0x16DF6A8", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x16DF7BC", Offset = "0x16DF7BC", VA = "0x16DF7BC", Slot = "7")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x16DF860", Offset = "0x16DF860", VA = "0x16DF860", Slot = "8")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x16DFA38", Offset = "0x16DFA38", VA = "0x16DFA38", Slot = "9")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x16DFAD0", Offset = "0x16DFAD0", VA = "0x16DFAD0", Slot = "10")]
	protected virtual void OnDragStart()
	{
	}

	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x16DFCE4", Offset = "0x16DFCE4", VA = "0x16DFCE4", Slot = "11")]
	public virtual void StartDragging()
	{
	}

	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x16E0310", Offset = "0x16E0310", VA = "0x16E0310", Slot = "12")]
	protected virtual void OnClone(GameObject original)
	{
	}

	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x16E0314", Offset = "0x16E0314", VA = "0x16E0314", Slot = "13")]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x16E0520", Offset = "0x16E0520", VA = "0x16E0520", Slot = "14")]
	protected virtual void OnDragEnd()
	{
	}

	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x16DF75C", Offset = "0x16DF75C", VA = "0x16DF75C")]
	public void StopDragging(GameObject go)
	{
	}

	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x16E0630", Offset = "0x16E0630", VA = "0x16E0630", Slot = "15")]
	protected virtual void OnDragDropStart()
	{
	}

	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x16E0D3C", Offset = "0x16E0D3C", VA = "0x16E0D3C", Slot = "16")]
	protected virtual void OnDragDropMove(Vector2 delta)
	{
	}

	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x16E0DE0", Offset = "0x16E0DE0", VA = "0x16E0DE0", Slot = "17")]
	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x16E1464", Offset = "0x16E1464", VA = "0x16E1464", Slot = "18")]
	protected virtual void OnDragDropEnd()
	{
	}

	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x16E1550", Offset = "0x16E1550", VA = "0x16E1550")]
	protected void EnableDragScrollView()
	{
	}
}
