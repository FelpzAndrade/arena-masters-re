using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XUIEnum;

[Token(Token = "0x2001058")]
public class XUIMgr_Game : XUIMgrBase
{
	[Token(Token = "0x2001059")]
	public enum AsyncUI
	{
		[Token(Token = "0x4005824")]
		pnlGameCommon = 1,
		[Token(Token = "0x4005825")]
		pnlGameRecords = 2,
		[Token(Token = "0x4005826")]
		pnlGameResult = 3,
		[Token(Token = "0x4005827")]
		pnlGameResultCharactersDirection = 4,
		[Token(Token = "0x4005828")]
		allyUltOn = 101,
		[Token(Token = "0x4005829")]
		enemyUltOn = 102,
		[Token(Token = "0x400582A")]
		messageBarKillEffect = 103
	}

	[Token(Token = "0x200105A")]
	private sealed class _003CCoroutineShowRespawnWindow_003Ec__IteratorB4 : IDisposable
	{
		[Token(Token = "0x400582B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float fDelayTime;

		[Token(Token = "0x400582C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400582D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400582E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003EfDelayTime;

		[Token(Token = "0x400582F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal XUIMgr_Game _003C_003Ef__this;

		[Token(Token = "0x17000F1D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6007AB9")]
			[Address(RVA = "0x10BF478", Offset = "0x10BF478", VA = "0x10BF478", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000F1E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007ABA")]
			[Address(RVA = "0x10BF480", Offset = "0x10BF480", VA = "0x10BF480", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6007AB8")]
		[Address(RVA = "0x10BD418", Offset = "0x10BD418", VA = "0x10BD418")]
		public _003CCoroutineShowRespawnWindow_003Ec__IteratorB4()
		{
		}

		[Token(Token = "0x6007AB9")]
		[Address(RVA = "0x10BF478", Offset = "0x10BF478", VA = "0x10BF478", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007ABA")]
		[Address(RVA = "0x10BF480", Offset = "0x10BF480", VA = "0x10BF480", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007ABB")]
		[Address(RVA = "0x10BF488", Offset = "0x10BF488", VA = "0x10BF488", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007ABC")]
		[Address(RVA = "0x10BF61C", Offset = "0x10BF61C", VA = "0x10BF61C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6007ABD")]
		[Address(RVA = "0x10BF628", Offset = "0x10BF628", VA = "0x10BF628", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400581D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XUIGameMode m_curMode;

	[Token(Token = "0x400581E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AmplifyColorEffect amplifyColorEffect;

	[Token(Token = "0x400581F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool isDieEffect;

	[Token(Token = "0x4005820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float dieEffectTime;

	[Token(Token = "0x4005821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float blendAmount;

	[Token(Token = "0x4005822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float equationValue;

	[Token(Token = "0x17000F1C")]
	public XUIGameMode ModeUI
	{
		[Token(Token = "0x6007AAF")]
		[Address(RVA = "0x10BF26C", Offset = "0x10BF26C", VA = "0x10BF26C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A4D")]
	[Address(RVA = "0x10B15A0", Offset = "0x10B15A0", VA = "0x10B15A0")]
	public XUIMgr_Game()
	{
	}

	[Token(Token = "0x6007A4E")]
	[Address(RVA = "0x10BBEB4", Offset = "0x10BBEB4", VA = "0x10BBEB4", Slot = "6")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6007A4F")]
	[Address(RVA = "0x10BBF90", Offset = "0x10BBF90", VA = "0x10BBF90", Slot = "7")]
	public override void ReleaseNGUIAtlas()
	{
	}

	[Token(Token = "0x6007A50")]
	[Address(RVA = "0x10BC240", Offset = "0x10BC240", VA = "0x10BC240", Slot = "4")]
	public override string GetPrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6007A51")]
	[Address(RVA = "0x10B1FF4", Offset = "0x10B1FF4", VA = "0x10B1FF4")]
	public void Final()
	{
	}

	[Token(Token = "0x6007A52")]
	[Address(RVA = "0x10BC2B8", Offset = "0x10BC2B8", VA = "0x10BC2B8")]
	public GameObject GetHealtBarRoot()
	{
		return null;
	}

	[Token(Token = "0x6007A53")]
	[Address(RVA = "0x10BC2D0", Offset = "0x10BC2D0", VA = "0x10BC2D0")]
	public GameObject GetHeadBalloonRoot()
	{
		return null;
	}

	[Token(Token = "0x6007A54")]
	[Address(RVA = "0x10BC2E8", Offset = "0x10BC2E8", VA = "0x10BC2E8", Slot = "8")]
	public override void BackGroundLoadAsyncUI(int ui)
	{
	}

	[Token(Token = "0x6007A55")]
	[Address(RVA = "0x10BC60C", Offset = "0x10BC60C", VA = "0x10BC60C")]
	public void PreloadAsyncUIEffect()
	{
	}

	[Token(Token = "0x6007A56")]
	[Address(RVA = "0x10BC728", Offset = "0x10BC728", VA = "0x10BC728")]
	private XUIGameMode MakeMode(XGameModeType type)
	{
		return null;
	}

	[Token(Token = "0x6007A57")]
	[Address(RVA = "0x10BCB08", Offset = "0x10BCB08", VA = "0x10BCB08", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6007A58")]
	[Address(RVA = "0x10BCC14", Offset = "0x10BCC14", VA = "0x10BCC14")]
	public void Init(XGameModeType type)
	{
	}

	[Token(Token = "0x6007A59")]
	[Address(RVA = "0x10BCFC0", Offset = "0x10BCFC0", VA = "0x10BCFC0")]
	public void OnInitGame()
	{
	}

	[Token(Token = "0x6007A5A")]
	[Address(RVA = "0x10BD044", Offset = "0x10BD044", VA = "0x10BD044")]
	public void InitSkillWindow()
	{
	}

	[Token(Token = "0x6007A5B")]
	[Address(RVA = "0x10BD058", Offset = "0x10BD058", VA = "0x10BD058")]
	internal void ReLinkSkillModule()
	{
	}

	[Token(Token = "0x6007A5C")]
	[Address(RVA = "0x10BD06C", Offset = "0x10BD06C", VA = "0x10BD06C")]
	public void ShowRespawnWindow(bool val, float fDelayTime = 0f)
	{
	}

	[Token(Token = "0x6007A5D")]
	[Address(RVA = "0x10BD1D8", Offset = "0x10BD1D8", VA = "0x10BD1D8")]
	public void HideNavigation()
	{
	}

	[Token(Token = "0x6007A5E")]
	[Address(RVA = "0x10BD224", Offset = "0x10BD224", VA = "0x10BD224")]
	public void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6007A5F")]
	[Address(RVA = "0x10BD284", Offset = "0x10BD284", VA = "0x10BD284")]
	public void ShowBossDesc(bool bShow, [Optional] Action onComplete, [Optional] string top, [Optional] string bot)
	{
	}

	[Token(Token = "0x6007A60")]
	[Address(RVA = "0x10BD2F0", Offset = "0x10BD2F0", VA = "0x10BD2F0")]
	public void ShowBossHP(bool bShow, [Optional] XModuleActor boss)
	{
	}

	[Token(Token = "0x6007A61")]
	[Address(RVA = "0x10BD350", Offset = "0x10BD350", VA = "0x10BD350")]
	public void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6007A62")]
	[Address(RVA = "0x10BD3A4", Offset = "0x10BD3A4", VA = "0x10BD3A4")]
	public void OnDelayCommonUI()
	{
	}

	[Token(Token = "0x6007A63")]
	[Address(RVA = "0x10BD3F0", Offset = "0x10BD3F0", VA = "0x10BD3F0")]
	public void HideSpectatorTargetMsg()
	{
	}

	[Token(Token = "0x6007A64")]
	[Address(RVA = "0x10BD404", Offset = "0x10BD404", VA = "0x10BD404")]
	public void SetCanInteractionInput(bool isCanInput)
	{
	}

	[Token(Token = "0x6007A65")]
	[Address(RVA = "0x10BD124", Offset = "0x10BD124", VA = "0x10BD124")]
	[DebuggerHidden]
	private IEnumerator CoroutineShowRespawnWindow(float fDelayTime)
	{
		return null;
	}

	[Token(Token = "0x6007A66")]
	[Address(RVA = "0x10BD420", Offset = "0x10BD420", VA = "0x10BD420")]
	public void RefreshGameStatus()
	{
	}

	[Token(Token = "0x6007A67")]
	[Address(RVA = "0x10BD46C", Offset = "0x10BD46C", VA = "0x10BD46C")]
	public void RefreshGameReady()
	{
	}

	[Token(Token = "0x6007A68")]
	[Address(RVA = "0x10BD480", Offset = "0x10BD480", VA = "0x10BD480")]
	public void RefreshTopUI()
	{
	}

	[Token(Token = "0x6007A69")]
	[Address(RVA = "0x10BD4CC", Offset = "0x10BD4CC", VA = "0x10BD4CC")]
	public void RegisterJoyStick()
	{
	}

	[Token(Token = "0x6007A6A")]
	[Address(RVA = "0x10BD4E0", Offset = "0x10BD4E0", VA = "0x10BD4E0")]
	public void RefreshTeamHpBar(List<XPlayer> playerList)
	{
	}

	[Token(Token = "0x6007A6B")]
	[Address(RVA = "0x10BD4F4", Offset = "0x10BD4F4", VA = "0x10BD4F4")]
	public void RefreshFriendlyTeamInfo()
	{
	}

	[Token(Token = "0x6007A6C")]
	[Address(RVA = "0x10BD508", Offset = "0x10BD508", VA = "0x10BD508")]
	public void ShowFriendlySettingUI(bool isActive)
	{
	}

	[Token(Token = "0x6007A6D")]
	[Address(RVA = "0x10BD51C", Offset = "0x10BD51C", VA = "0x10BD51C")]
	public void RecvMasterClientTeamInfo(byte teamInfo)
	{
	}

	[Token(Token = "0x6007A6E")]
	[Address(RVA = "0x10BD530", Offset = "0x10BD530", VA = "0x10BD530")]
	public void RefreshLifeUI()
	{
	}

	[Token(Token = "0x6007A6F")]
	[Address(RVA = "0x10BD57C", Offset = "0x10BD57C", VA = "0x10BD57C")]
	public void ShowGameExit(bool val)
	{
	}

	[Token(Token = "0x6007A70")]
	[Address(RVA = "0x107C024", Offset = "0x107C024", VA = "0x107C024")]
	public void ShowPauseMenu(bool val, [Optional] Action<bool> action)
	{
	}

	[Token(Token = "0x6007A71")]
	[Address(RVA = "0x10BD5DC", Offset = "0x10BD5DC", VA = "0x10BD5DC")]
	public void ShowGameRecords(bool val)
	{
	}

	[Token(Token = "0x6007A72")]
	[Address(RVA = "0x10BD844", Offset = "0x10BD844", VA = "0x10BD844")]
	public void ShowRankPointDirection(CSTrophyReward beforeTrophyRewardInfo, CSTrophyReward currentTrophyRewardInfo, List<CSWinlose> placementResult, List<int> tierTable, int beforeScore, int currentScore, bool isKickedClan = false)
	{
	}

	[Token(Token = "0x6007A73")]
	[Address(RVA = "0x10BD88C", Offset = "0x10BD88C", VA = "0x10BD88C")]
	public void ShowClanPointDirection(int beforeClanScore, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6007A74")]
	[Address(RVA = "0x10BD8A0", Offset = "0x10BD8A0", VA = "0x10BD8A0")]
	public void HideClanPointDirection()
	{
	}

	[Token(Token = "0x6007A75")]
	[Address(RVA = "0x10BD8B4", Offset = "0x10BD8B4", VA = "0x10BD8B4")]
	public void SetBeforeResultElo(int elo)
	{
	}

	[Token(Token = "0x6007A76")]
	[Address(RVA = "0x10BD908", Offset = "0x10BD908", VA = "0x10BD908")]
	public void ShowResultWindow(bool bShow, [Optional] Netdata_CompleteGame result, [Optional] XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6007A77")]
	[Address(RVA = "0x10BD96C", Offset = "0x10BD96C", VA = "0x10BD96C")]
	public void ShowSpecialGameResultWindow(bool bShow, [Optional] Netdata_CompleteSpecial result)
	{
	}

	[Token(Token = "0x6007A78")]
	[Address(RVA = "0x10BD9CC", Offset = "0x10BD9CC", VA = "0x10BD9CC")]
	public void ShowMissionResultWindow(bool bShow, int clearBeforTotalStar, [Optional] Netdata_CompleteMission result, int score = 0)
	{
	}

	[Token(Token = "0x6007A79")]
	[Address(RVA = "0x10BDA3C", Offset = "0x10BDA3C", VA = "0x10BDA3C")]
	public void ShowSkyTowerResultWindow(bool bShow, [Optional] Netdata_CompleteSkyTower result)
	{
	}

	[Token(Token = "0x6007A7A")]
	[Address(RVA = "0x10BDA9C", Offset = "0x10BDA9C", VA = "0x10BDA9C")]
	public void ShowGameResultExpression(XGameModeType gameModeType, CSWinlose gameResult, [Optional] Action endAction)
	{
	}

	[Token(Token = "0x6007A7B")]
	[Address(RVA = "0x10BDB00", Offset = "0x10BDB00", VA = "0x10BDB00")]
	public void HideGameResultExpression()
	{
	}

	[Token(Token = "0x6007A7C")]
	[Address(RVA = "0x10BDB4C", Offset = "0x10BDB4C", VA = "0x10BDB4C")]
	public void CreatePlayerCharacterObject(XPlayerManager playerManager, List<XModuleEntity> playerMoludeEntityList, Action action)
	{
	}

	[Token(Token = "0x6007A7D")]
	[Address(RVA = "0x10BDBB0", Offset = "0x10BDBB0", VA = "0x10BDBB0")]
	public void ShowGameResultCharactersDirection(XPlayerManager playerManager, Action action)
	{
	}

	[Token(Token = "0x6007A7E")]
	[Address(RVA = "0x10BDC10", Offset = "0x10BDC10", VA = "0x10BDC10")]
	public void HideGameResultCharactersDirection()
	{
	}

	[Token(Token = "0x6007A7F")]
	[Address(RVA = "0x10BDC5C", Offset = "0x10BDC5C", VA = "0x10BDC5C")]
	public void HideResultWindow()
	{
	}

	[Token(Token = "0x6007A80")]
	[Address(RVA = "0x10BDCA8", Offset = "0x10BDCA8", VA = "0x10BDCA8")]
	public void SetEnableRecordsPressButtons(bool isEnable)
	{
	}

	[Token(Token = "0x6007A81")]
	[Address(RVA = "0x10BDD08", Offset = "0x10BDD08", VA = "0x10BDD08")]
	public void ShowFinalGameRecords(bool bShow, [Optional] XPlayerManager playerManager, [Optional] Action clickAction)
	{
	}

	[Token(Token = "0x6007A82")]
	[Address(RVA = "0x10BDD6C", Offset = "0x10BDD6C", VA = "0x10BDD6C")]
	public void RefreshGameReadyWindow()
	{
	}

	[Token(Token = "0x6007A83")]
	[Address(RVA = "0x10BDDB8", Offset = "0x10BDDB8", VA = "0x10BDDB8")]
	public void ShowGameReadyWindow(bool bShow, bool isMasterclient = false)
	{
	}

	[Token(Token = "0x6007A84")]
	[Address(RVA = "0x10BDE18", Offset = "0x10BDE18", VA = "0x10BDE18")]
	public void RefreshGamePauseWindow()
	{
	}

	[Token(Token = "0x6007A85")]
	[Address(RVA = "0x10BDE64", Offset = "0x10BDE64", VA = "0x10BDE64")]
	public void RefreshPauseButton()
	{
	}

	[Token(Token = "0x6007A86")]
	[Address(RVA = "0x10BDE78", Offset = "0x10BDE78", VA = "0x10BDE78")]
	public void RefreshMiniMapPlayer()
	{
	}

	[Token(Token = "0x6007A87")]
	[Address(RVA = "0x10BDE8C", Offset = "0x10BDE8C", VA = "0x10BDE8C")]
	public void RefreshMiniMapItem()
	{
	}

	[Token(Token = "0x6007A88")]
	[Address(RVA = "0x10BDEA0", Offset = "0x10BDEA0", VA = "0x10BDEA0")]
	public void RefreshMiniMapFlag()
	{
	}

	[Token(Token = "0x6007A89")]
	[Address(RVA = "0x10BDEB4", Offset = "0x10BDEB4", VA = "0x10BDEB4")]
	public void RefreshCharTagButton()
	{
	}

	[Token(Token = "0x6007A8A")]
	[Address(RVA = "0x10BDEC8", Offset = "0x10BDEC8", VA = "0x10BDEC8")]
	public void ShowMultiKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x6007A8B")]
	[Address(RVA = "0x10BDF08", Offset = "0x10BDF08", VA = "0x10BDF08")]
	public void ShowStreakKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount, bool isEnemy)
	{
	}

	[Token(Token = "0x6007A8C")]
	[Address(RVA = "0x10BDF50", Offset = "0x10BDF50", VA = "0x10BDF50")]
	public void ShowShutDownKill(int charID, int skinID, int profileIconID, int titleID, string userName, bool isEnemy)
	{
	}

	[Token(Token = "0x6007A8D")]
	[Address(RVA = "0x10BDF90", Offset = "0x10BDF90", VA = "0x10BDF90")]
	public void OnMyRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6007A8E")]
	[Address(RVA = "0x10BDFE4", Offset = "0x10BDFE4", VA = "0x10BDFE4")]
	public void OnRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6007A8F")]
	[Address(RVA = "0x10BE038", Offset = "0x10BE038", VA = "0x10BE038")]
	public void ShowWelcomeProfileIcon(int profileIconId, int titleId, float durationTime)
	{
	}

	[Token(Token = "0x6007A90")]
	[Address(RVA = "0x10BE064", Offset = "0x10BE064", VA = "0x10BE064")]
	public void PushSystemMessage(string strText)
	{
	}

	[Token(Token = "0x6007A91")]
	[Address(RVA = "0x10BE0FC", Offset = "0x10BE0FC", VA = "0x10BE0FC")]
	public void PushChatMessage(XChatMsgType chatMsgType, string strName, string strMsg, bool bMyKill)
	{
	}

	[Token(Token = "0x6007A92")]
	[Address(RVA = "0x10BE090", Offset = "0x10BE090", VA = "0x10BE090")]
	private void PushMessage(XChatMsgType msgType, string strName, string strText, bool bMyKill = false)
	{
	}

	[Token(Token = "0x6007A93")]
	[Address(RVA = "0x10BE11C", Offset = "0x10BE11C", VA = "0x10BE11C")]
	public void RefreshGameUI()
	{
	}

	[Token(Token = "0x6007A94")]
	[Address(RVA = "0x10BE168", Offset = "0x10BE168", VA = "0x10BE168")]
	public void RefreshRankRecord()
	{
	}

	[Token(Token = "0x6007A95")]
	[Address(RVA = "0x10BE1B4", Offset = "0x10BE1B4", VA = "0x10BE1B4")]
	public void ShowRevivePopup(bool nShow, Vector3 diePos, Action giveUpCallback)
	{
	}

	[Token(Token = "0x6007A96")]
	[Address(RVA = "0x10BE228", Offset = "0x10BE228", VA = "0x10BE228", Slot = "10")]
	public override void Update()
	{
	}

	[Token(Token = "0x6007A97")]
	[Address(RVA = "0x10BE480", Offset = "0x10BE480", VA = "0x10BE480", Slot = "11")]
	protected override void BackUpdateFunc()
	{
	}

	[Token(Token = "0x6007A98")]
	[Address(RVA = "0x10BE530", Offset = "0x10BE530", VA = "0x10BE530", Slot = "12")]
	protected override bool PreBackStateCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A99")]
	[Address(RVA = "0x10BE8D0", Offset = "0x10BE8D0", VA = "0x10BE8D0", Slot = "13")]
	protected override void BackFunc()
	{
	}

	[Token(Token = "0x6007A9A")]
	[Address(RVA = "0x10BEABC", Offset = "0x10BEABC", VA = "0x10BEABC")]
	private bool ShowPauseMenu()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A9B")]
	[Address(RVA = "0x10BE32C", Offset = "0x10BE32C", VA = "0x10BE32C")]
	private void DieEffect()
	{
	}

	[Token(Token = "0x6007A9C")]
	[Address(RVA = "0x10BD024", Offset = "0x10BD024", VA = "0x10BD024")]
	private void ResetDieEffect()
	{
	}

	[Token(Token = "0x6007A9D")]
	[Address(RVA = "0x10BEC9C", Offset = "0x10BEC9C", VA = "0x10BEC9C")]
	public void TurnOnDieEffect()
	{
	}

	[Token(Token = "0x6007A9E")]
	[Address(RVA = "0x10BECA8", Offset = "0x10BECA8", VA = "0x10BECA8")]
	public void TurnOffDieEffect()
	{
	}

	[Token(Token = "0x6007A9F")]
	[Address(RVA = "0x10BEE28", Offset = "0x10BEE28", VA = "0x10BEE28")]
	public Vector3 GetStickDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6007AA0")]
	[Address(RVA = "0x10BEF1C", Offset = "0x10BEF1C", VA = "0x10BEF1C")]
	public float GetTilt()
	{
		return default(float);
	}

	[Token(Token = "0x6007AA1")]
	[Address(RVA = "0x10BEF34", Offset = "0x10BEF34", VA = "0x10BEF34")]
	public Vector3 GetStickPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6007AA2")]
	[Address(RVA = "0x10BEF64", Offset = "0x10BEF64", VA = "0x10BEF64")]
	public void ShowDamge(string damage, DamageType type, Vector3 worldPos, Vector3 dir, int fontsize)
	{
	}

	[Token(Token = "0x6007AA3")]
	[Address(RVA = "0x10BF010", Offset = "0x10BF010", VA = "0x10BF010")]
	public void ShowScrCaution()
	{
	}

	[Token(Token = "0x6007AA4")]
	[Address(RVA = "0x10BEE14", Offset = "0x10BEE14", VA = "0x10BEE14")]
	public void HideScrCaution()
	{
	}

	[Token(Token = "0x6007AA5")]
	[Address(RVA = "0x10BF024", Offset = "0x10BF024", VA = "0x10BF024")]
	public void SetOption(GameUIOption option)
	{
	}

	[Token(Token = "0x6007AA6")]
	[Address(RVA = "0x10BF078", Offset = "0x10BF078", VA = "0x10BF078")]
	public void ShowCombo(int combo)
	{
	}

	[Token(Token = "0x6007AA7")]
	[Address(RVA = "0x10BF08C", Offset = "0x10BF08C", VA = "0x10BF08C")]
	public void VirtualKeyControlState(bool showkey)
	{
	}

	[Token(Token = "0x6007AA8")]
	[Address(RVA = "0x10BF0E0", Offset = "0x10BF0E0", VA = "0x10BF0E0")]
	public void SetTeamSpectatorMode(bool isEnable)
	{
	}

	[Token(Token = "0x6007AA9")]
	[Address(RVA = "0x10BF134", Offset = "0x10BF134", VA = "0x10BF134")]
	public void EnableSpectatorMode(bool isEnable)
	{
	}

	[Token(Token = "0x6007AAA")]
	[Address(RVA = "0x10BF148", Offset = "0x10BF148", VA = "0x10BF148")]
	public void BuildSkill()
	{
	}

	[Token(Token = "0x6007AAB")]
	[Address(RVA = "0x10BF194", Offset = "0x10BF194", VA = "0x10BF194")]
	public void DirecionOnTag(string iconPath, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6007AAC")]
	[Address(RVA = "0x10BF1A8", Offset = "0x10BF1A8", VA = "0x10BF1A8")]
	public void SetFadeOut(bool bShow)
	{
	}

	[Token(Token = "0x6007AAD")]
	[Address(RVA = "0x10BF1FC", Offset = "0x10BF1FC", VA = "0x10BF1FC")]
	public bool IsShowGameResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6007AAE")]
	[Address(RVA = "0x10BF244", Offset = "0x10BF244", VA = "0x10BF244")]
	public bool IsPlayedCharacterAniSound()
	{
		return default(bool);
	}

	[Token(Token = "0x6007AB0")]
	[Address(RVA = "0x10BF274", Offset = "0x10BF274", VA = "0x10BF274")]
	public void SettingStateOpen(bool isActive)
	{
	}

	[Token(Token = "0x6007AB1")]
	[Address(RVA = "0x10BF2C8", Offset = "0x10BF2C8", VA = "0x10BF2C8")]
	public void ShowIngameCustomMessage(string strMsgKey, float duration)
	{
	}

	[Token(Token = "0x6007AB2")]
	[Address(RVA = "0x10BF328", Offset = "0x10BF328", VA = "0x10BF328")]
	public void ShowRelayMatchGameStartUI(int round)
	{
	}

	[Token(Token = "0x6007AB3")]
	[Address(RVA = "0x10BF37C", Offset = "0x10BF37C", VA = "0x10BF37C")]
	public void OnGameModeStateEnter(XGameModeStateType gameModeStateType)
	{
	}

	[Token(Token = "0x6007AB4")]
	[Address(RVA = "0x10BF3D0", Offset = "0x10BF3D0", VA = "0x10BF3D0")]
	public void ShowMessageTop(Color color, string text = "", float durationtime = 2f, string msgSoundName = "")
	{
	}

	[Token(Token = "0x6007AB5")]
	[Address(RVA = "0x10BF41C", Offset = "0x10BF41C", VA = "0x10BF41C")]
	public void HideMessageTop()
	{
	}

	[Token(Token = "0x6007AB6")]
	[Address(RVA = "0x10BF430", Offset = "0x10BF430", VA = "0x10BF430")]
	public void ShowMessageTitle(TitleType titleType, string text = "", float durationtime = 2f, string msgSoundName = "")
	{
	}

	[Token(Token = "0x6007AB7")]
	[Address(RVA = "0x10BF460", Offset = "0x10BF460", VA = "0x10BF460")]
	public void OnAutoStartCountDownThreeSecondsAgo()
	{
	}
}
