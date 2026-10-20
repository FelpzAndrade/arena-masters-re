using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CC9")]
public class RewardInfo
{
	[Token(Token = "0x4004107")]
	[FieldOffset(Offset = "0x8")]
	public CSContent box;

	[Token(Token = "0x4004108")]
	[FieldOffset(Offset = "0xC")]
	public CSContentReward Value;

	[Token(Token = "0x4004109")]
	[FieldOffset(Offset = "0x10")]
	private bool IsFirstClear__BackingField;

	[Token(Token = "0x400410A")]
	[FieldOffset(Offset = "0x11")]
	private bool IsEventReward__BackingField;

	[Token(Token = "0x400410B")]
	[FieldOffset(Offset = "0x12")]
	private bool IsBooster__BackingField;

	[Token(Token = "0x400410C")]
	[FieldOffset(Offset = "0x14")]
	private int Multiple__BackingField;

	[Token(Token = "0x400410D")]
	[FieldOffset(Offset = "0x18")]
	private string TopShowLocaleKey__BackingField;

	[Token(Token = "0x17000CD9")]
	public bool IsFirstClear
	{
		[Token(Token = "0x6005C31")]
		[Address(RVA = "0x20EBF14", Offset = "0x20EBF14", VA = "0x20EBF14")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C32")]
		[Address(RVA = "0x20EBF1C", Offset = "0x20EBF1C", VA = "0x20EBF1C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CDA")]
	public bool IsEventReward
	{
		[Token(Token = "0x6005C33")]
		[Address(RVA = "0x20EBF24", Offset = "0x20EBF24", VA = "0x20EBF24")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C34")]
		[Address(RVA = "0x20EBF2C", Offset = "0x20EBF2C", VA = "0x20EBF2C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CDB")]
	public bool IsBooster
	{
		[Token(Token = "0x6005C35")]
		[Address(RVA = "0x20EBF34", Offset = "0x20EBF34", VA = "0x20EBF34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C36")]
		[Address(RVA = "0x20EBF0C", Offset = "0x20EBF0C", VA = "0x20EBF0C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CDC")]
	public int Multiple
	{
		[Token(Token = "0x6005C37")]
		[Address(RVA = "0x20EBF3C", Offset = "0x20EBF3C", VA = "0x20EBF3C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C38")]
		[Address(RVA = "0x20EBF04", Offset = "0x20EBF04", VA = "0x20EBF04")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CDD")]
	public string TopShowLocaleKey
	{
		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x20EBF44", Offset = "0x20EBF44", VA = "0x20EBF44")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x20EBF4C", Offset = "0x20EBF4C", VA = "0x20EBF4C")]
		private set
		{
		}
	}

	[Token(Token = "0x6005C2F")]
	[Address(RVA = "0x20EBEA4", Offset = "0x20EBEA4", VA = "0x20EBEA4")]
	public RewardInfo(CSContent box, CSContentReward value)
	{
	}

	[Token(Token = "0x6005C30")]
	[Address(RVA = "0x20EBECC", Offset = "0x20EBECC", VA = "0x20EBECC")]
	public RewardInfo(CSContent box, CSContentReward value, int multiple, bool booster)
	{
	}

	[Token(Token = "0x6005C3B")]
	[Address(RVA = "0x20EBF54", Offset = "0x20EBF54", VA = "0x20EBF54")]
	public void SetFirstClear(string localeKey)
	{
	}

	[Token(Token = "0x6005C3C")]
	[Address(RVA = "0x20EBF64", Offset = "0x20EBF64", VA = "0x20EBF64")]
	public void SetTopKey(string localeKey)
	{
	}

	[Token(Token = "0x6005C3D")]
	[Address(RVA = "0x20EBF6C", Offset = "0x20EBF6C", VA = "0x20EBF6C")]
	public void SetEventReward(string localeKey)
	{
	}
}
