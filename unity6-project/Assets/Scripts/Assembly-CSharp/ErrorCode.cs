using Il2CppDummyDll;

[Token(Token = "0x20002A8")]
public class ErrorCode
{
	[Token(Token = "0x4000CF9")]
	public const int Ok = 0;

	[Token(Token = "0x4000CFA")]
	public const int OperationNotAllowedInCurrentState = -3;

	[Token(Token = "0x4000CFB")]
	public const int InvalidOperationCode = -2;

	[Token(Token = "0x4000CFC")]
	public const int InvalidOperation = -2;

	[Token(Token = "0x4000CFD")]
	public const int InternalServerError = -1;

	[Token(Token = "0x4000CFE")]
	public const int InvalidAuthentication = 32767;

	[Token(Token = "0x4000CFF")]
	public const int GameIdAlreadyExists = 32766;

	[Token(Token = "0x4000D00")]
	public const int GameFull = 32765;

	[Token(Token = "0x4000D01")]
	public const int GameClosed = 32764;

	[Token(Token = "0x4000D02")]
	public const int AlreadyMatched = 32763;

	[Token(Token = "0x4000D03")]
	public const int ServerFull = 32762;

	[Token(Token = "0x4000D04")]
	public const int UserBlocked = 32761;

	[Token(Token = "0x4000D05")]
	public const int NoRandomMatchFound = 32760;

	[Token(Token = "0x4000D06")]
	public const int GameDoesNotExist = 32758;

	[Token(Token = "0x4000D07")]
	public const int MaxCcuReached = 32757;

	[Token(Token = "0x4000D08")]
	public const int InvalidRegion = 32756;

	[Token(Token = "0x4000D09")]
	public const int CustomAuthenticationFailed = 32755;

	[Token(Token = "0x4000D0A")]
	public const int AuthenticationTicketExpired = 32753;

	[Token(Token = "0x4000D0B")]
	public const int PluginReportedError = 32752;

	[Token(Token = "0x4000D0C")]
	public const int PluginMismatch = 32751;

	[Token(Token = "0x4000D0D")]
	public const int JoinFailedPeerAlreadyJoined = 32750;

	[Token(Token = "0x4000D0E")]
	public const int JoinFailedFoundInactiveJoiner = 32749;

	[Token(Token = "0x4000D0F")]
	public const int JoinFailedWithRejoinerNotFound = 32748;

	[Token(Token = "0x4000D10")]
	public const int JoinFailedFoundExcludedUserId = 32747;

	[Token(Token = "0x4000D11")]
	public const int JoinFailedFoundActiveJoiner = 32746;

	[Token(Token = "0x4000D12")]
	public const int HttpLimitReached = 32745;

	[Token(Token = "0x4000D13")]
	public const int ExternalHttpCallFailed = 32744;

	[Token(Token = "0x4000D14")]
	public const int SlotError = 32742;

	[Token(Token = "0x4000D15")]
	public const int InvalidEncryptionParameters = 32741;

	[Token(Token = "0x4000D16")]
	public const int AlreadyJoinedMatch = 32700;

	[Token(Token = "0x4000D17")]
	public const int CannotFindMatchUnit = 32699;

	[Token(Token = "0x4000D18")]
	public const int CreateFailedMatchUnit = 32698;

	[Token(Token = "0x4000D19")]
	public const int AlreadyRegisted = 32697;

	[Token(Token = "0x4000D1A")]
	public const int NotFindParty = 32696;

	[Token(Token = "0x4000D1B")]
	public const int CanNotJoinParty = 32695;

	[Token(Token = "0x4000D1C")]
	public const int NotTheMaster = 32694;

	[Token(Token = "0x4000D1D")]
	public const int NotFullPartyMember = 32693;

	[Token(Token = "0x4000D1E")]
	public const int IsNotAllReady = 32692;

	[Token(Token = "0x4000D1F")]
	public const int InternalError = 32200;

	[Token(Token = "0x4000D20")]
	public const int PartyIsBreaked = 32201;

	[Token(Token = "0x6001707")]
	[Address(RVA = "0x1E6AF64", Offset = "0x1E6AF64", VA = "0x1E6AF64")]
	public ErrorCode()
	{
	}
}
