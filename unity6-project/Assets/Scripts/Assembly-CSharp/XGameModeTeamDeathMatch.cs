using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000583")]
public class XGameModeTeamDeathMatch : XGameModePVP
{
		protected XGameModeTeamDeathMatch()
		{
		}

	[Token(Token = "0x4001B28")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x6002EE7")]
	[Address(RVA = "0x1402C38", Offset = "0x1402C38", VA = "0x1402C38")]
	public XGameModeTeamDeathMatch(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x141E71C", Offset = "0x141E71C", VA = "0x141E71C", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x141E988", Offset = "0x141E988", VA = "0x141E988", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x141E98C", Offset = "0x141E98C", VA = "0x141E98C", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EEB")]
	[Address(RVA = "0x141EC38", Offset = "0x141EC38", VA = "0x141EC38", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002EEC")]
	[Address(RVA = "0x141EC3C", Offset = "0x141EC3C", VA = "0x141EC3C", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x141EC40", Offset = "0x141EC40", VA = "0x141EC40", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x141ED1C", Offset = "0x141ED1C", VA = "0x141ED1C", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}
}
