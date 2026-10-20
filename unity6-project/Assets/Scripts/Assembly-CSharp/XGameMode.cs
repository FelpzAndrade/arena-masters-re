using System;
using System.Collections.Generic;
using CS;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200058C")]
public abstract class XGameMode
{
		protected XGameMode()
		{
		}

	[Token(Token = "0x200058D")]
	public class XPlayerTotalScoreComparer : IComparer<ObscuredInt>
	{
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x13FB2F4", Offset = "0x13FB2F4", VA = "0x13FB2F4")]
		public XPlayerTotalScoreComparer()
		{
		}

		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x13FEE8C", Offset = "0x13FEE8C", VA = "0x13FEE8C", Slot = "4")]
		public int Compare(ObscuredInt x, ObscuredInt y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4001B3B")]
	[FieldOffset(Offset = "0x8")]
	protected GameModeInfo m_GameModeInfo;

	[Token(Token = "0x4001B3C")]
	[FieldOffset(Offset = "0xC")]
	protected XGameModeStateMachine m_GameModeStateMachine;

	[Token(Token = "0x4001B3D")]
	[FieldOffset(Offset = "0x10")]
	protected bool m_bBlindSight;

	[Token(Token = "0x4001B3E")]
	[FieldOffset(Offset = "0x14")]
	protected ObscuredFloat m_fStartTime;

	[Token(Token = "0x4001B3F")]
	[FieldOffset(Offset = "0x28")]
	protected ObscuredFloat m_fTime;

	[Token(Token = "0x4001B40")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_bTimePause;

	[Token(Token = "0x4001B41")]
	[FieldOffset(Offset = "0x40")]
	protected int m_nWinnerPhotonID;

	[Token(Token = "0x4001B42")]
	[FieldOffset(Offset = "0x44")]
	private bool m_isReconnect;

	[Token(Token = "0x4001B43")]
	[FieldOffset(Offset = "0x48")]
	protected ObscuredInt m_goalKillCount;

	[Token(Token = "0x4001B44")]
	[FieldOffset(Offset = "0x58")]
	protected ObscuredFloat m_remainedTime;

	[Token(Token = "0x4001B45")]
	[FieldOffset(Offset = "0x0")]
	public static XPlayerTotalScoreComparer comparer;

	[Token(Token = "0x4001B46")]
	[FieldOffset(Offset = "0x6C")]
	private bool IsRevived__BackingField;

	[Token(Token = "0x4001B47")]
	[FieldOffset(Offset = "0x70")]
	private XGameModeData GameModeData__BackingField;

	[Token(Token = "0x4001B48")]
	[FieldOffset(Offset = "0x74")]
	private XGameModeLocalData GameModeLocalData__BackingField;

	[Token(Token = "0x4001B49")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XPlayer, ObscuredInt> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x1700073D")]
	public bool IsRevived
	{
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x13FB2FC", Offset = "0x13FB2FC", VA = "0x13FB2FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x13FB24C", Offset = "0x13FB24C", VA = "0x13FB24C")]
		set
		{
		}
	}

	[Token(Token = "0x1700073E")]
	public virtual float StartTime
	{
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x13FB304", Offset = "0x13FB304", VA = "0x13FB304", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700073F")]
	public bool TimePause
	{
		[Token(Token = "0x6002F21")]
		[Address(RVA = "0x13F5180", Offset = "0x13F5180", VA = "0x13F5180")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x13F5188", Offset = "0x13F5188", VA = "0x13F5188")]
		set
		{
		}
	}

	[Token(Token = "0x17000740")]
	public virtual XGameModeData GameModeData
	{
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x13FB3E4", Offset = "0x13FB3E4", VA = "0x13FB3E4", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x13FB3EC", Offset = "0x13FB3EC", VA = "0x13FB3EC", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000741")]
	public virtual XGameModeLocalData GameModeLocalData
	{
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x13FB3F4", Offset = "0x13FB3F4", VA = "0x13FB3F4", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x13FB3FC", Offset = "0x13FB3FC", VA = "0x13FB3FC", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17000742")]
	public virtual bool IsCleared
	{
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x13FB404", Offset = "0x13FB404", VA = "0x13FB404", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000743")]
	public int RespawnTime
	{
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x13FB5DC", Offset = "0x13FB5DC", VA = "0x13FB5DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000744")]
	public virtual float GameFullTime
	{
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x13FD604", Offset = "0x13FD604", VA = "0x13FD604", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000745")]
	public int GoalKillCount
	{
		[Token(Token = "0x6002F51")]
		[Address(RVA = "0x13FD784", Offset = "0x13FD784", VA = "0x13FD784")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000746")]
	public int GoalMaxKillCount
	{
		[Token(Token = "0x6002F52")]
		[Address(RVA = "0x13FD850", Offset = "0x13FD850", VA = "0x13FD850")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000747")]
	public virtual int MaxPlayerCount
	{
		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x13FD9C4", Offset = "0x13FD9C4", VA = "0x13FD9C4", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000748")]
	public GameModeInfo Info
	{
		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x13FB858", Offset = "0x13FB858", VA = "0x13FB858")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000749")]
	public XGameModeType Type
	{
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x13FD9E8", Offset = "0x13FD9E8", VA = "0x13FD9E8")]
		get
		{
			return default(XGameModeType);
		}
	}

	[Token(Token = "0x1700074A")]
	public virtual bool TimeOut
	{
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x13FDA0C", Offset = "0x13FDA0C", VA = "0x13FDA0C", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700074B")]
	public XGameModeStateType CurrentStateType
	{
		[Token(Token = "0x6002F57")]
		[Address(RVA = "0x13FDA38", Offset = "0x13FDA38", VA = "0x13FDA38")]
		get
		{
			return default(XGameModeStateType);
		}
	}

	[Token(Token = "0x1700074C")]
	public XGameModeState CurrentState
	{
		[Token(Token = "0x6002F58")]
		[Address(RVA = "0x13FDAB4", Offset = "0x13FDAB4", VA = "0x13FDAB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074D")]
	public float Time
	{
		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x13FDAD8", Offset = "0x13FDAD8", VA = "0x13FDAD8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700074E")]
	public float RemainedTime
	{
		[Token(Token = "0x6002F5B")]
		[Address(RVA = "0x13FDBB0", Offset = "0x13FDBB0", VA = "0x13FDBB0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x13FB078", Offset = "0x13FB078", VA = "0x13FB078")]
	public XGameMode(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x13FB3DC", Offset = "0x13FB3DC", VA = "0x13FB3DC")]
	public bool IsReconnect()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x13FB40C", Offset = "0x13FB40C", VA = "0x13FB40C", Slot = "10")]
	public virtual void SetStateMachine(XGameModeStateMachine stateMachine)
	{
	}

	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x13FB870", Offset = "0x13FB870", VA = "0x13FB870", Slot = "11")]
	public virtual void OnGameInit()
	{
	}

	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x13FBA2C", Offset = "0x13FBA2C", VA = "0x13FBA2C")]
	public void SetState_CountDown(Action action)
	{
	}

	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x13FBC04", Offset = "0x13FBC04", VA = "0x13FBC04")]
	public void SetState_Play(Action action)
	{
	}

	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x13FBC78", Offset = "0x13FBC78", VA = "0x13FBC78", Slot = "12")]
	public virtual List<Vector3> GetCurrentWayPoints()
	{
		return null;
	}

	[Token(Token = "0x6002F2F")]
	[Address(RVA = "0x13FBC80", Offset = "0x13FBC80", VA = "0x13FBC80", Slot = "13")]
	public virtual void InitPlayerTeam()
	{
	}

	[Token(Token = "0x6002F30")]
	[Address(RVA = "0x13FBC84", Offset = "0x13FBC84", VA = "0x13FBC84", Slot = "14")]
	public virtual void InitOnGetReady()
	{
	}

	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x13FBC88", Offset = "0x13FBC88", VA = "0x13FBC88")]
	public void GameInit()
	{
	}

	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x13FBCCC", Offset = "0x13FBCCC", VA = "0x13FBCCC")]
	public void Update(float dt)
	{
	}

	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x13FBEA0", Offset = "0x13FBEA0", VA = "0x13FBEA0")]
	public void FixedUpdate(float dt)
	{
	}

	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x13FBEE4", Offset = "0x13FBEE4", VA = "0x13FBEE4", Slot = "15")]
	public virtual void OnUpdate()
	{
	}

	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x13FBF58", Offset = "0x13FBF58", VA = "0x13FBF58", Slot = "16")]
	public virtual void OnFixedUpdate()
	{
	}

	[Token(Token = "0x6002F36")]
	[Address(RVA = "0x13FBFCC", Offset = "0x13FBFCC", VA = "0x13FBFCC")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6002F37")]
	[Address(RVA = "0x13FC118", Offset = "0x13FC118", VA = "0x13FC118")]
	public bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F38")]
	[Address(RVA = "0x13FC190", Offset = "0x13FC190", VA = "0x13FC190")]
	public void ChangeState(XGameModeStateType nState)
	{
	}

	[Token(Token = "0x6002F39")]
	[Address(RVA = "0x13FC4AC", Offset = "0x13FC4AC", VA = "0x13FC4AC")]
	public void SetFromMasterClient(float fStartTime, float remainedTime)
	{
	}

	[Token(Token = "0x6002F3A")]
	[Address(RVA = "0x13FC5AC", Offset = "0x13FC5AC", VA = "0x13FC5AC")]
	public void SetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002F3B")]
	[Address(RVA = "0x13FC5FC", Offset = "0x13FC5FC", VA = "0x13FC5FC", Slot = "17")]
	protected virtual void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0x13FC600", Offset = "0x13FC600", VA = "0x13FC600", Slot = "18")]
	public virtual void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002F3D")]
	[Address(RVA = "0x13FC604", Offset = "0x13FC604", VA = "0x13FC604", Slot = "19")]
	public virtual void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002F3E")]
	[Address(RVA = "0x13FC608", Offset = "0x13FC608", VA = "0x13FC608", Slot = "20")]
	public virtual void OnRespawn(int photonID)
	{
	}

	[Token(Token = "0x6002F3F")]
	[Address(RVA = "0x13FC60C", Offset = "0x13FC60C", VA = "0x13FC60C", Slot = "21")]
	public virtual void OnHit(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002F40")]
	[Address(RVA = "0x13FC610", Offset = "0x13FC610", VA = "0x13FC610", Slot = "22")]
	public virtual void ResetTime()
	{
	}

	[Token(Token = "0x6002F41")]
	[Address(RVA = "0x13FC708", Offset = "0x13FC708", VA = "0x13FC708", Slot = "23")]
	public virtual void SetStartTime(float fStartTime)
	{
	}

	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x13FC7D8", Offset = "0x13FC7D8", VA = "0x13FC7D8", Slot = "24")]
	public virtual void SetClear()
	{
	}

	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x13FC7DC", Offset = "0x13FC7DC", VA = "0x13FC7DC")]
	public void SetTeam(int nTargetPhotonID, int nTeamID, bool onReconnect)
	{
	}

	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x13FC900", Offset = "0x13FC900", VA = "0x13FC900", Slot = "25")]
	protected virtual void OnSetTeam(int nTargetPhotonID, int nTeamID, bool onReconnect)
	{
	}

	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x13FCBFC", Offset = "0x13FCBFC", VA = "0x13FCBFC")]
	public void JoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x13FCC48", Offset = "0x13FCC48", VA = "0x13FCC48")]
	internal void RejoinPlayer(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x13FCC94", Offset = "0x13FCC94", VA = "0x13FCC94")]
	internal void WelcomeAgain()
	{
	}

	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x13FCCD8", Offset = "0x13FCCD8", VA = "0x13FCCD8", Slot = "26")]
	protected virtual void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x13FCD4C", Offset = "0x13FCD4C", VA = "0x13FCD4C", Slot = "27")]
	protected virtual void OnRejoinPlayer(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x13FCD50", Offset = "0x13FCD50", VA = "0x13FCD50", Slot = "28")]
	protected virtual void OnWelcomeAgain()
	{
	}

	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x13FCD54", Offset = "0x13FCD54", VA = "0x13FCD54", Slot = "29")]
	public virtual void OnGameExit()
	{
	}

	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0x13FCD58", Offset = "0x13FCD58", VA = "0x13FCD58")]
	public bool IsEscaped(int nTargetPhotonID)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0x13FD078", Offset = "0x13FD078", VA = "0x13FD078")]
	public bool IsEscaped(int nTargetPhotonID, out XPlayer player)
	{
		player = default;
		return default(bool);
	}

	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0x13FD380", Offset = "0x13FD380", VA = "0x13FD380", Slot = "30")]
	public virtual void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0x13FD49C", Offset = "0x13FD49C", VA = "0x13FD49C", Slot = "31")]
	public virtual bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F59")]
	public T GetCurrentState<T>() where T : XGameModeState
	{
		return null;
	}

	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0x13FDCF8", Offset = "0x13FDCF8", VA = "0x13FDCF8", Slot = "35")]
	public virtual void RefreshRecords()
	{
	}

	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x13FDDC4", Offset = "0x13FDDC4", VA = "0x13FDDC4", Slot = "36")]
	public virtual void RefreshGameModeData()
	{
	}

	[Token(Token = "0x6002F5E")]
	public abstract bool IsFinish();

	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x13FDDC8", Offset = "0x13FDDC8", VA = "0x13FDDC8", Slot = "38")]
	public virtual XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x13FDE58", Offset = "0x13FDE58", VA = "0x13FDE58", Slot = "39")]
	public virtual XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x13FDF54", Offset = "0x13FDF54", VA = "0x13FDF54")]
	public void ChangeHost(PhotonPlayer player, string playerName)
	{
	}

	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x13FE094", Offset = "0x13FE094", VA = "0x13FE094", Slot = "40")]
	protected virtual void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x13FE098", Offset = "0x13FE098", VA = "0x13FE098", Slot = "41")]
	public virtual void SetPlayerDisconnect(string playerName)
	{
	}

	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x13FE30C", Offset = "0x13FE30C", VA = "0x13FE30C", Slot = "42")]
	public virtual bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F65")]
	[Address(RVA = "0x13FE314", Offset = "0x13FE314", VA = "0x13FE314")]
	public bool IsPlayState()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x13FE34C", Offset = "0x13FE34C", VA = "0x13FE34C")]
	public bool IsReadyState()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x13FE37C", Offset = "0x13FE37C", VA = "0x13FE37C")]
	public void ShowReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6002F68")]
	[Address(RVA = "0x13FE4FC", Offset = "0x13FE4FC", VA = "0x13FE4FC")]
	public void OnSyncReadyTimeoutTime(int _nCounter)
	{
	}

	[Token(Token = "0x6002F69")]
	[Address(RVA = "0x13FE5EC", Offset = "0x13FE5EC", VA = "0x13FE5EC")]
	public XGameModeStateType GetPreGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x6002F6A")]
	[Address(RVA = "0x13FE618", Offset = "0x13FE618", VA = "0x13FE618")]
	public static int GetPointObjectInteractionTime(GameModeInfo gameModeInfo)
	{
		return default(int);
	}

	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0x13FE718", Offset = "0x13FE718", VA = "0x13FE718", Slot = "43")]
	public virtual void SetGoalKillCount()
	{
	}

	[Token(Token = "0x6002F6C")]
	[Address(RVA = "0x13FE7EC", Offset = "0x13FE7EC", VA = "0x13FE7EC")]
	public void SetGoalKillCount(int count)
	{
	}

	[Token(Token = "0x6002F6D")]
	[Address(RVA = "0x13FE8B8", Offset = "0x13FE8B8", VA = "0x13FE8B8", Slot = "44")]
	public virtual void OnReqInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0x13FE8BC", Offset = "0x13FE8BC", VA = "0x13FE8BC", Slot = "45")]
	public virtual void OnReqCancelInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002F6F")]
	[Address(RVA = "0x13FE8C0", Offset = "0x13FE8C0", VA = "0x13FE8C0", Slot = "46")]
	public virtual void OnInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002F70")]
	[Address(RVA = "0x13FE8C4", Offset = "0x13FE8C4", VA = "0x13FE8C4", Slot = "47")]
	public virtual void OnCancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002F71")]
	[Address(RVA = "0x13FE8C8", Offset = "0x13FE8C8", VA = "0x13FE8C8")]
	public static void SortGameScoreRank(List<XPlayer> list)
	{
	}

	[Token(Token = "0x6002F72")]
	[Address(RVA = "0x13FEE48", Offset = "0x13FEE48", VA = "0x13FEE48")]
	private static ObscuredInt _003CSortGameScoreRank_003Em__118(XPlayer item)
	{
		return default(ObscuredInt);
	}
}
