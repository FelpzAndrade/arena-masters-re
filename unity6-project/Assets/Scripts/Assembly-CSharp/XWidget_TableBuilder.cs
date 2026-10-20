using Il2CppDummyDll;

[Token(Token = "0x2000D4A")]
public class XWidget_TableBuilder : XWidget_Builder
{
	[Token(Token = "0x4004459")]
	[FieldOffset(Offset = "0x20")]
	public bool hideInvactive;

	[Token(Token = "0x400445A")]
	[FieldOffset(Offset = "0x24")]
	private UITable m_table;

	[Token(Token = "0x17000D28")]
	public UITable Table
	{
		[Token(Token = "0x6006199")]
		[Address(RVA = "0x1B132D4", Offset = "0x1B132D4", VA = "0x1B132D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006198")]
	[Address(RVA = "0x1B132C4", Offset = "0x1B132C4", VA = "0x1B132C4")]
	public XWidget_TableBuilder()
	{
	}

	[Token(Token = "0x600619A")]
	[Address(RVA = "0x1B133D4", Offset = "0x1B133D4", VA = "0x1B133D4", Slot = "4")]
	public override void Reposition()
	{
	}
}
