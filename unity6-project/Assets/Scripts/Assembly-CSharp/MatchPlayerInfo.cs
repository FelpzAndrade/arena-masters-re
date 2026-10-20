using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005C2")]
public class MatchPlayerInfo
{
	[Token(Token = "0x4001BEE")]
	[FieldOffset(Offset = "0x8")]
	public string aid;

	[Token(Token = "0x4001BEF")]
	[FieldOffset(Offset = "0xC")]
	public short elo;

	[Token(Token = "0x4001BF0")]
	[FieldOffset(Offset = "0x10")]
	public string nickName;

	[Token(Token = "0x4001BF1")]
	[FieldOffset(Offset = "0x14")]
	public string[] charactersInfo;

	[Token(Token = "0x4001BF2")]
	[FieldOffset(Offset = "0x18")]
	public int relicID;

	[Token(Token = "0x4001BF3")]
	[FieldOffset(Offset = "0x1C")]
	public int relicLevel;

	[Token(Token = "0x4001BF4")]
	[FieldOffset(Offset = "0x20")]
	public XTeamEnum team;

	[Token(Token = "0x4001BF5")]
	[FieldOffset(Offset = "0x24")]
	public bool isPlacementTest;

	[Token(Token = "0x4001BF6")]
	[FieldOffset(Offset = "0x28")]
	public string clanName;

	[Token(Token = "0x4001BF7")]
	[FieldOffset(Offset = "0x2C")]
	public int clanMarkId;

	[Token(Token = "0x4001BF8")]
	[FieldOffset(Offset = "0x30")]
	public int clanColorId;

	[Token(Token = "0x6003109")]
	[Address(RVA = "0x135B9B4", Offset = "0x135B9B4", VA = "0x135B9B4")]
	public MatchPlayerInfo(string _aid, short _elo, string _nickName, string _characterInfo, int _relicID, int _relicLevel, XTeamEnum _team, bool _isPlacementTest, string _clanName, int _clanMarkId, int _clanColorId)
	{
	}

	[Token(Token = "0x600310A")]
	[Address(RVA = "0x135BCC0", Offset = "0x135BCC0", VA = "0x135BCC0")]
	public MatchPlayerInfo(XPlayer _player)
	{
	}

	[Token(Token = "0x600310B")]
	[Address(RVA = "0x135BE1C", Offset = "0x135BE1C", VA = "0x135BE1C")]
	public MatchPlayerInfo()
	{
	}

	[Token(Token = "0x600310C")]
	[Address(RVA = "0x135BE24", Offset = "0x135BE24", VA = "0x135BE24")]
	public bool TryGetCharacterInfo(int index, out int charID, out int charLv, out int charSkinID)
	{
		charID = default;
		charLv = default;
		charSkinID = default;
		return default(bool);
	}
}
