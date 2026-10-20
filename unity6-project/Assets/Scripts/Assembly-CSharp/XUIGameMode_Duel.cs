using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CFC")]
public class XUIGameMode_Duel : XUIGameMode
{
	[Token(Token = "0x400421B")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_Duel m_pnlDuel;

	[Token(Token = "0x6005E47")]
	[Address(RVA = "0x1A54CA8", Offset = "0x1A54CA8", VA = "0x1A54CA8")]
	public XUIGameMode_Duel()
	{
	}

	[Token(Token = "0x6005E48")]
	[Address(RVA = "0x1A54CB8", Offset = "0x1A54CB8", VA = "0x1A54CB8", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005E49")]
	[Address(RVA = "0x1A54CD4", Offset = "0x1A54CD4", VA = "0x1A54CD4", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005E4A")]
	[Address(RVA = "0x1A54CDC", Offset = "0x1A54CDC", VA = "0x1A54CDC", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005E4B")]
	[Address(RVA = "0x1A54D88", Offset = "0x1A54D88", VA = "0x1A54D88", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005E4C")]
	[Address(RVA = "0x1A54DD4", Offset = "0x1A54DD4", VA = "0x1A54DD4", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005E4D")]
	[Address(RVA = "0x1A54DD8", Offset = "0x1A54DD8", VA = "0x1A54DD8", Slot = "55")]
	public override void RefreshTopUI()
	{
	}

	[Token(Token = "0x6005E4E")]
	[Address(RVA = "0x1A550C0", Offset = "0x1A550C0", VA = "0x1A550C0", Slot = "44")]
	public override void ShowRespawnWindow(bool bShow)
	{
	}

	[Token(Token = "0x6005E4F")]
	[Address(RVA = "0x1A551E4", Offset = "0x1A551E4", VA = "0x1A551E4", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005E50")]
	[Address(RVA = "0x1A552F4", Offset = "0x1A552F4", VA = "0x1A552F4", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005E51")]
	[Address(RVA = "0x1A553B8", Offset = "0x1A553B8", VA = "0x1A553B8", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005E52")]
	[Address(RVA = "0x1A55770", Offset = "0x1A55770", VA = "0x1A55770", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005E53")]
	[Address(RVA = "0x1A5566C", Offset = "0x1A5566C", VA = "0x1A5566C")]
	public void ShowPanelDuel(bool bShow)
	{
	}
}
