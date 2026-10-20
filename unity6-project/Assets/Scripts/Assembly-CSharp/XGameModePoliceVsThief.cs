using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000527")]
public class XGameModePoliceVsThief : XGameModePVP
{
	[Token(Token = "0x4001A04")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x170006DD")]
	public override bool TimeOut
	{
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x140FF20", Offset = "0x140FF20", VA = "0x140FF20", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002C20")]
	[Address(RVA = "0x140745C", Offset = "0x140745C", VA = "0x140745C")]
	public XGameModePoliceVsThief(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002C21")]
	[Address(RVA = "0x140FF18", Offset = "0x140FF18", VA = "0x140FF18", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C23")]
	[Address(RVA = "0x140FF28", Offset = "0x140FF28", VA = "0x140FF28", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002C24")]
	[Address(RVA = "0x140FFC8", Offset = "0x140FFC8", VA = "0x140FFC8", Slot = "40")]
	protected override void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002C25")]
	[Address(RVA = "0x1410064", Offset = "0x1410064", VA = "0x1410064", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002C26")]
	[Address(RVA = "0x1410074", Offset = "0x1410074", VA = "0x1410074", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002C27")]
	[Address(RVA = "0x1410660", Offset = "0x1410660", VA = "0x1410660", Slot = "41")]
	public override void SetPlayerDisconnect(string playeAid)
	{
	}

	[Token(Token = "0x6002C28")]
	[Address(RVA = "0x1410924", Offset = "0x1410924", VA = "0x1410924", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002C29")]
	[Address(RVA = "0x1410B38", Offset = "0x1410B38", VA = "0x1410B38", Slot = "20")]
	public override void OnRespawn(int photonID)
	{
	}
}
