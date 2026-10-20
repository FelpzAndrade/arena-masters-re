using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005FA")]
public class XZombieTagState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x20005FB")]
	private sealed class _003CRefreshTopUI_003Ec__Iterator6F : IDisposable
	{
		[Token(Token = "0x4001CC3")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001CC4")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x1700079C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003313")]
			[Address(RVA = "0x23E3288", Offset = "0x23E3288", VA = "0x23E3288", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700079D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003314")]
			[Address(RVA = "0x23E3290", Offset = "0x23E3290", VA = "0x23E3290", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003312")]
		[Address(RVA = "0x23E1544", Offset = "0x23E1544", VA = "0x23E1544")]
		public _003CRefreshTopUI_003Ec__Iterator6F()
		{
		}

		[Token(Token = "0x6003313")]
		[Address(RVA = "0x23E3288", Offset = "0x23E3288", VA = "0x23E3288", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003314")]
		[Address(RVA = "0x23E3290", Offset = "0x23E3290", VA = "0x23E3290", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003315")]
		[Address(RVA = "0x23E3298", Offset = "0x23E3298", VA = "0x23E3298", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003316")]
		[Address(RVA = "0x23E33E0", Offset = "0x23E33E0", VA = "0x23E33E0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003317")]
		[Address(RVA = "0x23E33EC", Offset = "0x23E33EC", VA = "0x23E33EC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20005FC")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator70 : IDisposable
	{
		[Token(Token = "0x4001CC5")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001CC6")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001CC7")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001CC8")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001CC9")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001CCA")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001CCB")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001CCC")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x1700079E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003319")]
			[Address(RVA = "0x23E3480", Offset = "0x23E3480", VA = "0x23E3480", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700079F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600331A")]
			[Address(RVA = "0x23E3488", Offset = "0x23E3488", VA = "0x23E3488", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003318")]
		[Address(RVA = "0x23E1EAC", Offset = "0x23E1EAC", VA = "0x23E1EAC")]
		public _003CRepositionMyPlayer_003Ec__Iterator70()
		{
		}

		[Token(Token = "0x6003319")]
		[Address(RVA = "0x23E3480", Offset = "0x23E3480", VA = "0x23E3480", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600331A")]
		[Address(RVA = "0x23E3488", Offset = "0x23E3488", VA = "0x23E3488", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600331B")]
		[Address(RVA = "0x23E3490", Offset = "0x23E3490", VA = "0x23E3490", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600331C")]
		[Address(RVA = "0x23E3618", Offset = "0x23E3618", VA = "0x23E3618", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600331D")]
		[Address(RVA = "0x23E3624", Offset = "0x23E3624", VA = "0x23E3624", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001CBE")]
	[FieldOffset(Offset = "0x24")]
	private XZombieTagRule m_Rule;

	[Token(Token = "0x4001CBF")]
	[FieldOffset(Offset = "0x28")]
	private XRoundTimer m_RoundTimer;

	[Token(Token = "0x4001CC0")]
	[FieldOffset(Offset = "0x2C")]
	private int m_nCurrentRound;

	[Token(Token = "0x4001CC1")]
	[FieldOffset(Offset = "0x30")]
	private XGameModeData_ZombieTag m_GameModeData;

	[Token(Token = "0x4001CC2")]
	[FieldOffset(Offset = "0x34")]
	private XGameModeLocalData_ZombieTag m_GameModeLocalData;

	[Token(Token = "0x1700079A")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x600330A")]
		[Address(RVA = "0x23E2A20", Offset = "0x23E2A20", VA = "0x23E2A20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700079B")]
	public int CurrentRound
	{
		[Token(Token = "0x600330B")]
		[Address(RVA = "0x23E2A4C", Offset = "0x23E2A4C", VA = "0x23E2A4C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60032F1")]
	[Address(RVA = "0x23E0858", Offset = "0x23E0858", VA = "0x23E0858")]
	public XZombieTagState_Play()
	{
	}

	[Token(Token = "0x60032F2")]
	[Address(RVA = "0x23E0920", Offset = "0x23E0920", VA = "0x23E0920", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60032F3")]
	[Address(RVA = "0x23E0EC8", Offset = "0x23E0EC8", VA = "0x23E0EC8")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x60032F4")]
	[Address(RVA = "0x23DC000", Offset = "0x23DC000", VA = "0x23DC000")]
	public void OnRoundStart(int nRound, bool isFirst = false)
	{
	}

	[Token(Token = "0x60032F5")]
	[Address(RVA = "0x23E0EFC", Offset = "0x23E0EFC", VA = "0x23E0EFC")]
	private void CheckEscapePlayerKill()
	{
	}

	[Token(Token = "0x60032F6")]
	[Address(RVA = "0x23E14B8", Offset = "0x23E14B8", VA = "0x23E14B8")]
	[DebuggerHidden]
	private IEnumerator RefreshTopUI()
	{
		return null;
	}

	[Token(Token = "0x60032F7")]
	[Address(RVA = "0x23E154C", Offset = "0x23E154C", VA = "0x23E154C")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x60032F8")]
	[Address(RVA = "0x23E1640", Offset = "0x23E1640", VA = "0x23E1640")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x60032F9")]
	[Address(RVA = "0x23E166C", Offset = "0x23E166C", VA = "0x23E166C", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x23E0C08", Offset = "0x23E0C08", VA = "0x23E0C08")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x60032FB")]
	[Address(RVA = "0x23E1750", Offset = "0x23E1750", VA = "0x23E1750", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x23E13D0", Offset = "0x23E13D0", VA = "0x23E13D0")]
	public void StartRespawnPlayer()
	{
	}

	[Token(Token = "0x60032FD")]
	[Address(RVA = "0x23E19DC", Offset = "0x23E19DC", VA = "0x23E19DC")]
	private void RespawnMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x60032FE")]
	[Address(RVA = "0x23E1C3C", Offset = "0x23E1C3C", VA = "0x23E1C3C", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x60032FF")]
	[Address(RVA = "0x23E1AC4", Offset = "0x23E1AC4", VA = "0x23E1AC4")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6003300")]
	[Address(RVA = "0x23E1DE8", Offset = "0x23E1DE8", VA = "0x23E1DE8")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}

	[Token(Token = "0x6003301")]
	[Address(RVA = "0x23E1D1C", Offset = "0x23E1D1C", VA = "0x23E1D1C")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6003302")]
	[Address(RVA = "0x23E1EB4", Offset = "0x23E1EB4", VA = "0x23E1EB4")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6003303")]
	[Address(RVA = "0x23E20C4", Offset = "0x23E20C4", VA = "0x23E20C4")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeamEnum, bool onReconnect)
	{
	}

	[Token(Token = "0x6003304")]
	[Address(RVA = "0x23E2410", Offset = "0x23E2410", VA = "0x23E2410", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6003305")]
	[Address(RVA = "0x23E26BC", Offset = "0x23E26BC", VA = "0x23E26BC")]
	public void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6003306")]
	[Address(RVA = "0x23E18C8", Offset = "0x23E18C8", VA = "0x23E18C8")]
	public new void SetPlayerState(CSPlayerState state)
	{
	}

	[Token(Token = "0x6003307")]
	[Address(RVA = "0x23E275C", Offset = "0x23E275C", VA = "0x23E275C", Slot = "26")]
	protected virtual bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6003308")]
	[Address(RVA = "0x23E28C4", Offset = "0x23E28C4", VA = "0x23E28C4")]
	public void OnSyncGameModeData(NetData_ZombieTagGameModeData gameModeNetData)
	{
	}

	[Token(Token = "0x6003309")]
	[Address(RVA = "0x23E2930", Offset = "0x23E2930", VA = "0x23E2930")]
	public void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x600330C")]
	[Address(RVA = "0x23E11CC", Offset = "0x23E11CC", VA = "0x23E11CC")]
	private void LostZombieBuff()
	{
	}

	[Token(Token = "0x600330D")]
	[Address(RVA = "0x23E2A54", Offset = "0x23E2A54", VA = "0x23E2A54")]
	public void AddAdvantageBuff()
	{
	}

	[Token(Token = "0x600330E")]
	[Address(RVA = "0x23E2B8C", Offset = "0x23E2B8C", VA = "0x23E2B8C")]
	public void AddZombieBuff()
	{
	}

	[Token(Token = "0x600330F")]
	[Address(RVA = "0x23E2C88", Offset = "0x23E2C88", VA = "0x23E2C88")]
	private void SetPlayerLostZombieHp()
	{
	}

	[Token(Token = "0x6003310")]
	[Address(RVA = "0x23E2DDC", Offset = "0x23E2DDC", VA = "0x23E2DDC")]
	public void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6003311")]
	[Address(RVA = "0x23E2DE0", Offset = "0x23E2DE0", VA = "0x23E2DE0")]
	public void OnHit(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}
}
