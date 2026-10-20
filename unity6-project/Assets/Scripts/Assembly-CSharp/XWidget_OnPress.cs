using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C8D")]
public class XWidget_OnPress : MonoBehaviour
{
	[Token(Token = "0x4003FE2")]
	[FieldOffset(Offset = "0xC")]
	private Action m_onPress;

	[Token(Token = "0x4003FE3")]
	[FieldOffset(Offset = "0x10")]
	private Action m_onRelease;

	[Token(Token = "0x4003FE4")]
	[FieldOffset(Offset = "0x14")]
	private bool m_isWorking;

	[Token(Token = "0x6005AAA")]
	[Address(RVA = "0x1301C48", Offset = "0x1301C48", VA = "0x1301C48")]
	public XWidget_OnPress()
	{
	}

	[Token(Token = "0x6005AAB")]
	[Address(RVA = "0x1301C58", Offset = "0x1301C58", VA = "0x1301C58")]
	public void Init(Action onPress, Action onRelease)
	{
	}

	[Token(Token = "0x6005AAC")]
	[Address(RVA = "0x1301C64", Offset = "0x1301C64", VA = "0x1301C64")]
	public void SetWorking(bool working)
	{
	}

	[Token(Token = "0x6005AAD")]
	[Address(RVA = "0x1301C6C", Offset = "0x1301C6C", VA = "0x1301C6C")]
	private void OnPress(bool isPressed)
	{
	}
}
