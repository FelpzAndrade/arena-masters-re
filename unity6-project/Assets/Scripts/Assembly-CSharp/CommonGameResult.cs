using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CCB")]
public class CommonGameResult : XCommonBackUI
{
	[Token(Token = "0x2000CCC")]
	public enum EventRewardType
	{
		[Token(Token = "0x4004138")]
		Normal = 0,
		[Token(Token = "0x4004139")]
		ArenaCoin = 1,
		[Token(Token = "0x400413A")]
		Treasure = 2
	}

	[Token(Token = "0x2000CCD")]
	private sealed class _003CDirectionAddOpenBox_003Ec__AnonStorey190
	{
		[Token(Token = "0x400413B")]
		[FieldOffset(Offset = "0x8")]
		internal bool isShow;

		[Token(Token = "0x400413C")]
		[FieldOffset(Offset = "0xC")]
		internal CommonGameResult _003C_003Ef__this;

		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x20C8E50", Offset = "0x20C8E50", VA = "0x20C8E50")]
		public _003CDirectionAddOpenBox_003Ec__AnonStorey190()
		{
		}

		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x20CC9F8", Offset = "0x20CC9F8", VA = "0x20CC9F8")]
		internal void _003C_003Em__288()
		{
		}
	}

	[Token(Token = "0x2000CCE")]
	private sealed class _003CCreateTeamLvSeq_003Ec__AnonStorey191
	{
		[Token(Token = "0x400413D")]
		[FieldOffset(Offset = "0x8")]
		internal int earnXp;

		[Token(Token = "0x400413E")]
		[FieldOffset(Offset = "0xC")]
		internal CommonGameResult _003C_003Ef__this;

		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x20C9374", Offset = "0x20C9374", VA = "0x20C9374")]
		public _003CCreateTeamLvSeq_003Ec__AnonStorey191()
		{
		}

		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0x20CC974", Offset = "0x20CC974", VA = "0x20CC974")]
		internal void _003C_003Em__289()
		{
		}

		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0x20CC9AC", Offset = "0x20CC9AC", VA = "0x20CC9AC")]
		internal void _003C_003Em__28A()
		{
		}
	}

	[Token(Token = "0x2000CCF")]
	private sealed class _003CBuildTeamLevel_003Ec__AnonStorey192
	{
		[Token(Token = "0x400413F")]
		[FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManager_TeamLevel teamProto;

		[Token(Token = "0x4004140")]
		[FieldOffset(Offset = "0xC")]
		internal CommonGameResult _003C_003Ef__this;

		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0x20C97F4", Offset = "0x20C97F4", VA = "0x20C97F4")]
		public _003CBuildTeamLevel_003Ec__AnonStorey192()
		{
		}

		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0x20CC878", Offset = "0x20CC878", VA = "0x20CC878")]
		internal string _003C_003Em__28B(int val)
		{
			return null;
		}

		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x20CC8C4", Offset = "0x20CC8C4", VA = "0x20CC8C4")]
		internal void _003C_003Em__28C(int val)
		{
		}

		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0x20CC934", Offset = "0x20CC934", VA = "0x20CC934")]
		internal bool _003C_003Em__28D(int val)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000CD0")]
	private sealed class _003CAddDirectionTeamLvUpSeq_003Ec__AnonStorey193
	{
		[Token(Token = "0x4004141")]
		[FieldOffset(Offset = "0x8")]
		internal int curLevel;

		[Token(Token = "0x4004142")]
		[FieldOffset(Offset = "0xC")]
		internal int targetLevel;

		[Token(Token = "0x4004143")]
		[FieldOffset(Offset = "0x10")]
		internal int earnEnergy;

		[Token(Token = "0x4004144")]
		[FieldOffset(Offset = "0x14")]
		internal CommonGameResult _003C_003Ef__this;

		[Token(Token = "0x6005C70")]
		[Address(RVA = "0x20CA1DC", Offset = "0x20CA1DC", VA = "0x20CA1DC")]
		public _003CAddDirectionTeamLvUpSeq_003Ec__AnonStorey193()
		{
		}

		[Token(Token = "0x6005C71")]
		[Address(RVA = "0x20CC668", Offset = "0x20CC668", VA = "0x20CC668")]
		internal void _003C_003Em__290()
		{
		}

		[Token(Token = "0x6005C72")]
		[Address(RVA = "0x20CC774", Offset = "0x20CC774", VA = "0x20CC774")]
		internal void _003C_003Em__291()
		{
		}
	}

	[Token(Token = "0x2000CD1")]
	private sealed class _003CAddDirectionReward_003Ec__AnonStorey194
	{
		[Token(Token = "0x4004145")]
		[FieldOffset(Offset = "0x8")]
		internal CSCharacterInfo charInfo;

		[Token(Token = "0x4004146")]
		[FieldOffset(Offset = "0xC")]
		internal CommonGameResult _003C_003Ef__this;

		[Token(Token = "0x6005C73")]
		[Address(RVA = "0x20CA9E8", Offset = "0x20CA9E8", VA = "0x20CA9E8")]
		public _003CAddDirectionReward_003Ec__AnonStorey194()
		{
		}

		[Token(Token = "0x6005C74")]
		[Address(RVA = "0x20CC634", Offset = "0x20CC634", VA = "0x20CC634")]
		internal void _003C_003Em__293()
		{
		}
	}

	[Token(Token = "0x2000CD2")]
	private sealed class _003CBuildGachaBox_003Ec__AnonStorey195
	{
		[Token(Token = "0x4004147")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_RewardGachaWithBoxEffect widget;

		[Token(Token = "0x4004148")]
		[FieldOffset(Offset = "0xC")]
		internal CommonGameResult _003C_003Ef__this;

		[Token(Token = "0x6005C75")]
		[Address(RVA = "0x20CAE20", Offset = "0x20CAE20", VA = "0x20CAE20")]
		public _003CBuildGachaBox_003Ec__AnonStorey195()
		{
		}

		[Token(Token = "0x6005C76")]
		[Address(RVA = "0x20CC7D4", Offset = "0x20CC7D4", VA = "0x20CC7D4")]
		internal void _003C_003Em__296()
		{
		}
	}

	[Token(Token = "0x2000CD3")]
	private sealed class _003COpenRewardGachaBox_003Ec__AnonStorey196
	{
		[Token(Token = "0x4004149")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_RewardGachaWithBoxEffect widget;

		[Token(Token = "0x400414A")]
		[FieldOffset(Offset = "0xC")]
		internal CSContent reward;

		[Token(Token = "0x400414B")]
		[FieldOffset(Offset = "0x10")]
		internal string topLocaleKey;

		[Token(Token = "0x400414C")]
		[FieldOffset(Offset = "0x14")]
		internal bool isFirstClear;

		[Token(Token = "0x400414D")]
		[FieldOffset(Offset = "0x15")]
		internal bool isBooster;

		[Token(Token = "0x400414E")]
		[FieldOffset(Offset = "0x18")]
		internal int multiple;

		[Token(Token = "0x400414F")]
		[FieldOffset(Offset = "0x1C")]
		internal CommonGameResult _003C_003Ef__this;

		[Token(Token = "0x6005C77")]
		[Address(RVA = "0x20CB1D0", Offset = "0x20CB1D0", VA = "0x20CB1D0")]
		public _003COpenRewardGachaBox_003Ec__AnonStorey196()
		{
		}

		[Token(Token = "0x6005C78")]
		[Address(RVA = "0x20CCA44", Offset = "0x20CCA44", VA = "0x20CCA44")]
		internal void _003C_003Em__297()
		{
		}

		[Token(Token = "0x6005C79")]
		[Address(RVA = "0x20CCA74", Offset = "0x20CCA74", VA = "0x20CCA74")]
		internal void _003C_003Em__298()
		{
		}
	}

	[Token(Token = "0x4004110")]
	[FieldOffset(Offset = "0x18")]
	public GameObject root;

	[Token(Token = "0x4004111")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ViewCenterRoot;

	[Token(Token = "0x4004112")]
	[FieldOffset(Offset = "0x20")]
	public GameObject panelRoot;

	[Token(Token = "0x4004113")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblUserName;

	[Token(Token = "0x4004114")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goTeamlv;

	[Token(Token = "0x4004115")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_ProgressBarWithTable prbTeamLv;

	[Token(Token = "0x4004116")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblTeamLevelIncreased;

	[Token(Token = "0x4004117")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_NGUITween tweenUpTeamLevel;

	[Token(Token = "0x4004118")]
	[FieldOffset(Offset = "0x38")]
	public GameObject goRewardRoot;

	[Token(Token = "0x4004119")]
	[FieldOffset(Offset = "0x3C")]
	public XWiget_GridBuilder gridDropRewards;

	[Token(Token = "0x400411A")]
	[FieldOffset(Offset = "0x40")]
	public UIButton btnSkip;

	[Token(Token = "0x400411B")]
	[FieldOffset(Offset = "0x44")]
	public UIButton btnOpenBox;

	[Token(Token = "0x400411C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel lblRewardComment;

	[Token(Token = "0x400411D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject goRewardComment;

	[Token(Token = "0x400411E")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblToMail;

	[Token(Token = "0x400411F")]
	[FieldOffset(Offset = "0x54")]
	public UILabel lblOpenBox;

	[Token(Token = "0x4004120")]
	[FieldOffset(Offset = "0x58")]
	public UILabel lblDupSkinArenaCoin;

	[Token(Token = "0x4004121")]
	[FieldOffset(Offset = "0x5C")]
	protected UIDirector m_directions;

	[Token(Token = "0x4004122")]
	[FieldOffset(Offset = "0x60")]
	protected XWidget_TeamLevleUpPopup m_teamLvPopup;

	[Token(Token = "0x4004123")]
	[FieldOffset(Offset = "0x64")]
	protected bool isSkipGetCardDirectionPermit;

	[Token(Token = "0x4004124")]
	[FieldOffset(Offset = "0x68")]
	protected float m_labelIncreaseSpeed;

	[Token(Token = "0x4004125")]
	[FieldOffset(Offset = "0x6C")]
	protected XWidget_ContentIcon.Option m_option;

	[Token(Token = "0x4004126")]
	[FieldOffset(Offset = "0x70")]
	protected CSStageInfo m_nextStageInfo;

	[Token(Token = "0x4004127")]
	[FieldOffset(Offset = "0x74")]
	protected CSStageInfo m_curStageInfo;

	[Token(Token = "0x4004128")]
	[FieldOffset(Offset = "0x78")]
	protected string EventPopupSoundKey;

	[Token(Token = "0x4004129")]
	[FieldOffset(Offset = "0x7C")]
	protected string UIProgressBarSoundKey;

	[Token(Token = "0x400412A")]
	[FieldOffset(Offset = "0x80")]
	protected string UITeamLevelUpSoundKey;

	[Token(Token = "0x400412B")]
	[FieldOffset(Offset = "0x84")]
	protected string UIlvUpWidgetSoundKey;

	[Token(Token = "0x400412C")]
	[FieldOffset(Offset = "0x88")]
	protected bool m_isMissionResult;

	[Token(Token = "0x400412D")]
	[FieldOffset(Offset = "0x8C")]
	protected XPlayerManager m_finalPlayRecord;

	[Token(Token = "0x400412E")]
	[FieldOffset(Offset = "0x90")]
	protected bool m_isTouchExit;

	[Token(Token = "0x400412F")]
	[FieldOffset(Offset = "0x91")]
	protected bool m_isClickOpenBox;

	[Token(Token = "0x4004130")]
	[FieldOffset(Offset = "0x94")]
	protected XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x4004131")]
	[FieldOffset(Offset = "0x98")]
	protected bool m_isMail;

	[Token(Token = "0x4004132")]
	[FieldOffset(Offset = "0x9C")]
	private List<RewardGachaBoxInfo> m_rewardGachaBoxInfoList;

	[Token(Token = "0x4004133")]
	[FieldOffset(Offset = "0xA0")]
	private XWidget_RewardGachaWithBoxEffect[] RewardWidgets__BackingField;

	[Token(Token = "0x4004134")]
	[FieldOffset(Offset = "0x0")]
	private static Action<UILabel, int> _003C_003Ef__am_0024cache24;

	[Token(Token = "0x4004135")]
	[FieldOffset(Offset = "0x4")]
	private static Action<UIProgressBar, int> _003C_003Ef__am_0024cache25;

	[Token(Token = "0x4004136")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache26;

	[Token(Token = "0x17000CDE")]
	public XWidget_RewardGachaWithBoxEffect[] RewardWidgets
	{
		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x20C7E48", Offset = "0x20C7E48", VA = "0x20C7E48")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x20C7E50", Offset = "0x20C7E50", VA = "0x20C7E50")]
		protected set
		{
		}
	}

	[Token(Token = "0x6005C3F")]
	[Address(RVA = "0x20C7D04", Offset = "0x20C7D04", VA = "0x20C7D04")]
	public CommonGameResult()
	{
	}

	[Token(Token = "0x6005C42")]
	[Address(RVA = "0x20C7E58", Offset = "0x20C7E58", VA = "0x20C7E58")]
	public void Update()
	{
	}

	[Token(Token = "0x6005C43")]
	[Address(RVA = "0x20C7E84", Offset = "0x20C7E84", VA = "0x20C7E84")]
	public void PlayUIBattleVictorySound()
	{
	}

	[Token(Token = "0x6005C44")]
	[Address(RVA = "0x20C7FD8", Offset = "0x20C7FD8", VA = "0x20C7FD8")]
	public void PlayUIBattleEndSound()
	{
	}

	[Token(Token = "0x6005C45")]
	[Address(RVA = "0x20C812C", Offset = "0x20C812C", VA = "0x20C812C")]
	protected void OffBGM(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005C46")]
	[Address(RVA = "0x20C8200", Offset = "0x20C8200", VA = "0x20C8200")]
	protected void ResultPanelShow()
	{
	}

	[Token(Token = "0x6005C47")]
	[Address(RVA = "0x20C8258", Offset = "0x20C8258", VA = "0x20C8258")]
	public bool IsPVPGameModeType(XGameModeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C48")]
	[Address(RVA = "0x20C8264", Offset = "0x20C8264", VA = "0x20C8264")]
	protected void SetGameEvaluateCondition(XPlayerManager finalPlayRecord)
	{
	}

	[Token(Token = "0x6005C49")]
	[Address(RVA = "0x20C8768", Offset = "0x20C8768", VA = "0x20C8768")]
	protected void DirectionAddToMail(bool toMail)
	{
	}

	[Token(Token = "0x6005C4A")]
	[Address(RVA = "0x20C8864", Offset = "0x20C8864", VA = "0x20C8864")]
	protected bool DirectionDupSkinArenaCoin(EventRewardType type, int count)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C4B")]
	[Address(RVA = "0x20C8BCC", Offset = "0x20C8BCC", VA = "0x20C8BCC")]
	private void SetSkinTreasureLabel()
	{
	}

	[Token(Token = "0x6005C4C")]
	[Address(RVA = "0x20C89E8", Offset = "0x20C89E8", VA = "0x20C89E8")]
	private void SetLabelInsteadof(int count)
	{
	}

	[Token(Token = "0x6005C4D")]
	[Address(RVA = "0x20C8D20", Offset = "0x20C8D20", VA = "0x20C8D20")]
	protected void DirectionAddOpenBox(bool isShow)
	{
	}

	[Token(Token = "0x6005C4E")]
	[Address(RVA = "0x20C8E58", Offset = "0x20C8E58", VA = "0x20C8E58", Slot = "18")]
	protected virtual void DirectionStart()
	{
	}

	[Token(Token = "0x6005C4F")]
	[Address(RVA = "0x20C90C4", Offset = "0x20C90C4", VA = "0x20C90C4")]
	protected UIDirectionSequence CreateTeamLvSeq(int earnXp, int beforeXp)
	{
		return null;
	}

	[Token(Token = "0x6005C50")]
	[Address(RVA = "0x20C937C", Offset = "0x20C937C", VA = "0x20C937C")]
	protected void BuildTeamLevel(int beforeXp, int earnXp, UIDirectionPararell pararell)
	{
	}

	[Token(Token = "0x6005C51")]
	[Address(RVA = "0x20C9BD4", Offset = "0x20C9BD4", VA = "0x20C9BD4")]
	protected void AddDirectionTeamLvUpSeq(int beforeXp, int earnXp, int earnEnergy)
	{
	}

	[Token(Token = "0x6005C52")]
	[Address(RVA = "0x20CA1E4", Offset = "0x20CA1E4", VA = "0x20CA1E4", Slot = "19")]
	public virtual bool IsApplyedBooster(CSContentType contentType, bool isUseGoldBooster, bool isUseItemBooster, bool isUsePromstoneBooster)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C53")]
	[Address(RVA = "0x20CA214", Offset = "0x20CA214", VA = "0x20CA214")]
	protected void AddDirectionReward(List<RewardInfo> rewardList)
	{
	}

	[Token(Token = "0x6005C54")]
	[Address(RVA = "0x20CA9F0", Offset = "0x20CA9F0", VA = "0x20CA9F0")]
	protected bool IsClanMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005C55")]
	[Address(RVA = "0x20CAACC", Offset = "0x20CAACC", VA = "0x20CAACC")]
	protected bool IsShowClanPointDirection(List<CSContentReward> lotteryRewards)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C56")]
	[Address(RVA = "0x20CAB70", Offset = "0x20CAB70", VA = "0x20CAB70", Slot = "20")]
	protected virtual void BuildGachaBox(XWidget_RewardGachaWithBoxEffect widget, RewardInfo info, UIDirectionSequence seq)
	{
	}

	[Token(Token = "0x6005C57")]
	[Address(RVA = "0x20CAE28", Offset = "0x20CAE28", VA = "0x20CAE28")]
	protected void OpenRewardGachaBox()
	{
	}

	[Token(Token = "0x6005C58")]
	[Address(RVA = "0x20CB1D8", Offset = "0x20CB1D8", VA = "0x20CB1D8")]
	protected int GetRewardGachaBoxInfoListCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005C59")]
	[Address(RVA = "0x20CB260", Offset = "0x20CB260", VA = "0x20CB260")]
	protected void ShowCardDirection(int nCharID)
	{
	}

	[Token(Token = "0x6005C5A")]
	[Address(RVA = "0x20CB560", Offset = "0x20CB560", VA = "0x20CB560")]
	protected List<RewardInfo> GetInGameRewardInfoList(Netdata_CompleteGame result, CSWinlose winLose, int rank)
	{
		return null;
	}

	[Token(Token = "0x6005C5B")]
	[Address(RVA = "0x20C97FC", Offset = "0x20C97FC", VA = "0x20C97FC")]
	protected UIDirectionPararell GetProgressBarDirectionSequenceSet(int initValue, int valueIncreased, bool isPercentText, bool useDecimalPoint, XWidget_ProgressBarWithTable prb, UILabel lblIncreased, List<int> table, Func<int, string> levCalc, Action<int> onChangeFloor, Func<int, bool> labelException, Action<UILabel, int> labelExceptionSetter, Action<UIProgressBar, int> prbExceptionSetter, string lblIncresedWholeFormat = "{0}")
	{
		return null;
	}

	[Token(Token = "0x6005C5C")]
	[Address(RVA = "0x20CBF30", Offset = "0x20CBF30", VA = "0x20CBF30")]
	public void OnExitButtonClick()
	{
	}

	[Token(Token = "0x6005C5D")]
	[Address(RVA = "0x20CC020", Offset = "0x20CC020", VA = "0x20CC020")]
	public void ShowQuestCompleteNoti()
	{
	}

	[Token(Token = "0x6005C5E")]
	[Address(RVA = "0x20CC0F4", Offset = "0x20CC0F4", VA = "0x20CC0F4")]
	private void _003CDirectionAddToMail_003Em__286()
	{
	}

	[Token(Token = "0x6005C5F")]
	[Address(RVA = "0x20CC134", Offset = "0x20CC134", VA = "0x20CC134")]
	private void _003CDirectionDupSkinArenaCoin_003Em__287()
	{
	}

	[Token(Token = "0x6005C60")]
	[Address(RVA = "0x20CC174", Offset = "0x20CC174", VA = "0x20CC174")]
	private static void _003CBuildTeamLevel_003Em__28E(UILabel label, int val)
	{
	}

	[Token(Token = "0x6005C61")]
	[Address(RVA = "0x20CC2CC", Offset = "0x20CC2CC", VA = "0x20CC2CC")]
	private static void _003CBuildTeamLevel_003Em__28F(UIProgressBar prb, int val)
	{
	}

	[Token(Token = "0x6005C62")]
	[Address(RVA = "0x20CC47C", Offset = "0x20CC47C", VA = "0x20CC47C")]
	private void _003CAddDirectionReward_003Em__292()
	{
	}

	[Token(Token = "0x6005C63")]
	[Address(RVA = "0x20CC4BC", Offset = "0x20CC4BC", VA = "0x20CC4BC")]
	private void _003CAddDirectionReward_003Em__294()
	{
	}

	[Token(Token = "0x6005C64")]
	[Address(RVA = "0x20CC508", Offset = "0x20CC508", VA = "0x20CC508")]
	private void _003CAddDirectionReward_003Em__295()
	{
	}

	[Token(Token = "0x6005C65")]
	[Address(RVA = "0x20CC540", Offset = "0x20CC540", VA = "0x20CC540")]
	private void _003CShowCardDirection_003Em__299()
	{
	}

	[Token(Token = "0x6005C66")]
	[Address(RVA = "0x20CC54C", Offset = "0x20CC54C", VA = "0x20CC54C")]
	private static void _003CGetProgressBarDirectionSequenceSet_003Em__29A()
	{
	}
}
