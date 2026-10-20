using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CF8")]
public class XUIGameMode_Cooperation : XUIStageGameMode
{
	[Token(Token = "0x4004215")]
	[FieldOffset(Offset = "0x54")]
	private XPanel_Cooperation m_pnlCooperation;

	[Token(Token = "0x4004216")]
	[FieldOffset(Offset = "0x58")]
	private IRecordUISetter recordSetter;

	[Token(Token = "0x6005E24")]
	[Address(RVA = "0x1A5377C", Offset = "0x1A5377C", VA = "0x1A5377C")]
	public XUIGameMode_Cooperation()
	{
	}

	[Token(Token = "0x6005E25")]
	[Address(RVA = "0x1A53818", Offset = "0x1A53818", VA = "0x1A53818", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005E26")]
	[Address(RVA = "0x1A53838", Offset = "0x1A53838", VA = "0x1A53838", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005E27")]
	[Address(RVA = "0x1A53840", Offset = "0x1A53840", VA = "0x1A53840", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005E28")]
	[Address(RVA = "0x1A538F8", Offset = "0x1A538F8", VA = "0x1A538F8", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005E29")]
	[Address(RVA = "0x1A53A50", Offset = "0x1A53A50", VA = "0x1A53A50", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005E2A")]
	[Address(RVA = "0x1A53B14", Offset = "0x1A53B14", VA = "0x1A53B14", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005E2B")]
	[Address(RVA = "0x1A53B60", Offset = "0x1A53B60", VA = "0x1A53B60", Slot = "14")]
	public override void RefreshRankRecord()
	{
	}

	[Token(Token = "0x6005E2C")]
	[Address(RVA = "0x1A53CDC", Offset = "0x1A53CDC", VA = "0x1A53CDC", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005E2D")]
	[Address(RVA = "0x1A53E40", Offset = "0x1A53E40", VA = "0x1A53E40", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005E2E")]
	[Address(RVA = "0x1A53E60", Offset = "0x1A53E60", VA = "0x1A53E60", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005E2F")]
	[Address(RVA = "0x1A53CFC", Offset = "0x1A53CFC", VA = "0x1A53CFC")]
	public void ShowPanel(bool bShow)
	{
	}
}
