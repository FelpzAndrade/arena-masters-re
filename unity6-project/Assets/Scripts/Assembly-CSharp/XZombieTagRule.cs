using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005F3")]
public class XZombieTagRule : XBaseRule
{
	[Token(Token = "0x4001C9B")]
	[FieldOffset(Offset = "0x34")]
	private GameModeInfo m_GameModeInfo;

	[Token(Token = "0x4001C9C")]
	[FieldOffset(Offset = "0x38")]
	private XZombieTagState_Play m_PlayState;

	[Token(Token = "0x4001C9D")]
	[FieldOffset(Offset = "0x3C")]
	private XGameModeData_ZombieTag m_GameModeData;

	[Token(Token = "0x4001C9E")]
	[FieldOffset(Offset = "0x40")]
	private int m_LastGameModeDataChecksum;

	[Token(Token = "0x4001C9F")]
	[FieldOffset(Offset = "0x44")]
	private float m_fDataSyncElapsedTime;

	[Token(Token = "0x60032B4")]
	[Address(RVA = "0x23DBF54", Offset = "0x23DBF54", VA = "0x23DBF54")]
	public XZombieTagRule()
	{
	}

	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x23DBF5C", Offset = "0x23DBF5C", VA = "0x23DBF5C")]
	public void Enter(GameModeInfo gameModeInfo, XZombieTagState_Play playState, XGameModeData_ZombieTag gameModeData)
	{
	}

	[Token(Token = "0x60032B6")]
	[Address(RVA = "0x23DBFCC", Offset = "0x23DBFCC", VA = "0x23DBFCC", Slot = "9")]
	protected override void OnRoundStart(int nRound)
	{
	}

	[Token(Token = "0x60032B7")]
	[Address(RVA = "0x23DC2F8", Offset = "0x23DC2F8", VA = "0x23DC2F8", Slot = "8")]
	protected override bool CheckFinished(int nCurrentRound)
	{
		return default(bool);
	}

	[Token(Token = "0x60032B8")]
	[Address(RVA = "0x23DC300", Offset = "0x23DC300", VA = "0x23DC300")]
	public void OnMasterClientSwitched(GameModeInfo gameModeInfo, XZombieTagState_Play playState, XGameModeData_ZombieTag gameModeData)
	{
	}

	[Token(Token = "0x60032B9")]
	[Address(RVA = "0x23DC30C", Offset = "0x23DC30C", VA = "0x23DC30C", Slot = "10")]
	protected override void OnUpdate(float fDeltaTime, float fRemainedTime)
	{
	}

	[Token(Token = "0x60032BA")]
	[Address(RVA = "0x23DC334", Offset = "0x23DC334", VA = "0x23DC334")]
	private void UpdateSyncGameModeData(float fDeltaTime)
	{
	}

	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x23DC3DC", Offset = "0x23DC3DC", VA = "0x23DC3DC")]
	private bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x60032BC")]
	[Address(RVA = "0x23DC544", Offset = "0x23DC544", VA = "0x23DC544", Slot = "14")]
	public virtual void SendSyncGameModeData()
	{
	}

	[Token(Token = "0x60032BD")]
	[Address(RVA = "0x23DC6AC", Offset = "0x23DC6AC", VA = "0x23DC6AC")]
	private bool AllTeamZombies(List<XPlayer> team)
	{
		return default(bool);
	}

	[Token(Token = "0x60032BE")]
	[Address(RVA = "0x23DC7E0", Offset = "0x23DC7E0", VA = "0x23DC7E0", Slot = "13")]
	public override CSWinlose CheckRoundVictimsAndResult()
	{
		return default(CSWinlose);
	}
}
