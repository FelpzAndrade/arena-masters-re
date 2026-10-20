using System.Collections.Generic;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002A4")]
internal class LoadBalancingPeer : PhotonPeer
{
		protected LoadBalancingPeer() : base(default(ConnectionProtocol))
		{
		}

	[Token(Token = "0x20002A5")]
	private enum RoomOptionBit
	{
		[Token(Token = "0x4000CE5")]
		CheckUserOnJoin = 1,
		[Token(Token = "0x4000CE6")]
		DeleteCacheOnLeave = 2,
		[Token(Token = "0x4000CE7")]
		SuppressRoomEvents = 4,
		[Token(Token = "0x4000CE8")]
		PublishUserId = 8,
		[Token(Token = "0x4000CE9")]
		DeleteNullProps = 0x10,
		[Token(Token = "0x4000CEA")]
		BroadcastPropsChangeToAll = 0x20
	}

	[Token(Token = "0x4000CE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Dictionary<byte, object> opParameters;

	[Token(Token = "0x170003D3")]
	internal bool IsProtocolSecure
	{
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x13497D4", Offset = "0x13497D4", VA = "0x13497D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x1349638", Offset = "0x1349638", VA = "0x1349638")]
	public LoadBalancingPeer(ConnectionProtocol protocolType) : base(protocolType)
	{
	}

	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x1349718", Offset = "0x1349718", VA = "0x1349718")]
	public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType) : base(listener, protocolType)
	{
	}

	[Token(Token = "0x60016E0")]
	[Address(RVA = "0x13497F8", Offset = "0x13497F8", VA = "0x13497F8", Slot = "17")]
	public virtual bool OpGetRegions(string appId)
	{
		return default(bool);
	}

	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x1349924", Offset = "0x1349924", VA = "0x1349924", Slot = "18")]
	public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
	{
		return default(bool);
	}

	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x1349B5C", Offset = "0x1349B5C", VA = "0x1349B5C", Slot = "19")]
	public virtual bool OpLeaveLobby()
	{
		return default(bool);
	}

	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x1349CC8", Offset = "0x1349CC8", VA = "0x1349CC8")]
	private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
	{
	}

	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x134A284", Offset = "0x134A284", VA = "0x134A284", Slot = "20")]
	public virtual bool OpCreateRoom(EnterRoomParams opParams)
	{
		return default(bool);
	}

	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x134AA2C", Offset = "0x134AA2C", VA = "0x134AA2C", Slot = "21")]
	public virtual bool OpJoinRoom(EnterRoomParams opParams)
	{
		return default(bool);
	}

	[Token(Token = "0x60016E6")]
	[Address(RVA = "0x134AEAC", Offset = "0x134AEAC", VA = "0x134AEAC", Slot = "22")]
	public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
	{
		return default(bool);
	}

	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x134B3B8", Offset = "0x134B3B8", VA = "0x134B3B8", Slot = "23")]
	public virtual bool OpLeaveRoom(bool becomeInactive)
	{
		return default(bool);
	}

	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x134B50C", Offset = "0x134B50C", VA = "0x134B50C", Slot = "24")]
	public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
	{
		return default(bool);
	}

	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x134B8A4", Offset = "0x134B8A4", VA = "0x134B8A4", Slot = "25")]
	public virtual bool OpFindFriends(string[] friendsToFind)
	{
		return default(bool);
	}

	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x134B9D8", Offset = "0x134B9D8", VA = "0x134B9D8")]
	public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60016EB")]
	[Address(RVA = "0x134BAAC", Offset = "0x134BAAC", VA = "0x134BAAC")]
	protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, bool webForward = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x134BE9C", Offset = "0x134BE9C", VA = "0x134BE9C")]
	protected void OpSetPropertyOfRoom(byte propCode, object value)
	{
	}

	[Token(Token = "0x60016ED")]
	[Address(RVA = "0x134C264", Offset = "0x134C264", VA = "0x134C264")]
	public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties, bool broadcast, byte channelId)
	{
		return default(bool);
	}

	[Token(Token = "0x60016EE")]
	[Address(RVA = "0x134BF90", Offset = "0x134BF90", VA = "0x134BF90")]
	protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, bool webForward = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x134C32C", Offset = "0x134C32C", VA = "0x134C32C", Slot = "26")]
	public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x134CA5C", Offset = "0x134CA5C", VA = "0x134CA5C", Slot = "27")]
	public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x134D18C", Offset = "0x134D18C", VA = "0x134D18C", Slot = "28")]
	public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x134D3B4", Offset = "0x134D3B4", VA = "0x134D3B4", Slot = "29")]
	public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x134D758", Offset = "0x134D758", VA = "0x134D758", Slot = "30")]
	public virtual bool OpSettings(bool receiveLobbyStats)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x134D9A0", Offset = "0x134D9A0", VA = "0x134D9A0", Slot = "31")]
	public virtual bool OpJoinMatch(Hashtable match_properties)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x134DAC0", Offset = "0x134DAC0", VA = "0x134DAC0", Slot = "32")]
	public virtual bool OpCancelMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x134DB9C", Offset = "0x134DB9C", VA = "0x134DB9C", Slot = "33")]
	public virtual bool OpMatchGameStart(string usreID)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F7")]
	[Address(RVA = "0x134DCBC", Offset = "0x134DCBC", VA = "0x134DCBC", Slot = "34")]
	public virtual bool OpLeaveMatchRoom(string usreID)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x134DDDC", Offset = "0x134DDDC", VA = "0x134DDDC", Slot = "35")]
	public virtual bool OpCreateClanParty(Hashtable _htCreateClanParty)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x134DEFC", Offset = "0x134DEFC", VA = "0x134DEFC", Slot = "36")]
	public virtual bool OpJoinClanParty(Hashtable _htJoinClanParty)
	{
		return default(bool);
	}

	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x134E01C", Offset = "0x134E01C", VA = "0x134E01C", Slot = "37")]
	public virtual bool OpRefreshClanParty(string userAID, long _partyKey)
	{
		return default(bool);
	}

	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x134E160", Offset = "0x134E160", VA = "0x134E160", Slot = "38")]
	public virtual bool OpLeaveClanParty(Hashtable _htLeaveClanParty)
	{
		return default(bool);
	}

	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x134E280", Offset = "0x134E280", VA = "0x134E280", Slot = "39")]
	public virtual bool OpGetClanPartyList(Hashtable _htParam)
	{
		return default(bool);
	}

	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x134E3A0", Offset = "0x134E3A0", VA = "0x134E3A0", Slot = "40")]
	public virtual bool OpStartClanWar(Hashtable _htStartClanWar)
	{
		return default(bool);
	}

	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x134E4C0", Offset = "0x134E4C0", VA = "0x134E4C0", Slot = "41")]
	public virtual bool OpChangeReadyState(Hashtable _htReadyState)
	{
		return default(bool);
	}

	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x134E5E0", Offset = "0x134E5E0", VA = "0x134E5E0", Slot = "42")]
	public virtual bool OpCreateParty(Hashtable properties)
	{
		return default(bool);
	}

	[Token(Token = "0x6001700")]
	[Address(RVA = "0x134E700", Offset = "0x134E700", VA = "0x134E700", Slot = "43")]
	public virtual bool OpJoinParty(Hashtable properties)
	{
		return default(bool);
	}

	[Token(Token = "0x6001701")]
	[Address(RVA = "0x134E820", Offset = "0x134E820", VA = "0x134E820", Slot = "44")]
	public virtual bool OpLeaveParty(Hashtable properties)
	{
		return default(bool);
	}

	[Token(Token = "0x6001702")]
	[Address(RVA = "0x134E940", Offset = "0x134E940", VA = "0x134E940", Slot = "45")]
	public virtual bool OpStartPartyGame(Hashtable properties)
	{
		return default(bool);
	}

	[Token(Token = "0x6001703")]
	[Address(RVA = "0x134EA60", Offset = "0x134EA60", VA = "0x134EA60", Slot = "46")]
	public virtual bool OpChangePartyInfoState(Hashtable _htReadyState)
	{
		return default(bool);
	}

	[Token(Token = "0x6001704")]
	[Address(RVA = "0x134EB80", Offset = "0x134EB80", VA = "0x134EB80", Slot = "14")]
	public override bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable)
	{
		return default(bool);
	}
}
