using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200057E")]
public class XKOFState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x200057F")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator61 : IDisposable
	{
		[Token(Token = "0x4001B1C")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001B1D")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleEntity _003CmyPlayerME_003E__0;

		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x14")]
		internal int myIndex;

		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x4001B21")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x20")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x24")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x28")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x2C")]
		internal XKOFState_Play _003C_003Ef__this;

		[Token(Token = "0x17000739")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002ED8")]
			[Address(RVA = "0x1D3E650", Offset = "0x1D3E650", VA = "0x1D3E650", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700073A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002ED9")]
			[Address(RVA = "0x1D3E658", Offset = "0x1D3E658", VA = "0x1D3E658", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002ED7")]
		[Address(RVA = "0x1D3D1F0", Offset = "0x1D3D1F0", VA = "0x1D3D1F0")]
		public _003CRepositionMyPlayer_003Ec__Iterator61()
		{
		}

		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x1D3E650", Offset = "0x1D3E650", VA = "0x1D3E650", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x1D3E658", Offset = "0x1D3E658", VA = "0x1D3E658", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x1D3E660", Offset = "0x1D3E660", VA = "0x1D3E660", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x1D3E9C4", Offset = "0x1D3E9C4", VA = "0x1D3E9C4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x1D3E9D0", Offset = "0x1D3E9D0", VA = "0x1D3E9D0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000580")]
	private sealed class _003CRefreshTopUI_003Ec__Iterator62 : IDisposable
	{
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001B27")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x1700073B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002EDE")]
			[Address(RVA = "0x1D3E458", Offset = "0x1D3E458", VA = "0x1D3E458", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700073C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002EDF")]
			[Address(RVA = "0x1D3E460", Offset = "0x1D3E460", VA = "0x1D3E460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002EDD")]
		[Address(RVA = "0x1D3DDAC", Offset = "0x1D3DDAC", VA = "0x1D3DDAC")]
		public _003CRefreshTopUI_003Ec__Iterator62()
		{
		}

		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x1D3E458", Offset = "0x1D3E458", VA = "0x1D3E458", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x1D3E460", Offset = "0x1D3E460", VA = "0x1D3E460", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002EE0")]
		[Address(RVA = "0x1D3E468", Offset = "0x1D3E468", VA = "0x1D3E468", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x1D3E5B0", Offset = "0x1D3E5B0", VA = "0x1D3E5B0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x1D3E5BC", Offset = "0x1D3E5BC", VA = "0x1D3E5BC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001B18")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001B19")]
	[FieldOffset(Offset = "0x28")]
	private XKOFRule m_Rule;

	[Token(Token = "0x4001B1A")]
	[FieldOffset(Offset = "0x2C")]
	private XRoundTimer m_RoundTimer;

	[Token(Token = "0x4001B1B")]
	[FieldOffset(Offset = "0x30")]
	private int m_nCurrentRound;

	[Token(Token = "0x17000737")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x1D3E424", Offset = "0x1D3E424", VA = "0x1D3E424")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000738")]
	public int CurrentRound
	{
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x1D3E450", Offset = "0x1D3E450", VA = "0x1D3E450")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x1D3C44C", Offset = "0x1D3C44C", VA = "0x1D3C44C")]
	public XKOFState_Play()
	{
	}

	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0x1D3C548", Offset = "0x1D3C548", VA = "0x1D3C548", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x1D3C978", Offset = "0x1D3C978", VA = "0x1D3C978", Slot = "21")]
	protected override void ShowGameStart()
	{
	}

	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x1D3CBB4", Offset = "0x1D3CBB4", VA = "0x1D3CBB4")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x6002EBF")]
	[Address(RVA = "0x1D3CBE4", Offset = "0x1D3CBE4", VA = "0x1D3CBE4", Slot = "20")]
	protected override void EachActorDoOnGameStart(XModuleEntity eachActor)
	{
	}

	[Token(Token = "0x6002EC0")]
	[Address(RVA = "0x1D3C6B8", Offset = "0x1D3C6B8", VA = "0x1D3C6B8")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x6002EC1")]
	[Address(RVA = "0x1D3CC20", Offset = "0x1D3CC20", VA = "0x1D3CC20", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x1D3CD98", Offset = "0x1D3CD98", VA = "0x1D3CD98", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x1D3CEB0", Offset = "0x1D3CEB0", VA = "0x1D3CEB0")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x1D3D124", Offset = "0x1D3D124", VA = "0x1D3D124")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}

	[Token(Token = "0x6002EC5")]
	[Address(RVA = "0x1D3D1F8", Offset = "0x1D3D1F8", VA = "0x1D3D1F8")]
	private int GetWinnerBuffID()
	{
		return default(int);
	}

	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x1D3D058", Offset = "0x1D3D058", VA = "0x1D3D058")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002EC7")]
	[Address(RVA = "0x1D3D27C", Offset = "0x1D3D27C", VA = "0x1D3D27C")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeamEnum, bool onReconnect)
	{
	}

	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x1D3D5C8", Offset = "0x1D3D5C8", VA = "0x1D3D5C8", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002EC9")]
	[Address(RVA = "0x1D3D874", Offset = "0x1D3D874", VA = "0x1D3D874", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002ECA")]
	[Address(RVA = "0x1D3D940", Offset = "0x1D3D940", VA = "0x1D3D940")]
	private void CheckEscapePlayerKill()
	{
	}

	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x1D39674", Offset = "0x1D39674", VA = "0x1D39674")]
	public void OnRoundStart(int nRound, bool isFirst = false)
	{
	}

	[Token(Token = "0x6002ECC")]
	[Address(RVA = "0x1D3DD20", Offset = "0x1D3DD20", VA = "0x1D3DD20")]
	[DebuggerHidden]
	private IEnumerator RefreshTopUI()
	{
		return null;
	}

	[Token(Token = "0x6002ECD")]
	[Address(RVA = "0x1D3DDB4", Offset = "0x1D3DDB4", VA = "0x1D3DDB4")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6002ECE")]
	[Address(RVA = "0x1D3DEA8", Offset = "0x1D3DEA8", VA = "0x1D3DEA8")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6002ECF")]
	[Address(RVA = "0x1D3DC10", Offset = "0x1D3DC10", VA = "0x1D3DC10")]
	public void StartRespawnPlayer()
	{
	}

	[Token(Token = "0x6002ED0")]
	[Address(RVA = "0x1D3DED0", Offset = "0x1D3DED0", VA = "0x1D3DED0")]
	private void RespawnMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002ED1")]
	[Address(RVA = "0x1D3DFB8", Offset = "0x1D3DFB8", VA = "0x1D3DFB8")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002ED2")]
	[Address(RVA = "0x1D3E1BC", Offset = "0x1D3E1BC", VA = "0x1D3E1BC")]
	public void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x1D3E25C", Offset = "0x1D3E25C", VA = "0x1D3E25C")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x1D3E2BC", Offset = "0x1D3E2BC", VA = "0x1D3E2BC", Slot = "26")]
	protected virtual bool IsMasterClient()
	{
		return default(bool);
	}
}
