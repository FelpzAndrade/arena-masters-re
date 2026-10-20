using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CFE")]
public class XUIGameMode_KOF : XUIGameMode
{
	[Token(Token = "0x4004221")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_KOF m_pnlKOF;

	[Token(Token = "0x6005E6A")]
	[Address(RVA = "0x1A56B34", Offset = "0x1A56B34", VA = "0x1A56B34")]
	public XUIGameMode_KOF()
	{
	}

	[Token(Token = "0x6005E6B")]
	[Address(RVA = "0x1A56B44", Offset = "0x1A56B44", VA = "0x1A56B44", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005E6C")]
	[Address(RVA = "0x1A56B60", Offset = "0x1A56B60", VA = "0x1A56B60", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005E6D")]
	[Address(RVA = "0x1A56B68", Offset = "0x1A56B68", VA = "0x1A56B68", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005E6E")]
	[Address(RVA = "0x1A56C14", Offset = "0x1A56C14", VA = "0x1A56C14", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005E6F")]
	[Address(RVA = "0x1A56D24", Offset = "0x1A56D24", VA = "0x1A56D24", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005E70")]
	[Address(RVA = "0x1A56D70", Offset = "0x1A56D70", VA = "0x1A56D70", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005E71")]
	[Address(RVA = "0x1A56E94", Offset = "0x1A56E94", VA = "0x1A56E94", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005E72")]
	[Address(RVA = "0x1A56D90", Offset = "0x1A56D90", VA = "0x1A56D90")]
	private void ShowPanelKOF(bool bShow)
	{
	}

	[Token(Token = "0x6005E73")]
	[Address(RVA = "0x1A56EB8", Offset = "0x1A56EB8", VA = "0x1A56EB8", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005E74")]
	[Address(RVA = "0x1A56F84", Offset = "0x1A56F84", VA = "0x1A56F84", Slot = "55")]
	public override void RefreshTopUI()
	{
	}

	[Token(Token = "0x6005E75")]
	[Address(RVA = "0x1A57190", Offset = "0x1A57190", VA = "0x1A57190", Slot = "52")]
	public override void RefreshGameLifeUI()
	{
	}

	[Token(Token = "0x6005E76")]
	[Address(RVA = "0x1A57330", Offset = "0x1A57330", VA = "0x1A57330", Slot = "66")]
	protected override int GetCurrentRound()
	{
		return default(int);
	}

	[Token(Token = "0x6005E77")]
	[Address(RVA = "0x1A57424", Offset = "0x1A57424", VA = "0x1A57424", Slot = "67")]
	public override void SettingStateOpen(bool isActive)
	{
	}

	[Token(Token = "0x6005E78")]
	[Address(RVA = "0x1A57450", Offset = "0x1A57450", VA = "0x1A57450", Slot = "68")]
	public override void ShowIngameCustomMessage(string strMsgKey, float duration)
	{
	}

	[Token(Token = "0x6005E79")]
	[Address(RVA = "0x1A5747C", Offset = "0x1A5747C", VA = "0x1A5747C", Slot = "69")]
	public override void ShowRelayMatchGameStartUI(int round)
	{
	}
}
