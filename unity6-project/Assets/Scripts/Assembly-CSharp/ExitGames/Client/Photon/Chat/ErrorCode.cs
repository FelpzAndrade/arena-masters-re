using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000331")]
	public class ErrorCode
	{
		[Token(Token = "0x40010C2")]
		public const int Ok = 0;

		[Token(Token = "0x40010C3")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40010C4")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40010C5")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40010C6")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40010C7")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40010C8")]
		public const int GameFull = 32765;

		[Token(Token = "0x40010C9")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40010CA")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40010CB")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x40010CC")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x40010CD")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x40010CE")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x40010CF")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x40010D0")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0x1E7D6A4", Offset = "0x1E7D6A4", VA = "0x1E7D6A4")]
		public ErrorCode()
		{
		}
	}
}
