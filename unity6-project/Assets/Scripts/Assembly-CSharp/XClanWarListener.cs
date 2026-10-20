using Il2CppDummyDll;

[Token(Token = "0x2000401")]
public class XClanWarListener : IClanWarListener
{
	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x198465C", Offset = "0x198465C", VA = "0x198465C")]
	public XClanWarListener()
	{
	}

	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x1984664", Offset = "0x1984664", VA = "0x1984664", Slot = "4")]
	public void OnCreateParty(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x1984778", Offset = "0x1984778", VA = "0x1984778")]
	private void SendCreateParty(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x19848EC", Offset = "0x19848EC", VA = "0x19848EC", Slot = "5")]
	public void OnJoinParty1(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x19849CC", Offset = "0x19849CC", VA = "0x19849CC")]
	private void SendJoinPartyMsg(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x1984B40", Offset = "0x1984B40", VA = "0x1984B40", Slot = "6")]
	public void OnLeaveParty(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x1984B44", Offset = "0x1984B44", VA = "0x1984B44")]
	private void SendUpdateMemberPartyMsg(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x1984CB8", Offset = "0x1984CB8", VA = "0x1984CB8", Slot = "7")]
	public void OnPartyBreak(long partyKey)
	{
	}

	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x1984CD0", Offset = "0x1984CD0", VA = "0x1984CD0")]
	private void SendPartyBreakMsg(long partyKey)
	{
	}

	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x1984E4C", Offset = "0x1984E4C", VA = "0x1984E4C", Slot = "8")]
	public void OnClanMatchStart(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x1984E50", Offset = "0x1984E50", VA = "0x1984E50")]
	private void SendClanMatchStartMsg(DTPartyInfo party)
	{
	}

	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x1984FC4", Offset = "0x1984FC4", VA = "0x1984FC4", Slot = "9")]
	public void OnClanMatchCancel()
	{
	}

	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x198519C", Offset = "0x198519C", VA = "0x198519C", Slot = "10")]
	public void OnRefreshInParty()
	{
	}

	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x19851A0", Offset = "0x19851A0", VA = "0x19851A0", Slot = "11")]
	public void OnRefreshMyClanParty(DTPartyInfo party)
	{
	}
}
