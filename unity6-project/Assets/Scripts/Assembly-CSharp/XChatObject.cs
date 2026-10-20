using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003DD")]
public class XChatObject
{
	[Token(Token = "0x4001363")]
	[FieldOffset(Offset = "0x8")]
	public string sender;

	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0xC")]
	public XChatMsgType msgType;

	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x10")]
	public string strMsg;

	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x14")]
	public string jsonMsg;

	[Token(Token = "0x6001F80")]
	[Address(RVA = "0x1AC4998", Offset = "0x1AC4998", VA = "0x1AC4998")]
	public XChatObject()
	{
	}

	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x1AC49A0", Offset = "0x1AC49A0", VA = "0x1AC49A0")]
	public XChatObject(string sender, XChatMsgType msgType, string strMsg, XChatMessageObject chatParam)
	{
	}

	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x1AC4A5C", Offset = "0x1AC4A5C", VA = "0x1AC4A5C")]
	public XChatObject(string sender, XChatMsgType msgType, string strMsg, XClanInviteChatMessageObject chatParam)
	{
	}

	[Token(Token = "0x6001F83")]
	[Address(RVA = "0x1AC4B18", Offset = "0x1AC4B18", VA = "0x1AC4B18")]
	public XChatObject(string sender, XChatMsgType msgType, string strMsg, XPrivateChatMessageObject chatParam)
	{
	}

	[Token(Token = "0x6001F84")]
	public T GetJsonObject<T>()
	{
		return (T)default;
	}
}
