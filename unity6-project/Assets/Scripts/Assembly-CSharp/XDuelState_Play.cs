using CS;
using Il2CppDummyDll;

[Token(Token = "0x200056F")]
public class XDuelState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x4001ADC")]
	[FieldOffset(Offset = "0x24")]
	private XDuelRule m_Rule;

	[Token(Token = "0x4001ADD")]
	[FieldOffset(Offset = "0x28")]
	private XRoundTimer m_RoundTimer;

	[Token(Token = "0x4001ADE")]
	[FieldOffset(Offset = "0x2C")]
	private int m_nCurrentRound;

	[Token(Token = "0x17000727")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x19AD198", Offset = "0x19AD198", VA = "0x19AD198")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000728")]
	public int CurrentRound
	{
		[Token(Token = "0x6002E39")]
		[Address(RVA = "0x19AD1C4", Offset = "0x19AD1C4", VA = "0x19AD1C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002E2E")]
	[Address(RVA = "0x19AC9E8", Offset = "0x19AC9E8", VA = "0x19AC9E8")]
	public XDuelState_Play()
	{
	}

	[Token(Token = "0x6002E2F")]
	[Address(RVA = "0x19ACAAC", Offset = "0x19ACAAC", VA = "0x19ACAAC", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002E30")]
	[Address(RVA = "0x19ACC30", Offset = "0x19ACC30", VA = "0x19ACC30", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002E31")]
	[Address(RVA = "0x19ACCF0", Offset = "0x19ACCF0", VA = "0x19ACCF0", Slot = "26")]
	protected virtual bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E32")]
	[Address(RVA = "0x19AAD20", Offset = "0x19AAD20", VA = "0x19AAD20")]
	public void OnRoundStart(int nRound)
	{
	}

	[Token(Token = "0x6002E33")]
	[Address(RVA = "0x19ACF94", Offset = "0x19ACF94", VA = "0x19ACF94")]
	public void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002E34")]
	[Address(RVA = "0x19ABB4C", Offset = "0x19ABB4C", VA = "0x19ABB4C")]
	public void OnRoundResult(int nRound, int nPhotonID_0, CSWinlose result_0, int nPhotonID_1, CSWinlose result_1)
	{
	}

	[Token(Token = "0x6002E35")]
	[Address(RVA = "0x19ACE58", Offset = "0x19ACE58", VA = "0x19ACE58")]
	private void RespawnMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x19AD034", Offset = "0x19AD034", VA = "0x19AD034")]
	public static int GetPlayerSpawnIndex(XTeamEnum team)
	{
		return default(int);
	}

	[Token(Token = "0x6002E37")]
	[Address(RVA = "0x19AD044", Offset = "0x19AD044", VA = "0x19AD044", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}
}
