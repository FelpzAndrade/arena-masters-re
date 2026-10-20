using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003E0")]
public class XChatMessageObject
{
	[Token(Token = "0x400137B")]
	[FieldOffset(Offset = "0x8")]
	public XChatMsgType MsgType;

	[Token(Token = "0x400137C")]
	[FieldOffset(Offset = "0xC")]
	public string Message;

	[Token(Token = "0x400137D")]
	[FieldOffset(Offset = "0x10")]
	public int ProfileIconId;

	[Token(Token = "0x400137E")]
	[FieldOffset(Offset = "0x14")]
	public int TitleId;

	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0x18")]
	public long SendTimeTick;

	[Token(Token = "0x4001380")]
	[FieldOffset(Offset = "0x20")]
	public string Aid;

	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x1AC46C0", Offset = "0x1AC46C0", VA = "0x1AC46C0")]
	public XChatMessageObject()
	{
	}

	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x1AC46C8", Offset = "0x1AC46C8", VA = "0x1AC46C8")]
	public static XChatMessageObject MakeNormalChatMessage(XChatMsgType msgType, string chatMessage)
	{
		return null;
	}

	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x1AC4868", Offset = "0x1AC4868", VA = "0x1AC4868")]
	public static XChatMessageObject MakeInGameChatMessage(XChatMsgType msgType, string chatMessage, int profileID, int titleID, string aid)
	{
		return null;
	}
}
