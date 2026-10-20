using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002C3")]
public interface IPunCallbacks
{
	[Token(Token = "0x60017CA")]
	void OnConnectedToPhoton();

	[Token(Token = "0x60017CB")]
	void OnLeftRoom();

	[Token(Token = "0x60017CC")]
	void OnMasterClientSwitched(PhotonPlayer newMasterClient);

	[Token(Token = "0x60017CD")]
	void OnPhotonCreateRoomFailed(object[] codeAndMsg);

	[Token(Token = "0x60017CE")]
	void OnPhotonJoinRoomFailed(object[] codeAndMsg);

	[Token(Token = "0x60017CF")]
	void OnCreatedRoom();

	[Token(Token = "0x60017D0")]
	void OnJoinedLobby();

	[Token(Token = "0x60017D1")]
	void OnLeftLobby();

	[Token(Token = "0x60017D2")]
	void OnFailedToConnectToPhoton(DisconnectCause cause);

	[Token(Token = "0x60017D3")]
	void OnConnectionFail(DisconnectCause cause);

	[Token(Token = "0x60017D4")]
	void OnDisconnectedFromPhoton();

	[Token(Token = "0x60017D5")]
	void OnPhotonInstantiate(PhotonMessageInfo info);

	[Token(Token = "0x60017D6")]
	void OnReceivedRoomListUpdate();

	[Token(Token = "0x60017D7")]
	void OnJoinedRoom();

	[Token(Token = "0x60017D8")]
	void OnPhotonPlayerConnected(PhotonPlayer newPlayer);

	[Token(Token = "0x60017D9")]
	void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer);

	[Token(Token = "0x60017DA")]
	void OnPhotonRandomJoinFailed(object[] codeAndMsg);

	[Token(Token = "0x60017DB")]
	void OnConnectedToMaster();

	[Token(Token = "0x60017DC")]
	void OnPhotonMaxCccuReached();

	[Token(Token = "0x60017DD")]
	void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged);

	[Token(Token = "0x60017DE")]
	void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps);

	[Token(Token = "0x60017DF")]
	void OnUpdatedFriendList();

	[Token(Token = "0x60017E0")]
	void OnCustomAuthenticationFailed(string debugMessage);

	[Token(Token = "0x60017E1")]
	void OnCustomAuthenticationResponse(Dictionary<string, object> data);

	[Token(Token = "0x60017E2")]
	void OnWebRpcResponse(OperationResponse response);

	[Token(Token = "0x60017E3")]
	void OnOwnershipRequest(object[] viewAndPlayer);

	[Token(Token = "0x60017E4")]
	void OnLobbyStatisticsUpdate();

	[Token(Token = "0x60017E5")]
	void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer);

	[Token(Token = "0x60017E6")]
	void OnOwnershipTransfered(object[] viewAndPlayers);
}
