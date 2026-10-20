using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D07")]
public class XUIGameMode_ZombieTag : XUIGameMode
{
	[Token(Token = "0x400422B")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_ZombieTag m_pnlZombieTag;

	[Token(Token = "0x6005EF8")]
	[Address(RVA = "0x1A5B8DC", Offset = "0x1A5B8DC", VA = "0x1A5B8DC")]
	public XUIGameMode_ZombieTag()
	{
	}

	[Token(Token = "0x6005EF9")]
	[Address(RVA = "0x1A5B8EC", Offset = "0x1A5B8EC", VA = "0x1A5B8EC", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005EFA")]
	[Address(RVA = "0x1A5B908", Offset = "0x1A5B908", VA = "0x1A5B908", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005EFB")]
	[Address(RVA = "0x1A5B910", Offset = "0x1A5B910", VA = "0x1A5B910", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005EFC")]
	[Address(RVA = "0x1A5B9BC", Offset = "0x1A5B9BC", VA = "0x1A5B9BC", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005EFD")]
	[Address(RVA = "0x1A5BA08", Offset = "0x1A5BA08", VA = "0x1A5BA08", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005EFE")]
	[Address(RVA = "0x1A5BB18", Offset = "0x1A5BB18", VA = "0x1A5BB18", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005EFF")]
	[Address(RVA = "0x1A5BBF8", Offset = "0x1A5BBF8", VA = "0x1A5BBF8", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005F00")]
	[Address(RVA = "0x1A5BD1C", Offset = "0x1A5BD1C", VA = "0x1A5BD1C", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005F01")]
	[Address(RVA = "0x1A5BD40", Offset = "0x1A5BD40", VA = "0x1A5BD40", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005F02")]
	[Address(RVA = "0x1A5BC18", Offset = "0x1A5BC18", VA = "0x1A5BC18")]
	public void ShowPanelZombieTag(bool bShow)
	{
	}
}
