using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D01")]
public class XUIGameMode_Scenario : XUIStageGameMode
{
	[Token(Token = "0x4004224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public XPanel_ScenarioGameMode m_pnlScenario;

	[Token(Token = "0x4004225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public XPanel_GameResult m_pnlScenarioGameResult;

	[Token(Token = "0x17000D03")]
	public override string StageName
	{
		[Token(Token = "0x6005EB9")]
		[Address(RVA = "0x1A59564", Offset = "0x1A59564", VA = "0x1A59564", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005EB2")]
	[Address(RVA = "0x1A5780C", Offset = "0x1A5780C", VA = "0x1A5780C")]
	public XUIGameMode_Scenario()
	{
	}

	[Token(Token = "0x6005EB3")]
	[Address(RVA = "0x1A58F88", Offset = "0x1A58F88", VA = "0x1A58F88", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005EB4")]
	[Address(RVA = "0x1A58FA8", Offset = "0x1A58FA8", VA = "0x1A58FA8", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005EB5")]
	[Address(RVA = "0x1A58FB0", Offset = "0x1A58FB0", VA = "0x1A58FB0", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005EB6")]
	[Address(RVA = "0x1A59068", Offset = "0x1A59068", VA = "0x1A59068", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005EB7")]
	[Address(RVA = "0x1A5906C", Offset = "0x1A5906C", VA = "0x1A5906C", Slot = "54")]
	public override void SetOption(GameUIOption option)
	{
	}

	[Token(Token = "0x6005EB8")]
	[Address(RVA = "0x1A590C0", Offset = "0x1A590C0", VA = "0x1A590C0", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005EBA")]
	[Address(RVA = "0x1A5967C", Offset = "0x1A5967C", VA = "0x1A5967C", Slot = "46")]
	public override void HideNavigation()
	{
	}

	[Token(Token = "0x6005EBB")]
	[Address(RVA = "0x1A596B4", Offset = "0x1A596B4", VA = "0x1A596B4", Slot = "51")]
	public override void RefreshGameUI()
	{
	}

	[Token(Token = "0x6005EBC")]
	[Address(RVA = "0x1A593C8", Offset = "0x1A593C8", VA = "0x1A593C8")]
	public void ShowPanel(bool bShow, float fadeIn = 0f)
	{
	}

	[Token(Token = "0x6005EBD")]
	[Address(RVA = "0x1A59704", Offset = "0x1A59704", VA = "0x1A59704")]
	public void EndTutorial()
	{
	}

	[Token(Token = "0x6005EBE")]
	[Address(RVA = "0x1A597D0", Offset = "0x1A597D0", VA = "0x1A597D0", Slot = "38")]
	public override void ShowMissionGameResultWindow(bool bShow, int clearBeforeTotalStar, [Optional] Netdata_CompleteMission gameResult, int score = 0, int earnEnergy = 0)
	{
	}

	[Token(Token = "0x6005EBF")]
	[Address(RVA = "0x1A59970", Offset = "0x1A59970", VA = "0x1A59970", Slot = "62")]
	public override void ShowBossDesc(bool bShow, [Optional] Action onComplete, [Optional] string top, [Optional] string bot)
	{
	}

	[Token(Token = "0x6005EC0")]
	[Address(RVA = "0x1A599D0", Offset = "0x1A599D0", VA = "0x1A599D0", Slot = "63")]
	public override void ShowBossHP(bool bShow, [Optional] XModuleActor boss)
	{
	}

	[Token(Token = "0x6005EC1")]
	[Address(RVA = "0x1A599FC", Offset = "0x1A599FC", VA = "0x1A599FC", Slot = "65")]
	public override bool IsShowGameResult()
	{
		return default(bool);
	}
}
