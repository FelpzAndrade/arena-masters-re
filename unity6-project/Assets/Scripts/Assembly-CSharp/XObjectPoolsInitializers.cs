using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200063F")]
public class XObjectPoolsInitializers : MonoBehaviour
{
	[Token(Token = "0x4001E13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject CharacterParent;

	[Token(Token = "0x4001E14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject EffectParent;

	[Token(Token = "0x4001E15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject MapObjectParent;

	[Token(Token = "0x4001E16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject DropObjectParent;

	[Token(Token = "0x4001E17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject SkillParent;

	[Token(Token = "0x4001E18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject InterfaceParent;

	[Token(Token = "0x4001E19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject EtcParent;

	[Token(Token = "0x4001E1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static XObjectPoolsInitializers Instance;

	[Token(Token = "0x4001E1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Action<GameObject> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x60035B1")]
	[Address(RVA = "0x168E684", Offset = "0x168E684", VA = "0x168E684")]
	public XObjectPoolsInitializers()
	{
	}

	[Token(Token = "0x60035B3")]
	[Address(RVA = "0x168E690", Offset = "0x168E690", VA = "0x168E690")]
	private void Awake()
	{
	}

	[Token(Token = "0x60035B4")]
	[Address(RVA = "0x168E840", Offset = "0x168E840", VA = "0x168E840")]
	private void InitializeObjectPools()
	{
	}

	[Token(Token = "0x60035B5")]
	[Address(RVA = "0x168EDC4", Offset = "0x168EDC4", VA = "0x168EDC4")]
	public XObjectPool NewObjectPool(GameObject goParent, [Optional] Action<GameObject> initAction)
	{
		return null;
	}

	[Token(Token = "0x60035B6")]
	[Address(RVA = "0x168EE5C", Offset = "0x168EE5C", VA = "0x168EE5C")]
	private static void _003CInitializeObjectPools_003Em__179(GameObject go)
	{
	}
}
