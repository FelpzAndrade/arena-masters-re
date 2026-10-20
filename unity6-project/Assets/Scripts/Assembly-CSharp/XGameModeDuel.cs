using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000571")]
public class XGameModeDuel : XGameModePVP
{
	[Token(Token = "0x4001ADF")]
	public const int MAX_PLAYER = 2;

	[Token(Token = "0x17000729")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x14063D0", Offset = "0x14063D0", VA = "0x14063D0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700072A")]
	public int CurrentRound
	{
		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x140649C", Offset = "0x140649C", VA = "0x140649C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x14059E4", Offset = "0x14059E4", VA = "0x14059E4")]
	public XGameModeDuel(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002E3D")]
	[Address(RVA = "0x1405A00", Offset = "0x1405A00", VA = "0x1405A00", Slot = "11")]
	public override void OnGameInit()
	{
	}

	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x1405AFC", Offset = "0x1405AFC", VA = "0x1405AFC", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E3F")]
	[Address(RVA = "0x1405BD8", Offset = "0x1405BD8", VA = "0x1405BD8", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002E40")]
	[Address(RVA = "0x1405BDC", Offset = "0x1405BDC", VA = "0x1405BDC", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002E41")]
	[Address(RVA = "0x1405BE0", Offset = "0x1405BE0", VA = "0x1405BE0", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002E42")]
	[Address(RVA = "0x1406134", Offset = "0x1406134", VA = "0x1406134", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E43")]
	[Address(RVA = "0x140613C", Offset = "0x140613C", VA = "0x140613C")]
	public void StartRound(int nRound)
	{
	}

	[Token(Token = "0x6002E44")]
	[Address(RVA = "0x1406208", Offset = "0x1406208", VA = "0x1406208")]
	public void OnRoundResult(int nRound, int nPhotonID_0, CSWinlose result_0, int nPhotonID_1, CSWinlose result_1)
	{
	}

	[Token(Token = "0x6002E45")]
	[Address(RVA = "0x14062FC", Offset = "0x14062FC", VA = "0x14062FC", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002E48")]
	[Address(RVA = "0x1406568", Offset = "0x1406568", VA = "0x1406568", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAID)
	{
	}
}
