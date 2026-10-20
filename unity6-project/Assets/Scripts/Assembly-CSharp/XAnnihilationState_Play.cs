using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200054E")]
public class XAnnihilationState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x200054F")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator53 : IDisposable
	{
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x1700070A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002D4B")]
			[Address(RVA = "0x1EE8754", Offset = "0x1EE8754", VA = "0x1EE8754", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700070B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D4C")]
			[Address(RVA = "0x1EE875C", Offset = "0x1EE875C", VA = "0x1EE875C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D4A")]
		[Address(RVA = "0x1EE73A8", Offset = "0x1EE73A8", VA = "0x1EE73A8")]
		public _003CRepositionMyPlayer_003Ec__Iterator53()
		{
		}

		[Token(Token = "0x6002D4B")]
		[Address(RVA = "0x1EE8754", Offset = "0x1EE8754", VA = "0x1EE8754", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0x1EE875C", Offset = "0x1EE875C", VA = "0x1EE875C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x1EE8764", Offset = "0x1EE8764", VA = "0x1EE8764", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x1EE88EC", Offset = "0x1EE88EC", VA = "0x1EE88EC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x1EE88F8", Offset = "0x1EE88F8", VA = "0x1EE88F8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000550")]
	private sealed class _003CRefreshTopUI_003Ec__Iterator54 : IDisposable
	{
		[Token(Token = "0x4001A88")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001A89")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x1700070C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002D51")]
			[Address(RVA = "0x1EE855C", Offset = "0x1EE855C", VA = "0x1EE855C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700070D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D52")]
			[Address(RVA = "0x1EE8564", Offset = "0x1EE8564", VA = "0x1EE8564", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x1EE7EB8", Offset = "0x1EE7EB8", VA = "0x1EE7EB8")]
		public _003CRefreshTopUI_003Ec__Iterator54()
		{
		}

		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x1EE855C", Offset = "0x1EE855C", VA = "0x1EE855C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x1EE8564", Offset = "0x1EE8564", VA = "0x1EE8564", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x1EE856C", Offset = "0x1EE856C", VA = "0x1EE856C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D54")]
		[Address(RVA = "0x1EE86B4", Offset = "0x1EE86B4", VA = "0x1EE86B4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x1EE86C0", Offset = "0x1EE86C0", VA = "0x1EE86C0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001A7A")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001A7B")]
	[FieldOffset(Offset = "0x28")]
	private string endCountDownSoundKey;

	[Token(Token = "0x4001A7C")]
	[FieldOffset(Offset = "0x2C")]
	private XAnnihilationRule m_Rule;

	[Token(Token = "0x4001A7D")]
	[FieldOffset(Offset = "0x30")]
	private XRoundTimer m_RoundTimer;

	[Token(Token = "0x4001A7E")]
	[FieldOffset(Offset = "0x34")]
	private int m_nCurrentRound;

	[Token(Token = "0x4001A7F")]
	[FieldOffset(Offset = "0x38")]
	private float m_fRefreshLifeUI;

	[Token(Token = "0x17000708")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002D48")]
		[Address(RVA = "0x1EE8528", Offset = "0x1EE8528", VA = "0x1EE8528")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000709")]
	public int CurrentRound
	{
		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x1EE8554", Offset = "0x1EE8554", VA = "0x1EE8554")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002D2F")]
	[Address(RVA = "0x1EE6750", Offset = "0x1EE6750", VA = "0x1EE6750")]
	public XAnnihilationState_Play()
	{
	}

	[Token(Token = "0x6002D30")]
	[Address(RVA = "0x1EE6860", Offset = "0x1EE6860", VA = "0x1EE6860", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002D31")]
	[Address(RVA = "0x1EE6C90", Offset = "0x1EE6C90", VA = "0x1EE6C90")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x1EE6CC0", Offset = "0x1EE6CC0", VA = "0x1EE6CC0", Slot = "20")]
	protected override void EachActorDoOnGameStart(XModuleEntity eachActor)
	{
	}

	[Token(Token = "0x6002D33")]
	[Address(RVA = "0x1EE69D0", Offset = "0x1EE69D0", VA = "0x1EE69D0")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x6002D34")]
	[Address(RVA = "0x1EE6CFC", Offset = "0x1EE6CFC", VA = "0x1EE6CFC", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6002D35")]
	[Address(RVA = "0x1EE6E74", Offset = "0x1EE6E74", VA = "0x1EE6E74", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002D36")]
	[Address(RVA = "0x1EE6F8C", Offset = "0x1EE6F8C", VA = "0x1EE6F8C")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002D37")]
	[Address(RVA = "0x1EE72E4", Offset = "0x1EE72E4", VA = "0x1EE72E4")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}

	[Token(Token = "0x6002D38")]
	[Address(RVA = "0x1EE7104", Offset = "0x1EE7104", VA = "0x1EE7104")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002D39")]
	[Address(RVA = "0x1EE73B0", Offset = "0x1EE73B0", VA = "0x1EE73B0")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeamEnum, bool onReconnect)
	{
	}

	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x1EE76FC", Offset = "0x1EE76FC", VA = "0x1EE76FC", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x1EE79A8", Offset = "0x1EE79A8", VA = "0x1EE79A8", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x1EE7A74", Offset = "0x1EE7A74", VA = "0x1EE7A74")]
	private void CheckEscapePlayerKill()
	{
	}

	[Token(Token = "0x6002D3D")]
	[Address(RVA = "0x1EE3DB4", Offset = "0x1EE3DB4", VA = "0x1EE3DB4")]
	public void OnRoundStart(int nRound, bool isFirst = false)
	{
	}

	[Token(Token = "0x6002D3E")]
	[Address(RVA = "0x1EE7E2C", Offset = "0x1EE7E2C", VA = "0x1EE7E2C")]
	[DebuggerHidden]
	private IEnumerator RefreshTopUI()
	{
		return null;
	}

	[Token(Token = "0x6002D3F")]
	[Address(RVA = "0x1EE7EC0", Offset = "0x1EE7EC0", VA = "0x1EE7EC0")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6002D40")]
	[Address(RVA = "0x1EE7FB4", Offset = "0x1EE7FB4", VA = "0x1EE7FB4")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x1EE7D44", Offset = "0x1EE7D44", VA = "0x1EE7D44")]
	public void StartRespawnPlayer()
	{
	}

	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x1EE7FDC", Offset = "0x1EE7FDC", VA = "0x1EE7FDC")]
	private void RespawnMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x1EE80C4", Offset = "0x1EE80C4", VA = "0x1EE80C4")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x1EE82C0", Offset = "0x1EE82C0", VA = "0x1EE82C0")]
	public void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x1EE8360", Offset = "0x1EE8360", VA = "0x1EE8360")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002D46")]
	[Address(RVA = "0x1EE71D0", Offset = "0x1EE71D0", VA = "0x1EE71D0")]
	public new void SetPlayerState(CSPlayerState state)
	{
	}

	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x1EE83C0", Offset = "0x1EE83C0", VA = "0x1EE83C0", Slot = "26")]
	protected virtual bool IsMasterClient()
	{
		return default(bool);
	}
}
