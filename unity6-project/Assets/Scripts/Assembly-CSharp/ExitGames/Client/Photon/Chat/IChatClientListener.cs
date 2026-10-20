using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000334")]
	public interface IChatClientListener
	{
		[Token(Token = "0x6001B4B")]
		void DebugReturn(DebugLevel level, string message);

		[Token(Token = "0x6001B4C")]
		void OnDisconnected();

		[Token(Token = "0x6001B4D")]
		void OnConnected();

		[Token(Token = "0x6001B4E")]
		void OnChatStateChange(ChatState state);

		[Token(Token = "0x6001B4F")]
		void OnGetMessages(string channelName, string[] senders, object[] messages);

		[Token(Token = "0x6001B50")]
		void OnPrivateMessage(string sender, object message, string channelName);

		[Token(Token = "0x6001B51")]
		void OnSubscribed(string[] channels, bool[] results);

		[Token(Token = "0x6001B52")]
		void OnUnsubscribed(string[] channels);

		[Token(Token = "0x6001B53")]
		void OnStatusUpdate(string user, int status, bool gotMessage, object message);
	}
}
