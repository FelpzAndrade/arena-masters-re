using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D03")]
public class XUIGameMode_Special : XUIStageGameMode
{
	[Token(Token = "0x4004227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XPanel_SpecialGameMode m_pnlSpecial;

	[Token(Token = "0x6005ECA")]
	[Address(RVA = "0x1A577FC", Offset = "0x1A577FC", VA = "0x1A577FC")]
	public XUIGameMode_Special()
	{
	}

	[Token(Token = "0x6005ECB")]
	[Address(RVA = "0x1A59F64", Offset = "0x1A59F64", VA = "0x1A59F64", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005ECC")]
	[Address(RVA = "0x1A59F84", Offset = "0x1A59F84", VA = "0x1A59F84", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005ECD")]
	[Address(RVA = "0x1A59F8C", Offset = "0x1A59F8C", VA = "0x1A59F8C", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005ECE")]
	[Address(RVA = "0x1A5A044", Offset = "0x1A5A044", VA = "0x1A5A044", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005ECF")]
	[Address(RVA = "0x1A5A140", Offset = "0x1A5A140", VA = "0x1A5A140", Slot = "51")]
	public override void RefreshGameUI()
	{
	}

	[Token(Token = "0x6005ED0")]
	[Address(RVA = "0x1A5A244", Offset = "0x1A5A244", VA = "0x1A5A244", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005ED1")]
	[Address(RVA = "0x1A5A264", Offset = "0x1A5A264", VA = "0x1A5A264")]
	private void ShowPanel(bool bShow)
	{
	}

	[Token(Token = "0x6005ED2")]
	[Address(RVA = "0x1A5A3A8", Offset = "0x1A5A3A8", VA = "0x1A5A3A8", Slot = "37")]
	public override void ShowSpecialGameResultWindow(bool bShow, [Optional] Netdata_CompleteSpecial gameResult)
	{
	}

	[Token(Token = "0x6005ED3")]
	[Address(RVA = "0x1A5A5AC", Offset = "0x1A5A5AC", VA = "0x1A5A5AC", Slot = "65")]
	public override bool IsShowGameResult()
	{
		return default(bool);
	}
}
