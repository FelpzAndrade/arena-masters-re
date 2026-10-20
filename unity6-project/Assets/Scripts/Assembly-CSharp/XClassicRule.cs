using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000558")]
public class XClassicRule : XBaseRule
{
	[Token(Token = "0x4001AA2")]
	[FieldOffset(Offset = "0x34")]
	protected XClassicState_Play m_PlayState;

	[Token(Token = "0x6002D99")]
	[Address(RVA = "0x1985B90", Offset = "0x1985B90", VA = "0x1985B90")]
	public XClassicRule()
	{
	}

	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x1985B98", Offset = "0x1985B98", VA = "0x1985B98")]
	public void Enter(XClassicState_Play playState, int nTotalRound, int nCountDown)
	{
	}

	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x1985BF0", Offset = "0x1985BF0", VA = "0x1985BF0", Slot = "9")]
	protected override void OnRoundStart(int nRound)
	{
	}

	[Token(Token = "0x6002D9C")]
	[Address(RVA = "0x1985F18", Offset = "0x1985F18", VA = "0x1985F18", Slot = "8")]
	protected override bool CheckFinished(int nCurrentRound)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D9D")]
	[Address(RVA = "0x1985F20", Offset = "0x1985F20", VA = "0x1985F20", Slot = "12")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002D9E")]
	[Address(RVA = "0x1985F28", Offset = "0x1985F28", VA = "0x1985F28")]
	private bool AllTeamDied(List<XPlayer> team)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D9F")]
	[Address(RVA = "0x198605C", Offset = "0x198605C", VA = "0x198605C", Slot = "13")]
	public override CSWinlose CheckRoundVictimsAndResult()
	{
		return default(CSWinlose);
	}
}
