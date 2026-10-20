using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000C0F")]
public class XTutorialManager
{
	[Token(Token = "0x2000C10")]
	public enum ClickStart
	{
		[Token(Token = "0x4003D12")]
		Attendance = 0,
		[Token(Token = "0x4003D13")]
		Fusion = 1,
		[Token(Token = "0x4003D14")]
		Promotion = 2,
		[Token(Token = "0x4003D15")]
		Transcendence = 3,
		[Token(Token = "0x4003D16")]
		Refine = 4,
		[Token(Token = "0x4003D17")]
		Talent = 5
	}

	[Token(Token = "0x2000C11")]
	private sealed class _003CProcessTutorial_003Ec__AnonStorey16D
	{
		[Token(Token = "0x4003D18")]
		[FieldOffset(Offset = "0x8")]
		internal int order;

		[Token(Token = "0x4003D19")]
		[FieldOffset(Offset = "0xC")]
		internal XTutorialManager _003C_003Ef__this;

		[Token(Token = "0x6005789")]
		[Address(RVA = "0x18557A4", Offset = "0x18557A4", VA = "0x18557A4")]
		public _003CProcessTutorial_003Ec__AnonStorey16D()
		{
		}

		[Token(Token = "0x600578A")]
		[Address(RVA = "0x1856D4C", Offset = "0x1856D4C", VA = "0x1856D4C")]
		internal void _003C_003Em__23B()
		{
		}
	}

	[Token(Token = "0x2000C12")]
	private sealed class _003CSendSetTutorialGroup_003Ec__AnonStorey16E
	{
		[Token(Token = "0x2000C13")]
		private sealed class _003CSendSetTutorialGroup_003Ec__AnonStorey16F
		{
			[Token(Token = "0x2000C14")]
			private sealed class _003CSendSetTutorialGroup_003Ec__AnonStorey170
			{
				[Token(Token = "0x4003D25")]
				[FieldOffset(Offset = "0x8")]
				internal Action onClickAction;

				[Token(Token = "0x4003D26")]
				[FieldOffset(Offset = "0xC")]
				internal _003CSendSetTutorialGroup_003Ec__AnonStorey16E _003C_003Ef__ref_0024366;

				[Token(Token = "0x4003D27")]
				[FieldOffset(Offset = "0x10")]
				internal _003CSendSetTutorialGroup_003Ec__AnonStorey16F _003C_003Ef__ref_0024367;

				[Token(Token = "0x6005790")]
				[Address(RVA = "0x18577A8", Offset = "0x18577A8", VA = "0x18577A8")]
				public _003CSendSetTutorialGroup_003Ec__AnonStorey170()
				{
				}

				[Token(Token = "0x6005791")]
				[Address(RVA = "0x18577B0", Offset = "0x18577B0", VA = "0x18577B0")]
				internal void _003C_003Em__240()
				{
				}
			}

			[Token(Token = "0x4003D1E")]
			[FieldOffset(Offset = "0x8")]
			internal XLobbyStateTypes enterState;

			[Token(Token = "0x4003D1F")]
			[FieldOffset(Offset = "0xC")]
			internal bool isNextTutoImmediatelyStart;

			[Token(Token = "0x4003D20")]
			[FieldOffset(Offset = "0x10")]
			internal Action nextTutoStartAction;

			[Token(Token = "0x4003D21")]
			[FieldOffset(Offset = "0x14")]
			internal bool isResumeTutorialExit;

			[Token(Token = "0x4003D22")]
			[FieldOffset(Offset = "0x18")]
			internal TutorialConditionInfo tutoConditionInfo;

			[Token(Token = "0x4003D23")]
			[FieldOffset(Offset = "0x1C")]
			internal ApiReturnCode nErrorCode;

			[Token(Token = "0x4003D24")]
			[FieldOffset(Offset = "0x20")]
			internal _003CSendSetTutorialGroup_003Ec__AnonStorey16E _003C_003Ef__ref_0024366;

			[Token(Token = "0x600578D")]
			[Address(RVA = "0x1857290", Offset = "0x1857290", VA = "0x1857290")]
			public _003CSendSetTutorialGroup_003Ec__AnonStorey16F()
			{
			}

			[Token(Token = "0x600578E")]
			[Address(RVA = "0x1857298", Offset = "0x1857298", VA = "0x1857298")]
			internal void _003C_003Em__23E()
			{
			}

			[Token(Token = "0x600578F")]
			[Address(RVA = "0x18572D4", Offset = "0x18572D4", VA = "0x18572D4")]
			internal void _003C_003Em__23F(Action onClickAction)
			{
			}
		}

		[Token(Token = "0x4003D1A")]
		[FieldOffset(Offset = "0x8")]
		internal bool isEnd;

		[Token(Token = "0x4003D1B")]
		[FieldOffset(Offset = "0xC")]
		internal int tutorialID;

		[Token(Token = "0x4003D1C")]
		[FieldOffset(Offset = "0x10")]
		internal bool isSkip;

		[Token(Token = "0x4003D1D")]
		[FieldOffset(Offset = "0x14")]
		internal XTutorialManager _003C_003Ef__this;

		[Token(Token = "0x600578B")]
		[Address(RVA = "0x18563F8", Offset = "0x18563F8", VA = "0x18563F8")]
		public _003CSendSetTutorialGroup_003Ec__AnonStorey16E()
		{
		}

		[Token(Token = "0x600578C")]
		[Address(RVA = "0x1856DA4", Offset = "0x1856DA4", VA = "0x1856DA4")]
		internal void _003C_003Em__23D(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4003CFB")]
	[FieldOffset(Offset = "0x8")]
	protected XGameObjectHolder m_goHolder;

	[Token(Token = "0x4003CFC")]
	[FieldOffset(Offset = "0xC")]
	private TutorialGroup m_tutoGroup;

	[Token(Token = "0x4003CFD")]
	[FieldOffset(Offset = "0x10")]
	private TutorialConditionInfo m_tutoCondition;

	[Token(Token = "0x4003CFE")]
	[FieldOffset(Offset = "0x14")]
	private TutorialConditionInfo m_reserveTutoCondition;

	[Token(Token = "0x4003CFF")]
	[FieldOffset(Offset = "0x18")]
	private CSWinlose m_prevPlayRecord;

	[Token(Token = "0x4003D00")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<string, int> PVPPlayLoseCount;

	[Token(Token = "0x4003D01")]
	[FieldOffset(Offset = "0x20")]
	public int curTutorialIdx;

	[Token(Token = "0x4003D02")]
	[FieldOffset(Offset = "0x24")]
	public int curGroupID;

	[Token(Token = "0x4003D03")]
	[FieldOffset(Offset = "0x28")]
	public XTutorialData tutoLocalData;

	[Token(Token = "0x4003D04")]
	[FieldOffset(Offset = "0x2C")]
	private Action m_hideCallBack;

	[Token(Token = "0x4003D05")]
	[FieldOffset(Offset = "0x30")]
	private bool isForceChecking;

	[Token(Token = "0x4003D06")]
	[FieldOffset(Offset = "0x34")]
	private float m_delayTime;

	[Token(Token = "0x4003D07")]
	[FieldOffset(Offset = "0x38")]
	private float m_elaspedDelayTime;

	[Token(Token = "0x4003D08")]
	[FieldOffset(Offset = "0x3C")]
	private bool isCompleteEndLastTutoScript;

	[Token(Token = "0x4003D09")]
	[FieldOffset(Offset = "0x40")]
	private Action m_lastTutoEndCallback;

	[Token(Token = "0x4003D0A")]
	[FieldOffset(Offset = "0x44")]
	private bool progress;

	[Token(Token = "0x4003D0B")]
	[FieldOffset(Offset = "0x48")]
	private XPanel_TutorialUI m_pnlTutorial;

	[Token(Token = "0x4003D0C")]
	[FieldOffset(Offset = "0x4C")]
	private bool TutorialReserved;

	[Token(Token = "0x4003D0D")]
	[FieldOffset(Offset = "0x50")]
	private Action<Action> m_delayShowTutorialReward;

	[Token(Token = "0x4003D0E")]
	[FieldOffset(Offset = "0x54")]
	private TutorialScriptType CurrentScriptType__BackingField;

	[Token(Token = "0x4003D0F")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map15;

	[Token(Token = "0x4003D10")]
	[FieldOffset(Offset = "0x4")]
	private static Func<int, bool> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x17000C9E")]
	public XGameObjectHolder GOHolder
	{
		[Token(Token = "0x600572E")]
		[Address(RVA = "0x184DCC0", Offset = "0x184DCC0", VA = "0x184DCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C9F")]
	public CSWinlose PrevPlayRecord
	{
		[Token(Token = "0x600572F")]
		[Address(RVA = "0x184DCC8", Offset = "0x184DCC8", VA = "0x184DCC8")]
		get
		{
			return default(CSWinlose);
		}
	}

	[Token(Token = "0x17000CA0")]
	public TutorialType CurrentTutorialType
	{
		[Token(Token = "0x6005731")]
		[Address(RVA = "0x184DCE4", Offset = "0x184DCE4", VA = "0x184DCE4")]
		get
		{
			return default(TutorialType);
		}
	}

	[Token(Token = "0x17000CA1")]
	public TutorialScriptType CurrentScriptType
	{
		[Token(Token = "0x6005732")]
		[Address(RVA = "0x184DCF8", Offset = "0x184DCF8", VA = "0x184DCF8")]
		get
		{
			return default(TutorialScriptType);
		}
		[Token(Token = "0x6005733")]
		[Address(RVA = "0x184DD00", Offset = "0x184DD00", VA = "0x184DD00")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CA2")]
	public bool Progress
	{
		[Token(Token = "0x6005735")]
		[Address(RVA = "0x1844884", Offset = "0x1844884", VA = "0x1844884")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000CA3")]
	public XPanel_TutorialUI pnlTutorial
	{
		[Token(Token = "0x6005739")]
		[Address(RVA = "0x184E314", Offset = "0x184E314", VA = "0x184E314")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600572D")]
	[Address(RVA = "0x184DC00", Offset = "0x184DC00", VA = "0x184DC00")]
	public XTutorialManager()
	{
	}

	[Token(Token = "0x6005730")]
	[Address(RVA = "0x184DCDC", Offset = "0x184DCDC", VA = "0x184DCDC")]
	public void RegistTutorialEndCallback(Action endCallback)
	{
	}

	[Token(Token = "0x6005734")]
	[Address(RVA = "0x184DD08", Offset = "0x184DD08", VA = "0x184DD08")]
	public bool IsProgressTutorial(TutorialType tutorialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6005736")]
	[Address(RVA = "0x184DD44", Offset = "0x184DD44", VA = "0x184DD44")]
	public void Update(float delta)
	{
	}

	[Token(Token = "0x6005737")]
	[Address(RVA = "0x184DF68", Offset = "0x184DF68", VA = "0x184DF68")]
	public void TutoCompletedReset()
	{
	}

	[Token(Token = "0x6005738")]
	[Address(RVA = "0x184E1AC", Offset = "0x184E1AC", VA = "0x184E1AC")]
	public void InitHolder()
	{
	}

	[Token(Token = "0x600573A")]
	[Address(RVA = "0x184E42C", Offset = "0x184E42C", VA = "0x184E42C")]
	public void DestroyDynamicLoadPrefab()
	{
	}

	[Token(Token = "0x600573B")]
	[Address(RVA = "0x184E508", Offset = "0x184E508", VA = "0x184E508")]
	public void InitTutorialUI()
	{
	}

	[Token(Token = "0x600573C")]
	[Address(RVA = "0x184E6C0", Offset = "0x184E6C0", VA = "0x184E6C0")]
	public void SetToLocalDataAllClear()
	{
	}

	[Token(Token = "0x600573D")]
	[Address(RVA = "0x184E88C", Offset = "0x184E88C", VA = "0x184E88C")]
	public void SetSkipNeedData()
	{
	}

	[Token(Token = "0x600573E")]
	[Address(RVA = "0x184FCFC", Offset = "0x184FCFC", VA = "0x184FCFC")]
	private bool IsSkipDisable()
	{
		return default(bool);
	}

	[Token(Token = "0x600573F")]
	[Address(RVA = "0x184FD78", Offset = "0x184FD78", VA = "0x184FD78")]
	public void ProcessTutoBackButton()
	{
	}

	[Token(Token = "0x6005740")]
	[Address(RVA = "0x1850528", Offset = "0x1850528", VA = "0x1850528")]
	public void ForceMoveLobbyState(string strForceMove)
	{
	}

	[Token(Token = "0x6005741")]
	[Address(RVA = "0x1851D44", Offset = "0x1851D44", VA = "0x1851D44")]
	public bool ForceRestartTutorial(bool reserve)
	{
		return default(bool);
	}

	[Token(Token = "0x6005742")]
	[Address(RVA = "0x1851E58", Offset = "0x1851E58", VA = "0x1851E58")]
	private bool TryGetExistResumeTutorial(out int restartTutoID, out TutorialConditionInfo tutoInfo)
	{
		restartTutoID = default;
		tutoInfo = default;
		return default(bool);
	}

	[Token(Token = "0x6005743")]
	[Address(RVA = "0x1851D90", Offset = "0x1851D90", VA = "0x1851D90")]
	public bool RestartTutorial(bool reserve)
	{
		return default(bool);
	}

	[Token(Token = "0x6005744")]
	[Address(RVA = "0x18527D0", Offset = "0x18527D0", VA = "0x18527D0")]
	public bool ConsoleForceStartTutorial(int tutoID, int tutoGroup)
	{
		return default(bool);
	}

	[Token(Token = "0x6005745")]
	[Address(RVA = "0x18537A0", Offset = "0x18537A0", VA = "0x18537A0")]
	public bool LevelUpStartTutorialReserve(int teamLv)
	{
		return default(bool);
	}

	[Token(Token = "0x6005746")]
	[Address(RVA = "0x1853AE0", Offset = "0x1853AE0", VA = "0x1853AE0")]
	public bool StartReserveTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x6005747")]
	[Address(RVA = "0x1853C8C", Offset = "0x1853C8C", VA = "0x1853C8C")]
	public void ClickButtonStartTutorial(ClickStart startenum)
	{
	}

	[Token(Token = "0x6005748")]
	[Address(RVA = "0x1853E70", Offset = "0x1853E70", VA = "0x1853E70")]
	public bool EnterLobbyStateStartTutorial(XLobbyStateTypes enterState, bool reserve = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005749")]
	[Address(RVA = "0x1854008", Offset = "0x1854008", VA = "0x1854008")]
	public int GetMissionIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600574A")]
	[Address(RVA = "0x1854124", Offset = "0x1854124", VA = "0x1854124")]
	public bool StartInGameTutorial(int tutorialID, int startOrder)
	{
		return default(bool);
	}

	[Token(Token = "0x600574B")]
	[Address(RVA = "0x1852524", Offset = "0x1852524", VA = "0x1852524")]
	public bool StartTutorial(int tutorialID, int startOrder, bool reserve = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600574C")]
	[Address(RVA = "0x1854320", Offset = "0x1854320", VA = "0x1854320")]
	public void ReserveTutorialStart()
	{
	}

	[Token(Token = "0x600574D")]
	[Address(RVA = "0x18529D4", Offset = "0x18529D4", VA = "0x18529D4")]
	private bool BuildTutorial(TutorialGroup group, int startIdx, int startGroupID)
	{
		return default(bool);
	}

	[Token(Token = "0x600574E")]
	[Address(RVA = "0x185437C", Offset = "0x185437C", VA = "0x185437C")]
	private void SetBG(TutorialGroup group, int groupID, int tutoIdx)
	{
	}

	[Token(Token = "0x600574F")]
	[Address(RVA = "0x1854958", Offset = "0x1854958", VA = "0x1854958")]
	private void SetRightTutorialReward(TutorialGroup group, int curGroupID, int curTutorialIdx)
	{
	}

	[Token(Token = "0x6005750")]
	[Address(RVA = "0x1850314", Offset = "0x1850314", VA = "0x1850314")]
	private void SkipTutorial()
	{
	}

	[Token(Token = "0x6005751")]
	[Address(RVA = "0x1854D48", Offset = "0x1854D48", VA = "0x1854D48")]
	private bool IsSkipableScriptType(TutorialScriptType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6005752")]
	[Address(RVA = "0x184DFDC", Offset = "0x184DFDC", VA = "0x184DFDC")]
	private void SetProgress(bool isProgress)
	{
	}

	[Token(Token = "0x6005753")]
	[Address(RVA = "0x1854D5C", Offset = "0x1854D5C", VA = "0x1854D5C")]
	private void BuildSkip(int idxInGroup)
	{
	}

	[Token(Token = "0x6005754")]
	[Address(RVA = "0x1854DD0", Offset = "0x1854DD0", VA = "0x1854DD0")]
	private bool IsAIModeSkipable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005755")]
	[Address(RVA = "0x1854F54", Offset = "0x1854F54", VA = "0x1854F54")]
	public void NextGroup()
	{
	}

	[Token(Token = "0x6005756")]
	[Address(RVA = "0x1855030", Offset = "0x1855030", VA = "0x1855030")]
	private void CompeteEndLastScript()
	{
	}

	[Token(Token = "0x6005757")]
	[Address(RVA = "0x184DDA8", Offset = "0x184DDA8", VA = "0x184DDA8")]
	private void NextTutorial()
	{
	}

	[Token(Token = "0x6005758")]
	[Address(RVA = "0x18553E4", Offset = "0x18553E4", VA = "0x18553E4")]
	public void CompleteEndLastTutoScript()
	{
	}

	[Token(Token = "0x6005759")]
	[Address(RVA = "0x1855414", Offset = "0x1855414", VA = "0x1855414")]
	public bool NextTutorial(TutorialType checkType, GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600575A")]
	[Address(RVA = "0x185555C", Offset = "0x185555C", VA = "0x185555C")]
	public bool NextTutorial(TutorialType checkType, float delayTime = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x600575B")]
	[Address(RVA = "0x18556C4", Offset = "0x18556C4", VA = "0x18556C4")]
	public void NextTutorial(Action hideCallBack)
	{
	}

	[Token(Token = "0x600575C")]
	[Address(RVA = "0x185579C", Offset = "0x185579C", VA = "0x185579C")]
	public void SetHideCallBack(Action hideCallBack)
	{
	}

	[Token(Token = "0x600575D")]
	[Address(RVA = "0x1854C64", Offset = "0x1854C64", VA = "0x1854C64")]
	private bool CheckGroupEnd(int groupIdx, int tutorialIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x600575E")]
	[Address(RVA = "0x1854AE4", Offset = "0x1854AE4", VA = "0x1854AE4")]
	private TutorialDataBase GetTutorialData(int groupIdx, int tutorialIdx)
	{
		return null;
	}

	[Token(Token = "0x600575F")]
	[Address(RVA = "0x1852ED8", Offset = "0x1852ED8", VA = "0x1852ED8")]
	private void ProcessTutorial(int tutorialIdx)
	{
	}

	[Token(Token = "0x6005760")]
	[Address(RVA = "0x1855D80", Offset = "0x1855D80", VA = "0x1855D80")]
	public void ChangeSnapShotName(string name)
	{
	}

	[Token(Token = "0x6005761")]
	[Address(RVA = "0x184DFE4", Offset = "0x184DFE4", VA = "0x184DFE4")]
	private void EndTutorial(bool isSkip = false)
	{
	}

	[Token(Token = "0x6005762")]
	[Address(RVA = "0x1855210", Offset = "0x1855210", VA = "0x1855210")]
	private void ShowEventNotification()
	{
	}

	[Token(Token = "0x6005763")]
	[Address(RVA = "0x1853ADC", Offset = "0x1853ADC", VA = "0x1853ADC")]
	private void ReserveForceStart(int nextTutorialID)
	{
	}

	[Token(Token = "0x6005764")]
	[Address(RVA = "0x1855DB4", Offset = "0x1855DB4", VA = "0x1855DB4")]
	public void OnClick_EndTutorial()
	{
	}

	[Token(Token = "0x6005765")]
	[Address(RVA = "0x1850138", Offset = "0x1850138", VA = "0x1850138")]
	public void ShowEndTutorialCheckMessage(Action okAction)
	{
	}

	[Token(Token = "0x6005766")]
	[Address(RVA = "0x1855E60", Offset = "0x1855E60", VA = "0x1855E60")]
	public void ForceTutorialQuit()
	{
	}

	[Token(Token = "0x6005767")]
	[Address(RVA = "0x1856054", Offset = "0x1856054", VA = "0x1856054")]
	public void SetFadeInOutDuration(float fadeInDuration, float fadeOutDuration)
	{
	}

	[Token(Token = "0x6005768")]
	[Address(RVA = "0x1856090", Offset = "0x1856090", VA = "0x1856090")]
	public void FadeInOut(Action fadeOutFinishAction)
	{
	}

	[Token(Token = "0x6005769")]
	[Address(RVA = "0x18560C4", Offset = "0x18560C4", VA = "0x18560C4")]
	public void FadeIn(Action fadeInFinishAction)
	{
	}

	[Token(Token = "0x600576A")]
	[Address(RVA = "0x18560F8", Offset = "0x18560F8", VA = "0x18560F8")]
	public void FadeOut(Action fadeOutFinishAction)
	{
	}

	[Token(Token = "0x600576B")]
	[Address(RVA = "0x185612C", Offset = "0x185612C", VA = "0x185612C")]
	private bool IsLastScriptInGroup(TutorialGroup group, int groupIdx, int sriptIdxInGroup)
	{
		return default(bool);
	}

	[Token(Token = "0x600576C")]
	[Address(RVA = "0x1855BF4", Offset = "0x1855BF4", VA = "0x1855BF4")]
	private bool IsLastTutorialScript(int order)
	{
		return default(bool);
	}

	[Token(Token = "0x600576D")]
	[Address(RVA = "0x18522F0", Offset = "0x18522F0", VA = "0x18522F0")]
	private bool CheckCondition(TutorialConditionInfo tutoConditionInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600576E")]
	[Address(RVA = "0x185620C", Offset = "0x185620C", VA = "0x185620C")]
	private bool CheckCondition(TutorialType prevCondition, int teamLv)
	{
		return default(bool);
	}

	[Token(Token = "0x600576F")]
	[Address(RVA = "0x185631C", Offset = "0x185631C", VA = "0x185631C")]
	public void HideMsg()
	{
	}

	[Token(Token = "0x6005770")]
	[Address(RVA = "0x184E540", Offset = "0x184E540", VA = "0x184E540")]
	public void UIHide()
	{
	}

	[Token(Token = "0x6005771")]
	[Address(RVA = "0x1855C28", Offset = "0x1855C28", VA = "0x1855C28")]
	private void SetCompleteGroup(TutorialGroup tutoGroup, int groupID, int tutoIdx, int order)
	{
	}

	[Token(Token = "0x6005772")]
	[Address(RVA = "0x18548F8", Offset = "0x18548F8", VA = "0x18548F8")]
	private void SetStartGroup(int tutorialID)
	{
	}

	[Token(Token = "0x6005773")]
	[Address(RVA = "0x1854414", Offset = "0x1854414", VA = "0x1854414")]
	private void SendSetTutorialGroup(int tutorialID, int groupID, bool isEnd, bool isSkip = false)
	{
	}

	[Token(Token = "0x6005774")]
	[Address(RVA = "0x1856400", Offset = "0x1856400", VA = "0x1856400")]
	public void SetSavePointByCurShowTutorial()
	{
	}

	[Token(Token = "0x6005775")]
	[Address(RVA = "0x18557AC", Offset = "0x18557AC", VA = "0x18557AC")]
	private void SetTutorialTimeScaleZero(bool on)
	{
	}

	[Token(Token = "0x6005776")]
	[Address(RVA = "0x1854EB0", Offset = "0x1854EB0", VA = "0x1854EB0")]
	private bool IsInGameScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6005777")]
	[Address(RVA = "0x1855AC4", Offset = "0x1855AC4", VA = "0x1855AC4")]
	private bool IsShowedGameReadyView()
	{
		return default(bool);
	}

	[Token(Token = "0x6005778")]
	[Address(RVA = "0x184DE00", Offset = "0x184DE00", VA = "0x184DE00")]
	private void ShowVirtualKey(bool isShow)
	{
	}

	[Token(Token = "0x6005779")]
	[Address(RVA = "0x18564D4", Offset = "0x18564D4", VA = "0x18564D4")]
	public int GetSelectCharacterID()
	{
		return default(int);
	}

	[Token(Token = "0x600577A")]
	[Address(RVA = "0x18538C4", Offset = "0x18538C4", VA = "0x18538C4")]
	private TutorialConditionInfo GetEnterableTutorialConditionInfo(string strStartCondition)
	{
		return null;
	}

	[Token(Token = "0x600577B")]
	[Address(RVA = "0x1852320", Offset = "0x1852320", VA = "0x1852320")]
	private TutorialGroup GetTutorialGroupData(int tutorialID)
	{
		return null;
	}

	[Token(Token = "0x600577C")]
	[Address(RVA = "0x184E8C0", Offset = "0x184E8C0", VA = "0x184E8C0")]
	private void SetIngameGuid()
	{
	}

	[Token(Token = "0x600577D")]
	[Address(RVA = "0x18564F8", Offset = "0x18564F8", VA = "0x18564F8")]
	private void SetPartyLeaderReina()
	{
	}

	[Token(Token = "0x600577E")]
	[Address(RVA = "0x184E9F8", Offset = "0x184E9F8", VA = "0x184E9F8")]
	private void SetSkipRecruitTeamGuid()
	{
	}

	[Token(Token = "0x600577F")]
	[Address(RVA = "0x184F338", Offset = "0x184F338", VA = "0x184F338")]
	private void SetSkipMission()
	{
	}

	[Token(Token = "0x6005780")]
	[Address(RVA = "0x184F6C4", Offset = "0x184F6C4", VA = "0x184F6C4")]
	private void SetSkipTalentGuide()
	{
	}

	[Token(Token = "0x6005781")]
	[Address(RVA = "0x1856718", Offset = "0x1856718", VA = "0x1856718")]
	private bool CheckClearStage(int stageIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6005782")]
	[Address(RVA = "0x184F948", Offset = "0x184F948", VA = "0x184F948")]
	public void LinkNextTutoImmediatlyCommitTypes()
	{
	}

	[Token(Token = "0x6005783")]
	[Address(RVA = "0x18569A0", Offset = "0x18569A0", VA = "0x18569A0")]
	public void SetLastPVPPlayRecord(CSWinlose winLose)
	{
	}

	[Token(Token = "0x6005784")]
	[Address(RVA = "0x18569A8", Offset = "0x18569A8", VA = "0x18569A8")]
	public int GetPVPTutorialLoseCount(string aid)
	{
		return default(int);
	}

	[Token(Token = "0x6005785")]
	[Address(RVA = "0x1856AE4", Offset = "0x1856AE4", VA = "0x1856AE4")]
	private void _003CProcessTutoBackButton_003Em__238()
	{
	}

	[Token(Token = "0x6005786")]
	[Address(RVA = "0x1856B04", Offset = "0x1856B04", VA = "0x1856B04")]
	private static bool _003CTryGetExistResumeTutorial_003Em__239(int tutoID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005787")]
	[Address(RVA = "0x1856C38", Offset = "0x1856C38", VA = "0x1856C38")]
	private void _003CCompeteEndLastScript_003Em__23A()
	{
	}

	[Token(Token = "0x6005788")]
	[Address(RVA = "0x1856C3C", Offset = "0x1856C3C", VA = "0x1856C3C")]
	private void _003COnClick_EndTutorial_003Em__23C()
	{
	}
}
