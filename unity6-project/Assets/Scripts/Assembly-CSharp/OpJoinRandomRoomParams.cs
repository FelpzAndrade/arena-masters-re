using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002A6")]
internal class OpJoinRandomRoomParams
{
	[Token(Token = "0x4000CEB")]
	[FieldOffset(Offset = "0x8")]
	public Hashtable ExpectedCustomRoomProperties;

	[Token(Token = "0x4000CEC")]
	[FieldOffset(Offset = "0xC")]
	public byte ExpectedMaxPlayers;

	[Token(Token = "0x4000CED")]
	[FieldOffset(Offset = "0xD")]
	public MatchmakingMode MatchingType;

	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x10")]
	public TypedLobby TypedLobby;

	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x14")]
	public string SqlLobbyFilter;

	[Token(Token = "0x4000CF0")]
	[FieldOffset(Offset = "0x18")]
	public string[] ExpectedUsers;

	[Token(Token = "0x6001705")]
	[Address(RVA = "0x1B76E70", Offset = "0x1B76E70", VA = "0x1B76E70")]
	public OpJoinRandomRoomParams()
	{
	}
}
