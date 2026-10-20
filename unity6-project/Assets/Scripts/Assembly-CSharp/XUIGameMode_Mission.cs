using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XUIEnum;

[Token(Token = "0x2000CFF")]
public class XUIGameMode_Mission : XUIGameMode
{
	[Token(Token = "0x4004222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private XUIGameMode m_subMode;

	[Token(Token = "0x17000D02")]
	public override string StageName
	{
		[Token(Token = "0x6005E89")]
		[Address(RVA = "0x1A57D24", Offset = "0x1A57D24", VA = "0x1A57D24", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005E7A")]
	[Address(RVA = "0x1A574A8", Offset = "0x1A574A8", VA = "0x1A574A8")]
	public XUIGameMode_Mission()
	{
	}

	[Token(Token = "0x6005E7B")]
	[Address(RVA = "0x1A574B8", Offset = "0x1A574B8", VA = "0x1A574B8", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005E7C")]
	public T GetConcreteMode<T>() where T : XUIGameMode
	{
		return null;
	}

	[Token(Token = "0x6005E7D")]
	[Address(RVA = "0x1A57518", Offset = "0x1A57518", VA = "0x1A57518", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005E7E")]
	[Address(RVA = "0x1A57520", Offset = "0x1A57520", VA = "0x1A57520", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005E7F")]
	[Address(RVA = "0x1A57598", Offset = "0x1A57598", VA = "0x1A57598")]
	private XUIGameMode GetMode()
	{
		return null;
	}

	[Token(Token = "0x6005E80")]
	[Address(RVA = "0x1A57814", Offset = "0x1A57814", VA = "0x1A57814", Slot = "12")]
	public override void ShowGameRecords(bool bShow, [Optional] XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005E81")]
	[Address(RVA = "0x1A5787C", Offset = "0x1A5787C", VA = "0x1A5787C", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005E82")]
	[Address(RVA = "0x1A578D4", Offset = "0x1A578D4", VA = "0x1A578D4", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005E83")]
	[Address(RVA = "0x1A57A8C", Offset = "0x1A57A8C", VA = "0x1A57A8C", Slot = "10")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x6005E84")]
	[Address(RVA = "0x1A57AE4", Offset = "0x1A57AE4", VA = "0x1A57AE4", Slot = "13")]
	public override void RefreshGameRecords(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005E85")]
	[Address(RVA = "0x1A57B44", Offset = "0x1A57B44", VA = "0x1A57B44", Slot = "55")]
	public override void RefreshTopUI()
	{
	}

	[Token(Token = "0x6005E86")]
	[Address(RVA = "0x1A57B9C", Offset = "0x1A57B9C", VA = "0x1A57B9C", Slot = "20")]
	public override void ShowFinalGameRecords(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005E87")]
	[Address(RVA = "0x1A57BFC", Offset = "0x1A57BFC", VA = "0x1A57BFC", Slot = "39")]
	public override void ShowSkyTowerResultWindow(bool bShow, [Optional] Netdata_CompleteSkyTower gameResult)
	{
	}

	[Token(Token = "0x6005E88")]
	[Address(RVA = "0x1A57C90", Offset = "0x1A57C90", VA = "0x1A57C90", Slot = "37")]
	public override void ShowSpecialGameResultWindow(bool bShow, [Optional] Netdata_CompleteSpecial gameResult)
	{
	}

	[Token(Token = "0x6005E8A")]
	[Address(RVA = "0x1A57D7C", Offset = "0x1A57D7C", VA = "0x1A57D7C", Slot = "49")]
	public override void ShowGameCommon(bool bShow, [Optional] XModuleActor actor)
	{
	}

	[Token(Token = "0x6005E8B")]
	[Address(RVA = "0x1A57DE4", Offset = "0x1A57DE4", VA = "0x1A57DE4", Slot = "51")]
	public override void RefreshGameUI()
	{
	}

	[Token(Token = "0x6005E8C")]
	[Address(RVA = "0x1A57E44", Offset = "0x1A57E44", VA = "0x1A57E44", Slot = "38")]
	public override void ShowMissionGameResultWindow(bool bShow, int clearBeforeTotalStar, [Optional] Netdata_CompleteMission gameResult, int score = 0, int earnEnergy = 0)
	{
	}

	[Token(Token = "0x6005E8D")]
	[Address(RVA = "0x1A58030", Offset = "0x1A58030", VA = "0x1A58030", Slot = "60")]
	public override void BuildSkill()
	{
	}

	[Token(Token = "0x6005E8E")]
	[Address(RVA = "0x1A58088", Offset = "0x1A58088", VA = "0x1A58088", Slot = "23")]
	public override void HideDuelGameReadyLabel()
	{
	}

	[Token(Token = "0x6005E8F")]
	[Address(RVA = "0x1A580E0", Offset = "0x1A580E0", VA = "0x1A580E0", Slot = "57")]
	public override void HideName()
	{
	}

	[Token(Token = "0x6005E90")]
	[Address(RVA = "0x1A58138", Offset = "0x1A58138", VA = "0x1A58138", Slot = "41")]
	public override void HideResultWindow()
	{
	}

	[Token(Token = "0x6005E91")]
	[Address(RVA = "0x1A58190", Offset = "0x1A58190", VA = "0x1A58190", Slot = "15")]
	public override bool IsGameRecordsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E92")]
	[Address(RVA = "0x1A581E8", Offset = "0x1A581E8", VA = "0x1A581E8", Slot = "16")]
	public override bool IsGameRespawnVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E93")]
	[Address(RVA = "0x1A58240", Offset = "0x1A58240", VA = "0x1A58240", Slot = "42")]
	public override bool IsResultWindowVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E94")]
	[Address(RVA = "0x1A58298", Offset = "0x1A58298", VA = "0x1A58298", Slot = "56")]
	public override void PushMessage(XChatMsgType msgType, string strName, string strText, bool bMyKill = false)
	{
	}

	[Token(Token = "0x6005E95")]
	[Address(RVA = "0x1A58310", Offset = "0x1A58310", VA = "0x1A58310", Slot = "25")]
	public override void RefreshGamePauseWindow()
	{
	}

	[Token(Token = "0x6005E96")]
	[Address(RVA = "0x1A58368", Offset = "0x1A58368", VA = "0x1A58368", Slot = "24")]
	public override void RefreshGameReadyWindow()
	{
	}

	[Token(Token = "0x6005E97")]
	[Address(RVA = "0x1A5836C", Offset = "0x1A5836C", VA = "0x1A5836C", Slot = "48")]
	public override void RenewalGameRecord()
	{
	}

	[Token(Token = "0x6005E98")]
	[Address(RVA = "0x1A583C4", Offset = "0x1A583C4", VA = "0x1A583C4", Slot = "53")]
	public override void ShowDamage(string damage, DamageType type, Vector3 worldPos, Vector3 dir, int fontsize)
	{
	}

	[Token(Token = "0x6005E99")]
	[Address(RVA = "0x1A5847C", Offset = "0x1A5847C", VA = "0x1A5847C", Slot = "22")]
	public override void ShowGameReadyWindow(bool bShow, bool bStartButton = false)
	{
	}

	[Token(Token = "0x6005E9A")]
	[Address(RVA = "0x1A584E4", Offset = "0x1A584E4", VA = "0x1A584E4", Slot = "18")]
	public override void ShowGameRecords(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005E9B")]
	[Address(RVA = "0x1A58544", Offset = "0x1A58544", VA = "0x1A58544", Slot = "31")]
	public override void ShowResultWindow(bool bShow, [Optional] Netdata_CompleteGame gameResult, [Optional] XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6005E9C")]
	[Address(RVA = "0x1A585B4", Offset = "0x1A585B4", VA = "0x1A585B4", Slot = "61")]
	public override void ShowMissionGameFadeOut(bool bShow)
	{
	}

	[Token(Token = "0x6005E9D")]
	[Address(RVA = "0x1A58614", Offset = "0x1A58614", VA = "0x1A58614", Slot = "58")]
	public override void VirtualKeyControlState(bool bShow)
	{
	}

	[Token(Token = "0x6005E9E")]
	[Address(RVA = "0x1A58674", Offset = "0x1A58674", VA = "0x1A58674", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005E9F")]
	[Address(RVA = "0x1A58678", Offset = "0x1A58678", VA = "0x1A58678", Slot = "46")]
	public override void HideNavigation()
	{
	}

	[Token(Token = "0x6005EA0")]
	[Address(RVA = "0x1A586D0", Offset = "0x1A586D0", VA = "0x1A586D0", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005EA1")]
	[Address(RVA = "0x1A58738", Offset = "0x1A58738", VA = "0x1A58738", Slot = "62")]
	public override void ShowBossDesc(bool bShow, [Optional] Action onComplete, [Optional] string top, [Optional] string bot)
	{
	}

	[Token(Token = "0x6005EA2")]
	[Address(RVA = "0x1A587B0", Offset = "0x1A587B0", VA = "0x1A587B0", Slot = "63")]
	public override void ShowBossHP(bool bShow, [Optional] XModuleActor boss)
	{
	}

	[Token(Token = "0x6005EA3")]
	[Address(RVA = "0x1A58818", Offset = "0x1A58818", VA = "0x1A58818", Slot = "64")]
	public override void ShowRevivePopup(bool bShow, Vector3 diePos, Action giveUpCallBack)
	{
	}

	[Token(Token = "0x6005EA4")]
	[Address(RVA = "0x1A58898", Offset = "0x1A58898", VA = "0x1A58898", Slot = "54")]
	public override void SetOption(GameUIOption option)
	{
	}

	[Token(Token = "0x6005EA5")]
	[Address(RVA = "0x1A588F8", Offset = "0x1A588F8", VA = "0x1A588F8", Slot = "65")]
	public override bool IsShowGameResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EA6")]
	[Address(RVA = "0x1A58950", Offset = "0x1A58950", VA = "0x1A58950", Slot = "9")]
	public override void OnDelayShow()
	{
	}
}
