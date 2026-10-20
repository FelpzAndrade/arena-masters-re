using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000513")]
public class XGameModeCapturePointA : XGameModePVP
{
	[Token(Token = "0x40019CB")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x40019CC")]
	[FieldOffset(Offset = "0x7C")]
	private XGameModeData_CapturePointA m_GameModeData;

	[Token(Token = "0x40019CD")]
	[FieldOffset(Offset = "0x80")]
	private XGameModeLocalData_CapturePointA m_GameModeLocalData;

	[Token(Token = "0x170006D0")]
	public override XGameModeData GameModeData
	{
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x140181C", Offset = "0x140181C", VA = "0x140181C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D1")]
	public override XGameModeLocalData GameModeLocalData
	{
		[Token(Token = "0x6002B9E")]
		[Address(RVA = "0x1401824", Offset = "0x1401824", VA = "0x1401824", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x140182C", Offset = "0x140182C", VA = "0x140182C", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x6002B9C")]
	[Address(RVA = "0x14016A8", Offset = "0x14016A8", VA = "0x14016A8")]
	public XGameModeCapturePointA(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002BA0")]
	[Address(RVA = "0x14018E8", Offset = "0x14018E8", VA = "0x14018E8", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002BA1")]
	[Address(RVA = "0x1401B54", Offset = "0x1401B54", VA = "0x1401B54", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x1401B58", Offset = "0x1401B58", VA = "0x1401B58", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002BA3")]
	[Address(RVA = "0x1401D3C", Offset = "0x1401D3C", VA = "0x1401D3C", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x1401D40", Offset = "0x1401D40", VA = "0x1401D40", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x1401E68", Offset = "0x1401E68", VA = "0x1401E68", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x1401E6C", Offset = "0x1401E6C", VA = "0x1401E6C", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002BA7")]
	[Address(RVA = "0x1401EBC", Offset = "0x1401EBC", VA = "0x1401EBC", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002BA8")]
	[Address(RVA = "0x1401EC0", Offset = "0x1401EC0", VA = "0x1401EC0")]
	public int GetTeamScore(XTeamEnum nTeam)
	{
		return default(int);
	}

	[Token(Token = "0x6002BA9")]
	[Address(RVA = "0x1401F14", Offset = "0x1401F14", VA = "0x1401F14")]
	public int GetGoalScore()
	{
		return default(int);
	}

	[Token(Token = "0x6002BAA")]
	[Address(RVA = "0x1401F1C", Offset = "0x1401F1C", VA = "0x1401F1C")]
	public NetData_CapturePointAGameModeData Generate_NetData()
	{
		return null;
	}

	[Token(Token = "0x6002BAB")]
	[Address(RVA = "0x1402088", Offset = "0x1402088", VA = "0x1402088", Slot = "36")]
	public override void RefreshGameModeData()
	{
	}

	[Token(Token = "0x6002BAC")]
	[Address(RVA = "0x140208C", Offset = "0x140208C", VA = "0x140208C", Slot = "44")]
	public override void OnReqInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002BAD")]
	[Address(RVA = "0x1402268", Offset = "0x1402268", VA = "0x1402268", Slot = "45")]
	public override void OnReqCancelInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002BAE")]
	[Address(RVA = "0x1402420", Offset = "0x1402420", VA = "0x1402420", Slot = "46")]
	public override void OnInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002BAF")]
	[Address(RVA = "0x14025FC", Offset = "0x14025FC", VA = "0x14025FC", Slot = "47")]
	public override void OnCancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002BB0")]
	[Address(RVA = "0x14027B4", Offset = "0x14027B4", VA = "0x14027B4", Slot = "27")]
	protected override void OnRejoinPlayer(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6002BB1")]
	[Address(RVA = "0x14027B8", Offset = "0x14027B8", VA = "0x14027B8")]
	public void SyncGameModeDataToRejoiner(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6002BB2")]
	[Address(RVA = "0x14028B8", Offset = "0x14028B8", VA = "0x14028B8")]
	public void OnSyncGameModeData(NetData_CapturePointAGameModeData gameModeNetData)
	{
	}

	[Token(Token = "0x6002BB3")]
	[Address(RVA = "0x1402978", Offset = "0x1402978", VA = "0x1402978", Slot = "40")]
	protected override void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002BB4")]
	[Address(RVA = "0x1402A38", Offset = "0x1402A38", VA = "0x1402A38")]
	internal void OnReadyTimeout()
	{
	}

	[Token(Token = "0x6002BB5")]
	[Address(RVA = "0x1402AF0", Offset = "0x1402AF0", VA = "0x1402AF0", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAID)
	{
	}
}
