using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200044D")]
public class XModuleAnimation : XModuleBase
{
	[Token(Token = "0x200044E")]
	private sealed class _003CPlayNextFrame_Idle_003Ec__Iterator36 : IDisposable
	{
		[Token(Token = "0x4001532")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001533")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001534")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleAnimation _003C_003Ef__this;

		[Token(Token = "0x170005F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600232E")]
			[Address(RVA = "0xB441C0", Offset = "0xB441C0", VA = "0xB441C0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600232F")]
			[Address(RVA = "0xB441C8", Offset = "0xB441C8", VA = "0xB441C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600232D")]
		[Address(RVA = "0xB41C30", Offset = "0xB41C30", VA = "0xB41C30")]
		public _003CPlayNextFrame_Idle_003Ec__Iterator36()
		{
		}

		[Token(Token = "0x600232E")]
		[Address(RVA = "0xB441C0", Offset = "0xB441C0", VA = "0xB441C0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600232F")]
		[Address(RVA = "0xB441C8", Offset = "0xB441C8", VA = "0xB441C8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002330")]
		[Address(RVA = "0xB441D0", Offset = "0xB441D0", VA = "0xB441D0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002331")]
		[Address(RVA = "0xB442BC", Offset = "0xB442BC", VA = "0xB442BC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002332")]
		[Address(RVA = "0xB442C8", Offset = "0xB442C8", VA = "0xB442C8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200044F")]
	private sealed class _003COnCineamAnimationEnd_003Ec__Iterator37 : IDisposable
	{
		[Token(Token = "0x4001535")]
		[FieldOffset(Offset = "0x8")]
		internal float sec;

		[Token(Token = "0x4001536")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001537")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001538")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003Esec;

		[Token(Token = "0x4001539")]
		[FieldOffset(Offset = "0x18")]
		internal XModuleAnimation _003C_003Ef__this;

		[Token(Token = "0x170005F8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002334")]
			[Address(RVA = "0xB43EC8", Offset = "0xB43EC8", VA = "0xB43EC8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005F9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002335")]
			[Address(RVA = "0xB43ED0", Offset = "0xB43ED0", VA = "0xB43ED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002333")]
		[Address(RVA = "0xB43078", Offset = "0xB43078", VA = "0xB43078")]
		public _003COnCineamAnimationEnd_003Ec__Iterator37()
		{
		}

		[Token(Token = "0x6002334")]
		[Address(RVA = "0xB43EC8", Offset = "0xB43EC8", VA = "0xB43EC8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002335")]
		[Address(RVA = "0xB43ED0", Offset = "0xB43ED0", VA = "0xB43ED0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002336")]
		[Address(RVA = "0xB43ED8", Offset = "0xB43ED8", VA = "0xB43ED8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002337")]
		[Address(RVA = "0xB44120", Offset = "0xB44120", VA = "0xB44120", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002338")]
		[Address(RVA = "0xB4412C", Offset = "0xB4412C", VA = "0xB4412C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000450")]
	private sealed class _003COnAnimationEnd_003Ec__Iterator38 : IDisposable
	{
		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x8")]
		internal float sec;

		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400153C")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400153D")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003Esec;

		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x18")]
		internal XModuleAnimation _003C_003Ef__this;

		[Token(Token = "0x170005FA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600233A")]
			[Address(RVA = "0xB43D24", Offset = "0xB43D24", VA = "0xB43D24", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005FB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600233B")]
			[Address(RVA = "0xB43D2C", Offset = "0xB43D2C", VA = "0xB43D2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002339")]
		[Address(RVA = "0xB430E4", Offset = "0xB430E4", VA = "0xB430E4")]
		public _003COnAnimationEnd_003Ec__Iterator38()
		{
		}

		[Token(Token = "0x600233A")]
		[Address(RVA = "0xB43D24", Offset = "0xB43D24", VA = "0xB43D24", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600233B")]
		[Address(RVA = "0xB43D2C", Offset = "0xB43D2C", VA = "0xB43D2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600233C")]
		[Address(RVA = "0xB43D34", Offset = "0xB43D34", VA = "0xB43D34", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600233D")]
		[Address(RVA = "0xB43E28", Offset = "0xB43E28", VA = "0xB43E28", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600233E")]
		[Address(RVA = "0xB43E34", Offset = "0xB43E34", VA = "0xB43E34", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400152A")]
	private const float defaultFadeTime = 0.1f;

	[Token(Token = "0x400152B")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 m_vecDummyLocApplied;

	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_startCinema;

	[Token(Token = "0x400152D")]
	[FieldOffset(Offset = "0x20")]
	private Action m_cinemaEndAction;

	[Token(Token = "0x400152E")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_goModel;

	[Token(Token = "0x400152F")]
	[FieldOffset(Offset = "0x28")]
	private Animation m_modelAnimation;

	[Token(Token = "0x4001530")]
	[FieldOffset(Offset = "0x2C")]
	private string m_motionControlAnimName;

	[Token(Token = "0x4001531")]
	[FieldOffset(Offset = "0x30")]
	private AnimationState m_aniState;

	[Token(Token = "0x170005F3")]
	public GameObject goModel
	{
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0xB406B4", Offset = "0xB406B4", VA = "0xB406B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0xB406BC", Offset = "0xB406BC", VA = "0xB406BC")]
		set
		{
		}
	}

	[Token(Token = "0x170005F4")]
	public Animation ModelAnimation
	{
		[Token(Token = "0x6002300")]
		[Address(RVA = "0xB40A4C", Offset = "0xB40A4C", VA = "0xB40A4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F5")]
	public string PlayingAniName
	{
		[Token(Token = "0x6002301")]
		[Address(RVA = "0xB40A54", Offset = "0xB40A54", VA = "0xB40A54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022FD")]
	[Address(RVA = "0xB405F8", Offset = "0xB405F8", VA = "0xB405F8")]
	public XModuleAnimation()
	{
	}

	[Token(Token = "0x6002302")]
	[Address(RVA = "0xB40F14", Offset = "0xB40F14", VA = "0xB40F14")]
	public bool IsInvalid()
	{
		return default(bool);
	}

	[Token(Token = "0x6002303")]
	[Address(RVA = "0xB40FC4", Offset = "0xB40FC4", VA = "0xB40FC4")]
	public bool IsInvalid(string strAniName)
	{
		return default(bool);
	}

	[Token(Token = "0x6002304")]
	[Address(RVA = "0xB41358", Offset = "0xB41358", VA = "0xB41358")]
	public void Play(string strAniName)
	{
	}

	[Token(Token = "0x6002305")]
	[Address(RVA = "0xB4139C", Offset = "0xB4139C", VA = "0xB4139C")]
	public void PlayQueued(string strAniName)
	{
	}

	[Token(Token = "0x6002306")]
	[Address(RVA = "0xB413E0", Offset = "0xB413E0", VA = "0xB413E0")]
	public void CrossFade(string strAniName, float fadeLength = 0.1f)
	{
	}

	[Token(Token = "0x6002307")]
	[Address(RVA = "0xB4142C", Offset = "0xB4142C", VA = "0xB4142C")]
	public void CrossFadeQueued(string strAniName, float fadeLength = 0.1f)
	{
	}

	[Token(Token = "0x6002308")]
	[Address(RVA = "0xB41478", Offset = "0xB41478", VA = "0xB41478")]
	public void CrossFadeQueuedPlayNow(string strAniName, float fadeLength = 0.1f, float playTime = 0f)
	{
	}

	[Token(Token = "0x6002309")]
	[Address(RVA = "0xB4152C", Offset = "0xB4152C", VA = "0xB4152C")]
	public AnimationState CrossFadeQueuedPlaySpecificFrameNow(string strAniName, float fadeLength = 0.1f, float normalizedTime = 0f)
	{
		return null;
	}

	[Token(Token = "0x600230A")]
	[Address(RVA = "0xB415B0", Offset = "0xB415B0", VA = "0xB415B0")]
	public void QueuedPlayNow(string strAniName, float playTime = 0f)
	{
	}

	[Token(Token = "0x600230B")]
	[Address(RVA = "0xB4164C", Offset = "0xB4164C", VA = "0xB4164C")]
	public bool IsPlaying(string strAniName)
	{
		return default(bool);
	}

	[Token(Token = "0x600230C")]
	[Address(RVA = "0xB41698", Offset = "0xB41698", VA = "0xB41698")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600230D")]
	[Address(RVA = "0xB416DC", Offset = "0xB416DC", VA = "0xB416DC")]
	public void Blend(string strAniName, float fTargetWeight = 1f, float fFadeLength = 0.3f)
	{
	}

	[Token(Token = "0x600230E")]
	[Address(RVA = "0xB4173C", Offset = "0xB4173C", VA = "0xB4173C")]
	public void Stop()
	{
	}

	[Token(Token = "0x600230F")]
	[Address(RVA = "0xB41814", Offset = "0xB41814", VA = "0xB41814")]
	public void ChangeAnimationSpeed(string strAniName, float speed)
	{
	}

	[Token(Token = "0x6002310")]
	[Address(RVA = "0xB41870", Offset = "0xB41870", VA = "0xB41870")]
	public void PlayCameraAnimation(string aniName, float waitTime)
	{
	}

	[Token(Token = "0x6002311")]
	[Address(RVA = "0xB4196C", Offset = "0xB4196C", VA = "0xB4196C")]
	public void CrossFade_Idle(float fadeTime = 0.1f)
	{
	}

	[Token(Token = "0x6002312")]
	[Address(RVA = "0xB419BC", Offset = "0xB419BC", VA = "0xB419BC")]
	public void Play_Lobby()
	{
	}

	[Token(Token = "0x6002313")]
	[Address(RVA = "0xB41A98", Offset = "0xB41A98", VA = "0xB41A98")]
	public void CrossFadeQueued_Idle(float fadeTime = 0.1f)
	{
	}

	[Token(Token = "0x6002314")]
	[Address(RVA = "0xB41AE8", Offset = "0xB41AE8", VA = "0xB41AE8")]
	public void CrossFadeQueued_IdlePlayNow(float fadeTime = 0.1f)
	{
	}

	[Token(Token = "0x6002315")]
	[Address(RVA = "0xB41B44", Offset = "0xB41B44", VA = "0xB41B44")]
	public void PlayQueued_Idle()
	{
	}

	[Token(Token = "0x6002316")]
	[Address(RVA = "0xB41B8C", Offset = "0xB41B8C", VA = "0xB41B8C")]
	[DebuggerHidden]
	private IEnumerator PlayNextFrame_Idle()
	{
		return null;
	}

	[Token(Token = "0x6002317")]
	[Address(RVA = "0xB407BC", Offset = "0xB407BC", VA = "0xB407BC")]
	private void GenerateFakeBeaten()
	{
	}

	[Token(Token = "0x6002318")]
	[Address(RVA = "0xB41C38", Offset = "0xB41C38", VA = "0xB41C38")]
	public void FakeBeaten()
	{
	}

	[Token(Token = "0x6002319")]
	[Address(RVA = "0xB41DFC", Offset = "0xB41DFC", VA = "0xB41DFC", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x600231A")]
	[Address(RVA = "0xB41EB8", Offset = "0xB41EB8", VA = "0xB41EB8", Slot = "21")]
	public override void OnIdle()
	{
	}

	[Token(Token = "0x600231B")]
	[Address(RVA = "0xB420B4", Offset = "0xB420B4", VA = "0xB420B4", Slot = "20")]
	public override void OnRun(Vector3 directionOnWorldSpace)
	{
	}

	[Token(Token = "0x600231C")]
	[Address(RVA = "0xB42004", Offset = "0xB42004", VA = "0xB42004")]
	private bool PlayMovableSkillAni(string aniName)
	{
		return default(bool);
	}

	[Token(Token = "0x600231D")]
	[Address(RVA = "0xB42494", Offset = "0xB42494", VA = "0xB42494")]
	private bool IsPlayCameraAni(EffectTarget CameraAniEffectTarget)
	{
		return default(bool);
	}

	[Token(Token = "0x600231E")]
	[Address(RVA = "0xB426C8", Offset = "0xB426C8", VA = "0xB426C8", Slot = "23")]
	public override void OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x600231F")]
	[Address(RVA = "0xB426D4", Offset = "0xB426D4", VA = "0xB426D4", Slot = "24")]
	public override void OnActorTag()
	{
	}

	[Token(Token = "0x6002320")]
	[Address(RVA = "0xB426E0", Offset = "0xB426E0", VA = "0xB426E0", Slot = "32")]
	public override void OnMotionControlStart(XMotionControlBase mc)
	{
	}

	[Token(Token = "0x6002321")]
	[Address(RVA = "0xB42A30", Offset = "0xB42A30", VA = "0xB42A30", Slot = "33")]
	public override void OnMotionControlRelease(XMotionControlBase mc)
	{
	}

	[Token(Token = "0x6002322")]
	[Address(RVA = "0xB3264C", Offset = "0xB3264C", VA = "0xB3264C")]
	public void PlayAnimation(string aniName)
	{
	}

	[Token(Token = "0x6002323")]
	[Address(RVA = "0xB42CF8", Offset = "0xB42CF8", VA = "0xB42CF8", Slot = "51")]
	public override void OnStartUlitmateCinema(int skillID)
	{
	}

	[Token(Token = "0x6002324")]
	[Address(RVA = "0xB42D80", Offset = "0xB42D80", VA = "0xB42D80")]
	public void CinemaPlayAnimation(string aniName, Action action)
	{
	}

	[Token(Token = "0x6002325")]
	[Address(RVA = "0xB42FC4", Offset = "0xB42FC4", VA = "0xB42FC4")]
	[DebuggerHidden]
	private IEnumerator OnCineamAnimationEnd(float sec)
	{
		return null;
	}

	[Token(Token = "0x6002326")]
	[Address(RVA = "0xB43080", Offset = "0xB43080", VA = "0xB43080")]
	private void CinemaStopAnimation()
	{
	}

	[Token(Token = "0x6002327")]
	[Address(RVA = "0xB42C44", Offset = "0xB42C44", VA = "0xB42C44")]
	[DebuggerHidden]
	private IEnumerator OnAnimationEnd(float sec)
	{
		return null;
	}

	[Token(Token = "0x6002328")]
	[Address(RVA = "0xB430EC", Offset = "0xB430EC", VA = "0xB430EC", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x6002329")]
	[Address(RVA = "0xB435EC", Offset = "0xB435EC", VA = "0xB435EC", Slot = "31")]
	public override void OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x600232A")]
	[Address(RVA = "0xB437C0", Offset = "0xB437C0", VA = "0xB437C0", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x600232B")]
	[Address(RVA = "0xB43A78", Offset = "0xB43A78", VA = "0xB43A78", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x600232C")]
	[Address(RVA = "0xB43A84", Offset = "0xB43A84", VA = "0xB43A84", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}
}
