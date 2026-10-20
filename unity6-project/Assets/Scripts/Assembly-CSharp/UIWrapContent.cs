using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000204")]
public class UIWrapContent : MonoBehaviour
{
	[Token(Token = "0x2000205")]
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0xC")]
	public int itemSize;

	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x10")]
	public bool cullContent;

	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x14")]
	public int minIndex;

	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x18")]
	public int maxIndex;

	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x1C")]
	public bool hideInactive;

	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x20")]
	public OnInitializeItem onInitializeItem;

	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x24")]
	protected Transform mTrans;

	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x28")]
	protected UIPanel mPanel;

	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x2C")]
	protected UIScrollView mScroll;

	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x30")]
	protected bool mHorizontal;

	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x31")]
	protected bool mFirstTime;

	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x34")]
	protected List<Transform> mChildren;

	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x17AF908", Offset = "0x17AF908", VA = "0x17AF908")]
	public UIWrapContent()
	{
	}

	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x17AF9C8", Offset = "0x17AF9C8", VA = "0x17AF9C8", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x17AFB58", Offset = "0x17AFB58", VA = "0x17AFB58", Slot = "5")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x17AFB9C", Offset = "0x17AFB9C", VA = "0x17AFB9C", Slot = "6")]
	public virtual void SortBasedOnScrollMovement()
	{
	}

	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x17AFFD0", Offset = "0x17AFFD0", VA = "0x17AFFD0", Slot = "7")]
	public virtual void SortAlphabetically()
	{
	}

	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x17AFE2C", Offset = "0x17AFE2C", VA = "0x17AFE2C")]
	protected bool CacheScrollView()
	{
		return default(bool);
	}

	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x17B01EC", Offset = "0x17B01EC", VA = "0x17B01EC", Slot = "8")]
	protected virtual void ResetChildPositions()
	{
	}

	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x17B03B4", Offset = "0x17B03B4", VA = "0x17B03B4", Slot = "9")]
	public virtual void WrapContent()
	{
	}

	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x17B0EA8", Offset = "0x17B0EA8", VA = "0x17B0EA8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x17B0EC8", Offset = "0x17B0EC8", VA = "0x17B0EC8", Slot = "10")]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}
}
