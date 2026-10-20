using CS;
using Il2CppDummyDll;

[Token(Token = "0x20004AD")]
public interface IPartyOperationResListener
{
	[Token(Token = "0x6002826")]
	void OnCreateParty(DTPartyInfo partyInfo);

	[Token(Token = "0x6002827")]
	void OnJoinParty(DTPartyInfo partyInfo);

	[Token(Token = "0x6002828")]
	void OnLeaveParty();

	[Token(Token = "0x6002829")]
	void OnLeavePartyNotify(DTPartyInfo partyInfo);

	[Token(Token = "0x600282A")]
	void OnStartPartyGame(bool isSuccess);

	[Token(Token = "0x600282B")]
	void OnStartPartyGameNotify(action createOrJoin, string roomName, int sectorID, XGameModeType gameMode, MatchType matchType);

	[Token(Token = "0x600282C")]
	void OnBreakPartyNotify();

	[Token(Token = "0x600282D")]
	void OnUpdatePartyNotify(DTPartyInfo partyInfo);

	[Token(Token = "0x600282E")]
	void OnUpdatePlayerState();

	[Token(Token = "0x600282F")]
	void OnChangeReadyState();

	[Token(Token = "0x6002830")]
	void OnChangePartyInfoState();

	[Token(Token = "0x6002831")]
	void OnUpdatePartyMemberInfo(NetMatchPlayerInfo info);

	[Token(Token = "0x6002832")]
	void OnChangePartyInfoStateNotify(XGameModeType gameMode);
}
