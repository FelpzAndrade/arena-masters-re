using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000587")]
public class XTeamDeathMatchState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x4001B39")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001B3A")]
	[FieldOffset(Offset = "0x28")]
	private string endCountDownSoundKey;

	[Token(Token = "0x6002F0B")]
	[Address(RVA = "0x1844B64", Offset = "0x1844B64", VA = "0x1844B64")]
	public XTeamDeathMatchState_Play()
	{
	}

	[Token(Token = "0x6002F0C")]
	[Address(RVA = "0x1844C14", Offset = "0x1844C14", VA = "0x1844C14", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002F0D")]
	[Address(RVA = "0x1845174", Offset = "0x1845174", VA = "0x1845174", Slot = "20")]
	protected override void EachActorDoOnGameStart(XModuleEntity eachActor)
	{
	}

	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0x1844D90", Offset = "0x1844D90", VA = "0x1844D90")]
	private void SetRoomOpen()
	{
	}

	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0x1845260", Offset = "0x1845260", VA = "0x1845260", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6002F10")]
	[Address(RVA = "0x18453D8", Offset = "0x18453D8", VA = "0x18453D8", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002F11")]
	[Address(RVA = "0x1845050", Offset = "0x1845050", VA = "0x1845050")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002F12")]
	[Address(RVA = "0x18454F0", Offset = "0x18454F0", VA = "0x18454F0")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002F13")]
	[Address(RVA = "0x18455BC", Offset = "0x18455BC", VA = "0x18455BC")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeamEnum, bool onReconnect)
	{
	}

	[Token(Token = "0x6002F14")]
	[Address(RVA = "0x1845908", Offset = "0x1845908", VA = "0x1845908", Slot = "18")]
	public override void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002F15")]
	[Address(RVA = "0x1845BB4", Offset = "0x1845BB4", VA = "0x1845BB4", Slot = "7")]
	public override void Update()
	{
	}
}
