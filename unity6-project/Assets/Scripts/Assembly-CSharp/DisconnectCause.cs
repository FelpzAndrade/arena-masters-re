using Il2CppDummyDll;

[Token(Token = "0x20002BD")]
public enum DisconnectCause
{
	[Token(Token = "0x4000E3E")]
	DisconnectByServerUserLimit = 1042,
	[Token(Token = "0x4000E3F")]
	ExceptionOnConnect = 1023,
	[Token(Token = "0x4000E40")]
	DisconnectByServerTimeout = 1041,
	[Token(Token = "0x4000E41")]
	DisconnectByServerLogic = 1043,
	[Token(Token = "0x4000E42")]
	Exception = 1026,
	[Token(Token = "0x4000E43")]
	InvalidAuthentication = 32767,
	[Token(Token = "0x4000E44")]
	MaxCcuReached = 32757,
	[Token(Token = "0x4000E45")]
	InvalidRegion = 32756,
	[Token(Token = "0x4000E46")]
	SecurityExceptionOnConnect = 1022,
	[Token(Token = "0x4000E47")]
	DisconnectByClientTimeout = 1040,
	[Token(Token = "0x4000E48")]
	InternalReceiveException = 1039,
	[Token(Token = "0x4000E49")]
	AuthenticationTicketExpired = 32753
}
