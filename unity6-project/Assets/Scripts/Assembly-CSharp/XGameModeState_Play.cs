using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005A5")]
public class XGameModeState_Play : XGameModeState
{
	[Token(Token = "0x20005A6")]
	private sealed class _003CCoroutineShowGoalMessage_003Ec__Iterator49 : IDisposable
	{
		[Token(Token = "0x4001B7A")]
		[FieldOffset(Offset = "0x8")]
		internal string _003CstrMessage_003E__0;

		[Token(Token = "0x4001B7B")]
		[FieldOffset(Offset = "0xC")]
		internal GameModeInfo _003CgameModeInfo_003E__1;

		[Token(Token = "0x4001B7C")]
		[FieldOffset(Offset = "0x10")]
		internal XTeamEnum _003CmyTeam_003E__2;

		[Token(Token = "0x4001B7D")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001B7E")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001B7F")]
		[FieldOffset(Offset = "0x1C")]
		internal XGameModeState_Play _003C_003Ef__this;

		[Token(Token = "0x17000764")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600305B")]
			[Address(RVA = "0x141C26C", Offset = "0x141C26C", VA = "0x141C26C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000765")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600305C")]
			[Address(RVA = "0x141C274", Offset = "0x141C274", VA = "0x141C274", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600305A")]
		[Address(RVA = "0x141B4EC", Offset = "0x141B4EC", VA = "0x141B4EC")]
		public _003CCoroutineShowGoalMessage_003Ec__Iterator49()
		{
		}

		[Token(Token = "0x600305B")]
		[Address(RVA = "0x141C26C", Offset = "0x141C26C", VA = "0x141C26C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600305C")]
		[Address(RVA = "0x141C274", Offset = "0x141C274", VA = "0x141C274", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600305D")]
		[Address(RVA = "0x141C27C", Offset = "0x141C27C", VA = "0x141C27C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600305E")]
		[Address(RVA = "0x141C83C", Offset = "0x141C83C", VA = "0x141C83C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600305F")]
		[Address(RVA = "0x141C848", Offset = "0x141C848", VA = "0x141C848", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001B73")]
	protected const float m_fDropObjectSpawnerTick = 0.5f;

	[Token(Token = "0x4001B74")]
	[FieldOffset(Offset = "0x11")]
	protected bool m_bClosedRoom;

	[Token(Token = "0x4001B75")]
	[FieldOffset(Offset = "0x14")]
	protected float m_fSyncElapsedTime;

	[Token(Token = "0x4001B76")]
	[FieldOffset(Offset = "0x18")]
	protected XDropObjectSpawner m_DropObjectSpawner;

	[Token(Token = "0x4001B77")]
	[FieldOffset(Offset = "0x1C")]
	protected float m_fDropObjectSpawnerElapsedTime;

	[Token(Token = "0x4001B78")]
	[FieldOffset(Offset = "0x20")]
	protected XGimmickManager m_GimmickManager;

	[Token(Token = "0x4001B79")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map8;

	[Token(Token = "0x6003042")]
	[Address(RVA = "0x1419A14", Offset = "0x1419A14", VA = "0x1419A14")]
	public XGameModeState_Play()
	{
	}

	[Token(Token = "0x6003043")]
	[Address(RVA = "0x1419AB0", Offset = "0x1419AB0", VA = "0x1419AB0", Slot = "15")]
	public override XGameModeStateType GetGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x6003044")]
	[Address(RVA = "0x1419AB8", Offset = "0x1419AB8", VA = "0x1419AB8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003045")]
	[Address(RVA = "0x141A68C", Offset = "0x141A68C", VA = "0x141A68C")]
	private void OnWorkingStateExitAction(int index, XMapGimmickWorkingState gimmickWorkingState)
	{
	}

	[Token(Token = "0x6003046")]
	[Address(RVA = "0x141A900", Offset = "0x141A900", VA = "0x141A900")]
	public void OnEnterWorkingState(int index, XMapGimmickWorkingState enterGimmickWorkingState)
	{
	}

	[Token(Token = "0x6003047")]
	[Address(RVA = "0x141A3DC", Offset = "0x141A3DC", VA = "0x141A3DC")]
	private void CalcGameModeInfo(XModuleEntity myPlayer)
	{
	}

	[Token(Token = "0x6003048")]
	[Address(RVA = "0x141A92C", Offset = "0x141A92C", VA = "0x141A92C")]
	private void TapjoyMatchStartLog(GameModeInfo gameModeInfo)
	{
	}

	[Token(Token = "0x6003049")]
	[Address(RVA = "0x141AB88", Offset = "0x141AB88", VA = "0x141AB88")]
	private void CalcStartBattleSound(XModuleEntity myPlayer, GameModeInfo gameModeInfo)
	{
	}

	[Token(Token = "0x600304A")]
	[Address(RVA = "0x141AD9C", Offset = "0x141AD9C", VA = "0x141AD9C")]
	private XModuleActor GetMyTeamOnePlayer(XModuleEntity myPlayer)
	{
		return null;
	}

	[Token(Token = "0x600304B")]
	[Address(RVA = "0x141A1D4", Offset = "0x141A1D4", VA = "0x141A1D4")]
	private void OnGameStart()
	{
	}

	[Token(Token = "0x600304C")]
	[Address(RVA = "0x141B0CC", Offset = "0x141B0CC", VA = "0x141B0CC", Slot = "19")]
	protected virtual void RequestStartGameForIntruder()
	{
	}

	[Token(Token = "0x600304D")]
	[Address(RVA = "0x141B1CC", Offset = "0x141B1CC", VA = "0x141B1CC", Slot = "20")]
	protected virtual void EachActorDoOnGameStart(XModuleEntity eachActor)
	{
	}

	[Token(Token = "0x600304E")]
	[Address(RVA = "0x141B1D0", Offset = "0x141B1D0", VA = "0x141B1D0", Slot = "21")]
	protected virtual void ShowGameStart()
	{
	}

	[Token(Token = "0x600304F")]
	[Address(RVA = "0x141A338", Offset = "0x141A338", VA = "0x141A338")]
	[DebuggerHidden]
	private IEnumerator CoroutineShowGoalMessage()
	{
		return null;
	}

	[Token(Token = "0x6003050")]
	[Address(RVA = "0x141B4F4", Offset = "0x141B4F4", VA = "0x141B4F4", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6003051")]
	[Address(RVA = "0x141B7EC", Offset = "0x141B7EC", VA = "0x141B7EC")]
	private void UpdateGimmickManager(float modeRemainedTime)
	{
	}

	[Token(Token = "0x6003052")]
	[Address(RVA = "0x141B6B4", Offset = "0x141B6B4", VA = "0x141B6B4")]
	private void UpdateDropObjectSpawn(float fDeltaTime)
	{
	}

	[Token(Token = "0x6003053")]
	[Address(RVA = "0x141BEA0", Offset = "0x141BEA0", VA = "0x141BEA0")]
	private void SpawnDropObject(int groupIndex, int nSpawnID, int nCharID)
	{
	}

	[Token(Token = "0x6003054")]
	[Address(RVA = "0x141C064", Offset = "0x141C064", VA = "0x141C064", Slot = "22")]
	protected virtual bool CheckFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6003055")]
	[Address(RVA = "0x141BD7C", Offset = "0x141BD7C", VA = "0x141BD7C")]
	protected bool CheckTimeOut()
	{
		return default(bool);
	}

	[Token(Token = "0x6003056")]
	[Address(RVA = "0x141C0BC", Offset = "0x141C0BC", VA = "0x141C0BC", Slot = "23")]
	protected virtual void OnTimeout()
	{
	}

	[Token(Token = "0x6003057")]
	[Address(RVA = "0x141B818", Offset = "0x141B818", VA = "0x141B818")]
	private void UpdateCheckRoomClosed()
	{
	}

	[Token(Token = "0x6003058")]
	[Address(RVA = "0x141BBFC", Offset = "0x141BBFC", VA = "0x141BBFC")]
	protected void UpdateRoomInfoSync(float fDeltaTime)
	{
	}

	[Token(Token = "0x6003059")]
	[Address(RVA = "0x141C0C0", Offset = "0x141C0C0", VA = "0x141C0C0", Slot = "24")]
	protected virtual void SyncRoomInfo()
	{
	}
}
