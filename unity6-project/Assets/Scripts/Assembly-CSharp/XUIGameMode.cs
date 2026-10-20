using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XUIEnum;

[Token(Token = "0x2000CF0")]
public abstract class XUIGameMode
{
	[Token(Token = "0x2000CF1")]
	private sealed class _003CShowPauseMenu_003Ec__AnonStorey197
	{
		[Token(Token = "0x400420D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action<bool> action;

		[Token(Token = "0x400420E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XUIGameMode _003C_003Ef__this;

		[Token(Token = "0x6005DF1")]
		[Address(RVA = "0x1A4B288", Offset = "0x1A4B288", VA = "0x1A4B288")]
		public _003CShowPauseMenu_003Ec__AnonStorey197()
		{
		}

		[Token(Token = "0x6005DF2")]
		[Address(RVA = "0x1A51BB0", Offset = "0x1A51BB0", VA = "0x1A51BB0")]
		internal void _003C_003Em__29C()
		{
		}
	}

	[Token(Token = "0x2000CF2")]
	private sealed class _003CBanPlayer_003Ec__AnonStorey198
	{
		[Token(Token = "0x400420F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XPlayer banPlayer;

		[Token(Token = "0x6005DF3")]
		[Address(RVA = "0x1A51400", Offset = "0x1A51400", VA = "0x1A51400")]
		public _003CBanPlayer_003Ec__AnonStorey198()
		{
		}

		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0x1A51AD4", Offset = "0x1A51AD4", VA = "0x1A51AD4")]
		internal void _003C_003Em__2A0()
		{
		}
	}

	[Token(Token = "0x40041F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected XGameObjectHolder m_goHolder;

	[Token(Token = "0x40041F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected Hashtable m_parameters;

	[Token(Token = "0x40041F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected bool finalShowed;

	[Token(Token = "0x40041FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private bool m_isCanInteractionInput;

	[Token(Token = "0x40041FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected XUIGameExit m_pnlGameExit;

	[Token(Token = "0x40041FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected XPanel_GameReady m_pnlGameReadyWindow;

	[Token(Token = "0x40041FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected XPanel_GameResult m_resultWindow;

	[Token(Token = "0x40041FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected XPanel_GameResultPVP m_resultWindowPVP;

	[Token(Token = "0x40041FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected XPanel_RankPointDirection m_rankPointDirection;

	[Token(Token = "0x4004200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected XUIRespawnWindow m_respawnWindow;

	[Token(Token = "0x4004201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected XPanel_GameRecords m_panel_GameRecords;

	[Token(Token = "0x4004202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected XUIMessageBar m_messageBar;

	[Token(Token = "0x4004203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected XPanel_GameCommon m_pnlGameCommon;

	[Token(Token = "0x4004204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected XWidget_FriendlyTeamSetting m_pnlFriendlyTeamSetting;

	[Token(Token = "0x4004205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected XPanel_VirtualJoystick m_virtualKeyCustom;

	[Token(Token = "0x4004206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected XPanel_FailureFadeOut m_pnlFailureFadeOut;

	[Token(Token = "0x4004207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected XPanel_GameResultExpression m_pnlGameResultExpression;

	[Token(Token = "0x4004208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected XPanel_ResultCharactersDirectionRoot m_pnlResultCharactersDirectionRoot;

	[Token(Token = "0x4004209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected XPanel_IngameMessage m_messageWindow;

	[Token(Token = "0x400420A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<string, XPlayer>, XPlayer> _003C_003Ef__am_0024cache13;

	[Token(Token = "0x400420B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Func<XPlayer, int> _003C_003Ef__am_0024cache14;

	[Token(Token = "0x400420C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Func<XPlayer, int> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x17000CF2")]
	protected XUIGameExit pnlGameExit
	{
		[Token(Token = "0x6005D65")]
		[Address(RVA = "0x1A48B40", Offset = "0x1A48B40", VA = "0x1A48B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CF3")]
	protected XPanel_GameReady pnlGameReadyWindow
	{
		[Token(Token = "0x6005D66")]
		[Address(RVA = "0x1A48C4C", Offset = "0x1A48C4C", VA = "0x1A48C4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CF4")]
	protected XPanel_GameResult resultWindow
	{
		[Token(Token = "0x6005D67")]
		[Address(RVA = "0x1A48D58", Offset = "0x1A48D58", VA = "0x1A48D58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CF5")]
	protected XPanel_GameResultPVP resultWindowPVP
	{
		[Token(Token = "0x6005D68")]
		[Address(RVA = "0x1A48FE8", Offset = "0x1A48FE8", VA = "0x1A48FE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CF6")]
	protected XPanel_RankPointDirection rankPointDirection
	{
		[Token(Token = "0x6005D69")]
		[Address(RVA = "0x1A49278", Offset = "0x1A49278", VA = "0x1A49278")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CF7")]
	protected XUIRespawnWindow respawnWindow
	{
		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0x1A49508", Offset = "0x1A49508", VA = "0x1A49508")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CF8")]
	protected XPanel_GameRecords panel_GameRecords
	{
		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0x1A49614", Offset = "0x1A49614", VA = "0x1A49614")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CF9")]
	protected XUIMessageBar messageBar
	{
		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0x1A498A4", Offset = "0x1A498A4", VA = "0x1A498A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CFA")]
	protected XPanel_GameCommon pnlGameCommon
	{
		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0x1A499B0", Offset = "0x1A499B0", VA = "0x1A499B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CFB")]
	protected XWidget_FriendlyTeamSetting pnlFriendlyTeamSetting
	{
		[Token(Token = "0x6005D6E")]
		[Address(RVA = "0x1A49C3C", Offset = "0x1A49C3C", VA = "0x1A49C3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CFC")]
	protected XPanel_VirtualJoystick virtualKeyCustom
	{
		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0x1A49D78", Offset = "0x1A49D78", VA = "0x1A49D78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CFD")]
	protected XPanel_FailureFadeOut pnlFailureFadeOut
	{
		[Token(Token = "0x6005D70")]
		[Address(RVA = "0x1A49E84", Offset = "0x1A49E84", VA = "0x1A49E84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CFE")]
	protected XPanel_GameResultExpression pnlGameResultExpression
	{
		[Token(Token = "0x6005D71")]
		[Address(RVA = "0x1A49F90", Offset = "0x1A49F90", VA = "0x1A49F90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CFF")]
	protected XPanel_ResultCharactersDirectionRoot pnlResultCharactersDirectionRoot
	{
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0x1A4A0A8", Offset = "0x1A4A0A8", VA = "0x1A4A0A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D00")]
	protected XPanel_IngameMessage messageWindow
	{
		[Token(Token = "0x6005D73")]
		[Address(RVA = "0x1A4A1C0", Offset = "0x1A4A1C0", VA = "0x1A4A1C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D01")]
	public virtual string StageName
	{
		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0x1A4D8BC", Offset = "0x1A4D8BC", VA = "0x1A4D8BC", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D62")]
	[Address(RVA = "0x1A48978", Offset = "0x1A48978", VA = "0x1A48978")]
	protected XUIGameMode()
	{
	}

	[Token(Token = "0x6005D63")]
	[Address(RVA = "0x1A48988", Offset = "0x1A48988", VA = "0x1A48988", Slot = "4")]
	public virtual void Final()
	{
	}

	[Token(Token = "0x6005D64")]
	[Address(RVA = "0x1A48B38", Offset = "0x1A48B38", VA = "0x1A48B38")]
	public void SetCanInteractionInput(bool isCanInput)
	{
	}

	[Token(Token = "0x6005D74")]
	[Address(RVA = "0x1A4A2CC", Offset = "0x1A4A2CC", VA = "0x1A4A2CC", Slot = "5")]
	protected virtual void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005D75")]
	[Address(RVA = "0x1A4A2D0", Offset = "0x1A4A2D0", VA = "0x1A4A2D0")]
	public void Create(XGameObjectHolder goHolder)
	{
	}

	[Token(Token = "0x6005D76")]
	[Address(RVA = "0x1A4A3EC", Offset = "0x1A4A3EC", VA = "0x1A4A3EC", Slot = "6")]
	public virtual void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005D77")]
	[Address(RVA = "0x1A4A73C", Offset = "0x1A4A73C", VA = "0x1A4A73C", Slot = "7")]
	public virtual void OnCreated()
	{
	}

	[Token(Token = "0x6005D78")]
	[Address(RVA = "0x1A4A780", Offset = "0x1A4A780", VA = "0x1A4A780", Slot = "8")]
	public virtual void OnShow()
	{
	}

	[Token(Token = "0x6005D79")]
	[Address(RVA = "0x1A4AE14", Offset = "0x1A4AE14", VA = "0x1A4AE14", Slot = "9")]
	public virtual void OnDelayShow()
	{
	}

	[Token(Token = "0x6005D7A")]
	[Address(RVA = "0x1A4B278", Offset = "0x1A4B278", VA = "0x1A4B278", Slot = "10")]
	public virtual void OnHide()
	{
	}

	[Token(Token = "0x6005D7B")]
	[Address(RVA = "0x1A4B27C", Offset = "0x1A4B27C", VA = "0x1A4B27C")]
	public void SetParam(Hashtable param)
	{
	}

	[Token(Token = "0x6005D7C")]
	public abstract XGameModeType GetModeType();

	[Token(Token = "0x6005D7D")]
	[Address(RVA = "0x1A4A980", Offset = "0x1A4A980", VA = "0x1A4A980")]
	public void ShowPauseMenu(bool bShow, [Optional] Action<bool> action)
	{
	}

	[Token(Token = "0x6005D7E")]
	[Address(RVA = "0x1A4B290", Offset = "0x1A4B290", VA = "0x1A4B290", Slot = "12")]
	public virtual void ShowGameRecords(bool bShow, [Optional] XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005D7F")]
	[Address(RVA = "0x1A4B4AC", Offset = "0x1A4B4AC", VA = "0x1A4B4AC")]
	public Vector3 GetStickDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005D80")]
	[Address(RVA = "0x1A4B4E8", Offset = "0x1A4B4E8", VA = "0x1A4B4E8")]
	public float GetTilt()
	{
		return default(float);
	}

	[Token(Token = "0x6005D81")]
	[Address(RVA = "0x1A4B514", Offset = "0x1A4B514", VA = "0x1A4B514")]
	public float GetStickSize()
	{
		return default(float);
	}

	[Token(Token = "0x6005D82")]
	[Address(RVA = "0x1A4B540", Offset = "0x1A4B540", VA = "0x1A4B540")]
	public Vector3 GetStickPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005D83")]
	[Address(RVA = "0x1A4B57C", Offset = "0x1A4B57C", VA = "0x1A4B57C")]
	public void ShowPauseMenu()
	{
	}

	[Token(Token = "0x6005D84")]
	[Address(RVA = "0x1A4B5A8", Offset = "0x1A4B5A8", VA = "0x1A4B5A8")]
	public GameObject GetHealthBarRoot()
	{
		return null;
	}

	[Token(Token = "0x6005D85")]
	[Address(RVA = "0x1A4B5CC", Offset = "0x1A4B5CC", VA = "0x1A4B5CC")]
	public GameObject GetHeadBalloonRoot()
	{
		return null;
	}

	[Token(Token = "0x6005D86")]
	[Address(RVA = "0x1A4B5F0", Offset = "0x1A4B5F0", VA = "0x1A4B5F0", Slot = "13")]
	public virtual void RefreshGameRecords(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005D87")]
	[Address(RVA = "0x1A4B634", Offset = "0x1A4B634", VA = "0x1A4B634", Slot = "14")]
	public virtual void RefreshRankRecord()
	{
	}

	[Token(Token = "0x6005D88")]
	[Address(RVA = "0x1A4B638", Offset = "0x1A4B638", VA = "0x1A4B638", Slot = "15")]
	public virtual bool IsGameRecordsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D89")]
	[Address(RVA = "0x1A4B674", Offset = "0x1A4B674", VA = "0x1A4B674", Slot = "16")]
	public virtual bool IsGameRespawnVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D8A")]
	[Address(RVA = "0x1A4B76C", Offset = "0x1A4B76C", VA = "0x1A4B76C", Slot = "17")]
	public virtual void ShowGameRecords_MissionPvP(bool isSuccess, XPlayerManager playerManager, Action ShowGameResultAction)
	{
	}

	[Token(Token = "0x6005D8B")]
	[Address(RVA = "0x1A4B82C", Offset = "0x1A4B82C", VA = "0x1A4B82C", Slot = "18")]
	public virtual void ShowGameRecords(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005D8C")]
	[Address(RVA = "0x1A4B8CC", Offset = "0x1A4B8CC", VA = "0x1A4B8CC", Slot = "19")]
	public virtual void SetEnableRecordsPressButtons(bool isEnable)
	{
	}

	[Token(Token = "0x6005D8D")]
	[Address(RVA = "0x1A4B900", Offset = "0x1A4B900", VA = "0x1A4B900", Slot = "20")]
	public virtual void ShowFinalGameRecords(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005D8E")]
	[Address(RVA = "0x1A4B5F8", Offset = "0x1A4B5F8", VA = "0x1A4B5F8")]
	protected void BuildList(XPlayerManager playerManager, bool bFinish = false)
	{
	}

	[Token(Token = "0x6005D8F")]
	[Address(RVA = "0x1A4B9B0", Offset = "0x1A4B9B0", VA = "0x1A4B9B0", Slot = "21")]
	public virtual void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005D90")]
	[Address(RVA = "0x1A4BC10", Offset = "0x1A4BC10", VA = "0x1A4BC10", Slot = "22")]
	public virtual void ShowGameReadyWindow(bool bShow, bool bStartButton = false)
	{
	}

	[Token(Token = "0x6005D91")]
	[Address(RVA = "0x1A4BDB4", Offset = "0x1A4BDB4", VA = "0x1A4BDB4", Slot = "23")]
	public virtual void HideDuelGameReadyLabel()
	{
	}

	[Token(Token = "0x6005D92")]
	[Address(RVA = "0x1A4BE90", Offset = "0x1A4BE90", VA = "0x1A4BE90", Slot = "24")]
	public virtual void RefreshGameReadyWindow()
	{
	}

	[Token(Token = "0x6005D93")]
	[Address(RVA = "0x1A4C2A4", Offset = "0x1A4C2A4", VA = "0x1A4C2A4", Slot = "25")]
	public virtual void RefreshGamePauseWindow()
	{
	}

	[Token(Token = "0x6005D94")]
	[Address(RVA = "0x1A4C538", Offset = "0x1A4C538", VA = "0x1A4C538")]
	public void RefreshPauseButton()
	{
	}

	[Token(Token = "0x6005D95")]
	[Address(RVA = "0x1A4C614", Offset = "0x1A4C614", VA = "0x1A4C614")]
	public void RefreshMiniMapPlayer()
	{
	}

	[Token(Token = "0x6005D96")]
	[Address(RVA = "0x1A4C6F0", Offset = "0x1A4C6F0", VA = "0x1A4C6F0")]
	protected void InitSpectatorTargetMsg()
	{
	}

	[Token(Token = "0x6005D97")]
	[Address(RVA = "0x1A4C7DC", Offset = "0x1A4C7DC", VA = "0x1A4C7DC")]
	protected void SetSpectatorTargetMsg(string nickName)
	{
	}

	[Token(Token = "0x6005D98")]
	[Address(RVA = "0x1A4C92C", Offset = "0x1A4C92C", VA = "0x1A4C92C")]
	public void HideSpectatorTargetMsg()
	{
	}

	[Token(Token = "0x6005D99")]
	[Address(RVA = "0x1A4CA50", Offset = "0x1A4CA50", VA = "0x1A4CA50")]
	public void RefreshMiniMapItem()
	{
	}

	[Token(Token = "0x6005D9A")]
	[Address(RVA = "0x1A4CB2C", Offset = "0x1A4CB2C", VA = "0x1A4CB2C")]
	public void RefreshMiniMapFlag()
	{
	}

	[Token(Token = "0x6005D9B")]
	[Address(RVA = "0x1A4CC08", Offset = "0x1A4CC08", VA = "0x1A4CC08")]
	public void RefreshCharTagButton()
	{
	}

	[Token(Token = "0x6005D9C")]
	[Address(RVA = "0x1A4CCE4", Offset = "0x1A4CCE4", VA = "0x1A4CCE4")]
	public void ShowMultiKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x6005D9D")]
	[Address(RVA = "0x1A4CD48", Offset = "0x1A4CD48", VA = "0x1A4CD48")]
	public void ShowStreakKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount, bool isEnemy)
	{
	}

	[Token(Token = "0x6005D9E")]
	[Address(RVA = "0x1A4CDAC", Offset = "0x1A4CDAC", VA = "0x1A4CDAC")]
	public void ShowShutDownKill(int charID, int skinID, int profileIconID, int titleID, string userName, bool isEnemy)
	{
	}

	[Token(Token = "0x6005D9F")]
	[Address(RVA = "0x1A4CE10", Offset = "0x1A4CE10", VA = "0x1A4CE10")]
	private void ClearKillMessageDirection()
	{
	}

	[Token(Token = "0x6005DA0")]
	[Address(RVA = "0x1A4CE3C", Offset = "0x1A4CE3C", VA = "0x1A4CE3C")]
	public void ShowRankPointDirection(CSTrophyReward beforeTrophyRewardInfo, CSTrophyReward currentTrophyRewardInfo, List<CSWinlose> placementResult, List<int> tierTable, int beforeScore, int currentScore, bool isKickedClan = false)
	{
	}

	[Token(Token = "0x6005DA1")]
	[Address(RVA = "0x1A4CF60", Offset = "0x1A4CF60", VA = "0x1A4CF60")]
	public void ShowClanPointDirection(int beforeClanScore, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005DA2")]
	[Address(RVA = "0x1A4D050", Offset = "0x1A4D050", VA = "0x1A4D050")]
	public void HideClanPointDirection()
	{
	}

	[Token(Token = "0x6005DA3")]
	[Address(RVA = "0x1A4D128", Offset = "0x1A4D128", VA = "0x1A4D128", Slot = "26")]
	public virtual void OnMyRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6005DA4")]
	[Address(RVA = "0x1A4D12C", Offset = "0x1A4D12C", VA = "0x1A4D12C", Slot = "27")]
	public virtual void OnRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6005DA5")]
	[Address(RVA = "0x1A4D210", Offset = "0x1A4D210", VA = "0x1A4D210", Slot = "28")]
	public virtual void ShowGameExit()
	{
	}

	[Token(Token = "0x6005DA6")]
	[Address(RVA = "0x1A4D238", Offset = "0x1A4D238", VA = "0x1A4D238", Slot = "29")]
	public virtual void HideGameExit()
	{
	}

	[Token(Token = "0x6005DA7")]
	[Address(RVA = "0x1A4D260", Offset = "0x1A4D260", VA = "0x1A4D260", Slot = "30")]
	public virtual void SetBeforeResultElo(int elo)
	{
	}

	[Token(Token = "0x6005DA8")]
	[Address(RVA = "0x1A4D34C", Offset = "0x1A4D34C", VA = "0x1A4D34C", Slot = "31")]
	public virtual void ShowResultWindow(bool bShow, [Optional] Netdata_CompleteGame gameResult, [Optional] XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005DA9")]
	[Address(RVA = "0x1A4D4E0", Offset = "0x1A4D4E0", VA = "0x1A4D4E0", Slot = "32")]
	public virtual void ShowGameResultExpression(XGameModeType gameModeType, CSWinlose gameResult, [Optional] Action endAction)
	{
	}

	[Token(Token = "0x6005DAA")]
	[Address(RVA = "0x1A4D628", Offset = "0x1A4D628", VA = "0x1A4D628", Slot = "33")]
	public virtual void HideGameResultExpression()
	{
	}

	[Token(Token = "0x6005DAB")]
	[Address(RVA = "0x1A4D654", Offset = "0x1A4D654", VA = "0x1A4D654", Slot = "34")]
	public virtual void CreatePlayerCharacterObject(XPlayerManager playerManager, List<XModuleEntity> playerMoludeEntityList, Action action)
	{
	}

	[Token(Token = "0x6005DAC")]
	[Address(RVA = "0x1A4D848", Offset = "0x1A4D848", VA = "0x1A4D848", Slot = "35")]
	public virtual void ShowGameResultCharactersDirection(XPlayerManager playerManager, Action action)
	{
	}

	[Token(Token = "0x6005DAD")]
	[Address(RVA = "0x1A4D884", Offset = "0x1A4D884", VA = "0x1A4D884", Slot = "36")]
	public virtual void HideGameResultCharactersDirection()
	{
	}

	[Token(Token = "0x6005DAE")]
	[Address(RVA = "0x1A4D8B0", Offset = "0x1A4D8B0", VA = "0x1A4D8B0", Slot = "37")]
	public virtual void ShowSpecialGameResultWindow(bool bShow, [Optional] Netdata_CompleteSpecial gameResult)
	{
	}

	[Token(Token = "0x6005DAF")]
	[Address(RVA = "0x1A4D8B4", Offset = "0x1A4D8B4", VA = "0x1A4D8B4", Slot = "38")]
	public virtual void ShowMissionGameResultWindow(bool bShow, int clearBeforeTotalStar, [Optional] Netdata_CompleteMission gameResult, int score = 0, int earnEnergy = 0)
	{
	}

	[Token(Token = "0x6005DB0")]
	[Address(RVA = "0x1A4D8B8", Offset = "0x1A4D8B8", VA = "0x1A4D8B8", Slot = "39")]
	public virtual void ShowSkyTowerResultWindow(bool bShow, [Optional] Netdata_CompleteSkyTower gameResult)
	{
	}

	[Token(Token = "0x6005DB2")]
	[Address(RVA = "0x1A4D8C4", Offset = "0x1A4D8C4", VA = "0x1A4D8C4", Slot = "41")]
	public virtual void HideResultWindow()
	{
	}

	[Token(Token = "0x6005DB3")]
	[Address(RVA = "0x1A4D9D0", Offset = "0x1A4D9D0", VA = "0x1A4D9D0", Slot = "42")]
	public virtual bool IsResultWindowVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DB4")]
	[Address(RVA = "0x1A4DB34", Offset = "0x1A4DB34", VA = "0x1A4DB34", Slot = "43")]
	public virtual void ShowFinalGameRecords(bool bShow, [Optional] XPlayerManager playerManager, [Optional] Action clickAction)
	{
	}

	[Token(Token = "0x6005DB5")]
	[Address(RVA = "0x1A4DCDC", Offset = "0x1A4DCDC", VA = "0x1A4DCDC", Slot = "44")]
	public virtual void ShowRespawnWindow(bool bShow)
	{
	}

	[Token(Token = "0x6005DB6")]
	[Address(RVA = "0x1A4E0F4", Offset = "0x1A4E0F4", VA = "0x1A4E0F4", Slot = "45")]
	protected virtual int GetRankForAIMode(XPlayerManager pm)
	{
		return default(int);
	}

	[Token(Token = "0x6005DB7")]
	[Address(RVA = "0x1A4E9E0", Offset = "0x1A4E9E0", VA = "0x1A4E9E0", Slot = "46")]
	public virtual void HideNavigation()
	{
	}

	[Token(Token = "0x6005DB8")]
	[Address(RVA = "0x1A4E9E4", Offset = "0x1A4E9E4", VA = "0x1A4E9E4", Slot = "47")]
	public virtual void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005DB9")]
	[Address(RVA = "0x1A4ED28", Offset = "0x1A4ED28", VA = "0x1A4ED28", Slot = "48")]
	public virtual void RenewalGameRecord()
	{
	}

	[Token(Token = "0x6005DBA")]
	[Address(RVA = "0x1A4EE4C", Offset = "0x1A4EE4C", VA = "0x1A4EE4C")]
	public void SkillButtonEffectEnable(bool b)
	{
	}

	[Token(Token = "0x6005DBB")]
	[Address(RVA = "0x1A4EF30", Offset = "0x1A4EF30", VA = "0x1A4EF30", Slot = "49")]
	public virtual void ShowGameCommon(bool bShow, [Optional] XModuleActor actor)
	{
	}

	[Token(Token = "0x6005DBC")]
	[Address(RVA = "0x1A4F298", Offset = "0x1A4F298", VA = "0x1A4F298", Slot = "50")]
	protected virtual void OnShowGameCommon(bool bShow)
	{
	}

	[Token(Token = "0x6005DBD")]
	[Address(RVA = "0x1A4AF4C", Offset = "0x1A4AF4C", VA = "0x1A4AF4C")]
	public void ShowFriendlySettingUI(bool isActive)
	{
	}

	[Token(Token = "0x6005DBE")]
	[Address(RVA = "0x1A4F29C", Offset = "0x1A4F29C", VA = "0x1A4F29C")]
	public void RecvMasterClientTeamInfo(byte teamInfo)
	{
	}

	[Token(Token = "0x6005DBF")]
	[Address(RVA = "0x1A4F4D0", Offset = "0x1A4F4D0", VA = "0x1A4F4D0")]
	public void RefreshTeamHpBar(List<XPlayer> playerList)
	{
	}

	[Token(Token = "0x6005DC0")]
	[Address(RVA = "0x1A4FD04", Offset = "0x1A4FD04", VA = "0x1A4FD04")]
	public void RefreshFriendlyTeamInfo()
	{
	}

	[Token(Token = "0x6005DC1")]
	[Address(RVA = "0x1A4FDE0", Offset = "0x1A4FDE0", VA = "0x1A4FDE0", Slot = "51")]
	public virtual void RefreshGameUI()
	{
	}

	[Token(Token = "0x6005DC2")]
	[Address(RVA = "0x1A50138", Offset = "0x1A50138", VA = "0x1A50138")]
	public void EnableSpectatorMode(bool b)
	{
	}

	[Token(Token = "0x6005DC3")]
	[Address(RVA = "0x1A5005C", Offset = "0x1A5005C", VA = "0x1A5005C")]
	private void SetTrackingMyTeamPlayer()
	{
	}

	[Token(Token = "0x6005DC4")]
	[Address(RVA = "0x1A504B8", Offset = "0x1A504B8", VA = "0x1A504B8", Slot = "52")]
	public virtual void RefreshGameLifeUI()
	{
	}

	[Token(Token = "0x6005DC5")]
	[Address(RVA = "0x1A504BC", Offset = "0x1A504BC", VA = "0x1A504BC", Slot = "53")]
	public virtual void ShowDamage(string damage, DamageType type, Vector3 worldPos, Vector3 dir, int fontsize)
	{
	}

	[Token(Token = "0x6005DC6")]
	[Address(RVA = "0x1A505F0", Offset = "0x1A505F0", VA = "0x1A505F0")]
	public void ShowScrCaution()
	{
	}

	[Token(Token = "0x6005DC7")]
	[Address(RVA = "0x1A506D4", Offset = "0x1A506D4", VA = "0x1A506D4", Slot = "54")]
	public virtual void SetOption(GameUIOption option)
	{
	}

	[Token(Token = "0x6005DC8")]
	[Address(RVA = "0x1A507C0", Offset = "0x1A507C0", VA = "0x1A507C0")]
	public void HideScrCaution()
	{
	}

	[Token(Token = "0x6005DC9")]
	[Address(RVA = "0x1A508A4", Offset = "0x1A508A4", VA = "0x1A508A4")]
	public void DirectionOnUlt(string iconPath, Action onComplete)
	{
	}

	[Token(Token = "0x6005DCA")]
	[Address(RVA = "0x1A508E0", Offset = "0x1A508E0", VA = "0x1A508E0")]
	public void ShowCombo(int combo)
	{
	}

	[Token(Token = "0x6005DCB")]
	[Address(RVA = "0x1A4ACE4", Offset = "0x1A4ACE4", VA = "0x1A4ACE4")]
	public void InitSkillWindow()
	{
	}

	[Token(Token = "0x6005DCC")]
	[Address(RVA = "0x1A50A58", Offset = "0x1A50A58", VA = "0x1A50A58")]
	internal void ReLinkSkillModule()
	{
	}

	[Token(Token = "0x6005DCD")]
	[Address(RVA = "0x1A50A84", Offset = "0x1A50A84", VA = "0x1A50A84")]
	public void RefreshGameReady()
	{
	}

	[Token(Token = "0x6005DCE")]
	[Address(RVA = "0x1A50B90", Offset = "0x1A50B90", VA = "0x1A50B90", Slot = "55")]
	public virtual void RefreshTopUI()
	{
	}

	[Token(Token = "0x6005DCF")]
	[Address(RVA = "0x1A4B18C", Offset = "0x1A4B18C", VA = "0x1A4B18C")]
	public void RegisterJoyStick()
	{
	}

	[Token(Token = "0x6005DD0")]
	[Address(RVA = "0x1A50B94", Offset = "0x1A50B94", VA = "0x1A50B94", Slot = "56")]
	public virtual void PushMessage(XChatMsgType msgType, string strName, string strText, bool bMyKill = false)
	{
	}

	[Token(Token = "0x6005DD1")]
	[Address(RVA = "0x1A50D0C", Offset = "0x1A50D0C", VA = "0x1A50D0C", Slot = "57")]
	public virtual void HideName()
	{
	}

	[Token(Token = "0x6005DD2")]
	[Address(RVA = "0x1A50D38", Offset = "0x1A50D38", VA = "0x1A50D38", Slot = "58")]
	public virtual void VirtualKeyControlState(bool showkey)
	{
	}

	[Token(Token = "0x6005DD3")]
	[Address(RVA = "0x1A50E24", Offset = "0x1A50E24", VA = "0x1A50E24", Slot = "59")]
	public virtual void SetTeamSpectatorMode(bool isEnable)
	{
	}

	[Token(Token = "0x6005DD4")]
	[Address(RVA = "0x1A50E74", Offset = "0x1A50E74", VA = "0x1A50E74", Slot = "60")]
	public virtual void BuildSkill()
	{
	}

	[Token(Token = "0x6005DD5")]
	[Address(RVA = "0x1A50EA0", Offset = "0x1A50EA0", VA = "0x1A50EA0", Slot = "61")]
	public virtual void ShowMissionGameFadeOut(bool bShow)
	{
	}

	[Token(Token = "0x6005DD6")]
	[Address(RVA = "0x1A50F18", Offset = "0x1A50F18", VA = "0x1A50F18", Slot = "62")]
	public virtual void ShowBossDesc(bool bShow, [Optional] Action onComplete, [Optional] string top, [Optional] string bot)
	{
	}

	[Token(Token = "0x6005DD7")]
	[Address(RVA = "0x1A50F1C", Offset = "0x1A50F1C", VA = "0x1A50F1C", Slot = "63")]
	public virtual void ShowBossHP(bool bShow, [Optional] XModuleActor boss)
	{
	}

	[Token(Token = "0x6005DD8")]
	[Address(RVA = "0x1A50F20", Offset = "0x1A50F20", VA = "0x1A50F20", Slot = "64")]
	public virtual void ShowRevivePopup(bool bShow, Vector3 diePos, Action giveUpCallBack)
	{
	}

	[Token(Token = "0x6005DD9")]
	[Address(RVA = "0x1A50F24", Offset = "0x1A50F24", VA = "0x1A50F24", Slot = "65")]
	public virtual bool IsShowGameResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DDA")]
	[Address(RVA = "0x1A5101C", Offset = "0x1A5101C", VA = "0x1A5101C")]
	public bool IsPlayedCharacterAniSound()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DDB")]
	[Address(RVA = "0x1A4FB14", Offset = "0x1A4FB14", VA = "0x1A4FB14")]
	internal void ChangeVisiblePlayerBanButton(bool _bVisible)
	{
	}

	[Token(Token = "0x6005DDC")]
	[Address(RVA = "0x1A4FC0C", Offset = "0x1A4FC0C", VA = "0x1A4FC0C")]
	internal void ChangeVisiblePlayerSpectatorButton(bool _bVisible)
	{
	}

	[Token(Token = "0x6005DDD")]
	[Address(RVA = "0x1A4AD28", Offset = "0x1A4AD28", VA = "0x1A4AD28")]
	internal void ChangeVisibleFreeSpectatorButton(bool _bVisible)
	{
	}

	[Token(Token = "0x6005DDE")]
	[Address(RVA = "0x1A4F650", Offset = "0x1A4F650", VA = "0x1A4F650")]
	private bool IsPlayerBanButtonVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DDF")]
	[Address(RVA = "0x1A49AE8", Offset = "0x1A49AE8", VA = "0x1A49AE8")]
	private void SetTeamInfoPlayerEvent()
	{
	}

	[Token(Token = "0x6005DE0")]
	[Address(RVA = "0x1A51048", Offset = "0x1A51048", VA = "0x1A51048")]
	private void BanPlayer(XPlayer banPlayer)
	{
	}

	[Token(Token = "0x6005DE1")]
	[Address(RVA = "0x1A50284", Offset = "0x1A50284", VA = "0x1A50284")]
	protected void SpectatorPlayer(XPlayer spectatorPlayer)
	{
	}

	[Token(Token = "0x6005DE2")]
	[Address(RVA = "0x1A51408", Offset = "0x1A51408", VA = "0x1A51408")]
	private bool IsSpectatorTarget(XPlayer spectatorPlayer)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DE3")]
	[Address(RVA = "0x1A51498", Offset = "0x1A51498", VA = "0x1A51498")]
	private XModuleEntity FindME(int id)
	{
		return null;
	}

	[Token(Token = "0x6005DE4")]
	[Address(RVA = "0x1A51574", Offset = "0x1A51574", VA = "0x1A51574")]
	private XModuleEntity FindME(string aid)
	{
		return null;
	}

	[Token(Token = "0x6005DE5")]
	[Address(RVA = "0x1A51648", Offset = "0x1A51648", VA = "0x1A51648")]
	public void ShowWelcomeProfileIcon(int profileIconId, int titleId, float durationTime)
	{
	}

	[Token(Token = "0x6005DE6")]
	[Address(RVA = "0x1A51750", Offset = "0x1A51750", VA = "0x1A51750", Slot = "66")]
	protected virtual int GetCurrentRound()
	{
		return default(int);
	}

	[Token(Token = "0x6005DE7")]
	[Address(RVA = "0x1A51758", Offset = "0x1A51758", VA = "0x1A51758", Slot = "67")]
	public virtual void SettingStateOpen(bool isActive)
	{
	}

	[Token(Token = "0x6005DE8")]
	[Address(RVA = "0x1A5175C", Offset = "0x1A5175C", VA = "0x1A5175C", Slot = "68")]
	public virtual void ShowIngameCustomMessage(string strMsgKey, float duration)
	{
	}

	[Token(Token = "0x6005DE9")]
	[Address(RVA = "0x1A51760", Offset = "0x1A51760", VA = "0x1A51760", Slot = "69")]
	public virtual void ShowRelayMatchGameStartUI(int round)
	{
	}

	[Token(Token = "0x6005DEA")]
	[Address(RVA = "0x1A51764", Offset = "0x1A51764", VA = "0x1A51764", Slot = "70")]
	public virtual void OnGameModeStateEnter(XGameModeStateType gameModeStateType)
	{
	}

	[Token(Token = "0x6005DEB")]
	[Address(RVA = "0x1A51768", Offset = "0x1A51768", VA = "0x1A51768")]
	public void ShowMessageTop(Color color, string text, float durationtime, string msgSoundName)
	{
	}

	[Token(Token = "0x6005DEC")]
	[Address(RVA = "0x1A517D8", Offset = "0x1A517D8", VA = "0x1A517D8")]
	public void HideMessageTop()
	{
	}

	[Token(Token = "0x6005DED")]
	[Address(RVA = "0x1A51808", Offset = "0x1A51808", VA = "0x1A51808")]
	public void ShowMessageTitle(TitleType titleType, string text, float durationtime, string msgSoundName)
	{
	}

	[Token(Token = "0x6005DEE")]
	[Address(RVA = "0x1A51860", Offset = "0x1A51860", VA = "0x1A51860")]
	private static XPlayer _003CGetRankForAIMode_003Em__29D(KeyValuePair<string, XPlayer> item)
	{
		return null;
	}

	[Token(Token = "0x6005DEF")]
	[Address(RVA = "0x1A518EC", Offset = "0x1A518EC", VA = "0x1A518EC")]
	private static int _003CGetRankForAIMode_003Em__29E(XPlayer x)
	{
		return default(int);
	}

	[Token(Token = "0x6005DF0")]
	[Address(RVA = "0x1A519E0", Offset = "0x1A519E0", VA = "0x1A519E0")]
	private static int _003CGetRankForAIMode_003Em__29F(XPlayer x)
	{
		return default(int);
	}
}
