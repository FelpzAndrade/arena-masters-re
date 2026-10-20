using CS;
using Il2CppDummyDll;

[Token(Token = "0x20004A8")]
public interface IFriendPartyListener
{
	[Token(Token = "0x60027F9")]
	void OnUpdatePartyInfo(DTPartyInfo partyInfo);

	[Token(Token = "0x60027FA")]
	void OnDisconnectFromPhoton();

	[Token(Token = "0x60027FB")]
	void OnChangeGameModeInfo(XGameModeType gameModeType);

	[Token(Token = "0x60027FC")]
	void OnReciveAccept(string accepter);

	[Token(Token = "0x60027FD")]
	void OnReciveRefuse(string refuser);

	[Token(Token = "0x60027FE")]
	void OnCreatePary();

	[Token(Token = "0x60027FF")]
	void OnLeaveParty();

	[Token(Token = "0x6002800")]
	void OnBreakParty();
}
