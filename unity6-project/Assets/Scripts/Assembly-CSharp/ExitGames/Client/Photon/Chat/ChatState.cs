using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000332")]
	public enum ChatState
	{
		[Token(Token = "0x40010D2")]
		Uninitialized = 0,
		[Token(Token = "0x40010D3")]
		ConnectingToNameServer = 1,
		[Token(Token = "0x40010D4")]
		ConnectedToNameServer = 2,
		[Token(Token = "0x40010D5")]
		Authenticating = 3,
		[Token(Token = "0x40010D6")]
		Authenticated = 4,
		[Token(Token = "0x40010D7")]
		DisconnectingFromNameServer = 5,
		[Token(Token = "0x40010D8")]
		ConnectingToFrontEnd = 6,
		[Token(Token = "0x40010D9")]
		ConnectedToFrontEnd = 7,
		[Token(Token = "0x40010DA")]
		DisconnectingFromFrontEnd = 8,
		[Token(Token = "0x40010DB")]
		QueuedComingFromFrontEnd = 9,
		[Token(Token = "0x40010DC")]
		Disconnecting = 10,
		[Token(Token = "0x40010DD")]
		Disconnected = 11
	}
}
