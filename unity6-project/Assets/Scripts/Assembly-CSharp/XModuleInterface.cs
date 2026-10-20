using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XUIEnum;

[Token(Token = "0x2000468")]
public class XModuleInterface : XModuleBase
{
	[Token(Token = "0x2000469")]
	public interface IModuleInterfaceEventReciever
	{
		[Token(Token = "0x60024F8")]
		void OnActorTag();
	}

	[Token(Token = "0x200046A")]
	private sealed class _003CProgressHeadBalloon_003Ec__Iterator3A : IDisposable
	{
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x8")]
		internal float fTime;

		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003EfTime;

		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x18")]
		internal XModuleInterface _003C_003Ef__this;

		[Token(Token = "0x17000610")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60024FA")]
			[Address(RVA = "0xB688A8", Offset = "0xB688A8", VA = "0xB688A8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000611")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60024FB")]
			[Address(RVA = "0xB688B0", Offset = "0xB688B0", VA = "0xB688B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60024F9")]
		[Address(RVA = "0xB6687C", Offset = "0xB6687C", VA = "0xB6687C")]
		public _003CProgressHeadBalloon_003Ec__Iterator3A()
		{
		}

		[Token(Token = "0x60024FA")]
		[Address(RVA = "0xB688A8", Offset = "0xB688A8", VA = "0xB688A8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60024FB")]
		[Address(RVA = "0xB688B0", Offset = "0xB688B0", VA = "0xB688B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60024FC")]
		[Address(RVA = "0xB688B8", Offset = "0xB688B8", VA = "0xB688B8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60024FD")]
		[Address(RVA = "0xB68A14", Offset = "0xB68A14", VA = "0xB68A14", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60024FE")]
		[Address(RVA = "0xB68A20", Offset = "0xB68A20", VA = "0xB68A20", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200046B")]
	private sealed class _003CProgressEmoticon_003Ec__Iterator3B : IDisposable
	{
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x8")]
		internal float fTime;

		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003EfTime;

		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x18")]
		internal XModuleInterface _003C_003Ef__this;

		[Token(Token = "0x17000612")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002500")]
			[Address(RVA = "0xB6869C", Offset = "0xB6869C", VA = "0xB6869C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000613")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002501")]
			[Address(RVA = "0xB686A4", Offset = "0xB686A4", VA = "0xB686A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60024FF")]
		[Address(RVA = "0xB67088", Offset = "0xB67088", VA = "0xB67088")]
		public _003CProgressEmoticon_003Ec__Iterator3B()
		{
		}

		[Token(Token = "0x6002500")]
		[Address(RVA = "0xB6869C", Offset = "0xB6869C", VA = "0xB6869C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002501")]
		[Address(RVA = "0xB686A4", Offset = "0xB686A4", VA = "0xB686A4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002502")]
		[Address(RVA = "0xB686AC", Offset = "0xB686AC", VA = "0xB686AC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002503")]
		[Address(RVA = "0xB68808", Offset = "0xB68808", VA = "0xB68808", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002504")]
		[Address(RVA = "0xB68814", Offset = "0xB68814", VA = "0xB68814", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200046C")]
	private sealed class _003CUpdateHealthBarEndOfFrame_003Ec__Iterator3C : IDisposable
	{
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleInterface _003C_003Ef__this;

		[Token(Token = "0x17000614")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002506")]
			[Address(RVA = "0xB68AB4", Offset = "0xB68AB4", VA = "0xB68AB4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000615")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002507")]
			[Address(RVA = "0xB68ABC", Offset = "0xB68ABC", VA = "0xB68ABC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002505")]
		[Address(RVA = "0xB67BE0", Offset = "0xB67BE0", VA = "0xB67BE0")]
		public _003CUpdateHealthBarEndOfFrame_003Ec__Iterator3C()
		{
		}

		[Token(Token = "0x6002506")]
		[Address(RVA = "0xB68AB4", Offset = "0xB68AB4", VA = "0xB68AB4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002507")]
		[Address(RVA = "0xB68ABC", Offset = "0xB68ABC", VA = "0xB68ABC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002508")]
		[Address(RVA = "0xB68AC4", Offset = "0xB68AC4", VA = "0xB68AC4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002509")]
		[Address(RVA = "0xB68BB8", Offset = "0xB68BB8", VA = "0xB68BB8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600250A")]
		[Address(RVA = "0xB68BC4", Offset = "0xB68BC4", VA = "0xB68BC4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0x10")]
	private XHealthBarMgr m_HealthBarMgr;

	[Token(Token = "0x40015EF")]
	[FieldOffset(Offset = "0x14")]
	private float m_fOffsetHeight;

	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0x18")]
	private XUIFollowTargetWithinScreen m_hudHeadBalloonFollowTarget;

	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0x1C")]
	private UILabel m_headBalloonLabel;

	[Token(Token = "0x40015F2")]
	[FieldOffset(Offset = "0x20")]
	private UIPanel m_headBalloonPanel;

	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_goHeadBalloon;

	[Token(Token = "0x40015F4")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_goEmoticon;

	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0x2C")]
	private IEnumerator m_goEmoCoroutine;

	[Token(Token = "0x40015F6")]
	[FieldOffset(Offset = "0x30")]
	private XModuleActor m_moduleEntity;

	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0x34")]
	private bool m_bKeepStand;

	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_vLastMyPos;

	[Token(Token = "0x40015F9")]
	[FieldOffset(Offset = "0x44")]
	private float m_KeepStandElapsedTime;

	[Token(Token = "0x40015FA")]
	[FieldOffset(Offset = "0x48")]
	private bool m_isUltOn;

	[Token(Token = "0x40015FB")]
	[FieldOffset(Offset = "0x4C")]
	private int m_killCount;

	[Token(Token = "0x40015FC")]
	[FieldOffset(Offset = "0x50")]
	private float m_limitMultiKillTime;

	[Token(Token = "0x40015FD")]
	[FieldOffset(Offset = "0x54")]
	private float m_multiKillElapsedTime;

	[Token(Token = "0x40015FE")]
	[FieldOffset(Offset = "0x58")]
	private bool m_isMultiKilling;

	[Token(Token = "0x40015FF")]
	[FieldOffset(Offset = "0x5C")]
	private float m_multikillShowDelayTime;

	[Token(Token = "0x4001600")]
	[FieldOffset(Offset = "0x60")]
	private float m_multikillShowDelayElapsedTime;

	[Token(Token = "0x4001601")]
	[FieldOffset(Offset = "0x64")]
	private bool m_isStartShowMultiKillDelayTime;

	[Token(Token = "0x4001602")]
	[FieldOffset(Offset = "0x68")]
	private int m_streakKillCount;

	[Token(Token = "0x4001603")]
	[FieldOffset(Offset = "0x6C")]
	private float m_streakkillShowDelayElapsedTime;

	[Token(Token = "0x4001604")]
	[FieldOffset(Offset = "0x70")]
	private bool m_isStartShowStreakKillDelayTime;

	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0x71")]
	private bool isAsyncLoadDone;

	[Token(Token = "0x4001606")]
	[FieldOffset(Offset = "0x74")]
	private List<IModuleInterfaceEventReciever> recievers;

	[Token(Token = "0x1700060D")]
	public bool IsHealthBarHide
	{
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0xB63A04", Offset = "0xB63A04", VA = "0xB63A04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700060E")]
	public bool IsUltOn
	{
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0xB63A7C", Offset = "0xB63A7C", VA = "0xB63A7C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0xB63A84", Offset = "0xB63A84", VA = "0xB63A84")]
		set
		{
		}
	}

	[Token(Token = "0x1700060F")]
	public int StreakKillCount
	{
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0xB623E4", Offset = "0xB623E4", VA = "0xB623E4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60024CA")]
	[Address(RVA = "0xB638E0", Offset = "0xB638E0", VA = "0xB638E0")]
	public XModuleInterface()
	{
	}

	[Token(Token = "0x60024CB")]
	[Address(RVA = "0xB639D8", Offset = "0xB639D8", VA = "0xB639D8")]
	public string GetNickName()
	{
		return null;
	}

	[Token(Token = "0x60024D0")]
	[Address(RVA = "0xB63B60", Offset = "0xB63B60", VA = "0xB63B60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60024D1")]
	[Address(RVA = "0xB63E2C", Offset = "0xB63E2C", VA = "0xB63E2C", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60024D2")]
	[Address(RVA = "0xB64710", Offset = "0xB64710", VA = "0xB64710")]
	private void CheckAsyncLoadUltOnUI()
	{
	}

	[Token(Token = "0x60024D3")]
	[Address(RVA = "0xB64758", Offset = "0xB64758", VA = "0xB64758")]
	private bool CheckAsnycUI()
	{
		return default(bool);
	}

	[Token(Token = "0x60024D4")]
	[Address(RVA = "0xB64870", Offset = "0xB64870", VA = "0xB64870")]
	private void AsnycLoadUltUI()
	{
	}

	[Token(Token = "0x60024D5")]
	[Address(RVA = "0xB64884", Offset = "0xB64884", VA = "0xB64884", Slot = "7")]
	public override void OnLateUpdate(float dt)
	{
	}

	[Token(Token = "0x60024D6")]
	[Address(RVA = "0xB63F24", Offset = "0xB63F24", VA = "0xB63F24")]
	private void UpdateContinuityKillCount(float deltaTime)
	{
	}

	[Token(Token = "0x60024D7")]
	[Address(RVA = "0xB64F60", Offset = "0xB64F60", VA = "0xB64F60")]
	private void SetShowKillParamForAIMode(out int profileIconId, out int titleId, out string nickName)
	{
		nickName = default;
		profileIconId = default;
		titleId = default;
	}

	[Token(Token = "0x60024D8")]
	[Address(RVA = "0xB654A0", Offset = "0xB654A0", VA = "0xB654A0", Slot = "38")]
	public override void OnActorKill(int streakKillCount)
	{
	}

	[Token(Token = "0x60024D9")]
	[Address(RVA = "0xB64D74", Offset = "0xB64D74", VA = "0xB64D74")]
	public void ShowMultiKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x60024DA")]
	[Address(RVA = "0xB65254", Offset = "0xB65254", VA = "0xB65254")]
	public void ShowStreakKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x60024DB")]
	[Address(RVA = "0xB658E4", Offset = "0xB658E4", VA = "0xB658E4")]
	public void ShowShutDownKill(int charID, int skinID, int profileIconID, int titleID, string userName)
	{
	}

	[Token(Token = "0x60024DC")]
	[Address(RVA = "0xB65B10", Offset = "0xB65B10", VA = "0xB65B10")]
	private void SetupCharInfo()
	{
	}

	[Token(Token = "0x60024DD")]
	[Address(RVA = "0xB65B5C", Offset = "0xB65B5C", VA = "0xB65B5C")]
	private void InitHealthBar()
	{
	}

	[Token(Token = "0x60024DE")]
	[Address(RVA = "0xB63ACC", Offset = "0xB63ACC", VA = "0xB63ACC")]
	public bool IsUltEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60024DF")]
	[Address(RVA = "0xB661C4", Offset = "0xB661C4", VA = "0xB661C4")]
	public void ShowHudHeadBalloon(bool bShow, string strMessage = "", float fTime = 3f)
	{
	}

	[Token(Token = "0x60024E0")]
	[Address(RVA = "0xB667C8", Offset = "0xB667C8", VA = "0xB667C8")]
	[DebuggerHidden]
	private IEnumerator ProgressHeadBalloon(float fTime)
	{
		return null;
	}

	[Token(Token = "0x60024E1")]
	[Address(RVA = "0xB66884", Offset = "0xB66884", VA = "0xB66884")]
	public void ShowEmoticon(bool bShow, string strPath = "", float fTime = 3f)
	{
	}

	[Token(Token = "0x60024E2")]
	[Address(RVA = "0xB66E64", Offset = "0xB66E64", VA = "0xB66E64")]
	private void ReleaseEmoticon()
	{
	}

	[Token(Token = "0x60024E3")]
	[Address(RVA = "0xB66FD4", Offset = "0xB66FD4", VA = "0xB66FD4")]
	[DebuggerHidden]
	private IEnumerator ProgressEmoticon(float fTime)
	{
		return null;
	}

	[Token(Token = "0x60024E4")]
	[Address(RVA = "0xB64974", Offset = "0xB64974", VA = "0xB64974")]
	private void UpdateHealthBar()
	{
	}

	[Token(Token = "0x60024E5")]
	[Address(RVA = "0xB674CC", Offset = "0xB674CC", VA = "0xB674CC")]
	private void OnMyObject(float hp, float maxHp)
	{
	}

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0xB63BFC", Offset = "0xB63BFC", VA = "0xB63BFC")]
	private void DestroyGameObjects()
	{
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0xB61DF8", Offset = "0xB61DF8", VA = "0xB61DF8")]
	public void OnHitUI(string strDamage, DamageType type, Vector3 dir, int fontsize = 20)
	{
	}

	[Token(Token = "0x60024E8")]
	[Address(RVA = "0xB67090", Offset = "0xB67090", VA = "0xB67090")]
	private bool UpdateKeepStand(Vector3 vMyPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60024E9")]
	[Address(RVA = "0xB67638", Offset = "0xB67638", VA = "0xB67638")]
	private bool CheckSneakMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60024EA")]
	[Address(RVA = "0xB676D8", Offset = "0xB676D8", VA = "0xB676D8", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x60024EB")]
	[Address(RVA = "0xB67798", Offset = "0xB67798", VA = "0xB67798", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x60024EC")]
	[Address(RVA = "0xB679A0", Offset = "0xB679A0", VA = "0xB679A0", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60024ED")]
	[Address(RVA = "0xB67AB8", Offset = "0xB67AB8", VA = "0xB67AB8", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x60024EE")]
	[Address(RVA = "0xB67B3C", Offset = "0xB67B3C", VA = "0xB67B3C")]
	[DebuggerHidden]
	private IEnumerator UpdateHealthBarEndOfFrame()
	{
		return null;
	}

	[Token(Token = "0x60024EF")]
	[Address(RVA = "0xB67BE8", Offset = "0xB67BE8", VA = "0xB67BE8", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x60024F0")]
	[Address(RVA = "0xB67D24", Offset = "0xB67D24", VA = "0xB67D24", Slot = "23")]
	public override void OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x60024F1")]
	[Address(RVA = "0xB67EC4", Offset = "0xB67EC4", VA = "0xB67EC4", Slot = "24")]
	public override void OnActorTag()
	{
	}

	[Token(Token = "0x60024F2")]
	[Address(RVA = "0xB681C0", Offset = "0xB681C0", VA = "0xB681C0", Slot = "25")]
	public override void OnGainBuff(XBuff buff)
	{
	}

	[Token(Token = "0x60024F3")]
	[Address(RVA = "0xB6852C", Offset = "0xB6852C", VA = "0xB6852C", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x60024F4")]
	[Address(RVA = "0xB68530", Offset = "0xB68530", VA = "0xB68530", Slot = "45")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x60024F5")]
	[Address(RVA = "0xB67AA0", Offset = "0xB67AA0", VA = "0xB67AA0")]
	public void HideHealthBar()
	{
	}

	[Token(Token = "0x60024F6")]
	[Address(RVA = "0xB68560", Offset = "0xB68560", VA = "0xB68560")]
	public void ShowHealthBar()
	{
	}

	[Token(Token = "0x60024F7")]
	[Address(RVA = "0xB68578", Offset = "0xB68578", VA = "0xB68578")]
	public void AddReciever(IModuleInterfaceEventReciever reciever)
	{
	}
}
