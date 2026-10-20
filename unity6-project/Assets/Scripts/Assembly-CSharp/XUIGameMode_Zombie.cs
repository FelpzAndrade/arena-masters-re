using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000D05")]
public class XUIGameMode_Zombie : XUIGameMode
{
	[Token(Token = "0x4004229")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_Zombie m_pnlZombie;

	[Token(Token = "0x400422A")]
	[FieldOffset(Offset = "0x54")]
	private IRecordUISetter recordSetter;

	[Token(Token = "0x6005EDF")]
	[Address(RVA = "0x1A5ABD0", Offset = "0x1A5ABD0", VA = "0x1A5ABD0")]
	public XUIGameMode_Zombie()
	{
	}

	[Token(Token = "0x6005EE0")]
	[Address(RVA = "0x1A5AC74", Offset = "0x1A5AC74", VA = "0x1A5AC74", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005EE1")]
	[Address(RVA = "0x1A5AC90", Offset = "0x1A5AC90", VA = "0x1A5AC90", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005EE2")]
	[Address(RVA = "0x1A5AC98", Offset = "0x1A5AC98", VA = "0x1A5AC98", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005EE3")]
	[Address(RVA = "0x1A5AD44", Offset = "0x1A5AD44", VA = "0x1A5AD44", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005EE4")]
	[Address(RVA = "0x1A5AD90", Offset = "0x1A5AD90", VA = "0x1A5AD90", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005EE5")]
	[Address(RVA = "0x1A5AEA0", Offset = "0x1A5AEA0", VA = "0x1A5AEA0", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005EE6")]
	[Address(RVA = "0x1A5AF64", Offset = "0x1A5AF64", VA = "0x1A5AF64", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005EE7")]
	[Address(RVA = "0x1A5B0E8", Offset = "0x1A5B0E8", VA = "0x1A5B0E8", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005EE8")]
	[Address(RVA = "0x1A5B1F8", Offset = "0x1A5B1F8", VA = "0x1A5B1F8", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005EE9")]
	[Address(RVA = "0x1A5B108", Offset = "0x1A5B108", VA = "0x1A5B108")]
	public void ShowPanelZombie(bool bShow)
	{
	}

	[Token(Token = "0x6005EEA")]
	[Address(RVA = "0x1A5B21C", Offset = "0x1A5B21C", VA = "0x1A5B21C", Slot = "26")]
	public override void OnMyRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6005EEB")]
	[Address(RVA = "0x1A5B684", Offset = "0x1A5B684", VA = "0x1A5B684", Slot = "27")]
	public override void OnRecordEvent(RecordEvent recordEvent)
	{
	}
}
