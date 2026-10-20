using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200055D")]
public class XClassicState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x200055E")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator59 : IDisposable
	{
		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x1700071B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002DD7")]
			[Address(RVA = "0x1989EBC", Offset = "0x1989EBC", VA = "0x1989EBC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700071C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DD8")]
			[Address(RVA = "0x1989EC4", Offset = "0x1989EC4", VA = "0x1989EC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x19886A8", Offset = "0x19886A8", VA = "0x19886A8")]
		public _003CRepositionMyPlayer_003Ec__Iterator59()
		{
		}

		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x1989EBC", Offset = "0x1989EBC", VA = "0x1989EBC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x1989EC4", Offset = "0x1989EC4", VA = "0x1989EC4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x1989ECC", Offset = "0x1989ECC", VA = "0x1989ECC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x198A054", Offset = "0x198A054", VA = "0x198A054", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x198A060", Offset = "0x198A060", VA = "0x198A060", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200055F")]
	private sealed class _003CRefreshTopUI_003Ec__Iterator5A : IDisposable
	{
		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001ABF")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x1700071D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002DDD")]
			[Address(RVA = "0x1989CC4", Offset = "0x1989CC4", VA = "0x1989CC4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700071E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DDE")]
			[Address(RVA = "0x1989CCC", Offset = "0x1989CCC", VA = "0x1989CCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x1989604", Offset = "0x1989604", VA = "0x1989604")]
		public _003CRefreshTopUI_003Ec__Iterator5A()
		{
		}

		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x1989CC4", Offset = "0x1989CC4", VA = "0x1989CC4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x1989CCC", Offset = "0x1989CCC", VA = "0x1989CCC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DDF")]
		[Address(RVA = "0x1989CD4", Offset = "0x1989CD4", VA = "0x1989CD4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DE0")]
		[Address(RVA = "0x1989E1C", Offset = "0x1989E1C", VA = "0x1989E1C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x1989E28", Offset = "0x1989E28", VA = "0x1989E28", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001AB1")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001AB2")]
	[FieldOffset(Offset = "0x28")]
	private string endCountDownSoundKey;

	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x2C")]
	private XClassicRule m_Rule;

	[Token(Token = "0x4001AB4")]
	[FieldOffset(Offset = "0x30")]
	private XRoundTimer m_RoundTimer;

	[Token(Token = "0x4001AB5")]
	[FieldOffset(Offset = "0x34")]
	private int m_nCurrentRound;

	[Token(Token = "0x17000719")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x1989C90", Offset = "0x1989C90", VA = "0x1989C90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700071A")]
	public int CurrentRound
	{
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x1989CBC", Offset = "0x1989CBC", VA = "0x1989CBC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0x1987A6C", Offset = "0x1987A6C", VA = "0x1987A6C")]
	public XClassicState_Play()
	{
	}

	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0x1987B6C", Offset = "0x1987B6C", VA = "0x1987B6C", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x1987F8C", Offset = "0x1987F8C", VA = "0x1987F8C")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x1987FC0", Offset = "0x1987FC0", VA = "0x1987FC0", Slot = "20")]
	protected override void EachActorDoOnGameStart(XModuleEntity eachActor)
	{
	}

	[Token(Token = "0x6002DBF")]
	[Address(RVA = "0x1987CE4", Offset = "0x1987CE4", VA = "0x1987CE4")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0x1988004", Offset = "0x1988004", VA = "0x1988004", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x198817C", Offset = "0x198817C", VA = "0x198817C", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002DC2")]
	[Address(RVA = "0x1988294", Offset = "0x1988294", VA = "0x1988294")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002DC3")]
	[Address(RVA = "0x19885E4", Offset = "0x19885E4", VA = "0x19885E4")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}

	[Token(Token = "0x6002DC4")]
	[Address(RVA = "0x198840C", Offset = "0x198840C", VA = "0x198840C")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002DC5")]
	[Address(RVA = "0x19886B0", Offset = "0x19886B0", VA = "0x19886B0")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeamEnum, bool onReconnect)
	{
	}

	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0x19889FC", Offset = "0x19889FC", VA = "0x19889FC", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002DC7")]
	[Address(RVA = "0x1988CA8", Offset = "0x1988CA8", VA = "0x1988CA8", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002DC8")]
	[Address(RVA = "0x1988D8C", Offset = "0x1988D8C", VA = "0x1988D8C")]
	private void CheckEscapePlayerKill()
	{
	}

	[Token(Token = "0x6002DC9")]
	[Address(RVA = "0x1985C24", Offset = "0x1985C24", VA = "0x1985C24")]
	public void OnRoundStart(int nRound, bool isFirst = false)
	{
	}

	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0x1989578", Offset = "0x1989578", VA = "0x1989578")]
	[DebuggerHidden]
	private IEnumerator RefreshTopUI()
	{
		return null;
	}

	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x198960C", Offset = "0x198960C", VA = "0x198960C")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x1989700", Offset = "0x1989700", VA = "0x1989700")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0x1989490", Offset = "0x1989490", VA = "0x1989490")]
	public void StartRespawnPlayer()
	{
	}

	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0x198972C", Offset = "0x198972C", VA = "0x198972C")]
	private void RespawnMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002DCF")]
	[Address(RVA = "0x1989814", Offset = "0x1989814", VA = "0x1989814")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002DD0")]
	[Address(RVA = "0x1989A24", Offset = "0x1989A24", VA = "0x1989A24")]
	public void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002DD1")]
	[Address(RVA = "0x1989AC4", Offset = "0x1989AC4", VA = "0x1989AC4")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002DD2")]
	[Address(RVA = "0x19884D8", Offset = "0x19884D8", VA = "0x19884D8")]
	public new void SetPlayerState(CSPlayerState state)
	{
	}

	[Token(Token = "0x6002DD3")]
	[Address(RVA = "0x1989B28", Offset = "0x1989B28", VA = "0x1989B28", Slot = "26")]
	protected virtual bool IsMasterClient()
	{
		return default(bool);
	}
}
