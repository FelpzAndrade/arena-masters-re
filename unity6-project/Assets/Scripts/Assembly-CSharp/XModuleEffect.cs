using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200045B")]
public class XModuleEffect : XModuleBase
{
	[Token(Token = "0x200045C")]
	public class Entry : CSPoolEntry
	{
		[Token(Token = "0x400157F")]
		[FieldOffset(Offset = "0x8")]
		public CSSkillInfo skillInfo;

		[Token(Token = "0x4001580")]
		[FieldOffset(Offset = "0xC")]
		public CSSkillEffectInfo effectInfo;

		[Token(Token = "0x4001581")]
		[FieldOffset(Offset = "0x10")]
		public float remainTime;

		[Token(Token = "0x4001582")]
		[FieldOffset(Offset = "0x14")]
		public bool canceled;

		[Token(Token = "0x4001583")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 autoTargetSpawnPosition;

		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion autoTargetRotation;

		[Token(Token = "0x600243A")]
		[Address(RVA = "0xB5B4EC", Offset = "0xB5B4EC", VA = "0xB5B4EC")]
		public Entry()
		{
		}

		[Token(Token = "0x600243B")]
		[Address(RVA = "0xB5B4F4", Offset = "0xB5B4F4", VA = "0xB5B4F4", Slot = "4")]
		public void OnCleanupInObjectPool()
		{
		}

		[Token(Token = "0x600243C")]
		[Address(RVA = "0xB5B4F8", Offset = "0xB5B4F8", VA = "0xB5B4F8")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x200045D")]
	private sealed class _003CCreateDieEffect_003Ec__Iterator39 : IDisposable
	{
		[Token(Token = "0x4001585")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001586")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001587")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleEffect _003C_003Ef__this;

		[Token(Token = "0x17000607")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600243E")]
			[Address(RVA = "0xB5B2BC", Offset = "0xB5B2BC", VA = "0xB5B2BC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000608")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600243F")]
			[Address(RVA = "0xB5B2C4", Offset = "0xB5B2C4", VA = "0xB5B2C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600243D")]
		[Address(RVA = "0xB5A2C8", Offset = "0xB5A2C8", VA = "0xB5A2C8")]
		public _003CCreateDieEffect_003Ec__Iterator39()
		{
		}

		[Token(Token = "0x600243E")]
		[Address(RVA = "0xB5B2BC", Offset = "0xB5B2BC", VA = "0xB5B2BC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600243F")]
		[Address(RVA = "0xB5B2C4", Offset = "0xB5B2C4", VA = "0xB5B2C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002440")]
		[Address(RVA = "0xB5B2CC", Offset = "0xB5B2CC", VA = "0xB5B2CC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002441")]
		[Address(RVA = "0xB5B44C", Offset = "0xB5B44C", VA = "0xB5B44C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002442")]
		[Address(RVA = "0xB5B458", Offset = "0xB5B458", VA = "0xB5B458", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001578")]
	[FieldOffset(Offset = "0x10")]
	private List<Entry> scheduleEffects;

	[Token(Token = "0x4001579")]
	[FieldOffset(Offset = "0x14")]
	private Transform m_objCharacterShadow;

	[Token(Token = "0x400157A")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_transRootChild;

	[Token(Token = "0x400157B")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, List<GameObject>> runningSkillEffects;

	[Token(Token = "0x400157C")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, List<GameObject>> runningSkillFollowingEffects;

	[Token(Token = "0x400157D")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_tagEffect;

	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0x28")]
	private bool m_visible;

	[Token(Token = "0x600241E")]
	[Address(RVA = "0xB579C4", Offset = "0xB579C4", VA = "0xB579C4")]
	public XModuleEffect()
	{
	}

	[Token(Token = "0x600241F")]
	[Address(RVA = "0xB57ACC", Offset = "0xB57ACC", VA = "0xB57ACC")]
	private void RemoveEntry(int index)
	{
	}

	[Token(Token = "0x6002420")]
	[Address(RVA = "0xB57BF4", Offset = "0xB57BF4", VA = "0xB57BF4", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x6002421")]
	[Address(RVA = "0xB58388", Offset = "0xB58388", VA = "0xB58388", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x6002422")]
	[Address(RVA = "0xB584DC", Offset = "0xB584DC", VA = "0xB584DC")]
	private void ClearRunningSkillEffects()
	{
	}

	[Token(Token = "0x6002423")]
	[Address(RVA = "0xB58A3C", Offset = "0xB58A3C", VA = "0xB58A3C")]
	private void ClearScheduleEffects()
	{
	}

	[Token(Token = "0x6002424")]
	[Address(RVA = "0xB5838C", Offset = "0xB5838C", VA = "0xB5838C")]
	private void ClearAll()
	{
	}

	[Token(Token = "0x6002425")]
	[Address(RVA = "0xB57C10", Offset = "0xB57C10", VA = "0xB57C10")]
	private void UpdateScheduleCinemaEffects(float deltaTime)
	{
	}

	[Token(Token = "0x6002426")]
	[Address(RVA = "0xB58AF8", Offset = "0xB58AF8", VA = "0xB58AF8", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x6002427")]
	[Address(RVA = "0xB57C14", Offset = "0xB57C14", VA = "0xB57C14")]
	private void UpdateScheduleEffects(float deltaTime)
	{
	}

	[Token(Token = "0x6002428")]
	[Address(RVA = "0xB593E8", Offset = "0xB593E8", VA = "0xB593E8")]
	private void ScheduleEffect(XModuleEntity target, CSSkillInfo skillInfo, int usingSkillId = 0)
	{
	}

	[Token(Token = "0x6002429")]
	[Address(RVA = "0xB58158", Offset = "0xB58158", VA = "0xB58158")]
	private void UpdateCharacterShadow()
	{
	}

	[Token(Token = "0x600242A")]
	[Address(RVA = "0xB59878", Offset = "0xB59878", VA = "0xB59878", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600242B")]
	[Address(RVA = "0xB59920", Offset = "0xB59920", VA = "0xB59920", Slot = "24")]
	public override void OnActorTag()
	{
	}

	[Token(Token = "0x600242C")]
	[Address(RVA = "0xB59AB4", Offset = "0xB59AB4", VA = "0xB59AB4")]
	private Vector3 GetEffectOffset(ModuleEventArgument_Hit arg)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600242D")]
	[Address(RVA = "0xB50254", Offset = "0xB50254", VA = "0xB50254")]
	public Vector3 GetEffectOffset(XSystemData.EffectOffsetDirection direction, Vector3 attackerPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600242E")]
	[Address(RVA = "0xB59B3C", Offset = "0xB59B3C", VA = "0xB59B3C", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x600242F")]
	[Address(RVA = "0xB59E70", Offset = "0xB59E70", VA = "0xB59E70", Slot = "59")]
	protected virtual void CreateFragmentEffects(Vector3 position, float forceMultiplier, float yRotation)
	{
	}

	[Token(Token = "0x6002430")]
	[Address(RVA = "0xB5A224", Offset = "0xB5A224", VA = "0xB5A224")]
	[DebuggerHidden]
	private IEnumerator CreateDieEffect()
	{
		return null;
	}

	[Token(Token = "0x6002431")]
	[Address(RVA = "0xB5A2D0", Offset = "0xB5A2D0", VA = "0xB5A2D0")]
	public Transform GetRootChild()
	{
		return null;
	}

	[Token(Token = "0x6002432")]
	[Address(RVA = "0xB5A2D8", Offset = "0xB5A2D8", VA = "0xB5A2D8", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x6002433")]
	[Address(RVA = "0xB5A354", Offset = "0xB5A354", VA = "0xB5A354", Slot = "52")]
	public override void OnStartCinemaAnimation(string aniName)
	{
	}

	[Token(Token = "0x6002434")]
	[Address(RVA = "0xB58B04", Offset = "0xB58B04", VA = "0xB58B04")]
	private GameObject ActivateEffect(Entry entry)
	{
		return null;
	}

	[Token(Token = "0x6002435")]
	[Address(RVA = "0xB5A7B4", Offset = "0xB5A7B4", VA = "0xB5A7B4", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002436")]
	[Address(RVA = "0xB5ABD0", Offset = "0xB5ABD0", VA = "0xB5ABD0", Slot = "31")]
	public override void OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x6002437")]
	[Address(RVA = "0xB5AC14", Offset = "0xB5AC14", VA = "0xB5AC14")]
	private void ClearEffect(int skillId)
	{
	}

	[Token(Token = "0x6002438")]
	[Address(RVA = "0xB5B0A8", Offset = "0xB5B0A8", VA = "0xB5B0A8", Slot = "29")]
	public override void SetVisible(bool isInvisible, bool isEnemy)
	{
	}

	[Token(Token = "0x6002439")]
	[Address(RVA = "0xB5B0C8", Offset = "0xB5B0C8", VA = "0xB5B0C8")]
	public void SetVisibleRunningEffect(bool val)
	{
	}
}
