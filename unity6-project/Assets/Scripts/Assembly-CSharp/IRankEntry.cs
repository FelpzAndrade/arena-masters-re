using CS;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x200097C")]
public interface IRankEntry
{
	[Token(Token = "0x17000AE1")]
	[JsonIgnore]
	RankType RankType
	{
		[Token(Token = "0x6004C3B")]
		get;
	}

	[Token(Token = "0x17000AE2")]
	[JsonIgnore]
	int Season
	{
		[Token(Token = "0x6004C3C")]
		get;
	}

	[Token(Token = "0x17000AE3")]
	int Score
	{
		[Token(Token = "0x6004C3D")]
		get;
		[Token(Token = "0x6004C3E")]
		set;
	}

	[Token(Token = "0x17000AE4")]
	string EntryKey
	{
		[Token(Token = "0x6004C3F")]
		get;
		[Token(Token = "0x6004C40")]
		set;
	}

	[Token(Token = "0x6004C41")]
	string CreateRankKey();
}
