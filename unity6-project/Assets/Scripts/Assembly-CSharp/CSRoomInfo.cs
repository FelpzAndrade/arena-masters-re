using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000976")]
public class CSRoomInfo
{
	[Token(Token = "0x4002EC9")]
	[FieldOffset(Offset = "0x8")]
	public string RoomNumber;

	[Token(Token = "0x4002ECA")]
	[FieldOffset(Offset = "0xC")]
	public string MasterName;

	[Token(Token = "0x4002ECB")]
	[FieldOffset(Offset = "0x10")]
	public string RoomTitle;

	[Token(Token = "0x4002ECC")]
	[FieldOffset(Offset = "0x14")]
	public string ModeName;

	[Token(Token = "0x4002ECD")]
	[FieldOffset(Offset = "0x18")]
	public string MapName;

	[Token(Token = "0x4002ECE")]
	[FieldOffset(Offset = "0x1C")]
	public string PlayerCounting;

	[Token(Token = "0x4002ECF")]
	[FieldOffset(Offset = "0x20")]
	public string Password;

	[Token(Token = "0x4002ED0")]
	[FieldOffset(Offset = "0x24")]
	public bool IsLock;

	[Token(Token = "0x4002ED1")]
	[FieldOffset(Offset = "0x28")]
	public int GameModeInstanceID;

	[Token(Token = "0x4002ED2")]
	[FieldOffset(Offset = "0x2C")]
	public int SectorID;

	[Token(Token = "0x4002ED3")]
	[FieldOffset(Offset = "0x30")]
	public string PhtonRoomName;

	[Token(Token = "0x4002ED4")]
	[FieldOffset(Offset = "0x34")]
	public MatchType MatchType;

	[Token(Token = "0x4002ED5")]
	[FieldOffset(Offset = "0x38")]
	public XGameModeType GameModeType;

	[Token(Token = "0x6004C2A")]
	[Address(RVA = "0x21F64B0", Offset = "0x21F64B0", VA = "0x21F64B0")]
	public CSRoomInfo()
	{
	}
}
