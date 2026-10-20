using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D04")]
public class XUIGameMode_TeamDeath : XUIGameMode
{
	[Token(Token = "0x4004228")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_TeamDeath m_pnlTeamDeath;

	[Token(Token = "0x6005ED4")]
	[Address(RVA = "0x1A535D8", Offset = "0x1A535D8", VA = "0x1A535D8")]
	public XUIGameMode_TeamDeath()
	{
	}

	[Token(Token = "0x6005ED5")]
	[Address(RVA = "0x1A5A6A4", Offset = "0x1A5A6A4", VA = "0x1A5A6A4", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005ED6")]
	[Address(RVA = "0x1A5A6C0", Offset = "0x1A5A6C0", VA = "0x1A5A6C0", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005ED7")]
	[Address(RVA = "0x1A5A6C8", Offset = "0x1A5A6C8", VA = "0x1A5A6C8", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005ED8")]
	[Address(RVA = "0x1A5A774", Offset = "0x1A5A774", VA = "0x1A5A774", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005ED9")]
	[Address(RVA = "0x1A5A884", Offset = "0x1A5A884", VA = "0x1A5A884", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005EDA")]
	[Address(RVA = "0x1A5A8D0", Offset = "0x1A5A8D0", VA = "0x1A5A8D0", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005EDB")]
	[Address(RVA = "0x1A5A9B0", Offset = "0x1A5A9B0", VA = "0x1A5A9B0", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005EDC")]
	[Address(RVA = "0x1A5AAE8", Offset = "0x1A5AAE8", VA = "0x1A5AAE8", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005EDD")]
	[Address(RVA = "0x1A5AB0C", Offset = "0x1A5AB0C", VA = "0x1A5AB0C", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005EDE")]
	[Address(RVA = "0x1A5A9D0", Offset = "0x1A5A9D0", VA = "0x1A5A9D0")]
	private void ShowPanelTeamDeath(bool bShow)
	{
	}
}
