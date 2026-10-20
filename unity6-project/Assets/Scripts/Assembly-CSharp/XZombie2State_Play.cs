using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005E9")]
public class XZombie2State_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x20005EA")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator6B : IDisposable
	{
		[Token(Token = "0x4001C8D")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001C8E")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001C8F")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001C90")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001C91")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001C92")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001C93")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001C94")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x1700078E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003283")]
			[Address(RVA = "0x23D9B7C", Offset = "0x23D9B7C", VA = "0x23D9B7C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700078F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003284")]
			[Address(RVA = "0x23D9B84", Offset = "0x23D9B84", VA = "0x23D9B84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003282")]
		[Address(RVA = "0x23D87AC", Offset = "0x23D87AC", VA = "0x23D87AC")]
		public _003CRepositionMyPlayer_003Ec__Iterator6B()
		{
		}

		[Token(Token = "0x6003283")]
		[Address(RVA = "0x23D9B7C", Offset = "0x23D9B7C", VA = "0x23D9B7C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003284")]
		[Address(RVA = "0x23D9B84", Offset = "0x23D9B84", VA = "0x23D9B84", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003285")]
		[Address(RVA = "0x23D9B8C", Offset = "0x23D9B8C", VA = "0x23D9B8C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003286")]
		[Address(RVA = "0x23D9D14", Offset = "0x23D9D14", VA = "0x23D9D14", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003287")]
		[Address(RVA = "0x23D9D20", Offset = "0x23D9D20", VA = "0x23D9D20", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20005EB")]
	private sealed class _003CRefreshTopUI_003Ec__Iterator6C : IDisposable
	{
		[Token(Token = "0x4001C95")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001C96")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x17000790")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003289")]
			[Address(RVA = "0x23D9984", Offset = "0x23D9984", VA = "0x23D9984", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000791")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600328A")]
			[Address(RVA = "0x23D998C", Offset = "0x23D998C", VA = "0x23D998C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003288")]
		[Address(RVA = "0x23D92C4", Offset = "0x23D92C4", VA = "0x23D92C4")]
		public _003CRefreshTopUI_003Ec__Iterator6C()
		{
		}

		[Token(Token = "0x6003289")]
		[Address(RVA = "0x23D9984", Offset = "0x23D9984", VA = "0x23D9984", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600328A")]
		[Address(RVA = "0x23D998C", Offset = "0x23D998C", VA = "0x23D998C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600328B")]
		[Address(RVA = "0x23D9994", Offset = "0x23D9994", VA = "0x23D9994", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600328C")]
		[Address(RVA = "0x23D9ADC", Offset = "0x23D9ADC", VA = "0x23D9ADC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600328D")]
		[Address(RVA = "0x23D9AE8", Offset = "0x23D9AE8", VA = "0x23D9AE8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001C87")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001C88")]
	[FieldOffset(Offset = "0x28")]
	private string endCountDownSoundKey;

	[Token(Token = "0x4001C89")]
	[FieldOffset(Offset = "0x2C")]
	private XZombie2Rule m_Rule;

	[Token(Token = "0x4001C8A")]
	[FieldOffset(Offset = "0x30")]
	private XRoundTimer m_RoundTimer;

	[Token(Token = "0x4001C8B")]
	[FieldOffset(Offset = "0x34")]
	private int m_nCurrentRound;

	[Token(Token = "0x4001C8C")]
	[FieldOffset(Offset = "0x38")]
	private float m_fRefreshLifeUI;

	[Token(Token = "0x1700078C")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6003280")]
		[Address(RVA = "0x23D9950", Offset = "0x23D9950", VA = "0x23D9950")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700078D")]
	public int CurrentRound
	{
		[Token(Token = "0x6003281")]
		[Address(RVA = "0x23D997C", Offset = "0x23D997C", VA = "0x23D997C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003267")]
	[Address(RVA = "0x23D785C", Offset = "0x23D785C", VA = "0x23D785C")]
	public XZombie2State_Play()
	{
	}

	[Token(Token = "0x6003268")]
	[Address(RVA = "0x23D795C", Offset = "0x23D795C", VA = "0x23D795C", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003269")]
	[Address(RVA = "0x23D8090", Offset = "0x23D8090", VA = "0x23D8090")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x600326A")]
	[Address(RVA = "0x23D80C4", Offset = "0x23D80C4", VA = "0x23D80C4", Slot = "20")]
	protected override void EachActorDoOnGameStart(XModuleEntity eachActor)
	{
	}

	[Token(Token = "0x600326B")]
	[Address(RVA = "0x23D7ADC", Offset = "0x23D7ADC", VA = "0x23D7ADC")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x600326C")]
	[Address(RVA = "0x23D8100", Offset = "0x23D8100", VA = "0x23D8100", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x600326D")]
	[Address(RVA = "0x23D8278", Offset = "0x23D8278", VA = "0x23D8278", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x600326E")]
	[Address(RVA = "0x23D8390", Offset = "0x23D8390", VA = "0x23D8390")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x600326F")]
	[Address(RVA = "0x23D86E8", Offset = "0x23D86E8", VA = "0x23D86E8")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}

	[Token(Token = "0x6003270")]
	[Address(RVA = "0x23D8508", Offset = "0x23D8508", VA = "0x23D8508")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6003271")]
	[Address(RVA = "0x23D87B4", Offset = "0x23D87B4", VA = "0x23D87B4")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeamEnum, bool onReconnect)
	{
	}

	[Token(Token = "0x6003272")]
	[Address(RVA = "0x23D8B00", Offset = "0x23D8B00", VA = "0x23D8B00", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6003273")]
	[Address(RVA = "0x23D8DAC", Offset = "0x23D8DAC", VA = "0x23D8DAC", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6003274")]
	[Address(RVA = "0x23D8E80", Offset = "0x23D8E80", VA = "0x23D8E80")]
	private void CheckEscapePlayerKill()
	{
	}

	[Token(Token = "0x6003275")]
	[Address(RVA = "0x23D7D9C", Offset = "0x23D7D9C", VA = "0x23D7D9C")]
	public void OnRoundStart(int nRound, bool isFirst = false)
	{
	}

	[Token(Token = "0x6003276")]
	[Address(RVA = "0x23D9238", Offset = "0x23D9238", VA = "0x23D9238")]
	[DebuggerHidden]
	private IEnumerator RefreshTopUI()
	{
		return null;
	}

	[Token(Token = "0x6003277")]
	[Address(RVA = "0x23D92CC", Offset = "0x23D92CC", VA = "0x23D92CC")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6003278")]
	[Address(RVA = "0x23D93C0", Offset = "0x23D93C0", VA = "0x23D93C0")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6003279")]
	[Address(RVA = "0x23D9150", Offset = "0x23D9150", VA = "0x23D9150")]
	public void StartRespawnPlayer()
	{
	}

	[Token(Token = "0x600327A")]
	[Address(RVA = "0x23D93EC", Offset = "0x23D93EC", VA = "0x23D93EC")]
	private void RespawnMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x600327B")]
	[Address(RVA = "0x23D94D4", Offset = "0x23D94D4", VA = "0x23D94D4")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x600327C")]
	[Address(RVA = "0x23D96E4", Offset = "0x23D96E4", VA = "0x23D96E4")]
	public void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x600327D")]
	[Address(RVA = "0x23D9784", Offset = "0x23D9784", VA = "0x23D9784")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x600327E")]
	[Address(RVA = "0x23D85D4", Offset = "0x23D85D4", VA = "0x23D85D4")]
	public new void SetPlayerState(CSPlayerState state)
	{
	}

	[Token(Token = "0x600327F")]
	[Address(RVA = "0x23D97E8", Offset = "0x23D97E8", VA = "0x23D97E8", Slot = "26")]
	protected virtual bool IsMasterClient()
	{
		return default(bool);
	}
}
