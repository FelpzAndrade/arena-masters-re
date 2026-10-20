using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006DC")]
public class SpecialIronGolemModeElementLogic : BaseModeElementLogic
{
	[Token(Token = "0x40020AB")]
	[FieldOffset(Offset = "0xC")]
	private CSStageInfo stageInfo;

	[Token(Token = "0x40020AC")]
	[FieldOffset(Offset = "0x10")]
	private bool IsAllUsedCount;

	[Token(Token = "0x40020AD")]
	[FieldOffset(Offset = "0x14")]
	private int playedCount;

	[Token(Token = "0x40020AE")]
	[FieldOffset(Offset = "0x18")]
	private int playableMaxCount;

	[Token(Token = "0x40020AF")]
	[FieldOffset(Offset = "0x1C")]
	private bool enterable;

	[Token(Token = "0x40020B0")]
	[FieldOffset(Offset = "0x20")]
	private int premiumTicketBonus;

	[Token(Token = "0x40020B1")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<CSStageInfo> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x6003971")]
	[Address(RVA = "0x1D40B64", Offset = "0x1D40B64", VA = "0x1D40B64")]
	public SpecialIronGolemModeElementLogic(XGameModeMainCatecory mainCategory, XGameModeSubCatecory subCategory)
	{
	}

	[Token(Token = "0x6003972")]
	[Address(RVA = "0x1D410D4", Offset = "0x1D410D4", VA = "0x1D410D4", Slot = "18")]
	public override int GetUnlockLv()
	{
		return default(int);
	}

	[Token(Token = "0x6003973")]
	[Address(RVA = "0x1D411D8", Offset = "0x1D411D8", VA = "0x1D411D8")]
	private bool IsNomorePlayable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003974")]
	[Address(RVA = "0x1D411F8", Offset = "0x1D411F8", VA = "0x1D411F8", Slot = "19")]
	public override void OnClick()
	{
	}

	[Token(Token = "0x6003975")]
	[Address(RVA = "0x1D4143C", Offset = "0x1D4143C", VA = "0x1D4143C", Slot = "16")]
	public override void GetTopDeco(out string text, out bool isTween)
	{
		isTween = default;
		text = default;
	}

	[Token(Token = "0x6003976")]
	[Address(RVA = "0x1D41500", Offset = "0x1D41500", VA = "0x1D41500", Slot = "17")]
	public override bool GetMidTitle(out string midTitle, out bool isLock)
	{
		isLock = default;
		midTitle = default;
		return default(bool);
	}

	[Token(Token = "0x6003977")]
	[Address(RVA = "0x1D41CD4", Offset = "0x1D41CD4", VA = "0x1D41CD4", Slot = "20")]
	public override bool TryRewardItemIconInfo(out string iconPath, out Color color)
	{
		color = default;
		iconPath = default;
		return default(bool);
	}

	[Token(Token = "0x6003978")]
	[Address(RVA = "0x1D41DBC", Offset = "0x1D41DBC", VA = "0x1D41DBC")]
	private static bool _003CSpecialIronGolemModeElementLogic_003Em__195(CSStageInfo x)
	{
		return default(bool);
	}
}
