using Il2CppDummyDll;

[Token(Token = "0x200083D")]
public interface IPhotonPlayerConnectListener
{
	[Token(Token = "0x60041F7")]
	void OnPhotonPlayerConnected(PhotonPlayer player);

	[Token(Token = "0x60041F8")]
	void OnPhotonPlayerDisconnected(PhotonPlayer player);

	[Token(Token = "0x60041F9")]
	void OnMasterClientSwitched(PhotonPlayer player);

	[Token(Token = "0x60041FA")]
	void OnDisconnectedFromPhoton();

	[Token(Token = "0x60041FB")]
	void OnDisconnectedFromPhoton(DisconnectCause cause);

	[Token(Token = "0x60041FC")]
	void OnJoinedRoom();
}
