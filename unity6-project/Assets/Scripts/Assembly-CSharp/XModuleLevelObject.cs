using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLevel;

[Token(Token = "0x200046E")]
public class XModuleLevelObject : XModuleBase
{
	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0x10")]
	public LevelObjectData dataEntity;

	[Token(Token = "0x400161E")]
	[FieldOffset(Offset = "0x14")]
	public List<int> targetKGTriggers;

	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0x18")]
	public List<int> targetCombatTriggers;

	[Token(Token = "0x4001620")]
	[FieldOffset(Offset = "0x1C")]
	public Action<XModuleLevelObject, ModuleEventArgument_Hit> onDie;

	[Token(Token = "0x4001621")]
	[FieldOffset(Offset = "0x20")]
	public Action<XModuleLevelObject, ModuleEventArgument_Hit> onHitMe;

	[Token(Token = "0x4001622")]
	[FieldOffset(Offset = "0x24")]
	public Action<XModuleLevelObject, XSkill> onSkillStart;

	[Token(Token = "0x4001623")]
	[FieldOffset(Offset = "0x28")]
	public Action<XModuleLevelObject, XSkill> onSkillFinish;

	[Token(Token = "0x4001624")]
	[FieldOffset(Offset = "0x2C")]
	public Action<XModuleLevelObject> onDespawn;

	[Token(Token = "0x4001625")]
	[FieldOffset(Offset = "0x30")]
	public Action<XModuleLevelObject> ontoBattle;

	[Token(Token = "0x4001626")]
	[FieldOffset(Offset = "0x34")]
	public ushort groupUID;

	[Token(Token = "0x4001627")]
	[FieldOffset(Offset = "0x38")]
	public ActorType actorType;

	[Token(Token = "0x4001628")]
	[FieldOffset(Offset = "0x3C")]
	public int mapObjectHp;

	[Token(Token = "0x4001629")]
	[FieldOffset(Offset = "0x40")]
	public XModuleAction followTarget;

	[Token(Token = "0x400162A")]
	[FieldOffset(Offset = "0x44")]
	public bool followWayPoint;

	[Token(Token = "0x400162B")]
	[FieldOffset(Offset = "0x48")]
	public Tendency tendency;

	[Token(Token = "0x400162C")]
	[FieldOffset(Offset = "0x4C")]
	private XLevelObjectEventReciever m_reciever;

	[Token(Token = "0x600251A")]
	[Address(RVA = "0xB68C58", Offset = "0xB68C58", VA = "0xB68C58")]
	public XModuleLevelObject()
	{
	}

	[Token(Token = "0x600251B")]
	[Address(RVA = "0xB68D24", Offset = "0xB68D24", VA = "0xB68D24", Slot = "18")]
	public override void OnAfterActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x600251C")]
	[Address(RVA = "0xB54014", Offset = "0xB54014", VA = "0xB54014")]
	public void OnHitMapObject(Collider col)
	{
	}

	[Token(Token = "0x600251D")]
	[Address(RVA = "0xB692A0", Offset = "0xB692A0", VA = "0xB692A0")]
	private bool IgnoreCheck_MapObjectHitted(ModuleEventArgument_Hit arg, XModuleAttackInfo attackInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600251E")]
	[Address(RVA = "0xB693CC", Offset = "0xB693CC", VA = "0xB693CC", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x600251F")]
	[Address(RVA = "0xB69554", Offset = "0xB69554", VA = "0xB69554", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x6002520")]
	[Address(RVA = "0xB69634", Offset = "0xB69634", VA = "0xB69634", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0xB69738", Offset = "0xB69738", VA = "0xB69738")]
	public void Despawn()
	{
	}

	[Token(Token = "0x6002522")]
	[Address(RVA = "0xB697C8", Offset = "0xB697C8", VA = "0xB697C8", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002523")]
	[Address(RVA = "0xB69860", Offset = "0xB69860", VA = "0xB69860", Slot = "48")]
	public override void OnOntoBattle()
	{
	}

	[Token(Token = "0x6002524")]
	[Address(RVA = "0xB698F0", Offset = "0xB698F0", VA = "0xB698F0", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x6002525")]
	[Address(RVA = "0xB699F4", Offset = "0xB699F4", VA = "0xB699F4", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x6002526")]
	[Address(RVA = "0xB69A8C", Offset = "0xB69A8C", VA = "0xB69A8C", Slot = "30")]
	public override void OnSkillFinished(XSkill skill)
	{
	}
}
