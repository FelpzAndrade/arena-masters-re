using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D00")]
public class XUIGameMode_PoliceVsThief : XUIGameMode
{
	[Token(Token = "0x4004223")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_PoliceVSThief m_pnlPoliceVSThief;

	[Token(Token = "0x6005EA7")]
	[Address(RVA = "0x1A589A8", Offset = "0x1A589A8", VA = "0x1A589A8")]
	public XUIGameMode_PoliceVsThief()
	{
	}

	[Token(Token = "0x6005EA8")]
	[Address(RVA = "0x1A589B8", Offset = "0x1A589B8", VA = "0x1A589B8", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005EA9")]
	[Address(RVA = "0x1A589D4", Offset = "0x1A589D4", VA = "0x1A589D4", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005EAA")]
	[Address(RVA = "0x1A589DC", Offset = "0x1A589DC", VA = "0x1A589DC", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005EAB")]
	[Address(RVA = "0x1A58A88", Offset = "0x1A58A88", VA = "0x1A58A88", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005EAC")]
	[Address(RVA = "0x1A58B98", Offset = "0x1A58B98", VA = "0x1A58B98", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005EAD")]
	[Address(RVA = "0x1A58C84", Offset = "0x1A58C84", VA = "0x1A58C84")]
	public XPanel_PoliceVSThief Panel()
	{
		return null;
	}

	[Token(Token = "0x6005EAE")]
	[Address(RVA = "0x1A58C8C", Offset = "0x1A58C8C", VA = "0x1A58C8C", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005EAF")]
	[Address(RVA = "0x1A58D88", Offset = "0x1A58D88", VA = "0x1A58D88", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005EB0")]
	[Address(RVA = "0x1A58E8C", Offset = "0x1A58E8C", VA = "0x1A58E8C", Slot = "27")]
	public override void OnRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6005EB1")]
	[Address(RVA = "0x1A58F84", Offset = "0x1A58F84", VA = "0x1A58F84", Slot = "51")]
	public override void RefreshGameUI()
	{
	}
}
