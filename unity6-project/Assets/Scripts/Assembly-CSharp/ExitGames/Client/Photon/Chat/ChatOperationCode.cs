using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x200032B")]
	public class ChatOperationCode
	{
		[Token(Token = "0x400108F")]
		public const byte Authenticate = 230;

		[Token(Token = "0x4001090")]
		public const byte Subscribe = 0;

		[Token(Token = "0x4001091")]
		public const byte Unsubscribe = 1;

		[Token(Token = "0x4001092")]
		public const byte Publish = 2;

		[Token(Token = "0x4001093")]
		public const byte SendPrivate = 3;

		[Token(Token = "0x4001094")]
		public const byte ChannelHistory = 4;

		[Token(Token = "0x4001095")]
		public const byte UpdateStatus = 5;

		[Token(Token = "0x4001096")]
		public const byte AddFriends = 6;

		[Token(Token = "0x4001097")]
		public const byte RemoveFriends = 7;

		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x1E7CF18", Offset = "0x1E7CF18", VA = "0x1E7CF18")]
		public ChatOperationCode()
		{
		}
	}
}
