using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002A7")]
internal class EnterRoomParams
{
	[Token(Token = "0x4000CF1")]
	[FieldOffset(Offset = "0x8")]
	public string RoomName;

	[Token(Token = "0x4000CF2")]
	[FieldOffset(Offset = "0xC")]
	public RoomOptions RoomOptions;

	[Token(Token = "0x4000CF3")]
	[FieldOffset(Offset = "0x10")]
	public TypedLobby Lobby;

	[Token(Token = "0x4000CF4")]
	[FieldOffset(Offset = "0x14")]
	public Hashtable PlayerProperties;

	[Token(Token = "0x4000CF5")]
	[FieldOffset(Offset = "0x18")]
	public bool OnGameServer;

	[Token(Token = "0x4000CF6")]
	[FieldOffset(Offset = "0x19")]
	public bool CreateIfNotExists;

	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x1A")]
	public bool RejoinOnly;

	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x1C")]
	public string[] ExpectedUsers;

	[Token(Token = "0x6001706")]
	[Address(RVA = "0x1E6A520", Offset = "0x1E6A520", VA = "0x1E6A520")]
	public EnterRoomParams()
	{
	}
}
