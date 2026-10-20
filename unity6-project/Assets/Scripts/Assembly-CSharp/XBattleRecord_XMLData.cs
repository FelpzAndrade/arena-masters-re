using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000646")]
public class XBattleRecord_XMLData
{
	[Token(Token = "0x4001E25")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4001E26")]
	[FieldOffset(Offset = "0xC")]
	public XGameModeType GameMode;

	[Token(Token = "0x4001E27")]
	[FieldOffset(Offset = "0x10")]
	public MatchType matchType;

	[Token(Token = "0x4001E28")]
	[FieldOffset(Offset = "0x14")]
	public string PlayTotalCount;

	[Token(Token = "0x4001E29")]
	[FieldOffset(Offset = "0x18")]
	public string Win;

	[Token(Token = "0x4001E2A")]
	[FieldOffset(Offset = "0x1C")]
	public string WinRate;

	[Token(Token = "0x4001E2B")]
	[FieldOffset(Offset = "0x20")]
	public string Mvp;

	[Token(Token = "0x4001E2C")]
	[FieldOffset(Offset = "0x24")]
	public string Kill;

	[Token(Token = "0x4001E2D")]
	[FieldOffset(Offset = "0x28")]
	public string Assist;

	[Token(Token = "0x4001E2E")]
	[FieldOffset(Offset = "0x2C")]
	public string Death;

	[Token(Token = "0x4001E2F")]
	[FieldOffset(Offset = "0x30")]
	public string HumanServive;

	[Token(Token = "0x4001E30")]
	[FieldOffset(Offset = "0x34")]
	public string ZombieInfect;

	[Token(Token = "0x4001E31")]
	[FieldOffset(Offset = "0x38")]
	public string TagZombieToHuman;

	[Token(Token = "0x4001E32")]
	[FieldOffset(Offset = "0x3C")]
	public string BestLadderRank;

	[Token(Token = "0x4001E33")]
	[FieldOffset(Offset = "0x40")]
	public string BestScore;

	[Token(Token = "0x4001E34")]
	[FieldOffset(Offset = "0x44")]
	public string PerfectWin;

	[Token(Token = "0x4001E35")]
	[FieldOffset(Offset = "0x48")]
	public string Rank_1;

	[Token(Token = "0x4001E36")]
	[FieldOffset(Offset = "0x4C")]
	public string Rank_2;

	[Token(Token = "0x4001E37")]
	[FieldOffset(Offset = "0x50")]
	public string Rank_3;

	[Token(Token = "0x4001E38")]
	[FieldOffset(Offset = "0x54")]
	public string Rank_4;

	[Token(Token = "0x4001E39")]
	[FieldOffset(Offset = "0x58")]
	public string Rank_5;

	[Token(Token = "0x4001E3A")]
	[FieldOffset(Offset = "0x5C")]
	public string Rank_6;

	[Token(Token = "0x60035E0")]
	[Address(RVA = "0x1EFF46C", Offset = "0x1EFF46C", VA = "0x1EFF46C")]
	public XBattleRecord_XMLData()
	{
	}

	[Token(Token = "0x60035E1")]
	[Address(RVA = "0x1EFF474", Offset = "0x1EFF474", VA = "0x1EFF474")]
	public void GetRecordViewList(out List<GameRecordType> gameRecordViewList, out List<GameRecordType> rankRecordViewList)
	{
		gameRecordViewList = default;
		rankRecordViewList = default;
	}
}
