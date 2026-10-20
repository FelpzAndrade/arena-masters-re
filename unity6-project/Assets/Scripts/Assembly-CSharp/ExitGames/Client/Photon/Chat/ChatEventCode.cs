using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x200032A")]
	public class ChatEventCode
	{
		[Token(Token = "0x4001088")]
		public const byte ChatMessages = 0;

		[Token(Token = "0x4001089")]
		public const byte Users = 1;

		[Token(Token = "0x400108A")]
		public const byte PrivateMessage = 2;

		[Token(Token = "0x400108B")]
		public const byte FriendsList = 3;

		[Token(Token = "0x400108C")]
		public const byte StatusUpdate = 4;

		[Token(Token = "0x400108D")]
		public const byte Subscribe = 5;

		[Token(Token = "0x400108E")]
		public const byte Unsubscribe = 6;

		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x1E7CF10", Offset = "0x1E7CF10", VA = "0x1E7CF10")]
		public ChatEventCode()
		{
		}
	}
}
