using CS;
using Il2CppDummyDll;

[Token(Token = "0x20006E3")]
public class XUILadderModeMenuElement : XUIModeElementBase
{
	[Token(Token = "0x40020E3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblRankTypeText;

	[Token(Token = "0x40020E4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblRankTypeSubText;

	[Token(Token = "0x40020E5")]
	[FieldOffset(Offset = "0x34")]
	public RankType rankType;

	[Token(Token = "0x40020E6")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblDayOfWeek;

	[Token(Token = "0x40020E7")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_RankTierInfo tierInfo;

	[Token(Token = "0x40020E8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblPlayCount;

	[Token(Token = "0x40020E9")]
	[FieldOffset(Offset = "0x44")]
	public bool IsRandomElement;

	[Token(Token = "0x40020EA")]
	[FieldOffset(Offset = "0x45")]
	private bool isEnterableTime__BackingField;

	[Token(Token = "0x1700081B")]
	public bool isEnterableTime
	{
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x1096B5C", Offset = "0x1096B5C", VA = "0x1096B5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x1096B64", Offset = "0x1096B64", VA = "0x1096B64")]
		private set
		{
		}
	}

	[Token(Token = "0x60039A3")]
	[Address(RVA = "0x1096AAC", Offset = "0x1096AAC", VA = "0x1096AAC")]
	public XUILadderModeMenuElement()
	{
	}

	[Token(Token = "0x60039A6")]
	[Address(RVA = "0x1096B6C", Offset = "0x1096B6C", VA = "0x1096B6C")]
	public void Init()
	{
	}

	[Token(Token = "0x60039A7")]
	[Address(RVA = "0x109784C", Offset = "0x109784C", VA = "0x109784C")]
	private void Update()
	{
	}

	[Token(Token = "0x60039A8")]
	[Address(RVA = "0x1097638", Offset = "0x1097638", VA = "0x1097638")]
	private void SetModeOpen()
	{
	}

	[Token(Token = "0x60039A9")]
	[Address(RVA = "0x1097524", Offset = "0x1097524", VA = "0x1097524")]
	private void SetDayOfWeek()
	{
	}

	[Token(Token = "0x60039AA")]
	[Address(RVA = "0x1096F48", Offset = "0x1096F48", VA = "0x1096F48")]
	protected void BuildITierInfo()
	{
	}

	[Token(Token = "0x60039AB")]
	[Address(RVA = "0x1097260", Offset = "0x1097260", VA = "0x1097260")]
	private void BuildPlayCount()
	{
	}

	[Token(Token = "0x60039AC")]
	[Address(RVA = "0x1096E24", Offset = "0x1096E24", VA = "0x1096E24")]
	protected void BuildCommon()
	{
	}
}
