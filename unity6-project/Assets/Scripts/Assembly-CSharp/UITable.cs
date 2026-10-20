using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001FB")]
public class UITable : UIWidgetContainer
{
	[Token(Token = "0x20001FC")]
	public enum Direction
	{
		[Token(Token = "0x4000849")]
		Down = 0,
		[Token(Token = "0x400084A")]
		Up = 1
	}

	[Token(Token = "0x20001FD")]
	public enum Sorting
	{
		[Token(Token = "0x400084C")]
		None = 0,
		[Token(Token = "0x400084D")]
		Alphabetic = 1,
		[Token(Token = "0x400084E")]
		Horizontal = 2,
		[Token(Token = "0x400084F")]
		Vertical = 3,
		[Token(Token = "0x4000850")]
		Custom = 4
	}

	[Token(Token = "0x20001FE")]
	public delegate void OnReposition();

	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0xC")]
	public int columns;

	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x10")]
	public Direction direction;

	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x14")]
	public Sorting sorting;

	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget.Pivot cellAlignment;

	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x20")]
	public bool hideInactive;

	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x21")]
	public bool keepWithinPanel;

	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 padding;

	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x2C")]
	public OnReposition onReposition;

	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x30")]
	public Comparison<Transform> onCustomSort;

	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x34")]
	protected UIPanel mPanel;

	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0x38")]
	protected bool mInitDone;

	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0x39")]
	protected bool mReposition;

	[Token(Token = "0x17000281")]
	public bool repositionNow
	{
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x17A1D4C", Offset = "0x17A1D4C", VA = "0x17A1D4C")]
		set
		{
		}
	}

	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x17A1D08", Offset = "0x17A1D08", VA = "0x17A1D08")]
	public UITable()
	{
	}

	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x17A1D68", Offset = "0x17A1D68", VA = "0x17A1D68")]
	public List<Transform> GetChildList()
	{
		return null;
	}

	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x17A217C", Offset = "0x17A217C", VA = "0x17A217C", Slot = "4")]
	protected virtual void Sort(List<Transform> list)
	{
	}

	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x17A226C", Offset = "0x17A226C", VA = "0x17A226C", Slot = "5")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x17A22E4", Offset = "0x17A22E4", VA = "0x17A22E4", Slot = "6")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x17A23C0", Offset = "0x17A23C0", VA = "0x17A23C0", Slot = "7")]
	protected virtual void LateUpdate()
	{
	}

	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x17A2418", Offset = "0x17A2418", VA = "0x17A2418")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x17A2514", Offset = "0x17A2514", VA = "0x17A2514")]
	protected void RepositionVariableSize(List<Transform> children)
	{
	}

	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x17A312C", Offset = "0x17A312C", VA = "0x17A312C", Slot = "8")]
	public virtual void Reposition()
	{
	}
}
