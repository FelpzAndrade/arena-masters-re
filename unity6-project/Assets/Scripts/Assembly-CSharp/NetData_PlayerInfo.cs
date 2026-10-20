using Il2CppDummyDll;

[Token(Token = "0x20005BD")]
public class NetData_PlayerInfo
{
	[Token(Token = "0x4001BD4")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x4001BD5")]
	[FieldOffset(Offset = "0xC")]
	public string countryCode;

	[Token(Token = "0x4001BD6")]
	[FieldOffset(Offset = "0x10")]
	public int charId;

	[Token(Token = "0x4001BD7")]
	[FieldOffset(Offset = "0x14")]
	public int charSkinId;

	[Token(Token = "0x4001BD8")]
	[FieldOffset(Offset = "0x18")]
	public short level;

	[Token(Token = "0x4001BD9")]
	[FieldOffset(Offset = "0x1C")]
	public int charId2;

	[Token(Token = "0x4001BDA")]
	[FieldOffset(Offset = "0x20")]
	public int charSkinId2;

	[Token(Token = "0x4001BDB")]
	[FieldOffset(Offset = "0x24")]
	public short level2;

	[Token(Token = "0x4001BDC")]
	[FieldOffset(Offset = "0x28")]
	public int relicId;

	[Token(Token = "0x4001BDD")]
	[FieldOffset(Offset = "0x2C")]
	public short relicLevel;

	[Token(Token = "0x4001BDE")]
	[FieldOffset(Offset = "0x2E")]
	public short TeamID;

	[Token(Token = "0x4001BDF")]
	[FieldOffset(Offset = "0x30")]
	public short ping;

	[Token(Token = "0x4001BE0")]
	[FieldOffset(Offset = "0x32")]
	public short elo;

	[Token(Token = "0x4001BE1")]
	[FieldOffset(Offset = "0x34")]
	public short roundResult_0;

	[Token(Token = "0x4001BE2")]
	[FieldOffset(Offset = "0x36")]
	public short roundResult_1;

	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x38")]
	public short roundResult_2;

	[Token(Token = "0x4001BE4")]
	[FieldOffset(Offset = "0x3A")]
	public short roundResult_3;

	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x3C")]
	public short roundResult_4;

	[Token(Token = "0x4001BE6")]
	[FieldOffset(Offset = "0x3E")]
	public bool isPlacement;

	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x40")]
	public short profileIconId;

	[Token(Token = "0x4001BE8")]
	[FieldOffset(Offset = "0x42")]
	public short titleId;

	[Token(Token = "0x4001BE9")]
	[FieldOffset(Offset = "0x44")]
	public int petId;

	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x135DE90", Offset = "0x135DE90", VA = "0x135DE90")]
	public NetData_PlayerInfo()
	{
	}
}
