using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200062C")]
public class LastWeekRankerInfo
{
	[Token(Token = "0x4001DBF")]
	[FieldOffset(Offset = "0x8")]
	public int season;

	[Token(Token = "0x4001DC0")]
	[FieldOffset(Offset = "0xC")]
	public List<RankerMetaData> duelRankers;

	[Token(Token = "0x4001DC1")]
	[FieldOffset(Offset = "0x10")]
	public List<RankerMetaData> teamRankers;

	[Token(Token = "0x4001DC2")]
	[FieldOffset(Offset = "0x14")]
	public List<ClanRankMetaData> clanRankers;

	[Token(Token = "0x600350C")]
	[Address(RVA = "0xDD5568", Offset = "0xDD5568", VA = "0xDD5568")]
	public LastWeekRankerInfo()
	{
	}
}
