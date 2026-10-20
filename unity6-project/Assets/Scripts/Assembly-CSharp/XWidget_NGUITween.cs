using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C8A")]
public class XWidget_NGUITween : MonoBehaviour
{
	[Token(Token = "0x4003FD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private UITweener[] m_tweeners;

	[Token(Token = "0x4003FD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Action m_onComplete;

	[Token(Token = "0x4003FD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float m_oncompleteDuration;

	[Token(Token = "0x4003FDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_hideOnComplete;

	[Token(Token = "0x4003FDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool includeChildren;

	[Token(Token = "0x6005A9A")]
	[Address(RVA = "0x1301648", Offset = "0x1301648", VA = "0x1301648")]
	public XWidget_NGUITween()
	{
	}

	[Token(Token = "0x6005A9B")]
	[Address(RVA = "0x1301658", Offset = "0x1301658", VA = "0x1301658")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005A9C")]
	[Address(RVA = "0x130165C", Offset = "0x130165C", VA = "0x130165C")]
	public void RefreshTweeners()
	{
	}

	[Token(Token = "0x6005A9D")]
	[Address(RVA = "0x1301868", Offset = "0x1301868", VA = "0x1301868")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005A9E")]
	[Address(RVA = "0x130189C", Offset = "0x130189C", VA = "0x130189C")]
	public void Show([Optional] Action onComplete, bool hideOnComplete = true)
	{
	}

	[Token(Token = "0x6005A9F")]
	[Address(RVA = "0x1301904", Offset = "0x1301904", VA = "0x1301904")]
	public void ResetTween()
	{
	}

	[Token(Token = "0x6005AA0")]
	[Address(RVA = "0x1301914", Offset = "0x1301914", VA = "0x1301914")]
	private void OnComplete()
	{
	}
}
