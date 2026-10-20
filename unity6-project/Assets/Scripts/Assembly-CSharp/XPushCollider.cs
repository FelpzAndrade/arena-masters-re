using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200040A")]
public class XPushCollider : MonoBehaviour
{
	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0xC")]
	public CapsuleCollider capsuleCollider;

	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x10")]
	public GameObject owner;

	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0x14")]
	private Action<CharacterController> m_pushAction;

	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject pusher;

	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x1C959FC", Offset = "0x1C959FC", VA = "0x1C959FC")]
	public XPushCollider()
	{
	}

	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x1C95A04", Offset = "0x1C95A04", VA = "0x1C95A04")]
	private void Awake()
	{
	}

	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x1C95A8C", Offset = "0x1C95A8C", VA = "0x1C95A8C")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60020F3")]
	[Address(RVA = "0x1C95C14", Offset = "0x1C95C14", VA = "0x1C95C14")]
	public void RegisterPushAction(GameObject pusher, Action<CharacterController> pushAction)
	{
	}
}
