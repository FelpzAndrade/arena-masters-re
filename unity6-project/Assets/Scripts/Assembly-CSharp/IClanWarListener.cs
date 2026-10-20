using Il2CppDummyDll;

[Token(Token = "0x2000400")]
public interface IClanWarListener
{
	[Token(Token = "0x60020BB")]
	void OnCreateParty(DTPartyInfo partyInfo);

	[Token(Token = "0x60020BC")]
	void OnJoinParty1(DTPartyInfo partyInfo);

	[Token(Token = "0x60020BD")]
	void OnLeaveParty(DTPartyInfo partyInfo);

	[Token(Token = "0x60020BE")]
	void OnPartyBreak(long partyKey);

	[Token(Token = "0x60020BF")]
	void OnClanMatchStart(DTPartyInfo party);

	[Token(Token = "0x60020C0")]
	void OnClanMatchCancel();

	[Token(Token = "0x60020C1")]
	void OnRefreshInParty();

	[Token(Token = "0x60020C2")]
	void OnRefreshMyClanParty(DTPartyInfo party);
}
