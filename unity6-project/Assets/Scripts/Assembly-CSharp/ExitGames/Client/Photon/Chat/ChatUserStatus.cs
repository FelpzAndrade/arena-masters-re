using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000333")]
	public static class ChatUserStatus
	{
		[Token(Token = "0x40010DE")]
		public const int Offline = 0;

		[Token(Token = "0x40010DF")]
		public const int Invisible = 1;

		[Token(Token = "0x40010E0")]
		public const int Online = 2;

		[Token(Token = "0x40010E1")]
		public const int Away = 3;

		[Token(Token = "0x40010E2")]
		public const int DND = 4;

		[Token(Token = "0x40010E3")]
		public const int LFG = 5;

		[Token(Token = "0x40010E4")]
		public const int Playing = 6;
	}
}
