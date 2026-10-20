using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CA3")]
public class XWidget_SwipeImage : MonoBehaviour
{
	[Token(Token = "0x4004058")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder imageBuilder;

	[Token(Token = "0x4004059")]
	[FieldOffset(Offset = "0x10")]
	public UIScrollView imageScrollView;

	[Token(Token = "0x400405A")]
	[FieldOffset(Offset = "0x14")]
	private List<UI2DSprite> imageList;

	[Token(Token = "0x400405B")]
	[FieldOffset(Offset = "0x18")]
	public UICenterOnChild centerOnChild;

	[Token(Token = "0x400405C")]
	[FieldOffset(Offset = "0x1C")]
	public UIWrapContent wrapContent;

	[Token(Token = "0x400405D")]
	[FieldOffset(Offset = "0x20")]
	private Action<int> swipeFinishDelegate;

	[Token(Token = "0x400405E")]
	[FieldOffset(Offset = "0x24")]
	private int Index__BackingField;

	[Token(Token = "0x17000CC7")]
	public int Index
	{
		[Token(Token = "0x6005B44")]
		[Address(RVA = "0x1B11A84", Offset = "0x1B11A84", VA = "0x1B11A84")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005B45")]
		[Address(RVA = "0x1B11A8C", Offset = "0x1B11A8C", VA = "0x1B11A8C")]
		private set
		{
		}
	}

	[Token(Token = "0x6005B43")]
	[Address(RVA = "0x1B119D8", Offset = "0x1B119D8", VA = "0x1B119D8")]
	public XWidget_SwipeImage()
	{
	}

	[Token(Token = "0x6005B46")]
	[Address(RVA = "0x1B11A94", Offset = "0x1B11A94", VA = "0x1B11A94")]
	public void RegisterswipeFinishDelegate(Action<int> swipeFinishDelegate)
	{
	}

	[Token(Token = "0x6005B47")]
	[Address(RVA = "0x1B11A9C", Offset = "0x1B11A9C", VA = "0x1B11A9C")]
	public void Init(List<string> spriteKeyList)
	{
	}

	[Token(Token = "0x6005B48")]
	[Address(RVA = "0x1B12190", Offset = "0x1B12190", VA = "0x1B12190")]
	private void OnDragFinish(GameObject go)
	{
	}

	[Token(Token = "0x6005B49")]
	[Address(RVA = "0x1B1204C", Offset = "0x1B1204C", VA = "0x1B1204C")]
	private void SwipeImage(int index, bool isClick)
	{
	}

	[Token(Token = "0x6005B4A")]
	[Address(RVA = "0x1B12328", Offset = "0x1B12328", VA = "0x1B12328")]
	public void OnClick_Prev()
	{
	}

	[Token(Token = "0x6005B4B")]
	[Address(RVA = "0x1B12414", Offset = "0x1B12414", VA = "0x1B12414")]
	public void OnClick_Next()
	{
	}

	[Token(Token = "0x6005B4C")]
	[Address(RVA = "0x1B12500", Offset = "0x1B12500", VA = "0x1B12500")]
	public void ItemHide()
	{
	}
}
