using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F63")]
public class XUITitleSlotItem : MonoBehaviour
{
	[Token(Token = "0x40050D6")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x40050D7")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x40050D8")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprLock;

	[Token(Token = "0x40050D9")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprArrow;

	[Token(Token = "0x40050DA")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition arrowTween;

	[Token(Token = "0x40050DB")]
	[FieldOffset(Offset = "0x20")]
	private RelicInfo selObject;

	[Token(Token = "0x40050DC")]
	[FieldOffset(Offset = "0x24")]
	public int m_index;

	[Token(Token = "0x40050DD")]
	[FieldOffset(Offset = "0x28")]
	public Action<int> selSlotIndex;

	[Token(Token = "0x40050DE")]
	[FieldOffset(Offset = "0x2C")]
	public Action setSlotAction;

	[Token(Token = "0x40050DF")]
	[FieldOffset(Offset = "0x30")]
	public Action buyAction;

	[Token(Token = "0x40050E0")]
	[FieldOffset(Offset = "0x34")]
	public Action<int> changeSlot;

	[Token(Token = "0x40050E1")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblLevel;

	[Token(Token = "0x6007258")]
	[Address(RVA = "0x1939068", Offset = "0x1939068", VA = "0x1939068")]
	public XUITitleSlotItem()
	{
	}

	[Token(Token = "0x6007259")]
	[Address(RVA = "0x1939078", Offset = "0x1939078", VA = "0x1939078")]
	public void Build(Action<int> selSlot, Action slotAction, Action slotBuy)
	{
	}

	[Token(Token = "0x600725A")]
	[Address(RVA = "0x19393E8", Offset = "0x19393E8", VA = "0x19393E8")]
	public void ChangeAction(Action<int> actionChange)
	{
	}

	[Token(Token = "0x600725B")]
	[Address(RVA = "0x1939084", Offset = "0x1939084", VA = "0x1939084")]
	public void InItItem()
	{
	}

	[Token(Token = "0x600725C")]
	[Address(RVA = "0x19393F0", Offset = "0x19393F0", VA = "0x19393F0")]
	public void RefreshSlotItem(int index)
	{
	}

	[Token(Token = "0x600725D")]
	[Address(RVA = "0x1939928", Offset = "0x1939928", VA = "0x1939928")]
	public void RefreshArrow(bool state)
	{
	}

	[Token(Token = "0x600725E")]
	[Address(RVA = "0x1939AC8", Offset = "0x1939AC8", VA = "0x1939AC8")]
	public void OnClick()
	{
	}

	[Token(Token = "0x600725F")]
	[Address(RVA = "0x1939CE4", Offset = "0x1939CE4", VA = "0x1939CE4")]
	public void SettingObject(RelicInfo obj)
	{
	}

	[Token(Token = "0x6007260")]
	[Address(RVA = "0x1939CEC", Offset = "0x1939CEC", VA = "0x1939CEC")]
	public GameObject SlotGameObject()
	{
		return null;
	}
}
