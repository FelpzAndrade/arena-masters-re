using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005F1")]
public class XGameModeZombieTag : XGameModePVP
{
	[Token(Token = "0x4001C97")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x4001C98")]
	[FieldOffset(Offset = "0x7C")]
	private XGameModeData_ZombieTag m_GameModeData;

	[Token(Token = "0x4001C99")]
	[FieldOffset(Offset = "0x80")]
	private XGameModeLocalData_ZombieTag m_GameModeLocalData;

	[Token(Token = "0x4001C9A")]
	[FieldOffset(Offset = "0x84")]
	private bool suddenDeath;

	[Token(Token = "0x17000792")]
	public new XGameModeData_ZombieTag GameModeData
	{
		[Token(Token = "0x6003298")]
		[Address(RVA = "0x14231C4", Offset = "0x14231C4", VA = "0x14231C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000793")]
	public new XGameModeLocalData_ZombieTag GameModeLocalData
	{
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x14231CC", Offset = "0x14231CC", VA = "0x14231CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x14231D4", Offset = "0x14231D4", VA = "0x14231D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000794")]
	public int CurrentRound
	{
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x1424924", Offset = "0x1424924", VA = "0x1424924")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000795")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x14249F0", Offset = "0x14249F0", VA = "0x14249F0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003297")]
	[Address(RVA = "0x1406EE0", Offset = "0x1406EE0", VA = "0x1406EE0")]
	public XGameModeZombieTag(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x600329B")]
	[Address(RVA = "0x14231DC", Offset = "0x14231DC", VA = "0x14231DC", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x600329C")]
	[Address(RVA = "0x1423448", Offset = "0x1423448", VA = "0x1423448", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x600329D")]
	[Address(RVA = "0x142352C", Offset = "0x142352C", VA = "0x142352C", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x600329E")]
	[Address(RVA = "0x1423600", Offset = "0x1423600", VA = "0x1423600")]
	public void StartRound(int nRound)
	{
	}

	[Token(Token = "0x600329F")]
	[Address(RVA = "0x14236D0", Offset = "0x14236D0", VA = "0x14236D0")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x60032A0")]
	[Address(RVA = "0x142379C", Offset = "0x142379C", VA = "0x142379C")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x60032A1")]
	[Address(RVA = "0x1423868", Offset = "0x1423868", VA = "0x1423868")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x60032A2")]
	[Address(RVA = "0x142392C", Offset = "0x142392C", VA = "0x142392C", Slot = "25")]
	protected override void OnSetTeam(int nTargetPhotonID, int nTeamID, bool onReconnect)
	{
	}

	[Token(Token = "0x60032A3")]
	[Address(RVA = "0x1423B7C", Offset = "0x1423B7C", VA = "0x1423B7C", Slot = "13")]
	public override void InitPlayerTeam()
	{
	}

	[Token(Token = "0x60032A4")]
	[Address(RVA = "0x1423B80", Offset = "0x1423B80", VA = "0x1423B80", Slot = "14")]
	public override void InitOnGetReady()
	{
	}

	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x1423B84", Offset = "0x1423B84", VA = "0x1423B84", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x60032A6")]
	[Address(RVA = "0x1423D20", Offset = "0x1423D20", VA = "0x1423D20", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x60032A7")]
	[Address(RVA = "0x1423D24", Offset = "0x1423D24", VA = "0x1423D24", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x60032A8")]
	[Address(RVA = "0x1423D28", Offset = "0x1423D28", VA = "0x1423D28")]
	public void CalcTeamScore(out int nATeamScore, out int nBTeamScore)
	{
		nATeamScore = default;
		nBTeamScore = default;
	}

	[Token(Token = "0x60032A9")]
	[Address(RVA = "0x1423FB4", Offset = "0x1423FB4", VA = "0x1423FB4", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x60032AA")]
	[Address(RVA = "0x14240C8", Offset = "0x14240C8", VA = "0x14240C8", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x60032AB")]
	[Address(RVA = "0x14240CC", Offset = "0x14240CC", VA = "0x14240CC")]
	public NetData_ZombieTagGameModeData Generate_NetData()
	{
		return null;
	}

	[Token(Token = "0x60032AC")]
	[Address(RVA = "0x1424158", Offset = "0x1424158", VA = "0x1424158", Slot = "36")]
	public override void RefreshGameModeData()
	{
	}

	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x142415C", Offset = "0x142415C", VA = "0x142415C")]
	public void OnSyncGameModeData(NetData_ZombieTagGameModeData gameModeNetData)
	{
	}

	[Token(Token = "0x60032AE")]
	[Address(RVA = "0x142421C", Offset = "0x142421C", VA = "0x142421C", Slot = "40")]
	protected override void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x14242DC", Offset = "0x14242DC", VA = "0x14242DC", Slot = "21")]
	public override void OnHit(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x60032B0")]
	[Address(RVA = "0x14243B0", Offset = "0x14243B0", VA = "0x14243B0")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x60032B1")]
	[Address(RVA = "0x1424690", Offset = "0x1424690", VA = "0x1424690")]
	private void ShowRoundResult(CSWinlose state)
	{
	}
}
