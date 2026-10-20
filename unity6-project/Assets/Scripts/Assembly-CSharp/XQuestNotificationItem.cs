using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000C52")]
public class XQuestNotificationItem
{
	[Token(Token = "0x4003E64")]
	[FieldOffset(Offset = "0x8")]
	public CSContent Content;

	[Token(Token = "0x4003E65")]
	[FieldOffset(Offset = "0xC")]
	public string Title;

	[Token(Token = "0x4003E66")]
	[FieldOffset(Offset = "0x10")]
	public string Desc;

	[Token(Token = "0x600591B")]
	[Address(RVA = "0x1C9EE00", Offset = "0x1C9EE00", VA = "0x1C9EE00")]
	public XQuestNotificationItem()
	{
	}

	[Token(Token = "0x600591C")]
	[Address(RVA = "0x1C9EE08", Offset = "0x1C9EE08", VA = "0x1C9EE08")]
	public void Set(CSContent content, string title, string desc)
	{
	}
}
