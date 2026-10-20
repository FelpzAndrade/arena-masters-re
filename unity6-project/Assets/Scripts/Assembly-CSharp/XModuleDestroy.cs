using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000458")]
public class XModuleDestroy : XModuleBase
{
	[Token(Token = "0x4001564")]
	[FieldOffset(Offset = "0x10")]
	private float m_fElapsedTime;

	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x14")]
	private CSCharacterInfo m_CharacterInfo;

	[Token(Token = "0x4001566")]
	[FieldOffset(Offset = "0x18")]
	private bool m_bDied;

	[Token(Token = "0x4001567")]
	[FieldOffset(Offset = "0x1C")]
	private float m_fDieTime;

	[Token(Token = "0x4001568")]
	[FieldOffset(Offset = "0x20")]
	private bool m_bSetup;

	[Token(Token = "0x4001569")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_attackerPos;

	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x30")]
	private XModuleEntity m_attackerME;

	[Token(Token = "0x400156B")]
	[FieldOffset(Offset = "0x34")]
	public XInstanceType instanceType;

	[Token(Token = "0x400156C")]
	[FieldOffset(Offset = "0x38")]
	public Action OnDieComplete;

	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x3C")]
	public bool hideOnDestroy;

	[Token(Token = "0x6002401")]
	[Address(RVA = "0xB5526C", Offset = "0xB5526C", VA = "0xB5526C")]
	public XModuleDestroy()
	{
	}

	[Token(Token = "0x6002402")]
	[Address(RVA = "0xB55284", Offset = "0xB55284", VA = "0xB55284", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002403")]
	[Address(RVA = "0xB553DC", Offset = "0xB553DC", VA = "0xB553DC")]
	private void GetReady()
	{
	}

	[Token(Token = "0x6002404")]
	[Address(RVA = "0xB5540C", Offset = "0xB5540C", VA = "0xB5540C", Slot = "6")]
	public override void OnUpdate(float deltaTime)
	{
	}

	[Token(Token = "0x6002405")]
	[Address(RVA = "0xB55448", Offset = "0xB55448", VA = "0xB55448")]
	private void SetupCharacterInfo()
	{
	}

	[Token(Token = "0x6002406")]
	[Address(RVA = "0xB556A8", Offset = "0xB556A8", VA = "0xB556A8")]
	private void _UpdateKnockback(float deltaTime)
	{
	}

	[Token(Token = "0x6002407")]
	[Address(RVA = "0xB558F4", Offset = "0xB558F4", VA = "0xB558F4")]
	private void _UpdateBlinkAndDestroy()
	{
	}

	[Token(Token = "0x6002408")]
	[Address(RVA = "0xB55BB8", Offset = "0xB55BB8", VA = "0xB55BB8")]
	private void DestroyGameObject()
	{
	}

	[Token(Token = "0x6002409")]
	[Address(RVA = "0xB56028", Offset = "0xB56028", VA = "0xB56028", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x600240A")]
	[Address(RVA = "0xB560FC", Offset = "0xB560FC", VA = "0xB560FC")]
	public void Stop()
	{
	}

	[Token(Token = "0x600240B")]
	[Address(RVA = "0xB553F8", Offset = "0xB553F8", VA = "0xB553F8")]
	private void Reset()
	{
	}

	[Token(Token = "0x600240C")]
	[Address(RVA = "0xB56114", Offset = "0xB56114", VA = "0xB56114", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x600240D")]
	[Address(RVA = "0xB5612C", Offset = "0xB5612C", VA = "0xB5612C")]
	public bool DieComplete()
	{
		return default(bool);
	}
}
