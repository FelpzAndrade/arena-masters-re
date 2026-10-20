using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006DD")]
public class SpecialLavaModeElementLogic : BaseModeElementLogic
{
	[Token(Token = "0x40020B2")]
	[FieldOffset(Offset = "0xC")]
	private CSStageInfo stageInfo;

	[Token(Token = "0x40020B3")]
	[FieldOffset(Offset = "0x10")]
	private bool IsAllUsedCount;

	[Token(Token = "0x40020B4")]
	[FieldOffset(Offset = "0x14")]
	private int playedCount;

	[Token(Token = "0x40020B5")]
	[FieldOffset(Offset = "0x18")]
	private int playableMaxCount;

	[Token(Token = "0x40020B6")]
	[FieldOffset(Offset = "0x1C")]
	private bool enterable;

	[Token(Token = "0x40020B7")]
	[FieldOffset(Offset = "0x20")]
	private int premiumTicketBonus;

	[Token(Token = "0x40020B8")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<CSStageInfo> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x6003979")]
	[Address(RVA = "0x1D41DEC", Offset = "0x1D41DEC", VA = "0x1D41DEC")]
	public SpecialLavaModeElementLogic(XGameModeMainCatecory mainCategory, XGameModeSubCatecory subCategory)
	{
	}

	[Token(Token = "0x600397A")]
	[Address(RVA = "0x1D4235C", Offset = "0x1D4235C", VA = "0x1D4235C", Slot = "18")]
	public override int GetUnlockLv()
	{
		return default(int);
	}

	[Token(Token = "0x600397B")]
	[Address(RVA = "0x1D42460", Offset = "0x1D42460", VA = "0x1D42460")]
	private bool IsNomorePlayable()
	{
		return default(bool);
	}

	[Token(Token = "0x600397C")]
	[Address(RVA = "0x1D42480", Offset = "0x1D42480", VA = "0x1D42480", Slot = "19")]
	public override void OnClick()
	{
	}

	[Token(Token = "0x600397D")]
	[Address(RVA = "0x1D426C4", Offset = "0x1D426C4", VA = "0x1D426C4", Slot = "16")]
	public override void GetTopDeco(out string text, out bool isTween)
	{
		isTween = default;
		text = default;
	}

	[Token(Token = "0x600397E")]
	[Address(RVA = "0x1D42788", Offset = "0x1D42788", VA = "0x1D42788", Slot = "17")]
	public override bool GetMidTitle(out string midTitle, out bool isLock)
	{
		isLock = default;
		midTitle = default;
		return default(bool);
	}

	[Token(Token = "0x600397F")]
	[Address(RVA = "0x1D42F5C", Offset = "0x1D42F5C", VA = "0x1D42F5C", Slot = "20")]
	public override bool TryRewardItemIconInfo(out string iconPath, out Color color)
	{
		color = default;
		iconPath = default;
		return default(bool);
	}

	[Token(Token = "0x6003980")]
	[Address(RVA = "0x1D43044", Offset = "0x1D43044", VA = "0x1D43044")]
	private static bool _003CSpecialLavaModeElementLogic_003Em__196(CSStageInfo x)
	{
		return default(bool);
	}
}
