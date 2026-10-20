using CS;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x200097E")]
public class ClanRankEntry : IRankEntry
{
	[Token(Token = "0x4002EF2")]
	[FieldOffset(Offset = "0x8")]
	private RankType RankType__BackingField;

	[Token(Token = "0x4002EF3")]
	[FieldOffset(Offset = "0xC")]
	private int Season__BackingField;

	[Token(Token = "0x4002EF4")]
	[FieldOffset(Offset = "0x10")]
	private int Score__BackingField;

	[Token(Token = "0x4002EF5")]
	[FieldOffset(Offset = "0x14")]
	private string EntryKey__BackingField;

	[Token(Token = "0x17000AE9")]
	[JsonIgnore]
	public RankType RankType
	{
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x20C597C", Offset = "0x20C597C", VA = "0x20C597C", Slot = "4")]
		get
		{
			return default(RankType);
		}
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x20C5984", Offset = "0x20C5984", VA = "0x20C5984")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEA")]
	public int Season
	{
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x20C598C", Offset = "0x20C598C", VA = "0x20C598C", Slot = "5")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C50")]
		[Address(RVA = "0x20C5994", Offset = "0x20C5994", VA = "0x20C5994")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEB")]
	public int Score
	{
		[Token(Token = "0x6004C51")]
		[Address(RVA = "0x20C599C", Offset = "0x20C599C", VA = "0x20C599C", Slot = "6")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x20C59A4", Offset = "0x20C59A4", VA = "0x20C59A4", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEC")]
	public string EntryKey
	{
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0x20C59AC", Offset = "0x20C59AC", VA = "0x20C59AC", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C54")]
		[Address(RVA = "0x20C59B4", Offset = "0x20C59B4", VA = "0x20C59B4", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x6004C4C")]
	[Address(RVA = "0x20C5974", Offset = "0x20C5974", VA = "0x20C5974")]
	public ClanRankEntry()
	{
	}

	[Token(Token = "0x6004C55")]
	[Address(RVA = "0x20C59BC", Offset = "0x20C59BC", VA = "0x20C59BC")]
	public static ClanRankEntry Create(string key, int season, int score)
	{
		return null;
	}

	[Token(Token = "0x6004C56")]
	[Address(RVA = "0x20C5A70", Offset = "0x20C5A70", VA = "0x20C5A70", Slot = "11")]
	public virtual string CreateRankKey()
	{
		return null;
	}

	[Token(Token = "0x6004C57")]
	[Address(RVA = "0x20C5B60", Offset = "0x20C5B60", VA = "0x20C5B60")]
	public static string GetMakeRankKey(int season)
	{
		return null;
	}
}
