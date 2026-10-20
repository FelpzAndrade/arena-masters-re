using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C27")]
public class XWidget_TutorialNotification : MonoBehaviour
{
	[Token(Token = "0x4003D78")]
	[FieldOffset(Offset = "0xC")]
	protected Action m_nextCallBack;

	[Token(Token = "0x4003D79")]
	[FieldOffset(Offset = "0x10")]
	public List<Transform> targetObjects;

	[Token(Token = "0x4003D7A")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_Builder arrowBuilder;

	[Token(Token = "0x4003D7B")]
	[FieldOffset(Offset = "0x18")]
	public float ShowNotiTime;

	[Token(Token = "0x4003D7C")]
	[FieldOffset(Offset = "0x1C")]
	private float m_elaspedTime;

	[Token(Token = "0x4003D7D")]
	[FieldOffset(Offset = "0x20")]
	private bool useNoti;

	[Token(Token = "0x60057F6")]
	[Address(RVA = "0x1B30ED8", Offset = "0x1B30ED8", VA = "0x1B30ED8")]
	public XWidget_TutorialNotification()
	{
	}

	[Token(Token = "0x60057F7")]
	[Address(RVA = "0x1B30F90", Offset = "0x1B30F90", VA = "0x1B30F90")]
	public void Show(TutorialNotificationData data, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057F8")]
	[Address(RVA = "0x1B311DC", Offset = "0x1B311DC", VA = "0x1B311DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60057F9")]
	[Address(RVA = "0x1B311A8", Offset = "0x1B311A8", VA = "0x1B311A8")]
	public void Show()
	{
	}

	[Token(Token = "0x60057FA")]
	[Address(RVA = "0x1B31248", Offset = "0x1B31248", VA = "0x1B31248")]
	public void Hide()
	{
	}

	[Token(Token = "0x60057FB")]
	[Address(RVA = "0x1B3127C", Offset = "0x1B3127C", VA = "0x1B3127C")]
	public void HideArrows()
	{
	}
}
