using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000452")]
public abstract class XModuleBase
{
	[Token(Token = "0x4001545")]
	[FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x4001546")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public XModuleEntity me;

	[Token(Token = "0x600234F")]
	[Address(RVA = "0xB32FA4", Offset = "0xB32FA4", VA = "0xB32FA4")]
	protected XModuleBase()
	{
	}

	[Token(Token = "0x6002350")]
	[Address(RVA = "0xB44A6C", Offset = "0xB44A6C", VA = "0xB44A6C", Slot = "4")]
	public virtual string GetTypeStr()
	{
		return null;
	}

	[Token(Token = "0x6002351")]
	[Address(RVA = "0xB44ACC", Offset = "0xB44ACC", VA = "0xB44ACC")]
	public void SetContainer(XModuleEntity me)
	{
	}

	[Token(Token = "0x6002352")]
	[Address(RVA = "0xB44AD4", Offset = "0xB44AD4", VA = "0xB44AD4", Slot = "5")]
	public virtual void OnInit()
	{
	}

	[Token(Token = "0x6002353")]
	[Address(RVA = "0xB44AD8", Offset = "0xB44AD8", VA = "0xB44AD8", Slot = "6")]
	public virtual void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x6002354")]
	[Address(RVA = "0xB44ADC", Offset = "0xB44ADC", VA = "0xB44ADC", Slot = "7")]
	public virtual void OnLateUpdate(float dt)
	{
	}

	[Token(Token = "0x6002355")]
	[Address(RVA = "0xB44AE0", Offset = "0xB44AE0", VA = "0xB44AE0", Slot = "8")]
	public virtual void OnFixedUpdate(float dt)
	{
	}

	[Token(Token = "0x6002356")]
	[Address(RVA = "0xB44AE4", Offset = "0xB44AE4", VA = "0xB44AE4", Slot = "9")]
	public virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002357")]
	[Address(RVA = "0xB44AE8", Offset = "0xB44AE8", VA = "0xB44AE8", Slot = "10")]
	public virtual void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6002358")]
	[Address(RVA = "0xB44AEC", Offset = "0xB44AEC", VA = "0xB44AEC", Slot = "11")]
	public virtual void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6002359")]
	[Address(RVA = "0xB44AF0", Offset = "0xB44AF0", VA = "0xB44AF0", Slot = "12")]
	public virtual void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600235A")]
	[Address(RVA = "0xB44AF4", Offset = "0xB44AF4", VA = "0xB44AF4", Slot = "13")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600235B")]
	[Address(RVA = "0xB44AF8", Offset = "0xB44AF8", VA = "0xB44AF8", Slot = "14")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600235C")]
	[Address(RVA = "0xB44AFC", Offset = "0xB44AFC", VA = "0xB44AFC", Slot = "15")]
	public virtual void OnGUI()
	{
	}

	[Token(Token = "0x600235D")]
	[Address(RVA = "0xB44B00", Offset = "0xB44B00", VA = "0xB44B00", Slot = "16")]
	public virtual void OnActorRevive()
	{
	}

	[Token(Token = "0x600235E")]
	[Address(RVA = "0xB44B04", Offset = "0xB44B04", VA = "0xB44B04", Slot = "17")]
	public virtual void OnActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x600235F")]
	[Address(RVA = "0xB44B08", Offset = "0xB44B08", VA = "0xB44B08", Slot = "18")]
	public virtual void OnAfterActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x6002360")]
	[Address(RVA = "0xB44B0C", Offset = "0xB44B0C", VA = "0xB44B0C", Slot = "19")]
	public virtual void OnActorReady()
	{
	}

	[Token(Token = "0x6002361")]
	[Address(RVA = "0xB44B10", Offset = "0xB44B10", VA = "0xB44B10", Slot = "20")]
	public virtual void OnRun(Vector3 directionOnWorldSpace)
	{
	}

	[Token(Token = "0x6002362")]
	[Address(RVA = "0xB44B14", Offset = "0xB44B14", VA = "0xB44B14", Slot = "21")]
	public virtual void OnIdle()
	{
	}

	[Token(Token = "0x6002363")]
	[Address(RVA = "0xB44B18", Offset = "0xB44B18", VA = "0xB44B18", Slot = "22")]
	public virtual void OnSkillMotionEnd()
	{
	}

	[Token(Token = "0x6002364")]
	[Address(RVA = "0xB44B1C", Offset = "0xB44B1C", VA = "0xB44B1C", Slot = "23")]
	public virtual void OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x6002365")]
	[Address(RVA = "0xB44B20", Offset = "0xB44B20", VA = "0xB44B20", Slot = "24")]
	public virtual void OnActorTag()
	{
	}

	[Token(Token = "0x6002366")]
	[Address(RVA = "0xB44B24", Offset = "0xB44B24", VA = "0xB44B24", Slot = "25")]
	public virtual void OnGainBuff(XBuff buff)
	{
	}

	[Token(Token = "0x6002367")]
	[Address(RVA = "0xB44B28", Offset = "0xB44B28", VA = "0xB44B28", Slot = "26")]
	public virtual void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x6002368")]
	[Address(RVA = "0xB44B2C", Offset = "0xB44B2C", VA = "0xB44B2C", Slot = "27")]
	public virtual void OnAfterSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x6002369")]
	[Address(RVA = "0xB44B30", Offset = "0xB44B30", VA = "0xB44B30", Slot = "28")]
	public virtual void OnLostBuff(XBuff buff)
	{
	}

	[Token(Token = "0x600236A")]
	[Address(RVA = "0xB44B34", Offset = "0xB44B34", VA = "0xB44B34", Slot = "29")]
	public virtual void SetVisible(bool isVisible, bool isEnemy)
	{
	}

	[Token(Token = "0x600236B")]
	[Address(RVA = "0xB44B38", Offset = "0xB44B38", VA = "0xB44B38", Slot = "30")]
	public virtual void OnSkillFinished(XSkill skill)
	{
	}

	[Token(Token = "0x600236C")]
	[Address(RVA = "0xB44B3C", Offset = "0xB44B3C", VA = "0xB44B3C", Slot = "31")]
	public virtual void OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x600236D")]
	[Address(RVA = "0xB44B40", Offset = "0xB44B40", VA = "0xB44B40", Slot = "32")]
	public virtual void OnMotionControlStart(XMotionControlBase mc)
	{
	}

	[Token(Token = "0x600236E")]
	[Address(RVA = "0xB44B44", Offset = "0xB44B44", VA = "0xB44B44", Slot = "33")]
	public virtual void OnMotionControlRelease(XMotionControlBase mc)
	{
	}

	[Token(Token = "0x600236F")]
	[Address(RVA = "0xB44B48", Offset = "0xB44B48", VA = "0xB44B48", Slot = "34")]
	public virtual void OnHitActor(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002370")]
	[Address(RVA = "0xB44B4C", Offset = "0xB44B4C", VA = "0xB44B4C", Slot = "35")]
	public virtual void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002371")]
	[Address(RVA = "0xB44B50", Offset = "0xB44B50", VA = "0xB44B50", Slot = "36")]
	public virtual void OnBeforeActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002372")]
	[Address(RVA = "0xB44B54", Offset = "0xB44B54", VA = "0xB44B54", Slot = "37")]
	public virtual void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002373")]
	[Address(RVA = "0xB44B58", Offset = "0xB44B58", VA = "0xB44B58", Slot = "38")]
	public virtual void OnActorKill(int streakKillCount)
	{
	}

	[Token(Token = "0x6002374")]
	[Address(RVA = "0xB44B5C", Offset = "0xB44B5C", VA = "0xB44B5C", Slot = "39")]
	public virtual void OnActorDodge()
	{
	}

	[Token(Token = "0x6002375")]
	[Address(RVA = "0xB44B60", Offset = "0xB44B60", VA = "0xB44B60", Slot = "40")]
	public virtual void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x6002376")]
	[Address(RVA = "0xB44B64", Offset = "0xB44B64", VA = "0xB44B64", Slot = "41")]
	public virtual void OnGameResume()
	{
	}

	[Token(Token = "0x6002377")]
	[Address(RVA = "0xB44B68", Offset = "0xB44B68", VA = "0xB44B68", Slot = "42")]
	public virtual void OnGamePause()
	{
	}

	[Token(Token = "0x6002378")]
	[Address(RVA = "0xB44B6C", Offset = "0xB44B6C", VA = "0xB44B6C", Slot = "43")]
	public virtual void OnGameModePlayStateEnter()
	{
	}

	[Token(Token = "0x6002379")]
	[Address(RVA = "0xB44B70", Offset = "0xB44B70", VA = "0xB44B70", Slot = "44")]
	public virtual void OnGameModeFinishStateEnter()
	{
	}

	[Token(Token = "0x600237A")]
	[Address(RVA = "0xB44B74", Offset = "0xB44B74", VA = "0xB44B74", Slot = "45")]
	public virtual void OnHide()
	{
	}

	[Token(Token = "0x600237B")]
	[Address(RVA = "0xB44B78", Offset = "0xB44B78", VA = "0xB44B78", Slot = "46")]
	public virtual void OnPlayAnimation()
	{
	}

	[Token(Token = "0x600237C")]
	[Address(RVA = "0xB44B7C", Offset = "0xB44B7C", VA = "0xB44B7C", Slot = "47")]
	public virtual void OnStopAnimation()
	{
	}

	[Token(Token = "0x600237D")]
	[Address(RVA = "0xB44B80", Offset = "0xB44B80", VA = "0xB44B80", Slot = "48")]
	public virtual void OnOntoBattle()
	{
	}

	[Token(Token = "0x600237E")]
	[Address(RVA = "0xB44B84", Offset = "0xB44B84", VA = "0xB44B84", Slot = "49")]
	public virtual void OnEnterDeathsDoor()
	{
	}

	[Token(Token = "0x600237F")]
	[Address(RVA = "0xB44B88", Offset = "0xB44B88", VA = "0xB44B88", Slot = "50")]
	public virtual void OnStuck(XModuleEntity stuckME)
	{
	}

	[Token(Token = "0x6002380")]
	[Address(RVA = "0xB44B8C", Offset = "0xB44B8C", VA = "0xB44B8C", Slot = "51")]
	public virtual void OnStartUlitmateCinema(int skillID)
	{
	}

	[Token(Token = "0x6002381")]
	[Address(RVA = "0xB44B90", Offset = "0xB44B90", VA = "0xB44B90", Slot = "52")]
	public virtual void OnStartCinemaAnimation(string aniName)
	{
	}

	[Token(Token = "0x6002382")]
	[Address(RVA = "0xB44B94", Offset = "0xB44B94", VA = "0xB44B94", Slot = "53")]
	public virtual void OnEndCinemaAnimation()
	{
	}

	[Token(Token = "0x6002383")]
	[Address(RVA = "0xB44B98", Offset = "0xB44B98", VA = "0xB44B98", Slot = "54")]
	public virtual void OnLootingStart(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x6002384")]
	[Address(RVA = "0xB44B9C", Offset = "0xB44B9C", VA = "0xB44B9C", Slot = "55")]
	public virtual void OnLootingCancel(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x6002385")]
	[Address(RVA = "0xB44BA0", Offset = "0xB44BA0", VA = "0xB44BA0", Slot = "56")]
	public virtual void OnLootingFinish(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x6002386")]
	[Address(RVA = "0xB44BA4", Offset = "0xB44BA4", VA = "0xB44BA4", Slot = "57")]
	public virtual void OnReviveStart(XModuleEntity srcEntity)
	{
	}

	[Token(Token = "0x6002387")]
	[Address(RVA = "0xB44BA8", Offset = "0xB44BA8", VA = "0xB44BA8", Slot = "58")]
	public virtual void OnReviveCancel(XModuleEntity srcEntity)
	{
	}
}
