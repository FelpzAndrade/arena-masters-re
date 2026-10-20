using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D02")]
public class XUIGameMode_Solo : XUIStageGameMode
{
	[Token(Token = "0x4004226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XPanel_Solo m_pnlSolo;

	[Token(Token = "0x6005EC2")]
	[Address(RVA = "0x1A57804", Offset = "0x1A57804", VA = "0x1A57804")]
	public XUIGameMode_Solo()
	{
	}

	[Token(Token = "0x6005EC3")]
	[Address(RVA = "0x1A59AF0", Offset = "0x1A59AF0", VA = "0x1A59AF0", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005EC4")]
	[Address(RVA = "0x1A59B10", Offset = "0x1A59B10", VA = "0x1A59B10", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005EC5")]
	[Address(RVA = "0x1A59B18", Offset = "0x1A59B18", VA = "0x1A59B18", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005EC6")]
	[Address(RVA = "0x1A59BD0", Offset = "0x1A59BD0", VA = "0x1A59BD0", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005EC7")]
	[Address(RVA = "0x1A59BF0", Offset = "0x1A59BF0", VA = "0x1A59BF0")]
	public void ShowPanelSolo(bool bShow)
	{
	}

	[Token(Token = "0x6005EC8")]
	[Address(RVA = "0x1A59D34", Offset = "0x1A59D34", VA = "0x1A59D34", Slot = "39")]
	public override void ShowSkyTowerResultWindow(bool bShow, [Optional] Netdata_CompleteSkyTower gameResult)
	{
	}

	[Token(Token = "0x6005EC9")]
	[Address(RVA = "0x1A59E3C", Offset = "0x1A59E3C", VA = "0x1A59E3C")]
	private Netdata_CompleteGame ToNetDataCompleteGame(Netdata_CompleteSkyTower gameResult)
	{
		return null;
	}
}
