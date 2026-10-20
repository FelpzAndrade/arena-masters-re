using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D5C")]
public class XPanel_GameResult : CommonGameResult
{
	[Token(Token = "0x2000D5D")]
	private sealed class _003CDirectionAdd_MissionStar_003Ec__AnonStorey19F
	{
		[Token(Token = "0x40044E4")]
		[FieldOffset(Offset = "0x8")]
		internal UITweener starTween;

		[Token(Token = "0x6006235")]
		[Address(RVA = "0xFEA2B8", Offset = "0xFEA2B8", VA = "0xFEA2B8")]
		public _003CDirectionAdd_MissionStar_003Ec__AnonStorey19F()
		{
		}

		[Token(Token = "0x6006236")]
		[Address(RVA = "0xFEB584", Offset = "0xFEB584", VA = "0xFEB584")]
		internal void _003C_003Em__2DB()
		{
		}
	}

	[Token(Token = "0x2000D5E")]
	private sealed class _003CCreateSpecialProgress_003Ec__AnonStorey1A0
	{
		[Token(Token = "0x40044E5")]
		[FieldOffset(Offset = "0x8")]
		internal int totalCount;

		[Token(Token = "0x40044E6")]
		[FieldOffset(Offset = "0xC")]
		internal int premiumTicketBonus;

		[Token(Token = "0x40044E7")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_GameResult _003C_003Ef__this;

		[Token(Token = "0x6006237")]
		[Address(RVA = "0xFEA3B8", Offset = "0xFEA3B8", VA = "0xFEA3B8")]
		public _003CCreateSpecialProgress_003Ec__AnonStorey1A0()
		{
		}

		[Token(Token = "0x6006238")]
		[Address(RVA = "0xFEB53C", Offset = "0xFEB53C", VA = "0xFEB53C")]
		internal void _003C_003Em__2DC()
		{
		}

		[Token(Token = "0x6006239")]
		[Address(RVA = "0xFEB574", Offset = "0xFEB574", VA = "0xFEB574")]
		internal int _003C_003Em__2DD(int curVal)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000D5F")]
	private sealed class _003CCreateSoloCurrentProgress_003Ec__AnonStorey1A1
	{
		[Token(Token = "0x40044E8")]
		[FieldOffset(Offset = "0x8")]
		internal int totalFloor;

		[Token(Token = "0x40044E9")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_GameResult _003C_003Ef__this;

		[Token(Token = "0x600623A")]
		[Address(RVA = "0xFEA3C0", Offset = "0xFEA3C0", VA = "0xFEA3C0")]
		public _003CCreateSoloCurrentProgress_003Ec__AnonStorey1A1()
		{
		}

		[Token(Token = "0x600623B")]
		[Address(RVA = "0xFEB4FC", Offset = "0xFEB4FC", VA = "0xFEB4FC")]
		internal void _003C_003Em__2E0()
		{
		}

		[Token(Token = "0x600623C")]
		[Address(RVA = "0xFEB534", Offset = "0xFEB534", VA = "0xFEB534")]
		internal int _003C_003Em__2E1(int curVal)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000D60")]
	private sealed class _003CCreateBonusMissionRemainSeq_003Ec__AnonStorey1A2
	{
		[Token(Token = "0x40044EA")]
		[FieldOffset(Offset = "0x8")]
		internal int totalCount;

		[Token(Token = "0x40044EB")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_GameResult _003C_003Ef__this;

		[Token(Token = "0x600623D")]
		[Address(RVA = "0xFEA3C8", Offset = "0xFEA3C8", VA = "0xFEA3C8")]
		public _003CCreateBonusMissionRemainSeq_003Ec__AnonStorey1A2()
		{
		}

		[Token(Token = "0x600623E")]
		[Address(RVA = "0xFEB4BC", Offset = "0xFEB4BC", VA = "0xFEB4BC")]
		internal void _003C_003Em__2E4()
		{
		}

		[Token(Token = "0x600623F")]
		[Address(RVA = "0xFEB4F4", Offset = "0xFEB4F4", VA = "0xFEB4F4")]
		internal int _003C_003Em__2E5(int curVal)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40044C9")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel lblSpecialRewardComment;

	[Token(Token = "0x40044CA")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject goIngameTitleRoot;

	[Token(Token = "0x40044CB")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject goMissionTitleRoot;

	[Token(Token = "0x40044CC")]
	[FieldOffset(Offset = "0xB0")]
	public UITweener[] starTweens;

	[Token(Token = "0x40044CD")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject goInfo;

	[Token(Token = "0x40044CE")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject goInfoStar;

	[Token(Token = "0x40044CF")]
	[FieldOffset(Offset = "0xBC")]
	public XWidget_ProgressBar prbInfo;

	[Token(Token = "0x40044D0")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel lblInfoText;

	[Token(Token = "0x40044D1")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel lblProgressBarText;

	[Token(Token = "0x40044D2")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject goButtonRoot;

	[Token(Token = "0x40044D3")]
	[FieldOffset(Offset = "0xCC")]
	public XWidget_Button btnReplay;

	[Token(Token = "0x40044D4")]
	[FieldOffset(Offset = "0xD0")]
	public XWidget_Button btnNextStage;

	[Token(Token = "0x40044D5")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject goGoHomeButtonRoot;

	[Token(Token = "0x40044D6")]
	[FieldOffset(Offset = "0xD8")]
	public UIBasicSprite sprBG;

	[Token(Token = "0x40044D7")]
	[FieldOffset(Offset = "0xDC")]
	public Color scenarioBGColor;

	[Token(Token = "0x40044D8")]
	[FieldOffset(Offset = "0xEC")]
	public Color pvpBGColor;

	[Token(Token = "0x40044D9")]
	[FieldOffset(Offset = "0xFC")]
	private bool m_isStarting;

	[Token(Token = "0x40044DA")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache11;

	[Token(Token = "0x40044DB")]
	[FieldOffset(Offset = "0x4")]
	private static Func<int, int> _003C_003Ef__am_0024cache12;

	[Token(Token = "0x40044DC")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache13;

	[Token(Token = "0x40044DD")]
	[FieldOffset(Offset = "0xC")]
	private static Func<int, int> _003C_003Ef__am_0024cache14;

	[Token(Token = "0x40044DE")]
	[FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache15;

	[Token(Token = "0x40044DF")]
	[FieldOffset(Offset = "0x14")]
	private static Func<int, int> _003C_003Ef__am_0024cache16;

	[Token(Token = "0x40044E0")]
	[FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cache17;

	[Token(Token = "0x40044E1")]
	[FieldOffset(Offset = "0x1C")]
	private static Func<int, int> _003C_003Ef__am_0024cache18;

	[Token(Token = "0x40044E2")]
	[FieldOffset(Offset = "0x20")]
	private static Func<int, int> _003C_003Ef__am_0024cache19;

	[Token(Token = "0x40044E3")]
	[FieldOffset(Offset = "0x24")]
	private static Action _003C_003Ef__am_0024cache1A;

	[Token(Token = "0x6006207")]
	[Address(RVA = "0xFE57DC", Offset = "0xFE57DC", VA = "0xFE57DC")]
	public XPanel_GameResult()
	{
	}

	[Token(Token = "0x6006208")]
	[Address(RVA = "0xFE57E4", Offset = "0xFE57E4", VA = "0xFE57E4", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006209")]
	[Address(RVA = "0xFE5A24", Offset = "0xFE5A24", VA = "0xFE5A24")]
	public void Show(Netdata_CompleteSpecial result, int earnEnergy = 0)
	{
	}

	[Token(Token = "0x600620A")]
	[Address(RVA = "0xFE78BC", Offset = "0xFE78BC", VA = "0xFE78BC")]
	public void Show(Netdata_CompleteGame result, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x600620B")]
	[Address(RVA = "0xFE88FC", Offset = "0xFE88FC", VA = "0xFE88FC")]
	public void Show(Netdata_CompleteMission gameReward, int clearBeforeTotalStar, int score, int earnEnergy)
	{
	}

	[Token(Token = "0x600620C")]
	[Address(RVA = "0xFE63F0", Offset = "0xFE63F0", VA = "0xFE63F0")]
	private void BuildBottom(CSStageLogic svcStage)
	{
	}

	[Token(Token = "0x600620D")]
	[Address(RVA = "0xFE61B4", Offset = "0xFE61B4", VA = "0xFE61B4")]
	private void DirectionAdd_InGameTitle(XGameModeType gameMode)
	{
	}

	[Token(Token = "0x600620E")]
	[Address(RVA = "0xFE919C", Offset = "0xFE919C", VA = "0xFE919C")]
	private void DirectionAdd_MissionStar(int score)
	{
	}

	[Token(Token = "0x600620F")]
	[Address(RVA = "0xFEA2C0", Offset = "0xFEA2C0", VA = "0xFEA2C0", Slot = "18")]
	protected override void DirectionStart()
	{
	}

	[Token(Token = "0x6006210")]
	[Address(RVA = "0xFE6944", Offset = "0xFE6944", VA = "0xFE6944")]
	private UIDirectionSequence CreateSpecialProgress(CSStageLogic svcStage)
	{
		return null;
	}

	[Token(Token = "0x6006211")]
	[Address(RVA = "0xFE8174", Offset = "0xFE8174", VA = "0xFE8174")]
	private UIDirectionSequence CreateSoloCurrentProgress(CSStageLogic svcStage, CSWinlose winLose)
	{
		return null;
	}

	[Token(Token = "0x6006212")]
	[Address(RVA = "0xFE94B4", Offset = "0xFE94B4", VA = "0xFE94B4")]
	private UIDirectionSequence CreateBonusMissionRemainSeq(int clearBeforeTotalStar, CSStageLogic svcStage)
	{
		return null;
	}

	[Token(Token = "0x6006213")]
	[Address(RVA = "0xFE72D0", Offset = "0xFE72D0", VA = "0xFE72D0")]
	private List<RewardInfo> GetRewardInfoList(CSStageInfo stageInfo, List<CSContentReward> dropGachaList, CSContentReward gold, CSContentReward firstClear, bool isUseGoldBooster, bool isUseItemBooster, bool isUsePromstoneBooster, bool showFirstReward, int multiple = 0)
	{
		return null;
	}

	[Token(Token = "0x6006214")]
	[Address(RVA = "0xFEA3D0", Offset = "0xFEA3D0", VA = "0xFEA3D0")]
	private void BuildButtonRoot()
	{
	}

	[Token(Token = "0x6006215")]
	[Address(RVA = "0xFE5938", Offset = "0xFE5938", VA = "0xFE5938")]
	public void OnClickOpenBox()
	{
	}

	[Token(Token = "0x6006216")]
	[Address(RVA = "0xFE589C", Offset = "0xFE589C", VA = "0xFE589C")]
	public void OnClickSkip()
	{
	}

	[Token(Token = "0x6006217")]
	[Address(RVA = "0xFEA4C0", Offset = "0xFEA4C0", VA = "0xFEA4C0")]
	public void OnAnotherGameStartFail()
	{
	}

	[Token(Token = "0x6006218")]
	[Address(RVA = "0xFEA59C", Offset = "0xFEA59C", VA = "0xFEA59C")]
	public void OnClickNextStage()
	{
	}

	[Token(Token = "0x6006219")]
	[Address(RVA = "0xFEA6D4", Offset = "0xFEA6D4", VA = "0xFEA6D4")]
	private void StartAnotherGame()
	{
	}

	[Token(Token = "0x600621A")]
	[Address(RVA = "0xFEA810", Offset = "0xFEA810", VA = "0xFEA810")]
	public void OnClickReplay()
	{
	}

	[Token(Token = "0x600621B")]
	[Address(RVA = "0xFEA938", Offset = "0xFEA938", VA = "0xFEA938")]
	public void SkipAllDirection()
	{
	}

	[Token(Token = "0x600621C")]
	[Address(RVA = "0xFEA9A0", Offset = "0xFEA9A0", VA = "0xFEA9A0")]
	private void _003CShow_003Em__2CD()
	{
	}

	[Token(Token = "0x600621D")]
	[Address(RVA = "0xFEA9E0", Offset = "0xFEA9E0", VA = "0xFEA9E0")]
	private void _003CShow_003Em__2CE()
	{
	}

	[Token(Token = "0x600621E")]
	[Address(RVA = "0xFEAA08", Offset = "0xFEAA08", VA = "0xFEAA08")]
	private void _003CShow_003Em__2CF()
	{
	}

	[Token(Token = "0x600621F")]
	[Address(RVA = "0xFEAAC8", Offset = "0xFEAAC8", VA = "0xFEAAC8")]
	private void _003CShow_003Em__2D0()
	{
	}

	[Token(Token = "0x6006220")]
	[Address(RVA = "0xFEAB08", Offset = "0xFEAB08", VA = "0xFEAB08")]
	private void _003CShow_003Em__2D1()
	{
	}

	[Token(Token = "0x6006221")]
	[Address(RVA = "0xFEAB30", Offset = "0xFEAB30", VA = "0xFEAB30")]
	private void _003CShow_003Em__2D2()
	{
	}

	[Token(Token = "0x6006222")]
	[Address(RVA = "0xFEABF0", Offset = "0xFEABF0", VA = "0xFEABF0")]
	private void _003CShow_003Em__2D3()
	{
	}

	[Token(Token = "0x6006223")]
	[Address(RVA = "0xFEAC30", Offset = "0xFEAC30", VA = "0xFEAC30")]
	private void _003CShow_003Em__2D4()
	{
	}

	[Token(Token = "0x6006224")]
	[Address(RVA = "0xFEAC3C", Offset = "0xFEAC3C", VA = "0xFEAC3C")]
	private void _003CShow_003Em__2D5()
	{
	}

	[Token(Token = "0x6006225")]
	[Address(RVA = "0xFEACFC", Offset = "0xFEACFC", VA = "0xFEACFC")]
	private void _003CDirectionAdd_InGameTitle_003Em__2D6()
	{
	}

	[Token(Token = "0x6006226")]
	[Address(RVA = "0xFEAD3C", Offset = "0xFEAD3C", VA = "0xFEAD3C")]
	private static void _003CDirectionAdd_InGameTitle_003Em__2D7()
	{
	}

	[Token(Token = "0x6006227")]
	[Address(RVA = "0xFEAE14", Offset = "0xFEAE14", VA = "0xFEAE14")]
	private void _003CDirectionAdd_InGameTitle_003Em__2D8()
	{
	}

	[Token(Token = "0x6006228")]
	[Address(RVA = "0xFEAE1C", Offset = "0xFEAE1C", VA = "0xFEAE1C")]
	private void _003CDirectionAdd_MissionStar_003Em__2D9()
	{
	}

	[Token(Token = "0x6006229")]
	[Address(RVA = "0xFEAE24", Offset = "0xFEAE24", VA = "0xFEAE24")]
	private void _003CDirectionAdd_MissionStar_003Em__2DA()
	{
	}

	[Token(Token = "0x600622A")]
	[Address(RVA = "0xFEAE64", Offset = "0xFEAE64", VA = "0xFEAE64")]
	private static int _003CCreateSpecialProgress_003Em__2DE(int curVal)
	{
		return default(int);
	}

	[Token(Token = "0x600622B")]
	[Address(RVA = "0xFEAE6C", Offset = "0xFEAE6C", VA = "0xFEAE6C")]
	private static void _003CCreateSpecialProgress_003Em__2DF()
	{
	}

	[Token(Token = "0x600622C")]
	[Address(RVA = "0xFEAF54", Offset = "0xFEAF54", VA = "0xFEAF54")]
	private static int _003CCreateSoloCurrentProgress_003Em__2E2(int curVal)
	{
		return default(int);
	}

	[Token(Token = "0x600622D")]
	[Address(RVA = "0xFEAF5C", Offset = "0xFEAF5C", VA = "0xFEAF5C")]
	private static void _003CCreateSoloCurrentProgress_003Em__2E3()
	{
	}

	[Token(Token = "0x600622E")]
	[Address(RVA = "0xFEB044", Offset = "0xFEB044", VA = "0xFEB044")]
	private static int _003CCreateBonusMissionRemainSeq_003Em__2E6(int curVal)
	{
		return default(int);
	}

	[Token(Token = "0x600622F")]
	[Address(RVA = "0xFEB04C", Offset = "0xFEB04C", VA = "0xFEB04C")]
	private static void _003CCreateBonusMissionRemainSeq_003Em__2E7()
	{
	}

	[Token(Token = "0x6006230")]
	[Address(RVA = "0xFEB134", Offset = "0xFEB134", VA = "0xFEB134")]
	private void _003CCreateBonusMissionRemainSeq_003Em__2E8()
	{
	}

	[Token(Token = "0x6006231")]
	[Address(RVA = "0xFEB164", Offset = "0xFEB164", VA = "0xFEB164")]
	private static int _003CCreateBonusMissionRemainSeq_003Em__2E9(int curVal)
	{
		return default(int);
	}

	[Token(Token = "0x6006232")]
	[Address(RVA = "0xFEB16C", Offset = "0xFEB16C", VA = "0xFEB16C")]
	private static int _003CCreateBonusMissionRemainSeq_003Em__2EA(int curVal)
	{
		return default(int);
	}

	[Token(Token = "0x6006233")]
	[Address(RVA = "0xFEB174", Offset = "0xFEB174", VA = "0xFEB174")]
	private static void _003CCreateBonusMissionRemainSeq_003Em__2EB()
	{
	}

	[Token(Token = "0x6006234")]
	[Address(RVA = "0xFEB25C", Offset = "0xFEB25C", VA = "0xFEB25C")]
	private void _003CBuildButtonRoot_003Em__2EC()
	{
	}
}
