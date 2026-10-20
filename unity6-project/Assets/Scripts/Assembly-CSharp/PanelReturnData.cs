using Il2CppDummyDll;

[Token(Token = "0x2000C25")]
public class PanelReturnData
{
	[Token(Token = "0x4003D72")]
	[FieldOffset(Offset = "0x8")]
	private UIPanel panel;

	[Token(Token = "0x4003D73")]
	[FieldOffset(Offset = "0xC")]
	private int originDepth;

	[Token(Token = "0x60057EE")]
	[Address(RVA = "0x1B7B250", Offset = "0x1B7B250", VA = "0x1B7B250")]
	public PanelReturnData(UIPanel panel)
	{
	}

	[Token(Token = "0x60057EF")]
	[Address(RVA = "0x1B7B294", Offset = "0x1B7B294", VA = "0x1B7B294")]
	public void ReturnPanelDepth()
	{
	}
}
