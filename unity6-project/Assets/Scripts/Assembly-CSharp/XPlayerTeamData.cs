using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005C0")]
public class XPlayerTeamData
{
	[Token(Token = "0x4001BEB")]
	[FieldOffset(Offset = "0x8")]
	public int photonID;

	[Token(Token = "0x4001BEC")]
	[FieldOffset(Offset = "0xC")]
	public XTeamEnum team;

	[Token(Token = "0x6003106")]
	[Address(RVA = "0x1C82B44", Offset = "0x1C82B44", VA = "0x1C82B44")]
	public XPlayerTeamData(int id, XTeamEnum team)
	{
	}
}
