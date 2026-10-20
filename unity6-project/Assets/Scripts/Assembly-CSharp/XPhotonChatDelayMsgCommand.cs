using Il2CppDummyDll;

[Token(Token = "0x20003E6")]
public class XPhotonChatDelayMsgCommand
{
	[Token(Token = "0x4001391")]
	[FieldOffset(Offset = "0x8")]
	public XChatMsgType msgType;

	[Token(Token = "0x4001392")]
	[FieldOffset(Offset = "0xC")]
	public string strMessage;

	[Token(Token = "0x4001393")]
	[FieldOffset(Offset = "0x10")]
	public string strOriginMessage;

	[Token(Token = "0x4001394")]
	[FieldOffset(Offset = "0x14")]
	public object chatParams;

	[Token(Token = "0x4001395")]
	[FieldOffset(Offset = "0x18")]
	public ChannelState channelState;

	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0xAE13BC", Offset = "0xAE13BC", VA = "0xAE13BC")]
	public XPhotonChatDelayMsgCommand(XChatMsgType _msgType, string _strMessage, string _strOriginMessage, object _chatParams, ChannelState _curChannelState)
	{
	}
}
