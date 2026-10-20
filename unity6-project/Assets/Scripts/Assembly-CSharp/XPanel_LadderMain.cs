using System;
using System.Collections.Generic;
using System.Text;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DF2")]
public class XPanel_LadderMain : XUIBasePanel
{
	[Token(Token = "0x2000DF3")]
	private sealed class _003CRefresh_003Ec__AnonStorey1D2
	{
		[Token(Token = "0x40048F2")]
		[FieldOffset(Offset = "0x8")]
		internal RankType rankType;

		[Token(Token = "0x40048F3")]
		[FieldOffset(Offset = "0xC")]
		internal XGameModeType modeType;

		[Token(Token = "0x40048F4")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_LadderMain _003C_003Ef__this;

		[Token(Token = "0x6006754")]
		[Address(RVA = "0xFFBF80", Offset = "0xFFBF80", VA = "0xFFBF80")]
		public _003CRefresh_003Ec__AnonStorey1D2()
		{
		}

		[Token(Token = "0x6006755")]
		[Address(RVA = "0xFFC800", Offset = "0xFFC800", VA = "0xFFC800")]
		internal void _003C_003Em__388()
		{
		}
	}

	[Token(Token = "0x40048E6")]
	[FieldOffset(Offset = "0x10")]
	public List<XUILadderModeMenuElement> pvpModes;

	[Token(Token = "0x40048E7")]
	[FieldOffset(Offset = "0x14")]
	public XTutorialObjContainer tutoContainer;

	[Token(Token = "0x40048E8")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_TrophyReward rewardInfo;

	[Token(Token = "0x40048E9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject rankingRemainTimeObject;

	[Token(Token = "0x40048EA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblRankingRemainTime;

	[Token(Token = "0x40048EB")]
	[FieldOffset(Offset = "0x24")]
	private CSGameOpenModeInfo m_gameOpenModeInfo;

	[Token(Token = "0x40048EC")]
	[FieldOffset(Offset = "0x28")]
	private bool m_isModeOpen;

	[Token(Token = "0x40048ED")]
	[FieldOffset(Offset = "0x29")]
	private bool m_isNearestModeOpen;

	[Token(Token = "0x40048EE")]
	[FieldOffset(Offset = "0x2C")]
	private readonly string Path_TrophyRewardDetailPopup;

	[Token(Token = "0x40048EF")]
	[FieldOffset(Offset = "0x30")]
	private XWidget_RewardDetailPopup _rewardBoxDetailPopup;

	[Token(Token = "0x40048F0")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XUILadderModeMenuElement> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x40048F1")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XUILadderModeMenuElement> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x17000D6F")]
	public XWidget_RewardDetailPopup rewardBoxDetailPopup
	{
		[Token(Token = "0x600673F")]
		[Address(RVA = "0xFFA7A8", Offset = "0xFFA7A8", VA = "0xFFA7A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600673E")]
	[Address(RVA = "0xFFA6E8", Offset = "0xFFA6E8", VA = "0xFFA6E8")]
	public XPanel_LadderMain()
	{
	}

	[Token(Token = "0x6006740")]
	[Address(RVA = "0xFFA8C4", Offset = "0xFFA8C4", VA = "0xFFA8C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6006741")]
	[Address(RVA = "0xFFAB04", Offset = "0xFFAB04", VA = "0xFFAB04")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x6006742")]
	[Address(RVA = "0xFFAB08", Offset = "0xFFAB08", VA = "0xFFAB08")]
	private void Update()
	{
	}

	[Token(Token = "0x6006743")]
	[Address(RVA = "0xFFAB0C", Offset = "0xFFAB0C", VA = "0xFFAB0C")]
	private void BuildRemainTime()
	{
	}

	[Token(Token = "0x6006744")]
	[Address(RVA = "0xFFAEF0", Offset = "0xFFAEF0", VA = "0xFFAEF0")]
	private void DescriptRemainTime(bool open, StringBuilder stringBuilder, DayOfWeek dayOfWeek)
	{
	}

	[Token(Token = "0x6006745")]
	[Address(RVA = "0xFFB2F4", Offset = "0xFFB2F4", VA = "0xFFB2F4")]
	private string GetRankTypeString()
	{
		return null;
	}

	[Token(Token = "0x6006746")]
	[Address(RVA = "0xFFB4E4", Offset = "0xFFB4E4", VA = "0xFFB4E4")]
	private void SetTextRankingRemainTime(StringBuilder stringBuilder)
	{
	}

	[Token(Token = "0x6006747")]
	[Address(RVA = "0xFFB60C", Offset = "0xFFB60C", VA = "0xFFB60C")]
	public void Show()
	{
	}

	[Token(Token = "0x6006748")]
	[Address(RVA = "0xFFB75C", Offset = "0xFFB75C", VA = "0xFFB75C")]
	private void ShowTrophyReward()
	{
	}

	[Token(Token = "0x6006749")]
	[Address(RVA = "0xFFBE60", Offset = "0xFFBE60", VA = "0xFFBE60")]
	public void OnClick_ShowRewardBoxDetailPopup()
	{
	}

	[Token(Token = "0x600674A")]
	[Address(RVA = "0xFFBE8C", Offset = "0xFFBE8C", VA = "0xFFBE8C")]
	public void RefreshTween()
	{
	}

	[Token(Token = "0x600674B")]
	[Address(RVA = "0xFFA8C8", Offset = "0xFFA8C8", VA = "0xFFA8C8")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600674C")]
	[Address(RVA = "0xFFBF88", Offset = "0xFFBF88", VA = "0xFFBF88")]
	public new void Hide()
	{
	}

	[Token(Token = "0x600674D")]
	[Address(RVA = "0xFFBFBC", Offset = "0xFFBFBC", VA = "0xFFBFBC")]
	private void ChangeSelectGameMode(RankType rankType, XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x600674E")]
	[Address(RVA = "0xFFC174", Offset = "0xFFC174", VA = "0xFFC174")]
	public int GetPlayAvableMinLevel()
	{
		return default(int);
	}

	[Token(Token = "0x600674F")]
	[Address(RVA = "0xFFB674", Offset = "0xFFB674", VA = "0xFFB674")]
	private void CleatTutorialObject()
	{
	}

	[Token(Token = "0x6006750")]
	[Address(RVA = "0xFFC32C", Offset = "0xFFC32C", VA = "0xFFC32C")]
	public void SetDuelTutoObj()
	{
	}

	[Token(Token = "0x6006751")]
	[Address(RVA = "0xFFC568", Offset = "0xFFC568", VA = "0xFFC568")]
	public void SetCaptureATutoObj()
	{
	}

	[Token(Token = "0x6006752")]
	[Address(RVA = "0xFFC7A4", Offset = "0xFFC7A4", VA = "0xFFC7A4")]
	private static bool _003CSetDuelTutoObj_003Em__389(XUILadderModeMenuElement x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006753")]
	[Address(RVA = "0xFFC7D0", Offset = "0xFFC7D0", VA = "0xFFC7D0")]
	private static bool _003CSetCaptureATutoObj_003Em__38A(XUILadderModeMenuElement x)
	{
		return default(bool);
	}
}
