using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D8")]
public class UIGrid : UIWidgetContainer
{
	[Token(Token = "0x20001D9")]
	public enum Arrangement
	{
		[Token(Token = "0x4000740")]
		Horizontal = 0,
		[Token(Token = "0x4000741")]
		Vertical = 1,
		[Token(Token = "0x4000742")]
		CellSnap = 2
	}

	[Token(Token = "0x20001DA")]
	public enum Sorting
	{
		[Token(Token = "0x4000744")]
		None = 0,
		[Token(Token = "0x4000745")]
		Alphabetic = 1,
		[Token(Token = "0x4000746")]
		Horizontal = 2,
		[Token(Token = "0x4000747")]
		Vertical = 3,
		[Token(Token = "0x4000748")]
		Custom = 4
	}

	[Token(Token = "0x20001DB")]
	public delegate void OnReposition();

	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0xC")]
	public Arrangement arrangement;

	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x10")]
	public Sorting sorting;

	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x18")]
	public int maxPerLine;

	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x1C")]
	public float cellWidth;

	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x20")]
	public float cellHeight;

	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x24")]
	public bool animateSmoothly;

	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x25")]
	public bool hideInactive;

	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x26")]
	public bool keepWithinPanel;

	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x28")]
	public OnReposition onReposition;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x2C")]
	public Comparison<Transform> onCustomSort;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private bool sorted;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x31")]
	protected bool mReposition;

	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x34")]
	protected UIPanel mPanel;

	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x38")]
	protected bool mInitDone;

	[Token(Token = "0x17000254")]
	public bool repositionNow
	{
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x16E0D20", Offset = "0x16E0D20", VA = "0x16E0D20")]
		set
		{
		}
	}

	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x16F2FFC", Offset = "0x16F2FFC", VA = "0x16F2FFC")]
	public UIGrid()
	{
	}

	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x16D994C", Offset = "0x16D994C", VA = "0x16D994C")]
	public List<Transform> GetChildList()
	{
		return null;
	}

	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x16F3014", Offset = "0x16F3014", VA = "0x16F3014")]
	public Transform GetChild(int index)
	{
		return null;
	}

	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x16F30F4", Offset = "0x16F30F4", VA = "0x16F30F4")]
	public int GetIndex(Transform trans)
	{
		return default(int);
	}

	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x16F3198", Offset = "0x16F3198", VA = "0x16F3198")]
	public void AddChild(Transform trans)
	{
	}

	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x16F31A0", Offset = "0x16F31A0", VA = "0x16F31A0")]
	public void AddChild(Transform trans, bool sort)
	{
	}

	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x16F32CC", Offset = "0x16F32CC", VA = "0x16F32CC")]
	public bool RemoveChild(Transform t)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x16F33BC", Offset = "0x16F33BC", VA = "0x16F33BC", Slot = "4")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x16F3498", Offset = "0x16F3498", VA = "0x16F3498", Slot = "5")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x16F352C", Offset = "0x16F352C", VA = "0x16F352C", Slot = "6")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x16F3578", Offset = "0x16F3578", VA = "0x16F3578")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x16F3674", Offset = "0x16F3674", VA = "0x16F3674")]
	public static int SortByName(Transform a, Transform b)
	{
		return default(int);
	}

	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x16F3760", Offset = "0x16F3760", VA = "0x16F3760")]
	public static int SortHorizontal(Transform a, Transform b)
	{
		return default(int);
	}

	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x16F37E0", Offset = "0x16F37E0", VA = "0x16F37E0")]
	public static int SortVertical(Transform a, Transform b)
	{
		return default(int);
	}

	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x16F3868", Offset = "0x16F3868", VA = "0x16F3868", Slot = "7")]
	protected virtual void Sort(List<Transform> list)
	{
	}

	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x16F386C", Offset = "0x16F386C", VA = "0x16F386C", Slot = "8")]
	public virtual void Reposition()
	{
	}

	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x16F3A3C", Offset = "0x16F3A3C", VA = "0x16F3A3C")]
	public void ConstrainWithinPanel()
	{
	}

	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x16F3C70", Offset = "0x16F3C70", VA = "0x16F3C70", Slot = "9")]
	protected virtual void ResetPosition(List<Transform> list)
	{
	}
}
