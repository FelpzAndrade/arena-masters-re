using Il2CppDummyDll;

[Token(Token = "0x2000833")]
public interface IConnectProcessor
{
	[Token(Token = "0x60041B0")]
	void OnDisconnect(DisconnectCause cause);

	[Token(Token = "0x60041B1")]
	void OnDisconnectedFromPhoton();

	[Token(Token = "0x60041B2")]
	void OnDisconnectedFromPhoton(DisconnectCause cause);

	[Token(Token = "0x60041B3")]
	void OnConnectedToMaster();

	[Token(Token = "0x60041B4")]
	void OnConnectedToPhoton();

	[Token(Token = "0x60041B5")]
	void OnJoinedLobby();

	[Token(Token = "0x60041B6")]
	void OnCreatedRoom();

	[Token(Token = "0x60041B7")]
	void OnJoinedRoom();

	[Token(Token = "0x60041B8")]
	void OnApplicationPause(bool paused);

	[Token(Token = "0x60041B9")]
	void OnPhotonCreateRoomFailed(object[] codeAndMsg);

	[Token(Token = "0x60041BA")]
	void OnPhotonJoinRoomFailed(object[] result);

	[Token(Token = "0x60041BB")]
	void OnPhotonRandomJoinFailed();

	[Token(Token = "0x60041BC")]
	void OnExitReconnector();

	[Token(Token = "0x60041BD")]
	void TryConnectToMasterServer();

	[Token(Token = "0x60041BE")]
	void OnKicked();

	[Token(Token = "0x60041BF")]
	void OnBanned();

	[Token(Token = "0x60041C0")]
	void OnComplteGame();
}
