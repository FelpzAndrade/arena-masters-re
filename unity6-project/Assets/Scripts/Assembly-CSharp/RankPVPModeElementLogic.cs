using System;
using Il2CppDummyDll;

[Token(Token = "0x20006DA")]
public class RankPVPModeElementLogic : BaseModeElementLogic
{
	[Token(Token = "0x40020A7")]
	[FieldOffset(Offset = "0xC")]
	private DayOfWeek today;

	[Token(Token = "0x40020A8")]
	[FieldOffset(Offset = "0x10")]
	private string[] weekdayOpenTime;

	[Token(Token = "0x40020A9")]
	[FieldOffset(Offset = "0x14")]
	private string[] weekendOpenTime;

	[Token(Token = "0x40020AA")]
	[FieldOffset(Offset = "0x18")]
	private string weekendDateKeyType;

	[Token(Token = "0x600396A")]
	[Address(RVA = "0x20EACE4", Offset = "0x20EACE4", VA = "0x20EACE4")]
	public RankPVPModeElementLogic(XGameModeMainCatecory mainCategory, XGameModeSubCatecory subCategory)
	{
	}

	[Token(Token = "0x600396B")]
	[Address(RVA = "0x20EAE04", Offset = "0x20EAE04", VA = "0x20EAE04", Slot = "18")]
	public override int GetUnlockLv()
	{
		return default(int);
	}

	[Token(Token = "0x600396C")]
	[Address(RVA = "0x20EAF04", Offset = "0x20EAF04", VA = "0x20EAF04", Slot = "19")]
	public override void OnClick()
	{
	}

	[Token(Token = "0x600396D")]
	[Address(RVA = "0x20EAFD8", Offset = "0x20EAFD8", VA = "0x20EAFD8", Slot = "16")]
	public override void GetTopDeco(out string text, out bool isTween)
	{
		isTween = default;
		text = default;
	}
}
