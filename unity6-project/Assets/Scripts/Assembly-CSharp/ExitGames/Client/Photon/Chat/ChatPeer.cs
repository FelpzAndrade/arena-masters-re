using System.Collections.Generic;
using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x200032D")]
	public class ChatPeer : PhotonPeer
	{
		[Token(Token = "0x40010A9")]
		public const string NameServerHost = "ns.exitgames.com";

		[Token(Token = "0x40010AA")]
		public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x170004A4")]
		public string NameServerAddress
		{
			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x1E7ABB4", Offset = "0x1E7ABB4", VA = "0x1E7ABB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A5")]
		internal virtual bool IsProtocolSecure
		{
			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x1E7D680", Offset = "0x1E7D680", VA = "0x1E7D680", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x1E77434", Offset = "0x1E77434", VA = "0x1E77434")]
		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol) : base(listener, protocol)
		{
		}

		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x1E7CF28", Offset = "0x1E7CF28", VA = "0x1E7CF28")]
		private void ConfigUnitySockets()
		{
		}

		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x1E7D394", Offset = "0x1E7D394", VA = "0x1E7D394")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x1E7ABB8", Offset = "0x1E7ABB8", VA = "0x1E7ABB8")]
		public bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x1E79940", Offset = "0x1E79940", VA = "0x1E79940")]
		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues)
		{
			return default(bool);
		}
	}
}
