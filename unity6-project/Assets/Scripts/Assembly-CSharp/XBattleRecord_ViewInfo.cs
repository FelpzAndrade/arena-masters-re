using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000645")]
public class XBattleRecord_ViewInfo
{
	[Token(Token = "0x4001E20")]
	[FieldOffset(Offset = "0x8")]
	public int Id;

	[Token(Token = "0x4001E21")]
	[FieldOffset(Offset = "0xC")]
	public MatchType MatchType;

	[Token(Token = "0x4001E22")]
	[FieldOffset(Offset = "0x10")]
	public XGameModeType GameMode;

	[Token(Token = "0x4001E23")]
	[FieldOffset(Offset = "0x14")]
	public List<GameRecordType> GameRecordViewList;

	[Token(Token = "0x4001E24")]
	[FieldOffset(Offset = "0x18")]
	public List<GameRecordType> RankRecordViewList;

	[Token(Token = "0x60035DF")]
	[Address(RVA = "0x1EFF2F0", Offset = "0x1EFF2F0", VA = "0x1EFF2F0")]
	public XBattleRecord_ViewInfo(int id, MatchType matchType, XGameModeType gameMode)
	{
	}
}
