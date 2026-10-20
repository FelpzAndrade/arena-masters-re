using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200101D")]
public class XUIButtonPress : MonoBehaviour
{
	[Token(Token = "0x4005652")]
	[FieldOffset(Offset = "0xC")]
	private bool isTime;

	[Token(Token = "0x4005653")]
	[FieldOffset(Offset = "0xD")]
	private bool isPressed;

	[Token(Token = "0x4005654")]
	[FieldOffset(Offset = "0x10")]
	private Action m_Action;

	[Token(Token = "0x4005655")]
	[FieldOffset(Offset = "0x14")]
	private bool isDelay;

	[Token(Token = "0x4005656")]
	[FieldOffset(Offset = "0x18")]
	private float deltaTime;

	[Token(Token = "0x4005657")]
	[FieldOffset(Offset = "0x1C")]
	private float pressDelay;

	[Token(Token = "0x6007829")]
	[Address(RVA = "0x1A2E9A0", Offset = "0x1A2E9A0", VA = "0x1A2E9A0")]
	public XUIButtonPress()
	{
	}

	[Token(Token = "0x600782A")]
	[Address(RVA = "0x1A2E9B4", Offset = "0x1A2E9B4", VA = "0x1A2E9B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600782B")]
	[Address(RVA = "0x1A2EA40", Offset = "0x1A2EA40", VA = "0x1A2EA40")]
	private void OnPress(bool Pressed)
	{
	}

	[Token(Token = "0x600782C")]
	[Address(RVA = "0x1A2EA7C", Offset = "0x1A2EA7C", VA = "0x1A2EA7C")]
	private void OnRelease()
	{
	}

	[Token(Token = "0x600782D")]
	[Address(RVA = "0x1A2EA94", Offset = "0x1A2EA94", VA = "0x1A2EA94")]
	public void SetPressAction(Action onAction)
	{
	}
}
