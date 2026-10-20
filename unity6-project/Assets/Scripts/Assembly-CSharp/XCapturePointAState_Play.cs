using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200050C")]
public class XCapturePointAState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0x24")]
	private XCapturePointARule m_Rule;

	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0x28")]
	private XGameModeData_CapturePointA m_GameModeData;

	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0x2C")]
	public XGameModeLocalData_CapturePointA m_GameModeLocalData;

	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0x30")]
	private XTeamEnum m_LastCapturePointTeam;

	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0x34")]
	private XTeamEnum m_LastCapturingTeam;

	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_capturingEffect;

	[Token(Token = "0x40019B6")]
	[FieldOffset(Offset = "0x3C")]
	private GameObject m_captureEffect;

	[Token(Token = "0x6002B79")]
	[Address(RVA = "0x1AA7D80", Offset = "0x1AA7D80", VA = "0x1AA7D80")]
	public XCapturePointAState_Play()
	{
	}

	[Token(Token = "0x6002B7A")]
	[Address(RVA = "0x1AA7E18", Offset = "0x1AA7E18", VA = "0x1AA7E18", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002B7B")]
	[Address(RVA = "0x1AA8598", Offset = "0x1AA8598", VA = "0x1AA8598", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002B7C")]
	[Address(RVA = "0x1AA8614", Offset = "0x1AA8614", VA = "0x1AA8614", Slot = "14")]
	public override void OnBeforeFinish()
	{
	}

	[Token(Token = "0x6002B7D")]
	[Address(RVA = "0x1AA86B0", Offset = "0x1AA86B0", VA = "0x1AA86B0")]
	public void SyncGameModeDataToRejoiner(PhotonPlayer photonPlayer)
	{
	}

	[Token(Token = "0x6002B7E")]
	[Address(RVA = "0x1AA81B4", Offset = "0x1AA81B4", VA = "0x1AA81B4")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x6002B7F")]
	[Address(RVA = "0x1AA8710", Offset = "0x1AA8710", VA = "0x1AA8710", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6002B80")]
	[Address(RVA = "0x1AA8888", Offset = "0x1AA8888", VA = "0x1AA8888", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002B81")]
	[Address(RVA = "0x1AA8474", Offset = "0x1AA8474", VA = "0x1AA8474")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002B82")]
	[Address(RVA = "0x1AA89A0", Offset = "0x1AA89A0", VA = "0x1AA89A0")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002B83")]
	[Address(RVA = "0x1AA8A6C", Offset = "0x1AA8A6C", VA = "0x1AA8A6C")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeamEnum, bool onReconnect)
	{
	}

	[Token(Token = "0x6002B84")]
	[Address(RVA = "0x1AA8DB8", Offset = "0x1AA8DB8", VA = "0x1AA8DB8", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002B85")]
	[Address(RVA = "0x1AA9064", Offset = "0x1AA9064", VA = "0x1AA9064", Slot = "26")]
	public virtual bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002B86")]
	[Address(RVA = "0x1AA91CC", Offset = "0x1AA91CC", VA = "0x1AA91CC")]
	public void OnReqInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002B87")]
	[Address(RVA = "0x1AA923C", Offset = "0x1AA923C", VA = "0x1AA923C")]
	public void OnReqCancelInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002B88")]
	[Address(RVA = "0x1AA92AC", Offset = "0x1AA92AC", VA = "0x1AA92AC")]
	public void OnInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002B89")]
	[Address(RVA = "0x1AA9430", Offset = "0x1AA9430", VA = "0x1AA9430")]
	public void OnCancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002B8A")]
	[Address(RVA = "0x1AA95B4", Offset = "0x1AA95B4", VA = "0x1AA95B4")]
	public void OnSyncGameModeData(NetData_CapturePointAGameModeData gameModeNetData)
	{
	}

	[Token(Token = "0x6002B8B")]
	[Address(RVA = "0x1AA68F4", Offset = "0x1AA68F4", VA = "0x1AA68F4")]
	public void ApplyGameModeData()
	{
	}

	[Token(Token = "0x6002B8C")]
	[Address(RVA = "0x1AA9628", Offset = "0x1AA9628", VA = "0x1AA9628")]
	private void ShowTeamCaptureMsg(XTeamEnum team)
	{
	}

	[Token(Token = "0x6002B8D")]
	[Address(RVA = "0x1AA9B78", Offset = "0x1AA9B78", VA = "0x1AA9B78")]
	public void OnMasterClientSwitched(PhotonPlayer player)
	{
	}
}
