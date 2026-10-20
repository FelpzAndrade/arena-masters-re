using CS;
using Il2CppDummyDll;

[Token(Token = "0x200097D")]
public class UserRankEntry : IRankEntry
{
	[Token(Token = "0x4002EEE")]
	[FieldOffset(Offset = "0x8")]
	private RankType RankType__BackingField;

	[Token(Token = "0x4002EEF")]
	[FieldOffset(Offset = "0xC")]
	private int Season__BackingField;

	[Token(Token = "0x4002EF0")]
	[FieldOffset(Offset = "0x10")]
	private int Score__BackingField;

	[Token(Token = "0x4002EF1")]
	[FieldOffset(Offset = "0x14")]
	private string EntryKey__BackingField;

	[Token(Token = "0x17000AE5")]
	public RankType RankType
	{
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x17B1F38", Offset = "0x17B1F38", VA = "0x17B1F38", Slot = "4")]
		get
		{
			return default(RankType);
		}
		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x17B1F40", Offset = "0x17B1F40", VA = "0x17B1F40")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE6")]
	public int Season
	{
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x17B1F48", Offset = "0x17B1F48", VA = "0x17B1F48", Slot = "5")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x17B1F50", Offset = "0x17B1F50", VA = "0x17B1F50")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE7")]
	public int Score
	{
		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x17B1F58", Offset = "0x17B1F58", VA = "0x17B1F58", Slot = "6")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x17B1F60", Offset = "0x17B1F60", VA = "0x17B1F60", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE8")]
	public string EntryKey
	{
		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x17B1F68", Offset = "0x17B1F68", VA = "0x17B1F68", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x17B1F70", Offset = "0x17B1F70", VA = "0x17B1F70", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x6004C42")]
	[Address(RVA = "0x17B1F30", Offset = "0x17B1F30", VA = "0x17B1F30")]
	public UserRankEntry()
	{
	}

	[Token(Token = "0x6004C4B")]
	[Address(RVA = "0x17B1F78", Offset = "0x17B1F78", VA = "0x17B1F78", Slot = "11")]
	public virtual string CreateRankKey()
	{
		return null;
	}
}
