using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004BC")]
public class SimpleGameobjectPooler : MonoSingleton<SimpleGameobjectPooler>
{
	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0xC")]
	public Stack<GameObject> pool;

	[Token(Token = "0x400178C")]
	[FieldOffset(Offset = "0x10")]
	public Transform used;

	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x14")]
	public Transform unused;

	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_transform;

	[Token(Token = "0x60028B8")]
	[Address(RVA = "0x20F9C34", Offset = "0x20F9C34", VA = "0x20F9C34")]
	public SimpleGameobjectPooler()
	{
	}

	[Token(Token = "0x60028B9")]
	[Address(RVA = "0x20F9D24", Offset = "0x20F9D24", VA = "0x20F9D24", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x60028BA")]
	[Address(RVA = "0x20F9E98", Offset = "0x20F9E98", VA = "0x20F9E98")]
	public GameObject Pop()
	{
		return null;
	}

	[Token(Token = "0x60028BB")]
	[Address(RVA = "0x20F9FC4", Offset = "0x20F9FC4", VA = "0x20F9FC4")]
	public void Push(GameObject go)
	{
	}
}
