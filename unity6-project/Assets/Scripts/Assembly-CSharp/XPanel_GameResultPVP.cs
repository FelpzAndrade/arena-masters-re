using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D63")]
public class XPanel_GameResultPVP : CommonGameResult
{
	[Token(Token = "0x2000D64")]
	private sealed class _003CGetCharacterCombatQuestListSetting_003Ec__AnonStorey1A3
	{
		[Token(Token = "0x4004518")]
		[FieldOffset(Offset = "0x8")]
		internal string condition;

		[Token(Token = "0x6006274")]
		[Address(RVA = "0xFEC954", Offset = "0xFEC954", VA = "0xFEC954")]
		public _003CGetCharacterCombatQuestListSetting_003Ec__AnonStorey1A3()
		{
		}

		[Token(Token = "0x6006275")]
		[Address(RVA = "0xFF14C8", Offset = "0xFF14C8", VA = "0xFF14C8")]
		internal bool _003C_003Em__2ED(QuestInfo w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D65")]
	private sealed class _003CGetCurrentCombatQuestInfo_003Ec__AnonStorey1A4
	{
		[Token(Token = "0x4004519")]
		[FieldOffset(Offset = "0x8")]
		internal string condition;

		[Token(Token = "0x6006276")]
		[Address(RVA = "0xFECCE0", Offset = "0xFECCE0", VA = "0xFECCE0")]
		public _003CGetCurrentCombatQuestInfo_003Ec__AnonStorey1A4()
		{
		}

		[Token(Token = "0x6006277")]
		[Address(RVA = "0xFF1594", Offset = "0xFF1594", VA = "0xFF1594")]
		internal bool _003C_003Em__2EF(QuestInfo w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D66")]
	private sealed class _003CShow_003Ec__AnonStorey1A5
	{
		[Token(Token = "0x400451A")]
		[FieldOffset(Offset = "0x8")]
		internal Netdata_CompleteGame result;

		[Token(Token = "0x400451B")]
		[FieldOffset(Offset = "0xC")]
		internal List<RewardInfo> totalRewardList;

		[Token(Token = "0x400451C")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_GameResultPVP _003C_003Ef__this;

		[Token(Token = "0x6006278")]
		[Address(RVA = "0xFEDAD0", Offset = "0xFEDAD0", VA = "0xFEDAD0")]
		public _003CShow_003Ec__AnonStorey1A5()
		{
		}

		[Token(Token = "0x6006279")]
		[Address(RVA = "0xFF1660", Offset = "0xFF1660", VA = "0xFF1660")]
		internal void _003C_003Em__2F1()
		{
		}

		[Token(Token = "0x600627A")]
		[Address(RVA = "0xFF16A8", Offset = "0xFF16A8", VA = "0xFF16A8")]
		internal void _003C_003Em__2F2()
		{
		}

		[Token(Token = "0x600627B")]
		[Address(RVA = "0xFF16F0", Offset = "0xFF16F0", VA = "0xFF16F0")]
		internal void _003C_003Em__2F3()
		{
		}

		[Token(Token = "0x600627C")]
		[Address(RVA = "0xFF18A4", Offset = "0xFF18A4", VA = "0xFF18A4")]
		internal void _003C_003Em__2F4()
		{
		}

		[Token(Token = "0x600627D")]
		[Address(RVA = "0xFF19CC", Offset = "0xFF19CC", VA = "0xFF19CC")]
		internal void _003C_003Em__2F5()
		{
		}
	}

	[Token(Token = "0x2000D67")]
	private sealed class _003CAddDirectionCharacterCombatQuest_003Ec__AnonStorey1A6
	{
		[Token(Token = "0x400451D")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_ResultCharLevel curLvUpWidget;

		[Token(Token = "0x400451E")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_GameResultPVP _003C_003Ef__this;

		[Token(Token = "0x600627E")]
		[Address(RVA = "0xFEF8B8", Offset = "0xFEF8B8", VA = "0xFEF8B8")]
		public _003CAddDirectionCharacterCombatQuest_003Ec__AnonStorey1A6()
		{
		}

		[Token(Token = "0x600627F")]
		[Address(RVA = "0xFF11C8", Offset = "0xFF11C8", VA = "0xFF11C8")]
		internal void _003C_003Em__2FE()
		{
		}

		[Token(Token = "0x6006280")]
		[Address(RVA = "0xFF1208", Offset = "0xFF1208", VA = "0xFF1208")]
		internal void _003C_003Em__2FF()
		{
		}
	}

	[Token(Token = "0x2000D68")]
	private sealed class _003CBuildCharLevel_003Ec__AnonStorey1A7
	{
		[Token(Token = "0x400451F")]
		[FieldOffset(Offset = "0x8")]
		internal int beforeXp;

		[Token(Token = "0x4004520")]
		[FieldOffset(Offset = "0xC")]
		internal int earnXp;

		[Token(Token = "0x4004521")]
		[FieldOffset(Offset = "0x10")]
		internal CSCharacterInfo charInfo;

		[Token(Token = "0x4004522")]
		[FieldOffset(Offset = "0x14")]
		internal XWidget_ResultCharLevel charlvUpWidget;

		[Token(Token = "0x4004523")]
		[FieldOffset(Offset = "0x18")]
		internal List<int> questPointTable;

		[Token(Token = "0x4004524")]
		[FieldOffset(Offset = "0x1C")]
		internal XPanel_GameResultPVP _003C_003Ef__this;

		[Token(Token = "0x6006281")]
		[Address(RVA = "0xFEFD58", Offset = "0xFEFD58", VA = "0xFEFD58")]
		public _003CBuildCharLevel_003Ec__AnonStorey1A7()
		{
		}

		[Token(Token = "0x6006282")]
		[Address(RVA = "0xFF1268", Offset = "0xFF1268", VA = "0xFF1268")]
		internal string _003C_003Em__300(int val)
		{
			return null;
		}

		[Token(Token = "0x6006283")]
		[Address(RVA = "0xFF1298", Offset = "0xFF1298", VA = "0xFF1298")]
		internal void _003C_003Em__301(int val)
		{
		}

		[Token(Token = "0x6006284")]
		[Address(RVA = "0xFF12F4", Offset = "0xFF12F4", VA = "0xFF12F4")]
		internal bool _003C_003Em__302(int val)
		{
			return default(bool);
		}

		[Token(Token = "0x6006285")]
		[Address(RVA = "0xFF13C8", Offset = "0xFF13C8", VA = "0xFF13C8")]
		internal void _003C_003Em__303(UILabel label, int val)
		{
		}
	}

	[Token(Token = "0x40044F7")]
	[FieldOffset(Offset = "0xA4")]
	public UIBasicSprite lineVertical;

	[Token(Token = "0x40044F8")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton btnExit;

	[Token(Token = "0x40044F9")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject goCharRoot;

	[Token(Token = "0x40044FA")]
	[FieldOffset(Offset = "0xB0")]
	public XWiget_GridBuilder gridChar;

	[Token(Token = "0x40044FB")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject goCombatPointRoot;

	[Token(Token = "0x40044FC")]
	[FieldOffset(Offset = "0xB8")]
	public XWidget_ProgressBarWithTable prbCombatPoint;

	[Token(Token = "0x40044FD")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel lblIncreasedCombatPoint;

	[Token(Token = "0x40044FE")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel goComment;

	[Token(Token = "0x40044FF")]
	[FieldOffset(Offset = "0xC4")]
	private List<QuestInfo> m_combatQuestList;

	[Token(Token = "0x4004500")]
	[FieldOffset(Offset = "0xC8")]
	private List<QuestInfo> m_weekQuestList;

	[Token(Token = "0x4004501")]
	[FieldOffset(Offset = "0xCC")]
	private List<CSWinlose> m_liPlacementTest;

	[Token(Token = "0x4004502")]
	[FieldOffset(Offset = "0xD0")]
	public List<CSContentReward> lotteryRewards;

	[Token(Token = "0x4004503")]
	[FieldOffset(Offset = "0xD4")]
	public int beforeClanScore;

	[Token(Token = "0x4004504")]
	[FieldOffset(Offset = "0xD8")]
	public int getClanWarPoint;

	[Token(Token = "0x4004505")]
	[FieldOffset(Offset = "0xDC")]
	public UI2DSprite sprCombatQuestIcon;

	[Token(Token = "0x4004506")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel lblCombatQuestTitle;

	[Token(Token = "0x4004507")]
	[FieldOffset(Offset = "0xE4")]
	public UILabel lblCombatQuestPoint;

	[Token(Token = "0x4004508")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject CombatQuestPortraitObject;

	[Token(Token = "0x4004509")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject CombatPointObject;

	[Token(Token = "0x400450A")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject EventObject;

	[Token(Token = "0x400450B")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel lblEventText;

	[Token(Token = "0x400450C")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject sprScrollArrow;

	[Token(Token = "0x400450D")]
	[FieldOffset(Offset = "0xFC")]
	public UILabel lblTopRightMission;

	[Token(Token = "0x400450E")]
	[FieldOffset(Offset = "0x100")]
	public UI2DSprite sprTopRightIcon;

	[Token(Token = "0x400450F")]
	[FieldOffset(Offset = "0x104")]
	private bool m_isKickedClan;

	[Token(Token = "0x4004510")]
	[FieldOffset(Offset = "0x108")]
	private int m_beforeElo;

	[Token(Token = "0x4004511")]
	[FieldOffset(Offset = "0x10C")]
	private int m_acquireSkinArenaCoin;

	[Token(Token = "0x4004512")]
	[FieldOffset(Offset = "0x110")]
	private EventRewardType m_eventRewardType;

	[Token(Token = "0x4004513")]
	[FieldOffset(Offset = "0x114")]
	private bool m_isStarting;

	[Token(Token = "0x4004514")]
	[FieldOffset(Offset = "0x118")]
	private XWidget_ResultCharLevel[] CharLvUpWidgets__BackingField;

	[Token(Token = "0x4004515")]
	[FieldOffset(Offset = "0x0")]
	private static Func<QuestInfo, int> _003C_003Ef__am_0024cache1E;

	[Token(Token = "0x4004516")]
	[FieldOffset(Offset = "0x4")]
	private static Func<QuestInfo, int> _003C_003Ef__am_0024cache1F;

	[Token(Token = "0x4004517")]
	[FieldOffset(Offset = "0x8")]
	private static Action<UIProgressBar, int> _003C_003Ef__am_0024cache20;

	[Token(Token = "0x17000D31")]
	public XWidget_ResultCharLevel[] CharLvUpWidgets
	{
		[Token(Token = "0x600624D")]
		[Address(RVA = "0xFEC078", Offset = "0xFEC078", VA = "0xFEC078")]
		get
		{
			return null;
		}
		[Token(Token = "0x600624E")]
		[Address(RVA = "0xFEC080", Offset = "0xFEC080", VA = "0xFEC080")]
		private set
		{
		}
	}

	[Token(Token = "0x600624B")]
	[Address(RVA = "0xFEBB48", Offset = "0xFEBB48", VA = "0xFEBB48")]
	public XPanel_GameResultPVP()
	{
	}

	[Token(Token = "0x600624C")]
	[Address(RVA = "0xFEBC0C", Offset = "0xFEBC0C", VA = "0xFEBC0C", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x600624F")]
	[Address(RVA = "0xFEC088", Offset = "0xFEC088", VA = "0xFEC088")]
	private void SetMainQuestListSetting()
	{
	}

	[Token(Token = "0x6006250")]
	[Address(RVA = "0xFEC410", Offset = "0xFEC410", VA = "0xFEC410")]
	private QuestInfo GetCharacterCombatQuestListSetting(int charID, out List<int> questPointTable)
	{
		questPointTable = default;
		return null;
	}

	[Token(Token = "0x6006251")]
	[Address(RVA = "0xFEC95C", Offset = "0xFEC95C", VA = "0xFEC95C")]
	private QuestInfo GetCurrentCombatQuestInfo(int charID, int curStat)
	{
		return null;
	}

	[Token(Token = "0x6006252")]
	[Address(RVA = "0xFECCE8", Offset = "0xFECCE8", VA = "0xFECCE8")]
	public void SetBeforeResultElo(int elo)
	{
	}

	[Token(Token = "0x6006253")]
	[Address(RVA = "0xFECCF0", Offset = "0xFECCF0", VA = "0xFECCF0")]
	public void Show(Netdata_CompleteGame result, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6006254")]
	[Address(RVA = "0xFEEED4", Offset = "0xFEEED4", VA = "0xFEEED4")]
	protected List<RewardInfo> GetInGameEvnetModeRewardInfoList(Netdata_CompleteGame result)
	{
		return null;
	}

	[Token(Token = "0x6006255")]
	[Address(RVA = "0xFEF43C", Offset = "0xFEF43C", VA = "0xFEF43C")]
	private void CheckDupSkinArenaCoin(CSContentReward rewordInfo)
	{
	}

	[Token(Token = "0x6006256")]
	[Address(RVA = "0xFEF164", Offset = "0xFEF164", VA = "0xFEF164")]
	private void DirectionAddGameQuestPoint(XGameModeType type)
	{
	}

	[Token(Token = "0x6006257")]
	[Address(RVA = "0xFEDBC8", Offset = "0xFEDBC8", VA = "0xFEDBC8")]
	private void BuildBottom(CSStageLogic svcStage)
	{
	}

	[Token(Token = "0x6006258")]
	[Address(RVA = "0xFEDAD8", Offset = "0xFEDAD8", VA = "0xFEDAD8")]
	private void DirectionAdd_InGameTitle(XGameModeType gameMode)
	{
	}

	[Token(Token = "0x6006259")]
	[Address(RVA = "0xFEF5F4", Offset = "0xFEF5F4", VA = "0xFEF5F4", Slot = "18")]
	protected override void DirectionStart()
	{
	}

	[Token(Token = "0x600625A")]
	[Address(RVA = "0xFEE318", Offset = "0xFEE318", VA = "0xFEE318")]
	private UIDirectionSequence CreateCombatPointSeq(XGameModeType type, CSPointReward combatPointReward)
	{
		return null;
	}

	[Token(Token = "0x600625B")]
	[Address(RVA = "0xFEDF34", Offset = "0xFEDF34", VA = "0xFEDF34")]
	private UIDirectionSequence CreateTrophyPointPointSeq(CSPointReward trophyPointReward)
	{
		return null;
	}

	[Token(Token = "0x600625C")]
	[Address(RVA = "0xFEE72C", Offset = "0xFEE72C", VA = "0xFEE72C")]
	private void AddDirectionCharacterCombatQuest()
	{
	}

	[Token(Token = "0x600625D")]
	[Address(RVA = "0xFEF8C0", Offset = "0xFEF8C0", VA = "0xFEF8C0")]
	private void BuildCharLevel(XWidget_ResultCharLevel charlvUpWidget, int beforeXp, int earnXp, UIDirectionPararell pararell, List<int> questPointTable)
	{
	}

	[Token(Token = "0x600625E")]
	[Address(RVA = "0xFEF2D0", Offset = "0xFEF2D0", VA = "0xFEF2D0")]
	private void BuildEndComment()
	{
	}

	[Token(Token = "0x600625F")]
	[Address(RVA = "0xFEBE8C", Offset = "0xFEBE8C", VA = "0xFEBE8C")]
	public void OnClickOpenBox()
	{
	}

	[Token(Token = "0x6006260")]
	[Address(RVA = "0xFEBCCC", Offset = "0xFEBCCC", VA = "0xFEBCCC")]
	public void OnClickSkip()
	{
	}

	[Token(Token = "0x6006261")]
	[Address(RVA = "0xFEBF78", Offset = "0xFEBF78", VA = "0xFEBF78")]
	public void OnPVPExitButtonClick()
	{
	}

	[Token(Token = "0x6006262")]
	[Address(RVA = "0xFEFD60", Offset = "0xFEFD60", VA = "0xFEFD60")]
	private void ShowRankScoreDirection()
	{
	}

	[Token(Token = "0x6006263")]
	[Address(RVA = "0xFF02F4", Offset = "0xFF02F4", VA = "0xFF02F4")]
	public void OnAnotherGameStartFail()
	{
	}

	[Token(Token = "0x6006264")]
	[Address(RVA = "0xFF03D0", Offset = "0xFF03D0", VA = "0xFF03D0")]
	public void OnClickNextStage()
	{
	}

	[Token(Token = "0x6006265")]
	[Address(RVA = "0xFF0508", Offset = "0xFF0508", VA = "0xFF0508")]
	public void OnClickReplay()
	{
	}

	[Token(Token = "0x6006266")]
	[Address(RVA = "0xFF0630", Offset = "0xFF0630", VA = "0xFF0630")]
	public void SkipAllDirection()
	{
	}

	[Token(Token = "0x6006267")]
	[Address(RVA = "0xFF0698", Offset = "0xFF0698", VA = "0xFF0698")]
	private static int _003CGetCharacterCombatQuestListSetting_003Em__2EE(QuestInfo o)
	{
		return default(int);
	}

	[Token(Token = "0x6006268")]
	[Address(RVA = "0xFF06B8", Offset = "0xFF06B8", VA = "0xFF06B8")]
	private static int _003CGetCurrentCombatQuestInfo_003Em__2F0(QuestInfo o)
	{
		return default(int);
	}

	[Token(Token = "0x6006269")]
	[Address(RVA = "0xFF06D8", Offset = "0xFF06D8", VA = "0xFF06D8")]
	private void _003CDirectionAddGameQuestPoint_003Em__2F6()
	{
	}

	[Token(Token = "0x600626A")]
	[Address(RVA = "0xFF079C", Offset = "0xFF079C", VA = "0xFF079C")]
	private void _003CDirectionAddGameQuestPoint_003Em__2F7()
	{
	}

	[Token(Token = "0x600626B")]
	[Address(RVA = "0xFF0DDC", Offset = "0xFF0DDC", VA = "0xFF0DDC")]
	private void _003CDirectionAdd_InGameTitle_003Em__2F8()
	{
	}

	[Token(Token = "0x600626C")]
	[Address(RVA = "0xFF0DE4", Offset = "0xFF0DE4", VA = "0xFF0DE4")]
	private void _003CCreateCombatPointSeq_003Em__2F9()
	{
	}

	[Token(Token = "0x600626D")]
	[Address(RVA = "0xFF0E14", Offset = "0xFF0E14", VA = "0xFF0E14")]
	private void _003CCreateCombatPointSeq_003Em__2FA()
	{
	}

	[Token(Token = "0x600626E")]
	[Address(RVA = "0xFF0E54", Offset = "0xFF0E54", VA = "0xFF0E54")]
	private void _003CCreateTrophyPointPointSeq_003Em__2FB()
	{
	}

	[Token(Token = "0x600626F")]
	[Address(RVA = "0xFF0E84", Offset = "0xFF0E84", VA = "0xFF0E84")]
	private void _003CCreateTrophyPointPointSeq_003Em__2FC()
	{
	}

	[Token(Token = "0x6006270")]
	[Address(RVA = "0xFF0EC4", Offset = "0xFF0EC4", VA = "0xFF0EC4")]
	private void _003CAddDirectionCharacterCombatQuest_003Em__2FD()
	{
	}

	[Token(Token = "0x6006271")]
	[Address(RVA = "0xFF0F04", Offset = "0xFF0F04", VA = "0xFF0F04")]
	private static void _003CBuildCharLevel_003Em__304(UIProgressBar prb, int val)
	{
	}

	[Token(Token = "0x6006272")]
	[Address(RVA = "0xFF0F84", Offset = "0xFF0F84", VA = "0xFF0F84")]
	private void _003CBuildEndComment_003Em__305()
	{
	}

	[Token(Token = "0x6006273")]
	[Address(RVA = "0xFF1018", Offset = "0xFF1018", VA = "0xFF1018")]
	private void _003CBuildEndComment_003Em__306()
	{
	}
}
