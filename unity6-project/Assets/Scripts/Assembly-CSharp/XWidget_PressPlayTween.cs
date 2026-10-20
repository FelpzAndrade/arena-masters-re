using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C91")]
public class XWidget_PressPlayTween : MonoBehaviour
{
	[Token(Token = "0x4003FEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject playTarget;

	[Token(Token = "0x4003FED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private UITweener[] m_tweeners;

	[Token(Token = "0x4003FEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private bool m_bPress;

	[Token(Token = "0x4003FEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool includeChildren;

	[Token(Token = "0x6005ABD")]
	[Address(RVA = "0x131EDA4", Offset = "0x131EDA4", VA = "0x131EDA4")]
	public XWidget_PressPlayTween()
	{
	}

	[Token(Token = "0x6005ABE")]
	[Address(RVA = "0x131EDB4", Offset = "0x131EDB4", VA = "0x131EDB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005ABF")]
	[Address(RVA = "0x131EEE8", Offset = "0x131EEE8", VA = "0x131EEE8")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6005AC0")]
	[Address(RVA = "0x131EF34", Offset = "0x131EF34", VA = "0x131EF34")]
	public void OnPress(bool press)
	{
	}

	[Token(Token = "0x6005AC1")]
	[Address(RVA = "0x131EDB8", Offset = "0x131EDB8", VA = "0x131EDB8")]
	public void SetTweeners()
	{
	}

	[Token(Token = "0x6005AC2")]
	[Address(RVA = "0x131EFE8", Offset = "0x131EFE8", VA = "0x131EFE8")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005AC3")]
	[Address(RVA = "0x131EF9C", Offset = "0x131EF9C", VA = "0x131EF9C")]
	public void Show([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6005AC4")]
	[Address(RVA = "0x131EF24", Offset = "0x131EF24", VA = "0x131EF24")]
	public void ResetTween()
	{
	}
}
