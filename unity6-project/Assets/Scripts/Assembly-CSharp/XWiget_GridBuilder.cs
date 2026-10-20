using Il2CppDummyDll;

[Token(Token = "0x2000D53")]
public class XWiget_GridBuilder : XWidget_Builder
{
	[Token(Token = "0x4004487")]
	[FieldOffset(Offset = "0x20")]
	public bool hideInvactive;

	[Token(Token = "0x4004488")]
	[FieldOffset(Offset = "0x24")]
	private UIGrid m_grid;

	[Token(Token = "0x17000D2C")]
	public UIGrid Grid
	{
		[Token(Token = "0x60061D4")]
		[Address(RVA = "0x1B11F4C", Offset = "0x1B11F4C", VA = "0x1B11F4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60061D3")]
	[Address(RVA = "0x1B34994", Offset = "0x1B34994", VA = "0x1B34994")]
	public XWiget_GridBuilder()
	{
	}

	[Token(Token = "0x60061D5")]
	[Address(RVA = "0x1B349A4", Offset = "0x1B349A4", VA = "0x1B349A4", Slot = "4")]
	public override void Reposition()
	{
	}
}
