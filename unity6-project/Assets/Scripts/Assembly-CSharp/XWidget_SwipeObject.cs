using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CA4")]
public class XWidget_SwipeObject : MonoBehaviour
{
	[Token(Token = "0x400405F")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder goBuilder;

	[Token(Token = "0x4004060")]
	[FieldOffset(Offset = "0x10")]
	public UIScrollView imageScrollView;

	[Token(Token = "0x4004061")]
	[FieldOffset(Offset = "0x14")]
	private List<GameObject> objectList;

	[Token(Token = "0x4004062")]
	[FieldOffset(Offset = "0x18")]
	public UICenterOnChild centerOnChild;

	[Token(Token = "0x4004063")]
	[FieldOffset(Offset = "0x1C")]
	public UIWrapContent wrapContent;

	[Token(Token = "0x4004064")]
	[FieldOffset(Offset = "0x20")]
	private Action<int> swipeFinishDelegate;

	[Token(Token = "0x4004065")]
	[FieldOffset(Offset = "0x24")]
	private int Index__BackingField;

	[Token(Token = "0x17000CC8")]
	public int Index
	{
		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0x1B12804", Offset = "0x1B12804", VA = "0x1B12804")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005B4F")]
		[Address(RVA = "0x1B1280C", Offset = "0x1B1280C", VA = "0x1B1280C")]
		private set
		{
		}
	}

	[Token(Token = "0x6005B4D")]
	[Address(RVA = "0x1B12758", Offset = "0x1B12758", VA = "0x1B12758")]
	public XWidget_SwipeObject()
	{
	}

	[Token(Token = "0x6005B50")]
	[Address(RVA = "0x1B12814", Offset = "0x1B12814", VA = "0x1B12814")]
	public void RegisterswipeFinishDelegate(Action<int> swipeFinishDelegate)
	{
	}

	[Token(Token = "0x6005B51")]
	[Address(RVA = "0x1B1281C", Offset = "0x1B1281C", VA = "0x1B1281C")]
	public void Init(int buildCount, Action<int, GameObject> buildAction)
	{
	}

	[Token(Token = "0x6005B52")]
	[Address(RVA = "0x1B12D2C", Offset = "0x1B12D2C", VA = "0x1B12D2C")]
	private void OnDragFinish(GameObject go)
	{
	}

	[Token(Token = "0x6005B53")]
	[Address(RVA = "0x1B12BEC", Offset = "0x1B12BEC", VA = "0x1B12BEC")]
	private void SwipeImage(int index, bool isClick)
	{
	}

	[Token(Token = "0x6005B54")]
	[Address(RVA = "0x1B12E94", Offset = "0x1B12E94", VA = "0x1B12E94")]
	public void OnClick_Prev()
	{
	}

	[Token(Token = "0x6005B55")]
	[Address(RVA = "0x1B12F80", Offset = "0x1B12F80", VA = "0x1B12F80")]
	public void OnClick_Next()
	{
	}

	[Token(Token = "0x6005B56")]
	[Address(RVA = "0x1B1306C", Offset = "0x1B1306C", VA = "0x1B1306C")]
	public void ItemHide()
	{
	}
}
