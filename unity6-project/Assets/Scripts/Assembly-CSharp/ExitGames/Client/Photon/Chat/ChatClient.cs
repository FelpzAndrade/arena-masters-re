using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000328")]
	public class ChatClient
	{
		[Token(Token = "0x4001068")]
		private const int FriendRequestListMax = 1024;

		[Token(Token = "0x4001069")]
		private const string ChatAppName = "chat";

		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x8")]
		private string chatRegion;

		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0xC")]
		public int MessageLimit;

		[Token(Token = "0x400106C")]
		[FieldOffset(Offset = "0x10")]
		public readonly Dictionary<string, ChatChannel> PublicChannels;

		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x14")]
		public readonly Dictionary<string, ChatChannel> PrivateChannels;

		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<string> PublicChannelsUnsubscribing;

		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IChatClientListener listener;

		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x20")]
		public ChatPeer chatPeer;

		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x24")]
		private bool didAuthenticate;

		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0x28")]
		private int msDeltaForServiceCalls;

		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x2C")]
		private int msTimestampOfLastServiceCall;

		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x30")]
		private string NameServerAddress__BackingField;

		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0x34")]
		private string FrontendAddress__BackingField;

		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0x38")]
		private ChatState State__BackingField;

		[Token(Token = "0x4001077")]
		[FieldOffset(Offset = "0x3C")]
		private ChatDisconnectCause DisconnectedCause__BackingField;

		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x40")]
		private string AppVersion__BackingField;

		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x44")]
		private string AppId__BackingField;

		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x48")]
		private AuthenticationValues AuthValues__BackingField;

		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x4C")]
		private bool UseBackgroundWorkerForSending__BackingField;

		[Token(Token = "0x17000495")]
		public string NameServerAddress
		{
			[Token(Token = "0x6001AF1")]
			[Address(RVA = "0x1E7A258", Offset = "0x1E7A258", VA = "0x1E7A258")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF2")]
			[Address(RVA = "0x1E7A260", Offset = "0x1E7A260", VA = "0x1E7A260")]
			private set
			{
			}
		}

		[Token(Token = "0x17000496")]
		public string FrontendAddress
		{
			[Token(Token = "0x6001AF3")]
			[Address(RVA = "0x1E7A268", Offset = "0x1E7A268", VA = "0x1E7A268")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF4")]
			[Address(RVA = "0x1E7A270", Offset = "0x1E7A270", VA = "0x1E7A270")]
			private set
			{
			}
		}

		[Token(Token = "0x17000497")]
		public string ChatRegion
		{
			[Token(Token = "0x6001AF5")]
			[Address(RVA = "0x1E7A278", Offset = "0x1E7A278", VA = "0x1E7A278")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF6")]
			[Address(RVA = "0x1E7A280", Offset = "0x1E7A280", VA = "0x1E7A280")]
			set
			{
			}
		}

		[Token(Token = "0x17000498")]
		public ChatState State
		{
			[Token(Token = "0x6001AF7")]
			[Address(RVA = "0x1E79D40", Offset = "0x1E79D40", VA = "0x1E79D40")]
			get
			{
				return default(ChatState);
			}
			[Token(Token = "0x6001AF8")]
			[Address(RVA = "0x1E7742C", Offset = "0x1E7742C", VA = "0x1E7742C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000499")]
		public ChatDisconnectCause DisconnectedCause
		{
			[Token(Token = "0x6001AF9")]
			[Address(RVA = "0x1E7A288", Offset = "0x1E7A288", VA = "0x1E7A288")]
			get
			{
				return default(ChatDisconnectCause);
			}
			[Token(Token = "0x6001AFA")]
			[Address(RVA = "0x1E7A290", Offset = "0x1E7A290", VA = "0x1E7A290")]
			private set
			{
			}
		}

		[Token(Token = "0x1700049A")]
		public bool CanChat
		{
			[Token(Token = "0x6001AFB")]
			[Address(RVA = "0x1E7A298", Offset = "0x1E7A298", VA = "0x1E7A298")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700049B")]
		private bool HasPeer
		{
			[Token(Token = "0x6001AFD")]
			[Address(RVA = "0x1E7A2BC", Offset = "0x1E7A2BC", VA = "0x1E7A2BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700049C")]
		public string AppVersion
		{
			[Token(Token = "0x6001AFE")]
			[Address(RVA = "0x1E79930", Offset = "0x1E79930", VA = "0x1E79930")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFF")]
			[Address(RVA = "0x1E7A3C8", Offset = "0x1E7A3C8", VA = "0x1E7A3C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700049D")]
		public string AppId
		{
			[Token(Token = "0x6001B00")]
			[Address(RVA = "0x1E79928", Offset = "0x1E79928", VA = "0x1E79928")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B01")]
			[Address(RVA = "0x1E7A3D0", Offset = "0x1E7A3D0", VA = "0x1E7A3D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700049E")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x6001B02")]
			[Address(RVA = "0x1E79938", Offset = "0x1E79938", VA = "0x1E79938")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B03")]
			[Address(RVA = "0x1E7A3D8", Offset = "0x1E7A3D8", VA = "0x1E7A3D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700049F")]
		public string UserId
		{
			[Token(Token = "0x6001B04")]
			[Address(RVA = "0x1E7A3E0", Offset = "0x1E7A3E0", VA = "0x1E7A3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B05")]
			[Address(RVA = "0x1E7A3F4", Offset = "0x1E7A3F4", VA = "0x1E7A3F4")]
			private set
			{
			}
		}

		[Token(Token = "0x170004A0")]
		public bool UseBackgroundWorkerForSending
		{
			[Token(Token = "0x6001B06")]
			[Address(RVA = "0x1E7A4B8", Offset = "0x1E7A4B8", VA = "0x1E7A4B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B07")]
			[Address(RVA = "0x1E7A4C0", Offset = "0x1E7A4C0", VA = "0x1E7A4C0")]
			set
			{
			}
		}

		[Token(Token = "0x170004A1")]
		public ConnectionProtocol TransportProtocol
		{
			[Token(Token = "0x6001B08")]
			[Address(RVA = "0x1E7A4C8", Offset = "0x1E7A4C8", VA = "0x1E7A4C8")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Token(Token = "0x6001B09")]
			[Address(RVA = "0x1E7A4F4", Offset = "0x1E7A4F4", VA = "0x1E7A4F4")]
			set
			{
			}
		}

		[Token(Token = "0x170004A2")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Token(Token = "0x6001B0A")]
			[Address(RVA = "0x1E7A780", Offset = "0x1E7A780", VA = "0x1E7A780")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A3")]
		public DebugLevel DebugOut
		{
			[Token(Token = "0x6001B24")]
			[Address(RVA = "0x1E7930C", Offset = "0x1E7930C", VA = "0x1E7930C")]
			get
			{
				return default(DebugLevel);
			}
			[Token(Token = "0x6001B23")]
			[Address(RVA = "0x1E7CEEC", Offset = "0x1E7CEEC", VA = "0x1E7CEEC")]
			set
			{
			}
		}

		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x1E772DC", Offset = "0x1E772DC", VA = "0x1E772DC")]
		public ChatClient(IChatClientListener listener, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x1E774F0", Offset = "0x1E774F0", VA = "0x1E774F0", Slot = "4")]
		private void ExitGames_002EClient_002EPhoton_002EIPhotonPeerListener_002EDebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x1E77604", Offset = "0x1E77604", VA = "0x1E77604", Slot = "7")]
		private void ExitGames_002EClient_002EPhoton_002EIPhotonPeerListener_002EOnEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x1E78754", Offset = "0x1E78754", VA = "0x1E78754", Slot = "5")]
		private void ExitGames_002EClient_002EPhoton_002EIPhotonPeerListener_002EOnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x1E79330", Offset = "0x1E79330", VA = "0x1E79330", Slot = "6")]
		private void ExitGames_002EClient_002EPhoton_002EIPhotonPeerListener_002EOnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x1E7A2CC", Offset = "0x1E7A2CC", VA = "0x1E7A2CC")]
		public bool CanChatInChannel(string channelName)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x1E7A7A4", Offset = "0x1E7A7A4", VA = "0x1E7A7A4")]
		public bool Connect(string appId, string appVersion, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x1E7ADAC", Offset = "0x1E7ADAC", VA = "0x1E7ADAC")]
		public void Service()
		{
		}

		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x1E7AE80", Offset = "0x1E7AE80", VA = "0x1E7AE80")]
		private bool SendOutgoingInBackground()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x1E7AEE0", Offset = "0x1E7AEE0", VA = "0x1E7AEE0")]
		public void SendAcksOnly()
		{
		}

		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x1E7AF2C", Offset = "0x1E7AF2C", VA = "0x1E7AF2C")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x1E7AFA8", Offset = "0x1E7AFA8", VA = "0x1E7AFA8")]
		public void StopThread()
		{
		}

		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x1E7AFF4", Offset = "0x1E7AFF4", VA = "0x1E7AFF4")]
		public bool Subscribe(string[] channels)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x1E7AFFC", Offset = "0x1E7AFFC", VA = "0x1E7AFFC")]
		public bool Subscribe(string[] channels, int messagesFromHistory)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x1E7B3A8", Offset = "0x1E7B3A8", VA = "0x1E7B3A8")]
		public bool Unsubscribe(string[] channels)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x1E7B634", Offset = "0x1E7B634", VA = "0x1E7B634")]
		public bool PublishMessage(string channelName, object message, bool forwardAsWebhook = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x1E7B9E0", Offset = "0x1E7B9E0", VA = "0x1E7B9E0")]
		internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x1E7B654", Offset = "0x1E7B654", VA = "0x1E7B654")]
		private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x1E7BA00", Offset = "0x1E7BA00", VA = "0x1E7BA00")]
		public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x1E7BA28", Offset = "0x1E7BA28", VA = "0x1E7BA28")]
		public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x1E7BDE8", Offset = "0x1E7BDE8", VA = "0x1E7BDE8")]
		internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x1E7BA50", Offset = "0x1E7BA50", VA = "0x1E7BA50")]
		private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x1E7BE10", Offset = "0x1E7BE10", VA = "0x1E7BE10")]
		private bool SetOnlineStatus(int status, object message, bool skipMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x1E7C0C0", Offset = "0x1E7C0C0", VA = "0x1E7C0C0")]
		public bool SetOnlineStatus(int status)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x1E7C0E0", Offset = "0x1E7C0E0", VA = "0x1E7C0E0")]
		public bool SetOnlineStatus(int status, object message)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x1E7C0FC", Offset = "0x1E7C0FC", VA = "0x1E7C0FC")]
		public bool AddFriends(string[] friends)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x1E7C6A4", Offset = "0x1E7C6A4", VA = "0x1E7C6A4")]
		public bool RemoveFriends(string[] friends)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x1E7CC4C", Offset = "0x1E7CC4C", VA = "0x1E7CC4C")]
		public string GetPrivateChannelNameByUser(string userName)
		{
			return null;
		}

		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x1E7CD34", Offset = "0x1E7CD34", VA = "0x1E7CD34")]
		public bool TryGetChannel(string channelName, bool isPrivate, out ChatChannel channel)
		{
			channel = default;
			return default(bool);
		}

		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x1E7CE08", Offset = "0x1E7CE08", VA = "0x1E7CE08")]
		public bool TryGetChannel(string channelName, out ChatChannel channel)
		{
			channel = default;
			return default(bool);
		}

		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x1E7B22C", Offset = "0x1E7B22C", VA = "0x1E7B22C")]
		private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x1E77AD0", Offset = "0x1E77AD0", VA = "0x1E77AD0")]
		private void HandlePrivateMessageEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x1E77684", Offset = "0x1E77684", VA = "0x1E77684")]
		private void HandleChatMessagesEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x1E78288", Offset = "0x1E78288", VA = "0x1E78288")]
		private void HandleSubscribeEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x1E78568", Offset = "0x1E78568", VA = "0x1E78568")]
		private void HandleUnsubscribeEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x1E78A50", Offset = "0x1E78A50", VA = "0x1E78A50")]
		private void HandleAuthResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x1E77F80", Offset = "0x1E77F80", VA = "0x1E77F80")]
		private void HandleStatusUpdate(EventData eventData)
		{
		}

		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x1E7A054", Offset = "0x1E7A054", VA = "0x1E7A054")]
		private void ConnectToFrontEnd()
		{
		}

		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x1E79D48", Offset = "0x1E79D48", VA = "0x1E79D48")]
		private bool AuthenticateOnFrontEnd()
		{
			return default(bool);
		}
	}
}
