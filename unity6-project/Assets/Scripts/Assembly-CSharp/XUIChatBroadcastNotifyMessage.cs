using System;
using Il2CppDummyDll;

[Token(Token = "0x2000C33")]
public class XUIChatBroadcastNotifyMessage : XUIChatMessageBase
{
	[Token(Token = "0x4003DAB")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_BroadcastMsg msgUI;

	[Token(Token = "0x600583A")]
	[Address(RVA = "0x1A31968", Offset = "0x1A31968", VA = "0x1A31968")]
	public XUIChatBroadcastNotifyMessage()
	{
	}

	[Token(Token = "0x600583B")]
	[Address(RVA = "0x1A31988", Offset = "0x1A31988", VA = "0x1A31988", Slot = "4")]
	public override void Build(ChatMessage msg, Action<EventDelegate> infoAction)
	{
	}
}
