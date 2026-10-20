using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

namespace Photon
{
	[Token(Token = "0x20002C6")]
	public class PunBehaviour : MonoBehaviour, IPunCallbacks
	{
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x1B80438", Offset = "0x1B80438", VA = "0x1B80438")]
		public PunBehaviour()
		{
		}

		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x1B80440", Offset = "0x1B80440", VA = "0x1B80440", Slot = "33")]
		public virtual void OnConnectedToPhoton()
		{
		}

		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x1B80444", Offset = "0x1B80444", VA = "0x1B80444", Slot = "34")]
		public virtual void OnLeftRoom()
		{
		}

		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x1B80448", Offset = "0x1B80448", VA = "0x1B80448", Slot = "35")]
		public virtual void OnMasterClientSwitched(PhotonPlayer newMasterClient)
		{
		}

		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x1B8044C", Offset = "0x1B8044C", VA = "0x1B8044C", Slot = "36")]
		public virtual void OnPhotonCreateRoomFailed(object[] codeAndMsg)
		{
		}

		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x1B80450", Offset = "0x1B80450", VA = "0x1B80450", Slot = "37")]
		public virtual void OnPhotonJoinRoomFailed(object[] codeAndMsg)
		{
		}

		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x1B80454", Offset = "0x1B80454", VA = "0x1B80454", Slot = "38")]
		public virtual void OnCreatedRoom()
		{
		}

		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x1B80458", Offset = "0x1B80458", VA = "0x1B80458", Slot = "39")]
		public virtual void OnJoinedLobby()
		{
		}

		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x1B8045C", Offset = "0x1B8045C", VA = "0x1B8045C", Slot = "40")]
		public virtual void OnLeftLobby()
		{
		}

		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x1B80460", Offset = "0x1B80460", VA = "0x1B80460", Slot = "41")]
		public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
		{
		}

		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x1B80464", Offset = "0x1B80464", VA = "0x1B80464", Slot = "42")]
		public virtual void OnDisconnectedFromPhoton()
		{
		}

		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x1B80468", Offset = "0x1B80468", VA = "0x1B80468", Slot = "43")]
		public virtual void OnConnectionFail(DisconnectCause cause)
		{
		}

		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x1B8046C", Offset = "0x1B8046C", VA = "0x1B8046C", Slot = "44")]
		public virtual void OnPhotonInstantiate(PhotonMessageInfo info)
		{
		}

		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x1B80470", Offset = "0x1B80470", VA = "0x1B80470", Slot = "45")]
		public virtual void OnReceivedRoomListUpdate()
		{
		}

		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x1B80474", Offset = "0x1B80474", VA = "0x1B80474", Slot = "46")]
		public virtual void OnJoinedRoom()
		{
		}

		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x1B80478", Offset = "0x1B80478", VA = "0x1B80478", Slot = "47")]
		public virtual void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
		{
		}

		[Token(Token = "0x60017FB")]
		[Address(RVA = "0x1B8047C", Offset = "0x1B8047C", VA = "0x1B8047C", Slot = "48")]
		public virtual void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
		{
		}

		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x1B80480", Offset = "0x1B80480", VA = "0x1B80480", Slot = "49")]
		public virtual void OnPhotonRandomJoinFailed(object[] codeAndMsg)
		{
		}

		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x1B80484", Offset = "0x1B80484", VA = "0x1B80484", Slot = "50")]
		public virtual void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x1B80488", Offset = "0x1B80488", VA = "0x1B80488", Slot = "51")]
		public virtual void OnPhotonMaxCccuReached()
		{
		}

		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x1B8048C", Offset = "0x1B8048C", VA = "0x1B8048C", Slot = "52")]
		public virtual void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x6001800")]
		[Address(RVA = "0x1B80490", Offset = "0x1B80490", VA = "0x1B80490", Slot = "53")]
		public virtual void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
		{
		}

		[Token(Token = "0x6001801")]
		[Address(RVA = "0x1B80494", Offset = "0x1B80494", VA = "0x1B80494", Slot = "54")]
		public virtual void OnUpdatedFriendList()
		{
		}

		[Token(Token = "0x6001802")]
		[Address(RVA = "0x1B80498", Offset = "0x1B80498", VA = "0x1B80498", Slot = "55")]
		public virtual void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		[Token(Token = "0x6001803")]
		[Address(RVA = "0x1B8049C", Offset = "0x1B8049C", VA = "0x1B8049C", Slot = "56")]
		public virtual void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x6001804")]
		[Address(RVA = "0x1B804A0", Offset = "0x1B804A0", VA = "0x1B804A0", Slot = "57")]
		public virtual void OnWebRpcResponse(OperationResponse response)
		{
		}

		[Token(Token = "0x6001805")]
		[Address(RVA = "0x1B804A4", Offset = "0x1B804A4", VA = "0x1B804A4", Slot = "58")]
		public virtual void OnOwnershipRequest(object[] viewAndPlayer)
		{
		}

		[Token(Token = "0x6001806")]
		[Address(RVA = "0x1B804A8", Offset = "0x1B804A8", VA = "0x1B804A8", Slot = "59")]
		public virtual void OnLobbyStatisticsUpdate()
		{
		}

		[Token(Token = "0x6001807")]
		[Address(RVA = "0x1B804AC", Offset = "0x1B804AC", VA = "0x1B804AC", Slot = "60")]
		public virtual void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer)
		{
		}

		[Token(Token = "0x6001808")]
		[Address(RVA = "0x1B804B0", Offset = "0x1B804B0", VA = "0x1B804B0", Slot = "61")]
		public virtual void OnOwnershipTransfered(object[] viewAndPlayers)
		{
		}
	}
}
