using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200045E")]
public class XModuleEntity : MonoBehaviour
{
	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0xC")]
	public List<XModuleBase> modules;

	[Token(Token = "0x4001589")]
	[FieldOffset(Offset = "0x10")]
	public XModuleAction action;

	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x14")]
	public XModuleAnimation anim;

	[Token(Token = "0x400158B")]
	[FieldOffset(Offset = "0x18")]
	public XModuleBuff buff;

	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x1C")]
	public XModuleCollision collision;

	[Token(Token = "0x400158D")]
	[FieldOffset(Offset = "0x20")]
	public XModuleDestroy destroy;

	[Token(Token = "0x400158E")]
	[FieldOffset(Offset = "0x24")]
	public XModuleEffect effect;

	[Token(Token = "0x400158F")]
	[FieldOffset(Offset = "0x28")]
	public XModuleActor actor;

	[Token(Token = "0x4001590")]
	[FieldOffset(Offset = "0x2C")]
	public XModuleHit hit;

	[Token(Token = "0x4001591")]
	[FieldOffset(Offset = "0x30")]
	public XModuleInterface ui;

	[Token(Token = "0x4001592")]
	[FieldOffset(Offset = "0x34")]
	public XModuleMesh mesh;

	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x38")]
	public XModuleMyControl control;

	[Token(Token = "0x4001594")]
	[FieldOffset(Offset = "0x3C")]
	public XModuleNetControl netControl;

	[Token(Token = "0x4001595")]
	[FieldOffset(Offset = "0x40")]
	public XModuleSkill skill;

	[Token(Token = "0x4001596")]
	[FieldOffset(Offset = "0x44")]
	public XModuleTarget target;

	[Token(Token = "0x4001597")]
	[FieldOffset(Offset = "0x48")]
	public XModuleLobbyUI lobbyUI;

	[Token(Token = "0x4001598")]
	[FieldOffset(Offset = "0x4C")]
	public XModuleSound sound;

	[Token(Token = "0x4001599")]
	[FieldOffset(Offset = "0x50")]
	public XModuleLevelObject levelObject;

	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x54")]
	public XModuleBT behavierTree;

	[Token(Token = "0x400159B")]
	[FieldOffset(Offset = "0x58")]
	public XModuleTeam team;

	[Token(Token = "0x400159C")]
	[FieldOffset(Offset = "0x5C")]
	public XModuleMeter meter;

	[Token(Token = "0x400159D")]
	[FieldOffset(Offset = "0x60")]
	public XModuleAttackInfo attackInfo;

	[Token(Token = "0x400159E")]
	[FieldOffset(Offset = "0x64")]
	public XModuleMyEffect myEffect;

	[Token(Token = "0x400159F")]
	[FieldOffset(Offset = "0x68")]
	public XModuleCharacterController characterController;

	[Token(Token = "0x40015A0")]
	[FieldOffset(Offset = "0x6C")]
	public XModuleDropObject dropObject;

	[Token(Token = "0x40015A1")]
	[FieldOffset(Offset = "0x70")]
	public XModuleRevive headStone;

	[Token(Token = "0x40015A2")]
	[FieldOffset(Offset = "0x74")]
	public XModulePet myModulePet;

	[Token(Token = "0x40015A3")]
	[FieldOffset(Offset = "0x78")]
	public new Transform transform;

	[Token(Token = "0x40015A4")]
	[FieldOffset(Offset = "0x7C")]
	public new GameObject gameObject;

	[Token(Token = "0x40015A5")]
	[FieldOffset(Offset = "0x80")]
	public GameObject HeadStoneTrigger;

	[Token(Token = "0x6002443")]
	[Address(RVA = "0xB5B568", Offset = "0xB5B568", VA = "0xB5B568")]
	public XModuleEntity()
	{
	}

	[Token(Token = "0x6002444")]
	[Address(RVA = "0xB5B614", Offset = "0xB5B614", VA = "0xB5B614")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002445")]
	[Address(RVA = "0xB5B618", Offset = "0xB5B618", VA = "0xB5B618")]
	public void CacheTransform()
	{
	}

	[Token(Token = "0x6002446")]
	[Address(RVA = "0xB38938", Offset = "0xB38938", VA = "0xB38938")]
	public void SetActiveHeadStoneTrigger(bool isActive)
	{
	}

	[Token(Token = "0x6002447")]
	[Address(RVA = "0xB5B6C0", Offset = "0xB5B6C0", VA = "0xB5B6C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002448")]
	[Address(RVA = "0xB5B804", Offset = "0xB5B804", VA = "0xB5B804")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002449")]
	[Address(RVA = "0xB5B948", Offset = "0xB5B948", VA = "0xB5B948")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600244A")]
	[Address(RVA = "0xB5BA8C", Offset = "0xB5BA8C", VA = "0xB5BA8C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600244B")]
	[Address(RVA = "0xB5BBC0", Offset = "0xB5BBC0", VA = "0xB5BBC0")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600244C")]
	[Address(RVA = "0xB5BCF4", Offset = "0xB5BCF4", VA = "0xB5BCF4")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x600244D")]
	[Address(RVA = "0xB5BE28", Offset = "0xB5BE28", VA = "0xB5BE28")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600244E")]
	[Address(RVA = "0xB5BF5C", Offset = "0xB5BF5C", VA = "0xB5BF5C")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600244F")]
	[Address(RVA = "0xB5C090", Offset = "0xB5C090", VA = "0xB5C090")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002450")]
	[Address(RVA = "0xB5C1C0", Offset = "0xB5C1C0", VA = "0xB5C1C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002451")]
	public void Set<T>(XModuleBase c) where T : XModuleBase
	{
	}

	[Token(Token = "0x6002452")]
	private void SetImpl<T>(XModuleBase other, ref T mine) where T : XModuleBase
	{
	}

	[Token(Token = "0x6002453")]
	[Address(RVA = "0xB5C300", Offset = "0xB5C300", VA = "0xB5C300")]
	private void SendMessageAll(Action<XModuleBase> callback)
	{
	}

	[Token(Token = "0x6002454")]
	[Address(RVA = "0xB5C42C", Offset = "0xB5C42C", VA = "0xB5C42C")]
	public void Notify_OnActorRevive()
	{
	}

	[Token(Token = "0x6002455")]
	[Address(RVA = "0xB5C550", Offset = "0xB5C550", VA = "0xB5C550")]
	public void Notify_OnActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x6002456")]
	[Address(RVA = "0xB3B58C", Offset = "0xB3B58C", VA = "0xB3B58C")]
	public void Notify_OnActorReady()
	{
	}

	[Token(Token = "0x6002457")]
	[Address(RVA = "0xB33FAC", Offset = "0xB33FAC", VA = "0xB33FAC")]
	public void Notify_OnRun(Vector3 directionOnWorldSpace)
	{
	}

	[Token(Token = "0x6002458")]
	[Address(RVA = "0xB34134", Offset = "0xB34134", VA = "0xB34134")]
	public void Notify_OnIdle()
	{
	}

	[Token(Token = "0x6002459")]
	[Address(RVA = "0xB5C6C8", Offset = "0xB5C6C8", VA = "0xB5C6C8")]
	public void Notify_OnSkillMotionEnd()
	{
	}

	[Token(Token = "0x600245A")]
	[Address(RVA = "0xB4BBA4", Offset = "0xB4BBA4", VA = "0xB4BBA4")]
	public void Notify_OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x600245B")]
	[Address(RVA = "0xB39164", Offset = "0xB39164", VA = "0xB39164")]
	public void Notify_OnActorTag()
	{
	}

	[Token(Token = "0x600245C")]
	[Address(RVA = "0xB4C9A4", Offset = "0xB4C9A4", VA = "0xB4C9A4")]
	public void Notify_OnGainBuff(XBuff buff)
	{
	}

	[Token(Token = "0x600245D")]
	[Address(RVA = "0xB47440", Offset = "0xB47440", VA = "0xB47440")]
	public void Notify_OnLostBuff(XBuff buff)
	{
	}

	[Token(Token = "0x600245E")]
	[Address(RVA = "0xB5C7EC", Offset = "0xB5C7EC", VA = "0xB5C7EC")]
	public void Notify_OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x600245F")]
	[Address(RVA = "0xB5C914", Offset = "0xB5C914", VA = "0xB5C914")]
	public void Notify_OnAfterSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x6002460")]
	[Address(RVA = "0xB5CA3C", Offset = "0xB5CA3C", VA = "0xB5CA3C")]
	public void Notify_SetVisible(bool isInvisible, bool isEnemy)
	{
	}

	[Token(Token = "0x6002461")]
	[Address(RVA = "0xB5CB68", Offset = "0xB5CB68", VA = "0xB5CB68")]
	public void Notify_OnSkillFinished(XSkill skill)
	{
	}

	[Token(Token = "0x6002462")]
	[Address(RVA = "0xB5CC90", Offset = "0xB5CC90", VA = "0xB5CC90")]
	public void Notify_OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x6002463")]
	[Address(RVA = "0xB337D8", Offset = "0xB337D8", VA = "0xB337D8")]
	public void Notify_OnMotionControlStart(XMotionControlBase mc)
	{
	}

	[Token(Token = "0x6002464")]
	[Address(RVA = "0xB33984", Offset = "0xB33984", VA = "0xB33984")]
	public void Notify_OnMotionControlRelease(XMotionControlBase mc)
	{
	}

	[Token(Token = "0x6002465")]
	[Address(RVA = "0xB5CDB8", Offset = "0xB5CDB8", VA = "0xB5CDB8")]
	public void Notify_OnActorHitActor(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002466")]
	[Address(RVA = "0xB5CEE0", Offset = "0xB5CEE0", VA = "0xB5CEE0")]
	public void Notify_OnActorHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002467")]
	[Address(RVA = "0xB5D008", Offset = "0xB5D008", VA = "0xB5D008")]
	public void Notify_OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002468")]
	[Address(RVA = "0xB5D1C4", Offset = "0xB5D1C4", VA = "0xB5D1C4")]
	public void Notify_OnActorKill(int streakKillCountint)
	{
	}

	[Token(Token = "0x6002469")]
	[Address(RVA = "0xB5D2EC", Offset = "0xB5D2EC", VA = "0xB5D2EC")]
	public void Notify_OnActorDodge()
	{
	}

	[Token(Token = "0x600246A")]
	[Address(RVA = "0xB5C1C4", Offset = "0xB5C1C4", VA = "0xB5C1C4")]
	public void Notify_OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x600246B")]
	[Address(RVA = "0xB55EE8", Offset = "0xB55EE8", VA = "0xB55EE8")]
	public void Notify_OnHide()
	{
	}

	[Token(Token = "0x600246C")]
	[Address(RVA = "0xB5C6B8", Offset = "0xB5C6B8", VA = "0xB5C6B8")]
	public void EnableController(bool isEnable)
	{
	}

	[Token(Token = "0x600246D")]
	[Address(RVA = "0xB42B20", Offset = "0xB42B20", VA = "0xB42B20")]
	public void Notify_OnPlayAnimation()
	{
	}

	[Token(Token = "0x600246E")]
	[Address(RVA = "0xB324C4", Offset = "0xB324C4", VA = "0xB324C4")]
	public void Notify_OnStopAnimation()
	{
	}

	[Token(Token = "0x600246F")]
	[Address(RVA = "0xB5D410", Offset = "0xB5D410", VA = "0xB5D410")]
	public void Notify_OnGamePause()
	{
	}

	[Token(Token = "0x6002470")]
	[Address(RVA = "0xB5D534", Offset = "0xB5D534", VA = "0xB5D534")]
	public void Notify_OnGameResume()
	{
	}

	[Token(Token = "0x6002471")]
	[Address(RVA = "0xB5D658", Offset = "0xB5D658", VA = "0xB5D658")]
	public void Notify_OnGameModeFinishStateEnter()
	{
	}

	[Token(Token = "0x6002472")]
	[Address(RVA = "0xB5D77C", Offset = "0xB5D77C", VA = "0xB5D77C")]
	public void Notify_OnGameModePlayStateEnter()
	{
	}

	[Token(Token = "0x6002473")]
	[Address(RVA = "0xB5D8A0", Offset = "0xB5D8A0", VA = "0xB5D8A0")]
	public void Notify_OnOntoBattle()
	{
	}

	[Token(Token = "0x6002474")]
	[Address(RVA = "0xB5D9C4", Offset = "0xB5D9C4", VA = "0xB5D9C4")]
	public void Notify_OnEnterDeathsDoor()
	{
	}

	[Token(Token = "0x6002475")]
	[Address(RVA = "0xB5DAE8", Offset = "0xB5DAE8", VA = "0xB5DAE8")]
	public void Notify_OnStuck(XModuleEntity stuckME)
	{
	}

	[Token(Token = "0x6002476")]
	[Address(RVA = "0xB5DC10", Offset = "0xB5DC10", VA = "0xB5DC10")]
	public void Notify_OnStartUlitmateCinema(int skillID)
	{
	}

	[Token(Token = "0x6002477")]
	[Address(RVA = "0xB42E9C", Offset = "0xB42E9C", VA = "0xB42E9C")]
	public void Notify_OnStartCinemaAnimation(string aniName)
	{
	}

	[Token(Token = "0x6002478")]
	[Address(RVA = "0xB43FFC", Offset = "0xB43FFC", VA = "0xB43FFC")]
	public void Notify_OnEndCinemaAnimation()
	{
	}

	[Token(Token = "0x6002479")]
	[Address(RVA = "0xB5440C", Offset = "0xB5440C", VA = "0xB5440C")]
	public void Notify_OnLootingStart(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x600247A")]
	[Address(RVA = "0xB54534", Offset = "0xB54534", VA = "0xB54534")]
	public void Notify_OnLootingCancel(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x600247B")]
	[Address(RVA = "0xB542E4", Offset = "0xB542E4", VA = "0xB542E4")]
	public void Notify_OnLootingFinish(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x600247C")]
	[Address(RVA = "0xB5465C", Offset = "0xB5465C", VA = "0xB5465C")]
	public void Notify_OnReviveStart(XModuleEntity srcEntity)
	{
	}

	[Token(Token = "0x600247D")]
	[Address(RVA = "0xB54784", Offset = "0xB54784", VA = "0xB54784")]
	public void Notify_OnReviveCancel(XModuleEntity srcEntity)
	{
	}

	[Token(Token = "0x600247E")]
	[Address(RVA = "0xB33C90", Offset = "0xB33C90", VA = "0xB33C90")]
	public bool IsAI()
	{
		return default(bool);
	}

	[Token(Token = "0x600247F")]
	[Address(RVA = "0xB33CA4", Offset = "0xB33CA4", VA = "0xB33CA4")]
	public bool IsMine()
	{
		return default(bool);
	}
}
