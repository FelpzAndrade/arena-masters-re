using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000592")]
public class XGameModeManager
{
	[Token(Token = "0x4001B50")]
	[FieldOffset(Offset = "0x8")]
	private XGameMode m_GameMode;

	[Token(Token = "0x4001B51")]
	[FieldOffset(Offset = "0xC")]
	private bool IsPveModeClear__BackingField;

	[Token(Token = "0x1700074F")]
	public bool IsPveModeClear
	{
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0x140C710", Offset = "0x140C710", VA = "0x140C710")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0x140C718", Offset = "0x140C718", VA = "0x140C718")]
		set
		{
		}
	}

	[Token(Token = "0x17000750")]
	public XGameModeType Type
	{
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x140CC90", Offset = "0x140CC90", VA = "0x140CC90")]
		get
		{
			return default(XGameModeType);
		}
	}

	[Token(Token = "0x17000751")]
	public XGameMode GameMode
	{
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x13F5178", Offset = "0x13F5178", VA = "0x13F5178")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000752")]
	public GameModeInfo GameModeInfo
	{
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x13F58E8", Offset = "0x13F58E8", VA = "0x13F58E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000753")]
	public XGameModeStateType State
	{
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x13F58FC", Offset = "0x13F58FC", VA = "0x13F58FC")]
		get
		{
			return default(XGameModeStateType);
		}
	}

	[Token(Token = "0x17000754")]
	public float Time
	{
		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x140CCC8", Offset = "0x140CCC8", VA = "0x140CCC8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000755")]
	public float StartTime
	{
		[Token(Token = "0x6002F8C")]
		[Address(RVA = "0x140CCDC", Offset = "0x140CCDC", VA = "0x140CCDC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000756")]
	public float RemainedTime
	{
		[Token(Token = "0x6002F8D")]
		[Address(RVA = "0x140CD30", Offset = "0x140CD30", VA = "0x140CD30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000757")]
	public float ElapsedTime
	{
		[Token(Token = "0x6002F8E")]
		[Address(RVA = "0x140CD44", Offset = "0x140CD44", VA = "0x140CD44")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x140C6EC", Offset = "0x140C6EC", VA = "0x140C6EC")]
	public XGameModeManager()
	{
	}

	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x13E3C3C", Offset = "0x13E3C3C", VA = "0x13E3C3C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x13F8F70", Offset = "0x13F8F70", VA = "0x13F8F70")]
	public void Init(XGameModeType nType)
	{
	}

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x140C8E4", Offset = "0x140C8E4", VA = "0x140C8E4")]
	public void SyncRoomInfoFromMasterClient(XGameModeType nType, XGameModeStateType nGameModeState, float startTime, float remainedTime, NetData_DropObjectSpawnedInfo[] dropObjectSpawnedInfos, NetData_GimmickWorkingInfo gimmickWorkingInfo)
	{
	}

	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x13F2954", Offset = "0x13F2954", VA = "0x13F2954")]
	public void Update(float dt)
	{
	}

	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0x13F2964", Offset = "0x13F2964", VA = "0x13F2964")]
	public void FixedUpdate(float dt)
	{
	}

	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x13F88F0", Offset = "0x13F88F0", VA = "0x13F88F0")]
	public void GameInit()
	{
	}

	[Token(Token = "0x6002F81")]
	[Address(RVA = "0x140CBA0", Offset = "0x140CBA0", VA = "0x140CBA0")]
	public void ChangeState(XGameModeStateType nState)
	{
	}

	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x13F4A18", Offset = "0x13F4A18", VA = "0x13F4A18")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x140CBF0", Offset = "0x140CBF0", VA = "0x140CBF0")]
	public bool SendMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x140CC18", Offset = "0x140CC18", VA = "0x140CC18")]
	public void JoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x140CC40", Offset = "0x140CC40", VA = "0x140CC40")]
	internal void RejoinPlayer(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x140CC68", Offset = "0x140CC68", VA = "0x140CC68")]
	internal void WelcomeAgain()
	{
	}

	[Token(Token = "0x6002F8F")]
	[Address(RVA = "0x140CBC8", Offset = "0x140CBC8", VA = "0x140CBC8")]
	public void SetFromMasterClient(float fStartTime, float remainedTime)
	{
	}

	[Token(Token = "0x6002F90")]
	[Address(RVA = "0x140CD9C", Offset = "0x140CD9C", VA = "0x140CD9C")]
	public void SetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002F91")]
	[Address(RVA = "0x140CDC4", Offset = "0x140CDC4", VA = "0x140CDC4")]
	public void SetTeam(int nTargetPhotonID, int nTeamID, bool onReconnect)
	{
	}

	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x140CDF4", Offset = "0x140CDF4", VA = "0x140CDF4")]
	public void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x140CF38", Offset = "0x140CF38", VA = "0x140CF38")]
	public void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002F94")]
	[Address(RVA = "0x140CFA0", Offset = "0x140CFA0", VA = "0x140CFA0")]
	public void OnRespawn(int photonID)
	{
	}

	[Token(Token = "0x6002F95")]
	[Address(RVA = "0x140D000", Offset = "0x140D000", VA = "0x140D000")]
	public void OnHit(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002F96")]
	[Address(RVA = "0x140D068", Offset = "0x140D068", VA = "0x140D068")]
	public void OnGameExit()
	{
	}

	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x140D0C0", Offset = "0x140D0C0", VA = "0x140D0C0")]
	public void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002F98")]
	[Address(RVA = "0x140D118", Offset = "0x140D118", VA = "0x140D118")]
	public void StageRevivePlayer()
	{
	}

	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x140D180", Offset = "0x140D180", VA = "0x140D180")]
	public void RefreshRecords()
	{
	}

	[Token(Token = "0x6002F9A")]
	[Address(RVA = "0x140D1CC", Offset = "0x140D1CC", VA = "0x140D1CC")]
	public void RefreshGameModeData()
	{
	}

	[Token(Token = "0x6002F9B")]
	[Address(RVA = "0x13EAA90", Offset = "0x13EAA90", VA = "0x13EAA90")]
	public XGameMode GetGameMode()
	{
		return null;
	}

	[Token(Token = "0x6002F9C")]
	public T GetGameMode<T>() where T : XGameMode
	{
		return null;
	}

	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x140D218", Offset = "0x140D218", VA = "0x140D218")]
	public void DefectorRejoined(int target_photon_id)
	{
	}

	[Token(Token = "0x6002F9E")]
	public T GetGameModeState<T>() where T : XGameModeState
	{
		return null;
	}

	[Token(Token = "0x6002F9F")]
	[Address(RVA = "0x140D2EC", Offset = "0x140D2EC", VA = "0x140D2EC")]
	public void ChangeHost(PhotonPlayer player, string playerName)
	{
	}

	[Token(Token = "0x6002FA0")]
	[Address(RVA = "0x140D2FC", Offset = "0x140D2FC", VA = "0x140D2FC")]
	public void SetPlayerDisconnect(string playerAID)
	{
	}

	[Token(Token = "0x6002FA1")]
	[Address(RVA = "0x140D35C", Offset = "0x140D35C", VA = "0x140D35C")]
	public bool IsEnableRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FA2")]
	[Address(RVA = "0x140D5DC", Offset = "0x140D5DC", VA = "0x140D5DC")]
	public bool IsStageGameEnableRevive(bool isMyDie = false, bool isEscortDie = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FA3")]
	[Address(RVA = "0x140D890", Offset = "0x140D890", VA = "0x140D890")]
	internal void CompleteGame()
	{
	}

	[Token(Token = "0x6002FA4")]
	[Address(RVA = "0x140D948", Offset = "0x140D948", VA = "0x140D948")]
	public void InGameStartFail()
	{
	}

	[Token(Token = "0x6002FA5")]
	[Address(RVA = "0x1405154", Offset = "0x1405154", VA = "0x1405154")]
	public void SyncHeadStone()
	{
	}
}
