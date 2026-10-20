using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6A")]
public class XButton_OnPress : MonoBehaviour
{
	[Token(Token = "0x4004B73")]
	[FieldOffset(Offset = "0xC")]
	private bool m_isPress;

	[Token(Token = "0x4004B74")]
	[FieldOffset(Offset = "0x10")]
	private Action m_pressStartAction;

	[Token(Token = "0x4004B75")]
	[FieldOffset(Offset = "0x14")]
	private Action m_pressEndAction;

	[Token(Token = "0x4004B76")]
	[FieldOffset(Offset = "0x18")]
	private float m_pressTimer;

	[Token(Token = "0x4004B77")]
	[FieldOffset(Offset = "0x1C")]
	private float m_deltaTime;

	[Token(Token = "0x4004B78")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isStartTimer;

	[Token(Token = "0x4004B79")]
	[FieldOffset(Offset = "0x21")]
	private bool m_isWorkingPress;

	[Token(Token = "0x4004B7A")]
	[FieldOffset(Offset = "0x24")]
	private float m_delayTime;

	[Token(Token = "0x4004B7B")]
	[FieldOffset(Offset = "0x28")]
	private float m_delayDeltaTime;

	[Token(Token = "0x4004B7C")]
	[FieldOffset(Offset = "0x2C")]
	private int m_multiTouchCount;

	[Token(Token = "0x4004B7D")]
	[FieldOffset(Offset = "0x30")]
	public bool StatePress;

	[Token(Token = "0x6006B9E")]
	[Address(RVA = "0x1A99DE4", Offset = "0x1A99DE4", VA = "0x1A99DE4")]
	public XButton_OnPress()
	{
	}

	[Token(Token = "0x6006B9F")]
	[Address(RVA = "0x1A99E00", Offset = "0x1A99E00", VA = "0x1A99E00")]
	public void SetPressStartAction(Action action)
	{
	}

	[Token(Token = "0x6006BA0")]
	[Address(RVA = "0x1A99E08", Offset = "0x1A99E08", VA = "0x1A99E08")]
	public void SetPressEndAction(Action action)
	{
	}

	[Token(Token = "0x6006BA1")]
	[Address(RVA = "0x1A99E10", Offset = "0x1A99E10", VA = "0x1A99E10")]
	private void Reset()
	{
	}

	[Token(Token = "0x6006BA2")]
	[Address(RVA = "0x1A99E34", Offset = "0x1A99E34", VA = "0x1A99E34")]
	private void Update()
	{
	}

	[Token(Token = "0x6006BA3")]
	[Address(RVA = "0x1A99FA8", Offset = "0x1A99FA8", VA = "0x1A99FA8")]
	private void OnPress(bool isPress)
	{
	}
}
