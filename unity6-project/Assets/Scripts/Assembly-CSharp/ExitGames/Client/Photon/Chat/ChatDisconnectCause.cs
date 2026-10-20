using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000329")]
	public enum ChatDisconnectCause
	{
		[Token(Token = "0x400107D")]
		None = 0,
		[Token(Token = "0x400107E")]
		DisconnectByServerUserLimit = 1,
		[Token(Token = "0x400107F")]
		ExceptionOnConnect = 2,
		[Token(Token = "0x4001080")]
		DisconnectByServer = 3,
		[Token(Token = "0x4001081")]
		TimeoutDisconnect = 4,
		[Token(Token = "0x4001082")]
		Exception = 5,
		[Token(Token = "0x4001083")]
		InvalidAuthentication = 6,
		[Token(Token = "0x4001084")]
		MaxCcuReached = 7,
		[Token(Token = "0x4001085")]
		InvalidRegion = 8,
		[Token(Token = "0x4001086")]
		OperationNotAllowedInCurrentState = 9,
		[Token(Token = "0x4001087")]
		CustomAuthenticationFailed = 10
	}
}
